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
    public partial class EnglishTest2 : Form
    {
        public EnglishTest2()
        {
            InitializeComponent();
        }
        string iid, nname;
            public void ee(string id,string name)
            {
                 iid = id;
                 nname = name;
            }
        private void button1_Click(object sender, EventArgs e)
        {
            uni1.EnglishTest1 eng= new uni1.EnglishTest1();
            uni1.eng engl = new uni1.eng();
            MessageBox.Show("" + nname);
            engl.set(iid, nname, textBox1.Text);
            
            this.Hide();
            Form2 f3 = new Form2();
            f3.ShowDialog();
        }
    }
}
