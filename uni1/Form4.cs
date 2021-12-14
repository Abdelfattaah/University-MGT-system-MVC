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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            AddBook f3 = new AddBook();
            f3.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            VeiwBook f3 = new VeiwBook();
            f3.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Hide();
            Borrow_Book f3 = new Borrow_Book();
            f3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            this.Hide();
            ReturnBookcs f3 = new ReturnBookcs();
            f3.ShowDialog();
        }
    }
}
