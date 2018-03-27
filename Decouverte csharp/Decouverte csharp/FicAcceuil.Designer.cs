namespace Decouverte_csharp
{
    partial class EcranAcceuil
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
            this.btnPoussez = new System.Windows.Forms.Button();
            this.btnEntrez = new System.Windows.Forms.Button();
            this.lblTitre = new System.Windows.Forms.Label();
            this.pbImageDepart = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageDepart)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPoussez
            // 
            this.btnPoussez.Font = new System.Drawing.Font("Script MT Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoussez.Location = new System.Drawing.Point(24, 221);
            this.btnPoussez.Name = "btnPoussez";
            this.btnPoussez.Size = new System.Drawing.Size(137, 41);
            this.btnPoussez.TabIndex = 0;
            this.btnPoussez.Text = "Poussez";
            this.btnPoussez.UseVisualStyleBackColor = true;
            this.btnPoussez.Click += new System.EventHandler(this.btnPoussez_Click);
            // 
            // btnEntrez
            // 
            this.btnEntrez.Font = new System.Drawing.Font("Script MT Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrez.Location = new System.Drawing.Point(326, 221);
            this.btnEntrez.Name = "btnEntrez";
            this.btnEntrez.Size = new System.Drawing.Size(137, 41);
            this.btnEntrez.TabIndex = 1;
            this.btnEntrez.Text = "Entrez";
            this.btnEntrez.UseVisualStyleBackColor = true;
            this.btnEntrez.Click += new System.EventHandler(this.btnEntrez_Click);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(112, 42);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(284, 27);
            this.lblTitre.TabIndex = 2;
            this.lblTitre.Text = "Decouverte du Csharp";
            // 
            // pbImageDepart
            // 
            this.pbImageDepart.Location = new System.Drawing.Point(170, 88);
            this.pbImageDepart.Name = "pbImageDepart";
            this.pbImageDepart.Size = new System.Drawing.Size(152, 112);
            this.pbImageDepart.TabIndex = 3;
            this.pbImageDepart.TabStop = false;
            // 
            // EcranAcceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(492, 274);
            this.Controls.Add(this.pbImageDepart);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.btnEntrez);
            this.Controls.Add(this.btnPoussez);
            this.Name = "EcranAcceuil";
            this.Text = "bienvenue, Welcome";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EcranAcceuil_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbImageDepart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPoussez;
        private System.Windows.Forms.Button btnEntrez;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.PictureBox pbImageDepart;
    }
}

