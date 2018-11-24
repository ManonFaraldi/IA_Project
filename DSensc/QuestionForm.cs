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
        private int NumRep { get; set; } //à enlever !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        private RadioButton RadioBtnFalse { get; set; } //Réponse fausse sélectionnée

        public QuestionForm()
        {
            InitializeComponent();
            questions = new List<Questions>();

            //Cacher le form d'inscription :
            MainForm.ActiveForm.Hide();

            // Chargement des questions du fichier xml dans Questions
            questions = SerialisationQuestions.CreateFromFile("..\\..\\..\\Donnees\\Questions.xml");

            // Trier les questions dans le désordre :
            TriQuestion(questions);

            NbQuestion = 0;
            numQuestion_lbl.Text = Convert.ToString(NbQuestion + 1);
            question_enonce_lbl.Text = questions[NbQuestion].Enonce;
            rep1_radiobtn.Text = questions[NbQuestion].Reponse1;
            rep2_radiobtn.Text = questions[NbQuestion].Reponse2;
            rep3_radiobtn.Text = questions[NbQuestion].Reponse3;
            rep4_radiobtn.Text = questions[NbQuestion].Reponse4;
            VraiFaux(NbQuestion);
        }


        public void valider_btn_Click(object sender, EventArgs e)
        {
            //Vérifier qu'une réponse est cochée :
            if ((rep1_radiobtn.Checked == false) && (rep2_radiobtn.Checked == false) && (rep3_radiobtn.Checked == false) && (rep4_radiobtn.Checked == false))
            {
                MessageBox.Show("Veuillez cocher une réponse", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                NbQuestion++;

                if (NbQuestion == 20) //le test est fini
                {
                    ResultatsForm resultatsForm = new ResultatsForm();
                    if (resultatsForm.ShowDialog() == DialogResult.OK)
                    {
                    }
                }
                else //affichage du n° et texte de la question :
                {                 
                    numQuestion_lbl.Text = Convert.ToString(NbQuestion + 1);
                    question_enonce_lbl.Text = questions[NbQuestion].Enonce;
                    rep1_radiobtn.Text = questions[NbQuestion].Reponse1;
                    rep2_radiobtn.Text = questions[NbQuestion].Reponse2;
                    rep3_radiobtn.Text = questions[NbQuestion].Reponse3;
                    rep4_radiobtn.Text = questions[NbQuestion].Reponse4;
                    VraiFaux(NbQuestion);
                }
            }

            //Décocher toutes les réponses pour la prochaine question :
            rep1_radiobtn.Checked = false;
            rep2_radiobtn.Checked = false;
            rep3_radiobtn.Checked = false;
            rep4_radiobtn.Checked = false;         
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

        //Affiche en vert la bonne réponse et en rouge la mauvaise réponse à la question posée :
        public void VraiFaux(int numQuestion)
        {
            if (questions[numQuestion].ReponseVraie == 1)
            {
                rep1_radiobtn.BackColor = Color.Green;
                if (rep1_radiobtn.Checked == false)
                {
                    RadioBtnFalse = CheckedFalse(rep2_radiobtn, rep3_radiobtn, rep4_radiobtn);
                    RadioBtnFalse.BackColor = Color.Red;
                }
            }
            else if(questions[numQuestion].ReponseVraie == 2)
            {
                rep2_radiobtn.BackColor = Color.Green;
                if (rep2_radiobtn.Checked == false)
                {
                    RadioBtnFalse = CheckedFalse(rep1_radiobtn, rep3_radiobtn, rep4_radiobtn);
                    RadioBtnFalse.BackColor = Color.Red;
                }
            }
            else if (questions[numQuestion].ReponseVraie == 3)
            {
                rep3_radiobtn.BackColor = Color.Green;
                if (rep3_radiobtn.Checked == false)
                {
                    RadioBtnFalse = CheckedFalse(rep1_radiobtn, rep2_radiobtn, rep4_radiobtn);
                    RadioBtnFalse.BackColor = Color.Red;
                }
            }
            else if (questions[numQuestion].ReponseVraie == 4) // OK avec un else ??????????????????????????????????????????????????????????????????????????????????????????
            {
                rep4_radiobtn.BackColor = Color.Green;
                if (rep4_radiobtn.Checked == false)
                {
                    RadioBtnFalse = CheckedFalse(rep1_radiobtn, rep2_radiobtn, rep3_radiobtn);
                    RadioBtnFalse.BackColor = Color.Red;
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

        






    }
}
