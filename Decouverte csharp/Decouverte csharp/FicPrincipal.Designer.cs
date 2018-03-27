namespace Decouverte_csharp
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fenetreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barreDeProgressionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mfListe = new System.Windows.Forms.ToolStripMenuItem();
            this.editeurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horlogeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spirographeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grapheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mfCarnaval = new System.Windows.Forms.ToolStripMenuItem();
            this.mfClavierSouris = new System.Windows.Forms.ToolStripMenuItem();
            this.mfexplorateur = new System.Windows.Forms.ToolStripMenuItem();
            this.mfBD1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mfBD2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mfBD3 = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fenetreToolStripMenuItem,
            this.aideToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(593, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fenetreToolStripMenuItem
            // 
            this.fenetreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barreDeProgressionToolStripMenuItem,
            this.mfListe,
            this.editeurToolStripMenuItem,
            this.horlogeToolStripMenuItem,
            this.spirographeToolStripMenuItem,
            this.grapheToolStripMenuItem,
            this.mfCarnaval,
            this.mfClavierSouris,
            this.mfexplorateur,
            this.mfBD1,
            this.mfBD2,
            this.mfBD3});
            this.fenetreToolStripMenuItem.Name = "fenetreToolStripMenuItem";
            this.fenetreToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.fenetreToolStripMenuItem.Text = "Fenetre";
            // 
            // barreDeProgressionToolStripMenuItem
            // 
            this.barreDeProgressionToolStripMenuItem.Name = "barreDeProgressionToolStripMenuItem";
            this.barreDeProgressionToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.barreDeProgressionToolStripMenuItem.Text = "Barres de progression";
            this.barreDeProgressionToolStripMenuItem.Click += new System.EventHandler(this.barreDeProgressionToolStripMenuItem_Click);
            // 
            // mfListe
            // 
            this.mfListe.Name = "mfListe";
            this.mfListe.Size = new System.Drawing.Size(187, 22);
            this.mfListe.Text = "Liste";
            this.mfListe.Click += new System.EventHandler(this.mfListe_Click);
            // 
            // editeurToolStripMenuItem
            // 
            this.editeurToolStripMenuItem.Name = "editeurToolStripMenuItem";
            this.editeurToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.editeurToolStripMenuItem.Text = "Editeur";
            this.editeurToolStripMenuItem.Click += new System.EventHandler(this.editeurToolStripMenuItem_Click_1);
            // 
            // horlogeToolStripMenuItem
            // 
            this.horlogeToolStripMenuItem.Name = "horlogeToolStripMenuItem";
            this.horlogeToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.horlogeToolStripMenuItem.Text = "Horloge";
            this.horlogeToolStripMenuItem.Click += new System.EventHandler(this.horlogeToolStripMenuItem_Click);
            // 
            // spirographeToolStripMenuItem
            // 
            this.spirographeToolStripMenuItem.Name = "spirographeToolStripMenuItem";
            this.spirographeToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.spirographeToolStripMenuItem.Text = "Spirographe";
            this.spirographeToolStripMenuItem.Click += new System.EventHandler(this.spirographeToolStripMenuItem_Click);
            // 
            // grapheToolStripMenuItem
            // 
            this.grapheToolStripMenuItem.Name = "grapheToolStripMenuItem";
            this.grapheToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.grapheToolStripMenuItem.Text = "Graphe";
            this.grapheToolStripMenuItem.Click += new System.EventHandler(this.grapheToolStripMenuItem_Click_1);
            // 
            // mfCarnaval
            // 
            this.mfCarnaval.Name = "mfCarnaval";
            this.mfCarnaval.Size = new System.Drawing.Size(187, 22);
            this.mfCarnaval.Text = "Carnaval";
            this.mfCarnaval.Click += new System.EventHandler(this.mfCarnaval_Click);
            // 
            // mfClavierSouris
            // 
            this.mfClavierSouris.Name = "mfClavierSouris";
            this.mfClavierSouris.Size = new System.Drawing.Size(187, 22);
            this.mfClavierSouris.Text = "Clavier - Souris";
            this.mfClavierSouris.Click += new System.EventHandler(this.mfClavierSouris_Click);
            // 
            // mfexplorateur
            // 
            this.mfexplorateur.Name = "mfexplorateur";
            this.mfexplorateur.Size = new System.Drawing.Size(187, 22);
            this.mfexplorateur.Text = "Explorateur";
            this.mfexplorateur.Click += new System.EventHandler(this.mfexplorateur_Click);
            // 
            // mfBD1
            // 
            this.mfBD1.Name = "mfBD1";
            this.mfBD1.Size = new System.Drawing.Size(187, 22);
            this.mfBD1.Text = "Base de données 1";
            this.mfBD1.Click += new System.EventHandler(this.mfBD1_Click);
            // 
            // mfBD2
            // 
            this.mfBD2.Name = "mfBD2";
            this.mfBD2.Size = new System.Drawing.Size(187, 22);
            this.mfBD2.Text = "Base de données 2";
            this.mfBD2.Click += new System.EventHandler(this.mfBD2_Click);
            // 
            // mfBD3
            // 
            this.mfBD3.Name = "mfBD3";
            this.mfBD3.Size = new System.Drawing.Size(187, 22);
            this.mfBD3.Text = "Base de données 3";
            this.mfBD3.Click += new System.EventHandler(this.mfBD3_Click);
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.aideToolStripMenuItem.Text = "Aide";
            this.aideToolStripMenuItem.Click += new System.EventHandler(this.aideToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // EcranPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 327);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EcranPrincipal";
            this.Text = "Ecran Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EcranPrincipal_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fenetreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barreDeProgressionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mfListe;
        private System.Windows.Forms.ToolStripMenuItem editeurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horlogeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spirographeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grapheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mfCarnaval;
        private System.Windows.Forms.ToolStripMenuItem mfClavierSouris;
        private System.Windows.Forms.ToolStripMenuItem mfexplorateur;
        private System.Windows.Forms.ToolStripMenuItem mfBD1;
        private System.Windows.Forms.ToolStripMenuItem mfBD2;
        private System.Windows.Forms.ToolStripMenuItem mfBD3;
    }
}