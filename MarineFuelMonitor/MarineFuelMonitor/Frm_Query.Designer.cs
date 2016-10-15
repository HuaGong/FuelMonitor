namespace MarineFuelMonitor
{
    partial class Frm_Query
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
            this.dgv_query = new System.Windows.Forms.DataGridView();
            this.dtp_Query = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_query)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_query
            // 
            this.dgv_query.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_query.Location = new System.Drawing.Point(12, 93);
            this.dgv_query.Name = "dgv_query";
            this.dgv_query.RowTemplate.Height = 23;
            this.dgv_query.Size = new System.Drawing.Size(1160, 457);
            this.dgv_query.TabIndex = 0;
            // 
            // dtp_Query
            // 
            this.dtp_Query.CalendarFont = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtp_Query.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtp_Query.Location = new System.Drawing.Point(14, 12);
            this.dtp_Query.Name = "dtp_Query";
            this.dtp_Query.Size = new System.Drawing.Size(329, 62);
            this.dtp_Query.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(348, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 61);
            this.button1.TabIndex = 2;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(540, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 61);
            this.button2.TabIndex = 3;
            this.button2.Text = "退出";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Frm_Query
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 562);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtp_Query);
            this.Controls.Add(this.dgv_query);
            this.Name = "Frm_Query";
            this.Text = "历史查询界面";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_query)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_query;
        private System.Windows.Forms.DateTimePicker dtp_Query;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}