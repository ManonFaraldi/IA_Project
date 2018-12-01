namespace DSensc
{
    partial class ResultForm
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
            this.close_btn = new System.Windows.Forms.Button();
            this.result_lbl = new System.Windows.Forms.Label();
            this.part_lbl = new System.Windows.Forms.Label();
            this.part2_lbl = new System.Windows.Forms.Label();
            this.note1_lbl = new System.Windows.Forms.Label();
            this.note2_lbl = new System.Windows.Forms.Label();
            this.total_lbl = new System.Windows.Forms.Label();
            this.noteFinal_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // close_btn
            // 
            this.close_btn.Location = new System.Drawing.Point(119, 247);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(75, 23);
            this.close_btn.TabIndex = 0;
            this.close_btn.Text = "Fermer";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // result_lbl
            // 
            this.result_lbl.AutoSize = true;
            this.result_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_lbl.Location = new System.Drawing.Point(115, 20);
            this.result_lbl.Name = "result_lbl";
            this.result_lbl.Size = new System.Drawing.Size(86, 20);
            this.result_lbl.TabIndex = 1;
            this.result_lbl.Text = "Résultats";
            // 
            // part_lbl
            // 
            this.part_lbl.AutoSize = true;
            this.part_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.part_lbl.Location = new System.Drawing.Point(23, 67);
            this.part_lbl.Name = "part_lbl";
            this.part_lbl.Size = new System.Drawing.Size(71, 20);
            this.part_lbl.TabIndex = 2;
            this.part_lbl.Text = "Partie I : ";
            // 
            // part2_lbl
            // 
            this.part2_lbl.AutoSize = true;
            this.part2_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.part2_lbl.Location = new System.Drawing.Point(23, 129);
            this.part2_lbl.Name = "part2_lbl";
            this.part2_lbl.Size = new System.Drawing.Size(76, 20);
            this.part2_lbl.TabIndex = 3;
            this.part2_lbl.Text = "Partie II : ";
            // 
            // note1_lbl
            // 
            this.note1_lbl.AutoSize = true;
            this.note1_lbl.Location = new System.Drawing.Point(133, 72);
            this.note1_lbl.Name = "note1_lbl";
            this.note1_lbl.Size = new System.Drawing.Size(61, 13);
            this.note1_lbl.TabIndex = 4;
            this.note1_lbl.Text = "Note_Part1";
            // 
            // note2_lbl
            // 
            this.note2_lbl.AutoSize = true;
            this.note2_lbl.Location = new System.Drawing.Point(133, 134);
            this.note2_lbl.Name = "note2_lbl";
            this.note2_lbl.Size = new System.Drawing.Size(61, 13);
            this.note2_lbl.TabIndex = 5;
            this.note2_lbl.Text = "Note_Part2";
            // 
            // total_lbl
            // 
            this.total_lbl.AutoSize = true;
            this.total_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_lbl.Location = new System.Drawing.Point(35, 185);
            this.total_lbl.Name = "total_lbl";
            this.total_lbl.Size = new System.Drawing.Size(44, 20);
            this.total_lbl.TabIndex = 6;
            this.total_lbl.Text = "Total";
            // 
            // noteFinal_lbl
            // 
            this.noteFinal_lbl.AutoSize = true;
            this.noteFinal_lbl.Location = new System.Drawing.Point(133, 186);
            this.noteFinal_lbl.Name = "noteFinal_lbl";
            this.noteFinal_lbl.Size = new System.Drawing.Size(58, 13);
            this.noteFinal_lbl.TabIndex = 8;
            this.noteFinal_lbl.Text = "Note_Final";
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 282);
            this.Controls.Add(this.noteFinal_lbl);
            this.Controls.Add(this.total_lbl);
            this.Controls.Add(this.note2_lbl);
            this.Controls.Add(this.note1_lbl);
            this.Controls.Add(this.part2_lbl);
            this.Controls.Add(this.part_lbl);
            this.Controls.Add(this.result_lbl);
            this.Controls.Add(this.close_btn);
            this.Name = "ResultForm";
            this.Text = "ResultForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Label result_lbl;
        private System.Windows.Forms.Label part_lbl;
        private System.Windows.Forms.Label part2_lbl;
        private System.Windows.Forms.Label note1_lbl;
        private System.Windows.Forms.Label note2_lbl;
        private System.Windows.Forms.Label total_lbl;
        private System.Windows.Forms.Label noteFinal_lbl;
    }
}