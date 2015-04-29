using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace  FetchEmpleo
{
    public partial class FormEditarOferta : Form
    {
        string empresa;
        string logo;
        Datos datosBD;
        Oferta unaOferta;
        public event Cerrar CerrarPadre;

        public FormEditarOferta()
        {
            InitializeComponent();
            Inicializar();
        }
        public FormEditarOferta(string empresa, string logo, Oferta unaOferta, Datos datosBD)
        {
            this.empresa = empresa;
            this.logo = logo;
            this.unaOferta = unaOferta;
            this.datosBD = datosBD;
            InitializeComponent();
            Inicializar();
        }

        void Inicializar()
        {
            lblNombreEmpresa.Text = empresa;
            if (logo != "null")
                pbxLogoEmpresa.Image = new Bitmap(logo);
            tbxTitulo.Text = unaOferta.Titulo;
            tbxRequisitos.Text = unaOferta.Requisitos;
            tbxDescripcion.Text = unaOferta.Descripcion;
            if (unaOferta.Discapacitado == true)
                rbtnSi.Checked = true;
            else
                rbtnNo.Checked = true;
            nudNumPlazas.Value = unaOferta.Plazas;
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            unaOferta.Titulo = tbxTitulo.Text;
            unaOferta.Requisitos = tbxRequisitos.Text;
            unaOferta.Descripcion = tbxDescripcion.Text;
            if (rbtnSi.Checked == true)
                unaOferta.Discapacitado = true;
            else
                unaOferta.Discapacitado = false;
            unaOferta.Plazas = (int)nudNumPlazas.Value;
            //Actualizar la oferta
            try
            {
                datosBD.ModificarOferta(unaOferta);
                lblCambios.Text = "¡Cambios aplicados correctamente!";
            }
            catch(Exception mysqlException)
            {
                MessageBox.Show(mysqlException.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbxTitulo_TextChanged(object sender, EventArgs e)
        {
            lblCambios.Text = string.Empty;
        }

        private void pbxAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CerrarPadre();
        }

    }
}
