using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decouverte_csharp
{
    public partial class EcranEditeur : Form
    {
        private bool lModifie = false;
        private string NomFichier = "";

        public EcranEditeur()
        {
            InitializeComponent();
        }
        private void  EnregistrerFichier()
        {
            if (NomFichier == "")
                if (dlgsauverFichier.ShowDialog() == DialogResult.OK)
            NomFichier = dlgsauverFichier.FileName;
            if(NomFichier != "")
            {
                rtbText.SaveFile(NomFichier);
                lModifie = false;
            }
        }
        private void VerifierSauve()
        {
            if (lModifie)
                if (MessageBox.Show("Enregistrer le modification ?" , "Texte modifier" , MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                    EnregistrerFichier();
        }

        private void mefNouveu_Click(object sender, EventArgs e)
        {
            VerifierSauve();
            rtbText.Clear();
            NomFichier = "";
            lModifie = false;
            rtbText.Focus();
        }

        private void mefOuvrir_Click(object sender, EventArgs e)
        {
            VerifierSauve();
            if (dlgOuvrirFichier.ShowDialog() == DialogResult.OK)
            {
                NomFichier = dlgOuvrirFichier.FileName;
                rtbText.LoadFile(NomFichier);
            }
            lModifie = false;
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            VerifierSauve();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            VerifierSauve();
            Close();
        }

        private void rtbText_TextChanged(object sender, EventArgs e)
        {
            lModifie = true;
        }

        private void mefjGauche_Click(object sender, EventArgs e)
        {
            rtbText.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void mefjDroite_Click(object sender, EventArgs e)
        {
            rtbText.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void mefjCentrer_Click(object sender, EventArgs e)
        {
            rtbText.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void mefPolicce_Click(object sender, EventArgs e)
        {
            if (dlgPolice.ShowDialog() == DialogResult.OK)
                rtbText.SelectionFont = new Font(dlgPolice.Font, dlgPolice.Font.Style);
        }

        private void mefcGras_Click(object sender, EventArgs e)
        {
            System.Drawing.Font policeActuelle = rtbText.SelectionFont;
            System.Drawing.FontStyle NouvellePolice;
            //if (rtbText.SelectionFont.Bold)
                NouvellePolice = FontStyle.Regular ^ policeActuelle.Style;
            //else
                NouvellePolice = FontStyle.Bold;
            rtbText.SelectionFont = new Font(policeActuelle.FontFamily, policeActuelle.Size, NouvellePolice);
        }

        private void mefcItalique_Click(object sender, EventArgs e)
        {
            System.Drawing.Font policeActuelle = rtbText.SelectionFont;
            System.Drawing.FontStyle NouvellePolice;
            //if (rtbText.SelectionFont.Italic)
                NouvellePolice = FontStyle.Regular ^ policeActuelle.Style;
           // else
                NouvellePolice = FontStyle.Italic;
            rtbText.SelectionFont = new Font(policeActuelle.FontFamily, policeActuelle.Size, NouvellePolice);
        }

        private void mefcSouligner_Click(object sender, EventArgs e)
        {
            System.Drawing.Font policeActuelle = rtbText.SelectionFont;
            System.Drawing.FontStyle NouvellePolice;
            //if (rtbText.SelectionFont.Underline)
                NouvellePolice = FontStyle.Regular ^ policeActuelle.Style;
           // else
                NouvellePolice = FontStyle.Underline;
            rtbText.SelectionFont = new Font(policeActuelle.FontFamily, policeActuelle.Size, NouvellePolice);
        }

        private void mefcBarre_Click(object sender, EventArgs e)
        {
            System.Drawing.Font policeActuelle = rtbText.SelectionFont;
            System.Drawing.FontStyle NouvellePolice;
           // if (rtbText.SelectionFont.Strikeout)
                NouvellePolice = FontStyle.Regular ^ policeActuelle.Style;
            //else
                NouvellePolice = FontStyle.Strikeout;
            rtbText.SelectionFont = new Font(policeActuelle.FontFamily, policeActuelle.Size, NouvellePolice);
        }

        private void meeCouper_Click(object sender, EventArgs e)
        {
            rtbText.Cut();
        }

        private void meeCopier_Click(object sender, EventArgs e)
        {
            rtbText.Copy();
        }

        private void meeColler_Click(object sender, EventArgs e)
        {
            rtbText.Paste();
        }
    }
}
