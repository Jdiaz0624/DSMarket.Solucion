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
        Lazy<DSMarket.Logica.Logica.LogicaServicio.LogicaServicio> ObjDataServicio = new Lazy<Logica.Logica.LogicaServicio.LogicaServicio>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

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

        private void CargarTipoSuplidores() {
            try {
                var TipoSuplidores = ObjDataListas.Value.BuscaListaTipoSuplidor();
                ddlTipoSuplidor.DataSource = TipoSuplidores;
                ddlTipoSuplidor.DisplayMember = "Descripcion";
                ddlTipoSuplidor.ValueMember = "IdTipoSuplidor";
            }
            catch (Exception) { }
        }
        private void CargarSuplidores() {

            try
            {
                var Sulidores = ObjDataListas.Value.BuscaListaSuplidores(Convert.ToDecimal(ddlTipoSuplidor.SelectedValue));
                ddlSuplidor.DataSource = Sulidores;
                ddlSuplidor.DisplayMember = "Nombre";
                ddlSuplidor.ValueMember = "IdSuplidor";
            }
            catch (Exception) { }
        }
        private void CargarTipogarantia() {
            try
            {
                var Tipogarantia = ObjDataListas.Value.ListadoTipoTiempoGarantia();
                ddlTipoGarantia.DataSource = Tipogarantia;
                ddlTipoGarantia.DisplayMember = "TipoTiempoGarantia";
                ddlTipoGarantia.ValueMember = "IdTipoTiempoGarantia";

                txtTiempoGarantia.Text = SacarTiempoGarantia(Convert.ToInt32(ddlTipoGarantia.SelectedValue)).ToString();
            }
            catch (Exception) { }
        }

        private void CargarListas() {
            CargarTipoPdoducto();
            CargarCategorias();
            CargarMarcas();
            CargarTipoSuplidores();
            CargarSuplidores();
            CargarTipogarantia();
        }
        #endregion
        /// <summary>
        /// Este metodo es para sacar la informacion del producto seleccionado
        /// </summary>
        private void SacarInformacionProductoSeleccionado() {
            var SacarInformacion = ObjDataInventario.Value.BuscaProductosServicios(
                        VariablesGlobales.IdMantenimeinto,
                        VariablesGlobales.NumeroConectorstring,
                        null, null, null, null, null, null, null, null, null, null, null, null, null, null, 1, 1);
            foreach (var n in SacarInformacion)
            {
                cbAplicaParaImpuesto.Checked = (n.AplicaParaImpuesto0.HasValue ? n.AplicaParaImpuesto0.Value : false);
                cbLlevagarantia.Checked = (n.LlevaGarantia0.HasValue ? n.LlevaGarantia0.Value : false);
                CargarTipoPdoducto();
                ddlTipoProducto.Text = n.TipoProducto;
                CargarCategorias();
                ddlCategoria.Text = n.Categoria;
                CargarMarcas();
                ddlMarca.Text = n.Marca;
                CargarTipoSuplidores();
                ddlTipoSuplidor.Text = n.TipoSuplidor;
                CargarSuplidores();
                ddlSuplidor.Text = n.Suplidor;
                txtDescripcion.Text = n.Descripcion;
                txtcodigobarra.Text = n.CodigoBarra;
                txtReferencia.Text = n.Referencia;
                txtNumeroSeguimiento.Text = n.NumeroSeguimiento;
                txtCodigoproducto.Text = n.CodigoProducto;
                txtPrecioCompra.Text = n.PrecioCompra.ToString();
                txtPrecioVenta.Text = n.PrecioVenta.ToString();
                txtstock.Text = n.Stock.ToString();
                txtstockminimo.Text = n.StockMinimo.ToString();
                txtUnidadMedinda.Text = n.UnidadMedida;
                txtModelo.Text = n.Modelo;
                txtColor.Text = n.Color;
                txtCondicion.Text = n.Condicion;
                txtCapacidad.Text = n.Capacidad;
                CargarTipogarantia();
                ddlTipoGarantia.Text = n.TipoTiempoGarantia;
                txtTiempoGarantia.Text = n.TiempoGarantia.ToString();
                txtComentario.Text = n.Comentario;
            }
        }
        private void ProcesarInformacionProductoServicio() {
            decimal IdTipoGarantia = cbLlevagarantia.Checked == true ? Convert.ToDecimal(ddlTipoGarantia.SelectedValue) : 0;
           int TiempoGarantia = cbLlevagarantia.Checked == true ? Convert.ToInt32(txtTiempoGarantia.Text) : 0;

            DSMarket.Logica.Comunes.ProcesarInformacion.Inventario.ProcesarInformacionProductoServicio Procesar = new Logica.Comunes.ProcesarInformacion.Inventario.ProcesarInformacionProductoServicio(
            VariablesGlobales.IdMantenimeinto,
            VariablesGlobales.NumeroConectorstring,
            Convert.ToDecimal(ddlTipoProducto.SelectedValue),
            Convert.ToDecimal(ddlCategoria.SelectedValue),
            Convert.ToDecimal(ddlMarca.SelectedValue),
            Convert.ToDecimal(ddlTipoSuplidor.SelectedValue),
            Convert.ToDecimal(ddlSuplidor.SelectedValue),
            txtDescripcion.Text,
            txtcodigobarra.Text,
            txtReferencia.Text,
            txtNumeroSeguimiento.Text,
            txtCodigoproducto.Text,
            Convert.ToDecimal(txtPrecioCompra.Text),
            Convert.ToDecimal(txtPrecioVenta.Text),
            Convert.ToDecimal(txtstock.Text),
            Convert.ToDecimal(txtstockminimo.Text),
            txtUnidadMedinda.Text,
            txtModelo.Text,
            txtColor.Text,
            txtCondicion.Text,
            txtCapacidad.Text,
            cbAplicaParaImpuesto.Checked,
            false,
            cbLlevagarantia.Checked,
            IdTipoGarantia,
            TiempoGarantia,
            txtComentario.Text,
            VariablesGlobales.IdUsuario,
            VariablesGlobales.Accion);
            Procesar.ProcesarInformacion();
        }

        private int SacarTiempoGarantia(int IdGarantia) {
            int TiempoGarantia = 0;

            var SacarGarantia = ObjDataServicio.Value.BuscaTipoTiempoGarantia(IdGarantia);
            foreach (var n in SacarGarantia) {
                TiempoGarantia = (int)n.TiempoGarantia;
            }
            return TiempoGarantia;
        }

        private void cerrarPantalla() {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.ProductoConsulta Consulta = new ProductoConsulta();
            Consulta.variablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Consulta.ShowDialog();
        }
        private void LimpiarPantalla() { 
        
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            cerrarPantalla();
        }

        private void MantenimientoProducto_Load(object sender, EventArgs e)
        {
            lbTitulo.Text = "PROCESAR INFORMACION DE PRODUCTOS Y SERVICIOS";
            lbTitulo.ForeColor = Color.White;

            if (VariablesGlobales.Accion == "INSERT") {
                btnGuardar.Text = "Guardar";

                lbTipoGarantia.Visible = false;
                ddlTipoGarantia.Visible = false;
                lbTiempoGarantia.Visible = false;
                txtTiempoGarantia.Visible = false;
            }
            else if (VariablesGlobales.Accion == "UPDATE") {
                btnGuardar.Text = "Modificar";
                SacarInformacionProductoSeleccionado();


            }
            else if (VariablesGlobales.Accion == "DELETE") {
                btnGuardar.Text = "Eliminar";
                SacarInformacionProductoSeleccionado();
            }
            CargarListas();
        }

    

        private void MantenimientoProducto_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason) {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void ddlTipoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                CargarCategorias();
                CargarMarcas();
            }
            catch (Exception) { }
        }

        private void ddlCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                CargarMarcas();
            }
            catch (Exception) { }
        }

        private void ddlTipoSuplidor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                CargarSuplidores();
            }
            catch (Exception) { }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ddlTipoProducto.Text.Trim()) ||
                string.IsNullOrEmpty(ddlCategoria.Text.Trim()) ||
                string.IsNullOrEmpty(ddlMarca.Text.Trim()) ||
                string.IsNullOrEmpty(ddlTipoSuplidor.Text.Trim()) ||
                string.IsNullOrEmpty(ddlSuplidor.Text.Trim()) ||
                string.IsNullOrEmpty(txtPrecioCompra.Text.Trim()) ||
                string.IsNullOrEmpty(txtPrecioVenta.Text.Trim()) ||
                string.IsNullOrEmpty(txtstock.Text.Trim()) ||
                string.IsNullOrEmpty(txtstockminimo.Text.Trim()))
            {
                MessageBox.Show("Has dejado campos vacios que son nedesarios para completar este proceso, favor de verificar los campos señalados con un *.", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ProcesarInformacionProductoServicio();
                MessageBox.Show("Proceso completado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (VariablesGlobales.Accion == "INSERT")
                {
                    if (MessageBox.Show("¿Quieres agregar otro registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        LimpiarPantalla();
                    }
                    else
                    {
                        cerrarPantalla();
                    }
                }
                else
                {
                    cerrarPantalla();
                }
            }
        }

        private void cbLlevagarantia_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLlevagarantia.Checked == true) {
                lbTipoGarantia.Visible = true;
                ddlTipoGarantia.Visible = true;
                lbTiempoGarantia.Visible = true;
                txtTiempoGarantia.Visible = true;
                CargarTipogarantia();
            }
            else if (cbLlevagarantia.Checked == false) {
                lbTipoGarantia.Visible = false;
                ddlTipoGarantia.Visible = false;
                lbTiempoGarantia.Visible = false;
                txtTiempoGarantia.Visible = false;
            }
        }

        private void ddlTipoGarantia_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                txtTiempoGarantia.Text = SacarTiempoGarantia(Convert.ToInt32(ddlTipoGarantia.SelectedValue)).ToString();
            }
            catch (Exception) { }
        }
    }
}
