using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISET_2018_Decouverte
{
    public partial class EcranPrincipal : Form
    {
        public EcranPrincipal()
        {
            InitializeComponent();
        }

        private void mQuitter_Click(object sender, EventArgs e)
        {Close();}
        private void mNonDefini_Click(object sender, EventArgs e)
        {MessageBox.Show("Fonctionalité non implementée");}

    }
}
