using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSMarket.Solucion.Pantallas.Pantallas.Servicio
{
    public partial class AnularFactura : Form
    {
        public AnularFactura()
        {
            InitializeComponent();
        }

        #region APLICAR TEMA
        private void TemaGenerico()
        {
            this.BackColor = SystemColors.Control;

            txtTipoFacturacion.BackColor = Color.WhiteSmoke;
            txtNombreCliente.BackColor = Color.WhiteSmoke;
            txtTelefono.BackColor = Color.WhiteSmoke;
            txtTipoIdentificacion.BackColor = Color.WhiteSmoke;
            txtIdentificacion.BackColor = Color.WhiteSmoke;
            txtDireccion.BackColor = Color.WhiteSmoke;
            txtEmail.BackColor = Color.WhiteSmoke;
            txtFecha.BackColor = Color.WhiteSmoke;
            txtFaturadoPor.BackColor = Color.WhiteSmoke;
            txtCantidadArtiuclos.BackColor = Color.WhiteSmoke;
            txtCantidadServicios.BackColor = Color.WhiteSmoke;
            txtTotalDescuento.BackColor = Color.WhiteSmoke;
            txtSubtotal.BackColor = Color.WhiteSmoke;
            txtImpuesto.BackColor = Color.WhiteSmoke;
            txtTotal.BackColor = Color.WhiteSmoke;
            txtTipoPago.BackColor = Color.WhiteSmoke;
            txtMontoPagar.BackColor = Color.WhiteSmoke;
            txtcambio.BackColor = Color.WhiteSmoke;
            txtClaveSeguridad.BackColor = Color.WhiteSmoke;
            txtNumeroPagina.BackColor = Color.WhiteSmoke;
            txtNumeroRegistros.BackColor = Color.WhiteSmoke;

            txtTipoFacturacion.ForeColor = Color.Black;
            txtNombreCliente.ForeColor = Color.Black;
            txtTelefono.ForeColor = Color.Black;
            txtTipoIdentificacion.ForeColor = Color.Black;
            txtIdentificacion.ForeColor = Color.Black;
            txtDireccion.ForeColor = Color.Black;
            txtEmail.ForeColor = Color.Black;
            txtFecha.ForeColor = Color.Black;
            txtFaturadoPor.ForeColor = Color.Black;
            txtCantidadArtiuclos.ForeColor = Color.Black;
            txtCantidadServicios.ForeColor = Color.Black;
            txtTotalDescuento.ForeColor = Color.Black;
            txtSubtotal.ForeColor = Color.Black;
            txtImpuesto.ForeColor = Color.Black;
            txtTotal.ForeColor = Color.Black;
            txtTipoPago.ForeColor = Color.Black;
            txtMontoPagar.ForeColor = Color.Black;
            txtcambio.ForeColor = Color.Black;
            txtClaveSeguridad.ForeColor = Color.Black;
            txtNumeroPagina.ForeColor = Color.Black;
            txtNumeroRegistros.ForeColor = Color.Black;

            txtTipoFacturacion.Enabled = false;
            txtNombreCliente.Enabled = false;
            txtTelefono.Enabled = false;
            txtTipoIdentificacion.Enabled = false;
            txtIdentificacion.Enabled = false;
            txtDireccion.Enabled = false;
            txtEmail.Enabled = false;
            txtFecha.Enabled = false;
            txtFaturadoPor.Enabled = false;
            txtCantidadArtiuclos.Enabled = false;
            txtCantidadServicios.Enabled = false;
            txtTotalDescuento.Enabled = false;
            txtSubtotal.Enabled = false;
            txtImpuesto.Enabled = false;
            txtTotal.Enabled = false;
            txtTipoPago.Enabled = false;
            txtMontoPagar.Enabled = false;
            txtcambio.Enabled = false;

            dtListado.BackgroundColor = SystemColors.Control;
        }
        #endregion

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Servicio.HistorialFActuracion Historial = new HistorialFActuracion();
            Historial.ShowDialog();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void AnularFactura_Load(object sender, EventArgs e)
        {
            TemaGenerico();
            txtClaveSeguridad.PasswordChar = '•';
        }

        private void AnularFactura_FormClosing(object sender, FormClosingEventArgs e)
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
