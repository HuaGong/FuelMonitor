using System;
using System.IO;
using System.IO.Ports;
using System.Threading;
using System.Text;
using System.Collections;

namespace gps.parser
{
    public class Nmea
    {
        public event NewMessageEventHandler NewMessage;
        public delegate void NewMessageEventHandler(NmeaMsg msg);

        private Stream source = null;
        private enum SpecialChars { CR = 13, LF = 10 }
        private MessageHandler handler = new MessageHandler();

        public MessageHandler Handler
        {
            get { return handler; }
        }

        private void FireNewMessage(NmeaMsg msg)
        {
            if (msg == null) return;
            if (NewMessage != null)
            {
                try
                {
                    NewMessage(msg);
                }
                catch{}
            }
        }

        public Stream Source
        {
            get { return source; }
            set
            {
                Stop();
                count = 0;
                source = value; 
            }
        }

        public bool HasSource
        {
            get { return ((source != null) && source.CanRead); }
        }

        private ManualResetEvent doneEvent = new ManualResetEvent(false);
        private ManualResetEvent shouldStop = new ManualResetEvent(false);
        private Thread workThread = null;

        public void Start()
        {
            Stop();
            workThread = new Thread(new ThreadStart(DoWork));
            workThread.IsBackground = true;
            ShouldStop = false;
            doneEvent.Reset();
            workThread.Start();
        }

        public void Stop()
        {
            if(IsRunning)
            {
                ShouldStop = true;
            }
        }

        public bool IsRunning
        {
            get { return (workThread != null); }
        }

        public void WaitDone()
        {
            if (!IsRunning) return;
            doneEvent.WaitOne();
        }

        protected bool ShouldStop 
        {
            get { return shouldStop.WaitOne(0); }
            set
            {
                if (value)
                {
                    shouldStop.Set();
                }
                else
                {
                    shouldStop.Reset();
                }
            }
        }

        private void DoWork()
        {
            try
            {
                for(string line = ReadLine(); line != null; line = ReadLine())
                {
                    if (ShouldStop)
                    {
                        break;
                    }
                    if (line.Length <= 0)
                    {
                        continue;
                    }
                    ParseLine(line);
                }
            }
            catch(Exception ex)
            {
                Error e = new Error(null, ex);
                FireNewMessage(e);
            }
            finally
            {
                workThread = null;
                doneEvent.Set();
                FireNewMessage(new NmeaMsg(NmeaMsg.MsgType.Done));
            }
        }

        private long count = 0;
        private void ParseLine(string line)
        {
            if ((line == null) || (line.Length <= 0))
            {
                return;
            }
            NmeaMsg outMsg = null;
            try
            {
                int csIndex = line.LastIndexOf('*');
                if(csIndex <= 0)
                {
                    return;
                }
                csIndex++;
                if(csIndex >= line.Length)
                {
                    return;
                }
                string cs = line.Substring(csIndex, line.Length - csIndex);
                string tempLine = line.Substring(0, csIndex - 1);
                string[] parts = tempLine.ToUpper().Split(',');
                if (parts.Length <= 0)
                {
                    return;
                }
                if (!ValidateChecksum(tempLine, cs))
                {
                    return;
                }
                outMsg = handler.Parse(parts);
            }
            catch(Exception ex)
            {
                outMsg = new Error(line, ex);
            }
            FireNewMessage(outMsg);
        }

        private bool ValidateChecksum(string line, string cs)
        {
            int crc = Convert.ToInt32(cs, 16);
            int checksum = 0;
            for (int i = 1; i < line.Length; i++)
            {
                if (ShouldStop)
                {
                    break;
                }
                checksum ^= Convert.ToByte(line[i]);
            }
            //return (checksum == crc);
            return true;
        }

        private string ReadLine()
        {
            count++;
            if (!HasSource) return null;
            StringBuilder line = new StringBuilder();
            int c = -1;
            while(true)
            {
                if(ShouldStop)
                {
                    break;
                }
                c = source.ReadByte();
                if (c < 0)
                {
                    if (line.Length <= 0)
                    {
                        return null;
                    }
                    break;
                }
                if ((c == (int)SpecialChars.LF)
                    || (c == (int)SpecialChars.CR))
                {
                    if (line.Length <= 0)
                    {
                        continue;
                    }
                    break;
                }
                line.Append((char)c);
            }
           // System.Diagnostics.Debug.WriteLine(count.ToString() + ": " + line.ToString());
            return line.ToString();
        }
        
    }//EOC
}//EOC
