using System;
using System.Text;

namespace gps.parser
{
    public class GSA : NmeaMsg
    {
        public class FieldIds
        {
            public static readonly int SateliteCh01 = 0;
            public static readonly int SateliteCh02 = 1;
            public static readonly int SateliteCh03 = 2;
            public static readonly int SateliteCh04 = 3;
            public static readonly int SateliteCh05 = 4;
            public static readonly int SateliteCh06 = 5;
            public static readonly int SateliteCh07 = 6;
            public static readonly int SateliteCh08 = 7;
            public static readonly int SateliteCh09 = 8;
            public static readonly int SateliteCh10 = 9;
            public static readonly int SateliteCh11 = 10;
            public static readonly int SateliteCh12 = 11;
                        
            public static readonly int Mode1 = 12;
            public static readonly int Mode2 = 13;
            public static readonly int Pdop = 14;
            public static readonly int Hdop = 15;
            public static readonly int Vdop = 16;
 
        }//EOC

        public GSA()
        {
            id = NmeaMsg.MsgType.GSA;
            Field f = null;

            for (int i = 0; i < 12; ++i)
            {
                f = new Field(Field.ValueType.INTEGER);
                f.index = new int[] { 3 + i };
                fields.Add(i, f);
            }

            f = new Field(Field.ValueType.ENUM);
            f.index = new int[] { 1 };
            fields.Add(FieldIds.Mode1, f);

            f = new Field(Field.ValueType.INTEGER);
            f.index = new int[] { 2 };
            fields.Add(FieldIds.Mode2, f);

            f = new Field(Field.ValueType.DOUBLE);
            f.index = new int[] { 15 };
            fields.Add(FieldIds.Pdop, f);

            f = new Field(Field.ValueType.DOUBLE);
            f.index = new int[] { 16 };
            fields.Add(FieldIds.Hdop, f);

            f = new Field(Field.ValueType.DOUBLE);
            f.index = new int[] { 17 };
            fields.Add(FieldIds.Vdop, f);
      
        }

        public override bool CanHandle(string[] nmea)
        {
            return nmea[0].Trim().Equals("$GPGSA");
        }

        public override NmeaMsg CreateEmpty()
        {
            return new GSA();
        }
    }//EOC
}//EON

