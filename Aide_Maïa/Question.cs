using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IALib
{
    public class Question
    {
        public string Text { get; set; }
        public int Difficulty { get; set; }

        public string[] Answers { get; set; }

        public bool[] Correct { get; set; }

        public string[] Figures { get; set; }

        public Question()
        {

        }

        public Question(string text, int difficulty, string[] answers, bool[] correct, string[] figures)
        {
            this.Text = text;
            this.Difficulty = difficulty;
            this.Answers = answers;
            this.Correct = correct;
            this.Figures = figures;
        }

        public override string ToString()
        {
            return this.Text + "\n\n" + this.Answers.Length + "\n\n" + this.Correct.Length;
        }

        public bool HasFigures()
        {
            if (Figures == null) return false;
            return true;
        }
    }
}
