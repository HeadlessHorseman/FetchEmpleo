using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace FetchEmpleo
{
    public partial class FormPrincipalLogin : Form
    {
        private MySqlConnection conexion;        
        public FormPrincipalLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            formPrincipalEmpresa Principal = new formPrincipalEmpresa();
          
            Entrar();
            
        }
        public bool Conectar(string srv, string db, string user, string pwd)
        {
            string cadenaConexion = "server=" + srv + ";" + "database=" + db + ";"
                + "uid=" + user + ";" + "pwd=" + pwd + ";";
            bool conectado = false;
            

            try
            {
                conexion = new MySqlConnection(cadenaConexion);
                conexion.Open(); //conexión habilitada
                conectado = true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 113: throw new Exception("Error en la conexión");
                    case 1045: throw new Exception("Usuario o contraseña incorrectos");
                }
            }
            return conectado;
        }
        private bool Entrar()
        {
            bool conectado=false;

            MySqlCommand cmd = new MySqlCommand("select login, contrasena from usuario where login = '" + tbxUsuario.Text + "' and contrasena ='" + tbxContrasenya.Text + "' ", conexion);
            return true;
        }

        
        private void tbxUsuario_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            tbxUsuario.SelectionLength = tbxUsuario.Text.Length;
        }

        private void tbxContrasenya_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tbxContrasenya.SelectionLength = tbxContrasenya.Text.Length;
        }

    }
}
