using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                              IdTipoPago=n.IdTipoPago,
                              TipoPago=n.TipoPago,
                              Estatus0=n.Estatus0,
                              Estatus=n.Estatus,
                              UsuarioAdiciona=n.UsuarioAdiciona,
                              CreadPor=n.CreadPor,
                              FechaAdiciona=n.FechaAdiciona,
                              FechaCreado=n.FechaCreado,
                              ModificadoPor=n.ModificadoPor,
                              FechaModifica=n.FechaModifica,
                              FechaModificado=n.FechaModificado,
                              BloqueaMonto0=n.BloqueaMonto0,
                              BloqueaMonto=n.BloqueaMonto,
                              CantidadRegistros=n.CantidadRegistros
                          }).ToList();
            return Buscar;
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
                               Secuencia=n.Secuencia,
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
                                     Secuencia=n.Secuencial,
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
                Accion);
            if (FacturacionCliente != null) {
                Guardar = (from n in FacturacionCliente
                           select new DSMarket.Logica.Entidades.EntidadesServicio.EFacturacionClientes
                           {
                               IdFactura=n.IdFactura,
                               NumeroConector=n.NumeroConector,
                               IdEstatusFacturacion=n.IdEstatusFacturacion,
                               IdComprobante=n.IdComprobante,
                               Nombre=n.Nombre,
                               Telefono=n.Telefono,
                               Email=n.Email,
                               IdTipoIdentificacion=n.IdTipoIdentificacion,
                               NumeroIdentificacion=n.NumeroIdentificacion,
                               Direccion=n.Direccion,
                               Comentario=n.Comentario,
                               IdTipoVenta=n.IdTipoVenta,
                               IdCantidadDias=n.IdCantidadDias,
                               IdUsuario=n.IdUsuario
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
                               IdUsuario=n.IdUsuario,
                               NumeroConector=n.NumeroConector,
                               AgregarCliente=n.AgregarCliente,
                               BuscarCliente=n.BuscarCliente,
                               IdTipoVenta=n.IdTipoVenta,
                               TipoVenta=n.TipoVenta,
                               IdCantidadDias=n.IdCantidadDias,
                               CantidadDias=n.CantidadDias,
                               RncConsulta=n.RncConsulta,
                               IdComprobante=n.IdComprobante,
                               Comprobante=n.Comprobante,
                               Nombre=n.Nombre,
                               Telefono=n.Telefono,
                               Email=n.Email,
                               NoCotizacion=n.NoCotizacion,
                               IdTipoIdentificacion=n.IdTipoIdentificacion,
                               TipoIdentificacion=n.TipoIdentificacion,
                               NumeroIdentificacion=n.NumeroIdentificacion,
                               Comentario=n.Comentario,
                               MontoCredito=n.MontoCredito,
                               FacturarCotizar=n.FacturarCotizar,
                               FacturaPuntoVenta=n.FacturaPuntoVenta,
                               FormatoFactura=n.FormatoFactura,
                               BloqueaControles=n.BloqueaControles
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
                                     IdUsuario=n.IdUsuario,
                                     NumeroConector=n.NumeroConector,
                                     AgregarCliente=n.AgregarCliente,
                                     BuscarCliente=n.BuscarCliente,
                                     IdTipoVenta=n.IdTipoVenta,
                                     IdCantidadDias=n.IdCantidadDias,
                                     RncConsulta=n.RncConsulta,
                                     IdComprobante=n.IdComprobante,
                                     Nombre=n.Nombre,
                                     Telefono=n.Telefono,
                                     Email=n.Email,
                                     NoCotizacion=n.NoCotizacion,
                                     IdTipoIdentificacion=n.IdTipoIdentificacion,
                                     NumeroIdentificacion=n.NumeroIdentificacion,
                                     Comentario=n.Comentario,
                                     MontoCredito=n.MontoCredito,
                                     FacturarCotizar=n.FacturarCotizar,
                                     FacturaPuntoVenta=n.FacturaPuntoVenta,
                                     FormatoFactura=n.FormatoFactura,
                                     BloqueaControles=n.BloqueaControles
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
                           }).FirstOrDefault();
            }
            return Guardar;
        }
        #endregion


    }
}
