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
        /// Este metodo es para mostrar el listado de las facturas minimizadas mediante el usuario
        /// </summary>
        /// <param name="IdUsuario"></param>
        /// <param name="NumeroConector"></param>
        /// <param name="Nombre"></param>
        /// <param name="Rnc"></param>
        /// <returns></returns>
        public List<DSMarket.Logica.Entidades.EntidadesServicio.EFacturaMinimizada> BuscaFacturasMinimizadas(decimal? IdUsuario = null, decimal? NumeroConector = null, decimal? Secuencial = null, string Nombre = null, string Rnc = null)
        {
            ObjData.CommandTimeout = 999999999;

            var Listado = (from n in ObjData.SP_BUSCA_FACTURA_MINIMIZADAS(IdUsuario, NumeroConector, Secuencial, Nombre, Rnc)
                           select new DSMarket.Logica.Entidades.EntidadesServicio.EFacturaMinimizada
                           {
                               IdUsuario = n.IdUsuario,
                               Usuario = n.Usuario,
                               NumeroConector = n.NumeroConector,
                               Secuencia = n.Secuencia,
                               AgregarCliente = n.AgregarCliente,
                               BuscarCliente = n.BuscarCliente,
                               IdTipoVenta = n.IdTipoVenta,
                               TipoVenta = n.TipoVenta,
                               IdCantidadDias = n.IdCantidadDias,
                               CantidadDias = n.CantidadDias,
                               RncConsulta = n.RncConsulta,
                               IdComprobante = n.IdComprobante,
                               Comprobante = n.Comprobante,
                               Nombre = n.Nombre,
                               Telefono = n.Telefono,
                               Email = n.Email,
                               NoCotizacion = n.NoCotizacion,
                               IdTipoIdentificacion = n.IdTipoIdentificacion,
                               TipoIdentificacion = n.TipoIdentificacion,
                               NumeroIdentificacion = n.NumeroIdentificacion,
                               Comentario = n.Comentario,
                               MontoCredito = n.MontoCredito,
                               FacturarCotizar = n.FacturarCotizar,
                               FacturaPuntoVenta = n.FacturaPuntoVenta,
                               FormatoFactura = n.FormatoFactura,
                               BloqueaControles = n.BloqueaControles,
                               Cantidadregistros = n.Cantidadregistros
                           }).ToList();
            return Listado;
        }
        /// <summary>
        /// Este metodo es para realziar el mantenimiento de las facturas minimizadas
        /// </summary>
        /// <param name="Item"></param>
        /// <param name="Accion"></param>
        /// <returns></returns>
        public DSMarket.Logica.Entidades.EntidadesServicio.EFacturaMinimizada MantenimientoFacturaMinimizado(DSMarket.Logica.Entidades.EntidadesServicio.EFacturaMinimizada Item, string Accion)
        {
            ObjData.CommandTimeout = 999999999;

            DSMarket.Logica.Entidades.EntidadesServicio.EFacturaMinimizada Mantenimiento = null;

            var FacturasMinimizadas = ObjData.SP_MANTENIMIENTO_FACTURAS_MINIMUZADAS(
                Item.IdUsuario,
                Item.NumeroConector,
                Item.Secuencia,
                Item.AgregarCliente,
                Item.BuscarCliente,
                Item.IdTipoVenta,
                Item.IdCantidadDias,
                Item.RncConsulta,
                Item.IdComprobante,
                Item.Nombre,
                Item.Telefono,
                Item.Email,
                Item.NoCotizacion,
                Item.IdTipoIdentificacion,
                Item.NumeroIdentificacion,
                Item.Comentario,
                Item.MontoCredito,
                Item.FacturarCotizar,
                Item.FacturaPuntoVenta,
                Item.FormatoFactura,
                Item.BloqueaControles,
                Accion);
            if (FacturasMinimizadas != null)
            {
                Mantenimiento = (from n in FacturasMinimizadas
                                 select new DSMarket.Logica.Entidades.EntidadesServicio.EFacturaMinimizada
                                 {
                                     IdUsuario = n.IdUsuario,
                                     NumeroConector = n.NumeroConector,
                                     Secuencia = n.Secuencial,
                                     AgregarCliente = n.AgregarCliente,
                                     BuscarCliente = n.BuscarCliente,
                                     IdTipoVenta = n.IdTipoVenta,
                                     IdCantidadDias = n.IdCantidadDias,
                                     RncConsulta = n.RncConsulta,
                                     IdComprobante = n.IdComprobante,
                                     Nombre = n.Nombre,
                                     Telefono = n.Telefono,
                                     Email = n.Email,
                                     NoCotizacion = n.NoCotizacion,
                                     IdTipoIdentificacion = n.IdTipoIdentificacion,
                                     NumeroIdentificacion = n.NumeroIdentificacion,
                                     Comentario = n.Comentario,
                                     MontoCredito = n.MontoCredito,
                                     FacturarCotizar = n.FacturarCotizar,
                                     FacturaPuntoVenta = n.FacturaPuntoVenta,
                                     FormatoFactura = n.FormatoFactura,
                                     BloqueaControles = n.BloqueaControles
                                 }).FirstOrDefault();
            }
            return Mantenimiento;


        }

        public DSMarket.Logica.Entidades.EntidadesServicio.EFacturacionClientes GuardarFacturacionClientes(DSMarket.Logica.Entidades.EntidadesServicio.EFacturacionClientes Items, string Accion)
        {
            ObjData.CommandTimeout = 999999999;

            DSMarket.Logica.Entidades.EntidadesServicio.EFacturacionClientes Guardar = null;

            var FacturacionCliente = ObjData.SP_GUARDAR_CLIENTE_FACTURACION(
                Items.IdFactura,
                Items.NumeroConector,
                Items.IdEstatusFacturacion,
                Items.IdComprobante,
                Items.Nombre,
                Items.Telefono,
                Items.Email,
                Items.IdTipoIdentificacion,
                Items.NumeroIdentificacion,
                Items.Direccion,
                Items.Comentario,
                Items.IdTipoVenta,
                Items.IdCantidadDias,
                Items.IdUsuario,
                Items.AplicaGarantia,
                Items.DiasGarantia,
                Accion);
            if (FacturacionCliente != null) {
                Guardar = (from n in FacturacionCliente
                           select new DSMarket.Logica.Entidades.EntidadesServicio.EFacturacionClientes
                           {
                               IdFactura = n.IdFactura,
                               NumeroConector = n.NumeroConector,
                               IdEstatusFacturacion = n.IdEstatusFacturacion,
                               IdComprobante = n.IdComprobante,
                               Nombre = n.Nombre,
                               Telefono = n.Telefono,
                               Email = n.Email,
                               IdTipoIdentificacion = n.IdTipoIdentificacion,
                               NumeroIdentificacion = n.NumeroIdentificacion,
                               Direccion = n.Direccion,
                               Comentario = n.Comentario,
                               IdTipoVenta = n.IdTipoVenta,
                               IdCantidadDias = n.IdCantidadDias,
                               IdUsuario = n.IdUsuario,
                               FechaFacturacion=n.FechaFacturacion,
                               AplicaGarantia=n.AplicaGarantia,
                               DiasGarantia=n.DiasGarantia
                           }).FirstOrDefault();
            }
            return Guardar;
        }


        public List<DSMarket.Logica.Entidades.EntidadesServicio.EFacturacionEspejo> BuscaFacturacionEspeo(Nullable<decimal> IdUsuario = null)
        {
            ObjData.CommandTimeout = 999999999;

            var Listado = (from n in ObjData.SP_BUSCA_FACTURACION_ESPEJO(IdUsuario)
                           select new DSMarket.Logica.Entidades.EntidadesServicio.EFacturacionEspejo
                           {
                               IdUsuario = n.IdUsuario,
                               NumeroConector = n.NumeroConector,
                               AgregarCliente = n.AgregarCliente,
                               BuscarCliente = n.BuscarCliente,
                               IdTipoVenta = n.IdTipoVenta,
                               TipoVenta = n.TipoVenta,
                               IdCantidadDias = n.IdCantidadDias,
                               CantidadDias = n.CantidadDias,
                               RncConsulta = n.RncConsulta,
                               IdComprobante = n.IdComprobante,
                               Comprobante = n.Comprobante,
                               Nombre = n.Nombre,
                               Telefono = n.Telefono,
                               Email = n.Email,
                               NoCotizacion = n.NoCotizacion,
                               IdTipoIdentificacion = n.IdTipoIdentificacion,
                               TipoIdentificacion = n.TipoIdentificacion,
                               NumeroIdentificacion = n.NumeroIdentificacion,
                               Comentario = n.Comentario,
                               MontoCredito = n.MontoCredito,
                               FacturarCotizar = n.FacturarCotizar,
                               FacturaPuntoVenta = n.FacturaPuntoVenta,
                               FormatoFactura = n.FormatoFactura,
                               BloqueaControles = n.BloqueaControles
                           }).ToList();
            return Listado;
        }

        public DSMarket.Logica.Entidades.EntidadesServicio.EFacturacionEspejo ManteniientoFacturacionEspejo(DSMarket.Logica.Entidades.EntidadesServicio.EFacturacionEspejo Item, string Accion)
        {
            ObjData.CommandTimeout = 999999999;

            DSMarket.Logica.Entidades.EntidadesServicio.EFacturacionEspejo Mantenimiento = null;

            var FacturacionEspejo = ObjData.SP_MANTENIMIENTO_FACTURACION_ESPEJO(
                Item.IdUsuario,
                Item.NumeroConector,
                Item.AgregarCliente,
                Item.BuscarCliente,
                Item.IdTipoVenta,
                Item.IdCantidadDias,
                Item.RncConsulta,
                Item.IdComprobante,
                Item.Nombre,
                Item.Telefono,
                Item.Email,
                Item.NoCotizacion,
                Item.IdTipoIdentificacion,
                Item.NumeroIdentificacion,
                Item.Comentario,
                Item.MontoCredito,
                Item.FacturarCotizar,
                Item.FacturaPuntoVenta,
                Item.FormatoFactura,
                Item.BloqueaControles,
                Accion);
            if (FacturacionEspejo != null)
            {
                Mantenimiento = (from n in FacturacionEspejo
                                 select new DSMarket.Logica.Entidades.EntidadesServicio.EFacturacionEspejo
                                 {
                                     IdUsuario = n.IdUsuario,
                                     NumeroConector = n.NumeroConector,
                                     AgregarCliente = n.AgregarCliente,
                                     BuscarCliente = n.BuscarCliente,
                                     IdTipoVenta = n.IdTipoVenta,
                                     IdCantidadDias = n.IdCantidadDias,
                                     RncConsulta = n.RncConsulta,
                                     IdComprobante = n.IdComprobante,
                                     Nombre = n.Nombre,
                                     Telefono = n.Telefono,
                                     Email = n.Email,
                                     NoCotizacion = n.NoCotizacion,
                                     IdTipoIdentificacion = n.IdTipoIdentificacion,
                                     NumeroIdentificacion = n.NumeroIdentificacion,
                                     Comentario = n.Comentario,
                                     MontoCredito = n.MontoCredito,
                                     FacturarCotizar = n.FacturarCotizar,
                                     FacturaPuntoVenta = n.FacturaPuntoVenta,
                                     FormatoFactura = n.FormatoFactura,
                                     BloqueaControles = n.BloqueaControles
                                 }).FirstOrDefault();
            }
            return Mantenimiento;
        }

        public DSMarket.Logica.Entidades.EntidadesServicio.EFacturacionProducto GuardarFacturacionProductos(DSMarket.Logica.Entidades.EntidadesServicio.EFacturacionProducto Item, string Accion) {

            ObjData.CommandTimeout = 999999999;

            DSMarket.Logica.Entidades.EntidadesServicio.EFacturacionProducto Guardar = null;

            var FacturacionProducto = ObjData.SP_GUARDAR_FACTURACION_PRODUCTO(
                Item.NumeroConector,
                Item.IdTipoProducto,
                Item.IdCategoria,
                Item.DescripcionProducto,
                Item.CantidadVendida,
                Item.Precio,
                Item.DescuentoAplicado,
                Item.DescripcionTipoProducto,
                Item.PorcientoDescuento,
                Item.IdProducto,
                Item.Acumulativo,
                Item.ConectorProducto,
                Item.Impuesto,
                Accion);
            if (FacturacionProducto != null) {
                Guardar = (from n in FacturacionProducto
                           select new DSMarket.Logica.Entidades.EntidadesServicio.EFacturacionProducto
                           {
                               NumeroConector = n.NumeroConector,
                               IdTipoProducto = n.IdTipoProducto,
                               IdCategoria = n.IdCategoria,
                               DescripcionProducto = n.DescripcionProducto,
                               CantidadVendida = n.CantidadVendida,
                               Precio = n.Precio,
                               DescuentoAplicado = n.DescuentoAplicado,
                               DescripcionTipoProducto = n.DescripcionTipoProducto,
                               PorcientoDescuento = n.PorcientoDescuento,
                               IdProducto = n.IdProducto,
                               Acumulativo = n.Acumulativo,
                               ConectorProducto = n.ConectorProducto,
                               Impuesto=n.Impuesto,
                           }).FirstOrDefault();
            }
            return Guardar;
        }
        public List<DSMarket.Logica.Entidades.EntidadesServicio.EProductosAgregados> BuscapRoductosAgregados(decimal? IdProducto = null, decimal? NumeroConector = null) {
            ObjData.CommandTimeout = 999999999;

            var Listado = (from n in ObjData.SP_BUSCA_PRODUCTOS_AGREGADOS(IdProducto, NumeroConector)
                           select new DSMarket.Logica.Entidades.EntidadesServicio.EProductosAgregados
                           {
                               NumeroConector = n.NumeroConector,
                               IdTipoProducto = n.IdTipoProducto,
                               DescripcionTipoProducto = n.DescripcionTipoProducto,
                               IdCategoria = n.IdCategoria,
                               Categoria = n.Categoria,
                               DescripcionProducto = n.DescripcionProducto,
                               Precio = n.Precio,
                               Cantidad = n.Cantidad,
                               DescuentoAplicado = n.DescuentoAplicado,
                               Total = n.Total,
                               DescripcionTipoProducto1 = n.DescripcionTipoProducto1,
                               PorcientoDescuento = n.PorcientoDescuento,
                               Acumulativo = n.Acumulativo,
                               IdProducto = n.IdProducto,
                               ConectorProducto = n.ConectorProducto,
                               AplicaImpuesto = n.AplicaImpuesto,
                               Impuesto = n.Impuesto,
                               CantidadProductos = n.CantidadProductos,
                               CantidadServicios = n.CantidadServicios,
                               CantidadRegistros = n.CantidadRegistros,
                               TotalDescuento = n.TotalDescuento,
                               PorcientoImpuesto = n.PorcientoImpuesto,
                               SubTotal = n.SubTotal,
                               TotalImpuesto = n.TotalImpuesto,
                               TotalGeneral = n.TotalGeneral,
                               
                           }).ToList();
            return Listado;
        }
        /// <summary>
        /// Este metodo es para guardar los datos de los calculos.
        /// </summary>
        /// <param name="Item"></param>
        /// <param name="Accion"></param>
        /// <returns></returns>
        public DSMarket.Logica.Entidades.EntidadesServicio.EGuardarFacturacionCalculos GuardarFacturacionCalculos(DSMarket.Logica.Entidades.EntidadesServicio.EGuardarFacturacionCalculos Item, string Accion) {
            ObjData.CommandTimeout = 999999999;

            DSMarket.Logica.Entidades.EntidadesServicio.EGuardarFacturacionCalculos Guardar = null;

            var FacturacionCalculos = ObjData.SP_GUARDAR_FACTURACION_CALCULOS(
                Item.NumeroColector,
                Item.CantidadProductos,
                Item.CantidadServicios,
                Item.CantidadArticulos,
                Item.TotalDescuento,
                Item.SubTotal,
                Item.Impuesto,
                Item.PorcientoImpuesto,
                Item.MontoPagado,
                Item.Cambio,
                Item.IdTipoPago,
                Item.TotalGeneral,
                Accion);
            if (FacturacionCalculos != null)
            {
                Guardar = (from n in FacturacionCalculos
                           select new DSMarket.Logica.Entidades.EntidadesServicio.EGuardarFacturacionCalculos
                           {
                               NumeroColector = n.NumeroColector,
                               CantidadProductos = n.CantidadProductos,
                               CantidadServicios = n.CantidadServicios,
                               CantidadArticulos = n.CantidadArticulos,
                               TotalDescuento = n.TotalDescuento,
                               SubTotal = n.SubTotal,
                               Impuesto = n.Impuesto,
                               PorcientoImpuesto = n.PorcientoImpuesto,
                               MontoPagado = n.MontoPagado,
                               Cambio = n.Cambio,
                               IdTipoPago = n.IdTipoPago,
                               TotalGeneral=n.TotalGeneral
                           }).FirstOrDefault();
            }
            return Guardar;
        }

        public DSMarket.Logica.Entidades.EntidadesServicio.EGuardarFacturacionComprobantes GuardarFacturacionComprobante (DSMarket.Logica.Entidades.EntidadesServicio.EGuardarFacturacionComprobantes Item, string Accion){
            ObjData.CommandTimeout = 999999999;

            DSMarket.Logica.Entidades.EntidadesServicio.EGuardarFacturacionComprobantes Guardar = null;

            var FacturacionComprobante = ObjData.SP_GUARDAR_FACTURACION_COMPROBANTE(
                Item.IdFacturacion,
                Item.NumeroConector,
                Item.DescripcionComprobante,
                Item.Comprobante,
                Accion);
            if (FacturacionComprobante != null) {
                Guardar = (from n in FacturacionComprobante
                           select new DSMarket.Logica.Entidades.EntidadesServicio.EGuardarFacturacionComprobantes
                           {
                               IdFacturacion=n.IdFacturacion,
                               NumeroConector=n.NumeroConector,
                               DescripcionComprobante=n.DescripcionComprobante,
                               Comprobante=n.Comprobante
                           }).FirstOrDefault();
            }
            return Guardar;
        }

        public List<DSMarket.Logica.Entidades.EntidadesServicio.ESacarNumeroFactura> SacarNumeroFactura(decimal? NumeroConector = null) {
            ObjData.CommandTimeout = 999999999;

            var BuscarNumero = (from n in ObjData.SP_SACAR_NUMERO_FACTURA(NumeroConector)
                                select new DSMarket.Logica.Entidades.EntidadesServicio.ESacarNumeroFactura
                                {
                                    IdFactura=n.IdFactura
                                }).ToList();
            return BuscarNumero;
        }

       
        #endregion
        #region BUSCAR LOS REGISTROS DEL HISTORIAL DE PRODUCTOS
        public List<DSMarket.Logica.Entidades.EntidadesServicio.EBuscaHistorialProducto> BuscaHistorialProducto(decimal? IdHistorialProducto = null, decimal? IdProducto = null) {
            ObjData.CommandTimeout = 999999999;

            var Listado = (from n in ObjData.SP_BUSCA_HISTORIAL_PRODUCTO(IdHistorialProducto, IdProducto)
                           select new DSMarket.Logica.Entidades.EntidadesServicio.EBuscaHistorialProducto
                           {
                              IdHistorialProducto=n.IdHistorialProducto,
                               IdProducto=n.IdProducto,
                               NumeroConector=n.NumeroConector,
                               IdTipoProducto=n.IdTipoProducto,
                               TipoProducto=n.TipoProducto,
                               IdCategoria=n.IdCategoria,
                               Categoria=n.Categoria,
                               IdUnidadMedida=n.IdUnidadMedida,
                               UnidadMedida=n.UnidadMedida,
                               IdMarca=n.IdMarca,
                               Marca=n.Marca,
                               IdModelo=n.IdModelo,
                               Modelo=n.Modelo,
                               IdTipoSuplidor=n.IdTipoSuplidor,
                               TipoSuplidor=n.TipoSuplidor,
                               IdSuplidor=n.IdSuplidor,
                               Suplidor=n.Suplidor,
                               Producto=n.Producto,
                               CodigoBarra=n.CodigoBarra,
                               Referencia=n.Referencia,
                               PrecioCompra=n.PrecioCompra,
                               PrecioVenta=n.PrecioVenta,
                               Stock=n.Stock,
                               StockMinimo=n.StockMinimo,
                               PorcientoDescuento=n.PorcientoDescuento,
                               AfectaOferta=n.AfectaOferta,
                               ProductoAcumulativo0=n.ProductoAcumulativo0,
                               ProductoAcumulativo=n.ProductoAcumulativo,
                               LlevaImagen=n.LlevaImagen,
                               UsuarioAdiciona=n.UsuarioAdiciona,
                               FechaAdiciona=n.FechaAdiciona,
                               UsuarioModifica=n.UsuarioModifica,
                               FechaModifica=n.FechaModifica,
                               Fecha=n.Fecha,
                               Comentario=n.Comentario,
                               AplicaParaimpuesto=n.AplicaParaimpuesto,
                               PrecioOriginal=n.PrecioOriginal
                               
                           }).ToList();
            return Listado;
        }
        #endregion
        #region MANTENIMIENTO DE HISTORIAL DE PRODUCTO
        public DSMarket.Logica.Entidades.EntidadesServicio.EMantenimientoHistorialProductoInventario MantenimientoHistorialProducto(DSMarket.Logica.Entidades.EntidadesServicio.EMantenimientoHistorialProductoInventario Item, string Accion)
        {
            ObjData.CommandTimeout = 999999999;

            DSMarket.Logica.Entidades.EntidadesServicio.EMantenimientoHistorialProductoInventario Mantenimiento = null;

            var HistorialProducto = ObjData.SP_MANTENIMIENTO_HISTORIAL_PRODUCTO_INVENTARIO(
                Item.IdHistorialProducto,
                Item.IdProducto,
                Accion);
            if (HistorialProducto != null) {
                Mantenimiento = (from n in HistorialProducto
                                 select new DSMarket.Logica.Entidades.EntidadesServicio.EMantenimientoHistorialProductoInventario
                                 {
                                     IdHistorialProducto=n.IdHistorialProducto,
                                     IdProducto=n.IdProducto
                                 }).FirstOrDefault();
            }
            return Mantenimiento;
        }


        #endregion
        #region HISTORIAL DE FACTURACION
        public List<DSMarket.Logica.Entidades.EntidadesServicio.EHistorialFacturacion> HistorialFacturacion(decimal? IdFactura = null, decimal? NumeroConector=null, decimal? IdEstatusFacturacion = null, decimal? IdTipoFacturacion = null, decimal? IdTipoPago = null, string Cliente = null, DateTime? FechaDesde = null, DateTime? FechaHasta = null, int? NumeroPagina = null, int? NumeroRegistros = null) {
            ObjData.CommandTimeout = 999999999;

            var Listado = (from n in ObjData.SP_BUSCA_HISTORIAL_FACTURACION(IdFactura,NumeroConector, IdEstatusFacturacion, IdTipoFacturacion, IdTipoPago, Cliente, FechaDesde, FechaHasta, NumeroPagina, NumeroRegistros)
                           select new DSMarket.Logica.Entidades.EntidadesServicio.EHistorialFacturacion
                           {
                               Cliente=n.Cliente,
                               EstatusFacturacion=n.EstatusFacturacion,
                               IdFactura=n.IdFactura,
                               NumeroConector=n.NumeroConector,
                               IdEstatusFacturacion=n.IdEstatusFacturacion,
                               TipoIdentificacion=n.TipoIdentificacion,
                               DescripcionComprobante=n.DescripcionComprobante,
                               Comprobante=n.Comprobante,
                               IdComprobante=n.IdComprobante,
                               Descripcion=n.Descripcion,
                               Telefono=n.Telefono,
                               Email=n.Email,
                               IdTipoIdentificacion = n.IdTipoIdentificacion,
                               NumeroIdentificacion=n.NumeroIdentificacion,
                               Direccion=n.Direccion,
                               Comentario=n.Comentario,
                               IdTipoVenta=n.IdTipoVenta,
                               TipoVenta=n.TipoVenta,
                               CantidadDias=n.CantidadDias,
                               IdCantidadDias=n.IdCantidadDias,
                               IdUsuario=n.IdUsuario,
                               CreadoPor=n.CreadoPor,
                               FechaFacturacion=n.FechaFacturacion,
                               FechaFacturacion0=n.FechaFacturacion0,
                               CantidadProductos=n.CantidadProductos,
                               CantidadServicios=n.CantidadServicios,
                               CantidadArticulos=n.CantidadArticulos,
                               TotalDescuento=n.TotalDescuento,
                               SubTotal=n.SubTotal,
                               Impuesto=n.Impuesto,
                               PorcientoImpuesto=n.PorcientoImpuesto,
                               MontoPagado=n.MontoPagado,
                               Cambio=n.Cambio,
                               IdTipoPago=n.IdTipoPago,
                               TipoPago=n.TipoPago,
                               TotalGeneral=n.TotalGeneral,
                               CantidadRegistros = n.CantidadRegistros,
                               AplicaGarantia0=n.AplicaGarantia0,
                               AplicaGarantia=n.AplicaGarantia,
                               DiasGarantia=n.DiasGarantia
                           }).ToList();
            return Listado;
        }
        #endregion
        #region VALIDAR LAS FACTURAS ANULADAS
        public List<DSMarket.Logica.Entidades.EntidadesServicio.EValidarFacturaAnulada> ValidarFacturaAnulada(decimal? NumeroConector = null) {
            ObjData.CommandTimeout = 999999999;

            var Validar = (from n in ObjData.SP_VALIDAR_FACTURA_ANULADA(NumeroConector)
                           select new DSMarket.Logica.Entidades.EntidadesServicio.EValidarFacturaAnulada
                           {
                               NumeroConector=n.NumeroConector
                           }).ToList();
            return Validar;
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



    }
}
