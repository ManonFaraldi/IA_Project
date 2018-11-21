using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class QuestionForm : Form
    {
        private int NbQuestion { get; set; }

        public List<Questions> questions = new List<Questions>();
      
        public QuestionForm()
        {
            InitializeComponent();
            this.questions = App.SerialisationQuestions.CreateFromFile("questions.xml");
            
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
            else //l'affichage continue
            {               
                numQuestion_lbl.Text = Convert.ToString(NbQuestion);
                TriQuestion(questions);
               // question_enonce_lbl = this.questions.Enonce; // REvoir les using + 2 namespace (IALib & Afficheur --> séparer App et les questions ??)
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
