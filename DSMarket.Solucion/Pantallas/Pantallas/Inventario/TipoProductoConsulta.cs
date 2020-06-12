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
    public partial class TipoProductoConsulta : Form
    {
        public TipoProductoConsulta()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaInventario.LogicaInventario> ObjDataInventario = new Lazy<Logica.Logica.LogicaInventario.LogicaInventario>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region CONSULTA DE REGISTROS
        private void ConsultarRegistros()
        {
            string _TipoProducto = string.IsNullOrEmpty(txtTipoProducto.Text.Trim()) ? null : txtTipoProducto.Text.Trim();

            var Buscar = ObjDataInventario.Value.BuscaTipoProducto(
                new Nullable<decimal>(),
                _TipoProducto,
                Convert.ToInt32(txtNumeroPagina.Value),
                Convert.ToInt32(txtNumeroRegistros.Value));
            if (Buscar.Count() < 1)
            {
                lbCantidadRegistrosVariable.Text = "0";
            }
            else
            {
                foreach (var n in Buscar)
                {
                    int CantidadRegistros = Convert.ToInt32(n.CantidadRegistros);
                    lbCantidadRegistrosVariable.Text = CantidadRegistros.ToString("N0");
                }
            }
            dtListado.DataSource = Buscar;
            OcultarColumnas();
        }

        private void OcultarColumnas() {
            this.dtListado.Columns["IdTipoproducto"].Visible = false;
            this.dtListado.Columns["Estatus0"].Visible = false;
            this.dtListado.Columns["Acumulativo0"].Visible = false;
            this.dtListado.Columns["UsuarioAdiciona"].Visible = false;
            this.dtListado.Columns["Fechaadiciona"].Visible = false;
            this.dtListado.Columns["UsuarioModifica"].Visible = false;
            this.dtListado.Columns["FechaModifica"].Visible = false;
            this.dtListado.Columns["CantidadRegistros"].Visible = false;
        }
        #endregion
        #region APLICAR TEMA
        private void AplicarTema()
        {
            this.BackColor = SystemColors.Control;
            txtTipoProducto.BackColor = Color.WhiteSmoke;
            txtNumeroRegistros.BackColor = Color.WhiteSmoke;
            txtNumeroPagina.BackColor = Color.WhiteSmoke;
            dtListado.BackgroundColor = SystemColors.Control;

        }
        #endregion
        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.MantenimientoTipoProducto Mantenimiento = new MantenimientoTipoProducto();
            Mantenimiento.VariablesGlobales.Accion = "INSERT";
            Mantenimiento.VariablesGlobales.IdMantenimeinto = 0;
            Mantenimiento.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Mantenimiento.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.MantenimientoTipoProducto Mantenimiento = new MantenimientoTipoProducto();
            Mantenimiento.VariablesGlobales.Accion = "UPDATE";
            Mantenimiento.VariablesGlobales.IdMantenimeinto = VariablesGlobales.IdMantenimeinto;
            Mantenimiento.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Mantenimiento.ShowDialog();
        }

        private void TipoProductoConsulta_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void TipoProductoConsulta_Load(object sender, EventArgs e)
        {
            AplicarTema();
            lbTitulo.Text = "CONSULTA DE TIPO DE PRODUCTO";
            lbTitulo.ForeColor = Color.WhiteSmoke;
            lbCantidadRegistrosVariable.ForeColor = Color.WhiteSmoke;
            lbCantidadRegistrosTitulo.ForeColor = Color.WhiteSmoke;

            this.dtListado.RowsDefaultCellStyle.BackColor = SystemColors.Control;
            this.dtListado.AlternatingRowsDefaultCellStyle.BackColor = SystemColors.Control;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ConsultarRegistros();
        }

        private void dtListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("¿Quieres seleccionar este registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.VariablesGlobales.IdMantenimeinto = Convert.ToDecimal(this.dtListado.CurrentRow.Cells["IdTipoproducto"].Value.ToString());

                var BuscarRegistro = ObjDataInventario.Value.BuscaTipoProducto(VariablesGlobales.IdMantenimeinto, null, 1, 1);
                dtListado.DataSource = BuscarRegistro;
                foreach (var n in BuscarRegistro)
                {
                    int CantidadRegistros = Convert.ToInt32(n.CantidadRegistros);
                    lbCantidadRegistrosVariable.Text = CantidadRegistros.ToString("N0");
                }
                btnNuevo.Enabled = false;
                btnEditar.Enabled = true;
                btnBuscar.Enabled = false;
                txtNumeroPagina.Enabled = false;
                txtNumeroRegistros.Enabled = false;
            }
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            txtTipoProducto.Text = string.Empty;
            txtNumeroPagina.Value = 1;
            txtNumeroRegistros.Value = 10;
            ConsultarRegistros();
            btnBuscar.Enabled = true;
            btnNuevo.Enabled = true;
            btnEditar.Enabled = false;
            txtNumeroPagina.Enabled = true;
            txtNumeroRegistros.Enabled = true;
        }

        private void txtNumeroPagina_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroPagina.Value < 1)
            {
                MessageBox.Show("El numero de pagina no puede ser menor a 1", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumeroPagina.Value = 1;
                ConsultarRegistros();
            }
            else
            {
                ConsultarRegistros();
            }
        }

        private void txtNumeroRegistros_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroRegistros.Value < 1)
            {
                MessageBox.Show("El numero de registros no puede ser menor a 1", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumeroRegistros.Value = 10;
                ConsultarRegistros();
            }
            else
            {
                ConsultarRegistros();
            }
        }
    }
}
