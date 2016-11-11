using System;
using System.Text;

namespace gps.parser
{
    public class GSV : NmeaMsg
    {
        public class FieldIds
        {
            public static readonly int Sat01Id = 0;
            public static readonly int Sat01Elevation = 1;
            public static readonly int Sat01Azimuth = 2;
            public static readonly int Sat01SNR = 3;

            public static readonly int Sat02Id = 4;
            public static readonly int Sat02Elevation = 5;
            public static readonly int Sat02Azimuth = 6;
            public static readonly int Sat02SNR = 7;

            public static readonly int Sat03Id = 8;
            public static readonly int Sat03Elevation = 9;
            public static readonly int Sat03Azimuth = 10;
            public static readonly int Sat03SNR = 11;

            public static readonly int Sat04Id = 12;
            public static readonly int Sat04Elevation = 13;
            public static readonly int Sat04Azimuth = 14;
            public static readonly int Sat04SNR = 15;

            public static readonly int NumberOfMessages = 16;
            public static readonly int MessageNumber = 17;
            public static readonly int VisibleSatelites = 18;
        }//EOC

        public GSV()
        {
            id = NmeaMsg.MsgType.GSV;
            Field f = null;

            for (int i = 0; i < 4; ++i)
            {
                int t = 4 * i;

                f = new Field(Field.ValueType.INTEGER);
                f.index = new int[] { t + 4 };
                fields.Add(t + FieldIds.Sat01Id, f);

                f = new Field(Field.ValueType.DOUBLE);
                f.index = new int[] { t + 5 };
                fields.Add(t + FieldIds.Sat01Elevation, f);

                f = new Field(Field.ValueType.DOUBLE);
                f.index = new int[] { t + 6 };
                fields.Add(t + FieldIds.Sat01Azimuth, f);

                f = new Field(Field.ValueType.INTEGER);
                f.index = new int[] {t + 7 };
                fields.Add(t + FieldIds.Sat01SNR, f);
            }

            f = new Field(Field.ValueType.INTEGER);
            f.index = new int[] { 1 };
            fields.Add(FieldIds.NumberOfMessages, f);

            f = new Field(Field.ValueType.INTEGER);
            f.index = new int[] { 2 };
            fields.Add(FieldIds.MessageNumber, f);

            f = new Field(Field.ValueType.INTEGER);
            f.index = new int[] { 3 };
            fields.Add(FieldIds.VisibleSatelites, f);
        }

        public override bool CanHandle(string[] nmea)
        {
            return nmea[0].Trim().Equals("$GPGSV");
        }

        public override NmeaMsg CreateEmpty()
        {
            return new GSV();
        }
    }//EOC
}//EON

