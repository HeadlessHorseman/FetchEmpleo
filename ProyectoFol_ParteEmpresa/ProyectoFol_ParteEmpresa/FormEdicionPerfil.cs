using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace  FetchEmpleo
{
    public partial class FormEdicionPerfil : Form
    {
        Datos datosBD;
        Empresa empresa;
        OpenFileDialog elegirImagen;
        public event Cerrar CerrarPadre;

        #region CONSTRUCTORES
        public FormEdicionPerfil()
        {
            InitializeComponent();
            Inicializar();
        }
        public FormEdicionPerfil(Datos datosBD, Empresa empresa)
        {
            this.datosBD = datosBD;
            this.empresa = empresa;
            InitializeComponent();
            Inicializar();
        }
        #endregion

        void Inicializar()
        {
            lblNombreEmpresa.Text = empresa.Nombre;
            if (string.IsNullOrEmpty(empresa.Imagen))
                pbxLogoEmpresa.Image = new Bitmap(empresa.Imagen);
            //Edición
            tbxNombre.Text = empresa.Nombre;
            tbxCif.Text = empresa.Cif;
            tbxRaSocial.Text = empresa.RaSocial;
            tbxCategoria.Text = empresa.Categoria;
            tbxDireccion.Text = empresa.Domicilio;
            tbxLocalidad.Text = empresa.Localidad;
            tbxTelefono.Text = empresa.Telefono.ToString();
            tbxEmail.Text = empresa.Email;
            tbxWeb.Text = empresa.Web;
        }

        //Cambios en el perfil
        private void btnAplicar_Click(object sender, EventArgs e)
        {
            empresa.Nombre = tbxNombre.Text;
            empresa.Cif = tbxCif.Text;
            empresa.RaSocial = tbxRaSocial.Text;
            empresa.Categoria = tbxCategoria.Text;
            empresa.Domicilio = tbxDireccion.Text;
            empresa.Localidad = tbxLocalidad.Text;
            empresa.Telefono = Convert.ToInt32(tbxTelefono.Text);
            empresa.Email = tbxEmail.Text;
            empresa.Web = tbxWeb.Text;

            try
            {
                datosBD.ModificarEmpresa(empresa);
                Inicializar();
            }
            catch (Exception mysqlException)
            {
                MessageBox.Show(mysqlException.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Cambiar imagen de logo
        private void pbxLogoEmpresa_Click(object sender, EventArgs e)
        {
            elegirImagen = new OpenFileDialog();
            Bitmap imagen;
            elegirImagen.Filter = "Imágenes (*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG";
            elegirImagen.RestoreDirectory = true;
            elegirImagen.Title = "Elegir imagen";

            if (elegirImagen.ShowDialog() == DialogResult.OK)
            {
                imagen = new Bitmap(elegirImagen.FileName);
                pbxLogoEmpresa.Image = imagen;
                try
                {
                    datosBD.LogoDeEmpresa("heikki", elegirImagen.FileName);
                }
                catch (Exception mysqlException)
                {
                    MessageBox.Show(mysqlException.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //Sólo números en el texbox de Teléfono
        private void tbxTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void pbxAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbxSalir_Click(object sender, EventArgs e)
        {
            //
        }
    }
}
