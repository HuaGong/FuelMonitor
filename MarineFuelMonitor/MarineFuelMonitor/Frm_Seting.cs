using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace MarineFuelMonitor
{
    public partial class Frm_Seting : Form
    {
        public Frm_Seting()
        {
            InitializeComponent();
        }

        private void btn_QuitClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_SetingLoad(object sender, EventArgs e)
        {
            this.TB_RDSConnString.Text = UserSetings.Default.RDSConnString;
            this.TB_PLCIP.Text = UserSetings.Default.PLCConnIp;
            this.cmb_ComSelect.Text = UserSetings.Default.GPSPort;
            string[] str = System.IO.Ports.SerialPort.GetPortNames();
            this.tb_DeleteDay.Text = UserSetings.Default.DeleteDay;
            this.tb_ManagerTel.Text = UserSetings.Default.ManagerTel;
            this.tb_MarineName.Text= UserSetings.Default.MarineName;
            if (str != null)
            {
                foreach (string s in str)
                {
                    cmb_ComSelect.Items.Add(s);
                }
            }
            else
            {
                MessageBox.Show("没有发现串口");
            }
            cmb_ComSelect.Text = UserSetings.Default.GPSPort;
        }

        private void BTN_DBResave_Click(object sender, EventArgs e)
        {
            UserSetings.Default.RDSConnString = this.TB_RDSConnString.Text;
            UserSetings.Default.DeleteDay = this.tb_DeleteDay.Text;
            UserSetings.Default.Save();
        }

        private void BTN_PLCResave_Click(object sender, EventArgs e)
        {
            UserSetings.Default.PLCConnIp = this.TB_PLCIP.Text;
            UserSetings.Default.Save();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cmb_ComSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            UserSetings.Default.GPSPort = cmb_ComSelect.Text;
            UserSetings.Default.Save();
        }

        private void cmb_ComSelect_TextChanged(object sender, EventArgs e)
        {
           // UserSetings.Default.GPSPort = cmb_ComSelect.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("设置开机自启动，需要修改注册表", "提示");
            string path = Application.ExecutablePath;
            RegistryKey rk = Registry.LocalMachine;
            RegistryKey rk2 = rk.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run");
            rk2.SetValue("AutoStart", path);
            rk2.Close();
            rk.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("取消开机自启动，需要修改注册表", "提示");
            string path = Application.ExecutablePath;
            RegistryKey rk = Registry.LocalMachine;
            RegistryKey rk2 = rk.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run");
            rk2.DeleteValue("AutoStart", false);
            rk2.Close();
            rk.Close();
        }

        private void ManagerTelChanged(object sender, EventArgs e)
        {
            UserSetings.Default.ManagerTel = "13952850491,"+ this.tb_ManagerTel.Text;
            UserSetings.Default.Save();
        }

        private void MarineNameChanged(object sender, EventArgs e)
        {
            UserSetings.Default.MarineName = this.tb_MarineName.Text;
            UserSetings.Default.Save();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
