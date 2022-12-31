using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace formeApp1
{
    public partial class etudiant : Form
    {
        string myfile = Application.StartupPath + @"\etudiant.json";
        private Etudian1 ed;
        List<Etudian1> tabEt = new List<Etudian1>();
        private char sx;
         
        public etudiant()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {
            
            try

            {
                ed = new Etudian1(Cnetxt.Text, Nomtext.Text, CheKSex());tabEt.Add(ed);
                SerializData();
                tabEt.Add(ed);
                listBox1.Items.Add(ed.aff());


            }
            catch {

            };


        }
        public char CheKSex()
        {
            if (radioButton1.Checked)
            {
                sx = Convert.ToChar(radioButton1.Text);

            }
            else
            {
                sx = Convert.ToChar(radioButton1.Text);
            }
            return sx;
        }   
        public void SerializData()
        {
            if(File.Exists(myfile)) 
            {
                string MyJson = JsonConvert.SerializeObject(tabEt);
                File.WriteAllText(myfile, MyJson);
            }
            else
            {
                File.Create(myfile);
                MessageBox.Show("le fichier est untrouvable");
            }

        }
    }
}
