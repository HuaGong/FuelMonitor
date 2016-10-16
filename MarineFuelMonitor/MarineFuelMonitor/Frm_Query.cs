using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MarineFuelMonitor
{
    public partial class Frm_Query : Form
    {
        MySqlConnection conn;
        public Frm_Query()
        {
            InitializeComponent();
           dtp_Query.Format = DateTimePickerFormat.Custom;
           dtp_Query.CustomFormat = "yyyy-MM-dd"; 
            //Data.conn = string.Format("Server=localhost;uid=root;pwd=ihmc;Database=marinefueldb;CharSet=utf8;port=3306");
         /*  dgv_query.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
           dgv_query.Columns[0].HeaderCell.Value = "编号";
           dgv_query.Columns[1].HeaderCell.Value = "开始时间";
           dgv_query.Columns[2].HeaderCell.Value = "结束时间";
           dgv_query.Columns[3].HeaderCell.Value = "操作员";
           dgv_query.Columns[4].HeaderCell.Value = "工况";
           dgv_query.Columns[5].HeaderCell.Value = "主机编号";
           dgv_query.Columns[6].HeaderCell.Value = "航行里程";
           dgv_query.Columns[7].HeaderCell.Value = "编号油耗合计";
          * */

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt1;
            dt1= dtp_Query.Value;
            conn = new MySqlConnection(Data.conn);
            MySqlCommand readdatabase = new MySqlCommand();
            readdatabase.Connection = conn;

            readdatabase.CommandText = "SELECT revsubdata.ID,revsubdata.BeginTime,revsubdata.EndTime,seaman.`Name`,operatmode.`Name`,revsubdata.MENumber,revsubdata.AveFuel,revsubdata.SubTotal FROM revsubdata ,operatmode,seaman WHERE revsubdata.`Mode`=operatmode.ID and revsubdata.Operator=seaman.ID  and DATE_FORMAT(BeginTime,'%Y-%m-%d') = '" + dt1.ToString("yyyy-MM-dd")+"'";
            readdatabase.CommandType = CommandType.Text;

            
            MySqlDataAdapter sda = new MySqlDataAdapter();
            sda.SelectCommand = readdatabase;
            DataSet ds = new DataSet();
            sda.Fill(ds, "t1");
            dgv_query.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
