namespace MarineFuelMonitor
{
    partial class Frm_Seting
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
            this.tb_db = new System.Windows.Forms.TabControl();
            this.Tpg_Server = new System.Windows.Forms.TabPage();
            this.BTN_DBResave = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_RDSConnString = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Tpg_PLC = new System.Windows.Forms.TabPage();
            this.Tpg_GPS = new System.Windows.Forms.TabPage();
            this.Tpg_System = new System.Windows.Forms.TabPage();
            this.btn_Quit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TB_PLCIP = new System.Windows.Forms.TextBox();
            this.BTN_PLCResave = new System.Windows.Forms.Button();
            this.tb_db.SuspendLayout();
            this.Tpg_Server.SuspendLayout();
            this.Tpg_PLC.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_db
            // 
            this.tb_db.Controls.Add(this.Tpg_Server);
            this.tb_db.Controls.Add(this.Tpg_PLC);
            this.tb_db.Controls.Add(this.Tpg_GPS);
            this.tb_db.Controls.Add(this.Tpg_System);
            this.tb_db.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_db.ItemSize = new System.Drawing.Size(200, 100);
            this.tb_db.Location = new System.Drawing.Point(12, 12);
            this.tb_db.Name = "tb_db";
            this.tb_db.SelectedIndex = 0;
            this.tb_db.Size = new System.Drawing.Size(1138, 538);
            this.tb_db.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tb_db.TabIndex = 0;
            // 
            // Tpg_Server
            // 
            this.Tpg_Server.BackColor = System.Drawing.SystemColors.Control;
            this.Tpg_Server.Controls.Add(this.BTN_DBResave);
            this.Tpg_Server.Controls.Add(this.textBox4);
            this.Tpg_Server.Controls.Add(this.label4);
            this.Tpg_Server.Controls.Add(this.TB_RDSConnString);
            this.Tpg_Server.Controls.Add(this.label1);
            this.Tpg_Server.Controls.Add(this.groupBox1);
            this.Tpg_Server.Controls.Add(this.groupBox2);
            this.Tpg_Server.Location = new System.Drawing.Point(4, 104);
            this.Tpg_Server.Name = "Tpg_Server";
            this.Tpg_Server.Padding = new System.Windows.Forms.Padding(3);
            this.Tpg_Server.Size = new System.Drawing.Size(1130, 430);
            this.Tpg_Server.TabIndex = 0;
            this.Tpg_Server.Text = "数据库";
            // 
            // BTN_DBResave
            // 
            this.BTN_DBResave.Location = new System.Drawing.Point(913, 226);
            this.BTN_DBResave.Name = "BTN_DBResave";
            this.BTN_DBResave.Size = new System.Drawing.Size(200, 100);
            this.BTN_DBResave.TabIndex = 16;
            this.BTN_DBResave.Text = "保存";
            this.BTN_DBResave.UseVisualStyleBackColor = true;
            this.BTN_DBResave.Click += new System.EventHandler(this.BTN_DBResave_Click);
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(179, 254);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(135, 31);
            this.textBox4.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "数据存储时长：";
            // 
            // TB_RDSConnString
            // 
            this.TB_RDSConnString.Location = new System.Drawing.Point(130, 32);
            this.TB_RDSConnString.Name = "TB_RDSConnString";
            this.TB_RDSConnString.Size = new System.Drawing.Size(950, 31);
            this.TB_RDSConnString.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "连接字符：";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1093, 188);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "远程";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(6, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(869, 188);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "本地";
            // 
            // Tpg_PLC
            // 
            this.Tpg_PLC.BackColor = System.Drawing.SystemColors.Control;
            this.Tpg_PLC.Controls.Add(this.BTN_PLCResave);
            this.Tpg_PLC.Controls.Add(this.TB_PLCIP);
            this.Tpg_PLC.Controls.Add(this.label2);
            this.Tpg_PLC.Controls.Add(this.groupBox3);
            this.Tpg_PLC.Location = new System.Drawing.Point(4, 104);
            this.Tpg_PLC.Name = "Tpg_PLC";
            this.Tpg_PLC.Padding = new System.Windows.Forms.Padding(3);
            this.Tpg_PLC.Size = new System.Drawing.Size(1130, 430);
            this.Tpg_PLC.TabIndex = 1;
            this.Tpg_PLC.Text = "机舱采集箱";
            // 
            // Tpg_GPS
            // 
            this.Tpg_GPS.BackColor = System.Drawing.SystemColors.Control;
            this.Tpg_GPS.Location = new System.Drawing.Point(4, 104);
            this.Tpg_GPS.Name = "Tpg_GPS";
            this.Tpg_GPS.Size = new System.Drawing.Size(1130, 430);
            this.Tpg_GPS.TabIndex = 2;
            this.Tpg_GPS.Text = "GPS";
            // 
            // Tpg_System
            // 
            this.Tpg_System.BackColor = System.Drawing.SystemColors.Control;
            this.Tpg_System.Location = new System.Drawing.Point(4, 104);
            this.Tpg_System.Name = "Tpg_System";
            this.Tpg_System.Size = new System.Drawing.Size(1130, 430);
            this.Tpg_System.TabIndex = 3;
            this.Tpg_System.Text = "系统";
            // 
            // btn_Quit
            // 
            this.btn_Quit.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Quit.Location = new System.Drawing.Point(929, 12);
            this.btn_Quit.Name = "btn_Quit";
            this.btn_Quit.Size = new System.Drawing.Size(200, 100);
            this.btn_Quit.TabIndex = 1;
            this.btn_Quit.Text = "退出";
            this.btn_Quit.UseVisualStyleBackColor = true;
            this.btn_Quit.Click += new System.EventHandler(this.btn_QuitClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "IP地址：";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(16, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(869, 188);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "机舱采集箱";
            // 
            // TB_PLCIP
            // 
            this.TB_PLCIP.Location = new System.Drawing.Point(131, 64);
            this.TB_PLCIP.Name = "TB_PLCIP";
            this.TB_PLCIP.Size = new System.Drawing.Size(231, 31);
            this.TB_PLCIP.TabIndex = 9;
            // 
            // BTN_PLCResave
            // 
            this.BTN_PLCResave.Location = new System.Drawing.Point(883, 270);
            this.BTN_PLCResave.Name = "BTN_PLCResave";
            this.BTN_PLCResave.Size = new System.Drawing.Size(200, 100);
            this.BTN_PLCResave.TabIndex = 17;
            this.BTN_PLCResave.Text = "保存";
            this.BTN_PLCResave.UseVisualStyleBackColor = true;
            this.BTN_PLCResave.Click += new System.EventHandler(this.BTN_PLCResave_Click);
            // 
            // Frm_Seting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 562);
            this.Controls.Add(this.btn_Quit);
            this.Controls.Add(this.tb_db);
            this.Name = "Frm_Seting";
            this.Text = "系统设定";
            this.Load += new System.EventHandler(this.Frm_SetingLoad);
            this.tb_db.ResumeLayout(false);
            this.Tpg_Server.ResumeLayout(false);
            this.Tpg_Server.PerformLayout();
            this.Tpg_PLC.ResumeLayout(false);
            this.Tpg_PLC.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tb_db;
        private System.Windows.Forms.TabPage Tpg_Server;
        private System.Windows.Forms.TabPage Tpg_PLC;
        private System.Windows.Forms.TabPage Tpg_GPS;
        private System.Windows.Forms.TabPage Tpg_System;
        private System.Windows.Forms.Button btn_Quit;
        private System.Windows.Forms.Button BTN_DBResave;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_RDSConnString;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TB_PLCIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BTN_PLCResave;
    }
}