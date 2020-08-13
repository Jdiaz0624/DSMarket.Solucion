using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Logica.LogicaCaja
{
    public class LogicaCaja
    {
        DSMarket.Data.Conexion.ConexionLINQ.BDConexionCajaDataContext ObjData = new Data.Conexion.ConexionLINQ.BDConexionCajaDataContext(System.Configuration.ConfigurationManager.ConnectionStrings["DSMarketConexion"].ConnectionString);

        //MOSTRAR EL ESTATUS DE LA CAJA
        public List<DSMarket.Logica.Entidades.EntidadesCaja.ECajaGeneral> BuscaEstatusCaja()
        {
            ObjData.CommandTimeout = 999999999;

            var Buscar = (from n in ObjData.SP_ESTATUS_CAJA()
                          select new DSMarket.Logica.Entidades.EntidadesCaja.ECajaGeneral
                          {
                              IdCaja=n.IdCaja,
                              Caja=n.Caja,
                              MontoActual=n.MontoActual,
                              Estatus0=n.Estatus0,
                              Estatus=n.Estatus
                          }).ToList();
            return Buscar;
        }

        //AFECTAR CAJA GENERAL
        public DSMarket.Logica.Entidades.EntidadesCaja.ECajaGeneral AfectarCaja(DSMarket.Logica.Entidades.EntidadesCaja.ECajaGeneral Item, string Accion)
        {
            DSMarket.Logica.Entidades.EntidadesCaja.ECajaGeneral Afectar = null;

           var Caja= ObjData.SP_AFECTAR_CAJA_GENERAL(
                Item.IdCaja,
                Item.Caja,
                Item.MontoActual,
                Item.Estatus0,
                Accion);
            if (Caja != null)
            {
                Afectar = (from n in Caja
                           select new DSMarket.Logica.Entidades.EntidadesCaja.ECajaGeneral
                           {
                               IdCaja=n.IdCaja,
                               Caja=n.Descripcion,
                               MontoActual=n.MontoActual,
                               Estatus0=n.Estatus
                           }).FirstOrDefault();
            }
            return Afectar;
        }

        //BUSCAR EL LISTADO DEL HISTORIAL DE CAJA
        public List<DSMarket.Logica.Entidades.EntidadesCaja.EHistorialCaja> BuscaHistorialCaja(decimal? IdHistorialCaja = null, decimal? IdCaja = null, DateTime? FechaDesde = null, DateTime? FechaHasta = null)
        {
            ObjData.CommandTimeout = 999999999;

            var Listado = (from n in ObjData.SP_BUSCA_HISTORIAL_CAJA(IdHistorialCaja, IdCaja, FechaDesde, FechaHasta)
                           select new DSMarket.Logica.Entidades.EntidadesCaja.EHistorialCaja
                           {
                               IdHistorialCaja=n.IdHistorialCaja,
                               IdCaja=n.IdCaja,
                               Monto=n.Monto,
                               Concepto=n.Concepto,
                               Fecha0=n.Fecha0,
                               Fecha=n.Fecha,
                               IdUsuario=n.IdUsuario,
                               CreadoPor=n.CreadoPor,
                               NumeroReferencia=n.NumeroReferencia,
                               IdTipoPago=n.IdTipoPago,
                               TipoPago=n.TipoPago,
                               Total=n.Total
                           }).ToList();
            return Listado;
        }

        //MANTENIMIENTO DE HISTORIAL DE CAJA
        public DSMarket.Logica.Entidades.EntidadesCaja.EHistorialCaja MantenimientoHistorialCaja(DSMarket.Logica.Entidades.EntidadesCaja.EHistorialCaja Item, string Accion)
        {
            DSMarket.Logica.Entidades.EntidadesCaja.EHistorialCaja Guardar = null;

           var HistorialCaja= ObjData.SP_MANTENIMIENTO_HISTORIAL_CAJA(
                Item.IdHistorialCaja,
                Item.IdCaja,
                Item.Monto,
                Item.Concepto,
                Item.IdUsuario,
                Item.NumeroReferencia,
                Item.IdTipoPago,
                Accion);
            if (HistorialCaja != null) {
                Guardar = (from n in HistorialCaja
                           select new DSMarket.Logica.Entidades.EntidadesCaja.EHistorialCaja
                           {
                               IdHistorialCaja=n.IdHistorialCaja,
                               IdCaja=n.IdCaja,
                               Monto=n.Monto,
                               Concepto=n.Concepto,
                               Fecha0=n.Fecha,
                               IdUsuario=n.IdUsuario,
                               NumeroReferencia=n.NumeroReferencia,
                               IdTipoPago=n.IdTipoPago
                           }).FirstOrDefault();
            }
            return Guardar;
        }


        //REPORTE DE CUADRE DE CAJA
        public List<DSMarket.Logica.Entidades.EntidadesCaja.EReporteCuadreCaja> ReporteCuadreCaja(decimal? IdUsuario = null) {
            ObjData.CommandTimeout = 999999999;

            var Listado = (from n in ObjData.SP_GENERAR_REPORTE_CUADRE_CAJA(IdUsuario)
                           select new DSMarket.Logica.Entidades.EntidadesCaja.EReporteCuadreCaja
                           {
                               IdUsuario=n.IdUsuario,
                               GeneradoPor=n.GeneradoPor,
                               IdCaja=n.IdCaja,
                               Monto=n.Monto,
                               Concepto=n.Concepto,
                               FechaProcesado0=n.FechaProcesado0,
                               FechaProcesado=n.FechaProcesado,
                               FechaDesde0=n.FechaDesde0,
                               FechaDesde=n.FechaDesde,
                               FechaHasta0=n.FechaHasta0,
                               FechaHasta=n.FechaHasta,
                               NumeroReferencia=n.NumeroReferencia,
                               IdTipoPago=n.IdTipoPago,
                               TipoPago=n.TipoPago,
                               NombreEmpresa=n.NombreEmpresa,
                               RNC=n.RNC,
                               Direccion=n.Direccion,
                               Telefonos=n.Telefonos,
                               Email=n.Email,
                               Email2=n.Email2,
                               Facebook=n.Facebook,
                               Instagran=n.Instagran,
                               LogoEmpresa=n.LogoEmpresa,
                               MontoTotal=n.MontoTotal,
                               Cantidadmovimientos=n.Cantidadmovimientos

                           }).ToList();
            return Listado;
        }

        //BUSCAR EL MONTO INICIAL DE LA CAJA
        public List<DSMarket.Logica.Entidades.EntidadesCaja.EMontoInicialCaja> BuscaMontoInicialCaja(int? IdCaja = null) {
            ObjData.CommandTimeout = 999999999;

            var Buscar = (from n in ObjData.SP_BUSCAR_MONTO_INICIAL_CAJA(IdCaja)
                          select new DSMarket.Logica.Entidades.EntidadesCaja.EMontoInicialCaja
                          {
                              IdCaja=n.IdCaja,
                              MontoInicialCaja=n.MontoInicialCaja
                          }).ToList();
            return Buscar;
        }


        //MANTENIMIENTO DEL MONTO DE LA CAJA
        public DSMarket.Logica.Entidades.EntidadesCaja.EMontoInicialCaja MantenimientoMontoInicialCaja(DSMarket.Logica.Entidades.EntidadesCaja.EMontoInicialCaja Item, string Accion) {
            ObjData.CommandTimeout = 999999999;

            DSMarket.Logica.Entidades.EntidadesCaja.EMontoInicialCaja MAntenimiento = null;

            var MontoInicialCaja = ObjData.SP_MODIFICAR_MONTO_INICIAL_CAJA(
                Item.IdCaja,
                Item.MontoInicialCaja,
                Accion);
            if (MontoInicialCaja != null) {
                MAntenimiento = (from n in MontoInicialCaja
                                 select new DSMarket.Logica.Entidades.EntidadesCaja.EMontoInicialCaja
                                 {
                                     IdCaja=n.IdCaja,
                                     MontoInicialCaja=n.MontoInicialCaja
                                 }).FirstOrDefault();
            }
            return MAntenimiento;

        }

        #region MANTENIMIENTO DE HISTORIAL DE CIERRE DE CAJA
        //LISTADO DE HISTORIAL DE CIERRE CAJA
        public List<DSMarket.Logica.Entidades.EntidadesCaja.EHistorialCierreCaja> BuscaHistorialCierreCaja(decimal? IdHistorialCierreCaja = null, decimal? IdUsuario = null, DateTime? FechaCierreDesde = null, DateTime? FechaCierreHasta = null, int? NumeroPagina = null, int? NumeroRegistros = null) {
            ObjData.CommandTimeout = 999999999;

            var Listado = (from n in ObjData.SP_BUSCA_HISTORIAL_CIERRE_CAJA(IdHistorialCierreCaja, IdUsuario, FechaCierreDesde, FechaCierreHasta, NumeroPagina, NumeroRegistros)
                           select new DSMarket.Logica.Entidades.EntidadesCaja.EHistorialCierreCaja
                           {
                               IdHistirualCierreCaja=n.IdHistirualCierreCaja,
                               IdUsuario=n.IdUsuario,
                               CerradoPor=n.CerradoPor,
                               FechaCierre0=n.FechaCierre0,
                               FechaCierre=n.FechaCierre,
                               MontoAntesCerrar=n.MontoAntesCerrar,
                               MontoDespuesCierre=n.MontoDespuesCierre,
                               ConceptoCierre=n.ConceptoCierre
                           }).ToList();
            return Listado;
        }

        //MANTENIMIENTO DE HISTORIAL DE CIERRE DE CAJA
        public DSMarket.Logica.Entidades.EntidadesCaja.EHistorialCierreCaja MantenimientoHistorialCierreCaja(DSMarket.Logica.Entidades.EntidadesCaja.EHistorialCierreCaja Item, string Accion) {
            ObjData.CommandTimeout = 999999999;

            DSMarket.Logica.Entidades.EntidadesCaja.EHistorialCierreCaja Mantenimiento = null;

            var HistorialCierreCaja = ObjData.SP_MANTENIMIENTO_HISTORIAL_CIERRE_CAJA(
                Item.IdHistirualCierreCaja,
                Item.IdUsuario,
                Item.MontoAntesCerrar,
                Item.MontoDespuesCierre,
                Item.ConceptoCierre,
                Accion);
            if (HistorialCierreCaja != null) {
                Mantenimiento = (from n in HistorialCierreCaja
                                 select new DSMarket.Logica.Entidades.EntidadesCaja.EHistorialCierreCaja
                                 {
                                     IdHistirualCierreCaja=n.IdHistorialCierreCaja,
                                     IdUsuario=n.IdUsuario,
                                     FechaCierre0=n.FechaCierre,
                                     MontoAntesCerrar=n.MontoAntesCerrar,
                                     MontoDespuesCierre=n.MontoDespuesCerrar,
                                     ConceptoCierre=n.ConceptoCierre
                                 }).FirstOrDefault();
            }
            return Mantenimiento;
        }
        #endregion

    }
}
