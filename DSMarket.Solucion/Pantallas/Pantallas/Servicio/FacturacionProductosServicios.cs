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

        enum OpcionesConfiguracionGeneral {
        UsarComprobantesFiscales=1,
        BuscarClientesRegistrados=2,
        ImprimirFacturaDirectoImpresora=3,
        ValidarTipoPago=4,
        ValidarMoneda=5,
        UsoComprobantesFiscalesPorDefecto=6,
        ValidarOpcionesContables=7,
        EliminarProductosAgotadosFacturar=8
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


        #region AFECTAR LA CAJA
        private void AfectarCaja() { }

        private void GuardarHistorialcaja() { }
        #endregion
        private void ConsultarClientesRegistrados() {
            if (string.IsNullOrEmpty(txtFiltroCliente.Text.Trim())) {
                MessageBox.Show("El campo Dato de filtro de cliente no puede estar vacio para buscar esta información, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
              
            }
            else {
                string _DatoFiltro = string.IsNullOrEmpty(txtFiltroCliente.Text.Trim()) ? null : txtFiltroCliente.Text.Trim();

                bool ValidarComprobantesFiscales = false;
                DSMarket.Logica.Comunes.ValidarConfiguracionesGeneralesSistema ValidarComprobante = new Logica.Comunes.ValidarConfiguracionesGeneralesSistema((decimal)OpcionesConfiguracionGeneral.UsarComprobantesFiscales, 2);
                ValidarComprobantesFiscales = ValidarComprobante.ValidarConfiguracionGeneral();
                switch (ValidarComprobantesFiscales) {
                    case true:
                        cbUsarComprobantes.Visible = true;
                        cbUsarComprobantes.Checked = true;
                        lbComprobante.Visible = true;
                        ddlComprobante.Visible = true;
                        MostrarComprobante();
                        break;

                    case false:

                        break;
                }

                if (rbBuscarPorRNC.Checked == true) {
                    var BuscarInformacion = ObjDataEmpresa.Value.BuscaClientes(
                        new Nullable<decimal>(),
                        null,
                        null,
                        _DatoFiltro,
                        null,
                        null,
                        1, 1);
                    if (BuscarInformacion.Count() < 1)
                    {
                        MessageBox.Show("No se encontraron registros con el numero e RNC ingresado, favor de verificar.", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        bool ValidarUsoComprobanteRegistroNoEncontrado = false;
                        bool ValidarUsoComprobanteRegistroNoEncontradoPorDefecto = false;

                        DSMarket.Logica.Comunes.ValidarConfiguracionesGeneralesSistema Validar = new Logica.Comunes.ValidarConfiguracionesGeneralesSistema((decimal)OpcionesConfiguracionGeneral.UsarComprobantesFiscales, 2);
                        ValidarUsoComprobanteRegistroNoEncontrado = Validar.ValidarConfiguracionGeneral();

                        switch (ValidarUsoComprobanteRegistroNoEncontrado) {
                            case true:
                                cbUsarComprobantes.Visible = true;
                                cbUsarComprobantes.Checked = true;
                                lbComprobante.Visible = true;
                                ddlComprobante.Visible = true;
                                DSMarket.Logica.Comunes.ValidarConfiguracionesGeneralesSistema ValidarPorDefecto = new Logica.Comunes.ValidarConfiguracionesGeneralesSistema((decimal)OpcionesConfiguracionGeneral.UsoComprobantesFiscalesPorDefecto, 2);
                                ValidarUsoComprobanteRegistroNoEncontradoPorDefecto = ValidarPorDefecto.ValidarConfiguracionGeneral();
                                switch (ValidarUsoComprobanteRegistroNoEncontradoPorDefecto) {
                                    case true:
                                        cbUsarComprobantes.Checked = true;
                                        break;
                                    case false:
                                        cbUsarComprobantes.Checked = false;
                                        break;
                                }
                                break;

                            case false:
                                cbUsarComprobantes.Visible = false;
                                cbUsarComprobantes.Checked = false;
                                lbComprobante.Visible = false;
                                ddlComprobante.Visible = false;
                                break;
                        }

                       
                    }
                    else {
                       
                        foreach (var n in BuscarInformacion) {
                            txtNombreCliente.Text = n.Nombre.ToUpper();
                            ddlComprobante.Text = n.Comprobante;
                            VariablesGlobales.CodigoClienteFacturacion = (decimal)n.IdCliente;
                        }
                        
                        cbUsarComprobantes.Enabled = false;
                        rbBuscarPorRNC.Enabled = false;
                        rbBuscarPorCodigo.Enabled = false;
                        txtFiltroCliente.Enabled = false;
                        txtNombreCliente.Enabled = false;
                        btnBuscarCliente.Enabled = false;
                        lbComprobante.Enabled = false;
                        ddlComprobante.Enabled = false;
                        btnRestablecer.Visible = true;
                    }
                }
                else if (rbBuscarPorCodigo.Checked == true) {
                    try {
                        var BuscarInformacion = ObjDataEmpresa.Value.BuscaClientes(
                            Convert.ToDecimal(_DatoFiltro),
                            null,
                            null,
                            null,
                            null,
                            null,
                            1, 1);
                        if (BuscarInformacion.Count() < 1)
                        {
                            MessageBox.Show("No se encontraron registros con el codigo de cliente ingresado, favor de verificar.", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            cbUsarComprobantes.Visible = false;
                            cbUsarComprobantes.Checked = false;
                            lbComprobante.Visible = false;
                            ddlComprobante.Visible = false;
                        }
                        else
                        {

                            foreach (var n in BuscarInformacion)
                            {
                                txtNombreCliente.Text = n.Nombre.ToUpper();
                                ddlComprobante.Text = n.Comprobante;
                                VariablesGlobales.CodigoClienteFacturacion = (decimal)n.IdCliente;
                            }

                            cbUsarComprobantes.Enabled = false;
                            rbBuscarPorRNC.Enabled = false;
                            rbBuscarPorCodigo.Enabled = false;
                            txtFiltroCliente.Enabled = false;
                            txtNombreCliente.Enabled = false;
                            btnBuscarCliente.Enabled = false;
                            lbComprobante.Enabled = false;
                            ddlComprobante.Enabled = false;
                            btnRestablecer.Visible = true;
                        }
                    }
                    catch (Exception ex) {
                        MessageBox.Show("El valor ingresado tiene que ser numerico para consultar mediante el codigo del cliente, favor de verificar, codigo de error: " + ex.Message , VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                
                }
            }
            
        }
        private void ValidarConfiguracionGeneral() {
            bool ResultadoValidacionUsoComprobantesFiscales = false, ResultadoValidacionBuscarClientesRegistrados = false, ResultadoValidarTipoPago = false, ResultadoValidarMoneda = false, UsoComprobanteFiscalPorDefecto = false;

            #region USAR COMPROBANTES FISCALES
            DSMarket.Logica.Comunes.ValidarConfiguracionesGeneralesSistema ValidarUsoComprobanteFiscal = new Logica.Comunes.ValidarConfiguracionesGeneralesSistema((decimal)OpcionesConfiguracionGeneral.UsarComprobantesFiscales, 2);
            ResultadoValidacionUsoComprobantesFiscales = ValidarUsoComprobanteFiscal.ValidarConfiguracionGeneral();
            switch (ResultadoValidacionUsoComprobantesFiscales)
            {
                case true:
                    cbUsarComprobantes.Visible = true;
                    cbUsarComprobantes.Checked = false;
                    lbComprobante.Visible = false;
                    ddlComprobante.Visible = false;
                    break;

                case false:
                    cbUsarComprobantes.Visible = false;
                    cbUsarComprobantes.Checked = false;
                    lbComprobante.Visible = false;
                    ddlComprobante.Visible = false;
                    break;
            }
            #endregion

            #region BUSCAR CLIENTES REGISTRADOS EN EL SISTEMA
            DSMarket.Logica.Comunes.ValidarConfiguracionesGeneralesSistema ValidarBuscarClientesRegistrados = new Logica.Comunes.ValidarConfiguracionesGeneralesSistema((decimal)OpcionesConfiguracionGeneral.BuscarClientesRegistrados, 2);
            ResultadoValidacionBuscarClientesRegistrados = ValidarBuscarClientesRegistrados.ValidarConfiguracionGeneral();
            switch (ResultadoValidacionBuscarClientesRegistrados) {
                case true:
                    lbLetreroFiltroCliente.Visible = true;
                    txtFiltroCliente.Visible = true;
                    btnBuscarCliente.Visible = true;
                    rbBuscarPorCodigo.Visible = true;
                    rbBuscarPorRNC.Visible = true;
                    rbBuscarPorRNC.Checked = true;
                    break;

                case false:
                    lbLetreroFiltroCliente.Visible = false;
                    txtFiltroCliente.Visible = false;
                    btnBuscarCliente.Visible = false;
                    rbBuscarPorCodigo.Visible = false;
                    rbBuscarPorRNC.Visible = false;
                    break;
            }
            #endregion

            #region VALIDAR EL TIPO DE PAGO
            DSMarket.Logica.Comunes.ValidarConfiguracionesGeneralesSistema ValidarTipoPago = new Logica.Comunes.ValidarConfiguracionesGeneralesSistema((decimal)OpcionesConfiguracionGeneral.ValidarTipoPago, 2);
            ResultadoValidarTipoPago = ValidarTipoPago.ValidarConfiguracionGeneral();
            switch (ResultadoValidarTipoPago) {
                case true:
                    lbTipoPago.Visible = true;
                    ddltIPago.Visible = true;
                    break;

                case false:
                    lbTipoPago.Visible = false;
                    ddltIPago.Visible = false;
                    break;
            }
            #endregion

            #region VALIDAR LA MONEDA
            DSMarket.Logica.Comunes.ValidarConfiguracionesGeneralesSistema ValidarMoneda = new Logica.Comunes.ValidarConfiguracionesGeneralesSistema((decimal)OpcionesConfiguracionGeneral.ValidarMoneda, 2);
            ResultadoValidarMoneda = ValidarMoneda.ValidarConfiguracionGeneral();
            switch (ResultadoValidarMoneda) {
                case true:
                    lbMoneda.Visible = true;
                    ddlSeleccionarMoneda.Visible = true;
                    lbTasa.Visible = true;
                    txtTasa.Visible = true;
                    break;

                case false:
                    lbMoneda.Visible = false;
                    ddlSeleccionarMoneda.Visible = false;
                    lbTasa.Visible = false;
                    txtTasa.Visible = false;
                    break;
            }
            #endregion

            #region VALIDAR EL USO DE COMPROBANTES FISCALES POR DEFECTO
            DSMarket.Logica.Comunes.ValidarConfiguracionesGeneralesSistema ValidarUsoComprobanteFiscalesPorDefecto = new Logica.Comunes.ValidarConfiguracionesGeneralesSistema((decimal)OpcionesConfiguracionGeneral.UsoComprobantesFiscalesPorDefecto, 2);
            UsoComprobanteFiscalPorDefecto = ValidarUsoComprobanteFiscalesPorDefecto.ValidarConfiguracionGeneral();

            switch (UsoComprobanteFiscalPorDefecto) {
                case true:
                    cbUsarComprobantes.Checked = true;
                    lbComprobante.Visible = true;
                    ddlComprobante.Visible = true;
                    MostrarComprobante();
                    break;

                case false:
                    cbUsarComprobantes.Checked = false;
                    break;
            }
            #endregion
            }
        private void AgregarItems() {
            try
            {
                if (VariablesGlobales.ProductoSeleccionadoFacturarCotizar == "SI")
                {
                    if (string.IsNullOrEmpty(txtCantidadItemSelecionado.Text.Trim()))
                    {
                        txtCantidadItemSelecionado.Text = "1";
                    }

                    string TipoProducto = txtTipoProductoItemsseleccionado.Text;

                    if (TipoProducto == "PRODUCTO")
                    {

                        decimal StockActual = 0, CantidadFacturar = 0;
                        StockActual = Convert.ToDecimal(txtStockitemSeleccionado.Text);
                        CantidadFacturar = Convert.ToDecimal(txtCantidadItemSelecionado.Text);

                        if (CantidadFacturar > StockActual)
                        {
                            MessageBox.Show("Actualmente tienes " + StockActual.ToString("N0") + " del item seleccionado e intentas facturar " + CantidadFacturar.ToString("N0") + " por lo tanto no es posible proceder con este paso, favor de verificar la cantidad.", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            ProcesarPreviewFacturacion();
                            MostrarItemsagregados(VariablesGlobales.IdUsuario, VariablesGlobales.NumeroConectorstring);
                            RestablecerPantallaFacturacion();
                            MostrarListadoProductos();
                        }

                    }
                    else if (TipoProducto == "SERVICIO")
                    {
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

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
            DSMarket.Logica.Comunes.SacarPorcientoImpuesto Porciento = new Logica.Comunes.SacarPorcientoImpuesto(1);
            int PorcitneoImpuesto = Porciento.PorcientoImpuesto();
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
        #region GUARDAR LA INFORMACION DE FACTURACION
        private void GuardarInformacionFacturacion() {
            DSMarket.Logica.Comunes.SacarNombreClientePorDefecto SacarNombreCliente = new Logica.Comunes.SacarNombreClientePorDefecto();

            string _FacturadoA = string.IsNullOrEmpty(txtNombreCliente.Text.Trim()) && VariablesGlobales.CodigoClienteFacturacion == 0 ? SacarNombreCliente.SacarClientePorDefecto() : txtNombreCliente.Text.Trim();
            decimal _CodigoCliente = VariablesGlobales.CodigoClienteFacturacion == 0 ? 1 : VariablesGlobales.CodigoClienteFacturacion;
            decimal _IdTipoFacturacion = rbFacturar.Checked == true ? 1 : 2;
            string _Comentario = string.IsNullOrEmpty(txtComentario.Text.Trim()) ? null : txtComentario.Text.Trim();

            decimal _IdComprobante = 0;
            string _ValidoHasta = "";
            string _NumeroComprobante = "";
            bool ValidarComprobante = false;
            DSMarket.Logica.Comunes.ValidarConfiguracionesGeneralesSistema Validar = new Logica.Comunes.ValidarConfiguracionesGeneralesSistema((decimal)OpcionesConfiguracionGeneral.UsarComprobantesFiscales, 2);
            ValidarComprobante = Validar.ValidarConfiguracionGeneral();
            switch (ValidarComprobante) {
                case true:
                    _IdComprobante = Convert.ToDecimal(ddlComprobante.SelectedValue);
                    DSMarket.Logica.Comunes.ProcesarInformacionComprobanteFiscal ProcesarComprobante = new Logica.Comunes.ProcesarInformacionComprobanteFiscal(_IdComprobante);
                    _ValidoHasta = ProcesarComprobante.SacarFechaValidoComprobante();
                    _NumeroComprobante = ProcesarComprobante.GenerarComprobanteFiscal();
                    break;

                case false:
                    _IdComprobante = 0;
                    _ValidoHasta = "";
                    _NumeroComprobante = "";
                    break;
            }

            DSMarket.Logica.Comunes.ProcesarInformacion.Servicio.ProcesarInformacionFactura GuardarInformacion = new Logica.Comunes.ProcesarInformacion.Servicio.ProcesarInformacionFactura(
                0,
                VariablesGlobales.NumeroConectorstring,
                _FacturadoA,
                _CodigoCliente,
                _IdTipoFacturacion,
                _Comentario,
                VariablesGlobales.TotalProductosFacturarCotizar,
                VariablesGlobales.TotalServiciosFacturarCotizar,
                VariablesGlobales.TotalItemsFacturarCotizar,
                VariablesGlobales.SubTotalFacturarCotizar,
                VariablesGlobales.TotalDescuentoFacturarCotizar,
                VariablesGlobales.TotalImpuestoFacturarCotizar,
                VariablesGlobales.TotalGeneralFacturarCotizar,
                Convert.ToDecimal(ddltIPago.SelectedValue),
                Convert.ToDecimal(txtMontoPagar.Text),
                0,//Convert.ToDecimal(txtCambio.Text),
                Convert.ToDecimal(ddlSeleccionarMoneda.SelectedValue),
                0,///Convert.ToDecimal(txtTasa.Text),
                VariablesGlobales.IdUsuario,
                _IdComprobante,
                _ValidoHasta,
                _NumeroComprobante,
                "INSERT");
            GuardarInformacion.ProcesarInformacion();
        }
        #endregion
        #region GUARDAR LA INFORMACION DEL DETALLE DE FACTURACION
        private void GuardarInformacionDetalleFacturacion() {
            string NumeroConector = "";
            decimal IdTipoProducto = 0;
            string Tipo = "";
            decimal Precio = 0;//
            decimal Descuento = 0; //
            int Cantidad = 0;//
            int PorcientoImpuesto = 0;
            decimal SubTotal = 0;
            decimal Impuesto = 0;
            decimal Total = 0;
            decimal IdRegistroRespaldo = 0; //
            string NumeroConectorItemRespaldo = "";
            decimal IdTipoProductoRespaldo = 0;
            decimal IdCategoriaRespaldo = 0;
            decimal IdMarcaRespaldo = 0;
            decimal IdTipoSuplidorRespaldo = 0;
            decimal IdSuplidorRespaldo = 0;
            string DescripcionRespaldo = "";
            string CodigoBarraRespaldo = "";
            string ReferenciaRespaldo = "";
            string NumeroSeguimientoRespaldo = "";
            string CodigoProductoRespaldo = "";
            decimal PrecioCompraRespaldo = 0;
            decimal PrecioVentaRespaldo = 0;
            decimal StockRespaldo = 0;
            decimal StockMinimoRespaldo = 0;
            string UnidadMedidaRespaldo = "";
            string ModeloRespaldo = "";
            string ColorRespaldo = "";
            string CondicionRespaldo = "";
            string CapacidadRespaldo = "";
            bool AplicaParaImpuestoRespaldo = false;
            bool TieneImagenRespaldo = false;
            bool LlevaGarantiaRespaldo = false;
            decimal IdTipoGarantiaRespaldo = 0;
            int TiempoGarantiaRespaldo = 0;
            string ComentarioItemRespaldo = "";
            decimal UsuarioAdicionaRespaldo = 0;
            DateTime FechaAdicionaRespaldo = DateTime.Now;
            decimal UsuarioModificaRespaldo = 0;
            DateTime FechaModificaRespaldo = DateTime.Now;
            DateTime FechaIngresoRespaldo = DateTime.Now;

            bool ValidarEliminarProductosAgotadosFacturar = false;
            string EliminarProductoAgotado = "";
            DSMarket.Logica.Comunes.ValidarConfiguracionesGeneralesSistema Validar = new Logica.Comunes.ValidarConfiguracionesGeneralesSistema((decimal)OpcionesConfiguracionGeneral.EliminarProductosAgotadosFacturar, 2);
            ValidarEliminarProductosAgotadosFacturar = Validar.ValidarConfiguracionGeneral();
            switch (ValidarEliminarProductosAgotadosFacturar) {
                case true:
                    EliminarProductoAgotado = "SI";
                    break;

                case false:
                    EliminarProductoAgotado = "NO";
                    break;
            }

            //RECORREMOS TODOS LOS ITEMS AGREGADOS
            var RecorrerItemsAgregados = ObjDataServicio.Value.BuscaFacturacionPreview(
                VariablesGlobales.IdUsuario,
                VariablesGlobales.NumeroConectorstring,
                null, null);
            foreach (var n in RecorrerItemsAgregados) {
                NumeroConector = n.NumeroConector;
                IdTipoProducto = (decimal)n.IdTipoProducto;
                Tipo = IdTipoProducto == 1 ? "PRODUCTO" : "SERVICIO";
                Precio = (decimal)n.Precio;
                Descuento = (decimal)n.Descuento;
                Cantidad = (int)n.Cantidad;
                PorcientoImpuesto = (int)n.PorcientoImpuesto;
                SubTotal = (decimal)n.SubTotal;
                Impuesto = (decimal)n.Impuesto;
                Total = (decimal)n.Total;
                IdRegistroRespaldo = (decimal)n.IdProducto;

                //SACAMOS LOS DATOS DEL PRODUCTO REGISTRADO

                var SacarInformacionItem = ObjDataInventario.Value.BuscaProductosServicios(
                    IdRegistroRespaldo, 
                    null, 
                    IdTipoProducto, 
                    null, 
                    null, 
                    null, 
                    null, 
                    null, 
                    null, 
                    null, 
                    null, 
                    null, 
                    null,
                    null,
                    null,
                    null, 
                    1,
                    1);
                foreach (var InformacionItem in SacarInformacionItem) {
                    NumeroConectorItemRespaldo = InformacionItem.NumeroConector;
                    IdTipoProductoRespaldo = (decimal)InformacionItem.IdTipoProducto;
                    IdCategoriaRespaldo = (decimal)InformacionItem.IdCategoria;
                    IdMarcaRespaldo = (decimal)InformacionItem.IdMarca;
                    IdTipoSuplidorRespaldo = (decimal)InformacionItem.IdTipoSuplidor;
                    IdSuplidorRespaldo = (decimal)InformacionItem.IdSuplidor;
                    DescripcionRespaldo = InformacionItem.Descripcion;
                    CodigoBarraRespaldo = InformacionItem.CodigoBarra;
                    ReferenciaRespaldo = InformacionItem.Referencia;
                    NumeroSeguimientoRespaldo = InformacionItem.NumeroSeguimiento;
                    CodigoProductoRespaldo = InformacionItem.CodigoProducto;
                    PrecioCompraRespaldo = (decimal)InformacionItem.PrecioCompra;
                    PrecioVentaRespaldo = (decimal)InformacionItem.PrecioVenta;
                    StockRespaldo = (decimal)InformacionItem.Stock;
                    StockMinimoRespaldo = (decimal)InformacionItem.StockMinimo;
                    UnidadMedidaRespaldo = InformacionItem.UnidadMedida;
                    ModeloRespaldo = InformacionItem.Modelo;
                    ColorRespaldo = InformacionItem.Color;
                    CondicionRespaldo = InformacionItem.Condicion;
                    CapacidadRespaldo = InformacionItem.Capacidad;
                    AplicaParaImpuestoRespaldo = (bool)InformacionItem.AplicaParaImpuesto0;
                    TieneImagenRespaldo = (bool)InformacionItem.TieneImagen0;
                    LlevaGarantiaRespaldo = (bool)InformacionItem.LlevaGarantia0;
                    IdTipoGarantiaRespaldo = (decimal)InformacionItem.IdTipoGarantia;
                    TiempoGarantiaRespaldo = (int)InformacionItem.TiempoGarantia;
                    ComentarioItemRespaldo = InformacionItem.Comentario;
                    UsuarioAdicionaRespaldo = (decimal)InformacionItem.UsuarioAdiciona;
                    FechaAdicionaRespaldo = (DateTime)InformacionItem.FechaAdiciona0;
                    UsuarioModificaRespaldo = (decimal)InformacionItem.UsuarioModifica;
                    FechaModificaRespaldo = (DateTime)InformacionItem.FechaModifica0;
                    FechaIngresoRespaldo = (DateTime)InformacionItem.FechaIngreso0;
                }

                //GUARDAMOS LA INFORMACION EN LA BASE DE DATOS
                DSMarket.Logica.Comunes.ProcesarInformacion.Servicio.ProcesarInformacionFacturacionDetalle Procesar = new Logica.Comunes.ProcesarInformacion.Servicio.ProcesarInformacionFacturacionDetalle(
                    NumeroConector,
                    Tipo,
                    Precio,
                    Descuento,
                    Cantidad,
                    PorcientoImpuesto,
                    SubTotal,
                    Impuesto,
                    Total,
                    IdRegistroRespaldo,
                    NumeroConectorItemRespaldo,
                    IdTipoProductoRespaldo,
                    IdCategoriaRespaldo,
                    IdMarcaRespaldo,
                    IdTipoSuplidorRespaldo,
                    IdSuplidorRespaldo,
                    DescripcionRespaldo,
                    CodigoBarraRespaldo,
                    ReferenciaRespaldo,
                    NumeroSeguimientoRespaldo,
                    CodigoProductoRespaldo,
                    PrecioCompraRespaldo,
                    PrecioVentaRespaldo,
                    StockRespaldo,
                    StockMinimoRespaldo,
                    UnidadMedidaRespaldo,
                    ModeloRespaldo,
                    ColorRespaldo,
                    CondicionRespaldo,
                    CapacidadRespaldo,
                    AplicaParaImpuestoRespaldo,
                    TieneImagenRespaldo,
                    LlevaGarantiaRespaldo,
                    IdTipoGarantiaRespaldo,
                    TiempoGarantiaRespaldo,
                    ComentarioItemRespaldo,
                    UsuarioAdicionaRespaldo,
                    FechaAdicionaRespaldo,
                    UsuarioModificaRespaldo,
                    FechaModificaRespaldo,
                    FechaIngresoRespaldo,
                    "INSERT");
                Procesar.ProcesarInformacion();

                //AFECTAMOS EL INVENTARIO
                DSMarket.Logica.Comunes.ProcesarInformacion.Inventario.ProcesarInformacionProductoServicio AfectarInventario = new Logica.Comunes.ProcesarInformacion.Inventario.ProcesarInformacionProductoServicio(
                    IdRegistroRespaldo,
                    NumeroConectorItemRespaldo,
                    0, 0, 0, 0, 0, "", "", "", "", "", 0, 0,
                    Cantidad,
                    0, "", "", "", "", "", false, false, false, 0, 0, "", 0, "LESSPRODUCT");
                AfectarInventario.ProcesarInformacion();

                //VALIDAMOS SI ESTA ACTIVA LA OPCION DE ELIMINAR EL REGISTRO AL MOMENTO DE AGOTARSE
                if (EliminarProductoAgotado == "SI") {
                    decimal cantidad = 0;

                    var SacarCantidadproducto = ObjDataInventario.Value.BuscaProductosServicios(IdRegistroRespaldo, NumeroConectorItemRespaldo, null, null, null, null, null, null, null, null, null, null, null, null, null, null, 1, 1);
                    foreach (var nCantidad in SacarCantidadproducto) {
                        cantidad = (decimal)nCantidad.Stock;
                    }

                    if (cantidad < 1 && IdTipoProductoRespaldo == 1) {
                        DSMarket.Logica.Comunes.ProcesarInformacion.Inventario.ProcesarInformacionProductoServicio EliminarProducto = new Logica.Comunes.ProcesarInformacion.Inventario.ProcesarInformacionProductoServicio(
                           IdRegistroRespaldo,
                           NumeroConectorItemRespaldo,
                           0, 0, 0, 0, 0, "", "", "", "", "", 0, 0,
                           0,
                           0, "", "", "", "", "", false, false, false, 0, 0, "", 0, "DELETE");
                        EliminarProducto.ProcesarInformacion();
                    }
                   
                }
                
            }


        }
        #endregion
        #region GUARDAR LA INFORMACION DE LA COTIZACION
        /// <summary>
        /// Guardamos los datos de la cotización
        /// </summary>
        private void GuardarCotizacion() {
            DSMarket.Logica.Comunes.SacarNombreClientePorDefecto SacarNombreCliente = new Logica.Comunes.SacarNombreClientePorDefecto();

            string _CotizadoA = string.IsNullOrEmpty(txtNombreCliente.Text.Trim()) && VariablesGlobales.CodigoClienteFacturacion == 0 ? SacarNombreCliente.SacarClientePorDefecto() : txtNombreCliente.Text.Trim();
            decimal _CodigoCliente = VariablesGlobales.CodigoClienteFacturacion == 0 ? 1 : VariablesGlobales.CodigoClienteFacturacion;
            decimal _IdTipoFacturacion = rbFacturar.Checked == true ? 1 : 2;
            string _Comentario = string.IsNullOrEmpty(txtComentario.Text.Trim()) ? null : txtComentario.Text.Trim();

            DSMarket.Logica.Comunes.ProcesarInformacion.Servicio.ProcesarInformacionCotizacion GuardarCotizacion = new Logica.Comunes.ProcesarInformacion.Servicio.ProcesarInformacionCotizacion(
                0,
                VariablesGlobales.NumeroConectorstring,
                _CotizadoA,
                _CodigoCliente,
                _IdTipoFacturacion,
                _Comentario,
                VariablesGlobales.TotalProductosFacturarCotizar,
                VariablesGlobales.TotalServiciosFacturarCotizar,
                VariablesGlobales.TotalItemsFacturarCotizar,
                VariablesGlobales.SubTotalFacturarCotizar,
                VariablesGlobales.TotalDescuentoFacturarCotizar,
                VariablesGlobales.TotalImpuestoFacturarCotizar,
                VariablesGlobales.TotalGeneralFacturarCotizar,
                Convert.ToDecimal(ddltIPago.SelectedValue),
                0,
                0,
                Convert.ToDecimal(ddlSeleccionarMoneda.SelectedValue),
                Convert.ToDecimal(txtTasa.Text),
                VariablesGlobales.IdUsuario,
                DateTime.Now,
                "INSERT");
            GuardarCotizacion.ProcesarInformacion();
        }

        /// <summary>
        /// Guardamos los datos del detalle de la cotización
        /// </summary>
        private void GuardarCotizacionDetalle() {
            string NumeroConector = "";
            decimal IdTipoProducto = 0;
            string Tipo = "";
            decimal Precio = 0;//
            decimal Descuento = 0; //
            int Cantidad = 0;//
            int PorcientoImpuesto = 0;
            decimal SubTotal = 0;
            decimal Impuesto = 0;
            decimal Total = 0;
            decimal IdRegistroRespaldo = 0; //
            string NumeroConectorItemRespaldo = "";
            decimal IdTipoProductoRespaldo = 0;
            decimal IdCategoriaRespaldo = 0;
            decimal IdMarcaRespaldo = 0;
            decimal IdTipoSuplidorRespaldo = 0;
            decimal IdSuplidorRespaldo = 0;
            string DescripcionRespaldo = "";
            string CodigoBarraRespaldo = "";
            string ReferenciaRespaldo = "";
            string NumeroSeguimientoRespaldo = "";
            string CodigoProductoRespaldo = "";
            decimal PrecioCompraRespaldo = 0;
            decimal PrecioVentaRespaldo = 0;
            decimal StockRespaldo = 0;
            decimal StockMinimoRespaldo = 0;
            string UnidadMedidaRespaldo = "";
            string ModeloRespaldo = "";
            string ColorRespaldo = "";
            string CondicionRespaldo = "";
            string CapacidadRespaldo = "";
            bool AplicaParaImpuestoRespaldo = false;
            bool TieneImagenRespaldo = false;
            bool LlevaGarantiaRespaldo = false;
            decimal IdTipoGarantiaRespaldo = 0;
            int TiempoGarantiaRespaldo = 0;
            string ComentarioItemRespaldo = "";
            decimal UsuarioAdicionaRespaldo = 0;
            DateTime FechaAdicionaRespaldo = DateTime.Now;
            decimal UsuarioModificaRespaldo = 0;
            DateTime FechaModificaRespaldo = DateTime.Now;
            DateTime FechaIngresoRespaldo = DateTime.Now;

            //RECORREMOS TODOS LOS ITEMS AGREGADOS
            var RecorrerItemsAgregados = ObjDataServicio.Value.BuscaFacturacionPreview(
                VariablesGlobales.IdUsuario,
                VariablesGlobales.NumeroConectorstring,
                null, null);
            foreach (var n in RecorrerItemsAgregados)
            {
                NumeroConector = n.NumeroConector;
                IdTipoProducto = (decimal)n.IdTipoProducto;
                Tipo = IdTipoProducto == 1 ? "PRODUCTO" : "SERVICIO";
                Precio = (decimal)n.Precio;
                Descuento = (decimal)n.Descuento;
                Cantidad = (int)n.Cantidad;
                PorcientoImpuesto = (int)n.PorcientoImpuesto;
                SubTotal = (decimal)n.SubTotal;
                Impuesto = (decimal)n.Impuesto;
                Total = (decimal)n.Total;
                IdRegistroRespaldo = (decimal)n.IdProducto;

                //SACAMOS LOS DATOS DEL PRODUCTO REGISTRADO

                var SacarInformacionItem = ObjDataInventario.Value.BuscaProductosServicios(
                    IdRegistroRespaldo,
                    null,
                    IdTipoProducto,
                    null,
                    null,
                    null,
                    null,
                    null,
                    null,
                    null,
                    null,
                    null,
                    null,
                    null,
                    null,
                    null,
                    1,
                    1);
                foreach (var InformacionItem in SacarInformacionItem)
                {
                    NumeroConectorItemRespaldo = InformacionItem.NumeroConector;
                    IdTipoProductoRespaldo = (decimal)InformacionItem.IdTipoProducto;
                    IdCategoriaRespaldo = (decimal)InformacionItem.IdCategoria;
                    IdMarcaRespaldo = (decimal)InformacionItem.IdMarca;
                    IdTipoSuplidorRespaldo = (decimal)InformacionItem.IdTipoSuplidor;
                    IdSuplidorRespaldo = (decimal)InformacionItem.IdSuplidor;
                    DescripcionRespaldo = InformacionItem.Descripcion;
                    CodigoBarraRespaldo = InformacionItem.CodigoBarra;
                    ReferenciaRespaldo = InformacionItem.Referencia;
                    NumeroSeguimientoRespaldo = InformacionItem.NumeroSeguimiento;
                    CodigoProductoRespaldo = InformacionItem.CodigoProducto;
                    PrecioCompraRespaldo = (decimal)InformacionItem.PrecioCompra;
                    PrecioVentaRespaldo = (decimal)InformacionItem.PrecioVenta;
                    StockRespaldo = (decimal)InformacionItem.Stock;
                    StockMinimoRespaldo = (decimal)InformacionItem.StockMinimo;
                    UnidadMedidaRespaldo = InformacionItem.UnidadMedida;
                    ModeloRespaldo = InformacionItem.Modelo;
                    ColorRespaldo = InformacionItem.Color;
                    CondicionRespaldo = InformacionItem.Condicion;
                    CapacidadRespaldo = InformacionItem.Capacidad;
                    AplicaParaImpuestoRespaldo = (bool)InformacionItem.AplicaParaImpuesto0;
                    TieneImagenRespaldo = (bool)InformacionItem.TieneImagen0;
                    LlevaGarantiaRespaldo = (bool)InformacionItem.LlevaGarantia0;
                    IdTipoGarantiaRespaldo = (decimal)InformacionItem.IdTipoGarantia;
                    TiempoGarantiaRespaldo = (int)InformacionItem.TiempoGarantia;
                    ComentarioItemRespaldo = InformacionItem.Comentario;
                    UsuarioAdicionaRespaldo = (decimal)InformacionItem.UsuarioAdiciona;
                    FechaAdicionaRespaldo = (DateTime)InformacionItem.FechaAdiciona0;
                    UsuarioModificaRespaldo = (decimal)InformacionItem.UsuarioModifica;
                    FechaModificaRespaldo = (DateTime)InformacionItem.FechaModifica0;
                    FechaIngresoRespaldo = (DateTime)InformacionItem.FechaIngreso0;
                }

                //GUARDAMOS EL DETALLE DE LA COTIZACION EN LA BASE DE DATOS
                DSMarket.Logica.Comunes.ProcesarInformacion.Servicio.ProcesarInformacionCotizacionDetalle GaurdarInformacion = new Logica.Comunes.ProcesarInformacion.Servicio.ProcesarInformacionCotizacionDetalle(
                    NumeroConector,
                    Tipo,
                    Precio,
                    Descuento,
                    Cantidad,
                    PorcientoImpuesto,
                    SubTotal,
                    Impuesto,
                    Total,
                    IdRegistroRespaldo,
                    NumeroConectorItemRespaldo,
                    IdTipoProductoRespaldo,
                    IdCategoriaRespaldo,
                    IdMarcaRespaldo,
                    IdTipoSuplidorRespaldo,
                    IdSuplidorRespaldo,
                    DescripcionRespaldo,
                    CodigoBarraRespaldo,
                    ReferenciaRespaldo,
                    NumeroSeguimientoRespaldo,
                    CodigoProductoRespaldo,
                    PrecioCompraRespaldo,
                    PrecioVentaRespaldo,
                    StockRespaldo,
                    StockMinimoRespaldo,
                    UnidadMedidaRespaldo,
                    ModeloRespaldo,
                    ColorRespaldo,
                    CondicionRespaldo,
                    CapacidadRespaldo,
                    AplicaParaImpuestoRespaldo,
                    TieneImagenRespaldo,
                    LlevaGarantiaRespaldo,
                    IdTipoGarantiaRespaldo,
                    TiempoGarantiaRespaldo,
                    ComentarioItemRespaldo,
                    UsuarioAdicionaRespaldo,
                    FechaAdicionaRespaldo,
                    UsuarioModificaRespaldo,
                    FechaModificaRespaldo,
                    FechaIngresoRespaldo,
                    "INSERT");
                GaurdarInformacion.ProcesarInformacion();
            }

             
            }
        #endregion
        #region CALCULAR EL CAMBIO 
        private decimal CalcularCambio(decimal TotalPagar, decimal MontoPagado) {
            try {
                decimal Cambio = MontoPagado - TotalPagar;
                return Cambio;
            }
            catch (Exception) {
                decimal Cambio = 0;
                return Cambio;
            }

        }
        #endregion
        #region SACAR TASA DE LA MONEDA
        private decimal SacarTasaMoneda(decimal IdMoneda)
        {

            decimal Tasa = 0;
            var BuscarMoneda = ObjDataServicio.Value.BuscaMOneda(IdMoneda, null, 1, 1);
            foreach (var n in BuscarMoneda) {
                Tasa = (decimal)n.Tasa;
            }
            return Tasa;
        }
        #endregion
        #region MOSTRAR LOS PRODUCTOS AGREGADOS
        private void MostrarItemsagregados(decimal Idusuario, string NumeroConector) {
            var MostrarItems = ObjDataServicio.Value.BuscaFacturacionPreview(Idusuario, NumeroConector);
            if (MostrarItems.Count() < 1)
            {
                dtItemsAgregados.DataSource = null;
                gbItemsAgregados.Text = MostrarRecuentoFactura(0, 0, 0, 0, 0);
            }

            else {
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
                txtMontoPagar.Text = txtTotal.Text;
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
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            VariablesGlobales.CodigoClienteFacturacion = 0;
            DSMarket.Logica.Comunes.ProcesarInformacion.Servicio.ProcesarInformacionFacturacionPreview Eliminar = new Logica.Comunes.ProcesarInformacion.Servicio.ProcesarInformacionFacturacionPreview(
                VariablesGlobales.IdUsuario, "", 0, 0, 0, 0, 0, 0, "DELETEALL");
            Eliminar.ProcesarInformacion();

            ValidarConfiguracionGeneral();

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

            //cbUsarComprobantes.Visible = true;
            //cbUsarComprobantes.Checked = false;
            //lbComprobante.Visible = false;
            //ddlComprobante.Visible = false;
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
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) {
                AgregarItems();
            }
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
                //cbUsarComprobantes.Visible = true;
                //cbUsarComprobantes.Checked = false;
                lbComprobante.Visible = false;
                ddlComprobante.Visible = false;
                lbTitulo.Text = "FACTURACION";
                lbFActuradoA.Text = "Facturado A";
            }
            else if (rbFacturar.Checked == false) {
                //cbUsarComprobantes.Visible = false;
                //cbUsarComprobantes.Checked = false;
                lbComprobante.Visible = false;
                ddlComprobante.Visible = false;
                lbTitulo.Text = "";
            }
        }

        private void rbCotizar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCotizar.Checked == true) {
                //cbUsarComprobantes.Visible = false;
                //cbUsarComprobantes.Checked = false;
                lbComprobante.Visible = false;
                ddlComprobante.Visible = false;
                lbTitulo.Text = "COTIZACION";
                lbFActuradoA.Text = "Cotizado A";
            }
            else if (rbCotizar.Checked == false) {
                //cbUsarComprobantes.Visible = true;
                //cbUsarComprobantes.Checked = false;
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
                            MessageBox.Show("Este producto esta actualmente agotado, por lo tanto no puede facturar.", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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


                txtCantidadItemSelecionado.Focus();

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
            AgregarItems();
          
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

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            ConsultarClientesRegistrados();
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            bool ValidarComprobantesFiscales = false;
            DSMarket.Logica.Comunes.ValidarConfiguracionesGeneralesSistema ValidarComprobante = new Logica.Comunes.ValidarConfiguracionesGeneralesSistema((decimal)OpcionesConfiguracionGeneral.UsarComprobantesFiscales, 2);
            ValidarComprobantesFiscales = ValidarComprobante.ValidarConfiguracionGeneral();
            VariablesGlobales.CodigoClienteFacturacion = 0;
            switch (ValidarComprobantesFiscales)
            {
                case true:
                    bool ValidarComprobantePorDefecto = false;
                    DSMarket.Logica.Comunes.ValidarConfiguracionesGeneralesSistema Validar = new Logica.Comunes.ValidarConfiguracionesGeneralesSistema((decimal)OpcionesConfiguracionGeneral.UsoComprobantesFiscalesPorDefecto, 2);
                    ValidarComprobantePorDefecto = Validar.ValidarConfiguracionGeneral();
                    switch (ValidarComprobantePorDefecto) {
                        case true:
                            cbUsarComprobantes.Checked = true;
                            lbComprobante.Visible = true;
                            ddlComprobante.Visible = true;
                            MostrarComprobante();
                            break;

                        case false:
                            cbUsarComprobantes.Checked = false;
                            lbComprobante.Visible = false;
                            ddlComprobante.Visible = false;
                            //MostrarComprobante();
                            break;
                    }
                    break;

                case false:
                    cbUsarComprobantes.Visible = false;
                    cbUsarComprobantes.Checked = false;
                    lbComprobante.Visible = false;
                    ddlComprobante.Visible = false;
                    //MostrarComprobante();
                    break;
            }

            cbUsarComprobantes.Enabled = true;
            rbBuscarPorRNC.Enabled = true;
            rbBuscarPorCodigo.Enabled = true;
            txtFiltroCliente.Enabled = true;
            txtNombreCliente.Enabled = true;
            btnBuscarCliente.Enabled = true;
            lbComprobante.Enabled = true;
            ddlComprobante.Enabled = true;
            btnRestablecer.Visible = false;
            txtFiltroCliente.Text = string.Empty;
            txtNombreCliente.Text = string.Empty;
        }

        private void txtFiltroCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rbBuscarPorCodigo.Checked == true) {
                DSMarket.Logica.Comunes.ValidarControles.SoloNumeros(e);
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter)) {
                ConsultarClientesRegistrados();
            }
        }

        private void dtItemsAgregados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("¿Quieres quitar este item de la factura?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                decimal IdusuarioQuitar = 0, IdProductoQuitar = 0, IdTipoProductoQUitar = 0;
                string NumeroConectorQUitar = "";

                IdusuarioQuitar = Convert.ToDecimal(this.dtItemsAgregados.CurrentRow.Cells["IdUsuario"].Value.ToString());
                NumeroConectorQUitar = dtItemsAgregados.CurrentRow.Cells["NumeroConector"].Value.ToString();
                IdProductoQuitar = Convert.ToDecimal(this.dtItemsAgregados.CurrentRow.Cells["IdProducto"].Value.ToString());
                IdTipoProductoQUitar = Convert.ToDecimal(this.dtItemsAgregados.CurrentRow.Cells["IdTipoProducto"].Value.ToString());

                DSMarket.Logica.Comunes.ProcesarInformacion.Servicio.ProcesarInformacionFacturacionPreview Eliminar = new Logica.Comunes.ProcesarInformacion.Servicio.ProcesarInformacionFacturacionPreview(
                    IdusuarioQuitar,
                    NumeroConectorQUitar,
                    IdProductoQuitar,
                    IdTipoProductoQUitar,
                    0, 0, 0, 0, "DELETE");
                Eliminar.ProcesarInformacion();
                MostrarItemsagregados(VariablesGlobales.IdUsuario, VariablesGlobales.NumeroConectorstring);
                RestablecerPantallaFacturacion();
                MostrarListadoProductos();

            }
        }

        private void btnARS_Click(object sender, EventArgs e)
        {
            var ValidarItemsAgregado = ObjDataServicio.Value.BuscaFacturacionPreview(
                VariablesGlobales.IdUsuario,
                VariablesGlobales.NumeroConectorstring,
                null, null);
            int RegistrosAgregados = ValidarItemsAgregado.Count;
            if (RegistrosAgregados < 1)
            {
                MessageBox.Show("No es posible completar esta operación por que no se ha agregado ningun items para facturar, favor de verificar.", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {

                if (string.IsNullOrEmpty(txtMontoPagar.Text.Trim()) && rbFacturar.Checked==true)
                {
                    MessageBox.Show("El campo monto a pagar no puede estar vacio para facturar, favor de verificar.", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else {
                    if (rbFacturar.Checked == true) {
                        decimal MontoTotalPagar = Convert.ToDecimal(txtTotal.Text);
                        decimal MontoPagado = (Convert.ToDecimal(txtMontoPagar.Text));

                        if (MontoTotalPagar > MontoPagado) {
                            MessageBox.Show("El total a pagar supera el monto ingresado, favor de verificar.", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else {
                            GuardarInformacionFacturacion();
                            GuardarInformacionDetalleFacturacion();
                            MessageBox.Show("Operación completada con exito.", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Dispose();

                        }
                    }
                    else if (rbCotizar.Checked == true) {
                        GuardarCotizacion();
                        GuardarCotizacionDetalle();
                        MessageBox.Show("Operación completada con exito.", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();
                    }
                }
            }
        }

        private void txtMontoPagar_TextChanged(object sender, EventArgs e)
        {
            try {
                txtCambio.Text = CalcularCambio(Convert.ToDecimal(txtTotal.Text), Convert.ToDecimal(txtMontoPagar.Text)).ToString("N2");
            }
            catch (Exception) {
                txtCambio.Text = "0";
            }
        }

        private void ddlSeleccionarMoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                txtTasa.Text = SacarTasaMoneda(Convert.ToDecimal(ddlSeleccionarMoneda.SelectedValue)).ToString();
            }
            catch (Exception) {
                txtTasa.Text = "1";
            }
        }
    }
}