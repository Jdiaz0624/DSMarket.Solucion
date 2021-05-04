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
    public partial class TipoEmpleadoConsulta : Form
    {
        Lazy<DSMarket.Logica.Logica.LogicaEmpresa.LogicaEmpresa> ObjDataEmpresa = new Lazy<Logica.Logica.LogicaEmpresa.LogicaEmpresa>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region CONSULTAR TIPO DE EMPLEADOS
        private void ConsultarListado() {
            string _TipoEmpleado = string.IsNullOrEmpty(txtTipoEmpleado.Text.Trim()) ? null : txtTipoEmpleado.Text.Trim();

            var Listado = ObjDataEmpresa.Value.BuscaTipoEmpleado(
                new Nullable<int>(),
                _TipoEmpleado,
                (int)txtNumeroPagina.Value,
                (int)txtNumeroRegistros.Value);
            dtListado.DataSource = Listado;
            OcultarColumna();
        }
        private void OcultarColumna() {
            this.dtListado.Columns["IdTipoEmpleado"].Visible = false;
            this.dtListado.Columns["Estatus0"].Visible = false;
            this.dtListado.Columns["UsuarioAdiciona"].Visible = false;
            this.dtListado.Columns["FechaAdiciona"].Visible = false;
            this.dtListado.Columns["UsuarioModifica"].Visible = false;
            this.dtListado.Columns["ModificadoPor"].Visible = false;
            this.dtListado.Columns["FechaModifica"].Visible = false;
            this.dtListado.Columns["FechaModificado"].Visible = false;
            this.dtListado.Columns["CantidadRegistros"].Visible = false;
        }
        #endregion
        public TipoEmpleadoConsulta()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ConsultarListado();
        }

        private void txtNumeroPagina_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroPagina.Value < 1) {
                txtNumeroPagina.Value = 1;
                ConsultarListado();
            }
            else {
                ConsultarListado();
            }
        }

        private void txtNumeroRegistros_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroRegistros.Value < 1) {
                txtNumeroRegistros.Value = 10;
                ConsultarListado();
            }
            else {
                ConsultarListado();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.TipoEmpleadoMantenimiento TipoEmpleado = new TipoEmpleadoMantenimiento();
            TipoEmpleado.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            TipoEmpleado.VariablesGlobales.IdMantenimeinto = 0;
            TipoEmpleado.VariablesGlobales.Accion = "INSERT";
            TipoEmpleado.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.TipoEmpleadoMantenimiento TipoEmpleado = new TipoEmpleadoMantenimiento();
            TipoEmpleado.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            TipoEmpleado.VariablesGlobales.IdMantenimeinto = VariablesGlobales.IdMantenimeinto;
            TipoEmpleado.VariablesGlobales.Accion = "UPDATE";
            TipoEmpleado.ShowDialog();
        }

        private void TipoEmpleadoConsulta_Load(object sender, EventArgs e)
        {
            lbTitulo.Text = "TIPO DE EMPLEADO CONSULTA";
            lbTitulo.ForeColor = Color.White;
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNumeroPagina.Value = 1;
            txtNumeroRegistros.Value = 10;
            txtTipoEmpleado.Text = string.Empty;
            btnNuevo.Enabled = true;
            btnEditar.Enabled = false;
            btnBuscar.Enabled = true;
            txtNumeroPagina.Enabled = true;
            txtNumeroRegistros.Enabled = true;
            ConsultarListado();
        }

        private void dtListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.VariablesGlobales.IdMantenimeinto = Convert.ToDecimal(this.dtListado.CurrentRow.Cells["IdTipoEmpleado"].Value.ToString());

            var BuscarRegistro = ObjDataEmpresa.Value.BuscaTipoEmpleado(
                VariablesGlobales.IdMantenimeinto,
                null, 1, 1);
            dtListado.DataSource = BuscarRegistro;
            OcultarColumna();
            btnBuscar.Enabled = false;
            btnEditar.Enabled = true;
            btnNuevo.Enabled = false;
            txtNumeroPagina.Enabled = false;
            txtNumeroRegistros.Enabled = false;
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void TipoEmpleadoConsulta_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason) {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }
    }
}
