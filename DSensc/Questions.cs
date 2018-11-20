using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Questions
    {
        //attributs
        public string enonce { get; set; }
        public string reponse1 { get; set; }
        public string reponse2 { get; set; }
        public string reponse3 { get; set; }
        public string reponse4 { get; set; }
        public int nbPoint { get; set;}
        public int reponseVraie { get; set; }
        public string image { get; set; }

        // constructeur

        public Questions()
        {
        }

        public Questions(string _enonce, string _rep1, string _rep2, string _rep3, string _rep4, int _pt, int _repVraie)
        {
            enonce = _enonce;
            reponse1 = _rep1;
            reponse2 = _rep2;
            reponse3 = _rep3;
            reponse4 = _rep4;
            nbPoint = _pt;
            reponseVraie = _repVraie;
        }

        public Questions(string _enonce, string _rep1, string _rep2, string _rep3, string _rep4, int _pt, int _repVraie, string _image)
        {
            enonce = _enonce;
            reponse1 = _rep1;
            reponse2 = _rep2;
            reponse3 = _rep3;
            reponse4 = _rep4;
            nbPoint = _pt;
            reponseVraie = _repVraie;
            image = _image;
         }

        public override string ToString()
        {
            return this.enonce + "\n\n" + this.reponse1 + "\n\n" + this.reponse2
                + "\n\n" + this.reponse3 + "\n\n" + this.reponse4 + "\n\n" + this.reponseVraie;
        }
    }
}
