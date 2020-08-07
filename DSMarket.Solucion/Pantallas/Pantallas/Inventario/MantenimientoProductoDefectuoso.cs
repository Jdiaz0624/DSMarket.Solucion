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
    public partial class MantenimientoProductoDefectuoso : Form
    {
        public MantenimientoProductoDefectuoso()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaListas.LogicaListas> ObjDataListas = new Lazy<Logica.Logica.LogicaListas.LogicaListas>();
        Lazy<DSMarket.Logica.Logica.LogicaInventario.LogicaInventario> ObjDataInventario = new Lazy<Logica.Logica.LogicaInventario.LogicaInventario>();
        Lazy<DSMarket.Logica.Logica.LogicaSeguridad.LogicaSeguridad> ObjDataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad.LogicaSeguridad>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region CARGAR LAS LISTAS DESPLEGABLES
        private void CargarTipoProducto()
        {
            try
            {
                var TipoPrducto = ObjDataListas.Value.ListaTipoProducto(
              new Nullable<decimal>(), null);
                ddlSeleccionarTipoProducto.DataSource = TipoPrducto;
                ddlSeleccionarTipoProducto.DisplayMember = "Descripcion";
                ddlSeleccionarTipoProducto.ValueMember = "IdTipoproducto";
            }
            catch (Exception) { }
        }
        private void CargarCategorias()
        {
            try
            {
                var Categorias = ObjDataListas.Value.ListadoCategorias(Convert.ToDecimal(ddlSeleccionarTipoProducto.SelectedValue));
                ddlSeleccionarCategoria.DataSource = Categorias;
                ddlSeleccionarCategoria.DisplayMember = "Descripcion";
                ddlSeleccionarCategoria.ValueMember = "IdCategoria";
            }
            catch (Exception) { }
        }
        private void CargarUnidadMedida()
        {
            var UnidadMeddida = ObjDataListas.Value.BuscaUnidadMedida();
            ddlSeleccionarUnidadMedida.DataSource = UnidadMeddida;
            ddlSeleccionarUnidadMedida.DisplayMember = "Descripcion";
            ddlSeleccionarUnidadMedida.ValueMember = "IdUnidadMedida";
        }
        private void CargarMarcas()
        {
            var MArcas = ObjDataListas.Value.BucaLisaMarcas(
                Convert.ToDecimal(ddlSeleccionarCategoria.SelectedValue));
            ddlSeleccionarMarca.DataSource = MArcas;
            ddlSeleccionarMarca.DisplayMember = "Descripcion";
            ddlSeleccionarMarca.ValueMember = "IdMarca";
        }
        private void CargarModelos()
        {
            try
            {
                var CargarModelos = ObjDataListas.Value.BuscaListaModelos(Convert.ToDecimal(ddlSeleccionarMarca.SelectedValue));
                ddlSeleccionarModelo.DataSource = CargarModelos;
                ddlSeleccionarModelo.DisplayMember = "Descripcion";
                ddlSeleccionarModelo.ValueMember = "IdModelo";
            }
            catch (Exception) { }
        }
        private void CargarTipoSuplidores()
        {
            var TipoSuplidores = ObjDataListas.Value.BuscaListaTipoSuplidor();
            ddlSeleccionarTipoSuplidor.DataSource = TipoSuplidores;
            ddlSeleccionarTipoSuplidor.DisplayMember = "Descripcion";
            ddlSeleccionarTipoSuplidor.ValueMember = "IdTipoSuplidor";
        }
        private void CargarSupldores()
        {
            try
            {
                var Suplidores = ObjDataListas.Value.BuscaListaSuplidores(Convert.ToDecimal(ddlSeleccionarTipoSuplidor.SelectedValue));
                ddlSeleccionarSuplidor.DataSource = Suplidores;
                ddlSeleccionarSuplidor.DisplayMember = "Nombre";
                ddlSeleccionarSuplidor.ValueMember = "IdSuplidor";
            }
            catch (Exception) { }
        }
        #endregion
        #region CERRAR Y LIMPIAR PANTALLA
        private void CerrarPantalla() {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.ProductosDefectuososConsulta Consulta = new ProductosDefectuososConsulta();
            Consulta.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Consulta.ShowDialog();
        }
        private void LimpiarControles() {
            CargarTipoProducto();
            CargarCategorias();
            CargarUnidadMedida();
            CargarMarcas();
            CargarModelos();
            CargarTipoSuplidores();
            CargarSupldores();
            txtCantidadIngresar.Text = string.Empty;
            txtClaveSeguridad.Text = string.Empty;
            txtCodigoBarra.Text = string.Empty;
            txtComentario.Text = string.Empty;
            txtdescripcion.Text = string.Empty;
            txtPrecioCompra.Text = string.Empty;
            txtPrecioVenta.Text = string.Empty;
            txtReferencia.Text = string.Empty;
        }
        #endregion

        private void MantenimientoProductoDefectuoso_Load(object sender, EventArgs e)
        {
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            CargarTipoProducto();
            CargarCategorias();
            CargarUnidadMedida();
            CargarMarcas();
            CargarModelos();
            CargarTipoSuplidores();
            CargarSupldores();

            if (VariablesGlobales.Accion == "UPDATE")
            {

            }
            else {
                lbCLaveSeguridad.Visible = false;
                txtClaveSeguridad.Visible = false;
            }
        }

        private void ddlSeleccionarTipoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                CargarCategorias();
                CargarMarcas();
                CargarModelos();
            }
            catch (Exception) {

            }
        }

        private void ddlSeleccionarCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                CargarMarcas();
                CargarModelos();
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
            try {
                CargarSupldores();
            }
            catch (Exception) { }
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            CerrarPantalla();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //VALIDAMOS LOS CAMPOS VACIOS
            if (string.IsNullOrEmpty(ddlSeleccionarTipoProducto.Text.Trim()) || string.IsNullOrEmpty(ddlSeleccionarCategoria.Text.Trim()) || string.IsNullOrEmpty(ddlSeleccionarUnidadMedida.Text.Trim()) || string.IsNullOrEmpty(ddlSeleccionarMarca.Text.Trim()) || string.IsNullOrEmpty(ddlSeleccionarModelo.Text.Trim()) || string.IsNullOrEmpty(ddlSeleccionarTipoSuplidor.Text.Trim()) || string.IsNullOrEmpty(ddlSeleccionarSuplidor.Text.Trim()) || string.IsNullOrEmpty(txtPrecioCompra.Text.Trim()) || string.IsNullOrEmpty(txtPrecioVenta.Text.Trim()) || string.IsNullOrEmpty(txtdescripcion.Text.Trim()) || String.IsNullOrEmpty(txtCantidadIngresar.Text.Trim()))
            {

                MessageBox.Show("Has dejado campos vacios que son necesarios para realizar esta operación favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (string.IsNullOrEmpty(ddlSeleccionarTipoProducto.Text.Trim()))
                {
                    errorProvider1.SetError(ddlSeleccionarTipoProducto, "Campo Vacio");
                }
                //----------------------------------------------------------------------------------------------------

                if (string.IsNullOrEmpty(ddlSeleccionarCategoria.Text.Trim()))
                {
                    errorProvider1.SetError(ddlSeleccionarCategoria, "Campo Vacio");
                }
                //----------------------------------------------------------------------------------------------------

                if (string.IsNullOrEmpty(ddlSeleccionarUnidadMedida.Text.Trim()))
                {
                    errorProvider1.SetError(ddlSeleccionarUnidadMedida, "Campo Vacio");
                }
                //----------------------------------------------------------------------------------------------------

                if (string.IsNullOrEmpty(ddlSeleccionarMarca.Text.Trim()))
                {
                    errorProvider1.SetError(ddlSeleccionarMarca, "Campo Vacio");
                }
                //----------------------------------------------------------------------------------------------------

                if (string.IsNullOrEmpty(ddlSeleccionarModelo.Text.Trim()))
                {
                    errorProvider1.SetError(ddlSeleccionarModelo, "Campo Vacio");
                }
                //----------------------------------------------------------------------------------------------------

                if (string.IsNullOrEmpty(ddlSeleccionarTipoSuplidor.Text.Trim()))
                {
                    errorProvider1.SetError(ddlSeleccionarTipoSuplidor, "Campo Vacio");
                }
                //----------------------------------------------------------------------------------------------------

                if (string.IsNullOrEmpty(ddlSeleccionarSuplidor.Text.Trim()))
                {
                    errorProvider1.SetError(ddlSeleccionarSuplidor, "Campo Vacio");
                }
                //----------------------------------------------------------------------------------------------------

                if (string.IsNullOrEmpty(txtPrecioCompra.Text.Trim()))
                {
                    errorProvider1.SetError(txtPrecioCompra, "Campo Vacio");
                }
                //----------------------------------------------------------------------------------------------------

                if (string.IsNullOrEmpty(txtPrecioVenta.Text.Trim()))
                {
                    errorProvider1.SetError(txtPrecioVenta, "Campo Vacio");
                }
                //----------------------------------------------------------------------------------------------------


                if (string.IsNullOrEmpty(txtdescripcion.Text.Trim()))
                {
                    errorProvider1.SetError(txtdescripcion, "Campo Vacio");
                }
                //----------------------------------------------------------------------------------------------------

                if (string.IsNullOrEmpty(txtCantidadIngresar.Text.Trim())) {
                    errorProvider1.SetError(txtCantidadIngresar, "Campo Vacio");
                }


            }
            else {
                if (VariablesGlobales.Accion == "INSERT") {
                    //INSERTAMOS
                    DSMarket.Logica.Comunes.ProcesarProductosDefectuosos Procesar = new Logica.Comunes.ProcesarProductosDefectuosos(
                        VariablesGlobales.IdMantenimeinto,
                        0,
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
                        1,
                        1,
                        0,
                        false,
                        false,
                        false,
                        VariablesGlobales.IdUsuario,
                        DateTime.Now,
                        VariablesGlobales.IdUsuario,
                        DateTime.Now,
                        DateTime.Now,
                        txtComentario.Text,
                        false,
                        false,
                        Convert.ToDecimal(txtCantidadIngresar.Text),
                        txtNumeroSeguimiento.Text,
                        "INSERT");
                    Procesar.ProcesarInformaicon();
                    MessageBox.Show("Registro guardado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (MessageBox.Show("¿Quieres agregar otro registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        LimpiarControles();
                    }
                    else {
                        CerrarPantalla();
                    }
                }
                else {
                    //MODIFICAMOS
                    if (string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim())) {
                        MessageBox.Show("El campo clave de seguridad no puede estar vacio, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()))
                        {
                            errorProvider1.SetError(txtClaveSeguridad, "Campo Vacio");

                        }
                        else {
                            string _ClaveSeguridad = string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()) ? null : txtClaveSeguridad.Text.Trim();

                            var ValidarClaveSeguridad = ObjDataSeguridad.Value.BuscaClaveSeguridad(
                                new Nullable<decimal>(),
                                null,
                                DSMarket.Logica.Comunes.SeguridadEncriptacion.Encriptar(_ClaveSeguridad),
                                1, 1);
                            if (ValidarClaveSeguridad.Count() < 1)
                            {
                                MessageBox.Show("La clave de seguridad ingresada no es valida, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txtClaveSeguridad.Text = string.Empty;
                                txtClaveSeguridad.Focus();
                            }
                            else {
                                DSMarket.Logica.Comunes.ProcesarProductosDefectuosos Procesar = new Logica.Comunes.ProcesarProductosDefectuosos(
                      VariablesGlobales.IdMantenimeinto,
                      0,
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
                      1,
                      1,
                      0,
                      false,
                      false,
                      false,
                      VariablesGlobales.IdUsuario,
                      DateTime.Now,
                      VariablesGlobales.IdUsuario,
                      DateTime.Now,
                      DateTime.Now,
                      txtComentario.Text,
                      false,
                      false,
                      Convert.ToDecimal(txtCantidadIngresar.Text),
                      txtNumeroSeguimiento.Text,
                      "INSERT");
                                Procesar.ProcesarInformaicon();
                                MessageBox.Show("Registro modificado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                CerrarPantalla();
                            }
                        }
                    }
                }
            }
        }

        private void txtCantidadIngresar_KeyPress(object sender, KeyPressEventArgs e)
        {
            DSMarket.Logica.Comunes.ValidarControles.SoloNumerosDecimales(e);
        }
    }
}
