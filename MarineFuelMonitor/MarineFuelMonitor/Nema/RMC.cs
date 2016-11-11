using System;
using System.Text;

namespace gps.parser
{
    public class RMC : NmeaMsg
    {
        public class FieldIds
        {
            public static readonly int Utc = 0;
            public static readonly int Status = 1;
            public static readonly int X = 2; // longitude
            public static readonly int Y = 3; // latitude
            public static readonly int Speed = 4;
            public static readonly int Course = 5;
            public static readonly int Date = 6;
        }//EOC

        public RMC()
        {
            id = NmeaMsg.MsgType.RMC;
            Field f = null;

            f = new Field(Field.ValueType.TIME);
            f.index = new int[] { 1 };
            fields.Add(FieldIds.Utc, f);

            f = new Field(Field.ValueType.ENUM);
            f.index = new int[] { 2 };
            fields.Add(FieldIds.Status, f);

            f = new Field(Field.ValueType.GEODEGREES);
            f.index = new int[] { 3, 4 };
            fields.Add(FieldIds.Y, f);

            f = new Field(Field.ValueType.GEODEGREES);
            f.index = new int[] { 5, 6 };
            fields.Add(FieldIds.X, f);

            f = new Field(Field.ValueType.SPEED);
            f.index = new int[] { 7 };
            fields.Add(FieldIds.Speed, f);

            f = new Field(Field.ValueType.DEGREES);
            f.index = new int[] { 8 };
            fields.Add(FieldIds.Course, f);

            f = new Field(Field.ValueType.DATE);
            f.index = new int[] { 9 };
            fields.Add(FieldIds.Date, f);
        }
        
        public override bool CanHandle(string[] nmea)
        {
            return nmea[0].Trim().Equals("$GPRMC");
        }

        public override NmeaMsg CreateEmpty()
        {
            return new RMC();
        }
    }//EOC
}//EON
