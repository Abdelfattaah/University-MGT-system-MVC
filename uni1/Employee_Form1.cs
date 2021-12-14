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
    public partial class Employee_Form1 : Form
    {
        public Employee_Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Employee_Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            uni1.employee l = new uni1.employee();
            l.set(textBox10.Text, textBox1.Text, textBox2.Text, textBox9.Text, comboBox9.Text, dateTimePicker1.Value, comboBox1.Text, comboBox2.Text, comboBox3.Text, comboBox4.Text, textBox7.Text, textBox6.Text, textBox11.Text, comboBox5.Text, textBox8.Text);
            this.Hide();
            Form2 f3 = new Form2();
            f3.ShowDialog();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
