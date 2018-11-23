namespace Afficheur
{
    partial class AffichageQuestion
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AffichageQuestion));
            this.intituleQuestion = new System.Windows.Forms.Label();
            this.envoyer = new System.Windows.Forms.Button();
            this.quitter = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // intituleQuestion
            // 
            this.intituleQuestion.AutoEllipsis = true;
            this.intituleQuestion.BackColor = System.Drawing.Color.Transparent;
            this.intituleQuestion.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intituleQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(0)))), ((int)(((byte)(56)))));
            this.intituleQuestion.Location = new System.Drawing.Point(14, 0);
            this.intituleQuestion.Name = "intituleQuestion";
            this.intituleQuestion.Padding = new System.Windows.Forms.Padding(20);
            this.intituleQuestion.Size = new System.Drawing.Size(750, 109);
            this.intituleQuestion.TabIndex = 0;
            this.intituleQuestion.Text = "question";
            // 
            // envoyer
            // 
            this.envoyer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("envoyer.BackgroundImage")));
            this.envoyer.Location = new System.Drawing.Point(353, 443);
            this.envoyer.Name = "envoyer";
            this.envoyer.Size = new System.Drawing.Size(110, 41);
            this.envoyer.TabIndex = 1;
            this.envoyer.Text = "Envoyer";
            this.envoyer.UseVisualStyleBackColor = true;
            this.envoyer.Click += new System.EventHandler(this.envoyer_Click);
            // 
            // quitter
            // 
            this.quitter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("quitter.BackgroundImage")));
            this.quitter.Location = new System.Drawing.Point(667, 452);
            this.quitter.Name = "quitter";
            this.quitter.Size = new System.Drawing.Size(75, 23);
            this.quitter.TabIndex = 2;
            this.quitter.Text = "Quitter";
            this.quitter.UseVisualStyleBackColor = true;
            this.quitter.Click += new System.EventHandler(this.quitter_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.Location = new System.Drawing.Point(18, 112);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(228, 300);
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            this.pictureBox.Visible = false;
            // 
            // AffichageQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.quitter);
            this.Controls.Add(this.envoyer);
            this.Controls.Add(this.intituleQuestion);
            this.Name = "AffichageQuestion";
            this.Size = new System.Drawing.Size(780, 525);
            this.Load += new System.EventHandler(this.AffichageQuestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label intituleQuestion;
        private System.Windows.Forms.Button envoyer;
        private System.Windows.Forms.Button quitter;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}
