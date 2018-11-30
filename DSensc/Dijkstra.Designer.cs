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
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("??");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("??");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("??", new System.Windows.Forms.TreeNode[] {
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("??", new System.Windows.Forms.TreeNode[] {
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("??", new System.Windows.Forms.TreeNode[] {
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("??");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("??", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode12,
            treeNode13});
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
            this.treeView_toComplete = new System.Windows.Forms.TreeView();
            this.verifTree_btn = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxgraphe
            // 
            this.listBoxgraphe.FormattingEnabled = true;
            this.listBoxgraphe.Location = new System.Drawing.Point(22, 110);
            this.listBoxgraphe.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxgraphe.Name = "listBoxgraphe";
            this.listBoxgraphe.Size = new System.Drawing.Size(182, 238);
            this.listBoxgraphe.TabIndex = 10;
            // 
            // TestIA_txt
            // 
            this.TestIA_txt.AutoSize = true;
            this.TestIA_txt.Cursor = System.Windows.Forms.Cursors.Default;
            this.TestIA_txt.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestIA_txt.Location = new System.Drawing.Point(300, 9);
            this.TestIA_txt.Name = "TestIA_txt";
            this.TestIA_txt.Size = new System.Drawing.Size(145, 42);
            this.TestIA_txt.TabIndex = 11;
            this.TestIA_txt.Text = "Test IA";
            // 
            // F_txtBox
            // 
            this.F_txtBox.Location = new System.Drawing.Point(254, 140);
            this.F_txtBox.Name = "F_txtBox";
            this.F_txtBox.Size = new System.Drawing.Size(204, 20);
            this.F_txtBox.TabIndex = 12;
            // 
            // O_txtBox
            // 
            this.O_txtBox.Location = new System.Drawing.Point(255, 218);
            this.O_txtBox.Name = "O_txtBox";
            this.O_txtBox.Size = new System.Drawing.Size(204, 20);
            this.O_txtBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Remplir l\'espace des Fermés :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Remplir l\'espace des Ouverts :";
            // 
            // valider_btn
            // 
            this.valider_btn.BackColor = System.Drawing.Color.LimeGreen;
            this.valider_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.valider_btn.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valider_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.valider_btn.Location = new System.Drawing.Point(307, 300);
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
            this.suivant_btn.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suivant_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.suivant_btn.Location = new System.Drawing.Point(307, 300);
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
            this.treeViewFinal_btn.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewFinal_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.treeViewFinal_btn.Location = new System.Drawing.Point(285, 300);
            this.treeViewFinal_btn.Name = "treeViewFinal_btn";
            this.treeViewFinal_btn.Size = new System.Drawing.Size(128, 43);
            this.treeViewFinal_btn.TabIndex = 22;
            this.treeViewFinal_btn.Text = "TreeView final";
            this.treeViewFinal_btn.UseVisualStyleBackColor = false;
            this.treeViewFinal_btn.Click += new System.EventHandler(this.treeViewFinal_btn_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(511, 110);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(215, 238);
            this.treeView1.TabIndex = 23;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(511, 354);
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
            this.correctionFermes_lbl.Location = new System.Drawing.Point(254, 165);
            this.correctionFermes_lbl.Name = "correctionFermes_lbl";
            this.correctionFermes_lbl.Size = new System.Drawing.Size(109, 13);
            this.correctionFermes_lbl.TabIndex = 26;
            this.correctionFermes_lbl.Text = "Correction des fermés";
            // 
            // correctionOuverts_lbl
            // 
            this.correctionOuverts_lbl.AutoSize = true;
            this.correctionOuverts_lbl.ForeColor = System.Drawing.Color.Red;
            this.correctionOuverts_lbl.Location = new System.Drawing.Point(253, 243);
            this.correctionOuverts_lbl.Name = "correctionOuverts_lbl";
            this.correctionOuverts_lbl.Size = new System.Drawing.Size(113, 13);
            this.correctionOuverts_lbl.TabIndex = 27;
            this.correctionOuverts_lbl.Text = "Correction des ouverts";
            // 
            // treeView_toComplete
            // 
            this.treeView_toComplete.LabelEdit = true;
            this.treeView_toComplete.Location = new System.Drawing.Point(775, 110);
            this.treeView_toComplete.Name = "treeView_toComplete";
            treeNode8.Name = "Nœud1";
            treeNode8.Text = "??";
            treeNode9.Name = "Nœud6";
            treeNode9.Text = "??";
            treeNode10.Name = "Nœud5";
            treeNode10.Text = "??";
            treeNode11.Name = "Nœud4";
            treeNode11.Text = "??";
            treeNode12.Name = "Nœud2";
            treeNode12.Text = "??";
            treeNode13.Name = "Nœud3";
            treeNode13.Text = "??";
            treeNode14.Name = "Nœud0";
            treeNode14.Text = "??";
            this.treeView_toComplete.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode14});
            this.treeView_toComplete.Size = new System.Drawing.Size(215, 238);
            this.treeView_toComplete.TabIndex = 33;
            // 
            // verifTree_btn
            // 
            this.verifTree_btn.BackColor = System.Drawing.Color.LimeGreen;
            this.verifTree_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.verifTree_btn.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verifTree_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.verifTree_btn.Location = new System.Drawing.Point(818, 383);
            this.verifTree_btn.Name = "verifTree_btn";
            this.verifTree_btn.Size = new System.Drawing.Size(128, 43);
            this.verifTree_btn.TabIndex = 34;
            this.verifTree_btn.Text = "Vérification ";
            this.verifTree_btn.UseVisualStyleBackColor = false;
            this.verifTree_btn.Click += new System.EventHandler(this.verifTree_btn_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(775, 453);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(215, 134);
            this.listBox2.TabIndex = 35;
            // 
            // Dijkstra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1072, 725);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.verifTree_btn);
            this.Controls.Add(this.treeView_toComplete);
            this.Controls.Add(this.correctionOuverts_lbl);
            this.Controls.Add(this.correctionFermes_lbl);
            this.Controls.Add(this.enonce_lbl);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.treeViewFinal_btn);
            this.Controls.Add(this.suivant_btn);
            this.Controls.Add(this.valider_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.O_txtBox);
            this.Controls.Add(this.F_txtBox);
            this.Controls.Add(this.TestIA_txt);
            this.Controls.Add(this.listBoxgraphe);
            this.Name = "Dijkstra";
            this.Text = " ";
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
        private System.Windows.Forms.TreeView treeView_toComplete;
        private System.Windows.Forms.Button verifTree_btn;
        private System.Windows.Forms.ListBox listBox2;
    }
}