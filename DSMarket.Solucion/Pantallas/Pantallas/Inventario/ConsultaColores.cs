using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSMarket.Solucion.Pantallas.Pantallas.Inventario
{
    public partial class ConsultaColores : Form
    {
        public ConsultaColores()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaInventario.LogicaInventario> ObjDataInventario = new Lazy<Logica.Logica.LogicaInventario.LogicaInventario>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region BUSCAR REGISTROS
        private void ConsultarRegistros() {
            string _Colores = string.IsNullOrEmpty(txtColorConsulta.Text.Trim()) ? null : txtColorConsulta.Text.Trim();

            var BuscarColores = ObjDataInventario.Value.BuscaColoresArticulos(
                new Nullable<decimal>(),
                _Colores,
                Convert.ToInt32(txtNumeroPagina.Value),
                Convert.ToInt32(txtNumeroRegistros.Value));
            dtListado.DataSource = BuscarColores;
            OcultarColumnas();
            if (BuscarColores.Count() < 1)
            {
                lbCantidadRegistrosVariable.Text = "0";
            }
            else {
              
                foreach (var n in BuscarColores) {
                    decimal Cantidad = Convert.ToDecimal(n.CantidadRegistros);
                    lbCantidadRegistrosVariable.Text = Cantidad.ToString("N0");
                }
            }
        }
        private void OcultarColumnas() {
            this.dtListado.Columns["IdColor"].Visible = false;
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

        private void ConsultaColores_Load(object sender, EventArgs e)
        {
            lbTitulo.Text = "CONSULTA DE COLORES";
            lbTitulo.ForeColor = Color.White;
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
        }

        private void ConsultaColores_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason) {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ConsultarRegistros();

        }

        private void txtNumeroPagina_ValueChanged(object sender, EventArgs e)
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

        private void txtNumeroRegistros_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroRegistros.Value < 1) {
                txtNumeroRegistros.Value = 10;
                ConsultarRegistros();
            }
            else {
                ConsultarRegistros();
            }
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            txtColorConsulta.Text = string.Empty;
            txtNumeroPagina.Value = 1;
            txtNumeroRegistros.Value = 10;
            btnBuscar.Enabled = true;
            txtNumeroPagina.Enabled = true;
            txtNumeroRegistros.Enabled = true;
            btnNuevo.Enabled = true;
            ConsultarRegistros();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.MantenimientoColores Mantenimiento = new MantenimientoColores();
            Mantenimiento.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Mantenimiento.VariablesGlobales.IdMantenimeinto = 0;
            Mantenimiento.VariablesGlobales.Accion = "INSERT";
            Mantenimiento.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.MantenimientoColores Mantenimiento = new MantenimientoColores();
            Mantenimiento.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Mantenimiento.VariablesGlobales.IdMantenimeinto = VariablesGlobales.IdMantenimeinto;
            Mantenimiento.VariablesGlobales.Accion = "UPDATE";
            Mantenimiento.ShowDialog();
        }

        private void dtListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("¿Quieres seleccionar este registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                this.VariablesGlobales.IdMantenimeinto = Convert.ToDecimal(this.dtListado.CurrentRow.Cells["IdColor"].Value.ToString());

                var Buscar = ObjDataInventario.Value.BuscaColoresArticulos(VariablesGlobales.IdMantenimeinto, null, 1, 1);
                dtListado.DataSource = Buscar;
                lbCantidadRegistrosVariable.Text = "1";
                btnBuscar.Enabled = false;
                btnNuevo.Enabled = false;
                btnEditar.Enabled = true;
                txtNumeroPagina.Enabled = false;
                txtNumeroRegistros.Enabled = false;
            }
        }
    }
}
