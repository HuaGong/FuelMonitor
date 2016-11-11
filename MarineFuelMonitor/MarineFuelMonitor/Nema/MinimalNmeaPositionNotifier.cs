using System;
using System.Collections.Generic;
using System.Text;

namespace gps.parser
{
    public class GpsPosition
    {
        public double x = 0.0; // longitude
        public double y = 0.0; // latitude
        public double speed = -1.0; // km/h
        public double course = -1.0; // degrees
        public DateTime date = DateTime.MinValue;
        public TimeSpan time = TimeSpan.MinValue;

        public int positionFixIndicator = -1;
        public int satelites = 0;
        public int hdop = 0;
             

        public void Init(GpsPosition other)
        {
            if(object.ReferenceEquals(this, other))
            {
                return;
            }
            this.x = other.x;
            this.y = other.y;
            this.speed = other.speed;
            this.course = other.course;
            this.date = other.date;
            this.time = other.time;
            this.positionFixIndicator = other.positionFixIndicator;
            this.satelites = other.satelites;
            this.hdop = other.hdop;
        }

        public DateTime GetDateTime()
        {
            DateTime d = new DateTime(date.Year, date.Month, date.Day, time.Hours, time.Minutes, time.Seconds, time.Milliseconds);
            return d;
        }

        // for debug only
        public override string ToString()
        {
            return "Gps: {X=" + x + " Y=" + y 
                + "} S:" + speed + "km/h C:" + course
                + " H:" + hdop
                + " P:" + positionFixIndicator
                + " ST: " + satelites
                + " D:" + GetDateTime().ToString()
                + string.Empty;
        }
    }//EOC

    public class MinimalNmeaPositionNotifier
    {
        public event NewGspPositionEventHandler NewGspPosition;
        public delegate void NewGspPositionEventHandler(GpsPosition pos);

        public NmeaMsg.MsgType cycleStartMsgType = NmeaMsg.MsgType.GGA;

        ~MinimalNmeaPositionNotifier()
        {
            Uninit();
        }
        
        private Nmea parser = null;
        private GpsPosition position = new GpsPosition();

        private void FireNewPosition()
        {
            if(NewGspPosition != null)
            {
                GpsPosition pos = new GpsPosition();
                pos.Init(this.position);
                NewGspPosition(pos);
            }
        }

        public void Init(Nmea parser)
        {
            if (parser != null)
            {
                parser.NewMessage += new gps.parser.Nmea.NewMessageEventHandler(HandleNewMessage);
            }
        }

        public void Uninit()
        {
            if (parser != null)
            {
                parser.NewMessage -= new gps.parser.Nmea.NewMessageEventHandler(HandleNewMessage);
            }
            parser = null;
        }

        private void HandleNewMessage(NmeaMsg msg)
        {
            Field f = null;
           // bool newPosition = (msg.id == cycleStartMsgType);
            bool newPosition = ((msg.id == NmeaMsg.MsgType.GGA) || (msg.id == NmeaMsg.MsgType.RMC));
            switch(msg.id)
            {
                case NmeaMsg.MsgType.GGA:
                    f = (Field)msg.Fields[GGA.FieldIds.PositionFixIndicator];
                    if ((f != null) && f.HasValue)
                    {
                        position.positionFixIndicator = f.GetInt(position.positionFixIndicator);
                    }
                    f = (Field)msg.Fields[GGA.FieldIds.X];
                    if((f != null) && f.HasValue)
                    {
                        position.x = f.GetDouble(position.x);
                    }
                    f = (Field)msg.Fields[GGA.FieldIds.Y];
                    if ((f != null) && f.HasValue)
                    {
                        position.y = f.GetDouble(position.y);
                    }
                    f = (Field)msg.Fields[GGA.FieldIds.Utc];
                    if ((f != null) && f.HasValue)
                    {
                        position.time = f.GetTime(position.time);
                    }
                    f = (Field)msg.Fields[GGA.FieldIds.Satelites];
                    if ((f != null) && f.HasValue)
                    {
                        position.satelites = f.GetInt(position.satelites);
                    }
                    f = (Field)msg.Fields[GGA.FieldIds.Hdop];
                    if ((f != null) && f.HasValue)
                    {
                        position.hdop = f.GetInt(position.hdop);
                    }
                    break;
                case NmeaMsg.MsgType.RMC:
                    f = (Field)msg.Fields[RMC.FieldIds.Status];
                    if ((f != null) && f.HasValue)
                    {
                        char status = f.GetChar((char)0);
                        if(status == 'A') // read data only if valid
                        {
                            f = (Field)msg.Fields[RMC.FieldIds.X];
                            if ((f != null) && f.HasValue)
                            {
                                position.x = f.GetDouble(position.x);
                            }
                            f = (Field)msg.Fields[RMC.FieldIds.Y];
                            if ((f != null) && f.HasValue)
                            {
                                position.y = f.GetDouble(position.y);
                            }
                            f = (Field)msg.Fields[RMC.FieldIds.Utc];
                            if ((f != null) && f.HasValue)
                            {
                                position.time = f.GetTime(position.time);
                            }
                            f = (Field)msg.Fields[RMC.FieldIds.Date];
                            if ((f != null) && f.HasValue)
                            {
                                position.date = f.GetDate(position.date);
                            }
                            f = (Field)msg.Fields[RMC.FieldIds.Speed];
                            if ((f != null) && f.HasValue)
                            {
                                position.speed = f.GetDouble(position.speed);
                            }
                            f = (Field)msg.Fields[RMC.FieldIds.Course];
                            if ((f != null) && f.HasValue)
                            {
                                position.course = f.GetDouble(position.course);
                            }
                        }
                    }
                    break;
            }
            if(newPosition)
            {
                this.FireNewPosition();
            }
        }

    }//EOC

}//EON
