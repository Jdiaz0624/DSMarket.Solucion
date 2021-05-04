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
    public partial class EstadoCivilConsulta : Form
    {
        Lazy<DSMarket.Logica.Logica.LogicaEmpresa.LogicaEmpresa> ObjdataEmpresa = new Lazy<Logica.Logica.LogicaEmpresa.LogicaEmpresa>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region CONSULTA DE ESTADO CIVIL
        private void ConsultarInformacion() {
            string _EstadoCivil = string.IsNullOrEmpty(txtEstadiCivilFiltro.Text.Trim()) ? null : txtEstadiCivilFiltro.Text.Trim();

            var Listado = ObjdataEmpresa.Value.BuscaEstadiCivil(
                new Nullable<decimal>(),
                _EstadoCivil,
                Convert.ToInt32(txtNumeroPagina.Value),
                Convert.ToInt32(txtNumeroRegistros.Value));
            int CantidadRegistros = 0;
            foreach (var n in Listado) {
                CantidadRegistros = Convert.ToInt32(n.CantidadRegistros);
            }
            lbCantidadRegistrosVariable.Text = CantidadRegistros.ToString("N0");
            dtListado.DataSource = Listado;
            OcultarColumnas();
        }
        private void OcultarColumnas() {
            this.dtListado.Columns["IdEstadoCivil"].Visible = false;
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
        public EstadoCivilConsulta()
        {
            InitializeComponent();
        }

        private void EstadoCivilConsulta_Load(object sender, EventArgs e)
        {
            lbCantidadRegistrosTitulo.ForeColor = Color.White;
            lbCantidadRegistrosVariable.ForeColor = Color.White;
            lbTitulo.ForeColor = Color.White;
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            lbTitulo.Text = "Estado Civil Consulta";
        }

        private void TxtNumeroPagina_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroPagina.Value < 1) {
                txtNumeroPagina.Value = 1;
                ConsultarInformacion();
            }
            else {
                ConsultarInformacion();
            }
        }

        private void TxtNumeroRegistros_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroRegistros.Value < 1) {
                txtNumeroRegistros.Value = 10;
                ConsultarInformacion();
            }
            else {
                ConsultarInformacion();
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.EstadoCivilMantenimiento Mantenimiento = new EstadoCivilMantenimiento();
            Mantenimiento.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Mantenimiento.VariablesGlobales.IdMantenimeinto = 0;
            Mantenimiento.VariablesGlobales.Accion = "INSERT";
            Mantenimiento.ShowDialog();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.EstadoCivilMantenimiento Mantenimiento = new EstadoCivilMantenimiento();
            Mantenimiento.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Mantenimiento.VariablesGlobales.IdMantenimeinto = VariablesGlobales.IdMantenimeinto;
            Mantenimiento.VariablesGlobales.Accion = "UPDATE";
            Mantenimiento.ShowDialog();
        }

        private void BtnDeshabilitar_Click(object sender, EventArgs e)
        {
            btnBuscar.Enabled = true;
            btnEditar.Enabled = false;
            txtNumeroPagina.Enabled = true;
            btnNuevo.Enabled = true;
            txtNumeroRegistros.Enabled = true;
            txtNumeroPagina.Value = 1;
            txtNumeroRegistros.Value = 10;
            ConsultarInformacion();
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void EstadoCivilConsulta_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason) {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            ConsultarInformacion();
        }

        private void DtListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.VariablesGlobales.IdMantenimeinto = Convert.ToDecimal(dtListado.CurrentRow.Cells["IdEstadoCivil"].Value.ToString());

            var Buscar = ObjdataEmpresa.Value.BuscaEstadiCivil(VariablesGlobales.IdMantenimeinto, null, 1, 1);
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
