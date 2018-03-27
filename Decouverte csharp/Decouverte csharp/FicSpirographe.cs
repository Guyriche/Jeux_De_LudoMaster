using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Threading;

namespace Decouverte_csharp
{
    public partial class EcranSpirographe : Form
    {
        private Color Fond, Trait;
        //permet d'enregistrer l'image en memoire
        private GraphicsPath GraphEnr;

        private double d(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
        }
        private void btnTrait_Click(object sender, EventArgs e)
        {
            dlgCouleur.Color = Trait;
            if (dlgCouleur .ShowDialog() == DialogResult.OK)
            {
                Fond = dlgCouleur.Color;
                Invalidate();
            }
        }

        private void btnFond_Click(object sender, EventArgs e)
        {
            dlgCouleur.Color = Fond;
            if (dlgCouleur.ShowDialog() == DialogResult.OK)
            {
                Fond = dlgCouleur.Color;
                Invalidate();
            }
        }

        private void EcarnSpirographe_Paint(object sender, PaintEventArgs e)
        {
            if(GraphEnr != null)
            {
                Rectangle zone = new Rectangle(new System.Drawing.Point(248, 0), ClientSize);
                e.Graphics.FillRectangle(new SolidBrush(Fond) , zone); // permet de visualisé l'image sur l'ecran
                e.Graphics.DrawPath(new Pen(Trait), GraphEnr);
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            int nsom = tbNbSommet.Value;
            int nden = tbDensite.Value;
            int npro = 100 - tbProfondeur.Value;//Afin d'aller a 20% de la distance
            GraphEnr = new GraphicsPath();
            Rectangle zone = new Rectangle(new System.Drawing.Point(248, 0), ClientSize);
            Graphics gr = CreateGraphics();
            gr.FillRectangle(new SolidBrush(Fond), zone);
            // Variable du  centre 
            int xc = 248 + (ClientSize.Width - 248) / 2;
            int yc = ClientSize.Height / 2;
            // rayon 
            int rayon = 9 * Math.Min(ClientSize.Width - 248, ClientSize.Height) / 20;
            // sommet
            float[] sX = new float[nsom + 1];
            float[] sY = new float[nsom + 1];
            for (int i = 0; i <= nsom; i++)
            {
                sX[i] = (int)(xc + rayon * Math.Cos(2 * Math.PI * i / nsom));
                sY[i] = (int)(yc + rayon * Math.Sin(2 * Math.PI * i / nsom));
            }
            // tant que la distance avec un sommet du polygone avec le centre est superieur au une certaine valeur , on dessine 
            while (d(sX[0], sY[0], xc, yc) > rayon * npro / 100)
            {
                for (int i = 1; i <= nsom; i++)
                {
                    gr.DrawLine(new Pen(Trait), sX[i - 1], sY[i - 1], sX[i], sY[i]);
                    GraphEnr.AddLine(sX[i - 1], sY[i - 1], sX[i], sY[i]);
                //Dessine 
                    Application.DoEvents();     // recupere les evenement evatuelle arrivé sur la fenetre(que tu peut fermé la fenetre en cour de dessin) 
                    Thread.Sleep(15);           // rallenti 
                }
                //Calcule
                for (int i = 0; i < nsom; i++)
                {
                    sX[i] = sX[i] + (sX[1 + i] - sX[i]) / nden; // determine ou deisiné le prochaine dessin ainsi de suite
                    sY[i] = sY[i] + (sY[1 + i] - sY[i]) / nden;
                }
                sX[nsom] = sX[0];
                sY[nsom] = sY[0];
            }
        }

        public EcranSpirographe()
        {
            InitializeComponent();
            Fond = Color.DarkBlue;
            Trait = Color.Cyan;
        }
    }
}
