using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Resources;

namespace ProjetsDeJeux
{
    public partial class EcranTableDeJeux : Form
    {
        public EcranTableDeJeux()
        {
            InitializeComponent();
        }
        // declaration des variables pour les 4 joueurs(avec la classe joueur qui a été créer)
        Joueur plyer0, plyer1, plyer2, plyer3;
        // variable permettant de manipulée les images des dés
        Image[] picturesdice;

        PictureBox[] TableDeJeux;
        // declaration des variable des bouton pour chaque joueurs
        Button[] buttonPlyr0, buttonPlyr1, buttonPlyr2, buttonPlyr3;
        //
        Button[][] xBouton = new Button[4][];

        // bitmap pour les 16 cheval de 4 players
        Bitmap[][] xBitmap = new Bitmap[16][];
        // initialaisation de chaque images du dé 
        Bitmap[] images_diceBmp = new Bitmap[7] { Properties.Resources.dice0, Properties.Resources.dice1, Properties.Resources.dice2,
        Properties.Resources.dice3, Properties.Resources.dice4, Properties.Resources.dice5, Properties.Resources.dice6 };

        // bitmap pour les 16 cheval de 4 players
        Bitmap[][] xbitmap = new Bitmap[16][];
        int nbrJr = 0;
        // fonction me permettant d'initialiser tous les variable des joueurs et ce qui conserne la table de jeux

        private void EcranTableDeJeux_Load_1(object sender, EventArgs e)
        {
            // ici on crée l'existance de chaque joueur
            plyer0 = new Joueur();
            plyer1 = new Joueur();
            plyer2 = new Joueur();
            plyer3 = new Joueur();

            nbrJr = EcranMenuFr.brIindex;
            // Boucle permettant d'inialisé le depart de chaque joueurs (referencé par la couleur de son enclot)
            for (int i = 0; i <= 3; i++)
            {
                //la position de départ du joueur, joueur0 par défaut a des positions mises à zéro
                plyer0._PositionJoueur[i] = 0;
                plyer1._PositionJoueur[i] = 12;
                plyer2._PositionJoueur[i] = 24;
                plyer3._PositionJoueur[i] = 36;
            }
            // positions pour chaque joueur du début à la fin de son mouvement sur le plateau y compris le stationnement
            plyer0._PositionDeCase = new int[52] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25,
                                         26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51 };
            plyer1._PositionDeCase = new int[52] { 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35,
                                         36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 52, 53, 54, 55 };
            plyer2._PositionDeCase = new int[52] { 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47,
                                         0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 56, 57, 58, 59 };
            plyer3._PositionDeCase = new int[52] { 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13,
                                         14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 60, 61, 62, 63 };
            // on créer des boutons pour chaque pion de chaque joueur
            buttonPlyr0 = new Button[4] { btnRed0, btnRed1, btnRed2, btnRed3 };
            buttonPlyr1 = new Button[4] { btnYellow0, btnYellow1, btnYellow2, btnYellow3 };
            buttonPlyr2 = new Button[4] { btnBlue0, btnBlue1, btnBlue2, btnBlue3 };
            buttonPlyr3 = new Button[4] { btnGreen0, btnGreen1, btnGreen2, btnGreen3 };

            // chaîne de boutons (jeu 4x4)
            xBouton[0] = buttonPlyr0;
            xBouton[1] = buttonPlyr1;
            xBouton[2] = buttonPlyr2;
            xBouton[3] = buttonPlyr3;
            // pour faire correspondre chaque images des dés a sa valeur
            picturesdice = new Image[7];
            // permet d'attribuer chaque image du dé a sa valeur
            for (int j = 0; j < picturesdice.Length; j++)
                picturesdice[j] = images_diceBmp[j];

            TableDeJeux = new PictureBox[64];

            int X = 404, Y = 12;
            for (int i = 0; i <= 47; i++)
            {
                // permet de créer a chaque passage une picture box pour chaque marche du tableau de jeu
                TableDeJeux[i] = new PictureBox();
                //permet de donner la taille de chaque marche
                TableDeJeux[i].Size = new Size(50, 50);
                //crée la couleur de fond de chaque marche
                TableDeJeux[i].BackColor = Color.WhiteSmoke;

                //
                if ((i >= 1 && i <= 5) || (i >= 11 && i <= 12) || (i >= 18 && i <= 22))
                    Y += 50 + 6;
                if ((i >= 6 && i <= 10) || (i >= 37 && i <= 41) || (i >= 47))
                    X += 50 + 6;
                if ((i >= 13 && i <= 17) || (i >= 23 && i <= 24) || (i >= 30 && i <= 34))
                    X -= 50 + 6;
                if ((i >= 25 && i <= 29) || (i >= 35 && i <= 36) || (i >= 42 && i <= 46))
                    Y -= 50 + 6;
                // permet d'avoir un couple de point en x et y pour pouvoir avoir la marche 
                TableDeJeux[i].Location = new Point(X, Y);

                if (i == 1)
                {
                    TableDeJeux[i].BackgroundImage = Properties.Resources.down2;
                    TableDeJeux[i].BackgroundImageLayout = ImageLayout.Stretch;
                }
                else if (i == 13)
                {
                    TableDeJeux[i].BackgroundImage = Properties.Resources.left2;
                    TableDeJeux[i].BackgroundImageLayout = ImageLayout.Stretch;
                }
                else if (i == 25)
                {
                    TableDeJeux[i].BackgroundImage = Properties.Resources.up2;
                    TableDeJeux[i].BackgroundImageLayout = ImageLayout.Stretch;
                }
                else if (i == 37
                    )
                {
                    TableDeJeux[i].BackgroundImage = Properties.Resources.right2;
                    TableDeJeux[i].BackgroundImageLayout = ImageLayout.Stretch;
                }

                this.Controls.Add(TableDeJeux[i]);
            }
            TableDeJeux[48] = pbRed1;
            TableDeJeux[49] = pbRed2; 
            TableDeJeux[50] = pbRed3;
            TableDeJeux[51] = pbRed4;

            TableDeJeux[52] = pbYellow1;
            TableDeJeux[53] = pbYellow2;
            TableDeJeux[54] = pbYellow3;
            TableDeJeux[55] = pbYellow4;

            TableDeJeux[56] = pbBlue1;
            TableDeJeux[57] = pbBlue2;
            TableDeJeux[58] = pbBlue3;
            TableDeJeux[59] = pbBlue4;

            TableDeJeux[60] = pbGreen1;
            TableDeJeux[61] = pbGreen2;
            TableDeJeux[62] = pbGreen3;
            TableDeJeux[63] = pbGreen4;
        }


        //private void EcranTableDeJeux_Load(object sender, EventArgs e)
        //{
        //    // ici on crée l'existance de chaque joueur
        //    plyer0 = new Joueur();
        //    plyer1 = new Joueur();
        //    plyer2 = new Joueur();
        //    plyer3 = new Joueur();

        //    nbrJr = EcranMenuEn.brIindex;
        //    // Boucle permettant d'inialisé le depart de chaque joueurs (referencé par la couleur de son enclot)
        //    for(int i =0; i<= 3; i++)
        //    {
        //        //la position de départ du joueur, joueur0 par défaut a des positions mises à zéro
        //        plyer0._PositionJoueur[i] = 0;
        //        plyer1._PositionJoueur[i] = 12;
        //        plyer2._PositionJoueur[i] = 24;
        //        plyer3._PositionJoueur[i] = 36;
        //    }
        //    // positions pour chaque joueur du début à la fin de son mouvement sur le plateau y compris le stationnement
        //        plyer0._PositionDeCase = new int[52] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25,
        //                                 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51 };
        //        plyer1._PositionDeCase = new int[52] { 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35,
        //                                 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 52, 53, 54, 55 };
        //        plyer2._PositionDeCase = new int[52] { 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47,
        //                                 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 56, 57, 58, 59 };
        //        plyer3._PositionDeCase = new int[52] { 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13,
        //                                 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 60, 61, 62, 63 };
        //        // on créer des boutons pour chaque pion de chaque joueur
        //        buttonPlyr0 = new Button[4] { btnRed0, btnRed1, btnRed2, btnRed3 };
        //        buttonPlyr1 = new Button[4] { btnYellow0, btnYellow1, btnYellow2, btnYellow3 };
        //        buttonPlyr2 = new Button[4] { btnBlue0, btnBlue1, btnBlue2, btnBlue3 };
        //        buttonPlyr3 = new Button[4] { btnGreen0, btnGreen1, btnGreen2, btnGreen3 };

        //        // chaîne de boutons (jeu 4x4)
        //        xBouton[0] = buttonPlyr0;
        //        xBouton[1] = buttonPlyr1;
        //        xBouton[2] = buttonPlyr2;
        //        xBouton[3] = buttonPlyr3;
        //        // pour faire correspondre chaque images des dés a sa valeur
        //        picturesdice = new Image[7];
        //        // permet d'attribuer chaque image du dé a sa valeur
        //        for (int j = 0; j < picturesdice.Length; j++)
        //            picturesdice[j] = images_diceBmp[j];

        //        TableDeJeux = new PictureBox[64];

        //        int X = 404, Y = 12;
        //    for(int i = 0; i<=47; i++)
        //    {
        //        // permet de créer a chaque passage une picture box pour chaque marche du tableau de jeu
        //        TableDeJeux[i] = new PictureBox();
        //        //permet de donner la taille de chaque marche
        //        TableDeJeux[i].Size = new Size(50, 50);
        //        //crée la couleur de fond de chaque marche
        //        TableDeJeux[i].BackColor = Color.DarkCyan;

        //        // permet de pouvoir avoir 
        //        if ((i >= 1 && i <= 5) || (i >= 11 && i <= 12) || (i >= 18 && i <= 22))
        //            Y += 50 + 6;
        //        if ((i >= 6 && i <= 10) || (i >= 37 && i <= 41) || (i >= 47))
        //            X += 50 + 6;
        //        if ((i >= 13 && i <= 17) || (i >= 23 && i <= 24) || (i >= 30 && i <= 34))
        //            X -= 50 + 6;
        //        if ((i >= 25 && i <= 29) || (i >= 35 && i <= 36) || (i >= 42 && i <= 46))
        //            Y -= 50 + 6;
        //        // permet d'avoir un couple de point en x et y pour pouvoir avoir la marche 
        //        TableDeJeux[i].Location = new Point(X, Y);

        //        if (i == 0)
        //        {
        //            TableDeJeux[i].BackgroundImage = Properties.Resources.down2;
        //            TableDeJeux[i].BackgroundImageLayout = ImageLayout.Stretch;
        //        }
        //        else if (i == 12)
        //        {
        //            TableDeJeux[i].BackgroundImage = Properties.Resources.left2;
        //            TableDeJeux[i].BackgroundImageLayout = ImageLayout.Stretch;
        //        }
        //        else if (i == 24)
        //        {
        //            TableDeJeux[i].BackgroundImage = Properties.Resources.up2;
        //            TableDeJeux[i].BackgroundImageLayout = ImageLayout.Stretch;
        //        }
        //        else if (i == 36)
        //        {
        //            TableDeJeux[i].BackgroundImage = Properties.Resources.right2;
        //            TableDeJeux[i].BackgroundImageLayout = ImageLayout.Stretch;
        //        }

        //        this.Controls.Add(TableDeJeux[i]);
        //    }
        //            TableDeJeux[48] = pbRed1;
        //            TableDeJeux[49] = pbRed2;
        //            TableDeJeux[50] = pbRed3;
        //            TableDeJeux[51] = pbRed4;

        //            TableDeJeux[52] = pbYellow1;
        //            TableDeJeux[53] = pbYellow2;
        //            TableDeJeux[54] = pbYellow3;
        //            TableDeJeux[55] = pbYellow4;

        //            TableDeJeux[56] = pbBlue1;
        //            TableDeJeux[57] = pbBlue2;
        //            TableDeJeux[58] = pbBlue3;
        //            TableDeJeux[59] = pbBlue4;

        //            TableDeJeux[60] = pbGreen1;
        //            TableDeJeux[61] = pbGreen2;
        //            TableDeJeux[62] = pbGreen3;
        //            TableDeJeux[63] = pbGreen4;
        //}

    //     mes Methodes 
    //    private void SetFigure(int[] fic)
    //    {

    //    }
    }
}
