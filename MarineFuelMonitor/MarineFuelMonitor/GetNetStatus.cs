using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Net.NetworkInformation;

namespace GetNetStatus
{
    public class GetInternetConStatus
    {
        private const int INTERNET_CONNECTION_MODEM = 1;
        private const int INTERNET_CONNECTION_LAN = 2;
        [DllImport("winInet.dll")]
        private static extern bool InternetGetConnectedState(
        ref   int dwFlag,
        int dwReserved
        );

        /// <summary>
        /// 判断网络的连接状态
        /// </summary>
        /// <returns>
        /// 网络状态(1-->未联网;2-->采用调治解调器上网;3-->采用网卡上网)
        ///</returns>
        public static int GetNetConStatus(string strNetAddress)
        {
            int iNetStatus = 0;
            System.Int32 dwFlag = new int();
            if (!InternetGetConnectedState(ref dwFlag, 0))
            {  
                //没有能连上互联网
                iNetStatus = 1;
            }
            else if ((dwFlag & INTERNET_CONNECTION_MODEM) != 0)
            {
                //采用调治解调器上网,需要进一步判断能否登录具体网站
                if (PingNetAddress(strNetAddress))
                {
                    //可以ping通给定的网址,网络OK
                    iNetStatus = 2;
                }
                else
                {
                    //不可以ping通给定的网址,网络不OK
                    iNetStatus = 4;
                }
            }
            
            else if ((dwFlag & INTERNET_CONNECTION_LAN) != 0)
            {
                //采用网卡上网,需要进一步判断能否登录具体网站
                if (PingNetAddress(strNetAddress))
                {
                    //可以ping通给定的网址,网络OK
                    iNetStatus = 3;
                }
                else
                {
                    //不可以ping通给定的网址,网络不OK
                    iNetStatus = 5;
                }
            }

            return iNetStatus;
        }

        /// <summary>
        /// ping 具体的网址看能否ping通
        /// </summary>
        /// <param name="strNetAdd"></param>
        /// <returns></returns>
        private static bool PingNetAddress(string strNetAdd)
        {
            bool Flage = false;
            Ping ping = new Ping();
            try
            {
                PingReply pr = ping.Send(strNetAdd, 3000);
                if (pr.Status == IPStatus.TimedOut)
                {
                    Flage = false;
                }
                if (pr.Status == IPStatus.Success)
                {
                    Flage = true;
                }
                else
                {
                    Flage = false;
                }
            }
            catch
            {
                Flage = false;
            }
            return Flage;
        }

    }
}
//判断方法
/*
 private void btnJudge_Click(object sender, EventArgs e)
        {
            int iNetStatus = GetInternetConStatus.GetNetConStatus("baidu.com");
            if (iNetStatus == 1)
            {
                lblNetStatus.Text = "网络未连接";
            }
            else if(iNetStatus==2)
            {
                lblNetStatus.Text = "采用调治解调器上网";
            }
            else if (iNetStatus == 3)
            {
                lblNetStatus.Text = "采用网卡上网";
            }
            else if (iNetStatus == 4)
            {
                lblNetStatus.Text = "采用调治解调器上网,但是联不通指定网络";
            }
            else if (iNetStatus == 5)
            {
                lblNetStatus.Text = "采用网卡上网,但是联不通指定网络";
            }
        }
*/