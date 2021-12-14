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
    public class hightschool
    {
        public string Diploma;
        public string Diploma_Country;
        public string High_School_Graduation_Year;
        public string School_Name;
        public string School_Name_in_Arabic;
        public string Percentage;
        public string Seatting_NO;
        public string Section;
        public string Universty;
        public string Faculty;
        public string Country;
        public string No_of_Semesters_Attended;
        public string No_Of_Credits;

        public void get( string Diploma_Country,
         string High_School_Graduation_Year,
         string School_Name,
         string School_Name_in_Arabic,
         string Percentage,
         string Seatting_NO,
         string Section,
         string Universty,
         string Faculty,
         string Country,
         string No_of_Semesters_Attended,
         string No_Of_Credits)
        {

        }
        public void set(string Diploma,
            string Diploma_Country,
         string High_School_Graduation_Year,
         string School_Name,
         string School_Name_in_Arabic,
         string Percentage,
         string Seatting_NO,
         string Section,
         string Universty,
         string Faculty,
         string Country,
         string No_of_Semesters_Attended,
         string No_Of_Credits,int Student_ID)
        {
            string MySqlConnString = @"server=localhost; user id=root; password=;database=universty";
            MySqlConnection dbconnection = new MySqlConnection(MySqlConnString);
            try
            {
                dbconnection.Open();
          //      MessageBox.Show("Connection Open ! ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }

            MessageBox.Show(Student_ID.ToString());
            string Query = "insert into universty.student_hightschool(ID,Diploma_Country,High_School_Graduation_Year,School_Name,School_Name_in_Arabic,Percentage,Seatting_NO,Section,Universty,Faculty,Country,No_of_Semesters_Attended,No_Of_Credits) values('" +Student_ID+ "','" + Diploma_Country + "','" + High_School_Graduation_Year + "','" + School_Name + "','" + School_Name_in_Arabic + "','" + Percentage + "','" + Seatting_NO + "','" + Section + "','" + Universty + "','" + Faculty + "','" + Country + "','" + No_of_Semesters_Attended + "','" + No_Of_Credits + "');";
            MySqlCommand MyCommand2 = new MySqlCommand(Query, dbconnection);
            //MySqlDataReader MyReader2;
            //dbconnection.Open();
            MySqlDataReader MyReader2;
            MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
            dbconnection.Close();
        //  MessageBox.Show("Save Data");
        }
    }
}

