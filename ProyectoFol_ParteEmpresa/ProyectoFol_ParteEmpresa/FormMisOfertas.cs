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
    public partial class FormMisOfertas : Form
    {
        int indiceActual;
        string imagen;
        string empresa;
        Datos datosBD;
        Label[] arrLabelOferta;
        Panel[] arrPanelesOferta;
        List<Oferta> misOfertas = new List<Oferta>();
        public event Cerrar CerrarPadre;

        public FormMisOfertas()
        {
            InitializeComponent();
            
        }
        public FormMisOfertas(string imagen, string empresa, Datos bd)
        {
            InitializeComponent();
            this.imagen = imagen;
            this.empresa = empresa;
            datosBD = bd;
            Inicializar();
        }

        void Inicializar()
        {
            arrLabelOferta = new Label[] { lblOferta, lblOferta2, lblOferta3, lblOferta4 };
            arrPanelesOferta = new Panel[] { pnlOferta1, pnlOferta2, pnlOferta3, pnlOferta4 };
  
            if (imagen != "null")
                pbxLogoEmpresa.Image = new Bitmap(imagen);
            lblNombreEmpresa.Text = empresa;
            try
            {
                misOfertas = datosBD.SeleccionarMisOfertas("heikki"); //Traer datos Ofertas
            }
            catch (Exception mysqlException)
            {
                MessageBox.Show(mysqlException.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (misOfertas.Count == 0)
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
                    arrLabelOferta.ElementAt(j).Text = misOfertas.ElementAt(i).Titulo;
                    index++;
                    j++;
                } catch {
                    indiceActual = index;
                    break; 
                }
            }
            //Números de página
            if ((misOfertas.Count % 4) > 0)
                lblTotalPaginas.Text = ((misOfertas.Count / 4) + 1).ToString();
            else
                lblTotalPaginas.Text = (misOfertas.Count / 4).ToString();

            InhabilitarPaneles();
        }

        void InhabilitarPaneles()
        {
            for (int i = 0; i < arrLabelOferta.Length; i++)
            {
                if (arrLabelOferta[i].Text == string.Empty)
                {
                    arrPanelesOferta[i].Visible = false;
                    arrPanelesOferta[i].Enabled = false;
                }
            }
        }

        void HabilitarPaneles()
        {
            for (int i = 0; i < arrLabelOferta.Length; i++)
            {
                arrPanelesOferta[i].Visible = true;
                arrPanelesOferta[i].Enabled = true;
            }
        }

        #region BOTONES
        private void pbxAnterior_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lblPagina.Text) > 1)
            {
                lblPagina.Text = (Convert.ToInt32(lblPagina.Text) - 1).ToString();

                //Borrar títulos ofertas
                for (int i = 0; i < arrLabelOferta.Length; i++)
                {
                    arrLabelOferta[i].Text = "";
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
                for (int i = 0; i < arrLabelOferta.Length; i++)
                {
                    arrLabelOferta[i].Text = "";
                }
                MostrarDatosOferta(indiceActual);
            }
        }
        //Salir y Atras
        private void pbxSalir_Click(object sender, EventArgs e)
        {
            CerrarPadre();
            //HACER QUE AL CERRAR ESTE SE CIERRE EL FORM PRINCIPAL
        }
        private void pbxAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Borrar y Editar Ofertas
        private void pbxBorrarOf_Click(object sender, EventArgs e)
        {
            int indiceABorrar = -1;
            PictureBox botonEliminar = (PictureBox)sender;
            for (int i = 0; i < arrPanelesOferta.Length; i++)
            {
                if (arrPanelesOferta[i].Controls.Contains(botonEliminar)) //Si el botón Eliminar pertenece al Panel...
                {
                    indiceABorrar = (Convert.ToInt32(lblPagina.Text) * 4) - (4 - i);
                    if (MessageBox.Show("¿Está seguro de que quiere borrar la oferta?", "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            datosBD.BorrarOferta(misOfertas.ElementAt(indiceABorrar));
                            misOfertas.RemoveAt(indiceABorrar);
                        }
                        catch (Exception mysqlException)
                        {
                            MessageBox.Show(mysqlException.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        MostrarDatosOferta(0); //Cargar desde cero las Ofertas
                        lblPagina.Text = "1"; //Restablecer numeración página
                    }
                    break;
                }
            }
        }
        private void pbxEditOferta_Click(object sender, EventArgs e)
        {
            int indiceAEditar = -1;
            PictureBox botonEditar = (PictureBox)sender;
            for (int i = 0; i < arrPanelesOferta.Length; i++)
            {
                if (arrPanelesOferta[i].Controls.Contains(botonEditar)) //Si el botón Editar pertenece al Panel...
                {
                    indiceAEditar = (Convert.ToInt32(lblPagina.Text) * 4) - (4 - i);
                    break;
                }
            }
            //Mostrar Form de Editar Ofertas
            FormEditarOferta editarOferta = new FormEditarOferta(empresa, imagen, misOfertas.ElementAt(indiceAEditar), datosBD);
            this.Hide();
            editarOferta.ShowDialog();
            this.Visible = true;
        }
        //Ver Candidatos
        private void pbxCandidatos1_Click(object sender, EventArgs e)
        {
            //Por hacer
        }
        #endregion

    }
}
