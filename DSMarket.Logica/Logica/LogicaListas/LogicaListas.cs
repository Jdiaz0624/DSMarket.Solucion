using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Logica.LogicaListas
{
    public class LogicaListas
    {
        DSMarket.Data.Conexion.ConexionLINQ.BDConexionListasDataContext ObjDataListas = new Data.Conexion.ConexionLINQ.BDConexionListasDataContext(System.Configuration.ConfigurationManager.ConnectionStrings["DSMarketConexion"].ConnectionString);

        #region LISTA TIPO DE PRODUCTO
        public List<DSMarket.Logica.Entidades.EntidadesListas.EListaTipoProducto> ListaTipoProducto(decimal? IdTipoProducto = null, string Descripcion = null)
        {
            ObjDataListas.CommandTimeout = 999999999;

            var Listado = (from n in ObjDataListas.SP_CARGAR_LISTA_TIPO_PRODUCTO(IdTipoProducto, Descripcion)
                           select new DSMarket.Logica.Entidades.EntidadesListas.EListaTipoProducto
                           {
                               IdTipoproducto=n.IdTipoproducto,
                               Descripcion=n.Descripcion
                           }).ToList();
            return Listado;
        }
        #endregion
        #region LISTA DE MARCAS
        public List<DSMarket.Logica.Entidades.EntidadesListas.EListaMarcas> BucaLisaMarcas()
        {
            ObjDataListas.CommandTimeout = 999999999;

            var Buscar = (from n in ObjDataListas.SP_CARGAR_MARCAS()
                          select new DSMarket.Logica.Entidades.EntidadesListas.EListaMarcas
                          {
                              IdMarca = n.IdMarca,
                              Descripcion = n.Descripcion
                          }).ToList();
            return Buscar;
        }
        #endregion
    }
}
