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

        #region REPORTES CONTABLES
        //GUARDAR LOS DATOS PARA EL RPEORTE DEL 606
        public DSMarket.Logica.Entidades.EntidadesConfiguracion.EGuardarDatosReporte606 GuardarDatosReporte606(DSMarket.Logica.Entidades.EntidadesConfiguracion.EGuardarDatosReporte606 Item, string Accion) {
            ObjData.CommandTimeout = 999999999;

            DSMarket.Logica.Entidades.EntidadesConfiguracion.EGuardarDatosReporte606 Guardar = null;

            var DatosReporte606 = ObjData.SP_GUARDAR_DATOS_REPORTE_606(
                Item.IdUsuario,
                Item.IdCompraSuplidor,
                Item.IdTipoSuplidor,
                Item.TipoSuplidor,
                Item.IdSuplidor,
                Item.Suplidor,
                Item.RNCCedula,
                Item.IdTipoIdentificacion,
                Item.TipoIdentificacion,
                Item.IdTipoBienesServicios,
                Item.TipoBienesServicios,
                Item.CodigoTipoBienesServicio,
                Item.NCF,
                Item.NCFMODIFICADO,
                Item.FechaComprobante0,
                Item.FechaComprobante,
                Item.FechaPago0,
                Item.FechaPago,
                Item.MontoFacturadoServicios,
                Item.MontoFacturadoBienes,
                Item.TotalMontoFacturado,
                Item.ITBISFacturado,
                Item.ITBISRetenido,
                Item.ITBISSujetoProporcionalidad,
                Item.ITBISLlevadoCosto,
                Item.ITBISPorAdelantar,
                Item.ITBISPercibidoCompras,
                Item.IdTipoRetencionISR,
                Item.TipoRetencionISR,
                Item.CodigoTipoRetencionISR,
                Item.MontoRetencionRenta,
                Item.ISRPercibidoCompras,
                Item.ImpuestoSelectivoConsumo,
                Item.OtrosImpuestosTasa,
                Item.MontoPropinaLegal,
                Item.IdFormaPago,
                Item.FormaPago,
                Item.CodigoTipoPago,
                Item.UsuarioAdiciona,
                Item.CreadoPor,
                Item.FechaCreado0,
                Item.FechaCreado,
                Item.CantidadRegistros,
                Item.ValidadoDesde,
                Item.ValidadoHasta,
                Accion);
            if (DatosReporte606 != null) {

                Guardar = (from n in DatosReporte606
                           select new DSMarket.Logica.Entidades.EntidadesConfiguracion.EGuardarDatosReporte606
                           {
                IdUsuario = n.IdUsuario,
                IdCompraSuplidor = n.IdCompraSuplidor,
                IdTipoSuplidor=n.IdTipoSuplidor,
                TipoSuplidor = n.TipoSuplidor,
                IdSuplidor = n.IdSuplidor,
                Suplidor = n.Suplidor,
                RNCCedula = n.RNCCedula,
                IdTipoIdentificacion = n.IdTipoIdentificacion,
                TipoIdentificacion = n.TipoIdentificacion,
                IdTipoBienesServicios = n.IdTipoBienesServicios,
                TipoBienesServicios = n.TipoBienesServicios,
                CodigoTipoBienesServicio = n.CodigoTipoBienesServicio,
                NCF = n.NCF,
                NCFMODIFICADO = n.NCFMODIFICADO,
                FechaComprobante0 = n.FechaComprobante0,
                FechaComprobante = n.FechaComprobante,
                FechaPago0 = n.FechaPago0,
                FechaPago = n.FechaPago,
                MontoFacturadoServicios = n.MontoFacturadoServicios,
                MontoFacturadoBienes = n.MontoFacturadoBienes,
                TotalMontoFacturado = n.TotalMontoFacturado,
                ITBISFacturado = n.ITBISFacturado,
                ITBISRetenido = n.ITBISRetenido,
                ITBISSujetoProporcionalidad = n.ITBISSujetoProporcionalidad,
                ITBISLlevadoCosto = n.ITBISLlevadoCosto,
                ITBISPorAdelantar = n.ITBISPorAdelantar,
                ITBISPercibidoCompras = n.ITBISPercibidoCompras,
                IdTipoRetencionISR = n.IdTipoRetencionISR,
                TipoRetencionISR = n.TipoRetencionISR,
                CodigoTipoRetencionISR = n.CodigoTipoRetencionISR,
                MontoRetencionRenta = n.MontoRetencionRenta,
                ISRPercibidoCompras = n.ISRPercibidoCompras,
                ImpuestoSelectivoConsumo = n.ImpuestoSelectivoConsumo,
                OtrosImpuestosTasa = n.OtrosImpuestosTasa,
                MontoPropinaLegal = n.MontoPropinaLegal,
                IdFormaPago = n.IdFormaPago,
                FormaPago = n.FormaPago,
                CodigoTipoPago = n.CodigoTipoPago,
                UsuarioAdiciona = n.UsuarioAdiciona,
                CreadoPor = n.CreadoPor,
                FechaCreado0 = n.FechaCreado0,
                FechaCreado = n.FechaCreado,
                CantidadRegistros = n.CantidadRegistros,
                ValidadoDesde=n.ValidadoDesde,
                ValidadoHasta=n.ValidadoHasta
                           }).FirstOrDefault();
            }
            return Guardar;
        }

        //MOSTRAR EL LISTADO DEL REPORTE DEL 607 PARA ARCHIVO TXT
        public List<DSMarket.Logica.Entidades.EntidadesConfiguracion.EGenerarArchivo607> Reporte607(DateTime? FechaDesde = null, DateTime? FechaHasta = null) {
            ObjData.CommandTimeout = 999999999;

            var Listado = (from n in ObjData.SP_GENERAR_ARCHIVO_REPORTE_607(FechaDesde, FechaHasta)
                           select new DSMarket.Logica.Entidades.EntidadesConfiguracion.EGenerarArchivo607
                           {
                               NumeroIdentificacion=n.NumeroIdentificacion,
                               TipoIdentificacion=n.TipoIdentificacion,
                               IdTipoIdentificacion=n.IdTipoIdentificacion,
                               NCF=n.NCF,
                               NCFModificado=n.NCFModificado,
                               IdTipoIngreso=n.IdTipoIngreso,
                               TipoIngreso=n.TipoIngreso,
                               CodigoTipoIngreso=n.CodigoTipoIngreso,
                               FechaFacturacion=n.FechaFacturacion,
                               FechaArchivo=n.FechaArchivo,
                               FechaRetencion=n.FechaRetencion,
                               MontoFacturado=n.MontoFacturado,
                               ImpuestoFacturado=n.ImpuestoFacturado,
                               ITBISRetenidoPorTerceros=n.ITBISRetenidoPorTerceros,
                               ITBISPercibido=n.ITBISPercibido,
                               RetencionRentaPorTerceros=n.RetencionRentaPorTerceros,
                               ISRPercibido=n.ISRPercibido,
                               ImpuestoSostenidoConsumo=n.ImpuestoSostenidoConsumo,
                               OtrosImpuestoTasa=n.OtrosImpuestoTasa,
                               MontoPropinaLegal=n.MontoPropinaLegal,
                               MontoEfectivo=n.MontoEfectivo,
                               MontoChequeTransferenciaDeposito=n.MontoChequeTransferenciaDeposito,
                               MontoTarjetaDebitoCredito=n.MontoTarjetaDebitoCredito,
                               MontoVentaCredito=n.MontoVentaCredito,
                               BonosCertificadosRegalos=n.BonosCertificadosRegalos,
                               Permuta=n.Permuta,
                               OtrasFormasVenta=n.OtrasFormasVenta,
                               CantidadRegistros=n.CantidadRegistros
                           }).ToList();
            return Listado;
        }

        //PROCESAR INFORMACION PARA GENERAR REPORTE DEL 607 POR PANTALLA
        public DSMarket.Logica.Entidades.EntidadesConfiguracion.EProcesarInformacion607 ProcesarInformacion607(DSMarket.Logica.Entidades.EntidadesConfiguracion.EProcesarInformacion607 Item, string Accion) {
            ObjData.CommandTimeout = 999999999;

            DSMarket.Logica.Entidades.EntidadesConfiguracion.EProcesarInformacion607 Procesar = null;

            var Informacion607 = ObjData.SP_PROCESAR_INFORMACION_REPORTE_607(
                Item.IdUsuario,
                Item.NumeroIdentificacion,
                Item.TipoIdentificacion,
                Item.IdTipoIdentificacion,
                Item.NCF,
                Item.NCFModificado,
                Item.IdTipoIngreso,
                Item.TipoIngreso,
                Item.CodigoTipoIngreso,
                Item.FechaFacturacion,
                Item.FechaArchivo,
                Item.FechaRetencion,
                Item.MontoFacturado,
                Item.ImpuestoFacturado,
                Item.ITBISRetenidoPorTerceros,
                Item.ITBISPercibido,
                Item.RetencionRentaPorTerceros,
                Item.ISRPercibido,
                Item.ImpuestoSostenidoConsumo,
                Item.OtrosImpuestoTasa,
                Item.MontoPropinaLegal,
                Item.MontoEfectivo,
                Item.MontoChequeTransferenciaDeposito,
                Item.MontoTarjetaDebitoCredito,
                Item.MontoVentaCredito,
                Item.BonosCertificadosRegalos,
                Item.Permuta,
                Item.OtrasFormasVenta,
                Item.CantidadRegistros,
                Item.FechaDesde,
                Item.FechaHasta,
                Accion);
            if (Informacion607 != null) {
                Procesar = (from n in Informacion607
                            select new DSMarket.Logica.Entidades.EntidadesConfiguracion.EProcesarInformacion607
                            {

                                IdUsuario = n.IdUsuario,
                                NumeroIdentificacion = n.NumeroIdentificacion,
                                TipoIdentificacion = n.TipoIdentificacion,
                                IdTipoIdentificacion = n.IdTipoIdentificacion,
                                NCF = n.NCF,
                                NCFModificado = n.NCFModificado,
                                IdTipoIngreso = n.IdTipoIngreso,
                                TipoIngreso = n.TipoIngreso,
                                CodigoTipoIngreso = n.CodigoTipoIngreso,
                                FechaFacturacion = n.FechaFacturacion,
                                FechaArchivo = n.FechaArchivo,
                                FechaRetencion = n.FechaRetencion,
                                MontoFacturado = n.MontoFacturado,
                                ImpuestoFacturado = n.ImpuestoFacturado,
                                ITBISRetenidoPorTerceros = n.ITBISRetenidoPorTerceros,
                                ITBISPercibido = n.ITBISPercibido,
                                RetencionRentaPorTerceros = n.RetencionRentaPorTerceros,
                                ISRPercibido = n.ISRPercibido,
                                ImpuestoSostenidoConsumo = n.ImpuestoSostenidoConsumo,
                                OtrosImpuestoTasa = n.OtrosImpuestoTasa,
                                MontoPropinaLegal = n.MontoPropinaLegal,
                                MontoEfectivo = n.MontoEfectivo,
                                MontoChequeTransferenciaDeposito = n.MontoChequeTransferenciaDeposito,
                                MontoTarjetaDebitoCredito = n.MontoTarjetaDebitoCredito,
                                MontoVentaCredito = n.MontoVentaCredito,
                                BonosCertificadosRegalos = n.BonosCertificadosRegalos,
                                Permuta = n.Permuta,
                                OtrasFormasVenta = n.OtrasFormasVenta,
                                CantidadRegistros = n.CantidadRegistros,
                                FechaDesde=n.FechaDesde,
                                FechaHasta=n.FechaHasta

                            }).FirstOrDefault();
            }
            return Procesar;
        }

        //GENERAR ARCHIVO PARA EL REPORTE DEL 608
        public List<DSMarket.Logica.Entidades.EntidadesConfiguracion.EGenerarArchivo608> GenerarArchivo608(DateTime? FechaDesde = null, DateTime? FechaHasta = null) {
            ObjData.CommandTimeout = 999999999;

            var Listado = (from n in ObjData.SP_GENERAR_ARCHIVO_608(FechaDesde, FechaHasta)
                           select new DSMarket.Logica.Entidades.EntidadesConfiguracion.EGenerarArchivo608
                           {
                               Comprobante=n.Comprobante,
                               FechaFacturacion0=n.FechaFacturacion0,
                               FechaFacturacion=n.FechaFacturacion,
                               FechaArchivo=n.FechaArchivo,
                               TipoAnulacion=n.TipoAnulacion,
                               CodigoTipoAnulacion=n.CodigoTipoAnulacion,
                               Comentario=n.Comentario,
                               CantidadRegistros=n.CantidadRegistros
                           }).ToList();
            return Listado;
        }

        //PROCESAR LA INFORMACION PARA GENERAR EL REPORTE DEL 608 POR PANTALLA
        public DSMarket.Logica.Entidades.EntidadesConfiguracion.EProcesarInformacion608 ProcesarInformacion608(DSMarket.Logica.Entidades.EntidadesConfiguracion.EProcesarInformacion608 Item, string Accion) {
            ObjData.CommandTimeout = 999999999;

            DSMarket.Logica.Entidades.EntidadesConfiguracion.EProcesarInformacion608 Procesar = null;

            var Informacion608 = ObjData.SP_PROCESAR_INFORMACION_REPORTE_608(
                Item.IdUsuario,
                Item.Comprobante,
                Item.FechaFacturacion0,
                Item.FechaFActuracion,
                Item.FechaArchivo,
                Item.TipoAnulacion,
                Item.CodigoTipoAnulacion,
                Item.Comentario,
                Item.CantidadRegistros,
                Item.ValidadoDesde,
                Item.ValidadoHasta,
                Accion);
            if(Informacion608!=null){
                Procesar = (from n in Informacion608
                            select new DSMarket.Logica.Entidades.EntidadesConfiguracion.EProcesarInformacion608
                            {
                                IdUsuario=n.IdUsuario,
                                Comprobante=n.Comprobante,
                                FechaFacturacion0=n.FechaFacturacion0,
                                FechaFActuracion=n.FechaFActuracion,
                                FechaArchivo=n.FechaArchivo,
                                TipoAnulacion=n.TipoAnulacion,
                                CodigoTipoAnulacion=n.CodigoTipoAnulacion,
                                Comentario=n.Comentario,
                                CantidadRegistros=n.CantidadRegistros,
                                ValidadoDesde=n.ValidadoDesde,
                                ValidadoHasta=n.ValidadoHasta
                            }).FirstOrDefault();
            }
            return Procesar;
        }
        #endregion
        #region BUSCA LISTAS
        //BUSCA LISTAS
        public List<DSMarket.Logica.Entidades.EntidadesConfiguracion.EListas> BuscaListas(string NombreLista = null, string PrimerFiltro = null, string SegundoFiltro = null, string TerceFiltro = null, string CuartoFiltro = null, string QuintoFiltro = null)
        {
            ObjData.CommandTimeout = 999999999;

            var BuscaListas = (from n in ObjData.SP_BUSCA_LISTAS(NombreLista, PrimerFiltro, SegundoFiltro, TerceFiltro, CuartoFiltro, QuintoFiltro)
                               select new DSMarket.Logica.Entidades.EntidadesConfiguracion.EListas
                               {
                                   Descripcion = n.Descripcion,
                                   PrimerValor = n.PrimerValor,
                                   SegundoValor = n.SegundoValor,
                                   TerceValor = n.TerceValor
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
                                   LogoEmpresa = n.LogoEmpresa
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
                                 IdInformacionEmpresa = n.IdInformacionEMpres,
                                 NombreEmpresa = n.NombreEmpresa,
                                 RNC = n.RNC,
                                 Direccion = n.Direccion,
                                 Email = n.Email,
                                 Email2 = n.Email2,
                                 Facebook = n.Facebook,
                                 Instagran = n.Instagram,
                                 Telefonos = n.Telefonos,
                                 IdLogoEmpresa = n.IdLogoEmpresa
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
                               IdConfiguracionGeneral = n.IdConfiguracionGeneral,
                               Descripcion = n.Descripcion,
                               Estatus0 = n.Estatus0,
                               Estatus = n.Estatus,
                               CantidadActivos = n.CantidadActivos,
                               CantidadInactivos = n.CantidadInactivos
                           }).ToList();
            return Listado;
        }
        public DSMarket.Logica.Entidades.EntidadesConfiguracion.EConfiguracionGeneral MantenimientoConfiguracionGeneral(DSMarket.Logica.Entidades.EntidadesConfiguracion.EConfiguracionGeneral Item, string Accion)
        {
            ObjData.CommandTimeout = 999999999;

            DSMarket.Logica.Entidades.EntidadesConfiguracion.EConfiguracionGeneral Mantenimiento = null;

            var ConfiguracionGeneral = ObjData.SP_MANTENIMIENTO_CONFIGURACION_GENERAL(
                Item.IdConfiguracionGeneral,
                Item.Descripcion,
                Item.Estatus0,
                Accion);
            if (ConfiguracionGeneral != null)
            {
                Mantenimiento = (from n in ConfiguracionGeneral
                                 select new DSMarket.Logica.Entidades.EntidadesConfiguracion.EConfiguracionGeneral
                                 {
                                     IdConfiguracionGeneral = n.IdConfiguracionGeneral,
                                     Descripcion = n.Descripcion,
                                     Estatus0 = n.Estatus
                                 }).FirstOrDefault();
            }
            return Mantenimiento;
        }

        public List<DSMarket.Logica.Entidades.EntidadesConfiguracion.EGenerarComprobante> GenerarComprobanteFiscal(decimal? IdComprobante = null)
        {
            ObjData.CommandTimeout = 999999999;

            var Generar = (from n in ObjData.SP_GENERAR_COMPROBANTE_FISCAL(IdComprobante)
                           select new DSMarket.Logica.Entidades.EntidadesConfiguracion.EGenerarComprobante
                           {
                               TipoComprobante = n.TipoComprobante,
                               Comprobante = n.Comprobante
                           }).ToList();
            return Generar;
        }
        #endregion
        #region GENERAR COMPROBANTE FISCAL
        public List<DSMarket.Logica.Entidades.EntidadesConfiguracion.EGenerarComprobante> GenerarComprobante(decimal? IdComprobante = null)
        {
            ObjData.CommandTimeout = 999999999;

            var Listado = (from n in ObjData.SP_GENERAR_COMPROBANTE_FISCAL(IdComprobante)
                           select new DSMarket.Logica.Entidades.EntidadesConfiguracion.EGenerarComprobante
                           {
                               TipoComprobante = n.TipoComprobante,
                               Comprobante = n.Comprobante
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
                               IdComprobante = n.IdComprobante,
                               Comprobante = n.Comprobante,
                               Serie = n.Serie,
                               TipoComprobante = n.TipoComprobante,
                               Secuencia = n.Secuencia,
                               SecuenciaInicial = n.SecuenciaInicial,
                               SecuenciaFinal = n.SecuenciaFinal,
                               Limite = n.Limite,
                               Estatus0 = n.Estatus0,
                               Estatus = n.Estatus,
                               ValidoHasta = n.ValidoHasta,
                               PorDefecto0 = n.PorDefecto0,
                               PorDefecto = n.PorDefecto,
                               Posiciones = n.Posiciones,
                               CobroPorcientoAdicional=n.CobroPorcientoAdicional
                           }).ToList();
            return Listado;
        }

        //MANTENIMIENTO DE COMPROBANTES FISCALES
        public DSMarket.Logica.Entidades.EntidadesConfiguracion.EMantenimientoComprobantes MantenimientoComprobantes(DSMarket.Logica.Entidades.EntidadesConfiguracion.EMantenimientoComprobantes Item, string Accion)
        {
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
                Item.CobroPorcientoAdicional,
                Accion);
            if (Comprobante != null)
            {
                Mantenimiento = (from n in Comprobante
                                 select new DSMarket.Logica.Entidades.EntidadesConfiguracion.EMantenimientoComprobantes
                                 {
                                     IdComprobante = n.IdComprobante,
                                     Descripcion = n.Descripcion,
                                     Serie = n.Serie,
                                     TipoComprobante = n.TipoComprobante,
                                     Secuencia = n.Secuencia,
                                     SecuenciaInicial = n.SecuenciaInicial,
                                     SecuenciaFinal = n.SecuenciaFinal,
                                     Limite = n.Limite,
                                     Estatus = n.Estatus,
                                     ValidoHasta = n.ValidoHasta,
                                     PorDefecto = n.PorDefecto,
                                     Posiciones = n.Posiciones,
                                     CobroPorcientoAdicional=n.CobroPorcientoAdicional
                                 }).FirstOrDefault();
            }
            return Mantenimiento;
        }
        #endregion
        #region MANTENIMEINTO IMPUESTOS
        public List<DSMarket.Logica.Entidades.EntidadesConfiguracion.EImpuesto> BuscaImpuestos(int? IdImpuesto = null)
        {
            ObjData.CommandTimeout = 999999999;

            var Listado = (from n in ObjData.SP_BUSCA_IMPUESTO_VENTA(IdImpuesto)
                           select new DSMarket.Logica.Entidades.EntidadesConfiguracion.EImpuesto
                           {
                               IdImpuesto = n.IdImpuesto,
                               Descripcion = n.Descripcion,
                               PorcientoImpuesto = n.PorcientoImpuesto,
                               Operacion0 = n.Operacion0,
                               Operacion = n.Operacion
                           }).ToList();
            return Listado;
        }
        #endregion
        #region MANTENIMIENTO DE RUTA DE REPORTES
        //LISTADO DE RUTA DE REPORTES
        public List<DSMarket.Logica.Entidades.EntidadesConfiguracion.ERutaReporte> BuscaRutaReporte(int? IdRutaReporte = null)
        {
            ObjData.CommandTimeout = 999999999;

            var Listado = (from n in ObjData.SP_SACAR_RUTA_REPORTE(IdRutaReporte)
                           select new DSMarket.Logica.Entidades.EntidadesConfiguracion.ERutaReporte
                           {
                               IdReporte = n.IdReporte,
                               Nombre = n.Nombre,
                               RutaReporte = n.RutaReporte
                           }).ToList();
            return Listado;
        }
        //MANTENIMIENTO DE RUTA DE REPORTE
        public DSMarket.Logica.Entidades.EntidadesConfiguracion.ERutaReporte MantenimientoRutaReporte(DSMarket.Logica.Entidades.EntidadesConfiguracion.ERutaReporte Item, string Accion)
        {
            ObjData.CommandTimeout = 999999999;

            DSMarket.Logica.Entidades.EntidadesConfiguracion.ERutaReporte Mantenimiento = null;

            var RutaReporte = ObjData.SP_MANTENIMIENTO_RUTA_REPORTE(
                Item.IdReporte,
                Item.Nombre,
                Item.RutaReporte,
                Accion);
            if (RutaReporte != null)
            {
                Mantenimiento = (from n in RutaReporte
                                 select new DSMarket.Logica.Entidades.EntidadesConfiguracion.ERutaReporte
                                 {
                                     IdReporte = n.IdReporte,
                                     Nombre = n.Descripcion,
                                     RutaReporte = n.RutaReporte
                                 }).FirstOrDefault();
            }
            return Mantenimiento;
        }
        #endregion
        #region PROCESAR CUADRE CAJA
        public DSMarket.Logica.Entidades.EntidadesConfiguracion.EProcesarReporteCuadreCaja ProcesarCuadreCaja(DSMarket.Logica.Entidades.EntidadesConfiguracion.EProcesarReporteCuadreCaja Item, string Accion)
        {
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
            if (CuadreCaja != null)
            {
                Procesar = (from n in CuadreCaja
                            select new DSMarket.Logica.Entidades.EntidadesConfiguracion.EProcesarReporteCuadreCaja
                            {
                                IdUsuario = n.IdUsuario,
                                IdCaja = n.IdCaja,
                                Monto = n.Monto,
                                Concepto = n.Concepto,
                                FechaProcesado = n.FechaProcesado,
                                FechaDesde = n.FechaDesde,
                                FechaHasta = n.FechaHasta,
                                NumeroReferencia = n.NumeroReferencia,
                                IdTipoPago = n.IdTipoPago
                            }).FirstOrDefault();
            }
            return Procesar;
        }
        #endregion
        #region GUARDAR DATOS REPORTE VENTA
        public DSMarket.Logica.Entidades.EntidadesConfiguracion.EGuardarReporteVenta GuardarReporteVenta(DSMarket.Logica.Entidades.EntidadesConfiguracion.EGuardarReporteVenta Item, string Accion)
        {
            ObjData.CommandTimeout = 999999999;

            DSMarket.Logica.Entidades.EntidadesConfiguracion.EGuardarReporteVenta Guardar = null;

            var ReporteVenta = ObjData.SP_GUARDAR_HISTORIAL_VENTA(
                Item.IdUsuario,
                Item.Cliente,
                Item.EstatusFacturacion,
                Item.IdFactura,
                Item.NumeroConector,
                Item.IdEstatusFActuracion,
                Item.TipoIdentificacion,
                Item.DescripciomComprobanre,
                Item.Comprobante,
                Item.IdComprobante,
                Item.Descripcion,
                Item.Telefono,
                Item.Email,
                Item.IdTipoIdentificacion,
                Item.NumeroIdentificacion,
                Item.Direccion,
                Item.Comentario,
                Item.IdTipoVenta,
                Item.TipoVenta,
                Item.CantidadDias,
                Item.IdCantidadDias,
                Item.UsuarioVendio,
                Item.CreadoPor,
                Item.FechaFActuracion,
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
                Item.TipoPago,
                Item.TotalGeneral,
                Accion);
            if (ReporteVenta != null)
            {
                Guardar = (from n in ReporteVenta
                           select new DSMarket.Logica.Entidades.EntidadesConfiguracion.EGuardarReporteVenta
                           {
                               IdUsuario = n.IdUsuario,
                               Cliente = n.Cliente,
                               EstatusFacturacion = n.EstatusFacturacion,
                               IdFactura = n.IdFactura,
                               NumeroConector = n.NumeroConector,
                               IdEstatusFActuracion = n.IdEstatusFActuracion,
                               TipoIdentificacion = n.TipoIdentificacion,
                               DescripciomComprobanre = n.DescripciomComprobanre,
                               Comprobante = n.Comprobante,
                               IdComprobante = n.IdComprobante,
                               Descripcion = n.Descripcion,
                               Telefono = n.Telefono,
                               Email = n.Email,
                               IdTipoIdentificacion = n.IdTipoIdentificacion,
                               NumeroIdentificacion = n.NumeroIdentificacion,
                               Direccion = n.Direccion,
                               Comentario = n.Comentario,
                               IdTipoVenta = n.IdTipoVenta,
                               TipoVenta = n.TipoVenta,
                               CantidadDias = n.CantidadDias,
                               IdCantidadDias = n.IdCantidadDias,
                               UsuarioVendio = n.UsuarioVendio,
                               CreadoPor = n.CreadoPor,
                               FechaFActuracion = n.FechaFActuracion,
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
                               TipoPago = n.TipoPago,
                               TotalGeneral = n.TotalGeneral
                           }).FirstOrDefault();
            }
            return Guardar;
        }
        #endregion
        #region PROCESAR LA INFORMACION DE LA GANANCIA
        public DSMarket.Logica.Entidades.EntidadesConfiguracion.EProcesarInformacionGanancia ProcesarInformacionGanancia(DSMarket.Logica.Entidades.EntidadesConfiguracion.EProcesarInformacionGanancia Item, string Accion)
        {
            ObjData.CommandTimeout = 999999999;

            DSMarket.Logica.Entidades.EntidadesConfiguracion.EProcesarInformacionGanancia Procesar = null;

            var InformacionGanancia = ObjData.SP_GUARDAR_INFORMACION_GANANCIA(
                Item.IdUsuario,
                Item.IdEstatusFacturacion,
                Item.Estatus,
                Item.IdFActura,
                Item.DescripcionProducto,
                Item.Acumulativo,
                Item.IdCategoria,
                Item.Categoria,
                Item.TipoProducto,
                Item.PrecioCompra,
                Item.PrecioVenta,
                Item.CantidadVendda,
                Item.DescuentoAplicado,
                Item.TotalVenta,
                Item.TotalPrecioCompra,
                Item.Ganancia,
                Accion);
            if (InformacionGanancia != null)
            {
                Procesar = (from n in InformacionGanancia
                            select new DSMarket.Logica.Entidades.EntidadesConfiguracion.EProcesarInformacionGanancia
                            {
                                IdUsuario = n.IdUsuario,
                                IdEstatusFacturacion = n.IdEstatusFacturacion,
                                Estatus = n.Estatus,
                                IdFActura = n.IdFActura,
                                DescripcionProducto = n.DescripcionProducto,
                                Acumulativo = n.Acumulativo,
                                IdCategoria = n.IdCategoria,
                                Categoria = n.Categoria,
                                TipoProducto = n.TipoProducto,
                                PrecioCompra = n.PrecioCompra,
                                PrecioVenta = n.PrecioVenta,
                                CantidadVendda = n.CantidadVendda,
                                DescuentoAplicado = n.DescuentoAplicado,
                                TotalVenta = n.TotalVenta,
                                TotalPrecioCompra = n.TotalPrecioCompra,
                                Ganancia = n.Ganancia
                            }).FirstOrDefault();
            }
            return Procesar;
        }
        #endregion
        #region RUTA BD
        //BUSCAR RUTRA
        public List<DSMarket.Logica.Entidades.EntidadesConfiguracion.ERutaBackup> BuscaRutaBAckup(decimal? IdRutaBackup = null)
        {
            ObjData.CommandTimeout = 999999999;

            var Buscar = (from n in ObjData.SP_SACAR_RUTA_BACKUP_BD(IdRutaBackup)
                          select new DSMarket.Logica.Entidades.EntidadesConfiguracion.ERutaBackup
                          {
                              IdRutaBAckupBD = n.IdRutaBAckupBD,
                              Ruta = n.Ruta
                          }).ToList();
            return Buscar;
        }

        //MANTENIMIENTO DE RUTA DE REPORTE
        public DSMarket.Logica.Entidades.EntidadesConfiguracion.ERutaBackup MantenimientoRutaBackup(DSMarket.Logica.Entidades.EntidadesConfiguracion.ERutaBackup Item, string Accion)
        {
            ObjData.CommandTimeout = 999999999;

            DSMarket.Logica.Entidades.EntidadesConfiguracion.ERutaBackup Mantenimiento = null;

            var RutaBackup = ObjData.SP_MODIFICAR_RUTA_BACKUP(
                Item.IdRutaBAckupBD,
                Item.Ruta,
                Accion);
            if (RutaBackup != null)
            {
                Mantenimiento = (from n in RutaBackup
                                 select new DSMarket.Logica.Entidades.EntidadesConfiguracion.ERutaBackup
                                 {
                                     IdRutaBAckupBD = n.IdRutaBackup,
                                     Ruta = n.Ruta
                                 }).FirstOrDefault();

            }
            return Mantenimiento;
        }

        //GENERAR BACKUP REPORTE
        public DSMarket.Logica.Entidades.EntidadesConfiguracion.EGenerarRutaBackup GenerarBackup(DSMarket.Logica.Entidades.EntidadesConfiguracion.EGenerarRutaBackup Item, string Accion)
        {
            ObjData.CommandTimeout = 999999999;

            DSMarket.Logica.Entidades.EntidadesConfiguracion.EGenerarRutaBackup Generar = null;

            var Backup = ObjData.SP_GENERAR_BACKUP_DATABASE(
                Item.RutaArchivo,
                Accion);
            if (Backup != null)
            {
                Generar = (from n in Backup
                           select new DSMarket.Logica.Entidades.EntidadesConfiguracion.EGenerarRutaBackup
                           {
                               RutaArchivo = n.RutaArchivo
                           }).FirstOrDefault();
            }
            return Generar;
        }
        #endregion
        #region MANTENIMIENTO DE RUTA DE ARCHIVO TXT
        //BUSCA RUTA ARCHIVO TXT
        public List<DSMarket.Logica.Entidades.EntidadesConfiguracion.ERutaArchivotxt> BuscaRutaArchivotxt(int? IdRutaArchivostxt = null) {
            ObjData.CommandTimeout = 999999999;

            var Buscar = (from n in ObjData.SP_BUSCAR_RUTA_ARCHIVO_TXT(IdRutaArchivostxt)
                          select new DSMarket.Logica.Entidades.EntidadesConfiguracion.ERutaArchivotxt
                          {
                              IdRutaArchivotxt=n.IdRutaArchivotxt,
                              Ruta=n.Ruta
                          }).ToList();
            return Buscar;
        }
        //MODFICAR RUTA ARCHIVO TXT
        public DSMarket.Logica.Entidades.EntidadesConfiguracion.ERutaArchivotxt ModificarRUtaArchivotxt(DSMarket.Logica.Entidades.EntidadesConfiguracion.ERutaArchivotxt Item, string Accion) {
            ObjData.CommandTimeout = 999999999;

            DSMarket.Logica.Entidades.EntidadesConfiguracion.ERutaArchivotxt Modificar = null;

            var RutaArchivotxt = ObjData.SP_MODIFICAR_RUTA_ARCHIVO_TXT(
                Item.IdRutaArchivotxt,
                Item.Ruta,
                Accion);
            if (RutaArchivotxt != null)
            {
                Modificar = (from n in RutaArchivotxt
                             select new DSMarket.Logica.Entidades.EntidadesConfiguracion.ERutaArchivotxt
                             {
                                 IdRutaArchivotxt=n.IdRutaArchivotxt,
                                 Ruta=n.Ruta
                             }).FirstOrDefault();
            }
            return Modificar;
        }
        #endregion
        #region MANTENIMIENTO DE PORCIENTO DE IMPUESTO
        public DSMarket.Logica.Entidades.EntidadesConfiguracion.EModificarImpuestoVenta ModificarImpuesto(DSMarket.Logica.Entidades.EntidadesConfiguracion.EModificarImpuestoVenta Item, string Accion)
        {
            ObjData.CommandTimeout = 999999999;

            DSMarket.Logica.Entidades.EntidadesConfiguracion.EModificarImpuestoVenta Modificar = null;

            var Impuesto = ObjData.SP_MODIFICAR_IMPUESTO_VENTA(
                Item.IdImpuesto,
                Item.Descripcion,
                Item.PorcientoImpuesto,
                Item.Operacion,
                Accion);
            if (Impuesto != null)
            {
                Modificar = (from n in Impuesto
                             select new DSMarket.Logica.Entidades.EntidadesConfiguracion.EModificarImpuestoVenta
                             {
                                 IdImpuesto = n.IdImpuesto,
                                 Descripcion = n.Descripcion,
                                 PorcientoImpuesto = n.PorcientoImpuesto,
                                 Operacion = n.Operacion


                             }).FirstOrDefault();
            }
            return Modificar;
        }
        #endregion
        #region MAIL
        //BUSCA LOS TIPO DE MAILS
        public List<DSMarket.Logica.Entidades.EntidadesConfiguracion.EBuscaTipoMail> BuscaTipoMail(int? IdTipoMail = null)
        {
            ObjData.CommandTimeout = 999999999;

            var Buscar = (from n in ObjData.SP_BUSCA_TIPO_MAIL(IdTipoMail)
                          select new DSMarket.Logica.Entidades.EntidadesConfiguracion.EBuscaTipoMail
                          {
                              IdTipoMail = n.IdTipoMail
                              ,
                              TipoMail = n.TipoMail,
                              smtp = n.smtp,
                              Puerto = n.Puerto
                          }).ToList();
            return Buscar;
        }

        //BUSCA LISTADO DE MAILS
        public List<DSMarket.Logica.Entidades.EntidadesConfiguracion.EMail> BuscaMail(decimal? IdMail = null)
        {
            ObjData.CommandTimeout = 999999999;

            var Listado = (from n in ObjData.SP_BUSCA_MAIL(IdMail)
                           select new DSMarket.Logica.Entidades.EntidadesConfiguracion.EMail
                           {
                               IdMail = n.IdMail,
                               Mail = n.Mail,
                               Clave = n.Clave,
                               Estatus = n.Estatus,
                               IdTipoMail = n.IdTipoMail,
                               TipoMail = n.TipoMail,
                               Puerto = n.Puerto,
                               smtp = n.smtp
                           }).ToList();
            return Listado;
        }

        //MANTENIMIENTO DE MAIL
        public DSMarket.Logica.Entidades.EntidadesConfiguracion.EMail MantenimientoMail(DSMarket.Logica.Entidades.EntidadesConfiguracion.EMail Item, string Accion)
        {
            ObjData.CommandTimeout = 999999999;

            DSMarket.Logica.Entidades.EntidadesConfiguracion.EMail Actualizar = null;

            var Mail = ObjData.SP_MANTENIMIENTO_MAIL(
                Item.IdMail,
                Item.Mail,
                Item.Clave,
                Item.Estatus,
                Item.IdTipoCorreo,
                Accion);
            if (Mail != null)
            {
                Actualizar = (from n in Mail
                              select new DSMarket.Logica.Entidades.EntidadesConfiguracion.EMail
                              {
                                  IdMail = n.IdMail,
                                  Mail = n.Mail,
                                  Clave = n.Clave,
                                  Estatus = n.Estatus,
                                  IdTipoCorreo = n.IdTipoCorreo,
                              }).FirstOrDefault();
            }
            return Actualizar;
        }
        #endregion
        #region GUARDAR REPORTE PRODUCTOS DEECTUOSOS
        public DSMarket.Logica.Entidades.EntidadesConfiguracion.EReporteProductosDefectuosos GuardarRegistrosProductosDefectuosos(DSMarket.Logica.Entidades.EntidadesConfiguracion.EReporteProductosDefectuosos Item, string Accion)
        {
            ObjData.CommandTimeout = 999999999;

            DSMarket.Logica.Entidades.EntidadesConfiguracion.EReporteProductosDefectuosos Guardar = null;

            var RegistroProductoDefectuoso = ObjData.SP_GUARDAR_DATOS_REPORTE_PRODUCTOS_DEFECTUOSOS(
                Item.IdUsuario,
                Item.NumeroConector,
                Item.IdTipoProducto,
                Item.Producto,
                Item.TipoProducto,
                Item.IdCategoria,
                Item.Categoria,
                Item.IdUnidadMedida,
                Item.UnidadMedida,
                Item.Idmarca,
                Item.Marca,
                Item.IdModelo,
                Item.Modelo,
                Item.IdTipoSuplidor,
                Item.TipoSuplidor,
                Item.IdSuplidor,
                Item.Suplidor,
                Item.CodigoBarra,
                Item.Referencia,
                Item.PrecioCompra,
                Item.PrecioVenta,
                Item.Stock,
                Item.StockMinimo,
                Item.PorcientoDescuento,
                Item.AfctaOferta0,
                Item.AfectaOferta,
                Item.ProductoAcumulativo0,
                Item.ProductoAcumulativo,
                Item.LlevaImagen0,
                Item.LlevaImagen,
                Item.UsuarioAdiciona,
                Item.CreadoPor,
                Item.FechaAdiciona,
                Item.FechaCreado,
                Item.UsuarioModifica,
                Item.ModificadoPor,
                Item.FechaModifica,
                Item.FechaModificado,
                Item.Fecha,
                Item.AplicaParaImpuesto0,
                Item.EstatusProducto0,
                Item.EstatusProducto,
                Item.AplicaImpuesto,
                Item.CantidadAgregada,
                Item.CantidadRegistros,
                Item.ProductoConOferta,
                Item.ProductoProximoAgotarse,
                Item.ProductosAgostados,
                Item.TotalProductos,
                Item.Comentario,
                Accion);
            if (RegistroProductoDefectuoso != null)
            {
                Guardar = (from n in RegistroProductoDefectuoso
                           select new DSMarket.Logica.Entidades.EntidadesConfiguracion.EReporteProductosDefectuosos
                           {
                                      IdUsuario = n.IdUsuario,
                                      NumeroConector = n.NumeroConector,
                                      IdTipoProducto = n.IdTipoProducto,
                                      Producto = n.Producto,
                                      TipoProducto = n.TipoProducto,
                                      IdCategoria = n.IdCategoria,
                                      Categoria = n.Categoria,
                                      IdUnidadMedida = n.IdUnidadMedida,
                                      UnidadMedida = n.UnidadMedida,
                                      Idmarca = n.Idmarca,
                                      Marca = n.Marca,
                                      IdModelo = n.IdModelo,
                                      Modelo = n.Modelo,
                                      IdTipoSuplidor = n.IdTipoSuplidor,
                                      TipoSuplidor = n.TipoSuplidor,
                                      IdSuplidor = n.IdSuplidor,
                                      Suplidor = n.Suplidor,
                                      CodigoBarra = n.CodigoBarra,
                                      Referencia = n.Referencia,
                                      PrecioCompra = n.PrecioCompra,
                                      PrecioVenta = n.PrecioVenta,
                                      Stock = n.Stock,
                                      StockMinimo = n.StockMinimo,
                                      PorcientoDescuento = n.PorcientoDescuento,
                                      AfctaOferta0 = n.AfctaOferta0,
                                      AfectaOferta = n.AfectaOferta,
                                      ProductoAcumulativo0 = n.ProductoAcumulativo0,
                                      ProductoAcumulativo = n.ProductoAcumulativo,
                                      LlevaImagen0 = n.LlevaImagen0,
                                      LlevaImagen = n.LlevaImagen,
                                      UsuarioAdiciona = n.UsuarioAdiciona,
                                      CreadoPor = n.CreadoPor,
                                      FechaAdiciona = n.FechaAdiciona,
                                      FechaCreado = n.FechaCreado,
                                      UsuarioModifica = n.UsuarioModifica,
                                      ModificadoPor = n.ModificadoPor,
                                      FechaModifica = n.FechaModifica,
                                      FechaModificado = n.FechaModificado,
                                      Fecha = n.Fecha,
                                      AplicaParaImpuesto0 = n.AplicaParaImpuesto0,
                                      EstatusProducto0 = n.EstatusProducto0,
                                      EstatusProducto = n.EstatusProducto,
                                      AplicaImpuesto = n.AplicaImpuesto,
                                      CantidadAgregada = n.CantidadAgregada,
                                      CantidadRegistros = n.CantidadRegistros,
                                      ProductoConOferta = n.ProductoConOferta,
                                      ProductoProximoAgotarse = n.ProductoProximoAgotarse,
                                      ProductosAgostados = n.ProductosAgostados,
                                      TotalProductos = n.TotalProductos,
                                      Comentario = n.Comentario,
                           }).FirstOrDefault();



            }
            return Guardar;
           

            

        }
        #endregion
        #region MODIFICAR LA CONFIGURACION GENERAL
        public DSMarket.Logica.Entidades.EntidadesConfiguracion.EModificarConfiguracionGeneral ModificarConfiguracionGeneral(DSMarket.Logica.Entidades.EntidadesConfiguracion.EModificarConfiguracionGeneral Item, string Accion) {
            ObjData.CommandTimeout = 999999999;

            DSMarket.Logica.Entidades.EntidadesConfiguracion.EModificarConfiguracionGeneral Modificar = null;

            var ConfiguracionGeneral = ObjData.SP_MODIFICAR_CONFIGURACION_GENERAL(
                Item.IdConfiguracionGeneral,
                Item.Descripcion,
                Item.Estatus,
                Accion);
            if (ConfiguracionGeneral != null) {
                Modificar = (from n in ConfiguracionGeneral
                             select new DSMarket.Logica.Entidades.EntidadesConfiguracion.EModificarConfiguracionGeneral
                             {
                                 IdConfiguracionGeneral=n.IdConfiguracionGeneral,
                                 Descripcion=n.Descripcion,
                                 Estatus=n.Estatus
                             }).FirstOrDefault();
                
            }
            return Modificar;
        }
        #endregion
        #region OBTENER EL PRIMER DIA DEL MES
        //SACAR EL PRIMER DIA DEL MES
        public List<DSMarket.Logica.Entidades.EntidadesConfiguracion.EObtenerPrimerDiaMes> ObtenerPrimerDiaMes() {
            ObjData.CommandTimeout = 99999999;

            var PrimerDia = (from n in ObjData.SP_OBTENER_PRIMER_DIA_MES()
                             select new DSMarket.Logica.Entidades.EntidadesConfiguracion.EObtenerPrimerDiaMes
                             {
                                 PrimerDia=n.PrimerDia
                             }).ToList();
            return PrimerDia;
        }
        #endregion
        #region PROCESAR LOS DATOS PARA EL REPORTE FINANCIERO
        public DSMarket.Logica.Entidades.EntidadesConfiguracion.EProcesarDatosReportesFinancieros ProcesarDatosReportesFinancieros(DSMarket.Logica.Entidades.EntidadesConfiguracion.EProcesarDatosReportesFinancieros Item, string Accion) {
            ObjData.CommandTimeout = 999999999;

            DSMarket.Logica.Entidades.EntidadesConfiguracion.EProcesarDatosReportesFinancieros Procesar = null;

            var DatosReportesFinancieros = ObjData.SP_PROCESAR_DATOS_REPORTES_FINANCIEROS(
                Item.IdUsuario,
                Item.IdRegistro,
                Item.Ano,
                Item.Mes,
                Item.IdTipoCuenta,
                Item.TipoCuenta,
                Item.IdModulo,
                Item.Modulo,
                Item.Conector,
                Item.Secuencia,
                Item.Banco,
                Item.NombreBanco,
                Item.Cuenta,
                Item.Auxiliar,
                Item.Valor,
                Item.IdOrigenCuenta,
                Item.OrigenCuenta,
                Item.CuentaConcepto,
                Item.NumeroRelacionado,
                Item.IdClaseCuenta,
                Item.ClaseCuenta,
                Item.IdCuentaContable,
                Item.Cuentadescargo,
                Accion);
            if (DatosReportesFinancieros != null) {
                Procesar = (from n in DatosReportesFinancieros
                            select new DSMarket.Logica.Entidades.EntidadesConfiguracion.EProcesarDatosReportesFinancieros
                            {
                                IdUsuario=n.IdUsuario,
                                IdRegistro=n.IdRegistro,
                                Ano=n.Ano,
                                Mes=n.Mes,
                                IdTipoCuenta=n.IdTipoCuenta,
                                TipoCuenta=n.TipoCuenta,
                                IdModulo=n.IdModulo,
                                Modulo=n.Modulo,
                                Conector=n.Conector,
                                Secuencia=n.Secuencia,
                                Banco=n.Banco,
                                NombreBanco=n.NombreBanco,
                                Cuenta=n.Cuenta,
                                Auxiliar=n.Auxiliar,
                                Valor=n.Valor,
                                IdOrigenCuenta=n.IdOrigenCuenta,
                                OrigenCuenta=n.OrigenCuenta,
                                CuentaConcepto=n.CuentaConcepto,
                                NumeroRelacionado=n.NumeroRelacionado,
                                IdClaseCuenta=n.IdClaseCuenta,
                                ClaseCuenta=n.ClaseCuenta,
                                IdCuentaContable=n.IdCuentaContable,
                                Cuentadescargo=n.Cuentadescargo
                            }).FirstOrDefault();
            }
            return Procesar;
        }

        public DSMarket.Logica.Entidades.EntidadesConfiguracion.EProcesarDatosReporteFinanciero ProcesarDatoReporteFinanciero(DSMarket.Logica.Entidades.EntidadesConfiguracion.EProcesarDatosReporteFinanciero Item, string Accion) {
            ObjData.CommandTimeout = 999999999;

            DSMarket.Logica.Entidades.EntidadesConfiguracion.EProcesarDatosReporteFinanciero Mantenimiento = null;

            var ReporteFinanciero = ObjData.SP_PROCESAR_DATOS_REPORTE_FINANCIEROS(
                Item.IdUsuario,
                Item.TipoReporte,
                Item.CuentaAuxiliar,
                Item.ConceptoCuenta,
                Item.Valor,
                Item.Cuenta,
                Item.CuentaDescargo,
                Item.Ano,
                Item.Mes,
                Accion);
            if (ReporteFinanciero != null) {
                Mantenimiento = (from n in ReporteFinanciero
                                 select new DSMarket.Logica.Entidades.EntidadesConfiguracion.EProcesarDatosReporteFinanciero
                                 {
                                     IdUsuario=n.IdUsuario,
                                     TipoReporte=n.TipoReporte,
                                     CuentaAuxiliar=n.CuentaAuxiliar,
                                     ConceptoCuenta=n.ConceptoCuenta,
                                     Valor=n.Valor,
                                     Cuenta=n.Cuenta,
                                     CuentaDescargo=n.CuentaDescargo,
                                     Ano=n.Ano,
                                     Mes=n.Mes
                                 }).FirstOrDefault();
            }
            return Mantenimiento;
        }
        #endregion
    }
}
