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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_N1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_aff_Click(object sender, EventArgs e)
        {
            int N1 = int.Parse(txt_N1.Text);
            int N2 = int.Parse(Txt_N2.Text);
           int somme = N1 + N2;
            txt_Re.Text = somme.ToString();
        }

        private void txt_Re_TextChanged(object sender, EventArgs e)
        {
            txt_Re.Focus();
        }

        private void Txt_N2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lbl_aff_Click(object sender, EventArgs e)
        {

        }

        private void lbl_RESULTAT_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_Nombre2_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_Nombre1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
