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
    public partial class EcranPrincipal : Form
    {
        public EcranPrincipal()
        {
            InitializeComponent();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EcranPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Souhaitez vous réellement quitter?", "votre souhait", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) e.Cancel = false;
            else e.Cancel = true;
        }

        private void barreDeProgressionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EcranProgression f = new EcranProgression();
            f.ShowDialog();
        }

        private void mfListe_Click(object sender, EventArgs e)
        {
            EcranListe f = new EcranListe();
            f.ShowDialog();
        }

        private void aideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EcranAide f = new EcranAide();
            f.ShowDialog();
        }

        private void editeurToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            EcranEditeur f = new EcranEditeur();
            f.ShowDialog();
        }

        private void horlogeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EcranHorloge f = new EcranHorloge();
            f.ShowDialog();
        }

        private void spirographeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EcranSpirographe f = new EcranSpirographe();
            f.ShowDialog();
        }
        private void grapheToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            EcranDessin f = new EcranDessin();
            f.ShowDialog();
        }

        private void mfCarnaval_Click(object sender, EventArgs e)
        {
            EcranCarnaval f = new EcranCarnaval();
            f.ShowDialog();
        }

        private void mfClavierSouris_Click(object sender, EventArgs e)
        {
            EcranClavierSouris f = new EcranClavierSouris();
            f.ShowDialog();
        }

        private void mfexplorateur_Click(object sender, EventArgs e)
        {
            EcranExplorateur f = new EcranExplorateur();
            f.ShowDialog();
        }

        private void mfBD1_Click(object sender, EventArgs e)
        {
            EcranBD1 f = new  EcranBD1();
            f.ShowDialog();
        }

        private void mfBD2_Click(object sender, EventArgs e)
        {
            EcranBD2 f = new EcranBD2();
            f.ShowDialog();
        }

        private void mfBD3_Click(object sender, EventArgs e)
        {
            EcranBD3 f = new EcranBD3();
            f.ShowDialog();
        }
    }
}
// D:\Nouveau doc 2eme IS\Quadrimestre II\Program even th(Mr Alexandre)\Decouverte csharp\Decouverte csharp\FicPrincipal
