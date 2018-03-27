namespace ProjetsDeJeux
{
    partial class EcranPrincipal
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
            this.btnRègles = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnFrancais = new System.Windows.Forms.Button();
            this.btnAnglais = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRègles
            // 
            this.btnRègles.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRègles.Location = new System.Drawing.Point(248, 12);
            this.btnRègles.Name = "btnRègles";
            this.btnRègles.Size = new System.Drawing.Size(83, 36);
            this.btnRègles.TabIndex = 2;
            this.btnRègles.Text = "Règles";
            this.btnRègles.UseVisualStyleBackColor = true;
            this.btnRègles.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackgroundImage = global::ProjetsDeJeux.Properties.Resources.fermer;
            this.btnQuitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuitter.Location = new System.Drawing.Point(140, 145);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(59, 47);
            this.btnQuitter.TabIndex = 3;
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnFrancais
            // 
            this.btnFrancais.BackgroundImage = global::ProjetsDeJeux.Properties.Resources.fr;
            this.btnFrancais.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFrancais.Location = new System.Drawing.Point(189, 54);
            this.btnFrancais.Name = "btnFrancais";
            this.btnFrancais.Size = new System.Drawing.Size(142, 76);
            this.btnFrancais.TabIndex = 1;
            this.btnFrancais.UseVisualStyleBackColor = true;
            this.btnFrancais.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAnglais
            // 
            this.btnAnglais.BackgroundImage = global::ProjetsDeJeux.Properties.Resources.En;
            this.btnAnglais.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnglais.Location = new System.Drawing.Point(12, 54);
            this.btnAnglais.Name = "btnAnglais";
            this.btnAnglais.Size = new System.Drawing.Size(147, 76);
            this.btnAnglais.TabIndex = 0;
            this.btnAnglais.UseVisualStyleBackColor = true;
            this.btnAnglais.Click += new System.EventHandler(this.button1_Click);
            // 
            // EcranPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 195);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnRègles);
            this.Controls.Add(this.btnFrancais);
            this.Controls.Add(this.btnAnglais);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "EcranPrincipal";
            this.Text = "Choix De  La Langue";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAnglais;
        private System.Windows.Forms.Button btnFrancais;
        private System.Windows.Forms.Button btnRègles;
        private System.Windows.Forms.Button btnQuitter;
    }
}

