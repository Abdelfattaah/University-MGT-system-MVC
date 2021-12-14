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
    public partial class Student_list : Form
    {
        public Student_list()
        {
            InitializeComponent();
        }

        private void Student_list_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f3 = new Form2();
            f3.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
