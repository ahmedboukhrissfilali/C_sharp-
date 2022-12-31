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
    public partial class clacule : Form
    {
        public clacule()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bt1_Click(object sender, EventArgs e)
        {
            try
            {
                Double nb1 = Convert.ToDouble(textBox1.Text);
                Double nb2 = Convert.ToDouble(textBox2.Text);

                if (rdbp.Checked == true)
                {
                    label3.Text = (nb1 + nb2).ToString();
                }
                if (rdbmul.Checked == true)
                {
                    label3.Text = (nb1 * nb2).ToString();
                }

                if (rdbd.Checked == true)
                {
                    label3.Text = (nb1 / nb2).ToString();
                }
                if (rdbs.Checked == true)
                {
                    label3.Text = (nb1 - nb2).ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("entrer les valeurs obligatoire");
            }
            
        
        }
    }
}
