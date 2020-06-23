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
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region CARGAR LAS LISTAS DESPLEGABLES
        private void CargarTipoProducto() {
            var TipoPrducto = ObjDataListas.Value.ListaTipoProducto(
                new Nullable<decimal>(), null);
            ddlSeleccionarTipoProducto.DataSource = TipoPrducto;
            ddlSeleccionarTipoProducto.DisplayMember = "Descripcion";
            ddlSeleccionarTipoProducto.ValueMember = "IdTipoproducto";
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
            var MArcas = ObjDataListas.Value.BucaLisaMarcas();
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
                DSMarket.Logica.Entidades.EntidadesInventario.EProducto Mantenimiento = new Logica.Entidades.EntidadesInventario.EProducto();

                Mantenimiento.IdProducto = VariablesGlobales.IdMantenimeinto;
                Mantenimiento.NumeroConector = VariablesGlobales.NumeroConector;
                Mantenimiento.IdTipoProducto = Convert.ToDecimal(ddlSeleccionarTipoProducto.SelectedValue);
                Mantenimiento.IdCategoria = Convert.ToDecimal(ddlSeleccionarCategoria.SelectedValue);
                Mantenimiento.IdUnidadMedida = Convert.ToDecimal(ddlSeleccionarUnidadMedida.SelectedValue);
                Mantenimiento.IdMarca = Convert.ToDecimal(ddlSeleccionarMarca.SelectedValue);
                Mantenimiento.IdModelo = Convert.ToDecimal(ddlSeleccionarModelo.SelectedValue);
                Mantenimiento.IdTipoSuplidor = Convert.ToDecimal(ddlSeleccionarTipoSuplidor.SelectedValue);
                Mantenimiento.IdSuplidor = Convert.ToDecimal(ddlSeleccionarSuplidor.SelectedValue);
                Mantenimiento.Producto = txtdescripcion.Text;
                Mantenimiento.CodigoBarra = txtCodigoBarra.Text;
                Mantenimiento.Referencia = txtReferencia.Text;
                Mantenimiento.PrecioCompra = Convert.ToDecimal(txtPrecioCompra.Text);
                Mantenimiento.PrecioVenta = Convert.ToDecimal(txtPrecioVenta.Text);
                Mantenimiento.Stock = Convert.ToDecimal(txtStock.Text);
                Mantenimiento.StockMinimo = Convert.ToDecimal(txtStockMinimo.Text);
                Mantenimiento.PorcientoDescuento = Convert.ToDecimal(txtPorcientoDescuento.Text);
                Mantenimiento.AfectaOferta0 = cbAceptaOferta.Checked;
                Mantenimiento.ProductoAcumulativo0 = cbProductoAcumulativo.Checked;
                Mantenimiento.LlevaImagen0 = cbLlevaImagen.Checked;
                Mantenimiento.UsuarioAdicion = VariablesGlobales.IdUsuario;
                Mantenimiento.FechaAdiciona = DateTime.Now;
                Mantenimiento.UsuarioModifica = VariablesGlobales.IdUsuario;
                Mantenimiento.FechaModifica = DateTime.Now;
                Mantenimiento.Fecha = DateTime.Now;

                var MAn = ObjDataInventario.Value.MantenimientoProducto(Mantenimiento, VariablesGlobales.Accion);
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
            txtPorcientoDescuento.Text = string.Empty;
            txtPrecioCompra.Text = string.Empty;
            txtPrecioVenta.Text = string.Empty;
            txtReferencia.Text = string.Empty;
            txtStock.Text = string.Empty;
            txtStockMinimo.Text = string.Empty;
            
        }
        #endregion
        #region SACAR LOS DATOS DEL PRODUCTO
        private void SacardatosProducto(decimal IdProducto, decimal NumeroConector)
        {
            var SacarDatos = ObjDataInventario.Value.BuscaProductos(
                IdProducto,
                NumeroConector,
                null, null, null, null, null, null, null, null, null, null, null, 1, 1);
            foreach (var n in SacarDatos)
            {
                ddlSeleccionarTipoProducto.Text = n.TipoProducto;
                ddlSeleccionarCategoria.Text = n.Categoria;
                ddlSeleccionarUnidadMedida.Text = n.UnidadMedida;
                ddlSeleccionarMarca.Text = n.Marca;
                ddlSeleccionarModelo.Text = n.Modelo;
                ddlSeleccionarTipoSuplidor.Text = n.TipoSuplidor;
                ddlSeleccionarSuplidor.Text = n.Suplidor;
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

                if (cbLlevaImagen.Checked == true)
                {
                    //HALAR LA IMAGEN
                }
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
            AplicarTema();
            CargarTipoProducto();
            CargarCategorias();
            CargarUnidadMedida();
            CargarMarcas();
            CargarModelos();
            CargarTipoSuplidores();
            CargarSupldores();
            lbTitulo.ForeColor = Color.WhiteSmoke;
            if (VariablesGlobales.Accion == "INSERT")
            {
                lbTitulo.Text = "CREAR NUEVO PRODUCTO";
                btnGuardar.Text = "Guardar";

                lbCLaveSeguridad.Visible = false;
                txtClaveSeguridad.Visible = false;

                Random Aleatorio = new Random();
                decimal Numero = Aleatorio.Next(0, 999999999);
                VariablesGlobales.NumeroConector = Numero;
            }
            else if (VariablesGlobales.Accion == "UPDATE")
            {
                lbTitulo.Text = "MODIFICAR PRODUCTO SELECCIONADO";
                btnGuardar.Text = "Modificar";

                lbCLaveSeguridad.Visible = true;
                txtClaveSeguridad.Visible = true;
                txtStock.Enabled = false;

                SacardatosProducto(VariablesGlobales.IdMantenimeinto, VariablesGlobales.NumeroConector);
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
            }

            
        }

        private void ddlSeleccionarTipoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarCategorias();
        }

        private void ddlSeleccionarMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarModelos();
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
            if (string.IsNullOrEmpty(ddlSeleccionarTipoProducto.Text.Trim()) || string.IsNullOrEmpty(ddlSeleccionarCategoria.Text.Trim()) || string.IsNullOrEmpty(ddlSeleccionarUnidadMedida.Text.Trim()) || string.IsNullOrEmpty(ddlSeleccionarMarca.Text.Trim()) || string.IsNullOrEmpty(ddlSeleccionarModelo.Text.Trim()) || string.IsNullOrEmpty(ddlSeleccionarTipoSuplidor.Text.Trim()) || string.IsNullOrEmpty(ddlSeleccionarSuplidor.Text.Trim()) || string.IsNullOrEmpty(txtdescripcion.Text.Trim()) || string.IsNullOrEmpty(txtPrecioCompra.Text.Trim()) || string.IsNullOrEmpty(txtPrecioVenta.Text.Trim()) || string.IsNullOrEmpty(txtStock.Text.Trim()) || string.IsNullOrEmpty(txtStockMinimo.Text.Trim()) || string.IsNullOrEmpty(txtPorcientoDescuento.Text.Trim()))
            {
                MessageBox.Show("Has dejado campos vacios que son necesarios para realizar esta operación, los campos que tienen * son obligatorios.", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
    }
}
