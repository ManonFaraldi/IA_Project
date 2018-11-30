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
            dateDS_txt.Text = DateTime.Today.ToLongDateString();
        }

        public static string prenomValue;
        public void demarrer_btn_Click(object sender, EventArgs e)
        {
            
            prenomValue =prenom_txtbox.Text;
            QuestionForm questionnaire = new QuestionForm();
            if (questionnaire.ShowDialog() == DialogResult.OK)
            {
            }
        }
    }
}
