﻿namespace App
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.nom_txt = new System.Windows.Forms.Label();
            this.prenom_txt = new System.Windows.Forms.Label();
            this.nom_txtbox = new System.Windows.Forms.TextBox();
            this.prenom_txtbox = new System.Windows.Forms.TextBox();
            this.TestIA_txt = new System.Windows.Forms.Label();
            this.JMSalotti_txt = new System.Windows.Forms.Label();
            this.demarrer_btn = new System.Windows.Forms.Button();
            this.dateDS_txt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nom_txt
            // 
            this.nom_txt.AutoSize = true;
            this.nom_txt.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom_txt.Location = new System.Drawing.Point(67, 113);
            this.nom_txt.Name = "nom_txt";
            this.nom_txt.Size = new System.Drawing.Size(52, 23);
            this.nom_txt.TabIndex = 0;
            this.nom_txt.Text = "Nom :";
            // 
            // prenom_txt
            // 
            this.prenom_txt.AutoSize = true;
            this.prenom_txt.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenom_txt.Location = new System.Drawing.Point(50, 158);
            this.prenom_txt.Name = "prenom_txt";
            this.prenom_txt.Size = new System.Drawing.Size(69, 23);
            this.prenom_txt.TabIndex = 1;
            this.prenom_txt.Text = "Prénom :";
            // 
            // nom_txtbox
            // 
            this.nom_txtbox.Location = new System.Drawing.Point(140, 117);
            this.nom_txtbox.Name = "nom_txtbox";
            this.nom_txtbox.Size = new System.Drawing.Size(182, 20);
            this.nom_txtbox.TabIndex = 2;
            // 
            // prenom_txtbox
            // 
            this.prenom_txtbox.Location = new System.Drawing.Point(140, 162);
            this.prenom_txtbox.Name = "prenom_txtbox";
            this.prenom_txtbox.Size = new System.Drawing.Size(182, 20);
            this.prenom_txtbox.TabIndex = 3;
            // 
            // TestIA_txt
            // 
            this.TestIA_txt.AutoSize = true;
            this.TestIA_txt.Cursor = System.Windows.Forms.Cursors.Default;
            this.TestIA_txt.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestIA_txt.Location = new System.Drawing.Point(158, 5);
            this.TestIA_txt.Name = "TestIA_txt";
            this.TestIA_txt.Size = new System.Drawing.Size(145, 42);
            this.TestIA_txt.TabIndex = 4;
            this.TestIA_txt.Text = "Test IA";
            // 
            // JMSalotti_txt
            // 
            this.JMSalotti_txt.AutoSize = true;
            this.JMSalotti_txt.Font = new System.Drawing.Font("Gill Sans MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JMSalotti_txt.Location = new System.Drawing.Point(348, 44);
            this.JMSalotti_txt.Name = "JMSalotti_txt";
            this.JMSalotti_txt.Size = new System.Drawing.Size(85, 16);
            this.JMSalotti_txt.TabIndex = 5;
            this.JMSalotti_txt.Text = "Jean-Marc Salotti";
            // 
            // demarrer_btn
            // 
            this.demarrer_btn.BackColor = System.Drawing.Color.LimeGreen;
            this.demarrer_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.demarrer_btn.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.demarrer_btn.Location = new System.Drawing.Point(165, 226);
            this.demarrer_btn.Name = "demarrer_btn";
            this.demarrer_btn.Size = new System.Drawing.Size(138, 67);
            this.demarrer_btn.TabIndex = 6;
            this.demarrer_btn.Text = "Démarrer le test !";
            this.demarrer_btn.UseVisualStyleBackColor = false;
            this.demarrer_btn.Click += new System.EventHandler(this.demarrer_btn_Click);
            // 
            // dateDS_txt
            // 
            this.dateDS_txt.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.dateDS_txt.AutoSize = true;
            this.dateDS_txt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateDS_txt.Font = new System.Drawing.Font("Gill Sans MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDS_txt.Location = new System.Drawing.Point(26, 44);
            this.dateDS_txt.Name = "dateDS_txt";
            this.dateDS_txt.Size = new System.Drawing.Size(52, 16);
            this.dateDS_txt.TabIndex = 7;
            this.dateDS_txt.Text = "DateTime\r\n";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(445, 314);
            this.Controls.Add(this.dateDS_txt);
            this.Controls.Add(this.demarrer_btn);
            this.Controls.Add(this.JMSalotti_txt);
            this.Controls.Add(this.TestIA_txt);
            this.Controls.Add(this.prenom_txtbox);
            this.Controls.Add(this.nom_txtbox);
            this.Controls.Add(this.prenom_txt);
            this.Controls.Add(this.nom_txt);
            this.Name = "MainForm";
            this.Text = "Accueil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nom_txt;
        private System.Windows.Forms.Label prenom_txt;
        private System.Windows.Forms.TextBox nom_txtbox;
        private System.Windows.Forms.Label TestIA_txt;
        private System.Windows.Forms.Label JMSalotti_txt;
        private System.Windows.Forms.Button demarrer_btn;
        private System.Windows.Forms.Label dateDS_txt;
        public System.Windows.Forms.TextBox prenom_txtbox;
    }
}

