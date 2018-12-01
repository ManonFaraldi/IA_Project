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


namespace App
{
    public partial class QuestionForm : Form
    {
        
        public List<Questions> questions;

        private int NbQuestion { get; set; }   
        private RadioButton RadioBtnFalse { get; set; } //Réponse fausse sélectionnée
        private double Note { get; set; } //Note /20
        private int Total { get; set; } //Nb. total de points pour toutes les questions
        private int NbPts { get; set; } //Nb. points accumulés pour les q°) répondues jusqu'à présent
        public static int NoteValue;
        public QuestionForm()
        {
            
            InitializeComponent();
            questions = new List<Questions>();

            
                //Cacher les forms et panels :
            MainForm.ActiveForm.Hide();
            resultats_panel.Visible = false;
            
            // Chargement des questions du fichier xml dans Questions
            questions = SerialisationQuestions.CreateFromFile("..\\..\\..\\Donnees\\Questions.xml");

            // Trier les questions dans le désordre :
            TriQuestion(questions);

            //Mise à jour des points de l'utilisateur :
            Note = 0;
            NbPts = 0;
            Total = 0;
            /*foreach (Questions q in questions)
            {
                Total += q.NbPoint; //exam sur 26 points au total
            }*/

            //Affichage de la 1ère question :
            NbQuestion = 0;            
            numQuestion_lbl.Text = Convert.ToString(NbQuestion + 1) + "/20 :";
            question_enonce_lbl.Text = questions[NbQuestion].Enonce;
            rep1_radiobtn.Text = questions[NbQuestion].Reponse1;
            rep2_radiobtn.Text = questions[NbQuestion].Reponse2;
            rep3_radiobtn.Text = questions[NbQuestion].Reponse3;
            rep4_radiobtn.Text = questions[NbQuestion].Reponse4;
            Total += questions[NbQuestion].NbPoint;

            if (questions[NbQuestion].Image != "")
              {
                  string pathImage = "..\\..\\..\\Donnees\\Images\\" +  questions[NbQuestion].Image;
                  Image img = Image.FromFile(@pathImage);
                  PictureBox.Image = img;
              }
         
            
            suivant_btn.Hide();
        }
        
             
        //Passer à la question suivante :
        public void suivant_btn_Click(object sender, EventArgs e)
        {
            suivant_btn.Hide();
            valider_btn.Show();
            
            NbQuestion++;

            //Décocher toutes les réponses :
            rep1_radiobtn.Checked = false;
            rep2_radiobtn.Checked = false;
            rep3_radiobtn.Checked = false;
            rep4_radiobtn.Checked = false;
            PictureBox.Image = null; // nettoyage picturebox

            //Remise à zéro des couleurs des questions :
            rep1_radiobtn.BackColor = Color.AliceBlue;
            rep2_radiobtn.BackColor = Color.AliceBlue;
            rep3_radiobtn.BackColor = Color.AliceBlue;
            rep4_radiobtn.BackColor = Color.AliceBlue;

            if (NbQuestion == 20) //le test est fini
            {
                resultats_panel.Visible = true;
                noteFinale_lbl.Text = Convert.ToString(Note);
                if (Note >= 10)
                {
                    appreciation_txt.Text = "Félicitation ! Vous avez réussi le test !";
                }
                else
                {
                    appreciation_txt.Text = "Désolé, vous avez échoué à ce test !";
                }
            }
            else //affichage du n° et texte de la question :
            {                 
                numQuestion_lbl.Text = Convert.ToString(NbQuestion + 1) +"/20 :";
                question_enonce_lbl.Text = questions[NbQuestion].Enonce;
                rep1_radiobtn.Text = questions[NbQuestion].Reponse1;
                rep2_radiobtn.Text = questions[NbQuestion].Reponse2;
                rep3_radiobtn.Text = questions[NbQuestion].Reponse3;
                rep4_radiobtn.Text = questions[NbQuestion].Reponse4;
                Total += questions[NbQuestion].NbPoint; // on met à jour le nombre de points totaux
                if (questions[NbQuestion].Image != "")
                {
                    string pathImage = "..\\..\\..\\Donnees\\Images\\" + questions[NbQuestion].Image;
                    Image img = Image.FromFile(@pathImage);
                    PictureBox.Image = img;
                }
            }                             
        }

        //Affichage de la bonne et mauvaise réponse  en couleurs :
        private void valider_btn_Click(object sender, EventArgs e)
        {
            //Vérifier qu'une réponse est cochée :
            if ((rep1_radiobtn.Checked == false) && (rep2_radiobtn.Checked == false) && (rep3_radiobtn.Checked == false) && (rep4_radiobtn.Checked == false))
            {
                MessageBox.Show("Veuillez cocher une réponse", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //Afficher les réponses en couleur :
            else
            {
                valider_btn.Hide();
                suivant_btn.Show();
                VraiFaux(NbQuestion);
                //CalcNote(NbQuestion);
                note_lbl.Text = Convert.ToString(Note);
            }
        }

        public static void TriQuestion<T>(IList<T> list) //Trier les questions dans un ordre aléatoire
        {
            Random random = new Random();
            int n = list.Count;

            for (int i = list.Count - 1; i > 1; i--)
            {
                int rnd = random.Next(i + 1);
                T value = list[rnd];
                list[rnd] = list[i];
                list[i] = value;
            }
        }

        //Affiche en vert la bonne réponse et en rouge la mauvaise réponse à la question posée + MAJ de la note
        public void VraiFaux(int numQuestion)
        {
            if (questions[numQuestion].ReponseVraie == 1)
            {              
                rep1_radiobtn.BackColor = Color.Green;
                if (rep1_radiobtn.Checked == false)
                {
                    RadioBtnFalse = CheckedFalse(rep2_radiobtn, rep3_radiobtn, rep4_radiobtn);
                    RadioBtnFalse.BackColor = Color.Red;
                    Note += 0; // On ne gagne pas de points
                }
                else
                {
                    CalcNote(numQuestion);
                }
            }
            else if(questions[numQuestion].ReponseVraie == 2)
            {
                rep2_radiobtn.BackColor = Color.Green;
                if (rep2_radiobtn.Checked == false)
                {
                    RadioBtnFalse = CheckedFalse(rep1_radiobtn, rep3_radiobtn, rep4_radiobtn);
                    RadioBtnFalse.BackColor = Color.Red;
                    Note += 0; // On ne gagne pas de points
                }
                else
                {
                    CalcNote(numQuestion);
                }
            }
            else if (questions[numQuestion].ReponseVraie == 3)
            {
                rep3_radiobtn.BackColor = Color.Green;
                if (rep3_radiobtn.Checked == false)
                {
                    RadioBtnFalse = CheckedFalse(rep1_radiobtn, rep2_radiobtn, rep4_radiobtn);
                    RadioBtnFalse.BackColor = Color.Red;
                    Note += 0; // On ne gagne pas de points
                }
                else
                {
                    CalcNote(numQuestion);
                }
            }
            else
            {
                rep4_radiobtn.BackColor = Color.Green;
                if (rep4_radiobtn.Checked == false)
                {
                    RadioBtnFalse = CheckedFalse(rep1_radiobtn, rep2_radiobtn, rep3_radiobtn);
                    RadioBtnFalse.BackColor = Color.Red;
                    Note += 0; // On ne gagne pas de points
                }
                else
                {
                    CalcNote(numQuestion);
                }
            }
        }


        // Renvoi la réponse fausse sélectionnée par l'utilisateur :
        public RadioButton CheckedFalse (RadioButton rep1, RadioButton rep2, RadioButton rep3)
        {
            RadioButton btnFalse = rep1;
            if (rep1.Checked == true)
            {
                btnFalse = rep1;
            }
            else if (rep2.Checked == true)
            {
                btnFalse = rep2;
            }
            else if (rep3.Checked == true)
            {
                btnFalse = rep3;
            }
            return btnFalse;
        }

        //Calcul la note de l'utilisateur quand la réponse est correcte :
        public void CalcNote(int numQuestion)
        {
            NbPts += questions[numQuestion].NbPoint;
            double noteCalc = ((NbPts * 20) / Total); 
            Note = Math.Round(noteCalc, 1);       
        }

        private void AccesDijkstra_btn_Click(object sender, EventArgs e)
        {
            Dijkstra djikstra = new Dijkstra();
            if (djikstra.ShowDialog() == DialogResult.OK)
            {

            }
            NoteValue = Total;
        }

        private void QuestionForm_Load(object sender, EventArgs e)
        {
            prenom_txt.Text = MainForm.prenomValue;
        }

    }
}
