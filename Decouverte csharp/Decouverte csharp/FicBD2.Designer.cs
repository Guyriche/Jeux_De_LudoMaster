namespace Decouverte_csharp
{
    partial class EcranBD2
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPre = new System.Windows.Forms.TextBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPerso = new Decouverte_csharp.dsPerso();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDatedeNaissance = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPrem = new System.Windows.Forms.Button();
            this.btnPrec = new System.Windows.Forms.Button();
            this.btnSuiv = new System.Windows.Forms.Button();
            this.btnDern = new System.Windows.Forms.Button();
            this.lblPost = new System.Windows.Forms.Label();
            this.btnAjout = new System.Windows.Forms.Button();
            this.btnSupp = new System.Windows.Forms.Button();
            this.btnModi = new System.Windows.Forms.Button();
            this.btnConf = new System.Windows.Forms.Button();
            this.btnAnn = new System.Windows.Forms.Button();
            this.clientTableAdapter = new Decouverte_csharp.dsPersoTableAdapters.ClientTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPerso)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prenom";
            // 
            // tbPre
            // 
            this.tbPre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "NOM", true));
            this.tbPre.Location = new System.Drawing.Point(2, 25);
            this.tbPre.Name = "tbPre";
            this.tbPre.Size = new System.Drawing.Size(289, 20);
            this.tbPre.TabIndex = 1;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.dsPerso;
            // 
            // dsPerso
            // 
            this.dsPerso.DataSetName = "dsPerso";
            this.dsPerso.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbNom
            // 
            this.tbNom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "NOM", true));
            this.tbNom.Location = new System.Drawing.Point(3, 76);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(289, 20);
            this.tbNom.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nom";
            // 
            // dtpDatedeNaissance
            // 
            this.dtpDatedeNaissance.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "NAI", true));
            this.dtpDatedeNaissance.Location = new System.Drawing.Point(3, 129);
            this.dtpDatedeNaissance.Name = "dtpDatedeNaissance";
            this.dtpDatedeNaissance.Size = new System.Drawing.Size(289, 20);
            this.dtpDatedeNaissance.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date de Naissance";
            // 
            // btnPrem
            // 
            this.btnPrem.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrem.Location = new System.Drawing.Point(3, 168);
            this.btnPrem.Name = "btnPrem";
            this.btnPrem.Size = new System.Drawing.Size(43, 35);
            this.btnPrem.TabIndex = 7;
            this.btnPrem.Text = "|<";
            this.btnPrem.UseVisualStyleBackColor = true;
            this.btnPrem.Click += new System.EventHandler(this.btnPrem_Click);
            // 
            // btnPrec
            // 
            this.btnPrec.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrec.Location = new System.Drawing.Point(52, 168);
            this.btnPrec.Name = "btnPrec";
            this.btnPrec.Size = new System.Drawing.Size(43, 35);
            this.btnPrec.TabIndex = 8;
            this.btnPrec.Text = "<";
            this.btnPrec.UseVisualStyleBackColor = true;
            this.btnPrec.Click += new System.EventHandler(this.btnPrec_Click);
            // 
            // btnSuiv
            // 
            this.btnSuiv.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuiv.Location = new System.Drawing.Point(199, 168);
            this.btnSuiv.Name = "btnSuiv";
            this.btnSuiv.Size = new System.Drawing.Size(43, 35);
            this.btnSuiv.TabIndex = 9;
            this.btnSuiv.Text = ">";
            this.btnSuiv.UseVisualStyleBackColor = true;
            this.btnSuiv.Click += new System.EventHandler(this.btnSuiv_Click);
            // 
            // btnDern
            // 
            this.btnDern.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDern.Location = new System.Drawing.Point(248, 168);
            this.btnDern.Name = "btnDern";
            this.btnDern.Size = new System.Drawing.Size(43, 35);
            this.btnDern.TabIndex = 10;
            this.btnDern.Text = ">|";
            this.btnDern.UseVisualStyleBackColor = true;
            this.btnDern.Click += new System.EventHandler(this.btnDern_Click);
            // 
            // lblPost
            // 
            this.lblPost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPost.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPost.Location = new System.Drawing.Point(101, 168);
            this.lblPost.Name = "lblPost";
            this.lblPost.Size = new System.Drawing.Size(92, 35);
            this.lblPost.TabIndex = 11;
            this.lblPost.Text = "p/n";
            this.lblPost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAjout
            // 
            this.btnAjout.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjout.Location = new System.Drawing.Point(7, 222);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(93, 31);
            this.btnAjout.TabIndex = 12;
            this.btnAjout.Text = "Ajouter";
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // btnSupp
            // 
            this.btnSupp.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupp.Location = new System.Drawing.Point(204, 222);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(93, 31);
            this.btnSupp.TabIndex = 13;
            this.btnSupp.Text = "Supprimer";
            this.btnSupp.UseVisualStyleBackColor = true;
            this.btnSupp.Click += new System.EventHandler(this.btnSupp_Click);
            // 
            // btnModi
            // 
            this.btnModi.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModi.Location = new System.Drawing.Point(105, 222);
            this.btnModi.Name = "btnModi";
            this.btnModi.Size = new System.Drawing.Size(93, 31);
            this.btnModi.TabIndex = 14;
            this.btnModi.Text = "Modifier";
            this.btnModi.UseVisualStyleBackColor = true;
            this.btnModi.Click += new System.EventHandler(this.btnModi_Click);
            // 
            // btnConf
            // 
            this.btnConf.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConf.Location = new System.Drawing.Point(50, 272);
            this.btnConf.Name = "btnConf";
            this.btnConf.Size = new System.Drawing.Size(93, 31);
            this.btnConf.TabIndex = 16;
            this.btnConf.Text = "Confirmer";
            this.btnConf.UseVisualStyleBackColor = true;
            this.btnConf.Click += new System.EventHandler(this.btnConf_Click);
            // 
            // btnAnn
            // 
            this.btnAnn.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnn.Location = new System.Drawing.Point(149, 272);
            this.btnAnn.Name = "btnAnn";
            this.btnAnn.Size = new System.Drawing.Size(93, 31);
            this.btnAnn.TabIndex = 15;
            this.btnAnn.Text = "Annuler";
            this.btnAnn.UseVisualStyleBackColor = true;
            this.btnAnn.Click += new System.EventHandler(this.btnAnn_Click);
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // EcranBD2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(298, 315);
            this.Controls.Add(this.btnConf);
            this.Controls.Add(this.btnAnn);
            this.Controls.Add(this.btnModi);
            this.Controls.Add(this.btnSupp);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.lblPost);
            this.Controls.Add(this.btnDern);
            this.Controls.Add(this.btnSuiv);
            this.Controls.Add(this.btnPrec);
            this.Controls.Add(this.btnPrem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDatedeNaissance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.tbPre);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "EcranBD2";
            this.Text = "Gestion de base de données";
            this.Load += new System.EventHandler(this.EcranBD2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPerso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPre;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDatedeNaissance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPrem;
        private System.Windows.Forms.Button btnPrec;
        private System.Windows.Forms.Button btnSuiv;
        private System.Windows.Forms.Button btnDern;
        private System.Windows.Forms.Label lblPost;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.Button btnSupp;
        private System.Windows.Forms.Button btnModi;
        private System.Windows.Forms.Button btnConf;
        private System.Windows.Forms.Button btnAnn;
        private dsPerso dsPerso;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private dsPersoTableAdapters.ClientTableAdapter clientTableAdapter;
    }
}