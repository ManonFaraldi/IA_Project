using System;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IALib;

namespace Afficheur
{
    public partial class AffichageQuestion : UserControl
    {

        public List<RadioButton> radioButtons;
        public List<Question> questions;
        public int nQu;
        public int nbPoints;

        public AffichageQuestion(List<Question> questions, int nQu, int nbPoints)
        {            
            InitializeComponent();
            this.questions = questions;
            this.nQu = nQu;
            this.nbPoints = nbPoints;
            radioButtons = new List<RadioButton>();

            afficherQuestion(nQu);
        }

        private void AffichageQuestion_Load(object sender, EventArgs e)
        {
        }

        private void quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void creerReponseUnique(int nQuestion)
        {
            radioButtons.Clear();
            for (int i = 0; i < this.questions[nQuestion].Answers.Length; i++)
            {
                radioButtons.Add(new RadioButton());
                radioButtons[i].Name = "RadioButton" + i;
                radioButtons[i].Text = (i + 1) + " : " + this.questions[nQuestion].Answers[i];
                radioButtons[i].BackColor = Color.Transparent;
                radioButtons[i].Width = 400;
                radioButtons[i].Height = 70;
                radioButtons[i].AutoSize = false;
                radioButtons[i].Location = new Point(this.Width/2-90, 50 * i + 130);
                this.Controls.Add(radioButtons[i]);
            }
        }
        private void creerReponsesMultiples(int nbReponses)
        {
            for (int i = 0; i <= nbReponses; i++)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Name = "CheckBox" + i;
                checkBox.Text = i + ". ";
                checkBox.Location = new Point(5, 30 * i);
            }
        }

        private void afficherQuestion(int nQuestion)
        {
            Question questionConsideree = this.questions[nQuestion];
            int texteNumero = nQuestion + 1;
            intituleQuestion.Text = "Question n°" + texteNumero + " : " + questionConsideree.Text;
            Console.WriteLine(intituleQuestion.Text);
            creerReponseUnique(nQuestion);

            if (questionConsideree.HasFigures())
            {
                pictureBox.Visible = true;
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                pictureBox.ImageLocation = questionConsideree.Figures[0];
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Load();
            }

        }

        private void envoyer_Click(object sender, EventArgs e)
        {
            bool found = false;
            bool repJuste = false;
            int i = 0;
            while (!found && i < this.questions[nQu].Answers.Length)
            {
                if (radioButtons[i].Checked)
                {
                    found = true;
                }
                else  i++;
            }

            if (found)
            {
                int compteur = 0;
                while (questions[nQu].Correct[compteur] != true)
                {
                    compteur++;
                }
                if(compteur==i)
                {
                    nbPoints += questions[nQu].Difficulty;
                    repJuste = true;
                }                
                AffichageCorrection c = new AffichageCorrection(questions, nQu, nbPoints, repJuste);
                ((Form1)this.Parent).ChangeControl(c);
                
            }
            else MessageBox.Show("Veuillez sélectionner au moins une réponse", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);                       

        }

    }
}
