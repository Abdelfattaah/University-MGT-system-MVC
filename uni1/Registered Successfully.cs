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
    public partial class Registered_Successfully : Form
    {
        public Registered_Successfully()
        {
            InitializeComponent();
           
            //  MessageBox.Show("" + c.use);
        }

        private void label3_Click(object sender, EventArgs e)
        {
     

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            _ِApplication_Formcs f3 = new _ِApplication_Formcs();
          
            f3.ShowDialog();
        }
   
        private void label1_Click(object sender, EventArgs e)
        {
           
           
        }

        private void Registered_Successfully_Load(object sender, EventArgs e)
        {
            uni1.susses cy = new uni1.susses();
            cy.set();
            label1.Text = cy.use;
            label2.Text = cy.id;
        }
    }
}
