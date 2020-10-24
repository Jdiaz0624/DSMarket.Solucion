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
    public partial class TipoNominaConsulta : Form
    {
        Lazy<DSMarket.Logica.Logica.LogicaEmpresa.LogicaEmpresa> ObjDataEmpresa = new Lazy<Logica.Logica.LogicaEmpresa.LogicaEmpresa>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        private void Listado() {
            string _TipoNomina = string.IsNullOrEmpty(txtTipoNimina.Text.Trim()) ? null : txtTipoNimina.Text.Trim();

            var ListadoTipoNomina = ObjDataEmpresa.Value.BuscaTipoNomina(
                new Nullable<decimal>(),
                _TipoNomina,
                (int)txtNumeroPagina.Value,
                (int)txtNumeroRegistros.Value);
            dtListado.DataSource = ListadoTipoNomina;
           
            if (ListadoTipoNomina.Count() < 1)
            {
                lbCantidadRegistrosVariable.Text = "0";
            }
            else {
                int CantiadRegistros = 0;
                foreach (var n in ListadoTipoNomina) {
                    CantiadRegistros = Convert.ToInt32(n.CantidadRegistros);
                    lbCantidadRegistrosVariable.Text = CantiadRegistros.ToString("N0");
                }
            }
            OcultarCOlumnas();
        }
        private void OcultarCOlumnas() {
            this.dtListado.Columns["IdTipoNomina"].Visible = false;
            this.dtListado.Columns["Estatus0"].Visible = false;
            this.dtListado.Columns["UsuairoModifica"].Visible = false;
            this.dtListado.Columns["FechaAdiciona"].Visible = false;
            this.dtListado.Columns["UsuarioAdiciona"].Visible = false;
            this.dtListado.Columns["ModificadoPor"].Visible = false;
            this.dtListado.Columns["FechaModifica"].Visible = false;
            this.dtListado.Columns["FechaModificado"].Visible = false;
            this.dtListado.Columns["CantidadRegistros"].Visible = false;
        }
        public TipoNominaConsulta()
        {
            InitializeComponent();
        }

        private void TipoNominaConsulta_Load(object sender, EventArgs e)
        {
            lbTitulo.Text = "TIPO DE NOMINA CONSULTA";
            lbTitulo.ForeColor = Color.White;
            lbCantidadRegistrosVariable.ForeColor = Color.White;
            lbCantidadRegistrosTitulo.ForeColor = Color.White;
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Listado();
        }

        private void txtNumeroPagina_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroPagina.Value < 1) {
                txtNumeroPagina.Value = 1;
                Listado();
            }
            else {
                Listado();
            }
        }

        private void txtNumeroRegistros_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroRegistros.Value < 1) {
                txtNumeroRegistros.Value = 10;
                Listado();
            }
            else {
                Listado();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.TipoNominaMantenimiento Mantenimiento = new TipoNominaMantenimiento();
            Mantenimiento.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Mantenimiento.VariablesGlobales.Accion = "INSERT";
            Mantenimiento.VariablesGlobales.IdMantenimeinto = 0;
            Mantenimiento.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.TipoNominaMantenimiento Mantenimiento = new TipoNominaMantenimiento();
            Mantenimiento.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Mantenimiento.VariablesGlobales.Accion = "UPDATE";
            Mantenimiento.VariablesGlobales.IdMantenimeinto = VariablesGlobales.IdMantenimeinto;
            Mantenimiento.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtTipoNimina.Text = string.Empty;
            txtNumeroPagina.Value = 1;
            txtNumeroRegistros.Value = 10;
            txtNumeroPagina.Enabled = true;
            txtNumeroRegistros.Enabled = true;
            btnBuscar.Enabled = true;
            btnNuevo.Enabled = true;
            btnEditar.Enabled = false;

        }

        private void dtListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("¿Quieres seleccionar este registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                this.VariablesGlobales.IdMantenimeinto = Convert.ToDecimal(this.dtListado.CurrentRow.Cells["IdTipoNomina"].Value.ToString());

                var Buscar = ObjDataEmpresa.Value.BuscaTipoNomina(VariablesGlobales.IdMantenimeinto, null, 1, 1);
                dtListado.DataSource = Buscar;
                OcultarCOlumnas();
                lbCantidadRegistrosVariable.Text = "1";
                btnBuscar.Enabled = false;
                btnNuevo.Enabled = false;
                btnEditar.Enabled = true;
                txtNumeroPagina.Enabled = false;
                txtNumeroRegistros.Enabled = false;
            }
        }

        private void TipoNominaConsulta_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason) {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;

            }
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
