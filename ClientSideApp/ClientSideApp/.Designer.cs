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
            this.monTimer = new System.Windows.Forms.Timer(this.components);
            this.lbl_txt_sec = new System.Windows.Forms.Label();
            this.lbl_compteur = new System.Windows.Forms.Label();
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
            this.lbl_JetonGenere.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_JetonGenere.Location = new System.Drawing.Point(475, 22);
            this.lbl_JetonGenere.Name = "lbl_JetonGenere";
            this.lbl_JetonGenere.Size = new System.Drawing.Size(149, 29);
            this.lbl_JetonGenere.TabIndex = 2;
            this.lbl_JetonGenere.Text = "01234567";
            // 
            // progressBarWithText1
            // 
            this.progressBarWithText1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.progressBarWithText1.Location = new System.Drawing.Point(45, 132);
            this.progressBarWithText1.MarqueeAnimationSpeed = 1000;
            this.progressBarWithText1.Maximum = 60;
            this.progressBarWithText1.Name = "progressBarWithText1";
            this.progressBarWithText1.Secondes = 0;
            this.progressBarWithText1.Size = new System.Drawing.Size(571, 61);
            this.progressBarWithText1.Step = 1;
            this.progressBarWithText1.TabIndex = 3;
            this.progressBarWithText1.Value = 60;
            // 
            // monTimer
            // 
            this.monTimer.Enabled = true;
            this.monTimer.Interval = 1000;
            // 
            // lbl_txt_sec
            // 
            this.lbl_txt_sec.AutoSize = true;
            this.lbl_txt_sec.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_txt_sec.Location = new System.Drawing.Point(45, 92);
            this.lbl_txt_sec.Name = "lbl_txt_sec";
            this.lbl_txt_sec.Size = new System.Drawing.Size(257, 23);
            this.lbl_txt_sec.TabIndex = 4;
            this.lbl_txt_sec.Text = "Secondes restantes:";
            // 
            // lbl_compteur
            // 
            this.lbl_compteur.AutoSize = true;
            this.lbl_compteur.Font = new System.Drawing.Font("OCR A Extended", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_compteur.Location = new System.Drawing.Point(308, 80);
            this.lbl_compteur.Name = "lbl_compteur";
            this.lbl_compteur.Size = new System.Drawing.Size(55, 35);
            this.lbl_compteur.TabIndex = 5;
            this.lbl_compteur.Text = "60";
            // 
            // GenerateurDeJetons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(668, 225);
            this.Controls.Add(this.lbl_compteur);
            this.Controls.Add(this.lbl_txt_sec);
            this.Controls.Add(this.progressBarWithText1);
            this.Controls.Add(this.lbl_JetonGenere);
            this.Controls.Add(this.lbl_TitreJeton);
            this.Name = "GenerateurDeJetons";
            this.Text = "Generateur de jetons";
            this.Shown += new System.EventHandler(this.GenerateurDeJetons_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_TitreJeton;
        private System.Windows.Forms.Label lbl_JetonGenere;
        private CustomTools.ProgressBarWithText progressBarWithText1;
        private System.Windows.Forms.Timer monTimer;
        private System.Windows.Forms.Label lbl_txt_sec;
        private System.Windows.Forms.Label lbl_compteur;
    }
}

