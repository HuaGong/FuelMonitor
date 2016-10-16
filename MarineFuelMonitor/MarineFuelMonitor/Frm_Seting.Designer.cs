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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Tpg_Server = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Tpg_PLC = new System.Windows.Forms.TabPage();
            this.Tpg_GPS = new System.Windows.Forms.TabPage();
            this.Tpg_System = new System.Windows.Forms.TabPage();
            this.btn_Quit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.Tpg_Server.SuspendLayout();
            this.Tpg_System.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Tpg_Server);
            this.tabControl1.Controls.Add(this.Tpg_PLC);
            this.tabControl1.Controls.Add(this.Tpg_GPS);
            this.tabControl1.Controls.Add(this.Tpg_System);
            this.tabControl1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.ItemSize = new System.Drawing.Size(200, 100);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1138, 538);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // Tpg_Server
            // 
            this.Tpg_Server.BackColor = System.Drawing.SystemColors.Control;
            this.Tpg_Server.Controls.Add(this.button2);
            this.Tpg_Server.Controls.Add(this.textBox4);
            this.Tpg_Server.Controls.Add(this.label4);
            this.Tpg_Server.Controls.Add(this.textBox3);
            this.Tpg_Server.Controls.Add(this.label3);
            this.Tpg_Server.Controls.Add(this.textBox2);
            this.Tpg_Server.Controls.Add(this.label2);
            this.Tpg_Server.Controls.Add(this.textBox1);
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(913, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 100);
            this.button2.TabIndex = 16;
            this.button2.Text = "保存";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
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
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(130, 146);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(717, 31);
            this.textBox3.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "密    码：";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(130, 91);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(717, 31);
            this.textBox2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "用 户 名：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(717, 31);
            this.textBox1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "远程地址：";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(869, 188);
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
            this.Tpg_System.Controls.Add(this.dataGridView1);
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(416, 381);
            this.dataGridView1.TabIndex = 0;
            // 
            // Frm_Seting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 562);
            this.Controls.Add(this.btn_Quit);
            this.Controls.Add(this.tabControl1);
            this.Name = "Frm_Seting";
            this.Text = "系统设定";
            this.tabControl1.ResumeLayout(false);
            this.Tpg_Server.ResumeLayout(false);
            this.Tpg_Server.PerformLayout();
            this.Tpg_System.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Tpg_Server;
        private System.Windows.Forms.TabPage Tpg_PLC;
        private System.Windows.Forms.TabPage Tpg_GPS;
        private System.Windows.Forms.TabPage Tpg_System;
        private System.Windows.Forms.Button btn_Quit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}