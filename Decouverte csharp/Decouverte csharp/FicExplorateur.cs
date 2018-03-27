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

namespace Decouverte_csharp
{
    public partial class EcranExplorateur : Form
    {
        private TreeNode NoeudRacine;
        public EcranExplorateur()
        {
            InitializeComponent();
            slMessage.Text = "";
            LireDisque();
        }

        private string NomFichier(string nf)
        {
            return nf.Substring(1 + nf.LastIndexOf('\\'));
        }
        private void tsQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsPetitesIcones_Click(object sender, EventArgs e)
        {
            lvFichier.View = View.SmallIcon;
        }

        private void tsGrandesIcones_Click(object sender, EventArgs e)
        {
            lvFichier.View = View.LargeIcon;
        }

        private void tsListe_Click(object sender, EventArgs e)
        {
            lvFichier.View = View.List;
        }

        private void tsDetail_Click(object sender, EventArgs e)
        {
            lvFichier.View = View.Details;
        }

        private void LireDisque()
        {
            //permet de creer l'arborescence d'un disque qui se reouve sur notre ordinateuer
            Cursor = Cursors.WaitCursor;
            slMessage.Text = "Lecture de l'arborescence";
            NoeudRacine = new TreeNode("Poste de travail", 0, 0);  // veut l'index des petite et grande icônes
            tvRepertoire.Nodes.Clear();
            tvRepertoire.Nodes.Add(NoeudRacine);
            string[] Disques = Environment.GetLogicalDrives();
            foreach(string Disque in Disques)
            {
                TreeNode NoeudDisque = new TreeNode(Disque, 1, 1);
                NoeudRacine.Nodes.Add(NoeudDisque);
                LireRepertoire(Disque, NoeudDisque.Nodes);
            }
            slMessage.Text = "";
            Cursor = Cursors.Arrow;
        }
        private void LireRepertoire(string nd , TreeNodeCollection tnc) // TreeNodeCollection permet de  remplir l'arbescence
        {
            if(Directory.Exists(nd))
            {
                try
                {
                    string [] sReps = Directory.GetDirectories(nd);
                    foreach (string sRep in sReps)
                    {
                        string s1 = "", s2 = "";
                        s1 = NomFichier(sRep);
                        s2 =s1.ToUpper();    // ToUpper pour transformer en mejuscule
                        TreeNode NoeudCourant;
                        if (s2 == "RECYCLED" || s2 == "RECYCLER" || s2 == "$RECYCLE.BIN") // arcour tout les repertoire et verifie si c'est une poubelle
                            NoeudCourant = new TreeNode(s1, 4, 4);
                        else
                            NoeudCourant = new TreeNode(s1, 2, 3);
                        tnc.Add(NoeudCourant);
                        //LireRepertoire(sRep , NoeudCourant.Nodes);
                    }
                }
                catch
                {
                    //MessageBox.Show("Problème dans la lecture du repertoire");
                }
            }
        }

        private void tvRepertoire_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode NoeudCourant = e.Node;
            if(NoeudCourant == NoeudRacine)
            {
                string[] sTmp = { "Poste de travail", "", "", "" };
                ListViewItem lvi = new ListViewItem(sTmp, 0);
                lvFichier.Items.Add(lvi);
            }
            else
            {
                string sRep = NoeudCourant.FullPath;
                sRep = sRep.Substring(1 + sRep.IndexOf('\\')); // Substring permet de chercher ce dont tu veut dans un string
                try
                {
                    lvFichier.Items.Clear(); // permet ne nettoyer tout les objet de items(objet d'une liste)
                    if (!Directory.Exists(sRep))
                    {
                        string[] sTmp = { "Poste de travail", "", "", "" };
                        ListViewItem lvi = new ListViewItem(sTmp, 0);
                        lvFichier.Items.Add(lvi);
                        Cursor = Cursors.Arrow;
                        ssMessage.Text = "";
                        tvRepertoire.Focus();
                    }
                    else
                        LireFichier(sRep);
                }
                catch(IOException Fote)
                {
                    MessageBox.Show("Erreur d'acces à " + sRep + "(" + Fote.Message + ")");
                    Cursor = Cursors.Arrow;
                    ssMessage.Text = "";
                    tvRepertoire.Focus();
                }
            }
        }
        private void LireFichier (string sRep)
        {
            lvFichier.Items.Clear();
            ssMessage.Text = "Rafrî^chissement de " + sRep + "en cours";
            Cursor =  Cursors.WaitCursor;
            try
            {
                string[] sFics = Directory.GetFiles(sRep);
                string[] lvCol = new string[4];
                //lvCol [0] <- Nom du fichier 
                //lvCol [1] <- Taille du fichier 
                //lvCol [2] <- date de creation  du fichier 
                //lvCol [3] <- date de dernière modification  du fichier 
                ssMessage.Text = " Parcours de " + sRep;
                foreach (string sFic in sFics)
                {
                    if (sFic.ToUpper() != "PAGEFILE.SYS")
                    {
                        FileInfo fi = new FileInfo(sFic);
                        lvCol[0] = NomFichier(sFic);
                        if (fi.Length > 1024 * 1024)
                            lvCol[1] = (fi.Length / (1024 * 1024)).ToString() + "MB";
                        else if (fi.Length > 1024)
                            lvCol[1] = (fi.Length / (1024)).ToString() + "KB";
                        else
                        lvCol[1] = fi.Length.ToString();
                        lvCol[2] = fi.CreationTime.ToString("dd/MM/yyyy");
                        lvCol[3] = fi.LastWriteTime.ToString("dd/MM/yyyy");
                        ListViewItem lvi = new ListViewItem(lvCol, 0);
                        lvFichier.Items.Add(lvi);
                    }
                }
            }
            catch (IOException Fot)
            {
                MessageBox.Show("Erreur d'acces " + sRep + "( " + Fot.Message + ")");
            }
            catch
            {
                MessageBox.Show("Erreur d'acces à " + sRep);
            }
            finally
            {
                ssMessage.Text = "";
                Cursor = Cursors.Arrow;
            }
        }
    }
}
