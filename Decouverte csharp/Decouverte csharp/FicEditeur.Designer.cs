namespace Decouverte_csharp
{
    partial class EcranEditeur
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
            this.mEditeur = new System.Windows.Forms.MenuStrip();
            this.meFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.mefNouveu = new System.Windows.Forms.ToolStripMenuItem();
            this.mefOuvrir = new System.Windows.Forms.ToolStripMenuItem();
            this.mefSauver = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mefQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.meEditer = new System.Windows.Forms.ToolStripMenuItem();
            this.meeCouper = new System.Windows.Forms.ToolStripMenuItem();
            this.meeCopier = new System.Windows.Forms.ToolStripMenuItem();
            this.meeColler = new System.Windows.Forms.ToolStripMenuItem();
            this.meFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.mefJustifier = new System.Windows.Forms.ToolStripMenuItem();
            this.mefjGauche = new System.Windows.Forms.ToolStripMenuItem();
            this.mefjDroite = new System.Windows.Forms.ToolStripMenuItem();
            this.mefjCentrer = new System.Windows.Forms.ToolStripMenuItem();
            this.mefPolicce = new System.Windows.Forms.ToolStripMenuItem();
            this.mefCaractere = new System.Windows.Forms.ToolStripMenuItem();
            this.mefcGras = new System.Windows.Forms.ToolStripMenuItem();
            this.mefcItalique = new System.Windows.Forms.ToolStripMenuItem();
            this.mefcSouligner = new System.Windows.Forms.ToolStripMenuItem();
            this.mefcBarre = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgOuvrirFichier = new System.Windows.Forms.OpenFileDialog();
            this.dlgsauverFichier = new System.Windows.Forms.SaveFileDialog();
            this.dlgPolice = new System.Windows.Forms.FontDialog();
            this.pBarreBouton = new System.Windows.Forms.Panel();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnOuvrir = new System.Windows.Forms.Button();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.mEditeur.SuspendLayout();
            this.pBarreBouton.SuspendLayout();
            this.SuspendLayout();
            // 
            // mEditeur
            // 
            this.mEditeur.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meFichier,
            this.meEditer,
            this.meFormat});
            this.mEditeur.Location = new System.Drawing.Point(0, 0);
            this.mEditeur.Name = "mEditeur";
            this.mEditeur.Size = new System.Drawing.Size(409, 24);
            this.mEditeur.TabIndex = 0;
            this.mEditeur.Text = "menuStrip1";
            // 
            // meFichier
            // 
            this.meFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mefNouveu,
            this.mefOuvrir,
            this.mefSauver,
            this.toolStripMenuItem1,
            this.mefQuitter});
            this.meFichier.Name = "meFichier";
            this.meFichier.Size = new System.Drawing.Size(54, 20);
            this.meFichier.Text = "Fichier";
            // 
            // mefNouveu
            // 
            this.mefNouveu.Name = "mefNouveu";
            this.mefNouveu.Size = new System.Drawing.Size(152, 22);
            this.mefNouveu.Text = "Nouveau";
            this.mefNouveu.Click += new System.EventHandler(this.mefNouveu_Click);
            // 
            // mefOuvrir
            // 
            this.mefOuvrir.Name = "mefOuvrir";
            this.mefOuvrir.Size = new System.Drawing.Size(152, 22);
            this.mefOuvrir.Text = "Ouvrir";
            this.mefOuvrir.Click += new System.EventHandler(this.mefOuvrir_Click);
            // 
            // mefSauver
            // 
            this.mefSauver.Name = "mefSauver";
            this.mefSauver.Size = new System.Drawing.Size(152, 22);
            this.mefSauver.Text = "Sauver";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // mefQuitter
            // 
            this.mefQuitter.Name = "mefQuitter";
            this.mefQuitter.Size = new System.Drawing.Size(152, 22);
            this.mefQuitter.Text = "Quitter";
            // 
            // meEditer
            // 
            this.meEditer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meeCouper,
            this.meeCopier,
            this.meeColler});
            this.meEditer.Name = "meEditer";
            this.meEditer.Size = new System.Drawing.Size(49, 20);
            this.meEditer.Text = "Editer";
            // 
            // meeCouper
            // 
            this.meeCouper.Name = "meeCouper";
            this.meeCouper.Size = new System.Drawing.Size(152, 22);
            this.meeCouper.Text = "Couper";
            this.meeCouper.Click += new System.EventHandler(this.meeCouper_Click);
            // 
            // meeCopier
            // 
            this.meeCopier.Name = "meeCopier";
            this.meeCopier.Size = new System.Drawing.Size(152, 22);
            this.meeCopier.Text = "Copier";
            this.meeCopier.Click += new System.EventHandler(this.meeCopier_Click);
            // 
            // meeColler
            // 
            this.meeColler.Name = "meeColler";
            this.meeColler.Size = new System.Drawing.Size(152, 22);
            this.meeColler.Text = "Coller";
            this.meeColler.Click += new System.EventHandler(this.meeColler_Click);
            // 
            // meFormat
            // 
            this.meFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mefJustifier,
            this.mefPolicce,
            this.mefCaractere});
            this.meFormat.Name = "meFormat";
            this.meFormat.Size = new System.Drawing.Size(57, 20);
            this.meFormat.Text = "Format";
            // 
            // mefJustifier
            // 
            this.mefJustifier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mefjGauche,
            this.mefjDroite,
            this.mefjCentrer});
            this.mefJustifier.Name = "mefJustifier";
            this.mefJustifier.Size = new System.Drawing.Size(152, 22);
            this.mefJustifier.Text = "Justifeir";
            // 
            // mefjGauche
            // 
            this.mefjGauche.Name = "mefjGauche";
            this.mefjGauche.Size = new System.Drawing.Size(152, 22);
            this.mefjGauche.Text = "Gauche";
            this.mefjGauche.Click += new System.EventHandler(this.mefjGauche_Click);
            // 
            // mefjDroite
            // 
            this.mefjDroite.Name = "mefjDroite";
            this.mefjDroite.Size = new System.Drawing.Size(152, 22);
            this.mefjDroite.Text = "Droite";
            this.mefjDroite.Click += new System.EventHandler(this.mefjDroite_Click);
            // 
            // mefjCentrer
            // 
            this.mefjCentrer.Name = "mefjCentrer";
            this.mefjCentrer.Size = new System.Drawing.Size(152, 22);
            this.mefjCentrer.Text = "Centrer";
            this.mefjCentrer.Click += new System.EventHandler(this.mefjCentrer_Click);
            // 
            // mefPolicce
            // 
            this.mefPolicce.Name = "mefPolicce";
            this.mefPolicce.Size = new System.Drawing.Size(152, 22);
            this.mefPolicce.Text = "Police";
            this.mefPolicce.Click += new System.EventHandler(this.mefPolicce_Click);
            // 
            // mefCaractere
            // 
            this.mefCaractere.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mefcGras,
            this.mefcItalique,
            this.mefcSouligner,
            this.mefcBarre});
            this.mefCaractere.Name = "mefCaractere";
            this.mefCaractere.Size = new System.Drawing.Size(152, 22);
            this.mefCaractere.Text = "Caractère";
            // 
            // mefcGras
            // 
            this.mefcGras.Name = "mefcGras";
            this.mefcGras.Size = new System.Drawing.Size(152, 22);
            this.mefcGras.Text = "Gras";
            this.mefcGras.Click += new System.EventHandler(this.mefcGras_Click);
            // 
            // mefcItalique
            // 
            this.mefcItalique.Name = "mefcItalique";
            this.mefcItalique.Size = new System.Drawing.Size(152, 22);
            this.mefcItalique.Text = "Italique";
            this.mefcItalique.Click += new System.EventHandler(this.mefcItalique_Click);
            // 
            // mefcSouligner
            // 
            this.mefcSouligner.Name = "mefcSouligner";
            this.mefcSouligner.Size = new System.Drawing.Size(152, 22);
            this.mefcSouligner.Text = "Souligner";
            this.mefcSouligner.Click += new System.EventHandler(this.mefcSouligner_Click);
            // 
            // mefcBarre
            // 
            this.mefcBarre.Name = "mefcBarre";
            this.mefcBarre.Size = new System.Drawing.Size(152, 22);
            this.mefcBarre.Text = "Barrer";
            this.mefcBarre.Click += new System.EventHandler(this.mefcBarre_Click);
            // 
            // dlgOuvrirFichier
            // 
            this.dlgOuvrirFichier.FileName = "openFileDialog1";
            this.dlgOuvrirFichier.Filter = "NosFichier(*.mesdocs) |*.mesdocs | Tous Fichiers(*.*)|*.*";
            // 
            // dlgsauverFichier
            // 
            this.dlgsauverFichier.Filter = "NosFichier(*.mesdocs) |*.mesdocs | Tous Fichiers(*.*)|*.*";
            // 
            // pBarreBouton
            // 
            this.pBarreBouton.Controls.Add(this.btnQuitter);
            this.pBarreBouton.Controls.Add(this.btnEnregistrer);
            this.pBarreBouton.Controls.Add(this.btnOuvrir);
            this.pBarreBouton.Controls.Add(this.btnNouveau);
            this.pBarreBouton.Dock = System.Windows.Forms.DockStyle.Top;
            this.pBarreBouton.Location = new System.Drawing.Point(0, 24);
            this.pBarreBouton.Name = "pBarreBouton";
            this.pBarreBouton.Size = new System.Drawing.Size(409, 39);
            this.pBarreBouton.TabIndex = 1;
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackgroundImage = global::Decouverte_csharp.Properties.Resources.exit1;
            this.btnQuitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuitter.Location = new System.Drawing.Point(113, 3);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(34, 33);
            this.btnQuitter.TabIndex = 3;
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BackgroundImage = global::Decouverte_csharp.Properties.Resources.save;
            this.btnEnregistrer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEnregistrer.Location = new System.Drawing.Point(77, 3);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(30, 33);
            this.btnEnregistrer.TabIndex = 2;
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnOuvrir
            // 
            this.btnOuvrir.BackgroundImage = global::Decouverte_csharp.Properties.Resources.Open;
            this.btnOuvrir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOuvrir.Location = new System.Drawing.Point(41, 3);
            this.btnOuvrir.Name = "btnOuvrir";
            this.btnOuvrir.Size = new System.Drawing.Size(30, 33);
            this.btnOuvrir.TabIndex = 1;
            this.btnOuvrir.UseVisualStyleBackColor = true;
            this.btnOuvrir.Click += new System.EventHandler(this.mefOuvrir_Click);
            // 
            // btnNouveau
            // 
            this.btnNouveau.BackgroundImage = global::Decouverte_csharp.Properties.Resources._new;
            this.btnNouveau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNouveau.Location = new System.Drawing.Point(5, 3);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(30, 33);
            this.btnNouveau.TabIndex = 0;
            this.btnNouveau.UseVisualStyleBackColor = true;
            this.btnNouveau.Click += new System.EventHandler(this.mefNouveu_Click);
            // 
            // rtbText
            // 
            this.rtbText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbText.Location = new System.Drawing.Point(0, 63);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(409, 259);
            this.rtbText.TabIndex = 2;
            this.rtbText.Text = "";
            this.rtbText.TextChanged += new System.EventHandler(this.rtbText_TextChanged);
            // 
            // EcranEditeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 322);
            this.Controls.Add(this.rtbText);
            this.Controls.Add(this.pBarreBouton);
            this.Controls.Add(this.mEditeur);
            this.MainMenuStrip = this.mEditeur;
            this.Name = "EcranEditeur";
            this.Text = "Traitement de texte... en toute modestie";
            this.mEditeur.ResumeLayout(false);
            this.mEditeur.PerformLayout();
            this.pBarreBouton.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mEditeur;
        private System.Windows.Forms.OpenFileDialog dlgOuvrirFichier;
        private System.Windows.Forms.SaveFileDialog dlgsauverFichier;
        private System.Windows.Forms.FontDialog dlgPolice;
        private System.Windows.Forms.Panel pBarreBouton;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnOuvrir;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.RichTextBox rtbText;
        private System.Windows.Forms.ToolStripMenuItem meFichier;
        private System.Windows.Forms.ToolStripMenuItem mefNouveu;
        private System.Windows.Forms.ToolStripMenuItem mefOuvrir;
        private System.Windows.Forms.ToolStripMenuItem mefSauver;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mefQuitter;
        private System.Windows.Forms.ToolStripMenuItem meEditer;
        private System.Windows.Forms.ToolStripMenuItem meeCouper;
        private System.Windows.Forms.ToolStripMenuItem meeCopier;
        private System.Windows.Forms.ToolStripMenuItem meeColler;
        private System.Windows.Forms.ToolStripMenuItem meFormat;
        private System.Windows.Forms.ToolStripMenuItem mefJustifier;
        private System.Windows.Forms.ToolStripMenuItem mefjGauche;
        private System.Windows.Forms.ToolStripMenuItem mefjDroite;
        private System.Windows.Forms.ToolStripMenuItem mefjCentrer;
        private System.Windows.Forms.ToolStripMenuItem mefPolicce;
        private System.Windows.Forms.ToolStripMenuItem mefCaractere;
        private System.Windows.Forms.ToolStripMenuItem mefcGras;
        private System.Windows.Forms.ToolStripMenuItem mefcItalique;
        private System.Windows.Forms.ToolStripMenuItem mefcSouligner;
        private System.Windows.Forms.ToolStripMenuItem mefcBarre;
    }
}