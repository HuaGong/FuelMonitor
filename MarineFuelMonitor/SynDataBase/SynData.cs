using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;


namespace SynDataBase
{

    public class SynData
    {
        MySqlConnection ConnSrc, ConnTar;
       //设置两个数据库的连接字符串
        //String cmdInsert;
        public void setconn(string strSrc, string strTar)
        {
            ConnSrc = new MySqlConnection(strSrc);
            ConnTar = new MySqlConnection(strTar);

        }
        //打开两个数据的连接
        public void openconn()
        {
            try
            {
                ConnSrc.Open();
                ConnTar.Open();

            }
            catch
            {
            }
        }

        //同步两个数据库的数据
        public bool syn()
        { 
            //定义返回变量
            bool status;
            status = false;
            MySqlDataReader readerSrc;
            MySqlCommand cmdSrc ;
            MySqlDataReader readerTar;
            MySqlCommand cmdTar;
          //获取第一个数据库的最后时间
          
            //从数据库中读取数据流存入reader中  
            if (ConnSrc.State == ConnectionState.Closed)
            {
                try
                {
                    ConnSrc.Open();
                }
                catch
                { 
                }
            }
            if (ConnTar.State == ConnectionState.Closed)
            {
                try
                {
                    ConnTar.Open();
                }
                catch
                {
                }
            }
            
            DateTime LastTimeSrc = new DateTime();
            if (ConnTar.State == ConnectionState.Open)
            {
                cmdTar = ConnTar.CreateCommand();
                //创建查询语句  
                cmdTar.CommandText = "select MAX(`BeginTime`)  from `revsubdata` ";
                readerTar = cmdTar.ExecuteReader();
                if (readerTar.HasRows)
                {
                    while (readerTar.Read())
                    {
                        LastTimeSrc = readerTar.GetDateTime(0);
                    }
                    readerTar.Close();
                }
            }





            if (ConnTar.State == ConnectionState.Open && ConnSrc.State == ConnectionState.Open)
            {
                //获取所有大于第一个数据库最后时间的第二个数据库的10条数据条目
                cmdSrc = ConnSrc.CreateCommand();
                cmdSrc.CommandText = "select ID,BeginTime,EndTime,Mode,Operator,MENumber,AveFuel,SubTotal from `revsubdata` WHERE `BeginTime` >  str_to_date('" + LastTimeSrc.ToString("yyyy-MM-dd HH:mm:ss") + "','%Y-%m-%d %H:%i:%s')order by `BeginTime` ASC LIMIT 0,10;";
                readerSrc = cmdSrc.ExecuteReader();

                DateTime BeginTime;
                DateTime EndTime;
                int Mode;
                int Operator;
                int MENumber;
                float AveFuel;
                float SubTotal;

                while (readerSrc.Read())
                {
                    BeginTime = readerSrc.GetDateTime(readerSrc.GetOrdinal("BeginTime"));
                    EndTime = readerSrc.GetDateTime(readerSrc.GetOrdinal("EndTime"));
                    Mode = readerSrc.GetInt32(readerSrc.GetOrdinal("Mode"));
                    Operator = readerSrc.GetInt32(readerSrc.GetOrdinal("Operator"));
                    MENumber = readerSrc.GetInt32(readerSrc.GetOrdinal("MENumber"));
                    AveFuel = readerSrc.GetFloat(readerSrc.GetOrdinal("AveFuel"));
                    SubTotal = readerSrc.GetFloat(readerSrc.GetOrdinal("SubTotal"));

                    try
                    {

                        if (ConnTar.State == ConnectionState.Open)
                        {
                            MySqlCommand mycmd = new MySqlCommand("insert into revsubdata(BeginTime,EndTime,Mode,Operator,MENumber,AveFuel,SubTotal) values(STR_TO_DATE('"
                                                                                      + BeginTime + "','%Y-%m-%d %H:%i:%s'),STR_TO_DATE('"
                                                                                      + EndTime + "','%Y-%m-%d %H:%i:%s'),"
                                                                                      + Mode + ","
                                                                                      + Operator + ","
                                                                                      + MENumber + ","
                                                                                      + AveFuel + ","
                                                                                      + SubTotal + ")", ConnTar);



                            if (mycmd.ExecuteNonQuery() > 0)
                            {
                                Console.WriteLine("数据插入成功！");
                                status = true;

                            }
                        }
                    }
                    catch
                    {

                    }

                }
                if (readerSrc.IsClosed == false)
                { readerSrc.Close(); }
            }
            
          return status;
         
        }
    }
}
