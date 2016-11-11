using System;
using System.Text;

namespace gps.parser
{
    public class Error : NmeaMsg
    {
        public Error()
        {
            this.id = MsgType.Error;
        }

        public Error(string line, Exception ex)
        {
            this.id = MsgType.Error;
            this.line = line;
            this.error = ex;
        }

        public Exception error = null;
        public string line = string.Empty;

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(id.ToString()).Append(" ");
            if (line != null)
            {
                sb.Append(line).Append(" "); ;
            }
            if (error != null)
            {
                sb.Append(error.Message);
            }
            return sb.ToString();
        }

    }//EOC
}
