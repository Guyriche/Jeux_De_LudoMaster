using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace Decouverte_csharp
{
    public partial class EcranListe : Form
    {
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        private const int LB_Lire = 0x0199;
        private const int LB_Ecrire = 0x019A;
        private string NomFichiier = "";
        public EcranListe()
        {
            InitializeComponent();
        }

        private void Activer(bool lDetail)
        {
            lbPersonne.Enabled = !lDetail;
            btnOuvrir.Enabled = btnEnregistrer.Enabled
            = btnAjouter.Enabled = btnSupprimer.Enabled = !lDetail; // désactive toutes les fonctions au lancement du programme 
            gbDétail.Enabled = lDetail;
            if (lDetail)
            {
                cbQualité.SelectedIndex = 0; // Selectionne le premier index de la liste.
                tbNom.Text = "";
                cbQualité.Focus(); // permet d'ecrire dans le textfield qualite
            }
            else
                lbPersonne.Focus();
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
             int n =  lbPersonne.Items.Add(tbNom.Text + " (" + cbQualité.Text + ")");
             SendMessage(lbPersonne.Handle, LB_Ecrire, n, lbPersonne.Items.Count);
             Activer(false);
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Activer(false);
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Activer(true);
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int nItem = lbPersonne.SelectedIndex;
            //int n = lbPersonne.Items.Add(str[0]);
            if (nItem >= 0)
            {
                int nval = SendMessage(lbPersonne.Handle, LB_Lire, nItem, 0);
                lbPersonne.Items.RemoveAt(nItem);
                for(int i =0; i<lbPersonne.Items.Count; i++)
                {
                    int m = SendMessage(lbPersonne.Handle, LB_Lire, i, 0);
                    if (m > nval)
                        SendMessage(lbPersonne.Handle, LB_Ecrire, i, (m-1));
                }
            }
            else
                MessageBox.Show("Aucune personne Sélectionnée");
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if( dlgEnregistrer.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(dlgEnregistrer.FileName);
                NomFichiier = dlgEnregistrer.FileName;
                for(int i=0; i< lbPersonne.Items.Count; i++)
                {
                    int n = SendMessage(lbPersonne.Handle, LB_Lire, i, 0);
                    sw.WriteLine(lbPersonne.Items[i] + "#" +n);
                }
                
                sw.Close();
                lblFichier.Text = NomFichiier.Substring(1 + NomFichiier.LastIndexOf(@"\"));
            }
        }

        private void btnOuvrir_Click(object sender, EventArgs e)
        {
            if(NomFichiier !="")
            dlgOuvrir.FileName = NomFichiier;
            dlgOuvrir.Filter = "Fichier texte|*.txt|Toues fichiers|*.*" ;
            if(dlgOuvrir.ShowDialog() == DialogResult.OK)
            {
                lbPersonne.Items.Clear();
                NomFichiier = dlgOuvrir.FileName;
                StreamReader sr = new StreamReader(NomFichiier);
                string lecture;
                while((lecture = sr.ReadLine()) != null)
                {
                    lbPersonne.Items.Add(lecture);
                    string[] str = lecture.Split('#');
                    int n = lbPersonne.Items.Add(str[0]);
                    SendMessage(lbPersonne.Handle, LB_Ecrire, n, int.Parse(str[1]));
                }

                sr.Close();
                lblFichier.Text = NomFichiier.Substring(1 + NomFichiier.LastIndexOf(@"\"));
            }
        }

        private void lbPersonne_DoubleClick(object sender, EventArgs e)
        {
            if(lbPersonne.SelectedIndex >=0)
            {
                int n = SendMessage(lbPersonne.Handle, LB_Lire, lbPersonne.SelectedIndex, 0);
                MessageBox.Show(lbPersonne.Text + "en Position " + (1+ lbPersonne.SelectedIndex).ToString() + "(tri),"
                    + n.ToString() + "(encodage)");
            }
        }
    }
}
