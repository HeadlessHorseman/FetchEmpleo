using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroEmpresa
{
    public partial class FrnEmpresa : Form
    {

        #region variables
        string usuario;
        string passwd;
        string nombre;
        string cif;
        string dir;
        string razonso;
        string email;
        string tlf;
        string web;

        #endregion
        public FrnEmpresa()
        {
            InitializeComponent();
        }
        private void limpiarCampos()
        {
            foreach (TextBox item in pnlDatos.Controls)
            {
                item.Text = "";
            }
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            limpiarCampos(); 
        }

        private void btnIngresarDatos_Click(object sender, EventArgs e)
        {
            //daoEmpresa dao = new daoEmpresa();
            if (comprobarcampos())
            {
                //llamada al dao.registrar<- insert into table empresa
            }
            else
            {
                MessageBox.Show("Te has dejado campos sin rellenar");
            }
            
        }
        void llenarConDatos()
        {
            usuario = txbUsuario.Text.Trim(); ;
            passwd = txbContraseña.Text.Trim(); ;
            nombre=txbNombre.Text.Trim();
            cif = txbDNI.Text.Trim();
            dir = txbDir.Text.Trim();
            razonso = txbRS.Text.Trim();
            email = txbEmail.Text.Trim();
            tlf = txbtelf.Text.Trim();
            web = txbWeb.Text.Trim();

        }
        bool comprobarcampos()
        {
                foreach (TextBox item in pnlDatos.Controls)
                {
                    if (item.Text == "" || item.Text == " ")
                    {
                        return false;
                    }
                }
                return true;
        }

        private void txbContraseña_TextChanged(object sender, EventArgs e)
        {
            if(txbContraseña.Text != txbContraseña.Text.Trim())
            {
                MessageBox.Show("La contraseña no puede llevar espacios ni al comienzo ni al final");
                txbContraseña.Text = "";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //
            this.Close();
        }

     }
}
