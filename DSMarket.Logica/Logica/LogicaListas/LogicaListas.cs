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
        #region BUSCA LISTA TIPO SUPLIDOR
        public List<DSMarket.Logica.Entidades.EntidadesListas.EListaTipoSuplidor> BuscaListaTipoSuplidor()
        {
            ObjDataListas.CommandTimeout = 999999999;

            var Lista = (from n in ObjDataListas.SP_BUSCA_LISTA_TIPO_SUPLIDOR()
                         select new DSMarket.Logica.Entidades.EntidadesListas.EListaTipoSuplidor
                         {
                             IdTipoSuplidor=n.IdTipoSuplidor,
                             Descripcion=n.Descripcion
                         }).ToList();
            return Lista;
        }
        #endregion
        #region OSTRAR EL LOSTADO DE LA CATEGORIAS
        public List<DSMarket.Logica.Entidades.EntidadesListas.EListaCategorias> ListadoCategorias(decimal? IdTipoProducto = null)
        {
            ObjDataListas.CommandTimeout = 999999999;

            var Lista = (from n in ObjDataListas.SP_LISTADO_CATEGORIAS(IdTipoProducto)
                         select new DSMarket.Logica.Entidades.EntidadesListas.EListaCategorias
                         {
                             IdCategoria=n.IdCategoria,
                             Descripcion=n.Descripcion
                         }).ToList();
            return Lista;
        }
        #endregion
        #region MOSTRAR UNIDAD DE MEDIDA
        public List<DSMarket.Logica.Entidades.EntidadesListas.EUnidadMedida> BuscaUnidadMedida() {
            ObjDataListas.CommandTimeout = 999999999;

            var Listado = (from n in ObjDataListas.SP_LISTADO_UNIDAD_MEDIDA()
                           select new DSMarket.Logica.Entidades.EntidadesListas.EUnidadMedida
                           {
                               IdUnidadMedida = n.IdUnidadMedida,
                               Descripcion=n.Descripcion
                           }).ToList();
            return Listado;
        }
        #endregion
        #region MOSTRAR LISTADO DE MODELOS
        public List<DSMarket.Logica.Entidades.EntidadesListas.EListaModeos> BuscaListaModelos(decimal? IdMarca = null)
        {
            ObjDataListas.CommandTimeout = 999999999;

            var Listado = (from n in ObjDataListas.SP_CARGAR_LISTA_MODELOS(IdMarca)
                           select new DSMarket.Logica.Entidades.EntidadesListas.EListaModeos
                           {
                               IdModelo=n.IdModelo,
                               Descripcion=n.Descripcion
                           }).ToList();
            return Listado;
        }

        #endregion
        #region MOSTRAR LISTADO DE SUPLIDORES
        public List<DSMarket.Logica.Entidades.EntidadesListas.EListaSuplidor> BuscaListaSuplidores(decimal? IdTipoSuplidor = null)
        {
            ObjDataListas.CommandTimeout = 999999999;

            var Buscar = (from n in ObjDataListas.SP_LISTAS_SUPLIDORES(IdTipoSuplidor)
                          select new DSMarket.Logica.Entidades.EntidadesListas.EListaSuplidor
                          {
                              IdSuplidor=n.IdSuplidor,
                              Nombre=n.Nombre
                          }).ToList();
            return Buscar;
        }
        #endregion
    }
}
