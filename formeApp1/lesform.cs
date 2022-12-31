using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formeApp1
{
    public partial class lesform : Form
    {
        public lesform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            etudiant v = new etudiant();
            v.ShowDialog();
        }

    }
   public class Etudiant
    {
        private string cne,Name;
        private 

    }
}
