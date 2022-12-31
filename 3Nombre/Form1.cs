using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _3Nombre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_R_Click(object sender, EventArgs e)
        {
            double N1 = double.Parse(txt_N1.Text);
            double N2 = double.Parse(Txt_N2.Text);
            double N3 = double.Parse(txt_N3.Text);
            
           double Mx1 = Math.Max(N1, N2);
            double Mx2 = Math.Max(Mx1, N3);
            lbl_Max.Text = Mx2.ToString();
            double min0 = Math.Min(N1, N2);
            double min = Math.Min(min0, N3);

            lbl_min.Text = min.ToString();
          

            lbl_min.Text = min.ToString();  
            //soustraction 
            double Sous = N1- N2 - N3;
            lbl_sus.Text = Sous.ToString(); 
            //Somme//
            double Somme = N1 +N2+N3;
            lbl_somme.Text = Somme.ToString();
            //Mulltiplication
            double Mul = N1 * N2 * N3;
            lbl_Mul.Text = Mul.ToString();
            //Moyenne
            double Moy = (N1 + N2 + N3) / 3;
           
            lbl_Moyenne.Text = Moy.ToString();


        }
    }
}
