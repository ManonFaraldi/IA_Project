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
using System.Xml.Serialization;
using System.IO;

namespace App
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

        public string Prenom
        {
            get { return prenom_txtbox.Text; }
            set { prenom_txtbox.Text = value; }
        }


        public void demarrer_btn_Click(object sender, EventArgs e)
        {
            
            QuestionForm questionnaire = new QuestionForm();
            if (questionnaire.ShowDialog() == DialogResult.OK)
            {
            }

        }
        public string GetPrenomUser()
        {
            string p = prenom_txtbox.Text;
            return p;
        }
    }
}
