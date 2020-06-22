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
    public partial class UnidadMedidaConsulta : Form
    {
        public UnidadMedidaConsulta()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaInventario.LogicaInventario> ObjDataInventario = new Lazy<Logica.Logica.LogicaInventario.LogicaInventario>();
        public DSMarket.Logica.Comunes.VariablesGlobales variablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region MOSTRAR EL LISTADO DE UNIDADES DE MDIDA
        private void Listado() {
            try {
                string _UnidadMedida = string.IsNullOrEmpty(txtunidadmedida.Text.Trim()) ? null : txtunidadmedida.Text.Trim();

                var Buscar = ObjDataInventario.Value.BuscaUnidadMedida(
                    new Nullable<decimal>(),
                    _UnidadMedida,
                    Convert.ToInt32(txtNumeroPagina.Value),
                    Convert.ToInt32(txtNumeroRegistros.Value));
                dtListado.DataSource = Buscar;
                if (Buscar.Count() < 1)
                {
                    lbCantidadRegistrosVariable.Text = "0";
                }
                else
                {
                    foreach (var n in Buscar)
                    {
                        int Cantidad = Convert.ToInt32(n.CantidadRegistros);
                        lbCantidadRegistrosVariable.Text = Cantidad.ToString("N0");
                    }
                }
                OcultarColumnas();
            }
            catch (Exception ex) {
                MessageBox.Show("Error al mostrar la consulta, codigo de error --> " + ex.Message, variablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void OcultarColumnas() {
            this.dtListado.Columns["IdUnidadMedida"].Visible = false;
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
        #region RestablecerTanpatt
        private void Restabelcer() {
            txtNumeroPagina.Enabled = true;
            txtNumeroRegistros.Enabled = true;
            btnBuscar.Enabled = true;
            btnNuevo.Enabled = true;
            btnEditar.Enabled = false;
            // btnDeshabilitar.Enabled = true;
            txtNumeroPagina.Value = 1;
            txtNumeroRegistros.Value = 10;
            txtunidadmedida.Text = string.Empty;
            Listado();
        }
        #endregion
        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void UnidadMedidaConsulta_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void UnidadMedidaConsulta_Load(object sender, EventArgs e)
        {
            variablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            lbCantidadRegistrosTitulo.ForeColor = SystemColors.Control;
            lbCantidadRegistrosVariable.ForeColor = SystemColors.Control;
            lbTitulo.Text = "CONSULTA DE UNIDADES DE MEDIDAS";
            lbTitulo.ForeColor = Color.WhiteSmoke;
            this.BackColor = SystemColors.Control;
            txtunidadmedida.BackColor = Color.WhiteSmoke;
            txtNumeroRegistros.BackColor = Color.WhiteSmoke;
            txtNumeroPagina.BackColor = Color.WhiteSmoke;
            dtListado.BackgroundColor = SystemColors.Control;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.MantenimientoUnidadMedida Mantenimiento = new MantenimientoUnidadMedida();
            Mantenimiento.VariablesGlobales.ModoRecarga = false;
            Mantenimiento.VariablesGlobales.Accion = "INSERT";
            Mantenimiento.VariablesGlobales.IdMantenimeinto = 0;
            Mantenimiento.VariablesGlobales.IdUsuario = variablesGlobales.IdUsuario;
            Mantenimiento.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.MantenimientoUnidadMedida Mantenimiento = new MantenimientoUnidadMedida();
            Mantenimiento.VariablesGlobales.Accion = "UPDATE";
            Mantenimiento.VariablesGlobales.IdMantenimeinto = variablesGlobales.IdMantenimeinto;
            Mantenimiento.VariablesGlobales.IdUsuario = variablesGlobales.IdUsuario;
            Mantenimiento.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Listado();
        }

        private void txtNumeroPagina_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroPagina.Value < 1)
            {
                txtNumeroPagina.Value = 1;
                Listado();
            }
            else
            {
                Listado();
            }
        }

        private void txtNumeroRegistros_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroRegistros.Value < 1)
            {
                txtNumeroRegistros.Value = 1;
                Listado();
            }
            else
            {
                Listado();
            }
        }

        private void dtListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("¿Quieres seleccionar este registro?", variablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.variablesGlobales.IdMantenimeinto = Convert.ToDecimal(this.dtListado.CurrentRow.Cells["IdUnidadMedida"].Value.ToString());

                var Seleccionr = ObjDataInventario.Value.BuscaUnidadMedida(
                    variablesGlobales.IdMantenimeinto,
                    null,
                    1, 1);
                dtListado.DataSource = Seleccionr;
                OcultarColumnas();
                txtNumeroPagina.Enabled = false;
                txtNumeroRegistros.Enabled = false;
                btnBuscar.Enabled = false;
                btnNuevo.Enabled = false;
                btnEditar.Enabled = true;
                //btnDeshabilitar.Enabled = true;
            }

        }
    }
}
