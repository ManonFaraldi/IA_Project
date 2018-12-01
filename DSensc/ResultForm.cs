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
            int note1 = int.Parse(note1_lbl.Text);
            int note2 = int.Parse(note2_lbl.Text);
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

        private void ResultForm_Load(object sender, EventArgs e)
        {
            note1_lbl.Text = QuestionForm.NoteValue;
            note2_lbl.Text = Dijkstra.NoteValue;
        }
    }
}
