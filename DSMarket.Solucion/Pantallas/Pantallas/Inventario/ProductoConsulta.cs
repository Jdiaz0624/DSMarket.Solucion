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
    public partial class ProductoConsulta : Form
    {
        public ProductoConsulta()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaListas.LogicaListas> ObjDataListas = new Lazy<Logica.Logica.LogicaListas.LogicaListas>();
        Lazy<DSMarket.Logica.Logica.LogicaInventario.LogicaInventario> ObjDataInventario = new Lazy<Logica.Logica.LogicaInventario.LogicaInventario>();
        public DSMarket.Logica.Comunes.VariablesGlobales variablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region CARGAR LAS LISTAS
        private void CargarTipoPdoducto() {
            try {
                var TipoProducto = ObjDataListas.Value.ListaTipoProducto(
                    new Nullable<decimal>(),
                    null);
                ddlSeleccionarTipoProducto.DataSource = TipoProducto;
                ddlSeleccionarTipoProducto.DisplayMember = "Descripcion";
                ddlSeleccionarTipoProducto.ValueMember = "IdTipoproducto";
            }
            catch (Exception) { }
        }
        private void CargarCategorias() {
            try {
                var Categoria = ObjDataListas.Value.ListadoCategorias(
                    Convert.ToDecimal(ddlSeleccionarTipoProducto.SelectedValue));
                ddlSeleccionarCategoria.DataSource = Categoria;
                ddlSeleccionarCategoria.DisplayMember = "Descripcion";
                ddlSeleccionarCategoria.ValueMember = "IdCategoria";
            }
            catch (Exception) { }
        }
        private void UnidadMedida() {
            try {
                var UnidadMedida = ObjDataListas.Value.BuscaUnidadMedida();
                ddlSeleccionarUnidadMedida.DataSource = UnidadMedida;
                ddlSeleccionarUnidadMedida.DisplayMember = "Descripcion";
                ddlSeleccionarUnidadMedida.ValueMember = "IdUnidadMedida";
            }
            catch (Exception) { }
        }
        private void CargarMarcas() {
            try {
                var Marca = ObjDataListas.Value.BucaLisaMarcas();
                ddlSeleccionarMarca.DataSource = Marca;
                ddlSeleccionarMarca.DisplayMember = "Descripcion";
                ddlSeleccionarMarca.ValueMember = "IdMarca";
            }
            catch (Exception) { }
          
        }
        private void CargarModelos() {
            try {
                var Modelos = ObjDataListas.Value.BuscaListaModelos(Convert.ToDecimal(ddlSeleccionarMarca.SelectedValue));
                ddlSeleccionarModelo.DataSource = Modelos;
                ddlSeleccionarModelo.DisplayMember = "Descripcion";
                ddlSeleccionarModelo.ValueMember = "IdModelo";
            }
            catch (Exception) { }
        }
        #endregion
        #region APLICAR TEMA
        private void TemaPredeterminado()
        {
            this.BackColor = SystemColors.Control;

            txtdescripcion.BackColor = Color.WhiteSmoke;
            txtCodigoBarra.BackColor = Color.WhiteSmoke;
            txtReferencia.BackColor = Color.WhiteSmoke;
            txtNumeroPagina.BackColor = Color.WhiteSmoke;
            txtNumeroRegistros.BackColor = Color.WhiteSmoke;
            ddlSeleccionarCategoria.BackColor = Color.WhiteSmoke;
            ddlSeleccionarMarca.BackColor = Color.WhiteSmoke;
            ddlSeleccionarModelo.BackColor = Color.WhiteSmoke;
            ddlSeleccionarTipoProducto.BackColor = Color.WhiteSmoke;
            ddlSeleccionarUnidadMedida.BackColor = Color.WhiteSmoke;

            txtdescripcion.ForeColor = Color.Black;
            txtCodigoBarra.ForeColor = Color.Black;
            txtReferencia.ForeColor = Color.Black;
            txtNumeroPagina.ForeColor = Color.Black;
            txtNumeroRegistros.ForeColor = Color.Black;
            ddlSeleccionarCategoria.ForeColor = Color.Black;
            ddlSeleccionarMarca.ForeColor = Color.Black;
            ddlSeleccionarModelo.ForeColor = Color.Black;
            ddlSeleccionarTipoProducto.ForeColor = Color.Black;
            ddlSeleccionarUnidadMedida.ForeColor = Color.Black;

            dtListado.BackgroundColor = SystemColors.Control;



        }
        #endregion
        #region MOSTRAR LISTADO DE PRODUCTOS
        private void MostrarListadoProducto() {
            try {
                string _Descripcion = string.IsNullOrEmpty(txtdescripcion.Text.Trim()) ? null : txtdescripcion.Text.Trim();
                string _CodigoBarra = string.IsNullOrEmpty(txtCodigoBarra.Text.Trim()) ? null : txtCodigoBarra.Text.Trim();
                string _Referencia = string.IsNullOrEmpty(txtReferencia.Text.Trim()) ? null : txtReferencia.Text.Trim();

                //TODOS LOS PRODUCTOS
                if (rbAmbos.Checked == true)
                {

                    if (cbAgregarRangoFecha.Checked == true)
                    {
                        //AGREGANDO RANGO DE FECHA
                        if (cbAgregarFiltroPreciso.Checked == true)
                        {
                            //AGREGAR FILTRO PRECISO
                            var BuscarProducto = ObjDataInventario.Value.BuscaProductos(
                                new Nullable<decimal>(),
                                null,
                                _Descripcion,
                                _CodigoBarra,
                                _Referencia,
                                Convert.ToDateTime(txtFechaDesde.Text),
                                Convert.ToDateTime(txtFechaHasta.Text),
                                Convert.ToDecimal(ddlSeleccionarTipoProducto.SelectedValue),
                                Convert.ToDecimal(ddlSeleccionarCategoria.SelectedValue),
                                Convert.ToDecimal(ddlSeleccionarUnidadMedida.SelectedValue),
                                Convert.ToDecimal(ddlSeleccionarMarca.SelectedValue),
                                Convert.ToDecimal(ddlSeleccionarModelo.SelectedValue),
                                null,
                                Convert.ToInt32(txtNumeroPagina.Value),
                                Convert.ToInt32(txtNumeroRegistros.Value));
                            dtListado.DataSource = BuscarProducto;
                            if (BuscarProducto.Count() < 1)
                            {
                                lbCantidadProductos.Text = "0";
                                lbCantidadProductosConOferta.Text = "0";
                                lbCantidadPoductosAgotarse.Text = "0";
                                lbProductosAgotados.Text = "0";
                            }
                            else
                            {
                                foreach (var n in BuscarProducto)
                                {
                                    int CantidadProductos = Convert.ToInt32(n.CantidadRegistros);
                                    int ProductosConOferta = Convert.ToInt32(n.CantidadRegistros);
                                    int ProductoProximoAgotarse = Convert.ToInt32(n.CantidadRegistros);
                                    int ProductosAgotados = Convert.ToInt32(n.CantidadRegistros);

                                    lbCantidadProductos.Text = CantidadProductos.ToString("N0");
                                    lbCantidadProductosConOferta.Text = ProductosConOferta.ToString("N0");
                                    lbCantidadPoductosAgotarse.Text = ProductoProximoAgotarse.ToString("N0");
                                    lbProductosAgotados.Text = ProductosAgotados.ToString("N0");
                                }
                            }
                        }
                        else {
                            //NO AGREGAR FILTRO PRECISO
                            var BuscarProducto = ObjDataInventario.Value.BuscaProductos(
                               new Nullable<decimal>(),
                               null,
                               _Descripcion,
                               _CodigoBarra,
                               _Referencia,
                               Convert.ToDateTime(txtFechaDesde.Text),
                               Convert.ToDateTime(txtFechaHasta.Text),
                               null,
                               null,
                               null,
                               null,
                               null,
                               null,
                               Convert.ToInt32(txtNumeroPagina.Value),
                               Convert.ToInt32(txtNumeroRegistros.Value));
                            dtListado.DataSource = BuscarProducto;
                            if (BuscarProducto.Count() < 1)
                            {
                                lbCantidadProductos.Text = "0";
                                lbCantidadProductosConOferta.Text = "0";
                                lbCantidadPoductosAgotarse.Text = "0";
                                lbProductosAgotados.Text = "0";
                            }
                            else
                            {
                                foreach (var n in BuscarProducto)
                                {
                                    int CantidadProductos = Convert.ToInt32(n.CantidadRegistros);
                                    int ProductosConOferta = Convert.ToInt32(n.CantidadRegistros);
                                    int ProductoProximoAgotarse = Convert.ToInt32(n.CantidadRegistros);
                                    int ProductosAgotados = Convert.ToInt32(n.CantidadRegistros);

                                    lbCantidadProductos.Text = CantidadProductos.ToString("N0");
                                    lbCantidadProductosConOferta.Text = ProductosConOferta.ToString("N0");
                                    lbCantidadPoductosAgotarse.Text = ProductoProximoAgotarse.ToString("N0");
                                    lbProductosAgotados.Text = ProductosAgotados.ToString("N0");
                                }
                            }
                        }
                    }
                    else
                    {
                        //SIN AGREGAR RANGO DE FECHA
                        if (cbAgregarFiltroPreciso.Checked == true)
                        {
                            //AGREGAR FILTRO PRECISO
                            var BuscarProducto = ObjDataInventario.Value.BuscaProductos(
                                new Nullable<decimal>(),
                                null,
                                _Descripcion,
                                _CodigoBarra,
                                _Referencia,
                                null,
                                null,
                                Convert.ToDecimal(ddlSeleccionarTipoProducto.SelectedValue),
                                Convert.ToDecimal(ddlSeleccionarCategoria.SelectedValue),
                                Convert.ToDecimal(ddlSeleccionarUnidadMedida.SelectedValue),
                                Convert.ToDecimal(ddlSeleccionarMarca.SelectedValue),
                                Convert.ToDecimal(ddlSeleccionarModelo.SelectedValue),
                                null,
                                Convert.ToInt32(txtNumeroPagina.Value),
                                Convert.ToInt32(txtNumeroRegistros.Value));
                            dtListado.DataSource = BuscarProducto;
                            if (BuscarProducto.Count() < 1)
                            {
                                lbCantidadProductos.Text = "0";
                                lbCantidadProductosConOferta.Text = "0";
                                lbCantidadPoductosAgotarse.Text = "0";
                                lbProductosAgotados.Text = "0";
                            }
                            else
                            {
                                foreach (var n in BuscarProducto)
                                {
                                    int CantidadProductos = Convert.ToInt32(n.CantidadRegistros);
                                    int ProductosConOferta = Convert.ToInt32(n.CantidadRegistros);
                                    int ProductoProximoAgotarse = Convert.ToInt32(n.CantidadRegistros);
                                    int ProductosAgotados = Convert.ToInt32(n.CantidadRegistros);

                                    lbCantidadProductos.Text = CantidadProductos.ToString("N0");
                                    lbCantidadProductosConOferta.Text = ProductosConOferta.ToString("N0");
                                    lbCantidadPoductosAgotarse.Text = ProductoProximoAgotarse.ToString("N0");
                                    lbProductosAgotados.Text = ProductosAgotados.ToString("N0");
                                }
                            }
                        }
                        else
                        {
                            //NO AGREGAR FILTRO PRECISO
                            var BuscarProducto = ObjDataInventario.Value.BuscaProductos(
                                new Nullable<decimal>(),
                                null,
                                _Descripcion,
                                _CodigoBarra,
                                _Referencia,
                                null,
                                null,
                                null,
                                null,
                                null,
                                null,
                                null,
                                null,
                                Convert.ToInt32(txtNumeroPagina.Value),
                                Convert.ToInt32(txtNumeroRegistros.Value));
                            dtListado.DataSource = BuscarProducto;
                            if (BuscarProducto.Count() < 1)
                            {
                                lbCantidadProductos.Text = "0";
                                lbCantidadProductosConOferta.Text = "0";
                                lbCantidadPoductosAgotarse.Text = "0";
                                lbProductosAgotados.Text = "0";
                            }
                            else
                            {
                                foreach (var n in BuscarProducto)
                                {
                                    int CantidadProductos = Convert.ToInt32(n.CantidadRegistros);
                                    int ProductosConOferta = Convert.ToInt32(n.CantidadRegistros);
                                    int ProductoProximoAgotarse = Convert.ToInt32(n.CantidadRegistros);
                                    int ProductosAgotados = Convert.ToInt32(n.CantidadRegistros);

                                    lbCantidadProductos.Text = CantidadProductos.ToString("N0");
                                    lbCantidadProductosConOferta.Text = ProductosConOferta.ToString("N0");
                                    lbCantidadPoductosAgotarse.Text = ProductoProximoAgotarse.ToString("N0");
                                    lbProductosAgotados.Text = ProductosAgotados.ToString("N0");
                                }
                            }
                        }
                    }
                }

                //PRODUCTO CON OFERTA
                else if (rbConOferta.Checked == true)
                {
                    if (cbAgregarRangoFecha.Checked == true)
                    {
                        //AGREGANDO RANGO DE FECHA
                        if (cbAgregarFiltroPreciso.Checked == true)
                        {
                            //AGREGAR FILTRO PRECISO
                            var BuscarProducto = ObjDataInventario.Value.BuscaProductos(
                                new Nullable<decimal>(),
                                null,
                                _Descripcion,
                                _CodigoBarra,
                                _Referencia,
                                Convert.ToDateTime(txtFechaDesde.Text),
                                Convert.ToDateTime(txtFechaHasta.Text),
                                Convert.ToDecimal(ddlSeleccionarTipoProducto.SelectedValue),
                                Convert.ToDecimal(ddlSeleccionarCategoria.SelectedValue),
                                Convert.ToDecimal(ddlSeleccionarUnidadMedida.SelectedValue),
                                Convert.ToDecimal(ddlSeleccionarMarca.SelectedValue),
                                Convert.ToDecimal(ddlSeleccionarModelo.SelectedValue),
                                true,
                                Convert.ToInt32(txtNumeroPagina.Value),
                                Convert.ToInt32(txtNumeroRegistros.Value));
                            dtListado.DataSource = BuscarProducto;
                            if (BuscarProducto.Count() < 1)
                            {
                                lbCantidadProductos.Text = "0";
                                lbCantidadProductosConOferta.Text = "0";
                                lbCantidadPoductosAgotarse.Text = "0";
                                lbProductosAgotados.Text = "0";
                            }
                            else
                            {
                                foreach (var n in BuscarProducto)
                                {
                                    int CantidadProductos = Convert.ToInt32(n.CantidadRegistros);
                                    int ProductosConOferta = Convert.ToInt32(n.CantidadRegistros);
                                    int ProductoProximoAgotarse = Convert.ToInt32(n.CantidadRegistros);
                                    int ProductosAgotados = Convert.ToInt32(n.CantidadRegistros);

                                    lbCantidadProductos.Text = CantidadProductos.ToString("N0");
                                    lbCantidadProductosConOferta.Text = ProductosConOferta.ToString("N0");
                                    lbCantidadPoductosAgotarse.Text = ProductoProximoAgotarse.ToString("N0");
                                    lbProductosAgotados.Text = ProductosAgotados.ToString("N0");
                                }
                            }
                        }
                        else
                        {
                            //NO AGREGAR FILTRO PRECISO
                            var BuscarProducto = ObjDataInventario.Value.BuscaProductos(
                                new Nullable<decimal>(),
                                null,
                                _Descripcion,
                                _CodigoBarra,
                                _Referencia,
                                Convert.ToDateTime(txtFechaDesde.Text),
                                Convert.ToDateTime(txtFechaHasta.Text),
                                null,
                                null,
                                null,
                                null,
                                null,
                                true,
                                Convert.ToInt32(txtNumeroPagina.Value),
                                Convert.ToInt32(txtNumeroRegistros.Value));
                            dtListado.DataSource = BuscarProducto;
                            if (BuscarProducto.Count() < 1)
                            {
                                lbCantidadProductos.Text = "0";
                                lbCantidadProductosConOferta.Text = "0";
                                lbCantidadPoductosAgotarse.Text = "0";
                                lbProductosAgotados.Text = "0";
                            }
                            else
                            {
                                foreach (var n in BuscarProducto)
                                {
                                    int CantidadProductos = Convert.ToInt32(n.CantidadRegistros);
                                    int ProductosConOferta = Convert.ToInt32(n.CantidadRegistros);
                                    int ProductoProximoAgotarse = Convert.ToInt32(n.CantidadRegistros);
                                    int ProductosAgotados = Convert.ToInt32(n.CantidadRegistros);

                                    lbCantidadProductos.Text = CantidadProductos.ToString("N0");
                                    lbCantidadProductosConOferta.Text = ProductosConOferta.ToString("N0");
                                    lbCantidadPoductosAgotarse.Text = ProductoProximoAgotarse.ToString("N0");
                                    lbProductosAgotados.Text = ProductosAgotados.ToString("N0");
                                }
                            }
                        }
                    }
                    else
                    {
                        //SIN AGREGAR RANGO DE FECHA
                        if (cbAgregarFiltroPreciso.Checked == true)
                        {
                            //AGREGAR FILTRO PRECISO
                            var BuscarProducto = ObjDataInventario.Value.BuscaProductos(
                                new Nullable<decimal>(),
                                null,
                                _Descripcion,
                                _CodigoBarra,
                                _Referencia,
                                null,
                                null,
                                Convert.ToDecimal(ddlSeleccionarTipoProducto.SelectedValue),
                                Convert.ToDecimal(ddlSeleccionarCategoria.SelectedValue),
                                Convert.ToDecimal(ddlSeleccionarUnidadMedida.SelectedValue),
                                Convert.ToDecimal(ddlSeleccionarMarca.SelectedValue),
                                Convert.ToDecimal(ddlSeleccionarModelo.SelectedValue),
                                true,
                                Convert.ToInt32(txtNumeroPagina.Value),
                                Convert.ToInt32(txtNumeroRegistros.Value));
                            dtListado.DataSource = BuscarProducto;
                            if (BuscarProducto.Count() < 1)
                            {
                                lbCantidadProductos.Text = "0";
                                lbCantidadProductosConOferta.Text = "0";
                                lbCantidadPoductosAgotarse.Text = "0";
                                lbProductosAgotados.Text = "0";
                            }
                            else
                            {
                                foreach (var n in BuscarProducto)
                                {
                                    int CantidadProductos = Convert.ToInt32(n.CantidadRegistros);
                                    int ProductosConOferta = Convert.ToInt32(n.CantidadRegistros);
                                    int ProductoProximoAgotarse = Convert.ToInt32(n.CantidadRegistros);
                                    int ProductosAgotados = Convert.ToInt32(n.CantidadRegistros);

                                    lbCantidadProductos.Text = CantidadProductos.ToString("N0");
                                    lbCantidadProductosConOferta.Text = ProductosConOferta.ToString("N0");
                                    lbCantidadPoductosAgotarse.Text = ProductoProximoAgotarse.ToString("N0");
                                    lbProductosAgotados.Text = ProductosAgotados.ToString("N0");
                                }
                            }
                        }
                        else
                        {
                            //NO AGREGAR FILTRO PRECISO
                            var BuscarProducto = ObjDataInventario.Value.BuscaProductos(
                                new Nullable<decimal>(),
                                null,
                                _Descripcion,
                                _CodigoBarra,
                                _Referencia,
                                null,
                                null,
                                null,
                                null,
                                null,
                                null,
                                null,
                                true,
                                Convert.ToInt32(txtNumeroPagina.Value),
                                Convert.ToInt32(txtNumeroRegistros.Value));
                            if (BuscarProducto.Count() < 1)
                            {
                                lbCantidadProductos.Text = "0";
                                lbCantidadProductosConOferta.Text = "0";
                                lbCantidadPoductosAgotarse.Text = "0";
                                lbProductosAgotados.Text = "0";
                            }
                            else
                            {
                                foreach (var n in BuscarProducto)
                                {
                                    int CantidadProductos = Convert.ToInt32(n.CantidadRegistros);
                                    int ProductosConOferta = Convert.ToInt32(n.CantidadRegistros);
                                    int ProductoProximoAgotarse = Convert.ToInt32(n.CantidadRegistros);
                                    int ProductosAgotados = Convert.ToInt32(n.CantidadRegistros);

                                    lbCantidadProductos.Text = CantidadProductos.ToString("N0");
                                    lbCantidadProductosConOferta.Text = ProductosConOferta.ToString("N0");
                                    lbCantidadPoductosAgotarse.Text = ProductoProximoAgotarse.ToString("N0");
                                    lbProductosAgotados.Text = ProductosAgotados.ToString("N0");
                                }
                            }
                        }
                    }
                }

                //PRODUCTO SIN OFERTA
                else if (rbSinOferta.Checked == true)
                {
                    if (cbAgregarRangoFecha.Checked == true)
                    {
                        //AGREGANDO RANGO DE FECHA
                        if (cbAgregarFiltroPreciso.Checked == true)
                        {
                            //AGREGAR FILTRO PRECISO
                        }
                        else
                        {
                            //NO AGREGAR FILTRO PRECISO
                        }
                    }
                    else
                    {
                        //SIN AGREGAR RANGO DE FECHA
                        if (cbAgregarFiltroPreciso.Checked == true)
                        {
                            //AGREGAR FILTRO PRECISO
                        }
                        else
                        {
                            //NO AGREGAR FILTRO PRECISO
                        }
                    }
                }
                OcultarColumnas();
            }
            catch (Exception ex) {
                MessageBox.Show("Error al mostrar el listado de los productos, codigo de error: " + ex.Message, variablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void OcultarColumnas() {
            this.dtListado.Columns["IdProducto"].Visible = false;
            this.dtListado.Columns["NumeroConector"].Visible = false;
            this.dtListado.Columns["IdTipoProducto"].Visible = false;
            this.dtListado.Columns["IdCategoria"].Visible = false;
            this.dtListado.Columns["IdUnidadMedida"].Visible = false;
            this.dtListado.Columns["IdMarca"].Visible = false;
            this.dtListado.Columns["IdModelo"].Visible = false;
            this.dtListado.Columns["IdTipoSuplidor"].Visible = false;
            this.dtListado.Columns["IdSuplidor"].Visible = false;
            this.dtListado.Columns["PrecioCompra"].Visible = false;
            this.dtListado.Columns["AfectaOferta0"].Visible = false;
            this.dtListado.Columns["ProductoAcumulativo0"].Visible = false;
            this.dtListado.Columns["LlevaImagen0"].Visible = false;
            this.dtListado.Columns["UsuarioAdicion"].Visible = false;
            this.dtListado.Columns["FechaAdiciona"].Visible = false;
            this.dtListado.Columns["UsuarioModifica"].Visible = false;
            this.dtListado.Columns["ModificadoPor"].Visible = false;
            this.dtListado.Columns["FechaModifica"].Visible = false;
            this.dtListado.Columns["FechaModificado"].Visible = false;
            this.dtListado.Columns["Fecha"].Visible = false;
            this.dtListado.Columns["CantidadRegistros"].Visible = false;
            this.dtListado.Columns["ProductosConOferta"].Visible = false;
            this.dtListado.Columns["ProductoProximoAgotarse"].Visible = false;
            this.dtListado.Columns["ProductosAgostados"].Visible = false;
        }
        #endregion

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ProductoConsulta_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void ProductoConsulta_Load(object sender, EventArgs e)
        {
            variablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            CargarTipoPdoducto();
            CargarCategorias();
            UnidadMedida();
            CargarMarcas();
            CargarModelos();
            lbTitulo.Text = "CONSULTA DE INVENTARIO";
            lbTitulo.ForeColor = Color.WhiteSmoke;
            TemaPredeterminado();
            cbAgregarRangoFecha.ForeColor = Color.DarkRed;
            cbAgregarFiltroPreciso.ForeColor = Color.DarkRed;
            rbAmbos.Checked = true;
            rbAmbos.ForeColor = Color.LimeGreen;
            rbConOferta.ForeColor = Color.DarkRed;
            rbConOferta.ForeColor = Color.DarkRed;

            cbAgregarFiltroPreciso.Checked = false;
            cbAgregarRangoFecha.Checked = false;

            lbTipoProducto.Visible = false;
            ddlSeleccionarTipoProducto.Visible = false;
            lbCategoria.Visible = false;
            ddlSeleccionarCategoria.Visible = false;
            lbUnidadMdida.Visible = false;
            ddlSeleccionarUnidadMedida.Visible = false;
            lbMArca.Visible = false;
            ddlSeleccionarMarca.Visible = false;
            lbModelo.Visible = false;
            ddlSeleccionarModelo.Visible = false;
            lbFechaDesde.Visible = false;
            txtFechaDesde.Visible = false;
            lbFechaHasta.Visible = false;
            txtFechaHasta.Visible = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAgregarFiltroPreciso.Checked == true)
            {
                cbAgregarFiltroPreciso.ForeColor = Color.LimeGreen;
                lbTipoProducto.Visible = true;
                ddlSeleccionarTipoProducto.Visible = true;
                lbCategoria.Visible = true;
                ddlSeleccionarCategoria.Visible = true;
                lbUnidadMdida.Visible = true;
                ddlSeleccionarUnidadMedida.Visible = true;
                lbMArca.Visible = true;
                ddlSeleccionarMarca.Visible = true;
                lbModelo.Visible = true;
                ddlSeleccionarModelo.Visible = true;
            }
            else
            {
                cbAgregarFiltroPreciso.ForeColor = Color.DarkRed;
                lbTipoProducto.Visible = false;
                ddlSeleccionarTipoProducto.Visible = false;
                lbCategoria.Visible = false;
                ddlSeleccionarCategoria.Visible = false;
                lbUnidadMdida.Visible = false;
                ddlSeleccionarUnidadMedida.Visible = false;
                lbMArca.Visible = false;
                ddlSeleccionarMarca.Visible = false;
                lbModelo.Visible = false;
                ddlSeleccionarModelo.Visible = false;
            }
        }

        private void cbAgregarRangoFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAgregarRangoFecha.Checked == true)
            {

                cbAgregarRangoFecha.ForeColor = Color.LimeGreen;
                lbFechaDesde.Visible = true;
                txtFechaDesde.Visible = true;
                lbFechaHasta.Visible = true;
                txtFechaHasta.Visible = true;
            }
            else
            {
                cbAgregarRangoFecha.ForeColor = Color.DarkRed;
                lbFechaDesde.Visible = false;
                txtFechaDesde.Visible = false;
                lbFechaHasta.Visible = false;
                txtFechaHasta.Visible = false;
            }
        }

        private void rbAmbos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAmbos.Checked == true)
            {
                rbConOferta.ForeColor = Color.DarkRed;
                rbAmbos.ForeColor = Color.LimeGreen;
                rbSinOferta.ForeColor = Color.DarkRed;
            }
            else {
                rbConOferta.ForeColor = Color.DarkRed;
                rbAmbos.ForeColor = Color.DarkRed;
                rbSinOferta.ForeColor = Color.DarkRed;

            }
        }

        private void rbConOferta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbConOferta.Checked == true)
            {
                rbConOferta.ForeColor = Color.LimeGreen;
                rbAmbos.ForeColor = Color.DarkRed;
                rbSinOferta.ForeColor = Color.DarkRed;
            }
            else
            {
                rbConOferta.ForeColor = Color.DarkRed;
                rbAmbos.ForeColor = Color.DarkRed;
                rbSinOferta.ForeColor = Color.DarkRed;
            }
        }

        private void rbSinOferta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSinOferta.Checked == true)
            {
                rbConOferta.ForeColor = Color.DarkRed;
                rbAmbos.ForeColor = Color.DarkRed;
                rbSinOferta.ForeColor = Color.LimeGreen;
            }
            else
            {
                rbConOferta.ForeColor = Color.DarkRed;
                rbAmbos.ForeColor = Color.DarkRed;
                rbSinOferta.ForeColor = Color.DarkRed;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.MantenimientoProducto Mantenimiento = new MantenimientoProducto();
            Mantenimiento.VariablesGlobales.Accion = "INSERT";
            Mantenimiento.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.MantenimientoProducto Mantenimiento = new MantenimientoProducto();
            Mantenimiento.VariablesGlobales.Accion = "UPDATE";
            Mantenimiento.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.MantenimientoProducto Mantenimiento = new MantenimientoProducto();
            Mantenimiento.VariablesGlobales.Accion = "DELETE";
            Mantenimiento.ShowDialog();
        }

        private void btnSuplir_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.AgregarQuitarProductos Suplir = new AgregarQuitarProductos();
            Suplir.ShowDialog();
        }

        private void btnOferta_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.AgregarOferta Oferta = new AgregarOferta();
            Oferta.ShowDialog();
        }

        private void ddlSeleccionarTipoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarCategorias();
        }

        private void ddlSeleccionarMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarModelos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MostrarListadoProducto();
        }

        private void txtNumeroPagina_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroPagina.Value < 1)
            {
                txtNumeroPagina.Value = 1;
                MostrarListadoProducto();
            }
            else {
                MostrarListadoProducto();
            }
        }

        private void txtNumeroRegistros_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroRegistros.Value < 1)
            {
                txtNumeroRegistros.Value = 10;
                MostrarListadoProducto();
            }
            else
            {
                MostrarListadoProducto();
            }
        }
    }
}
