using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSMarket.Solucion.Pantallas.Pantallas.Seguridad
{
    public partial class ClaveSeguridad : Form
    {
        public ClaveSeguridad()
        {
            InitializeComponent();
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ClaveSeguridad_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void ClaveSeguridad_Load(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
            lbTitulo.ForeColor = Color.WhiteSmoke;
            lbTitulo.Text = "MANTENIMIENTO DE CLAVE DE SEGURIDAD";
            lbCantidadRegistrosVariable.ForeColor = Color.WhiteSmoke;
            lbCantidadRegistrosTitulo.ForeColor = Color.WhiteSmoke;
            txtClave.BackColor = Color.WhiteSmoke;
            txtClaveSeguridad.BackColor = Color.WhiteSmoke;
            txtConfirmarClave.BackColor = Color.WhiteSmoke;
            txtNumeroPagina.BackColor = Color.WhiteSmoke;
            txtNumeroRegistros.BackColor = Color.WhiteSmoke;
            ddlSeleccionarUsuario.BackColor = Color.WhiteSmoke;

            txtClave.ForeColor = Color.Black;
            txtClaveSeguridad.ForeColor = Color.Black;
            txtConfirmarClave.ForeColor = Color.Black;
            txtNumeroPagina.ForeColor = Color.Black;
            txtNumeroRegistros.ForeColor = Color.Black;
            ddlSeleccionarUsuario.ForeColor = Color.Black;



            dtListado.BackgroundColor = SystemColors.Control;

            txtClave.PasswordChar = '•';
            txtClaveSeguridad.PasswordChar = '•';
            txtConfirmarClave.PasswordChar = '•';
        }
    }
}
