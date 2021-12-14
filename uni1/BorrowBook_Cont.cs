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
    class BorrowBook_Cont
    {



        public void set(string Student_Name, string Student_ID, string Phone_Num, string Book_Name, DateTime Borrow_Date, DateTime Return_Date)
        {
            int big = 0;
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


            using (var cmd = new MySqlCommand("SELECT * FROM borrow_book", dbconnection))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    int l = 0;
                    while (reader.Read())
                    {

                        var name = reader.GetString(3);

                        if (name == Book_Name)
                        {
                            MessageBox.Show("book not found");
                            big = 22;

                        }

                    }
                }
            }
            //*****************************************************************************************************
            if (big == 0)
            {
                string Query = "insert into universty.borrow_book(Student_Name,Student_ID,Phone_Num,Book_Name,Borrow_Date,Return_Date) values('" + Student_Name + "','" + Student_ID + "','" + Phone_Num + "','" + Book_Name + "','" + Borrow_Date + "','" + Return_Date + "')";
                MySqlCommand MyCommand2 = new MySqlCommand(Query, dbconnection);
                MySqlDataReader MyReader2;
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Saved");
            }
        }


    }
}
