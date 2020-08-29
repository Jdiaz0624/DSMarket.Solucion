using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSMarket.Solucion.Pantallas.Pantallas.Contabilidad
{
    public partial class CatalogoCuentasMantenimiento : Form 
    {
        public CatalogoCuentasMantenimiento()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaListas.LogicaListas> ObjDataListas = new Lazy<Logica.Logica.LogicaListas.LogicaListas>();
        Lazy<DSMarket.Logica.Logica.LogicaContabilidad.LogicaContabilidad> ObjDataContabilidad = new Lazy<Logica.Logica.LogicaContabilidad.LogicaContabilidad>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region CARGAR LOS LISTADOS
        private void CargarClases() {
            var Clases = ObjDataListas.Value.BuscaClasesCuentasContables();
            ddlSeleccionarClase.DataSource = Clases;
            ddlSeleccionarClase.DisplayMember = "Descripcion";
            ddlSeleccionarClase.ValueMember = "IdClaseCuenta";
        }
        private void CargarOrigenes() {
            var Origenes = ObjDataListas.Value.BuscaOrigenesCuentasCOntables();
            ddlSeleccionarOrigen.DataSource = Origenes;
            ddlSeleccionarOrigen.DisplayMember = "Descripcion";
            ddlSeleccionarOrigen.ValueMember = "IdOrigenCuenta";
        }
        private void CargarTipos() {
            var TiposCuentas = ObjDataListas.Value.BuscaTiposCuentasContables();
            ddlSeleccionarTipo.DataSource = TiposCuentas;
            ddlSeleccionarTipo.ValueMember = "IdTipoCuentas";
            ddlSeleccionarTipo.DisplayMember = "Descripcion";
        }
        private void CargarMovimientos() {
            var AceptaMovimiento = ObjDataListas.Value.BuscaAceptaMovimientoSCuentasCotables();
            ddlSeleccionarMovimiento.DataSource = AceptaMovimiento;
            ddlSeleccionarMovimiento.DisplayMember = "Descripcion";
            ddlSeleccionarMovimiento.ValueMember = "IdMovimientoCuenta";
        }
        #endregion

        private void CatalogoCuentasMantenimiento_Load(object sender, EventArgs e)
        {
            CargarClases();
            CargarOrigenes();
            CargarTipos();
            CargarMovimientos();
        }
    }
}
