using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1_affichier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_aff_Click(object sender, EventArgs e)
        {
           
            Lbl_aff.Text = "bonjour " + txt_Nom.Text + " " + txt_Prenom.Text + " ";
        }
    }
}
