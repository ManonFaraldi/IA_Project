namespace App
{
    partial class Dijkstra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxgraphe = new System.Windows.Forms.ListBox();
            this.TestIA_txt = new System.Windows.Forms.Label();
            this.F_txtBox = new System.Windows.Forms.TextBox();
            this.O_txtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.valider_btn = new System.Windows.Forms.Button();
            this.suivant_btn = new System.Windows.Forms.Button();
            this.treeViewFinal_btn = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.enonce_lbl = new System.Windows.Forms.Label();
            this.correctionFermes_lbl = new System.Windows.Forms.Label();
            this.correctionOuverts_lbl = new System.Windows.Forms.Label();
            this.listFermesFinal_txtBox = new System.Windows.Forms.TextBox();
            this.listOuvertsFinal_txtBox = new System.Windows.Forms.TextBox();
            this.listesFermes_txtBox = new System.Windows.Forms.TextBox();
            this.listesOuverts_txtBox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.treeViewCompete_btn = new System.Windows.Forms.Button();
            this.next_btn = new System.Windows.Forms.Button();
            this.validate_btn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxgraphe
            // 
            this.listBoxgraphe.FormattingEnabled = true;
            this.listBoxgraphe.Location = new System.Drawing.Point(15, 6);
            this.listBoxgraphe.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxgraphe.Name = "listBoxgraphe";
            this.listBoxgraphe.Size = new System.Drawing.Size(182, 238);
            this.listBoxgraphe.TabIndex = 10;
            // 
            // TestIA_txt
            // 
            this.TestIA_txt.AutoSize = true;
            this.TestIA_txt.Cursor = System.Windows.Forms.Cursors.Default;
            this.TestIA_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestIA_txt.Location = new System.Drawing.Point(300, 9);
            this.TestIA_txt.Name = "TestIA_txt";
            this.TestIA_txt.Size = new System.Drawing.Size(107, 33);
            this.TestIA_txt.TabIndex = 11;
            this.TestIA_txt.Text = "Test IA";
            // 
            // F_txtBox
            // 
            this.F_txtBox.Location = new System.Drawing.Point(247, 36);
            this.F_txtBox.Name = "F_txtBox";
            this.F_txtBox.Size = new System.Drawing.Size(204, 20);
            this.F_txtBox.TabIndex = 12;
            // 
            // O_txtBox
            // 
            this.O_txtBox.Location = new System.Drawing.Point(248, 114);
            this.O_txtBox.Name = "O_txtBox";
            this.O_txtBox.Size = new System.Drawing.Size(204, 20);
            this.O_txtBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Remplir l\'espace des Fermés :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Remplir l\'espace des Ouverts :";
            // 
            // valider_btn
            // 
            this.valider_btn.BackColor = System.Drawing.Color.LimeGreen;
            this.valider_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.valider_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valider_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.valider_btn.Location = new System.Drawing.Point(303, 198);
            this.valider_btn.Name = "valider_btn";
            this.valider_btn.Size = new System.Drawing.Size(82, 43);
            this.valider_btn.TabIndex = 20;
            this.valider_btn.Text = "Valider";
            this.valider_btn.UseVisualStyleBackColor = false;
            this.valider_btn.Click += new System.EventHandler(this.valider_btn_Click);
            // 
            // suivant_btn
            // 
            this.suivant_btn.BackColor = System.Drawing.Color.LimeGreen;
            this.suivant_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.suivant_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suivant_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.suivant_btn.Location = new System.Drawing.Point(303, 247);
            this.suivant_btn.Name = "suivant_btn";
            this.suivant_btn.Size = new System.Drawing.Size(82, 43);
            this.suivant_btn.TabIndex = 21;
            this.suivant_btn.Text = "Suivant";
            this.suivant_btn.UseVisualStyleBackColor = false;
            this.suivant_btn.Click += new System.EventHandler(this.suivant_btn_Click);
            // 
            // treeViewFinal_btn
            // 
            this.treeViewFinal_btn.BackColor = System.Drawing.Color.LimeGreen;
            this.treeViewFinal_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.treeViewFinal_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewFinal_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.treeViewFinal_btn.Location = new System.Drawing.Point(279, 296);
            this.treeViewFinal_btn.Name = "treeViewFinal_btn";
            this.treeViewFinal_btn.Size = new System.Drawing.Size(128, 43);
            this.treeViewFinal_btn.TabIndex = 22;
            this.treeViewFinal_btn.Text = "TreeView final";
            this.treeViewFinal_btn.UseVisualStyleBackColor = false;
            this.treeViewFinal_btn.Click += new System.EventHandler(this.treeViewComplete_btn_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(504, 6);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(215, 238);
            this.treeView1.TabIndex = 23;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(504, 264);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(215, 134);
            this.listBox1.TabIndex = 24;
            // 
            // enonce_lbl
            // 
            this.enonce_lbl.AutoSize = true;
            this.enonce_lbl.BackColor = System.Drawing.Color.Turquoise;
            this.enonce_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enonce_lbl.ForeColor = System.Drawing.Color.Red;
            this.enonce_lbl.Location = new System.Drawing.Point(24, 65);
            this.enonce_lbl.Name = "enonce_lbl";
            this.enonce_lbl.Size = new System.Drawing.Size(282, 25);
            this.enonce_lbl.TabIndex = 25;
            this.enonce_lbl.Text = "Enoncé !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!";
            // 
            // correctionFermes_lbl
            // 
            this.correctionFermes_lbl.AutoSize = true;
            this.correctionFermes_lbl.ForeColor = System.Drawing.Color.Red;
            this.correctionFermes_lbl.Location = new System.Drawing.Point(247, 61);
            this.correctionFermes_lbl.Name = "correctionFermes_lbl";
            this.correctionFermes_lbl.Size = new System.Drawing.Size(109, 13);
            this.correctionFermes_lbl.TabIndex = 26;
            this.correctionFermes_lbl.Text = "Correction des fermés";
            // 
            // correctionOuverts_lbl
            // 
            this.correctionOuverts_lbl.AutoSize = true;
            this.correctionOuverts_lbl.ForeColor = System.Drawing.Color.Red;
            this.correctionOuverts_lbl.Location = new System.Drawing.Point(246, 139);
            this.correctionOuverts_lbl.Name = "correctionOuverts_lbl";
            this.correctionOuverts_lbl.Size = new System.Drawing.Size(113, 13);
            this.correctionOuverts_lbl.TabIndex = 27;
            this.correctionOuverts_lbl.Text = "Correction des ouverts";
            // 
            // listFermesFinal_txtBox
            // 
            this.listFermesFinal_txtBox.Location = new System.Drawing.Point(15, 249);
            this.listFermesFinal_txtBox.Multiline = true;
            this.listFermesFinal_txtBox.Name = "listFermesFinal_txtBox";
            this.listFermesFinal_txtBox.Size = new System.Drawing.Size(237, 24);
            this.listFermesFinal_txtBox.TabIndex = 28;
            this.listFermesFinal_txtBox.Text = "Liste de tous les fermés à la fin";
            // 
            // listOuvertsFinal_txtBox
            // 
            this.listOuvertsFinal_txtBox.Location = new System.Drawing.Point(15, 279);
            this.listOuvertsFinal_txtBox.Multiline = true;
            this.listOuvertsFinal_txtBox.Name = "listOuvertsFinal_txtBox";
            this.listOuvertsFinal_txtBox.Size = new System.Drawing.Size(237, 23);
            this.listOuvertsFinal_txtBox.TabIndex = 29;
            this.listOuvertsFinal_txtBox.Text = "Liste de tous les ouverts à la fin";
            // 
            // listesFermes_txtBox
            // 
            this.listesFermes_txtBox.Location = new System.Drawing.Point(15, 322);
            this.listesFermes_txtBox.Multiline = true;
            this.listesFermes_txtBox.Name = "listesFermes_txtBox";
            this.listesFermes_txtBox.Size = new System.Drawing.Size(237, 226);
            this.listesFermes_txtBox.TabIndex = 30;
            this.listesFermes_txtBox.Text = "Liste de tous les fermés à chaque étape de résolution de A*";
            // 
            // listesOuverts_txtBox
            // 
            this.listesOuverts_txtBox.Location = new System.Drawing.Point(258, 380);
            this.listesOuverts_txtBox.Multiline = true;
            this.listesOuverts_txtBox.Name = "listesOuverts_txtBox";
            this.listesOuverts_txtBox.Size = new System.Drawing.Size(237, 121);
            this.listesOuverts_txtBox.TabIndex = 31;
            this.listesOuverts_txtBox.Text = "Liste de tous les ouverts  à chaque étape de résolution de A*";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(17, 113);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(745, 600);
            this.tabControl1.TabIndex = 32;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(737, 574);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Remplissage noeud par noeud";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listOuvertsFinal_txtBox);
            this.groupBox1.Controls.Add(this.listFermesFinal_txtBox);
            this.groupBox1.Controls.Add(this.listesOuverts_txtBox);
            this.groupBox1.Controls.Add(this.correctionOuverts_lbl);
            this.groupBox1.Controls.Add(this.listesFermes_txtBox);
            this.groupBox1.Controls.Add(this.correctionFermes_lbl);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.treeView1);
            this.groupBox1.Controls.Add(this.treeViewFinal_btn);
            this.groupBox1.Controls.Add(this.suivant_btn);
            this.groupBox1.Controls.Add(this.valider_btn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.O_txtBox);
            this.groupBox1.Controls.Add(this.F_txtBox);
            this.groupBox1.Controls.Add(this.listBoxgraphe);
            this.groupBox1.Location = new System.Drawing.Point(0, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(731, 554);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(737, 574);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Remplissage de l\'arbre";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox3);
            this.groupBox2.Controls.Add(this.treeView2);
            this.groupBox2.Controls.Add(this.listBox2);
            this.groupBox2.Controls.Add(this.treeViewCompete_btn);
            this.groupBox2.Controls.Add(this.next_btn);
            this.groupBox2.Controls.Add(this.validate_btn);
            this.groupBox2.Location = new System.Drawing.Point(8, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(723, 461);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(491, 292);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(215, 134);
            this.listBox3.TabIndex = 26;
            // 
            // treeView2
            // 
            this.treeView2.Location = new System.Drawing.Point(491, 18);
            this.treeView2.Name = "treeView2";
            this.treeView2.Size = new System.Drawing.Size(215, 238);
            this.treeView2.TabIndex = 25;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(18, 18);
            this.listBox2.Margin = new System.Windows.Forms.Padding(2);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(182, 238);
            this.listBox2.TabIndex = 24;
            // 
            // treeViewCompete_btn
            // 
            this.treeViewCompete_btn.BackColor = System.Drawing.Color.LimeGreen;
            this.treeViewCompete_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.treeViewCompete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewCompete_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.treeViewCompete_btn.Location = new System.Drawing.Point(297, 327);
            this.treeViewCompete_btn.Name = "treeViewCompete_btn";
            this.treeViewCompete_btn.Size = new System.Drawing.Size(128, 43);
            this.treeViewCompete_btn.TabIndex = 23;
            this.treeViewCompete_btn.Text = "TreeView final";
            this.treeViewCompete_btn.UseVisualStyleBackColor = false;
            // 
            // next_btn
            // 
            this.next_btn.BackColor = System.Drawing.Color.LimeGreen;
            this.next_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.next_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.next_btn.Location = new System.Drawing.Point(320, 278);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(82, 43);
            this.next_btn.TabIndex = 22;
            this.next_btn.Text = "Suivant";
            this.next_btn.UseVisualStyleBackColor = false;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // validate_btn
            // 
            this.validate_btn.BackColor = System.Drawing.Color.LimeGreen;
            this.validate_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.validate_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validate_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.validate_btn.Location = new System.Drawing.Point(320, 229);
            this.validate_btn.Name = "validate_btn";
            this.validate_btn.Size = new System.Drawing.Size(82, 43);
            this.validate_btn.TabIndex = 21;
            this.validate_btn.Text = "Valider";
            this.validate_btn.UseVisualStyleBackColor = false;
            this.validate_btn.Click += new System.EventHandler(this.validate_btn_Click);
            // 
            // Dijkstra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(774, 725);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.enonce_lbl);
            this.Controls.Add(this.TestIA_txt);
            this.Name = "Dijkstra";
            this.Text = " ";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxgraphe;
        private System.Windows.Forms.Label TestIA_txt;
        private System.Windows.Forms.TextBox F_txtBox;
        private System.Windows.Forms.TextBox O_txtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button valider_btn;
        private System.Windows.Forms.Button suivant_btn;
        private System.Windows.Forms.Button treeViewFinal_btn;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label enonce_lbl;
        private System.Windows.Forms.Label correctionFermes_lbl;
        private System.Windows.Forms.Label correctionOuverts_lbl;
        private System.Windows.Forms.TextBox listFermesFinal_txtBox;
        private System.Windows.Forms.TextBox listOuvertsFinal_txtBox;
        private System.Windows.Forms.TextBox listesFermes_txtBox;
        private System.Windows.Forms.TextBox listesOuverts_txtBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button treeViewCompete_btn;
        private System.Windows.Forms.Button next_btn;
        private System.Windows.Forms.Button validate_btn;
    }
}