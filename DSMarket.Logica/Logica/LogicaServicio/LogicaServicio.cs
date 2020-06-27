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
    }
}
