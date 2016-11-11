using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Acs;
using Acs.Pcsc;
using Acs.Readers.Pcsc;
using PCSC_Card_Polling;
using MifareCardProg;

namespace ICCard
{
    class M1Card
    {
         private CHIP_TYPE currentChipType = CHIP_TYPE.UNKNOWN;
        private Acr1281UC1 acr1281UC1;
        private MifareClassic mifareClassic;
        private byte currentSector, currentSectorTrailer;
        private CardPolling _cardPolling;
        public String Name;
        public int ID;
        public bool ReaderOK;
        string[] readerList;
       

        public void inital()
        {


            Readerinit();
            Name = "无人";
            ID = 0;
            if (_cardPolling == null)
            {
                return;
            }

            if (_cardPolling.isBusy())
            {
                _cardPolling.stop();
            }
            else
            {
                if (readerList != null)
                {
                    _cardPolling.start(readerList[0].ToString());
                }
            }


        }

        public void Readerinit()
        {
            try
            {
                

              

                acr1281UC1 = new Acr1281UC1();

                //Register to event OnReceivedCommand
                acr1281UC1.OnReceivedCommand += new TransmitApduDelegate(acr1281UC1_OnReceivedCommand);

                //Register to event OnSendCommand
                acr1281UC1.OnSendCommand += new TransmitApduDelegate(acr1281UC1_OnSendCommand);

                //Get all smart card reader connected to computer
                readerList = acr1281UC1.getReaderList();

                if (readerList != null)
                {
                    ReaderOK = true;
                }
                else
                {
                    ReaderOK = false;
                }

               
            }
            catch (PcscException pcscException)
            {
               
               // MessageBox.Show(pcscException.Message, "PCSC Exception");
            }
            catch (Exception generalException)
            {
                
               // MessageBox.Show(generalException.Message, "Exception");
            }

            try
            {
                _cardPolling = new CardPolling();

                //Register to event on card found
                _cardPolling.OnCardFound += new CardStatusChangeDelegate(cardPolling_OnCardFound);

                //Register to event on card remove
                _cardPolling.OnCardRemoved += new CardStatusChangeDelegate(cardPolling_OnCardRemoved);

                //Register to event on error
                _cardPolling.OnError += new CardPollingErrorDelegate(cardPolling_OnError);

                //Get all smart card reader connected to computer



                for (int i = 0; i < readerList.Length; i++)
                {
                    _cardPolling.add(readerList[i].ToString());
                }


            }


            catch (PcscException pcscException)
            {
               // MessageBox.Show("PCSC Exception: " + pcscException.Message);
                //MessageBox.Show(pcscException.Message, Resources.Exception);
            }
            catch (Exception generalException)
            {
               // MessageBox.Show(generalException.Message);
                //MessageBox.Show(generalException.Message, Resources.Exception);
            }
        }

        public void ConnectToCard()
        {
            try
            {

                acr1281UC1.connect(readerList[0].ToString());
               

                //Initialize Mifare classic class
                mifareClassic = new MifareClassic(acr1281UC1.pcscConnection);

                currentChipType = acr1281UC1.getChipType();


                if (currentChipType != CHIP_TYPE.MIFARE_1K && currentChipType != CHIP_TYPE.MIFARE_4K)
                {
                   // MessageBox.Show("Card is not supported.\r\nPlease present Mifare Classic card");
                    return;
                }

              
            }
            catch (PcscException pcscException)
            {
               
                //MessageBox.Show(pcscException.Message, "PCSC Exception");
            }
            catch (Exception generalException)
            {
              
               // MessageBox.Show(generalException.Message, "Exception");
            }
        }




        public void LoadKey()
        {
            byte[] key = new byte[6];
            byte keyNumber = 0x20;
            KEY_STRUCTURE keyStructure = KEY_STRUCTURE.VOLATILE;
            try
            {

                if (!byte.TryParse("00", out keyNumber) || keyNumber > 01)
                {
                   // MessageBox.Show("Please key-in key store number from 00 to 01");
                    return;
                }


                //Key should be 6 bytes long
                key = getBytes("FFFFFF", ' ');
                if (key == null || key.Length != 6)
                {
                    //MessageBox.Show("Please key-in 6 bytes key");
                    return;
                }

                acr1281UC1.loadAuthKey(keyStructure, keyNumber, key);
                
            }
            catch (PcscException pcscException)
            {
                
                //MessageBox.Show(pcscException.Message, "PCSC Exception");
            }
            catch (Exception ex)
            {
               
            }
        }




        public void bAuthed()
        {
            byte[] key = new byte[6];
            byte blockNumber = 0x00;
            KEYTYPES keyType = KEYTYPES.ACR122_KEYTYPE_A;


            byte keyNumber = 0x20;

            try
            {
                if (!byte.TryParse("01", out blockNumber))
                {
                   // MessageBox.Show("Please key-in valid block number", "Invalid Input");
                    
                    return;
                }

                if (!byte.TryParse("00", out keyNumber) ||
                    keyNumber > 31)
                {
                   // MessageBox.Show("Please key-in key store number from 00 to 31", "Invalid Input");
                   
                    return;
                }

                blockNumber = (byte)int.Parse("01");
                acr1281UC1.authenticate(blockNumber, keyType, keyNumber);
               // MessageBox.Show("Authenticate Success!");

                //GroupBoxChangeKey.Enabled = true;
            }
            catch (PcscException pcscException)
            {
                
                //MessageBox.Show(pcscException.Message, "PCSC Exception");
            }
            catch (Exception ex)
            {
                
            }
        }





        byte[] getBytes(string stringBytes, char delimeter)
        {
            int counter = 0;
            byte tmpByte;
            string[] arrayString = stringBytes.Split(delimeter);
            byte[] bytesResult = new byte[arrayString.Length];

            foreach (string str in arrayString)
            {
                if (byte.TryParse(str, System.Globalization.NumberStyles.HexNumber, null, out tmpByte))
                {
                    bytesResult[counter] = tmpByte;
                    counter++;
                }
                else
                {
                    return null;
                }
            }

            return bytesResult;
        }

        string byteArrayToString(byte[] b, int startIndx, int len, bool spaceinbetween)
        {
            byte[] newByte;

            if (b.Length < startIndx + len)
                Array.Resize(ref b, startIndx + len);

            newByte = new byte[len];
            Array.Copy(b, startIndx, newByte, 0, len);

            return byteArrayToString(newByte, spaceinbetween);
        }

        string byteArrayToString(byte[] tmpbytes, bool spaceinbetween)
        {
            string tmpStr = string.Empty;

            if (tmpbytes == null)
                return "";

            for (int i = 0; i < tmpbytes.Length; i++)
            {
                tmpStr += string.Format("{0:X2}", tmpbytes[i]);

                if (spaceinbetween)
                    tmpStr += " ";
            }

            return tmpStr;
        }

        void cardPolling_OnCardRemoved(object sender, CardPollingEventArg e)
        {
           // textBoxValueAmount.Text = "";
            //MessageBox.Show("Card is removed");
            Name = "无人";
            ID = 0;
        }

        void cardPolling_OnCardFound(object sender, CardPollingEventArg e)
        {
           // MessageBox.Show("Card found");
            ConnectToCard();
            LoadKey();
            bAuthed();
            ReadData();
        }

        void cardPolling_OnError(object sender, CardPollingErrorEventArg e)
        {
            //MessageBox.Show(e.errorMessage);

        }


        void acr1281UC1_OnSendCommand(object sender, TransmitApduEventArg e)
        {
            
        }

        void acr1281UC1_OnReceivedCommand(object sender, TransmitApduEventArg e)
        {
            
        }

        public void btn_Write_Click(object sender, EventArgs e)
        {
            try
            {


                String tmpStr = "";

                byte[] buff = new byte[16];
                //tmpStr = textBoxData.Text;
                //buff = Encoding.ASCII.GetBytes(tmpStr);
                buff = System.Text.Encoding.Default.GetBytes(tmpStr);
               // AscW()
                if (buff.Length < 16)
                    Array.Resize(ref buff, 16);

                mifareClassic.updateBinary((byte)int.Parse("02"), buff, (byte)int.Parse("16"));
                //textBoxData.Text = "";

            }
            catch (PcscException pcscException)
            {
                
                //MessageBox.Show(pcscException.Message, "PCSC Exception");
            }
            catch (Exception ex)
            {
                
            }
        }

        private void ReadData()
        {
            byte[] tempStr;

            try
            {
                //Validate Inputs
                //textBoxData.Text = "";

              

                int length = Convert.ToInt32("16");
                tempStr = mifareClassic.readBinary((byte)int.Parse("02"), (byte)int.Parse("16"));
                Name = System.Text.Encoding.Default.GetString(tempStr);
                //label1.Text = System.Text.Encoding.Default.GetString(tempStr);
                tempStr = mifareClassic.readBinary((byte)int.Parse("01"), (byte)int.Parse("16"));
                ID = Int32.Parse(Helper.byteArrayToString(tempStr));
                //label2.Text = System.Text.Encoding.Default.GetString(tempStr);
                //label1.Text = Helper.byteArrayToString(tempStr);
               

            }
            catch (PcscException pcscException)
            {
               
               // MessageBox.Show(pcscException.Message, "PCSC Exception");
            }
            catch (Exception ex)
            {
               
            }
        }

        
    }
}
