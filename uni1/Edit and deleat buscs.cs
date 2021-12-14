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
    public partial class Edit_and_deleat_buscs : Form
    {
        public Edit_and_deleat_buscs()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            uni1.edit_del_bus s = new uni1.edit_del_bus();
            s.update(textBox1.Text, textBox9.Text, textBox6.Text, textBox10.Text, textBox8.Text, textBox7.Text);

        }

        private void Edit_and_deleat_buscs_Load(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            uni1.edit_del_bus s = new uni1.edit_del_bus();
            s.serch(textBox1.Text);
            textBox9.Text = s.a;
            textBox6.Text = s.b;
            textBox10.Text = s.c;
            textBox8.Text = s.d;
            textBox7.Text = s.e;
          //  s.update(textBox1.Text,textBox9.Text, textBox6.Text, textBox10.Text, textBox8.Text, textBox7.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            uni1.edit_del_bus s = new uni1.edit_del_bus();
            s.del(textBox1.Text);
        }
    }
}
