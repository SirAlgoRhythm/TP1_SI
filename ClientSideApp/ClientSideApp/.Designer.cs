namespace ClientSideApp
{
    partial class GenerateurDeJetons
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
            this.components = new System.ComponentModel.Container();
            this.lbl_TitreJeton = new System.Windows.Forms.Label();
            this.lbl_JetonGenere = new System.Windows.Forms.Label();
            this.progressBarWithText1 = new ClientSideApp.CustomTools.ProgressBarWithText(this.components);
            this.SuspendLayout();
            // 
            // lbl_TitreJeton
            // 
            this.lbl_TitreJeton.AutoSize = true;
            this.lbl_TitreJeton.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TitreJeton.Location = new System.Drawing.Point(40, 22);
            this.lbl_TitreJeton.Name = "lbl_TitreJeton";
            this.lbl_TitreJeton.Size = new System.Drawing.Size(429, 29);
            this.lbl_TitreJeton.TabIndex = 1;
            this.lbl_TitreJeton.Text = "Jeton d\'authentification :";
            // 
            // lbl_JetonGenere
            // 
            this.lbl_JetonGenere.AutoSize = true;
            this.lbl_JetonGenere.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_JetonGenere.Location = new System.Drawing.Point(475, 22);
            this.lbl_JetonGenere.Name = "lbl_JetonGenere";
            this.lbl_JetonGenere.Size = new System.Drawing.Size(141, 29);
            this.lbl_JetonGenere.TabIndex = 2;
            this.lbl_JetonGenere.Text = "01234567";
            // 
            // progressBarWithText1
            // 
            this.progressBarWithText1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.progressBarWithText1.Location = new System.Drawing.Point(45, 93);
            this.progressBarWithText1.MarqueeAnimationSpeed = 1000;
            this.progressBarWithText1.Maximum = 60;
            this.progressBarWithText1.Name = "progressBarWithText1";
            this.progressBarWithText1.Size = new System.Drawing.Size(571, 61);
            this.progressBarWithText1.Step = 1;
            this.progressBarWithText1.TabIndex = 3;
            // 
            // GenerateurDeJetons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(668, 184);
            this.Controls.Add(this.progressBarWithText1);
            this.Controls.Add(this.lbl_JetonGenere);
            this.Controls.Add(this.lbl_TitreJeton);
            this.Name = "GenerateurDeJetons";
            this.Text = "Generateur de jetons";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_TitreJeton;
        private System.Windows.Forms.Label lbl_JetonGenere;
        private CustomTools.ProgressBarWithText progressBarWithText1;
    }
}

