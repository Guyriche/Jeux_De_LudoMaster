using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;

namespace ProjetsDeJeux
{
    public partial class EcranMenuFr : Form
    {
        public static int brIindex;

        public EcranMenuFr()
        {
            InitializeComponent();
        }
        public static ResourceManager LocRM; // permet de modifier la langue lors du choix par l'utilisateur

        // cette Fonction va nous permettre de gérer l'activation des joueurs pour pouvoir respecter les règle du jeux
        private void ActivationJoueur(CheckBox cb1, CheckBox cb2, CheckBox cb3, CheckBox cb4, TextBox tb1, TextBox tb2, TextBox tb3,
            TextBox tb4, Color Activer, Color desactiver, int nbr1, int nbr2, bool r, bool y, bool b, bool g)
        {
            errorProvider.Clear(); // permet de signaler une erreur

            if (cb1.Checked == true)
            {
                tb1.Enabled = true;
                if (y) cb2.Enabled = true;
                tb1.BackColor = Activer;
                brIindex = nbr1;
            }
            else
            {
                if (r)
                {
                    tb1.BackColor = desactiver;
                    tb1.Enabled = false;
                    tb1.Text = string.Empty;
                }
                if (y)
                {
                    cb2.Enabled = false;
                    tb2.Enabled = false;
                    tb2.Text = string.Empty;
                }
                if (b)
                {
                    cb3.Enabled = false;
                    tb3.Enabled = false;
                    tb3.Text = string.Empty;
                }
                if (g)
                {
                    cb4.Enabled = false;
                    tb4.Enabled = false;
                    tb4.Text = string.Empty;
                }

                if (y) cb2.Checked = false;
                if (b) cb3.Checked = false;
                if (g) cb4.Checked = false;


                brIindex = nbr2;
            }
        }

        private void cbRouge_CheckedChanged(object sender, EventArgs e)
        {
            ActivationJoueur(cbRouge, cbJaune, cbBleu, cbVert, tbRouge, tbJaune, tbBleu, tbVert,
                                                    Color.Red, SystemColors.Control, 0, 0, true, true, true, true);
        }

        private void cbJaune_CheckedChanged(object sender, EventArgs e)
        {
            ActivationJoueur(cbJaune, cbBleu, cbVert, null, tbJaune, tbBleu, tbVert, null,
                                                    Color.Yellow, SystemColors.Control, 1, 0, true, true, true, false);
        }

        private void cbBleu_CheckedChanged(object sender, EventArgs e)
        {
            ActivationJoueur(cbBleu, cbVert, null, null, tbBleu, tbVert, null, null,
                                                    Color.Blue, SystemColors.Control, 2, 1, true, true, false, false);
        }

        private void cbVert_CheckedChanged(object sender, EventArgs e)
        {
            ActivationJoueur(cbVert, null, null, null, tbVert, null, null, null,
                                                    Color.Green, SystemColors.Control, 3, 2, true, false, false, false);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            EcranTableDeJeux f = new EcranTableDeJeux();
            f.ShowDialog();
        }
    }
}
