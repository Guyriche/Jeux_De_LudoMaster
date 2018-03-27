namespace Decouverte_csharp
{
    partial class EcranClavierSouris
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
            this.lblClavier = new System.Windows.Forms.Label();
            this.btnRaz = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.lbClavier = new System.Windows.Forms.ListBox();
            this.lblGauche = new System.Windows.Forms.Label();
            this.tbGauche = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbPosY = new System.Windows.Forms.TextBox();
            this.lblDroite = new System.Windows.Forms.Label();
            this.tbPosX = new System.Windows.Forms.TextBox();
            this.lblPosX = new System.Windows.Forms.Label();
            this.tbDroite = new System.Windows.Forms.TextBox();
            this.lblPosY = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblClavier
            // 
            this.lblClavier.AutoSize = true;
            this.lblClavier.Location = new System.Drawing.Point(12, 9);
            this.lblClavier.Name = "lblClavier";
            this.lblClavier.Size = new System.Drawing.Size(80, 13);
            this.lblClavier.TabIndex = 0;
            this.lblClavier.Text = "Suivi du Clavier";
            // 
            // btnRaz
            // 
            this.btnRaz.Location = new System.Drawing.Point(12, 254);
            this.btnRaz.Name = "btnRaz";
            this.btnRaz.Size = new System.Drawing.Size(119, 23);
            this.btnRaz.TabIndex = 1;
            this.btnRaz.Text = "Remise à zéro";
            this.btnRaz.UseVisualStyleBackColor = true;
            this.btnRaz.Click += new System.EventHandler(this.btnRaz_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(137, 254);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(119, 23);
            this.btnQuitter.TabIndex = 2;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // lbClavier
            // 
            this.lbClavier.FormattingEnabled = true;
            this.lbClavier.Location = new System.Drawing.Point(15, 38);
            this.lbClavier.Name = "lbClavier";
            this.lbClavier.Size = new System.Drawing.Size(241, 212);
            this.lbClavier.TabIndex = 3;
            // 
            // lblGauche
            // 
            this.lblGauche.AutoSize = true;
            this.lblGauche.Font = new System.Drawing.Font("Script MT Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGauche.Location = new System.Drawing.Point(259, 22);
            this.lblGauche.Name = "lblGauche";
            this.lblGauche.Size = new System.Drawing.Size(55, 15);
            this.lblGauche.TabIndex = 4;
            this.lblGauche.Text = "à Gauche";
            // 
            // tbGauche
            // 
            this.tbGauche.Location = new System.Drawing.Point(262, 38);
            this.tbGauche.Name = "tbGauche";
            this.tbGauche.Size = new System.Drawing.Size(66, 20);
            this.tbGauche.TabIndex = 5;
            this.tbGauche.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(262, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 213);
            this.panel1.TabIndex = 6;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // tbPosY
            // 
            this.tbPosY.Location = new System.Drawing.Point(551, 38);
            this.tbPosY.Name = "tbPosY";
            this.tbPosY.Size = new System.Drawing.Size(66, 20);
            this.tbPosY.TabIndex = 8;
            this.tbPosY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDroite
            // 
            this.lblDroite.AutoSize = true;
            this.lblDroite.Font = new System.Drawing.Font("Script MT Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDroite.Location = new System.Drawing.Point(331, 22);
            this.lblDroite.Name = "lblDroite";
            this.lblDroite.Size = new System.Drawing.Size(50, 15);
            this.lblDroite.TabIndex = 7;
            this.lblDroite.Text = "à Droite";
            // 
            // tbPosX
            // 
            this.tbPosX.Location = new System.Drawing.Point(479, 38);
            this.tbPosX.Name = "tbPosX";
            this.tbPosX.Size = new System.Drawing.Size(66, 20);
            this.tbPosX.TabIndex = 10;
            this.tbPosX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPosX
            // 
            this.lblPosX.AutoSize = true;
            this.lblPosX.Font = new System.Drawing.Font("Script MT Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosX.Location = new System.Drawing.Point(476, 22);
            this.lblPosX.Name = "lblPosX";
            this.lblPosX.Size = new System.Drawing.Size(48, 15);
            this.lblPosX.TabIndex = 9;
            this.lblPosX.Text = "abscisse";
            // 
            // tbDroite
            // 
            this.tbDroite.Location = new System.Drawing.Point(334, 38);
            this.tbDroite.Name = "tbDroite";
            this.tbDroite.Size = new System.Drawing.Size(66, 20);
            this.tbDroite.TabIndex = 12;
            this.tbDroite.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPosY
            // 
            this.lblPosY.AutoSize = true;
            this.lblPosY.Font = new System.Drawing.Font("Script MT Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosY.Location = new System.Drawing.Point(548, 22);
            this.lblPosY.Name = "lblPosY";
            this.lblPosY.Size = new System.Drawing.Size(53, 15);
            this.lblPosY.TabIndex = 11;
            this.lblPosY.Text = "ordonnée";
            // 
            // EcranClavierSouris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 289);
            this.Controls.Add(this.tbPosY);
            this.Controls.Add(this.tbPosX);
            this.Controls.Add(this.tbDroite);
            this.Controls.Add(this.lblPosY);
            this.Controls.Add(this.lblPosX);
            this.Controls.Add(this.lblDroite);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbGauche);
            this.Controls.Add(this.lblGauche);
            this.Controls.Add(this.lbClavier);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnRaz);
            this.Controls.Add(this.lblClavier);
            this.KeyPreview = true;
            this.Name = "EcranClavierSouris";
            this.Text = "Suivie du Clavier et de la Souris";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EcranClavierSouris_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EcranClavierSouris_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EcranClavierSouris_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClavier;
        private System.Windows.Forms.Button btnRaz;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.ListBox lbClavier;
        private System.Windows.Forms.Label lblGauche;
        private System.Windows.Forms.TextBox tbGauche;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbPosY;
        private System.Windows.Forms.Label lblDroite;
        private System.Windows.Forms.TextBox tbPosX;
        private System.Windows.Forms.Label lblPosX;
        private System.Windows.Forms.TextBox tbDroite;
        private System.Windows.Forms.Label lblPosY;
    }
}