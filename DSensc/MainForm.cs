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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public string Nom
        {
            get { return nom_txtbox.Text; }
            set { nom_txtbox.Text = value; }
        }

        private void demarrer_btn_Click(object sender, EventArgs e)
        {
            QuestionForm questionnaire = new QuestionForm();
            if (questionnaire.ShowDialog() == DialogResult.OK)
            {

            }



        }



    }
}
