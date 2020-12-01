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
    public partial class FormaPagoEmpleadoConsulta : Form
    {
        Lazy<DSMarket.Logica.Logica.LogicaEmpresa.LogicaEmpresa> ObjDataEmpresa = new Lazy<Logica.Logica.LogicaEmpresa.LogicaEmpresa>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region CONSULTAR REGISTROS
        private void COnsultarRegistros() {

            string _FormaPago = string.IsNullOrEmpty(txtFormaPagoFiltro.Text.Trim()) ? null : txtFormaPagoFiltro.Text.Trim();

            var BuscarRegistros = ObjDataEmpresa.Value.BuscaFormaPagoEmpleado(
                new Nullable<decimal>(),
                _FormaPago,
                Convert.ToInt32(txtNumeroPagina.Value),
                Convert.ToInt32(txtNumeroRegistros.Value));
            int CantidadRegistros = 0;
            foreach (var n in BuscarRegistros) {
                CantidadRegistros = Convert.ToInt32(n.CantidadRegistros);
            }
            lbCantidadRegistrosVariable.Text = CantidadRegistros.ToString("N0");
            dtListado.DataSource = BuscarRegistros;
            OcultarColumnas();

        }
        private void OcultarColumnas() {
            this.dtListado.Columns["IdFormaPagoEmpleado"].Visible = false;
            this.dtListado.Columns["Estatus0"].Visible = false;
            this.dtListado.Columns["UsuarioAdiciona"].Visible = false;
            this.dtListado.Columns["CreadoPor"].Visible = false;
            this.dtListado.Columns["FechaAdiciona"].Visible = false;
            this.dtListado.Columns["FechaCreado"].Visible = false;
            this.dtListado.Columns["UsuarioModifica"].Visible = false;
            this.dtListado.Columns["ModificadoPor"].Visible = false;
            this.dtListado.Columns["FechaModifica"].Visible = false;
            this.dtListado.Columns["FechaModificado"].Visible = false;
            this.dtListado.Columns["CantidadRegistros"].Visible = false;
        }
        #endregion
        public FormaPagoEmpleadoConsulta()
        {
            InitializeComponent();
        }

        private void FormaPagoEmpleadoConsulta_Load(object sender, EventArgs e)
        {
            lbTitulo.ForeColor = Color.White;
            lbTitulo.Text = "Forma de Pago Consulta";
            lbCantidadRegistrosTitulo.ForeColor = Color.White;
            lbCantidadRegistrosVariable.ForeColor = Color.White;
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            COnsultarRegistros();
        }

        private void txtNumeroPagina_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroPagina.Value < 1)
            {
                txtNumeroPagina.Value = 1;
                COnsultarRegistros();
            }
            else {
                COnsultarRegistros();
            }
        }

        private void txtNumeroRegistros_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroRegistros.Value < 1) {
                txtNumeroRegistros.Value = 10;
                COnsultarRegistros();
            }
            else {
                COnsultarRegistros();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.FormaPagoEmpleadoMantenimiento Mantenimiento = new FormaPagoEmpleadoMantenimiento();
            Mantenimiento.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Mantenimiento.VariablesGlobales.IdMantenimeinto = 0;
            Mantenimiento.VariablesGlobales.Accion = "INSERT";
            Mantenimiento.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.FormaPagoEmpleadoMantenimiento Mantenimiento = new FormaPagoEmpleadoMantenimiento();
            Mantenimiento.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Mantenimiento.VariablesGlobales.IdMantenimeinto = VariablesGlobales.IdMantenimeinto;
            Mantenimiento.VariablesGlobales.Accion = "UPDATE";
            Mantenimiento.ShowDialog();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            btnNuevo.Enabled = true;
            btnBuscar.Enabled = true;
            btnEditar.Enabled = false;
            txtNumeroPagina.Enabled = true;
            txtNumeroRegistros.Enabled = true;
            txtNumeroPagina.Value = 1;
            txtNumeroRegistros.Value = 10;
            txtFormaPagoFiltro.Text = string.Empty;
            COnsultarRegistros();
        }

        private void dtListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("¿Quieres seleccioanr este registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                this.VariablesGlobales.IdMantenimeinto = Convert.ToDecimal(this.dtListado.CurrentRow.Cells["IdFormaPagoEmpleado"].Value.ToString());

                var Buscar = ObjDataEmpresa.Value.BuscaFormaPagoEmpleado(
                    VariablesGlobales.IdMantenimeinto,
                    null, 1, 1);
                dtListado.DataSource = Buscar;
                OcultarColumnas();
                btnNuevo.Enabled = false;
                btnBuscar.Enabled = false;
                btnEditar.Enabled = true;
                txtNumeroPagina.Enabled = false;
                txtNumeroRegistros.Enabled = false;
            }
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FormaPagoEmpleadoConsulta_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason) {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }
    }
}
