namespace MarineFuelMonitor
{
    partial class Frm_Mode
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
            this.btn_Mode_1 = new System.Windows.Forms.Button();
            this.btn_Mode_2 = new System.Windows.Forms.Button();
            this.btn_Mode_4 = new System.Windows.Forms.Button();
            this.btn_Mode_3 = new System.Windows.Forms.Button();
            this.btn_Mode_6 = new System.Windows.Forms.Button();
            this.btn_Mode_5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Mode_1
            // 
            this.btn_Mode_1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btn_Mode_1.Location = new System.Drawing.Point(12, 22);
            this.btn_Mode_1.Name = "btn_Mode_1";
            this.btn_Mode_1.Size = new System.Drawing.Size(128, 80);
            this.btn_Mode_1.TabIndex = 0;
            this.btn_Mode_1.Text = "助泊";
            this.btn_Mode_1.UseVisualStyleBackColor = true;
            this.btn_Mode_1.Click += new System.EventHandler(this.btn_Mode_1_Clicked);
            // 
            // btn_Mode_2
            // 
            this.btn_Mode_2.Location = new System.Drawing.Point(176, 22);
            this.btn_Mode_2.Name = "btn_Mode_2";
            this.btn_Mode_2.Size = new System.Drawing.Size(128, 80);
            this.btn_Mode_2.TabIndex = 1;
            this.btn_Mode_2.Text = "单放";
            this.btn_Mode_2.UseVisualStyleBackColor = true;
            this.btn_Mode_2.Click += new System.EventHandler(this.btn_Mode_2_Clicked);
            // 
            // btn_Mode_4
            // 
            this.btn_Mode_4.Location = new System.Drawing.Point(176, 120);
            this.btn_Mode_4.Name = "btn_Mode_4";
            this.btn_Mode_4.Size = new System.Drawing.Size(128, 80);
            this.btn_Mode_4.TabIndex = 3;
            this.btn_Mode_4.Text = "拖带";
            this.btn_Mode_4.UseVisualStyleBackColor = true;
            this.btn_Mode_4.Click += new System.EventHandler(this.btn_Mode_4_Clicked);
            // 
            // btn_Mode_3
            // 
            this.btn_Mode_3.Location = new System.Drawing.Point(12, 120);
            this.btn_Mode_3.Name = "btn_Mode_3";
            this.btn_Mode_3.Size = new System.Drawing.Size(128, 80);
            this.btn_Mode_3.TabIndex = 2;
            this.btn_Mode_3.Text = "工况";
            this.btn_Mode_3.UseVisualStyleBackColor = true;
            this.btn_Mode_3.Click += new System.EventHandler(this.btn_Mode_3_Clicked);
            // 
            // btn_Mode_6
            // 
            this.btn_Mode_6.Location = new System.Drawing.Point(176, 220);
            this.btn_Mode_6.Name = "btn_Mode_6";
            this.btn_Mode_6.Size = new System.Drawing.Size(128, 80);
            this.btn_Mode_6.TabIndex = 5;
            this.btn_Mode_6.Text = "连续作业";
            this.btn_Mode_6.UseVisualStyleBackColor = true;
            this.btn_Mode_6.Click += new System.EventHandler(this.btn_Mode_6_Clicked);
            // 
            // btn_Mode_5
            // 
            this.btn_Mode_5.Location = new System.Drawing.Point(12, 220);
            this.btn_Mode_5.Name = "btn_Mode_5";
            this.btn_Mode_5.Size = new System.Drawing.Size(128, 80);
            this.btn_Mode_5.TabIndex = 4;
            this.btn_Mode_5.Text = "特种作业";
            this.btn_Mode_5.UseVisualStyleBackColor = true;
            this.btn_Mode_5.Click += new System.EventHandler(this.btn_Mode_5_Clicked);
            // 
            // Frm_Mode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 319);
            this.Controls.Add(this.btn_Mode_6);
            this.Controls.Add(this.btn_Mode_5);
            this.Controls.Add(this.btn_Mode_4);
            this.Controls.Add(this.btn_Mode_3);
            this.Controls.Add(this.btn_Mode_2);
            this.Controls.Add(this.btn_Mode_1);
            this.Name = "Frm_Mode";
            this.Text = "工况选择";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Mode_1;
        private System.Windows.Forms.Button btn_Mode_2;
        private System.Windows.Forms.Button btn_Mode_4;
        private System.Windows.Forms.Button btn_Mode_3;
        private System.Windows.Forms.Button btn_Mode_6;
        private System.Windows.Forms.Button btn_Mode_5;
    }
}