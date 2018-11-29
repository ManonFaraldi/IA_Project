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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // listBoxgraphe
            // 
            this.listBoxgraphe.FormattingEnabled = true;
            this.listBoxgraphe.Location = new System.Drawing.Point(22, 73);
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
            this.F_txtBox.Location = new System.Drawing.Point(255, 103);
            this.F_txtBox.Name = "F_txtBox";
            this.F_txtBox.Size = new System.Drawing.Size(204, 20);
            this.F_txtBox.TabIndex = 12;
            // 
            // O_txtBox
            // 
            this.O_txtBox.Location = new System.Drawing.Point(255, 167);
            this.O_txtBox.Name = "O_txtBox";
            this.O_txtBox.Size = new System.Drawing.Size(204, 20);
            this.O_txtBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Remplir l\'espace des Fermés :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 150);
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
            this.valider_btn.Location = new System.Drawing.Point(317, 233);
            this.valider_btn.Name = "valider_btn";
            this.valider_btn.Size = new System.Drawing.Size(82, 43);
            this.valider_btn.TabIndex = 20;
            this.valider_btn.Text = "Valider";
            this.valider_btn.UseVisualStyleBackColor = false;
            // 
            // suivant_btn
            // 
            this.suivant_btn.BackColor = System.Drawing.Color.LimeGreen;
            this.suivant_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.suivant_btn.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suivant_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.suivant_btn.Location = new System.Drawing.Point(317, 282);
            this.suivant_btn.Name = "suivant_btn";
            this.suivant_btn.Size = new System.Drawing.Size(82, 43);
            this.suivant_btn.TabIndex = 21;
            this.suivant_btn.Text = "Suivant";
            this.suivant_btn.UseVisualStyleBackColor = false;
            // 
            // treeViewFinal_btn
            // 
            this.treeViewFinal_btn.BackColor = System.Drawing.Color.LimeGreen;
            this.treeViewFinal_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.treeViewFinal_btn.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewFinal_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.treeViewFinal_btn.Location = new System.Drawing.Point(293, 331);
            this.treeViewFinal_btn.Name = "treeViewFinal_btn";
            this.treeViewFinal_btn.Size = new System.Drawing.Size(128, 43);
            this.treeViewFinal_btn.TabIndex = 22;
            this.treeViewFinal_btn.Text = "TreeView final";
            this.treeViewFinal_btn.UseVisualStyleBackColor = false;
            this.treeViewFinal_btn.Click += new System.EventHandler(this.treeViewFinal_btn_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(511, 331);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(215, 134);
            this.listBox1.TabIndex = 24;
            // 
            // treeView2
            // 
            this.treeView2.Location = new System.Drawing.Point(237, 382);
            this.treeView2.Name = "treeView2";
            this.treeView2.Size = new System.Drawing.Size(121, 97);
            this.treeView2.TabIndex = 26;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(511, 73);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(215, 238);
            this.treeView1.TabIndex = 23;
            // 
            // Dijkstra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(779, 491);
            this.Controls.Add(this.treeView2);
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
            this.Text = "Dijkstra";
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
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.TreeView treeView1;
    }
}