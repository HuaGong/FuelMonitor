using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Profile;
using Aliyun.Acs.Sms.Model.V20160927;

namespace MarineFuelMonitor
{
    public partial class Frm_Message : Form
    {
        public Frm_Message()
        {
            InitializeComponent();
        }

        private void Frm_Message_Load(object sender, EventArgs e)
        {
            lb_msgMarineName.Text = UserSetings.Default.MarineName;
            lb_msgTime.Text = DateTime.Now.ToString("T");
            lb_msgOilLevel.Text = Data.InputAI[7].ToString();
            lb_msgOilCapcity.Text = Data.InputAI[8].ToString();
            lb_msgOilWeight.Text = Data.InputAI[9].ToString();
            tb_msgOilNeed.Text = "0";

        }

        private void btn_messageSend(object sender, EventArgs e)
        {
            IClientProfile profile = DefaultProfile.GetProfile("cn-hangzhou", "LTAIwxpolVr3R9BF", "D8an0u8VEsLrsaR85h06DHtGl6PkvN");
            IAcsClient client = new DefaultAcsClient(profile);
            SingleSendSmsRequest request = new SingleSendSmsRequest();
            try
            {
                request.SignName = "华工测控";
                request.TemplateCode = "SMS_27430124";
                request.RecNum = UserSetings.Default.ManagerTel;
                request.ParamString = "{\"shipname\":\"" + lb_msgMarineName.Text + "\",\"time\":\"" + lb_msgTime.Text + "\",\"OilLevel\":\"" + lb_msgOilLevel.Text + "\",\"OilCapacity\":\"" + lb_msgOilCapcity.Text + "\",\"OilWeight\":\"" + lb_msgOilWeight.Text + "\",\"Oilneed\":\"" + tb_msgOilNeed.Text + "\"}";
                // request.ParamString = "{\"" + tb_ShipName.Text + "\"；\"" + tb_Time.Text + "\"；\"" + tb_OilLevel.Text + "\"；\"" + tb_OilCapacity.Text + "；" + tb_OilWeight.Text + "；" + tb_OilNeed.Text;
                SingleSendSmsResponse httpResponse = client.GetAcsResponse(request);
                this.Close();
            }
            catch (ServerException ex)
            {
                //ex.printStackTrace();
                MessageBox.Show(ex.ToString());
            }
            catch (ClientException ex)
            {
                MessageBox.Show(ex.ToString());
                //ex.printStackTrace();
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
