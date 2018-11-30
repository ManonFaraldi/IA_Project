using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    class TestAffichageCode
    {
        /*
        //Dans SearchTree :

            //##################################################################### à enlever : mais garder pour l'instant pour vérifs ####################################################################
            //Ecrire la liste de tous les fermés à chaque ETAPE :
            //string afficheFermes = "";
            for (int i = 0; i<g.ListeFermes.Count(); i++)
            {
                afficheFermes += g.ListeFermes[i];
            }
    listesFermes_txtBox.Text = afficheFermes;
            //Ecrire la liste de tous les ouverts à chaque ETAPE :
            //string afficheOuverts = "";
            for (int i = 0; i<g.ListeOuverts.Count(); i++)
            {
                afficheOuverts += g.ListeOuverts[i];
            }
listesOuverts_txtBox.Text = afficheOuverts;

            //Ecrire la liste de tous les ouverts et les fermés à la FIN (après résolution du A*) : à enlever !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            string afficheFermesFinal = "";
            for (int i = 0; i<g.L_Fermes.Count; i++)
            {
                afficheFermesFinal += Convert.ToString(g.L_Fermes[i]);
            }
            listFermesFinal_txtBox.Text = afficheFermesFinal;
            string afficheOuvertsFinal = "";
            for (int i = 0; i<g.L_Ouverts.Count; i++)
            {
                afficheOuvertsFinal += Convert.ToString(g.L_Ouverts[i]);
            }
            listOuvertsFinal_txtBox.Text = afficheOuvertsFinal;
            //##################################################################### à enlever : mais garder pour l'instant pour vérifs ####################################################################
       
    */
    /*
        //Dans Dijkstra.cs :
        //Comparer la liste des fermés ou ouverts du user avec la liste correcte générée par le pgrm : ATTENTION, on suppose ici que le user rentre la liste dans le bon ordre, avec tous les bons caractères, sans problème d'espace, ... !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        public bool VérifListe(string[] listeOK, string listeUser, int numEtape)
        {
            bool correct = true;

            int i = 0;
            while ((i < listeOK.Length) && (i < listeUser.Length) && (correct == true))
            {
                if (listeUser[i] != listeOK[numEtape][i]) //OUT of range :!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                {
                    correct = false;
                }
                i++;
            }
            return correct;
        }*/


    }
}
