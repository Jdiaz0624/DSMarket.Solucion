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
            txtPorcientoImpuesto.BackColor = Color.WhiteSmoke;
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
            txtPorcientoImpuesto.ForeColor = Color.Black;
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

            LimpiarControles();

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
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Servicio.AgregarProductos AddProducts = new AgregarProductos();
            AddProducts.VariablesGlbales.IdUsuario = VariablesGlobales.IdUsuario;
            AddProducts.VariablesGlbales.GenerarConector = VariablesGlobales.GenerarConector;
            AddProducts.ShowDialog();
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
        }

        private void btnAgregarAlmacen_Click(object sender, EventArgs e)
        {
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
            }

        }

        private void dtFacturasMinimizadas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (cbEliminarfacturaMinimizada.Checked == true)
            {
                if (MessageBox.Show("¿Quieres elimianr esta factura?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //SACAMOS LOS DATOS A VALIDAR
                    VariablesGlobales.NumeroConector = Convert.ToDecimal(dtFacturasMinimizadas.CurrentRow.Cells["NumeroConector"].Value.ToString());
                    VariablesGlobales.SecuencialFActuraMinimizada = Convert.ToDecimal(dtFacturasMinimizadas.CurrentRow.Cells["Secuencia"].Value.ToString());
                    MANFacturasMinimizadas("DELETE");
                    ListadoFacturaMinimizadas();
                    VariablesGlobales.NumeroConector = Convert.ToDecimal(lbNumeroConector.Text);
                }
            }
            else {

            }
        }
    }
}
