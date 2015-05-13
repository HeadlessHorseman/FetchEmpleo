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
    public struct MyStruct
    {
        public bool condicion;
        public bool demandante;
    }

    public partial class FormPrincipalLogin : Form
    {
        

        const string IP = "127.0.0.1"; //red local
        const string BD = "proyectoFol";
        private MySqlConnection conexion;    
    
        public FormPrincipalLogin()
        {
            InitializeComponent();
            Inicializar();
        }

        private void Inicializar()
        {
            Conectar(IP, BD, "root", "usuario");
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            MyStruct esc = new MyStruct();
            
            esc.condicion = Entrar();
            if (checkBoxUsuario.Checked == true)
                esc.demandante = true;

            this.Tag = esc;
            if (esc.condicion == true)
                this.Close();            
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
            string usuario;
            string passwd;
            string sql ="select login, contrasena from usuario where login = '" + tbxUsuario.Text + "' and contrasena ='" + tbxContrasenya.Text + "';";
            MySqlCommand cmd = new MySqlCommand(sql, conexion);

            MySqlDataReader lector = cmd.ExecuteReader();

            try
            {
                lector.Read();
                usuario = lector["login"].ToString();
                passwd = lector["contrasena"].ToString();
                lector.Close();

                if (tbxUsuario.Text == usuario && tbxContrasenya.Text == passwd)
                    return true;
                else
                    return false;
            }
            catch
            {
                lector.Close();
                MessageBox.Show("Usuario o contraseña incorrectos...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Esto para qué es??
        private void tbxUsuario_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            tbxUsuario.SelectionLength = tbxUsuario.Text.Length;
        }

        private void tbxContrasenya_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tbxContrasenya.SelectionLength = tbxContrasenya.Text.Length;
        }
        //
    }
}
