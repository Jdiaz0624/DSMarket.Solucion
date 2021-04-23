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
    public partial class ModelosConsulta : Form
    {
        public ModelosConsulta()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaListas.LogicaListas> ObjDataListas = new Lazy<Logica.Logica.LogicaListas.LogicaListas>();
        Lazy<DSMarket.Logica.Logica.LogicaInventario.LogicaInventario> ObjDataInventario = new Lazy<Logica.Logica.LogicaInventario.LogicaInventario>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        private void CargarMarcas() {
        
            try
            {
                var Marcas = ObjDataListas.Value.BucaLisaMarcas(new Nullable<decimal>());
                ddlMarca.DataSource = Marcas;
                ddlMarca.DisplayMember = "Descripcion";
                ddlMarca.ValueMember = "IdMarca";

            }
            catch (Exception) { }
        }

        private void CargarListadoModelos() {

            decimal? Marca = cbAgregarMarcaFiltro.Checked == true ? Convert.ToDecimal(ddlMarca.SelectedValue) : new Nullable<decimal>();
            string _Modelo = string.IsNullOrEmpty(txtModelo.Text.Trim()) ? null : txtModelo.Text.Trim();
            int CantidadRegistros = 0;
            var Buscar = ObjDataInventario.Value.BuscaModelos(
                Marca,
                null,
                _Modelo,
                (int)txtNumeroPagina.Value,
                (int)txtNumeroRegistros.Value);
            if (Buscar.Count() < 1) {
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
         
                this.dtListado.Columns["IdMarca"].Visible = false;
                this.dtListado.Columns["IdModelo"].Visible = false;
                this.dtListado.Columns["Estatus0"].Visible = false;
          
        }
        private void ModelosConsulta_Load(object sender, EventArgs e)
        {
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            CargarMarcas();
            CargarListadoModelos();
            lbTitulo.ForeColor = Color.White;
            lbTitulo.Text = "CONSULTA DE MODELOS";
            lbCantidadRegistrosTitulo.ForeColor = Color.White;
            lbCantidadRegistrosVariable.ForeColor = Color.White;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarListadoModelos();
        }

        private void txtNumeroPagina_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroPagina.Value < 1) {
                txtNumeroPagina.Value = 1;
                CargarListadoModelos();
            }
            else {
                CargarListadoModelos();
            }
        }

        private void txtNumeroRegistros_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroRegistros.Value < 1) {
                txtNumeroRegistros.Value = 10;
                CargarListadoModelos();
            }
            else {
                CargarListadoModelos();
            }
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ModelosConsulta_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason) {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void dtListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.VariablesGlobales.IdMantenimeinto = Convert.ToDecimal(this.dtListado.CurrentRow.Cells["IdModelo"].Value.ToString());

            var BuscarRegistroseleccionado = ObjDataInventario.Value.BuscaModelos(new Nullable<decimal>(), VariablesGlobales.IdMantenimeinto, null, 1, 1);
            dtListado.DataSource = BuscarRegistroseleccionado;
            lbCantidadRegistrosVariable.Text = "1";
            btnNuevo.Enabled = false;
            btnBuscar.Enabled = false;
            btnEliminar.Enabled = true;
            btnEditar.Enabled = true;
            button1.Enabled = true;
            txtNumeroPagina.Enabled = false;
            txtNumeroRegistros.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnNuevo.Enabled = true;
            btnBuscar.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            button1.Enabled = true;
            txtNumeroPagina.Enabled = true;
            txtNumeroRegistros.Enabled = true;
            txtNumeroPagina.Value = 1;
            txtNumeroRegistros.Value = 10;
            CargarMarcas();
            cbAgregarMarcaFiltro.Checked = false;
            CargarListadoModelos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.ModelosMantenimiento Mantenimiento = new ModelosMantenimiento();
            Mantenimiento.VariablesGlobales.IdMantenimeinto = 0;
            Mantenimiento.VariablesGlobales.Accion = "INSERT";
            Mantenimiento.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Mantenimiento.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.ModelosMantenimiento Mantenimiento = new ModelosMantenimiento();
            Mantenimiento.VariablesGlobales.IdMantenimeinto = VariablesGlobales.IdMantenimeinto;
            Mantenimiento.VariablesGlobales.Accion = "UPDATE";
            Mantenimiento.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Mantenimiento.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.ModelosMantenimiento Mantenimiento = new ModelosMantenimiento();
            Mantenimiento.VariablesGlobales.IdMantenimeinto = VariablesGlobales.IdMantenimeinto;
            Mantenimiento.VariablesGlobales.Accion = "DELETE";
            Mantenimiento.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Mantenimiento.ShowDialog();
        }
    }
}
