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
    public partial class VeiwBook : Form
    {
        public VeiwBook()
        {
            InitializeComponent();
        }

        private void VeiwBook_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f3 = new Form4();
            f3.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewBook_Cont Vc = new ViewBook_Cont();
            Vc.set(textBox1.Text);
            textBox3.Text = Vc.name;
            comboBox1.Text = Vc.aa;
            textBox6.Text = Vc.bb;
            textBox2.Text = Vc.ee;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
