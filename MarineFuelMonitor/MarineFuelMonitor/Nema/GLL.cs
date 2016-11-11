using System;
using System.Text;

namespace gps.parser
{
    public class GLL : NmeaMsg
    {
        public class FieldIds
        {
            public static readonly int Utc = 0;
            public static readonly int Status = 1;
            public static readonly int X = 2; // longitude
            public static readonly int Y = 3; // latitude
        }//EOC

        public GLL()
        {
            id = NmeaMsg.MsgType.GLL;
            Field f = null;
            
            f = new Field(Field.ValueType.GEODEGREES);
            f.index = new int[] { 1, 2 };
            fields.Add(FieldIds.Y, f);

            f = new Field(Field.ValueType.GEODEGREES);
            f.index = new int[] { 3, 4 };
            fields.Add(FieldIds.X, f);

            f = new Field(Field.ValueType.TIME);
            f.index = new int[] { 5 };
            fields.Add(FieldIds.Utc, f);

            f = new Field(Field.ValueType.ENUM);
            f.index = new int[] { 6 };
            fields.Add(FieldIds.Status, f);
        }

        public override bool CanHandle(string[] nmea)
        {
            return nmea[0].Trim().Equals("$GPGLL");
        }

        public override NmeaMsg CreateEmpty()
        {
            return new GLL();
        }
    }//EOC
}//EON

