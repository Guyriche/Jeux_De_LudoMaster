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
    public partial class EcranBD2 : Form
    {
        public EcranBD2()
        {
            InitializeComponent();
            clientBindingSource.PositionChanged += new EventHandler(BougerClient);
        }

        private void EcranBD2_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dsPerso.Client'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.clientTableAdapter.Fill(this.dsPerso.Client);
            // string s =  Program.PA.ChCommBD;
            Bouger();
            ActiverNavi(clientBindingSource.Count > 0);
        }
        private void BougerClient(object sender, EventArgs e)
        {
            Bouger();
        }
        private void btnPrem_Click(object sender, EventArgs e)
        {
            clientBindingSource.Position = 0;
        }

        private void btnDern_Click(object sender, EventArgs e)
        {
            clientBindingSource.Position = clientBindingSource.Count - 1;
        }

        private void btnPrec_Click(object sender, EventArgs e)
        {
            clientBindingSource.Position--;
        }

        private void btnSuiv_Click(object sender, EventArgs e)
        {
            clientBindingSource.Position++;
        }
        private void ActiverNavi(bool lActi)
        {
            //btnPrem.Enabled = btnPrec.Enabled = btnSuiv.Enabled = btnDern.Enabled = lActi;
            btnAjout.Enabled = btnModi.Enabled = btnSupp.Enabled = lActi;
            tbPre.Enabled = tbNom.Enabled = dtpDatedeNaissance.Enabled = !lActi;
            btnConf.Enabled = btnAnn.Enabled = !lActi;

        }
        private void Bouger() // mettre a jour les boutons de deplacement en fonction de ce qu'on fait
        {
            btnPrem.Enabled = btnPrec.Enabled = btnSuiv.Enabled = btnDern.Enabled = true;
            if (clientBindingSource.Position == 0)
                btnPrem.Enabled = btnPrec.Enabled = false;
            if (clientBindingSource.Position == clientBindingSource.Count - 1)
                btnSuiv.Enabled = btnDern.Enabled = false;
            lblPost.Text = (1 + clientBindingSource.Position).ToString() + "/" + clientBindingSource.Count.ToString();
            //if (clientBindingSource.Count == 0)      // regarde si ma table ne serrai pas vide 
            //    btnSupp.Enabled = btnModi.Enabled = false;
            //else
            //    btnSupp.Enabled = btnModi.Enabled = true;
            btnSupp.Enabled = btnModi.Enabled = (clientBindingSource.Count > 0);
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            clientBindingSource.AddNew(); // au niveau memoire va ajouté un nouveau enregistrement
            ActiverNavi(false);
        }

        private void btnModi_Click(object sender, EventArgs e)
        {
            ActiverNavi(false);
        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Souhaitez-Vous Supprimer cet enregistrement?" , "Confirmer" , MessageBoxButtons.YesNo
                , MessageBoxIcon.Question)==DialogResult.Yes)
            {
                clientBindingSource.RemoveAt(clientBindingSource.Position);
                ValiderModif();
                Bouger();
            }
        }

        private void btnAnn_Click(object sender, EventArgs e)
        {
            clientBindingSource.CancelEdit();
            ActiverNavi(true);
        }

        private void btnConf_Click(object sender, EventArgs e)
        {
            clientBindingSource.EndEdit();
            if (dsPerso.HasChanges()) ValiderModif();
            else MessageBox.Show("Aucun Modification");
            ActiverNavi(true);
        }
        private void ValiderModif()
        {
            try
            {
                MessageBox.Show(clientTableAdapter.Update(dsPerso.Client).ToString()
                    + "Mise(s) à Jour effectuée(s)");
            }
            catch
            {
                MessageBox.Show("Echec de la mise à jour");
            }
        }
    }
}
