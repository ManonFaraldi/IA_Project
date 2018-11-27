using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donnees
{
    [Serializable()]
    public class Utilisateur
    {
        //propriété
        public string Nom { get; set; } 
        public string Prenom { get; set; }
        public double Note { get; set; }

        //constructeur
        
        public Utilisateur()
        {
        }

        public Utilisateur (string n, string p)
        {
            Nom = n;
            Prenom = p;
        }

        public Utilisateur(string n, string p, int note)
        {
            Nom = n;
            Prenom = p;
            Note = note;
        }

        //methodes
        public override string ToString()
        {
            return this.Nom + "\n\n" + this.Prenom + "\n\n" + this.Note ; 
        }
    }
}
