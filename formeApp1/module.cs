using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formeApp1
{
    public partial class module : Form

    {
        string myfile = Application.StartupPath + @"etudiant.json";
        private etudiant ed;
        List<etudiant> tabEt = new List<etudiant>();
        private char sx;
        public module()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ed new = etudiant(textBox1.text,)
            }
            
        }
    }
}
