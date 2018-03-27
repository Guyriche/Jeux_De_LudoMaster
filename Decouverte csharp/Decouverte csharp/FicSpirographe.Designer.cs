namespace Decouverte_csharp
{
    partial class EcranSpirographe
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
            this.gbControle = new System.Windows.Forms.GroupBox();
            this.lblNbSommet = new System.Windows.Forms.Label();
            this.tbNbSommet = new System.Windows.Forms.TrackBar();
            this.tbProfondeur = new System.Windows.Forms.TrackBar();
            this.lbProfondeur = new System.Windows.Forms.Label();
            this.tbDensite = new System.Windows.Forms.TrackBar();
            this.lblDensite = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnFond = new System.Windows.Forms.Button();
            this.btnTrait = new System.Windows.Forms.Button();
            this.dlgCouleur = new System.Windows.Forms.ColorDialog();
            this.gbControle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbNbSommet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProfondeur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDensite)).BeginInit();
            this.SuspendLayout();
            // 
            // gbControle
            // 
            this.gbControle.Controls.Add(this.btnFond);
            this.gbControle.Controls.Add(this.btnTrait);
            this.gbControle.Controls.Add(this.btnGo);
            this.gbControle.Controls.Add(this.tbDensite);
            this.gbControle.Controls.Add(this.lblDensite);
            this.gbControle.Controls.Add(this.tbProfondeur);
            this.gbControle.Controls.Add(this.lbProfondeur);
            this.gbControle.Controls.Add(this.tbNbSommet);
            this.gbControle.Controls.Add(this.lblNbSommet);
            this.gbControle.Location = new System.Drawing.Point(12, 12);
            this.gbControle.Name = "gbControle";
            this.gbControle.Size = new System.Drawing.Size(200, 321);
            this.gbControle.TabIndex = 0;
            this.gbControle.TabStop = false;
            this.gbControle.Text = "Control";
            // 
            // lblNbSommet
            // 
            this.lblNbSommet.AutoSize = true;
            this.lblNbSommet.Location = new System.Drawing.Point(6, 16);
            this.lblNbSommet.Name = "lblNbSommet";
            this.lblNbSommet.Size = new System.Drawing.Size(128, 13);
            this.lblNbSommet.TabIndex = 0;
            this.lblNbSommet.Text = "Nombre de sommet(3 à 8)";
            // 
            // tbNbSommet
            // 
            this.tbNbSommet.Location = new System.Drawing.Point(9, 32);
            this.tbNbSommet.Maximum = 8;
            this.tbNbSommet.Minimum = 3;
            this.tbNbSommet.Name = "tbNbSommet";
            this.tbNbSommet.Size = new System.Drawing.Size(185, 45);
            this.tbNbSommet.TabIndex = 1;
            this.tbNbSommet.Value = 5;
            // 
            // tbProfondeur
            // 
            this.tbProfondeur.Location = new System.Drawing.Point(6, 156);
            this.tbProfondeur.Maximum = 80;
            this.tbProfondeur.Minimum = 20;
            this.tbProfondeur.Name = "tbProfondeur";
            this.tbProfondeur.Size = new System.Drawing.Size(185, 45);
            this.tbProfondeur.TabIndex = 3;
            this.tbProfondeur.TickFrequency = 5;
            this.tbProfondeur.Value = 40;
            // 
            // lbProfondeur
            // 
            this.lbProfondeur.AutoSize = true;
            this.lbProfondeur.Location = new System.Drawing.Point(6, 140);
            this.lbProfondeur.Name = "lbProfondeur";
            this.lbProfondeur.Size = new System.Drawing.Size(149, 13);
            this.lbProfondeur.TabIndex = 2;
            this.lbProfondeur.Text = "Profondeur de dessin(20 à 80)";
            // 
            // tbDensite
            // 
            this.tbDensite.Location = new System.Drawing.Point(6, 94);
            this.tbDensite.Maximum = 20;
            this.tbDensite.Minimum = 5;
            this.tbDensite.Name = "tbDensite";
            this.tbDensite.Size = new System.Drawing.Size(185, 45);
            this.tbDensite.TabIndex = 5;
            this.tbDensite.Value = 10;
            // 
            // lblDensite
            // 
            this.lblDensite.AutoSize = true;
            this.lblDensite.Location = new System.Drawing.Point(3, 78);
            this.lblDensite.Name = "lblDensite";
            this.lblDensite.Size = new System.Drawing.Size(127, 13);
            this.lblDensite.TabIndex = 4;
            this.lblDensite.Text = "Densité de dessin(5 à 20)\r\n";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(9, 208);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(182, 36);
            this.btnGo.TabIndex = 6;
            this.btnGo.Text = "go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnFond
            // 
            this.btnFond.Location = new System.Drawing.Point(106, 250);
            this.btnFond.Name = "btnFond";
            this.btnFond.Size = new System.Drawing.Size(85, 37);
            this.btnFond.TabIndex = 8;
            this.btnFond.Text = "Fond";
            this.btnFond.UseVisualStyleBackColor = true;
            this.btnFond.Click += new System.EventHandler(this.btnFond_Click);
            // 
            // btnTrait
            // 
            this.btnTrait.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTrait.Location = new System.Drawing.Point(6, 250);
            this.btnTrait.Name = "btnTrait";
            this.btnTrait.Size = new System.Drawing.Size(88, 37);
            this.btnTrait.TabIndex = 7;
            this.btnTrait.Text = "Trait";
            this.btnTrait.UseVisualStyleBackColor = true;
            this.btnTrait.Click += new System.EventHandler(this.btnTrait_Click);
            // 
            // EcranSpirographe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 345);
            this.Controls.Add(this.gbControle);
            this.MinimumSize = new System.Drawing.Size(384, 384);
            this.Name = "EcranSpirographe";
            this.Text = "FicSpirographe";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.EcarnSpirographe_Paint);
            this.gbControle.ResumeLayout(false);
            this.gbControle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbNbSommet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProfondeur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDensite)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbControle;
        private System.Windows.Forms.Button btnFond;
        private System.Windows.Forms.Button btnTrait;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TrackBar tbDensite;
        private System.Windows.Forms.Label lblDensite;
        private System.Windows.Forms.TrackBar tbProfondeur;
        private System.Windows.Forms.Label lbProfondeur;
        private System.Windows.Forms.TrackBar tbNbSommet;
        private System.Windows.Forms.Label lblNbSommet;
        private System.Windows.Forms.ColorDialog dlgCouleur;
    }
}