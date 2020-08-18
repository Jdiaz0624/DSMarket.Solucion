using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSMarket.Solucion.Pantallas.Pantallas.Empresa
{
    public partial class MantenimientoCompraSuplidores : Form
    {
        public MantenimientoCompraSuplidores()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaListas.LogicaListas> ObjDataListas = new Lazy<Logica.Logica.LogicaListas.LogicaListas>();
        Lazy<DSMarket.Logica.Logica.LogicaEmpresa.LogicaEmpresa> ObjDataEmpresa = new Lazy<Logica.Logica.LogicaEmpresa.LogicaEmpresa>();
        Lazy<DSMarket.Logica.Logica.LogicaSeguridad.LogicaSeguridad> ObjDataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad.LogicaSeguridad>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region MOSTRAR EL LISTADO DE LOS TIPO DE SUPLIDORES
        private void ListadoTipoSuplidores() {
            var TipoSuplidor = ObjDataListas.Value.BuscaListaTipoSuplidor();
            ddlSeleccionarTipoSuplidor.DataSource = TipoSuplidor;
            ddlSeleccionarTipoSuplidor.DisplayMember = "Descripcion";
            ddlSeleccionarTipoSuplidor.ValueMember = "IdTipoSuplidor";
        }
        #endregion
        #region MOSTRAR EL LISTADO DE LOS SUPLIDORES
        private void MostrarSuplidores() {
            var ListadoSuplidores = ObjDataListas.Value.BuscaListaSuplidores(
                Convert.ToDecimal(ddlSeleccionarTipoSuplidor.SelectedValue));
            ddlSeleccionarSuplidores.DataSource = ListadoSuplidores;
            ddlSeleccionarSuplidores.DisplayMember = "Nombre";
            ddlSeleccionarSuplidores.ValueMember = "IdSuplidor";
        }
        #endregion
        #region MOSTRAR LOS TIPOS DE IDENTIFICACION
        private void MostrarTipoIdentificacion() {
            var MostrarTipoIdentificacio = ObjDataListas.Value.BuscaTipoIdentificacion();
            ddlseleccionarTipoIdentificacion.DataSource = MostrarTipoIdentificacio;
            ddlseleccionarTipoIdentificacion.DisplayMember = "TipoIdentificacion";
            ddlseleccionarTipoIdentificacion.ValueMember = "IdTipoIdentificacion";
        }
        #endregion
        #region MOSTRAR LISTADO DE LOS BIENES Y SERVICIOS
        private void ListadoBienesServicios() {
            var BienesServicios = ObjDataListas.Value.ListadoBienesServicios();
            ddlSeleccionarTipoBienesServicios.DataSource = BienesServicios;
            ddlSeleccionarTipoBienesServicios.DisplayMember = "Descripcion";
            ddlSeleccionarTipoBienesServicios.ValueMember = "IdTipoBienesServicio";
        }
        #endregion
        #region MOSTRAR LISTADO DE LOS TIPOS DE RETENCION A ISR
        public void ListadoRetencionISR() {
            var Listado = ObjDataListas.Value.BuscaTipoRetencionISR();
            ddlSeleccionarTipoRetencionISR.DataSource = Listado;
            ddlSeleccionarTipoRetencionISR.DisplayMember = "Descripcion";
            ddlSeleccionarTipoRetencionISR.ValueMember = "IdTipoRetencionISR";
        }
        #endregion
        #region MOSTRAR LAS FORMAS DE PAGOS
        private void MostrarFormaPagos() {
            var Listado = ObjDataListas.Value.BuscaTipoPago(
                new Nullable<decimal>());
            ddlSeleccionarFormaPAgo.DataSource = Listado;
            ddlSeleccionarFormaPAgo.ValueMember = "IdTipoPago";
            ddlSeleccionarFormaPAgo.DisplayMember = "TipoPago";
        }
        #endregion
        #region CALCULAR EL TOTAL MONTO FACTURADO
        private void CalcularTotalMontoFacturado()
        {
            try {

                decimal MontoFacturadoServicios = 0, MontoFacturadoBienes = 0, TotalMontoFacturado = 0;
                if (string.IsNullOrEmpty(txtMontoFActuradoServicios.Text.Trim()))
                {
                    MontoFacturadoServicios = 0;
                }
                if (string.IsNullOrEmpty(txtMontoFacturadoBienes.Text.Trim()))
                {
                    MontoFacturadoBienes = 0;
                }

                MontoFacturadoServicios = Convert.ToDecimal(txtMontoFActuradoServicios.Text);
                MontoFacturadoBienes = Convert.ToDecimal(txtMontoFacturadoBienes.Text);
              

                TotalMontoFacturado = MontoFacturadoServicios + MontoFacturadoBienes;
                txtTotalMontoFacturado.Text = TotalMontoFacturado.ToString("N2");






            }
            catch (Exception) {
            }
        }
        #endregion
        #region CERRAR Y RESTABLECER PANTALLA
        private void CerrarPantalla() {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.CompraSuplidores Consulta = new CompraSuplidores();
            Consulta.Variableslobales.IdUsuario = VariablesGlobales.IdUsuario;
            Consulta.ShowDialog();
        }
        private void RestablecerPantalla() {
            ListadoTipoSuplidores();
            MostrarSuplidores();
            MostrarTipoIdentificacion();
            ListadoBienesServicios();
            ListadoRetencionISR();
            MostrarFormaPagos();
            CalcularTotalMontoFacturado();

            txtImpuestoSelecticoConsumo.Text = "0";
            txtISRRecibidoCompras.Text = "0";
            txtITBISAdelantar.Text = "0";
            txtITBISFacturado.Text = "0";
            txtITBISLlevadoCosto.Text = "0";
            txtITBISPercibidoCompras.Text = "0";
            txtITBISRetenido.Text = "0";
            txtITBISSujeto.Text = "0";
            txtMontoFacturadoBienes.Text = "0";
            txtMontoFActuradoServicios.Text = "0";
            txtMontoPropinaLegal.Text = "0";
            txtMontoRetencionCompras.Text = "0";
            txtMontoRetencionVenta.Text = "0";
            txtNCF.Text = "";
            txtNCFModificado.Text = "";
            txtRNCCedula.Text = "";
            txtTotalMontoFacturado.Text = "0";
            txtFechaComprobante.Text = DateTime.Now.ToString();
            txtFechaPago.Text= DateTime.Now.ToString();

        }
        #endregion
        #region MANTENIMIENTO DE COMPRA A SUPLIDORES
        private void MANCOmpraSuplidores(string Accion ) {
            DSMarket.Logica.Comunes.ProcesarInformacionCompraSuplidores Procesar = new Logica.Comunes.ProcesarInformacionCompraSuplidores(
                VariablesGlobales.IdMantenimeinto,
                Convert.ToDecimal(ddlSeleccionarTipoSuplidor.SelectedValue),
                Convert.ToDecimal(ddlSeleccionarSuplidores.SelectedValue),
                txtRNCCedula.Text,
                Convert.ToDecimal(ddlseleccionarTipoIdentificacion.SelectedValue),
                Convert.ToDecimal(ddlSeleccionarTipoBienesServicios.SelectedValue),
                txtNCF.Text,
                txtNCFModificado.Text,
                Convert.ToDateTime(txtFechaComprobante.Text),
                Convert.ToDateTime(txtFechaPago.Text),
                Convert.ToDecimal(txtMontoFActuradoServicios.Text),
                Convert.ToDecimal(txtMontoFacturadoBienes.Text),
                Convert.ToDecimal(txtTotalMontoFacturado.Text),
                Convert.ToDecimal(txtITBISFacturado.Text),
                Convert.ToDecimal(txtITBISRetenido.Text),
                Convert.ToDecimal(txtITBISSujeto.Text),
                Convert.ToDecimal(txtITBISLlevadoCosto.Text),
                Convert.ToDecimal(txtITBISAdelantar.Text),
                Convert.ToDecimal(txtISRRecibidoCompras.Text),
                Convert.ToDecimal(ddlSeleccionarTipoRetencionISR.SelectedValue),
                Convert.ToDecimal(txtMontoRetencionVenta.Text),
                Convert.ToDecimal(txtITBISPercibidoCompras.Text),
                Convert.ToDecimal(txtImpuestoSelecticoConsumo.Text),
                Convert.ToDecimal(OtrosImpuestosTasa.Text),
                Convert.ToDecimal(txtMontoPropinaLegal.Text),
                Convert.ToDecimal(ddlSeleccionarFormaPAgo.SelectedValue),
                VariablesGlobales.IdUsuario,
                DateTime.Now,
                Accion);
            Procesar.PrcesarInformacion();
            if (VariablesGlobales.Accion == "INSERT") {
                MessageBox.Show("Registro guardado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (MessageBox.Show("¿Quieres guardar otro registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    RestablecerPantalla();
                }
                else {
                    CerrarPantalla();
                }
            }
            else if (VariablesGlobales.Accion == "UPDATE") {
                MessageBox.Show("Registro modificado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                CerrarPantalla();
            }
            else if (VariablesGlobales.Accion == "DELETE") {
                MessageBox.Show("Registro eliminado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                CerrarPantalla();
            }
        }
        #endregion
      
        private void MantenimientoCompraSuplidores_Load(object sender, EventArgs e)
        {
            lbTitulo.Text = "REGISTRO DE COMPRA A SUPLIDORES";
            lbTitulo.ForeColor = Color.White;
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            ListadoTipoSuplidores();
            MostrarSuplidores();
            MostrarTipoIdentificacion();
            ListadoBienesServicios();
            ListadoRetencionISR();
            MostrarFormaPagos();
            CalcularTotalMontoFacturado();

            if (VariablesGlobales.Accion != "INSERT") {
                //SACAMOS LOS DATOS DEL PRODUCTO SELECCIONADO
                var BuscarRegistros = ObjDataEmpresa.Value.BuscaCompraSuplidores(
                    VariablesGlobales.IdMantenimeinto,
                    null, null, null, null, null, 1, 1);
                foreach (var n in BuscarRegistros) {
                    ddlSeleccionarTipoSuplidor.Text = n.TipoSuplidor;
                    ddlSeleccionarSuplidores.Text = n.Suplidor;
                    txtRNCCedula.Text = n.RNCCedula;
                    ddlseleccionarTipoIdentificacion.Text = n.TipoIdentificacion;
                    txtFechaComprobante.Text = n.FechaComprobante0.ToString();
                    txtFechaPago.Text = n.FechaPago0.ToString();
                    txtMontoFActuradoServicios.Text = n.MontoFacturadoServicios.ToString();
                    txtMontoFacturadoBienes.Text = n.MontoFacturadoBienes.ToString();
                    txtTotalMontoFacturado.Text = n.TotalMontoFacturado.ToString();
                    txtITBISFacturado.Text = n.ITBISFacturado.ToString();
                    txtITBISRetenido.Text = n.ITBISRetenido.ToString();
                    txtITBISSujeto.Text = n.ITBISSujetoProporcionalidad.ToString();
                    txtITBISLlevadoCosto.Text = n.ITBISLlevadoCosto.ToString();
                    ddlSeleccionarTipoRetencionISR.Text = n.TipoRetencionISR;
                    txtITBISAdelantar.Text = n.ITBISPorAdelantar.ToString();
                    txtITBISPercibidoCompras.Text = n.ITBISPercibidoCompras.ToString();
                    txtImpuestoSelecticoConsumo.Text = n.ImpuestoSelectivoConsumo.ToString();
                    txtISRRecibidoCompras.Text = n.ISRPercibidoCompras.ToString();
                    OtrosImpuestosTasa.Text = n.OtrosImpuestosTasa.ToString();
                    txtMontoPropinaLegal.Text = n.MontoPropinaLegal.ToString();
                    ddlSeleccionarFormaPAgo.Text = n.FormaPago;

                    lbCLaveSeguriad.Visible = true;
                    txtClaveSeguridad.Visible = true;

                    if (VariablesGlobales.Accion == "DELETE") {
                        ddlSeleccionarTipoSuplidor.Enabled = false;
                        ddlSeleccionarSuplidores.Enabled = false;
                        txtRNCCedula.Enabled = false;
                        ddlseleccionarTipoIdentificacion.Enabled = false;
                        txtFechaComprobante.Enabled = false;
                        txtFechaPago.Enabled = false;
                        txtMontoFActuradoServicios.Enabled = false;
                        txtMontoFacturadoBienes.Enabled = false;
                        txtTotalMontoFacturado.Enabled = false;
                        txtITBISFacturado.Enabled = false;
                        txtITBISRetenido.Enabled = false;
                        txtITBISSujeto.Enabled = false;
                        txtITBISLlevadoCosto.Enabled = false;
                        ddlSeleccionarTipoRetencionISR.Enabled = false;
                        txtITBISAdelantar.Enabled = false;
                        txtITBISPercibidoCompras.Enabled = false;
                        txtImpuestoSelecticoConsumo.Enabled = false;
                        txtISRRecibidoCompras.Enabled = false;
                        OtrosImpuestosTasa.Enabled = false;
                        txtMontoPropinaLegal.Enabled = false;
                        ddlSeleccionarFormaPAgo.Enabled = false;
                        txtNCF.Enabled = false;
                        txtNCFModificado.Enabled = false;
                        txtMontoRetencionVenta.Enabled = false;
                        txtMontoRetencionCompras.Enabled = false;
                    }
                }
            }
        }

        private void ddlSeleccionarTipoSuplidor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                ListadoTipoSuplidores();
            }
            catch (Exception) { }
        }

        private void txtMontoPropinaLegal_KeyPress(object sender, KeyPressEventArgs e)
        {
            DSMarket.Logica.Comunes.ValidarControles.SoloNumerosDecimales(e);
        }

        private void txtMontoFActuradoServicios_TextChanged(object sender, EventArgs e)
        {
            CalcularTotalMontoFacturado();
        }

        private void txtMontoFacturadoBienes_TextChanged(object sender, EventArgs e)
        {
            CalcularTotalMontoFacturado();
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            CerrarPantalla();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
           
            if (VariablesGlobales.Accion != "INSERT")
            {
                if (string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim())) {
                    MessageBox.Show("El campo clave de seguridad no puede estar vacio, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()))
                    {
                        errorProvider1.SetError(txtClaveSeguridad, "Campo Vacio");
                    }
                   
                }
                else
                {
                    //VALIDAMOS
                    string _ClaveSeguridad = string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()) ? null : txtClaveSeguridad.Text.Trim();

                    var Validar = ObjDataSeguridad.Value.BuscaClaveSeguridad(
                        new Nullable<decimal>(),
                        null,
                        DSMarket.Logica.Comunes.SeguridadEncriptacion.Encriptar(_ClaveSeguridad),
                        1, 1);
                    if (Validar.Count() < 1)
                    {
                        MessageBox.Show("La clave de seguridad ingresada no es valida, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtClaveSeguridad.Text = string.Empty;
                        txtClaveSeguridad.Focus();
                    }
                    else
                    {
                        CalcularTotalMontoFacturado();
                        MANCOmpraSuplidores(VariablesGlobales.Accion);
                    }
                }
            }
            else {
                CalcularTotalMontoFacturado();
                MANCOmpraSuplidores(VariablesGlobales.Accion);
            }
        }
    }
}
