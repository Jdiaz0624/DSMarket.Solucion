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
        private void CargarTipoPdoducto()
        {
            try
            {
                var TipoProducto = ObjDataListas.Value.ListaTipoProducto(
                    new Nullable<decimal>(),
                    null);
                ddlTipoProducto.DataSource = TipoProducto;
                ddlTipoProducto.DisplayMember = "Descripcion";
                ddlTipoProducto.ValueMember = "IdTipoproducto";
            }
            catch (Exception) { }
        }
        private void CargarCategorias()
        {
            try
            {
                var Categoria = ObjDataListas.Value.ListadoCategorias(
                    Convert.ToDecimal(ddlTipoProducto.SelectedValue));
                ddlCategoria.DataSource = Categoria;
                ddlCategoria.DisplayMember = "Descripcion";
                ddlCategoria.ValueMember = "IdCategoria";
            }
            catch (Exception) { }
        }

        private void CargarMarcas()
        {
            try
            {
                var Marca = ObjDataListas.Value.BucaLisaMarcas(
                    Convert.ToDecimal(ddlCategoria.SelectedValue));
                ddlMarca.DataSource = Marca;
                ddlMarca.DisplayMember = "Descripcion";
                ddlMarca.ValueMember = "IdMarca";
            }
            catch (Exception) { }

        }

        #endregion
        private void OcultarColumnasGrid() {
            this.dtListado.Columns["IdRegistro"].Visible = false;
            this.dtListado.Columns["NumeroConector"].Visible = false;
            this.dtListado.Columns["IdTipoProducto"].Visible = false;
           // this.dtListado.Columns["TipoProducto"].Visible = false;
            this.dtListado.Columns["IdCategoria"].Visible = false;
            this.dtListado.Columns["Categoria"].Visible = false;
            this.dtListado.Columns["IdMarca"].Visible = false;
            this.dtListado.Columns["Marca"].Visible = false;
            this.dtListado.Columns["IdTipoSuplidor"].Visible = false;
            this.dtListado.Columns["TipoSuplidor"].Visible = false;
            this.dtListado.Columns["IdSuplidor"].Visible = false;
            this.dtListado.Columns["Suplidor"].Visible = false;
          //  this.dtListado.Columns["Descripcion"].Visible = false;
         //   this.dtListado.Columns["CodigoBarra"].Visible = false;
         //   this.dtListado.Columns["Referencia"].Visible = false;
         //   this.dtListado.Columns["NumeroSeguimiento"].Visible = false;
         //   this.dtListado.Columns["CodigoProducto"].Visible = false;
            this.dtListado.Columns["PrecioCompra"].Visible = false;
         //   this.dtListado.Columns["PrecioVenta"].Visible = false;
            this.dtListado.Columns["GananciaAproximada"].Visible = false;
          //  this.dtListado.Columns["Stock"].Visible = false;
            this.dtListado.Columns["StockMinimo"].Visible = false;
          //  this.dtListado.Columns["Estatus"].Visible = false;
            this.dtListado.Columns["UnidadMedida"].Visible = false;
            this.dtListado.Columns["Modelo"].Visible = false;
            this.dtListado.Columns["Color"].Visible = false;
            this.dtListado.Columns["Condicion"].Visible = false;
            this.dtListado.Columns["Capacidad"].Visible = false;
            this.dtListado.Columns["AplicaParaImpuesto0"].Visible = false;
            this.dtListado.Columns["AplicaParaImpuesto"].Visible = false;
            this.dtListado.Columns["TieneImagen0"].Visible = false;
            this.dtListado.Columns["TieneImagen"].Visible = false;
            this.dtListado.Columns["LlevaGarantia0"].Visible = false;
            this.dtListado.Columns["LlevaGarantia"].Visible = false;
            this.dtListado.Columns["IdTipoGarantia"].Visible = false;
            this.dtListado.Columns["TipoTiempoGarantia"].Visible = false;
            this.dtListado.Columns["TiempoGarantia"].Visible = false;
            this.dtListado.Columns["Comentario"].Visible = false;
            this.dtListado.Columns["UsuarioAdiciona"].Visible = false;
            this.dtListado.Columns["CreadoPor"].Visible = false;
            this.dtListado.Columns["FechaAdiciona0"].Visible = false;
            this.dtListado.Columns["FechaAdiciona"].Visible = false;
            this.dtListado.Columns["UsuarioModifica"].Visible = false;
            this.dtListado.Columns["ModificadoPor"].Visible = false;
            this.dtListado.Columns["FechaModifica0"].Visible = false;
            this.dtListado.Columns["FechaModifica"].Visible = false;
            this.dtListado.Columns["FechaIngreso0"].Visible = false;
            this.dtListado.Columns["FechaIngreso"].Visible = false;
            this.dtListado.Columns["NombreEmpresa"].Visible = false;
            this.dtListado.Columns["RNC"].Visible = false;
            this.dtListado.Columns["Direccion"].Visible = false;
            this.dtListado.Columns["Telefonos"].Visible = false;
            this.dtListado.Columns["Email"].Visible = false;
            this.dtListado.Columns["Email2"].Visible = false;
            this.dtListado.Columns["Facebook"].Visible = false;
            this.dtListado.Columns["Instagran"].Visible = false;
            this.dtListado.Columns["LogoEmpresa"].Visible = false;
            this.dtListado.Columns["GeneradoPor"].Visible = false;
            this.dtListado.Columns["CapitalInvertido"].Visible = false;
            this.dtListado.Columns["GananciaAproximadaTotal"].Visible = false;
        }
        private void MostrarListadoInventario() {

            decimal? _TipoProducto = cbAgregarFiltroPreciso.Checked == true ? Convert.ToDecimal(ddlTipoProducto.SelectedValue) : new Nullable<decimal>();
            decimal? _Categoria = cbAgregarFiltroPreciso.Checked == true ? Convert.ToDecimal(ddlCategoria.SelectedValue) : new Nullable<decimal>();
            decimal? _Marca = cbAgregarFiltroPreciso.Checked == true ? Convert.ToDecimal(ddlMarca.SelectedValue) : new Nullable<decimal>();
            string _Descripcion = string.IsNullOrEmpty(txtDescripcion.Text.Trim()) ? null : txtDescripcion.Text.Trim();
            string _CodigoBarra = string.IsNullOrEmpty(txtCodigoBarra.Text.Trim()) ? null : txtCodigoBarra.Text.Trim();
            string _referencia = string.IsNullOrEmpty(txtReferencia.Text.Trim()) ? null : txtReferencia.Text.Trim();
            string _CodigoProducto = string.IsNullOrEmpty(txtCodigoProducto.Text.Trim()) ? null : txtCodigoProducto.Text.Trim();
            DateTime? _FechaDesde = cbAgregarRangoFecha.Checked == true ? string.IsNullOrEmpty(txtFechaDesde.Text.Trim()) ? new Nullable<DateTime>() : Convert.ToDateTime(txtFechaDesde.Text) : new Nullable<DateTime>();
            DateTime? _FechaHasta = cbAgregarRangoFecha.Checked == true ? string.IsNullOrEmpty(txtFechahasta.Text.Trim()) ? new Nullable<DateTime>() : Convert.ToDateTime(txtFechahasta.Text) : new Nullable<DateTime>();
            decimal? _Stock = cbProductosAgotados.Checked == true ? 0 : new Nullable<decimal>();

            var Buscrregistros = ObjDataInventario.Value.BuscaProductosServicios(
                new Nullable<decimal>(),
                null,
                _TipoProducto,
                _Categoria,
                _Marca,
                null, null,
                _Descripcion,
                _CodigoBarra,
                _referencia,
                null,
                _CodigoProducto,
                _FechaDesde,
                _FechaHasta,
                null,
                _Stock,
                (int)txtNumeroPagina.Value,
                (int)txtNumeroRegistros.Value);
            int CantidadRegistros = 0;
            decimal CapitalInvertido = 0, GananciaAproximada = 0;
            if (Buscrregistros.Count() < 1) {
                lbCantidadProductos.Text = "0";
                lbCapitalInvertidoVariable.Text = "0";
                lbGananciaAproximadaVariable.Text = "0";
                dtListado.DataSource = null;
            }
            else {
                CantidadRegistros = Buscrregistros.Count;
                foreach (var n in Buscrregistros) {
                    CapitalInvertido = (decimal)n.CapitalInvertido;
                    GananciaAproximada = (decimal)n.GananciaAproximadaTotal;
                }
                lbCantidadProductos.Text = CantidadRegistros.ToString("N0");
                lbCapitalInvertidoVariable.Text = CapitalInvertido.ToString("N2");
                lbGananciaAproximadaVariable.Text = GananciaAproximada.ToString("N2");

                dtListado.DataSource = Buscrregistros;
                OcultarColumnasGrid();
            }
        }

        private string GenerarNumeroConector() {
            string NumeroConector = "";

            Random NumeroAleatorio = new Random();
            string PrimerNumero = NumeroAleatorio.Next(0, 999999999).ToString();
            string SegundoNumero = NumeroAleatorio.Next(0, 999999999).ToString();
            string Year = DateTime.Now.Year.ToString();
            string Month = DateTime.Now.Month.ToString().Length == 1 ? "0" + DateTime.Now.Month.ToString() : DateTime.Now.Month.ToString();
            string Day = DateTime.Now.Day.ToString().Length == 1 ? "0" + DateTime.Now.Day.ToString() : DateTime.Now.Day.ToString();

            NumeroConector = PrimerNumero + Year + Month + Day + SegundoNumero;
            return NumeroConector;

        }


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
           
            lbTitulo.Text = "CONSULTA DE INVENTARIO";
            lbTitulo.ForeColor = Color.WhiteSmoke;

            CargarTipoPdoducto();
            CargarCategorias();
            CargarMarcas();
            MostrarListadoInventario();




            decimal IdNivelAcceso = DSMarket.Logica.Comunes.ValidarNivelUsuario.ValidarNivelAccesoUsuario(variablesGlobales.IdUsuario);

            if (IdNivelAcceso == 3) {
                btnEditar.Visible = false;
                btnEliminar.Visible = false;
                btnSuplir.Visible = false;
                btnSuplir.Visible = false;
                btnDescartar.Visible = false;
                btnReporte.Visible = false;
                lbCapitalInvertidoTitulo.Visible = false;
                lbCapitalInvertidoVariable.Visible = false;
                lbGananciaAproximadaTitulo.Visible = false;
                lbGananciaAproximadaVariable.Visible = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void cbAgregarRangoFecha_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void rbAmbos_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rbConOferta_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void rbSinOferta_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.MantenimientoProducto Mantenimiento = new MantenimientoProducto();
            Mantenimiento.VariablesGlobales.Accion = "INSERT";
            Mantenimiento.VariablesGlobales.NumeroConectorstring = GenerarNumeroConector();
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
           
        }

    

        private void ddlSeleccionarMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MostrarListadoInventario();


        }

        private void txtNumeroPagina_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroPagina.Value < 1)
            {
                txtNumeroPagina.Value = 1;
                MostrarListadoInventario();
            }
            else
            {
               
            }
        }

        private void txtNumeroRegistros_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroRegistros.Value < 1)
            {
                txtNumeroRegistros.Value = 10;
                MostrarListadoInventario();
            }
            else
            {
                MostrarListadoInventario();
            }
        }

        private void dtListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.variablesGlobales.IdMantenimeinto = Convert.ToDecimal(this.dtListado.CurrentRow.Cells["IdProducto"].Value.ToString());
            this.variablesGlobales.NumeroConector = Convert.ToDecimal(this.dtListado.CurrentRow.Cells["NumeroConector"].Value.ToString());
            this.variablesGlobales.LlevaDescuentoPregunta = Convert.ToBoolean(this.dtListado.CurrentRow.Cells["LlevaImagen0"].Value.ToString());
            decimal IdTipoProducto = Convert.ToDecimal(this.dtListado.CurrentRow.Cells["IdTipoProducto"].Value.ToString());


           
           
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            txtNumeroPagina.Enabled = true;
            txtNumeroRegistros.Enabled = true;
            btnNuevo.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnSuplir.Enabled = false;
          

            txtNumeroPagina.Value = 1;
            txtNumeroRegistros.Value = 10;


            CargarTipoPdoducto();
            CargarCategorias();
            CargarMarcas();


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
            
        }

        private void Txtdescripcion_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtCodigoBarra_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void TxtReferencia_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void TxtNumeroSeguimiento_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void ddlTipoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CargarCategorias();
            }
            catch (Exception) { }
        }

        private void ddlCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CargarMarcas();
            }
            catch (Exception) { }
        }

        private void ddlMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cbAgregarRangoFecha_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void txtDescripcion_TextChanged_1(object sender, EventArgs e)
        {
            MostrarListadoInventario();
        }

        private void txtCodigoBarra_TextChanged_1(object sender, EventArgs e)
        {
            MostrarListadoInventario();
        }

        private void txtReferencia_TextChanged_1(object sender, EventArgs e)
        {
            MostrarListadoInventario();
        }

        private void txtCodigoProducto_TextChanged(object sender, EventArgs e)
        {
            MostrarListadoInventario();
        }
    }
}
