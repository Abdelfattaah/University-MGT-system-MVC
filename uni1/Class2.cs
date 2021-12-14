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
    public class class2
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
        public string Starting_Semester;
        public string Choose_your_faculty;
        public string Second_Choice;
        public string Third_Choice;
        public string fourth_Choice;
        public int ID_Student;
        public void get(string Applicant_Full_Name_English,
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
           string Starting_Semester,
           string Choose_your_faculty,
           string Second_Choice,
           string Third_Choice,
           string fourth_Choice)
        {

        }

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
         string Starting_Semester,
         string Choose_your_faculty,
         string Second_Choice,
         string Third_Choice,
         string fourth_Choice, ref int f)
        {
             

            //Identification_number.Length != 14 || Passport_Number.Length != 14 || Applicant_Full_Name_English == "" || Applicant_Mother_Name == "" || employeApplicant_Name_Arabicname == "" || Gender == "" || Religion == "" || Nationality == "" || Other_Nationality == "" || Country_OF_Birth == "" || Country_of_residence == "" || Disability == "" || Starting_Semester == "" || Choose_your_faculty == "" || Second_Choice == "" || Third_Choice == "" || fourth_Choice == "")
            int x = 1;
            if (x == 0)
            {
                MessageBox.Show("Please compleat the information");
                f = 1;
            }
            else
            {
                //if(Int64.Parse(Identification_number) < 0 || Int64.Parse(Passport_Number) < 0)
                //{
                //    MessageBox.Show("pleas enter the correct Identification Number or Passport Number");
                //    f = 1;
                //}
                if (f == 0)
                {
                    string MySqlConnString = @"server=localhost; user id=root; password=;database=universty";
                    MySqlConnection dbconnection = new MySqlConnection(MySqlConnString);
                    try
                    {
                        dbconnection.Open();
                        //MessageBox.Show("Connection Open !");
                        //dbconnection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Can not open connection ! ");
                    }
                    string Query = "insert into universty.selsem(ID,Applicant_Full_Name_English,employeApplicant_Name_Arabicname,Applicant_Mother_Name,Nationality,Other_Nationality,Gender,Religion,date,Country_of_residence,Identification_number,Passport_Number,Disability,Starting_Semester,Choose_your_faculty,Second_Choice,Third_Choice,fourth_Choice) values('" + "','" + Applicant_Full_Name_English + "','" + employeApplicant_Name_Arabicname + "','" + Applicant_Mother_Name + "','" + Nationality + "','" + Other_Nationality + "','" + Gender + "','" + Religion + "','" + date + "','" + Country_of_residence + "','" + Identification_number + "','" + Passport_Number + "','" + Disability + "','" + Starting_Semester + "','" + Choose_your_faculty + "','" + Second_Choice + "','" + Third_Choice + "','" + fourth_Choice + "');";
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, dbconnection);
                    MySqlDataReader MyReader2;
                    MyReader2 = MyCommand2.ExecuteReader();
                    MessageBox.Show("Save Data");
                    MyReader2.Close();
                    dbconnection.Close();
                    //Query = "SELECT ID FROM selsem WHERE Applicant_Full_Name_English='" + Applicant_Full_Name_English + "';";

                    //string MySqlConnStringg = @"server=localhost; user id=root; password=;database=universty";
                    //MySqlConnection dbconnectionn = new MySqlConnection(MySqlConnString);
                    //try
                    //{
                    //    dbconnectionn.Open();
                    //    //   MessageBox.Show("Connection Open ! ");
                    //}
                    //catch (Exception ex)
                    //{
                    //    MessageBox.Show("Can not open connection ! ");
                    //}
                    //using (var conn = new MySqlConnection(MySqlConnStringg))
                    //{
                    //    using (var cmd = new MySqlCommand("SELECT ID From selsem WHERE Applicant_Full_Name_English='" + Applicant_Full_Name_English + "'", dbconnectionn))
                    //    {
                    //        using (var reader = cmd.ExecuteReader())
                    //        {
                    //
                    //            while (reader.Read())
                    //            {
                    //                var asd = reader.GetInt16(0);
                    //                ID_Student = asd;
                    //                MessageBox.Show(ID_Student.ToString());
                    //                //Student_High_School_Information SHI = new Student_High_School_Information();
                    //                //SHI.Set_ID( ID_Student);
                    //            }
                    //        }
                    //    }
                    //    dbconnectionn.Close();
                    //}
               
                }
            }
        
            
        }
        
    }
}