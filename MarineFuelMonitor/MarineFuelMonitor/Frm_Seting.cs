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
    }
}
