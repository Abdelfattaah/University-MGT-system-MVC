using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
namespace uni1
{
    class ViewBook_Cont
    {
        public string name;
       public string aa;
       public string bb;
     //  public DateTime cc ;
       public DateTime dd ;
       public string ee;
        public void set(string id)
        {

            string MySqlConnString = @"server=localhost; user id=root; password=;database=universty";
            MySqlConnection dbconnection = new MySqlConnection(MySqlConnString);
            try
            {
                dbconnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
            using (var conn = new MySqlConnection(MySqlConnString))
            {


                using (var cmd = new MySqlCommand("SELECT * FROM add_book WHERE Book_name = '" + id + "'", dbconnection))
                {
                    using (var reader = cmd.ExecuteReader())        
                    {

                        while (reader.Read())
                        {
                            var aaa = reader.GetString(1);
                            var a = reader.GetString(2);
                            var b = reader.GetString(4);
                      //    var d = reader.GetDateTime(3);
                            var e = reader.GetString(5);
                            name = aaa;
                            aa = a;
                            bb = b;
                           // cc = c;
                          //  dd = d;
                            ee = e;
                        }
                      


                    }
                }



            }

            

        }

      
    }
}
