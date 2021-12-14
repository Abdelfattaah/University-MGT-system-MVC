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
    class AddBook_Cont
    {
 

        public void set(string Book_name, string Book_category, DateTime Book_year, string Book_Auther, string Book_Describtion)
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

            string Query = "insert into universty.add_book(Book_name,Book_category,Book_year,Book_Auther,Book_Describtion) values('" + Book_name + "','" + Book_category + "','" + Book_year + "','" + Book_Auther + "','" + Book_Describtion + "')";
            MySqlCommand MyCommand2 = new MySqlCommand(Query, dbconnection);
            MySqlDataReader MyReader2;
            MyReader2 = MyCommand2.ExecuteReader();
            MessageBox.Show("Saved");
        }


    }
}
