using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace MarineFuelMonitor
{
    class Data
    {
        
        public static string conn;
        public static bool ReadyToWriteMysql;
        public static bool ReadyToWriteSubData;
        public static bool MysqlStatus;
        public static int Mode_Selected;
        public static int Mode_Selected_Last;
        public static int OperatorNow;
        public static DateTime StartTime; //工况起始时间
       // public static DateTime StopTime;  //工况停止时间
       // public static DateTime InstantUsedTime;//工况用时
        public static DateTime StartTimeLast; //上次的起始时间


        public static bool PLCComFlag;//PLC通信开始

        public static bool[] InputDI= new bool[2000];
        public static double[] InputAI= new double[500];
        /*
         * InputAI[0]:MENumber
         * InputAI[1]:InstantFuel
         * InputAI[2]:InstantMESpeed
         * InputAI[3]:InstantTemp
         * InputAI[4]:InstantShipSpeed
         * InputAI[5]:InstantN
         * InputAI[6]:InstantE
         * InputAI[7]:TankLevel
         * 
         * InputAI[8]:TankLevel
         * 
         * InputAI[10]：左主机瞬时油耗
         * InputAI[11]：左主机本航次油耗
         * InputAI[12]：左主机油温
         * InputAI[13]：左主机燃油密度
         * InputAI[14]：左主机转速
         * InputAI[15]：左主机累计油耗高位
                  
         * 
         * 
         * InputAI[20]：左主机瞬时油耗
         * InputAI[21]：左主机本航次油耗
         * InputAI[22]：左主机油温
         * InputAI[23]：左主机燃油密度
         * InputAI[24]：左主机转速
         * InputAI[25]：左主机累计油耗高位
         * 
         * 
         * InputDI[0]:PLC通信状态
                                                                                 
         */



    }
}
