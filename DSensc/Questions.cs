using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public class Questions
    {
        //propriétés
        public string Enonce { get; set; }
        public string Reponse1 { get; set; }
        public string Reponse2 { get; set; }
        public string Reponse3 { get; set; }
        public string Reponse4 { get; set; }
        public int NbPoint { get; set;}
        public int ReponseVraie { get; set; }
        public string Image { get; set; }

        // constructeur

        public Questions()
        {
            Enonce = "Null";
            Reponse1 = "Null";
            Reponse2 = "Null";
            Reponse3 = "Null";
            Reponse4 = "Null";
            NbPoint = 0;
            ReponseVraie = 1;
            ReponseVraie = 1;
        }

        public Questions(string enonce, string rep1, string rep2, string rep3, string rep4, int pt, int repVraie)
        {
            Enonce = enonce;
            Reponse1 = rep1;
            Reponse2 = rep2;
            Reponse3 = rep3;
            Reponse4 = rep4;
            NbPoint = pt;
            ReponseVraie = repVraie;
        }

        public Questions(string enonce, string rep1, string rep2, string rep3, string rep4, int pt, int repVraie, string image) : this(enonce, rep1, rep2, rep3, rep4, pt, repVraie)
        {
            Image = image;
         }

        public override string ToString()
        {
            return this.Enonce + "\n\n" + this.Reponse1 + "\n\n" + this.Reponse2
                + "\n\n" + this.Reponse3 + "\n\n" + this.Reponse4 + "\n\n" + this.ReponseVraie;
        }

        public bool AvecImage()
        {
            if (Image == null) return false;
            return true;
        }

    }
}
