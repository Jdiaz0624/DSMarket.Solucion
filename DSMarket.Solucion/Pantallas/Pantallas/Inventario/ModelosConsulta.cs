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
        Lazy<DSMarket.Logica.Logica.LogicaInventario.LogicaInventario> ObjdataInventario = new Lazy<Logica.Logica.LogicaInventario.LogicaInventario>();
        Lazy<DSMarket.Logica.Logica.LogicaSeguridad.LogicaSeguridad> ObjdataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad.LogicaSeguridad>();
        Lazy<DSMarket.Logica.Logica.LogicaListas.LogicaListas> ObjDataListas = new Lazy<Logica.Logica.LogicaListas.LogicaListas>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();


        #region CARGAR LISTAS
        private void CargarListas()
        {
            var Cargar = ObjDataListas.Value.BucaLisaMarcas(
                Convert.ToDecimal(ddlSelecionarCategoria.SelectedValue));
            ddlSeleccionarMarcas.DataSource = Cargar;
            ddlSeleccionarMarcas.ValueMember = "IdMarca";
            ddlSeleccionarMarcas.DisplayMember = "Descripcion";
        }
        #endregion
        #region RESTABLECER
        private void RestablcerPantalla() {
            txtNumeroPagina.Enabled = true;
            txtNumeroRegistros.Enabled = true;
            txtNumeroPagina.Value = 1;
            txtNumeroRegistros.Value = 10;
            CargarListas();
            txtModelos.Text = String.Empty;
            btnBuscar.Enabled = true;
            btnNuevo.Enabled = true;
            btnEditar.Enabled = false;
         //   btnDeshabilitar.Enabled = false;
            MostrarListado();
        }
        #endregion
        #region MOSTRAR LISTADO DE MODELOS
        private void MostrarListado() {
            try {
                string _Modelos = string.IsNullOrEmpty(txtModelos.Text.Trim()) ? null : txtModelos.Text.Trim();

                var BuscarRegistros = ObjdataInventario.Value.BuscaModelos(
                    Convert.ToDecimal(ddlSeleccionarTipoProducto.SelectedValue),
                    Convert.ToDecimal(ddlSelecionarCategoria.SelectedValue),
                    Convert.ToDecimal(ddlSeleccionarMarcas.SelectedValue),
                    new Nullable<decimal>(),
                    _Modelos,
                    Convert.ToInt32(txtNumeroPagina.Value),
                    Convert.ToInt32(txtNumeroRegistros.Value));
                dtListado.DataSource = BuscarRegistros;
                if (BuscarRegistros.Count() < 1)
                {
                    lbCantidadRegistrosVariable.Text = "0";
                }
                else
                {
                    foreach (var n in BuscarRegistros)
                    {
                        int cantidad = Convert.ToInt32(n.CantidadRegistros);
                        lbCantidadRegistrosVariable.Text = cantidad.ToString("N0");
                    }
                }
                OcultarColumnas();
            }
            catch (Exception ex) {
                MessageBox.Show("Error al mostrar el listado de modelos, codigo de error: " + ex.Message, VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void OcultarColumnas() {
            this.dtListado.Columns["IdMarca"].Visible = false;
            this.dtListado.Columns["IdModelo"].Visible = false;
            this.dtListado.Columns["Estatus0"].Visible = false;
            this.dtListado.Columns["UsuarioAdiciona"].Visible = false;
            this.dtListado.Columns["FechaAdiciona"].Visible = false;
            this.dtListado.Columns["UsuarioModifica"].Visible = false;
            this.dtListado.Columns["ModificadoPor"].Visible = false;
            this.dtListado.Columns["FechaModifica"].Visible = false;
            this.dtListado.Columns["FechaModificado"].Visible = false;
            this.dtListado.Columns["CantidadRegistros"].Visible = false;
            this.dtListado.Columns["IdTipoProducto"].Visible = false;
            this.dtListado.Columns["IdCategoria"].Visible = false;
        }
        #endregion
        #region CARGAR LAS CATEGORIAS
        private void CargarCategorias()
        {
            var Categorias = ObjDataListas.Value.ListadoCategorias(
                Convert.ToDecimal(ddlSeleccionarTipoProducto.SelectedValue));
            ddlSelecionarCategoria.DataSource = Categorias;
            ddlSelecionarCategoria.DisplayMember = "Descripcion";
            ddlSelecionarCategoria.ValueMember = "IdCategoria";
        }
        #endregion
        #region CARGAR LOS TIPOS DE PRODUCTOS
        private void CargarTipoProductos()
        {
            var TipoProducto = ObjDataListas.Value.ListaTipoProducto(
                new Nullable<decimal>(),
                null);
            ddlSeleccionarTipoProducto.DataSource = TipoProducto;
            ddlSeleccionarTipoProducto.DisplayMember = "Descripcion";
            ddlSeleccionarTipoProducto.ValueMember = "IdTipoproducto";
        }
        #endregion
        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ModelosConsulta_Load(object sender, EventArgs e)
        {
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            CargarTipoProductos();
            CargarCategorias();
            CargarListas();
            this.BackColor = SystemColors.Control;
            dtListado.BackgroundColor = SystemColors.Control;
            ddlSeleccionarMarcas.BackColor = Color.WhiteSmoke;
            txtModelos.BackColor = Color.WhiteSmoke;
            txtNumeroPagina.BackColor = Color.WhiteSmoke;
            txtNumeroRegistros.BackColor = Color.WhiteSmoke;
            lbTitulo.Text = "CONSULTA DE MODELOS";
            lbTitulo.ForeColor = Color.WhiteSmoke;
            lbCantidadRegistrosTitulo.ForeColor = Color.WhiteSmoke;
            lbCantidadRegistrosVariable.ForeColor = Color.WhiteSmoke;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.MantenimientoModelos Mantenimietnto = new MantenimientoModelos();
            Mantenimietnto.VariablesGlobales.ModoRecarga = false;
            Mantenimietnto.VariablesGlobales.Accion = "INSERT";
            Mantenimietnto.VariablesGlobales.IdMantenimeinto = 0;
            Mantenimietnto.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Mantenimietnto.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.MantenimientoModelos Mantenimietnto = new MantenimientoModelos();
            Mantenimietnto.VariablesGlobales.Accion = "UPDATE";
            Mantenimietnto.VariablesGlobales.IdMantenimeinto = VariablesGlobales.IdMantenimeinto;
            Mantenimietnto.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Mantenimietnto.ShowDialog();
        }

        private void ModelosConsulta_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
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
            else
            {
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
            else
            {
                MostrarListado();
            }
        }

        private void dtListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("¿Quieres seleccionar este registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.VariablesGlobales.IdMantenimeinto = Convert.ToDecimal(this.dtListado.CurrentRow.Cells["IdModelo"].Value.ToString());

                var Seleccionar = ObjdataInventario.Value.BuscaModelos(
                    null,
                    null,
                    null,
                    VariablesGlobales.IdMantenimeinto,
                    null, 1, 1);
                dtListado.DataSource = Seleccionar;
                OcultarColumnas();
                foreach (var n in Seleccionar)
                {
                    int Cantidad = Convert.ToInt32(n.CantidadRegistros);
                    lbCantidadRegistrosVariable.Text = Cantidad.ToString("N0");
                }
                btnBuscar.Enabled = false;
                btnNuevo.Enabled = false;btnEditar.Enabled = true;
                txtNumeroPagina.Enabled = false;
                txtNumeroRegistros.Enabled = false;
            }
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            RestablcerPantalla();
        }

        private void ddlSeleccionarTipoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                CargarCategorias();
            }
            catch (Exception) { }
        }

        private void ddlSelecionarCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                CargarListas();
            }
            catch (Exception) { }
        }
    }
}
