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
    class edit_del_bus
    {
        public string a, b, c, d, e;
        public void serch(string ID)
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
                using (var cmd = new MySqlCommand("SELECT * FROM universty.add_bus WHERE Bus_Number = '" + ID + "'", dbconnection))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var dest= reader.GetString(2);
                            var cap = reader.GetString(3);                         
                            var platno = reader.GetString(4);
                            var de = reader.GetString(5);
                            var lest = reader.GetString(6);
                            a = dest;
                            b = cap;
                            c = platno;
                            d = de;
                            e = lest;
                            return;

                        }

                    }
                }
            }

        }
        public void update(string ID,string Dis,string cap,string bu,string dri,string line)
        {
            string connectionString = @"server=localhost; user id=root; password=;database=universty";
            MySqlConnection connection = null;
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "UPDATE universty.add_bus SET Distination = '"+ Dis+ "' , Capacity = '"+cap+ "' ,Bus_Plate_No ='"+ bu + "', Driver_Mobile_Number ='"+dri+ "' ,Line='"+line+"' WHERE Bus_Number='" + ID + "';";
                cmd.ExecuteNonQuery();
                
            }
            finally
            {
                if (connection != null)

                    connection.Close();
            }
        }

        public void del(string id)
        {
            string connectionString = @"server=localhost; user id=root; password=;database=universty";
            MySqlConnection connection = null;
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "DELETE FROM universty.add_bus WHERE Bus_Number='" + id + "';";
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

