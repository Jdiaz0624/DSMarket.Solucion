﻿using System;
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
    public partial class FacturacionProductosServicios : Form
    {
        public FacturacionProductosServicios()
        {
            InitializeComponent();
        }
        enum TipoProductoSeleccionado { 
        ProductoNoSeleccionado=1,
        ProductoSeleccionado=2
        }

        Lazy<DSMarket.Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion> ObjDataConfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion>();
        Lazy<DSMarket.Logica.Logica.LogicaListas.LogicaListas> ObjDataListas = new Lazy<Logica.Logica.LogicaListas.LogicaListas>();
        Lazy<DSMarket.Logica.Logica.LogicaEmpresa.LogicaEmpresa> ObjDataEmpresa = new Lazy<Logica.Logica.LogicaEmpresa.LogicaEmpresa>();
        Lazy<DSMarket.Logica.Logica.LogicaServicio.LogicaServicio> ObjDataServicio = new Lazy<Logica.Logica.LogicaServicio.LogicaServicio>();
        Lazy<DSMarket.Logica.Logica.LogicaInventario.LogicaInventario> ObjDataInventario = new Lazy<Logica.Logica.LogicaInventario.LogicaInventario>();
        Lazy<DSMarket.Logica.Logica.LogicaCaja.LogicaCaja> ObjDataCaja = new Lazy<Logica.Logica.LogicaCaja.LogicaCaja>();
        Lazy<DSMarket.Logica.Logica.LogicaSeguridad.LogicaSeguridad> ObjDataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad.LogicaSeguridad>();
        Lazy<DSMarket.Logica.Logica.LogicaContabilidad.LogicaContabilidad> ObjdataContabilidad = new Lazy<Logica.Logica.LogicaContabilidad.LogicaContabilidad>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region CARGAR LAS LISTAS
        /// <summary>
        /// Muestra todos los tipos de productos del sistema
        /// </summary>
        private void CargarTipoPdoducto()
        {
            try
            {
                var TipoProducto = ObjDataListas.Value.ListaTipoProducto(
                    new Nullable<decimal>(),
                    null);
                ddlTipoProducto.DataSource = TipoProducto;
                ddlTipoProducto.DisplayMember = "Descripcion";
                ddlTipoProducto.ValueMember = "IdTipoproducto";
            }
            catch (Exception) { }
        }
        /// <summary>
        /// Muestra todas las categorias del sistema
        /// </summary>
        private void CargarCategorias()
        {
            try
            {
                var Categoria = ObjDataListas.Value.ListadoCategorias(
                    Convert.ToDecimal(ddlTipoProducto.SelectedValue));
                ddlCategoria.DataSource = Categoria;
                ddlCategoria.DisplayMember = "Descripcion";
                ddlCategoria.ValueMember = "IdCategoria";
            }
            catch (Exception) { }
        }

        /// <summary>
        /// Muestra todas las marcas registradas en el sistema
        /// </summary>
        private void CargarMarcas()
        {
            try
            {
                var Marca = ObjDataListas.Value.BucaLisaMarcas(
                    Convert.ToDecimal(ddlCategoria.SelectedValue));
                ddlMarca.DataSource = Marca;
                ddlMarca.DisplayMember = "Descripcion";
                ddlMarca.ValueMember = "IdMarca";
            }
            catch (Exception) { }

        }

        /// <summary>
        /// Mostramos el listado de los tipos de pagos
        /// </summary>
        private void MostrarListadoTipoPagos()
        {
            var TipoPago = ObjDataListas.Value.BuscaTipoPago(
                new Nullable<decimal>());
            ddltIPago.DataSource = TipoPago;
            ddltIPago.DisplayMember = "TipoPago";
            ddltIPago.ValueMember = "IdTipoPago";
        }

        /// <summary>
        /// Este metodo es para cargar las monedas del sistema
        /// </summary>
          private void CargarMonedas()
        {
            try
            {
                var Marca = ObjDataListas.Value.CargarListadoMonedas();
                ddlSeleccionarMoneda.DataSource = Marca;
                ddlSeleccionarMoneda.DisplayMember = "Descripcion";
                ddlSeleccionarMoneda.ValueMember = "IdMoneda";
            }
            catch (Exception) { }

        }
        #endregion
        #region MOSTRAR EL LISTADO DE LOS PRODUCTOS A FACTURAR
        private void MostrarListadoProductos() {
            decimal? TipoProducto = cbTipoProducto.Checked == true ? Convert.ToDecimal(ddlTipoProducto.SelectedValue) : new Nullable<decimal>();
            decimal? Categoria = cbCategoria.Checked == true ? Convert.ToDecimal(ddlCategoria.SelectedValue) : new Nullable<decimal>();
            decimal? Marca = cbMarca.Checked == true ? Convert.ToDecimal(ddlMarca.SelectedValue) : new Nullable<decimal>();
            string Descriipcion = string.IsNullOrEmpty(txtDescripcion.Text.Trim()) ? null : txtDescripcion.Text.Trim();
            string CodigoProducto = string.IsNullOrEmpty(txtCodigoProducto.Text.Trim()) ? null : txtCodigoProducto.Text.Trim();
            string Referencia = string.IsNullOrEmpty(txtReferencia.Text.Trim()) ? null : txtReferencia.Text.Trim();
            string CodigoBarra = string.IsNullOrEmpty(txtCodigoBarra.Text.Trim()) ? null : txtCodigoBarra.Text.Trim();


            var BuscarInformacion = ObjDataInventario.Value.BuscaProductosServicios(
                new Nullable<decimal>(),
                null,
                TipoProducto,
                Categoria,
                Marca,
                null, null,
                Descriipcion, CodigoBarra, Referencia, null, CodigoProducto, null, null, null, null, 1, (int)txtNumeroRegistros.Value);
            dtListadoItems.DataSource = BuscarInformacion;
            OcultarColumnasListadoItems();
        }

        private void OcultarColumnasListadoItems() {
            this.dtListadoItems.Columns["IdRegistro"].Visible = false;
            this.dtListadoItems.Columns["NumeroConector"].Visible = false;
            this.dtListadoItems.Columns["IdTipoProducto"].Visible = false;
            //this.dtListadoItems.Columns["TipoProducto"].Visible = false;
            this.dtListadoItems.Columns["IdCategoria"].Visible = false;
            //this.dtListadoItems.Columns["Categoria"].Visible = false;
            this.dtListadoItems.Columns["IdMarca"].Visible = false;
            this.dtListadoItems.Columns["Marca"].Visible = false;
            this.dtListadoItems.Columns["IdTipoSuplidor"].Visible = false;
            this.dtListadoItems.Columns["TipoSuplidor"].Visible = false;
            this.dtListadoItems.Columns["IdSuplidor"].Visible = false;
            this.dtListadoItems.Columns["Suplidor"].Visible = false;
            //this.dtListadoItems.Columns["Descripcion"].Visible = false;
            this.dtListadoItems.Columns["CodigoBarra"].Visible = false;
            this.dtListadoItems.Columns["Referencia"].Visible = false;
            this.dtListadoItems.Columns["NumeroSeguimiento"].Visible = false;
            this.dtListadoItems.Columns["CodigoProducto"].Visible = false;
            this.dtListadoItems.Columns["PrecioCompra"].Visible = false;
            //this.dtListadoItems.Columns["PrecioVenta"].Visible = false;
            this.dtListadoItems.Columns["GananciaAproximada"].Visible = false;
            //this.dtListadoItems.Columns["Stock"].Visible = false;
            this.dtListadoItems.Columns["StockMinimo"].Visible = false;
            //this.dtListadoItems.Columns["Estatus"].Visible = false;
            this.dtListadoItems.Columns["UnidadMedida"].Visible = false;
            this.dtListadoItems.Columns["Modelo"].Visible = false;
            this.dtListadoItems.Columns["Color"].Visible = false;
            this.dtListadoItems.Columns["Condicion"].Visible = false;
            this.dtListadoItems.Columns["Capacidad"].Visible = false;
            this.dtListadoItems.Columns["AplicaParaImpuesto0"].Visible = false;
            this.dtListadoItems.Columns["AplicaParaImpuesto"].Visible = false;
            this.dtListadoItems.Columns["TieneImagen0"].Visible = false;
            this.dtListadoItems.Columns["TieneImagen"].Visible = false;
            this.dtListadoItems.Columns["LlevaGarantia0"].Visible = false;
            this.dtListadoItems.Columns["LlevaGarantia"].Visible = false;
            this.dtListadoItems.Columns["IdTipoGarantia"].Visible = false;
            this.dtListadoItems.Columns["TipoTiempoGarantia"].Visible = false;
            this.dtListadoItems.Columns["TiempoGarantia"].Visible = false;
            this.dtListadoItems.Columns["Comentario"].Visible = false;
            this.dtListadoItems.Columns["UsuarioAdiciona"].Visible = false;
            this.dtListadoItems.Columns["CreadoPor"].Visible = false;
            this.dtListadoItems.Columns["FechaAdiciona0"].Visible = false;
            this.dtListadoItems.Columns["FechaAdiciona"].Visible = false;
            this.dtListadoItems.Columns["UsuarioModifica"].Visible = false;
            this.dtListadoItems.Columns["ModificadoPor"].Visible = false;
            this.dtListadoItems.Columns["FechaModifica0"].Visible = false;
            this.dtListadoItems.Columns["FechaModifica"].Visible = false;
            this.dtListadoItems.Columns["FechaIngreso0"].Visible = false;
            this.dtListadoItems.Columns["FechaIngreso"].Visible = false;
            this.dtListadoItems.Columns["NombreEmpresa"].Visible = false;
            this.dtListadoItems.Columns["RNC"].Visible = false;
            this.dtListadoItems.Columns["Direccion"].Visible = false;
            this.dtListadoItems.Columns["Telefonos"].Visible = false;
            this.dtListadoItems.Columns["Email"].Visible = false;
            this.dtListadoItems.Columns["Email2"].Visible = false;
            this.dtListadoItems.Columns["Facebook"].Visible = false;
            this.dtListadoItems.Columns["Instagran"].Visible = false;
            this.dtListadoItems.Columns["LogoEmpresa"].Visible = false;
            this.dtListadoItems.Columns["GeneradoPor"].Visible = false;
            this.dtListadoItems.Columns["CapitalInvertido"].Visible = false;
            this.dtListadoItems.Columns["GananciaAproximadaTotal"].Visible = false;
        }
        #endregion
        #region GENERAR EL NUMERO DE COENCTOR PARA LA FACTURA
        private string GenerarNumeroConector() {
            string NumeroConector = "";

            Random NumeroAleatorio = new Random();
            string PrimerNumero = NumeroAleatorio.Next(0, 999999999).ToString();
            string SegundoNumero = NumeroAleatorio.Next(0, 999999999).ToString();
            string Year = DateTime.Now.Year.ToString();
            string Month = DateTime.Now.Month.ToString().Length == 1 ?  "0" + DateTime.Now.Month.ToString() : DateTime.Now.Month.ToString();
            string Day = DateTime.Now.Day.ToString().Length == 1 ? "0" + DateTime.Now.Day.ToString() : DateTime.Now.Day.ToString();
            NumeroConector = PrimerNumero + Year + Month + Day + SegundoNumero;
            return NumeroConector;
        }
        #endregion
        #region MOSTRAR EL RECUENTO DE LA FACTURA
        private string MostrarRecuentoFactura(int TotalItems, decimal SubTotal, decimal TotalDescuento, decimal Impuesto, decimal Total) {
            string RecuentoFactura = "";

            string CerrarParentesis = " ) ";
            string TotalItemsTitulo = "Total de Items ( ";
            string SubTotalTitulo = "Sub Total ( ";
            string TotalDescuentoTitulo = "Total de Descuento ( ";
            string ImpuestoTitulo = "Impuesto ( ";
            string TotalTitulo = "Total ( ";

            RecuentoFactura = "Recuento de Facturación: " + TotalItemsTitulo + TotalItems.ToString("N0") + CerrarParentesis + ", " + SubTotalTitulo + SubTotal.ToString("N2") + CerrarParentesis + ", " + TotalDescuentoTitulo + TotalDescuento.ToString("N2") + CerrarParentesis + ", " + ImpuestoTitulo + Impuesto.ToString("N2") + CerrarParentesis + ", " + TotalTitulo + Total.ToString("N2") + CerrarParentesis + ".";
            return RecuentoFactura;
        }
        #endregion
        #region RESTABLECER PANTALLA DE FACTURACION
        private void RestablecerPantallaFacturacion() {
            VariablesGlobales.ProductoSeleccionadoFacturacion = (int)TipoProductoSeleccionado.ProductoNoSeleccionado;
            btnRestablecerPantalla.Visible = false;
            txtDescripcionItemsSeleccionado.Text = string.Empty;
            txtTipoProductoItemsseleccionado.Text = string.Empty;
            txtPrecioItemSeleccionado.Text = string.Empty;
            txtStockitemSeleccionado.Text = string.Empty;
            txtDescuentoItemsSeleccionado.Text = string.Empty;
            txtCantidadItemSelecionado.Text = string.Empty;
            VariablesGlobales.ProductoSeleccionadoFacturarCotizar = "NO";
        }
        #endregion

        #region PROCESAR INFORMACION DEL PREVIEW DE FACTURACION
        private void ProcesarPreviewFacturacion() {
            int PorcitneoImpuesto = 0;
            DSMarket.Logica.Comunes.ProcesarInformacion.Servicio.ProcesarInformacionFacturacionPreview Procesar = new Logica.Comunes.ProcesarInformacion.Servicio.ProcesarInformacionFacturacionPreview(
                VariablesGlobales.IdUsuario,
                VariablesGlobales.NumeroConectorstring,
                VariablesGlobales.IdProductoFacturarCotizar,
                VariablesGlobales.IdTipoProductoFacturarCotizar,
                Convert.ToDecimal(txtPrecioItemSeleccionado.Text),
                Convert.ToInt32(txtCantidadItemSelecionado.Text),
                Convert.ToDecimal(txtDescuentoItemsSeleccionado.Text),
                PorcitneoImpuesto,
                "INSERT");
            Procesar.ProcesarInformacion();

        }
        #endregion
        #region MOSTRAR LOS PRODUCTOS AGREGADOS
        private void MostrarItemsagregados(decimal Idusuario, string NumeroConector) {
            var MostrarItems = ObjDataServicio.Value.BuscaFacturacionPreview(Idusuario, NumeroConector);
            dtItemsAgregados.DataSource = MostrarItems;


            foreach (var n in MostrarItems)
            {
                VariablesGlobales.TotalProductosFacturarCotizar = (int)n.TotalProducto;
                VariablesGlobales.TotalServiciosFacturarCotizar = (int)n.TotalServicio;
                VariablesGlobales.TotalItemsFacturarCotizar = (int)n.TotalItems;
                VariablesGlobales.SubTotalFacturarCotizar = (decimal)n.TotalSubTotal;
                VariablesGlobales.TotalDescuentoFacturarCotizar = (decimal)n.TotalDescuento;
                VariablesGlobales.TotalImpuestoFacturarCotizar = (decimal)n.TotalImpuesto;
                VariablesGlobales.TotalGeneralFacturarCotizar = (decimal)n.TotalGeneral;
            }
            lbCantidadProductosvariable.Text = VariablesGlobales.TotalProductosFacturarCotizar.ToString("N0");
            lbCantidadServiciosVariable.Text = VariablesGlobales.TotalServiciosFacturarCotizar.ToString("N0");
            txtTotal.Text = VariablesGlobales.TotalGeneralFacturarCotizar.ToString("N2");
            gbItemsAgregados.Text = MostrarRecuentoFactura(VariablesGlobales.TotalItemsFacturarCotizar, VariablesGlobales.SubTotalFacturarCotizar, VariablesGlobales.TotalDescuentoFacturarCotizar, VariablesGlobales.TotalImpuestoFacturarCotizar, VariablesGlobales.TotalGeneralFacturarCotizar);

            //OCULTAMOS LAS COLUMNAS QUE NO SON NECESARIOAS PARA MOSTRAR ESTE PROCESO
            this.dtItemsAgregados.Columns["IdUsuario"].Visible = false;
            this.dtItemsAgregados.Columns["NumeroConector"].Visible = false;
            this.dtItemsAgregados.Columns["IdProducto"].Visible = false;
            this.dtItemsAgregados.Columns["IdTipoProducto"].Visible = false;
            this.dtItemsAgregados.Columns["PorcientoImpuesto"].Visible = false;
            this.dtItemsAgregados.Columns["TotalProducto"].Visible = false;
            this.dtItemsAgregados.Columns["TotalServicio"].Visible = false;
            this.dtItemsAgregados.Columns["TotalItems"].Visible = false;
            this.dtItemsAgregados.Columns["TotalSubTotal"].Visible = false;
            this.dtItemsAgregados.Columns["TotalImpuesto"].Visible = false;
            this.dtItemsAgregados.Columns["TotalGeneral"].Visible = false;
            this.dtItemsAgregados.Columns["TotalDescuento"].Visible = false;
        }
        #endregion

        private void SacarDatosProductoSeleccionado(ref DataGridView Grid, decimal IdRegistro,string NumeroConector) {
           

            var BuscarRegistros = ObjDataInventario.Value.BuscaProductosServicios(IdRegistro, NumeroConector, null, null, null, null, null, null, null, null, null, null, null, null, null, null, 1, 1);
            dtListadoItems.DataSource = BuscarRegistros;
            OcultarColumnasListadoItems();
            foreach (var n in BuscarRegistros)
            {
                txtDescripcionItemsSeleccionado.Text = n.Descripcion;
                txtTipoProductoItemsseleccionado.Text = n.TipoProducto;
                decimal Precio = (decimal)n.PrecioVenta;
                txtPrecioItemSeleccionado.Text = Precio.ToString("N2");
                decimal Stock = (decimal)n.Stock;
                txtStockitemSeleccionado.Text = Stock.ToString("N0");
                txtDescuentoItemsSeleccionado.Text = "0";
                txtCantidadItemSelecionado.Text = "1";
                VariablesGlobales.ProductoSeleccionadoFacturacion = (int)TipoProductoSeleccionado.ProductoSeleccionado;
                btnRestablecerPantalla.Visible = true;
                VariablesGlobales.ProductoSeleccionadoFacturarCotizar = "SI";
            }
        }

        private void MostrarComprobante() {
            //Mostrar los comprobantes fiscales
            var Comprobantes = ObjDataListas.Value.BuscaCOmprobantesFiscales();
            ddlComprobante.DataSource = Comprobantes;
            ddlComprobante.DisplayMember = "Comprbante";
            ddlComprobante.ValueMember = "IdComprobante";
        }
        private void FacturacionProductosServicios_Load(object sender, EventArgs e)
        {
            DSMarket.Logica.Comunes.ProcesarInformacion.Servicio.ProcesarInformacionFacturacionPreview Eliminar = new Logica.Comunes.ProcesarInformacion.Servicio.ProcesarInformacionFacturacionPreview(
                VariablesGlobales.IdUsuario, "", 0, 0, 0, 0, 0, 0, "DELETEALL");
            Eliminar.ProcesarInformacion();


            VariablesGlobales.NumeroConectorstring = GenerarNumeroConector();
            MostrarItemsagregados(VariablesGlobales.IdUsuario, VariablesGlobales.NumeroConectorstring);
            rbFacturar.Checked = true;
            rbBuscarPorRNC.Checked = true;
            VariablesGlobales.ProductoSeleccionadoFacturarCotizar = "NO";


            lbTitulo.ForeColor = Color.White;
            lbCantidadProductosTitulo.ForeColor = Color.White;
            lbCantidadProductosvariable.ForeColor = Color.White;
            lbCantidadServiciosTitulo.ForeColor = Color.White;
            lbCantidadServiciosVariable.ForeColor = Color.White;

            cbUsarComprobantes.Visible = true;
            cbUsarComprobantes.Checked = false;
            lbComprobante.Visible = false;
            ddlComprobante.Visible = false;
            lbTitulo.Text = "FACTURACION";
            lbFActuradoA.Text = "Facturado A";

            CargarTipoPdoducto();
            CargarCategorias();
            CargarMarcas();
            MostrarListadoTipoPagos();
            CargarMonedas();

            VariablesGlobales.ProductoSeleccionadoFacturacion = (int)TipoProductoSeleccionado.ProductoNoSeleccionado;

            VariablesGlobales.TotalProductosFacturarCotizar = 0;
            VariablesGlobales.TotalServiciosFacturarCotizar = 0;
            VariablesGlobales.TotalItemsFacturarCotizar = 0;
            VariablesGlobales.SubTotalFacturarCotizar = 0;
            VariablesGlobales.TotalDescuentoFacturarCotizar = 0;
            VariablesGlobales.TotalImpuestoFacturarCotizar = 0;
            VariablesGlobales.TotalGeneralFacturarCotizar = 0;

            gbItemsAgregados.Text = MostrarRecuentoFactura(VariablesGlobales.TotalItemsFacturarCotizar, VariablesGlobales.SubTotalFacturarCotizar, VariablesGlobales.TotalDescuentoFacturarCotizar, VariablesGlobales.TotalImpuestoFacturarCotizar, VariablesGlobales.TotalGeneralFacturarCotizar);
            txtCodigoBarra.Focus();
        }

        private void cbUsarComprobantes_CheckedChanged(object sender, EventArgs e)
        {
            if (cbUsarComprobantes.Checked == true)
            {
                lbComprobante.Visible = true;
                ddlComprobante.Visible = true;
                MostrarComprobante();
            }
            else {
                lbComprobante.Visible = false;
                ddlComprobante.Visible = false;
            }
        }

        private void txtMontoPagar_KeyPress(object sender, KeyPressEventArgs e)
        {
            DSMarket.Logica.Comunes.ValidarControles.SoloNumeros(e);
        }

        private void ddlTipoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarCategorias();
            CargarMarcas();
        }

        private void ddlCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarMarcas();
        }

        private void cbMarca_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMarca.Checked == true) {
                cbTipoProducto.Checked = true;
                cbCategoria.Checked = true;
            
            }
           
        }

        private void cbCategoria_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCategoria.Checked == true) {
                cbTipoProducto.Checked = true;
            }
            else if (cbCategoria.Checked == false) { }
        }

        private void cbTipoProducto_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTipoProducto.Checked == false) {
                cbCategoria.Checked = false;
                cbMarca.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (VariablesGlobales.ProductoSeleccionadoFacturacion == (int)TipoProductoSeleccionado.ProductoNoSeleccionado) {
                MostrarListadoProductos();
            }
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            if (VariablesGlobales.ProductoSeleccionadoFacturacion == (int)TipoProductoSeleccionado.ProductoNoSeleccionado)
            {
                MostrarListadoProductos();
            }
        }

        private void txtCodigoProducto_TextChanged(object sender, EventArgs e)
        {
            if (VariablesGlobales.NumeroConectorstring == "-1")
            {
                MostrarListadoProductos();
            }
        }

        private void txtReferencia_TextChanged(object sender, EventArgs e)
        {
            if (VariablesGlobales.ProductoSeleccionadoFacturacion == (int)TipoProductoSeleccionado.ProductoNoSeleccionado)
            {
                MostrarListadoProductos();
            }
        }

        private void txtCodigoBarra_TextChanged(object sender, EventArgs e)
        {
            if (VariablesGlobales.ProductoSeleccionadoFacturacion == (int)TipoProductoSeleccionado.ProductoNoSeleccionado)
            {
                MostrarListadoProductos();
            }
        }

        private void txtNumeroRegistros_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroRegistros.Value < 1) {
                txtNumeroRegistros.Value = 10;
                if (VariablesGlobales.ProductoSeleccionadoFacturacion == (int)TipoProductoSeleccionado.ProductoNoSeleccionado)
                {
                    MostrarListadoProductos();
                }
            }
            else {
                if (VariablesGlobales.ProductoSeleccionadoFacturacion == (int)TipoProductoSeleccionado.ProductoNoSeleccionado)
                {
                    MostrarListadoProductos();
                }
            }
        }

        private void rbFacturar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFacturar.Checked == true) {
                cbUsarComprobantes.Visible = true;
                cbUsarComprobantes.Checked = false;
                lbComprobante.Visible = false;
                ddlComprobante.Visible = false;
                lbTitulo.Text = "FACTURACION";
                lbFActuradoA.Text = "Facturado A";
            }
            else if (rbFacturar.Checked == false) {
                cbUsarComprobantes.Visible = false;
                cbUsarComprobantes.Checked = false;
                lbComprobante.Visible = false;
                ddlComprobante.Visible = false;
                lbTitulo.Text = "";
            }
        }

        private void rbCotizar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCotizar.Checked == true) {
                cbUsarComprobantes.Visible = false;
                cbUsarComprobantes.Checked = false;
                lbComprobante.Visible = false;
                ddlComprobante.Visible = false;
                lbTitulo.Text = "COTIZACION";
                lbFActuradoA.Text = "Cotizado A";
            }
            else if (rbCotizar.Checked == false) {
                cbUsarComprobantes.Visible = true;
                cbUsarComprobantes.Checked = false;
                lbComprobante.Visible = false;
                ddlComprobante.Visible = false;
                lbTitulo.Text = "";
            }
        }

        private void dtListadoItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                decimal IdRegistro = Convert.ToDecimal(this.dtListadoItems.CurrentRow.Cells["IdRegistro"].Value.ToString());
                string NumeroConector = this.dtListadoItems.CurrentRow.Cells["NumeroConector"].Value.ToString();
                decimal IdTipoProducto = Convert.ToDecimal(this.dtListadoItems.CurrentRow.Cells["IdTipoProducto"].Value.ToString());
                decimal Stock = Convert.ToDecimal(this.dtListadoItems.CurrentRow.Cells["Stock"].Value.ToString());
                VariablesGlobales.IdTipoProductoFacturarCotizar = Convert.ToDecimal(this.dtListadoItems.CurrentRow.Cells["IdTipoProducto"].Value.ToString());
                VariablesGlobales.IdProductoFacturarCotizar = Convert.ToDecimal(this.dtListadoItems.CurrentRow.Cells["IdRegistro"].Value.ToString());

                //VALIDAMOS SI ESTE PRODUCTO YA ESTA AGREGADO PARA FACTURAR
                var ValidarRegistro = ObjDataServicio.Value.BuscaFacturacionPreview(
                    VariablesGlobales.IdUsuario,
                    VariablesGlobales.NumeroConectorstring,
                    IdRegistro,
                    IdTipoProducto);
                if (ValidarRegistro.Count() < 1) {
                    if (IdTipoProducto == 1)
                    {
                        if (Stock <= 0)
                        {
                            MessageBox.Show("Este producto esta actualmente agotado, por lo tanto no puede facturarse.", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            SacarDatosProductoSeleccionado(ref dtListadoItems, IdRegistro, NumeroConector);
                        }
                    }
                    else if (IdTipoProducto == 2)
                    {
                        SacarDatosProductoSeleccionado(ref dtListadoItems, IdRegistro, NumeroConector);
                    }
                }
                else {
                    string TipoOperacions ="";
                    TipoOperacions = rbFacturar.Checked == true ? "facturar" : "cotizar";
                    MessageBox.Show("Este registro ya esta agregado para " + TipoOperacions + ", favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
               

              

            }
            catch (Exception) { }
        }

        private void btnRestablecerPantalla_Click(object sender, EventArgs e)
        {
            RestablecerPantallaFacturacion();
            MostrarListadoProductos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try {
                if (VariablesGlobales.ProductoSeleccionadoFacturarCotizar == "SI")
                {
                    if (string.IsNullOrEmpty(txtCantidadItemSelecionado.Text.Trim())) {
                        txtCantidadItemSelecionado.Text = "1";
                    }

                    string TipoProducto = txtTipoProductoItemsseleccionado.Text;

                    if (TipoProducto == "PRODUCTO") {

                        decimal StockActual = 0, CantidadFacturar = 0;
                        StockActual = Convert.ToDecimal(txtStockitemSeleccionado.Text);
                        CantidadFacturar = Convert.ToDecimal(txtCantidadItemSelecionado.Text);

                        if (CantidadFacturar > StockActual)
                        {
                            MessageBox.Show("Actualmente tienes " + StockActual.ToString("N0") + " del item seleccionado e intentas facturar " + CantidadFacturar.ToString("N0") + " por lo tanto no es posible proceder con este paso, favor de verificar la cantidad.", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else {
                            ProcesarPreviewFacturacion();
                            MostrarItemsagregados(VariablesGlobales.IdUsuario, VariablesGlobales.NumeroConectorstring);
                            RestablecerPantallaFacturacion();
                            MostrarListadoProductos();
                        }
                       
                    }
                    else if (TipoProducto == "SERVICIO") {
                        ProcesarPreviewFacturacion();
                        MostrarItemsagregados(VariablesGlobales.IdUsuario, VariablesGlobales.NumeroConectorstring);
                        RestablecerPantallaFacturacion();
                        MostrarListadoProductos();
                    }
                }
                else
                {
                    MessageBox.Show("Favor de seleccionar un producto para proceder con esta operación, favor de verificar.", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
          
        }

        private void FacturacionProductosServicios_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason) {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
