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
    public partial class ProgramacionCitas : Form
    {
        Lazy<DSMarket.Logica.Logica.LogicaEmpresa.LogicaEmpresa> ObjDataEmpresa = new Lazy<Logica.Logica.LogicaEmpresa.LogicaEmpresa>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region LISTADO DE CITAS
        private void ListadoCitas() {
            bool? Estatus = false;

            if (rbActivos.Checked == true) {
                Estatus = true;
            }
            else if (rbInactivos.Checked == true) {
                Estatus = false;
            }
            else if (rbTodos.Checked == true) {
                Estatus = new Nullable<bool>();
            }

         

            if (cbRangoFecha.Checked == true) {
                string _NumeroCita = string.IsNullOrEmpty(txtNumeroCita.Text.Trim()) ? null : txtNumeroCita.Text.Trim();
                string _NombreCliente = string.IsNullOrEmpty(txtNombreCliente.Text.Trim()) ? null : txtNombreCliente.Text.Trim();
                string _NumeroIdentificacion = string.IsNullOrEmpty(txtNumeroIdentificacion.Text.Trim()) ? null : txtNumeroIdentificacion.Text.Trim();

                var Buscar = ObjDataEmpresa.Value.BuscaEncabezadoCita(
                        _NumeroCita,
                        null,
                        Convert.ToDateTime(txtFechaHasta.Text),
                        Convert.ToDateTime(txtFechaDesde.Text),
                        _NombreCliente,
                        null,
                        null,
                        Convert.ToInt32(txtNumeroPagina.Value),
                        Convert.ToInt32(txtNumeroRegistros.Value));
                dtListadoCitas.DataSource = Buscar;
                OcultarColumnas();
            }
            else {
                string _NumeroCita = string.IsNullOrEmpty(txtNumeroCita.Text.Trim()) ? null : txtNumeroCita.Text.Trim();
                string _NombreCliente = string.IsNullOrEmpty(txtNombreCliente.Text.Trim()) ? null : txtNombreCliente.Text.Trim();
                string _NumeroIdentificacion = string.IsNullOrEmpty(txtNumeroIdentificacion.Text.Trim()) ? null : txtNumeroIdentificacion.Text.Trim();

                var Buscar = ObjDataEmpresa.Value.BuscaEncabezadoCita(
                    _NumeroCita,
                    null,
                    null,
                    null,
                    _NombreCliente,
                    null,
                    null,
                    Convert.ToInt32(txtNumeroPagina.Value),
                    Convert.ToInt32(txtNumeroRegistros.Value));
                dtListadoCitas.DataSource = Buscar;
                OcultarColumnas();
            }
        }
        private void OcultarColumnas() {
            this.dtListadoCitas.Columns["IdEmpleado"].Visible = false;
            this.dtListadoCitas.Columns["FechaCita0"].Visible = false;
            this.dtListadoCitas.Columns["NumeroConectorCita"].Visible = false;
            this.dtListadoCitas.Columns["Estatus0"].Visible = false;
        }
        #endregion
        #region MOSTRAR LOS PRDUCTOS AGREGADOS A LA CITA
        private void ProductosServiciosAgregados(decimal NumeroConector) {
            var BuscarProductosServicios = ObjDataEmpresa.Value.BuscaCitaDetalle(NumeroConector);
            dtListado.DataSource = BuscarProductosServicios;
            this.dtListado.Columns["NumeroConectorCita"].Visible = false;
            this.dtListado.Columns["IdProducto"].Visible = false;
            this.dtListado.Columns["CantidadRegistros"].Visible = false;
            this.dtListado.Columns["Total"].Visible = false;
            int CantidadRegistros = 0;
            decimal TotalAgregado = 0;
            foreach (var n in BuscarProductosServicios) {
                CantidadRegistros = Convert.ToInt32(n.CantidadRegistros);
                TotalAgregado = Convert.ToDecimal(n.Total);
            }
            lbCantidadRegistrosAgregadosVAriables.Text = CantidadRegistros.ToString("N0");
            lbCantidadRegistrosTotal.Text = TotalAgregado.ToString("N2");

        }
        #endregion
        #region RESTABLECER PANTALLA
        private void RestablecerPantalla() {
            cbRangoFecha.Checked = false;
            rbActivos.Checked = true;
            txtNumeroCita.Text = string.Empty;
            txtNombreCliente.Text = string.Empty;
            txtNumeroIdentificacion.Text = string.Empty;
            txtNumeroPagina.Value = 1;
            txtNumeroRegistros.Value = 10;

            btnNuevo.Enabled = true;
            btnBuscar.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            txtNumeroPagina.Enabled = true;
            txtNumeroRegistros.Enabled = true;
            ListadoCitas();
            dtListado.DataSource = null;
        }
        #endregion


        public ProgramacionCitas()
        {
            InitializeComponent();
        }

        private void ProgramacionCitas_Load(object sender, EventArgs e)
        {
            lbTitulo.ForeColor = Color.White;
            lbTitulo.Text = "CONSULTA DE CITAS";
            lbCantidadRegistrosVariable.ForeColor = Color.White;
            lbCantidadRegistrosTitulo.ForeColor = Color.White;
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            rbActivos.Checked = true;



            var Buscar = ObjDataEmpresa.Value.BuscaEncabezadoCita(
                    null,
                    null,
                    DateTime.Now,
                    DateTime.Now,
                    null,
                    null,
                    null,
                    Convert.ToInt32(txtNumeroPagina.Value),
                    Convert.ToInt32(txtNumeroRegistros.Value));
            dtListadoCitas.DataSource = Buscar;
            OcultarColumnas();
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ProgramacionCitas_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason) {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.MantenimientoCitas Mantenimiento = new MantenimientoCitas();
            Mantenimiento.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Mantenimiento.VariablesGlobales.IdMantenimeinto = 0;
            Mantenimiento.VariablesGlobales.Accion = "INSERT";
            Mantenimiento.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.MantenimientoCitas Mantenimiento = new MantenimientoCitas();
            Mantenimiento.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Mantenimiento.VariablesGlobales.IdMantenimeinto = VariablesGlobales.IdMantenimeinto;
            Mantenimiento.VariablesGlobales.Accion = "UPDATE";
            Mantenimiento.VariablesGlobales.NumeroConector = VariablesGlobales.NumeroConector;
            Mantenimiento.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ListadoCitas();
        }

        private void txtNumeroPagina_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroPagina.Value < 1) {
                txtNumeroPagina.Value = 1;
                ListadoCitas();
            }
            else {
                ListadoCitas();
            }
        }

        private void txtNumeroRegistros_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroRegistros.Value < 1) {
                txtNumeroPagina.Value = 10;
                ListadoCitas();
            }
            else {
                ListadoCitas();
            }
        }

        private void dtListadoCitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("¿Quieres seleccionar este registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                decimal NumeroConector = Convert.ToDecimal(this.dtListadoCitas.CurrentRow.Cells["NumeroConectorCita"].Value.ToString());
                VariablesGlobales.NumeroConector = NumeroConector;
                this.VariablesGlobales.IdMantenimeinto = Convert.ToDecimal(dtListadoCitas.CurrentRow.Cells["IdCitas"].Value.ToString());

                var BuscarRegistroSeleccionado = ObjDataEmpresa.Value.BuscaEncabezadoCita(
                    VariablesGlobales.IdMantenimeinto.ToString(), null, null, null, null, null, null, 1, 1);
                dtListadoCitas.DataSource = BuscarRegistroSeleccionado;
                OcultarColumnas();
                btnNuevo.Enabled = false;
                btnBuscar.Enabled = false;
                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
                txtNumeroPagina.Enabled = false;
                txtNumeroRegistros.Enabled = false;

                ProductosServiciosAgregados(NumeroConector);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RestablecerPantalla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Quieres eliminar este registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                DSMarket.Logica.Comunes.ProcesarInformacion.Empresa.ProcesarInformacionCitas EliminarEncabezado = new Logica.Comunes.ProcesarInformacion.Empresa.ProcesarInformacionCitas(
                   0, 0, DateTime.Now, "", "", "", "", "", VariablesGlobales.NumeroConector, false, "DELETE");
                EliminarEncabezado.ProcesarInformacionCitasEncabezado();

                DSMarket.Logica.Comunes.ProcesarInformacion.Empresa.ProcesarInformacionCitas EliminarDetalle = new Logica.Comunes.ProcesarInformacion.Empresa.ProcesarInformacionCitas(
                    VariablesGlobales.NumeroConector, 0, 0, "", "DELETEALL");
                EliminarDetalle.ProcesarInformacionDetalle();

                MessageBox.Show("Registro eliminado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                RestablecerPantalla();
            }
        }
    }
}
