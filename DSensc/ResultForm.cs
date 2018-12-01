using App;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSensc
{
    public partial class ResultForm : Form
    {
        public ResultForm()
        {
            InitializeComponent();
            int note1 = Convert.ToInt32(QuestionForm.NoteValue);
            note1_lbl.Text = Convert.ToString(note1);
            int note2 = Convert.ToInt32(Dijkstra.NoteValue);
            note2_lbl.Text = Convert.ToString(note2);
            noteFinal_lbl.Text = (CalculerMean(note1, note2)).ToString();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private int CalculerMean(int note1, int note2)
        {
            int moyenne = (note1 + note2) / 2;
            return moyenne;
        }
    }
}

