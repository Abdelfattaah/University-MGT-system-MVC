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
    public partial class CHek_bus_subscribe : Form
    {
        public CHek_bus_subscribe()
        {
            InitializeComponent();
        }

        private void CHek_bus_subscribe_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            BUss1 f3 = new BUss1();
            f3.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uni1.Chek_Bus we=new uni1.Chek_Bus();
            we.chek(textBox1.Text);
        }
    }
}
