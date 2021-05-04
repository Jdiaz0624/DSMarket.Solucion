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
    public partial class TipoMovimientoConsulta : Form
    {
        public TipoMovimientoConsulta()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaEmpresa.LogicaEmpresa> ObjData = new Lazy<Logica.Logica.LogicaEmpresa.LogicaEmpresa>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region MOSTRAR EL LISTADO DE LOS TIPOS DE MOVIMIENTOS
        private void ListadoTipoMovimiento() {
            try {
                string _TipoMovimiento = string.IsNullOrEmpty(txtTipoMovimiento.Text.Trim()) ? null : txtTipoMovimiento.Text.Trim();

                var Listado = ObjData.Value.ListadoTipoMovimiento(
                    new Nullable<decimal>(),
                    _TipoMovimiento,
                    Convert.ToInt32(txtNumeroPagina.Value),
                    Convert.ToInt32(txtNumeroRegistros.Value));
                dtListado.DataSource = Listado;
                OcultarColumnas();
                if (Listado.Count() < 1) {
                    lbCantidadRegistrosVariable.Text = "0";
                }
                else {
                    foreach (var n in Listado) {
                        int Cantidadregistros = Convert.ToInt32(n.CantidadRegistros);
                        lbCantidadRegistrosVariable.Text = Cantidadregistros.ToString("N0");
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Error al mostrar la consulta, codigo de error " + ex.Message, VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void OcultarColumnas() {
            this.dtListado.Columns["IdTipoMovimiento"].Visible = false;
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

        private void TipoMovimientoConsulta_Load(object sender, EventArgs e)
        {
            lbCantidadRegistrosTitulo.ForeColor = Color.White;
            lbCantidadRegistrosVariable.ForeColor = Color.White;
            lbTitulo.ForeColor = Color.White;
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void TipoMovimientoConsulta_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason) {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ListadoTipoMovimiento();
        }

        private void txtNumeroPagina_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroPagina.Value < 1) {
                txtNumeroPagina.Value = 1;
                ListadoTipoMovimiento();
            }
            else {
                ListadoTipoMovimiento();
            }
        }

        private void txtNumeroRegistros_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroRegistros.Value < 1) {
                txtNumeroRegistros.Value = 10;
                ListadoTipoMovimiento();
            }
            else {
                ListadoTipoMovimiento();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.TipoMovimientoMantenimiento Nuevo = new TipoMovimientoMantenimiento();
            Nuevo.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Nuevo.VariablesGlobales.Accion = "INSERT";
            Nuevo.VariablesGlobales.IdMantenimeinto = 0;
            Nuevo.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.TipoMovimientoMantenimiento Modificar = new TipoMovimientoMantenimiento();
            Modificar.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Modificar.VariablesGlobales.Accion = "UPDATE";
            Modificar.VariablesGlobales.IdMantenimeinto = VariablesGlobales.IdMantenimeinto;
            Modificar.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtTipoMovimiento.Text = string.Empty;
            txtNumeroPagina.Value = 1;
            txtNumeroRegistros.Value = 10;
            txtNumeroPagina.Enabled = true;
            txtNumeroRegistros.Enabled = true;
            btnNuevo.Enabled = true;
            btnEditar.Enabled = false;
            btnBuscar.Enabled = true;
        }

        private void dtListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.VariablesGlobales.IdMantenimeinto = Convert.ToDecimal(dtListado.CurrentRow.Cells["IdTipoMovimiento"].Value.ToString());

            var Buscar = ObjData.Value.ListadoTipoMovimiento(
                VariablesGlobales.IdMantenimeinto,
                null, 1, 1);
            dtListado.DataSource = Buscar;
            OcultarColumnas();
            lbCantidadRegistrosVariable.Text = "1";
            btnNuevo.Enabled = false;
            btnEditar.Enabled = true;
            btnBuscar.Enabled = false;
            txtNumeroPagina.Enabled = false;
            txtNumeroRegistros.Enabled = false;
        }
    }
}
