using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using System.Data;
using MySql.Data.MySqlClient;
namespace uni1
{
    class login
    {
            public string username;
            public string password;
        string u;
        string p;
        public void get(string username,string password)
        {
            u = username;
            p = password;
        }
        int i = 0;
        public void chek(int i)
        {
            string MySqlConnString = @"server=localhost; user id=root; password=;database=universty";
            MySqlConnection dbconnection = new MySqlConnection(MySqlConnString);
            try
            {
                dbconnection.Open();
                //   MessageBox.Show("Connection Open ! ");
            }
            catch (Exception ex)
            {
                     MessageBox.Show("Can not open connection ! ");
            }
            using (var conn=new MySqlConnection(MySqlConnString))
            {
                Form1 f = new Form1();
                
                using(var cmd=new MySqlCommand("SELECT * FROM login",dbconnection))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        int l = 0;
                        while(reader.Read())
                        {
                            
                            var user = reader.GetString(l);
                            var pass = reader.GetString(1);
                           // MessageBox.Show("" + user);
                           // MessageBox.Show(""+user);
                        if(u==user&&p==pass)
                          {
                                username = "ok";
                              //  MessageBox.Show("c");
                                i = 8;
                                return ;
                          }
                        
                        }
                    }
                }
            }

        }
    }
}
