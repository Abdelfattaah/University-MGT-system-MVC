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
    public partial class EnglishTest1 : Form
    {
        public string i, n;
        public EnglishTest1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void EnglishTest1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            n = textBox1.Text;
            i = textBox2.Text;
            this.Hide();
           
            EnglishTest2 f3 = new EnglishTest2();
            f3.ee(i, n);  
            f3.ShowDialog();
        }
    }
}
