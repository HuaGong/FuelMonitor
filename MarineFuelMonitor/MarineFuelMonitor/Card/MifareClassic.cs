/*===========================================================================================
 * 
 *  Copyright (C)   : Advanced Card System Ltd
 * 
 *  File            : MifareClassic.cs
 * 
 *  Description     : Contain methods and properties related to mifare classic
 * 
 *  Author          : Arturo Salvamante
 *  
 *  Date            : October 19, 2011
 * 
 *  Revision Traile : [Author] / [Date if modification] / [Details of Modifications done] 
 * 
 * =========================================================================================*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Acs;
using Acs.Pcsc;
using Acs.Readers.Pcsc;

namespace MifareCardProg
{


    public class MifareClassic
    {
        public enum VALUEBLOCKOPERATION
        {
            STORE = 0,
            INCREMENT = 1,
            DECREMENT = 2,
        }

        public MifareClassic(string readerName)
        {
            _pcscConnection = new PcscReader(readerName);
        }

        public MifareClassic(PcscReader pcsc)
        {
            _pcscConnection = pcsc;
        }

        private PcscReader _pcscConnection;
        public PcscReader pcscConnection
        {
            get { return _pcscConnection; }
            set { _pcscConnection = value; }
        }
        
        private string getErrorMessage(byte[] sw1sw2)
        {
            if (sw1sw2.Length < 2)
                return "Unknown Status Word (" + Helper.byteAsString(sw1sw2, false) + ")";

            else if (sw1sw2[0] == 0x63 && sw1sw2[1] == 0x00)
                return "Command failed";
            else
                return "Unknown Status Word (" + Helper.byteAsString(sw1sw2, false) + ")";
        }

        public static bool isMifareClassic(byte[] atr)
        {
            if (atr != null && atr.Length > 8 && Helper.byteArrayIsEqual(atr.Skip(4).Take(3).ToArray(), new byte[] { 0x80, 0x4F, 0x0C }))
                return true;
            else
                return false;
        }

        public void valueBlock(byte blockNumber, VALUEBLOCKOPERATION transType, int amount)
        {
            Apdu apdu;
            apdu = new Apdu();
            apdu.setCommand(new byte[] { 0xFF, 0xD7, 0x00, blockNumber, 0x05 });

            apdu.data = new byte[5];
            apdu.data[0] = (byte)transType;
            Array.Copy(Helper.intToByte(amount), 0, apdu.data, 1, 4);

            pcscConnection.sendCommand(ref apdu);

            if (!apdu.statusWordEqualTo(new byte[] { 0x90, 0x00 }))
                throw new CardException("Value block operation failed", apdu.statusWord);
        }

        public void store(byte blockNumber, Int32 amount)
        {
            valueBlock(blockNumber, VALUEBLOCKOPERATION.STORE, amount);
        }

        public void decrement(byte blockNumber, Int32 amount)
        {
            valueBlock(blockNumber, VALUEBLOCKOPERATION.DECREMENT, amount);
        }

        public void increment(byte blockNumber, Int32 amount)
        {
            valueBlock(blockNumber, VALUEBLOCKOPERATION.INCREMENT, amount);
        }

        public Int32 inquireAmount(byte blockNumber)
        {
            Apdu apdu;

            apdu = new Apdu();
            apdu.setCommand(new byte[] { 0xFF, 0xB1, 0x00, blockNumber, 0x04 });
            apdu.data = null;
            apdu.lengthExpected = 4;

            pcscConnection.sendCommand(ref apdu);

            if (apdu.statusWord[0] != 0x90)
                throw new CardException("Read value failed", apdu.statusWord);


            return Helper.byteToInt(apdu.response);
        }

        public void restoreAmount(byte sourceBlock, byte targetBlock)
        {
            Apdu apdu;

            apdu = new Apdu();
            apdu.lengthExpected = 2;

            apdu.setCommand(new byte[] { 0xFF, 0xD7, 0x00, sourceBlock, 0x02 });

            apdu.data = new byte[2];
            apdu.data[0] = 0x03;
            apdu.data[1] = targetBlock;

            pcscConnection.sendCommand(ref apdu);

            if (apdu.statusWord[0] != 0x90)
                throw new CardException("Restore value failed", apdu.statusWord);

        }

        public byte[] readBinary(byte blockNumber, byte length)
        {
            Apdu apdu;
            
            apdu = new Apdu();
            apdu.setCommand(new byte[] { 0xFF, 0xB0, 0x00, blockNumber, length });
            apdu.data = new byte[0];
            apdu.lengthExpected =length;

            pcscConnection.sendCommand(ref apdu);
            if (apdu.statusWord[0] != 0x90)
                throw new CardException("Read failed", apdu.statusWord);

            return apdu.response.Take(length).ToArray();
        }
        
        public void updateBinary(byte blockNumber, byte[] data, byte length)
        {
            Apdu apdu;
            int retCode;

            if (data.Length > 48)
                throw new Exception("Data has invalid length");

            if (length % 16 != 0)
            {
                throw new Exception("Data length must be multiple of 16");
            }

            //if (data.Length != 16)
            //    Array.Resize(ref data, 16);

            apdu = new Apdu();
            apdu.setCommand(new byte[] { 0xFF, 0xD6, 0x00, blockNumber, length });

            apdu.data = new byte[data.Length];
            Array.Copy(data, apdu.data, length);

            pcscConnection.sendCommand(ref apdu);

            if (apdu.statusWord[0] != 0x90)
                throw new CardException("Update failed", apdu.statusWord);
        }

    }
}
