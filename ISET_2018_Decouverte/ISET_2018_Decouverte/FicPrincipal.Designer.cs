namespace ISET_2018_Decouverte
{
    partial class EcranPrincipal
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
            this.mMenu = new System.Windows.Forms.MenuStrip();
            this.mFenetres = new System.Windows.Forms.ToolStripMenuItem();
            this.mQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.mAide = new System.Windows.Forms.ToolStripMenuItem();
            this.mfProgression = new System.Windows.Forms.ToolStripMenuItem();
            this.mfListe = new System.Windows.Forms.ToolStripMenuItem();
            this.mfEditeur = new System.Windows.Forms.ToolStripMenuItem();
            this.mMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mMenu
            // 
            this.mMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFenetres,
            this.mAide,
            this.mQuitter});
            this.mMenu.Location = new System.Drawing.Point(0, 0);
            this.mMenu.Name = "mMenu";
            this.mMenu.Size = new System.Drawing.Size(1079, 33);
            this.mMenu.TabIndex = 0;
            this.mMenu.Text = "menuStrip1";
            // 
            // mFenetres
            // 
            this.mFenetres.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mfProgression,
            this.mfListe,
            this.mfEditeur});
            this.mFenetres.Name = "mFenetres";
            this.mFenetres.Size = new System.Drawing.Size(90, 29);
            this.mFenetres.Text = "Fenetres";
            // 
            // mQuitter
            // 
            this.mQuitter.Name = "mQuitter";
            this.mQuitter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mQuitter.Size = new System.Drawing.Size(79, 29);
            this.mQuitter.Text = "Quitter";
            this.mQuitter.Click += new System.EventHandler(this.mQuitter_Click);
            // 
            // mAide
            // 
            this.mAide.Name = "mAide";
            this.mAide.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.mAide.Size = new System.Drawing.Size(60, 29);
            this.mAide.Text = "Aide";
            // 
            // mfProgression
            // 
            this.mfProgression.Name = "mfProgression";
            this.mfProgression.Size = new System.Drawing.Size(268, 30);
            this.mfProgression.Text = "Barres de Progression";
            this.mfProgression.Click += new System.EventHandler(this.mNonDefini_Click);
            // 
            // mfListe
            // 
            this.mfListe.Name = "mfListe";
            this.mfListe.Size = new System.Drawing.Size(268, 30);
            this.mfListe.Text = "Liste";
            this.mfListe.Click += new System.EventHandler(this.mNonDefini_Click);
            // 
            // mfEditeur
            // 
            this.mfEditeur.Name = "mfEditeur";
            this.mfEditeur.Size = new System.Drawing.Size(268, 30);
            this.mfEditeur.Text = "Editeur";
            this.mfEditeur.Click += new System.EventHandler(this.mNonDefini_Click);
            // 
            // EcranPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 633);
            this.Controls.Add(this.mMenu);
            this.MainMenuStrip = this.mMenu;
            this.Name = "EcranPrincipal";
            this.Text = "Ecran Principal";
            this.mMenu.ResumeLayout(false);
            this.mMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mMenu;
        private System.Windows.Forms.ToolStripMenuItem mFenetres;
        private System.Windows.Forms.ToolStripMenuItem mAide;
        private System.Windows.Forms.ToolStripMenuItem mQuitter;
        private System.Windows.Forms.ToolStripMenuItem mfProgression;
        private System.Windows.Forms.ToolStripMenuItem mfListe;
        private System.Windows.Forms.ToolStripMenuItem mfEditeur;
    }
}