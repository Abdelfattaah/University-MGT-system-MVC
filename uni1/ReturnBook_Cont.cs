using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace uni1
{
    class ReturnBook_Cont
    {
        public void set(string BookName)
        {
            string connectionString = @"server=localhost; user id=root; password=;database=universty";
            MySqlConnection connection = null;
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "DELETE FROM universty.borrow_book WHERE Book_Name='"+BookName+"';";
                MessageBox.Show("Done");
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
