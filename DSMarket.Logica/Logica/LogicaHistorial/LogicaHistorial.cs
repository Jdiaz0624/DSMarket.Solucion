using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Logica.LogicaHistorial
{
    public class LogicaHistorial
    {
        DSMarket.Data.Conexion.ConexionLINQ.BDConexionHistorialDataContext ObjData = new Data.Conexion.ConexionLINQ.BDConexionHistorialDataContext(System.Configuration.ConfigurationManager.ConnectionStrings["DSMarketConexion"].ConnectionString);

        #region HISTORIAL DE FACTURACION
        /// <summary>
        /// Este metodo muestra todo el historial de facturación
        /// </summary>
        /// <param name="NumeroFactura"></param>
        /// <param name="NumeroConector"></param>
        /// <param name="FacturadoA"></param>
        /// <param name="Idusuario"></param>
        /// <param name="RangoFechaDesde"></param>
        /// <param name="RangoFechaHasta"></param>
        /// <param name="NumeroPagina"></param>
        /// <param name="NumeroRegistros"></param>
        /// <returns></returns>
        public List<DSMarket.Logica.Entidades.EntidadesHistorial.EHistorialFacturacion> HistorialFacturacion(decimal? NumeroFactura = null, string NumeroConector = null, string FacturadoA = null, decimal? Idusuario = null, DateTime? RangoFechaDesde = null, DateTime? RangoFechaHasta = null, int? NumeroPagina = null, int? NumeroRegistros = null) {

            ObjData.CommandTimeout = 999999999;

            var Historial = (from n in ObjData.SP_HISTORIAL_FACTURACION(NumeroFactura, NumeroConector, FacturadoA, Idusuario, RangoFechaDesde, RangoFechaHasta, NumeroPagina, NumeroRegistros)
                             select new DSMarket.Logica.Entidades.EntidadesHistorial.EHistorialFacturacion
                             {
                                 NumeroFactura=n.NumeroFactura,
                                 NumeroConector=n.NumeroConector,
                                 FacturadoA=n.FacturadoA,
                                 CodigoCliente=n.CodigoCliente,
                                 IdTipoFacturacion=n.IdTipoFacturacion,
                                 TipoFacturacion=n.TipoFacturacion,
                                 Comentario=n.Comentario,
                                 TotalProductos=n.TotalProductos,
                                 TotalServicios=n.TotalServicios,
                                 TotalItems=n.TotalItems,
                                 SubTotal=n.SubTotal,
                                 DescuentoTotal=n.DescuentoTotal,
                                 ImpuestoTotal=n.ImpuestoTotal,
                                 TotalGeneral=n.TotalGeneral,
                                 IdTipoPago=n.IdTipoPago,
                                 TipoPago=n.TipoPago,
                                 MontoPagado=n.MontoPagado,
                                 Cambio=n.Cambio,
                                 IdMoneda=n.IdMoneda,
                                 Moneda=n.Moneda,
                                 Tasa=n.Tasa,
                                 IdUsuario=n.IdUsuario,
                                 CreadoPor=n.CreadoPor,
                                 FechaFacturacion0=n.FechaFacturacion0,
                                 FechaFacturacion=n.FechaFacturacion,
                                 IdComprobante=n.IdComprobante,
                                 NCF=n.NCF,
                                 ValidoHasta=n.ValidoHasta,
                                 NumeroComprobante=n.NumeroComprobante,
                                 CapitalInvertido=n.CapitalInvertido,
                                 GananciaVenta=n.GananciaVenta,
                                 Ganancia=n.Ganancia
                             }).ToList();
            return Historial;
        }

        /// <summary>
        /// Este metodo muestra todos los items agregados de una factura seleccionada
        /// </summary>
        /// <param name="NumeroFactura"></param>
        /// <param name="NumeroConector"></param>
        /// <returns></returns>
        public List<DSMarket.Logica.Entidades.EntidadesHistorial.EItemsAgregadosFactura> ItemsAgregadosFactura(decimal? NumeroFactura = null, string NumeroConector = null) {

            ObjData.CommandTimeout = 999999999;

            var itemsAgregados = (from n in ObjData.SP_MOSTRAR_ITEMS_AGREGADOS_FACTURA(NumeroFactura, NumeroConector)
                           select new DSMarket.Logica.Entidades.EntidadesHistorial.EItemsAgregadosFactura
                           {
                               Descripcion = n.Descripcion,
                               NumeroFactura =n.NumeroFactura,
                               NumeroConector=n.NumeroConector,
                               IdTipoFacturacion=n.IdTipoFacturacion,
                               TipoFacturacion=n.TipoFacturacion,
                               Anulada=n.Anulada,
                               FacturadoA=n.FacturadoA,
                               FechaFacturacion=n.FechaFacturacion,
                               TotalProductos=n.TotalProductos,
                               TotalServicios=n.TotalServicios,
                               TotalItems=n.TotalItems,
                               Coenectordetalle=n.Coenectordetalle,
                               Tipo=n.Tipo,
                               Precio=n.Precio,
                               Descuento=n.Descuento,
                               Cantidad=n.Cantidad,
                               PorcientoImpuesto=n.PorcientoImpuesto,
                               SubTotal=n.SubTotal,
                               Impuesto=n.Impuesto,
                               Total=n.Total,
                               IdRegistroRespaldo=n.IdRegistroRespaldo,
                               NumeroConectorItemRespaldo=n.NumeroConectorItemRespaldo,
                               IdTipoProductoRespaldo=n.IdTipoProductoRespaldo,
                               IdCategoriaRespaldo=n.IdCategoriaRespaldo,
                               IdMarcaRespaldo=n.IdMarcaRespaldo,
                               IdTipoSuplidorRespaldo=n.IdTipoSuplidorRespaldo,
                               IdSuplidorRespaldo=n.IdSuplidorRespaldo,
                               CodigoBarraRespaldo=n.CodigoBarraRespaldo,
                               ReferenciaRespaldo=n.ReferenciaRespaldo,
                               NumeroSeguimientoRespaldo=n.NumeroSeguimientoRespaldo,
                               CodigoProductoRespaldo=n.CodigoProductoRespaldo,
                               PrecioCompraRespaldo=n.PrecioCompraRespaldo,
                               PrecioVentaRespaldo=n.PrecioVentaRespaldo,
                               StockRespaldo=n.StockRespaldo,
                               StockMinimoRespaldo=n.StockMinimoRespaldo,
                               UnidadMedidaRespaldo=n.UnidadMedidaRespaldo,
                               ModeloRespaldo=n.ModeloRespaldo,
                               ColorRespaldo=n.ColorRespaldo,
                               CondicionRespaldo=n.CondicionRespaldo,
                               CapacidadRespaldo=n.CapacidadRespaldo,
                               AplicaParaImpuestoRespaldo=n.AplicaParaImpuestoRespaldo,
                               TieneImagenRespaldo=n.TieneImagenRespaldo,
                               LlevaGarantiaRespaldo=n.LlevaGarantiaRespaldo,
                               IdTipoGarantiaRespaldo=n.IdTipoGarantiaRespaldo,
                               TiempoGarantiaRespaldo=n.TiempoGarantiaRespaldo,
                               ComentarioItemRespaldo=n.ComentarioItemRespaldo,
                               UsuarioAdicionaRespaldo=n.UsuarioAdicionaRespaldo,
                               FechaAdicionaRespaldo=n.FechaAdicionaRespaldo,
                               UsuarioModificaRespaldo=n.UsuarioModificaRespaldo,
                               FechaModificaRespaldo=n.FechaModificaRespaldo,
                               FechaIngresoRespaldo=n.FechaIngresoRespaldo

                           }).ToList();
            return itemsAgregados;



        }
        #endregion

        /// <summary>
        /// Este metodo es para procesar la informacion de los datos de la ganancia de venta
        /// </summary>
        /// <param name="Item"></param>
        /// <param name="Accion"></param>
        /// <returns></returns>
        public DSMarket.Logica.Entidades.EntidadesHistorial.EProcesarGananciaVenta ProcesarGananciaVenta(DSMarket.Logica.Entidades.EntidadesHistorial.EProcesarGananciaVenta Item, string Accion) {
            ObjData.CommandTimeout = 999999999;

            DSMarket.Logica.Entidades.EntidadesHistorial.EProcesarGananciaVenta Procesar = null;

            var GananciaVenta = ObjData.SP_PROCESAR_INFORMACION_GANANCIA_VENTA(
               Item.IdUsuario,
               Item.IdEstatusFacturacion,
               Item.Estatus,
               Item.NumeroFactura,
               Item.Descripcion,
               Item.IdCategoria,
               Item.IdTipoProducto,
               Item.PrecioCompra,
               Item.PrecioVenta,
               Item.CantidadVendida,
               Item.DescuentoAplicado,
               Item.TotalDescuentoAplicado,
               Item.TotalVenta,
               Item.TotalPrecioCompra,
               Item.Ganancia,
               Accion);
            if (GananciaVenta != null) {
                Procesar = (from n in GananciaVenta
                            select new DSMarket.Logica.Entidades.EntidadesHistorial.EProcesarGananciaVenta
                            {
                                IdUsuario=n.IdUsuario,
                                IdEstatusFacturacion=n.IdEstatusFacturacion,
                                Estatus=n.Estatus,
                                NumeroFactura=n.NumeroFactura,
                                Descripcion=n.Descripcion,
                                IdCategoria=n.IdCategoria,
                                IdTipoProducto=n.IdTipoProducto,
                                PrecioCompra=n.PrecioCompra,
                                PrecioVenta=n.PrecioVenta,
                                CantidadVendida=n.CantidadVendida,
                                DescuentoAplicado=n.DescuentoAplicado,
                                TotalDescuentoAplicado=n.TotalDescuentoAplicado,
                                TotalVenta=n.TotalVenta,
                                TotalPrecioCompra=n.TotalPrecioCompra,
                                Ganancia=n.Ganancia
                            }).FirstOrDefault();
            }

            return Procesar;
        }

        /// <summary>
        /// Este metodo es apra procesar la informacion para generar el reporte de ventas
        /// </summary>
        /// <param name="Item"></param>
        /// <param name="Accion"></param>
        /// <returns></returns>
        public DSMarket.Logica.Entidades.EntidadesHistorial.EInformacionInformcionVEnta InformacionInformacionVenta(DSMarket.Logica.Entidades.EntidadesHistorial.EInformacionInformcionVEnta Item, string Accion) {

            ObjData.CommandTimeout = 999999999;

            DSMarket.Logica.Entidades.EntidadesHistorial.EInformacionInformcionVEnta Procesar = null;

            var InformacionVenta = ObjData.SP_PROCESAR_INFORMACION_INFORMACION_VENTAS(
                Item.IdUsuario,
                Item.NumeroFActura,
                Item.IdTipoFacturacion,
                Item.NumeroConector,
                Item.FacturadoA,
                Item.NCF,
                Item.FechaFActuracion,
                Item.TotalProductos,
                Item.TotalServicios,
                Item.TotalItems,
                Item.SubTotal,
                Item.Descuento,
                Item.Impuesto,
                Item.Total,
                Item.IdTipoPago,
                Item.MontoPagado,
                Item.Cambio,
                Item.IdMoneda,
                Item.Tasa,
                Accion);
            if (InformacionVenta != null) {
                Procesar = (from n in InformacionVenta
                            select new DSMarket.Logica.Entidades.EntidadesHistorial.EInformacionInformcionVEnta
                            {
                                IdUsuario   =n.IdUsuario,
                                NumeroFActura = n.NumeroFActura,
                                IdTipoFacturacion=n.IdTipoFacturacion,
                                NumeroConector = n.NumeroConector,
                                FacturadoA=n.FacturadoA,
                                NCF = n.NCF,
                                FechaFActuracion = n.FechaFActuracion,
                                TotalProductos = n.TotalProductos,
                                TotalServicios = n.TotalServicios,
                                TotalItems = n.TotalItems,
                                SubTotal = n.SubTotal,
                                Descuento = n.Descuento,
                                Impuesto = n.Impuesto,
                                Total = n.Total,
                                IdTipoPago = n.IdTipoPago,
                                MontoPagado = n.MontoPagado,
                                Cambio = n.Cambio,
                                IdMoneda = n.IdMoneda,
                                Tasa = n.Tasa
                            }).FirstOrDefault();
            }
            return Procesar;
        }
    }
}
