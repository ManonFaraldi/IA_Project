﻿using System;
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
        private int Total { get; set; }//Nb. total de points des questions répondues


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

            //Affichage de la 1ère question :
            Note = 0;
            Total = 0;
            NbQuestion = 0;
            numQuestion_lbl.Text = Convert.ToString(NbQuestion + 1) + "/20 :";
            question_enonce_lbl.Text = questions[NbQuestion].Enonce;
            rep1_radiobtn.Text = questions[NbQuestion].Reponse1;
            rep2_radiobtn.Text = questions[NbQuestion].Reponse2;
            rep3_radiobtn.Text = questions[NbQuestion].Reponse3;
            rep4_radiobtn.Text = questions[NbQuestion].Reponse4;
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
            //Remise à zéro des couleurs des questions :
            rep1_radiobtn.BackColor = Color.AliceBlue;
            rep2_radiobtn.BackColor = Color.AliceBlue;
            rep3_radiobtn.BackColor = Color.AliceBlue;
            rep4_radiobtn.BackColor = Color.AliceBlue;

            if (NbQuestion == 20) //le test est fini
            {
                resultats_panel.Visible = true;
            }
            else //affichage du n° et texte de la question :
            {                 
                numQuestion_lbl.Text = Convert.ToString(NbQuestion + 1) +"/20 :";
                question_enonce_lbl.Text = questions[NbQuestion].Enonce;
                rep1_radiobtn.Text = questions[NbQuestion].Reponse1;
                rep2_radiobtn.Text = questions[NbQuestion].Reponse2;
                rep3_radiobtn.Text = questions[NbQuestion].Reponse3;
                rep4_radiobtn.Text = questions[NbQuestion].Reponse4;
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
                note_lbl.Text = Convert.ToString(Note);
            }
        }

        private void quitter_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
                }
                else
                {
                    Total += questions[numQuestion].NbPoint;
                    Note = ((Note + questions[numQuestion].NbPoint) * 20) / Total;
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
                else
                {
                    Total += questions[numQuestion].NbPoint;
                    Note = ((Note + questions[numQuestion].NbPoint) * 20) / Total;
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
                else
                {
                    Total += questions[numQuestion].NbPoint;
                    Note = ((Note + questions[numQuestion].NbPoint) * 20) / Total;
                }
            }
            else
            {
                rep4_radiobtn.BackColor = Color.Green;
                if (rep4_radiobtn.Checked == false)
                {
                    RadioBtnFalse = CheckedFalse(rep1_radiobtn, rep2_radiobtn, rep3_radiobtn);
                    RadioBtnFalse.BackColor = Color.Red;
                }
                else
                {
                    Total += questions[numQuestion].NbPoint;
                    Note = ((Note + questions[numQuestion].NbPoint) * 20) / Total;
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

        //Calcul la note de l'utilisateur :
        public void CalcNote(int numQuestion)
        {
            //int note;

            if (questions[numQuestion].NbPoint == 1)
            {
                Note += 1;
            }
            else
            {
                Note = ((Note + questions[numQuestion].NbPoint) * 20) / (20 + questions[numQuestion].NbPoint - 1);
            }
            //return Note;
        }





    }
}
