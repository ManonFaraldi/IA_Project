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
    public partial class QuestionForm : Form
    {
        private int NbQuestion { get; set; }
        public QuestionForm()
        {
            InitializeComponent();
        }

        private void question_enonce_lbl_Click(object sender, EventArgs e)
        {

        }

        private void valider_btn_Click(object sender, EventArgs e)
        {
            NbQuestion = int.Parse(numQuestion_lbl.Text);
            NbQuestion++;
            if (NbQuestion == 21)
            {
                ResultatsForm resultatsForm = new ResultatsForm();
                if (resultatsForm.ShowDialog() == DialogResult.OK)
                {

                }
                Form.ActiveForm.Close();
            }
            else
            {               
                numQuestion_lbl.Text = Convert.ToString(NbQuestion);
            }
        }
    }
}
