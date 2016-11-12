using NationalInstruments.Analysis;
using NationalInstruments.Analysis.Conversion;
using NationalInstruments.Analysis.Dsp;
using NationalInstruments.Analysis.Dsp.Filters;
using NationalInstruments.Analysis.Math;
using NationalInstruments.Analysis.Monitoring;
using NationalInstruments.Analysis.SignalGeneration;
using NationalInstruments.Analysis.SpectralMeasurements;
using NationalInstruments;
using NationalInstruments.UI;
using NationalInstruments.NetworkVariable;
using NationalInstruments.NetworkVariable.WindowsForms;
using NationalInstruments.Tdms;
using NationalInstruments.UI.WindowsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using EasyModbus;
using GetNetStatus;
using SynDataBase;
using SynRealDatabase;
using System.Threading;
using ICCard;
using gps.parser;
using System.IO;
using System.IO.Ports;

namespace MarineFuelMonitor
{
    public partial class Frm_Main : Form
    {

        MySqlConnection conn,conn2;
        ModbusClient modbusClient = new ModbusClient(UserSetings.Default.PLCConnIp , 502);
        Mutex M = new Mutex();
        M1Card _M1Card = new M1Card();
        gps.parser.Nmea NmeaParse = new gps.parser.Nmea();
        gps.parser.MinimalNmeaPositionNotifier mnPosition = new gps.parser.MinimalNmeaPositionNotifier();
        SerialPort GPSPort = new SerialPort();

        public Frm_Main()
        {
            InitializeComponent();
            //Data.conn = string.Format("Server=rm-uf64fql0n27338879o.mysql.rds.aliyuncs.com;uid=tuser;pwd=t_user001;Database=shipinfo;CharSet=utf8;port=3306");
            Data.conn = string.Format("Server=localhost;uid=root;pwd=ihmc;Database=marinefueldb;CharSet=utf8;port=3306");
            Data.StartTime = DateTime.Now;
            Data.Mode_Selected_Last = 0;
            Data.Mode_Selected = 1;

            conn = new MySqlConnection(Data.conn);
            conn2 = new MySqlConnection(Data.conn);

            _M1Card.inital();
           
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rectangleShape2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Monitor_Click(object sender, EventArgs e)
        {
            Frm_Seting FormSeting = new Frm_Seting();
            FormSeting.ShowDialog();

        }

        private void writemysql(object sender, DoWorkEventArgs e)
        {
           //检测数据库是否连接并重新连接
              try
                {
                    

                    if (conn.State == ConnectionState.Open)
                    {
                        Data.MysqlStatus = true;
                        Led_ConnOK.Value = true;

                    }
                    else
                    {
                        conn.Open();
                    }
                }
                catch
                {
                    Data.MysqlStatus = false;
                    Led_ConnOK.Value = false;
                }
            
            
            
            
            if (Data.ReadyToWriteMysql == true)
            {
                string tb_Time,tb_MENumber,tb_InstantFuel,tb_InstantMESpeed,tb_InstantTemp,tb_InstantShipSpeed,tb_InstantN,tb_InstantE,tb_TankLevel;
                //string BeginTime,EndTime,Mode,Operator,MENumber,AveFuel,SubTotal;
                Led_SqlInsert.Value = false;
               
                try
                {
                    
                        if (conn.State == ConnectionState.Open)
                        {
                            if (Data.InputDI[10] == false)
                            {
                            /*****************************准备1号主机的数据*******************************************/
                            tb_Time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                            tb_MENumber = "1";
                            tb_InstantFuel = Data.InputAI[10].ToString();
                            tb_InstantMESpeed = Data.InputAI[14].ToString();
                            tb_InstantTemp = Data.InputAI[12].ToString();
                            tb_InstantShipSpeed = Data.InputAI[30].ToString();
                            tb_InstantN = Data.InputAI[31].ToString();
                            tb_InstantE = Data.InputAI[32].ToString();
                            tb_TankLevel = Data.InputAI[20].ToString();
                            MySqlCommand mycmd = new MySqlCommand("insert into revrealdata(Time,MENumber,InstantFuel,InstantMESpeed,InstantTemp,InstantShipSpeed,InstantN,InstantE,TankLevel) values(STR_TO_DATE('"
                                                                                      + tb_Time + "','%Y-%m-%d %H:%i:%s'),"
                                                                                      + tb_MENumber + ","
                                                                                      + tb_InstantFuel + ","
                                                                                      + tb_InstantMESpeed + ","
                                                                                      + tb_InstantTemp + ","
                                                                                      + tb_InstantShipSpeed + ","
                                                                                      + tb_InstantN + ","
                                                                                      + tb_InstantE + ","
                                                                                      + tb_TankLevel + ")", conn);



                            if (mycmd.ExecuteNonQuery() > 0)
                            {
                                Console.WriteLine("数据插入成功！");
                                Led_SqlInsert.Value = true;

                            }

                            Data.InputDI[10] =true;

                           
                        }
                        else
                        {

                            /*****************************准备2号主机的数据*******************************************/
                            tb_Time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                            tb_MENumber = "2";
                            tb_InstantFuel = Data.InputAI[20].ToString();
                            tb_InstantMESpeed = Data.InputAI[24].ToString();
                            tb_InstantTemp = Data.InputAI[22].ToString();
                            tb_InstantShipSpeed = Data.InputAI[30].ToString();
                            tb_InstantN = Data.InputAI[31].ToString();
                            tb_InstantE = Data.InputAI[32].ToString();
                            tb_TankLevel = Data.InputAI[20].ToString();

                            MySqlCommand mycmd2 = new MySqlCommand("insert into revrealdata(Time,MENumber,InstantFuel,InstantMESpeed,InstantTemp,InstantShipSpeed,InstantN,InstantE,TankLevel) values(STR_TO_DATE('"
                                                                                     + tb_Time + "','%Y-%m-%d %H:%i:%s'),"
                                                                                     + tb_MENumber + ","
                                                                                     + tb_InstantFuel + ","
                                                                                     + tb_InstantMESpeed + ","
                                                                                     + tb_InstantTemp + ","
                                                                                     + tb_InstantShipSpeed + ","
                                                                                     + tb_InstantN + ","
                                                                                     + tb_InstantE + ","
                                                                                     + tb_TankLevel + ")", conn);


                            if (mycmd2.ExecuteNonQuery() > 0)
                            {
                                Console.WriteLine("数据插入成功！");
                                Led_SqlInsert.Value = true;

                            }
                            Data.InputDI[10] = false;
                        }


                        //删除过期数据 
                            MySqlCommand mydelecmd =new MySqlCommand("delete From revrealdata where DATE(TIME) <= DATE(DATE_SUB(NOW(),INTERVAL " 
                                                                                     +  UserSetings.Default.DeleteDay + " day))"
                                                                                     , conn);
                            if (mydelecmd.ExecuteNonQuery() > 0)
                            {
                                Console.WriteLine("数据删除成功！");

                            }




                    }
                }
                catch
                {
                    
                }

            }
            
            Data.ReadyToWriteMysql = false;
        }


        private string DateDiff(DateTime DateTime1, DateTime DateTime2)
        {
            string dateDiff = null;
            TimeSpan ts1 = new TimeSpan(DateTime1.Ticks);
            TimeSpan ts2 = new
            TimeSpan(DateTime2.Ticks);
            TimeSpan ts = ts1.Subtract(ts2).Duration();
            dateDiff =ts.Days.ToString() + "d " + ts.Hours.ToString() + "h " + ts.Minutes.ToString() + "m " + ts.Seconds.ToString() + "s" ;
            return dateDiff;
        }

        
        private void timer1s(object sender, EventArgs e)
        {

            //启动网络监测线程
            if (bgw_CheckInternet.IsBusy == false)
            {
                bgw_CheckInternet.RunWorkerAsync();
            }
            //启动统计数据库SubTotal同步线程
            if (bgw_SynRealData.IsBusy == false)
            {
                bgw_SynRealData.RunWorkerAsync();
            }
            //启动统计数据库SubTotal同步线程
            if (bgw_SynRevSubData.IsBusy == false)
            {
                bgw_SynRevSubData.RunWorkerAsync();
            }
            //启动统计数据库SubTotal写入线程
            if (bgw_WiteSubData.IsBusy == false)
            {
                bgw_WiteSubData.RunWorkerAsync();
            }
            //启动积分计算线程
            if (bgw_CalcTravel.IsBusy == false)
            {
                bgw_CalcTravel.RunWorkerAsync();
            }
            //更改工况选择的显示
            if (Data.Mode_Selected == 1) { btn_ModeSelect.Text = "助泊"; }
            if (Data.Mode_Selected == 2) { btn_ModeSelect.Text = "单放"; }
            if (Data.Mode_Selected == 3) { btn_ModeSelect.Text = "工况"; }
            if (Data.Mode_Selected == 4) { btn_ModeSelect.Text = "拖带"; }
            if (Data.Mode_Selected == 5) { btn_ModeSelect.Text = "特种作业"; }
            if (Data.Mode_Selected == 6) { btn_ModeSelect.Text = "连续作业"; }

            //工况更改之后计算时间、
            if ((Data.Mode_Selected != Data.Mode_Selected_Last) && Data.InputDI[13]==true)
            {
                M.WaitOne();
                Data.ReadyToWriteSubData = true;
                
                LB_StartTime.Text = DateTime.Now.ToString("T");
               Data.Mode_Selected_Last = Data.Mode_Selected;
               Data.InputDI[13] = false;
               //初始化积分程序变量
               Data.TravelCalcTime = DateTime.Now;
               Data.TravelLen = 0.0;
               Data.InputAI[11] = 0.0;
               Data.InputAI[21] = 0.0;
               M.ReleaseMutex();
             }

            LB_UsedTime.Text = DateDiff(Data.StartTime, DateTime.Now);

            //将工况写入数据库
            
            
            //刷新页面的显示值
            //左主机
            //转速
            LB_MESpeedPS.Text = Data.InputAI[14].ToString("N0");
            GG_MEPS.Value = Data.InputAI[14];
            //瞬时油耗
            LB_InstantFuelPS.Text = Data.InputAI[10].ToString("N2");
            //航次累计油耗
            LB_FuelAllPS.Text = Data.InputAI[11].ToString("N2");
            //航次平均油耗
            if (Data.TravelLen == 0.0)
            { LB_FuelPerNmiPS.Text = "0.0"; }
            else
            {
                LB_FuelPerNmiPS.Text = (Data.InputAI[11] / Data.TravelLen).ToString("N2");
            }
          //  LB_FuelPerNmiPS.Text = (Data.InputAI[11] / Data.TravelLen).ToString("N3");
            //总航行里程
            LB_ShipSpeed.Text = Data.ShipSpeed.ToString("N1");
            LB_TimeTravelLen.Text = Data.TravelLen.ToString("N1");
            //右主机
            //转速
            LB_MESpeedSB.Text = Data.InputAI[24].ToString("N0");
            GG_MESB.Value = Data.InputAI[24];
            //瞬时油耗
            LB_InstantFuelSB.Text = Data.InputAI[20].ToString("N2");
            //航次累计油耗
            LB_FuelAllSB.Text = Data.InputAI[21].ToString("N2");
            //航次平均油耗
            if (Data.TravelLen == 0.0)
            { LB_FuelPerNmiSB.Text = "0.0"; }
            else
            {
                LB_FuelPerNmiSB.Text = (Data.InputAI[21] / Data.TravelLen).ToString("N2");
            }
           // LB_FuelPerNmiSB.Text = (Data.InputAI[21] / Data.TravelLen).ToString("N3");
            //油位、舱容、油温、库存
            LB_TankLevel.Text = Data.InputAI[7].ToString("N2");
            TK_FuelTankLevel.Value = Data.InputAI[7];
            LB_TankCap.Text = Data.InputAI[8].ToString("N2");
            LB_TankTemp.Text = Data.InputAI[12].ToString("N2");
            LB_FuelWeight.Text = Data.InputAI[9].ToString("N2");
            LB_UsedFuel.Text = (Data.InputAI[11] + Data.InputAI[21]).ToString("N2");

            //当前的刷卡信息
            Data.OperatorNow = _M1Card.ID;
            LB_OperatorID.Text = Data.OperatorNow.ToString();
            LB_Operator.Text = _M1Card.Name;
            //读卡器连接状态指示
            Led_ReaderOk.Value = _M1Card.ReaderOK;

            //采集箱PLC连接状态显示
            Led_PlcOK.Value = Data.InputDI[0];
            Data.InputDI[12] = true;

            //GPS连接状态
            Data.GPSCounter += 1;
            if (Data.GPSCounter >= 10)
            {
                Led_GpsOk.Value = false;
                Data.GPSCounter = 10;
            }
            else
            {
                Led_GpsOk.Value = true;

            }


        }

        private void TimerToSQL(object sender, EventArgs e)
        {
            Data.ReadyToWriteMysql = true;
            if (bgw_writemyswl.IsBusy == false)
            {
                bgw_writemyswl.RunWorkerAsync();
            }
        }

        private void Frm_Main_Close(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
            GPSPort.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Close();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            mnPosition.Init(NmeaParse);
            mnPosition.NewGspPosition += new gps.parser.MinimalNmeaPositionNotifier.NewGspPositionEventHandler(NewGspPosition);
            //NmeaParse.NewMessage += new gps.parser.Nmea.NewMessageEventHandler(HandleNewMessage);
            initalGPS();


           
        }
        private void NewGspPosition(gps.parser.GpsPosition pos)
        { // access: pos.x, pos.y, pos.speed, pos.course, pos.hdop, etc. 
            // all data are in metric system ... 
            Data.InputAI[5] = pos.x;
            Data.InputAI[6] = pos.y;
            Data.InputAI[4] = pos.speed / 1.852;
            Data.ShipSpeed = Data.InputAI[4];

        }
        private void initalGPS()
        {
            //GPSPort.PortName = cmb_ComSelect.Text;
            GPSPort.PortName = UserSetings.Default.GPSPort;
            GPSPort.BaudRate = 9600;
            GPSPort.StopBits = StopBits.One;
            GPSPort.Parity = Parity.None;
            GPSPort.ReadTimeout = SerialPort.InfiniteTimeout;
            try
            {
                GPSPort.Open();
            }
            catch
            {
                MessageBox.Show("GPS端口打开失败，请检查端口设置");
            }

            if (GPSPort.IsOpen)
            {
                NmeaParse.Source = GPSPort.BaseStream;
                //GPSPort.BaseStream.
                // NmeaParse.Source.Length
                NmeaParse.Start();

            }
            else
            {
 
            }

        }


        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label44_Click(object sender, EventArgs e)
        {

        }

        private void btn_ModeSelect_Click(object sender, EventArgs e)
        {
            Frm_Mode Form_Mode_Select = new Frm_Mode();
            Form_Mode_Select.ShowDialog();
        }

        private void btn_Query_Click(object sender, EventArgs e)
        {
            Frm_Query Form_DB_Query = new Frm_Query();
            Form_DB_Query.ShowDialog();
        }

        private void GG_MEPS_AfterChangeValue(object sender, AfterChangeNumericValueEventArgs e)
        {

        }

        private void PLCCom(object sender, DoWorkEventArgs e)
        {
           if (Data.InputDI[0] == false)
            {
                try
                {
                    modbusClient.Connect();

                }
                catch 
                {
                   // MessageBox.Show("连接设备故障，故障代码：" + ex.Message, "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                }
            }

           
                //判断PLC是否已经连接
                Data.InputDI[0] = modbusClient.Connected;
                //如果已经连接并且通信标志位Data.PLCComFlag为1，则开始读写数据

                if (modbusClient.Connected )
                {
                    try
                    {
                        //周期性的读取数据
                        if (Data.PLCComFlag)
                        {
                            int[] readHoldingRegisters = new int[50];
                            readHoldingRegisters=modbusClient.ReadHoldingRegisters(0, 30);
                            //对获取的数据进行解码
                            Data.InputAI[10] = Convert.ToDouble(readHoldingRegisters[0]) / 100.0;
                           // Data.InputAI[11] = Convert.ToDouble(readHoldingRegisters[1]) / 100.0;
                            Data.InputAI[12] = Convert.ToDouble(readHoldingRegisters[2]) / 100.0;
                            Data.InputAI[13] = Convert.ToDouble(readHoldingRegisters[3]) / 100.0;
                            Data.InputAI[14] = Convert.ToDouble(readHoldingRegisters[4]) / 10.0;
                            byte[] LrealTrans1 = BitConverter.GetBytes(readHoldingRegisters[5]);
                            byte[] LrealTrans2 = BitConverter.GetBytes(readHoldingRegisters[6]);
                            byte[] LrealTrans3 = BitConverter.GetBytes(readHoldingRegisters[7]);
                            byte[] LrealTrans4 = BitConverter.GetBytes(readHoldingRegisters[8]);
                            byte[] LrealTrans = new byte[8];
                            LrealTrans[0] = LrealTrans1[0];
                            LrealTrans[1] = LrealTrans1[1];
                            LrealTrans[2] = LrealTrans2[0];
                            LrealTrans[3] = LrealTrans2[1];
                            LrealTrans[4] = LrealTrans3[0];
                            LrealTrans[5] = LrealTrans3[1];
                            LrealTrans[6] = LrealTrans4[0];
                            LrealTrans[7] = LrealTrans4[1];
                            //Data.InputAI[15] = BitConverter.ToDouble(LrealTrans,0);


                            Data.InputAI[20] = Convert.ToDouble(readHoldingRegisters[10]) / 100.0;
                           // Data.InputAI[21] = Convert.ToDouble(readHoldingRegisters[11]) / 100.0;
                            Data.InputAI[22] = Convert.ToDouble(readHoldingRegisters[12]) / 100.0;
                            Data.InputAI[23] = Convert.ToDouble(readHoldingRegisters[13]) / 100.0;
                            Data.InputAI[24] = Convert.ToDouble(readHoldingRegisters[14]) / 10.0;
                            LrealTrans1 = BitConverter.GetBytes(readHoldingRegisters[15]);
                            LrealTrans2 = BitConverter.GetBytes(readHoldingRegisters[16]);
                            LrealTrans3 = BitConverter.GetBytes(readHoldingRegisters[17]);
                            LrealTrans4 = BitConverter.GetBytes(readHoldingRegisters[18]);
                            LrealTrans = new byte[8];
                            LrealTrans[0] = LrealTrans1[0];
                            LrealTrans[1] = LrealTrans1[1];
                            LrealTrans[2] = LrealTrans2[0];
                            LrealTrans[3] = LrealTrans2[1];
                            LrealTrans[4] = LrealTrans3[0];
                            LrealTrans[5] = LrealTrans3[1];
                            LrealTrans[6] = LrealTrans4[0];
                            LrealTrans[7] = LrealTrans4[1];
                            //Data.InputAI[25] = BitConverter.ToDouble(LrealTrans, 0);

                            Data.PLCComFlag = false;

                        }

                        //实时的写入数据
                        int[] PLCWrite = new int[20];

                        PLCWrite[0] = Data.Mode_Selected;//当前的模式选择
                        PLCWrite[1] = Data.OperatorNow;//当前的操作员选择
                        modbusClient.WriteMultipleRegisters(100, PLCWrite);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("连接设备故障，故障代码：" + ex.Message, "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
              



        }

        

        private void PLCComOver(object sender, RunWorkerCompletedEventArgs e)
        {
            modbusClient.Disconnect(); 
        }

        private void Timer_PLCTick(object sender, EventArgs e)
        {
            Data.PLCComFlag = true;
            if (bgw_ConnPLC.IsBusy == false)
            {
                bgw_ConnPLC.RunWorkerAsync();
            }
            
        }

        private void btn_Monitor_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkInternet(object sender, DoWorkEventArgs e)
        {
            //监测是否连接互联网
            int iNetStatus = GetInternetConStatus.GetNetConStatus("baidu.com");
            if (iNetStatus == 3 || iNetStatus == 2)
            {
                Led_InternetOk.Value = true;
            }
            else
            {
                Led_InternetOk.Value = false;

            }
        }

        private void SynSubTotalDB(object sender, ProgressChangedEventArgs e)
        {
            

        }

        private void SynSubTotalDBDowork(object sender, DoWorkEventArgs e)
        {
            SynData synSubTotal = new SynData();
            synSubTotal.setconn("Server=localhost;uid=root;pwd=ihmc;Database=marinefueldb;CharSet=utf8;port=3306", UserSetings.Default.RDSConnString);
            synSubTotal.openconn();
            Led_SubTotalSynOk.Value= synSubTotal.syn();
        }

        private void SynRealDBDoWork(object sender, DoWorkEventArgs e)
        {
            SynRealDB synRealData = new SynRealDB();
            synRealData.setconn("Server=localhost;uid=root;pwd=ihmc;Database=marinefueldb;CharSet=utf8;port=3306", UserSetings.Default.RDSConnString);
            synRealData.openconn();
           Led_SynRealOK.Value = synRealData.syn();
        }

        private void bgw_WriteSubDataDoWork(object sender, DoWorkEventArgs e)
        {

            //检测数据库是否连接并重新连接
            try
            {


                if (conn2.State == ConnectionState.Open)
                {
                    //Data.MysqlStatus = true;
                    //Led_ConnOK.Value = true;

                }
                else
                {
                    conn2.Open();
                }
            }
            catch
            {
                Data.MysqlStatus = false;
                Led_ConnOK.Value = false;
            }
            if ((Data.Mode_Selected != Data.Mode_Selected_Last) && Data.InputDI[13] == false)
            {
                Data.InputDI[13] = true;
                M.WaitOne();
                string BeginTime, EndTime, Mode, Operator, MENumber, MENumber2, AveFuel, AveFuel2, SubTotal, SubTotal2;
                BeginTime = Data.StartTime.ToString("yyyy-MM-dd HH:mm:ss");
                MENumber = "1";
                MENumber2 = "2";
                EndTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                Mode = Data.Mode_Selected_Last.ToString();
                Operator = Data.OperatorNow.ToString();
                AveFuel = Data.InputAI[11].ToString("N2");
                AveFuel2 = Data.InputAI[21].ToString("N2");
                SubTotal = Data.InputAI[15].ToString();
                SubTotal2 = Data.InputAI[25].ToString();
                MySqlCommand mycmd3 = new MySqlCommand("insert into revsubdata(BeginTime,EndTime,Mode,Operator,MENumber,AveFuel,SubTotal) values(STR_TO_DATE('"
                                                                          + BeginTime + "','%Y-%m-%d %H:%i:%s'),STR_TO_DATE('"
                                                                          + EndTime + "','%Y-%m-%d %H:%i:%s'),"
                                                                          + Mode + ","
                                                                          + Operator + ","
                                                                          + MENumber + ","
                                                                          + AveFuel + ","
                                                                          + SubTotal + ")," +
                                                                          "(STR_TO_DATE('"
                                                                          + BeginTime + "','%Y-%m-%d %H:%i:%s'),STR_TO_DATE('"
                                                                          + EndTime + "','%Y-%m-%d %H:%i:%s'),"
                                                                          + Mode + ","
                                                                          + Operator + ","
                                                                          + MENumber2 + ","
                                                                          + AveFuel2 + ","
                                                                          + SubTotal2 + ")", conn2);



                if (mycmd3.ExecuteNonQuery() > 0)
                {
                    Console.WriteLine("数据插入成功！");
                    Led_SqlInsert.Value = true;


                }
                
                Data.StartTime = DateTime.Now;
                M.ReleaseMutex();
            }
            
            }

        private void btn_DayOrNight_Click(object sender, EventArgs e)
        {
            
        }

        private void bgw_CalcTravelLen(object sender, DoWorkEventArgs e)
        {
            
            TimeSpan ts;
            if (Data.TravelCalcTime==null)
            {
                Data.TravelCalcTime = Data.StartTime;
            }
            
            ts=DateTime.Now-Data.TravelCalcTime;
            //Data.ShipSpeed = 10.8;
            Data.TravelLen = Data.TravelLen + (Convert.ToDouble(ts.TotalMilliseconds) * Data.ShipSpeed) / 3600000.0;
            Data.InputAI[11] = Data.InputAI[11] + (Convert.ToDouble(ts.TotalMilliseconds) * Data.InputAI[10]) / 60000.0;
            Data.InputAI[21] = Data.InputAI[21] + (Convert.ToDouble(ts.TotalMilliseconds) * Data.InputAI[20]) / 60000.0;


            Data.TravelCalcTime = DateTime.Now;
            Thread.Sleep(1000);

        }
           

        
    }
}
