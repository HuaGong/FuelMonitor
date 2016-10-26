/*===========================================================================================
 * 
 *  Copyright (C)   : Advanced Card System Ltd
 * 
 *  File            : Helper.cs
 * 
 *  Description     : Contains helper methods
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
using System.IO;
using System.Security.Cryptography;

namespace Acs
{
    public class Helper
    {
        public static byte[] getBytes(string stringBytes, char delimeter)
        {
            string[] arrayString = stringBytes.Split(delimeter);
            byte[] bytesResult = new byte[arrayString.Length];
            byte tmpByte;
            int counter = 0;

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

        public static byte[] getBytes(string stringBytes)
        {
            string fString = "";
            int counter = 0;

            if (stringBytes.Trim() == "")
                return null;

            for (int i = 0; i < stringBytes.Length; i++)
            {
                if (stringBytes[i] == ' ')
                    continue;

                if (counter > 0)
                    if ((counter % 2) == 0)
                        fString += " ";

                fString += stringBytes[i].ToString();

                counter++;
            }

            return getBytes(fString, ' ');
        }

        public static Int32 byteToInt(byte[] data, bool isLittleEndian)
        {
            byte[] tmpArry = new byte[data.Length];
            Array.Copy(data, tmpArry, tmpArry.Length);

            if (tmpArry.Length != 4)
            {
                if (isLittleEndian)
                    Array.Resize(ref tmpArry, 4);
                else
                {
                    Array.Reverse(tmpArry);
                    Array.Resize(ref tmpArry, 4);
                    Array.Reverse(tmpArry);
                }
            }

            if (isLittleEndian)
                return (tmpArry[3] << 24) + (tmpArry[2] << 16) + (tmpArry[1] << 8) + tmpArry[0];
            else
                return (tmpArry[0] << 24) + (tmpArry[1] << 16) + (tmpArry[2] << 8) + tmpArry[3];
        }

        public static int byteToInt(byte[] data)
        {
            return byteToInt(data, false);
        }

        public static byte[] intToByte(int nummber)
        {
            byte[] tmpByte = new byte[4];

            tmpByte[0] = (byte)((nummber >> 24) & 0xFF);
            tmpByte[1] = (byte)((nummber >> 16) & 0xFF);
            tmpByte[2] = (byte)((nummber >> 8) & 0xFF);
            tmpByte[3] = (byte)(nummber & 0xFF);

            return tmpByte;
        }

        public static byte[] intToByte(UInt32 number)
        {
            byte[] tmpByte = new byte[4];

            tmpByte[0] = (byte)((number >> 24) & 0xFF);
            tmpByte[1] = (byte)((number >> 16) & 0xFF);
            tmpByte[2] = (byte)((number >> 8) & 0xFF);
            tmpByte[3] = (byte)(number & 0xFF);

            return tmpByte;
        }

        public static string byteAsString(byte[] bytes, int startIndex, int length, bool spaceInBetween)
        {
            byte[] newByte;

            if (bytes.Length < startIndex + length)
                Array.Resize(ref bytes, startIndex + length);

            newByte = new byte[length];
            Array.Copy(bytes, startIndex, newByte, 0, length);

            return byteAsString(newByte, spaceInBetween);
        }

        public static string byteAsString(byte[] tmpbytes, bool spaceInBetween)
        {
            string tmpStr = string.Empty;

            if (tmpbytes == null)
                return "";

            for (int i = 0; i < tmpbytes.Length; i++)
            {
                tmpStr += string.Format("{0:X2}", tmpbytes[i]);

                if (spaceInBetween)
                    tmpStr += " ";
            }

            return tmpStr;
        }

        public static bool byteArrayIsEqual(byte[] array1, byte[] array2, int lenght)
        {
            if (array1.Length < lenght)
                return false;

            if (array2.Length < lenght)
                return false;


            for (int i = 0; i < lenght; i++)
            {
                if (array1[i] != array2[i])
                    return false;
            }

            return true;
        }

        public static bool byteArrayIsEqual(byte[] array1, byte[] array2)
        {
            return byteArrayIsEqual(array1, array2, array2.Length);
        }

        public static byte[] appendArrays(byte[] array1, byte[] array2)
        {
            byte[] c = new byte[array1.Length + array2.Length];
            Buffer.BlockCopy(array1, 0, c, 0, array1.Length);
            Buffer.BlockCopy(array2, 0, c, array1.Length, array2.Length);
            return c;
        }

        public static byte[] appendArrays(byte[] array1, byte array2)
        {
            byte[] c = new byte[1 + array1.Length];
            Buffer.BlockCopy(array1, 0, c, 0, array1.Length);
            c[array1.Length] = array2;
            return c;
        }

        public static String byteArrayToString(byte[] data)
        {
            String str = "";

            for (int i = 0; i < data.Length; i++)
            {
                str += (char)data[i];
            }

            return str;
        }

    }
}
