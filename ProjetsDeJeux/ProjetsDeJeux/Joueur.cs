using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ProjetsDeJeux
{
    // cette classe va nous peemettre de definir le mouvement d'un joueur quelconque
    class Joueur
    {
    #region Declaration des variables pour les joueurs
        int nbrDeCube;
        int[] positionJoueur, compteurDuJoueur, positionDeLaCase;
        bool[] startJoueur;
        bool[] deplacement;
        Random Aleatoire;
    #endregion

    #region Attributs
        public Joueur()
        {
            compteurDuJoueur = new int[5] { 52, 52, 52, 52, 52 };
            positionJoueur = new int[4] { 0, 0, 0, 0, };

            startJoueur = new bool[4] { true, true, true, true };
            deplacement = new bool[4] { true, true, true, true };
            // declaration de la variable pour le dé
            Aleatoire = new Random();
        }
    #endregion

    #region Accesseurs

        public int _NbrDeCube
        {
            set { nbrDeCube = value; }
            get { return nbrDeCube; }
        }

        public int[] _CompteurDuJoueur
        {
            set { compteurDuJoueur = value; }
            get { return compteurDuJoueur; }
        }

        public int[] _PositionJoueur
        {
            set { positionJoueur = value; }
            get { return positionJoueur; }
        }

        public int [] _PositionDeCase
        {
            set { positionDeLaCase = value; }
            get { return positionDeLaCase; }
        }

        public bool[] _StartJoueur
        {
            set { startJoueur = value; }
            get { return startJoueur; }
        }
        public bool [] _Deplacement
        {
            set { deplacement = value; }
            get { return deplacement; }
        }
        #endregion

    #region Valeur du Dé
        //cette fonction  permet de gerer l'images de chaques vu du dé et l'afficher achaque lancé
        private void simulationDhe (PictureBox pictreBox , Image[] images )
        {
            // me donne un nombre aléatoire entre 1 et 6
            nbrDeCube = Aleatoire.Next(1, 7);
            // fais correspondre la chaque images a un nombre
            pictreBox.Image = images[nbrDeCube];
        }
    #endregion
    }
}
