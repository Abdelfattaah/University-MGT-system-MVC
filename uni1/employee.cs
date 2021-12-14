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
    public class employee
    {
        public string Applicant_Full_Name_English;
        public string employeApplicant_Name_Arabicname;
        public string Applicant_Mother_Name;
        public string Gender;
        public string Religion;
        public DateTime date;
        public string Nationality;
        public string Other_Nationality;
        public string Country_OF_Birth;
        public string Country_of_residence;
        public string Identification_number;
        public string Passport_Number;
        public string Disability;
        public string Type_OF_work;
        public string CV;
     
        public void set(string Applicant_Full_Name_English,
         string employeApplicant_Name_Arabicname,
         string Applicant_Mother_Name,
         string Gender,
         string Religion,
         DateTime date,
         string Nationality,
         string Other_Nationality,
         string Country_OF_Birth,
         string Country_of_residence,
         string Identification_number,
         string Passport_Number,
         string Disability,
          string Type_OF_work,
            string CV)
        {
            // wensh w = new wensh();
            string MySqlConnString = @"server=localhost; user id=root; password=;database=universty";
            MySqlConnection dbconnection = new MySqlConnection(MySqlConnString);
            try
            {
                dbconnection.Open();
                MessageBox.Show("Connection Open ! ");
                //dbconnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
            string Query = "insert into universty.employee(Applicant_Full_Name_English,employeApplicant_Name_Arabicname,Applicant_Mother_Name,Gender,Religion,Date,Nationality,Other_Nationality,Country_OF_Birth,Country_of_residence,Identification_number,Passport_Number,Disability,typeowork,cv) values('" + Applicant_Full_Name_English + "','" + employeApplicant_Name_Arabicname + "','" + Applicant_Mother_Name + "','" + Gender + "','" + Religion + "','" + date + "','" + Nationality + "','" + Other_Nationality + "','" + Country_OF_Birth + "'," + "'" + Country_of_residence + "','" + Identification_number + "','" + Passport_Number + "','" + Disability + "','" + Type_OF_work + "','" + CV + "');";
            
            MySqlCommand MyCommand2 = new MySqlCommand(Query, dbconnection);
            MySqlDataReader MyReader2;
            MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
            if(Type_OF_work=="admin")
            {
                MyReader2.Close();
                Query = "insert into universty.login(username,password) values('" + Applicant_Full_Name_English + "','" + Identification_number + "'  )";
                MySqlCommand MyCommand = new MySqlCommand(Query, dbconnection);
                MyReader2 = MyCommand.ExecuteReader();     // Here our query will be executed and data saved into the database.  
            }

            MessageBox.Show("Save Data");
        }

    }
}


