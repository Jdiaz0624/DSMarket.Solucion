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
        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.ProductoConsulta Consulta = new ProductoConsulta();
            Consulta.variablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Consulta.ShowDialog();
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
            }
            else if (VariablesGlobales.Accion == "UPDATE")
            {
                lbTitulo.Text = "MODIFICAR PRODUCTO SELECCIONADO";
                btnGuardar.Text = "Modificar";

                lbCLaveSeguridad.Visible = true;
                txtClaveSeguridad.Visible = true;
                txtStock.Enabled = false;
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
    }
}
