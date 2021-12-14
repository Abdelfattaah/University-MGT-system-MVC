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
    class AddBus_Cont
    {
        public string Bus_Number;
        public string Distnation;
        public string Capacity;
        public string Bus_Plate_Num;
        public string Driver_Phone_Num;
        public string Line;

        public void seet(string Bus_Number,string Distnation,string Capacity, string Bus_Plate_Num, string Driver_Phone_Num, string Line)
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

            string Query = "insert into universty.add_bus(Bus_Number,Distination,Capacity,Bus_Plate_No,Driver_Mobile_Number,Line) values('"+Bus_Number+"','"+Distnation+"','"+Capacity+"','"+Bus_Plate_Num+"','"+Driver_Phone_Num+"','"+Line+"')";
            MySqlCommand MyCommand2 = new MySqlCommand(Query, dbconnection);
            MySqlDataReader MyReader2;
            MyReader2 = MyCommand2.ExecuteReader();
            MessageBox.Show("Saved");
        }


    }                    

    
}
