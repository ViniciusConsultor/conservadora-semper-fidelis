using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SistemaConservadora
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormLogin log = new FormLogin();
            Application.Run(log);
           
            if (log.login)
                Application.Run(new FormPrincipal());
        }
    }
}
