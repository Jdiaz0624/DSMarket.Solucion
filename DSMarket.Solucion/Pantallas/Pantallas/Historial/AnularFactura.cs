using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSMarket.Solucion.Pantallas.Pantallas.Historial
{
    public partial class AnularFactura : Form
    {
        public AnularFactura()
        {
            InitializeComponent();
        }
        public DSMarket.Logica.Logica.LogicaHistorial.LogicaHistorial Hitorial = new Logica.Logica.LogicaHistorial.LogicaHistorial();
        public DSMarket.Logica.Logica.LogicaSeguridad.LogicaSeguridad ObjDataSeguriad = new Logica.Logica.LogicaSeguridad.LogicaSeguridad();
        public DSMarket.Logica.Logica.LogicaInventario.LogicaInventario ObjdataInventario = new Logica.Logica.LogicaInventario.LogicaInventario();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        enum Comprobantes { 
        NotaCredito=4
        }

        enum ConfiguracionesGeneralesSistema {
            USAR_COMPROBANTES_FISCALES=1,
            BUSCAR_CLIENTES_REGISTRADOS=2,
            IMPRIMIR_FACTURA_DIRECTO_A_LA_IMPRESORA=3,
            VALIDAR_EL_TIPO_DE_PAGO=4,
            VALIDAR_LA_MONEDA=5,
            USO_DE_COMPROBANTES_FISCALES_POR_DEFECTO=6,
            VALIDAR_LAS_OPCIONES_CONTABLES=7,
            ELIMINAR_PRODUCTOS_AGOTADOS_AL_FACTURAR=8,
            DEVOLVER_PRODUCTOS_A_INVENTARIO_AL_ANULAR_FACTURA=9,
            MONTO_TOTAL_VENTA_MANUAL=10,
            CREAR_NOTAS_DE_CREDITO_AL_ANULAR_FACTURAS=11
        }

        private void CerrarPantalla()
        {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Historial.HistorialFacturacion Historial = new Historial.HistorialFacturacion();
            Historial.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Historial.ShowDialog();
        }

        private void AfectarCaja(decimal Monto)
        {
            DSMarket.Logica.Comunes.ProcesarInformacion.Caja.ProcesarInformacionAfectarCaja AfectarCaja = new Logica.Comunes.ProcesarInformacion.Caja.ProcesarInformacionAfectarCaja(
                1,
                "Caja General",
                (Monto * -1),
                true,
                "LESSMONEY");
            AfectarCaja.ProcesarInformacion();
        }

        private void DevolverProductoInventario(decimal NumeroFacturaAnulada, string NumeroConectorAnulado) {
            if (MessageBox.Show("¿Quieres devolver todos los productos facturados para el inventario?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //BUSCAMOS TODOS LOS PRODUCTOS Y PARA DEVOLVER
                var BuscarItemsagregados = Hitorial.ItemsAgregadosFactura(NumeroFacturaAnulada, NumeroConectorAnulado);


                //DECLARAMOS LAS VARIABLES NECESARIOAS PARA REALIZAR ESTE PROCESO
                decimal IdRegistroAnulado = 0;
                string ConectorAnulado = "";
                decimal IdTipoProductoAnulado = 0;
                decimal IdCategoriaAnulado = 0;
                decimal IdMarcaAnulado = 0;
                decimal IdTipoSuplidorAnulado = 0;
                decimal IdSuplidorAnulado = 0;
                string DescripcionAnulado = "";
                string CodigoBarraAnulado = "";
                string ReferenciaAnulado = "";
                string NumeroSeguimientoAnulado = "";
                string CodigoProductoAnulado = "";
                decimal PrecioCompraAnulado = 0;
                decimal PrecioVentaAnulado = 0;
                decimal StockAnulado = 0;
                decimal StockMinimoAnulado = 0;
                string UnidadMedidaAnulado = "";
                string ModeloAnulado = "";
                string ColorAnulado = "";
                string CondicionAnulado = "";
                string CapacidadAnulado = "";
                bool AplicaParaImpuestoAnulado = false;
                bool TieneImagenAnulado = false;
                bool LlevaGarantiaAnulado = false;
                decimal IdTipoGarantiaAnulado = 0;
                int TiempoGarantiaAnulado = 0;
                string ComentarioAnulado = "";
                decimal UsuarioAdicionaAnulado = 0;
                DateTime FechaAdicionaAnulado = DateTime.Now;
                decimal UsuarioModificaAnulado = 0;
                DateTime FechaModificaAnulado = DateTime.Now;
                DateTime FechaIngresoAnulado = DateTime.Now;
                decimal CantidadFacturada = 0;



                foreach (var ProductosAgregados in BuscarItemsagregados)
                {
                    IdRegistroAnulado = (decimal)ProductosAgregados.IdRegistroRespaldo;
                    ConectorAnulado = ProductosAgregados.NumeroConectorItemRespaldo;
                    IdTipoProductoAnulado = (decimal)ProductosAgregados.IdTipoProductoRespaldo;
                    IdCategoriaAnulado = (decimal)ProductosAgregados.IdCategoriaRespaldo;
                    IdMarcaAnulado = (decimal)ProductosAgregados.IdMarcaRespaldo;
                    IdTipoSuplidorAnulado = (decimal)ProductosAgregados.IdTipoSuplidorRespaldo;
                    IdSuplidorAnulado = (decimal)ProductosAgregados.IdSuplidorRespaldo;
                    DescripcionAnulado = ProductosAgregados.Descripcion;
                    CodigoBarraAnulado = ProductosAgregados.CodigoBarraRespaldo;
                    ReferenciaAnulado = ProductosAgregados.ReferenciaRespaldo;
                    NumeroSeguimientoAnulado = ProductosAgregados.NumeroSeguimientoRespaldo;
                    CodigoProductoAnulado = ProductosAgregados.CodigoProductoRespaldo;
                    PrecioCompraAnulado = (decimal)ProductosAgregados.PrecioCompraRespaldo;
                    PrecioVentaAnulado = (decimal)ProductosAgregados.PrecioVentaRespaldo;
                    StockAnulado = (decimal)ProductosAgregados.StockRespaldo;
                    StockMinimoAnulado = (decimal)ProductosAgregados.StockMinimoRespaldo;
                    UnidadMedidaAnulado = ProductosAgregados.UnidadMedidaRespaldo;
                    ModeloAnulado = ProductosAgregados.ModeloRespaldo;
                    ColorAnulado = ProductosAgregados.ColorRespaldo;
                    CondicionAnulado = ProductosAgregados.CondicionRespaldo;
                    CapacidadAnulado = ProductosAgregados.CapacidadRespaldo;
                    AplicaParaImpuestoAnulado = (bool)ProductosAgregados.AplicaParaImpuestoRespaldo;
                    TieneImagenAnulado = (bool)ProductosAgregados.TieneImagenRespaldo;
                    LlevaGarantiaAnulado = (bool)ProductosAgregados.LlevaGarantiaRespaldo;
                    IdTipoGarantiaAnulado = (decimal)ProductosAgregados.IdTipoGarantiaRespaldo;
                    TiempoGarantiaAnulado = (int)ProductosAgregados.TiempoGarantiaRespaldo;
                    ComentarioAnulado = ProductosAgregados.ComentarioItemRespaldo;
                    UsuarioAdicionaAnulado = (decimal)ProductosAgregados.UsuarioAdicionaRespaldo;
                    FechaAdicionaAnulado = (DateTime)ProductosAgregados.FechaAdicionaRespaldo;
                    UsuarioModificaAnulado = (decimal)ProductosAgregados.UsuarioModificaRespaldo;
                    FechaModificaAnulado = (DateTime)ProductosAgregados.FechaModificaRespaldo;
                    FechaIngresoAnulado = (DateTime)ProductosAgregados.FechaIngresoRespaldo;
                    CantidadFacturada = (decimal)ProductosAgregados.Cantidad;

                    if (IdTipoProductoAnulado == 1)
                    {
                        //VERIFICAMOS QUE EL PRODUCTO EXISTE EN EL INVENTARIO
                        var VerificarExistencia = ObjdataInventario.BuscaProductosServicios(IdRegistroAnulado, ConectorAnulado,
                            null, null, null, null, null, null, null, null, null, null, null, null, null, null, 1, 1);
                        if (VerificarExistencia.Count() < 1)
                        {
                            //CREAMOS EL PRODUCTO
                            DSMarket.Logica.Comunes.ProcesarInformacion.Inventario.ProcesarInformacionProductoServicio NuevoRegistro = new Logica.Comunes.ProcesarInformacion.Inventario.ProcesarInformacionProductoServicio(
                                IdRegistroAnulado,
                                ConectorAnulado,
                                IdTipoProductoAnulado,
                                IdCategoriaAnulado,
                                IdMarcaAnulado,
                                IdTipoSuplidorAnulado,
                                IdSuplidorAnulado,
                                DescripcionAnulado,
                                CodigoBarraAnulado,
                                ReferenciaAnulado,
                                NumeroSeguimientoAnulado,
                                CodigoProductoAnulado,
                                PrecioCompraAnulado,
                                PrecioVentaAnulado,
                                StockAnulado,
                                StockMinimoAnulado,
                                UnidadMedidaAnulado,
                                ModeloAnulado,
                                ColorAnulado,
                                CondicionAnulado,
                                CapacidadAnulado,
                                AplicaParaImpuestoAnulado,
                                TieneImagenAnulado,
                                LlevaGarantiaAnulado,
                                IdTipoGarantiaAnulado,
                                TiempoGarantiaAnulado,
                                "PRODUCTO DEVUELTO DEL INVENTARIO",
                                UsuarioAdicionaAnulado,
                                "INSERT");
                            NuevoRegistro.ProcesarInformacion();
                          

                        }
                        else
                        {
                            //ACTUALIZAMOS EL INVENTARIO
                            DSMarket.Logica.Comunes.ProcesarInformacion.Inventario.ProcesarInformacionProductoServicio Actualizar = new Logica.Comunes.ProcesarInformacion.Inventario.ProcesarInformacionProductoServicio(
                                IdRegistroAnulado,
                                ConectorAnulado,
                                0, 0, 0, 0, 0, "", "", "", "", "", 0, 0, CantidadFacturada, 0, "", "", "", "", "", false, false, false, 0, 0, "", 0, "ADDPRODUCT");
                            Actualizar.ProcesarInformacion();
                          
                        }
                    }
                   
                }
                
            }
            else
            {
                
            }
        }


        private void GuardarHistorialcaja(decimal IdTipoPago, decimal Monto)
        {
            DSMarket.Logica.Comunes.SacarNumeroFactura Factura = new Logica.Comunes.SacarNumeroFactura(VariablesGlobales.NumeroConectorstring);
            decimal NumeroFactura = Factura.SacarNumero();

            DSMarket.Logica.Comunes.ProcesarInformacion.Caja.ProcesarInformacionHistorialCaja Historial = new Logica.Comunes.ProcesarInformacion.Caja.ProcesarInformacionHistorialCaja(
                0,
                1,
                Monto,
                "ANULACION DE LA FACTURA " + lbNumeroFacturaVariable.Text,
                VariablesGlobales.IdUsuario,
                NumeroFactura,
                IdTipoPago,
                "INSERT");
            Historial.ProcesarInformacion();
        }
        #region SACAR LA INFORMACION DE LA FACTURA
        private void SacarInformacion(decimal NumeroFactura, string NumeroConector) {
            var SacarInformacion = Hitorial.HistorialFacturacion(NumeroFactura, NumeroConector, null, null, null, null, 1, 1);
            foreach (var n in SacarInformacion) {
                lbNumeroFacturaVariable.Text = n.NumeroFactura.ToString();
                lbFActuradoAVariable.Text = n.FacturadoA;
                int TotalProductos = (int)n.TotalProductos;
                lbTotalProductoVariable.Text = TotalProductos.ToString("N0");
                int TotalServicios = (int)n.TotalServicios;
                lbTotalserviciosVariable.Text = TotalServicios.ToString("N0");
                int TotalItems = (int)n.TotalItems;
                lbTotalItemsVariable.Text = TotalItems.ToString("N0");
                lbFechaFActuracionVariable.Text = n.FechaFacturacion;
                decimal SubTotal = (decimal)n.SubTotal;
                lbSubtotalVariable.Text = SubTotal.ToString("N2");
                decimal ISC = (decimal)n.ImpuestoTotal;
                lbISCVariable.Text = ISC.ToString("N2");
                decimal Descuento = (decimal)n.DescuentoTotal;
                lbDescuentoVariable.Text = Descuento.ToString("N2");
                decimal TotalGeneral = (decimal)n.TotalGeneral;
                lbTotalGeneralVariable.Text = TotalGeneral.ToString("N2");
            }
        }
        #endregion

        private void AnularFactura_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason) {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void AnularFactura_Load(object sender, EventArgs e)
        {
            lbTitulo.ForeColor = Color.White;
            lbTitulo.Text = "ANULACION DE FACTURA";
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            SacarInformacion(VariablesGlobales.IdMantenimeinto, VariablesGlobales.NumeroConectorstring);
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            CerrarPantalla();
        }

        private void btnAnularfactura_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()))
            {
                MessageBox.Show("El campo clave de seguridad no puede estar vacio para realizar esta operación, favor de verificar.", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                //VALIDAMOS LA CLAVE DE SEGURIDAD
                var ValidarClaveSeguridad = ObjDataSeguriad.BuscaClaveSeguridad(new Nullable<decimal>(), null, DSMarket.Logica.Comunes.SeguridadEncriptacion.Encriptar(txtClaveSeguridad.Text), 1, 1);
                if (ValidarClaveSeguridad.Count() < 1) {
                    MessageBox.Show("La clave de seguridad ingresada no es validar, favor de verificar.", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else {
                  
                    //REALIZAMOS EL PROCESO DE ANULACION DE FACTURA
                    if (MessageBox.Show("Este proceso anulara la factura permanentemente, desea continuar?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        //DECLARAMOS LAS VARIABLES PARA CREAR EL REGISTRO
                        decimal NumeroFactura = 0;
                        string NumeroConector = "";
                        string FacturadoA = "";
                        decimal CodigoCliente = 0;
                        decimal IdTipoFacturacion = 0;
                        string Comentario = "";
                        int TotalProductos = 0;
                        int TotalServicios = 0;
                        int TotalItems = 0;
                        decimal SubTotal = 0;
                        decimal DescuentoTotal = 0;
                        decimal ImpuestoTotal = 0;
                        decimal TotalGeneral = 0;
                        decimal IdTipoPago = 0;
                        decimal MontoPagado = 0;
                        decimal Cambio = 0;
                        decimal IdMoneda = 0;
                        decimal Tasa = 0;
                        decimal IdUsuario = 0;
                        DateTime FechaFacturacion = DateTime.Now;
                        decimal IdComprobante = 0;
                        string ValidoHasta = "";
                        string NumeroComprobante = "";

                        DSMarket.Logica.Comunes.ProcesarInformacionComprobanteFiscal ComprobantesFiscales = new Logica.Comunes.ProcesarInformacionComprobanteFiscal((decimal)Comprobantes.NotaCredito);
                        //CARGAMOS LAS VARIABLES
                        var InformacionCompletaFactura = Hitorial.HistorialFacturacion(VariablesGlobales.IdMantenimeinto, VariablesGlobales.NumeroConectorstring, null, null, null, null, 1, 1);
                        foreach (var n in InformacionCompletaFactura) {
                            NumeroFactura = 0;
                            NumeroConector = n.NumeroConector;
                            FacturadoA = n.FacturadoA;
                            CodigoCliente = (decimal)n.CodigoCliente;
                            IdTipoFacturacion = 3;
                            Comentario = "Anulación de la factura " + n.NumeroFactura.ToString();
                            TotalProductos = (int)n.TotalProductos;
                            TotalServicios = (int)n.TotalServicios;
                            TotalItems = (int)n.TotalItems;
                            SubTotal = ((decimal)n.SubTotal * -1);
                            DescuentoTotal = ((decimal)n.DescuentoTotal * -1);
                            ImpuestoTotal = ((decimal)n.ImpuestoTotal * -1);
                            TotalGeneral = ((decimal)n.TotalGeneral * -1);
                            IdTipoPago = (decimal)n.IdTipoPago;
                            MontoPagado = ((decimal)n.MontoPagado * -1);
                            Cambio = ((decimal)n.Cambio * -1);
                            IdMoneda = (decimal)n.IdMoneda;
                            Tasa = (decimal)n.Tasa;
                            IdComprobante = (decimal)n.IdComprobante == 0 ? 0 : 4;
                            ValidoHasta = (decimal)n.IdComprobante == 0 ? "" : ComprobantesFiscales.SacarFechaValidoComprobante();
                            NumeroComprobante = (decimal)n.IdComprobante == 0 ? "" : ComprobantesFiscales.GenerarComprobanteFiscal();
                        }


                        bool ValidacionNotasCreditos = false;
                        DSMarket.Logica.Comunes.ValidarConfiguracionesGeneralesSistema Validaciones = new Logica.Comunes.ValidarConfiguracionesGeneralesSistema((decimal)ConfiguracionesGeneralesSistema.CREAR_NOTAS_DE_CREDITO_AL_ANULAR_FACTURAS, 2);
                        ValidacionNotasCreditos = Validaciones.ValidarConfiguracionGeneral();
                        switch (ValidacionNotasCreditos)
                        {
                            case true:
                                //GUARDAMOS EL REGISTRO
                                DSMarket.Logica.Comunes.ProcesarInformacion.Servicio.ProcesarInformacionFactura Anular = new Logica.Comunes.ProcesarInformacion.Servicio.ProcesarInformacionFactura(
                                    NumeroFactura,
                                    NumeroConector,
                                    FacturadoA,
                                    CodigoCliente,
                                    IdTipoFacturacion,
                                    Comentario,
                                    TotalProductos,
                                    TotalServicios,
                                    TotalItems,
                                    SubTotal,
                                    DescuentoTotal,
                                    ImpuestoTotal,
                                    TotalGeneral,
                                    IdTipoPago,
                                    MontoPagado,
                                    Cambio,
                                    IdMoneda,
                                    Tasa,
                                    VariablesGlobales.IdUsuario,
                                    IdComprobante,
                                    ValidoHasta,
                                    NumeroComprobante,
                                    false,0,false,0,false,0,false,0,false,0,
                                    "INSERT");
                                Anular.ProcesarInformacion();
                              //  AfectarCaja(TotalGeneral);
                                GuardarHistorialcaja(IdTipoPago, TotalGeneral);
                                MessageBox.Show("Factura anulada con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);

                                //VALIDAMOS SI ES ACTIVA LA OPCION DE DEVOLVER LOS PRODUCTOS A INVENTARIO
                                bool ValidarDevolverProductoInventario = false;
                                DSMarket.Logica.Comunes.ValidarConfiguracionesGeneralesSistema ValidarDevolverProducto = new Logica.Comunes.ValidarConfiguracionesGeneralesSistema((decimal)ConfiguracionesGeneralesSistema.DEVOLVER_PRODUCTOS_A_INVENTARIO_AL_ANULAR_FACTURA, 2);
                                ValidarDevolverProductoInventario = ValidarDevolverProducto.ValidarConfiguracionGeneral();

                                if (ValidarDevolverProductoInventario == true)
                                {
                                    DevolverProductoInventario(VariablesGlobales.IdMantenimeinto, VariablesGlobales.NumeroConectorstring);
                                }
                                //GENERAMOS LA FACTURA
                                DSMarket.Logica.Comunes.SacarNumeroFactura NoCredito = new Logica.Comunes.SacarNumeroFactura(VariablesGlobales.NumeroConectorstring);
                                decimal Credito = NoCredito.SacarNumero();

                                //DSMarket.Logica.Comunes.SacarNumeroFactura NoCredito = new Logica.Comunes.SacarNumeroFactura(VariablesGlobales.NumeroConectorstring);
                                //decimal NoCredito = NumeroFactura.SacarNumero();

                                DSMarket.Solucion.Pantallas.Pantallas.Reportes.Reportes NotaCredito = new Reportes.Reportes();
                                NotaCredito.GenerarFacturaVenta(Credito, false);
                                NotaCredito.ShowDialog();
                                CerrarPantalla();
                                break;

                            case false:
                                //ELIMINAMOS TODO REGISTRO DE LA FACTURA
                               // AfectarCaja(TotalGeneral);
                                GuardarHistorialcaja(IdTipoPago, TotalGeneral);
                                //VALIDAMOS SI ES ACTIVA LA OPCION DE DEVOLVER LOS PRODUCTOS A INVENTARIO
                                bool ValidarDevolverProductoInventarioEliminar = false;
                                DSMarket.Logica.Comunes.ValidarConfiguracionesGeneralesSistema ValidarDevolverProductoEliminar = new Logica.Comunes.ValidarConfiguracionesGeneralesSistema((decimal)ConfiguracionesGeneralesSistema.DEVOLVER_PRODUCTOS_A_INVENTARIO_AL_ANULAR_FACTURA, 2);
                                ValidarDevolverProductoInventarioEliminar = ValidarDevolverProductoEliminar.ValidarConfiguracionGeneral();

                                if (ValidarDevolverProductoInventarioEliminar == true)
                                {
                                    DevolverProductoInventario(VariablesGlobales.IdMantenimeinto, VariablesGlobales.NumeroConectorstring);
                                }


                                decimal NumeroFacturaEliminar = Convert.ToDecimal(lbNumeroFacturaVariable.Text);
                                DSMarket.Logica.Comunes.ProcesarInformacion.Servicio.ProcesarInformacionFactura Eliminar = new Logica.Comunes.ProcesarInformacion.Servicio.ProcesarInformacionFactura(
                                    NumeroFacturaEliminar,
                                    NumeroConector,
                                    "", 0, 0, "", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "", "",false,0,false,0,false,0,false,0,false,0, "DELETE");
                                Eliminar.ProcesarInformacion();


                                CerrarPantalla();
                                break;
                        }


                      


                    }
                    
                }
            }
        }
    }
}
