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
        private void Facturacion_Load(object sender, EventArgs e)
        {
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            MostrarComprobantesFiscales();
            MostrarTipoIdentificacion();
            MostrarListadoTipoVenta();
            TemaGenerico();
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
    }
}
