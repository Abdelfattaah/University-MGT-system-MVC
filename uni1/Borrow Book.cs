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
    public partial class Borrow_Book : Form
    {
        public Borrow_Book()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            BorrowBook_Cont Bc = new BorrowBook_Cont();
            Bc.set(textBox1.Text, textBox3.Text, textBox2.Text, textBox4.Text, dateTimePicker1.Value, dateTimePicker2.Value);
            
            Form4 f3 = new Form4();
            f3.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
