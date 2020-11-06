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
    public partial class MantenimientoProducto : Form
    {
        public MantenimientoProducto()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaListas.LogicaListas> ObjDataListas = new Lazy<Logica.Logica.LogicaListas.LogicaListas>();
        Lazy<DSMarket.Logica.Logica.LogicaInventario.LogicaInventario> ObjDataInventario = new Lazy<Logica.Logica.LogicaInventario.LogicaInventario>();
        Lazy<DSMarket.Logica.Logica.LogicaSeguridad.LogicaSeguridad> ObjDataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad.LogicaSeguridad>();
        Lazy<DSMarket.Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion> ObjDataConfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region CARGAR LAS LISTAS DESPLEGABLES
        private void CargarTipoProducto() {
            try {
                var TipoPrducto = ObjDataListas.Value.ListaTipoProducto(
              new Nullable<decimal>(), null);
                ddlSeleccionarTipoProducto.DataSource = TipoPrducto;
                ddlSeleccionarTipoProducto.DisplayMember = "Descripcion";
                ddlSeleccionarTipoProducto.ValueMember = "IdTipoproducto";

                int TipoProducto = Convert.ToInt32(ddlSeleccionarTipoProducto.SelectedValue);
                if (TipoProducto == 2)
                {
                    cbacumulativo.Checked = false;
                    cbacumulativo.Enabled = false;
                    txtStock.Enabled = false;
                    txtStock.Text = "1";

                    txtStockMinimo.Enabled = false;
                    txtPrecioCompra.Enabled = false;
                    txtStockMinimo.Text = "0";
                    txtPrecioCompra.Text = "0";
                }
                else
                {
                    cbacumulativo.Checked = false;
                    cbacumulativo.Enabled = true;
                    txtStock.Enabled = false;
                    txtStock.Text = "1";

                    txtStockMinimo.Enabled = true;
                    txtPrecioCompra.Enabled = true;
                    txtStockMinimo.Text = string.Empty;
                    txtPrecioCompra.Text = string.Empty;
                }
            }
            catch (Exception) { }
        }
        private void CargarCategorias() {
            try {
                var Categorias = ObjDataListas.Value.ListadoCategorias(Convert.ToDecimal(ddlSeleccionarTipoProducto.SelectedValue));
                ddlSeleccionarCategoria.DataSource = Categorias;
                ddlSeleccionarCategoria.DisplayMember = "Descripcion";
                ddlSeleccionarCategoria.ValueMember = "IdCategoria";
            }
            catch (Exception) { }
        }
        private void CargarUnidadMedida() {
            var UnidadMeddida = ObjDataListas.Value.BuscaUnidadMedida();
            ddlSeleccionarUnidadMedida.DataSource = UnidadMeddida;
            ddlSeleccionarUnidadMedida.DisplayMember = "Descripcion";
            ddlSeleccionarUnidadMedida.ValueMember = "IdUnidadMedida";
        }
        private void CargarMarcas() {
            var MArcas = ObjDataListas.Value.BucaLisaMarcas(
                Convert.ToDecimal(ddlSeleccionarCategoria.SelectedValue));
            ddlSeleccionarMarca.DataSource = MArcas;
            ddlSeleccionarMarca.DisplayMember = "Descripcion";
            ddlSeleccionarMarca.ValueMember = "IdMarca";
        }
        private void CargarModelos() {
            try {
                var CargarModelos = ObjDataListas.Value.BuscaListaModelos(Convert.ToDecimal(ddlSeleccionarMarca.SelectedValue));
                ddlSeleccionarModelo.DataSource = CargarModelos;
                ddlSeleccionarModelo.DisplayMember = "Descripcion";
                ddlSeleccionarModelo.ValueMember = "IdModelo";
            }
            catch (Exception) { }
        }
        private void CargarTipoSuplidores() {
            var TipoSuplidores = ObjDataListas.Value.BuscaListaTipoSuplidor();
            ddlSeleccionarTipoSuplidor.DataSource = TipoSuplidores;
            ddlSeleccionarTipoSuplidor.DisplayMember = "Descripcion";
            ddlSeleccionarTipoSuplidor.ValueMember = "IdTipoSuplidor";
        }
        private void CargarSupldores() {
            try {
                var Suplidores = ObjDataListas.Value.BuscaListaSuplidores(Convert.ToDecimal(ddlSeleccionarTipoSuplidor.SelectedValue));
                ddlSeleccionarSuplidor.DataSource = Suplidores;
                ddlSeleccionarSuplidor.DisplayMember = "Nombre";
                ddlSeleccionarSuplidor.ValueMember = "IdSuplidor";
            }
            catch (Exception) { }
        }
        private void CargarColores() {
            var CargarListaColores = ObjDataListas.Value.ListadoColores();
            ddlSeleccionarColor.DataSource = CargarListaColores;
            ddlSeleccionarColor.DisplayMember = "Color";
            ddlSeleccionarColor.ValueMember = "IdColor";
        }
        private void CargarCondiciones() {
            var CargarListaCondiciones = ObjDataListas.Value.ListadoCondiciones();
            ddlSeleccionarCondicion.DataSource = CargarListaCondiciones;
            ddlSeleccionarCondicion.DisplayMember = "Condicion";
            ddlSeleccionarCondicion.ValueMember = "IdCondicion";
        }
        private void CargarCapacidad() {
            var CargarCapacidad = ObjDataListas.Value.ListadoCapacidad();
            ddlSeleccionarCapacidad.DataSource = CargarCapacidad;
            ddlSeleccionarCapacidad.DisplayMember = "Capacidad";
            ddlSeleccionarCapacidad.ValueMember = "IdCapacidad";
        }
        #endregion
        #region APLICAR TEMA
        private void AplicarTema() {
            lbTitulo.ForeColor = Color.WhiteSmoke;
            txtClaveSeguridad.BackColor = Color.WhiteSmoke;
            txtCodigoBarra.BackColor = Color.WhiteSmoke;
            txtComentario.BackColor = Color.WhiteSmoke;
            txtdescripcion.BackColor = Color.WhiteSmoke;
            txtPorcientoDescuento.BackColor = Color.WhiteSmoke;
            txtPrecioCompra.BackColor = Color.WhiteSmoke;
            txtPrecioVenta.BackColor = Color.WhiteSmoke;
            txtReferencia.BackColor = Color.WhiteSmoke;
            txtStock.BackColor = Color.WhiteSmoke;
            txtStockMinimo.BackColor = Color.WhiteSmoke;
            ddlSeleccionarCategoria.BackColor = Color.WhiteSmoke;
            ddlSeleccionarMarca.BackColor = Color.WhiteSmoke;
            ddlSeleccionarModelo.BackColor = Color.WhiteSmoke;
            ddlSeleccionarSuplidor.BackColor = Color.WhiteSmoke;
            ddlSeleccionarTipoProducto.BackColor = Color.WhiteSmoke;
            ddlSeleccionarTipoSuplidor.BackColor = Color.WhiteSmoke;
            ddlSeleccionarUnidadMedida.BackColor = Color.WhiteSmoke;
            
        }
        #endregion
        #region GUARDAR IMAGEN DE PRODUCTO
        private void GuardarImagen() {
            try {
                SqlCommand comando = new SqlCommand();
                comando.Connection = DSMarket.Data.Conexion.ConexionADO.BDConexion.ObtenerConexion();
                comando.CommandText = "";

              
                /*  SqlCommand comando = new SqlCommand();
            comando.Connection = DSSistemaPuntoVentaClinico.Data.Conexiones.ConexionADO.BDConexion.ObtenerConexion();
            comando.CommandText = "EXEC Configuracion.SP_GUARDAR_LOGO_EMPRESA @IdLogoEmpresa,@Descripcion,@LogoEmpresa";

            comando.Parameters.Add("@IdLogoEmpresa", SqlDbType.Decimal);
            comando.Parameters.Add("@Descripcion", SqlDbType.VarChar);
            comando.Parameters.Add("@LogoEmpresa", SqlDbType.Image);

            comando.Parameters["@IdLogoEmpresa"].Value = 1;
            comando.Parameters["@Descripcion"].Value = "Logo";
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            comando.Parameters["@LogoEmpresa"].Value = ms.GetBuffer();

            DSSistemaPuntoVentaClinico.Data.Conexiones.ConexionADO.BDConexion.ObtenerConexion();
            comando.ExecuteNonQuery();
            DSSistemaPuntoVentaClinico.Data.Conexiones.ConexionADO.BDConexion.ObtenerConexion().Close();
            MessageBox.Show("Imagen Guardada");*/
            }
            catch (Exception) { }
        }
        #endregion
        #region MANTENIMIENTO DE PRODUCTOS
        private void MANProductos()
        {
            try {
                DSMarket.Logica.Comunes.ProcesarInformacion.ProcesarInformacionProductos Procesar = new Logica.Comunes.ProcesarInformacion.ProcesarInformacionProductos(
                    VariablesGlobales.IdMantenimeinto,
                    VariablesGlobales.NumeroConector,
                    Convert.ToDecimal(ddlSeleccionarTipoProducto.SelectedValue),
                    Convert.ToDecimal(ddlSeleccionarCategoria.SelectedValue),
                    Convert.ToDecimal(ddlSeleccionarUnidadMedida.SelectedValue),
                    Convert.ToDecimal(ddlSeleccionarMarca.SelectedValue),
                    Convert.ToDecimal(ddlSeleccionarModelo.SelectedValue),
                    Convert.ToDecimal(ddlSeleccionarTipoSuplidor.SelectedValue),
                    Convert.ToDecimal(ddlSeleccionarSuplidor.SelectedValue),
                    txtdescripcion.Text,
                    txtCodigoBarra.Text,
                    txtReferencia.Text,
                    Convert.ToDecimal(txtPrecioCompra.Text),
                    Convert.ToDecimal(txtPrecioVenta.Text),
                    Convert.ToDecimal(txtStock.Text),
                    Convert.ToDecimal(txtStockMinimo.Text),
                    Convert.ToDecimal(txtPorcientoDescuento.Value),
                    cbAceptaOferta.Checked,
                    cbacumulativo.Checked,
                    cbLlevaImagen.Checked,
                    VariablesGlobales.IdUsuario,
                    DateTime.Now,
                    VariablesGlobales.IdUsuario,
                    DateTime.Now,
                    DateTime.Now,
                    txtComentario.Text,
                    cbAplicaDescuento.Checked,
                    false,
                    txtNumeroSeguimiento.Text,
                    Convert.ToDecimal(ddlSeleccionarColor.SelectedValue),
                    Convert.ToDecimal(ddlSeleccionarCondicion.SelectedValue),
                    Convert.ToDecimal(ddlSeleccionarCapacidad.SelectedValue),
                    VariablesGlobales.Accion);
                Procesar.ProcesarInformacion();



                if (cbLlevaImagen.Checked == true)
                {
                    SacarIdProductoCreado(VariablesGlobales.NumeroConector);
                    GuardarFotoProducto();
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Error al realizar el mantenimiento, codigo de error: " + ex.Message, VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region CERRAR Y RESTABLECER LA PANTALLA
        private void CerrarPantalla() {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.ProductoConsulta Consulta = new ProductoConsulta();
            Consulta.variablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Consulta.ShowDialog();
        }
        private void RestablecerPantalla() {
            CargarTipoProducto();
            CargarCategorias();
            CargarUnidadMedida();
            CargarMarcas();
            CargarModelos();
            CargarTipoSuplidores();
            CargarSupldores();
            txtCodigoBarra.Text = string.Empty;
            txtComentario.Text = string.Empty;
            txtdescripcion.Text = string.Empty;
            txtPorcientoDescuento.Value = 0;
            txtPrecioCompra.Text = string.Empty;
            txtPrecioVenta.Text = string.Empty;
            txtReferencia.Text = string.Empty;
            txtStock.Text = string.Empty;
            txtStockMinimo.Text = string.Empty;
            GenerarConector();
            MostrarImagenPorDefecto(pbFoto);
            txtStock.Text = "1";
            txtStockMinimo.Text = "1";
            cbacumulativo.Checked = false;
        }
        #endregion
        #region SACAR LOS DATOS DEL PRODUCTO
        private void SacardatosProducto(decimal IdProducto, decimal NumeroConector)
        {
            var SacarDatos = ObjDataInventario.Value.BuscaProductos(
                IdProducto,
                NumeroConector,
                null, null, null, null, null, null, null, null, null, null, null, null, null, null, false, null, 1, 1);
            foreach (var n in SacarDatos)
            {
                ddlSeleccionarTipoProducto.Text = n.TipoProducto;
                ddlSeleccionarCategoria.Text = n.Categoria;
                ddlSeleccionarUnidadMedida.Text = n.UnidadMedida;
                ddlSeleccionarMarca.Text = n.Marca;
                ddlSeleccionarModelo.Text = n.Modelo;
                ddlSeleccionarTipoSuplidor.Text = n.TipoSuplidor;
                ddlSeleccionarSuplidor.Text = n.Suplidor;
                ddlSeleccionarColor.Text = n.Color;
                ddlSeleccionarCondicion.Text = n.Condicion;
                ddlSeleccionarCapacidad.Text = n.Capacidad;
                txtdescripcion.Text = n.Producto;
                txtComentario.Text = n.Comentario;
                txtCodigoBarra.Text = n.CodigoBarra;
                txtReferencia.Text = n.Referencia;
                txtPrecioCompra.Text = n.PrecioCompra.ToString();
                txtPrecioVenta.Text = n.PrecioVenta.ToString();
                txtStock.Text = n.Stock.ToString();
                txtStockMinimo.Text = n.StockMinimo.ToString();
                txtPorcientoDescuento.Text = n.PorcientoDescuento.ToString();
                cbAceptaOferta.Checked = (n.AfectaOferta0.HasValue ? n.AfectaOferta0.Value : false);
                cbacumulativo.Checked = (n.ProductoAcumulativo0.HasValue ? n.ProductoAcumulativo0.Value : false);
                cbLlevaImagen.Checked = (n.LlevaImagen0.HasValue ? n.LlevaImagen0.Value : false);
                cbAplicaDescuento.Checked = (n.AplicaParaImpuesto0.HasValue ? n.AplicaParaImpuesto0.Value : false);
                txtStock.Text = n.Stock.ToString();
                txtNumeroSeguimiento.Text = n.NumeroSeguimiento;

                if (cbLlevaImagen.Checked == true)
                {
                    //HALAR LA IMAGEN
                }
            }
        }
        #endregion
        #region MOSTRAR LA IMAGEN POR DEFECTO
        private void MostrarImagenPorDefecto(PictureBox Imagen)
        {
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
        #region GUARDAR FOTO DE PRODUCTO
        private void GuardarFotoProducto() {
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "EXEC Inventario.SP_GUARDAR_FOTO_PRODUCTO @IdProducto,@NumeroConector,@FotoProducto";
            comando.Connection = DSMarket.Data.Conexion.ConexionADO.BDConexion.ObtenerConexion();

            comando.Parameters.Add("@IdProducto", SqlDbType.Decimal);
            comando.Parameters.Add("@NumeroConector", SqlDbType.Decimal);
            comando.Parameters.Add("@FotoProducto", SqlDbType.Image);

            comando.Parameters["@IdProducto"].Value = Convert.ToDecimal(VariablesGlobales.IdMantenimeinto);
            comando.Parameters["@NumeroConector"].Value = Convert.ToDecimal(VariablesGlobales.NumeroConector);

            MemoryStream ms = new MemoryStream();
            pbFoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            comando.Parameters["@FotoProducto"].Value = ms.GetBuffer();

            DSMarket.Data.Conexion.ConexionADO.BDConexion.ObtenerConexion();
            comando.ExecuteNonQuery();
            DSMarket.Data.Conexion.ConexionADO.BDConexion.ObtenerConexion().Close();
        }
        #endregion
        #region SACAR EL ID DEL DEL PRODUCTO CREADO
        private void SacarIdProductoCreado(decimal NumeroConector)
        {
            var SacarId = ObjDataInventario.Value.BuscaProductos(
                new Nullable<decimal>(),
                NumeroConector,
                null, null, null, null, null, null, null, null, null, null, null, null, null, null, false, null, 1, 1);
            foreach (var n in SacarId)
            {
                VariablesGlobales.IdMantenimeinto = Convert.ToDecimal(n.IdProducto);
            }
        }
        #endregion
        #region GENERAR NUMERO DE CONECTOR
        private void GenerarConector() {
            Random Aleatorio = new Random();
            decimal Numero = Aleatorio.Next(0, 999999999);
            VariablesGlobales.NumeroConector = Numero;
        }
        #endregion

        #region MOSTRAR LA IMAGEN DEL PRODUCTO SELECCIONADO
        private void MostrarImagenSeleccionado(PictureBox Imaen)
        {
            try {
                SqlCommand comando = new SqlCommand("select FotoProducto from Inventario.FotoProducto where IdProducto = " + VariablesGlobales.IdMantenimeinto + " and NumeroConector = " + VariablesGlobales.NumeroConector, DSMarket.Data.Conexion.ConexionADO.BDConexion.ObtenerConexion());
                SqlDataAdapter adaptar = new SqlDataAdapter(comando);
                DataSet ds = new DataSet("FotoProducto");
                adaptar.Fill(ds, "FotoProducto");
                byte[] DATOS = new byte[0];
                DataRow dr = ds.Tables["FotoProducto"].Rows[0];
                DATOS = (byte[])dr["FotoProducto"];
                MemoryStream ms = new MemoryStream(DATOS);
                Imaen.Image = System.Drawing.Bitmap.FromStream(ms);
            }
            catch (Exception) { }
        }
        #endregion
        #region VALIDACIONES DE PANTALLA
        private void RealizarValidaciones() {
            //MOSTRAR EL CONTROL CHECK EN LA PANTALLA DE MANTENIMIENTO DE INVENTARIO
            VariablesGlobales.ValidarMostrarCheckLimpiarPantalla = DSMarket.Logica.Comunes.ValidarConfiguracionGeneral.Validar(8);
            VariablesGlobales.ValidarValidarCheckLimpiarPantalla = DSMarket.Logica.Comunes.ValidarConfiguracionGeneral.Validar(9);
            VariablesGlobales.ValidarCampoEspeciaProductolNumerico = DSMarket.Logica.Comunes.ValidarConfiguracionGeneral.Validar(11);
            VariablesGlobales.ValidarCampoEspecialProductoUnico = DSMarket.Logica.Comunes.ValidarConfiguracionGeneral.Validar(12);

            //CAMPOS ESPECIALES
            int LongigutCampoEspecial = 0;
            var CampoEspecial = ObjDataConfiguracion.Value.BuscaCaposEspeciales(1);
            foreach (var n in CampoEspecial) {
                lbReferencia.Text = n.Nombre;
                LongigutCampoEspecial = Convert.ToInt32(n.LongitudCampo);
                txtReferencia.MaxLength = LongigutCampoEspecial;
            }

            if (VariablesGlobales.ValidarMostrarCheckLimpiarPantalla == true) {
                cbLimpiarPantalla.Visible = true;
            }
            else {
                cbLimpiarPantalla.Visible = false;
            }

            if (VariablesGlobales.ValidarValidarCheckLimpiarPantalla == true) {
                cbLimpiarPantalla.Checked = true;
            }
            else {
                cbLimpiarPantalla.Checked = false;
            }

            //VALIDAR SI EL CAMPO REFERENCIA 
            if (VariablesGlobales.ValidarCampoEspecialProductoUnico == true) {
                panelReferencia.Visible = true;
                lbValidarreferencia.Visible = true;
                btnMostrarRegistro.Visible = true;
            }
            else {
                panelReferencia.Visible = false;
                lbValidarreferencia.Visible = false;
                btnMostrarRegistro.Visible = false;

            }

        }
        #endregion
        private void PCerrar_Click(object sender, EventArgs e)
        {
            CerrarPantalla();
        }

        private void MantenimientoProducto_Load(object sender, EventArgs e)
        {
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            RealizarValidaciones();
            
            MostrarImagenPorDefecto(pbFoto);
            AplicarTema();
            CargarTipoProducto();
            CargarCategorias();
            CargarUnidadMedida();
            CargarMarcas();
            CargarModelos();
            CargarTipoSuplidores();
            CargarSupldores();
            CargarColores();
            CargarCondiciones();
            CargarCapacidad();
            lbTitulo.ForeColor = Color.WhiteSmoke;
            if (VariablesGlobales.Accion == "INSERT")
            {
                lbTitulo.Text = "CREAR NUEVO PRODUCTO";
                btnGuardar.Text = "Guardar";

                lbCLaveSeguridad.Visible = false;
                txtClaveSeguridad.Visible = false;

                GenerarConector();
            }
            else if (VariablesGlobales.Accion == "UPDATE")
            {
                lbTitulo.Text = "MODIFICAR PRODUCTO SELECCIONADO";
                btnGuardar.Text = "Modificar";

                lbCLaveSeguridad.Visible = true;
                txtClaveSeguridad.Visible = true;
                txtStock.Enabled = false;

                SacardatosProducto(VariablesGlobales.IdMantenimeinto, VariablesGlobales.NumeroConector);
                if (cbLlevaImagen.Checked == true)
                {
                    MostrarImagenSeleccionado(pbFoto);
                }
            }
            else if(VariablesGlobales.Accion=="DELETE")
            {
                lbTitulo.Text = "ELIMINAR PRODUCTO SELECCIONADO";
                btnGuardar.Text = "Eliminar";

                ddlSeleccionarTipoProducto.Enabled = false;
                ddlSeleccionarCategoria.Enabled = false;
                ddlSeleccionarUnidadMedida.Enabled = false;
                ddlSeleccionarMarca.Enabled = false;
                ddlSeleccionarModelo.Enabled = false;
                ddlSeleccionarTipoSuplidor.Enabled = false;
                ddlSeleccionarSuplidor.Enabled = false;
                txtdescripcion.Enabled = false;
                txtComentario.Enabled = false;
                txtCodigoBarra.Enabled = false;
                txtReferencia.Enabled = false;
                txtPrecioCompra.Enabled = false;
                txtPrecioVenta.Enabled = false;
                txtStock.Enabled = false;
                txtStockMinimo.Enabled = false;
                txtPorcientoDescuento.Enabled = false;
                btnAgregarTipoProducto.Enabled = false;
                btnRefrescarTipoProducto.Enabled = false;
                btnAgregarCategoria.Enabled = false;
                btnRefrescarCategoria.Enabled = false;
                btnAgregarUnidadMedida.Enabled = false;
                btnRefrescarUnidadMedida.Enabled = false;
                btnAgregarMarca.Enabled = false;
                btnRefrescarMarca.Enabled = false;
                btnAgregarModelo.Enabled = false;
                btnRefrescarModelo.Enabled = false;
                btnAgregarTipoSuplidor.Enabled = false;
                btnRefrescarTipoSuplidor.Enabled = false;
                btnAgregarSuplidor.Enabled = false;
                btnRefrescarSuplidor.Enabled = false;
                cbAceptaOferta.Enabled = false;


                lbCLaveSeguridad.Visible = true;
                txtClaveSeguridad.Visible = true;

                btnBuscarFoto.Enabled = false;

                SacardatosProducto(VariablesGlobales.IdMantenimeinto, VariablesGlobales.NumeroConector);
                if (cbLlevaImagen.Checked == true)
                {
                    MostrarImagenSeleccionado(pbFoto);
                }
            }

            txtStockMinimo.Enabled = false;
            txtStockMinimo.Text = "1";
        }

        private void ddlSeleccionarTipoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                CargarCategorias();
                int TipoProducto = Convert.ToInt32(ddlSeleccionarTipoProducto.SelectedValue);
                if (TipoProducto == 2)
                {
                    cbacumulativo.Checked = false;
                    cbacumulativo.Enabled = false;
                    txtStock.Enabled = false;
                    txtStock.Text = "1";
                    txtStockMinimo.Enabled = false;
                    txtPrecioCompra.Enabled = false;
                    txtStockMinimo.Text = "0";
                    txtPrecioCompra.Text = "0";
                    txtPrecioVenta.Text = "0";
                    txtPrecioVenta.Enabled = true;
                  
                }
                else
                {
                    cbacumulativo.Checked = false;
                    cbacumulativo.Enabled = true;
                    txtStock.Enabled = false;
                    txtStock.Text = "1";

                    txtStockMinimo.Enabled = true;
                    txtPrecioCompra.Enabled = true;
                    txtStockMinimo.Text = string.Empty;
                    txtPrecioCompra.Text = string.Empty;
                    txtPrecioVenta.Text = string.Empty;
                    txtPrecioVenta.Enabled = true;
                }
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

        private void ddlSeleccionarTipoSuplidor_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarSupldores();
        }

        private void btnRefrescarTipoProducto_Click(object sender, EventArgs e)
        {
            CargarTipoProducto();
        }

        private void btnRefrescarCategoria_Click(object sender, EventArgs e)
        {
            CargarCategorias();
        }

        private void btnRefrescarUnidadMedida_Click(object sender, EventArgs e)
        {
            CargarUnidadMedida();
        }

        private void btnRefrescarMarca_Click(object sender, EventArgs e)
        {
            CargarMarcas();
            CargarModelos();
        }

        private void btnRefrescarModelo_Click(object sender, EventArgs e)
        {
            CargarModelos();
        }

        private void btnRefrescarTipoSuplidor_Click(object sender, EventArgs e)
        {
            CargarTipoSuplidores();
            CargarSupldores();
        }

        private void btnRefrescarSuplidor_Click(object sender, EventArgs e)
        {
            CargarSupldores();
        }

        private void btnBuscarFoto_Click(object sender, EventArgs e)
        {
            try {
                OpenFileDialog Imagen = new OpenFileDialog();
                Imagen.InitialDirectory = "C://";
                Imagen.Filter = "All files(*.*)|*.*";
                Imagen.FilterIndex = 2;
                Imagen.RestoreDirectory = true;
                if (Imagen.ShowDialog() == DialogResult.OK)
                {
                    this.VariablesGlobales.RutaImagen = Imagen.FileName;
                    pbFoto.ImageLocation = VariablesGlobales.RutaImagen;
                }
            }
            catch (Exception) { }
        }

        private void txtPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            DSMarket.Logica.Comunes.ValidarControles.SoloNumeros(e);
        }

        private void cbLlevaImagen_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLlevaImagen.Checked == true)
            {
                btnBuscarFoto.Enabled = true;
            }
            else
            {
                btnBuscarFoto.Enabled = false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           
            //VALIDAMOS LOS CAMPOS VACIOS
            if (string.IsNullOrEmpty(ddlSeleccionarTipoProducto.Text.Trim()) || string.IsNullOrEmpty(ddlSeleccionarCategoria.Text.Trim()) || string.IsNullOrEmpty(ddlSeleccionarUnidadMedida.Text.Trim()) || string.IsNullOrEmpty(ddlSeleccionarMarca.Text.Trim()) || string.IsNullOrEmpty(ddlSeleccionarModelo.Text.Trim()) || string.IsNullOrEmpty(ddlSeleccionarTipoSuplidor.Text.Trim()) || string.IsNullOrEmpty(ddlSeleccionarSuplidor.Text.Trim()) ||  string.IsNullOrEmpty(txtPrecioCompra.Text.Trim()) || string.IsNullOrEmpty(txtPrecioVenta.Text.Trim()) || string.IsNullOrEmpty(txtStock.Text.Trim()) || string.IsNullOrEmpty(txtStockMinimo.Text.Trim()) || string.IsNullOrEmpty(txtPorcientoDescuento.Text.Trim()))
            {
                MessageBox.Show("Has dejado campos vacios que son necesarios para realizar esta operación, los campos que tienen * son obligatorios.", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (string.IsNullOrEmpty(txtPrecioCompra.Text.Trim())) {
                    errorProvider1.SetError(txtPrecioCompra, "Campo Vacio");
                }
                if (string.IsNullOrEmpty(txtPrecioVenta.Text.Trim()))
                {
                    errorProvider1.SetError(txtPrecioVenta, "Campo Vacio");
                }
            }
            else
            {
                if (VariablesGlobales.Accion == "INSERT")
                {
                    MANProductos();
                   
                    MessageBox.Show("Registro guardado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (MessageBox.Show("¿Quieres guardar otro registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        RestablecerPantalla();
                    }
                    else
                    {
                        CerrarPantalla();
                    }
                }
                else
                {
                    if (string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()))
                    {
                        MessageBox.Show("La clave de seguridad no puede estar vacia, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //txtClaveSeguridad.Text = string.Empty;
                        txtClaveSeguridad.Focus();
                    }
                    else
                    {
                        string _ClaveSeguridad = string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()) ? null : txtClaveSeguridad.Text.Trim();

                        var Validar = ObjDataSeguridad.Value.BuscaClaveSeguridad(
                            new Nullable<decimal>(),
                            null,
                            DSMarket.Logica.Comunes.SeguridadEncriptacion.Encriptar(_ClaveSeguridad), 1, 1);
                        if (Validar.Count() < 1)
                        {
                            MessageBox.Show("La clave de seguridad ingresada no es valida, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtClaveSeguridad.Text = string.Empty;
                            txtClaveSeguridad.Focus();
                        }
                        else
                        {
                            MANProductos();
                            if (VariablesGlobales.Accion == "UPDATE")
                            {
                                MessageBox.Show("Registro modificado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else if (VariablesGlobales.Accion == "DELETE") {
                                MessageBox.Show("Registro eliminado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            CerrarPantalla();
                        }
                    }
                }
            }
        }

        private void cbacumulativo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbacumulativo.Checked == true)
            {
                txtStock.Enabled = true;
               // txtStock.Text = string.Empty;
                
                txtStockMinimo.Enabled = true;
              //  txtStockMinimo.Text = string.Empty;
            }
            else
            {
                txtStock.Enabled = false;
                txtStock.Text = "1";

                txtStockMinimo.Enabled = false;
                txtStockMinimo.Text = "1";
            }
        }

        private void ddlSeleccionarCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                CargarMarcas();
            }
            catch (Exception) { }
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtReferencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (VariablesGlobales.ValidarCampoEspeciaProductolNumerico == true) {
                DSMarket.Logica.Comunes.ValidarControles.SoloNumeros(e);
            }
        }
    }
}
