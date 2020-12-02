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
    public partial class EmpleadosConsulta : Form
    {
        Lazy<DSMarket.Logica.Logica.LogicaEmpresa.LogicaEmpresa> ObjDataEmpresa = new Lazy<Logica.Logica.LogicaEmpresa.LogicaEmpresa>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region MOSTRAR LISTADO DE EMPLEADOS
        private void MostrarLitado() {
            try {
                string _NombreEmpleado = string.IsNullOrEmpty(txtNombreEmpleado.Text.Trim()) ? null : txtNombreEmpleado.Text.Trim();
                string _NumeroIdentificacion = string.IsNullOrEmpty(txtNumeroIdentificacion.Text.Trim()) ? null : txtNumeroIdentificacion.Text.Trim();
                string _NSS = string.IsNullOrEmpty(txtNSS.Text.Trim()) ? null : txtNSS.Text.Trim();
                bool Estatus = false;

                if (rbActivos.Checked == true) {
                    Estatus = true;
                }
                else if (rbInactivos.Checked == true) {
                    Estatus = false;
                }

                if (cbAgregarRangoFecha.Checked == true) {

                    if (string.IsNullOrEmpty(txtFechaIngresoDesde.Text.Trim()) || string.IsNullOrEmpty(txtFechaIngresoHasta.Text.Trim())) {
                        MessageBox.Show("No puedes dejar los campos fechas vacios para buscar este registro", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else {
                        var BuscarRegistros = ObjDataEmpresa.Value.BuscaEmpleados(
                        new Nullable<decimal>(),
                        _NombreEmpleado,
                        _NumeroIdentificacion,
                        _NSS,
                        Convert.ToDateTime(txtFechaIngresoDesde.Text.Trim()),
                        Convert.ToDateTime(txtFechaIngresoHasta.Text.Trim()),
                        Estatus,
                        Convert.ToInt32(txtNumeroPagina.Value),
                        Convert.ToInt32(txtNumeroRegistros.Value));
                        int CantidadRegistros = 0, Activos = 0, Inactivos = 0;
                        foreach (var n in BuscarRegistros)
                        {
                            CantidadRegistros = Convert.ToInt32(n.CantidadRegistros);
                            Activos = Convert.ToInt32(n.CantidadActivos);
                            Inactivos = Convert.ToInt32(n.CantidadInactivos);
                        }
                        lbCantidadRegistrosVariable.Text = CantidadRegistros.ToString("N0");
                        lbActivosVariables.Text = Activos.ToString("N0");
                        lbInactivoVariable.Text = Inactivos.ToString("N0");
                        dtListado.DataSource = BuscarRegistros;
                        OcultarColumnas();
                    }
                }
                else {
                    var BuscarRegistros = ObjDataEmpresa.Value.BuscaEmpleados(
                        new Nullable<decimal>(),
                        _NombreEmpleado,
                        _NumeroIdentificacion,
                        _NSS,
                        null,
                        null,
                        Estatus,
                        Convert.ToInt32(txtNumeroPagina.Value),
                        Convert.ToInt32(txtNumeroRegistros.Value));
                    int CantidadRegistros = 0, Activos = 0, Inactivos = 0;
                    foreach (var n in BuscarRegistros)
                    {
                        CantidadRegistros = Convert.ToInt32(n.CantidadRegistros);
                        Activos = Convert.ToInt32(n.CantidadActivos);
                        Inactivos = Convert.ToInt32(n.CantidadInactivos);
                    }
                    lbCantidadRegistrosVariable.Text = CantidadRegistros.ToString("N0");
                    lbActivosVariables.Text = Activos.ToString("N0");
                    lbInactivoVariable.Text = Inactivos.ToString("N0");
                    dtListado.DataSource = BuscarRegistros;
                    OcultarColumnas();
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Error al mostrar el listado, codigo de error " + ex.Message, VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void OcultarColumnas() {
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
        }
        #endregion
        public EmpleadosConsulta()
        {
            InitializeComponent();
        }

        private void EmpleadosConsulta_Load(object sender, EventArgs e)
        {
            lbTitulo.ForeColor = Color.White;
            lbCantidadRegistrosTitulo.ForeColor = Color.White;
            lbCantidadRegistrosVariable.ForeColor = Color.White;
            lbActivosTitulos.ForeColor = Color.White;
            lbActivosVariables.ForeColor = Color.White;
            lbInactivosTitulo.ForeColor = Color.White;
            lbInactivoVariable.ForeColor = Color.White;

            lbTitulo.Text = "Empleados Consulta";
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            rbActivos.Checked = true;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            MostrarLitado();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.EmpleadosMantenimiento Mantenimiento = new EmpleadosMantenimiento();
            Mantenimiento.VariablesGlobales.IdMantenimeinto = 0;
            Mantenimiento.VariablesGlobales.Accion = "INSERT";
            Mantenimiento.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Mantenimiento.ShowDialog();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.EmpleadosMantenimiento Mantenimiento = new EmpleadosMantenimiento();
            Mantenimiento.VariablesGlobales.IdMantenimeinto = VariablesGlobales.IdMantenimeinto;
            Mantenimiento.VariablesGlobales.Accion = "UPDATE";
            Mantenimiento.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Mantenimiento.ShowDialog();
        }

        private void BtnRestabelcer_Click(object sender, EventArgs e)
        {
            btnBuscar.Enabled = true;
            btnNuevo.Enabled = true;
            btnEditar.Enabled = false;
            txtNombreEmpleado.Text = string.Empty;
            txtNumeroIdentificacion.Text = string.Empty;
            txtNSS.Text = string.Empty;
            rbActivos.Checked = true;
            cbAgregarRangoFecha.Checked = false;
            txtNumeroPagina.Enabled = true;
            txtNumeroRegistros.Enabled = true;
            txtNumeroPagina.Value = 1;
            txtNumeroRegistros.Value = 10;
            MostrarLitado();
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void EmpleadosConsulta_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason) {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void DtListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("¿Quieres seleccionar este registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                this.VariablesGlobales.IdMantenimeinto = Convert.ToDecimal(this.dtListado.CurrentRow.Cells["IdEmpleado"].Value.ToString());

                var Buscar = ObjDataEmpresa.Value.BuscaEmpleados(
                    VariablesGlobales.IdMantenimeinto,
                    null, null, null, null, null, null, 1, 1);
                dtListado.DataSource = Buscar;

                btnBuscar.Enabled = false;
                btnNuevo.Enabled = false;
                btnEditar.Enabled = true;
                txtNumeroPagina.Enabled = false;
                txtNumeroRegistros.Enabled = false;
            }
        }
    }
}
