using System;
using System.Text;
using System.Collections;

namespace gps.parser
{
    public class NmeaMsg
    {
        public enum MsgType { Error, Done, GGA, RMC, GLL, GSA, GSV }

        public MsgType id = MsgType.Error;
        protected Hashtable fields = new Hashtable();

        public NmeaMsg(){}
        public NmeaMsg(MsgType id) { this.id = id; }

        public Hashtable Fields
        {
            get { return fields; }
        }

        // true if can parse a given nmea
        public virtual bool CanHandle(string[] nmea)
        {
            return false;
        }

        public virtual NmeaMsg CreateEmpty()
        {
            return new NmeaMsg();
        }

        public virtual void FromNMEA(string[] p)
        {
            foreach (int i in fields.Keys)
            {
                Field f = (Field)fields[i];
                if (f == null) continue;
                f.Parse(p);
            }
        }

        // for debug only
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(id.ToString()).Append(" ");
            foreach (int i in fields.Keys)
            {
                Field f = (Field)fields[i];
                if (f == null) continue;
                sb.Append(f.ToString());
                sb.Append(" ~ ");
            }
            return sb.ToString();
        }

    }//EOC

}//EON
