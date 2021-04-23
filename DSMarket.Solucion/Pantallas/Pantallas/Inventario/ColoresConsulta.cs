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
    public partial class ColoresConsulta : Form
    {
        public ColoresConsulta()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaInventario.LogicaInventario> ObjDataInventario = new Lazy<Logica.Logica.LogicaInventario.LogicaInventario>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        private void ListadoCOlores() {
            string _Colores = string.IsNullOrEmpty(txtColor.Text.Trim()) ? null : txtColor.Text.Trim();
            int CantidadRegistros = 0;

            var Buscar = ObjDataInventario.Value.BuscaColores(
                new Nullable<decimal>(),
                _Colores,
                (int)txtNumeroPagina.Value,
                (int)txtNumeroRegistros.Value);
            if (Buscar.Count() < 1) {
                lbCantidadRegistrosVariable.Text = "0";
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
            this.dtListado.Columns["IdColor"].Visible = false;
            this.dtListado.Columns["Estatus0"].Visible = false;
        }

        private void ColoresConsulta_Load(object sender, EventArgs e)
        {
            lbTitulo.Text = "CONSULTA DE COLORES";
            lbTitulo.ForeColor = Color.White;
            lbCantidadRegistrosTitulo.ForeColor = Color.White;
            lbCantidadRegistrosVariable.ForeColor = Color.White;
            ListadoCOlores();
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
        }

        private void txtNumeroPagina_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroPagina.Value < 1) {
                txtNumeroPagina.Value = 1;
                ListadoCOlores();
            }
            else {
                ListadoCOlores();
            }
        }

        private void txtNumeroRegistros_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroRegistros.Value < 1) {
                txtNumeroRegistros.Value = 10;
                ListadoCOlores();
            }
            else {
                ListadoCOlores();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ListadoCOlores();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.ColoresMantenimiento Mantenimiento = new ColoresMantenimiento();
            Mantenimiento.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Mantenimiento.VariablesGlobales.IdMantenimeinto = 0;
            Mantenimiento.VariablesGlobales.Accion = "INSERT";
            Mantenimiento.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.ColoresMantenimiento Mantenimiento = new ColoresMantenimiento();
            Mantenimiento.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Mantenimiento.VariablesGlobales.IdMantenimeinto = VariablesGlobales.IdMantenimeinto;
            Mantenimiento.VariablesGlobales.Accion = "UPDATE";
            Mantenimiento.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.ColoresMantenimiento Mantenimiento = new ColoresMantenimiento();
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
            txtNumeroPagina.Value = 1;
            txtNumeroRegistros.Value = 10;
            txtNumeroPagina.Enabled = true;
            txtNumeroRegistros.Enabled = true;
            ListadoCOlores();
        }

        private void dtListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.VariablesGlobales.IdMantenimeinto = Convert.ToDecimal(this.dtListado.CurrentRow.Cells["IdColor"].Value.ToString());

            var Seleccionar = ObjDataInventario.Value.BuscaColores(VariablesGlobales.IdMantenimeinto, null, 1, 1);
            dtListado.DataSource = Seleccionar;
            OcultarColumnas();
            btnNuevo.Enabled = false;
            btnBuscar.Enabled = false;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            txtNumeroPagina.Enabled = false;
            txtNumeroRegistros.Enabled = false;
            lbCantidadRegistrosVariable.Text = "1";
        }

        private void ColoresConsulta_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
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
