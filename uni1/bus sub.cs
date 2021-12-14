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
    class bus_sub
    {
        public int Id;
        public void set(string ID)
        {
            string connectionString = @"server=localhost; user id=root; password=;database=universty";
            MySqlConnection connection = null;
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "UPDATE selsem SET bus ='1' WHERE ID='" + ID + "';";
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (connection != null)

                    connection.Close();
            }
        }
    }
}
