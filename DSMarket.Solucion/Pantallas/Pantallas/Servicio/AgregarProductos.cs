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
                    if (BuscaRegistros.Count() < 1)
                    {
                        lbCantidadMostradaVariable.Text = "000";
                    }
                    else {
                        foreach (var n in BuscaRegistros) {
                            int CantidadExistenteSeleccionada = Convert.ToInt32(n.CantidadRegistros);
                            lbCantidadMostradaVariable.Text = CantidadExistenteSeleccionada.ToString("N0");
                        }
                    }
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
                    if (BuscaRegistros.Count() < 1)
                    {
                        lbCantidadMostradaVariable.Text = "000";
                    }
                    else
                    {
                        foreach (var n in BuscaRegistros)
                        {
                            int CantidadExistenteSeleccionada = Convert.ToInt32(n.CantidadRegistros);
                            lbCantidadMostradaVariable.Text = CantidadExistenteSeleccionada.ToString("N0");
                        }
                    }
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
        #region CALCULAR DESCUENTO MAXIMO
        private decimal CalcularDescuentoMaximo(decimal PrecioVenta, decimal PorcientoDescento)
        {
            decimal PorcientoDescuentoDecimal = PorcientoDescento / 100;
            decimal Resultado = PorcientoDescuentoDecimal * PrecioVenta;
            return Resultado;
        }
        #endregion
        #region AGREGAR O EDITAR PRODUCTOS
        private void AgregarEditarProductos(string Accion) {
            try {
                DSMarket.Logica.Entidades.EntidadesServicio.EFacturacionProducto AgregarEditar = new Logica.Entidades.EntidadesServicio.EFacturacionProducto();

                AgregarEditar.NumeroConector = VariablesGlbales.NumeroConector;
                AgregarEditar.IdTipoProducto = VariablesGlbales.IdTipoProductoSeleccionadoAgregarEditar;
                AgregarEditar.IdCategoria = VariablesGlbales.IdCategoriaSeleccionadoAgregarEditar;
                AgregarEditar.DescripcionProducto = txtProducto.Text;
                AgregarEditar.CantidadVendida = Convert.ToDecimal(txtCantidadUsar.Text);
                AgregarEditar.Precio = Convert.ToDecimal(txtPrecio.Text);
                AgregarEditar.DescuentoAplicado = Convert.ToDecimal(txtDescuento.Text);
                AgregarEditar.DescripcionTipoProducto = VariablesGlbales.DescripcionTipoProductoAgregarProductos;
                AgregarEditar.PorcientoDescuento = Convert.ToInt32(txtPorcientoDescyento.Text);
                AgregarEditar.IdProducto = Convert.ToDecimal(VariablesGlbales.IdProductoSeleccionadoAgregarEditar);
                AgregarEditar.Acumulativo = txtAcumulativo.Text;
                AgregarEditar.ConectorProducto = VariablesGlbales.IdNumeroConectorProductoAgregarEditar;


                var MAn = ObjDataServicio.Value.GuardarFacturacionProductos(AgregarEditar, Accion);


            }
            catch (Exception ex) {
                MessageBox.Show("Error al Agregar o editar productos, Codigo de error--> " + ex.Message, VariablesGlbales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region CALCULAR EL DESCUENTO COLECTIVO
        private void CalcularColectivo() {
            try
            {
                decimal DescuentoMAximo = Convert.ToDecimal(lbDescuentoMaximo.Text);
                decimal CantidadUsar = Convert.ToDecimal(txtCantidadUsar.Text);
                decimal Operacion = DescuentoMAximo * CantidadUsar;
                lbDescuentoColectivoVariable.Text = Operacion.ToString("N2");
            }
            catch (Exception)
            {
                lbDescuentoColectivoVariable.Text = "0";
            }
        }
        #endregion
        #region VALIDAR EL DESCENTO DE ARTICULO
        private decimal ValidarDescuento(decimal Valor1, decimal Valor2) {

            decimal Valor3 = Valor1 * Valor2;
            return Valor3;
        }
        #endregion
        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Servicio.Facturacion Facturacion = new Facturacion();
            Facturacion.VariablesGlobales.IdUsuario = VariablesGlbales.IdUsuario;
            Facturacion.VariablesGlobales.GenerarConector = VariablesGlbales.GenerarConector;
            Facturacion.VariablesGlobales.SacarDataEspejo = true;
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
                int TipoProducto = 0;
                txtDescuento.Text = "0";
                decimal IdProductoSeleccionado = Convert.ToDecimal(this.dtSeleccionarproducto.CurrentRow.Cells["IdProducto"].Value.ToString());
                this.VariablesGlbales.IdProductoSeleccionadoAgregarPorpductos = Convert.ToDecimal(this.dtSeleccionarproducto.CurrentRow.Cells["IdProducto"].Value.ToString());
                this.VariablesGlbales.NumeroConectorSeleccionadoAgregarPorpductos = Convert.ToDecimal(this.dtSeleccionarproducto.CurrentRow.Cells["NumeroConector"].Value.ToString());
                this.VariablesGlbales.DescripcionTipoProductoAgregarProductos = this.dtSeleccionarproducto.CurrentRow.Cells["TipoProducto"].Value.ToString();
                int CantidadAlmcen = Convert.ToInt32(this.dtSeleccionarproducto.CurrentRow.Cells["Stock"].Value.ToString());
                bool LlevaImagen = Convert.ToBoolean(this.dtSeleccionarproducto.CurrentRow.Cells["LlevaImagen0"].Value.ToString());

                if (CantidadAlmcen <= 0)
                {
                    MessageBox.Show("Este producto esta agotado, favor de suplir mas", VariablesGlbales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else {
                    {
                        var Buscar = ObjDataLogicaInventario.Value.BuscaProductos(
                     IdProductoSeleccionado,
                     null, null, null, null, null, null, null, null, null, null, null, null, 1, 1);

                        foreach (var n in Buscar)
                        {
                            VariablesGlbales.IdTipoProductoSeleccionadoAgregarEditar = Convert.ToDecimal(n.IdTipoProducto);
                            VariablesGlbales.IdCategoriaSeleccionadoAgregarEditar = Convert.ToDecimal(n.IdCategoria);
                            VariablesGlbales.IdProductoSeleccionadoAgregarEditar = Convert.ToDecimal(n.IdProducto);
                            VariablesGlbales.NumeroConectorSeleccionadoAgregarPorpductos = Convert.ToDecimal(n.NumeroConector);
                            TipoProducto = Convert.ToInt32(n.IdTipoProducto);
                            txtTipoProducto.Text = n.TipoProducto;
                            txtCategoria.Text = n.Categoria;
                            txtProducto.Text = n.Producto;
                            int CantidadDisponible = Convert.ToInt32(n.Stock);
                            txtCantidadDisponible.Text = CantidadDisponible.ToString("N0");
                            if (TipoProducto == 1)
                            {

                                decimal Precio = Convert.ToDecimal(n.PrecioVenta);
                                txtPrecio.Text = Precio.ToString("N2");

                                cbEditarPrecio.Checked = false;
                                cbEditarPrecio.Enabled = true;
                                txtPrecio.Enabled = false;
                            }
                            else if (TipoProducto == 2)
                            {

                                decimal Precio = Convert.ToDecimal(n.PrecioVenta);
                                txtPrecio.Text = Precio.ToString("N0");
                                cbEditarPrecio.Checked = true;
                                cbEditarPrecio.Enabled = false;
                                txtPrecio.Enabled = true;

                            }
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
                                txtCantidadUsar.Text = "1";
                                txtCantidadUsar.Enabled = true;
                                txtCantidadUsar.Focus();
                                lbDescuentoColectivoVariable.Text = "0";
                                lbDescuentoColectivoTitulo.Visible = true;
                                lbDescuentoColectivoVariable.Visible = true;
                                lbDescuentoColectivoVariable.Text = lbDescuentoMaximo.Text;

                            }
                            else
                            {
                                txtCantidadUsar.Text = "1";
                                txtCantidadUsar.Enabled = false;
                                lbDescuentoColectivoTitulo.Visible = false;
                                lbDescuentoColectivoVariable.Visible = false;
                                lbDescuentoColectivoVariable.Text = "0";
                            }

                            if (LlevaImagen == true)
                            {
                                btnfoto.Enabled = true;
                            }
                            else
                            {
                                btnfoto.Enabled = false;
                            }
                            btnAgregar.Enabled = true;
                        }
                    }
                    decimal DescuentoMaximo = CalcularDescuentoMaximo(Convert.ToDecimal(txtPrecio.Text), Convert.ToDecimal(txtPorcientoDescyento.Text));
                    if (DescuentoMaximo < 1)
                    {
                        lbDescuentoMaximo.Text = DescuentoMaximo.ToString("N2");
                        txtDescuento.Enabled = false;
                    }
                    else
                    {
                        lbDescuentoMaximo.Text = DescuentoMaximo.ToString("N2");
                        txtDescuento.Enabled = true;
                    }
                }

            }

            CalcularColectivo();
        }

        private void txtDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            DSMarket.Logica.Comunes.ValidarControles.SoloNumeros(e);
        }

        private void btnfoto_Click(object sender, EventArgs e)
        {
            DSMarket.Solucion.Pantallas.Pantallas.Servicio.FotoProducto Foto = new FotoProducto();
            Foto.VariablesGlovbales.IdProductoSeleccionadoAgregarPorpductos = VariablesGlbales.IdProductoSeleccionadoAgregarPorpductos;
            Foto.VariablesGlovbales.NumeroConectorSeleccionadoAgregarPorpductos = VariablesGlbales.NumeroConectorSeleccionadoAgregarPorpductos;
            Foto.ShowDialog();
        }

        private void cbEditarPrecio_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEditarPrecio.Checked == true)
            {
                txtPrecio.Enabled = true;
            }
            else {
                txtPrecio.Enabled = false;
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            DSMarket.Logica.Comunes.ValidarControles.SoloNumerosDecimales(e);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //VALIDAMOS EL TIPO DE PRODUCTO SELECCIONADO
            if (VariablesGlbales.IdTipoProductoSeleccionadoAgregarEditar == 1) {
                //VALIDAMOS SI EL PRODUCTO ES ACUMULATIVO
                string ProductoAcumulativo = txtAcumulativo.Text;

                if (ProductoAcumulativo == "SI")
                {
                    //VERIFICAMOS SI LA CANTIDAD A USAR NO ESTA VACIA
                    int Valor = Convert.ToInt32(txtCantidadUsar.Text);
                    if (string.IsNullOrEmpty(txtCantidadUsar.Text.Trim()) || Valor <1)
                    {
                        txtCantidadUsar.Text = "1";
                    }
                    //VALIDAMOS LA CANTIDAD EN ALMACEN Y VERIFICAMOS QUE LA CANTIDAD A VENDER ES VALIDA.
                    int CantidadVender = Convert.ToInt32(txtCantidadUsar.Text);
                    int CantidadDisponible = 0;

                    var ValidarCantidadDisponible = ObjDataLogicaInventario.Value.BuscaProductos(
                        VariablesGlbales.IdProductoSeleccionadoAgregarEditar,
                        VariablesGlbales.NumeroConectorSeleccionadoAgregarPorpductos,
                        null,
                        null,
                        null,
                        null,
                        null,
                        null,
                        null,
                        null,
                        null,
                        null,
                        null,
                        1, 1);
                    foreach (var n in ValidarCantidadDisponible)
                    {
                        CantidadDisponible = Convert.ToInt32(n.Stock);
                    }

                    if (CantidadVender > CantidadDisponible)
                    {
                        MessageBox.Show("La cantidad que intentas agregar a factura, supera la cantidad que tienes en inventario, favor de verificar", VariablesGlbales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {

                        decimal DescuentoMaximo = Convert.ToDecimal(lbDescuentoColectivoVariable.Text);
                        decimal DescuentoAplicar = Convert.ToDecimal(txtDescuento.Text);
                        if (DescuentoAplicar > DescuentoMaximo)
                        {
                            MessageBox.Show("El descuento ingresado supera la cantidad permitida para descontar en este articulo, favor de verificar", VariablesGlbales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else {
                            AgregarEditarProductos("INSERT");
                        }
                  
                    }
                }
                else if (ProductoAcumulativo == "NO") {

                    decimal DescuentoMaximo = Convert.ToDecimal(lbDescuentoColectivoVariable.Text);
                    decimal DescuentoAplicar = Convert.ToDecimal(txtDescuento.Text);
                    if (DescuentoAplicar > DescuentoMaximo)
                    {
                        MessageBox.Show("El descuento ingresado supera la cantidad permitida para descontar en este articulo, favor de verificar", VariablesGlbales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        //AGREGAR PRODUCTO Y ELIMINAR
                        AgregarEditarProductos("INSERT");
                    }
                }
            }
            else if (VariablesGlbales.IdTipoProductoSeleccionadoAgregarEditar == 2) {


                decimal DescuentoMaximo = Convert.ToDecimal(lbDescuentoColectivoVariable.Text);
                decimal DescuentoAplicar = Convert.ToDecimal(txtDescuento.Text);
                if (DescuentoAplicar > DescuentoMaximo)
                {
                    MessageBox.Show("El descuento ingresado supera la cantidad permitida para descontar en este articulo, favor de verificar", VariablesGlbales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //AGREGAR PRODUCTO
                    AgregarEditarProductos("INSERT");
                }
            }
        }

        private void txtCantidadUsar_TextChanged(object sender, EventArgs e)
        {
            CalcularColectivo();
        }
    }
}
