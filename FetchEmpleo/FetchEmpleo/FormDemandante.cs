using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FetchEmpleo
{
    public partial class FormDemandante : Form
    {
        string user = "root";
        string passwd = "usuario";
        Datos datosBD = null;
        Demandante demandante = new Demandante();
        Font btnF;

        public FormDemandante()
        {
            InitializeComponent();
            Inicializar();
        }
        void Inicializar()
        {
            btnF = btnOfertasAsc.Font;
            if (TraerDatosBD() == true)
                MostrarDatosDemandante();
        }

        bool TraerDatosBD()
        {
            bool condicion = true;
            datosBD = new Datos(user, passwd); //Conexión
            try
            {
                demandante = datosBD.SeleccionarDemandante("demandante");
                //empresa = datosBD.SeleccionarEmpresa("heikki");
            }
            catch (Exception mysqlException)
            {
                MessageBox.Show(mysqlException.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                condicion = false;
            }
            return condicion;
        }

        void MostrarDatosDemandante()
        {
            lblDni.Text = demandante.Dni;
            lblNombre.Text = demandante.Nombre;
            lblApellidos.Text = demandante.Apellidos;
            lblDomicilio.Text = demandante.Domicilio;
            lblTelefono.Text = demandante.Telefono.ToString();
            lblEmail.Text = demandante.Email;
            lblSexo.Text = demandante.Sexo;
            lblWebLink.Text = demandante.Web;
            lblDiscp.Text = demandante.Discapacitado.ToString();
        }

        private void FormDemandante_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = MessageBox.Show("¿Está seguro de que quiere salir?", "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.No)
                e.Cancel = true;
        }

        private void btnOfertasAsc_Click(object sender, EventArgs e)
        {

        }

        private void btnEditarDts_Click(object sender, EventArgs e)
        {
            /*
            FormEditarDemandante editarPerfil = new FormEditarDemandante(datosBD, demandante);
            editarPerfil.CerrarPadre += misOfertas_CerrarPadre;
            this.Hide();
            editarPerfil.ShowDialog();
            this.Visible = true;
            Inicializar();
             */
        }

        private void lblWebLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(lblWebLink.Text);
        }

        void misOfertas_CerrarPadre()
        {
            this.Close();
        }
    }
}
