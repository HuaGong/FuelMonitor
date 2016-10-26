/*===========================================================================================
 * 
 *  Copyright (C)   : Advanced Card System Ltd
 * 
 *  File            : PcscException.cs
 * 
 *  Description     : Contain methods and properties related pcsc exceptions
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

namespace Acs.Pcsc
{
    public class PcscException : System.Exception
    {
        private int _errorCode;
        public int errorCode
        {
            get { return _errorCode; }
        }

        private string _message;
        public override string Message
        {
            get { return _message; }
        }

        public PcscException(int errCode)
        { 
            _errorCode = errCode;
            _message = PcscProvider.GetScardErrMsg(errCode);            
        }

        public PcscException(string message)
        {
            _message = message;
        }
    }
}
