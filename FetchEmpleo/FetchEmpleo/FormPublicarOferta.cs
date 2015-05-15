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
    public partial class FormPublicarOferta : Form
    {
        int maxId;
        int idEmpresa;
        string empresa;
        string logo;
        Datos datosBD;
        Oferta unaOferta = new Oferta();
        public event Cerrar CerrarPadre;

        public FormPublicarOferta()
        {
            InitializeComponent();
            maxId = 0;
        }
        public FormPublicarOferta(int idEmpresa, string empresa, string logo, Datos datosBD)
        {
            this.idEmpresa = idEmpresa;
            this.empresa = empresa;
            this.logo = logo;
            this.datosBD = datosBD;
            InitializeComponent();
            Inicializar();
        }

        void Inicializar()
        {
            maxId = 0;

            tbxTitulo.Select();
            lblNombreEmpresa.Text = empresa;
            if (logo != "null")
            {
                try
                {
                    pbxLogoEmpresa.Image = new Bitmap(logo);
                }
                catch { }
            }
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            maxId = datosBD.MaxId(idEmpresa);
            unaOferta.Id = maxId + 1;
            unaOferta.IdEmpresa = idEmpresa;
            unaOferta.Titulo = tbxTitulo.Text;
            unaOferta.Requisitos = tbxRequisitos.Text;
            unaOferta.Descripcion = tbxDescripcion.Text;
            if (rbtnSi.Checked == true)
                unaOferta.Discapacitado = true;
            else
                unaOferta.Discapacitado = false;
            unaOferta.Plazas = (int)nudNumPlazas.Value;
            //Insertar en BD
            try
            {
                datosBD.InsertarOferta(unaOferta);
                lblInsertado.Text = "¡Oferta añadida correctamente!";
                btnAplicar.Enabled = false;
            }
            catch (Exception mysqlException)
            {
                MessageBox.Show(mysqlException.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
