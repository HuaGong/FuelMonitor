/*===========================================================================================
 * 
 *  Copyright (C)   : Advanced Card System Ltd
 * 
 *  File            : CardException.cs
 * 
 *  Description     : Contains Methods and Properties for smart card related exceptions
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

namespace MifareCardProg
{
    public class CardException : Exception
    {
        protected byte[] _statusWord;
        public byte[] statusWord
        {
            get { return _statusWord; }
        }

        protected string _message;
        public override string Message
        {
            get { return _message; }
        }

        public CardException(string message, byte[] sw)
        {
            _message = message;
            _statusWord = sw;
        }
    }
}
