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
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        private void ListadoUnidadMedida() {
            string _UnidadMedida = string.IsNullOrEmpty(txtUnidadMedida.Text.Trim()) ? null : txtUnidadMedida.Text.Trim();
            int CantidadRegistros = 0;
            var Buscar = ObjDataInventario.Value.BuscaUnidadMedida(
                new Nullable<decimal>(),
                _UnidadMedida,
                (int)txtNumeroPagina.Value,
                (int)txtNumeroRegistros.Value);
            if (Buscar.Count() < 1)
            {
                lbCantidadRegistrosVariable.Text = "0";
                dtListado.DataSource = null;
            }
            else {
                 CantidadRegistros = Buscar.Count;
                lbCantidadRegistrosVariable.Text = CantidadRegistros.ToString("N0");
                dtListado.DataSource = Buscar;
            }
            if (CantidadRegistros > 0) {
                OcultarColumnas();
            }
           
        }
        private void OcultarColumnas() {
            this.dtListado.Columns["IdUnidadMedida"].Visible = false;
            this.dtListado.Columns["Estatus0"].Visible = false;
        }
        private void UnidadMedidaConsulta_Load(object sender, EventArgs e)
        {
            lbTitulo.Text = "CONSULTA DE UNIDAD DE MEDIDA";
            lbTitulo.ForeColor = Color.White;
            lbCantidadRegistrosTitulo.ForeColor = Color.White;
            lbCantidadRegistrosVariable.ForeColor = Color.White;
            ListadoUnidadMedida();

            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ListadoUnidadMedida();
        }

        private void txtNumeroPagina_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroPagina.Value < 1) {
                txtNumeroPagina.Value = 1;
                ListadoUnidadMedida();
            }
            else {
                ListadoUnidadMedida();
            }
        }

        private void txtNumeroRegistros_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroRegistros.Value < 1) {
                txtNumeroRegistros.Value = 10;
                ListadoUnidadMedida();
            }
            else {
                ListadoUnidadMedida();
            }
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void UnidadMedidaConsulta_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason) {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.UnidadMedidaMantenimiento Mantenimiento = new UnidadMedidaMantenimiento();
            Mantenimiento.VariablesGlobales.IdMantenimeinto = 0;
            Mantenimiento.VariablesGlobales.Accion = "INSERT";
            Mantenimiento.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Mantenimiento.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.UnidadMedidaMantenimiento Mantenimiento = new UnidadMedidaMantenimiento();
            Mantenimiento.VariablesGlobales.IdMantenimeinto = VariablesGlobales.IdMantenimeinto;
            Mantenimiento.VariablesGlobales.Accion = "UPDATE";
            Mantenimiento.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Mantenimiento.ShowDialog();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            btnBuscar.Enabled = true;
            btnNuevo.Enabled = true;
            btnEditar.Enabled = false;
            txtNumeroPagina.Enabled = true;
            btnEliminar.Enabled = false;
            txtNumeroRegistros.Enabled = true;
            txtNumeroPagina.Value = 1;
            txtNumeroRegistros.Value = 10;
            txtUnidadMedida.Text = string.Empty;
            ListadoUnidadMedida();
        }

        private void dtListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            VariablesGlobales.IdMantenimeinto = Convert.ToDecimal(this.dtListado.CurrentRow.Cells["IdUnidadMedida"].Value.ToString());

            var Seleccionar = ObjDataInventario.Value.BuscaUnidadMedida(VariablesGlobales.IdMantenimeinto, null, 1, 1);
            dtListado.DataSource = Seleccionar;
            OcultarColumnas();
            lbCantidadRegistrosVariable.Text = "1";
            btnBuscar.Enabled = false;
            btnNuevo.Enabled = false; btnEliminar.Enabled = true;
            btnEditar.Enabled = true;
            btnRestablecer.Enabled = true;
            txtNumeroPagina.Enabled = false;
            txtNumeroRegistros.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.UnidadMedidaMantenimiento Mantenimiento = new UnidadMedidaMantenimiento();
            Mantenimiento.VariablesGlobales.IdMantenimeinto = VariablesGlobales.IdMantenimeinto;
            Mantenimiento.VariablesGlobales.Accion = "DELETE";
            Mantenimiento.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Mantenimiento.ShowDialog();
        }
    }
}
