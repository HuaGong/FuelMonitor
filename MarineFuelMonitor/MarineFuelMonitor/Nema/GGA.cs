using System;
using System.Text;

namespace gps.parser
{
    public class GGA : NmeaMsg
    {
        public class FieldIds
        {
            public static readonly int Utc = 0;
            public static readonly int X = 1; // longitude
            public static readonly int Y = 2; // latitude
            public static readonly int PositionFixIndicator = 3;
            public static readonly int Satelites = 4;
            public static readonly int Hdop = 5;
            public static readonly int Altitude = 6;
            public static readonly int GeoidHeight = 7;
        }//EOC

        public GGA()
        {
            id = NmeaMsg.MsgType.GGA;
            Field f = null;

            f = new Field(Field.ValueType.TIME);
            f.index = new int[] { 1 };
            fields.Add(FieldIds.Utc, f);

            f = new Field(Field.ValueType.GEODEGREES);
            f.index = new int[] { 4, 5 };
            fields.Add(FieldIds.X, f);

            f = new Field(Field.ValueType.GEODEGREES);
            f.index = new int[] { 2, 3 };
            fields.Add(FieldIds.Y, f);

            f = new Field(Field.ValueType.INTEGER);
            f.index = new int[] { 6 };
            fields.Add(FieldIds.PositionFixIndicator, f);

            f = new Field(Field.ValueType.INTEGER);
            f.index = new int[] { 7 };
            fields.Add(FieldIds.Satelites, f);

            f = new Field(Field.ValueType.DOUBLE);
            f.index = new int[] { 8 };
            fields.Add(FieldIds.Hdop, f);

            f = new Field(Field.ValueType.DOUBLE);
            f.index = new int[] { 9 };
            fields.Add(FieldIds.Altitude, f);

            f = new Field(Field.ValueType.DOUBLE);
            f.index = new int[] { 11 };
            fields.Add(FieldIds.GeoidHeight, f);
        }
        
        public override bool CanHandle(string[] nmea)
        {
            return nmea[0].Trim().Equals("$GPGGA");
        }

        public override NmeaMsg CreateEmpty()
        {
            return new GGA();
        }
        
    }//EOC
}//EON
