/*===========================================================================================
 * 
 *  Copyright (C)   : Advanced Card System Ltd
 * 
 *  File            : CardPolling.cs
 * 
 *  Description     : Contain methods and properties related to pcsc card polling
 * 
 *  Author          : Arturo Salvamante
 *  
 *  Date            : October 21, 2011
 * 
 *  Revision Traile : [Author] / [Date if modification] / [Details of Modifications done] 
 * 
 * =========================================================================================*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Acs.Pcsc;

namespace PCSC_Card_Polling
{
    public delegate void CardStatusChangeDelegate(object sender, CardPollingEventArg e);
    public delegate void CardPollingErrorDelegate(object sender, CardPollingErrorEventArg e);

    public enum CARD_STATUS
    {
        UNKNOWN = 0,
        CARD_FOUND = 1,
        CARD_NOT_FOUND = 2,
        ERROR = 3
    }

    public class CardPollingEventArg : EventArgs
    {
        public string reader;
        public CARD_STATUS status;
        public byte[] atr;
        internal int currentStatus;
    }

    public class CardPollingErrorEventArg : EventArgs
    {
        public string reader;
        public string errorMessage;
        public int errorCode;
    }

    public class CardPolling
    {
        bool doCardPolling = false;
        object threadpollStatusLock = new object();
        List<string> _readers = new List<string>();
        Dictionary<string, BackgroundWorker> threadPoll = null;
        Dictionary<string, CARD_STATUS> threadPollCardStatus = null;

        public event CardStatusChangeDelegate OnCardFound = delegate { };
        public event CardStatusChangeDelegate OnCardRemoved = delegate { };
        public event CardPollingErrorDelegate OnError = delegate { };

        public bool isBusy()
        {
            if (threadPoll == null)
                return false;

            if (threadPoll.Count < 1)
                return false;

            foreach (string key in threadPoll.Keys)
                if (threadPoll[key].IsBusy) return true;

            return false;
        }

        public bool isBusy(string readerName)
        {
            if (threadPoll == null)
                return false;

            if (threadPoll.Count < 1)
                return false;

            foreach (string key in threadPoll.Keys)
                if (key.Trim() == readerName.Trim())
                    if (threadPoll[key].IsBusy)
                        return true;
                    else
                        return false;


            return false;
        }

        public void fillReader()
        {
            int ReaderCount = 255;
            byte[] retData;
            byte[] sReaderGroup = null;
            string[] readerList;
            string readerStr = string.Empty;
            readerList = null;
            int retCode;
            IntPtr hContext = new IntPtr();

            if (doCardPolling)
                throw new Exception("Card polling already started");

            retCode = PcscProvider.SCardEstablishContext(PcscProvider.SCARD_SCOPE_USER, 0, 0, ref hContext);
            if (retCode != PcscProvider.SCARD_S_SUCCESS)
                throw new Exception("Unable to establish context - " + PcscProvider.GetScardErrMsg(retCode));

            retCode = PcscProvider.SCardListReaders(hContext, null, null, ref ReaderCount);
            if (retCode != PcscProvider.SCARD_S_SUCCESS)
                throw new Exception("List Reader Failed - " + PcscProvider.GetScardErrMsg(retCode));

            retData = new byte[ReaderCount];

            retCode = PcscProvider.SCardListReaders(hContext, sReaderGroup, retData, ref ReaderCount);
            if (retCode != PcscProvider.SCARD_S_SUCCESS)
                throw new Exception("List Reader Failed - " + PcscProvider.GetScardErrMsg(retCode));

            //Convert retData(Hexadecimal) value to String 
            readerStr = System.Text.ASCIIEncoding.ASCII.GetString(retData).Trim('\0');
            readerList = readerStr.Split('\0');

            foreach (string rdr in readerList)
                _readers.Add(rdr);
        }

        public void add(string readerName)
        {
            if (doCardPolling)
            {
                throw new Exception("Card polling already started");
            }

            if (readerName.Trim() == "")
                return;

            if (!_readers.Contains(readerName))
                _readers.Add(readerName);
        }

        public void addRange(string[] readers)
        {
            if (doCardPolling)
            {
                throw new Exception("Card polling already started");
            }

            foreach (string rdr in _readers)
                _readers.Add(rdr);
        }

        public void clear()
        {
            if (doCardPolling)
            {
                throw new Exception("Card polling already started");
            }

            _readers.Clear();
        }

        public void start(String rdr)
        {

            if (doCardPolling)
            {
                throw new Exception("Card polling already started");
            }

            if (_readers.Count < 1)
            {
                throw new Exception("No reader found");
            }

            doCardPolling = true;

            threadPoll = new Dictionary<string, BackgroundWorker>();
            threadPollCardStatus = new Dictionary<string, CARD_STATUS>();
            //foreach (string rdr in _readers)
            //{
            BackgroundWorker bw = new BackgroundWorker();
            bw.WorkerReportsProgress = true;
            bw.WorkerSupportsCancellation = true;
            bw.ProgressChanged += new ProgressChangedEventHandler(bw_ProgressChanged);
            bw.DoWork += new DoWorkEventHandler(bw_DoWork);
            bw.RunWorkerAsync(rdr);
            threadPoll.Add(rdr, bw);
            threadPollCardStatus.Add(rdr, CARD_STATUS.UNKNOWN);
            //}
        }

        void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage >= 0)
            {
                CardPollingEventArg arg = (CardPollingEventArg)e.UserState;
                //lock (threadpollStatusLock)
                threadPollCardStatus[arg.reader] = arg.status;
                switch (arg.status)
                {
                    case CARD_STATUS.CARD_FOUND: CardFound(arg); break;
                    case CARD_STATUS.CARD_NOT_FOUND: CardRemove(arg); break;
                }
            }
            else if (e.ProgressPercentage == -1)
            {
                CardPollingErrorEventArg arg = (CardPollingErrorEventArg)e.UserState;
                //lock (threadpollStatusLock)
                threadPollCardStatus[arg.reader] = CARD_STATUS.ERROR;
                CardError(arg);
            }

        }

        void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                int retCode;
                IntPtr hContext = new IntPtr();
                CardPollingEventArg arg = new CardPollingEventArg();
                arg.reader = e.Argument.ToString();
                arg.status = CARD_STATUS.UNKNOWN;

                retCode = PcscProvider.SCardEstablishContext(PcscProvider.SCARD_SCOPE_USER, 0, 0, ref hContext);
                if (retCode != PcscProvider.SCARD_S_SUCCESS)
                {
                    throw new Exception("Unable to establish context", new Exception(PcscProvider.GetScardErrMsg(retCode)));
                }

                BackgroundWorker bwOwner = (BackgroundWorker)sender;


                while (!bwOwner.CancellationPending)
                {

                    PcscProvider.SCARD_READERSTATE state = new PcscProvider.SCARD_READERSTATE();
                    state.szReader = e.Argument.ToString();

                    retCode = PcscProvider.SCardGetStatusChange(hContext, 3000, ref state, 1);
                    if (retCode != 0)
                    {
                        if (arg.status != CARD_STATUS.ERROR)
                        {
                            arg.status = CARD_STATUS.ERROR;
                            CardPollingErrorEventArg errorArg = new CardPollingErrorEventArg();
                            errorArg.errorCode = retCode;
                            errorArg.errorMessage = PcscProvider.GetScardErrMsg(retCode);
                            errorArg.reader = e.Argument.ToString();
                            bwOwner.ReportProgress(-1, errorArg);
                        }
                    }
                    else
                    {
                        //state.dwCurrentState >>= 32;                        
                        if ((state.dwEventState & PcscProvider.SCARD_STATE_PRESENT) == PcscProvider.SCARD_STATE_PRESENT)
                        {
                            if (arg.status != CARD_STATUS.CARD_FOUND)
                            {
                                arg.status = CARD_STATUS.CARD_FOUND;
                                arg.atr = state.rgbAtr.Take(state.cbAtr).ToArray();
                                bwOwner.ReportProgress(0, arg);
                            }
                        }
                        else
                        {
                            if (arg.status != CARD_STATUS.CARD_NOT_FOUND)
                            {
                                arg.status = CARD_STATUS.CARD_NOT_FOUND;
                                bwOwner.ReportProgress(0, arg);
                            }
                        }
                    }

                    System.Threading.Thread.Sleep(500);
                }

                PcscProvider.SCardReleaseContext(hContext);
            }
            catch (Exception ex)
            {

            }

        }

        public void stop()
        {
            if (threadPoll == null)
                return;

            foreach (string k in threadPoll.Keys)
                threadPoll[k].CancelAsync();

            doCardPolling = false;
        }

        public CARD_STATUS getCardStatus(string readername)
        {
            try
            {
                //lock (threadpollStatusLock)
                //{
                if (!threadPollCardStatus.ContainsKey(readername))
                    throw new Exception("Reader not found");

                return threadPollCardStatus[readername];
                //}
            }
            catch (Exception ex)
            {
                return CARD_STATUS.UNKNOWN;
            }
        }

        void CardFound(CardPollingEventArg e)
        {
            if (OnCardFound == null)
                return;


            OnCardFound(this, e);
        }

        void CardRemove(CardPollingEventArg e)
        {
            if (OnCardFound == null)
                return;

            OnCardRemoved(this, e);
        }

        void CardError(CardPollingErrorEventArg e)
        {
            if (OnError == null)
                return;

            OnError(this, e);
        }


    }
}
