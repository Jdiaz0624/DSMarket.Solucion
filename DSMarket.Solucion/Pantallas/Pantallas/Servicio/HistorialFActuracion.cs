﻿using System;
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
    public partial class HistorialFActuracion : Form
    {
        public HistorialFActuracion()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaServicio.LogicaServicio> ObhDataServicio = new Lazy<Logica.Logica.LogicaServicio.LogicaServicio>();
        Lazy<DSMarket.Logica.Logica.LogicaListas.LogicaListas> ObjdataLista = new Lazy<Logica.Logica.LogicaListas.LogicaListas>();
        Lazy<DSMarket.Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion> ObjdataConfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion>();
        Lazy<DSMarket.Logica.Logica.LogicaSeguridad.LogicaSeguridad> ObjDataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad.LogicaSeguridad>();
        Lazy<DSMarket.Logica.Logica.LogicaInventario.LogicaInventario> ObjDataInventario = new Lazy<Logica.Logica.LogicaInventario.LogicaInventario>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();
        #region APLCIAR TEMA
        private void AplicarTema() {
            this.BackColor = SystemColors.Control;


        }
        #endregion

        #region MOSTRAR EL LISTADO DE LAS VENTAS
        private void MostrarListadoVentas() {
            try {
                if (cbNoagregarRangofecha.Checked == true) {
                    //HACEMOS LA CONSULTA AGREGANDO RANGO DE FECHA
                    if (rbGenerar.Checked == true) {
                        string _NombrreCliente = string.IsNullOrEmpty(txtParametro.Text.Trim()) ? null : txtParametro.Text.Trim();

                        var BuscarRegistro = ObhDataServicio.Value.HistorialFacturacion(
                            new Nullable<decimal>(),
                            null,
                            null,
                            null,
                            _NombrreCliente,
                            Convert.ToDateTime(txtFechaDesde.Text),
                            Convert.ToDateTime(txtFechaHasta.Text),
                            Convert.ToInt32(txtNumeroPagina.Value),
                            Convert.ToInt32(txtNumeroRegistros.Value));
                        dtListado.DataSource = BuscarRegistro;
                        OcultarColumnas();
                        if (BuscarRegistro.Count() < 1)
                        {
                            lbCantidadRegistrosVariable.Text = "0";
                        }
                        else {
                            foreach (var n in BuscarRegistro) {
                                int CantidadRegistros = Convert.ToInt32(n.CantidadRegistros);
                                lbCantidadRegistrosVariable.Text = CantidadRegistros.ToString("N0");
                            }
                        }
                    }
                    else if (rbNumero.Checked == true) {
                        if (string.IsNullOrEmpty(txtParametro.Text.Trim()))
                        {
                            MessageBox.Show("El campo parametro no puede estar vacio para buscar por el numero de factura, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else {
                            var BuscarRegistro = ObhDataServicio.Value.HistorialFacturacion(
                          Convert.ToDecimal(txtParametro.Text),
                          null,
                          null,
                          null,
                          null,
                          Convert.ToDateTime(txtFechaDesde.Text),
                          Convert.ToDateTime(txtFechaHasta.Text),
                          Convert.ToInt32(txtNumeroPagina.Value),
                          Convert.ToInt32(txtNumeroRegistros.Value));
                            dtListado.DataSource = BuscarRegistro;
                            OcultarColumnas();
                            if (BuscarRegistro.Count() < 1)
                            {
                                lbCantidadRegistrosVariable.Text = "0";
                            }
                            else
                            {
                                foreach (var n in BuscarRegistro)
                                {
                                    int CantidadRegistros = Convert.ToInt32(n.CantidadRegistros);
                                    lbCantidadRegistrosVariable.Text = CantidadRegistros.ToString("N0");
                                }
                            }
                        }

                    }
                    else if (rbEstatus.Checked == true) {
                        try {
                            var BuscarPorEstatus = ObhDataServicio.Value.HistorialFacturacion(
                          new Nullable<decimal>(),
                          Convert.ToDecimal(ddlSeleccionar.SelectedValue),
                          null,
                          null,
                          null,
                          Convert.ToDateTime(txtFechaDesde.Text),
                          Convert.ToDateTime(txtFechaHasta.Text),
                          Convert.ToInt32(txtNumeroPagina.Value),
                          Convert.ToInt32(txtNumeroRegistros.Value));
                            dtListado.DataSource = BuscarPorEstatus;
                            OcultarColumnas();
                            if (BuscarPorEstatus.Count() < 1)
                            {
                                lbCantidadRegistrosVariable.Text = "0";
                            }
                            else
                            {
                                foreach (var n in BuscarPorEstatus)
                                {
                                    int CantidadRegistros = Convert.ToInt32(n.CantidadRegistros);
                                    lbCantidadRegistrosVariable.Text = CantidadRegistros.ToString("N0");
                                }
                            }
                        }
                        catch (Exception) { }
                    }
                    else if (rbTipoFacturacion.Checked == true) {
                        try
                        {
                            var Listado = ObhDataServicio.Value.HistorialFacturacion(
                          new Nullable<decimal>(),
                          null,
                          Convert.ToDecimal(ddlSeleccionar.SelectedValue),
                          null,
                          null,
                          Convert.ToDateTime(txtFechaDesde.Text),
                          Convert.ToDateTime(txtFechaHasta.Text),
                          Convert.ToInt32(txtNumeroPagina.Value),
                          Convert.ToInt32(txtNumeroRegistros.Value));
                            dtListado.DataSource = Listado;
                            OcultarColumnas();
                            if (Listado.Count() < 1)
                            {
                                lbCantidadRegistrosVariable.Text = "0";
                            }
                            else
                            {
                                foreach (var n in Listado)
                                {
                                    int CantidadRegistros = Convert.ToInt32(n.CantidadRegistros);
                                    lbCantidadRegistrosVariable.Text = CantidadRegistros.ToString("N0");
                                }
                            }
                        }
                        catch (Exception) { }
                    }
                    else if (rbTipoPago.Checked == true) {
                        try
                        {
                            var Listado = ObhDataServicio.Value.HistorialFacturacion(
                          new Nullable<decimal>(),
                          null,
                          null,
                          Convert.ToDecimal(ddlSeleccionar.SelectedValue),
                          null,
                          Convert.ToDateTime(txtFechaDesde.Text),
                          Convert.ToDateTime(txtFechaHasta.Text),
                          Convert.ToInt32(txtNumeroPagina.Value),
                          Convert.ToInt32(txtNumeroRegistros.Value));
                            dtListado.DataSource = Listado;
                            OcultarColumnas();
                            if (Listado.Count() < 1)
                            {
                                lbCantidadRegistrosVariable.Text = "0";
                            }
                            else
                            {
                                foreach (var n in Listado)
                                {
                                    int CantidadRegistros = Convert.ToInt32(n.CantidadRegistros);
                                    lbCantidadRegistrosVariable.Text = CantidadRegistros.ToString("N0");
                                }
                            }
                        }
                        catch (Exception) { }
                    }
                    else {
                        MessageBox.Show("Favor de seleccionar una opción para consultar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else {
                    //HACEMOS LA CONSULTA SIN AGREGAR RANGO DE FECHA
                    if (rbGenerar.Checked == true)
                    {
                        string _NombrreCliente = string.IsNullOrEmpty(txtParametro.Text.Trim()) ? null : txtParametro.Text.Trim();

                        var BuscarRegistro = ObhDataServicio.Value.HistorialFacturacion(
                            new Nullable<decimal>(),
                            null,
                            null,
                            null,
                            _NombrreCliente,
                            null,
                            null,
                            Convert.ToInt32(txtNumeroPagina.Value),
                            Convert.ToInt32(txtNumeroRegistros.Value));
                        dtListado.DataSource = BuscarRegistro;
                        OcultarColumnas();
                        if (BuscarRegistro.Count() < 1)
                        {
                            lbCantidadRegistrosVariable.Text = "0";
                        }
                        else
                        {
                            foreach (var n in BuscarRegistro)
                            {
                                int CantidadRegistros = Convert.ToInt32(n.CantidadRegistros);
                                lbCantidadRegistrosVariable.Text = CantidadRegistros.ToString("N0");
                            }
                        }
                    }
                    else if (rbNumero.Checked == true)
                    {
                        if (string.IsNullOrEmpty(txtParametro.Text.Trim()))
                        {
                            MessageBox.Show("El campo parametro no puede estar vacio para buscar por el numero de factura, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            var BuscarRegistro = ObhDataServicio.Value.HistorialFacturacion(
                          Convert.ToDecimal(txtParametro.Text),
                          null,
                          null,
                          null,
                          null,
                          null,
                          null,
                          Convert.ToInt32(txtNumeroPagina.Value),
                          Convert.ToInt32(txtNumeroRegistros.Value));
                            dtListado.DataSource = BuscarRegistro;
                            OcultarColumnas();
                            if (BuscarRegistro.Count() < 1)
                            {
                                lbCantidadRegistrosVariable.Text = "0";
                            }
                            else
                            {
                                foreach (var n in BuscarRegistro)
                                {
                                    int CantidadRegistros = Convert.ToInt32(n.CantidadRegistros);
                                    lbCantidadRegistrosVariable.Text = CantidadRegistros.ToString("N0");
                                }
                            }
                        }
                    }
                    else if (rbEstatus.Checked == true)
                    {
                        try {
                            var BuscarPorEstatus = ObhDataServicio.Value.HistorialFacturacion(
                        new Nullable<decimal>(),
                        Convert.ToDecimal(ddlSeleccionar.SelectedValue),
                        null,
                        null,
                        null,
                        null,
                        null,
                        Convert.ToInt32(txtNumeroPagina.Value),
                        Convert.ToInt32(txtNumeroRegistros.Value));
                            dtListado.DataSource = BuscarPorEstatus;
                            OcultarColumnas();
                            if (BuscarPorEstatus.Count() < 1)
                            {
                                lbCantidadRegistrosVariable.Text = "0";
                            }
                            else
                            {
                                foreach (var n in BuscarPorEstatus)
                                {
                                    int CantidadRegistros = Convert.ToInt32(n.CantidadRegistros);
                                    lbCantidadRegistrosVariable.Text = CantidadRegistros.ToString("N0");
                                }
                            }
                        }
                        catch (Exception) { }
                    }
                    else if (rbTipoFacturacion.Checked == true)
                    {
                        try
                        {
                            var Listado = ObhDataServicio.Value.HistorialFacturacion(
                          new Nullable<decimal>(),
                          null,
                          Convert.ToDecimal(ddlSeleccionar.SelectedValue),
                          null,
                          null,
                          null,
                          null,
                          Convert.ToInt32(txtNumeroPagina.Value),
                          Convert.ToInt32(txtNumeroRegistros.Value));
                            dtListado.DataSource = Listado;
                            OcultarColumnas();
                            if (Listado.Count() < 1)
                            {
                                lbCantidadRegistrosVariable.Text = "0";
                            }
                            else
                            {
                                foreach (var n in Listado)
                                {
                                    int CantidadRegistros = Convert.ToInt32(n.CantidadRegistros);
                                    lbCantidadRegistrosVariable.Text = CantidadRegistros.ToString("N0");
                                }
                            }
                        }
                        catch (Exception) { }
                    }
                    else if (rbTipoPago.Checked == true)
                    {
                        try
                        {
                            var Listado = ObhDataServicio.Value.HistorialFacturacion(
                          new Nullable<decimal>(),
                          null,
                          null,
                          Convert.ToDecimal(ddlSeleccionar.SelectedValue),
                          null,
                          null,
                          null,
                          Convert.ToInt32(txtNumeroPagina.Value),
                          Convert.ToInt32(txtNumeroRegistros.Value));
                            dtListado.DataSource = Listado;
                            OcultarColumnas();
                            if (Listado.Count() < 1)
                            {
                                lbCantidadRegistrosVariable.Text = "0";
                            }
                            else
                            {
                                foreach (var n in Listado)
                                {
                                    int CantidadRegistros = Convert.ToInt32(n.CantidadRegistros);
                                    lbCantidadRegistrosVariable.Text = CantidadRegistros.ToString("N0");
                                }
                            }
                        }
                        catch (Exception) { }
                    }
                    else
                    {
                        MessageBox.Show("Favor de seleccionar una opción para consultar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Error al mostrar el listado, codigo de error--> " + ex.Message, VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region OCULTAR COLUMNAS
        private void OcultarColumnas() {
            this.dtListado.Columns["IdFactura"].Visible = false;
            this.dtListado.Columns["NumeroConector"].Visible = false;
            this.dtListado.Columns["IdEstatusFacturacion"].Visible = false;
            this.dtListado.Columns["DescripcionComprobante"].Visible = false;
            this.dtListado.Columns["Comprobante"].Visible = false;
            this.dtListado.Columns["IdComprobante"].Visible = false;
            this.dtListado.Columns["Descripcion"].Visible = false;
            this.dtListado.Columns["IdTipoIdentificacion"].Visible = false;
            this.dtListado.Columns["IdTipoVenta"].Visible = false;
            this.dtListado.Columns["IdUsuario"].Visible = false;
            this.dtListado.Columns["FechaFacturacion0"].Visible = false;
            this.dtListado.Columns["IdTipoPago"].Visible = false;
            this.dtListado.Columns["CantidadRegistros"].Visible = false;
            this.dtListado.Columns["IdCantidadDias"].Visible = false;
        }
        #endregion
        #region MOSTRAR EL LISTADO DE DEL ESTATUS DE FACTURACION
        private void MostrarListadoEstatusFacturacion() {
            var Listado = ObjdataLista.Value.BuscaListaEstatusFacturacion();
            ddlSeleccionar.DataSource = Listado;
            ddlSeleccionar.DisplayMember = "Estatus";
            ddlSeleccionar.ValueMember = "IdEstatusFacturacion";
        }
        #endregion
        #region MOSTRAR EL LISTADO DE TIPO DE FACTURACION
        private void MostrarListadoTipoFacturacion() {
            var TipoFacturacion = ObjdataLista.Value.BuscaTipoVenta();
            ddlSeleccionar.DataSource = TipoFacturacion;
            ddlSeleccionar.DisplayMember = "TipoVenta";
            ddlSeleccionar.ValueMember = "IdTipoVenta";

        }
        #endregion
        #region MOSTRAR LOS TIPOS DE PAGOS
        private void MostrarTipoPagos() {
            var TipoPago = ObjdataLista.Value.BuscaTipoPago(
                new Nullable<decimal>());
            ddlSeleccionar.DataSource = TipoPago;
            ddlSeleccionar.DisplayMember = "TipoPago";
            ddlSeleccionar.ValueMember = "IdTipoPago";
        }
        #endregion
        #region RESTABLECER PANTALLA
        private void RestablecerPantalla() {
            lbCantidadProductos.Visible = false;
            txtCantidadProductos.Visible = false;
            lbCantidadServicios.Visible = false;
            txtCantidadServicios.Visible = false;
            lbCantidadTotal.Visible = false;
            txtCantidadTotal.Visible = false;

            lbFormatoFactura.Visible = false;
            rbfacturaenglish.Visible = false;
            rbfacturaspanish.Visible = false;

            btnImprimir.Enabled = false;
            btnProductos.Enabled = false;
            rbfacturaspanish.Checked = false;

            rbGenerar.Checked = true;
            txtCantidadProductos.Text = string.Empty;
            txtCantidadServicios.Text = string.Empty;
            txtCantidadTotal.Text = string.Empty;
            btnBuscar.Enabled = true;
            txtNumeroPagina.Enabled = true;
            txtNumeroRegistros.Enabled = true;
            txtNumeroPagina.Value = 1;
            txtNumeroRegistros.Value = 10;
            btnFacturar.Enabled = false;
            btnAnular.Enabled = false;
            VariablesGlobales.IdEstatusFacturacionHistorial = 0;
            MostrarListadoVentas();
        }
        #endregion
        private void HistorialFActuracion_Load(object sender, EventArgs e)
        {
            rbGenerar.ForeColor = Color.LimeGreen;
            rbNumero.ForeColor = Color.DarkRed;
            rbEstatus.ForeColor = Color.DarkRed;
            rbTipoFacturacion.ForeColor = Color.DarkRed;
            rbTipoPago.ForeColor = Color.DarkRed;
            cbNoagregarRangofecha.ForeColor = Color.DarkRed;
            rbGenerar.Checked = true;
            lbCantidadRegistrosTitulo.ForeColor = Color.White;
            lbCantidadRegistros.ForeColor = Color.White;
            lbCantidadRegistrosVariable.ForeColor = Color.White;
            lbFechaDesde.Visible = false;
            txtFechaDesde.Visible = false;
            lbFechaHAsta.Visible = false;
            txtFechaHasta.Visible = false;
           // lbParametro.Visible = false;
          //  txtParametro.Visible = false;
            lbSeleccionar.Visible = false;
            ddlSeleccionar.Visible = false;
        }

        private void rbGenerar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGenerar.Checked == true)
            {
                rbGenerar.ForeColor = Color.LimeGreen;
                rbNumero.ForeColor = Color.DarkRed;
                rbEstatus.ForeColor = Color.DarkRed;
                rbTipoFacturacion.ForeColor = Color.DarkRed;
                rbTipoPago.ForeColor = Color.DarkRed;
                // cbNoagregarRangofecha.ForeColor = Color.DarkRed;

                txtParametro.Text = string.Empty;
                lbParametro.Visible = true;
                txtParametro.Visible = true;
                lbSeleccionar.Visible = false;
                ddlSeleccionar.Visible = false;
            }
            else
            {
                rbGenerar.ForeColor = Color.DarkRed;
                rbNumero.ForeColor = Color.DarkRed;
                rbEstatus.ForeColor = Color.DarkRed;
                rbTipoFacturacion.ForeColor = Color.DarkRed;
                rbTipoPago.ForeColor = Color.DarkRed;
               // cbNoagregarRangofecha.ForeColor = Color.DarkRed;

                lbParametro.Visible = false;
                txtParametro.Visible = false;
                lbSeleccionar.Visible = false;
                ddlSeleccionar.Visible = false;
            }
        }

        private void rbNumero_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNumero.Checked == true)
            {
                rbGenerar.ForeColor = Color.DarkRed;
                rbNumero.ForeColor = Color.LimeGreen;
                rbEstatus.ForeColor = Color.DarkRed;
                rbTipoFacturacion.ForeColor = Color.DarkRed;
                rbTipoPago.ForeColor = Color.DarkRed;
                //  cbNoagregarRangofecha.ForeColor = Color.DarkRed;

                txtParametro.Text = string.Empty;
                lbParametro.Visible = true;
                txtParametro.Visible = true;
                lbSeleccionar.Visible = false;
                ddlSeleccionar.Visible = false;
            }
            else
            {
                rbGenerar.ForeColor = Color.DarkRed;
                rbNumero.ForeColor = Color.DarkRed;
                rbEstatus.ForeColor = Color.DarkRed;
                rbTipoFacturacion.ForeColor = Color.DarkRed;
                rbTipoPago.ForeColor = Color.DarkRed;
             //   cbNoagregarRangofecha.ForeColor = Color.DarkRed;

                lbParametro.Visible = false;
                txtParametro.Visible = false;
                lbSeleccionar.Visible = false;
                ddlSeleccionar.Visible = false;
            }
        }

        private void rbEstatus_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEstatus.Checked == true)
            {
                rbGenerar.ForeColor = Color.DarkRed;
                rbNumero.ForeColor = Color.DarkRed;
                rbEstatus.ForeColor = Color.LimeGreen;
                rbTipoFacturacion.ForeColor = Color.DarkRed;
                rbTipoPago.ForeColor = Color.DarkRed;
              //  cbNoagregarRangofecha.ForeColor = Color.DarkRed;

                lbParametro.Visible = false;
                txtParametro.Visible = false;
                lbSeleccionar.Visible = true;
                ddlSeleccionar.Visible = true;
                MostrarListadoEstatusFacturacion();
            }
            else
            {
                rbGenerar.ForeColor = Color.DarkRed;
                rbNumero.ForeColor = Color.DarkRed;
                rbEstatus.ForeColor = Color.DarkRed;
                rbTipoFacturacion.ForeColor = Color.DarkRed;
                rbTipoPago.ForeColor = Color.DarkRed;
            //    cbNoagregarRangofecha.ForeColor = Color.DarkRed;

                lbParametro.Visible = false;
                txtParametro.Visible = false;
                lbSeleccionar.Visible = false;
                ddlSeleccionar.Visible = false;
                ddlSeleccionar.DataSource = null;
            }
        }

        private void rbTipoFacturacion_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTipoFacturacion.Checked == true)
            {
                rbGenerar.ForeColor = Color.DarkRed;
                rbNumero.ForeColor = Color.DarkRed;
                rbEstatus.ForeColor = Color.DarkRed;
                rbTipoFacturacion.ForeColor = Color.LimeGreen;
                rbTipoPago.ForeColor = Color.DarkRed;
              //  cbNoagregarRangofecha.ForeColor = Color.DarkRed;

                lbParametro.Visible = false;
                txtParametro.Visible = false;
                lbSeleccionar.Visible = true;
                ddlSeleccionar.Visible = true;
                MostrarListadoTipoFacturacion();
            }
            else
            {
                rbGenerar.ForeColor = Color.DarkRed;
                rbNumero.ForeColor = Color.DarkRed;
                rbEstatus.ForeColor = Color.DarkRed;
                rbTipoFacturacion.ForeColor = Color.DarkRed;
                rbTipoPago.ForeColor = Color.DarkRed;
            //    cbNoagregarRangofecha.ForeColor = Color.DarkRed;

                lbParametro.Visible = false;
                txtParametro.Visible = false;
                lbSeleccionar.Visible = false;
                ddlSeleccionar.Visible = false;
                ddlSeleccionar.DataSource = null;
            }
        }

        private void rbTipoPago_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTipoPago.Checked == true)
            {
                rbGenerar.ForeColor = Color.DarkRed;
                rbNumero.ForeColor = Color.DarkRed;
                rbEstatus.ForeColor = Color.DarkRed;
                rbTipoFacturacion.ForeColor = Color.DarkRed;
                rbTipoPago.ForeColor = Color.LimeGreen;
            //    cbNoagregarRangofecha.ForeColor = Color.DarkRed;

                lbParametro.Visible = false;
                txtParametro.Visible = false;
                lbSeleccionar.Visible = true;
                ddlSeleccionar.Visible = true;
                MostrarTipoPagos();
            }
            else
            {
                rbGenerar.ForeColor = Color.DarkRed;
                rbNumero.ForeColor = Color.DarkRed;
                rbEstatus.ForeColor = Color.DarkRed;
                rbTipoFacturacion.ForeColor = Color.DarkRed;
                rbTipoPago.ForeColor = Color.DarkRed;
                cbNoagregarRangofecha.ForeColor = Color.DarkRed;

                lbParametro.Visible = false;
                txtParametro.Visible = false;
                lbSeleccionar.Visible = false;
                ddlSeleccionar.Visible = false;
                ddlSeleccionar.DataSource = null;
            }
        }

        private void cbNoagregarRangofecha_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNoagregarRangofecha.Checked == true)
            {
                //rbGenerar.ForeColor = Color.DarkRed;
                //rbNumero.ForeColor = Color.DarkRed;
                //rbEstatus.ForeColor = Color.DarkRed;
                //rbTipoFacturacion.ForeColor = Color.DarkRed;
                //rbTipoPago.ForeColor = Color.DarkRed;
                cbNoagregarRangofecha.ForeColor = Color.LimeGreen;

                lbFechaDesde.Visible = true;
                txtFechaDesde.Visible = true;
                lbFechaHAsta.Visible = true;
                txtFechaHasta.Visible = true;
            }
            else
            {
                //rbGenerar.ForeColor = Color.DarkRed;
                //rbNumero.ForeColor = Color.DarkRed;
                //rbEstatus.ForeColor = Color.DarkRed;
                //rbTipoFacturacion.ForeColor = Color.DarkRed;
                //rbTipoPago.ForeColor = Color.DarkRed;
                cbNoagregarRangofecha.ForeColor = Color.DarkRed;

                lbFechaDesde.Visible = false;
                txtFechaDesde.Visible = false;
                lbFechaHAsta.Visible = false;
                txtFechaHasta.Visible = false;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            DSMarket.Solucion.Pantallas.Pantallas.Servicio.Facturacion Convertir = new Facturacion();
            Convertir.VariablesGlobales.ConvertirCotizacionFactura = true;
            Convertir.txtNoCotizacion.Text = VariablesGlobales.IdMantenimeinto.ToString();
            Convertir.BuscarCotizacion();
            Convertir.ddlTipoFacturacion.Enabled = true;
            Convertir.ShowDialog();
            btnFacturar.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Servicio.AnularFactura Anular = new AnularFactura();
            Anular.ShowDialog();
        }

        private void HistorialFActuracion_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtParametro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rbNumero.Checked == true) {
                DSMarket.Logica.Comunes.ValidarControles.SoloNumeros(e);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MostrarListadoVentas();
        }

        private void dtListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("¿Quieres seleccionar este registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                lbFormatoFactura.Visible = true;
                rbfacturaspanish.Visible = true;
                rbfacturaenglish.Visible = true;
                btnImprimir.Enabled = true;
                btnProductos.Enabled = true;
                rbfacturaspanish.Checked = true;
                btnBuscar.Enabled = false;
                txtNumeroPagina.Enabled = false;
                txtNumeroRegistros.Enabled = false;
                this.VariablesGlobales.IdMantenimeinto = Convert.ToDecimal(this.dtListado.CurrentRow.Cells["IdFactura"].Value.ToString());
                this.VariablesGlobales.NumeroConector = Convert.ToDecimal(this.dtListado.CurrentRow.Cells["NumeroConector"].Value.ToString());
                this.VariablesGlobales.IdEstatusFacturacionHistorial = Convert.ToDecimal(dtListado.CurrentRow.Cells["IdEstatusFacturacion"].Value.ToString());

                if (VariablesGlobales.IdEstatusFacturacionHistorial == 2) {
                    btnFacturar.Enabled = true;
                }

                if (VariablesGlobales.IdEstatusFacturacionHistorial != 3) {
                    btnAnular.Enabled = true;
                }
            }
        }

        private void txtNumeroPagina_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroPagina.Value < 1)
            {
                txtNumeroPagina.Value = 1;
                MostrarListadoVentas();
            }
            else {
                MostrarListadoVentas();
            }
        }

        private void txtNumeroRegistros_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroRegistros.Value < 1)
            {
                txtNumeroRegistros.Value = 10;
                MostrarListadoVentas();
            }
            else {
                MostrarListadoVentas();
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            string RutaReporte = "";
            string UsuarioBD = "";
            string ClaveBD = "";


            var SacarCredenciales = ObjDataSeguridad.Value.SacarCredencialBD(1);
            foreach (var n2 in SacarCredenciales) {
                UsuarioBD = n2.Usuario;
                ClaveBD = DSMarket.Logica.Comunes.SeguridadEncriptacion.DesEncriptar(n2.Clave);
            }
            if (rbfacturaspanish.Checked == true)
            {

                var SacarRutaReporte = ObjdataConfiguracion.Value.BuscaRutaReporte(1);
                foreach (var n in SacarRutaReporte)
                {
                    RutaReporte = n.RutaReporte;
                }

                DSMarket.Solucion.Pantallas.Pantallas.Reportes.Reportes Invocar = new Reportes.Reportes();
                Invocar.GenerarFacturaVenta(VariablesGlobales.IdMantenimeinto, RutaReporte, UsuarioBD, ClaveBD);
                Invocar.ShowDialog();
            }
            else if (rbfacturaenglish.Checked == true) {

                var SacarRutaReporte = ObjdataConfiguracion.Value.BuscaRutaReporte(2);
                foreach (var n in SacarRutaReporte)
                {
                    RutaReporte = n.RutaReporte;
                }

                DSMarket.Solucion.Pantallas.Pantallas.Reportes.Reportes Invocar = new Reportes.Reportes();
                Invocar.GenerarFacturaVenta(VariablesGlobales.IdMantenimeinto, RutaReporte, UsuarioBD, ClaveBD);
                Invocar.ShowDialog();
            }
            else {
                MessageBox.Show("Selecciona una opción para poder imprimir", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            lbCantidadProductos.Visible = true;
            txtCantidadProductos.Visible = true;
            lbCantidadServicios.Visible = true;
            txtCantidadServicios.Visible = true;
            lbCantidadTotal.Visible = true;
            txtCantidadTotal.Visible = true;

            var MostrarProductosAgregados = ObhDataServicio.Value.BuscapRoductosAgregados(
                new Nullable<decimal>(),
                VariablesGlobales.NumeroConector);
            dtListado.DataSource = MostrarProductosAgregados;

            foreach (var n in MostrarProductosAgregados) {
                int CantidadProductos = 0, CantidadServicios = 0, CantidadTotal;

                CantidadProductos = Convert.ToInt32(n.CantidadProductos);
                CantidadServicios = Convert.ToInt32(n.CantidadServicios);
                CantidadTotal = Convert.ToInt32(n.CantidadRegistros);

                txtCantidadProductos.Text = CantidadProductos.ToString("N0");
                txtCantidadServicios.Text = CantidadServicios.ToString("N0");
                txtCantidadTotal.Text = CantidadTotal.ToString("N0");
            }

            dtListado.Columns["IdTipoProducto"].Visible = false;
            dtListado.Columns["IdCategoria"].Visible = false;
            dtListado.Columns["DescripcionTipoProducto1"].Visible = false;
            dtListado.Columns["IdProducto"].Visible = false;
            dtListado.Columns["ConectorProducto"].Visible = false;
            dtListado.Columns["PorcientoImpuesto"].Visible = false;
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            RestablecerPantalla();

            
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {

        }
    }
}
