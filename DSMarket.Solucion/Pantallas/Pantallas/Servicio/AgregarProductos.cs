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
    public partial class AgregarProductos : Form
    {
        public AgregarProductos()
        {
            InitializeComponent();
        }


        #region APLICAR TEMA
        private void TemaGenerico() {
            this.BackColor= SystemColors.Control;


            ddlTipoProducto.BackColor = Color.WhiteSmoke;
            txtCodigo.BackColor = Color.WhiteSmoke;
            txtCodigoBarras.BackColor = Color.WhiteSmoke;
            txtReferencia.BackColor = Color.WhiteSmoke;
            ddlCategoria.BackColor = Color.WhiteSmoke;
            txtDescripcion.BackColor = Color.WhiteSmoke;
            txtNumeroPagina.BackColor = Color.WhiteSmoke;
            txtNumeroRegistros.BackColor = Color.WhiteSmoke;
            txtTipoProducto.BackColor = Color.WhiteSmoke;
            txtCategoria.BackColor = Color.WhiteSmoke;
            txtProducto.BackColor = Color.WhiteSmoke;
            txtCantidadDisponible.BackColor = Color.WhiteSmoke;
            txtCantidadUsar.BackColor = Color.WhiteSmoke;
            txtPrecio.BackColor = Color.WhiteSmoke;
            txtSegundoPrecio.BackColor = Color.WhiteSmoke;
            txtTercerprecio.BackColor = Color.WhiteSmoke;

            ddlTipoProducto.ForeColor = Color.Black;
            txtCodigo.ForeColor = Color.Black;
            txtCodigoBarras.ForeColor = Color.Black;
            txtReferencia.ForeColor = Color.Black;
            ddlCategoria.ForeColor = Color.Black;
            txtDescripcion.ForeColor = Color.Black;
            txtNumeroPagina.ForeColor = Color.Black;
            txtNumeroRegistros.ForeColor = Color.Black;
            txtTipoProducto.ForeColor = Color.Black;
            txtCategoria.ForeColor = Color.Black;
            txtProducto.ForeColor = Color.Black;
            txtCantidadDisponible.ForeColor = Color.Black;
            txtCantidadUsar.ForeColor = Color.Black;
            txtPrecio.ForeColor = Color.Black;
            txtSegundoPrecio.ForeColor = Color.Black;
            txtTercerprecio.ForeColor = Color.Black;


            dtSeleccionarproducto.BackgroundColor = SystemColors.Control;
            dtProductosAgregados.BackgroundColor = SystemColors.Control;

        }
        #endregion
        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Servicio.Facturacion Facturacion = new Facturacion();
            Facturacion.ShowDialog();
        }

        private void AgregarProductos_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void AgregarProductos_Load(object sender, EventArgs e)
        {
            TemaGenerico();
        }
    }
}
