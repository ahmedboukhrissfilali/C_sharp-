using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_2_somme_de_deux_Nombre
{
    public partial class nombre_pair_ou_unpaire : Form
    {
        public nombre_pair_ou_unpaire()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int N = int.Parse(textBox1.Text);
            double DIv = N / 2;
            if (DIv == 2)
            {
                lbl_Resultats.Text = "ce Nombre est Pair";


            }
            else
            {
                lbl_Resultats.Text = "Ce Nombre est Unpaire";
            }
           

        }
    }
}
