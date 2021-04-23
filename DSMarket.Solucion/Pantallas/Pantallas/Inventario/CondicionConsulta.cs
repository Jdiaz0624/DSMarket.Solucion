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
    public partial class CondicionConsulta : Form
    {
        public CondicionConsulta()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaInventario.LogicaInventario> ObjDataInventario = new Lazy<Logica.Logica.LogicaInventario.LogicaInventario>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        private void ListadoCondiciones() {
            string _Condicion = string.IsNullOrEmpty(txtCondicion.Text.Trim()) ? null : txtCondicion.Text.Trim();
            int CantidadRegistros = 0;
            var Listado = ObjDataInventario.Value.BuscaCondiciones(new Nullable<decimal>(), _Condicion, (int)txtNumeroPagina.Value, (int)txtNumeroRegistros.Value);
            if (Listado.Count() < 1) {
                lbCantidadRegistrosVariable.Text = "0";
                dtListado.DataSource = null;
            }
            else {
                CantidadRegistros = Listado.Count;
                lbCantidadRegistrosVariable.Text = CantidadRegistros.ToString("N0");
                dtListado.DataSource = Listado;
                OcultarColumnas();
            }
        }
        private void OcultarColumnas() {
            this.dtListado.Columns["IdCondicion"].Visible = false;
            this.dtListado.Columns["Estatus0"].Visible = false;
        }

        private void CondicionConsulta_Load(object sender, EventArgs e)
        {
            ListadoCondiciones();
            lbCantidadRegistrosTitulo.ForeColor = Color.White;
            lbCantidadRegistrosVariable.ForeColor = Color.White;
            lbTitulo.ForeColor = Color.White;
            lbTitulo.Text = "CONSULTA DE CONDICIONES";
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ListadoCondiciones();
        }

        private void txtNumeroPagina_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroPagina.Value < 1)
            {
                txtNumeroPagina.Value = 1;
                ListadoCondiciones();
            }
            else {
                ListadoCondiciones();
            }
        }

        private void txtNumeroRegistros_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroRegistros.Value < 1) {
                txtNumeroRegistros.Value = 10;
                ListadoCondiciones();
            }
            else {
                ListadoCondiciones();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.MantenimientoCondiciones Condicion = new MantenimientoCondiciones();
            Condicion.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Condicion.VariablesGlobales.IdMantenimeinto = 0;
            Condicion.VariablesGlobales.Accion = "INSERT";
            Condicion.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.MantenimientoCondiciones Condicion = new MantenimientoCondiciones();
            Condicion.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Condicion.VariablesGlobales.IdMantenimeinto = VariablesGlobales.IdMantenimeinto;
            Condicion.VariablesGlobales.Accion = "UPDATE";
            Condicion.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.MantenimientoCondiciones Condicion = new MantenimientoCondiciones();
            Condicion.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Condicion.VariablesGlobales.IdMantenimeinto = VariablesGlobales.IdMantenimeinto;
            Condicion.VariablesGlobales.Accion = "DELETE";
            Condicion.ShowDialog();
        }

        private void dtListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            VariablesGlobales.IdMantenimeinto = Convert.ToDecimal(this.dtListado.CurrentRow.Cells["IdCondicion"].Value.ToString());

            var Seleccioar = ObjDataInventario.Value.BuscaCondiciones(VariablesGlobales.IdMantenimeinto, null, 1, 1);
            dtListado.DataSource = Seleccioar;
            OcultarColumnas();
            btnBuscar.Enabled = false;
            btnNuevo.Enabled = false;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            txtNumeroPagina.Enabled = false;
            txtNumeroRegistros.Enabled = false;
            lbCantidadRegistrosVariable.Text = "1";
        }

        private void CondicionConsulta_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason) {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            btnBuscar.Enabled = true;
            btnNuevo.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            txtCondicion.Text = string.Empty;
            ListadoCondiciones();
        }
    }
}
