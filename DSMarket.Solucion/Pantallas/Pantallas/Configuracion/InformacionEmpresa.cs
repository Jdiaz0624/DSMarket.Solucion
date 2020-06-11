using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSMarket.Solucion.Pantallas.Pantallas.Configuracion
{
    public partial class InformacionEmpresa : Form
    {
        public InformacionEmpresa()
        {
            InitializeComponent();
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cbCambiarLogo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCambiarLogo.Checked == true)
            {
                cbCambiarLogo.ForeColor = Color.LimeGreen;
            }
            else
            {
                cbCambiarLogo.ForeColor = Color.DarkRed;
            }
        }

        private void InformacionEmpresa_Load(object sender, EventArgs e)
        {
            cbCambiarLogo.ForeColor = Color.LimeGreen;
            cbCambiarLogo.Checked = false;
            this.BackColor = SystemColors.Control;
            txtClaveSeguridad.PasswordChar = '•';
            lbTitulo.Text = "INFORMACION DE EMPRESA";
            lbTitulo.ForeColor = Color.WhiteSmoke;

            txtClaveSeguridad.BackColor = Color.WhiteSmoke;
            txtDireccion.BackColor = Color.WhiteSmoke;
            txtEmail.BackColor = Color.WhiteSmoke;
            txtEmail2.BackColor = Color.WhiteSmoke;
            txtFacebook.BackColor = Color.WhiteSmoke;
            txtFax.BackColor = Color.WhiteSmoke;
            txtInstagram.BackColor = Color.WhiteSmoke;
            txtNombreEmpresa.BackColor = Color.WhiteSmoke;
            txtRNC.BackColor = Color.WhiteSmoke;
            txtTelefonos.BackColor = Color.WhiteSmoke;
            
            
        }

        private void InformacionEmpresa_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }
    }
}
