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
    public class emplis
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

        public void set(int iid)
        {
           // MessageBox.Show("" + iid);
            string MySqlConnString = @"server=localhost; user id=root; password=;database=universty";
            MySqlConnection dbconnection = new MySqlConnection(MySqlConnString);
            try
            {

                dbconnection.Open();
                //MessageBox.Show("Connection Open ! ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open conne-ction ! ");
            }
            using (var conn = new MySqlConnection(MySqlConnString))
            {
                string Query = "SELECT * FROM `employee` WHERE ID= '" + iid + "';";
                using (var cmd = new MySqlCommand(Query, dbconnection))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                       // MessageBox.Show("" + iid);
                        int l = 0;
                        uni1.StaffList s = new uni1.StaffList();
                        while (reader.Read())
                        {
                            Applicant_Full_Name_English = reader.GetString(1);
                            employeApplicant_Name_Arabicname = reader.GetString(2);
                            Applicant_Mother_Name = reader.GetString(3);
                            Gender = reader.GetString(4);
                            Religion = reader.GetString(5);
                            //date= reader.GetString(6);
                            Nationality = reader.GetString(7);

                            Other_Nationality = reader.GetString(8);
                            Country_OF_Birth = reader.GetString(9);
                            Country_of_residence = reader.GetString(10);
                            Identification_number = reader.GetString(11);
                            Passport_Number = reader.GetString(12);
                            Disability = reader.GetString(13);
                            Type_OF_work = reader.GetString(14);
                            CV = reader.GetString(15);
                            //var user = reader.GetString(1);
                        }


                    }
                }
            }

        }
        public void deleat(int iid)
        {
            string connectionString = @"server=localhost; user id=root; password=;database=universty";
            MySqlConnection connection = null;
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "delete from employee WHERE ID='" + iid + "';";
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (connection != null)
             
                  connection.Close();
            }
        }

        public void Update(int iid, string texbox)
        {
            string connectionString = @"server=localhost; user id=root; password=;database=universty";
            MySqlConnection connection = null;
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "UPDATE employee SET Applicant_Full_Name_English ='"+texbox+"' WHERE ID='" + iid + "';";
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
