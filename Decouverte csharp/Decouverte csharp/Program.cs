using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Decouverte_csharp
{
    sealed class ParamApplication : ApplicationSettingsBase
    {       // permet d'aller voir les parametre de l'application

        [UserScopedSetting()]   // attribut a mettre pour le faire fonctionner
        public string ChCommBD
        {
            get { return (string)this["csPerso"]; } // permet de lire
            set { this["csPerso"] = value; } // pzrmet de modifier
        }
    }
    static class Program
    {
        public static ParamApplication PA = new ParamApplication(); // permet d'accéder partout
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new EcranAcceuil());
            Application.Run(new EcranPrincipal());
        }
    }
}
