using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FetchEmpleo
{
    public partial class formPrincipalEmpresa : Form
    {     
        string user = "root";
        string passwd = "usuario";
        Datos datosBD = null;
        Empresa empresa = new Empresa();
        Font btnF;
        OpenFileDialog elegirImagen;


        public formPrincipalEmpresa()
        {
            InitializeComponent();
            Inicializar();
        }
        void Inicializar()
        {
            btnF = btnMisOfertas.Font;
            if (TraerDatosBD() == true)
                MostrarDatosEmpresa();
        }

        #region Mis MÉTODOS
        bool TraerDatosBD()
        {
            bool condicion = true;
            datosBD = new Datos(user, passwd); //Conexión
            try
            {
                empresa = datosBD.SeleccionarEmpresa("heikki");
            }
            catch (Exception mysqlException)
            {
                MessageBox.Show(mysqlException.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                condicion = false;
            }
            return condicion;
        }

        void MostrarDatosEmpresa()
        {
            lblNombreEmpresa.Text = empresa.Nombre;
            lblCif.Text = empresa.Cif;
            lblRaSocial.Text = empresa.RaSocial;
            lblCategoria.Text = empresa.Categoria;
            lblDomicilio.Text = empresa.Domicilio;
            lblLocalizacion.Text = empresa.Localidad;
            lblTelefono.Text = empresa.Telefono.ToString();
            lblEmail.Text = empresa.Email;
            lblWebLink.Text = empresa.Web;
            lblNumOfertas.Text = datosBD.numOfertas(empresa.Id).ToString();
            if (empresa.Imagen != "null")
            {
                try
                {
                    pbxLogoEmpresa.Image = Image.FromFile(empresa.Imagen);
                }
                catch { }
            }
        }
        #endregion

        #region MANEJADORES DE LOS BOTONES
        //Aspecto de los 3 botones principales
        private void botones_MouseEnter(object sender, EventArgs e)
        {
            Font f = new Font(FontFamily.GenericSansSerif, 26);
            Button btn = (Button)sender;
            btn.Font = f;
        }
        private void botones_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Font = btnF;
        }
        
        //Mostrar Form de Mis Ofertas
        private void btnMisOfertas_Click(object sender, EventArgs e)
        {
            try
            {
                FormMisOfertas misOfertas = new FormMisOfertas(empresa.Imagen, empresa.Nombre, datosBD);
                misOfertas.CerrarPadre += misOfertas_CerrarPadre; //Suscripción para cerrar al padre cuando se cierren los hijos
                this.Hide();
                misOfertas.ShowDialog();
                this.Visible = true;
            }
            catch (ListaVaciaException)
            {
                MessageBox.Show("No hay ofertas disponibles", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch { }
            Inicializar();
        }

        //Mostrar Form de Publicar Oferta
        private void btnPublicarOferta_Click(object sender, EventArgs e)
        {           
            FormPublicarOferta publicarOferta = new FormPublicarOferta(empresa.Id, empresa.Nombre, empresa.Imagen, datosBD);
            publicarOferta.CerrarPadre += misOfertas_CerrarPadre;
            this.Hide();
            publicarOferta.ShowDialog();
            this.Visible = true;
            Inicializar();
        }
        //Mostrar Form de Ver Candiddatos
        private void btnVerCandidatos_Click(object sender, EventArgs e)
        {
            try
            {
                FormCandidatos verCandidatos = new FormCandidatos(empresa, datosBD);
                verCandidatos.CerrarPadre += misOfertas_CerrarPadre;
                this.Hide();
                verCandidatos.ShowDialog();
                this.Visible = true;
            }
            catch (ListaVaciaException)
            {
                MessageBox.Show("No hay candidatos disponibles", "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch { }
        }
        
        private void pbxEditarPerfil_Click(object sender, EventArgs e)
        {
            FormEdicionPerfil editarPerfil = new FormEdicionPerfil(datosBD, empresa);
            editarPerfil.CerrarPadre += misOfertas_CerrarPadre;
            this.Hide();
            editarPerfil.ShowDialog();
            this.Visible = true;
            Inicializar();
        }
        private void pbxSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
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
                empresa.Imagen = elegirImagen.FileName;
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
        #endregion

        //Confirmación de cierre
        private void formPrincipalEmpresa_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult=MessageBox.Show("¿Está seguro de que quiere salir?", "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.No)
                e.Cancel = true;
        }

        //Lanzar web en navegador
        private void lblWebLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(lblWebLink.Text);
        }

        void misOfertas_CerrarPadre()
        {
            this.Close();
        }
    }
    public class ListaVaciaException : Exception { }
    public delegate void Cerrar();
}
