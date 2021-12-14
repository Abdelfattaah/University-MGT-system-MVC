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
    public partial class _ِApplication_Formcs : Form
    {
        public _ِApplication_Formcs()
        {
            InitializeComponent();
            
        }
        
        private void _ِApplication_Formcs_Load(object sender, EventArgs e)
        {
            uni1.application ap = new uni1.application();
            ap.get();
            textBox5.Text = ap.q;
            textBox10.Text = ap.w;
            textBox6.Text = ap.e;
            textBox8.Text = ap.r;
            textBox7.Text = ap.t;
            textBox9.Text = ap.y;
            textBox32.Text = ap.aaa;
            textBox31.Text = ap.bbb;
            textBox28.Text = ap.ccc;
            textBox33.Text = ap.ddd;
            textBox30.Text = ap.eee;
            textBox27.Text = ap.fff;
        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void textBox33_TextChanged(object sender, EventArgs e)
        {

        }
        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f3 = new Form2();
            f3.ShowDialog();
        }
    }
}
