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
    public partial class EcranProgression : Form
    {
        public EcranProgression()
        {
            InitializeComponent();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExecuter_Click(object sender, EventArgs e)
        {
            int i, j, pas;
            Cursor curseur = Cursor;
            Random delai = new Random();
            Cursor = Cursors.WaitCursor; // nous permet d'obtenir le cursor attente parmis plusieurs types de cursor
            btnExecuter.Enabled = btnQuitter.Enabled = false;// desactiver les bouton executer et quitter lorsque le programme tourne
            pbPrincipal.Value = 0; //initialise la position de la barre de progression principal
            for(i=1 ; i <8 ; i++)
            {
                pbSecondaire.Value = 8;
                pas = 5 + 9 * delai.Next(20);
                //Random.Next() permet de retourné un nombre aleatoire inferieur a la vleur max entrée
                for(j=1; j<20; j++)
                {
                    pbSecondaire.Value = j * 5;
                    System.Threading.Thread.Sleep(pas);
                }
                pbPrincipal.Value = i * 100 / 8;
            }
            btnExecuter.Enabled = btnQuitter.Enabled = true;// permet d'activer les boutons exécuter et quitter
            Cursor = curseur; // permet de revenir a notre curseur de départ

        }
    }
}
