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

                        }
                        else {

                        }
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
                          null,
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
                        null,
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
        #region GENERAR REPORTE VENTA
        private void GenerarReporteVenta() {
            try {
                DSMarket.Logica.Entidades.EntidadesConfiguracion.EGuardarReporteVenta Borrar = new Logica.Entidades.EntidadesConfiguracion.EGuardarReporteVenta();
                Borrar.IdUsuario = VariablesGlobales.IdUsuario;
                var MANDelete = ObjdataConfiguracion.Value.GuardarReporteVenta(Borrar, "DELETE");

                if (cbNoagregarRangofecha.Checked == true)
                {
                    //HACEMOS LA CONSULTA AGREGANDO RANGO DE FECHA
                    if (rbGenerar.Checked == true)
                    {
                        

                        string _NombrreCliente = string.IsNullOrEmpty(txtParametro.Text.Trim()) ? null : txtParametro.Text.Trim();

                        var BuscarRegistro = ObhDataServicio.Value.HistorialFacturacion(
                            new Nullable<decimal>(),
                            null,
                            null,
                            null,
                            null,
                            _NombrreCliente,
                            Convert.ToDateTime(txtFechaDesde.Text),
                            Convert.ToDateTime(txtFechaHasta.Text),
                            Convert.ToInt32(txtNumeroPagina.Value),
                            Convert.ToInt32(txtNumeroRegistros.Value));
                        foreach (var n in BuscarRegistro) {
                            DSMarket.Logica.Comunes.ProcesarReporteVenta Procesar = new Logica.Comunes.ProcesarReporteVenta(
                                  VariablesGlobales.IdUsuario,
                                  n.Cliente,
                                  n.EstatusFacturacion,
                                  Convert.ToDecimal(n.IdFactura),
                                  Convert.ToDecimal(n.NumeroConector),
                                  Convert.ToDecimal(n.IdEstatusFacturacion),
                                  n.TipoIdentificacion,
                                  n.DescripcionComprobante,
                                  n.Comprobante,
                                  Convert.ToDecimal(n.IdComprobante),
                                  n.Descripcion,
                                  n.Telefono,
                                  n.Email,
                                  Convert.ToDecimal(n.IdTipoIdentificacion),
                                  n.NumeroIdentificacion,
                                  n.Direccion,
                                  n.Comentario,
                                  Convert.ToDecimal(n.IdTipoVenta),
                                  n.TipoVenta,
                                  Convert.ToInt32(n.CantidadDias),
                                  Convert.ToInt32(n.IdCantidadDias),
                                  Convert.ToDecimal(n.IdUsuario),
                                  n.CreadoPor,
                                  Convert.ToDateTime(n.FechaFacturacion0),
                                  Convert.ToInt32(n.CantidadProductos),
                                  Convert.ToInt32(n.CantidadServicios),
                                  Convert.ToInt32(n.CantidadArticulos),
                                  Convert.ToDecimal(n.TotalDescuento),
                                  Convert.ToDecimal(n.SubTotal),
                                  Convert.ToDecimal(n.Impuesto),
                                  Convert.ToInt32(n.PorcientoImpuesto),
                                  Convert.ToDecimal(n.MontoPagado),
                                  Convert.ToDecimal(n.Cambio),
                                  Convert.ToInt32(n.IdTipoPago),
                                  n.TipoPago,
                                  Convert.ToDecimal(n.TotalGeneral),
                                  "INSERT");
                            Procesar.ProcesarInformacion();
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
                          Convert.ToDateTime(txtFechaDesde.Text),
                          Convert.ToDateTime(txtFechaHasta.Text),
                          Convert.ToInt32(txtNumeroPagina.Value),
                          Convert.ToInt32(txtNumeroRegistros.Value));
                            foreach (var n in BuscarRegistro)
                            {
                                DSMarket.Logica.Comunes.ProcesarReporteVenta Procesar = new Logica.Comunes.ProcesarReporteVenta(
                                  VariablesGlobales.IdUsuario,
                                  n.Cliente,
                                  n.EstatusFacturacion,
                                  Convert.ToDecimal(n.IdFactura),
                                  Convert.ToDecimal(n.NumeroConector),
                                  Convert.ToDecimal(n.IdEstatusFacturacion),
                                  n.TipoIdentificacion,
                                  n.DescripcionComprobante,
                                  n.Comprobante,
                                  Convert.ToDecimal(n.IdComprobante),
                                  n.Descripcion,
                                  n.Telefono,
                                  n.Email,
                                  Convert.ToDecimal(n.IdTipoIdentificacion),
                                  n.NumeroIdentificacion,
                                  n.Direccion,
                                  n.Comentario,
                                  Convert.ToDecimal(n.IdTipoVenta),
                                  n.TipoVenta,
                                  Convert.ToInt32(n.CantidadDias),
                                  Convert.ToInt32(n.IdCantidadDias),
                                  Convert.ToDecimal(n.IdUsuario),
                                  n.CreadoPor,
                                  Convert.ToDateTime(n.FechaFacturacion0),
                                  Convert.ToInt32(n.CantidadProductos),
                                  Convert.ToInt32(n.CantidadServicios),
                                  Convert.ToInt32(n.CantidadArticulos),
                                  Convert.ToDecimal(n.TotalDescuento),
                                  Convert.ToDecimal(n.SubTotal),
                                  Convert.ToDecimal(n.Impuesto),
                                  Convert.ToInt32(n.PorcientoImpuesto),
                                  Convert.ToDecimal(n.MontoPagado),
                                  Convert.ToDecimal(n.Cambio),
                                  Convert.ToInt32(n.IdTipoPago),
                                  n.TipoPago,
                                  Convert.ToDecimal(n.TotalGeneral),
                                  "INSERT");
                                Procesar.ProcesarInformacion();
                            }
                        }

                    }
                    else if (rbEstatus.Checked == true)
                    {
                        try
                        {
                            var BuscarPorEstatus = ObhDataServicio.Value.HistorialFacturacion(
                          new Nullable<decimal>(),
                          null,
                          Convert.ToDecimal(ddlSeleccionar.SelectedValue),
                          null,
                          null,
                          null,
                          Convert.ToDateTime(txtFechaDesde.Text),
                          Convert.ToDateTime(txtFechaHasta.Text),
                          Convert.ToInt32(txtNumeroPagina.Value),
                          Convert.ToInt32(txtNumeroRegistros.Value));
                            foreach (var n in BuscarPorEstatus)
                            {
                                DSMarket.Logica.Comunes.ProcesarReporteVenta Procesar = new Logica.Comunes.ProcesarReporteVenta(
                                  VariablesGlobales.IdUsuario,
                                  n.Cliente,
                                  n.EstatusFacturacion,
                                  Convert.ToDecimal(n.IdFactura),
                                  Convert.ToDecimal(n.NumeroConector),
                                  Convert.ToDecimal(n.IdEstatusFacturacion),
                                  n.TipoIdentificacion,
                                  n.DescripcionComprobante,
                                  n.Comprobante,
                                  Convert.ToDecimal(n.IdComprobante),
                                  n.Descripcion,
                                  n.Telefono,
                                  n.Email,
                                  Convert.ToDecimal(n.IdTipoIdentificacion),
                                  n.NumeroIdentificacion,
                                  n.Direccion,
                                  n.Comentario,
                                  Convert.ToDecimal(n.IdTipoVenta),
                                  n.TipoVenta,
                                  Convert.ToInt32(n.CantidadDias),
                                  Convert.ToInt32(n.IdCantidadDias),
                                  Convert.ToDecimal(n.IdUsuario),
                                  n.CreadoPor,
                                  Convert.ToDateTime(n.FechaFacturacion0),
                                  Convert.ToInt32(n.CantidadProductos),
                                  Convert.ToInt32(n.CantidadServicios),
                                  Convert.ToInt32(n.CantidadArticulos),
                                  Convert.ToDecimal(n.TotalDescuento),
                                  Convert.ToDecimal(n.SubTotal),
                                  Convert.ToDecimal(n.Impuesto),
                                  Convert.ToInt32(n.PorcientoImpuesto),
                                  Convert.ToDecimal(n.MontoPagado),
                                  Convert.ToDecimal(n.Cambio),
                                  Convert.ToInt32(n.IdTipoPago),
                                  n.TipoPago,
                                  Convert.ToDecimal(n.TotalGeneral),
                                  "INSERT");
                                Procesar.ProcesarInformacion();
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
                          null,
                          Convert.ToDecimal(ddlSeleccionar.SelectedValue),
                          null,
                          null,
                          Convert.ToDateTime(txtFechaDesde.Text),
                          Convert.ToDateTime(txtFechaHasta.Text),
                          Convert.ToInt32(txtNumeroPagina.Value),
                          Convert.ToInt32(txtNumeroRegistros.Value));
                            foreach (var n in Listado)
                            {
                                DSMarket.Logica.Comunes.ProcesarReporteVenta Procesar = new Logica.Comunes.ProcesarReporteVenta(
                                  VariablesGlobales.IdUsuario,
                                  n.Cliente,
                                  n.EstatusFacturacion,
                                  Convert.ToDecimal(n.IdFactura),
                                  Convert.ToDecimal(n.NumeroConector),
                                  Convert.ToDecimal(n.IdEstatusFacturacion),
                                  n.TipoIdentificacion,
                                  n.DescripcionComprobante,
                                  n.Comprobante,
                                  Convert.ToDecimal(n.IdComprobante),
                                  n.Descripcion,
                                  n.Telefono,
                                  n.Email,
                                  Convert.ToDecimal(n.IdTipoIdentificacion),
                                  n.NumeroIdentificacion,
                                  n.Direccion,
                                  n.Comentario,
                                  Convert.ToDecimal(n.IdTipoVenta),
                                  n.TipoVenta,
                                  Convert.ToInt32(n.CantidadDias),
                                  Convert.ToInt32(n.IdCantidadDias),
                                  Convert.ToDecimal(n.IdUsuario),
                                  n.CreadoPor,
                                  Convert.ToDateTime(n.FechaFacturacion0),
                                  Convert.ToInt32(n.CantidadProductos),
                                  Convert.ToInt32(n.CantidadServicios),
                                  Convert.ToInt32(n.CantidadArticulos),
                                  Convert.ToDecimal(n.TotalDescuento),
                                  Convert.ToDecimal(n.SubTotal),
                                  Convert.ToDecimal(n.Impuesto),
                                  Convert.ToInt32(n.PorcientoImpuesto),
                                  Convert.ToDecimal(n.MontoPagado),
                                  Convert.ToDecimal(n.Cambio),
                                  Convert.ToInt32(n.IdTipoPago),
                                  n.TipoPago,
                                  Convert.ToDecimal(n.TotalGeneral),
                                  "INSERT");
                                Procesar.ProcesarInformacion();
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
                          null,
                          Convert.ToDecimal(ddlSeleccionar.SelectedValue),
                          null,
                          Convert.ToDateTime(txtFechaDesde.Text),
                          Convert.ToDateTime(txtFechaHasta.Text),
                          Convert.ToInt32(txtNumeroPagina.Value),
                          Convert.ToInt32(txtNumeroRegistros.Value));
                            foreach (var n in Listado)
                            {
                                DSMarket.Logica.Comunes.ProcesarReporteVenta Procesar = new Logica.Comunes.ProcesarReporteVenta(
                                  VariablesGlobales.IdUsuario,
                                  n.Cliente,
                                  n.EstatusFacturacion,
                                  Convert.ToDecimal(n.IdFactura),
                                  Convert.ToDecimal(n.NumeroConector),
                                  Convert.ToDecimal(n.IdEstatusFacturacion),
                                  n.TipoIdentificacion,
                                  n.DescripcionComprobante,
                                  n.Comprobante,
                                  Convert.ToDecimal(n.IdComprobante),
                                  n.Descripcion,
                                  n.Telefono,
                                  n.Email,
                                  Convert.ToDecimal(n.IdTipoIdentificacion),
                                  n.NumeroIdentificacion,
                                  n.Direccion,
                                  n.Comentario,
                                  Convert.ToDecimal(n.IdTipoVenta),
                                  n.TipoVenta,
                                  Convert.ToInt32(n.CantidadDias),
                                  Convert.ToInt32(n.IdCantidadDias),
                                  Convert.ToDecimal(n.IdUsuario),
                                  n.CreadoPor,
                                  Convert.ToDateTime(n.FechaFacturacion0),
                                  Convert.ToInt32(n.CantidadProductos),
                                  Convert.ToInt32(n.CantidadServicios),
                                  Convert.ToInt32(n.CantidadArticulos),
                                  Convert.ToDecimal(n.TotalDescuento),
                                  Convert.ToDecimal(n.SubTotal),
                                  Convert.ToDecimal(n.Impuesto),
                                  Convert.ToInt32(n.PorcientoImpuesto),
                                  Convert.ToDecimal(n.MontoPagado),
                                  Convert.ToDecimal(n.Cambio),
                                  Convert.ToInt32(n.IdTipoPago),
                                  n.TipoPago,
                                  Convert.ToDecimal(n.TotalGeneral),
                                  "INSERT");
                                Procesar.ProcesarInformacion();
                            }
                        }
                        catch (Exception) { }
                    }
                    else
                    {
                        MessageBox.Show("Favor de seleccionar una opción para consultar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    //HACEMOS LA CONSULTA SIN AGREGAR RANGO DE FECHA
                    if (rbGenerar.Checked == true)
                    {
                        string _NombrreCliente = string.IsNullOrEmpty(txtParametro.Text.Trim()) ? null : txtParametro.Text.Trim();

                        var BuscarRegistro = ObhDataServicio.Value.HistorialFacturacion(
                            new Nullable<decimal>(),
                            null,
                            null,
                            null,
                            null,
                            _NombrreCliente,
                            null,
                            null,
                            Convert.ToInt32(txtNumeroPagina.Value),
                            Convert.ToInt32(txtNumeroRegistros.Value));
                        foreach (var n in BuscarRegistro)
                        {
                            DSMarket.Logica.Comunes.ProcesarReporteVenta Procesar = new Logica.Comunes.ProcesarReporteVenta(
                                  VariablesGlobales.IdUsuario,
                                  n.Cliente,
                                  n.EstatusFacturacion,
                                  Convert.ToDecimal(n.IdFactura),
                                  Convert.ToDecimal(n.NumeroConector),
                                  Convert.ToDecimal(n.IdEstatusFacturacion),
                                  n.TipoIdentificacion,
                                  n.DescripcionComprobante,
                                  n.Comprobante,
                                  Convert.ToDecimal(n.IdComprobante),
                                  n.Descripcion,
                                  n.Telefono,
                                  n.Email,
                                  Convert.ToDecimal(n.IdTipoIdentificacion),
                                  n.NumeroIdentificacion,
                                  n.Direccion,
                                  n.Comentario,
                                  Convert.ToDecimal(n.IdTipoVenta),
                                  n.TipoVenta,
                                  Convert.ToInt32(n.CantidadDias),
                                  Convert.ToInt32(n.IdCantidadDias),
                                  Convert.ToDecimal(n.IdUsuario),
                                  n.CreadoPor,
                                  Convert.ToDateTime(n.FechaFacturacion0),
                                  Convert.ToInt32(n.CantidadProductos),
                                  Convert.ToInt32(n.CantidadServicios),
                                  Convert.ToInt32(n.CantidadArticulos),
                                  Convert.ToDecimal(n.TotalDescuento),
                                  Convert.ToDecimal(n.SubTotal),
                                  Convert.ToDecimal(n.Impuesto),
                                  Convert.ToInt32(n.PorcientoImpuesto),
                                  Convert.ToDecimal(n.MontoPagado),
                                  Convert.ToDecimal(n.Cambio),
                                  Convert.ToInt32(n.IdTipoPago),
                                  n.TipoPago,
                                  Convert.ToDecimal(n.TotalGeneral),
                                  "INSERT");
                            Procesar.ProcesarInformacion();
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
                          null,
                          Convert.ToInt32(txtNumeroPagina.Value),
                          Convert.ToInt32(txtNumeroRegistros.Value));
                            foreach (var n in BuscarRegistro)
                            {
                                DSMarket.Logica.Comunes.ProcesarReporteVenta Procesar = new Logica.Comunes.ProcesarReporteVenta(
                                  VariablesGlobales.IdUsuario,
                                  n.Cliente,
                                  n.EstatusFacturacion,
                                  Convert.ToDecimal(n.IdFactura),
                                  Convert.ToDecimal(n.NumeroConector),
                                  Convert.ToDecimal(n.IdEstatusFacturacion),
                                  n.TipoIdentificacion,
                                  n.DescripcionComprobante,
                                  n.Comprobante,
                                  Convert.ToDecimal(n.IdComprobante),
                                  n.Descripcion,
                                  n.Telefono,
                                  n.Email,
                                  Convert.ToDecimal(n.IdTipoIdentificacion),
                                  n.NumeroIdentificacion,
                                  n.Direccion,
                                  n.Comentario,
                                  Convert.ToDecimal(n.IdTipoVenta),
                                  n.TipoVenta,
                                  Convert.ToInt32(n.CantidadDias),
                                  Convert.ToInt32(n.IdCantidadDias),
                                  Convert.ToDecimal(n.IdUsuario),
                                  n.CreadoPor,
                                  Convert.ToDateTime(n.FechaFacturacion0),
                                  Convert.ToInt32(n.CantidadProductos),
                                  Convert.ToInt32(n.CantidadServicios),
                                  Convert.ToInt32(n.CantidadArticulos),
                                  Convert.ToDecimal(n.TotalDescuento),
                                  Convert.ToDecimal(n.SubTotal),
                                  Convert.ToDecimal(n.Impuesto),
                                  Convert.ToInt32(n.PorcientoImpuesto),
                                  Convert.ToDecimal(n.MontoPagado),
                                  Convert.ToDecimal(n.Cambio),
                                  Convert.ToInt32(n.IdTipoPago),
                                  n.TipoPago,
                                  Convert.ToDecimal(n.TotalGeneral),
                                  "INSERT");
                                Procesar.ProcesarInformacion();
                            }
                        }
                    }
                    else if (rbEstatus.Checked == true)
                    {
                        try
                        {
                            var BuscarPorEstatus = ObhDataServicio.Value.HistorialFacturacion(
                        new Nullable<decimal>(),
                        null,
                        Convert.ToDecimal(ddlSeleccionar.SelectedValue),
                        null,
                        null,
                        null,
                        null,
                        null,
                        Convert.ToInt32(txtNumeroPagina.Value),
                        Convert.ToInt32(txtNumeroRegistros.Value));
                            foreach (var n in BuscarPorEstatus)
                            {
                                DSMarket.Logica.Comunes.ProcesarReporteVenta Procesar = new Logica.Comunes.ProcesarReporteVenta(
                                   VariablesGlobales.IdUsuario,
                                   n.Cliente,
                                   n.EstatusFacturacion,
                                   Convert.ToDecimal(n.IdFactura),
                                   Convert.ToDecimal(n.NumeroConector),
                                   Convert.ToDecimal(n.IdEstatusFacturacion),
                                   n.TipoIdentificacion,
                                   n.DescripcionComprobante,
                                   n.Comprobante,
                                   Convert.ToDecimal(n.IdComprobante),
                                   n.Descripcion,
                                   n.Telefono,
                                   n.Email,
                                   Convert.ToDecimal(n.IdTipoIdentificacion),
                                   n.NumeroIdentificacion,
                                   n.Direccion,
                                   n.Comentario,
                                   Convert.ToDecimal(n.IdTipoVenta),
                                   n.TipoVenta,
                                   Convert.ToInt32(n.CantidadDias),
                                   Convert.ToInt32(n.IdCantidadDias),
                                   Convert.ToDecimal(n.IdUsuario),
                                   n.CreadoPor,
                                   Convert.ToDateTime(n.FechaFacturacion0),
                                   Convert.ToInt32(n.CantidadProductos),
                                   Convert.ToInt32(n.CantidadServicios),
                                   Convert.ToInt32(n.CantidadArticulos),
                                   Convert.ToDecimal(n.TotalDescuento),
                                   Convert.ToDecimal(n.SubTotal),
                                   Convert.ToDecimal(n.Impuesto),
                                   Convert.ToInt32(n.PorcientoImpuesto),
                                   Convert.ToDecimal(n.MontoPagado),
                                   Convert.ToDecimal(n.Cambio),
                                   Convert.ToInt32(n.IdTipoPago),
                                   n.TipoPago,
                                   Convert.ToDecimal(n.TotalGeneral),
                                   "INSERT");
                                Procesar.ProcesarInformacion();
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
                          null,
                          Convert.ToDecimal(ddlSeleccionar.SelectedValue),
                          null,
                          null,
                          null,
                          null,
                          Convert.ToInt32(txtNumeroPagina.Value),
                          Convert.ToInt32(txtNumeroRegistros.Value));
                            foreach (var n in Listado)
                            {
                                DSMarket.Logica.Comunes.ProcesarReporteVenta Procesar = new Logica.Comunes.ProcesarReporteVenta(
                                  VariablesGlobales.IdUsuario,
                                  n.Cliente,
                                  n.EstatusFacturacion,
                                  Convert.ToDecimal(n.IdFactura),
                                  Convert.ToDecimal(n.NumeroConector),
                                  Convert.ToDecimal(n.IdEstatusFacturacion),
                                  n.TipoIdentificacion,
                                  n.DescripcionComprobante,
                                  n.Comprobante,
                                  Convert.ToDecimal(n.IdComprobante),
                                  n.Descripcion,
                                  n.Telefono,
                                  n.Email,
                                  Convert.ToDecimal(n.IdTipoIdentificacion),
                                  n.NumeroIdentificacion,
                                  n.Direccion,
                                  n.Comentario,
                                  Convert.ToDecimal(n.IdTipoVenta),
                                  n.TipoVenta,
                                  Convert.ToInt32(n.CantidadDias),
                                  Convert.ToInt32(n.IdCantidadDias),
                                  Convert.ToDecimal(n.IdUsuario),
                                  n.CreadoPor,
                                  Convert.ToDateTime(n.FechaFacturacion0),
                                  Convert.ToInt32(n.CantidadProductos),
                                  Convert.ToInt32(n.CantidadServicios),
                                  Convert.ToInt32(n.CantidadArticulos),
                                  Convert.ToDecimal(n.TotalDescuento),
                                  Convert.ToDecimal(n.SubTotal),
                                  Convert.ToDecimal(n.Impuesto),
                                  Convert.ToInt32(n.PorcientoImpuesto),
                                  Convert.ToDecimal(n.MontoPagado),
                                  Convert.ToDecimal(n.Cambio),
                                  Convert.ToInt32(n.IdTipoPago),
                                  n.TipoPago,
                                  Convert.ToDecimal(n.TotalGeneral),
                                  "INSERT");
                                Procesar.ProcesarInformacion();
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

                //INVOCAMOS EL REPORTE
               
            string RutaReporte = "";
            string UsuarioBD = "";
            string ClaveBD = "";


            var SacarCredenciales = ObjDataSeguridad.Value.SacarCredencialBD(1);
            foreach (var n2 in SacarCredenciales) {
                UsuarioBD = n2.Usuario;
                ClaveBD = DSMarket.Logica.Comunes.SeguridadEncriptacion.DesEncriptar(n2.Clave);
            }


                var SacarRutaReporte = ObjdataConfiguracion.Value.BuscaRutaReporte(6);
                foreach (var n in SacarRutaReporte)
                {
                    RutaReporte = n.RutaReporte;
                }

                DSMarket.Solucion.Pantallas.Pantallas.Reportes.Reportes Invocar = new Reportes.Reportes();
                Invocar.GenerarReporteVenta(VariablesGlobales.IdUsuario, RutaReporte, UsuarioBD, ClaveBD);
                Invocar.ShowDialog();      

            }
            catch (Exception ex) {
                MessageBox.Show("Error al guardar los datos para cargar el reporte, codigo de error: " + ex.Message, VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            this.dtListado.Columns["AplicaGarantia0"].Visible = false;
            this.dtListado.Columns["AplicaGarantia"].Visible = false;
            this.dtListado.Columns["IdTipoIngreso"].Visible = false;
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
            VariablesGlobales.GananciaFacturaUnica = false;
            VariablesGlobales.ProductoHistorial = false;
            btnDescartarProducto.Enabled = false;

            lbCantidadFacturada.Visible = false;
            txtCantidadFacturada.Visible = false;
            lbCantidadProcesar.Visible = false;
            txtCantidadProcesar.Visible = false;
            lbClaveSeguridad.Visible = false;
            txtClaveSeguridad.Visible = false;
            btnDescartarProducto.Enabled = false;
            lbCantidadDisponible.Visible = false;
            txtCantidadDisponible.Visible = false;
            txtCantidadFacturada.Enabled = false;
            txtCantidadDisponible.Enabled = false;
        }
        #endregion
        #region GENERAR GAANANCIA DE VENTA
        private void GenerarGananciaVenta()
        {
            try {
                DSMarket.Logica.Entidades.EntidadesConfiguracion.EProcesarInformacionGanancia Eliminar = new Logica.Entidades.EntidadesConfiguracion.EProcesarInformacionGanancia();
                Eliminar.IdUsuario = VariablesGlobales.IdUsuario;
                var MAnElimianr = ObjdataConfiguracion.Value.ProcesarInformacionGanancia(Eliminar, "DELETE");

                if (cbNoagregarRangofecha.Checked)
                {
                    if (rbGenerar.Checked) {
                        string _NombreCliente = string.IsNullOrEmpty(txtParametro.Text.Trim()) ? null : txtParametro.Text.Trim();

                        var BuscarRegistros = ObhDataServicio.Value.GenerarGananciaVenta(
                            new Nullable<decimal>(),
                            null,
                            null, null, null, _NombreCliente,
                            Convert.ToDateTime(txtFechaDesde.Text),
                            Convert.ToDateTime(txtFechaHasta.Text));
                        foreach (var n in BuscarRegistros) {
                            DSMarket.Logica.Comunes.ProcesarGananciaVenta ProcesarGanancia = new Logica.Comunes.ProcesarGananciaVenta(
                                VariablesGlobales.IdUsuario,
                                Convert.ToDecimal(n.IdEstatusFacturacion),
                                n.Estatus,
                                Convert.ToDecimal(n.IdFactura),
                                n.DescripcionProducto,
                                n.Acumulativo,
                                Convert.ToDecimal(n.IdCategoria),
                                n.Categoria,
                                n.TipoProducto,
                                Convert.ToDecimal(n.PrecioCompra),
                                Convert.ToDecimal(n.PrecioVenta),
                                Convert.ToInt32(n.CantidadVendida),
                                Convert.ToDecimal(n.DescuentoAplicado),
                                Convert.ToDecimal(n.TotalVenta),
                                Convert.ToDecimal(n.TotalPrecioCompra),
                                Convert.ToDecimal(n.Ganancia),
                                "INSERT");
                            ProcesarGanancia.ProcesarGanancia();
                        }

                    }
                    else if (rbNumero.Checked) {
                        if (string.IsNullOrEmpty(txtParametro.Text.Trim()))
                        {
                            MessageBox.Show("Favr de ingresar el numero de Factura / Cotización para buscar registros", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else {

                            var BuscarRegistros = ObhDataServicio.Value.GenerarGananciaVenta(
                          Convert.ToDecimal(txtParametro.Text),
                          null, null, null, null, null,
                          Convert.ToDateTime(txtFechaDesde.Text),
                          Convert.ToDateTime(txtFechaHasta.Text));
                            foreach (var n in BuscarRegistros)
                            {
                                DSMarket.Logica.Comunes.ProcesarGananciaVenta ProcesarGanancia = new Logica.Comunes.ProcesarGananciaVenta(
                                    VariablesGlobales.IdUsuario,
                                    Convert.ToDecimal(n.IdEstatusFacturacion),
                                    n.Estatus,
                                    Convert.ToDecimal(n.IdFactura),
                                    n.DescripcionProducto,
                                    n.Acumulativo,
                                    Convert.ToDecimal(n.IdCategoria),
                                    n.Categoria,
                                    n.TipoProducto,
                                    Convert.ToDecimal(n.PrecioCompra),
                                    Convert.ToDecimal(n.PrecioVenta),
                                    Convert.ToInt32(n.CantidadVendida),
                                    Convert.ToDecimal(n.DescuentoAplicado),
                                    Convert.ToDecimal(n.TotalVenta),
                                    Convert.ToDecimal(n.TotalPrecioCompra),
                                    Convert.ToDecimal(n.Ganancia),
                                    "INSERT");
                                ProcesarGanancia.ProcesarGanancia();
                            }

                        }
                    }
                    else if (rbEstatus.Checked) {
                        var BuscarRegistros = ObhDataServicio.Value.GenerarGananciaVenta(
                        new Nullable<decimal>(), null,
                        Convert.ToDecimal(ddlSeleccionar.SelectedValue),
                         null, null, null,
                        Convert.ToDateTime(txtFechaDesde.Text),
                        Convert.ToDateTime(txtFechaHasta.Text));
                        foreach (var n in BuscarRegistros)
                        {
                            DSMarket.Logica.Comunes.ProcesarGananciaVenta ProcesarGanancia = new Logica.Comunes.ProcesarGananciaVenta(
                                VariablesGlobales.IdUsuario,
                                Convert.ToDecimal(n.IdEstatusFacturacion),
                                n.Estatus,
                                Convert.ToDecimal(n.IdFactura),
                                n.DescripcionProducto,
                                n.Acumulativo,
                                Convert.ToDecimal(n.IdCategoria),
                                n.Categoria,
                                n.TipoProducto,
                                Convert.ToDecimal(n.PrecioCompra),
                                Convert.ToDecimal(n.PrecioVenta),
                                Convert.ToInt32(n.CantidadVendida),
                                Convert.ToDecimal(n.DescuentoAplicado),
                                Convert.ToDecimal(n.TotalVenta),
                                Convert.ToDecimal(n.TotalPrecioCompra),
                                Convert.ToDecimal(n.Ganancia),
                                "INSERT");
                            ProcesarGanancia.ProcesarGanancia();
                        }
                    }
                    else if (rbTipoFacturacion.Checked) {
                        var BuscarRegistros = ObhDataServicio.Value.GenerarGananciaVenta(
                       new Nullable<decimal>(), null,
                       null,
                       Convert.ToDecimal(ddlSeleccionar.SelectedValue),
                       null,
                       null,
                       Convert.ToDateTime(txtFechaDesde.Text),
                       Convert.ToDateTime(txtFechaHasta.Text));
                        foreach (var n in BuscarRegistros)
                        {
                            DSMarket.Logica.Comunes.ProcesarGananciaVenta ProcesarGanancia = new Logica.Comunes.ProcesarGananciaVenta(
                                VariablesGlobales.IdUsuario,
                                Convert.ToDecimal(n.IdEstatusFacturacion),
                                n.Estatus,
                                Convert.ToDecimal(n.IdFactura),
                                n.DescripcionProducto,
                                n.Acumulativo,
                                Convert.ToDecimal(n.IdCategoria),
                                n.Categoria,
                                n.TipoProducto,
                                Convert.ToDecimal(n.PrecioCompra),
                                Convert.ToDecimal(n.PrecioVenta),
                                Convert.ToInt32(n.CantidadVendida),
                                Convert.ToDecimal(n.DescuentoAplicado),
                                Convert.ToDecimal(n.TotalVenta),
                                Convert.ToDecimal(n.TotalPrecioCompra),
                                Convert.ToDecimal(n.Ganancia),
                                "INSERT");
                            ProcesarGanancia.ProcesarGanancia();
                        }
                    }
                    else if (rbTipoPago.Checked) {
                        var BuscarRegistros = ObhDataServicio.Value.GenerarGananciaVenta(
                     new Nullable<decimal>(), null,
                     null,
                     null,
                     Convert.ToDecimal(ddlSeleccionar.SelectedValue),
                     null,
                     Convert.ToDateTime(txtFechaDesde.Text),
                     Convert.ToDateTime(txtFechaHasta.Text));
                        foreach (var n in BuscarRegistros)
                        {
                            DSMarket.Logica.Comunes.ProcesarGananciaVenta ProcesarGanancia = new Logica.Comunes.ProcesarGananciaVenta(
                                VariablesGlobales.IdUsuario,
                                Convert.ToDecimal(n.IdEstatusFacturacion),
                                n.Estatus,
                                Convert.ToDecimal(n.IdFactura),
                                n.DescripcionProducto,
                                n.Acumulativo,
                                Convert.ToDecimal(n.IdCategoria),
                                n.Categoria,
                                n.TipoProducto,
                                Convert.ToDecimal(n.PrecioCompra),
                                Convert.ToDecimal(n.PrecioVenta),
                                Convert.ToInt32(n.CantidadVendida),
                                Convert.ToDecimal(n.DescuentoAplicado),
                                Convert.ToDecimal(n.TotalVenta),
                                Convert.ToDecimal(n.TotalPrecioCompra),
                                Convert.ToDecimal(n.Ganancia),
                                "INSERT");
                            ProcesarGanancia.ProcesarGanancia();
                        }
                    }
                    else { MessageBox.Show("Seleccionar una Opción", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                }
                //dDDDDDDDDDDD
                else {
                    if (rbGenerar.Checked)
                    {
                        string _NombreCliente = string.IsNullOrEmpty(txtParametro.Text.Trim()) ? null : txtParametro.Text.Trim();

                        var BuscarRegistros = ObhDataServicio.Value.GenerarGananciaVenta(
                            new Nullable<decimal>(), null,
                            null, null, null, _NombreCliente,
                            null,
                            null);
                        foreach (var n in BuscarRegistros)
                        {
                            DSMarket.Logica.Comunes.ProcesarGananciaVenta ProcesarGanancia = new Logica.Comunes.ProcesarGananciaVenta(
                                VariablesGlobales.IdUsuario,
                                Convert.ToDecimal(n.IdEstatusFacturacion),
                                n.Estatus,
                                Convert.ToDecimal(n.IdFactura),
                                n.DescripcionProducto,
                                n.Acumulativo,
                                Convert.ToDecimal(n.IdCategoria),
                                n.Categoria,
                                n.TipoProducto,
                                Convert.ToDecimal(n.PrecioCompra),
                                Convert.ToDecimal(n.PrecioVenta),
                                Convert.ToInt32(n.CantidadVendida),
                                Convert.ToDecimal(n.DescuentoAplicado),
                                Convert.ToDecimal(n.TotalVenta),
                                Convert.ToDecimal(n.TotalPrecioCompra),
                                Convert.ToDecimal(n.Ganancia),
                                "INSERT");
                            ProcesarGanancia.ProcesarGanancia();
                        }

                    }
                    else if (rbNumero.Checked)
                    {
                        if (string.IsNullOrEmpty(txtParametro.Text.Trim()))
                        {
                            MessageBox.Show("Favr de ingresar el numero de Factura / Cotización para buscar registros", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {

                            var BuscarRegistros = ObhDataServicio.Value.GenerarGananciaVenta(
                          Convert.ToDecimal(txtParametro.Text),
                          null, null, null, null,
                         null,
                          null);
                            foreach (var n in BuscarRegistros)
                            {
                                DSMarket.Logica.Comunes.ProcesarGananciaVenta ProcesarGanancia = new Logica.Comunes.ProcesarGananciaVenta(
                                    VariablesGlobales.IdUsuario,
                                    Convert.ToDecimal(n.IdEstatusFacturacion),
                                    n.Estatus,
                                    Convert.ToDecimal(n.IdFactura),
                                    n.DescripcionProducto,
                                    n.Acumulativo,
                                    Convert.ToDecimal(n.IdCategoria),
                                    n.Categoria,
                                    n.TipoProducto,
                                    Convert.ToDecimal(n.PrecioCompra),
                                    Convert.ToDecimal(n.PrecioVenta),
                                    Convert.ToInt32(n.CantidadVendida),
                                    Convert.ToDecimal(n.DescuentoAplicado),
                                    Convert.ToDecimal(n.TotalVenta),
                                    Convert.ToDecimal(n.TotalPrecioCompra),
                                    Convert.ToDecimal(n.Ganancia),
                                    "INSERT");
                                ProcesarGanancia.ProcesarGanancia();
                            }
                        }
                    }
                    else if (rbEstatus.Checked)
                    {
                        var BuscarRegistros = ObhDataServicio.Value.GenerarGananciaVenta(
                        new Nullable<decimal>(),
                        Convert.ToDecimal(ddlSeleccionar.SelectedValue),
                         null, null, null,
                        null,
                        null);
                        foreach (var n in BuscarRegistros)
                        {
                            DSMarket.Logica.Comunes.ProcesarGananciaVenta ProcesarGanancia = new Logica.Comunes.ProcesarGananciaVenta(
                                VariablesGlobales.IdUsuario,
                                Convert.ToDecimal(n.IdEstatusFacturacion),
                                n.Estatus,
                                Convert.ToDecimal(n.IdFactura),
                                n.DescripcionProducto,
                                n.Acumulativo,
                                Convert.ToDecimal(n.IdCategoria),
                                n.Categoria,
                                n.TipoProducto,
                                Convert.ToDecimal(n.PrecioCompra),
                                Convert.ToDecimal(n.PrecioVenta),
                                Convert.ToInt32(n.CantidadVendida),
                                Convert.ToDecimal(n.DescuentoAplicado),
                                Convert.ToDecimal(n.TotalVenta),
                                Convert.ToDecimal(n.TotalPrecioCompra),
                                Convert.ToDecimal(n.Ganancia),
                                "INSERT");
                            ProcesarGanancia.ProcesarGanancia();
                        }
                    }
                    else if (rbTipoFacturacion.Checked)
                    {
                        var BuscarRegistros = ObhDataServicio.Value.GenerarGananciaVenta(
                       new Nullable<decimal>(),
                       null,
                       Convert.ToDecimal(ddlSeleccionar.SelectedValue),
                       null,
                       null,
                       null,
                       null);
                        foreach (var n in BuscarRegistros)
                        {
                            DSMarket.Logica.Comunes.ProcesarGananciaVenta ProcesarGanancia = new Logica.Comunes.ProcesarGananciaVenta(
                                VariablesGlobales.IdUsuario,
                                Convert.ToDecimal(n.IdEstatusFacturacion),
                                n.Estatus,
                                Convert.ToDecimal(n.IdFactura),
                                n.DescripcionProducto,
                                n.Acumulativo,
                                Convert.ToDecimal(n.IdCategoria),
                                n.Categoria,
                                n.TipoProducto,
                                Convert.ToDecimal(n.PrecioCompra),
                                Convert.ToDecimal(n.PrecioVenta),
                                Convert.ToInt32(n.CantidadVendida),
                                Convert.ToDecimal(n.DescuentoAplicado),
                                Convert.ToDecimal(n.TotalVenta),
                                Convert.ToDecimal(n.TotalPrecioCompra),
                                Convert.ToDecimal(n.Ganancia),
                                "INSERT");
                            ProcesarGanancia.ProcesarGanancia();
                        }
                    }
                    else if (rbTipoPago.Checked)
                    {
                        var BuscarRegistros = ObhDataServicio.Value.GenerarGananciaVenta(
                     new Nullable<decimal>(),
                     null,
                     null,
                     Convert.ToDecimal(ddlSeleccionar.SelectedValue),
                     null,
                     null,
                     null);
                        foreach (var n in BuscarRegistros)
                        {
                            DSMarket.Logica.Comunes.ProcesarGananciaVenta ProcesarGanancia = new Logica.Comunes.ProcesarGananciaVenta(
                                VariablesGlobales.IdUsuario,
                                Convert.ToDecimal(n.IdEstatusFacturacion),
                                n.Estatus,
                                Convert.ToDecimal(n.IdFactura),
                                n.DescripcionProducto,
                                n.Acumulativo,
                                Convert.ToDecimal(n.IdCategoria),
                                n.Categoria,
                                n.TipoProducto,
                                Convert.ToDecimal(n.PrecioCompra),
                                Convert.ToDecimal(n.PrecioVenta),
                                Convert.ToInt32(n.CantidadVendida),
                                Convert.ToDecimal(n.DescuentoAplicado),
                                Convert.ToDecimal(n.TotalVenta),
                                Convert.ToDecimal(n.TotalPrecioCompra),
                                Convert.ToDecimal(n.Ganancia),
                                "INSERT");
                            ProcesarGanancia.ProcesarGanancia();
                        }
                    }
                    else { MessageBox.Show("Seleccionar una Opción", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                }

                //INVOCAMOS EL REPORTE
              string RutaReporte = "";
              string UsuarioBD = "";
              string ClaveBD = "";
                //SACAMOS LA RUTA DEL REPORTE
                var SacarRutaReporte = ObjdataConfiguracion.Value.BuscaRutaReporte(4);
                foreach (var n in SacarRutaReporte) {
                    RutaReporte = n.RutaReporte;
                }

                //SACAR LAS CREDENCIALES DE BD
                var SacarCredenciales = ObjDataSeguridad.Value.SacarCredencialBD(1);
                foreach (var n2 in SacarCredenciales) {
                    UsuarioBD = n2.Usuario;
                    ClaveBD = DSMarket.Logica.Comunes.SeguridadEncriptacion.DesEncriptar(n2.Clave);
                }

                //INVOCAMOS
                DSMarket.Solucion.Pantallas.Pantallas.Reportes.Reportes ReporteGanancia = new Reportes.Reportes();

                ReporteGanancia.GenerarReporteGananciaVenta(VariablesGlobales.IdUsuario, RutaReporte, UsuarioBD, ClaveBD);
                ReporteGanancia.ShowDialog();
            }
            catch (Exception ex) {
                MessageBox.Show("Error al generar las estadisticas de facturación, codigo de error: " + ex.Message, VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        private void HistorialFActuracion_Load(object sender, EventArgs e)
        {
            VariablesGlobales.ProductoHistorial = false;
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
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

            decimal IdNivelAcceso = DSMarket.Logica.Comunes.ValidarNivelUsuario.ValidarNivelAccesoUsuario(VariablesGlobales.IdUsuario);
            if (IdNivelAcceso == 3) {
                btnReporte.Visible = false;
                btnEstadistica.Visible = false;
                btnAnular.Visible = false;
                btnProductos.Visible = false;
                btnDescartarProducto.Visible = false;
            }
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
            Anular.VariablesGlobales.IdMantenimeinto = VariablesGlobales.IdMantenimeinto;
            Anular.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
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
            if (VariablesGlobales.ProductoHistorial == false)
            {
                if (MessageBox.Show("¿Quieres seleccionar este registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
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

                    if (VariablesGlobales.IdEstatusFacturacionHistorial == 2)
                    {
                        btnFacturar.Enabled = true;
                    }

                    var ValidarFacturaAnulada = ObhDataServicio.Value.ValidarFacturaAnulada(VariablesGlobales.NumeroConector);
                    if (ValidarFacturaAnulada.Count() < 1)
                    {
                        btnAnular.Enabled = true;
                        btnModificarDiasGarantia.Enabled = true;
                    }
                    else
                    {
                        btnAnular.Enabled = false;
                        btnModificarDiasGarantia.Enabled = false;
                    }

                    var BuscarRegistro = ObhDataServicio.Value.HistorialFacturacion(
               new Nullable<decimal>(),
               VariablesGlobales.NumeroConector,
               null, null, null, null, null, null, 1, 1000);
                    dtListado.DataSource = BuscarRegistro;
                    OcultarColumnas();
                    VariablesGlobales.GananciaFacturaUnica = true;
                }
               

           

            }
            else {
                //ESTE BLOQUE ES PARA CUANDO SE NECESITE 
                if (MessageBox.Show("¿Quieres seleccionar este registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                    this.VariablesGlobales.IdMantenimeinto = Convert.ToDecimal(this.dtListado.CurrentRow.Cells["IdTipoProducto"].Value.ToString());
                    this.VariablesGlobales.NumeroConector = Convert.ToDecimal(this.dtListado.CurrentRow.Cells["NumeroConector"].Value.ToString());

                    var BuscarRegistro = ObhDataServicio.Value.BuscapRoductosAgregados(
                        VariablesGlobales.IdMantenimeinto,
                        VariablesGlobales.NumeroConector);
                    dtListado.DataSource = BuscarRegistro;
                    dtListado.Columns["IdTipoProducto"].Visible = false;
                    dtListado.Columns["IdCategoria"].Visible = false;
                    dtListado.Columns["DescripcionTipoProducto1"].Visible = false;
                    dtListado.Columns["IdProducto"].Visible = false;
                    dtListado.Columns["ConectorProducto"].Visible = false;
                    dtListado.Columns["PorcientoImpuesto"].Visible = false;
                    lbCantidadFacturada.Visible = true;
                    txtCantidadFacturada.Visible = true;
                    lbCantidadProcesar.Visible = true;
                    txtCantidadProcesar.Visible = true;
                    lbClaveSeguridad.Visible = true;
                    txtClaveSeguridad.Visible = true;
                    btnDescartarProducto.Enabled = true;
                    lbCantidadDisponible.Visible = true;
                    txtCantidadDisponible.Visible = true;
                    txtCantidadFacturada.Enabled = false;
                    txtCantidadDisponible.Enabled = false;
                    string ProductoAcumulativo = "";

                    foreach (var n in BuscarRegistro) {
                        txtCantidadFacturada.Text = n.Cantidad.ToString();
                        txtCantidadProcesar.Text = "1";
                        ProductoAcumulativo = n.Acumulativo;
                    }
                    if (ProductoAcumulativo == "SI") {
                        txtCantidadProcesar.Enabled = true;
                    }
                    else {
                        txtCantidadProcesar.Enabled = false;
                    }
                }

                int CantidadDIsponibleAlmacen = 0;
                var SacarCantidadDisponible = ObjDataInventario.Value.BuscaProductos(
                    VariablesGlobales.IdMantenimeinto,
                    null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, 1, 1);
                foreach (var n in SacarCantidadDisponible) {
                    CantidadDIsponibleAlmacen = Convert.ToInt32(n.Stock);
                    txtCantidadDisponible.Text = CantidadDIsponibleAlmacen.ToString("N0");
                    VariablesGlobales.NumeroConectorSeleccionadoAgregarPorpductos = Convert.ToDecimal(n.NumeroConector);
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
            if (cbFacturaPuntoVenta.Checked) {
                //IMPRIMIMOS A PUNTO DE VENTA
                if (rbfacturaspanish.Checked == true)
                {

                    var SacarRutaReporte = ObjdataConfiguracion.Value.BuscaRutaReporte(7);
                    foreach (var n in SacarRutaReporte)
                    {
                        RutaReporte = n.RutaReporte;
                    }

                    DSMarket.Solucion.Pantallas.Pantallas.Reportes.Reportes Invocar = new Reportes.Reportes();
                    Invocar.GenerarFacturaVenta(VariablesGlobales.IdMantenimeinto, RutaReporte, UsuarioBD, ClaveBD);
                    Invocar.ShowDialog();
                }
                else if (rbfacturaenglish.Checked == true)
                {

                    var SacarRutaReporte = ObjdataConfiguracion.Value.BuscaRutaReporte(8);
                    foreach (var n in SacarRutaReporte)
                    {
                        RutaReporte = n.RutaReporte;
                    }

                    DSMarket.Solucion.Pantallas.Pantallas.Reportes.Reportes Invocar = new Reportes.Reportes();
                    Invocar.GenerarFacturaVenta(VariablesGlobales.IdMantenimeinto, RutaReporte, UsuarioBD, ClaveBD);
                    Invocar.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Selecciona una opción para poder imprimir", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else {
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
                else if (rbfacturaenglish.Checked == true)
                {

                    var SacarRutaReporte = ObjdataConfiguracion.Value.BuscaRutaReporte(2);
                    foreach (var n in SacarRutaReporte)
                    {
                        RutaReporte = n.RutaReporte;
                    }

                    DSMarket.Solucion.Pantallas.Pantallas.Reportes.Reportes Invocar = new Reportes.Reportes();
                    Invocar.GenerarFacturaVenta(VariablesGlobales.IdMantenimeinto, RutaReporte, UsuarioBD, ClaveBD);
                    Invocar.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Selecciona una opción para poder imprimir", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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
            VariablesGlobales.ProductoHistorial = true;
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            RestablecerPantalla();

            
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            GenerarReporteVenta();
        }

        private void btnEstadistica_Click(object sender, EventArgs e)
        {
            GenerarGananciaVenta();

        }

        private void txtCantidadProcesar_KeyPress(object sender, KeyPressEventArgs e)
        {
            DSMarket.Logica.Comunes.ValidarControles.SoloNumeros(e);
        }

        private void btnDescartarProducto_Click(object sender, EventArgs e)
        {
            //VALIDAMOS LA CLAVE DE SEGURIDAD
            if (string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()))
            {
                MessageBox.Show("El campo clave de seguridad no puede estar vacio para descartar este producto", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()))
                {
                    errorProvider1.SetError(txtClaveSeguridad, "Campo Vacio");
                }
            }
            else {
                //VALIDAMOS LA CLAVE DE SEGURIDAD
                string _ClaveSeguridad = string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()) ? null : txtClaveSeguridad.Text.Trim();

                var ValidarClave = ObjDataSeguridad.Value.BuscaClaveSeguridad(
                    new Nullable<decimal>(),
                    null,
                    DSMarket.Logica.Comunes.SeguridadEncriptacion.Encriptar(_ClaveSeguridad),
                    1, 1);
                if (ValidarClave.Count() < 1)
                {
                    MessageBox.Show("La clave de seguriad ingresada no es valida, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtClaveSeguridad.Text = string.Empty;
                    txtClaveSeguridad.Focus();
                }
                else {
                    //VALIDAMOS LA CANTIDAD A PROCESAR
                    if (string.IsNullOrEmpty(txtCantidadProcesar.Text.Trim()))
                    {
                        MessageBox.Show("La cantidad a procesar no puede estar vacia, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (string.IsNullOrEmpty(txtCantidadProcesar.Text.Trim())) {
                            errorProvider1.SetError(txtCantidadProcesar, "Campo Vacio");
                        }
                    }
                    else {
                        //PEPITO
                        int CantidadFActurada = Convert.ToInt32(txtCantidadFacturada.Text);
                        int CantidadProcesar = Convert.ToInt32(txtCantidadProcesar.Text);
                        int CantidadAlmacen = Convert.ToInt32(txtCantidadDisponible.Text);

                        if (CantidadProcesar > CantidadFActurada)
                        {
                            MessageBox.Show("No es posible proceder con este proceso por que la cantidad que intentas procesar es mayor a la cantidad facturada, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else {
                            if (CantidadProcesar > CantidadAlmacen) {
                                MessageBox.Show("No es posible procesar esta operación por que la cantidad que intentas procesar supera la cantidad que se tiene en almacen, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else {
                                //PROCESAMOS
                                var BuscarRegistro = ObjDataInventario.Value.BuscaProductos(
                                    VariablesGlobales.IdMantenimeinto,
                                    null,
                                    null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, 1, 1);
                                bool ProductoSeleccionadoAcumulativo = false;
                                foreach (var n in BuscarRegistro)
                                {
                                    ProductoSeleccionadoAcumulativo = Convert.ToBoolean(n.ProductoAcumulativo0);
                                    DSMarket.Logica.Comunes.ProcesarProductosDefectuosos Procesar = new Logica.Comunes.ProcesarProductosDefectuosos(
                                        0,
                                        VariablesGlobales.NumeroConector,
                                        Convert.ToDecimal(n.IdTipoProducto),
                                        Convert.ToDecimal(n.IdCategoria),
                                        Convert.ToDecimal(n.IdUnidadMedida),
                                        Convert.ToDecimal(n.IdMarca),
                                        Convert.ToDecimal(n.IdModelo),
                                        Convert.ToDecimal(n.IdTipoSuplidor),
                                        Convert.ToDecimal(n.IdSuplidor),
                                        n.Producto,
                                        n.CodigoBarra,
                                        n.Referencia,
                                        Convert.ToDecimal(n.PrecioCompra),
                                        Convert.ToDecimal(n.PrecioVenta),
                                        Convert.ToDecimal(n.Stock),
                                        Convert.ToDecimal(n.StockMinimo),
                                        Convert.ToDecimal(n.PorcientoDescuento),
                                        Convert.ToBoolean(n.AfectaOferta0),
                                        Convert.ToBoolean(n.ProductoAcumulativo0),
                                        Convert.ToBoolean(n.LlevaImagen0),
                                        Convert.ToDecimal(n.UsuarioAdicion),
                                        Convert.ToDateTime(n.FechaAdiciona),
                                        Convert.ToDecimal(n.UsuarioModifica),
                                        Convert.ToDateTime(n.FechaModifica),
                                        Convert.ToDateTime(n.Fecha),
                                        n.Comentario,
                                        Convert.ToBoolean(n.AplicaParaImpuesto0),
                                        Convert.ToBoolean(n.EstatusProducto0),
                                        Convert.ToDecimal(txtCantidadProcesar.Text),
                                        n.NumeroSeguimiento,
                                        Convert.ToDecimal(n.IdColor),
                                        Convert.ToDecimal(n.IdCondicion),
                                        Convert.ToDecimal(n.IdCapacidad),
                                        "INSERT");
                                    Procesar.ProcesarInformaicon();
                                }

                                if (ProductoSeleccionadoAcumulativo == true) {
                                    //SACAMOS LOS PRODUCTOS DEL INVENTARIO
                                    DSMarket.Logica.Entidades.EntidadesInventario.EProducto Sacar = new Logica.Entidades.EntidadesInventario.EProducto();

                                    Sacar.IdProducto = VariablesGlobales.IdMantenimeinto;
                                    Sacar.NumeroConector = VariablesGlobales.NumeroConectorSeleccionadoAgregarPorpductos;
                                    Sacar.Stock = Convert.ToDecimal(txtCantidadProcesar.Text);

                                    var MAN = ObjDataInventario.Value.MantenimientoProducto(Sacar, "LESSPRODUCT");
                                }
                              

                                MessageBox.Show("Proceso completado exitosamente", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                RestablecerPantalla();
                            }
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Servicio.ModificarGarantiaFactura GarantiaEdtt = new ModificarGarantiaFactura();
            GarantiaEdtt.VariablesGlobales.IdMantenimeinto = VariablesGlobales.IdMantenimeinto;
            GarantiaEdtt.VariablesGlobales.NumeroConector = VariablesGlobales.NumeroConector;
            GarantiaEdtt.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            GarantiaEdtt.ShowDialog();
        }
    }
}
