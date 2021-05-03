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
            if (BuscarHistorial.Count() < 1) {
                dtListado.DataSource = null;
            }
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
            //this.dtListado.Columns["Comentario"].Visible = false;
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

        private void GenerarReporteGananciaVenta(decimal IdUsuario) {
            try
            {
                decimal IdEstatusFacturacion = 0;
                string Estatus = "";
                decimal NumeroFactura = 0;
                string Descripcion = "";
                decimal IdCategoria = 0;
                decimal IdTipoProducto = 0;
                decimal PrecioCompra = 0;
                decimal PrecioVenta = 0;
                decimal CantidadVendida = 0;
                decimal TotalDescuentoAplicado = 0;
                decimal TotalVenta = 0;
                decimal TotalPrecioCompra = 0;
                decimal Ganancia = 0;
                decimal DescuentoAplicado = 0;
                string NumeroConectorFactura = "";

                //ELIMINAMOS LOS DATOS
                DSMarket.Logica.Comunes.ProcesarInformacion.Historial.ProcesarInformacionGananciaVenta EliminarRegistros = new Logica.Comunes.ProcesarInformacion.Historial.ProcesarInformacionGananciaVenta(
                    IdUsuario, 0, "", 0, "", 0, 0, 0, 0, 0, 0,0, 0, 0, 0, "DELETE");
                EliminarRegistros.ProcesarInformacion();

                //CARGAMOS LAS VARIABES
                decimal? _NumeroFactura = string.IsNullOrEmpty(txtNumerofactura.Text.Trim()) ? new Nullable<decimal>() : Convert.ToDecimal(txtNumerofactura.Text.Trim());
                string _FacturadoA = string.IsNullOrEmpty(txtFacturadoA.Text.Trim()) ? null : txtFacturadoA.Text.Trim();
                DateTime? _FechaDesde = cbAgregarRangoFecha.Checked == true ? string.IsNullOrEmpty(txtFechaDesde.Text.Trim()) ? new Nullable<DateTime>() : Convert.ToDateTime(txtFechaDesde.Text) : new Nullable<DateTime>();
                DateTime? _FechaHasta = cbAgregarRangoFecha.Checked == true ? string.IsNullOrEmpty(txtFechaHasta.Text.Trim()) ? new Nullable<DateTime>() : Convert.ToDateTime(txtFechaHasta.Text) : new Nullable<DateTime>();


                var InformacionHistorial = ObjdataHistorial.Value.HistorialFacturacion(
                    _NumeroFactura,
                    null,
                    _FacturadoA,
                    null,
                    _FechaDesde,
                    _FechaHasta,
                    1, 999999999);
                if (InformacionHistorial.Count() < 1)
                {
                    MessageBox.Show("No se encontrarón registros para cargar este reporte, favor de verificar los parametros ingresados.", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else {
                    foreach (var n in InformacionHistorial) {
                        IdEstatusFacturacion = (decimal)n.IdTipoFacturacion;
                        Estatus = n.TipoFacturacion;
                        NumeroFactura = (decimal)n.NumeroFactura;
                        TotalDescuentoAplicado = (decimal)n.DescuentoTotal;
                        TotalVenta = (decimal)n.TotalGeneral;
                        TotalPrecioCompra = (decimal)n.GananciaVenta;
                        Ganancia = (decimal)n.Ganancia;
                        NumeroConectorFactura = n.NumeroConector;

                        var InformacionItems = ObjdataHistorial.Value.ItemsAgregadosFactura(NumeroFactura, NumeroConectorFactura);
                        foreach (var n2 in InformacionItems) {
                            Descripcion = n2.Descripcion;
                            IdCategoria = (decimal)n2.IdCategoriaRespaldo;
                            IdTipoProducto = (decimal)n2.IdTipoProductoRespaldo;
                            PrecioCompra = (decimal)n2.PrecioCompraRespaldo;
                            PrecioVenta = (decimal)n2.Precio;
                            CantidadVendida = (decimal)n2.Cantidad;
                            DescuentoAplicado = (decimal)n2.Descuento;

                            //GUARDAMOS EL REGISTRO
                            DSMarket.Logica.Comunes.ProcesarInformacion.Historial.ProcesarInformacionGananciaVenta GuardarRegistro = new Logica.Comunes.ProcesarInformacion.Historial.ProcesarInformacionGananciaVenta(
                                IdUsuario,
                                IdEstatusFacturacion,
                                Estatus,
                                NumeroFactura,
                                Descripcion,
                                IdCategoria,
                                IdTipoProducto,
                                PrecioCompra,
                                PrecioVenta,
                                CantidadVendida,
                                DescuentoAplicado,
                                TotalDescuentoAplicado,
                                TotalVenta,
                                TotalPrecioCompra,
                                Ganancia, "INSERT");
                            GuardarRegistro.ProcesarInformacion();
                        }
                    }
                    //GENERAMOS EL REPORTE
                    DSMarket.Solucion.Pantallas.Pantallas.Reportes.Reportes Reporte = new Reportes.Reportes();
                    Reporte.GenerarReporteGananciaVenta(IdUsuario);
                    Reporte.ShowDialog();

                }


             

            }
            catch (Exception ex) {
                MessageBox.Show("Error al generar el reporte de estadistica, codigo de error: " + ex.Message, VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void GenerarReporteVentas(decimal IdUsuario) {
            try {
                decimal NumeroFActura = 0;
                decimal IdTipoFActuracion = 0;
                string NumeroConector = "";
                string FacturadoA;
                string NCF = "";
                DateTime FechaFActuracion = DateTime.Now;
                int TotalProductos = 0;
                int TotalServicios = 0;
                int TotalItems = 0;
                decimal SubTotal = 0;
                decimal Descuento = 0;
                decimal Impuesto = 0;
                decimal Total = 0;
                decimal IdTipoPago = 0;
                decimal MontoPagado = 0;
                decimal Cambio = 0;
                decimal IdMoneda = 0;
                decimal Tasa = 0;

                //ELIMINAMOS TODOS LOS REGISTROS MEDIANTE EL USUARIO
                DSMarket.Logica.Comunes.ProcesarInformacion.Historial.ProcesarInformacionInformacionInformacionVentas EliminarRegistros = new Logica.Comunes.ProcesarInformacion.Historial.ProcesarInformacionInformacionInformacionVentas(
                    IdUsuario, 0,0, "","", "", DateTime.Now, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "DELETE");
                EliminarRegistros.ProcesarInformacion();

                //SACAMOS LOS DATOS PARA CARGAR LAS VARIABLES
                decimal? _NumeroFactura = string.IsNullOrEmpty(txtNumerofactura.Text.Trim()) ? new Nullable<decimal>() : Convert.ToDecimal(txtNumerofactura.Text.Trim());
                string _FacturadoA = string.IsNullOrEmpty(txtFacturadoA.Text.Trim()) ? null : txtFacturadoA.Text.Trim();
                DateTime? _FechaDesde = cbAgregarRangoFecha.Checked == true ? string.IsNullOrEmpty(txtFechaDesde.Text.Trim()) ? new Nullable<DateTime>() : Convert.ToDateTime(txtFechaDesde.Text) : new Nullable<DateTime>();
                DateTime? _FechaHasta = cbAgregarRangoFecha.Checked == true ? string.IsNullOrEmpty(txtFechaHasta.Text.Trim()) ? new Nullable<DateTime>() : Convert.ToDateTime(txtFechaHasta.Text) : new Nullable<DateTime>();

                var HistorialVenta = ObjdataHistorial.Value.HistorialFacturacion(
                    _NumeroFactura,
                    null,
                    _FacturadoA,
                    null,
                    _FechaDesde,
                    _FechaHasta,
                    1, 999999999);
                if (HistorialVenta.Count() < 1)
                {
                    MessageBox.Show("No se encontraron registros para cargar el reporte", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else {
                    foreach (var n in HistorialVenta) {
                        NumeroFActura = (decimal)n.NumeroFactura;
                        IdTipoFActuracion = (decimal)n.IdTipoFacturacion;
                        NumeroConector = n.NumeroConector;
                        FacturadoA = n.FacturadoA;
                        NCF = n.NumeroComprobante;
                        FechaFActuracion = (DateTime)n.FechaFacturacion0;
                        TotalProductos = (int)n.TotalProductos;
                        TotalServicios = (int)n.TotalServicios;
                        TotalItems = (int)n.TotalItems;
                        SubTotal = (decimal)n.SubTotal;
                        Descuento = (decimal)n.DescuentoTotal;
                        Impuesto = (decimal)n.ImpuestoTotal;
                        Total = (decimal)n.TotalGeneral;
                        IdTipoPago = (decimal)n.IdTipoPago;
                        MontoPagado = (decimal)n.MontoPagado;
                        Cambio = (decimal)n.Cambio;
                        IdMoneda = (decimal)n.IdMoneda;
                        Tasa = (decimal)n.Tasa;

                        //GUARDAMOS LOS DATOS
                        DSMarket.Logica.Comunes.ProcesarInformacion.Historial.ProcesarInformacionInformacionInformacionVentas GuardarInformacion = new Logica.Comunes.ProcesarInformacion.Historial.ProcesarInformacionInformacionInformacionVentas(
                            IdUsuario,
                            NumeroFActura,
                            IdTipoFActuracion,
                            NumeroConector,
                            FacturadoA,
                            NCF,
                            FechaFActuracion,
                            TotalProductos,
                            TotalServicios,
                            TotalItems,
                            SubTotal,
                            Descuento,
                            Impuesto,
                            Total,
                            IdTipoPago,
                            MontoPagado,
                            Cambio,
                            IdMoneda,
                            Tasa,
                            "INSERT");
                        GuardarInformacion.ProcesarInformacion();
                    }

                    //GENERAMOS EL REPORTE
                    DSMarket.Solucion.Pantallas.Pantallas.Reportes.Reportes ReporteFacturacion = new Reportes.Reportes();
                    ReporteFacturacion.GenerarReporteVenta(VariablesGlobales.IdUsuario);
                    ReporteFacturacion.ShowDialog();
                }

            }
            catch (Exception ex) {
                MessageBox.Show("Error al generar el reporte de ventas, codigo de error: " + ex.Message, VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
               btnItemsAgregados.Enabled = true;
            //  btnEstadisticaVenta.Enabled = true;
            //  btnReporteventa.Enabled = true;
            // btnAnularfactura.Enabled = false;
            txtNumeroPagina.Enabled = false;
            txtNumeroRegistros.Enabled = false;
            int EstatusFacturacion = 0;
            var ValidarEstatusValidacion = ObjdataHistorial.Value.ValidarEstatusFacturacion(VariablesGlobales.NumeroConectorstring);
            foreach (var n in ValidarEstatusValidacion) {
                EstatusFacturacion = (int)n.EstatusFacturacion;
            }

            if (EstatusFacturacion == 1)
            {
                btnAnularfactura.Enabled = true;
            }
            else {
                btnAnularfactura.Enabled = false;
            }
        }

        private void btnReImprimir_Click(object sender, EventArgs e)
        {
            GenerarFactura();
        }

        private void btnItemsAgregados_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Historial.ItemsAgregadosFactura ItemsAgregados = new ItemsAgregadosFactura();
            ItemsAgregados.VariablesGlobales.IdMantenimeinto = VariablesGlobales.IdMantenimeinto;
            ItemsAgregados.VariablesGlobales.NumeroConectorstring = VariablesGlobales.NumeroConectorstring;
            ItemsAgregados.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            ItemsAgregados.ShowDialog();
        }

        private void btnEstadisticaVenta_Click(object sender, EventArgs e)
        {
            GenerarReporteGananciaVenta(VariablesGlobales.IdUsuario);
        }

        private void btnReporteventa_Click(object sender, EventArgs e)
        {
            GenerarReporteVentas(VariablesGlobales.IdUsuario);
        }

        private void btnAnularfactura_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Historial.AnularFactura Anular = new AnularFactura();
            Anular.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Anular.VariablesGlobales.IdMantenimeinto = VariablesGlobales.IdMantenimeinto;
            Anular.VariablesGlobales.NumeroConectorstring = VariablesGlobales.NumeroConectorstring;
            Anular.ShowDialog();
        }
    }
}
