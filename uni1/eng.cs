using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace uni1
{
    public class eng
    {
        public string IDD;
        public string fuull_name;
        public string text;
        public void set(string ID,string full_name,string text)
        {
            int big = 0;
            string MySqlConnString = @"server=localhost; user id=root; password=;database=universty";
            MySqlConnection dbconnection = new MySqlConnection(MySqlConnString);
            try
            {
                dbconnection.Open();
                //  MessageBox.Show("Connection Open ! ");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
            using (var cmd = new MySqlCommand("SELECT * FROM selsem", dbconnection))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    int l = 0;
                    while (reader.Read())
                    {

                        var name = reader.GetString(1);
                        

                        if (name == full_name)
                        {
                         
                            big = 22;

                        }

                    }
                }
            }
            if (big == 22)
            {

                //********************************
                // wensh w = new wensh();

                uni1.EnglishTest1 eng = new uni1.EnglishTest1();
                uni1.eng engl = new uni1.eng();

                string Query = "insert into universty.english_test(ID ,full_name,text) values('" + ID + "','" + full_name + "','" + text + "');";
                MySqlCommand MyCommand2 = new MySqlCommand(Query, dbconnection);
                MySqlDataReader MyReader2;
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                                                            //MessageBox.Show("Save Data");
            }
            else
            {
                MessageBox.Show("student" + full_name+" not found");
            }
        }

        

    }
}


