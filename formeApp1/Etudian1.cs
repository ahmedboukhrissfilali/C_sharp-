using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formeApp1
{
    class Etudian1
    {
        private string cne, nom;
        private char sexe;

        public Etudian1(string cne, string nom,char sexe)
        {
            this.Cne = cne;
            this.Nom = nom;
            this.Sexe = sexe;
        }

        public string Cne { get => cne; set => cne = value; }
        public string Nom { get => nom; set => nom = value; }
        public char Sexe { get => sexe; set => sexe = value; }

     public string aff()
       {
            return String.Format("CNE {0} Nom {1} sexe {2} ",Cne,Nom,Sexe);
       }
    }
}
