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
    public partial class ResultatsForm : Form
    {
        public ResultatsForm()
        {
            InitializeComponent();
        }

        private void quitter_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
