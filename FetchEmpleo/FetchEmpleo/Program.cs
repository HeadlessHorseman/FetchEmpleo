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
         
            Application.Run(login);
            MyStruct esct = (MyStruct)login.Tag;
            if (esct.condicion == true)
            {
                if (esct.demandante == true)
                {
                    FormDemandante demandante = new FormDemandante();
                    Application.Run(demandante);
                }
                else
                {
                    formPrincipalEmpresa empresa = new formPrincipalEmpresa();
                    Application.Run(empresa);
                }
            }
        }
    }
}
