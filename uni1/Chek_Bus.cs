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
    class Chek_Bus
    {
        public void chek(string ID)
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
            using (var conn = new MySqlConnection(MySqlConnString))
            {
                using (var cmd = new MySqlCommand("SELECT * FROM selsem WHERE ID = '" + ID + "'", dbconnection))
                {
                    using (var reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            var a = reader.GetString(18);

                            if(a=="1")
                            {
                                MessageBox.Show("yes");

                            }
                            else
                            {
                                MessageBox.Show("No");
                            }

                        }

                    }
                }
            }

        }
    }
}
