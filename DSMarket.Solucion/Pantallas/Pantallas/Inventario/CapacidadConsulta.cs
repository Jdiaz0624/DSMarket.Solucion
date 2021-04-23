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
    public partial class CapacidadConsulta : Form
    {
        public CapacidadConsulta()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaInventario.LogicaInventario> ObjDataInventario = new Lazy<Logica.Logica.LogicaInventario.LogicaInventario>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        private void ListadoCapacidad() {
            string _Capacidad = string.IsNullOrEmpty(txtCapacidad.Text.Trim()) ? null : txtCapacidad.Text.Trim();
            int CantidadRegistros = 0;

            var Listado = ObjDataInventario.Value.BuscaCapacidad(
                new Nullable<decimal>(),
                _Capacidad,
                (int)txtNumeroPagina.Value,
                (int)txtNumeroRegistros.Value);
            if (Listado.Count() < 1) {
                lbCantidadRegistrosVariable.Text = "0";
                dtListado.DataSource = null;
            }
            else {
                dtListado.DataSource = Listado;
                CantidadRegistros = Listado.Count;
                lbCantidadRegistrosVariable.Text = CantidadRegistros.ToString("N0");
                OcultarColumna();
            }

        }

        private void OcultarColumna() {
            this.dtListado.Columns["IdCapacidad"].Visible = false;
            this.dtListado.Columns["Estatus0"].Visible = false;
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void CapacidadConsulta_Load(object sender, EventArgs e)
        {
            lbTitulo.Text = "CONSULTA DE CAPACIDAD";
            lbTitulo.ForeColor = Color.White;
            lbCantidadRegistrosTitulo.ForeColor = Color.White;
            lbCantidadRegistrosVariable.ForeColor = Color.White;
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            ListadoCapacidad();
        }

        private void txtNumeroPagina_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroPagina.Value < 1) {
                txtNumeroPagina.Value = 1;
                ListadoCapacidad();
            }
            else {
                ListadoCapacidad();
            }
        }

        private void txtNumeroRegistros_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroRegistros.Value < 1) {
                txtNumeroRegistros.Value = 10;
                ListadoCapacidad();
            }
            else {
                ListadoCapacidad();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ListadoCapacidad();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.MantenimientoCapacidad Mantenimiento = new MantenimientoCapacidad();
            Mantenimiento.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Mantenimiento.VariablesGlobales.IdMantenimeinto = 0;
            Mantenimiento.VariablesGlobales.Accion = "INSERT";
            Mantenimiento.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.MantenimientoCapacidad Mantenimiento = new MantenimientoCapacidad();
            Mantenimiento.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Mantenimiento.VariablesGlobales.IdMantenimeinto = VariablesGlobales.IdMantenimeinto;
            Mantenimiento.VariablesGlobales.Accion = "UPDATE";
            Mantenimiento.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.MantenimientoCapacidad Mantenimiento = new MantenimientoCapacidad();
            Mantenimiento.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Mantenimiento.VariablesGlobales.IdMantenimeinto = VariablesGlobales.IdMantenimeinto;
            Mantenimiento.VariablesGlobales.Accion = "DELETE";
            Mantenimiento.ShowDialog();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            btnBuscar.Enabled = true;
            btnNuevo.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            txtNumeroPagina.Enabled = true;
            txtNumeroRegistros.Enabled = true;
            txtNumeroPagina.Value = 1;
            txtNumeroRegistros.Value = 10;
            ListadoCapacidad();
        }

        private void dtListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.VariablesGlobales.IdMantenimeinto = Convert.ToDecimal(this.dtListado.CurrentRow.Cells["IdCapacidad"].Value.ToString());

            var Seleccionar = ObjDataInventario.Value.BuscaCapacidad(VariablesGlobales.IdMantenimeinto, null, 1, 1);
            dtListado.DataSource = Seleccionar;
            OcultarColumna();
            btnBuscar.Enabled = false;
            btnNuevo.Enabled = false;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            txtNumeroPagina.Enabled = false;
            txtNumeroRegistros.Enabled = false;
        }

        private void CapacidadConsulta_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason) {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }
    }
}
