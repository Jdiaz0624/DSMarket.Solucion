using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSMarket.Solucion.Pantallas.Pantallas.Servicio
{
    public partial class AnularFactura : Form 
    {
        public AnularFactura()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaServicio.LogicaServicio> ObjDataServicio = new Lazy<Logica.Logica.LogicaServicio.LogicaServicio>();
        Lazy<DSMarket.Logica.Logica.LogicaSeguridad.LogicaSeguridad> ObjDataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad.LogicaSeguridad>();
        Lazy<DSMarket.Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion> ObjDataConfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion>();
        Lazy<DSMarket.Logica.Logica.LogicaInventario.LogicaInventario> ObjDataInventario = new Lazy<Logica.Logica.LogicaInventario.LogicaInventario>();
        Lazy<DSMarket.Logica.Logica.LogicaCaja.LogicaCaja> ObjDataCaja = new Lazy<Logica.Logica.LogicaCaja.LogicaCaja>();
        Lazy<DSMarket.Logica.Logica.LogicaListas.LogicaListas> ObjDataListas = new Lazy<Logica.Logica.LogicaListas.LogicaListas>();
        Lazy<DSMarket.Logica.Logica.LogicaContabilidad.LogicaContabilidad> ObjdataContabilidad = new Lazy<Logica.Logica.LogicaContabilidad.LogicaContabilidad>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region APLICAR TEMA
        private void TemaGenerico()
        {
            this.BackColor = SystemColors.Control;

            txtTipoFacturacion.BackColor = Color.WhiteSmoke;
            txtNombreCliente.BackColor = Color.WhiteSmoke;
            txtTelefono.BackColor = Color.WhiteSmoke;
            txtTipoIdentificacion.BackColor = Color.WhiteSmoke;
            txtIdentificacion.BackColor = Color.WhiteSmoke;
            txtDireccion.BackColor = Color.WhiteSmoke;
            txtEmail.BackColor = Color.WhiteSmoke;
            txtFecha.BackColor = Color.WhiteSmoke;
            txtFaturadoPor.BackColor = Color.WhiteSmoke;
            txtCantidadArtiuclos.BackColor = Color.WhiteSmoke;
            txtCantidadServicios.BackColor = Color.WhiteSmoke;
            txtTotalDescuento.BackColor = Color.WhiteSmoke;
            txtSubtotal.BackColor = Color.WhiteSmoke;
            txtImpuesto.BackColor = Color.WhiteSmoke;
            txtTotal.BackColor = Color.WhiteSmoke;
            txtTipoPago.BackColor = Color.WhiteSmoke;
            txtMontoPagar.BackColor = Color.WhiteSmoke;
            txtcambio.BackColor = Color.WhiteSmoke;
            txtClaveSeguridad.BackColor = Color.WhiteSmoke;
            txtNumeroPagina.BackColor = Color.WhiteSmoke;
            txtNumeroRegistros.BackColor = Color.WhiteSmoke;

            txtTipoFacturacion.ForeColor = Color.Black;
            txtNombreCliente.ForeColor = Color.Black;
            txtTelefono.ForeColor = Color.Black;
            txtTipoIdentificacion.ForeColor = Color.Black;
            txtIdentificacion.ForeColor = Color.Black;
            txtDireccion.ForeColor = Color.Black;
            txtEmail.ForeColor = Color.Black;
            txtFecha.ForeColor = Color.Black;
            txtFaturadoPor.ForeColor = Color.Black;
            txtCantidadArtiuclos.ForeColor = Color.Black;
            txtCantidadServicios.ForeColor = Color.Black;
            txtTotalDescuento.ForeColor = Color.Black;
            txtSubtotal.ForeColor = Color.Black;
            txtImpuesto.ForeColor = Color.Black;
            txtTotal.ForeColor = Color.Black;
            txtTipoPago.ForeColor = Color.Black;
            txtMontoPagar.ForeColor = Color.Black;
            txtcambio.ForeColor = Color.Black;
            txtClaveSeguridad.ForeColor = Color.Black;
            txtNumeroPagina.ForeColor = Color.Black;
            txtNumeroRegistros.ForeColor = Color.Black;

            txtTipoFacturacion.Enabled = false;
            txtNombreCliente.Enabled = false;
            txtTelefono.Enabled = false;
            txtTipoIdentificacion.Enabled = false;
            txtIdentificacion.Enabled = false;
            txtDireccion.Enabled = false;
            txtEmail.Enabled = false;
            txtFecha.Enabled = false;
            txtFaturadoPor.Enabled = false;
            txtCantidadArtiuclos.Enabled = false;
            txtCantidadServicios.Enabled = false;
            txtTotalDescuento.Enabled = false;
            txtSubtotal.Enabled = false;
            txtImpuesto.Enabled = false;
            txtTotal.Enabled = false;
            txtTipoPago.Enabled = false;
            txtMontoPagar.Enabled = false;
            txtcambio.Enabled = false;

            dtListado.BackgroundColor = SystemColors.Control;
        }
        #endregion
        #region SACAR LA INFORMACION DE LA FACTURA
        private void SacarInformacionFactura(decimal IdFactura) {
            try {
                
                var SacarDatosFactura = ObjDataServicio.Value.HistorialFacturacion(IdFactura, null,
                    null, null, null, null, null, null, 1, 1);
                foreach (var n in SacarDatosFactura) {
                    txtTipoFacturacion.Text = n.EstatusFacturacion;
                    txtNombreCliente.Text = n.Cliente;
                    txtTelefono.Text = n.Telefono;
                    txtTipoIdentificacion.Text = n.TipoIdentificacion;
                    txtIdentificacion.Text = n.NumeroIdentificacion;
                    txtDireccion.Text = n.Direccion;
                    txtEmail.Text = n.Email;
                    txtFecha.Text = n.FechaFacturacion;
                    txtFaturadoPor.Text = n.CreadoPor;
                    int CantidadArticulos = Convert.ToInt32(n.CantidadProductos);
                    txtCantidadArtiuclos.Text = CantidadArticulos.ToString("N0");
                    int CantidadServicios = Convert.ToInt32(n.CantidadServicios);
                    txtCantidadServicios.Text = CantidadServicios.ToString("N0");
                    decimal TotalDescuento = Convert.ToDecimal(n.TotalDescuento);
                    decimal SubTotal = Convert.ToDecimal(n.SubTotal);
                    decimal Impuesto = Convert.ToDecimal(n.Impuesto);
                    decimal Total = Convert.ToDecimal(n.TotalGeneral);
                    decimal MontoPagado = Convert.ToDecimal(n.MontoPagado);
                    decimal Cambio = Convert.ToDecimal(n.Cambio);
                    txtTotalDescuento.Text = TotalDescuento.ToString("N2");
                    txtSubtotal.Text = SubTotal.ToString("N2");
                    txtImpuesto.Text = Impuesto.ToString("N2");
                    txtTotal.Text = Total.ToString("N2");
                    txtTipoPago.Text = n.TipoPago;
                    txtMontoPagar.Text = MontoPagado.ToString("N2");
                    txtcambio.Text = Cambio.ToString("N2");
                    txtComentario.Text = n.Comentario;
                    VariablesGlobales.NumeroConector = Convert.ToDecimal(n.NumeroConector);
                    VariablesGlobales.IdTipoIdentificacionAnularFactura = Convert.ToDecimal(n.IdTipoIdentificacion);
                    VariablesGlobales.NumeroIdentificacionAnularFactura = n.NumeroIdentificacion;
                    VariablesGlobales.IdTipoVentaAnularFactura = Convert.ToDecimal(n.IdTipoVenta);
                    VariablesGlobales.IdCantidadDiasAnularFactura = Convert.ToDecimal(n.IdCantidadDias);
                    VariablesGlobales.PorcientoDescuentoAnularFactura = Convert.ToInt32(n.PorcientoImpuesto);
                    VariablesGlobales.IdTipOpagoAnularFactura = Convert.ToDecimal(n.IdTipoPago);
                }

                var MostrarProductosAgregados = ObjDataServicio.Value.BuscapRoductosAgregados(
                    new Nullable<decimal>(),
                    VariablesGlobales.NumeroConector);
                dtListado.DataSource = MostrarProductosAgregados;
            
                this.dtListado.Columns["NumeroConector"].Visible = false;
                this.dtListado.Columns["IdTipoProducto"].Visible = false;
                this.dtListado.Columns["IdCategoria"].Visible = false;
                this.dtListado.Columns["DescripcionTipoProducto1"].Visible = false;
                this.dtListado.Columns["IdProducto"].Visible = false;
                this.dtListado.Columns["ConectorProducto"].Visible = false;

            }
            catch (Exception ex) {
                MessageBox.Show("Error al mostrar la informacion, codigo de error--> " + ex.Message, VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                  
            }
        }
        #endregion
        #region ELIMINAR FACTURACION CLIENTE
        private void FacturacionCliente(decimal NumeroConector,string Accion) {
            DSMarket.Logica.Entidades.EntidadesServicio.EFacturacionClientes Mantenimiento = new Logica.Entidades.EntidadesServicio.EFacturacionClientes();

            Mantenimiento.IdFactura = 0;
            Mantenimiento.NumeroConector = NumeroConector;
            Mantenimiento.IdEstatusFacturacion = 3;
            Mantenimiento.IdComprobante = 4;
            Mantenimiento.Nombre = txtNombreCliente.Text;
            Mantenimiento.Telefono = txtTelefono.Text;
            Mantenimiento.Email = txtEmail.Text;
            Mantenimiento.IdTipoIdentificacion = VariablesGlobales.IdTipoIdentificacionAnularFactura;
            Mantenimiento.NumeroIdentificacion = VariablesGlobales.NumeroIdentificacionAnularFactura;
            Mantenimiento.Direccion = txtDireccion.Text;
            Mantenimiento.Comentario = txtComentario.Text + "Anulación de la factura " + VariablesGlobales.IdMantenimeinto.ToString();
            Mantenimiento.IdTipoVenta = VariablesGlobales.IdTipoVentaAnularFactura;
            Mantenimiento.IdCantidadDias = VariablesGlobales.IdCantidadDiasAnularFactura;
            Mantenimiento.IdUsuario = VariablesGlobales.IdUsuario;
            Mantenimiento.FechaFacturacion = DateTime.Now;
            Mantenimiento.IdTipoAnulaicon = Convert.ToDecimal(ddlSeleccionarTipoAnulacion.SelectedValue);



            var MAN = ObjDataServicio.Value.GuardarFacturacionClientes(Mantenimiento, Accion);
        }
        #endregion
        #region ELIMINAR FACTURACION CALCULOS
        private void FacturacionCalculos(decimal NumeroConector,string Accion) {

            int CantidadProductos = Convert.ToInt32(txtCantidadArtiuclos.Text);
            int CantidadServicios = Convert.ToInt32(txtCantidadServicios.Text);
            int CantidadTotal = CantidadProductos + CantidadServicios;
            decimal TotalDescuento = Convert.ToDecimal(txtTotalDescuento.Text);
            decimal SubTotal = Convert.ToDecimal(txtSubtotal.Text);
            decimal Impuesto = Convert.ToDecimal(txtImpuesto.Text);
            decimal MontoPagar = Convert.ToDecimal(txtMontoPagar.Text);
            decimal Cambio = Convert.ToDecimal(txtcambio.Text);
            decimal Total = Convert.ToDecimal(txtTotal.Text);

            TotalDescuento = TotalDescuento * -1;
            SubTotal = SubTotal * -1;
            Impuesto = Impuesto * -1;
            MontoPagar = MontoPagar * -1;
            Cambio = Cambio * -1;
            Total = Total * -1;


            DSMarket.Logica.Entidades.EntidadesServicio.EGuardarFacturacionCalculos Mantenimiento = new Logica.Entidades.EntidadesServicio.EGuardarFacturacionCalculos();

            Mantenimiento.NumeroColector = NumeroConector;
            Mantenimiento.CantidadProductos = Convert.ToInt32(txtCantidadArtiuclos.Text);
            Mantenimiento.CantidadServicios = Convert.ToInt32(txtCantidadServicios.Text);
            Mantenimiento.CantidadArticulos = CantidadTotal;
            Mantenimiento.TotalDescuento = TotalDescuento;
            Mantenimiento.SubTotal = SubTotal;
            Mantenimiento.Impuesto = Impuesto;
            Mantenimiento.PorcientoImpuesto = VariablesGlobales.PorcientoDescuentoAnularFactura;
            Mantenimiento.MontoPagado = MontoPagar;
            Mantenimiento.Cambio = Cambio;
            Mantenimiento.IdTipoPago = VariablesGlobales.IdTipOpagoAnularFactura;
            Mantenimiento.TotalGeneral = Total;

            var MAn = ObjDataServicio.Value.GuardarFacturacionCalculos(Mantenimiento, Accion);
        }


        #endregion
        #region MANTENIMIENTO DE FACTURACION DE PRODUCTOS
        private void Productos(decimal NumeroConector, string Accion)
        {
            var BuscarProductos = ObjDataServicio.Value.BuscapRoductosAgregados(
                new Nullable<decimal>(),
                NumeroConector);
            foreach (var n in BuscarProductos) {
                DSMarket.Logica.Entidades.EntidadesServicio.EFacturacionProducto MantenimientoProducto = new Logica.Entidades.EntidadesServicio.EFacturacionProducto();

                MantenimientoProducto.NumeroConector = NumeroConector;
                MantenimientoProducto.IdTipoProducto = Convert.ToDecimal(n.IdTipoProducto);
                MantenimientoProducto.IdCategoria = Convert.ToDecimal(n.IdCategoria);
                MantenimientoProducto.DescripcionProducto = n.DescripcionProducto;
                MantenimientoProducto.CantidadVendida = Convert.ToInt32(n.Cantidad);
                MantenimientoProducto.Precio = Convert.ToDecimal(n.Precio);
                MantenimientoProducto.DescuentoAplicado = Convert.ToDecimal(n.DescuentoAplicado);
                MantenimientoProducto.DescripcionTipoProducto = n.DescripcionTipoProducto;
                MantenimientoProducto.PorcientoDescuento = Convert.ToInt32(n.PorcientoDescuento);
                MantenimientoProducto.IdProducto = Convert.ToDecimal(n.IdProducto);
                MantenimientoProducto.Acumulativo = n.Acumulativo;
                MantenimientoProducto.ConectorProducto = Convert.ToDecimal(n.ConectorProducto);
                MantenimientoProducto.Impuesto = Convert.ToDecimal(n.Impuesto);


                var MAN = ObjDataServicio.Value.GuardarFacturacionProductos(MantenimientoProducto, Accion);
            }


     
        }
        #endregion
        #region AFECTAR COMPROBANTE FISCAL

        private void AfectarComprobanteFiscal()
        {
            //VALIDAMOS SI LOS COMPROBANTES ESTAN ACTIVOS
            bool EstatusComprobante = false;

            var ValidarComprobante = ObjDataConfiguracion.Value.BuscaCOnfiguracionGeneral(1);
            foreach (var n in ValidarComprobante)
            {
                EstatusComprobante = Convert.ToBoolean(n.Estatus0);
            }
            if (EstatusComprobante == true)
            {
                //AFECTAMOS LOS COMPROBANTES
                decimal IdFacturaSacada = 0;
                string DescripcionComprobanteSacada = "";
                string NumeroComprobante = "";
                //1- SACAMOS EL NUMERO DE LA FACTURA
                var SacarnumeroFactura = ObjDataServicio.Value.SacarNumeroFactura(VariablesGlobales.NumeroConector);
                foreach (var ns in SacarnumeroFactura)
                {
                    IdFacturaSacada = Convert.ToDecimal(ns.IdFactura);
                }

                //2- SACAMOS LA DESCRIPCION DEL COMPROBANTE Y EL NUMERO DE COMPROBANTE
                var GenerarComprobanteFiscal = ObjDataConfiguracion.Value.GenerarComprobante(4);
                foreach (var n3 in GenerarComprobanteFiscal)
                {
                    DescripcionComprobanteSacada = n3.TipoComprobante;
                    NumeroComprobante = n3.Comprobante;
                }

                DSMarket.Logica.Entidades.EntidadesServicio.EGuardarFacturacionComprobantes Afectar = new Logica.Entidades.EntidadesServicio.EGuardarFacturacionComprobantes();

                Afectar.IdFacturacion = IdFacturaSacada;
                Afectar.NumeroConector = VariablesGlobales.NumeroConector;
                Afectar.DescripcionComprobante = DescripcionComprobanteSacada;
                Afectar.Comprobante = NumeroComprobante;

                var MAN = ObjDataServicio.Value.GuardarFacturacionComprobante(Afectar, "INSERT");

            }
            else if (EstatusComprobante == false) { }

        }
        #endregion
        #region MODIFICAR EL STOCK DE LA FACTURA
        private void ModificarStockproducto(decimal IdProducto, decimal NumeroConector, int Stock, string Accion)
        {
            DSMarket.Logica.Entidades.EntidadesInventario.EProducto Alterar = new Logica.Entidades.EntidadesInventario.EProducto();

            Alterar.IdProducto = IdProducto;
            Alterar.NumeroConector = NumeroConector;
            Alterar.Stock = Stock;

            var MAn = ObjDataInventario.Value.MantenimientoProducto(Alterar, Accion);
        }
        #endregion
        #region GENERAR LA FACTURA
        private void GenerarFacturaVenta()
        {
            try
            {
                decimal IdFactura = 0;
                string RutaReporte = "";
                string UsuarioBD = "";
                string ClaveBD = "";

                //SACAMOS EL NUMERO DE LA FACTURA
                var SacarNumeroFactura = ObjDataServicio.Value.SacarNumeroFactura(VariablesGlobales.NumeroConector);
                foreach (var n in SacarNumeroFactura)
                {
                    IdFactura = Convert.ToDecimal(n.IdFactura);
                }

                //SACAMOS LA RUTA DEL REPORTE DEPENDIENDO LA SELECCIONADO
                //if (rbfacturaspanish.Checked == true)
                //{
                    var SacarRutaReporte = ObjDataConfiguracion.Value.BuscaRutaReporte(1);
                    foreach (var n in SacarRutaReporte)
                    {
                        RutaReporte = n.RutaReporte;
                    }
               // }
                //else if (rbfacturaenglish.Checked == true)
                //{
                //    var SacarRutaReporte = ObjDataConfiguracion.Value.BuscaRutaReporte(2);
                //    foreach (var n in SacarRutaReporte)
                //    {
                //        RutaReporte = n.RutaReporte;
                //    }
                //}

                //SACAMOS LAS CREDENCIALES DE LAS BASES DE DATOS
                var SacarCredencialesBD = ObjDataSeguridad.Value.SacarCredencialBD(1);
                foreach (var n in SacarCredencialesBD)
                {
                    UsuarioBD = n.Usuario;
                    ClaveBD = DSMarket.Logica.Comunes.SeguridadEncriptacion.DesEncriptar(n.Clave);
                }

                //INVOCAMOS LA FACTURA
                DSMarket.Solucion.Pantallas.Pantallas.Reportes.Reportes FacturaVenta = new Reportes.Reportes();
                FacturaVenta.GenerarFacturaVenta(IdFactura, RutaReporte, UsuarioBD, ClaveBD);
                FacturaVenta.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar la factura, codigo de error--> " + ex.Message, VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region AFECTAR LA CAJA
        private void AfectarCaja()
        {
            decimal Monto = Convert.ToDecimal(txtTotal.Text);
            Monto = Monto * -1;

            DSMarket.Logica.Entidades.EntidadesCaja.EHistorialCaja MantenimientoCaja = new Logica.Entidades.EntidadesCaja.EHistorialCaja();

            MantenimientoCaja.IdHistorialCaja = 0;
            MantenimientoCaja.IdCaja = 1;
            MantenimientoCaja.Monto = Monto;
            MantenimientoCaja.Concepto = "ANULACION DE LA FACTURA " + VariablesGlobales.IdMantenimeinto.ToString();
            MantenimientoCaja.Fecha0 = DateTime.Now;
            MantenimientoCaja.IdUsuario = VariablesGlobales.IdUsuario;
            MantenimientoCaja.NumeroReferencia = VariablesGlobales.NumeroConector;
            MantenimientoCaja.IdTipoPago = VariablesGlobales.IdTipoProductoAnularFactura;

            var MAN = ObjDataCaja.Value.MantenimientoHistorialCaja(MantenimientoCaja, "INSERT");
        }

        private void IngresarSacarDinero(string Accion)
        {
            try
            {
                decimal Monto = Convert.ToDecimal(txtTotal.Text);

                DSMarket.Logica.Entidades.EntidadesCaja.ECajaGeneral AbrirCerrar = new Logica.Entidades.EntidadesCaja.ECajaGeneral();

                AbrirCerrar.IdCaja = 1;
                AbrirCerrar.Caja = "Caja General";
                AbrirCerrar.MontoActual = Monto;
                AbrirCerrar.Estatus0 = true;

                var MAN = ObjDataCaja.Value.AfectarCaja(AbrirCerrar, Accion);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir o cerrar caja, codigo de error --> " + ex.Message, VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region MOSTRAR EL LISTADO DE LOS TIPOS DE ANULACIONES
        private void MostrarListadoTipoAnulaciones() {
            var ListadoAnulaciones = ObjDataListas.Value.ListadoTipoAnulaciones();
            ddlSeleccionarTipoAnulacion.DataSource = ListadoAnulaciones;
            ddlSeleccionarTipoAnulacion.DisplayMember = "Descripcion";
            ddlSeleccionarTipoAnulacion.ValueMember = "IdTipoAnulacion";
        }
        #endregion
        #region AFECTAR LAS CUENTAS CONTABLES
        private void AfectarCuentasContablesDebitos() {
            //SACAMOS EL AñO DE LA ANULACION
            string AnoActual = DateTime.Now.Year.ToString();
            string Mes = DateTime.Now.Month.ToString();
            int Digitomes = Mes.Length;
            string MesActual = "";
            if (Digitomes == 1) {
                MesActual = "0" + Mes;
            }
            else {
                MesActual = Mes;
            }


            int IdTipoCuentaDebito = 0;
            int IdorigenCuentaDebito = 0;
            int IdClaseCuentaDebito = 0;
            int IdCuentaCatalogoCuenta = 0;
            string CuentaDebito = "";
            string AuxiliarDebito = "";
            decimal IdBanco = 0;
           

            var SacarDatosCuentas = ObjdataContabilidad.Value.BuscaCatalogoCuentas(8, null, null, null, null, 1, 1);
            foreach (var nCatalogo in SacarDatosCuentas) {
                IdTipoCuentaDebito = Convert.ToInt32(nCatalogo.IdTipoCuenta);
                IdorigenCuentaDebito = Convert.ToInt32(nCatalogo.IdOrigenCuenta);
                IdClaseCuentaDebito = Convert.ToInt32(nCatalogo.IdClaseCuenta);
                IdCuentaCatalogoCuenta = Convert.ToInt32(nCatalogo.IdRegistro);
                CuentaDebito = nCatalogo.Cuenta;
                AuxiliarDebito = nCatalogo.Auxiliar;
            }

            //SACAMOS EL COIGO DEL BANCO
            var SacarInformacionBanco = ObjdataContabilidad.Value.BuscaBancos(
                new Nullable<decimal>(), null, true, 1, 1);
            foreach (var nBanco in SacarInformacionBanco) {
                IdBanco = Convert.ToDecimal(nBanco.IdBanco);
            }

            decimal MontoPagar = Convert.ToDecimal(txtMontoPagar.Text);
            decimal Valor = MontoPagar * -1;

            string Concepto = DSMarket.Logica.Comunes.ObtenerValores.SacarConceptoCuenta(6);
            decimal NumeroRelacionado = DSMarket.Logica.Comunes.ObtenerValores.SacarNumeroFactura(VariablesGlobales.NumeroConector);


            DSMarket.Logica.Comunes.ProcesarInformacion.ProcesarInformacionCuentasMovimientos Procesar = new Logica.Comunes.ProcesarInformacion.ProcesarInformacionCuentasMovimientos(
              0, AnoActual, MesActual, IdTipoCuentaDebito, 1, VariablesGlobales.NumeroConector, 0, IdBanco, CuentaDebito, AuxiliarDebito, Valor, IdorigenCuentaDebito, Concepto, NumeroRelacionado, IdClaseCuentaDebito, IdCuentaCatalogoCuenta, "INSERT");
            Procesar.ProcesarInformacion();
        }
        private void AfectarCuentasContablesCreditos() {
            //DECLARAMOS LAS VARIABLES CORRESPONDIENTES PARA REALIZAR ESTE PROCESO
            int IdTipoCuentaContable = 0;
            int IdBanco = 0;
            string CuentaContable = "";
            string AuxiliarContable = "";
            int IdOrigenCuenta = 0;
            
            decimal NumeroRelacionado = DSMarket.Logica.Comunes.ObtenerValores.SacarNumeroFactura(VariablesGlobales.NumeroConector);
            int IdClaseCuenta = 0;
            int IdCuentaContable = 0;

            decimal IdProducto = 0;
            decimal PrecioProducto = 0;
            decimal ImpuestoProducto = 0;
            decimal ProductoSinImpuesto = 0;

            var SacarLosDatosBanco = ObjdataContabilidad.Value.BuscaBancos(new Nullable<decimal>(), null, true, 1, 1);
            foreach (var nBancos in SacarLosDatosBanco) {
                IdBanco = Convert.ToInt32(nBancos.IdBanco);
            }

            //BUSCAMOS LOS PRODUCTOS AGREGADOS A FACTURA
            var BuscarProductosAgregados = ObjDataServicio.Value.BuscapRoductosAgregados(
                new Nullable<decimal>(),
                VariablesGlobales.NumeroConector);
            foreach (var nAgregados in BuscarProductosAgregados) {
                IdProducto = Convert.ToDecimal(nAgregados.IdProducto);
                PrecioProducto = Convert.ToDecimal(nAgregados.Precio);
                ImpuestoProducto = Convert.ToInt32(nAgregados.Impuesto);

                var InspeccionarProducto = ObjDataInventario.Value.BuscaProductos(
                    IdProducto, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, 1, 1);
                foreach (var nProducto in InspeccionarProducto) {
                    bool AplicaImpuesto = Convert.ToBoolean(nProducto.AplicaParaImpuesto0);

                    //SACAMOS EL AÑO Y EL MES
                    string AnoActual = DateTime.Now.Year.ToString();
                    string Mes = DateTime.Now.Month.ToString();
                    int Cantidaddigitos = Mes.Length;
                    string MesActual = "";
                    if (Cantidaddigitos == 1) {
                        MesActual = "0" + Mes;
                    }
                    else {
                        MesActual = Mes;
                    }

                    

                    if (AplicaImpuesto == true) {
                        string CuentaConcepto = DSMarket.Logica.Comunes.ObtenerValores.SacarConceptoCuenta(9);
                        //PRODUCTOS NO EXENTO DE IMPUESTO
                        //SACAMOS LOS DATOS DE LA CUENTA
                        var SacarInformacionCuentaContable = ObjdataContabilidad.Value.BuscaCatalogoCuentas(14, null, null, null, null, 1, 1);
                        foreach (var n in SacarInformacionCuentaContable)
                        {
                            IdTipoCuentaContable = Convert.ToInt32(n.IdTipoCuenta);
                            CuentaContable = n.Cuenta;
                            AuxiliarContable = n.Auxiliar;
                            IdOrigenCuenta = Convert.ToInt32(n.IdOrigenCuenta);
                            IdClaseCuenta = Convert.ToInt32(n.IdClaseCuenta);
                            IdCuentaContable = Convert.ToInt32(n.IdRegistro);
                        }

                        ProductoSinImpuesto = PrecioProducto - ImpuestoProducto;
                        decimal ProductoSinImpuestoNeto = ProductoSinImpuesto * -1;
                        DSMarket.Logica.Comunes.ProcesarInformacion.ProcesarInformacionCuentasMovimientos Procesar = new Logica.Comunes.ProcesarInformacion.ProcesarInformacionCuentasMovimientos(
                            0, AnoActual, MesActual, IdTipoCuentaContable, 1, VariablesGlobales.NumeroConector, 0, IdBanco, CuentaContable, AuxiliarContable, ProductoSinImpuestoNeto, IdOrigenCuenta, CuentaConcepto, NumeroRelacionado, IdClaseCuenta, IdCuentaContable, "INSERT");
                        Procesar.ProcesarInformacion();

                        //AGREGAMOS LOS DATOS DEL ITBIS
                        CuentaConcepto = DSMarket.Logica.Comunes.ObtenerValores.SacarConceptoCuenta(10);
                        var SacarInformacionCuentaContableitbis = ObjdataContabilidad.Value.BuscaCatalogoCuentas(10, null, null, null, null, 1, 1);
                        foreach (var n2 in SacarInformacionCuentaContableitbis)
                        {
                            IdTipoCuentaContable = Convert.ToInt32(n2.IdTipoCuenta);
                            CuentaContable = n2.Cuenta;
                            AuxiliarContable = n2.Auxiliar;
                            IdOrigenCuenta = Convert.ToInt32(n2.IdOrigenCuenta);
                            IdClaseCuenta = Convert.ToInt32(n2.IdClaseCuenta);
                            IdCuentaContable = Convert.ToInt32(n2.IdRegistro);
                        }
                        decimal ValorITBISProcesar = ImpuestoProducto * -1;
                        DSMarket.Logica.Comunes.ProcesarInformacion.ProcesarInformacionCuentasMovimientos Procesaritbis = new Logica.Comunes.ProcesarInformacion.ProcesarInformacionCuentasMovimientos(
                            0, AnoActual, MesActual, IdTipoCuentaContable, 1, VariablesGlobales.NumeroConector, 0, IdBanco, CuentaContable, AuxiliarContable, ValorITBISProcesar, IdOrigenCuenta, CuentaConcepto, NumeroRelacionado, IdClaseCuenta, IdCuentaContable, "INSERT");
                        Procesaritbis.ProcesarInformacion();
                    }
                    else {
                        string CuentaConcepto = DSMarket.Logica.Comunes.ObtenerValores.SacarConceptoCuenta(8);
                        //SACAMOS LOS DATOS DE LA CUENTA
                        var SacarInformacionCuentaContable = ObjdataContabilidad.Value.BuscaCatalogoCuentas(9, null, null, null, null, 1, 1);
                        foreach (var n in SacarInformacionCuentaContable)
                        {
                            IdTipoCuentaContable = Convert.ToInt32(n.IdTipoCuenta);
                            CuentaContable = n.Cuenta;
                            AuxiliarContable = n.Auxiliar;
                            IdOrigenCuenta = Convert.ToInt32(n.IdOrigenCuenta);
                            IdClaseCuenta = Convert.ToInt32(n.IdClaseCuenta);
                            IdCuentaContable = Convert.ToInt32(n.IdRegistro);
                        }
                        //PRODUCTO EXENTO DE IMPUESTO
                        decimal Valorprocesar = PrecioProducto * -1;
                        DSMarket.Logica.Comunes.ProcesarInformacion.ProcesarInformacionCuentasMovimientos Procesar = new Logica.Comunes.ProcesarInformacion.ProcesarInformacionCuentasMovimientos(
                            0, AnoActual, MesActual, IdTipoCuentaContable, 1, VariablesGlobales.NumeroConector, 0, IdBanco, CuentaContable, AuxiliarContable, Valorprocesar, IdOrigenCuenta, CuentaConcepto, NumeroRelacionado, IdClaseCuenta, IdCuentaContable, "INSERT");
                        Procesar.ProcesarInformacion();
                    }

                }
            }
        }
        #endregion

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Servicio.HistorialFActuracion Historial = new HistorialFActuracion();
            Historial.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Historial.ShowDialog();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void AnularFactura_Load(object sender, EventArgs e)
        {
            TemaGenerico();
            txtClaveSeguridad.PasswordChar = '•';
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            SacarInformacionFactura(VariablesGlobales.IdMantenimeinto);
            MostrarListadoTipoAnulaciones();
        }

        private void AnularFactura_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()))
            {
                MessageBox.Show("El campo clave de seguridad no puede estar vacio, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    MessageBox.Show("La clave de seguridad ingresada no es valida", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else {
                    string TipoFacturacion = txtTipoFacturacion.Text;

                    if (TipoFacturacion == "FACTURACION") {
                        if (MessageBox.Show("¿Quieres anular esta factura?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                            if (MessageBox.Show("¿Quieres devolver los productos facturados al inventario?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                //DEVOLVEMOS
                                FacturacionCliente(VariablesGlobales.NumeroConector, "INSERT");
                                FacturacionCliente(VariablesGlobales.NumeroConector, "CHANGESTATUSCANCEL");
                                // Productos(VariablesGlobales.NumeroConector, "INSERT");
                                //  FacturacionCalculos(VariablesGlobales.NumeroConector, "INSERT");
                                //AFECTAMOS COMPROBANTE
                                AfectarComprobanteFiscal();
                               

                                //DEVOLVEMOS TODOS LOS PRODUCTOS A SU ESTADO ORIGITAN ANTES DE REALIZAR ESTA FACTURACION
                                decimal IdProducto = 0;
                                int Cantidadvendida = 0;
                                bool EstatusProducto = false;
                                decimal ConectorProducto = 0;
                                var BuscarProductos = ObjDataServicio.Value.BuscapRoductosAgregados(
                                    new Nullable<decimal>(),
                                    VariablesGlobales.NumeroConector);
                                foreach (var n in BuscarProductos) {
                                    IdProducto = Convert.ToDecimal(n.IdProducto);
                                    Cantidadvendida = Convert.ToInt32(n.Cantidad);

                                    //BUSCAMOS EL PRODUCTO Y ANALIZAMOS EL TIPO DE PRODUCTO Y SI ES ACUMULATIVO
                                    var BuscarPrducto = ObjDataInventario.Value.BuscaProductos(IdProducto,
                                        null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, 1, 1);
                                    foreach (var n2 in BuscarPrducto) {
                                        VariablesGlobales.IdTipoProductoAnularFactura = Convert.ToDecimal(n2.IdTipoProducto);
                                        VariablesGlobales.AcumulativoAnularFactura = Convert.ToBoolean(n2.ProductoAcumulativo0);
                                        EstatusProducto = Convert.ToBoolean(n2.EstatusProducto0);
                                        ConectorProducto = Convert.ToDecimal(n2.NumeroConector);

                                        if (VariablesGlobales.IdTipoProductoAnularFactura == 1) {

                                            if (VariablesGlobales.AcumulativoAnularFactura == true) {
                                                ModificarStockproducto(IdProducto, ConectorProducto, Cantidadvendida, "ADDPRODUCT");

                                            }
                                            else if (VariablesGlobales.AcumulativoAnularFactura == false) {

                                                DSMarket.Logica.Entidades.EntidadesInventario.EProducto Devolver = new Logica.Entidades.EntidadesInventario.EProducto();

                                                Devolver.IdProducto = IdProducto;
                                                Devolver.IdTipoProducto = VariablesGlobales.IdTipoProductoAnularFactura;
                                                Devolver.ProductoAcumulativo0 = VariablesGlobales.AcumulativoAnularFactura;
                                                Devolver.EstatusProducto0 = EstatusProducto;

                                                var Add = ObjDataInventario.Value.MantenimientoProducto(Devolver, "CHANGESTATUS");
                                            }
                                        }
                                        AfectarCuentasContablesDebitos();
                                        AfectarCuentasContablesCreditos();
                                        MessageBox.Show("Operación realizada con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        //IMPRIMIMOS LA FACTURA
                                        GenerarFacturaVenta();
                                        AfectarCaja();
                                        IngresarSacarDinero("LESSMONEY");
                                        this.Dispose();
                                        DSMarket.Solucion.Pantallas.Pantallas.Servicio.HistorialFActuracion Historial = new HistorialFActuracion();
                                        Historial.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
                                        Historial.ShowDialog();

                                    }
                                }
                            }
                            else
                            {
                                FacturacionCliente(VariablesGlobales.NumeroConector, "INSERT");
                                FacturacionCliente(VariablesGlobales.NumeroConector, "CHANGESTATUSCANCEL");
                                // Productos(VariablesGlobales.NumeroConector, "INSERT");
                                //  FacturacionCalculos(VariablesGlobales.NumeroConector, "INSERT");
                                //AFECTAMOS COMPROBANTE
                                AfectarComprobanteFiscal();
                                AfectarCuentasContablesDebitos();
                                AfectarCuentasContablesCreditos();
                                MessageBox.Show("Operación realizada con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);

                                //IMPRIMIMOS LA FACTURA
                                GenerarFacturaVenta();
                                AfectarCaja();
                                IngresarSacarDinero("LESSMONEY");
                                this.Dispose();
                                DSMarket.Solucion.Pantallas.Pantallas.Servicio.HistorialFActuracion Historial = new HistorialFActuracion();
                                Historial.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
                                Historial.ShowDialog();
                            }

                        }
                    }
                    else {
                        if (MessageBox.Show("¿Quieres eliminar esta cotización?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                            FacturacionCliente(VariablesGlobales.NumeroConector,"DELETE");
                            Productos(VariablesGlobales.NumeroConector,"DELETE");
                            FacturacionCalculos(VariablesGlobales.NumeroConector,"DELETEALL");
                            MessageBox.Show("Cotización eliminada exitosamente", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Dispose();
                            DSMarket.Solucion.Pantallas.Pantallas.Servicio.HistorialFActuracion Historial = new HistorialFActuracion();
                            Historial.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
                            Historial.ShowDialog();
                        }
                    }
                }
            }
        }
    }
}
