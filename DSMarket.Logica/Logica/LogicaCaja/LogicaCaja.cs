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
                               TipoPago=n.TipoPago
                           }).ToList();
            return Listado;
        }

        //MANTENIMIENTO DE HISTORIAL DE CAJA
        public DSMarket.Logica.Entidades.EntidadesCaja.EHistorialCaja MantenimientoHistorialCaja(DSMarket.Logica.Entidades.EntidadesCaja.EHistorialCaja Item, string Accion)
        {
            DSMarket.Logica.Entidades.EntidadesCaja.EHistorialCaja Guardar = null;

           var HistorialCaja= ObjData.SP_GUARDAR_HISTORIAL_CAJA(
                Item.IdHistorialCaja,
                Item.IdCaja,
                Item.Monto,
                Item.Concepto,
                Item.Fecha0,
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
    }
}
