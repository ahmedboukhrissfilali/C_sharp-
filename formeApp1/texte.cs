using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace formeApp1
{
    public partial class texte : Form
    {
        string myfichier = Application.StartupPath + @"\myfichier.txt";
        public texte()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllText(myfichier, textBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetType().Name);
               
            }
        }

        private void texte_Load(object sender, EventArgs e)
        {
            if (File.Exists(myfichier))
            {

                textBox1.Text = File.ReadAllText(myfichier);

            }
            else
            {
                File.Create(myfichier);
            }
        }
    }
}
