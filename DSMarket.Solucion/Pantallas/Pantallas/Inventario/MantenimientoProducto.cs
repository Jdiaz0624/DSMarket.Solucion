﻿using System;
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

        enum OpcionesConfigunacionGeneral
        {
            ImpuestoPorDefecto = 1,
            LlevaGarantiaPorDefecto = 2,
            CampoReferenciaObligatorio = 3,
            CampoReferenciaNumerico = 4,
            ValidarampoReferencia = 5,
            UnidadMedidaSeleccionable = 6,
            CampoModeloSeleccionable = 7,
            CampoColorSeleccionable = 8,
            CampoCondicionSeleccionable = 9,
            CampoCapacidadSeleccionable = 10,
            RestablecerListasDesplegablesGuardar = 11,
            AutoCompletarCampoReferenciaConsulta = 12
        }

        /// <summary>
        /// Este metodo es para validar las configuraciones generales del sistema
        /// </summary>
        private void ValidarConfiguracionesGenerales()
        {

            //DECLARAMOS LAS VARIABLES PARA RECIBIR LOS CAMPOS PARA VALIDAR
            bool RespuestaValidacion = false;


            #region VALIDACION DEL CHECK DE IMPUESTO
            DSMarket.Logica.Comunes.ValidarConfiguracionesGeneralesSistema ValidarImpuestoPorDefecto = new Logica.Comunes.ValidarConfiguracionesGeneralesSistema((decimal)OpcionesConfigunacionGeneral.ImpuestoPorDefecto, 1);
            RespuestaValidacion = ValidarImpuestoPorDefecto.ValidarConfiguracionGeneral();

            switch (RespuestaValidacion)
            {
                case true:
                    cbAplicaParaImpuesto.Checked = true;
                    break;
                case false:
                    cbAplicaParaImpuesto.Checked = false;
                    break;
            }
            #endregion


            #region VALIDACION DEL CHECK DE GARANTIA
            DSMarket.Logica.Comunes.ValidarConfiguracionesGeneralesSistema ValidarLlevaGarantiaPorDefecto = new Logica.Comunes.ValidarConfiguracionesGeneralesSistema((decimal)OpcionesConfigunacionGeneral.LlevaGarantiaPorDefecto, 1);
            RespuestaValidacion = ValidarLlevaGarantiaPorDefecto.ValidarConfiguracionGeneral();

            switch (RespuestaValidacion)
            {
                case true:
                    cbLlevagarantia.Checked = true;
                    lbTipoGarantia.Visible = true;
                    ddlTipoGarantia.Visible = true;
                    lbTiempoGarantia.Visible = true;
                    txtTiempoGarantia.Visible = true;
                    CargarTipogarantia();
                    break;
                case false:
                    cbLlevagarantia.Checked = false;
                    lbTipoGarantia.Visible = false;
                    ddlTipoGarantia.Visible = false;
                    lbTiempoGarantia.Visible = false;
                    txtTiempoGarantia.Visible = true;
                    CargarTipogarantia();
                    break;
            }
            #endregion


            #region VALIDAMOS EL CAMPO DE REFERENCIA OBLIGATORIA
            DSMarket.Logica.Comunes.ValidarConfiguracionesGeneralesSistema ValidarCampoReferenciaObligatorio = new Logica.Comunes.ValidarConfiguracionesGeneralesSistema((decimal)OpcionesConfigunacionGeneral.CampoReferenciaObligatorio, 1);
            RespuestaValidacion = ValidarCampoReferenciaObligatorio.ValidarConfiguracionGeneral();

            switch (RespuestaValidacion)
            {
                case true:
                    lbReferencia.Text = "Referencia *";
                    break;
                case false:
                    lbReferencia.Text = "Referencia";
                    break;
            }

            #endregion

            #region UNIDAD DE MEDIDA SELECCIONABLE
            DSMarket.Logica.Comunes.ValidarConfiguracionesGeneralesSistema ValidarUnidadMedidaSeleccionable = new Logica.Comunes.ValidarConfiguracionesGeneralesSistema((decimal)OpcionesConfigunacionGeneral.UnidadMedidaSeleccionable, 1);
            RespuestaValidacion = ValidarUnidadMedidaSeleccionable.ValidarConfiguracionGeneral();

            switch (RespuestaValidacion)
            {
                case true:
                    txtUnidadMedinda.Visible = false;
                    ddlUnidadMedida.Visible = true;
                 //   CargarUnidadMedida();
                    break;
                case false:
                    txtUnidadMedinda.Visible = true;
                    ddlUnidadMedida.Visible = false;
                    break;
            }
            #endregion

            #region MODELO SELECCIONABLE
            DSMarket.Logica.Comunes.ValidarConfiguracionesGeneralesSistema ValidarCampoModeloSeleccionable = new Logica.Comunes.ValidarConfiguracionesGeneralesSistema((decimal)OpcionesConfigunacionGeneral.CampoModeloSeleccionable, 1);
            RespuestaValidacion = ValidarCampoModeloSeleccionable.ValidarConfiguracionGeneral();

            switch (RespuestaValidacion)
            {
                case true:
                    txtModelo.Visible = false;
                    ddlModelo.Visible = true;
                  //  CargarModelos();
                    break;
                case false:
                    txtModelo.Visible = true;
                    ddlModelo.Visible = false;
                    break;
            }
            #endregion

            #region COLORES SELECCIONABLES
            DSMarket.Logica.Comunes.ValidarConfiguracionesGeneralesSistema ValidarCampoColorSeleccionable = new Logica.Comunes.ValidarConfiguracionesGeneralesSistema((decimal)OpcionesConfigunacionGeneral.CampoColorSeleccionable, 1);
            RespuestaValidacion = ValidarCampoColorSeleccionable.ValidarConfiguracionGeneral();
            switch (RespuestaValidacion) {
                case true:
                    txtColor.Visible = false;
                    ddlColor.Visible = true;
                //    CargarClores();
                    break;

                case false:
                    txtColor.Visible = true;
                    ddlColor.Visible = false;
                    break;
            }
            #endregion

            #region CONDICIONES SELECCIONABLES
            DSMarket.Logica.Comunes.ValidarConfiguracionesGeneralesSistema ValidarCampoCondicionSeleccionable = new Logica.Comunes.ValidarConfiguracionesGeneralesSistema((decimal)OpcionesConfigunacionGeneral.CampoCondicionSeleccionable, 1);
            RespuestaValidacion = ValidarCampoCondicionSeleccionable.ValidarConfiguracionGeneral();
            switch (RespuestaValidacion)
            {
                case true:
                    txtCondicion.Visible = false;
                    ddlCondicion.Visible = true;
                 //   CargarCondiciones();
                    break;

                case false:
                    txtCondicion.Visible = true;
                    ddlCondicion.Visible = false;
                    break;
            }
            #endregion

            #region CAPACIDAD SELECCIONABLE
            DSMarket.Logica.Comunes.ValidarConfiguracionesGeneralesSistema ValidarCampoCapacidadSeleccionable = new Logica.Comunes.ValidarConfiguracionesGeneralesSistema((decimal)OpcionesConfigunacionGeneral.CampoCapacidadSeleccionable, 1);
            RespuestaValidacion = ValidarCampoCapacidadSeleccionable.ValidarConfiguracionGeneral();
            switch (RespuestaValidacion)
            {
                case true:
                    txtCapacidad.Visible = false;
                    ddlCpacidad.Visible = true;
                 //   CargarCapacidad();
                    break;

                case false:
                    txtCapacidad.Visible = true;
                    ddlCpacidad.Visible = false;
                    break;
            }

            #endregion



          







        }
        enum TipoProductos { 
        Producto=1,
        Servicio=2
        }
        private void ModoProducto() {
            ddlTipoProducto.Enabled = true;
            ddlCategoria.Enabled = true;
            ddlMarca.Enabled = true;
            ddlTipoSuplidor.Enabled = true;
            ddlSuplidor.Enabled = true;
            txtDescripcion.Enabled = false;
            txtcodigobarra.Enabled = true;
            txtReferencia.Enabled = true;
            txtNumeroSeguimiento.Enabled = true;
            txtCodigoproducto.Enabled = true;
            txtPrecioCompra.Enabled = true;
            txtPrecioVenta.Enabled = true;
            txtstock.Enabled = true;
            txtstockminimo.Enabled = true;
            ddlUnidadMedida.Enabled = true;
            txtUnidadMedinda.Enabled = true;
            ddlModelo.Enabled = true;
            txtModelo.Enabled = true;
            ddlColor.Enabled = true;
            txtColor.Enabled = true;
            ddlCondicion.Enabled = true;
            txtCondicion.Enabled = true;
            ddlCpacidad.Enabled = true;
            txtCapacidad.Enabled = true;
            ddlTipoGarantia.Enabled = true;
            txtTiempoGarantia.Enabled = true;
            txtComentario.Enabled = true;
        }

        private void ModoServicio() {
            ddlTipoProducto.Enabled = true;
            ddlCategoria.Enabled = true;
            ddlMarca.Enabled = false;
            ddlTipoSuplidor.Enabled = false;
            ddlSuplidor.Enabled = false;
            txtDescripcion.Enabled = true;
            txtcodigobarra.Enabled = false;
            txtReferencia.Enabled = false;
            txtNumeroSeguimiento.Enabled = false;
            txtCodigoproducto.Enabled = true;
            txtPrecioCompra.Enabled = false;
            txtPrecioCompra.Text = "0";
            txtPrecioVenta.Enabled = true;
            txtstock.Enabled = false;
            txtstock.Text = "1";
            txtstockminimo.Enabled = false;
            txtstockminimo.Text = "1";
            ddlUnidadMedida.Enabled = false;
            txtUnidadMedinda.Enabled = false;
            ddlModelo.Enabled = false;
            txtModelo.Enabled = false;
            ddlColor.Enabled = false;
            txtColor.Enabled = false;
            ddlCondicion.Enabled = false;
            txtCondicion.Enabled = false;
            ddlCpacidad.Enabled = false;
            txtCapacidad.Enabled = false;
            ddlTipoGarantia.Enabled = true;
            txtTiempoGarantia.Enabled = true;
            txtComentario.Enabled = true;
        }


        private void ProcesarItem() {
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

        private void SeleccionarModo(decimal CodigoTipoProducto) {
            if (CodigoTipoProducto == (decimal)TipoProductos.Producto)
            {
                ModoProducto();
            }

            else if (CodigoTipoProducto == (decimal)TipoProductos.Servicio) {
                ModoServicio();
            }
        }
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

        private void CargarUnidadMedida() {
            try {
                var UnidadMEdida = ObjDataListas.Value.BuscaUnidadMedida();
                ddlUnidadMedida.DataSource = UnidadMEdida;
                ddlUnidadMedida.DisplayMember = "Descripcion";
                ddlUnidadMedida.SelectedValue = "IdUnidadMedida";
            }
            catch (Exception) { }
        }

        private void CargarModelos() {
            try {
                var Modelo = ObjDataListas.Value.BuscaListaModelos(Convert.ToDecimal(ddlMarca.SelectedValue));
                ddlModelo.DataSource = Modelo;
                ddlModelo.DisplayMember = "Descripcion";
                ddlModelo.ValueMember = "IdModelo";
            }
            catch (Exception) { }
        }

        private void CargarClores() {
            try {
                var Colores = ObjDataListas.Value.ListadoColores();
                ddlColor.DataSource = Colores;
                ddlColor.DisplayMember = "Color";
                
            }
            catch (Exception) { }
        }

        private void CargarCondiciones()
        {
            try
            {
                var Condicion = ObjDataListas.Value.ListadoCondiciones();
                ddlCondicion.DataSource = Condicion;
                ddlCondicion.DisplayMember = "Condicion";

            }
            catch (Exception) { }
        }

        private void CargarCapacidad()
        {
            try
            {
                var Capacidad = ObjDataListas.Value.ListadoCapacidad();
                ddlCpacidad.DataSource = Capacidad;
                ddlCpacidad.DisplayMember = "Capacidad";

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
            CargarModelos();
            CargarTipoSuplidores();
            CargarSuplidores();
            CargarTipogarantia();
            CargarUnidadMedida();
            CargarClores();
            CargarCondiciones();
            CargarCapacidad();


        }
        #endregion
        private void ValidarInformacionSacarInformacion(bool RespuestaValidacion, ref ComboBox ControlDDL, ref TextBox ControlTXT, string Dato) {

            switch (RespuestaValidacion) {
                case true:
                    ControlDDL.Text = Dato;
                    break;

                case false:
                    ControlTXT.Text = Dato;
                    break;
            }
        }
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
                SeleccionarModo(Convert.ToDecimal(ddlTipoProducto.SelectedValue));
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
                ddlUnidadMedida.Text = n.UnidadMedida;
                ddlModelo.Text = n.Modelo;
                txtModelo.Text = n.Modelo;
                txtColor.Text = n.Color;
                ddlColor.Text = n.Color;
                txtCondicion.Text = n.Condicion;
                ddlCondicion.Text = n.Condicion;
                txtCapacidad.Text = n.Capacidad;
                ddlCpacidad.Text = n.Capacidad;
                CargarTipogarantia();
                ddlTipoGarantia.Text = n.TipoTiempoGarantia;
                txtTiempoGarantia.Text = n.TiempoGarantia.ToString();
                txtComentario.Text = n.Comentario;
                ddlTipoProducto.Enabled = false;
            }
        }
        private void ProcesarInformacionProductoServicio() {
            decimal IdTipoGarantia = cbLlevagarantia.Checked == true ? Convert.ToDecimal(ddlTipoGarantia.SelectedValue) : 0;
            int TiempoGarantia = cbLlevagarantia.Checked == true ? Convert.ToInt32(txtTiempoGarantia.Text) : 0;
            string UnidadMedida = "", Modelo = "", Color = "", Capacidad = "", Condicion = "";
            bool ValidacionUnidadMedida = false, ValidacionModelo = false, ValidacionColor = false, ValidacionCapacidad = false, ValidacionCondicion = false;



            //VALIDAMOS
            DSMarket.Logica.Comunes.ValidarConfiguracionesGeneralesSistema ValidarUnidadMedidaSeleccionable = new Logica.Comunes.ValidarConfiguracionesGeneralesSistema((decimal)OpcionesConfigunacionGeneral.UnidadMedidaSeleccionable, 1);
            ValidacionUnidadMedida = ValidarUnidadMedidaSeleccionable.ValidarConfiguracionGeneral();

            DSMarket.Logica.Comunes.ValidarConfiguracionesGeneralesSistema ValidarCampoModeloSeleccionable = new Logica.Comunes.ValidarConfiguracionesGeneralesSistema((decimal)OpcionesConfigunacionGeneral.CampoModeloSeleccionable, 1);
            ValidacionModelo = ValidarCampoModeloSeleccionable.ValidarConfiguracionGeneral();

            DSMarket.Logica.Comunes.ValidarConfiguracionesGeneralesSistema ValidarCampoColorSeleccionable = new Logica.Comunes.ValidarConfiguracionesGeneralesSistema((decimal)OpcionesConfigunacionGeneral.CampoColorSeleccionable, 1);
            ValidacionColor = ValidarCampoColorSeleccionable.ValidarConfiguracionGeneral();

            DSMarket.Logica.Comunes.ValidarConfiguracionesGeneralesSistema ValidarCampoCondicionSeleccionable = new Logica.Comunes.ValidarConfiguracionesGeneralesSistema((decimal)OpcionesConfigunacionGeneral.CampoCondicionSeleccionable, 1);
            ValidacionCondicion = ValidarCampoCondicionSeleccionable.ValidarConfiguracionGeneral();

            DSMarket.Logica.Comunes.ValidarConfiguracionesGeneralesSistema ValidarCampoCapacidadSeleccionable = new Logica.Comunes.ValidarConfiguracionesGeneralesSistema((decimal)OpcionesConfigunacionGeneral.CampoCapacidadSeleccionable, 1);
            ValidacionCapacidad = ValidarCampoCapacidadSeleccionable.ValidarConfiguracionGeneral();

            //ASIGNAMOS LOS VALORES
            UnidadMedida = ValidacionUnidadMedida == true ? ddlUnidadMedida.Text.Trim() : txtUnidadMedinda.Text.Trim();
            Modelo = ValidacionModelo == true ? ddlModelo.Text.Trim() : txtModelo.Text.Trim();
            Color = ValidacionColor == true ? ddlColor.Text.Trim() : txtColor.Text.Trim();
            Capacidad = ValidacionCapacidad == true ? ddlCpacidad.Text.Trim() : txtCapacidad.Text.Trim();
            Condicion = ValidacionCondicion == true ? ddlCondicion.Text.Trim() : txtCondicion.Text.Trim();


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
            UnidadMedida,
            Modelo,
            Color,
            Condicion,
            Capacidad,
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
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            lbTitulo.Text = "PROCESAR INFORMACION DE PRODUCTOS Y SERVICIOS";
            lbTitulo.ForeColor = Color.White;
            txtstock.Text = "1";
            txtstockminimo.Text = "1";
            CargarListas();
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
           
            ValidarConfiguracionesGenerales();
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
                SeleccionarModo(Convert.ToDecimal(ddlTipoProducto.SelectedValue));
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
                if (VariablesGlobales.Accion == "INSERT") {

                    bool ValidacionReferenciaObligatorio = false;
                    DSMarket.Logica.Comunes.ValidarConfiguracionesGeneralesSistema ValidacionCampoReferenciaObligatorio = new Logica.Comunes.ValidarConfiguracionesGeneralesSistema((decimal)OpcionesConfigunacionGeneral.CampoReferenciaObligatorio, 1);
                    ValidacionReferenciaObligatorio = ValidacionCampoReferenciaObligatorio.ValidarConfiguracionGeneral();
                    int TipoProdcto = Convert.ToInt32(ddlTipoProducto.SelectedValue);

                    if (ValidacionReferenciaObligatorio == true && TipoProdcto == 1) {

                        //validamos si esta vacio el campo
                        if (string.IsNullOrEmpty(txtReferencia.Text.Trim())) {
                            MessageBox.Show("El campo referencia es obligatorio para guardar este registro, favor de verificar.", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else {

                            //BUSCAMOS SI LA REFERENCIA EXISTE EN BASE DE DATOS
                            string _Referencia = string.IsNullOrEmpty(txtReferencia.Text.Trim()) ? null : txtReferencia.Text.Trim();
                            string _Producto = "";
                            var BuscarReferencia = ObjDataInventario.Value.BuscaProductosServicios(
                                new Nullable<decimal>(),
                                null, null, null, null, null, null, null, null, _Referencia, null, null, null, null, null, null, 1, 1);
                            if (BuscarReferencia.Count() < 1)
                            {
                                ProcesarItem();
                            }
                            else
                            {
                                foreach (var n in BuscarReferencia)
                                {
                                    _Producto = n.Descripcion;
                                }
                                MessageBox.Show("La referencia ingresada pertenece al siguiente equipo, " + _Producto + " favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }

                        }

                    }
                    else {
                        ProcesarItem();
                    }


              



                }
                else {
                    ProcesarItem();
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

        private void txtReferencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool RespuestaValidacion = false;

            DSMarket.Logica.Comunes.ValidarConfiguracionesGeneralesSistema ValidarCampoReferenciaNumerico = new Logica.Comunes.ValidarConfiguracionesGeneralesSistema((decimal)OpcionesConfigunacionGeneral.CampoReferenciaNumerico, 1);
            RespuestaValidacion = ValidarCampoReferenciaNumerico.ValidarConfiguracionGeneral();

            if (RespuestaValidacion == true)
            {
                DSMarket.Logica.Comunes.ValidarControles.SoloNumeros(e);
            }
        }

        private void ddlMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool RespuestaValidacion = false;
            #region MODELO SELECCIONABLE
            DSMarket.Logica.Comunes.ValidarConfiguracionesGeneralesSistema ValidarCampoModeloSeleccionable = new Logica.Comunes.ValidarConfiguracionesGeneralesSistema((decimal)OpcionesConfigunacionGeneral.CampoModeloSeleccionable, 1);
            RespuestaValidacion = ValidarCampoModeloSeleccionable.ValidarConfiguracionGeneral();

            switch (RespuestaValidacion)
            {
                case true:
                    txtModelo.Visible = false;
                    ddlModelo.Visible = true;
                    CargarModelos();
                    break;
                case false:
                    txtModelo.Visible = true;
                    ddlModelo.Visible = false;
                    break;
            }
            #endregion
        }
    }
}
