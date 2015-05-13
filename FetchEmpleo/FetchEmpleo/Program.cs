using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FetchEmpleo
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormPrincipalLogin login = new FormPrincipalLogin();
            formPrincipalEmpresa empresa = new formPrincipalEmpresa();
            FormDemandante demandante = new FormDemandante();
         
            Application.Run(login);
            MyStruct esct = (MyStruct)login.Tag;
            if (esct.condicion == true)
            {
                if (esct.demandante == true)
                    Application.Run(demandante);
                else
                    Application.Run(empresa);
            }
        }
    }
}
