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
        public List<DSMarket.Logica.Entidades.EntidadesServicio.EFacturacionPreview> BuscaFacturacionPreview(decimal? IdUsuario = null, string NumeroConector = null) {
            ObjData.CommandTimeout = 999999999;

            var BuscarListado = (from n in ObjData.SP_BUSCAR_FACTURACION_PREVIEW(IdUsuario, NumeroConector)
                                 select new DSMarket.Logica.Entidades.EntidadesServicio.EFacturacionPreview
                                 {
                                     IdUsuario=n.IdUsuario,
                                     NumeroConector=n.NumeroConector,
                                     IdProducto=n.IdProducto,
                                     IdTipoProducto=n.IdTipoProducto,
                                     Precio=n.Precio,
                                     DescuentoAplicado=n.DescuentoAplicado,
                                     Cantidad=n.Cantidad,
                                     SubTotal=n.SubTotal,
                                     Impuesto=n.Impuesto,
                                     Total=n.Total,
                                     TotalProdctos=n.TotalProdctos,
                                     TotalServicios=n.TotalServicios,
                                     TotalItems=n.TotalItems,
                                     SubTotal1=n.SubTotal,
                                     TotalDescuento=n.TotalDescuento,
                                     TotalImpuesto=n.TotalImpuesto,
                                     TotalGeneral=n.TotalGeneral
                                 }).ToList();
            return BuscarListado;
        }

        public DSMarket.Logica.Entidades.EntidadesServicio.EFacturacionPreview ProcesarDatosFacturacionPreview(DSMarket.Logica.Entidades.EntidadesServicio.EFacturacionPreview Item, string Accion) {
            ObjData.CommandTimeout = 999999999;

            DSMarket.Logica.Entidades.EntidadesServicio.EFacturacionPreview Procesar = null;

            var FacturacionPreview = ObjData.SP_PROCESAR_INFORMACION_FACTURA_PREVIEW(
                Item.IdUsuario,
                Item.NumeroConector,
                Item.IdProducto,
                Item.IdTipoProducto,
                Item.Precio,
                Item.DescuentoAplicado,
                Item.Cantidad,
                Item.SubTotal,
                Item.Impuesto,
                Item.Total,
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
                                DescuentoAplicado=n.DescuentoAplicado,
                                Cantidad=n.Cantidad,
                                SubTotal=n.SubTotal,
                                Impuesto=n.Impuesto,
                                Total=n.Total
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


    }
}
