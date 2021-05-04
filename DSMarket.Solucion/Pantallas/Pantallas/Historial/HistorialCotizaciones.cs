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
    public partial class HistorialCotizaciones : Form
    {
        Lazy<DSMarket.Logica.Logica.LogicaHistorial.LogicaHistorial> ObjdataHistorial = new Lazy<Logica.Logica.LogicaHistorial.LogicaHistorial>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        enum TipoProductoSeleccionado
        {
            ProductoNoSeleccionado = 1,
            ProductoSeleccionado = 2
        }
        private void RestablecerPantalla()
        {
            txtNumerofactura.Text = string.Empty;
            txtFacturadoA.Text = string.Empty;
            txtFechaDesde.Text = string.Empty;
            txtFechaHasta.Text = string.Empty;
            txtNumeroPagina.Value = 1;
            txtNumeroRegistros.Value = 10;
            Historial();
            btnBuscar.Enabled = true;
            btnReImprimir.Enabled = false;
            btnItemsAgregados.Enabled = false;
            btnReporteventa.Enabled = true;
            btnAnularfactura.Enabled = false;
            txtNumeroPagina.Enabled = true;
            txtNumeroRegistros.Enabled = true;
            VariablesGlobales.ProductoSeleccionadoFacturacion = 1;
        }
        private void Historial() {
            decimal? _NumeroCotizacion = string.IsNullOrEmpty(txtNumerofactura.Text.Trim()) ? new Nullable<decimal>() : Convert.ToDecimal(txtNumerofactura.Text.Trim());
            string _CotizadoA = string.IsNullOrEmpty(txtFacturadoA.Text.Trim()) ? null : txtFacturadoA.Text.Trim();
            DateTime? _FechaDesde = cbAgregarRangoFecha.Checked == true ? string.IsNullOrEmpty(txtFechaDesde.Text.Trim()) ? new Nullable<DateTime>() : Convert.ToDateTime(txtFechaDesde.Text) : new Nullable<DateTime>();
            DateTime? _FechaHasta = cbAgregarRangoFecha.Checked == true ? string.IsNullOrEmpty(txtFechaHasta.Text.Trim()) ? new Nullable<DateTime>() : Convert.ToDateTime(txtFechaHasta.Text) : new Nullable<DateTime>();

            var Listado = ObjdataHistorial.Value.HistorialCotizaciones(
                _NumeroCotizacion,
                null,
                _CotizadoA,
                null,
                _FechaDesde,
                _FechaHasta,
                (int)txtNumeroPagina.Value,
                (int)txtNumeroRegistros.Value);
            if (Listado.Count() < 1) {
                dtListado.DataSource = null;
                OcultarColumnas();
            }
            else {
                dtListado.DataSource = Listado;
                OcultarColumnas();
            }

        }
        private void OcultarColumnas() {
           // this.dtListado.Columns["NumeroCotizacion"].Visible = false;
            this.dtListado.Columns["NumeroConector"].Visible = false;
            //this.dtListado.Columns["CotizadoA"].Visible = false;
            this.dtListado.Columns["CodigoCliente"].Visible = false;
            this.dtListado.Columns["IdTipoFacturacion"].Visible = false;
            //this.dtListado.Columns["TipoFacturacion"].Visible = false;
            //this.dtListado.Columns["Comentario"].Visible = false;
            //this.dtListado.Columns["TotalProductos"].Visible = false;
            //this.dtListado.Columns["TotalServicios"].Visible = false;
            //this.dtListado.Columns["TotalItems"].Visible = false;
            //this.dtListado.Columns["SubTotal"].Visible = false;
            //this.dtListado.Columns["DescuentoTotal"].Visible = false;
            //this.dtListado.Columns["ImpuestoTotal"].Visible = false;
            //this.dtListado.Columns["TotalGeneral"].Visible = false;
            this.dtListado.Columns["IdTipoPago"].Visible = false;
            this.dtListado.Columns["TipoPago"].Visible = false;
            this.dtListado.Columns["MontoPagado"].Visible = false;
            this.dtListado.Columns["Cambio"].Visible = false;
            this.dtListado.Columns["IdMoneda"].Visible = false;
            //this.dtListado.Columns["Moneda"].Visible = false;
            //this.dtListado.Columns["Tasa"].Visible = false;
            this.dtListado.Columns["IdUsuario"].Visible = false;
            //this.dtListado.Columns["CreadoPor"].Visible = false;
            this.dtListado.Columns["FechaCotizacion0"].Visible = false;
            //this.dtListado.Columns["FechaCotizacion"].Visible = false;
        }
        public HistorialCotizaciones()
        {
            InitializeComponent();
        }

        private void HistorialCotizaciones_Load(object sender, EventArgs e)
        {
            lbTitulo.Text = "HISTORIAL DE COTIZACIONES";
            lbTitulo.ForeColor = Color.White;
            Historial();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (VariablesGlobales.ProductoSeleccionadoFacturacion == (int)TipoProductoSeleccionado.ProductoNoSeleccionado)
            {
                Historial();
            }
        }

        private void txtFacturadoA_TextChanged(object sender, EventArgs e)
        {
            if (VariablesGlobales.ProductoSeleccionadoFacturacion == (int)TipoProductoSeleccionado.ProductoNoSeleccionado)
            {
                Historial();
            }
        }

        private void txtNumerofactura_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (VariablesGlobales.ProductoSeleccionadoFacturacion == (int)TipoProductoSeleccionado.ProductoNoSeleccionado)
                {
                    Historial();
                }

            }
            catch (Exception) { }
        }

        private void txtNumerofactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            DSMarket.Logica.Comunes.ValidarControles.SoloNumeros(e);
        }

        private void txtNumeroPagina_ValueChanged(object sender, EventArgs e)
        {
            if (VariablesGlobales.ProductoSeleccionadoFacturacion == (int)TipoProductoSeleccionado.ProductoNoSeleccionado)
            {
                if (txtNumeroPagina.Value < 1)
                {
                    txtNumeroPagina.Value = 1;
                    Historial();
                }
                else
                {
                    Historial();
                }
            }
        }

        private void txtNumeroRegistros_ValueChanged(object sender, EventArgs e)
        {
            if (VariablesGlobales.ProductoSeleccionadoFacturacion == (int)TipoProductoSeleccionado.ProductoNoSeleccionado)
            {
                if (txtNumeroRegistros.Value < 1)
                {
                    txtNumeroRegistros.Value = 10;
                    Historial();
                }
                else
                {
                    Historial();
                }
            }
        }

        private void btnReImprimir_Click(object sender, EventArgs e)
        {
            DSMarket.Solucion.Pantallas.Pantallas.Reportes.Reportes Cotizacion = new Reportes.Reportes();
            Cotizacion.GenerarCotizacion(VariablesGlobales.IdMantenimeinto, false);
            Cotizacion.ShowDialog();
            RestablecerPantalla();
        }

        private void btnrestablecer_Click(object sender, EventArgs e)
        {
            RestablecerPantalla();
        }

        private void dtListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.VariablesGlobales.IdMantenimeinto = Convert.ToDecimal(this.dtListado.CurrentRow.Cells["NumeroCotizacion"].Value.ToString());
            this.VariablesGlobales.NumeroConectorstring = this.dtListado.CurrentRow.Cells["NumeroConector"].Value.ToString();

            var Seleccionar = ObjdataHistorial.Value.HistorialCotizaciones(
                VariablesGlobales.IdMantenimeinto,
                VariablesGlobales.NumeroConectorstring, null, null, null, null, 1, 1);
            dtListado.DataSource = Seleccionar;
            OcultarColumnas();
            btnBuscar.Enabled = false;
            btnReImprimir.Enabled = true;
            btnItemsAgregados.Enabled = true;
            txtNumeroPagina.Enabled = false;
            txtNumeroRegistros.Enabled = false;
         
            VariablesGlobales.ProductoSeleccionadoFacturacion = 2;
        }

        private void btnItemsAgregados_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Historial.ItemsAgregadosCotizacion ItemsAgregados = new ItemsAgregadosCotizacion();
            ItemsAgregados.VariablesGlobales.IdMantenimeinto = VariablesGlobales.IdMantenimeinto;
            ItemsAgregados.VariablesGlobales.NumeroConectorstring = VariablesGlobales.NumeroConectorstring;
            ItemsAgregados.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            ItemsAgregados.ShowDialog();
        }

        private void HistorialCotizaciones_FormClosing(object sender, FormClosingEventArgs e)
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
