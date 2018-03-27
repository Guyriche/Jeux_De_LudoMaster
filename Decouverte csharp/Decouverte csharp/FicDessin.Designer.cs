namespace Decouverte_csharp
{
    partial class EcranDessin
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
            this.tbY = new System.Windows.Forms.TextBox();
            this.tbX = new System.Windows.Forms.TextBox();
            this.btnLancer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnTrait = new System.Windows.Forms.Button();
            this.btnFond = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dlgCouleur = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(270, 285);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(100, 20);
            this.tbY.TabIndex = 0;
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(270, 339);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(100, 20);
            this.tbX.TabIndex = 1;
            // 
            // btnLancer
            // 
            this.btnLancer.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLancer.Location = new System.Drawing.Point(504, 319);
            this.btnLancer.Name = "btnLancer";
            this.btnLancer.Size = new System.Drawing.Size(135, 35);
            this.btnLancer.TabIndex = 2;
            this.btnLancer.Text = "Lancer";
            this.btnLancer.UseVisualStyleBackColor = true;
            this.btnLancer.Click += new System.EventHandler(this.btnLancer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(376, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(650, 267);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnTrait
            // 
            this.btnTrait.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrait.Location = new System.Drawing.Point(587, 285);
            this.btnTrait.Name = "btnTrait";
            this.btnTrait.Size = new System.Drawing.Size(63, 28);
            this.btnTrait.TabIndex = 6;
            this.btnTrait.Text = "Trait";
            this.btnTrait.UseVisualStyleBackColor = true;
            this.btnTrait.Click += new System.EventHandler(this.btnTrait_Click);
            // 
            // btnFond
            // 
            this.btnFond.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFond.Location = new System.Drawing.Point(485, 288);
            this.btnFond.Name = "btnFond";
            this.btnFond.Size = new System.Drawing.Size(67, 28);
            this.btnFond.TabIndex = 7;
            this.btnFond.Text = "Fond";
            this.btnFond.UseVisualStyleBackColor = true;
            this.btnFond.Click += new System.EventHandler(this.btnFond_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 285);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 74);
            this.textBox1.TabIndex = 8;
            // 
            // EcranDessin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 366);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnFond);
            this.Controls.Add(this.btnTrait);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLancer);
            this.Controls.Add(this.tbX);
            this.Controls.Add(this.tbY);
            this.Name = "EcranDessin";
            this.Text = "Dessin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.Button btnLancer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnTrait;
        private System.Windows.Forms.Button btnFond;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ColorDialog dlgCouleur;
    }
}