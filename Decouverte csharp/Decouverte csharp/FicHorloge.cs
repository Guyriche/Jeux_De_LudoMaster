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
    public partial class EcranHorloge : Form
    {
        // objet me permettant de definir les ligne des aiguilles
        System.Drawing.Point[,] hands_coord = new System.Drawing.Point[3, 2]
        {
            {new System.Drawing.Point(0 , 0) , new System.Drawing.Point(0 , 90) },
            {new System.Drawing.Point(0 , 0) , new System.Drawing.Point(0 , 120) },
            {new System.Drawing.Point(0 , 0) , new System.Drawing.Point(0 , 140) }

        };
        DateTime cur;
        DateTime prev;
        Boolean change;

        public EcranHorloge()
        {
            InitializeComponent();
        }
        private void Ptrotation(System.Drawing.Point[] pt, int irotation, int iangle)
        {
            System.Drawing.Point ptTemp = new System.Drawing.Point(0, 0);
            for (int i = 0 ; i < irotation; i++)
            {
                ptTemp.X = (int)(pt[i].X * Math.Cos(2 * Math.PI * iangle / 360) - pt[i].Y * Math.Sin(2 * Math.PI * iangle / 360));
                ptTemp.Y = (int)(pt[i].Y * Math.Cos(2 * Math.PI * iangle / 360) + pt[i].X * Math.Sin(2 * Math.PI * iangle / 360));
                pt[i] = ptTemp;
            }
        }
        private void EcranHorloge_Load(object sender, EventArgs e)
        {
            this.Text = string.Format("{0:HH:mm | dd-MM-yy}", DateTime.Now);
        }

        private void EcranHorloge_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.TranslateTransform(this.Size.Width / 2, this.Size.Height / 2);
            DrawCercle(e.Graphics);
            Drawhands(e.Graphics, prev, true, Color.Blue);
        }
        private void DrawCercle(Graphics e)
        {
            System.Drawing.Point[] pt = new System.Drawing.Point[2];
            for(int iangle = 0; iangle <360; iangle += 6)
            {
                pt[0].X = 0;
                pt[0].Y = 150;
                Ptrotation(pt, 1, iangle);
                pt[1].X = pt[1].Y = (iangle % 5 == 0 ? 10 : 5);
                pt[0].X -= pt[1].X / 2;
                pt[0].Y -= pt[1].Y / 2;
                Pen p = new Pen(Color.FromArgb(255, 0, 0, 0));
                e.DrawEllipse(p, pt[0].X, pt[0].Y, pt[1].X, pt[1].Y);
                e.FillEllipse(new SolidBrush(Color.FromArgb(255, 0, 0, 0)) , pt[0].X, pt[0].Y, pt[1].X, pt[1].Y);
            }
        }
        private void Drawhands(Graphics e , DateTime dt , bool change, Color c)
        {
            System.Drawing.Point[,] temppt = new System.Drawing.Point[3, 2];
            int[] iangle = new int[3];
            iangle[0] = (int)((dt.Hour * 30) % 360 + dt.Minute / 2);
            iangle[1] = (int)((dt.Minute * 6));
            iangle[2] = (int)((dt.Second * 6));
            temppt = (System.Drawing.Point[,])(hands_coord.Clone());
            for(int i = change ?0:2; i < 3; i++)
            {
                System.Drawing.Point[] tt = { temppt[i, 0], temppt[i, 1] };
                Ptrotation(tt, 2, iangle[i]);
                Pen p = new Pen(c);
                e.DrawLine(p, tt[0], tt[1]);
            }
        }

        private void Chronometre_Tick(object sender, EventArgs e)
        {
            cur = DateTime.Now;
            change = cur.Hour != prev.Hour || cur.Minute != prev.Minute;
            Drawhands(this.CreateGraphics(), cur, change, Color.FromArgb(255, 255, 255, 255));
            Drawhands(this.CreateGraphics(), cur, true, Color.FromArgb(255, 0, 0, 0));
            prev = cur;
            Invalidate();

        }

        private void EcranHorloge_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
