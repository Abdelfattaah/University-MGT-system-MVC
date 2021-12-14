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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }  
        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            
            f3.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Student_list f3 = new Student_list();
            f3.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee_Form1 f3 = new Employee_Form1();
            f3.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            this.Hide();
            StaffList f3 = new StaffList();
            f3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            this.Hide();
            EnglishTest1 f3 = new EnglishTest1();
            f3.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form4 f3 = new Form4();
            f3.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            BUss1 f3 = new BUss1();
            f3.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateSch f3 = new CreateSch();
            f3.ShowDialog();
        }
    }
}
