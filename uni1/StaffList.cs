using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uni1
{
    public partial class StaffList : Form
    {
        public StaffList()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form2 f3 = new Form2();
            f3.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uni1.emplis st = new uni1.emplis();
            int x = Convert.ToInt32(textBox1.Text);
            st.set(x);
          textBox10.Text=  st.Applicant_Full_Name_English;
            textBox5.Text = st.employeApplicant_Name_Arabicname;
            textBox2.Text = st.Applicant_Mother_Name;
            textBox9.Text = st.Gender;
            comboBox9.Text = st.Religion;
            comboBox1.Text = st.Nationality;
            comboBox2.Text = st.Other_Nationality;
            comboBox3.Text = st.Country_OF_Birth;
            comboBox4.Text = st.Country_of_residence;
            textBox7.Text = st.Identification_number;
            textBox6.Text = st.Passport_Number;
            comboBox5.Text = st.Type_OF_work;
        }

        private void StaffList_Load(object sender, EventArgs e)
        {
            uni1.emplis st = new uni1.emplis();
            
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            uni1.emplis st = new uni1.emplis();

            
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            uni1.emplis st = new uni1.emplis();
            int x = Convert.ToInt32(textBox1.Text);
            st.deleat(x);
            textBox10.Text ="";
            textBox5.Text = "";
            textBox2.Text = "";
            textBox9.Text = "";
            comboBox9.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            textBox7.Text = "";
            textBox6.Text = "";
            comboBox5.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            uni1.emplis st = new uni1.emplis();
            int x = Convert.ToInt32(textBox1.Text);
            st.Update(x,textBox10.Text);
        }
    }
}
