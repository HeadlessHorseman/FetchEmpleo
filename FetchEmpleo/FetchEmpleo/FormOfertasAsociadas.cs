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
    public partial class FormOfertasAsociadas : Form
    {
        public FormOfertasAsociadas()
        {
            InitializeComponent();
        }

        private void FormOfertasAsociadas_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = MessageBox.Show("¿Está seguro de que quiere salir?", "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.No)
                e.Cancel = true;
        }
    }
}
