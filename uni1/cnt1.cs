using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace uni1
{
    public partial class cnt1 : uni1.Form3
    {
        public cnt1()
        {
            InitializeComponent();
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
        }
       
        public void cnt1_Load(object sender, EventArgs e)
        {
           
        }


        public class wensh
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
        }

    }
}
