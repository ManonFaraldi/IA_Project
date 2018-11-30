using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Donnees;
using System.IO;

namespace App
{
    public partial class Dijkstra : Form
    {

        static public double[,] matrice;
        static public int nbnodes = 10;
        static public int numinitial = 0;
        static public int numfinal = 6;
        protected int nbValider; //Le nb. de clics sur "Valider" correspond au nb. d'étapes où l'on doit écrire les ouverts et les fermés

        public Dijkstra()
        {
            InitializeComponent();

            // Initialisation de la matrice : à revoir selon la taille du graph (pour être générique) !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            matrice = new double[nbnodes, nbnodes];
            for (int k = 0; k < nbnodes; k++)
                for (int j = 0; j < nbnodes; j++)
                    matrice[k, j] = -1;
            // Remplissage de la matrice avec les poids de chaque arc (symétrique, car va de parent vers enfant et inversement quand on cherche le + court chemin !) : idem (voir si peut pas l'intégrer avec la partie suivante "Affichage des poids de chaque noeud"
            matrice[0, 1] = 3; matrice[1, 0] = 3;
            matrice[0, 2] = 5; matrice[2, 0] = 5;
            matrice[0, 3] = 7; matrice[3, 0] = 7;
            matrice[1, 4] = 8; matrice[4, 1] = 8;
            matrice[2, 4] = 3; matrice[4, 2] = 3;
            matrice[4, 5] = 7; matrice[5, 4] = 7;
            matrice[5, 6] = 4; matrice[6, 5] = 4;


            //Affichage des poids de chaque noeud :
            StreamReader monStreamReader = new StreamReader("..//..//..//Donnees//graphe1.txt"); //Grâce à System.IO
            // Lecture du fichier ("graph1.txt" dans le bin) avec un while, évidemment !
            // 1ère ligne : "nombre de noeuds du graphe
            string ligne = monStreamReader.ReadLine();
            int i = 0;
            while (ligne[i] != ':') i++;
            string strnbnoeuds = "";
            i++; // On dépasse le ":"
            while (ligne[i] == ' ') i++; // on saute les blancs éventuels
            while (i < ligne.Length)
            {
                strnbnoeuds = strnbnoeuds + ligne[i];
                i++;
            }
            nbnodes = Convert.ToInt32(strnbnoeuds);

            matrice = new double[nbnodes, nbnodes];
            for (i = 0; i < nbnodes; i++)
                for (int j = 0; j < nbnodes; j++)
                    matrice[i, j] = -1;
            // Ensuite on a la structure suivante : 
            //  arc : n°noeud départ  ->  n°noeud arrivée : valeur poids
            //  exemple 4 : 
            ligne = monStreamReader.ReadLine();
            while (ligne != null)
            {
                i = 0;
                while (ligne[i] != ':') i++;
                i++; // on passe le :
                while (ligne[i] == ' ') i++; // on saute les blancs éventuels
                string strN1 = "";
                while (ligne[i] != ' ')
                {
                    strN1 = strN1 + ligne[i];
                    i++;
                }
                int N1 = Convert.ToInt32(strN1);

                // On saute les blancs éventuels
                while (ligne[i] == ' ') i++;
                string strN2 = "";
                while (ligne[i] != ' ')
                {
                    strN2 = strN2 + ligne[i];
                    i++;
                }
                int N2 = Convert.ToInt32(strN2);

                // On saute les blancs éventuels
                while (ligne[i] == ' ') i++;
                string strVal = "";
                while ((i < ligne.Length) && (ligne[i] != ' '))
                {
                    strVal = strVal + ligne[i];
                    i++;
                }
                double val = Convert.ToDouble(strVal);

                matrice[N1, N2] = val;
                matrice[N2, N1] = val;
                listBoxgraphe.Items.Add(Convert.ToString(N1)
                   + "--->" + Convert.ToString(N2)
                   + "   : " + Convert.ToString(matrice[N1, N2]));

                ligne = monStreamReader.ReadLine();
            }
            // Fermeture du StreamReader (obligatoire) 
            monStreamReader.Close();

            //Cacher les boutons et lbl nécessaires :
            suivant_btn.Hide();
            treeViewFinal_btn.Hide();
            correctionFermes_lbl.Hide();
            correctionOuverts_lbl.Hide();
        }


        //Vérifie les fermés et ouverts de l'utilisateur et affiche correction si nécessaire
        private void valider_btn_Click(object sender, EventArgs e)
        {
            SearchTree g = new SearchTree();
            Node2 N0 = new Node2();
            N0.numero = numinitial;
            // Recherche du meilleur chemin à partir de ce noeud initial et final :
            List<GenericNode> solution = g.RechercheSolutionAEtoile(N0);

            string fermesUser = F_txtBox.Text;
            string ouvertsUser = O_txtBox.Text;
            bool correct;
            //Comparer la liste des fermés du user avec celui qui est correct :
            correct = VérifListe(g.ListeFermes, fermesUser, nbValider);
            if (correct == true)
            {
                F_txtBox.ForeColor = Color.Green;
                correctionFermes_lbl.Hide();
            }
            else
            {
                F_txtBox.ForeColor = Color.Red;
                correctionFermes_lbl.Show();
                correctionFermes_lbl.Text = g.ListeFermes[nbValider];
                correctionFermes_lbl.ForeColor = Color.Green;
            }
            //Comparer la liste des ouverts du user avec celui qui est correct :
            correct = VérifListe(g.ListeOuverts, ouvertsUser, nbValider);
            if (correct == true)
            {
                O_txtBox.ForeColor = Color.Green;
                correctionOuverts_lbl.Hide();
            }
            else
            {
                O_txtBox.ForeColor = Color.Red;
                correctionOuverts_lbl.Show();
                correctionOuverts_lbl.Text = g.ListeOuverts[nbValider];
                correctionOuverts_lbl.ForeColor = Color.Green;
            }

            nbValider++;
            valider_btn.Hide();
            suivant_btn.Show();

        }

        //Affichage automatique des solutions correctes dans le txtBox à la prochaine étape :
        private void suivant_btn_Click(object sender, EventArgs e)
        {
            SearchTree g = new SearchTree();
            Node2 N0 = new Node2();
            N0.numero = numinitial;
            // Recherche du meilleur chemin à partir de ce noeud initial et final :
            List<GenericNode> solution = g.RechercheSolutionAEtoile(N0);

            if ((F_txtBox.ForeColor == Color.Red) || (F_txtBox.Text == ""))
            {
                F_txtBox.Text = correctionFermes_lbl.Text;
            }
            F_txtBox.ForeColor = Color.Black;

            if ((O_txtBox.ForeColor == Color.Red) || (O_txtBox.Text == ""))
            {
                O_txtBox.Text = correctionOuverts_lbl.Text;
            }
            O_txtBox.ForeColor = Color.Black;

            //Gestion des boutons :
            if (nbValider ==  g.etapeDij)
            {
                correctionFermes_lbl.Hide();
                correctionOuverts_lbl.Hide();
                suivant_btn.Hide();
                valider_btn.Hide();
                treeViewFinal_btn.Show();
            }
            else
            {
                correctionFermes_lbl.Hide();
                correctionOuverts_lbl.Hide();
                suivant_btn.Hide();
                valider_btn.Show();
            }
        }


        //Calcul et affichage de l'arbre avec le meilleur chemin (bouton Valider) :
        private void treeViewFinal_btn_Click(object sender, EventArgs e)
        {
            SearchTree g = new SearchTree();
            Node2 N0 = new Node2();
            N0.numero = numinitial;
            // Recherche du meilleur chemin à partir de ce noeud initial et final :
            List<GenericNode> solution = g.RechercheSolutionAEtoile(N0);
             
            //Affichage de ce meilleur chemin dans listBox1
            Node2 N1 = N0;
            for (int i = 1; i < solution.Count; i++)
            {
                Node2 N2 = (Node2)solution[i]; 
                listBox1.Items.Add(Convert.ToString(N1.numero)
                     + "--->" + Convert.ToString(N2.numero)
                     + "   : " + Convert.ToString(matrice[N1.numero, N2.numero]));
                N1 = N2;
            }
            g.GetSearchTree(treeView1);
        }

        //Comparer la liste des fermés ou ouverts du user avec la liste correcte générée par le pgrm : ATTENTION, on suppose ici que le user rentre la liste dans le bon ordre, avec tous les bons caractères, sans problème d'espace, ... !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        public bool VérifListe(string[] listeOK, string listeUser, int numEtape)
        {
            bool correct = true;
            int i = 0;

            if (listeUser.Count() != listeOK[numEtape].Count())
            {
                correct = false;
            }
            else
            {
                while ((i<listeOK[numEtape].Count()) && (correct == true))
                {
                    if (listeUser[i] != listeOK[numEtape][i])
                    {
                        correct = false;
                    }
                    i++;
                }
            }

            return correct;
        }

        //Permet de compléter l'arbre à la main

        /* Get the tree node under the mouse pointer and 
        save it in the mySelectedNode variable. */
        private void menuItem1_Click(object sender, EventArgs e, MouseEventArgs m)
        {

            TreeNode mySelectedNode = treeView_toComplete.GetNodeAt(m.X, m.Y);
            if (mySelectedNode != null && mySelectedNode.Parent != null)
            {
                treeView_toComplete.SelectedNode = mySelectedNode;
                treeView_toComplete.LabelEdit = true;
                if (!mySelectedNode.IsEditing)
                {
                    mySelectedNode.BeginEdit();
                }
            }
            else
            {
                MessageBox.Show("Aucun noeud sélectionné ou sélection d'un noeud principal.\n" +
                   "Edition du noeud principal non autorisé.", "Sélection invalide");
            }
        }

        private void treeView_toComplete_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (e.Label != null)
            {
                if (e.Label.Length > 0)
                {
                    if (e.Label.IndexOfAny(new char[] { '@', '.', ',', '!', '>', '<', '&' }) == -1) //caractères interdits
                    {
                        // Stop editing without canceling the label change.
                        e.Node.EndEdit(false);
                    }
                    else
                    {
                        /* Cancel the label edit action, inform the user, and 
                           place the node in edit mode again. */
                        e.CancelEdit = true;
                        MessageBox.Show("Label invalide.\n" +
                           "Les caractères non autorisés sont '@','.', ',', '!','>','<','&'",
                           "Node Label Edit");
                        e.Node.BeginEdit();
                    }
                }
                else
                {
                    /* Cancel the label edit action, inform the user, and 
                       place the node in edit mode again. */
                    e.CancelEdit = true;
                    MessageBox.Show("Label de noeud invalide.\nLe label ne peut pas être vide",
                       "Node Label Edit");
                    e.Node.BeginEdit();
                }
            }
        }

        //Une fois que l'utilisateur a compléter le treeviw 
        private void verifTree_btn_Click(object sender, EventArgs e)
        {
            List<string> reponseUser = new List<string>();
            int error = 0;
            string[] reponse = { "0", "1", "2", "3", "4", "5", "6" };
            TreeNodeCollection N = treeView_toComplete.Nodes; //on récupère la liste des noeuds


            //On récupère la liste de saisie de l'utilisateur
            foreach (TreeNode item in N)
            {
                if (item != null)
                {
                    reponseUser.Add(Convert.ToString(item.Text));
                }
            }

            for (int n = 1; n < reponseUser.Count; n++)
            {

                listBox2.Items.Add(reponseUser[n]
                     + "--->" + reponse[n]);
               
            }

            int i = 0;
           /* while (i < 7)
            {
                //On vérifie que l'arbre soit bien remplit par l'utilisateur
                foreach (string rep in reponseUser)
                {
                    if (rep != reponse[i])
                    {
                        
                       // N[i].BackColor = Color.Red;
                        error++;
                    }
                    else
                    {
                        //N[i].BackColor = Color.LimeGreen;
                    }
                }
                i++;

            }*/
        }
    }
}

