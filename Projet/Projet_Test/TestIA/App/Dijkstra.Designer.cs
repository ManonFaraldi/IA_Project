namespace DSensc
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
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.treeViewFinal_btn = new System.Windows.Forms.Button();
            this.suivant_btn = new System.Windows.Forms.Button();
            this.valider_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.O_txtBox = new System.Windows.Forms.TextBox();
            this.F_txtBox = new System.Windows.Forms.TextBox();
            this.TestIA_txt = new System.Windows.Forms.Label();
            this.listBoxgraphe = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // treeView2
            // 
            this.treeView2.Location = new System.Drawing.Point(232, 377);
            this.treeView2.Name = "treeView2";
            this.treeView2.Size = new System.Drawing.Size(121, 97);
            this.treeView2.TabIndex = 38;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(506, 326);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(215, 134);
            this.listBox1.TabIndex = 37;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(506, 68);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(215, 238);
            this.treeView1.TabIndex = 36;
            // 
            // treeViewFinal_btn
            // 
            this.treeViewFinal_btn.BackColor = System.Drawing.Color.LimeGreen;
            this.treeViewFinal_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.treeViewFinal_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewFinal_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.treeViewFinal_btn.Location = new System.Drawing.Point(288, 326);
            this.treeViewFinal_btn.Name = "treeViewFinal_btn";
            this.treeViewFinal_btn.Size = new System.Drawing.Size(128, 43);
            this.treeViewFinal_btn.TabIndex = 35;
            this.treeViewFinal_btn.Text = "TreeView final";
            this.treeViewFinal_btn.UseVisualStyleBackColor = false;
            // 
            // suivant_btn
            // 
            this.suivant_btn.BackColor = System.Drawing.Color.LimeGreen;
            this.suivant_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.suivant_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suivant_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.suivant_btn.Location = new System.Drawing.Point(312, 277);
            this.suivant_btn.Name = "suivant_btn";
            this.suivant_btn.Size = new System.Drawing.Size(82, 43);
            this.suivant_btn.TabIndex = 34;
            this.suivant_btn.Text = "Suivant";
            this.suivant_btn.UseVisualStyleBackColor = false;
            // 
            // valider_btn
            // 
            this.valider_btn.BackColor = System.Drawing.Color.LimeGreen;
            this.valider_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.valider_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valider_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.valider_btn.Location = new System.Drawing.Point(312, 228);
            this.valider_btn.Name = "valider_btn";
            this.valider_btn.Size = new System.Drawing.Size(82, 43);
            this.valider_btn.TabIndex = 33;
            this.valider_btn.Text = "Valider";
            this.valider_btn.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Remplir l\'espace des Ouverts :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Remplir l\'espace des Fermés :";
            // 
            // O_txtBox
            // 
            this.O_txtBox.Location = new System.Drawing.Point(250, 162);
            this.O_txtBox.Name = "O_txtBox";
            this.O_txtBox.Size = new System.Drawing.Size(204, 20);
            this.O_txtBox.TabIndex = 30;
            // 
            // F_txtBox
            // 
            this.F_txtBox.Location = new System.Drawing.Point(250, 98);
            this.F_txtBox.Name = "F_txtBox";
            this.F_txtBox.Size = new System.Drawing.Size(204, 20);
            this.F_txtBox.TabIndex = 29;
            // 
            // TestIA_txt
            // 
            this.TestIA_txt.AutoSize = true;
            this.TestIA_txt.Cursor = System.Windows.Forms.Cursors.Default;
            this.TestIA_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestIA_txt.Location = new System.Drawing.Point(295, 4);
            this.TestIA_txt.Name = "TestIA_txt";
            this.TestIA_txt.Size = new System.Drawing.Size(107, 33);
            this.TestIA_txt.TabIndex = 28;
            this.TestIA_txt.Text = "Test IA";
            // 
            // listBoxgraphe
            // 
            this.listBoxgraphe.FormattingEnabled = true;
            this.listBoxgraphe.Location = new System.Drawing.Point(17, 68);
            this.listBoxgraphe.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxgraphe.Name = "listBoxgraphe";
            this.listBoxgraphe.Size = new System.Drawing.Size(182, 238);
            this.listBoxgraphe.TabIndex = 27;
            // 
            // Dijkstra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 487);
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

        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button treeViewFinal_btn;
        private System.Windows.Forms.Button suivant_btn;
        private System.Windows.Forms.Button valider_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox O_txtBox;
        private System.Windows.Forms.TextBox F_txtBox;
        private System.Windows.Forms.Label TestIA_txt;
        private System.Windows.Forms.ListBox listBoxgraphe;
    }
}