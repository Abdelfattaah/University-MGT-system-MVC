using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace uni1
{

    public partial class Form1 : Form
    {
        public int a=0;
        
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (a == 0)
            {
                textBox1.Clear();
                textBox2.Clear();
                a = 22;
            }
         

        }
        private void button1_Click(object sender, EventArgs e)
        {
            //int i = 0;
            //uni1.login l = new uni1.login();
            //l.get(textBox1.Text, textBox2.Text);
            //
            //l.chek(i);
            //if (l.username == "ok")
            //{
                this.Hide();
                Form2 f2 = new Form2();
                f2.ShowDialog();
            //}
            //else
            //{
            //    MessageBox.Show("8lt");
            //    this.Refresh();
            //}
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
