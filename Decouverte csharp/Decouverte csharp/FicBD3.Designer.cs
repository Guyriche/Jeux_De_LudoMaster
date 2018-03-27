namespace Decouverte_csharp
{
    partial class EcranBD3
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
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnEditer = new System.Windows.Forms.Button();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.dtpNai = new System.Windows.Forms.DateTimePicker();
            this.lblNe = new System.Windows.Forms.Label();
            this.tbPre = new System.Windows.Forms.TextBox();
            this.lblPre = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.dgvPersonne = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Afficher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblIdentifiant = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonne)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(269, 12);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 0;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(269, 70);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 1;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(269, 254);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 2;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnEditer
            // 
            this.btnEditer.Location = new System.Drawing.Point(269, 41);
            this.btnEditer.Name = "btnEditer";
            this.btnEditer.Size = new System.Drawing.Size(75, 23);
            this.btnEditer.TabIndex = 3;
            this.btnEditer.Text = "Editer";
            this.btnEditer.UseVisualStyleBackColor = true;
            this.btnEditer.Click += new System.EventHandler(this.btnEditer_Click);
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Location = new System.Drawing.Point(269, 225);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmer.TabIndex = 4;
            this.btnConfirmer.Text = "Confirmer";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // dtpNai
            // 
            this.dtpNai.Location = new System.Drawing.Point(12, 257);
            this.dtpNai.Name = "dtpNai";
            this.dtpNai.Size = new System.Drawing.Size(251, 20);
            this.dtpNai.TabIndex = 5;
            // 
            // lblNe
            // 
            this.lblNe.AutoSize = true;
            this.lblNe.Location = new System.Drawing.Point(12, 235);
            this.lblNe.Name = "lblNe";
            this.lblNe.Size = new System.Drawing.Size(100, 13);
            this.lblNe.TabIndex = 6;
            this.lblNe.Text = "Date De Naissance";
            // 
            // tbPre
            // 
            this.tbPre.Location = new System.Drawing.Point(12, 212);
            this.tbPre.Name = "tbPre";
            this.tbPre.Size = new System.Drawing.Size(251, 20);
            this.tbPre.TabIndex = 7;
            // 
            // lblPre
            // 
            this.lblPre.AutoSize = true;
            this.lblPre.Location = new System.Drawing.Point(12, 196);
            this.lblPre.Name = "lblPre";
            this.lblPre.Size = new System.Drawing.Size(23, 13);
            this.lblPre.TabIndex = 8;
            this.lblPre.Text = "Pre";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(12, 148);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(29, 13);
            this.lblNom.TabIndex = 10;
            this.lblNom.Text = "Nom";
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(12, 164);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(251, 20);
            this.tbNom.TabIndex = 9;
            // 
            // dgvPersonne
            // 
            this.dgvPersonne.AllowUserToAddRows = false;
            this.dgvPersonne.AllowUserToDeleteRows = false;
            this.dgvPersonne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonne.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Afficher});
            this.dgvPersonne.Location = new System.Drawing.Point(12, 8);
            this.dgvPersonne.Name = "dgvPersonne";
            this.dgvPersonne.ReadOnly = true;
            this.dgvPersonne.RowHeadersVisible = false;
            this.dgvPersonne.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonne.Size = new System.Drawing.Size(251, 98);
            this.dgvPersonne.TabIndex = 11;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Afficher
            // 
            this.Afficher.DataPropertyName = "Afficher";
            this.Afficher.HeaderText = "Nom et Prénom";
            this.Afficher.Name = "Afficher";
            this.Afficher.ReadOnly = true;
            this.Afficher.Width = 200;
            // 
            // lblIdentifiant
            // 
            this.lblIdentifiant.AutoSize = true;
            this.lblIdentifiant.Location = new System.Drawing.Point(12, 109);
            this.lblIdentifiant.Name = "lblIdentifiant";
            this.lblIdentifiant.Size = new System.Drawing.Size(53, 13);
            this.lblIdentifiant.TabIndex = 13;
            this.lblIdentifiant.Text = "Identifiant";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(12, 125);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(251, 20);
            this.tbId.TabIndex = 12;
            this.tbId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // EcranBD3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 289);
            this.Controls.Add(this.lblIdentifiant);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.dgvPersonne);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.lblPre);
            this.Controls.Add(this.tbPre);
            this.Controls.Add(this.lblNe);
            this.Controls.Add(this.dtpNai);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(this.btnEditer);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAjouter);
            this.MaximizeBox = false;
            this.Name = "EcranBD3";
            this.Text = "Manipulations BD en Couches";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnEditer;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.DateTimePicker dtpNai;
        private System.Windows.Forms.Label lblNe;
        private System.Windows.Forms.TextBox tbPre;
        private System.Windows.Forms.Label lblPre;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.DataGridView dgvPersonne;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Afficher;
        private System.Windows.Forms.Label lblIdentifiant;
        private System.Windows.Forms.TextBox tbId;
    }
}