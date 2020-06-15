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
    }
}
