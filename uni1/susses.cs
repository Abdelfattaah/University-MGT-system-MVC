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
    public class susses
    {

         public string id;
      public  string use;


        public void get()
        {

        }

        public void set()
        {
            string MySqlConnString = @"server=localhost; user id=root; password=;database=universty";
            MySqlConnection dbconnection = new MySqlConnection(MySqlConnString);
            try
            {
                dbconnection.Open();
              //  MessageBox.Show("Connection Open ! ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open conne-ction ! ");
            }
            using (var conn = new MySqlConnection(MySqlConnString))
            {
                using (var cmd = new MySqlCommand("SELECT * FROM selsem", dbconnection))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        int l = 0;
                        while (reader.Read())
                        {
                            var ID = reader.GetString(l);
                            var user = reader.GetString(1);
                            id = ID;
                            use = user;
                        }

                       
                    }
                }
            }
            
        }
    }
}

