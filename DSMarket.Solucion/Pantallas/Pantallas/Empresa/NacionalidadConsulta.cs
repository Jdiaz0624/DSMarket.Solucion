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
    public partial class NacionalidadConsulta : Form
    {
        Lazy<DSMarket.Logica.Logica.LogicaEmpresa.LogicaEmpresa> ObjdataEmpresa = new Lazy<Logica.Logica.LogicaEmpresa.LogicaEmpresa>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region CONSULTA DE NACIONALIDAD
        private void ConsultarRegistros() {
            string _Nacionalidad = string.IsNullOrEmpty(txtNacionalidadFiltro.Text.Trim()) ? null : txtNacionalidadFiltro.Text.Trim();

            var Buscar = ObjdataEmpresa.Value.BuscaNacionalidad(
                new Nullable<decimal>(),
                _Nacionalidad,
                Convert.ToInt32(txtNumeroPagina.Value),
                Convert.ToInt32(txtNumeroRegistros.Value));
            dtListado.DataSource = Buscar;
            OcultarColumnas();
            int CantidadRegistros = 0;
            foreach (var n in Buscar) {
                CantidadRegistros = Convert.ToInt32(n.CantidadRegistros);
            }
            lbCantidadRegistrosVariable.Text = CantidadRegistros.ToString("N0");
        }
        private void OcultarColumnas() {
            this.dtListado.Columns["IdNacionalidad"].Visible = false;
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
        public NacionalidadConsulta()
        {
            InitializeComponent();
        }

        private void NacionalidadConsulta_Load(object sender, EventArgs e)
        {
            lbTitulo.ForeColor = Color.White;
            lbCantidadRegistrosVariable.ForeColor = Color.White;
            lbCantidadRegistrosTitulo.ForeColor = Color.White;
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            lbTitulo.Text = "Nacionalidad Consulta";
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            ConsultarRegistros();
        }

        private void TxtNumeroPagina_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroPagina.Value < 1)
            {
                txtNumeroPagina.Value = 1;
                ConsultarRegistros();
            }
            else {
                ConsultarRegistros();
            }
        }

        private void TxtNumeroRegistros_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroRegistros.Value < 1)
            {
                txtNumeroRegistros.Value = 10;
                ConsultarRegistros();
            }
            else {
                ConsultarRegistros();
            }
        }

        private void BtnDeshabilitar_Click(object sender, EventArgs e)
        {
            txtNacionalidadFiltro.Text = string.Empty;
            txtNumeroPagina.Value = 1;
            txtNumeroRegistros.Value = 10;
            ConsultarRegistros();
            btnBuscar.Enabled = true;
            btnEditar.Enabled = false;
            txtNumeroPagina.Enabled = true;
            btnNuevo.Enabled = true;
            txtNumeroRegistros.Enabled = true;
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.NacionalidadMantenimiento Mantenimiento = new NacionalidadMantenimiento();
            Mantenimiento.VariablesGlobales.IdMantenimeinto = 0;
            Mantenimiento.VariablesGlobales.Accion = "INSERT";
            Mantenimiento.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Mantenimiento.ShowDialog();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.NacionalidadMantenimiento Mantenimiento = new NacionalidadMantenimiento();
            Mantenimiento.VariablesGlobales.IdMantenimeinto = VariablesGlobales.IdMantenimeinto;
            Mantenimiento.VariablesGlobales.Accion = "UPDATE";
            Mantenimiento.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Mantenimiento.ShowDialog();
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void NacionalidadConsulta_FormClosing(object sender, FormClosingEventArgs e)
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
                this.VariablesGlobales.IdMantenimeinto = Convert.ToDecimal(Convert.ToDecimal(dtListado.CurrentRow.Cells["IdNacionalidad"].Value.ToString()));

                var Buscar = ObjdataEmpresa.Value.BuscaNacionalidad(VariablesGlobales.IdMantenimeinto, null, 1, 1);
                dtListado.DataSource = Buscar;
                OcultarColumnas();
                btnBuscar.Enabled = false;
                btnNuevo.Enabled = false;
                btnEditar.Enabled = true;
                txtNumeroPagina.Enabled = false;
                txtNumeroRegistros.Enabled = false;
            }
        }
    }
}
