using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSMarket.Solucion.Pantallas.Pantallas.Servicio
{
    public partial class AgregarProductos : Form
    {
        public AgregarProductos()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaListas.LogicaListas> ObjDataListas = new Lazy<Logica.Logica.LogicaListas.LogicaListas>();
        Lazy<DSMarket.Logica.Logica.LogicaServicio.LogicaServicio> ObjDataServicio = new Lazy<Logica.Logica.LogicaServicio.LogicaServicio>();
        Lazy<DSMarket.Logica.Logica.LogicaInventario.LogicaInventario> ObjDataLogicaInventario = new Lazy<Logica.Logica.LogicaInventario.LogicaInventario>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlbales = new Logica.Comunes.VariablesGlobales();

        #region APLICAR TEMA
        private void TemaGenerico() {
            this.BackColor= SystemColors.Control;


            ddlTipoProducto.BackColor = Color.WhiteSmoke;
            //txtCodigo.BackColor = Color.WhiteSmoke;
            txtCodigoBarras.BackColor = Color.WhiteSmoke;
            txtReferencia.BackColor = Color.WhiteSmoke;
            ddlCategoria.BackColor = Color.WhiteSmoke;
            txtDescripcion.BackColor = Color.WhiteSmoke;
            txtNumeroPagina.BackColor = Color.WhiteSmoke;
            txtNumeroRegistros.BackColor = Color.WhiteSmoke;
            txtTipoProducto.BackColor = Color.WhiteSmoke;
            txtCategoria.BackColor = Color.WhiteSmoke;
            txtProducto.BackColor = Color.WhiteSmoke;
            txtCantidadDisponible.BackColor = Color.WhiteSmoke;
            txtCantidadUsar.BackColor = Color.WhiteSmoke;
            txtPrecio.BackColor = Color.WhiteSmoke;
            txtPorcientoDescyento.BackColor = Color.WhiteSmoke;
            txtDescuento.BackColor = Color.WhiteSmoke;
            txtAcumulativo.BackColor = Color.WhiteSmoke;

            ddlTipoProducto.ForeColor = Color.Black;
      //    txtCodigo.ForeColor = Color.Black;
            txtCodigoBarras.ForeColor = Color.Black;
            txtReferencia.ForeColor = Color.Black;
            ddlCategoria.ForeColor = Color.Black;
            txtDescripcion.ForeColor = Color.Black;
            txtNumeroPagina.ForeColor = Color.Black;
            txtNumeroRegistros.ForeColor = Color.Black;
            txtTipoProducto.ForeColor = Color.Black;
            txtCategoria.ForeColor = Color.Black;
            txtProducto.ForeColor = Color.Black;
            txtCantidadDisponible.ForeColor = Color.Black;
            txtCantidadUsar.ForeColor = Color.Black;
            txtPrecio.ForeColor = Color.Black;
            txtPorcientoDescyento.ForeColor = Color.Black;
            txtDescuento.ForeColor = Color.Black;
            txtAcumulativo.ForeColor = Color.Black;


            dtSeleccionarproducto.BackgroundColor = SystemColors.Control;
            dtProductosAgregados.BackgroundColor = SystemColors.Control;

        }
        #endregion
        #region CARGAR LAS LISTAS DESPLEGABLES
        //GARGAR LOS TIPOS DE PRODUCTOS
        private void CargarTipoPrductos() {
            var TipoProducto = ObjDataListas.Value.ListaTipoProducto(
                new Nullable<decimal>(),
                null);
            ddlTipoProducto.DataSource = TipoProducto;
            ddlTipoProducto.DisplayMember = "Descripcion";
            ddlTipoProducto.ValueMember = "IdTipoproducto";
        }
        private void CargarCategorias() {
            try {
                var CargarCategorias = ObjDataListas.Value.ListadoCategorias(
                    Convert.ToDecimal(ddlTipoProducto.SelectedValue));
                ddlCategoria.DataSource = CargarCategorias;
                ddlCategoria.DisplayMember = "Descripcion";
                ddlCategoria.ValueMember = "IdCategoria";
            }
            catch (Exception) { }
        }
        #endregion
        #region MOSTRAR EL LISTADO DE LOS PRODUCTOS
        private void MostrarListadoProductos() {
            try {
                string _Descripcion = string.IsNullOrEmpty(txtDescripcion.Text.Trim()) ? null : txtDescripcion.Text.Trim();
                string _CodigoBarra = string.IsNullOrEmpty(txtCodigoBarras.Text.Trim()) ? null : txtCodigoBarras.Text.Trim();
                string _Referencia = string.IsNullOrEmpty(txtReferencia.Text.Trim()) ? null : txtReferencia.Text.Trim();

                if (cbAgregarCategorias.Checked == true)
                {
                    var BuscaRegistros = ObjDataLogicaInventario.Value.BuscaProductos(
                        new Nullable<decimal>(),
                        null,
                        _Descripcion,
                        _CodigoBarra,
                        _Referencia,
                        null,
                        null,
                        Convert.ToDecimal(ddlTipoProducto.SelectedValue),
                        Convert.ToDecimal(ddlCategoria.SelectedValue),
                        null,
                        null,
                        null,
                        null,
                        Convert.ToInt32(txtNumeroPagina.Value),
                        Convert.ToInt32(txtNumeroRegistros.Value));
                    dtSeleccionarproducto.DataSource = BuscaRegistros;
                    OcultarColumnas();
                }
                else
                {
                    var BuscaRegistros = ObjDataLogicaInventario.Value.BuscaProductos(
                          new Nullable<decimal>(),
                          null,
                          _Descripcion,
                          _CodigoBarra,
                          _Referencia,
                          null,
                          null,
                          Convert.ToDecimal(ddlTipoProducto.SelectedValue),
                          null,
                          null,
                          null,
                          null,
                          null,
                          Convert.ToInt32(txtNumeroPagina.Value),
                          Convert.ToInt32(txtNumeroRegistros.Value));
                    dtSeleccionarproducto.DataSource = BuscaRegistros;
                    OcultarColumnas();

                }
            }
            catch (Exception ex) {
                MessageBox.Show("Error al mostrar el listado de los productos, codigo de error--> " + ex.Message, VariablesGlbales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void OcultarColumnas() {

        
            this.dtSeleccionarproducto.Columns["IdProducto"].Visible = false;
            this.dtSeleccionarproducto.Columns["NumeroConector"].Visible = false;
            this.dtSeleccionarproducto.Columns["IdTipoProducto"].Visible = false;
            this.dtSeleccionarproducto.Columns["IdCategoria"].Visible = false;
            this.dtSeleccionarproducto.Columns["IdUnidadMedida"].Visible = false;
            this.dtSeleccionarproducto.Columns["IdMarca"].Visible = false;
            this.dtSeleccionarproducto.Columns["IdModelo"].Visible = false;
            this.dtSeleccionarproducto.Columns["IdTipoSuplidor"].Visible = false;
            this.dtSeleccionarproducto.Columns["IdSuplidor"].Visible = false;
            this.dtSeleccionarproducto.Columns["PrecioCompra"].Visible = false;
            this.dtSeleccionarproducto.Columns["AfectaOferta0"].Visible = false;
            this.dtSeleccionarproducto.Columns["ProductoAcumulativo0"].Visible = false;
            this.dtSeleccionarproducto.Columns["LlevaImagen0"].Visible = false;
            this.dtSeleccionarproducto.Columns["UsuarioAdicion"].Visible = false;
            this.dtSeleccionarproducto.Columns["FechaAdiciona"].Visible = false;
            this.dtSeleccionarproducto.Columns["UsuarioModifica"].Visible = false;
            this.dtSeleccionarproducto.Columns["ModificadoPor"].Visible = false;
            this.dtSeleccionarproducto.Columns["FechaModifica"].Visible = false;
            this.dtSeleccionarproducto.Columns["FechaModificado"].Visible = false;
            this.dtSeleccionarproducto.Columns["Fecha"].Visible = false;
            this.dtSeleccionarproducto.Columns["CantidadRegistros"].Visible = false;
            this.dtSeleccionarproducto.Columns["ProductosConOferta"].Visible = false;
            this.dtSeleccionarproducto.Columns["ProductoProximoAgotarse"].Visible = false;
            this.dtSeleccionarproducto.Columns["ProductosAgostados"].Visible = false;
            this.dtSeleccionarproducto.Columns["CreadoPor"].Visible = false;
            this.dtSeleccionarproducto.Columns["FechaCreado"].Visible = false;


        }
        #endregion
        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Servicio.Facturacion Facturacion = new Facturacion();
            Facturacion.ShowDialog();
        }

        private void AgregarProductos_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void AgregarProductos_Load(object sender, EventArgs e)
        {
            TemaGenerico();
            VariablesGlbales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            CargarTipoPrductos();
            CargarCategorias();
        }

        private void ddlTipoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarCategorias();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MostrarListadoProductos();
        }

        private void txtNumeroPagina_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroPagina.Value < 1)
            {
                txtNumeroPagina.Value = 1;
                MostrarListadoProductos();
            }
            else {
                MostrarListadoProductos();
            }
        }

        private void txtNumeroRegistros_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroRegistros.Value < 1)
            {
                txtNumeroRegistros.Value = 10;
                MostrarListadoProductos();
            }
            else {
                MostrarListadoProductos();
            }
        }

        private void dtSeleccionarproducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("¿Quieres seleccionar este registro?", VariablesGlbales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                decimal IdProductoSeleccionado = Convert.ToDecimal(this.dtSeleccionarproducto.CurrentRow.Cells["IdProducto"].Value.ToString());
                int CantidadAlmcen = Convert.ToInt32(this.dtSeleccionarproducto.CurrentRow.Cells["Stock"].Value.ToString());
                bool LlevaImagen = Convert.ToBoolean(this.dtSeleccionarproducto.CurrentRow.Cells["LlevaImagen0"].Value.ToString());

                if (CantidadAlmcen <= 0)
                {
                    MessageBox.Show("Este producto esta agotado, favor de suplir mas", VariablesGlbales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                {
                    var Buscar = ObjDataLogicaInventario.Value.BuscaProductos(
                 IdProductoSeleccionado,
                 null, null, null, null, null, null, null, null, null, null, null, null, 1, 1);

                    foreach (var n in Buscar)
                    {
                        txtTipoProducto.Text = n.TipoProducto;
                        txtCategoria.Text = n.Categoria;
                        txtProducto.Text = n.Producto;
                        int CantidadDisponible = Convert.ToInt32(n.Stock);
                        txtCantidadDisponible.Text = CantidadDisponible.ToString("N0");
                        decimal Precio = Convert.ToDecimal(n.PrecioVenta);
                        txtPrecio.Text = Precio.ToString("N0");
                        txtPorcientoDescyento.Text = n.PorcientoDescuento.ToString();
                        txtAcumulativo.Text = n.ProductoAcumulativo;

                        if (txtAcumulativo.Text == "SI")
                        {
                            int CantidadMinima = Convert.ToInt32(n.StockMinimo);
                            int Stock = Convert.ToInt32(n.Stock);
                            if (Stock <= CantidadMinima)
                            {
                                lbAlerta.Visible = true;
                            }
                        }

                        if (LlevaImagen == true)
                        {
                            btnfoto.Enabled = true;
                        }
                    }
                }
            }
        }

        private void txtDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            DSMarket.Logica.Comunes.ValidarControles.SoloNumeros(e);
        }
    }
}
