using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ISET2018_CourClasse;
using ISET2018_CouGestion;

namespace Decouverte_csharp
{
    public partial class EcranBD3 : Form
    {
        private DataTable dtPersonne;
        // va permettre de faire le lien et pouvoir me permettre de me deplacer sans pb
        private BindingSource bsPersonne;  
        private string sChConn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Nouveau doc 2eme IS\Quadrimestre II\Program even th(Mr Alexandre)\Perso.mdf;Integrated Security=True;Connect Timeout=30";

        public EcranBD3()
        {
            InitializeComponent();
            RemplirDGV();
            if(dgvPersonne.Rows.Count > 0)
            {
                Activer(true);
                dgvPersonne.Rows[0].Selected = true;
            }
            else { Activer(false); }
        }
        private void Activer(bool lNavigation)
        {
            btnAjouter.Enabled = btnEditer.Enabled = btnSupprimer.Enabled = lNavigation;
            btnAnnuler.Enabled = btnConfirmer.Enabled = !lNavigation;
            dtpNai.Enabled = tbNom.Enabled = tbPre.Enabled = !lNavigation;
            dgvPersonne.Enabled = lNavigation;
            if (lNavigation)
                dgvPersonne.Focus();
            else
                tbPre.Focus();
        }
        private void RemplirDGV()
        {
            dtPersonne = new DataTable();
            dtPersonne.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            dtPersonne.Columns.Add("Afficher");
            List<C_Personne> lTmp = new G_Personne(sChConn).Lire("Nom");
            foreach (C_Personne Tmp in lTmp)
                dtPersonne.Rows.Add(Tmp.ID, Tmp.PRE + " " + Tmp.NOM);
            bsPersonne = new BindingSource();
            bsPersonne.DataSource = dtPersonne;
            dgvPersonne.DataSource = bsPersonne;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Activer(false);
            tbId.Text = tbPre.Text = tbNom.Text = "";
            dtpNai.Value = DateTime.Today;
        }

        private void btnEditer_Click(object sender, EventArgs e)
        {
            if (dgvPersonne.SelectedRows.Count > 0)
            {
                Activer(false);
               tbId.Text =  dgvPersonne.SelectedRows[0].Cells["ID"].Value.ToString();
                C_Personne Tmp 
                = new G_Personne(sChConn).Lire_ID(int.Parse(tbId.Text));
                tbPre.Text = Tmp.PRE;
                tbNom.Text = Tmp.NOM;
                dtpNai.Value = (Tmp.NAI == null ? DateTime.Today : (DateTime)Tmp.NAI);
                /* if(Tmp.NAI == null )
                 * {
                 *     dtpNai.Value =  DateTime.Today;
                 * }
                 * else
                 * {
                 *       dtpNai.Value = (DateTime)Tmp.NAI);
                 * }
                //(Tmp.NAI == null ?) veut dire if(Tmp.NAI == null ) on fait l'instruction suivente 
                alors le (:) signifie else
                */

            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if(dgvPersonne.SelectedRows.Count > 0)
            {
                int nID = (int)dgvPersonne.SelectedRows[0].Cells["ID"].Value;
                new G_Personne(sChConn).Supprimer(nID); // suppression dans la base de donnée
                // à tester
                bsPersonne.RemoveCurrent(); // suppression  a l'affichage
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Activer(true);
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {   
            if(tbNom.Text.Length == 0)
            {
                MessageBox.Show("Veuillez Renseigner le nom");
            }
            else
            {

                if (tbId.Text == "")
                //mode ajout
                {
                    int nID = new G_Personne(sChConn).Ajouter(tbNom.Text, tbPre.Text, dtpNai.Value);
                    dtPersonne.Rows.Add(nID , tbPre.Text  + " " + tbNom.Text);
                }
                else
                //mode édition
                {
                    int nID = int.Parse(tbId.Text);
                    new G_Personne(sChConn).Modifier( nID, tbNom.Text, tbPre.Text, dtpNai.Value);
                    //for (int i = 0; i < dtPersonne.Rows.Count; i++)
                    //{
                    //    if ((int)dtPersonne.Rows[i]["ID"] == nID)
                    //    {
                    //        dtPersonne.Rows[i]["Afficher"] = tbPre.Text + " " + tbNom.Text;
                    //        break;
                    //    }
                    // à tester 
                }
                    dgvPersonne.SelectedRows[0].Cells["Afficher"].Value = tbPre.Text + " " + tbNom.Text;
                    bsPersonne.EndEdit();
                Activer(true);
            }
        }
    }
}
