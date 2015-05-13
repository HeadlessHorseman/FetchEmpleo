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
    public partial class FormEditarDemandante : Form
    {
        Demandante demandante;        
        Datos datosBD;
        public event Cerrar CerrarPadre;

        public FormEditarDemandante()
        {
            InitializeComponent();
            Inicializar();
        }
        public FormEditarDemandante(Datos datosBD, Demandante demandante)
        {
            this.datosBD = datosBD;
            this.demandante = demandante;
            InitializeComponent();
            Inicializar();
        }

        
        void Inicializar()
        {
            lbl_ID.Text = demandante.Id.ToString();
            //Edición
            tbxDni.Text = demandante.Dni;
            tbxNombre.Text = demandante.Nombre;
            tbxApellidos.Text = demandante.Apellidos;
            tbxDomicilio.Text = demandante.Domicilio;
            tbxSexo.Text = demandante.Sexo;
            tbxDiscapacidad.Text = demandante.Discapacitado.ToString();
            tbxTelefono.Text = demandante.Telefono.ToString();
            tbxEmail.Text = demandante.Email;
            tbxWeb.Text = demandante.Web;
        }

        //Sólo números en el texbox de Teléfono        
        private void tbxTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void FormEditarDemandante_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = MessageBox.Show("¿Está seguro de que quiere salir?", "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.No)
                e.Cancel = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            demandante = new Demandante();

            demandante.Dni = tbxDni.Text;
            demandante.Apellidos = tbxApellidos.Text;
            demandante.Nombre = tbxNombre.Text;
            demandante.Sexo = tbxSexo.Text;
            demandante.Discapacitado = Convert.ToBoolean(tbxDiscapacidad.Text);
            demandante.Email = tbxEmail.Text;
            demandante.Telefono = Convert.ToInt32(tbxTelefono.Text);
            demandante.Domicilio = tbxDomicilio.Text;
            demandante.Web = tbxWeb.Text;

            try
            {
                datosBD.ModificarDemandante(demandante);
                Inicializar();
            }
            catch (Exception mysqlException)
            {
                MessageBox.Show(mysqlException.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
