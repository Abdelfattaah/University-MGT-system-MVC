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
    public partial class Bus_Subscrebtion : Form
    {
        public Bus_Subscrebtion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uni1.bus_sub s = new uni1.bus_sub();
            s.set(textBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
