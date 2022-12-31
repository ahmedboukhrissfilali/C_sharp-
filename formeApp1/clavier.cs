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
    public partial class clavier : Form
    {
        public clavier()
        {
            InitializeComponent();


        }
        private void saisie(Button c)
        {
            textBox1.Text += c.Text;
        }

        private void A_Click(object sender, EventArgs e)
        {
            saisie(A);
        }

        private void Z_Click(object sender, EventArgs e)
        {
            saisie(Z);
        }

        private void E_Click(object sender, EventArgs e)
        {
            saisie(E);
        }

        private void R_Click(object sender, EventArgs e)
        {
            saisie(R);
        }

        private void T_Click(object sender, EventArgs e)
        {
            saisie(T);
        }

        private void Y_Click(object sender, EventArgs e)
        {
            saisie(Y);
        }

        private void U_Click(object sender, EventArgs e)
        {
            saisie(U);
        }

        private void I_Click(object sender, EventArgs e)
        {
            saisie(I);
        }

        private void O_Click(object sender, EventArgs e)
        {
            saisie(O);
        }

        private void P_Click(object sender, EventArgs e)
        {
            saisie(P);
        }

        private void espace_Click(object sender, EventArgs e)
        {

            saisie(espace);
        }

        private void clavier_Load(object sender, EventArgs e)
        {

        }

        private void en_Click(object sender, EventArgs e)
        {
            Button b = new Button();
            b.Text = Environment.NewLine;
            saisie(b);
        }
        int comteur = 0;
        private void bloq_Click(object sender, EventArgs e)
        {
            comteur++;

            {

            }
            if (comteur % 2 == 0)
            {
                MAJ();

            }
            else
            {
                MIN();
            }
        }
        public void MAJ()
        {
            Button[] tab = new Button[] { A, Z, E,R,T,Y,U,I,O,P };
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i].Text = tab[i].Text.ToLower();
            }
        }
        public void MIN()
        {
            Button[] tab = new Button[] { A, Z, E, R, T, Y, U, I, O, P };
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i].Text = tab[i].Text.ToUpper();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar=='A' || e.KeyChar=='a')
            {
                A.BackColor = Color.Red;
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.A)
            {
                A.BackColor = Color.Gray;
            }
        }
    }
}
