namespace DSensc
{
    partial class Questions
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
            this.TestIA_txt = new System.Windows.Forms.Label();
            this.demarrer_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TestIA_txt
            // 
            this.TestIA_txt.AutoSize = true;
            this.TestIA_txt.Cursor = System.Windows.Forms.Cursors.Default;
            this.TestIA_txt.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestIA_txt.Location = new System.Drawing.Point(237, 18);
            this.TestIA_txt.Name = "TestIA_txt";
            this.TestIA_txt.Size = new System.Drawing.Size(145, 42);
            this.TestIA_txt.TabIndex = 5;
            this.TestIA_txt.Text = "Test IA";
            // 
            // demarrer_btn
            // 
            this.demarrer_btn.BackColor = System.Drawing.Color.LimeGreen;
            this.demarrer_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.demarrer_btn.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.demarrer_btn.Location = new System.Drawing.Point(54, 39);
            this.demarrer_btn.Name = "demarrer_btn";
            this.demarrer_btn.Size = new System.Drawing.Size(138, 67);
            this.demarrer_btn.TabIndex = 7;
            this.demarrer_btn.Text = "Démarrer le test !";
            this.demarrer_btn.UseVisualStyleBackColor = false;
            // 
            // Questions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(606, 493);
            this.Controls.Add(this.demarrer_btn);
            this.Controls.Add(this.TestIA_txt);
            this.Name = "Questions";
            this.Text = "Test IA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TestIA_txt;
        private System.Windows.Forms.Button demarrer_btn;
    }
}