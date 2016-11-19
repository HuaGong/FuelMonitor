namespace MarineFuelMonitor
{
    partial class Frm_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_SystemSetings = new System.Windows.Forms.Button();
            this.btn_DayOrNight = new System.Windows.Forms.Button();
            this.TK_FuelTankLevel = new NationalInstruments.UI.WindowsForms.Tank();
            this.GG_MEPS = new NationalInstruments.UI.WindowsForms.Gauge();
            this.GG_MESB = new NationalInstruments.UI.WindowsForms.Gauge();
            this.btn_Query = new System.Windows.Forms.Button();
            this.btn_Monitor = new System.Windows.Forms.Button();
            this.LB_StartTime = new System.Windows.Forms.Label();
            this.LB_Operator = new System.Windows.Forms.Label();
            this.LB_InstantFuelPS = new System.Windows.Forms.Label();
            this.LB_MESpeedPS = new System.Windows.Forms.Label();
            this.LB_InstantFuelSB = new System.Windows.Forms.Label();
            this.LB_MESpeedSB = new System.Windows.Forms.Label();
            this.bgw_writemyswl = new System.ComponentModel.BackgroundWorker();
            this.timer_1s = new System.Windows.Forms.Timer(this.components);
            this.TimerWriteSQL = new System.Windows.Forms.Timer(this.components);
            this.Led_ConnOK = new NationalInstruments.UI.WindowsForms.Led();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Led_InternetOk = new NationalInstruments.UI.WindowsForms.Led();
            this.label11 = new System.Windows.Forms.Label();
            this.Led_PlcOK = new NationalInstruments.UI.WindowsForms.Led();
            this.label12 = new System.Windows.Forms.Label();
            this.Led_ReaderOk = new NationalInstruments.UI.WindowsForms.Led();
            this.label13 = new System.Windows.Forms.Label();
            this.Led_GpsOk = new NationalInstruments.UI.WindowsForms.Led();
            this.label14 = new System.Windows.Forms.Label();
            this.Led_SubTotalSynOk = new NationalInstruments.UI.WindowsForms.Led();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.LB_TankLevel = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.LB_TankCap = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.LB_TankTemp = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.LB_FuelWeight = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.btn_ModeSelect = new System.Windows.Forms.Button();
            this.label30 = new System.Windows.Forms.Label();
            this.LB_UsedTime = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.LB_FuelPerNmiSB = new System.Windows.Forms.Label();
            this.LB_FuelPerNmiPS = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.LB_ShipSpeed = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LB_UsedFuel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Led_SqlInsert = new NationalInstruments.UI.WindowsForms.Led();
            this.bgw_ConnPLC = new System.ComponentModel.BackgroundWorker();
            this.timer_PLCRead = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.bgw_CheckInternet = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LB_FuelAllPS = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LB_FuelAllSB = new System.Windows.Forms.Label();
            this.bgw_SynRevSubData = new System.ComponentModel.BackgroundWorker();
            this.bgw_SynRealData = new System.ComponentModel.BackgroundWorker();
            this.label6 = new System.Windows.Forms.Label();
            this.Led_SynRealOK = new NationalInstruments.UI.WindowsForms.Led();
            this.bgw_WiteSubData = new System.ComponentModel.BackgroundWorker();
            this.bgw_CalcTravel = new System.ComponentModel.BackgroundWorker();
            this.label19 = new System.Windows.Forms.Label();
            this.LB_TimeTravelLen = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.LB_OperatorID = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TK_FuelTankLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GG_MEPS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GG_MESB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Led_ConnOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Led_InternetOk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Led_PlcOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Led_ReaderOk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Led_GpsOk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Led_SubTotalSynOk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Led_SqlInsert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Led_SynRealOK)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_SystemSetings
            // 
            this.btn_SystemSetings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SystemSetings.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_SystemSetings.Location = new System.Drawing.Point(1067, 617);
            this.btn_SystemSetings.Name = "btn_SystemSetings";
            this.btn_SystemSetings.Size = new System.Drawing.Size(160, 80);
            this.btn_SystemSetings.TabIndex = 0;
            this.btn_SystemSetings.Text = "系统设定";
            this.btn_SystemSetings.UseVisualStyleBackColor = true;
            this.btn_SystemSetings.Click += new System.EventHandler(this.btn_Monitor_Click);
            // 
            // btn_DayOrNight
            // 
            this.btn_DayOrNight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DayOrNight.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_DayOrNight.Location = new System.Drawing.Point(1067, 523);
            this.btn_DayOrNight.Name = "btn_DayOrNight";
            this.btn_DayOrNight.Size = new System.Drawing.Size(160, 80);
            this.btn_DayOrNight.TabIndex = 2;
            this.btn_DayOrNight.Text = "状态报告";
            this.btn_DayOrNight.UseVisualStyleBackColor = true;
            this.btn_DayOrNight.Click += new System.EventHandler(this.btn_DayOrNight_Click);
            // 
            // TK_FuelTankLevel
            // 
            this.TK_FuelTankLevel.CaptionBackColor = System.Drawing.Color.Transparent;
            this.TK_FuelTankLevel.CaptionForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.TK_FuelTankLevel.FillBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TK_FuelTankLevel.FillColor = System.Drawing.Color.DodgerBlue;
            this.TK_FuelTankLevel.FillStyle = NationalInstruments.UI.FillStyle.VerticalGradient;
            this.TK_FuelTankLevel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TK_FuelTankLevel.Location = new System.Drawing.Point(1001, 6);
            this.TK_FuelTankLevel.Name = "TK_FuelTankLevel";
            this.TK_FuelTankLevel.Range = new NationalInstruments.UI.Range(0D, 3D);
            this.TK_FuelTankLevel.Size = new System.Drawing.Size(265, 229);
            this.TK_FuelTankLevel.TabIndex = 3;
            this.TK_FuelTankLevel.TankStyle = NationalInstruments.UI.TankStyle.Flat;
            this.TK_FuelTankLevel.Value = 3D;
            // 
            // GG_MEPS
            // 
            this.GG_MEPS.DialColor = System.Drawing.Color.Transparent;
            this.GG_MEPS.ForeColor = System.Drawing.SystemColors.Highlight;
            this.GG_MEPS.GaugeStyle = NationalInstruments.UI.GaugeStyle.SunkenWithThickNeedle;
            this.GG_MEPS.Location = new System.Drawing.Point(17, 26);
            this.GG_MEPS.Name = "GG_MEPS";
            this.GG_MEPS.PointerColor = System.Drawing.SystemColors.Highlight;
            this.GG_MEPS.Range = new NationalInstruments.UI.Range(0D, 1000D);
            this.GG_MEPS.Size = new System.Drawing.Size(320, 320);
            this.GG_MEPS.SpindleColor = System.Drawing.Color.DimGray;
            this.GG_MEPS.TabIndex = 4;
            this.GG_MEPS.Value = 500D;
            this.GG_MEPS.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.GG_MEPS_AfterChangeValue);
            // 
            // GG_MESB
            // 
            this.GG_MESB.DialColor = System.Drawing.Color.Transparent;
            this.GG_MESB.ForeColor = System.Drawing.SystemColors.Highlight;
            this.GG_MESB.GaugeStyle = NationalInstruments.UI.GaugeStyle.SunkenWithThickNeedle;
            this.GG_MESB.Location = new System.Drawing.Point(363, 29);
            this.GG_MESB.Name = "GG_MESB";
            this.GG_MESB.PointerColor = System.Drawing.SystemColors.Highlight;
            this.GG_MESB.Range = new NationalInstruments.UI.Range(0D, 1000D);
            this.GG_MESB.Size = new System.Drawing.Size(320, 320);
            this.GG_MESB.SpindleColor = System.Drawing.Color.DimGray;
            this.GG_MESB.TabIndex = 11;
            this.GG_MESB.Value = 750D;
            // 
            // btn_Query
            // 
            this.btn_Query.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Query.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_Query.Location = new System.Drawing.Point(1067, 429);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(160, 80);
            this.btn_Query.TabIndex = 13;
            this.btn_Query.Text = "数据查询";
            this.btn_Query.UseVisualStyleBackColor = true;
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // btn_Monitor
            // 
            this.btn_Monitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Monitor.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_Monitor.Location = new System.Drawing.Point(1067, 333);
            this.btn_Monitor.Name = "btn_Monitor";
            this.btn_Monitor.Size = new System.Drawing.Size(160, 80);
            this.btn_Monitor.TabIndex = 14;
            this.btn_Monitor.Text = "退出监控";
            this.btn_Monitor.UseVisualStyleBackColor = true;
            this.btn_Monitor.Click += new System.EventHandler(this.btn_Monitor_Click_1);
            // 
            // LB_StartTime
            // 
            this.LB_StartTime.AutoSize = true;
            this.LB_StartTime.BackColor = System.Drawing.Color.Transparent;
            this.LB_StartTime.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LB_StartTime.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LB_StartTime.Location = new System.Drawing.Point(789, 544);
            this.LB_StartTime.Name = "LB_StartTime";
            this.LB_StartTime.Size = new System.Drawing.Size(143, 33);
            this.LB_StartTime.TabIndex = 15;
            this.LB_StartTime.Text = "18:18:18";
            // 
            // LB_Operator
            // 
            this.LB_Operator.AutoSize = true;
            this.LB_Operator.BackColor = System.Drawing.Color.Transparent;
            this.LB_Operator.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LB_Operator.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LB_Operator.Location = new System.Drawing.Point(816, 347);
            this.LB_Operator.Name = "LB_Operator";
            this.LB_Operator.Size = new System.Drawing.Size(127, 33);
            this.LB_Operator.TabIndex = 16;
            this.LB_Operator.Text = "驾驶员1";
            // 
            // LB_InstantFuelPS
            // 
            this.LB_InstantFuelPS.AutoSize = true;
            this.LB_InstantFuelPS.BackColor = System.Drawing.Color.Transparent;
            this.LB_InstantFuelPS.Font = new System.Drawing.Font("宋体", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LB_InstantFuelPS.ForeColor = System.Drawing.Color.Lime;
            this.LB_InstantFuelPS.Location = new System.Drawing.Point(59, 463);
            this.LB_InstantFuelPS.Name = "LB_InstantFuelPS";
            this.LB_InstantFuelPS.Size = new System.Drawing.Size(220, 64);
            this.LB_InstantFuelPS.TabIndex = 17;
            this.LB_InstantFuelPS.Text = "140.89";
            // 
            // LB_MESpeedPS
            // 
            this.LB_MESpeedPS.AutoSize = true;
            this.LB_MESpeedPS.BackColor = System.Drawing.Color.Transparent;
            this.LB_MESpeedPS.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LB_MESpeedPS.ForeColor = System.Drawing.Color.Red;
            this.LB_MESpeedPS.Location = new System.Drawing.Point(154, 239);
            this.LB_MESpeedPS.Name = "LB_MESpeedPS";
            this.LB_MESpeedPS.Size = new System.Drawing.Size(63, 33);
            this.LB_MESpeedPS.TabIndex = 18;
            this.LB_MESpeedPS.Text = "500";
            // 
            // LB_InstantFuelSB
            // 
            this.LB_InstantFuelSB.AutoSize = true;
            this.LB_InstantFuelSB.BackColor = System.Drawing.Color.Transparent;
            this.LB_InstantFuelSB.Font = new System.Drawing.Font("宋体", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LB_InstantFuelSB.ForeColor = System.Drawing.Color.Lime;
            this.LB_InstantFuelSB.Location = new System.Drawing.Point(431, 467);
            this.LB_InstantFuelSB.Name = "LB_InstantFuelSB";
            this.LB_InstantFuelSB.Size = new System.Drawing.Size(220, 64);
            this.LB_InstantFuelSB.TabIndex = 19;
            this.LB_InstantFuelSB.Text = "140.89";
            // 
            // LB_MESpeedSB
            // 
            this.LB_MESpeedSB.AutoSize = true;
            this.LB_MESpeedSB.BackColor = System.Drawing.Color.Transparent;
            this.LB_MESpeedSB.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LB_MESpeedSB.ForeColor = System.Drawing.Color.Red;
            this.LB_MESpeedSB.Location = new System.Drawing.Point(498, 239);
            this.LB_MESpeedSB.Name = "LB_MESpeedSB";
            this.LB_MESpeedSB.Size = new System.Drawing.Size(63, 33);
            this.LB_MESpeedSB.TabIndex = 20;
            this.LB_MESpeedSB.Text = "750";
            // 
            // bgw_writemyswl
            // 
            this.bgw_writemyswl.WorkerReportsProgress = true;
            this.bgw_writemyswl.DoWork += new System.ComponentModel.DoWorkEventHandler(this.writemysql);
            // 
            // timer_1s
            // 
            this.timer_1s.Enabled = true;
            this.timer_1s.Interval = 1000;
            this.timer_1s.Tick += new System.EventHandler(this.timer1s);
            // 
            // TimerWriteSQL
            // 
            this.TimerWriteSQL.Enabled = true;
            this.TimerWriteSQL.Interval = 1000;
            this.TimerWriteSQL.Tick += new System.EventHandler(this.TimerToSQL);
            // 
            // Led_ConnOK
            // 
            this.Led_ConnOK.Location = new System.Drawing.Point(17, 737);
            this.Led_ConnOK.Name = "Led_ConnOK";
            this.Led_ConnOK.OffColor = System.Drawing.Color.Red;
            this.Led_ConnOK.Size = new System.Drawing.Size(31, 31);
            this.Led_ConnOK.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label9.Location = new System.Drawing.Point(54, 747);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 12);
            this.label9.TabIndex = 22;
            this.label9.Text = "数据库连接状态";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label10.Location = new System.Drawing.Point(684, 747);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 12);
            this.label10.TabIndex = 24;
            this.label10.Text = "互联网连接状态";
            // 
            // Led_InternetOk
            // 
            this.Led_InternetOk.Location = new System.Drawing.Point(647, 736);
            this.Led_InternetOk.Name = "Led_InternetOk";
            this.Led_InternetOk.OffColor = System.Drawing.Color.Orange;
            this.Led_InternetOk.Size = new System.Drawing.Size(31, 31);
            this.Led_InternetOk.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label11.Location = new System.Drawing.Point(840, 747);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 12);
            this.label11.TabIndex = 26;
            this.label11.Text = "采集箱连接状态";
            // 
            // Led_PlcOK
            // 
            this.Led_PlcOK.Location = new System.Drawing.Point(803, 736);
            this.Led_PlcOK.Name = "Led_PlcOK";
            this.Led_PlcOK.Size = new System.Drawing.Size(31, 31);
            this.Led_PlcOK.TabIndex = 25;
            this.Led_PlcOK.StateChanged += new NationalInstruments.UI.ActionEventHandler(this.Led_PlcOK_StateChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label12.Location = new System.Drawing.Point(1001, 747);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 12);
            this.label12.TabIndex = 28;
            this.label12.Text = "读卡器连接状态";
            // 
            // Led_ReaderOk
            // 
            this.Led_ReaderOk.Location = new System.Drawing.Point(964, 736);
            this.Led_ReaderOk.Name = "Led_ReaderOk";
            this.Led_ReaderOk.OffColor = System.Drawing.Color.Red;
            this.Led_ReaderOk.Size = new System.Drawing.Size(31, 31);
            this.Led_ReaderOk.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label13.Location = new System.Drawing.Point(1156, 747);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 12);
            this.label13.TabIndex = 30;
            this.label13.Text = "GPS连接状态";
            // 
            // Led_GpsOk
            // 
            this.Led_GpsOk.Location = new System.Drawing.Point(1119, 736);
            this.Led_GpsOk.Name = "Led_GpsOk";
            this.Led_GpsOk.OffColor = System.Drawing.Color.Orange;
            this.Led_GpsOk.Size = new System.Drawing.Size(31, 31);
            this.Led_GpsOk.TabIndex = 29;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label14.Location = new System.Drawing.Point(361, 747);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 12);
            this.label14.TabIndex = 32;
            this.label14.Text = "数据统计库同步";
            // 
            // Led_SubTotalSynOk
            // 
            this.Led_SubTotalSynOk.Location = new System.Drawing.Point(324, 736);
            this.Led_SubTotalSynOk.Name = "Led_SubTotalSynOk";
            this.Led_SubTotalSynOk.Size = new System.Drawing.Size(31, 31);
            this.Led_SubTotalSynOk.TabIndex = 31;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label15.Location = new System.Drawing.Point(771, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 12);
            this.label15.TabIndex = 33;
            this.label15.Text = "当前液位:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label16.Location = new System.Drawing.Point(771, 125);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 12);
            this.label16.TabIndex = 34;
            this.label16.Text = "当前仓容:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label17.Location = new System.Drawing.Point(771, 220);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 12);
            this.label17.TabIndex = 35;
            this.label17.Text = "当前油温:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label18.Location = new System.Drawing.Point(1091, 232);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 12);
            this.label18.TabIndex = 36;
            this.label18.Text = "当前库存:";
            // 
            // LB_TankLevel
            // 
            this.LB_TankLevel.AutoSize = true;
            this.LB_TankLevel.BackColor = System.Drawing.Color.Transparent;
            this.LB_TankLevel.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LB_TankLevel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LB_TankLevel.Location = new System.Drawing.Point(789, 64);
            this.LB_TankLevel.Name = "LB_TankLevel";
            this.LB_TankLevel.Size = new System.Drawing.Size(79, 33);
            this.LB_TankLevel.TabIndex = 37;
            this.LB_TankLevel.Text = "2.45";
            this.LB_TankLevel.Click += new System.EventHandler(this.label19_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label20.Location = new System.Drawing.Point(896, 71);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(34, 24);
            this.label20.TabIndex = 38;
            this.label20.Text = "mm";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label21.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label21.Location = new System.Drawing.Point(899, 169);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(34, 24);
            this.label21.TabIndex = 40;
            this.label21.Text = "m³";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // LB_TankCap
            // 
            this.LB_TankCap.AutoSize = true;
            this.LB_TankCap.BackColor = System.Drawing.Color.Transparent;
            this.LB_TankCap.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LB_TankCap.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LB_TankCap.Location = new System.Drawing.Point(784, 160);
            this.LB_TankCap.Name = "LB_TankCap";
            this.LB_TankCap.Size = new System.Drawing.Size(111, 33);
            this.LB_TankCap.TabIndex = 39;
            this.LB_TankCap.Text = "102.45";
            this.LB_TankCap.Click += new System.EventHandler(this.label22_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label23.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label23.Location = new System.Drawing.Point(896, 251);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(34, 24);
            this.label23.TabIndex = 42;
            this.label23.Text = "℃";
            // 
            // LB_TankTemp
            // 
            this.LB_TankTemp.AutoSize = true;
            this.LB_TankTemp.BackColor = System.Drawing.Color.Transparent;
            this.LB_TankTemp.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LB_TankTemp.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LB_TankTemp.Location = new System.Drawing.Point(789, 244);
            this.LB_TankTemp.Name = "LB_TankTemp";
            this.LB_TankTemp.Size = new System.Drawing.Size(79, 33);
            this.LB_TankTemp.TabIndex = 41;
            this.LB_TankTemp.Text = "41.5";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label25.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label25.Location = new System.Drawing.Point(1214, 249);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(34, 24);
            this.label25.TabIndex = 44;
            this.label25.Text = "Kg";
            // 
            // LB_FuelWeight
            // 
            this.LB_FuelWeight.AutoSize = true;
            this.LB_FuelWeight.BackColor = System.Drawing.Color.Transparent;
            this.LB_FuelWeight.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LB_FuelWeight.ForeColor = System.Drawing.Color.Orange;
            this.LB_FuelWeight.Location = new System.Drawing.Point(1087, 244);
            this.LB_FuelWeight.Name = "LB_FuelWeight";
            this.LB_FuelWeight.Size = new System.Drawing.Size(111, 33);
            this.LB_FuelWeight.TabIndex = 43;
            this.LB_FuelWeight.Text = "3000.5";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label27.Location = new System.Drawing.Point(771, 313);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(83, 12);
            this.label27.TabIndex = 45;
            this.label27.Text = "当前操作人员:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label28.Location = new System.Drawing.Point(772, 390);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(77, 12);
            this.label28.TabIndex = 47;
            this.label28.Text = "当前工作模式";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label29.Location = new System.Drawing.Point(772, 517);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(101, 12);
            this.label29.TabIndex = 49;
            this.label29.Text = "当前模式起始时间";
            // 
            // btn_ModeSelect
            // 
            this.btn_ModeSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ModeSelect.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ModeSelect.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_ModeSelect.Location = new System.Drawing.Point(784, 431);
            this.btn_ModeSelect.Name = "btn_ModeSelect";
            this.btn_ModeSelect.Size = new System.Drawing.Size(177, 66);
            this.btn_ModeSelect.TabIndex = 1;
            this.btn_ModeSelect.Text = "助泊";
            this.btn_ModeSelect.UseVisualStyleBackColor = true;
            this.btn_ModeSelect.Click += new System.EventHandler(this.btn_ModeSelect_Click);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label30.Location = new System.Drawing.Point(772, 590);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(101, 12);
            this.label30.TabIndex = 51;
            this.label30.Text = "当前模式消耗时间";
            // 
            // LB_UsedTime
            // 
            this.LB_UsedTime.AutoSize = true;
            this.LB_UsedTime.BackColor = System.Drawing.Color.Transparent;
            this.LB_UsedTime.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LB_UsedTime.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LB_UsedTime.Location = new System.Drawing.Point(789, 622);
            this.LB_UsedTime.Name = "LB_UsedTime";
            this.LB_UsedTime.Size = new System.Drawing.Size(175, 33);
            this.LB_UsedTime.TabIndex = 50;
            this.LB_UsedTime.Text = "0h 26m 30s";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label32.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label32.Location = new System.Drawing.Point(552, 246);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(43, 21);
            this.label32.TabIndex = 52;
            this.label32.Text = "RPM";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label33.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label33.Location = new System.Drawing.Point(211, 248);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(43, 21);
            this.label33.TabIndex = 53;
            this.label33.Text = "RPM";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label34.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label34.Location = new System.Drawing.Point(645, 501);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(58, 24);
            this.label34.TabIndex = 54;
            this.label34.Text = "Kg/h";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label35.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label35.Location = new System.Drawing.Point(285, 497);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(58, 24);
            this.label35.TabIndex = 55;
            this.label35.Text = "Kg/h";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label36.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label36.Location = new System.Drawing.Point(285, 593);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(58, 24);
            this.label36.TabIndex = 59;
            this.label36.Text = "Kg/h";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label37.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label37.Location = new System.Drawing.Point(645, 597);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(58, 24);
            this.label37.TabIndex = 58;
            this.label37.Text = "Kg/h";
            // 
            // LB_FuelPerNmiSB
            // 
            this.LB_FuelPerNmiSB.AutoSize = true;
            this.LB_FuelPerNmiSB.BackColor = System.Drawing.Color.Transparent;
            this.LB_FuelPerNmiSB.Font = new System.Drawing.Font("宋体", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LB_FuelPerNmiSB.ForeColor = System.Drawing.Color.Blue;
            this.LB_FuelPerNmiSB.Location = new System.Drawing.Point(431, 563);
            this.LB_FuelPerNmiSB.Name = "LB_FuelPerNmiSB";
            this.LB_FuelPerNmiSB.Size = new System.Drawing.Size(220, 64);
            this.LB_FuelPerNmiSB.TabIndex = 57;
            this.LB_FuelPerNmiSB.Text = "140.89";
            // 
            // LB_FuelPerNmiPS
            // 
            this.LB_FuelPerNmiPS.AutoSize = true;
            this.LB_FuelPerNmiPS.BackColor = System.Drawing.Color.Transparent;
            this.LB_FuelPerNmiPS.Font = new System.Drawing.Font("宋体", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LB_FuelPerNmiPS.ForeColor = System.Drawing.Color.Blue;
            this.LB_FuelPerNmiPS.Location = new System.Drawing.Point(59, 559);
            this.LB_FuelPerNmiPS.Name = "LB_FuelPerNmiPS";
            this.LB_FuelPerNmiPS.Size = new System.Drawing.Size(220, 64);
            this.LB_FuelPerNmiPS.TabIndex = 56;
            this.LB_FuelPerNmiPS.Text = "140.89";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label40.Location = new System.Drawing.Point(79, 447);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(59, 12);
            this.label40.TabIndex = 60;
            this.label40.Text = "瞬时油耗:";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label41.Location = new System.Drawing.Point(446, 451);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(59, 12);
            this.label41.TabIndex = 61;
            this.label41.Text = "瞬时油耗:";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label42.Location = new System.Drawing.Point(446, 551);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(83, 12);
            this.label42.TabIndex = 63;
            this.label42.Text = "航次平均油耗:";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label43.Location = new System.Drawing.Point(79, 547);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(83, 12);
            this.label43.TabIndex = 62;
            this.label43.Text = "航次平均油耗:";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label44.Location = new System.Drawing.Point(228, 351);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(53, 12);
            this.label44.TabIndex = 64;
            this.label44.Text = "当前时速";
            this.label44.Click += new System.EventHandler(this.label44_Click);
            // 
            // LB_ShipSpeed
            // 
            this.LB_ShipSpeed.AutoSize = true;
            this.LB_ShipSpeed.BackColor = System.Drawing.Color.Transparent;
            this.LB_ShipSpeed.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LB_ShipSpeed.ForeColor = System.Drawing.Color.Orange;
            this.LB_ShipSpeed.Location = new System.Drawing.Point(218, 379);
            this.LB_ShipSpeed.Name = "LB_ShipSpeed";
            this.LB_ShipSpeed.Size = new System.Drawing.Size(79, 33);
            this.LB_ShipSpeed.TabIndex = 65;
            this.LB_ShipSpeed.Text = "10.5";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label46.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label46.Location = new System.Drawing.Point(297, 388);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(70, 24);
            this.label46.TabIndex = 66;
            this.label46.Text = "nmi/h";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(772, 655);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 68;
            this.label1.Text = "当前航次消耗燃油";
            // 
            // LB_UsedFuel
            // 
            this.LB_UsedFuel.AutoSize = true;
            this.LB_UsedFuel.BackColor = System.Drawing.Color.Transparent;
            this.LB_UsedFuel.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LB_UsedFuel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LB_UsedFuel.Location = new System.Drawing.Point(789, 681);
            this.LB_UsedFuel.Name = "LB_UsedFuel";
            this.LB_UsedFuel.Size = new System.Drawing.Size(63, 33);
            this.LB_UsedFuel.TabIndex = 67;
            this.LB_UsedFuel.Text = "300";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(204, 747);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 70;
            this.label2.Text = "数据库写入状态";
            // 
            // Led_SqlInsert
            // 
            this.Led_SqlInsert.Location = new System.Drawing.Point(167, 737);
            this.Led_SqlInsert.Name = "Led_SqlInsert";
            this.Led_SqlInsert.OffColor = System.Drawing.Color.Red;
            this.Led_SqlInsert.Size = new System.Drawing.Size(31, 31);
            this.Led_SqlInsert.TabIndex = 69;
            // 
            // bgw_ConnPLC
            // 
            this.bgw_ConnPLC.WorkerReportsProgress = true;
            this.bgw_ConnPLC.DoWork += new System.ComponentModel.DoWorkEventHandler(this.PLCCom);
            this.bgw_ConnPLC.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.PLCComOver);
            // 
            // timer_PLCRead
            // 
            this.timer_PLCRead.Enabled = true;
            this.timer_PLCRead.Tick += new System.EventHandler(this.Timer_PLCTick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(899, 690);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 24);
            this.label3.TabIndex = 71;
            this.label3.Text = "Kg";
            // 
            // bgw_CheckInternet
            // 
            this.bgw_CheckInternet.WorkerReportsProgress = true;
            this.bgw_CheckInternet.DoWork += new System.ComponentModel.DoWorkEventHandler(this.checkInternet);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(79, 639);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 74;
            this.label4.Text = "航次油耗:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(285, 685);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 24);
            this.label5.TabIndex = 73;
            this.label5.Text = "Kg";
            // 
            // LB_FuelAllPS
            // 
            this.LB_FuelAllPS.AutoSize = true;
            this.LB_FuelAllPS.BackColor = System.Drawing.Color.Transparent;
            this.LB_FuelAllPS.Font = new System.Drawing.Font("宋体", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LB_FuelAllPS.ForeColor = System.Drawing.Color.Blue;
            this.LB_FuelAllPS.Location = new System.Drawing.Point(59, 651);
            this.LB_FuelAllPS.Name = "LB_FuelAllPS";
            this.LB_FuelAllPS.Size = new System.Drawing.Size(220, 64);
            this.LB_FuelAllPS.TabIndex = 72;
            this.LB_FuelAllPS.Text = "140.89";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(450, 643);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 77;
            this.label7.Text = "航次油耗:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(644, 686);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 24);
            this.label8.TabIndex = 76;
            this.label8.Text = "Kg";
            // 
            // LB_FuelAllSB
            // 
            this.LB_FuelAllSB.AutoSize = true;
            this.LB_FuelAllSB.BackColor = System.Drawing.Color.Transparent;
            this.LB_FuelAllSB.Font = new System.Drawing.Font("宋体", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LB_FuelAllSB.ForeColor = System.Drawing.Color.Blue;
            this.LB_FuelAllSB.Location = new System.Drawing.Point(430, 655);
            this.LB_FuelAllSB.Name = "LB_FuelAllSB";
            this.LB_FuelAllSB.Size = new System.Drawing.Size(220, 64);
            this.LB_FuelAllSB.TabIndex = 75;
            this.LB_FuelAllSB.Text = "140.89";
            // 
            // bgw_SynRevSubData
            // 
            this.bgw_SynRevSubData.WorkerReportsProgress = true;
            this.bgw_SynRevSubData.DoWork += new System.ComponentModel.DoWorkEventHandler(this.SynSubTotalDBDowork);
            // 
            // bgw_SynRealData
            // 
            this.bgw_SynRealData.WorkerReportsProgress = true;
            this.bgw_SynRealData.DoWork += new System.ComponentModel.DoWorkEventHandler(this.SynRealDBDoWork);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(521, 747);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 12);
            this.label6.TabIndex = 79;
            this.label6.Text = "实时监控库同步";
            // 
            // Led_SynRealOK
            // 
            this.Led_SynRealOK.Location = new System.Drawing.Point(484, 736);
            this.Led_SynRealOK.Name = "Led_SynRealOK";
            this.Led_SynRealOK.OffColor = System.Drawing.Color.Orange;
            this.Led_SynRealOK.Size = new System.Drawing.Size(31, 31);
            this.Led_SynRealOK.TabIndex = 78;
            // 
            // bgw_WiteSubData
            // 
            this.bgw_WiteSubData.WorkerReportsProgress = true;
            this.bgw_WiteSubData.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_WriteSubDataDoWork);
            // 
            // bgw_CalcTravel
            // 
            this.bgw_CalcTravel.WorkerReportsProgress = true;
            this.bgw_CalcTravel.WorkerSupportsCancellation = true;
            this.bgw_CalcTravel.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_CalcTravelLen);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label19.Location = new System.Drawing.Point(500, 386);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(46, 24);
            this.label19.TabIndex = 82;
            this.label19.Text = "nmi";
            // 
            // LB_TimeTravelLen
            // 
            this.LB_TimeTravelLen.AutoSize = true;
            this.LB_TimeTravelLen.BackColor = System.Drawing.Color.Transparent;
            this.LB_TimeTravelLen.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LB_TimeTravelLen.ForeColor = System.Drawing.Color.Orange;
            this.LB_TimeTravelLen.Location = new System.Drawing.Point(417, 380);
            this.LB_TimeTravelLen.Name = "LB_TimeTravelLen";
            this.LB_TimeTravelLen.Size = new System.Drawing.Size(79, 33);
            this.LB_TimeTravelLen.TabIndex = 81;
            this.LB_TimeTravelLen.Text = "10.5";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label24.Location = new System.Drawing.Point(427, 352);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(53, 12);
            this.label24.TabIndex = 80;
            this.label24.Text = "航次里程";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label22.Location = new System.Drawing.Point(884, 387);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(23, 12);
            this.label22.TabIndex = 83;
            this.label22.Text = "ID:";
            // 
            // LB_OperatorID
            // 
            this.LB_OperatorID.AutoSize = true;
            this.LB_OperatorID.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LB_OperatorID.Location = new System.Drawing.Point(907, 388);
            this.LB_OperatorID.Name = "LB_OperatorID";
            this.LB_OperatorID.Size = new System.Drawing.Size(29, 12);
            this.LB_OperatorID.TabIndex = 84;
            this.LB_OperatorID.Text = "1004";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label26.Location = new System.Drawing.Point(1078, 779);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(149, 12);
            this.label26.TabIndex = 85;
            this.label26.Text = "镇江远洋电子科技有限公司";
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1280, 800);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.LB_OperatorID);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.LB_TimeTravelLen);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Led_SynRealOK);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LB_FuelAllSB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LB_FuelAllPS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Led_SqlInsert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LB_UsedFuel);
            this.Controls.Add(this.label46);
            this.Controls.Add(this.LB_ShipSpeed);
            this.Controls.Add(this.label44);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.label43);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.LB_FuelPerNmiSB);
            this.Controls.Add(this.LB_FuelPerNmiPS);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.LB_UsedTime);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.LB_FuelWeight);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.LB_TankTemp);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.LB_TankCap);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.LB_TankLevel);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Led_SubTotalSynOk);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Led_GpsOk);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Led_ReaderOk);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Led_PlcOK);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Led_InternetOk);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Led_ConnOK);
            this.Controls.Add(this.LB_MESpeedSB);
            this.Controls.Add(this.LB_InstantFuelSB);
            this.Controls.Add(this.LB_MESpeedPS);
            this.Controls.Add(this.LB_InstantFuelPS);
            this.Controls.Add(this.LB_Operator);
            this.Controls.Add(this.LB_StartTime);
            this.Controls.Add(this.btn_Monitor);
            this.Controls.Add(this.btn_Query);
            this.Controls.Add(this.GG_MESB);
            this.Controls.Add(this.GG_MEPS);
            this.Controls.Add(this.TK_FuelTankLevel);
            this.Controls.Add(this.btn_DayOrNight);
            this.Controls.Add(this.btn_ModeSelect);
            this.Controls.Add(this.btn_SystemSetings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Main";
            this.Text = "油耗监控系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Main_Close);
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TK_FuelTankLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GG_MEPS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GG_MESB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Led_ConnOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Led_InternetOk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Led_PlcOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Led_ReaderOk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Led_GpsOk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Led_SubTotalSynOk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Led_SqlInsert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Led_SynRealOK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SystemSetings;
        private System.Windows.Forms.Button btn_DayOrNight;
        private NationalInstruments.UI.WindowsForms.Tank TK_FuelTankLevel;
        private NationalInstruments.UI.WindowsForms.Gauge GG_MEPS;
        private NationalInstruments.UI.WindowsForms.Gauge GG_MESB;
        private System.Windows.Forms.Button btn_Query;
        private System.Windows.Forms.Button btn_Monitor;
        private System.Windows.Forms.Label LB_StartTime;
        private System.Windows.Forms.Label LB_Operator;
        private System.Windows.Forms.Label LB_InstantFuelPS;
        private System.Windows.Forms.Label LB_MESpeedPS;
        private System.Windows.Forms.Label LB_InstantFuelSB;
        private System.Windows.Forms.Label LB_MESpeedSB;
        private System.ComponentModel.BackgroundWorker bgw_writemyswl;
        private System.Windows.Forms.Timer timer_1s;
        private System.Windows.Forms.Timer TimerWriteSQL;
        private NationalInstruments.UI.WindowsForms.Led Led_ConnOK;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private NationalInstruments.UI.WindowsForms.Led Led_InternetOk;
        private System.Windows.Forms.Label label11;
        private NationalInstruments.UI.WindowsForms.Led Led_PlcOK;
        private System.Windows.Forms.Label label12;
        private NationalInstruments.UI.WindowsForms.Led Led_ReaderOk;
        private System.Windows.Forms.Label label13;
        private NationalInstruments.UI.WindowsForms.Led Led_GpsOk;
        private System.Windows.Forms.Label label14;
        private NationalInstruments.UI.WindowsForms.Led Led_SubTotalSynOk;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label LB_TankLevel;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label LB_TankCap;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label LB_TankTemp;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label LB_FuelWeight;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Button btn_ModeSelect;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label LB_UsedTime;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label LB_FuelPerNmiSB;
        private System.Windows.Forms.Label LB_FuelPerNmiPS;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label LB_ShipSpeed;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LB_UsedFuel;
        private System.Windows.Forms.Label label2;
        private NationalInstruments.UI.WindowsForms.Led Led_SqlInsert;
        private System.ComponentModel.BackgroundWorker bgw_ConnPLC;
        private System.Windows.Forms.Timer timer_PLCRead;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker bgw_CheckInternet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LB_FuelAllPS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LB_FuelAllSB;
        private System.ComponentModel.BackgroundWorker bgw_SynRevSubData;
        private System.ComponentModel.BackgroundWorker bgw_SynRealData;
        private System.Windows.Forms.Label label6;
        private NationalInstruments.UI.WindowsForms.Led Led_SynRealOK;
        private System.ComponentModel.BackgroundWorker bgw_WiteSubData;
        private System.ComponentModel.BackgroundWorker bgw_CalcTravel;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label LB_TimeTravelLen;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label LB_OperatorID;
        private System.Windows.Forms.Label label26;
    }
}

