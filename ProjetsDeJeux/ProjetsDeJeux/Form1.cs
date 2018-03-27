using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources; // va nous permettre de changer la langue

namespace ProjetsDeJeux
{
    public partial class EcranPrincipal : Form
    {
        public EcranPrincipal()
        {
            InitializeComponent();
        }
        //public static ResourceManager LocRM; // permet de modifier la langue lors du choix par l'utilisateur

        private void button1_Click(object sender, EventArgs e)
        {
            EcranMenuEn f = new EcranMenuEn();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EcranMenuFr f = new EcranMenuFr();
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EcranRègles f = new EcranRègles();
            f.ShowDialog();
        }
    }
}
