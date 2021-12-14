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
   public class stafflist
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

        public void set()
        {
            string MySqlConnString = @"server=localhost; user id=root; password=;database=universty";
            MySqlConnection dbconnection = new MySqlConnection(MySqlConnString);
            try
            {
                dbconnection.Open();
                //  MessageBox.Show("Connection Open ! ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open conne-ction ! ");
            }
            using (var conn = new MySqlConnection(MySqlConnString))
            {
                using (var cmd = new MySqlCommand("SELECT * FROM `employee` WHERE ID=3 ", dbconnection))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        int l = 0;
                        while (reader.Read())
                        {
                            var ID = reader.GetString(l);
                            var user = reader.GetString(1);
                            id = ID;
                            use = user;
                        }


                    }
                }
            }

        }
    }
}
