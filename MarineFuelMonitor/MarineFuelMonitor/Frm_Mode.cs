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
    public partial class Frm_Mode : Form
    {
        public Frm_Mode()
        {
            InitializeComponent();
        }

        private void btn_Mode_1_Clicked(object sender, EventArgs e)
        {
            Data.Mode_Selected = 1;
            this.Close();
        }

        private void btn_Mode_2_Clicked(object sender, EventArgs e)
        {
            Data.Mode_Selected = 2;
            this.Close();
        }

        private void btn_Mode_3_Clicked(object sender, EventArgs e)
        {
            Data.Mode_Selected = 3;
            this.Close();
        }

        private void btn_Mode_4_Clicked(object sender, EventArgs e)
        {
            Data.Mode_Selected = 4;
            this.Close();
        }

        private void btn_Mode_5_Clicked(object sender, EventArgs e)
        {
            Data.Mode_Selected = 5;
            this.Close();
        }

        private void btn_Mode_6_Clicked(object sender, EventArgs e)
        {
            Data.Mode_Selected = 6;
            this.Close();
        }
    }
}
