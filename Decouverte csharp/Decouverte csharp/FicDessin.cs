using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decouverte_csharp
{
    public partial class EcranDessin : Form
    {
        private Color Fond, Trait;
        Random rand = new Random();
        int xprec = 0 , X, Y;
        int nbrpoint;
        List<Point> PointList = new List<Point>();

        private void btnFond_Click(object sender, EventArgs e)
        {
            dlgCouleur.Color = Fond;
            if (dlgCouleur.ShowDialog() == DialogResult.OK)
            {
                Fond = dlgCouleur.Color;
                Invalidate();
            }
        }

        private void btnTrait_Click(object sender, EventArgs e)
        {
            dlgCouleur.Color = Trait;
            if (dlgCouleur.ShowDialog() == DialogResult.OK)
            {
                Fond = dlgCouleur.Color;
                Invalidate();
            }
        }

        //valeur du centre 
        int cx, cy;

        public EcranDessin()
        {
            InitializeComponent();
            Fond = Color.DarkBlue;
            Trait = Color.Cyan;
        }

        private void btnLancer_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            PointList.Clear();
            xprec = 0;
            Graphics gr = pictureBox1.CreateGraphics();
            pictureBox1.Refresh();
            //dimmension de la picturebox 
            cx = pictureBox1.Width;
            cy = pictureBox1.Height;
            gr.DrawLine(new Pen(Color.Red, 1), new Point(0, cy / 2), new Point(cx, cy / 2));

            this.nbrpoint = rand.Next(10, 25);
            for (int i =0; i< nbrpoint; i++)
            {
                X = rand.Next(xprec + 5, xprec + 20);
                Y = rand.Next(-100, 100);
                xprec = X;
                PointList.Add(new Point(X, Y));
            }
            tbX.Text = X.ToString();
            tbY.Text = Y.ToString();

            PointList.ForEach(pt => textBox1.Text += pt.ToString());
            //trouver la valeur maximal de X
            int Xmax = PointList[PointList.Count - 1].X;
            int val = cx / Xmax;
            // dessin du graphe 
            for (int i = 1; i< nbrpoint; i++)
            {
                gr.DrawLine(new Pen(Trait),new Point(PointList[i].X*val, PointList[i].Y + cy / 2) , new Point(PointList[i-1].X*val , PointList[i].Y+cy/2));
                gr.DrawLine(new Pen(Trait), new Point(PointList[i-1].X*val , PointList[i].Y+cy/2), new Point(PointList[i-1].X*val , PointList[i-1].Y + cy / 2));
            }
            //MessageBox.Show(nbrpoint.ToString());
        }
    }
}
