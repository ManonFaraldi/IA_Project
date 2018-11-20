namespace App
{
    partial class ResultatsForm
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
            this.resultats_txt = new System.Windows.Forms.Label();
            this.sur20_txt = new System.Windows.Forms.Label();
            this.appreciaiton_txt = new System.Windows.Forms.Label();
            this.quitter_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TestIA_txt
            // 
            this.TestIA_txt.AutoSize = true;
            this.TestIA_txt.Cursor = System.Windows.Forms.Cursors.Default;
            this.TestIA_txt.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestIA_txt.Location = new System.Drawing.Point(159, 33);
            this.TestIA_txt.Name = "TestIA_txt";
            this.TestIA_txt.Size = new System.Drawing.Size(145, 42);
            this.TestIA_txt.TabIndex = 6;
            this.TestIA_txt.Text = "Test IA";
            // 
            // resultats_txt
            // 
            this.resultats_txt.AutoSize = true;
            this.resultats_txt.Font = new System.Drawing.Font("Gill Sans MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultats_txt.Location = new System.Drawing.Point(188, 91);
            this.resultats_txt.Name = "resultats_txt";
            this.resultats_txt.Size = new System.Drawing.Size(37, 38);
            this.resultats_txt.TabIndex = 9;
            this.resultats_txt.Text = "??";
            // 
            // sur20_txt
            // 
            this.sur20_txt.AutoSize = true;
            this.sur20_txt.Font = new System.Drawing.Font("Gill Sans MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sur20_txt.Location = new System.Drawing.Point(216, 91);
            this.sur20_txt.Name = "sur20_txt";
            this.sur20_txt.Size = new System.Drawing.Size(63, 38);
            this.sur20_txt.TabIndex = 10;
            this.sur20_txt.Text = "/ 20";
            // 
            // appreciaiton_txt
            // 
            this.appreciaiton_txt.AutoSize = true;
            this.appreciaiton_txt.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appreciaiton_txt.Location = new System.Drawing.Point(175, 146);
            this.appreciaiton_txt.Name = "appreciaiton_txt";
            this.appreciaiton_txt.Size = new System.Drawing.Size(104, 23);
            this.appreciaiton_txt.TabIndex = 11;
            this.appreciaiton_txt.Text = "appréciation";
            // 
            // quitter_btn
            // 
            this.quitter_btn.BackColor = System.Drawing.Color.LimeGreen;
            this.quitter_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quitter_btn.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitter_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.quitter_btn.Location = new System.Drawing.Point(195, 192);
            this.quitter_btn.Name = "quitter_btn";
            this.quitter_btn.Size = new System.Drawing.Size(82, 43);
            this.quitter_btn.TabIndex = 15;
            this.quitter_btn.Text = "Quitter";
            this.quitter_btn.UseVisualStyleBackColor = false;
            this.quitter_btn.Click += new System.EventHandler(this.quitter_btn_Click);
            // 
            // ResultatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(464, 284);
            this.Controls.Add(this.quitter_btn);
            this.Controls.Add(this.appreciaiton_txt);
            this.Controls.Add(this.sur20_txt);
            this.Controls.Add(this.resultats_txt);
            this.Controls.Add(this.TestIA_txt);
            this.Name = "ResultatsForm";
            this.Text = "Resultats";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TestIA_txt;
        private System.Windows.Forms.Label resultats_txt;
        private System.Windows.Forms.Label sur20_txt;
        private System.Windows.Forms.Label appreciaiton_txt;
        private System.Windows.Forms.Button quitter_btn;
    }
}