using System;
using System.Collections;

namespace gps.parser
{
    public class MessageHandler
    {
        public ArrayList handlers = new ArrayList();

        public MessageHandler()
        {
            InitDefaults();
        }

        public void InitDefaults()
        {
            Add(new GGA());
            Add(new RMC());
            Add(new GLL());
            Add(new GSA());
            Add(new GSV());
        }

        public void Add(NmeaMsg msg)
        {
            if(msg == null)
            {
                return;
            }
            if (handlers == null)
            {
                handlers = new ArrayList();
            }
            for(int i = 0; i < handlers.Count; ++i)
            {
                NmeaMsg m = (NmeaMsg)handlers[i];
                if(m.id == msg.id)
                {
                    // already there
                    return; 
                }
            }
            handlers.Add(msg);
        }

        public NmeaMsg Parse(string[] nmea)
        {
            if((nmea == null) || (nmea.Length <= 0))
            {
                return null;
            }
            if (handlers == null)
            {
                return null;
            }
            for (int i = 0; i < handlers.Count; ++i)
            {
                NmeaMsg m = (NmeaMsg)handlers[i];
                if(m.CanHandle(nmea))
                {
                    NmeaMsg result = m.CreateEmpty();
                    result.FromNMEA(nmea);
                    return result;
                }
            }
            return null;
        }

    }//EOC

}//EON
