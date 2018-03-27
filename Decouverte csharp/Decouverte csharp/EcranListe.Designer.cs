namespace Decouverte_csharp
{
    partial class EcranListe
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
            this.lblFichier = new System.Windows.Forms.Label();
            this.lbPersonne = new System.Windows.Forms.ListBox();
            this.btnOuvrir = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.gbDétail = new System.Windows.Forms.GroupBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.cbQualité = new System.Windows.Forms.ComboBox();
            this.dlgOuvrir = new System.Windows.Forms.OpenFileDialog();
            this.dlgEnregistrer = new System.Windows.Forms.SaveFileDialog();
            this.gbDétail.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFichier
            // 
            this.lblFichier.AutoSize = true;
            this.lblFichier.Location = new System.Drawing.Point(12, 14);
            this.lblFichier.Name = "lblFichier";
            this.lblFichier.Size = new System.Drawing.Size(75, 13);
            this.lblFichier.TabIndex = 0;
            this.lblFichier.Text = "Nom de fichier";
            // 
            // lbPersonne
            // 
            this.lbPersonne.FormattingEnabled = true;
            this.lbPersonne.Location = new System.Drawing.Point(8, 45);
            this.lbPersonne.Name = "lbPersonne";
            this.lbPersonne.Size = new System.Drawing.Size(320, 121);
            this.lbPersonne.Sorted = true;
            this.lbPersonne.TabIndex = 0;
            this.lbPersonne.DoubleClick += new System.EventHandler(this.lbPersonne_DoubleClick);
            // 
            // btnOuvrir
            // 
            this.btnOuvrir.Location = new System.Drawing.Point(8, 172);
            this.btnOuvrir.Name = "btnOuvrir";
            this.btnOuvrir.Size = new System.Drawing.Size(75, 23);
            this.btnOuvrir.TabIndex = 1;
            this.btnOuvrir.Text = "Ouvrir";
            this.btnOuvrir.UseVisualStyleBackColor = true;
            this.btnOuvrir.Click += new System.EventHandler(this.btnOuvrir_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(8, 217);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.btnEnregistrer.TabIndex = 2;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(8, 260);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 3;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(8, 303);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 4;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // gbDétail
            // 
            this.gbDétail.Controls.Add(this.btnAnnuler);
            this.gbDétail.Controls.Add(this.btnConfirmer);
            this.gbDétail.Controls.Add(this.tbNom);
            this.gbDétail.Controls.Add(this.lblNom);
            this.gbDétail.Controls.Add(this.cbQualité);
            this.gbDétail.Location = new System.Drawing.Point(96, 172);
            this.gbDétail.Name = "gbDétail";
            this.gbDétail.Size = new System.Drawing.Size(232, 154);
            this.gbDétail.TabIndex = 6;
            this.gbDétail.TabStop = false;
            this.gbDétail.Text = "Détail Personne";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(126, 121);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(96, 27);
            this.btnAnnuler.TabIndex = 4;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Location = new System.Drawing.Point(10, 121);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(93, 27);
            this.btnConfirmer.TabIndex = 3;
            this.btnConfirmer.Text = "Confirmer";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(10, 79);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(212, 20);
            this.tbNom.TabIndex = 2;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(7, 55);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(29, 13);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nom";
            // 
            // cbQualité
            // 
            this.cbQualité.FormattingEnabled = true;
            this.cbQualité.Items.AddRange(new object[] {
            "Madame",
            "Mademoiselle",
            "Monsieur",
            "MonDamoiseau",
            "Indéfini"});
            this.cbQualité.Location = new System.Drawing.Point(10, 19);
            this.cbQualité.Name = "cbQualité";
            this.cbQualité.Size = new System.Drawing.Size(212, 21);
            this.cbQualité.TabIndex = 0;
            // 
            // dlgOuvrir
            // 
            this.dlgOuvrir.FileName = "openFileDialog1";
            // 
            // EcranListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 339);
            this.Controls.Add(this.gbDétail);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.btnOuvrir);
            this.Controls.Add(this.lbPersonne);
            this.Controls.Add(this.lblFichier);
            this.Name = "EcranListe";
            this.Text = "Manipulation d\'une Liste";
            this.gbDétail.ResumeLayout(false);
            this.gbDétail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFichier;
        private System.Windows.Forms.ListBox lbPersonne;
        private System.Windows.Forms.Button btnOuvrir;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.GroupBox gbDétail;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.ComboBox cbQualité;
        private System.Windows.Forms.OpenFileDialog dlgOuvrir;
        private System.Windows.Forms.SaveFileDialog dlgEnregistrer;
    }
}