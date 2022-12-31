using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_Paire_npair
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int N = int.Parse(textBox1.Text);
            string MSG;
            double div = N % 2;
            if(div == 0)
            {
                MSG = $"ce nombre : {textBox1.Text} est pair ";
            }
            else
            {
                MSG = $"ce nombre : {textBox1.Text} est inpair ";
            }
            lbl_Resultats.Text = MSG ;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Resultats_Click(object sender, EventArgs e)
        {

        }

        private void lbl_N1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
