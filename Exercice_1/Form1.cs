using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercice_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txt_Montant_Pay_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Calc_Click(object sender, EventArgs e)
        {  double RESULATS;
            double Msg;
            string Pourcentage;
            double N1 = double.Parse(txt_Saisir.Text);
            if (N1 < 1000)
            {
                Msg = 0;

            }
            else if (N1 < 3000)
            {
                Msg = 0.05;

            }
            else if (N1 < 4000)
            {
                Msg = 0.1;
            }
            else if (N1 < 5000)
            {
                Msg = 0.15;

            }
            else
            {
                Msg = 0.20;
            }
           Pourcentage= Msg*100 + "%";
           RESULATS = N1 - (N1 * Msg);
           txt_Taux_R.Text = Pourcentage.ToString();
            txt_Montant_Pay.Text = RESULATS.ToString();
        }
    }
}
