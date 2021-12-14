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
    public partial class ReturnBookcs : Form
    {
        public ReturnBookcs()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            ReturnBook_Cont Rc = new ReturnBook_Cont();
            Rc.set(textBox4.Text);

            Form4 f3 = new Form4();
            f3.ShowDialog();
        }

        private void ReturnBookcs_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
