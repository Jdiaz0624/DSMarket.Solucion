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
    public partial class Comprobantes : Form
    {
        public Comprobantes()
        {
            InitializeComponent();
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Comprobantes_Load(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
            txtClaveSeguridad.BackColor = Color.WhiteSmoke;
            txtDescripcion.BackColor = Color.WhiteSmoke;
            txtLimite.BackColor = Color.WhiteSmoke;
            txtPociciones.BackColor = Color.WhiteSmoke;
            txtSecuenciaFinal.BackColor = Color.WhiteSmoke;
            txtSecuenciaInicial.BackColor = Color.WhiteSmoke;
            txtSecuencial.BackColor = Color.WhiteSmoke;
            txtSerie.BackColor = Color.WhiteSmoke;
            txtTipoComprobante.BackColor = Color.WhiteSmoke;
            txtValidoHasta.BackColor = Color.WhiteSmoke;

            txtClaveSeguridad.ForeColor = Color.Black;
            txtDescripcion.ForeColor = Color.Black;
            txtLimite.ForeColor = Color.Black;
            txtPociciones.ForeColor = Color.Black;
            txtSecuenciaFinal.ForeColor = Color.Black;
            txtSecuenciaInicial.ForeColor = Color.Black;
            txtSecuencial.ForeColor = Color.Black;
            txtSerie.ForeColor = Color.Black;
            txtTipoComprobante.ForeColor = Color.Black;
            txtValidoHasta.ForeColor = Color.Black;

            txtClaveSeguridad.PasswordChar = '•';

            lbTitulo.Text = "MANTENIMIENTO DE COMPROBANTES";
            lbTitulo.ForeColor = Color.WhiteSmoke;

            dtListado.BackgroundColor = SystemColors.Control;
            cbEstatus.ForeColor = Color.DarkRed;
            cbPorDefecto.ForeColor = Color.DarkRed;
            cbUsarComprobantes.ForeColor = Color.DarkRed;
        }

        private void cbEstatus_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEstatus.Checked == true)
            {
                cbEstatus.ForeColor = Color.LimeGreen;
            }
            else
            {
                cbEstatus.ForeColor = Color.DarkRed;
            }
        }

        private void cbPorDefecto_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPorDefecto.Checked == true)
            {
                cbPorDefecto.ForeColor = Color.LimeGreen;
            }
            else
            {
                cbPorDefecto.ForeColor = Color.DarkRed;
            }
        }

        private void Comprobantes_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void cbUsarComprobantes_CheckedChanged(object sender, EventArgs e)
        {
            if (cbUsarComprobantes.Checked == true)
            {
                cbUsarComprobantes.ForeColor = Color.LimeGreen;
            }
            else {
                cbUsarComprobantes.ForeColor = Color.DarkRed;
            }
        }
    }
}
