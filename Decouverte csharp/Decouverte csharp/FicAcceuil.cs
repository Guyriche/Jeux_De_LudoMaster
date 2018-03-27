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
    public partial class EcranAcceuil : Form
    {
        private bool flag = false;
        public EcranAcceuil()
        {
            InitializeComponent();
        }

        private void btnPoussez_Click(object sender, EventArgs e)
        {
            flag = !flag;
            //PictureBox pb = new PictureBox();
            if (flag)
            {
                lblTitre.Text = "Alien Image";
                pbImageDepart.ImageLocation = "C:/Users/Alain/source/repos/ISET_2018_Decouverte/ISET_2018_Decouverte/alien.png";
                pbImageDepart.SizeMode = PictureBoxSizeMode.StretchImage;
                pbImageDepart.Height = 100;
                pbImageDepart.Width = 100;
                //this.Controls.Add(pb);
            }
            else
            {
                lblTitre.Text = "Decouverte de C sharp";
                pbImageDepart.ImageLocation = "C:/Users/Alain/source/repos/ISET_2018_Decouverte/ISET_2018_Decouverte/alien2.png";
                pbImageDepart.SizeMode = PictureBoxSizeMode.StretchImage;
                pbImageDepart.Height = 100;
                pbImageDepart.Width = 100;
                // this.Controls.Add(pb);
            }

        }

        private void EcranAcceuil_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void btnEntrez_Click(object sender, EventArgs e)
        {
            Close();
            //EcranPrincipal f = new EcranPrincipal();
            //f.ShowDialog();
            
        }
    }
}
