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
    }
}
