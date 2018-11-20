using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IALib;

namespace Afficheur
{
    public partial class Form1 : Form
    {
        public List<Question> questions;

        public Form1()
        {
            InitializeComponent();
            this.Text = "Questionnaire Intelligence Artificielle";
            int nQuestion = 0; //première question
            int nbPoints = 0; //0 points au début
            this.questions = IALib.QuestionFactory.CreateFromFile("questions.xml");
            ShuffleMe(questions);
            AffichageQuestion q = new AffichageQuestion(questions, nQuestion, nbPoints);
            Controls.Add(q);            
        }

        public static void ShuffleMe<T>(IList<T> list)
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
        
        private void quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        public void ChangeControl(UserControl control)
        {
            if (this.Controls.Count != 0)  
            {
                this.Controls.Clear();
            }
            this.Controls.Add(control);            
        }
    }
}
