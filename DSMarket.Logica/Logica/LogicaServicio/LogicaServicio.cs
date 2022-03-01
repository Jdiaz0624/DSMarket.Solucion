using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSMarket.Logica.Entidades.EntidadesServicio;

namespace DSMarket.Logica.Logica.LogicaServicio
{
    public class LogicaServicio
    {
        DSMarket.Data.Conexion.ConexionLINQ.BDConecionServicioDataContext ObjData = new Data.Conexion.ConexionLINQ.BDConecionServicioDataContext(System.Configuration.ConfigurationManager.ConnectionStrings["DSMarketConexion"].ConnectionString);

        #region LISTADO DE TIPOS DE PAGOS
        //LISTADO DE TIPOS DE PAGOS
        public List<DSMarket.Logica.Entidades.EntidadesServicio.ETipoPago> BuscaTipoPago(decimal? IdTipoPago = null, string Descripcion = null, int? NumeroPagina = null, int? NumeroRegistros = null)
        {
            ObjData.CommandTimeout = 999999999;

            var Buscar = (from n in ObjData.SP_BUSCA_TIPO_PAGO(IdTipoPago, Descripcion, NumeroPagina, NumeroRegistros)
                          select new DSMarket.Logica.Entidades.EntidadesServicio.ETipoPago
                          {
                              IdTipoPago = n.IdTipoPago,
                              TipoPago = n.TipoPago,
                              Estatus0 = n.Estatus0,
                              Estatus = n.Estatus,
                              UsuarioAdiciona = n.UsuarioAdiciona,
                              CreadPor = n.CreadPor,
                              FechaAdiciona = n.FechaAdiciona,
                              FechaCreado = n.FechaCreado,
                              ModificadoPor = n.ModificadoPor,
                              FechaModifica = n.FechaModifica,
                              FechaModificado = n.FechaModificado,
                              BloqueaMonto0 = n.BloqueaMonto0,
                              BloqueaMonto = n.BloqueaMonto,
                              ImpuestoAdicional0=n.ImpuestoAdicional0,
                              ImpuestoAdicional=n.ImpuestoAdicional,
                              PorcentajeEntero0=n.PorcentajeEntero0,
                              PorcentajeEntero=n.PorcentajeEntero,
                              Valor=n.Valor,
                              CodigoTipoPago=n.CodigoTipoPago,
                              CantidadRegistros = n.CantidadRegistros
                          }).ToList();
            return Buscar;

            
        }
        //MANTENIMIENTO DE TIPO DE PAGO
        public DSMarket.Logica.Entidades.EntidadesServicio.EMantenimientoTipoPago MantenimientoTipoPago(DSMarket.Logica.Entidades.EntidadesServicio.EMantenimientoTipoPago Item, string Accion) {
            ObjData.CommandTimeout = 999999999;

            DSMarket.Logica.Entidades.EntidadesServicio.EMantenimientoTipoPago Mantenimiento = null;

            var TipoPago = ObjData.SP_MANTENIMIENTO_TIPO_PAGO(
                Item.IdTipoPago,
                Item.Descripcion,
                Item.Estatus,
                Item.UsuarioAdiciona,
                Item.BloqueaMonto,
                Item.ImpuestoAdicional,
                Item.PorcentajeEntero,
                Item.Valor,
                Item.CodigoTipoPago,
                Accion);
            if (TipoPago != null) {
                Mantenimiento = (from n in TipoPago
                                 select new DSMarket.Logica.Entidades.EntidadesServicio.EMantenimientoTipoPago
                                 {
                                     IdTipoPago=n.IdTipoPago,
                                     Descripcion=n.Descripcion,
                                     Estatus=n.Estatus,
                                     UsuarioAdiciona=n.UsuarioAdiciona,
                                     FechaAdiciona=n.FechaAdiciona,
                                     UsuarioModifica=n.UsuarioModifica,
                                     FechaModifica=n.FechaModifica,
                                     BloqueaMonto=n.BloqueaMonto,
                                     ImpuestoAdicional=n.ImpuestoAdicional,
                                     PorcentajeEntero=n.PorcentajeEntero,
                                     Valor=n.Valor,
                                     CodigoTipoPago=n.CodigoTipoPago
                                 }).FirstOrDefault();
            }
            return Mantenimiento;
        }
        #endregion
        #region FACTURACION
        /// <summary>
        /// Este metodo es para sacar la información de la facturacion de manera de preview antes de facturar.
        /// </summary>
        /// <param name="IdUsuario"></param>
        /// <param name="NumeroConector"></param>
        /// <returns></returns>
        public List<DSMarket.Logica.Entidades.EntidadesServicio.EFacturacionPreview> BuscaFacturacionPreview(decimal? IdUsuario = null, string NumeroConector = null,decimal? IdProducto = null,decimal? IdTipoProducto = null) {
            ObjData.CommandTimeout = 999999999;

            var BuscarListado = (from n in ObjData.SP_BUSCAR_FACTURACION_PREVIEW(IdUsuario, NumeroConector, IdProducto, IdTipoProducto)
                                 select new DSMarket.Logica.Entidades.EntidadesServicio.EFacturacionPreview
                                 {
                                   IdUsuario=n.IdUsuario,
                                     NumeroConector=n.NumeroConector,
                                     IdProducto=n.IdProducto,
                                     Descripcion=n.Descripcion,
                                     IdTipoProducto=n.IdTipoProducto,
                                     Precio=n.Precio,
                                     Cantidad=n.Cantidad,
                                     Descuento=n.Descuento,
                                     PorcientoImpuesto=n.PorcientoImpuesto,
                                     SubTotal=n.SubTotal,
                                     Impuesto=n.Impuesto,
                                     Total=n.Total,
                                     TotalProducto=n.TotalProducto,
                                     TotalServicio=n.TotalServicio,
                                     TotalItems=n.TotalItems,
                                     TotalDescuento=n.TotalDescuento,
                                     TotalSubTotal=n.TotalSubTotal,
                                     TotalImpuesto=n.TotalImpuesto,
                                     TotalGeneral=n.TotalGeneral

                                 }).ToList();
            return BuscarListado;
        }

        /// <summary>
        /// Este metodo es para procesar informacion de los productos agregados
        /// </summary>
        /// <param name="Item"></param>
        /// <param name="Accion"></param>
        /// <returns></returns>
        public DSMarket.Logica.Entidades.EntidadesServicio.EFacturacionPreview ProcesarDatosFacturacionPreview(DSMarket.Logica.Entidades.EntidadesServicio.EFacturacionPreview Item, string Accion) {
            ObjData.CommandTimeout = 999999999;

            DSMarket.Logica.Entidades.EntidadesServicio.EFacturacionPreview Procesar = null;

            var FacturacionPreview = ObjData.SP_PROCESAR_INFORMACION_FACTURA_PREVIEW(
                Item.IdUsuario,
                Item.NumeroConector,
                Item.IdProducto,
                Item.IdTipoProducto,
                Item.Precio,
                Item.Cantidad,
                Item.Descuento,
                Item.PorcientoImpuesto,
                Accion);
            if (FacturacionPreview != null) {
                Procesar = (from n in FacturacionPreview
                            select new DSMarket.Logica.Entidades.EntidadesServicio.EFacturacionPreview
                            {
                                IdUsuario=n.IdUsuario,
                                NumeroConector=n.NumeroConector,
                                IdProducto=n.IdProducto,
                                IdTipoProducto=n.IdTipoProducto,
                                Precio=n.Precio,
                                Cantidad=n.Cantidad,
                                Descuento=n.Descuento,
                                PorcientoImpuesto=n.PorcientoImpuesto
                            }).FirstOrDefault();
            }
            return Procesar;
        }

        /// <summary>
        /// Este metodo es para procesar la informacion de la factura en cabezado
        /// </summary>
        /// <param name="Item"></param>
        /// <param name="Accion"></param>
        /// <returns></returns>
        public DSMarket.Logica.Entidades.EntidadesServicio.EFacturacion ProcesarFacturacion(DSMarket.Logica.Entidades.EntidadesServicio.EFacturacion Item, string Accion) {
            ObjData.CommandTimeout = 999999999;

            DSMarket.Logica.Entidades.EntidadesServicio.EFacturacion Procesar = null;

            var Facturacion = ObjData.SP_PROCESAR_INFORMACION_FACTURACION(
                Item.NumeroFactura,
                Item.NumeroConector,
                Item.FacturadoA,
                Item.CodigoCliente,
                Item.IdTipoFacturacion,
                Item.Comentario,
                Item.TotalProductos,
                Item.TotalServicios,
                Item.TotalItems,
                Item.SubTotal,
                Item.DescuentoTotal,
                Item.ImpuestoTotal,
                Item.TotalGeneral,
                Item.IdTipoPago,
                Item.MontoPagado,
                Item.Cambio,
                Item.IdMoneda,
                Item.Tasa,
                Item.IdUsuario,
                Item.FechaFacturacion,
                Item.IdComprobante,
                Item.ValidoHasta,
                Item.NumeroComprobante,
                Item.EfectivoMixto,
                Item.MontoEfectivoMixto,
                Item.ChequeMixto,
                Item.MontoChequeMixto,
                Item.TransferenciaMixto,
                Item.MontoTransferenciaMixto,
                Item.DepositoMixto,
                Item.MontoDepositoMixto,
                Item.TarjetaMixto,
                Item.MontoTarjetaMixto,
                Accion);
            if (Facturacion != null) {
                Procesar = (from n in Facturacion
                            select new DSMarket.Logica.Entidades.EntidadesServicio.EFacturacion
                            {
                                NumeroFactura=n.NumeroFactura,
                                NumeroConector=n.NumeroConector,
                                FacturadoA=n.FacturadoA,
                                CodigoCliente=n.CodigoCliente,
                                IdTipoFacturacion=n.IdTipoFacturacion,
                                Comentario=n.Comentario,
                                TotalProductos=n.TotalProductos,
                                TotalServicios=n.TotalServicios,
                                TotalItems=n.TotalItems,
                                SubTotal=n.SubTotal,
                                DescuentoTotal=n.DescuentoTotal,
                                ImpuestoTotal=n.ImpuestoTotal,
                                TotalGeneral=n.TotalGeneral,
                                IdTipoPago=n.IdTipoPago,
                                MontoPagado=n.MontoPagado,
                                Cambio=n.Cambio,
                                IdMoneda=n.IdMoneda,
                                Tasa=n.Tasa,
                                IdUsuario=n.IdUsuario,
                                FechaFacturacion=n.FechaFacturacion,
                                IdComprobante=n.IdComprobante,
                                ValidoHasta=n.ValidoHasta,
                                NumeroComprobante=n.NumeroComprobante,
                                EfectivoMixto=n.EfectivoMixto,
                                MontoEfectivoMixto=n.MontoEfectivoMixto,
                                ChequeMixto=n.ChequeMixto,
                                MontoChequeMixto=n.MontoChequeMixto,
                                TransferenciaMixto=n.TransferenciaMixto,
                                MontoTransferenciaMixto=n.MontoTransferenciaMixto,
                                DepositoMixto=n.DepositoMixto,
                                MontoDepositoMixto=n.MontoDepositoMixto,
                                TarjetaMixto=n.TarjetaMixto,
                                MontoTarjetaMixto=n.MontoTarjetaMixto

                            }).FirstOrDefault();
            }
            return Procesar;
        }

        public DSMarket.Logica.Entidades.EntidadesServicio.EFacturacionDetalle ProcesarfacturacionDetalle(DSMarket.Logica.Entidades.EntidadesServicio.EFacturacionDetalle Item, string Accion) {
            ObjData.CommandTimeout = 999999999;

            DSMarket.Logica.Entidades.EntidadesServicio.EFacturacionDetalle Procesar = null;

            var FacturacionDetalle = ObjData.SP_PROCESAR_INFORMACION_FACTURACION_DETALLE(
                Item.NumeroConector,
                Item.Tipo,
                Item.Precio,
                Item.Descuento,
                Item.Cantidad,
                Item.PorcientoImpuesto,
                Item.SubTotal,
                Item.Impuesto,
                Item.Total,
                Item.IdRegistroRespaldo,
                Item.NumeroConectorItemRespaldo,
                Item.IdTipoProductoRespaldo,
                Item.IdCategoriaRespaldo,
                Item.IdMarcaRespaldo,
                Item.IdTipoSuplidorRespaldo,
                Item.IdSuplidorRespaldo,
                Item.DescripcionRespaldo,
                Item.CodigoBarraRespaldo,
                Item.ReferenciaRespaldo,
                Item.NumeroSeguimientoRespaldo,
                Item.CodigoProductoRespaldo,
                Item.PrecioCompraRespaldo,
                Item.PrecioVentaRespaldo,
                Item.StockRespaldo,
                Item.StockMinimoRespaldo,
                Item.UnidadMedidaRespaldo,
                Item.ModeloRespaldo,
                Item.ColorRespaldo,
                Item.CondicionRespaldo,
                Item.CapacidadRespaldo,
                Item.AplicaParaImpuestoRespaldo,
                Item.TieneImagenRespaldo,
                Item.LlevaGarantiaRespaldo,
                Item.IdTipoGarantiaRespaldo,
                Item.TiempoGarantiaRespaldo,
                Item.ComentarioItemRespaldo,
                Item.UsuarioAdicionaRespaldo,
                Item.FechaAdicionaRespaldo,
                Item.UsuarioModificaRespaldo,
                Item.FechaModificaRespaldo,
                Item.FechaIngresoRespaldo,
                Accion);
            if (FacturacionDetalle != null) {
                Procesar = (from n in FacturacionDetalle
                            select new DSMarket.Logica.Entidades.EntidadesServicio.EFacturacionDetalle
                            {
                                NumeroConector = n.NumeroConector,
                                Tipo = n.Tipo,
                                Precio = n.Precio,
                                Descuento = n.Descuento,
                                Cantidad = n.Cantidad,
                                PorcientoImpuesto=n.PorcientoImpuesto,
                                SubTotal=n.SubTotal,
                                Impuesto=n.Impuesto,
                                Total=n.Total,
                                IdRegistroRespaldo = n.IdRegistroRespaldo,
                                NumeroConectorItemRespaldo = n.NumeroConectorItemRespaldo,
                                IdTipoProductoRespaldo = n.IdTipoProductoRespaldo,
                                IdCategoriaRespaldo = n.IdCategoriaRespaldo,
                                IdMarcaRespaldo = n.IdMarcaRespaldo,
                                IdTipoSuplidorRespaldo = n.IdTipoSuplidorRespaldo,
                                IdSuplidorRespaldo = n.IdSuplidorRespaldo,
                                DescripcionRespaldo = n.DescripcionRespaldo,
                                CodigoBarraRespaldo = n.CodigoBarraRespaldo,
                                ReferenciaRespaldo = n.ReferenciaRespaldo,
                                NumeroSeguimientoRespaldo = n.ReferenciaRespaldo,
                                CodigoProductoRespaldo = n.CodigoProductoRespaldo,
                                PrecioCompraRespaldo = n.PrecioCompraRespaldo,
                                PrecioVentaRespaldo = n.PrecioVentaRespaldo,
                                StockRespaldo = n.StockRespaldo,
                                StockMinimoRespaldo = n.StockMinimoRespaldo,
                                UnidadMedidaRespaldo = n.UnidadMedidaRespaldo,
                                ModeloRespaldo = n.ModeloRespaldo,
                                ColorRespaldo = n.ColorRespaldo,
                                CondicionRespaldo = n.CondicionRespaldo,
                                CapacidadRespaldo = n.CapacidadRespaldo,
                                AplicaParaImpuestoRespaldo = n.AplicaParaImpuestoRespaldo,
                                TieneImagenRespaldo = n.TieneImagenRespaldo,
                                LlevaGarantiaRespaldo = n.LlevaGarantiaRespaldo,
                                IdTipoGarantiaRespaldo = n.IdTipoGarantiaRespaldo,
                                TiempoGarantiaRespaldo = n.TiempoGarantiaRespaldo,
                                ComentarioItemRespaldo = n.ComentarioItemRespaldo,
                                UsuarioAdicionaRespaldo = n.UsuarioAdicionaRespaldo,
                                FechaAdicionaRespaldo = n.FechaAdicionaRespaldo,
                                UsuarioModificaRespaldo = n.UsuarioModificaRespaldo,
                                FechaModificaRespaldo = n.FechaModificaRespaldo,
                                FechaIngresoRespaldo = n.FechaIngresoRespaldo
                            }).FirstOrDefault();
            }
            return Procesar;
           
        }
        #endregion
        #region COTIZACION
        /// <summary>
        /// Este metodo es para guardar y eliminar datos de una cotización
        /// </summary>
        /// <param name="Item"></param>
        /// <param name="Accion"></param>
        /// <returns></returns>
        public DSMarket.Logica.Entidades.EntidadesServicio.ECotizacion ProcesarCotizacion(DSMarket.Logica.Entidades.EntidadesServicio.ECotizacion Item, string Accion) {
            ObjData.CommandTimeout = 999999999;

            DSMarket.Logica.Entidades.EntidadesServicio.ECotizacion Procesar = null;

            
            var Cotizacion = ObjData.SP_PROCESAR_INFORMCION_COTIZACION(
                Item.NumeroCotizacion,
                Item.NumeroConector,
                Item.CotizacoA,
                Item.CodigoCliente,
                Item.IdTipoFacturacion,
                Item.Comentario,
                Item.TotalProductos,
                Item.TotalServicios,
                Item.TotalItems,
                Item.SubTotal,
                Item.DescuentoTotal,
                Item.ImpuestoTotal,
                Item.TotalGeneral,
                Item.IdTipoPago,
                Item.MontoPagado,
                Item.Cambio,
                Item.IdMoneda,
                Item.Tasa,
                Item.IdUsuario,
                Item.FechaCotizacion,
                Accion);
            if (Cotizacion != null) {
                Procesar = (from n in Cotizacion
                            select new DSMarket.Logica.Entidades.EntidadesServicio.ECotizacion
                            {
                                NumeroCotizacion=n.NumeroCotizacion,
                                NumeroConector=n.NumeroConector,
                                CotizacoA=n.CotizacoA,
                                CodigoCliente=n.CodigoCliente,
                                IdTipoFacturacion=n.IdTipoFacturacion,
                                Comentario=n.Comentario,
                                TotalProductos=n.TotalProductos,
                                TotalServicios=n.TotalServicios,
                                TotalItems=n.TotalItems,
                                SubTotal=n.SubTotal,
                                DescuentoTotal=n.DescuentoTotal,
                                ImpuestoTotal=n.ImpuestoTotal,
                                TotalGeneral=n.TotalGeneral,
                                IdTipoPago=n.IdTipoPago,
                                MontoPagado=n.MontoPagado,
                                Cambio=n.Cambio,
                                IdMoneda=n.IdMoneda,
                                Tasa=n.Tasa,
                                IdUsuario=n.IdUsuario,
                                FechaCotizacion=n.FechaCotizacion,
                            }).FirstOrDefault();
            }
            return Procesar;
        }

        /// <summary>
        /// Este metodo es para guardar y eliminar los datos del detalle de una cotización
        /// </summary>
        /// <param name="Item"></param>
        /// <param name="Accion"></param>
        /// <returns></returns>
        public DSMarket.Logica.Entidades.EntidadesServicio.ECotizacionDetalle ProcesarCotizacionDetalle(DSMarket.Logica.Entidades.EntidadesServicio.ECotizacionDetalle Item, string Accion) {
            ObjData.CommandTimeout = 999999999;

            DSMarket.Logica.Entidades.EntidadesServicio.ECotizacionDetalle Procesar = null;

            var CotizacionDetalle = ObjData.SP_PROCESAR_INFORMACION_COTIZACION_DETALLE(
                Item.NumeroConector,
                Item.Tipo,
                Item.Precio,
                Item.Descuento,
                Item.Cantidad,
                Item.PorcientoImpuesto,
                Item.SubTotal,
                Item.Impuesto,
                Item.Total,
                Item.IdRegistroRespaldo,
                Item.NumeroConectorItemRespaldo,
                Item.IdTipoProductoRespaldo,
                Item.IdCategoriaRespaldo,
                Item.IdMarcaRespaldo,
                Item.IdTipoSuplidorRespaldo,
                Item.IdSuplidorRespaldo,
                Item.DescripcionRespaldo,
                Item.CodigoBarraRespaldo,
                Item.ReferenciaRespaldo,
                Item.NumeroSeguimientoRespaldo,
                Item.CodigoProductoRespaldo,
                Item.PrecioCompraRespaldo,
                Item.PrecioVentaRespaldo,
                Item.StockRespaldo,
                Item.StockMinimoRespaldo,
                Item.UnidadMedidaRespaldo,
                Item.ModeloRespaldo,
                Item.ColorRespaldo,
                Item.CondicionRespaldo,
                Item.CapacidadRespaldo,
                Item.AplicaParaImpuestoRespaldo,
                Item.TieneImagenRespaldo,
                Item.LlevaGarantiaRespaldo,
                Item.IdTipoGarantiaRespaldo,
                Item.TiempoGarantiaRespaldo,
                Item.ComentarioItemRespaldo,
                Item.UsuarioAdicionaRespaldo,
                Item.FechaAdicionaRespaldo,
                Item.UsuarioModificaRespaldo,
                Item.FechaModificaRespaldo,
                Item.FechaIngresoRespaldo,
                Accion);

            if (CotizacionDetalle != null) {
                Procesar = (from n in CotizacionDetalle
                            select new DSMarket.Logica.Entidades.EntidadesServicio.ECotizacionDetalle
                            {
                                NumeroConector =n.NumeroConector,
                                Tipo = n.Tipo,
                                Precio = n.Precio,
                                Descuento = n.Descuento,
                                Cantidad = n.Cantidad,
                                PorcientoImpuesto = n.PorcientoImpuesto,
                                SubTotal = n.SubTotal,
                                Impuesto = n.Impuesto,
                                Total = n.Total,
                                IdRegistroRespaldo = n.IdRegistroRespaldo,
                                NumeroConectorItemRespaldo = n.NumeroConectorItemRespaldo,
                                IdTipoProductoRespaldo = n.IdTipoProductoRespaldo,
                                IdCategoriaRespaldo = n.IdCategoriaRespaldo,
                                IdMarcaRespaldo = n.IdMarcaRespaldo,
                                IdTipoSuplidorRespaldo = n.IdTipoSuplidorRespaldo,
                                IdSuplidorRespaldo = n.IdSuplidorRespaldo,
                                DescripcionRespaldo = n.DescripcionRespaldo,
                                CodigoBarraRespaldo = n.CodigoBarraRespaldo,
                                ReferenciaRespaldo = n.ReferenciaRespaldo,
                                NumeroSeguimientoRespaldo = n.NumeroSeguimientoRespaldo,
                                CodigoProductoRespaldo = n.CodigoProductoRespaldo,
                                PrecioCompraRespaldo = n.PrecioCompraRespaldo,
                                PrecioVentaRespaldo = n.PrecioVentaRespaldo,
                                StockRespaldo = n.StockRespaldo,
                                StockMinimoRespaldo = n.StockMinimoRespaldo,
                                UnidadMedidaRespaldo = n.UnidadMedidaRespaldo,
                                ModeloRespaldo = n.ModeloRespaldo,
                                ColorRespaldo = n.ColorRespaldo,
                                CondicionRespaldo = n.CondicionRespaldo,
                                CapacidadRespaldo = n.CapacidadRespaldo,
                                AplicaParaImpuestoRespaldo = n.AplicaParaImpuestoRespaldo,
                                TieneImagenRespaldo = n.TieneImagenRespaldo,
                                LlevaGarantiaRespaldo = n.LlevaGarantiaRespaldo,
                                IdTipoGarantiaRespaldo = n.IdTipoGarantiaRespaldo,
                                TiempoGarantiaRespaldo = n.TiempoGarantiaRespaldo,
                                ComentarioItemRespaldo = n.ComentarioItemRespaldo,
                                UsuarioAdicionaRespaldo = n.UsuarioAdicionaRespaldo,
                                FechaAdicionaRespaldo = n.FechaAdicionaRespaldo,
                                UsuarioModificaRespaldo = n.UsuarioModificaRespaldo,
                                FechaModificaRespaldo = n.FechaModificaRespaldo,
                                FechaIngresoRespaldo = n.FechaIngresoRespaldo
                            }).FirstOrDefault();
            }
            return Procesar;
        }
        #endregion
        #region GENERAR LA GANANCIA DE VENTA
        public List<DSMarket.Logica.Entidades.EntidadesServicio.ESacarGananciaFacturacion> GenerarGananciaVenta(decimal? IdFactura = null,decimal? NumeroConector = null, decimal? IdEstatusFacturacion = null, decimal? IdTipoFacturacion = null, decimal? IdTipoPago = null, string Cliente = null, DateTime? FechaDesde = null, DateTime? FechaHasta = null)
        {
            ObjData.CommandTimeout = 999999999;

            var Listado = (from n in ObjData.SP_SACAR_GANANCIA_FACTURACION(IdFactura,NumeroConector, IdEstatusFacturacion, IdTipoFacturacion, IdTipoPago, Cliente, FechaDesde, FechaHasta)
                           select new DSMarket.Logica.Entidades.EntidadesServicio.ESacarGananciaFacturacion
                           {
                               IdEstatusFacturacion=n.IdEstatusFacturacion,
                               Estatus=n.Estatus,
                               IdFactura=n.IdFactura,
                               DescripcionProducto=n.DescripcionProducto,
                               Acumulativo=n.Acumulativo,
                               IdCategoria=n.IdCategoria,
                               Categoria=n.Categoria,
                               TipoProducto=n.TipoProducto,
                               PrecioCompra=n.PrecioCompra,
                               PrecioVenta=n.PrecioVenta,
                               CantidadVendida=n.CantidadVendida,
                               DescuentoAplicado=n.DescuentoAplicado,
                               TotalVenta=n.TotalVenta,
                               TotalPrecioCompra=n.TotalPrecioCompra,
                               Ganancia=n.Ganancia
                           }).ToList();
            return Listado;
        }
        #endregion
        #region MANTENIMIENTO DE OBSERVACIONES
        //LISTADO DE OBSERVACIONES
        public List<DSMarket.Logica.Entidades.EntidadesServicio.EObservaciones> BuscaObservaciones(int? IdObservacion = null) {
            ObjData.CommandTimeout = 999999999;

            var Listado = (from n in ObjData.SP_BUSCA_OBSERVACIONES(IdObservacion)
                           select new DSMarket.Logica.Entidades.EntidadesServicio.EObservaciones
                           {
                               IdObServacion=n.IdObServacion,
                               Observacion=n.Observacion
                           }).ToList();
            return Listado;
        }
        //MANTENIMIENTO DE OBSERVACION
        public DSMarket.Logica.Entidades.EntidadesServicio.EObservaciones MantenimientoObservacion(DSMarket.Logica.Entidades.EntidadesServicio.EObservaciones Item, string Accion) {

            ObjData.CommandTimeout = 999999999;

            DSMarket.Logica.Entidades.EntidadesServicio.EObservaciones Mantenimiento = null;

            var Observacion = ObjData.SP_MODIFICAR_OBSERVACION(
               Item.IdObServacion,
               Item.Observacion,
               Accion);
            if (Observacion != null) {
                Mantenimiento = (from n in Observacion
                                 select new DSMarket.Logica.Entidades.EntidadesServicio.EObservaciones
                                 {
                                     IdObServacion=n.IdObservacion,
                                     Observacion=n.Observacion
                                 }).FirstOrDefault();
            }
            return Mantenimiento;
        }
        #endregion
        #region MANTENIMIENTO DE TIPO DE TIEMPO DE GARANTIA
        //LISTADO DE TIPO DE TIEMPO DE GARANTIA
        public List<DSMarket.Logica.Entidades.EntidadesServicio.ETipoTiempoGarantia> BuscaTipoTiempoGarantia(int? IdTipoTiempoGarantia = null) {
            ObjData.CommandTimeout = 999999999;

            var Listado = (from n in ObjData.SP_BUSCA_TIPO_TIEMPO_GARANTIA(IdTipoTiempoGarantia)
                           select new DSMarket.Logica.Entidades.EntidadesServicio.ETipoTiempoGarantia
                           {
                               IdTipoTiempoGarantia=n.IdTipoTiempoGarantia,
                               TipoTiempoGarantia=n.TipoTiempoGarantia,
                               TiempoGarantia=n.TiempoGarantia
                           }).ToList();
            return Listado;
        }

        public DSMarket.Logica.Entidades.EntidadesServicio.ETipoTiempoGarantia ModificarTipoTiempoGaranta(DSMarket.Logica.Entidades.EntidadesServicio.ETipoTiempoGarantia Item, string Accion) {
            ObjData.CommandTimeout = 999999999;

            DSMarket.Logica.Entidades.EntidadesServicio.ETipoTiempoGarantia Modificar = null;

            var TipoTiempoGarantia = ObjData.SP_MODIFICAR_TIPO_TIEMPO_GARANTIA(
                Item.IdTipoTiempoGarantia,
                Item.TipoTiempoGarantia,
                Item.TiempoGarantia,
                Accion);
            if (TipoTiempoGarantia != null) {
                Modificar = (from n in TipoTiempoGarantia
                             select new DSMarket.Logica.Entidades.EntidadesServicio.ETipoTiempoGarantia
                             {
                                 IdTipoTiempoGarantia=n.IdTipoTiempoGarantia,
                                 TipoTiempoGarantia=n.TipoTiempoGarantia,
                                 TiempoGarantia=n.TiempoGarantia
                             }).FirstOrDefault();
            }
            return Modificar;
        }
        #endregion
        #region MANTENIMIENTO DE MONEDA
        /// <summary>
        /// Busca el listado de las monedas registradas en el sistema
        /// </summary>
        /// <param name="IdMoneda"></param>
        /// <param name="Moneda"></param>
        /// <param name="NumeroPagina"></param>
        /// <param name="NumeroRegistro"></param>
        /// <returns></returns>
        public List<DSMarket.Logica.Entidades.EntidadesServicio.EMoneda> BuscaMOneda(decimal? IdMoneda = null, string Moneda = null, int? NumeroPagina = 1, int? NumeroRegistro = 10) {
            ObjData.CommandTimeout = 999999999;

            var Listado = (from n in ObjData.SP_BUSCA_MONEDAS(IdMoneda, Moneda, NumeroPagina, NumeroRegistro)
                           select new DSMarket.Logica.Entidades.EntidadesServicio.EMoneda
                           {
                               IdMoneda=n.IdMoneda,
                               Moneda=n.Moneda,
                               Sigla=n.Sigla,
                               Estatus0=n.Estatus0,
                               Estatus=n.Estatus,
                               Tasa=n.Tasa,
                               UsuarioAdiciona=n.UsuarioAdiciona,
                               CreadoPor=n.CreadoPor,
                               FechaAdiciona=n.FechaAdiciona,
                               FechaCreado=n.FechaCreado,
                               UsuarioModifica=n.UsuarioModifica,
                               ModificadoPor=n.ModificadoPor,
                               FechaModifica=n.FechaModifica,
                               FechaModificado=n.FechaModificado,
                               PorDefecto0=n.PorDefecto0,
                               PorDefecto=n.PorDefecto
                           }).ToList();
            return Listado;
        }

        /// <summary>
        /// Procesar Informacion de las monedas
        /// </summary>
        /// <param name="Item"></param>
        /// <param name="Accion"></param>
        /// <returns></returns>
        public DSMarket.Logica.Entidades.EntidadesServicio.EMoneda ProcesarMonedas(DSMarket.Logica.Entidades.EntidadesServicio.EMoneda Item, string Accion){
            ObjData.CommandTimeout = 999999999;

            DSMarket.Logica.Entidades.EntidadesServicio.EMoneda Procesar = null;

            var Moneda = ObjData.SP_PROCESAR_INFORMACION_MONEDA(
                Item.IdMoneda,
                Item.Moneda,
                Item.Sigla,
                Item.Estatus0,
                Item.Tasa,
                Item.UsuarioAdiciona,
                Item.PorDefecto0,
                Accion);
            if (Moneda  != null) {
                Procesar = (from n in Moneda
                            select new DSMarket.Logica.Entidades.EntidadesServicio.EMoneda
                            {
                                IdMoneda=n.IdMoneda,
                                Moneda=n.Descripcion,
                                Sigla=n.Sigla,
                                Estatus0=n.Estatus,
                                Tasa=n.Tasa,
                                UsuarioAdiciona=n.UsuarioAdiciona,
                                FechaAdiciona=n.FechaAdiciona,
                                UsuarioModifica=n.UsuarioModifica,
                                FechaModifica=n.FechaModifica,
                                PorDefecto0=n.PorDefecto
                            }).FirstOrDefault();
            }
            return Procesar;
        
        }
        #endregion
        #region COMISIONES DE EMPLEADOS
        public List<DSMarket.Logica.Entidades.EntidadesServicio.EComisionesEmpleados> BuscaComisionesEmpleado(decimal? IdRegistro = null, decimal? IdEmpleado = null, decimal? IdTipoProducto = null, DateTime? FechaDesde = null, DateTime? FechaHasta = null,bool? Estatus =null, decimal? IdProducto = null,decimal? NumeroConectorProducto = null,decimal? NumeroConectorOperacion = null, int? Numeropagina = null, int? NumeroRegistros = null)
        {
            ObjData.CommandTimeout = 999999999;

            var Buscar = (from n in ObjData.SP_BUSCA_COMISIONES_EMPLEADOS(IdRegistro, IdEmpleado, IdTipoProducto, FechaDesde, FechaHasta, Estatus,IdProducto,NumeroConectorProducto,NumeroConectorOperacion, Numeropagina, NumeroRegistros)
                          select new DSMarket.Logica.Entidades.EntidadesServicio.EComisionesEmpleados
                          {
                              IdRegistro=n.IdRegistro,
                              IdEmpleado=n.IdEmpleado,
                              Empleado=n.Empleado,
                              IdTipoProducto=n.IdTipoProducto,
                              TipoProducto=n.TipoProducto,
                              PrecioProducto=n.PrecioProducto,
                              DescuentoAplicado=n.DescuentoAplicado,
                              ComisionEmpleado=n.ComisionEmpleado,
                              ComisionPagar=n.ComisionPagar,
                              NumeroConectorOperacion=n.NumeroConectorOperacion,
                              IdProducto=n.IdProducto,
                              ConectorProducto=n.ConectorProducto,
                              Fecha=n.Fecha,
                              FechaProceso=n.FechaProceso,
                              Estatus0=n.Estatus0,
                              Estatus=n.Estatus,
                              CantidadRegistros=n.CantidadRegistros,
                              CantidadVentas=n.CantidadVentas,
                              CantidadServicios=n.CantidadServicios
                          }).ToList();
            return Buscar;

        }
        public DSMarket.Logica.Entidades.EntidadesServicio.EComisionesEmpleados ProcesarComsionEmpleados(DSMarket.Logica.Entidades.EntidadesServicio.EComisionesEmpleados Item, string Accion) {
            ObjData.CommandTimeout = 999999999;

            DSMarket.Logica.Entidades.EntidadesServicio.EComisionesEmpleados Procesar = null;

            var ComisionEmpleado = ObjData.SP_PROCESAR_COMISION_EMPLEADOS(
                Item.IdRegistro,
                Item.IdEmpleado,
                Item.IdTipoProducto,
                Item.PrecioProducto,
                Item.DescuentoAplicado,
                Item.ComisionEmpleado,
                Item.NumeroConectorOperacion,
                Item.IdProducto,
                Item.ConectorProducto,
                Item.Estatus0,
                Accion);
            if (ComisionEmpleado != null) {
                Procesar = (from n in ComisionEmpleado
                            select new DSMarket.Logica.Entidades.EntidadesServicio.EComisionesEmpleados
                            {
                                IdRegistro=n.IdRegistro,
                                IdEmpleado=n.IdEmpleado,
                                IdTipoProducto=n.IdTipoProducto,
                                PrecioProducto=n.PrecioProducto,
                                DescuentoAplicado=n.DescuentoAplicado,
                                ComisionEmpleado=n.ComisionEmpleado,
                                NumeroConectorOperacion=n.NumeroConectorOperacion,
                                IdProducto=n.IdProducto,
                                ConectorProducto=n.ConectorProducto,
                                Fecha=n.Fecha
                            }).FirstOrDefault();
            }
            return Procesar;
        }
        #endregion
        #region SACAR EL NUMERO DE LA FACTURA
        public List<DSMarket.Logica.Entidades.EntidadesServicio.ESacarNumeroFactura> SacarNumeroFactura(string NumeroConector = null) {
            ObjData.CommandTimeout = 999999999;

            var Numero = (from n in ObjData.SP_SACAR_NUMERO_FACTURA(NumeroConector)
                          select new DSMarket.Logica.Entidades.EntidadesServicio.ESacarNumeroFactura
                          {
                              NumeroFactura=n.NumeroFactura
                          }).ToList();
            return Numero;
        }
        #region SACAR EL NUMERO DE LA COTIZACION
        public List<DSMarket.Logica.Entidades.EntidadesServicio.ESacarNumeroCotizacion> SacarNumeroCotizacion(string NumeroConector) {
            ObjData.CommandTimeout = 999999999;

            var Numero = (from n in ObjData.SP_SACAR_NUMERO_COTIZACION(NumeroConector)
                          select new DSMarket.Logica.Entidades.EntidadesServicio.ESacarNumeroCotizacion
                          {
                           NumeroCotizacion=n.NumeroCotizacion   
                          }).ToList();
            return Numero;
        }
        #endregion
        #endregion

        #region BUSCAR FACTURA MEDIANTE IMEI
        /// <summary>
        /// Este metodo es para buscar el numero de factura mediante el imei
        /// </summary>
        /// <param name="Imei"></param>
        /// <returns></returns>
        public List<DSMarket.Logica.Entidades.EntidadesServicio.EBuscarFacturaMedianteImei> BuscarFacturaMedianteImei(string Imei = null) {

            ObjData.CommandTimeout = 999999999;

            var Registro = (from n in ObjData.SP_BUSCAR_NUMERO_FACTURA_MEDIANTE_IMEI(Imei)
                            select new DSMarket.Logica.Entidades.EntidadesServicio.EBuscarFacturaMedianteImei
                            {
                                NumeroConector=n.NumeroConector,
                                NumeroFactura=n.NumeroFactura,
                                Imei=n.Imei,
                                Equipo=n.Equipo,
                                FacturadoA=n.FacturadoA,
                                Fecha=n.Fecha,
                                Hora=n.Hora
                            }).ToList();
            return Registro;
        }
        #endregion

    }
}
