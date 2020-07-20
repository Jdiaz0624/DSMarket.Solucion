using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Logica.LogicaConfiguracion
{
    public class LogicaCOnfiguracion
    {
        DSMarket.Data.Conexion.ConexionLINQ.BDConexionConfiguracionDataContext ObjData = new Data.Conexion.ConexionLINQ.BDConexionConfiguracionDataContext(System.Configuration.ConfigurationManager.ConnectionStrings["DSMarketConexion"].ConnectionString);

        #region BUSCA LISTAS
        //BUSCA LISTAS
        public List<DSMarket.Logica.Entidades.EntidadesConfiguracion.EListas> BuscaListas(string NombreLista = null, string PrimerFiltro = null, string SegundoFiltro = null, string TerceFiltro = null, string CuartoFiltro = null, string QuintoFiltro = null)
        {
            ObjData.CommandTimeout = 999999999;

            var BuscaListas = (from n in ObjData.SP_BUSCA_LISTAS(NombreLista, PrimerFiltro, SegundoFiltro, TerceFiltro, CuartoFiltro, QuintoFiltro)
                               select new DSMarket.Logica.Entidades.EntidadesConfiguracion.EListas
                               {
                                   Descripcion=n.Descripcion,
                                   PrimerValor=n.PrimerValor,
                                   SegundoValor=n.SegundoValor,
                                   TerceValor=n.TerceValor
                               }).ToList();
            return BuscaListas;
        }
        #endregion
        #region MANTENIMIENTO DE INFORACION DE EMPRESA
        //LISTADO DE INFORMACION DE EMPRESA
        public List<DSMarket.Logica.Entidades.EntidadesConfiguracion.EInformacionEmpresa> BuscaInformacionEmpresa()
        {
            ObjData.CommandTimeout = 999999999;

            var Informacion = (from n in ObjData.SP_SACAR_INFORMACION_EMPRESA()
                               select new DSMarket.Logica.Entidades.EntidadesConfiguracion.EInformacionEmpresa
                               {
                                   IdInformacionEmpresa = n.IdInformacionEmpresa,
                                   NombreEmpresa = n.NombreEmpresa,
                                   RNC = n.RNC,
                                   Direccion = n.Direccion,
                                   Email = n.Email,
                                   Email2 = n.Email2,
                                   Facebook = n.Facebook,
                                   Instagran = n.Instagran,
                                   Telefonos = n.Telefonos,
                                   IdLogoEmpresa = n.IdLogoEmpresa,
                                   LogoEmpresa=n.LogoEmpresa
                               }).ToList();
            return Informacion;
        }

        //MANTENIMIENTO INFORMACION EMPRESA
        public DSMarket.Logica.Entidades.EntidadesConfiguracion.EInformacionEmpresa ModificarInformacionEmpresa(DSMarket.Logica.Entidades.EntidadesConfiguracion.EInformacionEmpresa Item, string Accion)
        {
            ObjData.CommandTimeout = 999999999;

            DSMarket.Logica.Entidades.EntidadesConfiguracion.EInformacionEmpresa Modificar = null;

            var InformacionEmpresa = ObjData.SP_MODIFICAR_INFORMACION_EMPRESA(
                Item.IdInformacionEmpresa,
                Item.NombreEmpresa,
                Item.RNC,
                Item.Direccion,
                Item.Email,
                Item.Email2,
                Item.Facebook,
                Item.Instagran,
                Item.Telefonos,
                Item.IdLogoEmpresa,
                Accion);
            if (InformacionEmpresa != null)
            {
                Modificar = (from n in InformacionEmpresa
                             select new DSMarket.Logica.Entidades.EntidadesConfiguracion.EInformacionEmpresa
                             {
                                 IdInformacionEmpresa=n.IdInformacionEmpresa,
                                 NombreEmpresa=n.NombreEmpresa,
                                 RNC=n.RNC,
                                 Direccion=n.Direccion,
                                 Email=n.Email,
                                 Email2=n.Email2,
                                 Facebook=n.Facebook,
                                 Instagran=n.Instagran,
                                 Telefonos=n.Telefonos,
                                 IdLogoEmpresa=n.IdLogoEmpresa
                             }).FirstOrDefault();
            }
            return Modificar;
        }
        #endregion
        #region MOSTRAR EL LISTADO DE LOS CONFIGURACIONES GENERALES
        public List<DSMarket.Logica.Entidades.EntidadesConfiguracion.EConfiguracionGeneral> BuscaCOnfiguracionGeneral(int? IdConfiguracionGeneral = null)
        {
            ObjData.CommandTimeout = 999999999;

            var Listado = (from n in ObjData.SP_BUSCA_CONFIGURACION_GENERAL(IdConfiguracionGeneral)
                           select new DSMarket.Logica.Entidades.EntidadesConfiguracion.EConfiguracionGeneral
                           {
                               IdConfiguracionGeneral=n.IdConfiguracionGeneral,
                               Descripcion=n.Descripcion,
                               Estatus0=n.Estatus0,
                               Estatus=n.Estatus,
                               CantidadActivos=n.CantidadActivos,
                               CantidadInactivos=n.CantidadInactivos
                           }).ToList();
            return Listado;
        }
        public DSMarket.Logica.Entidades.EntidadesConfiguracion.EConfiguracionGeneral MantenimientoConfiguracionGeneral(DSMarket.Logica.Entidades.EntidadesConfiguracion.EConfiguracionGeneral Item, string Accion) {
            ObjData.CommandTimeout = 999999999;

            DSMarket.Logica.Entidades.EntidadesConfiguracion.EConfiguracionGeneral Mantenimiento = null;

            var ConfiguracionGeneral = ObjData.SP_MANTENIMIENTO_CONFIGURACION_GENERAL(
                Item.IdConfiguracionGeneral,
                Item.Descripcion,
                Item.Estatus0,
                Accion);
            if (ConfiguracionGeneral != null) {
                Mantenimiento = (from n in ConfiguracionGeneral
                                 select new DSMarket.Logica.Entidades.EntidadesConfiguracion.EConfiguracionGeneral
                                 {
                                     IdConfiguracionGeneral=n.IdConfiguracionGeneral,
                                     Descripcion=n.Descripcion,
                                     Estatus0=n.Estatus
                                 }).FirstOrDefault();
            }
            return Mantenimiento;
        }

        public List<DSMarket.Logica.Entidades.EntidadesConfiguracion.EGenerarComprobante> GenerarComprobanteFiscal(decimal? IdComprobante = null) {
            ObjData.CommandTimeout = 999999999;

            var Generar = (from n in ObjData.SP_GENERAR_COMPROBANTE_FISCAL(IdComprobante)
                           select new DSMarket.Logica.Entidades.EntidadesConfiguracion.EGenerarComprobante
                           {
                               TipoComprobante=n.TipoComprobante,
                               Comprobante=n.Comprobante
                           }).ToList();
            return Generar;
        }
        #endregion
        #region GENERAR COMPROBANTE FISCAL
        public List<DSMarket.Logica.Entidades.EntidadesConfiguracion.EGenerarComprobante> GenerarComprobante(decimal? IdComprobante = null) {
            ObjData.CommandTimeout = 999999999;

            var Listado = (from n in ObjData.SP_GENERAR_COMPROBANTE_FISCAL(IdComprobante)
                           select new DSMarket.Logica.Entidades.EntidadesConfiguracion.EGenerarComprobante
                           {
                               TipoComprobante=n.TipoComprobante,
                               Comprobante=n.Comprobante
                           }).ToList();
            return Listado;
        }

        //LISTADO DE COMPROBANTES FISCALES
        public List<DSMarket.Logica.Entidades.EntidadesConfiguracion.EComprobantes> BuscaComprobantesFiscales(decimal? IdComprobanteFiscales = null)
        {
            ObjData.CommandTimeout = 999999999;

            var Listado = (from n in ObjData.SP_BUSCA_COMPROBANTES_FISCALES(IdComprobanteFiscales)
                           select new DSMarket.Logica.Entidades.EntidadesConfiguracion.EComprobantes
                           {
                               IdComprobante=n.IdComprobante,
                               Comprobante=n.Comprobante,
                               Serie=n.Serie,
                               TipoComprobante=n.TipoComprobante,
                               Secuencia=n.Secuencia,
                               SecuenciaInicial=n.SecuenciaInicial,
                               SecuenciaFinal=n.SecuenciaFinal,
                               Limite=n.Limite,
                               Estatus0=n.Estatus0,
                               Estatus=n.Estatus,
                               ValidoHasta=n.ValidoHasta,
                               PorDefecto0=n.PorDefecto0,
                               PorDefecto=n.PorDefecto,
                               Posiciones=n.Posiciones
                           }).ToList();
            return Listado;
        }

        //MANTENIMIENTO DE COMPROBANTES FISCALES
        public DSMarket.Logica.Entidades.EntidadesConfiguracion.EMantenimientoComprobantes MantenimientoComprobantes(DSMarket.Logica.Entidades.EntidadesConfiguracion.EMantenimientoComprobantes Item, string Accion) {
            ObjData.CommandTimeout = 999999999;

            DSMarket.Logica.Entidades.EntidadesConfiguracion.EMantenimientoComprobantes Mantenimiento = null;

            var Comprobante = ObjData.SP_MANTENIMIENTO_COMPROBANTE_FISCALES(
                Item.IdComprobante,
                Item.Descripcion,
                Item.Serie,
                Item.TipoComprobante,
                Item.Secuencia,
                Item.SecuenciaInicial,
                Item.SecuenciaFinal,
                Item.Limite,
                Item.Estatus,
                Item.ValidoHasta,
                Item.PorDefecto,
                Item.Posiciones,
                Accion);
            if (Comprobante != null) {
                Mantenimiento = (from n in Comprobante
                                 select new DSMarket.Logica.Entidades.EntidadesConfiguracion.EMantenimientoComprobantes
                                 {
                                     IdComprobante=n.IdComprobante,
                                     Descripcion=n.Descripcion,
                                     Serie=n.Serie,
                                     TipoComprobante=n.TipoComprobante,
                                     Secuencia=n.Secuencia,
                                     SecuenciaInicial=n.SecuenciaInicial,
                                     SecuenciaFinal=n.SecuenciaFinal,
                                     Limite=n.Limite,
                                     Estatus=n.Estatus,
                                     ValidoHasta=n.ValidoHasta,
                                     PorDefecto=n.PorDefecto,
                                     Posiciones=n.Posiciones
                                 }).FirstOrDefault();
            }
            return Mantenimiento;
        }
        #endregion
        #region MANTENIMEINTO IMPUESTOS
        public List<DSMarket.Logica.Entidades.EntidadesConfiguracion.EImpuesto> BuscaImpuestos(int? IdImpuesto = null) {
            ObjData.CommandTimeout = 999999999;

            var Listado = (from n in ObjData.SP_BUSCA_IMPUESTO_VENTA(IdImpuesto)
                           select new DSMarket.Logica.Entidades.EntidadesConfiguracion.EImpuesto
                           {
                               IdImpuesto=n.IdImpuesto,
                               Descripcion=n.Descripcion,
                               PorcientoImpuesto=n.PorcientoImpuesto,
                               Operacion0=n.Operacion0,
                               Operacion=n.Operacion
                           }).ToList();
            return Listado;
        }
        #endregion

        #region MANTENIMIENTO DE RUTA DE REPORTES
        //LISTADO DE RUTA DE REPORTES
        public List<DSMarket.Logica.Entidades.EntidadesConfiguracion.ERutaReporte> BuscaRutaReporte(int? IdRutaReporte = null) {
            ObjData.CommandTimeout = 999999999;

            var Listado = (from n in ObjData.SP_SACAR_RUTA_REPORTE(IdRutaReporte)
                           select new DSMarket.Logica.Entidades.EntidadesConfiguracion.ERutaReporte
                           {
                               IdReporte=n.IdReporte,
                               Nombre=n.Nombre,
                               RutaReporte=n.RutaReporte
                           }).ToList();
            return Listado;
        }
        //MANTENIMIENTO DE RUTA DE REPORTE
        public DSMarket.Logica.Entidades.EntidadesConfiguracion.ERutaReporte MantenimientoRutaReporte(DSMarket.Logica.Entidades.EntidadesConfiguracion.ERutaReporte Item, string Accion) {
            ObjData.CommandTimeout = 999999999;

            DSMarket.Logica.Entidades.EntidadesConfiguracion.ERutaReporte Mantenimiento = null;

            var RutaReporte = ObjData.SP_MANTENIMIENTO_RUTA_REPORTE(
                Item.IdReporte,
                Item.Nombre,
                Item.RutaReporte,
                Accion);
            if (RutaReporte != null) {
                Mantenimiento = (from n in RutaReporte
                                 select new DSMarket.Logica.Entidades.EntidadesConfiguracion.ERutaReporte
                                 {
                                     IdReporte=n.IdReporte,
                                     Nombre=n.Descripcion,
                                     RutaReporte=n.RutaReporte
                                 }).FirstOrDefault();
            }
            return Mantenimiento;
        }
        #endregion

        #region PROCESAR CUADRE CAJA
        public DSMarket.Logica.Entidades.EntidadesConfiguracion.EProcesarReporteCuadreCaja ProcesarCuadreCaja(DSMarket.Logica.Entidades.EntidadesConfiguracion.EProcesarReporteCuadreCaja Item, string Accion) {
            ObjData.CommandTimeout = 999999999;

            DSMarket.Logica.Entidades.EntidadesConfiguracion.EProcesarReporteCuadreCaja Procesar = null;

            var CuadreCaja = ObjData.SP_PROCESAR_CUADRE_CAJA(
                Item.IdUsuario,
                Item.IdCaja,
                Item.Monto,
                Item.Concepto,
                Item.FechaProcesado,
                Item.FechaDesde,
                Item.FechaHasta,
                Item.NumeroReferencia,
                Item.IdTipoPago,
                Accion);
            if (CuadreCaja != null) {
                Procesar = (from n in CuadreCaja
                            select new DSMarket.Logica.Entidades.EntidadesConfiguracion.EProcesarReporteCuadreCaja
                            {
                                IdUsuario=n.IdUsuario,
                                IdCaja=n.IdCaja,
                                Monto=n.Monto,
                                Concepto=n.Concepto,
                                FechaProcesado=n.FechaProcesado,
                                FechaDesde=n.FechaDesde,
                                FechaHasta=n.FechaHasta,
                                NumeroReferencia=n.NumeroReferencia,
                                IdTipoPago=n.IdTipoPago
                            }).FirstOrDefault();
            }
            return Procesar;
        }
        #endregion
    }
}
