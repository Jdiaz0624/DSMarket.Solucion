using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSMarket.Solucion.Pantallas.Pantallas.Historial
{
    public partial class HistorialFacturacion : Form
    {
        public HistorialFacturacion()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaHistorial.LogicaHistorial> ObjdataHistorial = new Lazy<Logica.Logica.LogicaHistorial.LogicaHistorial>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region MOSTRAR EL LISTADO DE FACTURAS
        private void ListadoFacturas() {
            decimal? _NumeroFactura = string.IsNullOrEmpty(txtNumerofactura.Text.Trim()) ? new Nullable<decimal>() : Convert.ToDecimal(txtNumerofactura.Text.Trim());
            string _FacturadoA = string.IsNullOrEmpty(txtFacturadoA.Text.Trim()) ? null : txtFacturadoA.Text.Trim();
            DateTime? _FechaDesde = cbAgregarRangoFecha.Checked == true ? string.IsNullOrEmpty(txtFechaDesde.Text.Trim()) ? new Nullable<DateTime>() : Convert.ToDateTime(txtFechaDesde.Text) : new Nullable<DateTime>();
            DateTime? _FechaHasta = cbAgregarRangoFecha.Checked == true ? string.IsNullOrEmpty(txtFechaHasta.Text.Trim()) ? new Nullable<DateTime>() : Convert.ToDateTime(txtFechaHasta.Text) : new Nullable<DateTime>();

            var BuscarHistorial = ObjdataHistorial.Value.HistorialFacturacion(
                _NumeroFactura,
                null,
                _FacturadoA,
                null,
                _FechaDesde,
                _FechaHasta,
                (int)txtNumeroPagina.Value,
                (int)txtNumeroRegistros.Value);
            if (BuscarHistorial.Count() < 1) { }
            else {
                dtListado.DataSource = BuscarHistorial;
                decimal GananciaTotal = 0;
                foreach (var n in BuscarHistorial) {
                    GananciaTotal = (decimal)n.GananciaVenta;
                }
                lbGananciaVariable.Text = GananciaTotal.ToString("N2");
                OcultarColumnas();
            }
        }
        private void OcultarColumnas() {
            //this.dtListado.Columns["NumeroFactura"].Visible = false;
            this.dtListado.Columns["NumeroConector"].Visible = false;
            //this.dtListado.Columns["FacturadoA"].Visible = false;
            this.dtListado.Columns["CodigoCliente"].Visible = false;
            this.dtListado.Columns["IdTipoFacturacion"].Visible = false;
            //this.dtListado.Columns["TipoFacturacion"].Visible = false;
            this.dtListado.Columns["Comentario"].Visible = false;
            //this.dtListado.Columns["TotalProductos"].Visible = false;
            //this.dtListado.Columns["TotalServicios"].Visible = false;
            //this.dtListado.Columns["TotalItems"].Visible = false;
            //this.dtListado.Columns["SubTotal"].Visible = false;
            //this.dtListado.Columns["DescuentoTotal"].Visible = false;
            //this.dtListado.Columns["ImpuestoTotal"].Visible = false;
            //this.dtListado.Columns["TotalGeneral"].Visible = false;
            this.dtListado.Columns["IdTipoPago"].Visible = false;
            //this.dtListado.Columns["TipoPago"].Visible = false;
            //this.dtListado.Columns["MontoPagado"].Visible = false;
            //this.dtListado.Columns["Cambio"].Visible = false;
            this.dtListado.Columns["IdMoneda"].Visible = false;
            //this.dtListado.Columns["Moneda"].Visible = false;
            //this.dtListado.Columns["Tasa"].Visible = false;
            this.dtListado.Columns["IdUsuario"].Visible = false;
            //this.dtListado.Columns["CreadoPor"].Visible = false;
            this.dtListado.Columns["FechaFacturacion0"].Visible = false;
            //this.dtListado.Columns["FechaFacturacion"].Visible = false;
            this.dtListado.Columns["IdComprobante"].Visible = false;
            //this.dtListado.Columns["NCF"].Visible = false;
            //this.dtListado.Columns["ValidoHasta"].Visible = false;
            //this.dtListado.Columns["NumeroComprobante"].Visible = false;
            this.dtListado.Columns["CapitalInvertido"].Visible = false;
            this.dtListado.Columns["GananciaVenta"].Visible = false;


        }
        #endregion
        private void RestablecerPantalla() {
            txtNumerofactura.Text = string.Empty;
            txtFacturadoA.Text = string.Empty;
            txtFechaDesde.Text = string.Empty;
            txtFechaHasta.Text = string.Empty;
            txtNumeroPagina.Value = 1;
            txtNumeroRegistros.Value = 10;
            ListadoFacturas();
            btnBuscar.Enabled = true;
            btnReImprimir.Enabled = false;
            btnItemsAgregados.Enabled = false;
            btnEstadisticaVenta.Enabled = true;
            btnReporteventa.Enabled = true;
            btnAnularfactura.Enabled = false;
            txtNumeroPagina.Enabled = true;
            txtNumeroRegistros.Enabled = true;
        }

        private void GenerarFactura() {
            DSMarket.Solucion.Pantallas.Pantallas.Reportes.Reportes Factura = new Reportes.Reportes();
            Factura.GenerarFacturaVenta(VariablesGlobales.IdMantenimeinto, false);
            Factura.ShowDialog();
            RestablecerPantalla();
        }
        private void HistorialFacturacion_Load(object sender, EventArgs e)
        {
            lbTitulo.Text = "HISTORIAL DE FACTURACION";
            lbTitulo.ForeColor = Color.White;
            lbGananciaTitulo.ForeColor = Color.White;
            lbGananciaVariable.ForeColor = Color.White;
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            ListadoFacturas();
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void HistorialFacturacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing) {
                e.Cancel = true;
            }
          
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ListadoFacturas();
        }

        private void txtNumerofactura_TextChanged(object sender, EventArgs e)
        {
            try {
                ListadoFacturas();
            }
            catch (Exception) { }
        }

        private void txtFacturadoA_TextChanged(object sender, EventArgs e)
        {
            ListadoFacturas();
        }

        private void txtNumeroPagina_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroPagina.Value < 1)
            {
                txtNumeroPagina.Value = 1;
                ListadoFacturas();
            }
            else {
                ListadoFacturas();
            }
        }

        private void txtNumeroRegistros_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroRegistros.Value < 1)
            {
                txtNumeroRegistros.Value = 10;
                ListadoFacturas();
            }
            else {
                ListadoFacturas();
            }
        }

        private void txtNumerofactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            DSMarket.Logica.Comunes.ValidarControles.SoloNumeros(e);
        }

        private void btnrestablecer_Click(object sender, EventArgs e)
        {
            RestablecerPantalla();
        }

        private void dtListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.VariablesGlobales.IdMantenimeinto = Convert.ToDecimal(this.dtListado.CurrentRow.Cells["NumeroFactura"].Value.ToString());
            this.VariablesGlobales.NumeroConectorstring = this.dtListado.CurrentRow.Cells["NumeroConector"].Value.ToString();

            var Seleccionar = ObjdataHistorial.Value.HistorialFacturacion(
                VariablesGlobales.IdMantenimeinto,
                VariablesGlobales.NumeroConectorstring,
                null, null, null, null, 1, 1);
            dtListado.DataSource = Seleccionar;
            OcultarColumnas();
            btnBuscar.Enabled = false;
            btnReImprimir.Enabled = true;
            //   btnItemsAgregados.Enabled = false;
            //  btnEstadisticaVenta.Enabled = true;
            //  btnReporteventa.Enabled = true;
            // btnAnularfactura.Enabled = false;
            txtNumeroPagina.Enabled = false;
            txtNumeroRegistros.Enabled = false;
        }

        private void btnReImprimir_Click(object sender, EventArgs e)
        {
            GenerarFactura();
        }
    }
}
