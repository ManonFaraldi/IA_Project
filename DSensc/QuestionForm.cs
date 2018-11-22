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
        public List<Questions> questions = new List<Questions>();

        private int NbQuestion { get; set; }   
      
        public QuestionForm()
        {
            InitializeComponent();

            // Chargement des questions du fichier xml dans Questions
            questions = SerialisationQuestions.CreateFromFile("..\\..\\..\\Donnees\\Questions.xml");

            // Trier les questions dans le désordre :
            TriQuestion(questions);

            // prenom_txt.Text = MainForm.ActiveForm.Text.Nom; // AREVOIR !!!!!
        }


        public void valider_btn_Click(object sender, EventArgs e)
        {
            NbQuestion = int.Parse(numQuestion_lbl.Text);
            NbQuestion++;
            if (NbQuestion == 21) // le test est fini
            {
                ResultatsForm resultatsForm = new ResultatsForm();
                if (resultatsForm.ShowDialog() == DialogResult.OK)
                {
                }
            }
            else //l'affichage continu
            {
                //Affichage du n° de la question :
                numQuestion_lbl.Text = Convert.ToString(NbQuestion);

                /*Trier les questions dans le désordre :
                TriQuestion(questions);*/

                //Afficher la question :
                if ((rep1_radiobtn.Checked == false) && (rep2_radiobtn.Checked == false) && (rep3_radiobtn.Checked == false) && (rep4_radiobtn.Checked == false))
                {
                    MessageBox.Show("Veuillez cocher une réponse", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    /*foreach (Questions q in questions) //Refait un nouveau tri à chaque fois, donc risque d'avoir plusieurs fois la même quesiton !
                    {
                        question_enonce_lbl.Text = q.Enonce;
                        rep1_radiobtn.Text = q.Reponse1;
                        rep2_radiobtn.Text = q.Reponse2;
                        rep3_radiobtn.Text = q.Reponse3;
                        rep4_radiobtn.Text = q.Reponse4;
                    }*/
                    question_enonce_lbl.Text = questions[NbQuestion].Enonce; //ERREUR index out of range !!!
                    rep1_radiobtn.Text = questions[NbQuestion].Reponse1;
                    rep2_radiobtn.Text = questions[NbQuestion].Reponse2;
                    rep3_radiobtn.Text = questions[NbQuestion].Reponse3;
                    rep4_radiobtn.Text = questions[NbQuestion].Reponse4;
                }


            }


        }

        public static void TriQuestion<T>(IList<T> list)
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
    }
}
