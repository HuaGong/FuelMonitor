using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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

        }

        private void BTN_DBResave_Click(object sender, EventArgs e)
        {
            UserSetings.Default.RDSConnString = this.TB_RDSConnString.Text;
            UserSetings.Default.Save();
        }

        private void BTN_PLCResave_Click(object sender, EventArgs e)
        {
            UserSetings.Default.PLCConnIp = this.TB_PLCIP.Text;
            UserSetings.Default.Save();
        }
    }
}
