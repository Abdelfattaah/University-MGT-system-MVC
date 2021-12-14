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
    public partial class BUss1 : Form
    {
        public BUss1()
        {
            InitializeComponent();
        }

        private void BUss1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Move(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add f3 = new Add();
            f3.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bus_Subscrebtion f3 = new Bus_Subscrebtion();
            f3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Edit_and_deleat_buscs f3 = new Edit_and_deleat_buscs();
            f3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            CHek_bus_subscribe f3 = new CHek_bus_subscribe();
            f3.ShowDialog();
        }
    }
}
