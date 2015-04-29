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
    public partial class FormCandidatos : Form
    {
        int indiceActual;
        Empresa empresa;
        Datos datosBD;
        Label[] arrLabelCandidato;
        Panel[] arrPanelesCandidatos;
        List<Demandante> misCandidatos = new List<Demandante>();
        public event Cerrar CerrarPadre;

        #region CONSTRUCTORES
        public FormCandidatos()
        {
            InitializeComponent();
        }
        public FormCandidatos(Empresa empresa, Datos datosBD)
        {
            this.empresa = empresa;
            this.datosBD = datosBD;
            InitializeComponent();
            Inicializar();
        }
        #endregion

        void Inicializar()
        {
            arrLabelCandidato = new Label[] { lblCandidato, lblCandidato2, lblCandidato3, lblCandidato4 };
            arrPanelesCandidatos = new Panel[] { pnlCandidato1, pnlCandidato2, pnlCandidato3, pnlCandidato4 };
            
            lblNombreEmpresa.Text = empresa.Nombre;
            if (empresa.Imagen != "null")
                pbxLogoEmpresa.Image = new Bitmap(empresa.Imagen);
            
            try
            {
                misCandidatos = datosBD.SeleccionarCandidatos(empresa.Id); //Traer Candidatos
            }
            catch (Exception mysqlException)
            {
                MessageBox.Show(mysqlException.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (misCandidatos.Count == 0)
                throw new ListaVaciaException();
            indiceActual = 0;
            MostrarDatosOferta(indiceActual);
        }

        void MostrarDatosOferta(int index) // MUESTRA LOS 4 PRIMEROS
        {
            HabilitarPaneles();

            int j = 0;
            for (int i = index; i < index + 4; i++)
            {
                try
                {
                    arrLabelCandidato.ElementAt(j).Text = misCandidatos.ElementAt(i).Nombre+" "+misCandidatos.ElementAt(i).Apellidos;
                    index++;
                    j++;
                }
                catch
                {
                    indiceActual = index;
                    break;
                }
            }
            //Números de página
            if ((misCandidatos.Count % 4) > 0)
                lblTotalPaginas.Text = ((misCandidatos.Count / 4) + 1).ToString();
            else
                lblTotalPaginas.Text = (misCandidatos.Count / 4).ToString();

            InhabilitarPaneles();
        }

        void InhabilitarPaneles()
        {
            for (int i = 0; i < arrLabelCandidato.Length; i++)
            {
                if (arrLabelCandidato[i].Text == string.Empty)
                {
                    arrPanelesCandidatos[i].Visible = false;
                    arrPanelesCandidatos[i].Enabled = false;
                }
            }
        }

        void HabilitarPaneles()
        {
            for (int i = 0; i < arrLabelCandidato.Length; i++)
            {
                arrPanelesCandidatos[i].Visible = true;
                arrPanelesCandidatos[i].Enabled = true;
            }
        }

        #region BOTONES
        private void pbxAnterior_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lblPagina.Text) > 1)
            {
                lblPagina.Text = (Convert.ToInt32(lblPagina.Text) - 1).ToString();

                //Borrar títulos ofertas
                for (int i = 0; i < arrLabelCandidato.Length; i++)
                {
                    arrLabelCandidato[i].Text = "";
                }
                indiceActual -= 8;
                if (indiceActual < 0)
                    indiceActual = 0;
                MostrarDatosOferta(indiceActual);
            }
        }
        private void pbxSiguiente_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lblPagina.Text) < Convert.ToInt32(lblTotalPaginas.Text))
            {
                lblPagina.Text = (Convert.ToInt32(lblPagina.Text) + 1).ToString();

                //Borrar títulos ofertas
                for (int i = 0; i < arrLabelCandidato.Length; i++)
                {
                    arrLabelCandidato[i].Text = "";
                }
                MostrarDatosOferta(indiceActual);
            }
        }
        #endregion

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbxSalir_Click(object sender, EventArgs e)
        {
            CerrarPadre();
        }
    }
}
