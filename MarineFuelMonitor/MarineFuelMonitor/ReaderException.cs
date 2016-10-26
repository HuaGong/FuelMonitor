/*===========================================================================================
 * 
 *  Copyright (C)   : Advanced Card System Ltd
 * 
 *  File            : ReaderException.cs
 * 
 *  Description     : Contains Methods and Properties for smart card reader related exceptions
 * 
 *  Author          : Arturo Salvamante
 *  
 *  Date            : June 03, 2011
 * 
 *  Revision Traile : [Author] / [Date if modification] / [Details of Modifications done] 
 * 
 * =========================================================================================*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PCSC_Card_Polling
{
    public class ReaderException : Exception
    {
        protected byte[] _readerResponse;
        public byte[] readerResponse
        {
            get { return _readerResponse; }
        }

        protected string _message;
        public override string Message
        {
            get { return _message; }
        }

        public ReaderException(string message, byte[] sw)
        {
            _message = message;
            _readerResponse = sw;
        }
    }
}
