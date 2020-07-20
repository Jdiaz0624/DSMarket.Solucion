using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace DSMarket.Solucion.Pantallas.Pantallas.Servicio
{
    public partial class Facturacion : Form
    {
        public Facturacion()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion> ObjDataConfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion>();
        Lazy<DSMarket.Logica.Logica.LogicaListas.LogicaListas> ObjDataListas = new Lazy<Logica.Logica.LogicaListas.LogicaListas>();
        Lazy<DSMarket.Logica.Logica.LogicaEmpresa.LogicaEmpresa> ObjDataEmpresa = new Lazy<Logica.Logica.LogicaEmpresa.LogicaEmpresa>();
        Lazy<DSMarket.Logica.Logica.LogicaServicio.LogicaServicio> ObjDataServicio = new Lazy<Logica.Logica.LogicaServicio.LogicaServicio>();
        Lazy<DSMarket.Logica.Logica.LogicaInventario.LogicaInventario> ObjDataInventario = new Lazy<Logica.Logica.LogicaInventario.LogicaInventario>();
        Lazy<DSMarket.Logica.Logica.LogicaCaja.LogicaCaja> ObjDataCaja = new Lazy<Logica.Logica.LogicaCaja.LogicaCaja>();
        Lazy<DSMarket.Logica.Logica.LogicaSeguridad.LogicaSeguridad> ObjDataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad.LogicaSeguridad>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region BLOQUEAR Y DESBLOQUEAR CONTROLES DEL LADO DEL CLIENTE
        private void BloarControlesClientes() {
            txtCodigoCliente.Enabled = false;
            btnAgregarAlmacen.Enabled = false;
            btnRegresar.Enabled = false;
            ddlTipoFacturacion.Enabled = false;
            txtTelefono.Enabled = false;
            txtEmail.Enabled = false;
            ddlTipoIdentificacion.Enabled = false;
            txtIdentificacion.Enabled = false;
            txtDireccion.Enabled = false;
            txtComentario.Enabled = false;
            txtNombrePaciente.Enabled = false;

            //CARGAR LOS TIPOS DE FACTURACION
            //CARGAR LOS TIPOS DE IDENTIFICACION

            txtCodigoCliente.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtIdentificacion.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtComentario.Text = string.Empty;
            txtNombrePaciente.Text = string.Empty;

            txtNombrePaciente.Text = "CLIENTE CONSUMIDOR FINAL";
            txtIdentificacion.Text = "00000000000";
        }
        private void DesbloquearControlesClientes() {
            txtCodigoCliente.Enabled = true;
            btnAgregarAlmacen.Enabled = true;
            btnRegresar.Enabled = true;
            ddlTipoFacturacion.Enabled = true;
            txtTelefono.Enabled = true;
            txtEmail.Enabled = true;
            ddlTipoIdentificacion.Enabled = true;
            txtIdentificacion.Enabled = true;
            txtDireccion.Enabled = true;
            txtComentario.Enabled = true;
            txtNombrePaciente.Enabled = true;

            txtCodigoCliente.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtIdentificacion.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtComentario.Text = string.Empty;
            txtNombrePaciente.Text = string.Empty;
        }
        #endregion
        #region APLICAR TEMA
        private void TemaGenerico() {
            //COLOR DE FONDO
            this.BackColor = SystemColors.Control;


            //COLOR DE TEMBOX
            txtCodigoCliente.BackColor = Color.WhiteSmoke;
            ddlTipoFacturacion.BackColor = Color.WhiteSmoke;
            txtNombrePaciente.BackColor = Color.WhiteSmoke;
            txtTelefono.BackColor = Color.WhiteSmoke;
            txtEmail.BackColor = Color.WhiteSmoke;
            txtNoCotizacion.BackColor = Color.WhiteSmoke;
            ddlTipoIdentificacion.BackColor = Color.WhiteSmoke;
            txtIdentificacion.BackColor = Color.WhiteSmoke;
            txtDireccion.BackColor = Color.WhiteSmoke;
            txtComentario.BackColor = Color.WhiteSmoke;
            ddlTipoVenta.BackColor = Color.WhiteSmoke;
            ddlCantidadDias.BackColor = Color.WhiteSmoke;
            txtCantidadArtiuclos.BackColor = Color.WhiteSmoke;
            txtTotalDescuento.BackColor = Color.WhiteSmoke;
            txtSubtotal.BackColor = Color.WhiteSmoke;
            txtImpuesto.BackColor = Color.WhiteSmoke;
            //txtPorcientoImpuesto.BackColor = Color.WhiteSmoke;
            txtTotal.BackColor = Color.WhiteSmoke;
            ddltIPago.BackColor = Color.WhiteSmoke;
            txtMontoPagar.BackColor = Color.WhiteSmoke;
            txtCambio.BackColor = Color.WhiteSmoke;
            txtCantidadServicios.BackColor = Color.WhiteSmoke;

            //COLOR DE FUENTE
            txtCodigoCliente.ForeColor = Color.Black;
            ddlTipoFacturacion.ForeColor = Color.Black;
            txtNombrePaciente.ForeColor = Color.Black;
            txtTelefono.ForeColor = Color.Black;
            txtEmail.ForeColor = Color.Black;
            txtNoCotizacion.ForeColor = Color.Black;
            ddlTipoIdentificacion.ForeColor = Color.Black;
            txtIdentificacion.ForeColor = Color.Black;
            txtDireccion.ForeColor = Color.Black;
            txtComentario.ForeColor = Color.Black;
            ddlTipoVenta.ForeColor = Color.Black;
            ddlCantidadDias.ForeColor = Color.Black;
            txtCantidadArtiuclos.ForeColor = Color.Black;
            txtTotalDescuento.ForeColor = Color.Black;
            txtSubtotal.ForeColor = Color.Black;
            txtImpuesto.ForeColor = Color.Black;
            //txtPorcientoImpuesto.ForeColor = Color.Black;
            txtTotal.ForeColor = Color.Black;
            ddltIPago.ForeColor = Color.Black;
            txtMontoPagar.ForeColor = Color.Black;
            txtCambio.ForeColor = Color.Black;
            txtCantidadServicios.ForeColor = Color.Black;

            dtProductosAgregados.BackgroundColor = SystemColors.Control;
            dtFacturasMinimizadas.BackgroundColor = SystemColors.Control;

        }
        #endregion
        #region METODOS PARA MOVER LA PANTALLA
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        #endregion
        #region MOSTRAMOS LOS COMPROBANTES FISCALES

        private void MostrarComprobantesFiscales() {
            //VERIFICAMOS SI EL SISTEMA ESTA CONFIGURADO PARA USAR COMPROBANTES FISCALES
            bool UsoComprobante = false;
            var VerificarUsoComprobantes = ObjDataConfiguracion.Value.BuscaCOnfiguracionGeneral(1);
            foreach (var n in VerificarUsoComprobantes)
            {
                UsoComprobante = Convert.ToBoolean(n.Estatus0);
            }
            if (UsoComprobante == true)
            {
                //Mostrar los comprobantes fiscales
                var Comprobantes = ObjDataListas.Value.BuscaCOmprobantesFiscales();
                ddlTipoFacturacion.DataSource = Comprobantes;
                ddlTipoFacturacion.DisplayMember = "Comprbante";
                ddlTipoFacturacion.ValueMember = "IdComprobante";
            }
            else {
                //No Mostrar los comprobantes fiscales
                var NoMostrarComprobantes = ObjDataListas.Value.BuscaComprobantesnulos();
                ddlTipoFacturacion.DataSource = NoMostrarComprobantes;
                ddlTipoFacturacion.DisplayMember = "Descripcion";
                ddlTipoFacturacion.ValueMember = "IdComprobanteNulo";
            }
        }
        #endregion
        #region MOSTRAR LISTADO DE LOS TIPOS DE VENTAS
        private void MostrarListadoTipoVenta() {
            var TipoVenta = ObjDataListas.Value.BuscaTipoVenta();
            ddlTipoVenta.DataSource = TipoVenta;
            ddlTipoVenta.DisplayMember = "TipoVenta";
            ddlTipoVenta.ValueMember = "IdTipoVenta";
        }
        #endregion
        #region MOSTRAR EL LISTADO DE LOS TIPOS DE IDENTIFICACION
        private void MostrarTipoIdentificacion() {
            var TipoIdentificacion = ObjDataListas.Value.BuscaTipoIdentificacion();
            ddlTipoIdentificacion.DataSource = TipoIdentificacion;
            ddlTipoIdentificacion.DisplayMember = "TipoIdentificacion";
            ddlTipoIdentificacion.ValueMember = "IdTipoIdentificacion";
        }
        #endregion
        #region BLOQUEAR CONTROLES
        private void BloquearControles() {
            cbAgregarCliente.Enabled = false;
            cbBuscarPorCodigo.Enabled = false;
            txtCodigoConsulta.Enabled = false;
            btnBuscarCodigoCliente.Enabled = false;
            btnAgregarAlmacen.Enabled = false;
            txtCodigoCliente.Enabled = false;
            ddlTipoFacturacion.Enabled = false;
            txtNombrePaciente.Enabled = false;
            txtTelefono.Enabled = false;
            txtEmail.Enabled = false;
            txtNoCotizacion.Enabled = false;
            ddlTipoIdentificacion.Enabled = false;
            txtIdentificacion.Enabled = false;
            txtDireccion.Enabled = false;
            txtComentario.Enabled = false;
            btnBuscarCotizacion.Enabled = false;

            btnRegresar.Enabled = true;
            btnRefresarCotizacion.Enabled = true;
            VariablesGlobales.BloqueaControles = true;
        }

        private void DesbloquearControles() {
            cbAgregarCliente.Enabled = true;
            cbBuscarPorCodigo.Enabled = true;
            txtCodigoConsulta.Enabled = true;
            btnBuscarCodigoCliente.Enabled = true;
            btnAgregarAlmacen.Enabled = true;
            txtCodigoCliente.Enabled = true;
            ddlTipoFacturacion.Enabled = true;
            txtNombrePaciente.Enabled = true;
            txtTelefono.Enabled = true;
            txtEmail.Enabled = true;
            txtNoCotizacion.Enabled = true;
            ddlTipoIdentificacion.Enabled = true;
            txtIdentificacion.Enabled = true;
            txtDireccion.Enabled = true;
            txtComentario.Enabled = true;
            btnBuscarCotizacion.Enabled = true;

            btnRegresar.Enabled = false;
            btnRefresarCotizacion.Enabled = false;

            VariablesGlobales.BloqueaControles = false;

        }

        private void LimpiarControles() {
           
            txtCodigoConsulta.Text = string.Empty;
            txtCodigoCliente.Text = string.Empty;
            MostrarComprobantesFiscales();
            txtNombrePaciente.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtNoCotizacion.Text = string.Empty;
            MostrarTipoIdentificacion();
            txtIdentificacion.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtComentario.Text = string.Empty;
            cbAgregarCliente.Checked = false;
            cbBuscarPorCodigo.Checked = false;
            MostrarListadoTipoVenta();
            cbAgregarCliente.Enabled = true;
        }
        #endregion
        #region MOSTRAR LA CANTIDAD DE DIAS
        private void ListadoCantidadDias() {
            var Listado = ObjDataListas.Value.ListadoCantidadDias();
            ddlCantidadDias.DataSource = Listado;
            ddlCantidadDias.DisplayMember = "CantidadDias";
            ddlCantidadDias.ValueMember = "IdCantidadDias";
        }
        #endregion
        #region MOSTRAR EL LISTADO DE LAS FACTURAS MINIMIZADAS
        private void ListadoFacturaMinimizadas()
        {
            try
            {
                var BuscarFacturasMinimizadas = ObjDataServicio.Value.BuscaFacturasMinimizadas(
                    VariablesGlobales.IdUsuario);
                dtFacturasMinimizadas.DataSource = BuscarFacturasMinimizadas;
                OcultarColumnasMinimizadas();
                if (BuscarFacturasMinimizadas.Count() < 1)
                {
                    lbcantidadFActuras.Text = "0";

                }
                else
                {
                    foreach (var n in BuscarFacturasMinimizadas)
                    {
                        int CantidadRegistros = Convert.ToInt32(n.Cantidadregistros);
                        lbcantidadFActuras.Text = CantidadRegistros.ToString("N0");
                    }
                }
            }
            catch (Exception) { }

        }
        private void OcultarColumnasMinimizadas()
        {
            this.dtFacturasMinimizadas.Columns["IdUsuario"].Visible = false;
            this.dtFacturasMinimizadas.Columns["Usuario"].Visible = false;
            this.dtFacturasMinimizadas.Columns["NumeroConector"].Visible = false;
            this.dtFacturasMinimizadas.Columns["AgregarCliente"].Visible = false;
            this.dtFacturasMinimizadas.Columns["BuscarCliente"].Visible = false;
            this.dtFacturasMinimizadas.Columns["IdTipoVenta"].Visible = false;
            this.dtFacturasMinimizadas.Columns["TipoVenta"].Visible = false;
            this.dtFacturasMinimizadas.Columns["IdCantidadDias"].Visible = false;
            this.dtFacturasMinimizadas.Columns["CantidadDias"].Visible = false;
            this.dtFacturasMinimizadas.Columns["RncConsulta"].Visible = false;
            this.dtFacturasMinimizadas.Columns["IdComprobante"].Visible = false;
            this.dtFacturasMinimizadas.Columns["Comprobante"].Visible = false;
            this.dtFacturasMinimizadas.Columns["Telefono"].Visible = false;
            this.dtFacturasMinimizadas.Columns["Email"].Visible = false;
            this.dtFacturasMinimizadas.Columns["NoCotizacion"].Visible = false;
            this.dtFacturasMinimizadas.Columns["IdTipoIdentificacion"].Visible = false;
            this.dtFacturasMinimizadas.Columns["TipoIdentificacion"].Visible = false;
            this.dtFacturasMinimizadas.Columns["NumeroIdentificacion"].Visible = false;
            this.dtFacturasMinimizadas.Columns["Comentario"].Visible = false;
            this.dtFacturasMinimizadas.Columns["MontoCredito"].Visible = false;
            this.dtFacturasMinimizadas.Columns["FacturarCotizar"].Visible = false;
            this.dtFacturasMinimizadas.Columns["FacturaPuntoVenta"].Visible = false;
            this.dtFacturasMinimizadas.Columns["FormatoFactura"].Visible = false;
            this.dtFacturasMinimizadas.Columns["BloqueaControles"].Visible = false;
            this.dtFacturasMinimizadas.Columns["Cantidadregistros" +
                ""].Visible = false;
        }
        #endregion
        #region MANTENIMIENTO DE FACTURAS MINIMIZADAS
        private void MANFacturasMinimizadas(string Accion)
        {
            try
            {
                bool FacturrCotizar = false;

                if (rbFacturar.Checked == true)
                {
                    FacturrCotizar = true;
                }
                else if (rbCotizar.Checked == true)
                {
                    FacturrCotizar = false;
                }


                bool FormatoFActura = false;
                if (rbfacturaspanish.Checked == true)
                {
                    FormatoFActura = true;
                }
                else if (rbfacturaenglish.Checked == true)
                {
                    FormatoFActura = false;
                }

                if (string.IsNullOrEmpty(txtNoCotizacion.Text.Trim()))
                {
                    txtNoCotizacion.Text = "0";
                }

                DSMarket.Logica.Entidades.EntidadesServicio.EFacturaMinimizada Mantenimiento = new Logica.Entidades.EntidadesServicio.EFacturaMinimizada();

                Mantenimiento.IdUsuario = VariablesGlobales.IdUsuario;
                Mantenimiento.NumeroConector = VariablesGlobales.NumeroConector;
                Mantenimiento.Secuencia = VariablesGlobales.SecuencialFActuraMinimizada;
                Mantenimiento.AgregarCliente = cbAgregarCliente.Checked;
                Mantenimiento.BuscarCliente = cbBuscarPorCodigo.Checked;
                Mantenimiento.IdTipoVenta = Convert.ToInt32(ddlTipoVenta.SelectedValue);
                Mantenimiento.IdCantidadDias = Convert.ToInt32(ddlCantidadDias.SelectedValue);
                Mantenimiento.RncConsulta = txtCodigoCliente.Text;
                Mantenimiento.IdComprobante = Convert.ToDecimal(ddlTipoFacturacion.SelectedValue);
                Mantenimiento.Nombre = txtNombrePaciente.Text;
                Mantenimiento.Telefono = txtTelefono.Text;
                Mantenimiento.Email = txtEmail.Text;
                Mantenimiento.NoCotizacion = Convert.ToDecimal(txtNoCotizacion.Text);
                Mantenimiento.IdTipoIdentificacion = Convert.ToDecimal(ddlTipoIdentificacion.SelectedValue);
                Mantenimiento.NumeroIdentificacion = txtIdentificacion.Text;
                Mantenimiento.Comentario = txtComentario.Text;
                Mantenimiento.MontoCredito = Convert.ToDecimal(lbMontoCredito.Text);
                Mantenimiento.FacturarCotizar = FacturrCotizar;
                Mantenimiento.FacturaPuntoVenta = cbFacturaPuntoVenta.Checked;
                Mantenimiento.FormatoFactura = FormatoFActura;
                Mantenimiento.BloqueaControles = VariablesGlobales.BloqueaControles;

                var MANFacturaMinimizada = ObjDataServicio.Value.MantenimientoFacturaMinimizado(Mantenimiento, Accion);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al minimizar, codigo de error--> " + ex.Message, VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }
        #endregion
        #region GENERAR NUMERO DE CONECTOR
        /// <summary>
        /// Este metodo es para generar un numero aleatorio desde el numero 0 hasta el 999,999,999
        /// </summary>
        private void GenerarNumeroConector() {
            Random Generar = new Random();
            int Numero = Generar.Next(0, 999999999);
            VariablesGlobales.NumeroConector = Numero;
            VariablesGlobales.GenerarConector = false;
            lbNumeroConector.Text = VariablesGlobales.NumeroConector.ToString();
        }
        #endregion
        #region MANTENIMIENTOS
        //GUARDAR LOS DATOS DEL CLIENTE
        private void GuardarDatosClientes(string Accion) {
            int IdEstatusFacturacion = 0;

            if (rbFacturar.Checked == true) {
                IdEstatusFacturacion = 1;
            }
            else if (rbCotizar.Checked == true) { IdEstatusFacturacion = 2; }

            DSMarket.Logica.Entidades.EntidadesServicio.EFacturacionClientes ManClientes = new Logica.Entidades.EntidadesServicio.EFacturacionClientes();

            ManClientes.IdFactura = 0;
            ManClientes.NumeroConector = VariablesGlobales.NumeroConector;
            ManClientes.IdEstatusFacturacion = IdEstatusFacturacion;
            ManClientes.IdComprobante = Convert.ToDecimal(ddlTipoFacturacion.SelectedValue);
            ManClientes.Nombre = txtNombrePaciente.Text;
            ManClientes.Telefono = txtTelefono.Text;
            ManClientes.Email = txtEmail.Text;
            ManClientes.IdTipoIdentificacion = Convert.ToDecimal(ddlTipoIdentificacion.SelectedValue);
            ManClientes.NumeroIdentificacion = txtIdentificacion.Text;
            ManClientes.Direccion = txtDireccion.Text;
            ManClientes.Comentario = txtComentario.Text;
            ManClientes.IdTipoVenta = Convert.ToDecimal(ddlTipoVenta.SelectedValue);
            ManClientes.IdCantidadDias = Convert.ToDecimal(ddlCantidadDias.SelectedValue);
            ManClientes.IdUsuario = VariablesGlobales.IdUsuario;

            var MAN = ObjDataServicio.Value.GuardarFacturacionClientes(ManClientes, Accion);
        }
        //GUARDAR LOS DATOS DE LOS CALCULOS
        private void GuardarDatosCalculos(string Accion) {
            DSMarket.Logica.Entidades.EntidadesServicio.EGuardarFacturacionCalculos Calculos = new Logica.Entidades.EntidadesServicio.EGuardarFacturacionCalculos();

            Calculos.NumeroColector = VariablesGlobales.NumeroConector;
            Calculos.CantidadProductos = Convert.ToInt32(txtCantidadArtiuclos.Text);
            Calculos.CantidadServicios = Convert.ToInt32(txtCantidadServicios.Text);
            Calculos.CantidadArticulos = Convert.ToInt32(txtTotalServicios.Text);
            Calculos.TotalDescuento = Convert.ToDecimal(txtTotalDescuento.Text);
            Calculos.SubTotal = Convert.ToDecimal(txtSubtotal.Text);
            Calculos.Impuesto = Convert.ToDecimal(txtImpuesto.Text);
            Calculos.PorcientoImpuesto = 0;
            Calculos.MontoPagado = Convert.ToDecimal(txtMontoPagar.Text);
            Calculos.Cambio = Convert.ToDecimal(txtCambio.Text);
            Calculos.IdTipoPago = Convert.ToDecimal(ddltIPago.SelectedValue);
            Calculos.TotalGeneral = Convert.ToDecimal(txtTotal.Text);


            var MAn = ObjDataServicio.Value.GuardarFacturacionCalculos(Calculos, Accion);
        }
        #endregion
        #region SACAR LA DATA DE LAS FACTURAS MINIMIZADAS
        private void SacarDataFacturaMinimizadas() {
            var Buscar = ObjDataServicio.Value.BuscaFacturasMinimizadas(
                        VariablesGlobales.IdUsuario,
                        VariablesGlobales.NumeroConector,
                        VariablesGlobales.SecuencialFActuraMinimizada);
            foreach (var n in Buscar)
            {
                VariablesGlobales.NumeroConector = Convert.ToDecimal(n.NumeroConector);
                lbNumeroConector.Text = VariablesGlobales.NumeroConector.ToString();
                cbAgregarCliente.Checked = (n.AgregarCliente.HasValue ? n.AgregarCliente.Value : false);
                cbBuscarPorCodigo.Checked = (n.BuscarCliente.HasValue ? n.BuscarCliente.Value : false);
                ddlTipoVenta.Text = n.TipoVenta;
                ddlCantidadDias.Text = n.CantidadDias;
                txtCodigoCliente.Text = n.RncConsulta;
                ddlTipoFacturacion.Text = n.Comprobante;
                txtNombrePaciente.Text = n.Nombre;
                txtTelefono.Text = n.Telefono;
                txtEmail.Text = n.Email;
                txtNoCotizacion.Text = n.NoCotizacion.ToString();
                if (string.IsNullOrEmpty(txtNoCotizacion.Text.Trim()))
                {
                    txtNoCotizacion.Text = string.Empty;
                }
                ddlTipoIdentificacion.Text = n.TipoIdentificacion;
                txtIdentificacion.Text = n.TipoIdentificacion;
                txtComentario.Text = n.Comentario;
                decimal MontoCredito = Convert.ToDecimal(n.MontoCredito);
                lbMontoCredito.Text = MontoCredito.ToString("N2");
                bool TipoProceso = Convert.ToBoolean(n.FacturarCotizar.HasValue ? n.FacturarCotizar.Value : false);
                if (TipoProceso == true)
                {
                    rbCotizar.Checked = false;
                    rbFacturar.Checked = true;
                }
                else
                {
                    rbFacturar.Checked = false;
                    rbCotizar.Checked = true;

                }
                cbFacturaPuntoVenta.Checked = (n.FacturaPuntoVenta.HasValue ? n.FacturaPuntoVenta.Value : false);
                bool BloqueaControles = Convert.ToBoolean(n.BloqueaControles.HasValue ? n.BloqueaControles.Value : false);
                if (BloqueaControles == true)
                {
                    BloquearControles();
                }
                else
                {
                    DesbloquearControles();
                }
            }
        }
        #endregion
        #region MANTENIMIENTO DE PRODUCTO ESPEJO
        private void MANProductoEspejo(string Accion) {

            if (string.IsNullOrEmpty(txtNoCotizacion.Text.Trim())) {
                txtNoCotizacion.Text = "0";
            }
            bool FActurarCotizar = false;
            if (rbFacturar.Checked == true) {
                FActurarCotizar = true;
            }
            else if (rbCotizar.Checked == true) {
                FActurarCotizar = false;
            }

            bool FormatoFActura = false;

            if (rbfacturaspanish.Checked == true) {
                FormatoFActura = true;
            }
            else if (rbfacturaenglish.Checked == true) {
                FormatoFActura = true;
            }

            DSMarket.Logica.Entidades.EntidadesServicio.EFacturacionEspejo Mantenimiento = new Logica.Entidades.EntidadesServicio.EFacturacionEspejo();

            Mantenimiento.IdUsuario = VariablesGlobales.IdUsuario;
            Mantenimiento.NumeroConector = VariablesGlobales.NumeroConector;
            Mantenimiento.AgregarCliente = cbAgregarCliente.Checked;
            Mantenimiento.BuscarCliente = cbBuscarPorCodigo.Checked;
            Mantenimiento.IdTipoVenta = Convert.ToInt32(ddlTipoVenta.SelectedValue);
            Mantenimiento.IdCantidadDias = Convert.ToInt32(ddlCantidadDias.SelectedValue);
            Mantenimiento.RncConsulta = txtCodigoCliente.Text;
            Mantenimiento.IdComprobante = Convert.ToDecimal(ddlTipoFacturacion.SelectedValue);
            Mantenimiento.Nombre = txtNombrePaciente.Text;
            Mantenimiento.Telefono = txtTelefono.Text;
            Mantenimiento.Email = txtEmail.Text;
            Mantenimiento.NoCotizacion = Convert.ToDecimal(txtNoCotizacion.Text);
            Mantenimiento.IdTipoIdentificacion = Convert.ToDecimal(ddlTipoIdentificacion.SelectedValue);
            Mantenimiento.NumeroIdentificacion = txtIdentificacion.Text;
            Mantenimiento.Comentario = txtComentario.Text;
            Mantenimiento.MontoCredito = Convert.ToDecimal(lbMontoCredito.Text);
            Mantenimiento.FacturarCotizar = FActurarCotizar;
            Mantenimiento.FacturaPuntoVenta = cbFacturaPuntoVenta.Checked;
            Mantenimiento.FormatoFactura = FormatoFActura;
            Mantenimiento.BloqueaControles = VariablesGlobales.BloqueaControles;

            var MAn = ObjDataServicio.Value.ManteniientoFacturacionEspejo(Mantenimiento, Accion);

        }
        #endregion
        #region SACAR LOS DATOS DE LA FACTURACION ESPEJO
        /// <summary>
        /// Este metodo es para sacar los datos de la facturacion espejo, utilizada al momento de cambiar de pantalla
        /// </summary>
        /// <param name="IdUsuario"></param>
        private void SacarInformacionFacturacionEspejo() {
            var SacarListadoFacturacionEspejo = ObjDataServicio.Value.BuscaFacturacionEspeo(VariablesGlobales.IdUsuario);
            foreach (var n in SacarListadoFacturacionEspejo) {
                cbAgregarCliente.Checked = (n.AgregarCliente.HasValue ? n.AgregarCliente.Value : false);
                cbBuscarPorCodigo.Checked = (n.BuscarCliente.HasValue ? n.BuscarCliente.Value : false);
                VariablesGlobales.NumeroConector = Convert.ToDecimal(n.NumeroConector);
                lbNumeroConector.Text = VariablesGlobales.NumeroConector.ToString();
                txtNombrePaciente.Text = n.Nombre;
               
                ddlTipoVenta.Text = n.TipoVenta;
                ddlCantidadDias.Text = n.CantidadDias;
                txtCodigoCliente.Text = n.RncConsulta;
                ddlTipoFacturacion.Text = n.Comprobante;
                txtTelefono.Text = n.Telefono;
                txtEmail.Text = n.Email;
                if (n.NoCotizacion == 0)
                {
                    txtNoCotizacion.Text = string.Empty;
                }
                else {
                    txtNoCotizacion.Text = n.NoCotizacion.ToString();
                }
                ddlTipoIdentificacion.Text = n.TipoIdentificacion;
                txtIdentificacion.Text = n.NumeroIdentificacion;
                txtComentario.Text = n.Comentario;
                decimal MontoCredito = Convert.ToDecimal(n.MontoCredito);
                lbMontoCredito.Text = MontoCredito.ToString("N2");
                bool FacturarCotizar = Convert.ToBoolean(n.FacturarCotizar);
                if (FacturarCotizar == true) {
                    rbCotizar.Checked = false;
                    rbFacturar.Checked = true;
                }
                else if (FacturarCotizar == false) {
                    rbFacturar.Checked = false;
                    rbCotizar.Checked = true;
                }
                cbFacturaPuntoVenta.Checked = (n.FacturaPuntoVenta.HasValue ? n.FacturaPuntoVenta.Value : false);
                bool FormatoFactura = Convert.ToBoolean(n.FormatoFactura);
                if (FormatoFactura == true) {
                    rbfacturaenglish.Checked = false;
                    rbfacturaspanish.Checked = true;
                }
                else if (FormatoFactura == false) {
                    rbfacturaspanish.Checked = false;
                    rbfacturaenglish.Checked = true;    
                }
                bool BloqueaControles = Convert.ToBoolean(n.BloqueaControles);
                if (BloqueaControles == true)
                {
                    BloquearControles();
                    btnAgregarAlmacen.Visible = false;
                    btnRegresar.Visible = true;
                }
                else if (BloqueaControles == false)
                {
                    DesbloquearControles();
                }
            }
        }
        #endregion
        #region BUSCAR CONTROLES
        private void BuscarPorRNC() {
            if (string.IsNullOrEmpty(txtCodigoCliente.Text.Trim()))
            {
                MessageBox.Show("No puedes dejar el campo rnc vacio para buscar un registro", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigoCliente.Focus();
            }
            else
            {
                //BUSCAMOS EL REGISTRO
                var Buscarregistro = ObjDataEmpresa.Value.BuscaClientes(
                    new Nullable<decimal>(),
                    null, null, txtCodigoCliente.Text, null, 1, 1);
                if (Buscarregistro.Count() < 1)
                {
                    MessageBox.Show("El rnc de cliente ingresado no es valido, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCodigoCliente.Text = string.Empty;
                    txtCodigoCliente.Focus();
                }
                else
                {
                    foreach (var n in Buscarregistro)
                    {
                        bool usoComprobante = false;

                        var ValidarUsoCOmprobante = ObjDataConfiguracion.Value.BuscaCOnfiguracionGeneral(1);
                        foreach (var n2 in ValidarUsoCOmprobante)
                        {
                            usoComprobante = Convert.ToBoolean(n2.Estatus0);
                        }

                        if (usoComprobante == true)
                        {
                            ddlTipoFacturacion.Text = n.Comprobante;
                        }
                        decimal Credito = Convert.ToDecimal(n.MontoCredito);
                        lbMontoCredito.Text = Credito.ToString("N2");
                        txtNombrePaciente.Text = n.Nombre;
                        txtTelefono.Text = n.Telefono;
                        txtEmail.Text = n.Email;
                        ddlTipoIdentificacion.Text = n.TipoIdentificacion;
                        txtIdentificacion.Text = n.RNC;
                        txtDireccion.Text = n.Direccion;
                        txtComentario.Text = n.Comentario;
                    }
                    btnAgregarAlmacen.Visible = false;
                    btnRegresar.Visible = true;
                    BloquearControles();
                }
            }
        }
        #endregion
        #region BUSCAR LOS PRODUCTOS AGRGADOS
        private void BuscarProductosAgregados(decimal NumeroConector)
        {
            var BuscarRegistros = ObjDataServicio.Value.BuscapRoductosAgregados(
                new Nullable<Decimal>(),
                NumeroConector);
            dtProductosAgregados.DataSource = BuscarRegistros;

            foreach (var n in BuscarRegistros)
            {
                decimal TotalDescuento = Convert.ToDecimal(n.TotalDescuento);
                decimal SubTotal = Convert.ToDecimal(n.SubTotal);
                decimal Impuesto = Convert.ToDecimal(n.TotalImpuesto);
              //  decimal PorcientoImpuesto = Convert.ToDecimal(n.PorcientoImpuesto);
                decimal Total = Convert.ToDecimal(n.TotalGeneral);
                decimal CantidadArticulos = Convert.ToDecimal(n.CantidadProductos);
                decimal CantidadServicios = Convert.ToDecimal(n.CantidadServicios);
                decimal TotalRegistros = Convert.ToDecimal(n.CantidadRegistros);

                txtTotalDescuento.Text = TotalDescuento.ToString("N2");
                txtSubtotal.Text = SubTotal.ToString("N2");
                txtImpuesto.Text = Impuesto.ToString("N2");
               // txtPorcientoImpuesto.Text = PorcientoImpuesto.ToString("N0");
                txtTotal.Text = Total.ToString("N2");
                txtCantidadArtiuclos.Text = CantidadArticulos.ToString("N0");
                txtCantidadServicios.Text = CantidadServicios.ToString("N0");
                txtTotalServicios.Text = TotalRegistros.ToString("N0");
            }

            this.dtProductosAgregados.Columns["NumeroConector"].Visible = false;
            this.dtProductosAgregados.Columns["IdTipoProducto"].Visible = false;
            this.dtProductosAgregados.Columns["IdCategoria"].Visible = false;
            this.dtProductosAgregados.Columns["DescripcionTipoProducto1"].Visible = false;
            this.dtProductosAgregados.Columns["Acumulativo"].Visible = false;
            this.dtProductosAgregados.Columns["IdProducto"].Visible = false;
            this.dtProductosAgregados.Columns["ConectorProducto"].Visible = false;
            this.dtProductosAgregados.Columns["CantidadProductos"].Visible = false;
            this.dtProductosAgregados.Columns["CantidadServicios"].Visible = false;
            this.dtProductosAgregados.Columns["CantidadRegistros"].Visible = false;
            this.dtProductosAgregados.Columns["TotalDescuento"].Visible = false;
            this.dtProductosAgregados.Columns["PorcientoImpuesto"].Visible = false;
            this.dtProductosAgregados.Columns["SubTotal"].Visible = false;
            this.dtProductosAgregados.Columns["TotalImpuesto"].Visible = false;
            this.dtProductosAgregados.Columns["TotalGeneral"].Visible = false;
            //this.dtProductosAgregados.Columns[""].Visible = false;
            //this.dtProductosAgregados.Columns[""].Visible = false;
            //this.dtProductosAgregados.Columns[""].Visible = false;
            //this.dtProductosAgregados.Columns[""].Visible = false;
            //this.dtProductosAgregados.Columns[""].Visible = false;
        }
        #endregion
        #region MOSTRAR LOS TIPOS DE PAGOS
        private void MostrarListadoTipoPagos() {
            var TipoPago = ObjDataListas.Value.BuscaTipoPago(
                new Nullable<decimal>());
            ddltIPago.DataSource = TipoPago;
            ddltIPago.DisplayMember = "TipoPago";
            ddltIPago.ValueMember = "IdTipoPago";
        }
        #endregion
        #region DEVOLVER PRODUCTO A INVENTARIO
        private void DevolverProductosInventario(decimal NumeroConectorProcesar) {
            var BuscaProductosAgregados = ObjDataServicio.Value.BuscapRoductosAgregados(
                new Nullable<decimal>(),
                NumeroConectorProcesar);
            decimal IdProducto = 0;
            decimal IdTipoProducto = 0;
            bool Acumulativo = false;
            bool EstatusProducto = false;
            decimal NumeroConector = 0;
            int CantidadAgregada = 0;
            foreach (var n in BuscaProductosAgregados) {
                IdProducto = Convert.ToDecimal(n.IdProducto);

                //BUSCAMOS EL PRODUCTO PARA DETERMINAR QUE TIPO DE PRODUCTO ES
                var SacarDatosProducto = ObjDataInventario.Value.BuscaProductos(
                    IdProducto,
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
                    1, 1);
                foreach (var n2 in SacarDatosProducto) {
                    IdTipoProducto = Convert.ToDecimal(n2.IdTipoProducto);
                    Acumulativo = Convert.ToBoolean(n2.ProductoAcumulativo0);
                    EstatusProducto = Convert.ToBoolean(n2.EstatusProducto0);
                    NumeroConector = Convert.ToDecimal(n2.NumeroConector);
                    CantidadAgregada = Convert.ToInt32(n.Cantidad);
                }

                //VALIDAMOS LOS DATOS
                if (IdTipoProducto == 1)
                {
                    //ESTE BLOQUE ESTA RESERVADO PARA LOS PRODUCTOS
                    if (Acumulativo == true) {
                        //ESTE BLOQUE ESTA RESERVADO PARA LOS PRODUCTOS QUE SON ACUMULATIVO
                        //DEVOLVEMOS EL ESTATUS DEL PRODUCTO


                        ModificarStockproducto(IdProducto,NumeroConector, CantidadAgregada, "ADDPRODUCT");

                      //  EliminarListadoProductosAgregados();
                    }
                    else {
                        //ESTE BLOQUE ESTA RESERVADO PARA LOS PRODUCTOS QUE NO SON ACUMULATIVO
                        //ACTUAMIZAMOS EL ESTATUS DEL PRODUCTO

                        DSMarket.Logica.Entidades.EntidadesInventario.EProducto Devolver = new Logica.Entidades.EntidadesInventario.EProducto();

                        Devolver.IdProducto = IdProducto;
                        Devolver.IdTipoProducto = IdTipoProducto;
                        Devolver.ProductoAcumulativo0 = Acumulativo;
                        Devolver.EstatusProducto0 = EstatusProducto;

                        var Add = ObjDataInventario.Value.MantenimientoProducto(Devolver, "CHANGESTATUS");
                        EliminarListadoProductosAgregados();
                    }
                }
                else {
                    //ESTE BLOQUE ESTA RESERVADO PARA LOS SERVICIOS
                 //   EliminarListadoProductosAgregados();
                }
            }
        }
        #endregion
        #region ELIMINAR LISTADO DE PRODUCTOS AGREGADOS
        private void EliminarListadoProductosAgregados() {
            DSMarket.Logica.Entidades.EntidadesServicio.EFacturacionProducto Eliminar = new Logica.Entidades.EntidadesServicio.EFacturacionProducto();

            Eliminar.NumeroConector = VariablesGlobales.NumeroConector;

            var MAN = ObjDataServicio.Value.GuardarFacturacionProductos(Eliminar, "DELETEALL");
            //DSMarket.Logica.Entidades.EntidadesServicio.EProductosAgregados Eliminar = new Logica.Entidades.EntidadesServicio.EProductosAgregados();

            //Eliminar.NumeroConector = VariablesGlobales.NumeroConector;

            //var Borrar = ObjDataServicio.Value.GuardarFacturacionProductos(Eliminar, "DELETE");
        }
        #endregion
        #region MODIFICAR EL STOCK DE LA FACTURA
        private void ModificarStockproducto(decimal IdProducto, decimal NumeroConector, int Stock, string Accion)
        {
            DSMarket.Logica.Entidades.EntidadesInventario.EProducto Alterar = new Logica.Entidades.EntidadesInventario.EProducto();

            Alterar.IdProducto = IdProducto;
            Alterar.NumeroConector = NumeroConector;
            Alterar.Stock = Stock;

            var MAn = ObjDataInventario.Value.MantenimientoProducto(Alterar, Accion);
        }
        #endregion
        #region PROCESO PARA COTIZAR
        private void ProcesoCotizar(decimal NumeroConectorProcesar) {
            var BuscaProductosAgregados = ObjDataServicio.Value.BuscapRoductosAgregados(
               new Nullable<decimal>(),
               NumeroConectorProcesar);
            decimal IdProducto = 0;
            decimal IdTipoProducto = 0;
            bool Acumulativo = false;
            bool EstatusProducto = false;
            decimal NumeroConector = 0;
            int CantidadAgregada = 0;
            foreach (var n in BuscaProductosAgregados)
            {
                IdProducto = Convert.ToDecimal(n.IdProducto);

                //BUSCAMOS EL PRODUCTO PARA DETERMINAR QUE TIPO DE PRODUCTO ES
                var SacarDatosProducto = ObjDataInventario.Value.BuscaProductos(
                    IdProducto,
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
                    1, 1);
                foreach (var n2 in SacarDatosProducto)
                {
                    IdTipoProducto = Convert.ToDecimal(n2.IdTipoProducto);
                    Acumulativo = Convert.ToBoolean(n2.ProductoAcumulativo0);
                    EstatusProducto = Convert.ToBoolean(n2.EstatusProducto0);
                    NumeroConector = Convert.ToDecimal(n2.NumeroConector);
                    CantidadAgregada = Convert.ToInt32(n.Cantidad);
                }

                //VALIDAMOS LOS DATOS
                if (IdTipoProducto == 1)
                {
                    //ESTE BLOQUE ESTA RESERVADO PARA LOS PRODUCTOS
                    if (Acumulativo == true)
                    {
                        //ESTE BLOQUE ESTA RESERVADO PARA LOS PRODUCTOS QUE SON ACUMULATIVO
                        //DEVOLVEMOS EL ESTATUS DEL PRODUCTO


                        ModificarStockproducto(IdProducto, NumeroConector, CantidadAgregada, "ADDPRODUCT");

                        //  EliminarListadoProductosAgregados();
                    }
                    else
                    {
                        //ESTE BLOQUE ESTA RESERVADO PARA LOS PRODUCTOS QUE NO SON ACUMULATIVO
                        //ACTUAMIZAMOS EL ESTATUS DEL PRODUCTO

                        DSMarket.Logica.Entidades.EntidadesInventario.EProducto Devolver = new Logica.Entidades.EntidadesInventario.EProducto();

                        Devolver.IdProducto = IdProducto;
                        Devolver.IdTipoProducto = IdTipoProducto;
                        Devolver.ProductoAcumulativo0 = Acumulativo;
                        Devolver.EstatusProducto0 = EstatusProducto;

                        var Add = ObjDataInventario.Value.MantenimientoProducto(Devolver, "CHANGESTATUS");
                        
                    }
                }
                else
                {
                    //ESTE BLOQUE ESTA RESERVADO PARA LOS SERVICIOS
                    //   EliminarListadoProductosAgregados();
                }
            }
        }
        #endregion
        #region CALCULAR CAMBIO
        /// <summary>
        /// Este metodo es para calcular el cambio de la factura.
        /// </summary>
        private void CalcularCambio() {
            try
            {
                decimal MontoPagar, Total, Cambio;
                MontoPagar = Convert.ToDecimal(txtMontoPagar.Text);
                Total = Convert.ToDecimal(txtTotal.Text);
                Cambio = MontoPagar - Total;
                txtCambio.Text = Cambio.ToString("N2");
            }
            catch (Exception) { }
        }
        #endregion
        #region AGREGAR REGISTROS A FACTURA
        /// <summary>
        /// Este metodo es para cambiar de pantalla para agregar registros a factura.
        /// </summary>
        private void AgregarRegistros() {
            MANProductoEspejo("DELETE");
            MANProductoEspejo("INSERT");
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Servicio.AgregarProductos AddProducts = new AgregarProductos();
            AddProducts.VariablesGlbales.IdUsuario = VariablesGlobales.IdUsuario;
            AddProducts.VariablesGlbales.GenerarConector = VariablesGlobales.GenerarConector;
            AddProducts.VariablesGlbales.NumeroConector = VariablesGlobales.NumeroConector;
            AddProducts.ShowDialog();
        }
        #endregion
        #region AFECTAR COMPROBANTE FISCAL
        private void AfectarComprobanteFiscal() {
            //VALIDAMOS SI LOS COMPROBANTES ESTAN ACTIVOS
            bool EstatusComprobante = false;

            var ValidarComprobante = ObjDataConfiguracion.Value.BuscaCOnfiguracionGeneral(1);
            foreach (var n in ValidarComprobante) {
                EstatusComprobante = Convert.ToBoolean(n.Estatus0);
            }
            if (EstatusComprobante == true)
            {
                //AFECTAMOS LOS COMPROBANTES
                decimal IdFacturaSacada = 0;
                string DescripcionComprobanteSacada = "";
                string NumeroComprobante = "";
                //1- SACAMOS EL NUMERO DE LA FACTURA
                var SacarnumeroFactura = ObjDataServicio.Value.SacarNumeroFactura(VariablesGlobales.NumeroConector);
                foreach (var ns in SacarnumeroFactura)
                {
                    IdFacturaSacada = Convert.ToDecimal(ns.IdFactura);
                }

                //2- SACAMOS LA DESCRIPCION DEL COMPROBANTE Y EL NUMERO DE COMPROBANTE
                var GenerarComprobanteFiscal = ObjDataConfiguracion.Value.GenerarComprobante(Convert.ToDecimal(ddlTipoFacturacion.SelectedValue));
                foreach (var n3 in GenerarComprobanteFiscal)
                {
                    DescripcionComprobanteSacada = n3.TipoComprobante;
                    NumeroComprobante = n3.Comprobante;
                }

                DSMarket.Logica.Entidades.EntidadesServicio.EGuardarFacturacionComprobantes Afectar = new Logica.Entidades.EntidadesServicio.EGuardarFacturacionComprobantes();

                Afectar.IdFacturacion = IdFacturaSacada;
                Afectar.NumeroConector = VariablesGlobales.NumeroConector;
                Afectar.DescripcionComprobante = DescripcionComprobanteSacada;
                Afectar.Comprobante = NumeroComprobante;

                var MAN = ObjDataServicio.Value.GuardarFacturacionComprobante(Afectar, "INSERT");

            }
            else if (EstatusComprobante == false) { }

        }
        #endregion
        #region AFECTAR LA CAJA
        private void AfectarCaja() {
            DSMarket.Logica.Entidades.EntidadesCaja.EHistorialCaja MantenimientoCaja = new Logica.Entidades.EntidadesCaja.EHistorialCaja();

            MantenimientoCaja.IdHistorialCaja = 0;
            MantenimientoCaja.IdCaja = 1;
            MantenimientoCaja.Monto = Convert.ToDecimal(txtTotal.Text);
            MantenimientoCaja.Concepto = "FACTURACION";
            MantenimientoCaja.Fecha0 = DateTime.Now;
            MantenimientoCaja.IdUsuario = VariablesGlobales.IdUsuario;
            MantenimientoCaja.NumeroReferencia = VariablesGlobales.NumeroConector;
            MantenimientoCaja.IdTipoPago = Convert.ToDecimal(ddltIPago.SelectedValue);

            var MAN = ObjDataCaja.Value.MantenimientoHistorialCaja(MantenimientoCaja, "INSERT");
        }
        #endregion
        #region GENERAR LA FACTURA
        private void GenerarFacturaVenta() {
            try {
                decimal IdFactura = 0;
                string RutaReporte = "";
                string UsuarioBD = "";
                string ClaveBD = "";

                //SACAMOS EL NUMERO DE LA FACTURA
                var SacarNumeroFactura = ObjDataServicio.Value.SacarNumeroFactura(VariablesGlobales.NumeroConector);
                foreach (var n in SacarNumeroFactura) {
                    IdFactura = Convert.ToDecimal(n.IdFactura);
                }

                //SACAMOS LA RUTA DEL REPORTE DEPENDIENDO LA SELECCIONADO
                if (rbfacturaspanish.Checked == true) {
                    var SacarRutaReporte = ObjDataConfiguracion.Value.BuscaRutaReporte(1);
                    foreach (var n in SacarRutaReporte) {
                        RutaReporte = n.RutaReporte;
                    }
                }
                else if (rbfacturaenglish.Checked == true) {
                    var SacarRutaReporte = ObjDataConfiguracion.Value.BuscaRutaReporte(2);
                    foreach (var n in SacarRutaReporte)
                    {
                        RutaReporte = n.RutaReporte;
                    }
                }

                //SACAMOS LAS CREDENCIALES DE LAS BASES DE DATOS
                var SacarCredencialesBD = ObjDataSeguridad.Value.SacarCredencialBD(1);
                foreach (var n in SacarCredencialesBD) {
                    UsuarioBD = n.Usuario;
                    ClaveBD = DSMarket.Logica.Comunes.SeguridadEncriptacion.DesEncriptar(n.Clave);
                }

                //INVOCAMOS LA FACTURA
                DSMarket.Solucion.Pantallas.Pantallas.Reportes.Reportes FacturaVenta = new Reportes.Reportes();
                FacturaVenta.GenerarFacturaVenta(IdFactura, RutaReporte, UsuarioBD, ClaveBD);
                FacturaVenta.ShowDialog();
            }
            catch (Exception ex) {
                MessageBox.Show("Error al generar la factura, codigo de error--> " + ex.Message, VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void Facturacion_Load(object sender, EventArgs e)
        {
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            MostrarComprobantesFiscales();
            MostrarTipoIdentificacion();
            MostrarListadoTipoVenta();
            ListadoCantidadDias();
            ListadoFacturaMinimizadas();
            TemaGenerico();
            if (VariablesGlobales.GenerarConector == true) {
                GenerarNumeroConector();
            }
           // lbNumeroConector.Text = VariablesGlobales.NumeroConector.ToString();
            lbTitulo.Text = "FACTURACION";
            lbTitulo.ForeColor = Color.White;
            lbCredito.Text = "Credito:";
            lbCredito.ForeColor = Color.White;
            lbMontoCredito.Text = "0.00";
            lbMontoCredito.ForeColor = Color.White;
            rbFacturar.Checked = true;
            BloarControlesClientes();
            rbFacturar.ForeColor = Color.LimeGreen;
            rbCotizar.ForeColor = Color.DarkRed;
            cbAgregarCliente.ForeColor = Color.DarkRed;
            rbfacturaspanish.Checked = true;
            rbfacturaspanish.ForeColor = Color.LimeGreen;
            rbfacturaenglish.ForeColor = Color.DarkRed;
            cbFacturaPuntoVenta.ForeColor = Color.DarkRed;
            cbFacturaPuntoVenta.Checked = false;

            if (VariablesGlobales.SacarDataEspejo == true) {
                SacarInformacionFacturacionEspejo();
            }
           
            txtCantidadArtiuclos.Text = "0";
            txtCantidadServicios.Text = "0";
            txtTotalServicios.Text = "0";
            txtTotalDescuento.Text = "0";
            txtSubtotal.Text = "0";
            txtImpuesto.Text = "0";
           // txtPorcientoImpuesto.Text = "0";
            txtTotal.Text = "0";
            BuscarProductosAgregados(VariablesGlobales.NumeroConector);
            MostrarListadoTipoPagos();
            txtMontoPagar.Text = "0";
            CalcularCambio();
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            
        }

        private void rbFacturar_CheckedChanged(object sender, EventArgs e)
        {
            if (VariablesGlobales.ConvertirCotizacionFactura == true)
            {
                lbTitulo.Text = "CONVERTIR COTIZACION A FACTURA";
            }
            else
            {
                if (rbFacturar.Checked == true)
                {
                    lbTitulo.Text = "FACTURACION";
                    rbFacturar.ForeColor = Color.LimeGreen;
                }
                else
                {
                    lbTitulo.Text = "COTIZACION";
                    rbFacturar.ForeColor = Color.DarkRed;
                }
            }
        }

        private void rbCotizar_CheckedChanged(object sender, EventArgs e)
        {
            if (VariablesGlobales.ConvertirCotizacionFactura == true)
            {
                lbTitulo.Text = "CONVERTIR COTIZACION A FACTURA";
            }
            else
            {
                if (rbCotizar.Checked == true)
                {
                    lbTitulo.Text = "COTIZACION";
                    rbCotizar.ForeColor = Color.LimeGreen;
                }
                else
                {
                    lbTitulo.Text = "FACTURACION";
                    rbCotizar.ForeColor = Color.DarkRed;
                }
            }
        }

        private void cbAgregarCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAgregarCliente.Checked == true)
            {
                lbCredito.Visible = true;
                lbMontoCredito.Visible = true;
                DesbloquearControlesClientes();
                cbAgregarCliente.ForeColor = Color.LimeGreen;
                cbBuscarPorCodigo.Enabled = true;
            }
            else
            {
                lbCredito.Visible = false;
                lbMontoCredito.Visible = false;
                BloarControlesClientes();
                cbAgregarCliente.ForeColor = Color.DarkRed;
                cbBuscarPorCodigo.Enabled = false;
                cbBuscarPorCodigo.Checked = false;
                cbBuscarPorCodigo.ForeColor = Color.DarkRed;
                btnAgregarAlmacen.Visible = true;
                btnRegresar.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AgregarRegistros();
        }

        private void Facturacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            //switch (e.CloseReason)
            //{
            //    case CloseReason.UserClosing:
            //        e.Cancel = true;
            //        break;
            //}
        }

        private void rbfacturaspanish_CheckedChanged(object sender, EventArgs e)
        {
            if (rbfacturaspanish.Checked == true)
            {
                rbfacturaspanish.ForeColor = Color.LimeGreen;
                rbfacturaenglish.ForeColor = Color.DarkRed;
            }
            else
            {
                rbfacturaspanish.ForeColor = Color.DarkRed;
                rbfacturaenglish.ForeColor = Color.DarkRed;
            }
        }

        private void rbfacturaenglish_CheckedChanged(object sender, EventArgs e)
        {
            if (rbfacturaenglish.Checked == true)
            {
                rbfacturaspanish.ForeColor = Color.DarkRed;
                rbfacturaenglish.ForeColor = Color.LimeGreen;
            }
            else
            {
                rbfacturaspanish.ForeColor = Color.DarkRed;
                rbfacturaenglish.ForeColor = Color.DarkRed;
            }
        }

        private void cbFacturaPuntoVenta_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFacturaPuntoVenta.Checked == true)
            {
                cbFacturaPuntoVenta.ForeColor = Color.LimeGreen;
            }
            else
            {
                cbFacturaPuntoVenta.ForeColor = Color.DarkRed;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
        }

        private void PCerrar_Click_1(object sender, EventArgs e)
        {
            DevolverProductosInventario(VariablesGlobales.NumeroConector);
            this.Dispose();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            btnAgregarAlmacen.Visible = true;
            btnRegresar.Visible = false;
            DesbloquearControles();
            LimpiarControles();
        }

        private void btnAgregarAlmacen_Click(object sender, EventArgs e)
        {
            BuscarPorRNC();



           
        }

        private void btnBuscarCotizacion_Click(object sender, EventArgs e)
        {
            btnBuscarCotizacion.Visible = false;
            btnRefresarCotizacion.Visible = true;
        }

        private void btnRefresarCotizacion_Click(object sender, EventArgs e)
        {
            btnBuscarCotizacion.Visible = true;
            btnRefresarCotizacion.Visible = false;
        }

        private void cbBuscarPorCodigo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBuscarPorCodigo.Checked == true)
            {
                btnBuscarCodigoCliente.Visible = true;
                txtCodigoConsulta.Visible = true;
                txtCodigoConsulta.Text = string.Empty;
                txtCodigoConsulta.Focus();
                cbBuscarPorCodigo.ForeColor = Color.LimeGreen;
            }
            else
            {
                btnBuscarCodigoCliente.Visible = false;
                txtCodigoConsulta.Visible = false;
                cbBuscarPorCodigo.ForeColor = Color.DarkRed;
            }
        }

        private void btnBuscarCodigoCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigoConsulta.Text.Trim()))
            {
                MessageBox.Show("No puedes dejar el campo codigo vacio para buscar un registro", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigoConsulta.Focus();
            }
            else {
                //BUSCAMOS EL REGISTRO
                var Buscarregistro = ObjDataEmpresa.Value.BuscaClientes(
                    Convert.ToDecimal(txtCodigoConsulta.Text),
                    null, null, null, null, 1, 1);
                if (Buscarregistro.Count() < 1)
                {
                    MessageBox.Show("El Codigo de cliente ingresado no es valido, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCodigoConsulta.Text = string.Empty;
                    txtCodigoConsulta.Focus();
                }
                else {
                    foreach (var n in Buscarregistro) {
                        bool usoComprobante = false;

                        var ValidarUsoCOmprobante = ObjDataConfiguracion.Value.BuscaCOnfiguracionGeneral(1);
                        foreach (var n2 in ValidarUsoCOmprobante) {
                            usoComprobante = Convert.ToBoolean(n2.Estatus0);
                        }

                        if (usoComprobante == true) {
                            ddlTipoFacturacion.Text = n.Comprobante;
                        }

                        decimal Credito = Convert.ToDecimal(n.MontoCredito);
                        lbMontoCredito.Text = Credito.ToString("N2");
                        txtNombrePaciente.Text = n.Nombre;
                        txtTelefono.Text = n.Telefono;
                        txtEmail.Text = n.Email;
                        ddlTipoIdentificacion.Text = n.TipoIdentificacion;
                        txtIdentificacion.Text = n.RNC;
                        txtDireccion.Text = n.Direccion;
                        txtComentario.Text = n.Comentario;
                        BloquearControles();
                    }
                }
            }
        }

        private void ddlTipoVenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                int IdTipoVenta = Convert.ToInt32(ddlTipoVenta.SelectedValue);
                if (IdTipoVenta != 1)
                {
                    lbCantidadDias.Visible = true;
                    ddlCantidadDias.Visible = true;
                    lbCredito.Visible = true;
                    lbMontoCredito.Visible = true;
                    ListadoCantidadDias();
                }
                else {
                    lbCantidadDias.Visible = false;
                    ddlCantidadDias.Visible = false;
                    lbCredito.Visible = false;
                    lbMontoCredito.Visible = false;
                }
            }
            catch (Exception) { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Quieres Minimizar este proceso?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                VariablesGlobales.SecuencialFActuraMinimizada = 0;
                MANFacturasMinimizadas("INSERT");
                LimpiarControles();
                ListadoFacturaMinimizadas();
                //GENERAMOS NUEVAMENTE UN NUEMERO DE CONECTOR
                GenerarNumeroConector();
                dtProductosAgregados.DataSource = null;
                txtCantidadArtiuclos.Text = "0";
                txtCantidadServicios.Text = "0";
                txtTotalServicios.Text = "0";
                txtTotalDescuento.Text = "0";
                txtSubtotal.Text = "0";
                txtImpuesto.Text = "0";
             //   txtPorcientoImpuesto.Text = "0";
                txtTotal.Text = "0";
            }

        }

        private void dtFacturasMinimizadas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            decimal NumeroConector = Convert.ToDecimal(dtFacturasMinimizadas.CurrentRow.Cells["NumeroConector"].Value.ToString());
            VariablesGlobales.NumeroConector = Convert.ToDecimal(dtFacturasMinimizadas.CurrentRow.Cells["NumeroConector"].Value.ToString());
            VariablesGlobales.SecuencialFActuraMinimizada = Convert.ToDecimal(dtFacturasMinimizadas.CurrentRow.Cells["Secuencia"].Value.ToString());

            if (cbEliminarfacturaMinimizada.Checked == true)
            {
                if (MessageBox.Show("¿Quieres elimianr esta factura?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //SACAMOS LOS DATOS A VALIDAR
                    DevolverProductosInventario(NumeroConector);
                    MANFacturasMinimizadas("DELETE");
                    ListadoFacturaMinimizadas();
                    VariablesGlobales.NumeroConector = Convert.ToDecimal(lbNumeroConector.Text);
                }
            }
            else {
                if (MessageBox.Show("¿Quieres restaurar este registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SacarDataFacturaMinimizadas();
                    MANFacturasMinimizadas("DELETE");
                    ListadoFacturaMinimizadas();
                    BuscarProductosAgregados(VariablesGlobales.NumeroConector);
                }
            }
        }

        private void txtCodigoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) {
                BuscarPorRNC();
            }
        }

        private void ddltIPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                bool BloqueaMonto = false;
                var TipoPago = ObjDataListas.Value.BuscaTipoPago(
                Convert.ToDecimal(ddltIPago.SelectedValue));
                foreach (var n in TipoPago) {
                    BloqueaMonto = Convert.ToBoolean(n.BloqueaMonto);
                }
                if (BloqueaMonto == true)
                {
                    txtMontoPagar.Enabled = false;
                    txtMontoPagar.Text = txtTotal.Text;
                }
                else {
                    txtMontoPagar.Enabled = true;
                    txtMontoPagar.Text = string.Empty;
                }
            }
            catch (Exception) { }
        }

        private void cbEliminarfacturaMinimizada_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnARS_Click(object sender, EventArgs e)
        {
            //VERIFICAMOS SI HAY PRODUCTOS AGREGADOS A FACTURA
            var ValidarProductos = ObjDataServicio.Value.BuscapRoductosAgregados(
                new Nullable<decimal>(),
                VariablesGlobales.NumeroConector);
            if (ValidarProductos.Count() < 1) {
                MessageBox.Show("No es posible completar esta operación por que no nay nada agregado para facturar, decea agregar registros?", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (MessageBox.Show("¿Quieres agregar registros?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                    AgregarRegistros();
                }
            }
            else {
                if (rbFacturar.Checked == true)
                {
                    //FACTURAMOS
                    //VALIDAMOS EL TIPO DE VENTA
                    int TipoVenta = Convert.ToInt32(ddlTipoVenta.SelectedValue);
                    if (TipoVenta == 1)
                    {
                        //venta a contado
                        //validamos el tipo de pago
                        bool BloqueaControles = false;
                        var ValidarTipoPago = ObjDataListas.Value.BuscaTipoPago(
                            Convert.ToDecimal(ddltIPago.SelectedValue));
                        foreach (var n in ValidarTipoPago)
                        {
                            BloqueaControles = Convert.ToBoolean(n.BloqueaMonto);
                        }

                        if (BloqueaControles == true)
                        {
                            GuardarDatosClientes("INSERT");
                            GuardarDatosCalculos("INSERT");
                            AfectarComprobanteFiscal();
                            AfectarCaja();
                  
                            MessageBox.Show("Operación realizada con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            GenerarFacturaVenta();
                            this.Dispose();

                        }
                        else if (BloqueaControles == false)
                        {
                            //VALIDAMOS SI EL CAMPO ESTA VACIO
                            if (string.IsNullOrEmpty(txtMontoPagar.Text.Trim()))
                            {
                                MessageBox.Show("El campo monto no puede estar vacio para realizar esta operación", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                decimal MontoPagar = Convert.ToDecimal(txtMontoPagar.Text);
                                decimal MontoTotal = Convert.ToDecimal(txtTotal.Text);
                                if (MontoTotal > MontoPagar)
                                {
                                    MessageBox.Show("El monto ingresado es menor al monto a pagar, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else
                                {
                                    GuardarDatosClientes("INSERT");
                                    GuardarDatosCalculos("INSERT");
                                    AfectarComprobanteFiscal();
                                    AfectarCaja();
                                   
                                    MessageBox.Show("Operación realizada con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    GenerarFacturaVenta();
                                    this.Dispose();

                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error al Facturar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else if (TipoVenta == 2)
                    {
                        //venta a credito
                    }
                    else { MessageBox.Show("Error al Facturar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else if (rbCotizar.Checked == true)
                {
                    //COTIZAMOS
                    ProcesoCotizar(VariablesGlobales.NumeroConector);
                    GuardarDatosClientes("INSERT");
                    GuardarDatosCalculos("INSERT");

                    MessageBox.Show("Operación realizada con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GenerarFacturaVenta();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Error al Facturar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
        }

        private void txtMontoPagar_TextChanged(object sender, EventArgs e)
        {
            CalcularCambio();
        }
    }
}
