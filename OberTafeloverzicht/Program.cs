using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace OberTafeloverzicht
{
    class Program
    {
        //public Werknemer ingelogdeWerknemer;
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Werknemer werknemer = null;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new OberTafelOverzichtForm(werknemer));
        }
    }
}
