using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
namespace uni1
{
    public partial class Form3 : Form
    {
        public int flag = 0;
        public Form3()
        {
            InitializeComponent();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
                }
            }
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            int x = 1;
            
            uni1.class2 c = new uni1.class2();
            if (x == 1)
            {
                c.get(textBox10.Text,
                textBox1.Text,
             textBox2.Text,
                comboBox11.Text,
                comboBox9.Text,
               dateTimePicker1.Value,
               comboBox1.Text,
               comboBox2.Text,
              comboBox3.Text,
                 comboBox4.Text,
                textBox7.Text,
                  textBox6.Text,
                  comboBox12.Text,
                 comboBox10.Text,
                comboBox5.Text,
               comboBox6.Text,
              comboBox7.Text,
                 comboBox8.Text);
                c.set(textBox10.Text,
                textBox1.Text,
             textBox2.Text,
                comboBox11.Text,
                comboBox9.Text,
               dateTimePicker1.Value,
               comboBox1.Text,
               comboBox2.Text,
              comboBox3.Text,
                 comboBox4.Text,
              textBox7.Text,
               textBox6.Text,
                  comboBox12.Text,
                 comboBox10.Text,
                comboBox5.Text,
               comboBox6.Text,
              comboBox7.Text,
                 comboBox8.Text, ref flag);
                if (flag == 0)
                {

                    this.Hide();
                    Student_High_School_Information f3 = new Student_High_School_Information();
                   // f3.ID(Id);
                    f3.ShowDialog();
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_ContextMenuStripChanged(object sender, EventArgs e)
        {

        }
    }
}
