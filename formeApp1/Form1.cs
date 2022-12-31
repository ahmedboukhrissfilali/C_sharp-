using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formeApp1
{
    public partial class mayForm : Form
    {
        public mayForm()
        {
            InitializeComponent();
        }

       

        private void mbutton_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            MessageBox.Show(str,"information",MessageBoxButtons.YesNo);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mbutton2_Click(object sender, EventArgs e)
        {
            mlabel.Text = textBox1.Text;
        }
    }
}
