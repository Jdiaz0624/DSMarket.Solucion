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
    public partial class CapacidadConulta : Form
    {
        Lazy<DSMarket.Logica.Logica.LogicaInventario.LogicaInventario> ObjdataInventario = new Lazy<Logica.Logica.LogicaInventario.LogicaInventario>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region MOSTRAR EL LISTADO DE LAS CAPACIDADES
        private void MostrarListado() {
            string _Capacidad = string.IsNullOrEmpty(txtCapacidadConsulta.Text.Trim()) ? null : txtCapacidadConsulta.Text.Trim();

            var Listado = ObjdataInventario.Value.CapacidadArticulos(
                new Nullable<decimal>(),
                _Capacidad,
                Convert.ToInt32(txtNumeroPagina.Value),
                Convert.ToInt32(txtNumeroRegistros.Value));
            dtListado.DataSource = Listado;
            OcultarColumnas();
            if (Listado.Count() < 1)
            {
                lbCantidadRegistrosVariable.Text = "0";
            }
            else {

                foreach (var n in Listado) {
                    decimal Cantidad = Convert.ToDecimal(n.CantidadRegistros);
                    lbCantidadRegistrosVariable.Text = Cantidad.ToString("N0");
                }
            }
        }
        private void OcultarColumnas() {
            this.dtListado.Columns["IdCapacidad"].Visible = false;
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
        public CapacidadConulta()
        {
            InitializeComponent();
        }

        private void CapacidadConulta_Load(object sender, EventArgs e)
        {
            lbTitulo.Text = "CAPACIDAD CONSULTA";
            lbTitulo.ForeColor = Color.White;
            lbCantidadRegistrosTitulo.ForeColor = Color.White;
            lbCantidadRegistrosVariable.ForeColor = Color.White;
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MostrarListado();
        }

        private void txtNumeroPagina_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroPagina.Value < 1)
            {
                txtNumeroPagina.Value = 1;
                MostrarListado();
            }
            else {
                MostrarListado();
            }
        }

        private void txtNumeroRegistros_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroRegistros.Value < 1)
            {
                txtNumeroRegistros.Value = 10;
                MostrarListado();
            }
            else {
                MostrarListado();
            }
        }

        private void CapacidadConulta_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason) {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void dtListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("¿Quieres seleccionar este registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                this.VariablesGlobales.IdMantenimeinto = Convert.ToDecimal(this.dtListado.CurrentRow.Cells["IdCapacidad"].Value.ToString());

                var Seleccionar = ObjdataInventario.Value.CapacidadArticulos(VariablesGlobales.IdMantenimeinto, null, 1, 1);
                dtListado.DataSource = Seleccionar;
                btnBuscar.Enabled = false;
                btnNuevo.Enabled = false;
                btnEditar.Enabled = true;
                txtNumeroPagina.Enabled = false;
                txtNumeroRegistros.Enabled = false;
            }
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            btnBuscar.Enabled = true;
            btnNuevo.Enabled = true;
            btnEditar.Enabled = false;
            txtNumeroPagina.Enabled = true;
            txtNumeroRegistros.Enabled = true;
            txtNumeroPagina.Value = 1;
            txtNumeroRegistros.Value = 10;
            txtCapacidadConsulta.Text = string.Empty;

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.CapacidadMantenimiento Mantenimiento = new CapacidadMantenimiento();
            Mantenimiento.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Mantenimiento.VariablesGlobales.IdMantenimeinto = 0;
            Mantenimiento.VariablesGlobales.Accion = "INSERT";
            Mantenimiento.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.CapacidadMantenimiento Mantenimiento = new CapacidadMantenimiento();
            Mantenimiento.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Mantenimiento.VariablesGlobales.IdMantenimeinto = VariablesGlobales.IdMantenimeinto;
            Mantenimiento.VariablesGlobales.Accion = "UPDATE";
            Mantenimiento.ShowDialog();
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
