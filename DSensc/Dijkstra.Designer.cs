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
            this.verifTree_btn = new System.Windows.Forms.Button();
            this.result_btn = new System.Windows.Forms.Button();
            this.treeView_toComplete2 = new System.Windows.Forms.TreeView();
            this.treeViewVide_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxgraphe
            // 
            this.listBoxgraphe.FormattingEnabled = true;
            this.listBoxgraphe.Location = new System.Drawing.Point(22, 125);
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
            this.TestIA_txt.Location = new System.Drawing.Point(531, 9);
            this.TestIA_txt.Name = "TestIA_txt";
            this.TestIA_txt.Size = new System.Drawing.Size(145, 42);
            this.TestIA_txt.TabIndex = 11;
            this.TestIA_txt.Text = "Test IA";
            // 
            // F_txtBox
            // 
            this.F_txtBox.Location = new System.Drawing.Point(254, 155);
            this.F_txtBox.Name = "F_txtBox";
            this.F_txtBox.Size = new System.Drawing.Size(204, 20);
            this.F_txtBox.TabIndex = 12;
            // 
            // O_txtBox
            // 
            this.O_txtBox.Location = new System.Drawing.Point(255, 233);
            this.O_txtBox.Name = "O_txtBox";
            this.O_txtBox.Size = new System.Drawing.Size(204, 20);
            this.O_txtBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Remplir l\'espace des Fermés :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 216);
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
            this.valider_btn.Location = new System.Drawing.Point(307, 290);
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
            this.suivant_btn.Location = new System.Drawing.Point(307, 290);
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
            this.treeViewFinal_btn.Location = new System.Drawing.Point(285, 290);
            this.treeViewFinal_btn.Name = "treeViewFinal_btn";
            this.treeViewFinal_btn.Size = new System.Drawing.Size(128, 43);
            this.treeViewFinal_btn.TabIndex = 22;
            this.treeViewFinal_btn.Text = "TreeView final";
            this.treeViewFinal_btn.UseVisualStyleBackColor = false;
            this.treeViewFinal_btn.Click += new System.EventHandler(this.treeViewFinal_btn_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(511, 125);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(215, 238);
            this.treeView1.TabIndex = 23;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(511, 369);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(215, 134);
            this.listBox1.TabIndex = 24;
            // 
            // enonce_lbl
            // 
            this.enonce_lbl.AutoSize = true;
            this.enonce_lbl.BackColor = System.Drawing.Color.AliceBlue;
            this.enonce_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enonce_lbl.ForeColor = System.Drawing.Color.Black;
            this.enonce_lbl.Location = new System.Drawing.Point(19, 56);
            this.enonce_lbl.Name = "enonce_lbl";
            this.enonce_lbl.Size = new System.Drawing.Size(60, 16);
            this.enonce_lbl.TabIndex = 25;
            this.enonce_lbl.Text = "Enoncé";
            // 
            // correctionFermes_lbl
            // 
            this.correctionFermes_lbl.AutoSize = true;
            this.correctionFermes_lbl.ForeColor = System.Drawing.Color.Red;
            this.correctionFermes_lbl.Location = new System.Drawing.Point(254, 180);
            this.correctionFermes_lbl.Name = "correctionFermes_lbl";
            this.correctionFermes_lbl.Size = new System.Drawing.Size(109, 13);
            this.correctionFermes_lbl.TabIndex = 26;
            this.correctionFermes_lbl.Text = "Correction des fermés";
            // 
            // correctionOuverts_lbl
            // 
            this.correctionOuverts_lbl.AutoSize = true;
            this.correctionOuverts_lbl.ForeColor = System.Drawing.Color.Red;
            this.correctionOuverts_lbl.Location = new System.Drawing.Point(253, 258);
            this.correctionOuverts_lbl.Name = "correctionOuverts_lbl";
            this.correctionOuverts_lbl.Size = new System.Drawing.Size(113, 13);
            this.correctionOuverts_lbl.TabIndex = 27;
            this.correctionOuverts_lbl.Text = "Correction des ouverts";
            // 
            // verifTree_btn
            // 
            this.verifTree_btn.BackColor = System.Drawing.Color.LimeGreen;
            this.verifTree_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.verifTree_btn.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verifTree_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.verifTree_btn.Location = new System.Drawing.Point(832, 377);
            this.verifTree_btn.Name = "verifTree_btn";
            this.verifTree_btn.Size = new System.Drawing.Size(128, 43);
            this.verifTree_btn.TabIndex = 34;
            this.verifTree_btn.Text = "Vérification ";
            this.verifTree_btn.UseVisualStyleBackColor = false;
            this.verifTree_btn.Click += new System.EventHandler(this.verifTree_btn_Click);
            // 
            // result_btn
            // 
            this.result_btn.BackColor = System.Drawing.Color.LimeGreen;
            this.result_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.result_btn.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.result_btn.Location = new System.Drawing.Point(1079, 219);
            this.result_btn.Name = "result_btn";
            this.result_btn.Size = new System.Drawing.Size(128, 43);
            this.result_btn.TabIndex = 36;
            this.result_btn.Text = "Voir résultats";
            this.result_btn.UseVisualStyleBackColor = false;
            this.result_btn.Click += new System.EventHandler(this.result_btn_Click);
            // 
            // treeView_toComplete2
            // 
            this.treeView_toComplete2.LabelEdit = true;
            this.treeView_toComplete2.Location = new System.Drawing.Point(780, 125);
            this.treeView_toComplete2.Name = "treeView_toComplete2";
            this.treeView_toComplete2.Size = new System.Drawing.Size(215, 238);
            this.treeView_toComplete2.TabIndex = 37;
            // 
            // treeViewVide_btn
            // 
            this.treeViewVide_btn.BackColor = System.Drawing.Color.LimeGreen;
            this.treeViewVide_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.treeViewVide_btn.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewVide_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.treeViewVide_btn.Location = new System.Drawing.Point(807, 377);
            this.treeViewVide_btn.Name = "treeViewVide_btn";
            this.treeViewVide_btn.Size = new System.Drawing.Size(172, 43);
            this.treeViewVide_btn.TabIndex = 38;
            this.treeViewVide_btn.Text = "TreeView à remplir";
            this.treeViewVide_btn.UseVisualStyleBackColor = false;
            this.treeViewVide_btn.Click += new System.EventHandler(this.treeViewVide_Click);
            // 
            // Dijkstra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1289, 725);
            this.Controls.Add(this.treeViewVide_btn);
            this.Controls.Add(this.treeView_toComplete2);
            this.Controls.Add(this.result_btn);
            this.Controls.Add(this.verifTree_btn);
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
        private System.Windows.Forms.Button verifTree_btn;
        private System.Windows.Forms.Button result_btn;
        private System.Windows.Forms.TreeView treeView_toComplete2;
        private System.Windows.Forms.Button treeViewVide_btn;
    }
}