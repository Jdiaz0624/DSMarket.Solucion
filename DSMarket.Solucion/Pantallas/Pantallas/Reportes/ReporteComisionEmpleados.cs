using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSMarket.Solucion.Pantallas.Pantallas.Reportes
{
    public partial class ReporteComisionEmpleados : Form
    {
        Lazy<DSMarket.Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion> ObjDataCpmfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion>();
        Lazy<DSMarket.Logica.Logica.LogicaEmpresa.LogicaEmpresa> ObjdataEmpresa = new Lazy<Logica.Logica.LogicaEmpresa.LogicaEmpresa>();
        Lazy<DSMarket.Logica.Logica.LogicaServicio.LogicaServicio> ObjDataServicio = new Lazy<Logica.Logica.LogicaServicio.LogicaServicio>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlbales = new Logica.Comunes.VariablesGlobales();

        #region BUSCAR EMPLEADOS
        private void BuscarEmpleados() {
            string _Empleado = string.IsNullOrEmpty(txtnombreEmpleado.Text.Trim()) ? null : txtnombreEmpleado.Text.Trim();

            var Buscar = ObjdataEmpresa.Value.BuscaEmpleados(
                new Nullable<decimal>(),
                _Empleado,
                null, null, null, null, null,
                Convert.ToInt32(txtNumeroPagina.Value),
                Convert.ToInt32(txtNumeroRegistros.Value));
            dtListado.DataSource = Buscar;

            this.dtListado.Columns["IdEmpleado"].Visible = false;
            this.dtListado.Columns["Nombre"].Visible = false;
            this.dtListado.Columns["Apellido"].Visible = false;
            this.dtListado.Columns["IdTipoIdentificacion"].Visible = false;
            this.dtListado.Columns["IdNacionalidad"].Visible = false;
            this.dtListado.Columns["IdTipoEmpleado"].Visible = false;
            this.dtListado.Columns["IdTioNomina"].Visible = false;
            this.dtListado.Columns["IdDepartamento"].Visible = false;
            this.dtListado.Columns["IdCargo"].Visible = false;
            this.dtListado.Columns["IdEstadoCivil"].Visible = false;
            this.dtListado.Columns["IdFormaPago"].Visible = false;
            this.dtListado.Columns["FechaIngreso0"].Visible = false;
            this.dtListado.Columns["FechaNacimiento0"].Visible = false;
            this.dtListado.Columns["Estatus0"].Visible = false;
            this.dtListado.Columns["AplicaParaComision0"].Visible = false;
            this.dtListado.Columns["CantidadRegistros"].Visible = false;
            this.dtListado.Columns["CantidadActivos"].Visible = false;
            this.dtListado.Columns["CantidadInactivos"].Visible = false;

            this.dtListado.Columns["TipoIdentificacion"].Visible = false;
            this.dtListado.Columns["NumeroIdentificacion"].Visible = false;
            this.dtListado.Columns["NAcionalidad"].Visible = false;
            this.dtListado.Columns["NSS"].Visible = false;
            this.dtListado.Columns["Direccion"].Visible = false;
            this.dtListado.Columns["TipoEmpleado"].Visible = false;
            this.dtListado.Columns["TipoNomina"].Visible = false;
            this.dtListado.Columns["Departamento"].Visible = false;
            this.dtListado.Columns["Cargo"].Visible = false;
            this.dtListado.Columns["Telefono1"].Visible = false;
            this.dtListado.Columns["Telefono2"].Visible = false;
            this.dtListado.Columns["Email"].Visible = false;
            this.dtListado.Columns["EstadoCivil"].Visible = false;
            this.dtListado.Columns["Sueldo"].Visible = false;
            this.dtListado.Columns["OtrosIngresos"].Visible = false;
            this.dtListado.Columns["FormaPago"].Visible = false;
            this.dtListado.Columns["FechaIngreso"].Visible = false;
            this.dtListado.Columns["FechaNacimiento"].Visible = false;
            this.dtListado.Columns["Estatus"].Visible = false;
            this.dtListado.Columns["AplicaParaComision"].Visible = false;
            this.dtListado.Columns["PorcientoCOmisionVentas"].Visible = false;
            this.dtListado.Columns["PorcientoComsiionServicio"].Visible = false;
        }
        #endregion
        public ReporteComisionEmpleados()
        {
            InitializeComponent();
        }

        private void ReporteComisionEmpleados_Load(object sender, EventArgs e)
        {
            lbTitulo.Text = "GENERAR COMISIONES DE EMPLEADOS";
            lbTitulo.ForeColor = Color.White;
            VariablesGlbales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
        }

        private void TxtnombreEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) {
                BuscarEmpleados();
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            BuscarEmpleados();
        }

        private void TxtNumeroPagina_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroPagina.Value < 1) {
                txtNumeroPagina.Value = 1;
                BuscarEmpleados();
            }
            else {
                BuscarEmpleados();
            }
        }

        private void TxtNumeroRegistros_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroRegistros.Value < 1) {
                txtNumeroRegistros.Value = 10;
                BuscarEmpleados();
            }
            else {
                BuscarEmpleados();
            }
        }

        private void DtListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.VariablesGlbales.IdMantenimeinto = Convert.ToDecimal(this.dtListado.CurrentRow.Cells["IdEmpleado"].Value.ToString());
            //ELIMINAMOS LOS DATOS DEL USUARIO EN LA COMISIONES
            DSMarket.Logica.Comunes.ProcesarInformacion.Configuracion.ProcesarInformacionDatosreporteEmpleados Eliminar = new Logica.Comunes.ProcesarInformacion.Configuracion.ProcesarInformacionDatosreporteEmpleados(
                VariablesGlbales.IdUsuario, 0, 0, 0, 0, 0, 0, 0, 0, 0, DateTime.Now, false, DateTime.Now, DateTime.Now, "DELETE");
            Eliminar.ProcesarInformacionDatosComisiones();

            //BUSCMAOS LOS DATOS DE LAS COMISIONE SY GENERAMOS EL REPORTE
            var BuscarRegistros = ObjDataServicio.Value.BuscaComisionesEmpleado(
                new Nullable<decimal>(),
                VariablesGlbales.IdMantenimeinto, null,
                Convert.ToDateTime(txtFechaDesde.Text),
                Convert.ToDateTime(txtFechaHasta.Text),
                true, null, null, null, 1, 999999999);
            foreach (var n in BuscarRegistros)
            {
                DSMarket.Logica.Comunes.ProcesarInformacion.Configuracion.ProcesarInformacionDatosreporteEmpleados Guardar = new Logica.Comunes.ProcesarInformacion.Configuracion.ProcesarInformacionDatosreporteEmpleados(
                    VariablesGlbales.IdUsuario,
                    Convert.ToDecimal(n.IdRegistro),
                    Convert.ToDecimal(n.IdEmpleado),
                    Convert.ToDecimal(n.IdTipoProducto),
                    Convert.ToDecimal(n.PrecioProducto),
                    Convert.ToDecimal(n.DescuentoAplicado),
                    Convert.ToDecimal(n.ComisionEmpleado),
                    Convert.ToDecimal(n.NumeroConectorOperacion),
                    Convert.ToDecimal(n.IdProducto),
                    Convert.ToDecimal(n.ConectorProducto),
                    Convert.ToDateTime(n.Fecha),
                    Convert.ToBoolean(n.Estatus0),
                    Convert.ToDateTime(txtFechaDesde.Text),
                    Convert.ToDateTime(txtFechaHasta.Text),
                    "INSERT");
                Guardar.ProcesarInformacionDatosComisiones();
            }
            DSMarket.Solucion.Pantallas.Pantallas.Reportes.Reportes reporte = new Reportes();
            reporte.GenerarReporteComisionEmpleados(VariablesGlbales.IdUsuario);
            reporte.ShowDialog();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            //ELIMINAMOS LOS DATOS DEL USUARIO EN LA COMISIONES
            DSMarket.Logica.Comunes.ProcesarInformacion.Configuracion.ProcesarInformacionDatosreporteEmpleados Eliminar = new Logica.Comunes.ProcesarInformacion.Configuracion.ProcesarInformacionDatosreporteEmpleados(
                VariablesGlbales.IdUsuario, 0, 0, 0, 0, 0, 0, 0, 0, 0, DateTime.Now, false, DateTime.Now, DateTime.Now, "DELETE");
            Eliminar.ProcesarInformacionDatosComisiones();

            //BUSCMAOS LOS DATOS DE LAS COMISIONE SY GENERAMOS EL REPORTE
            var BuscarRegistros = ObjDataServicio.Value.BuscaComisionesEmpleado(
                new Nullable<decimal>(),
                null, null,
                Convert.ToDateTime(txtFechaDesde.Text),
                Convert.ToDateTime(txtFechaHasta.Text),
                true, null, null, null, 1, 999999999);
            foreach (var n in BuscarRegistros) {
                DSMarket.Logica.Comunes.ProcesarInformacion.Configuracion.ProcesarInformacionDatosreporteEmpleados Guardar = new Logica.Comunes.ProcesarInformacion.Configuracion.ProcesarInformacionDatosreporteEmpleados(
                    VariablesGlbales.IdUsuario,
                    Convert.ToDecimal(n.IdRegistro),
                    Convert.ToDecimal(n.IdEmpleado),
                    Convert.ToDecimal(n.IdTipoProducto),
                    Convert.ToDecimal(n.PrecioProducto),
                    Convert.ToDecimal(n.DescuentoAplicado),
                    Convert.ToDecimal(n.ComisionEmpleado),
                    Convert.ToDecimal(n.NumeroConectorOperacion),
                    Convert.ToDecimal(n.IdProducto),
                    Convert.ToDecimal(n.ConectorProducto),
                    Convert.ToDateTime(n.Fecha),
                    Convert.ToBoolean(n.Estatus0),
                    Convert.ToDateTime(txtFechaDesde.Text),
                    Convert.ToDateTime(txtFechaHasta.Text),
                    "INSERT");
                Guardar.ProcesarInformacionDatosComisiones();
            }
            DSMarket.Solucion.Pantallas.Pantallas.Reportes.Reportes reporte = new Reportes();
            reporte.GenerarReporteComisionEmpleados(VariablesGlbales.IdUsuario);
            reporte.ShowDialog();
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ReporteComisionEmpleados_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason) {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }

        }
    }
}
