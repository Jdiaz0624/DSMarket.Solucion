using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

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
        Lazy<DSMarket.Logica.Logica.LogicaSeguridad.LogicaSeguridad> ObjDataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad.LogicaSeguridad>();
        Lazy<DSMarket.Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion> ObjdataConfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion>();
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
                var Marca = ObjDataListas.Value.BucaLisaMarcas(
                    Convert.ToDecimal(ddlSeleccionarCategoria.SelectedValue));
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
            txtNumeroSeguimiento.BackColor = Color.WhiteSmoke;
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
            txtNumeroSeguimiento.ForeColor = Color.Black;
            ddlSeleccionarUnidadMedida.ForeColor = Color.Black;

            dtListado.BackgroundColor = SystemColors.Control;



        }
        #endregion
        #region MOSTRAR LISTADO DE PRODUCTOS
        private void MostrarListadoProducto() {
            try {
                MostrarImagenPorDefecto(pbFoto);
                //MOSTRAMOS EL LISTADO DE LOS PRODUCTOS
                //FILTROS
                string _Descripcion = string.IsNullOrEmpty(txtdescripcion.Text.Trim()) ? null : txtdescripcion.Text.Trim();
                string _CodigoBarra = string.IsNullOrEmpty(txtCodigoBarra.Text.Trim()) ? null : txtCodigoBarra.Text.Trim();
                string _Referencia = string.IsNullOrEmpty(txtReferencia.Text.Trim()) ? null : txtReferencia.Text.Trim();
                string _NumeroSeguimiento = string.IsNullOrEmpty(txtNumeroSeguimiento.Text.Trim()) ? null : txtNumeroSeguimiento.Text.Trim();

                //CONSULTA CON TODOS LOS PRODUCTOS (CON OFERTA Y SIN OFERTA)
                if (rbAmbos.Checked == true)
                {
                    //VALIDAMOS SI LA CONSULTA TIENE RANGO DE FECHA
                    if (cbAgregarRangoFecha.Checked == true)
                    {
                        if (cbAgregarFiltroPreciso.Checked == true)
                        {
                            var BuscarProductos = ObjDataInventario.Value.BuscaProductos(
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
                                null,
                                null,
                                null,
                                false,
                                _NumeroSeguimiento,
                                Convert.ToInt32(txtNumeroPagina.Value),
                                Convert.ToInt32(txtNumeroRegistros.Value));
                            dtListado.DataSource = BuscarProductos;
                            if (BuscarProductos.Count() < 1)
                            {
                                lbCantidadProductos.Text = "0";
                                lbCantidadProductosConOferta.Text = "0";
                                lbCantidadPoductosAgotarse.Text = "0";
                                lbProductosAgotados.Text = "0";
                            }
                            else
                            {
                                foreach (var n in BuscarProductos)
                                {
                                    int Cantidadproductos = Convert.ToInt32(n.CantidadRegistros);
                                    int ProductoConOferta = Convert.ToInt32(n.ProductosConOferta);
                                    int ProductoAgotarse = Convert.ToInt32(n.ProductoProximoAgotarse);
                                    int ProductoAgoado = Convert.ToInt32(n.ProductosAgostados);

                                    lbCantidadProductos.Text = Cantidadproductos.ToString("N0");
                                    lbCantidadProductosConOferta.Text = ProductoConOferta.ToString("N0");
                                    lbCantidadPoductosAgotarse.Text = ProductoAgotarse.ToString("N0");
                                    lbProductosAgotados.Text = ProductoAgoado.ToString("N0");
                                }
                            }
                            OcultarColumnas();
                        }
                        else
                        {
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
                                null,
                                null,
                                null, false, _NumeroSeguimiento,
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
                                    int Cantidadproductos = Convert.ToInt32(n.CantidadRegistros);
                                    int ProductoConOferta = Convert.ToInt32(n.ProductosConOferta);
                                    int ProductoAgotarse = Convert.ToInt32(n.ProductoProximoAgotarse);
                                    int ProductoAgoado = Convert.ToInt32(n.ProductosAgostados);

                                    lbCantidadProductos.Text = Cantidadproductos.ToString("N0");
                                    lbCantidadProductosConOferta.Text = ProductoConOferta.ToString("N0");
                                    lbCantidadPoductosAgotarse.Text = ProductoAgotarse.ToString("N0");
                                    lbProductosAgotados.Text = ProductoAgoado.ToString("N0");
                                }
                            }
                            OcultarColumnas();
                        }
                    }
                    else
                    {
                        if (cbAgregarFiltroPreciso.Checked == true)
                        {
                            var BuscarProductos = ObjDataInventario.Value.BuscaProductos(
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
                                null,null,null,
                                null, false, _NumeroSeguimiento,
                                Convert.ToInt32(txtNumeroPagina.Value),
                                Convert.ToInt32(txtNumeroRegistros.Value));
                            dtListado.DataSource = BuscarProductos;
                            if (BuscarProductos.Count() < 1)
                            {
                                lbCantidadProductos.Text = "0";
                                lbCantidadProductosConOferta.Text = "0";
                                lbCantidadPoductosAgotarse.Text = "0";
                                lbProductosAgotados.Text = "0";
                            }
                            else
                            {
                                foreach (var n in BuscarProductos)
                                {
                                    int Cantidadproductos = Convert.ToInt32(n.CantidadRegistros);
                                    int ProductoConOferta = Convert.ToInt32(n.ProductosConOferta);
                                    int ProductoAgotarse = Convert.ToInt32(n.ProductoProximoAgotarse);
                                    int ProductoAgoado = Convert.ToInt32(n.ProductosAgostados);

                                    lbCantidadProductos.Text = Cantidadproductos.ToString("N0");
                                    lbCantidadProductosConOferta.Text = ProductoConOferta.ToString("N0");
                                    lbCantidadPoductosAgotarse.Text = ProductoAgotarse.ToString("N0");
                                    lbProductosAgotados.Text = ProductoAgoado.ToString("N0");
                                }
                            }
                            OcultarColumnas();
                        }
                        else
                        {
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
                                null,null,null,null,
                                null, false, _NumeroSeguimiento,
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
                                    int Cantidadproductos = Convert.ToInt32(n.CantidadRegistros);
                                    int ProductoConOferta = Convert.ToInt32(n.ProductosConOferta);
                                    int ProductoAgotarse = Convert.ToInt32(n.ProductoProximoAgotarse);
                                    int ProductoAgoado = Convert.ToInt32(n.ProductosAgostados);

                                    lbCantidadProductos.Text = Cantidadproductos.ToString("N0");
                                    lbCantidadProductosConOferta.Text = ProductoConOferta.ToString("N0");
                                    lbCantidadPoductosAgotarse.Text = ProductoAgotarse.ToString("N0");
                                    lbProductosAgotados.Text = ProductoAgoado.ToString("N0");
                                }
                            }
                            OcultarColumnas();
                        }
                    }
                }

                //CONSULTA CON LOS PRODUCTOS CON OFERTA
                else if (rbConOferta.Checked == true)
                {
                    //VALIDAMOS SI LA CONSULTA TIENE RANGO DE FECHA
                    if (cbAgregarRangoFecha.Checked == true)
                    {
                        if (cbAgregarFiltroPreciso.Checked == true)
                        {
                            var BuscarProductoConOferta = ObjDataInventario.Value.BuscaProductos(
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
                                null,null,null,
                                true, false, _NumeroSeguimiento,
                                Convert.ToInt32(txtNumeroPagina.Value),
                                Convert.ToInt32(txtNumeroRegistros.Value));
                            dtListado.DataSource = BuscarProductoConOferta;
                            if (BuscarProductoConOferta.Count() < 1)
                            {
                                lbCantidadProductos.Text = "0";
                                lbCantidadProductosConOferta.Text = "0";
                                lbCantidadPoductosAgotarse.Text = "0";
                                lbProductosAgotados.Text = "0";
                            }
                            else
                            {
                                foreach (var n in BuscarProductoConOferta)
                                {
                                    int Cantidadproductos = Convert.ToInt32(n.CantidadRegistros);
                                    int ProductoConOferta = Convert.ToInt32(n.ProductosConOferta);
                                    int ProductoAgotarse = Convert.ToInt32(n.ProductoProximoAgotarse);
                                    int ProductoAgoado = Convert.ToInt32(n.ProductosAgostados);

                                    lbCantidadProductos.Text = Cantidadproductos.ToString("N0");
                                    lbCantidadProductosConOferta.Text = ProductoConOferta.ToString("N0");
                                    lbCantidadPoductosAgotarse.Text = ProductoAgotarse.ToString("N0");
                                    lbProductosAgotados.Text = ProductoAgoado.ToString("N0");
                                }
                            }
                            OcultarColumnas();
                        }
                        else
                        {
                            var BuscarProductoConOferta = ObjDataInventario.Value.BuscaProductos(
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
                                null,null,null,null,
                                true, false, _NumeroSeguimiento,
                                Convert.ToInt32(txtNumeroPagina.Value),
                                Convert.ToInt32(txtNumeroRegistros.Value));
                            dtListado.DataSource = BuscarProductoConOferta;
                            if (BuscarProductoConOferta.Count() < 1)
                            {
                                lbCantidadProductos.Text = "0";
                                lbCantidadProductosConOferta.Text = "0";
                                lbCantidadPoductosAgotarse.Text = "0";
                                lbProductosAgotados.Text = "0";
                            }
                            else
                            {
                                foreach (var n in BuscarProductoConOferta)
                                {
                                    int Cantidadproductos = Convert.ToInt32(n.CantidadRegistros);
                                    int ProductoConOferta = Convert.ToInt32(n.ProductosConOferta);
                                    int ProductoAgotarse = Convert.ToInt32(n.ProductoProximoAgotarse);
                                    int ProductoAgoado = Convert.ToInt32(n.ProductosAgostados);

                                    lbCantidadProductos.Text = Cantidadproductos.ToString("N0");
                                    lbCantidadProductosConOferta.Text = ProductoConOferta.ToString("N0");
                                    lbCantidadPoductosAgotarse.Text = ProductoAgotarse.ToString("N0");
                                    lbProductosAgotados.Text = ProductoAgoado.ToString("N0");
                                }
                            }
                            OcultarColumnas();
                        }
                    }
                    else
                    {
                        if (cbAgregarFiltroPreciso.Checked == true)
                        {
                            var BuscarProductoConOferta = ObjDataInventario.Value.BuscaProductos(
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
                               null, null, null,
                               true, false, _NumeroSeguimiento,
                               Convert.ToInt32(txtNumeroPagina.Value),
                               Convert.ToInt32(txtNumeroRegistros.Value));
                            dtListado.DataSource = BuscarProductoConOferta;
                            if (BuscarProductoConOferta.Count() < 1)
                            {
                                lbCantidadProductos.Text = "0";
                                lbCantidadProductosConOferta.Text = "0";
                                lbCantidadPoductosAgotarse.Text = "0";
                                lbProductosAgotados.Text = "0";
                            }
                            else
                            {
                                foreach (var n in BuscarProductoConOferta)
                                {
                                    int Cantidadproductos = Convert.ToInt32(n.CantidadRegistros);
                                    int ProductoConOferta = Convert.ToInt32(n.ProductosConOferta);
                                    int ProductoAgotarse = Convert.ToInt32(n.ProductoProximoAgotarse);
                                    int ProductoAgoado = Convert.ToInt32(n.ProductosAgostados);

                                    lbCantidadProductos.Text = Cantidadproductos.ToString("N0");
                                    lbCantidadProductosConOferta.Text = ProductoConOferta.ToString("N0");
                                    lbCantidadPoductosAgotarse.Text = ProductoAgotarse.ToString("N0");
                                    lbProductosAgotados.Text = ProductoAgoado.ToString("N0");
                                }
                            }
                            OcultarColumnas();
                        }
                        else
                        {
                            var BuscarProductoConOferta = ObjDataInventario.Value.BuscaProductos(
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
                               null, null, null,
                               true, false, _NumeroSeguimiento,
                               Convert.ToInt32(txtNumeroPagina.Value),
                               Convert.ToInt32(txtNumeroRegistros.Value));
                            dtListado.DataSource = BuscarProductoConOferta;
                            if (BuscarProductoConOferta.Count() < 1)
                            {
                                lbCantidadProductos.Text = "0";
                                lbCantidadProductosConOferta.Text = "0";
                                lbCantidadPoductosAgotarse.Text = "0";
                                lbProductosAgotados.Text = "0";
                            }
                            else
                            {
                                foreach (var n in BuscarProductoConOferta)
                                {
                                    int Cantidadproductos = Convert.ToInt32(n.CantidadRegistros);
                                    int ProductoConOferta = Convert.ToInt32(n.ProductosConOferta);
                                    int ProductoAgotarse = Convert.ToInt32(n.ProductoProximoAgotarse);
                                    int ProductoAgoado = Convert.ToInt32(n.ProductosAgostados);

                                    lbCantidadProductos.Text = Cantidadproductos.ToString("N0");
                                    lbCantidadProductosConOferta.Text = ProductoConOferta.ToString("N0");
                                    lbCantidadPoductosAgotarse.Text = ProductoAgotarse.ToString("N0");
                                    lbProductosAgotados.Text = ProductoAgoado.ToString("N0");
                                }
                            }
                            OcultarColumnas();
                        }
                    }
                }

                //CONSULTA CON LOS PRODUCTOS SIN OFERTA
                else if (rbSinOferta.Checked == true) {

                    //VALIDAMOS SI LA CONSULTA TIENE RANGO DE FECHA
                    if (cbAgregarRangoFecha.Checked == true)
                    {
                        if (cbAgregarFiltroPreciso.Checked == true)
                        {
                            var BuscarProductoConOferta = ObjDataInventario.Value.BuscaProductos(
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
                                null, null, null,
                                false, false, _NumeroSeguimiento,
                                Convert.ToInt32(txtNumeroPagina.Value),
                                Convert.ToInt32(txtNumeroRegistros.Value));
                            dtListado.DataSource = BuscarProductoConOferta;
                            if (BuscarProductoConOferta.Count() < 1)
                            {
                                lbCantidadProductos.Text = "0";
                                lbCantidadProductosConOferta.Text = "0";
                                lbCantidadPoductosAgotarse.Text = "0";
                                lbProductosAgotados.Text = "0";
                            }
                            else
                            {
                                foreach (var n in BuscarProductoConOferta)
                                {
                                    int Cantidadproductos = Convert.ToInt32(n.CantidadRegistros);
                                    int ProductoConOferta = Convert.ToInt32(n.ProductosConOferta);
                                    int ProductoAgotarse = Convert.ToInt32(n.ProductoProximoAgotarse);
                                    int ProductoAgoado = Convert.ToInt32(n.ProductosAgostados);

                                    lbCantidadProductos.Text = Cantidadproductos.ToString("N0");
                                    lbCantidadProductosConOferta.Text = ProductoConOferta.ToString("N0");
                                    lbCantidadPoductosAgotarse.Text = ProductoAgotarse.ToString("N0");
                                    lbProductosAgotados.Text = ProductoAgoado.ToString("N0");
                                }
                            }
                            OcultarColumnas();
                        }
                        else
                        {
                            var BuscarProductoConOferta = ObjDataInventario.Value.BuscaProductos(
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
                               null, null, null,
                               false, false, _NumeroSeguimiento,
                               Convert.ToInt32(txtNumeroPagina.Value),
                               Convert.ToInt32(txtNumeroRegistros.Value));
                            dtListado.DataSource = BuscarProductoConOferta;
                            if (BuscarProductoConOferta.Count() < 1)
                            {
                                lbCantidadProductos.Text = "0";
                                lbCantidadProductosConOferta.Text = "0";
                                lbCantidadPoductosAgotarse.Text = "0";
                                lbProductosAgotados.Text = "0";
                            }
                            else
                            {
                                foreach (var n in BuscarProductoConOferta)
                                {
                                    int Cantidadproductos = Convert.ToInt32(n.CantidadRegistros);
                                    int ProductoConOferta = Convert.ToInt32(n.ProductosConOferta);
                                    int ProductoAgotarse = Convert.ToInt32(n.ProductoProximoAgotarse);
                                    int ProductoAgoado = Convert.ToInt32(n.ProductosAgostados);

                                    lbCantidadProductos.Text = Cantidadproductos.ToString("N0");
                                    lbCantidadProductosConOferta.Text = ProductoConOferta.ToString("N0");
                                    lbCantidadPoductosAgotarse.Text = ProductoAgotarse.ToString("N0");
                                    lbProductosAgotados.Text = ProductoAgoado.ToString("N0");
                                }
                            }
                            OcultarColumnas();
                        }
                    }
                    else
                    {
                        if (cbAgregarFiltroPreciso.Checked == true)
                        {
                            var BuscarProductoConOferta = ObjDataInventario.Value.BuscaProductos(
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
                               null, null, null,
                               false, false, _NumeroSeguimiento,
                               Convert.ToInt32(txtNumeroPagina.Value),
                               Convert.ToInt32(txtNumeroRegistros.Value));
                            dtListado.DataSource = BuscarProductoConOferta;
                            if (BuscarProductoConOferta.Count() < 1)
                            {
                                lbCantidadProductos.Text = "0";
                                lbCantidadProductosConOferta.Text = "0";
                                lbCantidadPoductosAgotarse.Text = "0";
                                lbProductosAgotados.Text = "0";
                            }
                            else
                            {
                                foreach (var n in BuscarProductoConOferta)
                                {
                                    int Cantidadproductos = Convert.ToInt32(n.CantidadRegistros);
                                    int ProductoConOferta = Convert.ToInt32(n.ProductosConOferta);
                                    int ProductoAgotarse = Convert.ToInt32(n.ProductoProximoAgotarse);
                                    int ProductoAgoado = Convert.ToInt32(n.ProductosAgostados);

                                    lbCantidadProductos.Text = Cantidadproductos.ToString("N0");
                                    lbCantidadProductosConOferta.Text = ProductoConOferta.ToString("N0");
                                    lbCantidadPoductosAgotarse.Text = ProductoAgotarse.ToString("N0");
                                    lbProductosAgotados.Text = ProductoAgoado.ToString("N0");
                                }
                            }
                            OcultarColumnas();
                        }
                        else
                        {
                            var BuscarProductoConOferta = ObjDataInventario.Value.BuscaProductos(
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
                               null, null, null,
                               false, false, _NumeroSeguimiento,
                               Convert.ToInt32(txtNumeroPagina.Value),
                               Convert.ToInt32(txtNumeroRegistros.Value));
                            dtListado.DataSource = BuscarProductoConOferta;
                            if (BuscarProductoConOferta.Count() < 1)
                            {
                                lbCantidadProductos.Text = "0";
                                lbCantidadProductosConOferta.Text = "0";
                                lbCantidadPoductosAgotarse.Text = "0";
                                lbProductosAgotados.Text = "0";
                            }
                            else
                            {
                                foreach (var n in BuscarProductoConOferta)
                                {
                                    int Cantidadproductos = Convert.ToInt32(n.CantidadRegistros);
                                    int ProductoConOferta = Convert.ToInt32(n.ProductosConOferta);
                                    int ProductoAgotarse = Convert.ToInt32(n.ProductoProximoAgotarse);
                                    int ProductoAgoado = Convert.ToInt32(n.ProductosAgostados);

                                    lbCantidadProductos.Text = Cantidadproductos.ToString("N0");
                                    lbCantidadProductosConOferta.Text = ProductoConOferta.ToString("N0");
                                    lbCantidadPoductosAgotarse.Text = ProductoAgotarse.ToString("N0");
                                    lbProductosAgotados.Text = ProductoAgoado.ToString("N0");
                                }
                            }
                            OcultarColumnas();
                        }
                    }

                }

             
            }
            catch (Exception ex) {
                MessageBox.Show("Error al mostrar la consulta, codigo de error: " + ex.Message, variablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void MostrarListadoProductosVendidosDescartados() {
            try
            {
                MostrarImagenPorDefecto(pbFoto);
                //MOSTRAMOS EL LISTADO DE LOS PRODUCTOS
                //FILTROS
                string _Descripcion = string.IsNullOrEmpty(txtdescripcion.Text.Trim()) ? null : txtdescripcion.Text.Trim();
                string _CodigoBarra = string.IsNullOrEmpty(txtCodigoBarra.Text.Trim()) ? null : txtCodigoBarra.Text.Trim();
                string _Referencia = string.IsNullOrEmpty(txtReferencia.Text.Trim()) ? null : txtReferencia.Text.Trim();

                //CONSULTA CON TODOS LOS PRODUCTOS (CON OFERTA Y SIN OFERTA)
                if (rbAmbos.Checked == true)
                {
                    //VALIDAMOS SI LA CONSULTA TIENE RANGO DE FECHA
                    if (cbAgregarRangoFecha.Checked == true)
                    {
                        if (cbAgregarFiltroPreciso.Checked == true)
                        {
                            var BuscarProductos = ObjDataInventario.Value.BuscaProductos(
                                new Nullable<decimal>(),
                                null,
                                _Descripcion,
                                _CodigoBarra,
                                _Referencia,
                                Convert.ToDateTime(txtFechaDesde.Text),
                                Convert.ToDateTime(txtFechaHasta.Text),
                                1,
                                Convert.ToDecimal(ddlSeleccionarCategoria.SelectedValue),
                                Convert.ToDecimal(ddlSeleccionarUnidadMedida.SelectedValue),
                                Convert.ToDecimal(ddlSeleccionarMarca.SelectedValue),
                                Convert.ToDecimal(ddlSeleccionarModelo.SelectedValue),
                                null, null, null,
                                null, true, null,
                                Convert.ToInt32(txtNumeroPagina.Value),
                                Convert.ToInt32(txtNumeroRegistros.Value));
                            dtListado.DataSource = BuscarProductos;
                            if (BuscarProductos.Count() < 1)
                            {
                                lbCantidadProductos.Text = "0";
                                lbCantidadProductosConOferta.Text = "0";
                                lbCantidadPoductosAgotarse.Text = "0";
                                lbProductosAgotados.Text = "0";
                            }
                            else
                            {
                                foreach (var n in BuscarProductos)
                                {
                                    int Cantidadproductos = Convert.ToInt32(n.CantidadRegistros);
                                    int ProductoConOferta = Convert.ToInt32(n.ProductosConOferta);
                                    int ProductoAgotarse = Convert.ToInt32(n.ProductoProximoAgotarse);
                                    int ProductoAgoado = Convert.ToInt32(n.ProductosAgostados);

                                    lbCantidadProductos.Text = Cantidadproductos.ToString("N0");
                                    lbCantidadProductosConOferta.Text = ProductoConOferta.ToString("N0");
                                    lbCantidadPoductosAgotarse.Text = ProductoAgotarse.ToString("N0");
                                    lbProductosAgotados.Text = ProductoAgoado.ToString("N0");
                                }
                            }
                            OcultarColumnas();
                        }
                        else
                        {
                            var BuscarProducto = ObjDataInventario.Value.BuscaProductos(
                                new Nullable<decimal>(),
                                null,
                                _Descripcion,
                                _CodigoBarra,
                                _Referencia,
                                Convert.ToDateTime(txtFechaDesde.Text),
                                Convert.ToDateTime(txtFechaHasta.Text),
                                1,
                                null,
                                null,
                                null,
                                null, null, null, null,
                                null, true, null,
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
                                    int Cantidadproductos = Convert.ToInt32(n.CantidadRegistros);
                                    int ProductoConOferta = Convert.ToInt32(n.ProductosConOferta);
                                    int ProductoAgotarse = Convert.ToInt32(n.ProductoProximoAgotarse);
                                    int ProductoAgoado = Convert.ToInt32(n.ProductosAgostados);

                                    lbCantidadProductos.Text = Cantidadproductos.ToString("N0");
                                    lbCantidadProductosConOferta.Text = ProductoConOferta.ToString("N0");
                                    lbCantidadPoductosAgotarse.Text = ProductoAgotarse.ToString("N0");
                                    lbProductosAgotados.Text = ProductoAgoado.ToString("N0");
                                }
                            }
                            OcultarColumnas();
                        }
                    }
                    else
                    {
                        if (cbAgregarFiltroPreciso.Checked == true)
                        {
                            var BuscarProductos = ObjDataInventario.Value.BuscaProductos(
                                new Nullable<decimal>(),
                                null,
                                _Descripcion,
                                _CodigoBarra,
                                _Referencia,
                                null,
                                null,
                                1,
                                Convert.ToDecimal(ddlSeleccionarCategoria.SelectedValue),
                                Convert.ToDecimal(ddlSeleccionarUnidadMedida.SelectedValue),
                                Convert.ToDecimal(ddlSeleccionarMarca.SelectedValue),
                                Convert.ToDecimal(ddlSeleccionarModelo.SelectedValue),
                                null, null, null,
                                null, true, null,
                                Convert.ToInt32(txtNumeroPagina.Value),
                                Convert.ToInt32(txtNumeroRegistros.Value));
                            dtListado.DataSource = BuscarProductos;
                            if (BuscarProductos.Count() < 1)
                            {
                                lbCantidadProductos.Text = "0";
                                lbCantidadProductosConOferta.Text = "0";
                                lbCantidadPoductosAgotarse.Text = "0";
                                lbProductosAgotados.Text = "0";
                            }
                            else
                            {
                                foreach (var n in BuscarProductos)
                                {
                                    int Cantidadproductos = Convert.ToInt32(n.CantidadRegistros);
                                    int ProductoConOferta = Convert.ToInt32(n.ProductosConOferta);
                                    int ProductoAgotarse = Convert.ToInt32(n.ProductoProximoAgotarse);
                                    int ProductoAgoado = Convert.ToInt32(n.ProductosAgostados);

                                    lbCantidadProductos.Text = Cantidadproductos.ToString("N0");
                                    lbCantidadProductosConOferta.Text = ProductoConOferta.ToString("N0");
                                    lbCantidadPoductosAgotarse.Text = ProductoAgotarse.ToString("N0");
                                    lbProductosAgotados.Text = ProductoAgoado.ToString("N0");
                                }
                            }
                            OcultarColumnas();
                        }
                        else
                        {
                            var BuscarProducto = ObjDataInventario.Value.BuscaProductos(
                                new Nullable<decimal>(),
                                null,
                                _Descripcion,
                                _CodigoBarra,
                                _Referencia,
                                null,
                                null,
                                1,
                                null,
                                null,
                                null,
                                null, null, null, null,
                                null, true, null,
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
                                    int Cantidadproductos = Convert.ToInt32(n.CantidadRegistros);
                                    int ProductoConOferta = Convert.ToInt32(n.ProductosConOferta);
                                    int ProductoAgotarse = Convert.ToInt32(n.ProductoProximoAgotarse);
                                    int ProductoAgoado = Convert.ToInt32(n.ProductosAgostados);

                                    lbCantidadProductos.Text = Cantidadproductos.ToString("N0");
                                    lbCantidadProductosConOferta.Text = ProductoConOferta.ToString("N0");
                                    lbCantidadPoductosAgotarse.Text = ProductoAgotarse.ToString("N0");
                                    lbProductosAgotados.Text = ProductoAgoado.ToString("N0");
                                }
                            }
                            OcultarColumnas();
                        }
                    }
                }

                //CONSULTA CON LOS PRODUCTOS CON OFERTA
                else if (rbConOferta.Checked == true)
                {
                    //VALIDAMOS SI LA CONSULTA TIENE RANGO DE FECHA
                    if (cbAgregarRangoFecha.Checked == true)
                    {
                        if (cbAgregarFiltroPreciso.Checked == true)
                        {
                            var BuscarProductoConOferta = ObjDataInventario.Value.BuscaProductos(
                                new Nullable<decimal>(),
                                null,
                                _Descripcion,
                                _CodigoBarra,
                                _Referencia,
                                Convert.ToDateTime(txtFechaDesde.Text),
                                Convert.ToDateTime(txtFechaHasta.Text),
                                1,
                                Convert.ToDecimal(ddlSeleccionarCategoria.SelectedValue),
                                Convert.ToDecimal(ddlSeleccionarUnidadMedida.SelectedValue),
                                Convert.ToDecimal(ddlSeleccionarMarca.SelectedValue),
                                Convert.ToDecimal(ddlSeleccionarModelo.SelectedValue),
                                null, null, null,
                                true, true, null,
                                Convert.ToInt32(txtNumeroPagina.Value),
                                Convert.ToInt32(txtNumeroRegistros.Value));
                            dtListado.DataSource = BuscarProductoConOferta;
                            if (BuscarProductoConOferta.Count() < 1)
                            {
                                lbCantidadProductos.Text = "0";
                                lbCantidadProductosConOferta.Text = "0";
                                lbCantidadPoductosAgotarse.Text = "0";
                                lbProductosAgotados.Text = "0";
                            }
                            else
                            {
                                foreach (var n in BuscarProductoConOferta)
                                {
                                    int Cantidadproductos = Convert.ToInt32(n.CantidadRegistros);
                                    int ProductoConOferta = Convert.ToInt32(n.ProductosConOferta);
                                    int ProductoAgotarse = Convert.ToInt32(n.ProductoProximoAgotarse);
                                    int ProductoAgoado = Convert.ToInt32(n.ProductosAgostados);

                                    lbCantidadProductos.Text = Cantidadproductos.ToString("N0");
                                    lbCantidadProductosConOferta.Text = ProductoConOferta.ToString("N0");
                                    lbCantidadPoductosAgotarse.Text = ProductoAgotarse.ToString("N0");
                                    lbProductosAgotados.Text = ProductoAgoado.ToString("N0");
                                }
                            }
                            OcultarColumnas();
                        }
                        else
                        {
                            var BuscarProductoConOferta = ObjDataInventario.Value.BuscaProductos(
                                new Nullable<decimal>(),
                                null,
                                _Descripcion,
                                _CodigoBarra,
                                _Referencia,
                                Convert.ToDateTime(txtFechaDesde.Text),
                                Convert.ToDateTime(txtFechaHasta.Text),
                                1,
                                null,
                                null,
                                null,
                                null,
                                null, null, null,
                                true, true, null,
                                Convert.ToInt32(txtNumeroPagina.Value),
                                Convert.ToInt32(txtNumeroRegistros.Value));
                            dtListado.DataSource = BuscarProductoConOferta;
                            if (BuscarProductoConOferta.Count() < 1)
                            {
                                lbCantidadProductos.Text = "0";
                                lbCantidadProductosConOferta.Text = "0";
                                lbCantidadPoductosAgotarse.Text = "0";
                                lbProductosAgotados.Text = "0";
                            }
                            else
                            {
                                foreach (var n in BuscarProductoConOferta)
                                {
                                    int Cantidadproductos = Convert.ToInt32(n.CantidadRegistros);
                                    int ProductoConOferta = Convert.ToInt32(n.ProductosConOferta);
                                    int ProductoAgotarse = Convert.ToInt32(n.ProductoProximoAgotarse);
                                    int ProductoAgoado = Convert.ToInt32(n.ProductosAgostados);

                                    lbCantidadProductos.Text = Cantidadproductos.ToString("N0");
                                    lbCantidadProductosConOferta.Text = ProductoConOferta.ToString("N0");
                                    lbCantidadPoductosAgotarse.Text = ProductoAgotarse.ToString("N0");
                                    lbProductosAgotados.Text = ProductoAgoado.ToString("N0");
                                }
                            }
                            OcultarColumnas();
                        }
                    }
                    else
                    {
                        if (cbAgregarFiltroPreciso.Checked == true)
                        {
                            var BuscarProductoConOferta = ObjDataInventario.Value.BuscaProductos(
                               new Nullable<decimal>(),
                               null,
                               _Descripcion,
                               _CodigoBarra,
                               _Referencia,
                               null,
                               null,
                               1,
                               Convert.ToDecimal(ddlSeleccionarCategoria.SelectedValue),
                               Convert.ToDecimal(ddlSeleccionarUnidadMedida.SelectedValue),
                               Convert.ToDecimal(ddlSeleccionarMarca.SelectedValue),
                               Convert.ToDecimal(ddlSeleccionarModelo.SelectedValue),
                               null, null, null,
                               true, true, null,
                               Convert.ToInt32(txtNumeroPagina.Value),
                               Convert.ToInt32(txtNumeroRegistros.Value));
                            dtListado.DataSource = BuscarProductoConOferta;
                            if (BuscarProductoConOferta.Count() < 1)
                            {
                                lbCantidadProductos.Text = "0";
                                lbCantidadProductosConOferta.Text = "0";
                                lbCantidadPoductosAgotarse.Text = "0";
                                lbProductosAgotados.Text = "0";
                            }
                            else
                            {
                                foreach (var n in BuscarProductoConOferta)
                                {
                                    int Cantidadproductos = Convert.ToInt32(n.CantidadRegistros);
                                    int ProductoConOferta = Convert.ToInt32(n.ProductosConOferta);
                                    int ProductoAgotarse = Convert.ToInt32(n.ProductoProximoAgotarse);
                                    int ProductoAgoado = Convert.ToInt32(n.ProductosAgostados);

                                    lbCantidadProductos.Text = Cantidadproductos.ToString("N0");
                                    lbCantidadProductosConOferta.Text = ProductoConOferta.ToString("N0");
                                    lbCantidadPoductosAgotarse.Text = ProductoAgotarse.ToString("N0");
                                    lbProductosAgotados.Text = ProductoAgoado.ToString("N0");
                                }
                            }
                            OcultarColumnas();
                        }
                        else
                        {
                            var BuscarProductoConOferta = ObjDataInventario.Value.BuscaProductos(
                               new Nullable<decimal>(),
                               null,
                               _Descripcion,
                               _CodigoBarra,
                               _Referencia,
                               null,
                               null,
                               1,
                               null,
                               null,
                               null,
                               null,
                               null, null, null,
                               true, true, null,
                               Convert.ToInt32(txtNumeroPagina.Value),
                               Convert.ToInt32(txtNumeroRegistros.Value));
                            dtListado.DataSource = BuscarProductoConOferta;
                            if (BuscarProductoConOferta.Count() < 1)
                            {
                                lbCantidadProductos.Text = "0";
                                lbCantidadProductosConOferta.Text = "0";
                                lbCantidadPoductosAgotarse.Text = "0";
                                lbProductosAgotados.Text = "0";
                            }
                            else
                            {
                                foreach (var n in BuscarProductoConOferta)
                                {
                                    int Cantidadproductos = Convert.ToInt32(n.CantidadRegistros);
                                    int ProductoConOferta = Convert.ToInt32(n.ProductosConOferta);
                                    int ProductoAgotarse = Convert.ToInt32(n.ProductoProximoAgotarse);
                                    int ProductoAgoado = Convert.ToInt32(n.ProductosAgostados);

                                    lbCantidadProductos.Text = Cantidadproductos.ToString("N0");
                                    lbCantidadProductosConOferta.Text = ProductoConOferta.ToString("N0");
                                    lbCantidadPoductosAgotarse.Text = ProductoAgotarse.ToString("N0");
                                    lbProductosAgotados.Text = ProductoAgoado.ToString("N0");
                                }
                            }
                            OcultarColumnas();
                        }
                    }
                }

                //CONSULTA CON LOS PRODUCTOS SIN OFERTA
                else if (rbSinOferta.Checked == true)
                {

                    //VALIDAMOS SI LA CONSULTA TIENE RANGO DE FECHA
                    if (cbAgregarRangoFecha.Checked == true)
                    {
                        if (cbAgregarFiltroPreciso.Checked == true)
                        {
                            var BuscarProductoConOferta = ObjDataInventario.Value.BuscaProductos(
                                new Nullable<decimal>(),
                                null,
                                _Descripcion,
                                _CodigoBarra,
                                _Referencia,
                                Convert.ToDateTime(txtFechaDesde.Text),
                                Convert.ToDateTime(txtFechaHasta.Text),
                                1,
                                Convert.ToDecimal(ddlSeleccionarCategoria.SelectedValue),
                                Convert.ToDecimal(ddlSeleccionarUnidadMedida.SelectedValue),
                                Convert.ToDecimal(ddlSeleccionarMarca.SelectedValue),
                                Convert.ToDecimal(ddlSeleccionarModelo.SelectedValue),
                                null, null, null,
                                false, true, null,
                                Convert.ToInt32(txtNumeroPagina.Value),
                                Convert.ToInt32(txtNumeroRegistros.Value));
                            dtListado.DataSource = BuscarProductoConOferta;
                            if (BuscarProductoConOferta.Count() < 1)
                            {
                                lbCantidadProductos.Text = "0";
                                lbCantidadProductosConOferta.Text = "0";
                                lbCantidadPoductosAgotarse.Text = "0";
                                lbProductosAgotados.Text = "0";
                            }
                            else
                            {
                                foreach (var n in BuscarProductoConOferta)
                                {
                                    int Cantidadproductos = Convert.ToInt32(n.CantidadRegistros);
                                    int ProductoConOferta = Convert.ToInt32(n.ProductosConOferta);
                                    int ProductoAgotarse = Convert.ToInt32(n.ProductoProximoAgotarse);
                                    int ProductoAgoado = Convert.ToInt32(n.ProductosAgostados);

                                    lbCantidadProductos.Text = Cantidadproductos.ToString("N0");
                                    lbCantidadProductosConOferta.Text = ProductoConOferta.ToString("N0");
                                    lbCantidadPoductosAgotarse.Text = ProductoAgotarse.ToString("N0");
                                    lbProductosAgotados.Text = ProductoAgoado.ToString("N0");
                                }
                            }
                            OcultarColumnas();
                        }
                        else
                        {
                            var BuscarProductoConOferta = ObjDataInventario.Value.BuscaProductos(
                               new Nullable<decimal>(),
                               null,
                               _Descripcion,
                               _CodigoBarra,
                               _Referencia,
                               Convert.ToDateTime(txtFechaDesde.Text),
                               Convert.ToDateTime(txtFechaHasta.Text),
                               1,
                               null,
                               null,
                               null,
                               null,
                               null, null, null,
                               false, true, null,
                               Convert.ToInt32(txtNumeroPagina.Value),
                               Convert.ToInt32(txtNumeroRegistros.Value));
                            dtListado.DataSource = BuscarProductoConOferta;
                            if (BuscarProductoConOferta.Count() < 1)
                            {
                                lbCantidadProductos.Text = "0";
                                lbCantidadProductosConOferta.Text = "0";
                                lbCantidadPoductosAgotarse.Text = "0";
                                lbProductosAgotados.Text = "0";
                            }
                            else
                            {
                                foreach (var n in BuscarProductoConOferta)
                                {
                                    int Cantidadproductos = Convert.ToInt32(n.CantidadRegistros);
                                    int ProductoConOferta = Convert.ToInt32(n.ProductosConOferta);
                                    int ProductoAgotarse = Convert.ToInt32(n.ProductoProximoAgotarse);
                                    int ProductoAgoado = Convert.ToInt32(n.ProductosAgostados);

                                    lbCantidadProductos.Text = Cantidadproductos.ToString("N0");
                                    lbCantidadProductosConOferta.Text = ProductoConOferta.ToString("N0");
                                    lbCantidadPoductosAgotarse.Text = ProductoAgotarse.ToString("N0");
                                    lbProductosAgotados.Text = ProductoAgoado.ToString("N0");
                                }
                            }
                            OcultarColumnas();
                        }
                    }
                    else
                    {
                        if (cbAgregarFiltroPreciso.Checked == true)
                        {
                            var BuscarProductoConOferta = ObjDataInventario.Value.BuscaProductos(
                               new Nullable<decimal>(),
                               null,
                               _Descripcion,
                               _CodigoBarra,
                               _Referencia,
                               null,
                               null,
                               1,
                               Convert.ToDecimal(ddlSeleccionarCategoria.SelectedValue),
                               Convert.ToDecimal(ddlSeleccionarUnidadMedida.SelectedValue),
                               Convert.ToDecimal(ddlSeleccionarMarca.SelectedValue),
                               Convert.ToDecimal(ddlSeleccionarModelo.SelectedValue),
                               null, null, null,
                               false, true, null,
                               Convert.ToInt32(txtNumeroPagina.Value),
                               Convert.ToInt32(txtNumeroRegistros.Value));
                            dtListado.DataSource = BuscarProductoConOferta;
                            if (BuscarProductoConOferta.Count() < 1)
                            {
                                lbCantidadProductos.Text = "0";
                                lbCantidadProductosConOferta.Text = "0";
                                lbCantidadPoductosAgotarse.Text = "0";
                                lbProductosAgotados.Text = "0";
                            }
                            else
                            {
                                foreach (var n in BuscarProductoConOferta)
                                {
                                    int Cantidadproductos = Convert.ToInt32(n.CantidadRegistros);
                                    int ProductoConOferta = Convert.ToInt32(n.ProductosConOferta);
                                    int ProductoAgotarse = Convert.ToInt32(n.ProductoProximoAgotarse);
                                    int ProductoAgoado = Convert.ToInt32(n.ProductosAgostados);

                                    lbCantidadProductos.Text = Cantidadproductos.ToString("N0");
                                    lbCantidadProductosConOferta.Text = ProductoConOferta.ToString("N0");
                                    lbCantidadPoductosAgotarse.Text = ProductoAgotarse.ToString("N0");
                                    lbProductosAgotados.Text = ProductoAgoado.ToString("N0");
                                }
                            }
                            OcultarColumnas();
                        }
                        else
                        {
                            var BuscarProductoConOferta = ObjDataInventario.Value.BuscaProductos(
                               new Nullable<decimal>(),
                               null,
                               _Descripcion,
                               _CodigoBarra,
                               _Referencia,
                               null,
                               null,
                               1,
                               null,
                               null,
                               null,
                               null,
                               null, null, null,
                               false, true, null,
                               Convert.ToInt32(txtNumeroPagina.Value),
                               Convert.ToInt32(txtNumeroRegistros.Value));
                            dtListado.DataSource = BuscarProductoConOferta;
                            if (BuscarProductoConOferta.Count() < 1)
                            {
                                lbCantidadProductos.Text = "0";
                                lbCantidadProductosConOferta.Text = "0";
                                lbCantidadPoductosAgotarse.Text = "0";
                                lbProductosAgotados.Text = "0";
                            }
                            else
                            {
                                foreach (var n in BuscarProductoConOferta)
                                {
                                    int Cantidadproductos = Convert.ToInt32(n.CantidadRegistros);
                                    int ProductoConOferta = Convert.ToInt32(n.ProductosConOferta);
                                    int ProductoAgotarse = Convert.ToInt32(n.ProductoProximoAgotarse);
                                    int ProductoAgoado = Convert.ToInt32(n.ProductosAgostados);

                                    lbCantidadProductos.Text = Cantidadproductos.ToString("N0");
                                    lbCantidadProductosConOferta.Text = ProductoConOferta.ToString("N0");
                                    lbCantidadPoductosAgotarse.Text = ProductoAgotarse.ToString("N0");
                                    lbProductosAgotados.Text = ProductoAgoado.ToString("N0");
                                }
                            }
                            OcultarColumnas();
                        }
                    }

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar la consulta, codigo de error: " + ex.Message, variablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            this.dtListado.Columns["AplicaParaImpuesto0"].Visible = false;
            this.dtListado.Columns["EstatusProducto0"].Visible = false;
            this.dtListado.Columns["EstatusProducto"].Visible = false;


        }
        #endregion
        #region MOSTRAR LA IMAGEN POR DEFECTO
        private void MostrarImagenPorDefecto(PictureBox Imagen) {
            SqlCommand comando = new SqlCommand("select LogoEmpresa from Configuracion.ImagenesSistema where IdLogoEmpresa = 2", DSMarket.Data.Conexion.ConexionADO.BDConexion.ObtenerConexion());
            SqlDataAdapter adaptar = new SqlDataAdapter(comando);
            DataSet ds = new DataSet("LogoEmpresa");
            adaptar.Fill(ds, "LogoEmpresa");
            byte[] DATOS = new byte[0];
            DataRow dr = ds.Tables["LogoEmpresa"].Rows[0];
            DATOS = (byte[])dr["LogoEmpresa"];
            MemoryStream ms = new MemoryStream(DATOS);
            Imagen.Image = System.Drawing.Bitmap.FromStream(ms);
        }
        #endregion
        #region MOSTRAR LA IMAGEN DEL PRODUCTO SELECCIONADO
        private void MostrarImagenSeleccionado(PictureBox Imaen)
        {
            try {
                SqlCommand comando = new SqlCommand("select FotoProducto from Inventario.FotoProducto where IdProducto = " + variablesGlobales.IdMantenimeinto + " and NumeroConector = " + variablesGlobales.NumeroConector, DSMarket.Data.Conexion.ConexionADO.BDConexion.ObtenerConexion());
                SqlDataAdapter adaptar = new SqlDataAdapter(comando);
                DataSet ds = new DataSet("FotoProducto");
                adaptar.Fill(ds, "FotoProducto");
                byte[] DATOS = new byte[0];
                DataRow dr = ds.Tables["FotoProducto"].Rows[0];
                DATOS = (byte[])dr["FotoProducto"];
                MemoryStream ms = new MemoryStream(DATOS);
                Imaen.Image = System.Drawing.Bitmap.FromStream(ms);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, variablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region MOSTRAR LA CANTIDAD DE PRODUCTO DEFETUOSOS
        private void MostrarCantidadProductosDefectuosos() {
            var CantidadProductos = ObjDataInventario.Value.CantidadProductosDefectuosos();
            if (CantidadProductos.Count() < 1)
            {
                lbCantidadProductosConOferta.Text = "0";
            }
            else {
                foreach (var n in CantidadProductos) {
                    long Cantidad = Convert.ToInt64(n.CantidadProductosDefectuosos);
                    lbCantidadProductosConOferta.Text = Cantidad.ToString("N0");
                }
            }
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
            MostrarImagenPorDefecto(pbFoto);
            CargarTipoPdoducto();
            CargarCategorias();
            UnidadMedida();
            CargarMarcas();
            CargarModelos();
            MostrarListadoProducto();
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
            btnDescartar.Enabled = false;
            MostrarCantidadProductosDefectuosos();

            decimal IdNivelAcceso = DSMarket.Logica.Comunes.ValidarNivelUsuario.ValidarNivelAccesoUsuario(variablesGlobales.IdUsuario);

            if (IdNivelAcceso == 3) {
                btnEditar.Visible = false;
                btnEliminar.Visible = false;
                btnSuplir.Visible = false;
                btnSuplir.Visible = false;
                btnDescartar.Visible = false;
                btnReporte.Visible = false;
            }
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
            Mantenimiento.VariablesGlobales.IdUsuario = variablesGlobales.IdUsuario;
            Mantenimiento.VariablesGlobales.IdMantenimeinto = 0;
            Mantenimiento.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.MantenimientoProducto Mantenimiento = new MantenimientoProducto();
            Mantenimiento.VariablesGlobales.Accion = "UPDATE";
            Mantenimiento.VariablesGlobales.IdUsuario = variablesGlobales.IdUsuario;
            Mantenimiento.VariablesGlobales.IdMantenimeinto = variablesGlobales.IdMantenimeinto;
            Mantenimiento.VariablesGlobales.NumeroConector = variablesGlobales.NumeroConector;
            Mantenimiento.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.MantenimientoProducto Mantenimiento = new MantenimientoProducto();
            Mantenimiento.VariablesGlobales.Accion = "DELETE";
            Mantenimiento.VariablesGlobales.IdUsuario = variablesGlobales.IdUsuario;
            Mantenimiento.VariablesGlobales.IdMantenimeinto = variablesGlobales.IdMantenimeinto;
            Mantenimiento.VariablesGlobales.NumeroConector = variablesGlobales.NumeroConector;
            Mantenimiento.ShowDialog();
        }

        private void btnSuplir_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.AgregarQuitarProductos Suplir = new AgregarQuitarProductos();
            Suplir.VariablesGlobales.IdMantenimeinto = variablesGlobales.IdMantenimeinto;
            Suplir.VariablesGlobales.NumeroConector = variablesGlobales.NumeroConector;
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
            try {
                CargarCategorias();
            }
            catch (Exception) { }
        }

        private void ddlSeleccionarMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                CargarModelos();
            }
            catch (Exception) { }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if (cbProductosVendidosDescartados.Checked == true) {
                MostrarListadoProductosVendidosDescartados();
            }
            else {
                MostrarListadoProducto();
            }
        }

        private void txtNumeroPagina_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroPagina.Value < 1)
            {
                txtNumeroPagina.Value = 1;
                if (cbProductosVendidosDescartados.Checked == true)
                {
                    MostrarListadoProductosVendidosDescartados();
                }
                else
                {
                    MostrarListadoProducto();
                }
            }
            else {
                if (cbProductosVendidosDescartados.Checked == true)
                {
                    MostrarListadoProductosVendidosDescartados();
                }
                else
                {
                    MostrarListadoProducto();
                }
            }
        }

        private void txtNumeroRegistros_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroRegistros.Value < 1)
            {
                txtNumeroRegistros.Value = 10;
                if (cbProductosVendidosDescartados.Checked == true)
                {
                    MostrarListadoProductosVendidosDescartados();
                }
                else
                {
                    MostrarListadoProducto();
                }
            }
            else
            {
                if (cbProductosVendidosDescartados.Checked == true)
                {
                    MostrarListadoProductosVendidosDescartados();
                }
                else
                {
                    MostrarListadoProducto();
                }
            }
        }

        private void dtListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.variablesGlobales.IdMantenimeinto = Convert.ToDecimal(this.dtListado.CurrentRow.Cells["IdProducto"].Value.ToString());
            this.variablesGlobales.NumeroConector = Convert.ToDecimal(this.dtListado.CurrentRow.Cells["NumeroConector"].Value.ToString());
            this.variablesGlobales.LlevaDescuentoPregunta = Convert.ToBoolean(this.dtListado.CurrentRow.Cells["LlevaImagen0"].Value.ToString());
            decimal IdTipoProducto = Convert.ToDecimal(this.dtListado.CurrentRow.Cells["IdTipoProducto"].Value.ToString());
            bool Acumulativo = Convert.ToBoolean(this.dtListado.CurrentRow.Cells["ProductoAcumulativo0"].Value.ToString());
            bool EstatusProducto = Convert.ToBoolean(this.dtListado.CurrentRow.Cells["EstatusProducto0"].Value.ToString());

            if (cbProductosVendidosDescartados.Checked == true)
            {
                if (string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()))
                {
                    MessageBox.Show("Favor de ingresar la clave de seguridad para poder seleccionar un registro", variablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string _ClaveSeguridad = string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()) ? null : txtClaveSeguridad.Text.Trim();

                    var ValidarClaveSeguridad = ObjDataSeguridad.Value.BuscaClaveSeguridad(
                        new Nullable<decimal>(),
                        null,
                        DSMarket.Logica.Comunes.SeguridadEncriptacion.Encriptar(_ClaveSeguridad),
                        1, 1);
                    if (ValidarClaveSeguridad.Count() < 1)
                    {
                        MessageBox.Show("La clave de seguridad ingresada no es valida, favor de verificar", variablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtClaveSeguridad.Text = string.Empty;
                        txtClaveSeguridad.Focus();
                    }
                    else
                    {
                        if (MessageBox.Show("¿Quieres restaurar este registro?", variablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {


                            var BuscarProducto = ObjDataInventario.Value.BuscaProductos(
                                variablesGlobales.IdMantenimeinto,
                                variablesGlobales.NumeroConector,
                                null, null, null, null, null, null, null, null, null, null, null, null, null, null, true, null, 1, 1);
                            foreach (var n in BuscarProducto)
                            {
                                EstatusProducto = Convert.ToBoolean(n.EstatusProducto0);
                            }
                            DSMarket.Logica.Entidades.EntidadesInventario.EProducto Procesar = new Logica.Entidades.EntidadesInventario.EProducto();
                            Procesar.IdProducto = variablesGlobales.IdMantenimeinto;
                            Procesar.NumeroConector = variablesGlobales.NumeroConector;
                            Procesar.IdTipoProducto = IdTipoProducto;
                            Procesar.ProductoAcumulativo0 = Acumulativo;
                            Procesar.EstatusProducto0 = EstatusProducto;
                            var MAN = ObjDataInventario.Value.MantenimientoProducto(Procesar, "CHANGESTATUS");
                            MessageBox.Show("Registro restaurado con exito", variablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MostrarListadoProductosVendidosDescartados();
                        }
                    }
                }
            }
            else {
                if (MessageBox.Show("¿Quieres seleccionar este producto?", variablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                   

                    var SeleccionarRegistro = ObjDataInventario.Value.BuscaProductos(variablesGlobales.IdMantenimeinto, variablesGlobales.NumeroConector, null, null, null, null, null, null, null, null, null, null, null, null, null, null, false, null, 1, 1);
                    dtListado.DataSource = SeleccionarRegistro;
                    OcultarColumnas();
                    txtNumeroPagina.Enabled = false;
                    txtNumeroRegistros.Enabled = false;
                    btnNuevo.Enabled = false;
                    btnEditar.Enabled = true;
                    btnEliminar.Enabled = true;
                    if (IdTipoProducto == 1 && Acumulativo == true)
                    {
                        btnSuplir.Enabled = true;
                    }
                    else
                    {
                        btnSuplir.Enabled = false;
                    }
                    btnOferta.Enabled = true;

                    if (variablesGlobales.LlevaDescuentoPregunta == true)
                    {
                        MostrarImagenSeleccionado(pbFoto);
                    }
                    btnDescartar.Enabled = true;

                }
            }
           
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            txtNumeroPagina.Enabled = true;
            txtNumeroRegistros.Enabled = true;
            btnNuevo.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnSuplir.Enabled = false;
            btnOferta.Enabled = false;

            txtNumeroPagina.Value = 1;
            txtNumeroRegistros.Value = 10;
            txtdescripcion.Text = string.Empty;
            txtCodigoBarra.Text = string.Empty;
            txtReferencia.Text = string.Empty;

            CargarTipoPdoducto();
            CargarCategorias();
            UnidadMedida();
            CargarMarcas();
            CargarModelos();

            cbAgregarRangoFecha.Checked = false;
            cbAgregarFiltroPreciso.Checked = false;
            rbAmbos.Checked = true;
            MostrarListadoProducto();
            MostrarImagenPorDefecto(pbFoto);
        }

        private void btnProductoConOfertas_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.ProductosDefectuososConsulta Consulta = new ProductosDefectuososConsulta();
            Consulta.VariablesGlobales.IdUsuario = variablesGlobales.IdUsuario;
            Consulta.ShowDialog();
        }

        private void btnVerProductosPoximoAgotar_Click(object sender, EventArgs e)
        {

            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.EstadisticaProductos Estadistica = new EstadisticaProductos();
            Estadistica.VariablesGlobales.IdUsuario = variablesGlobales.IdUsuario;
            Estadistica.VariablesGlobales.EstadisticaProducto = 2;
            Estadistica.ShowDialog();
        }

        private void btnVerProductosAgotados_Click(object sender, EventArgs e)
        {

            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.EstadisticaProductos Estadistica = new EstadisticaProductos();
            Estadistica.VariablesGlobales.IdUsuario = variablesGlobales.IdUsuario;
            Estadistica.VariablesGlobales.EstadisticaProducto = 3;
            Estadistica.ShowDialog();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            if (cbTodoHistorial.Checked == true) {
                string RutaReporte = "";
                string UsuarioBD = "";
                string ClaveBD = "";


                var SacarCredenciales = ObjDataSeguridad.Value.SacarCredencialBD(1);
                foreach (var n2 in SacarCredenciales)
                {
                    UsuarioBD = n2.Usuario;
                    ClaveBD = DSMarket.Logica.Comunes.SeguridadEncriptacion.DesEncriptar(n2.Clave);
                }


                var SacarRutaReporte = ObjdataConfiguracion.Value.BuscaRutaReporte(5);
                foreach (var n in SacarRutaReporte)
                {
                    RutaReporte = n.RutaReporte;
                }

                DSMarket.Solucion.Pantallas.Pantallas.Reportes.Reportes Invocar = new Reportes.Reportes();
                Invocar.GenerarReporteInventarioGeneral(RutaReporte, UsuarioBD, ClaveBD);
                Invocar.ShowDialog();
            }
            else {
                MessageBox.Show("Opcion no disponible"); 
            }
        }

        private void ddlSeleccionarCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                CargarMarcas();
            }
            catch (Exception) { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.PasarInventarioDefectuoso Descartar = new PasarInventarioDefectuoso();
            Descartar.VariablesGlobales.IdUsuario = variablesGlobales.IdUsuario;
            Descartar.VariablesGlobales.IdMantenimeinto = variablesGlobales.IdMantenimeinto;
            Descartar.VariablesGlobales.NumeroConector = variablesGlobales.NumeroConector;
            Descartar.ShowDialog();
        }

        private void cbProductosVendidosDescartados_CheckedChanged(object sender, EventArgs e)
        {
            if (cbProductosVendidosDescartados.Checked) {
                lbClaveSeguridad.Visible = true;
                txtClaveSeguridad.Visible = true;
            }
            else {
                lbClaveSeguridad.Visible = false;
                txtClaveSeguridad.Visible = false;
            }
        }

        private void Txtdescripcion_TextChanged(object sender, EventArgs e)
        {
            if (cbProductosVendidosDescartados.Checked == true)
            {
                MostrarListadoProductosVendidosDescartados();
            }
            else
            {
                MostrarListadoProducto();
            }
        }

        private void TxtCodigoBarra_TextChanged(object sender, EventArgs e)
        {
            if (cbProductosVendidosDescartados.Checked == true)
            {
                MostrarListadoProductosVendidosDescartados();
            }
            else
            {
                MostrarListadoProducto();
            }
        }

        private void TxtReferencia_TextChanged(object sender, EventArgs e)
        {
            if (cbProductosVendidosDescartados.Checked == true)
            {
                MostrarListadoProductosVendidosDescartados();
            }
            else
            {
                MostrarListadoProducto();
            }
        }

        private void TxtNumeroSeguimiento_TextChanged(object sender, EventArgs e)
        {
            if (cbProductosVendidosDescartados.Checked == true)
            {
                MostrarListadoProductosVendidosDescartados();
            }
            else
            {
                MostrarListadoProducto();
            }
        }
    }
}
