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
    public partial class CargosConsulta : Form
    {
        public CargosConsulta()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaListas.LogicaListas> ObjDataListass = new Lazy<Logica.Logica.LogicaListas.LogicaListas>();
        Lazy<DSMarket.Logica.Logica.LogicaEmpresa.LogicaEmpresa> ObjDataEmpresa = new Lazy<Logica.Logica.LogicaEmpresa.LogicaEmpresa>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region MOSTRAR EL LISTADO DE LOS DEPARTAMENTOS
        private void MostrarListadoDepartamntos() {
            var Departamentos = ObjDataListass.Value.ListadoDepartamentos();
            ddlSeleccionarDepartamento.DataSource = Departamentos;
            ddlSeleccionarDepartamento.DisplayMember = "Departamento";
            ddlSeleccionarDepartamento.ValueMember = "IdDepartamento";
        }
        #endregion
        #region MOSTRAR EL LISTADO DE LOS CARGOS
        private void MostrarListadoCargos() {
            var BuscarRegistros = ObjDataEmpresa.Value.BuscaCargos(
                new Nullable<decimal>(),
                Convert.ToDecimal(ddlSeleccionarDepartamento.SelectedValue),
                txtCargo.Text,
                Convert.ToInt32(txtNumeroPagina.Value),
                Convert.ToInt32(txtNumeroRegistros.Value));
            dtListado.DataSource = BuscarRegistros;
            OcultarColumnas();
            if (BuscarRegistros.Count() < 1)
            {
                lbCantidadRegistrosVariable.Text = "0";
            }
            else {
                foreach (var n in BuscarRegistros) {
                    int CantidadRegistros = 0;

                    CantidadRegistros = Convert.ToInt32(n.CantidadRegistros);
                    lbCantidadRegistrosVariable.Text = CantidadRegistros.ToString();
                }
            }
        }
        private void OcultarColumnas() {
            this.dtListado.Columns["IdCargo"].Visible = false;
            this.dtListado.Columns["IdDepartamento"].Visible = false;
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

     

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void CargosConsulta_Load(object sender, EventArgs e)
        {
            MostrarListadoDepartamntos();
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            this.BackColor = SystemColors.Control;
            dtListado.BackgroundColor = SystemColors.Control;
            ddlSeleccionarDepartamento.BackColor = Color.WhiteSmoke;
            txtCargo.BackColor = Color.WhiteSmoke;
            txtNumeroPagina.BackColor = Color.WhiteSmoke;
            txtNumeroRegistros.BackColor = Color.WhiteSmoke;

            ddlSeleccionarDepartamento.ForeColor = Color.Black;
            txtCargo.ForeColor = Color.Black;
            txtNumeroPagina.ForeColor = Color.Black;
            txtNumeroRegistros.ForeColor = Color.Black;

            lbTitulo.ForeColor = Color.WhiteSmoke;
            lbCantidadRegistrosTitulo.ForeColor = Color.WhiteSmoke;
            lbCantidadRegistrosVariable.ForeColor = Color.WhiteSmoke;

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.CargosMantenimiento mantenimiento = new CargosMantenimiento();
            mantenimiento.VariablesGlobales.Accion = "INSERT";
            mantenimiento.VariablesGlobales.IdMantenimeinto = 0;
            mantenimiento.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            mantenimiento.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.CargosMantenimiento mantenimiento = new CargosMantenimiento();
            mantenimiento.VariablesGlobales.Accion = "UPDATE";
            mantenimiento.VariablesGlobales.IdMantenimeinto = VariablesGlobales.IdMantenimeinto;
            mantenimiento.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            mantenimiento.ShowDialog();
        }

        private void CargosConsulta_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MostrarListadoCargos();
        }

        private void txtNumeroPagina_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroPagina.Value < 1)
            {
                txtNumeroPagina.Value = 1;
                MostrarListadoCargos();
            }
            else {
                MostrarListadoCargos();
            }
        }

        private void txtNumeroRegistros_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroRegistros.Value < 1)
            {
                txtNumeroRegistros.Value = 10;
                MostrarListadoCargos();
            }
            else {
                MostrarListadoCargos();
            }
        }

        private void dtListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.VariablesGlobales.IdMantenimeinto = Convert.ToDecimal(this.dtListado.CurrentRow.Cells["IdCargo"].Value.ToString());

            var BuscarRegistroSelccionado = ObjDataEmpresa.Value.BuscaCargos(
                VariablesGlobales.IdMantenimeinto,
                null, null, 1, 1);
            dtListado.DataSource = BuscarRegistroSelccionado;
            OcultarColumnas();
            btnNuevo.Enabled = false;
            btnEditar.Enabled = true;
            txtNumeroPagina.Enabled = false;
            txtNumeroRegistros.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnNuevo.Enabled = true;
            btnEditar.Enabled = false;
            txtNumeroPagina.Enabled = true;
            txtNumeroRegistros.Enabled = true;
            txtNumeroPagina.Value = 1;
            txtNumeroRegistros.Value = 10;
            txtCargo.Text = string.Empty;
            MostrarListadoDepartamntos();
            MostrarListadoCargos();

        }
    }
}
