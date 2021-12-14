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
    class application
    {
        public string Applicant_Full_Name_English;
        public string employeApplicant_Name_Arabicname;
        public string Applicant_Mother_Name;
        public string Gender;
        public string Diploma_Country;
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
        public string Section;
        public string Percentage;
        public string year;
        public string    School_Name;
        public string Seatting_NO;

        public string q, w, e, r, t, y;
        public string aaa, bbb, ccc, ddd, eee, fff;
        public void get()
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
                Form1 f = new Form1();

                using (var cmd = new MySqlCommand("SELECT * FROM selsem", dbconnection))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        int l = 0;
                        while (reader.Read())
                        {
                            
                            var a = reader.GetString(1);
                            var b = reader.GetString(2);
                            var d = reader.GetString(14);
                            var e = reader.GetString(15);
                            var ff = reader.GetString(16);
                            var g = reader.GetString(17);
                            q=a;
                            w = b;
                            e = d;
                            r = e;
                            t = ff;
                            y = g;
                         //   MessageBox.Show("" + aaa);
                          
                            
                        }
                    }
                }
                using (var cmd = new MySqlCommand("SELECT * FROM student_hightschool", dbconnection))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                             var a = reader.GetString(1);
                            var b    = reader.GetString(8);
                            var ff = reader.GetString(3);
                        //    var c = reader.GetString(4);
                            var e = reader.GetString(7);
                            var d = reader.GetString(6);
                            aaa = a;
                            bbb = b;
                           // ccc = d;
                            ddd = e;
                            eee = ff;
                        
                            //   MessageBox.Show("" + aaa);


                        }
                    }
                }
            }

        }
    }
}
