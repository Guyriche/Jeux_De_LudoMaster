namespace Decouverte_csharp
{
    partial class EcranBD1
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
            this.lbContenu = new System.Windows.Forms.ListBox();
            this.tbPre = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbSup = new System.Windows.Forms.TextBox();
            this.btnCharger = new System.Windows.Forms.Button();
            this.btnSauver = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnConpter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbContenu
            // 
            this.lbContenu.FormattingEnabled = true;
            this.lbContenu.Location = new System.Drawing.Point(12, 12);
            this.lbContenu.Name = "lbContenu";
            this.lbContenu.Size = new System.Drawing.Size(571, 108);
            this.lbContenu.TabIndex = 0;
            // 
            // tbPre
            // 
            this.tbPre.Location = new System.Drawing.Point(12, 198);
            this.tbPre.Name = "tbPre";
            this.tbPre.Size = new System.Drawing.Size(425, 20);
            this.tbPre.TabIndex = 1;
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(12, 232);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(425, 20);
            this.tbNom.TabIndex = 2;
            // 
            // tbSup
            // 
            this.tbSup.Location = new System.Drawing.Point(12, 274);
            this.tbSup.Name = "tbSup";
            this.tbSup.Size = new System.Drawing.Size(425, 20);
            this.tbSup.TabIndex = 3;
            // 
            // btnCharger
            // 
            this.btnCharger.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCharger.Location = new System.Drawing.Point(12, 139);
            this.btnCharger.Name = "btnCharger";
            this.btnCharger.Size = new System.Drawing.Size(571, 31);
            this.btnCharger.TabIndex = 4;
            this.btnCharger.Text = "Charger";
            this.btnCharger.UseVisualStyleBackColor = true;
            this.btnCharger.Click += new System.EventHandler(this.btnCharger_Click);
            // 
            // btnSauver
            // 
            this.btnSauver.Location = new System.Drawing.Point(456, 196);
            this.btnSauver.Name = "btnSauver";
            this.btnSauver.Size = new System.Drawing.Size(127, 63);
            this.btnSauver.TabIndex = 5;
            this.btnSauver.Text = "Sauver";
            this.btnSauver.UseVisualStyleBackColor = true;
            this.btnSauver.Click += new System.EventHandler(this.btnSauver_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(456, 265);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(127, 36);
            this.btnSupprimer.TabIndex = 6;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnConpter
            // 
            this.btnConpter.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConpter.Location = new System.Drawing.Point(12, 309);
            this.btnConpter.Name = "btnConpter";
            this.btnConpter.Size = new System.Drawing.Size(571, 31);
            this.btnConpter.TabIndex = 7;
            this.btnConpter.Text = "Conpter";
            this.btnConpter.UseVisualStyleBackColor = true;
            this.btnConpter.Click += new System.EventHandler(this.btnConpter_Click);
            // 
            // EcranBD1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(585, 346);
            this.Controls.Add(this.btnConpter);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnSauver);
            this.Controls.Add(this.btnCharger);
            this.Controls.Add(this.tbSup);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.tbPre);
            this.Controls.Add(this.lbContenu);
            this.Name = "EcranBD1";
            this.Text = "FicBD1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbContenu;
        private System.Windows.Forms.TextBox tbPre;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbSup;
        private System.Windows.Forms.Button btnCharger;
        private System.Windows.Forms.Button btnSauver;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnConpter;
    }
}