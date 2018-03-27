namespace Decouverte_csharp
{
    partial class EcranProgression
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
            this.lblSecondaire = new System.Windows.Forms.Label();
            this.pbSecondaire = new System.Windows.Forms.ProgressBar();
            this.lblPrincipal = new System.Windows.Forms.Label();
            this.pbPrincipal = new System.Windows.Forms.ProgressBar();
            this.btnExecuter = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSecondaire
            // 
            this.lblSecondaire.AutoSize = true;
            this.lblSecondaire.Font = new System.Drawing.Font("Script MT Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondaire.ForeColor = System.Drawing.Color.Maroon;
            this.lblSecondaire.Location = new System.Drawing.Point(13, 22);
            this.lblSecondaire.Name = "lblSecondaire";
            this.lblSecondaire.Size = new System.Drawing.Size(132, 23);
            this.lblSecondaire.TabIndex = 0;
            this.lblSecondaire.Text = "Fichier (virtuel)";
            // 
            // pbSecondaire
            // 
            this.pbSecondaire.BackColor = System.Drawing.Color.Maroon;
            this.pbSecondaire.Location = new System.Drawing.Point(12, 59);
            this.pbSecondaire.Name = "pbSecondaire";
            this.pbSecondaire.Size = new System.Drawing.Size(300, 66);
            this.pbSecondaire.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbSecondaire.TabIndex = 1;
            // 
            // lblPrincipal
            // 
            this.lblPrincipal.AutoSize = true;
            this.lblPrincipal.Font = new System.Drawing.Font("Script MT Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrincipal.ForeColor = System.Drawing.Color.Maroon;
            this.lblPrincipal.Location = new System.Drawing.Point(13, 138);
            this.lblPrincipal.Name = "lblPrincipal";
            this.lblPrincipal.Size = new System.Drawing.Size(123, 23);
            this.lblPrincipal.TabIndex = 2;
            this.lblPrincipal.Text = "Copie (virtuel)";
            // 
            // pbPrincipal
            // 
            this.pbPrincipal.BackColor = System.Drawing.Color.Maroon;
            this.pbPrincipal.Location = new System.Drawing.Point(12, 173);
            this.pbPrincipal.Name = "pbPrincipal";
            this.pbPrincipal.Size = new System.Drawing.Size(300, 66);
            this.pbPrincipal.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbPrincipal.TabIndex = 3;
            // 
            // btnExecuter
            // 
            this.btnExecuter.Font = new System.Drawing.Font("Script MT Bold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecuter.ForeColor = System.Drawing.Color.Teal;
            this.btnExecuter.Location = new System.Drawing.Point(12, 264);
            this.btnExecuter.Name = "btnExecuter";
            this.btnExecuter.Size = new System.Drawing.Size(133, 39);
            this.btnExecuter.TabIndex = 4;
            this.btnExecuter.Text = "Executer";
            this.btnExecuter.UseVisualStyleBackColor = true;
            this.btnExecuter.Click += new System.EventHandler(this.btnExecuter_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Font = new System.Drawing.Font("Script MT Bold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.ForeColor = System.Drawing.Color.Teal;
            this.btnQuitter.Location = new System.Drawing.Point(179, 264);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(133, 39);
            this.btnQuitter.TabIndex = 5;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // EcranProgression
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 319);
            this.ControlBox = false;
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnExecuter);
            this.Controls.Add(this.pbPrincipal);
            this.Controls.Add(this.lblPrincipal);
            this.Controls.Add(this.pbSecondaire);
            this.Controls.Add(this.lblSecondaire);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "EcranProgression";
            this.Text = "Barre de Progression";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSecondaire;
        private System.Windows.Forms.ProgressBar pbSecondaire;
        private System.Windows.Forms.Label lblPrincipal;
        private System.Windows.Forms.ProgressBar pbPrincipal;
        private System.Windows.Forms.Button btnExecuter;
        private System.Windows.Forms.Button btnQuitter;
    }
}