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
    public partial class Student_High_School_Information : Form
    {
        public Student_High_School_Information()
        {
            InitializeComponent();
            
        }
        
        public int id = 0;
        
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Contact_Information f3 = new Contact_Information();
            f3.ShowDialog();
        }
        public int cid;
        int xz;
        private void button1_Click(object sender, EventArgs e)
        {
            uni1.hightschool c = new uni1.hightschool();
            class2 c2 = new class2();
            
            
            MessageBox.Show("is" + xz.ToString() );
            c.set(comboBox3.Text,
            textBox12.Text,
         textBox11.Text,
            textBox7.Text,
            textBox9.Text,
           textBox8.Text,
           textBox2.Text,
           textBox15.Text,
          textBox5.Text,
             textBox4.Text,
              comboBox1.Text,
              textBox3.Text,
             textBox1.Text,id) ;
            this.Hide();
       
            Registered_Successfully f3 = new Registered_Successfully();
            f3.ShowDialog();
        }

        private void Student_High_School_Information_Load(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
