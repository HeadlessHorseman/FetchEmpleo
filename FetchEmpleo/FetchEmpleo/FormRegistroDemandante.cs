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
    public partial class FormRegistroDemandante : Form
    {
        char sexo = ' ';
        bool discapacitado = false;

        public FormRegistroDemandante()
        {
            InitializeComponent();
        }

        Demandante nuevoDemand = new Demandante();

        #region Eventos

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void tbxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void tbxFNac_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbxTLF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void rbtHombre_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtHombre.Checked)
                sexo = 'H';
        }

        private void rbtMujer_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtMujer.Checked)
                sexo = 'M';
        }
        #endregion

        #region Métodos
        private void Limpiar()
        {
            try
            {
                foreach (TextBox textbox in pnlData.Controls)
                {
                    textbox.Text = "";
                }

                foreach (TextBox tbox in pnlData2.Controls)
                {
                    tbox.Text = "";
                }

                if (cbxDiscapacitado.Checked)
                    cbxDiscapacitado.Checked = false;


                if (rbtHombre.Checked)
                    rbtHombre.Checked = false;

                if (rbtMujer.Checked)
                    rbtMujer.Checked = false;
            }
            catch { }
        }

        
        //Comprobar que ambas contraseñas introducidas son iguales
        private bool ComprobarContraseña()
        {
            bool validar = false;
            if (tbxContraseña.Text != tbxConfirmarPw.Text)
                return validar;
            else
            {
                validar = true;
                return validar;
            }
        }

        //Comprobar que la cadena del email al menos contiene el caracter '@'
        private bool ComprobarEmail()
        {
            if (tbxEmail.Text.Contains("@"))
                return true;
            else return false;
        }

        //Comprobar que los campos obligatorios están rellenos
        private int ComprobarDatos()
        {

            if (ComprobarCamposObligatorios())
            {
                if (ComprobarContraseña() && ComprobarEmail() && ComprobarFecha())
                {
                    nuevoDemand.Nombre = tbxNombre.Text;
                    nuevoDemand.Apellidos = tbxApellidos.Text;
                    nuevoDemand.Login = tbxUsuario.Text;
                    nuevoDemand.Dni = tbxDNI.Text;
                    nuevoDemand.FechaNacimiento = Convert.ToDateTime(tbxFNac);
                    nuevoDemand.Sexo = sexo.ToString();

                    if (ComprobarDiscapacidad())
                        nuevoDemand.Discapacitado = true;
                    else
                        nuevoDemand.Discapacitado = false;

                    nuevoDemand.Domicilio = ComprobarDomicilio();
                    nuevoDemand.Telefono = int.Parse(ComprobarTlf());
                    nuevoDemand.Web = ComprobarWeb();
                    nuevoDemand.Email = tbxEmail.Text;

                    return 1;
                }
                else return 0;
            }
            else
            {
                MessageBox.Show("Se deben rellenar todos los campos obligatorios.");
                return 0;
            }
        }

        private bool ComprobarDiscapacidad()
        {
            if (cbxDiscapacitado.Checked)
                discapacitado = true;
            else
                discapacitado = false;

            return discapacitado;
        }

        //Comprobar que la fecha tiene el formato adecuado
        private bool ComprobarFecha()
        {
            try
            {
                Convert.ToDateTime(tbxFNac.Text);
                return true;
            }
            catch
            {
                MessageBox.Show("Entrada de fecha inválida.");
            }
            return false;
        }

        private string ComprobarDomicilio()
        {
            if (tbxDomicilio.Text == "")
                return "null";
            else
                return tbxDomicilio.Text;
        }

        private string ComprobarTlf()
        {
            if (tbxTLF.Text == "")
                return "null";
            else
                return tbxTLF.Text;
        }

        private string ComprobarWeb()
        {
            if (tbxPaginaWeb.Text == "")
                return "null";
            else
                return tbxPaginaWeb.Text;
        }

        private bool ComprobarCamposObligatorios()
        {
            foreach (TextBox tb in pnlData.Controls)
            {
                if (tb.Text == "" || tb.Text == " ")
                    return false;
            }

            if (!rbtHombre.Checked && !rbtMujer.Checked)
                return false;

            return true;
        }

        #endregion

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
