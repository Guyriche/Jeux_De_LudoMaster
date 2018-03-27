namespace ProjetsDeJeux
{
    partial class EcranMenuFr
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
            this.cbRouge = new System.Windows.Forms.CheckBox();
            this.cbVert = new System.Windows.Forms.CheckBox();
            this.cbBleu = new System.Windows.Forms.CheckBox();
            this.cbJaune = new System.Windows.Forms.CheckBox();
            this.tbRouge = new System.Windows.Forms.TextBox();
            this.tbBleu = new System.Windows.Forms.TextBox();
            this.tbJaune = new System.Windows.Forms.TextBox();
            this.tbVert = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // cbRouge
            // 
            this.cbRouge.AutoSize = true;
            this.cbRouge.BackColor = System.Drawing.SystemColors.Control;
            this.cbRouge.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRouge.Location = new System.Drawing.Point(12, 36);
            this.cbRouge.Name = "cbRouge";
            this.cbRouge.Size = new System.Drawing.Size(84, 29);
            this.cbRouge.TabIndex = 0;
            this.cbRouge.Text = "Rouge";
            this.cbRouge.UseVisualStyleBackColor = false;
            this.cbRouge.CheckedChanged += new System.EventHandler(this.cbRouge_CheckedChanged);
            // 
            // cbVert
            // 
            this.cbVert.AutoSize = true;
            this.cbVert.BackColor = System.Drawing.SystemColors.Control;
            this.cbVert.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVert.Location = new System.Drawing.Point(12, 259);
            this.cbVert.Name = "cbVert";
            this.cbVert.Size = new System.Drawing.Size(66, 29);
            this.cbVert.TabIndex = 1;
            this.cbVert.Text = "Vert";
            this.cbVert.UseVisualStyleBackColor = false;
            this.cbVert.CheckedChanged += new System.EventHandler(this.cbVert_CheckedChanged);
            // 
            // cbBleu
            // 
            this.cbBleu.AutoSize = true;
            this.cbBleu.BackColor = System.Drawing.SystemColors.Control;
            this.cbBleu.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBleu.Location = new System.Drawing.Point(12, 191);
            this.cbBleu.Name = "cbBleu";
            this.cbBleu.Size = new System.Drawing.Size(70, 29);
            this.cbBleu.TabIndex = 2;
            this.cbBleu.Text = "Bleu";
            this.cbBleu.UseVisualStyleBackColor = false;
            this.cbBleu.CheckedChanged += new System.EventHandler(this.cbBleu_CheckedChanged);
            // 
            // cbJaune
            // 
            this.cbJaune.AutoSize = true;
            this.cbJaune.BackColor = System.Drawing.SystemColors.Control;
            this.cbJaune.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbJaune.Location = new System.Drawing.Point(12, 113);
            this.cbJaune.Name = "cbJaune";
            this.cbJaune.Size = new System.Drawing.Size(79, 29);
            this.cbJaune.TabIndex = 3;
            this.cbJaune.Text = "Jaune";
            this.cbJaune.UseVisualStyleBackColor = false;
            this.cbJaune.CheckedChanged += new System.EventHandler(this.cbJaune_CheckedChanged);
            // 
            // tbRouge
            // 
            this.tbRouge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tbRouge.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRouge.Location = new System.Drawing.Point(108, 34);
            this.tbRouge.Multiline = true;
            this.tbRouge.Name = "tbRouge";
            this.tbRouge.Size = new System.Drawing.Size(180, 32);
            this.tbRouge.TabIndex = 4;
            // 
            // tbBleu
            // 
            this.tbBleu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tbBleu.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBleu.Location = new System.Drawing.Point(108, 190);
            this.tbBleu.Multiline = true;
            this.tbBleu.Name = "tbBleu";
            this.tbBleu.Size = new System.Drawing.Size(180, 30);
            this.tbBleu.TabIndex = 5;
            // 
            // tbJaune
            // 
            this.tbJaune.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tbJaune.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbJaune.Location = new System.Drawing.Point(108, 111);
            this.tbJaune.Multiline = true;
            this.tbJaune.Name = "tbJaune";
            this.tbJaune.Size = new System.Drawing.Size(180, 34);
            this.tbJaune.TabIndex = 6;
            // 
            // tbVert
            // 
            this.tbVert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tbVert.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVert.Location = new System.Drawing.Point(108, 257);
            this.tbVert.Multiline = true;
            this.tbVert.Name = "tbVert";
            this.tbVert.Size = new System.Drawing.Size(180, 35);
            this.tbVert.TabIndex = 7;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Gray;
            this.btnStart.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(12, 335);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(276, 45);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Commencer La Partie";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(126, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "NomJoueurI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(126, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 30);
            this.label2.TabIndex = 10;
            this.label2.Text = "NomJoueurII";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(126, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 30);
            this.label3.TabIndex = 11;
            this.label3.Text = "NomJoueurIII";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(126, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 30);
            this.label4.TabIndex = 12;
            this.label4.Text = "NomJoueurIV";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkRate = 400;
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // EcranMenuFr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 396);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tbVert);
            this.Controls.Add(this.tbJaune);
            this.Controls.Add(this.tbBleu);
            this.Controls.Add(this.tbRouge);
            this.Controls.Add(this.cbJaune);
            this.Controls.Add(this.cbBleu);
            this.Controls.Add(this.cbVert);
            this.Controls.Add(this.cbRouge);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "EcranMenuFr";
            this.Text = "FicMenu";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbRouge;
        private System.Windows.Forms.CheckBox cbVert;
        private System.Windows.Forms.CheckBox cbBleu;
        private System.Windows.Forms.CheckBox cbJaune;
        private System.Windows.Forms.TextBox tbRouge;
        private System.Windows.Forms.TextBox tbBleu;
        private System.Windows.Forms.TextBox tbJaune;
        private System.Windows.Forms.TextBox tbVert;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}