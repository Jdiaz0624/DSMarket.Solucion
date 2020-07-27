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
        #region LISTADO DE INFORMACION DE EMPRESA
        /// <summary>
        /// Este metodo es para buscar los comprobantes fiscales en caso de que esten activo esta opción en la configuracion
        /// </summary>
        /// <returns></returns>
        public List<DSMarket.Logica.Entidades.EntidadesListas.EListaComprobantesFiscales> BuscaCOmprobantesFiscales()
        {
            ObjDataListas.CommandTimeout = 999999999;

            var Listado = (from n in ObjDataListas.SP_BUSCA_COMPROBANTE_FISCALES()
                           select new DSMarket.Logica.Entidades.EntidadesListas.EListaComprobantesFiscales
                           {
                               IdComprobante=n.IdComprobante,
                               Comprbante=n.Comprbante
                           }).ToList();
            return Listado;
        }
        #endregion
        #region LISTADO DE LOS COMPROBANTES NULOS
        /// <summary>
        /// Este metodo es para mostrar la lista de que los comprobantes cuando no se esta usando los comprobante fiscales para facturar
        /// </summary>
        /// <returns></returns>
        public List<DSMarket.Logica.Entidades.EntidadesListas.EComprobantesNulos> BuscaComprobantesnulos()
        {
            ObjDataListas.CommandTimeout = 999999999;

            var Buscar = (from n in ObjDataListas.SP_BUSCA_LISTA_COMPROBANTE_NULOS()
                          select new DSMarket.Logica.Entidades.EntidadesListas.EComprobantesNulos
                          {
                              IdComprobanteNulo=n.IdComprobanteNulo,
                              Descripcion=n.Descripcion
                          }).ToList();
            return Buscar;
        }
        #endregion
        #region LISTADO DE TIPO DE IDENTIFICACION
        /// <summary>
        /// Este metodo es para mostrar el listado de los tipos de identificacion
        /// </summary>
        /// <returns></returns>
        public List<DSMarket.Logica.Entidades.EntidadesListas.EListaTipoIdentificacion> BuscaTipoIdentificacion() {
            ObjDataListas.CommandTimeout = 999999999;

            var Listado = (from n in ObjDataListas.SP_LISTADO_TIPO_IDENTIFICACION()
                           select new DSMarket.Logica.Entidades.EntidadesListas.EListaTipoIdentificacion
                           {
                               IdTipoIdentificacion=n.IdTipoIdentificacion,
                               TipoIdentificacion=n.TipoIdentificacion
                           }).ToList();
            return Listado;
        }
        #endregion
        #region LISTADO DE TIPO DE VENTA
        public List<DSMarket.Logica.Entidades.EntidadesListas.EListaTipoVenta> BuscaTipoVenta() {
            ObjDataListas.CommandTimeout = 999999999;

            var Buscar = (from n in ObjDataListas.SP_BUSCA_TIPO_VENTA()
                          select new DSMarket.Logica.Entidades.EntidadesListas.EListaTipoVenta
                          {
                              IdTipoVenta=n.IdTipoVenta,
                              TipoVenta=n.TipoVenta
                          }).ToList();
            return Buscar;
        }
        #endregion
        #region LISTADO DE LA CANTIDAD DE DIAS
        public List<DSMarket.Logica.Entidades.EntidadesListas.ECantidadDias> ListadoCantidadDias() {
            ObjDataListas.CommandTimeout = 999999999;

            var BuscaCantidadDias = (from n in ObjDataListas.SP_CANTIDAD_DIAS()
                                     select new DSMarket.Logica.Entidades.EntidadesListas.ECantidadDias
                                     {
                                         IdCantidadDias=n.IdCantidadDias,
                                         CantidadDias=n.CantidadDias
                                     }).ToList();
            return BuscaCantidadDias;
        }
        #endregion
        #region LISTADO DE LOS TIPOS DE PAGOS
        public List<DSMarket.Logica.Entidades.EntidadesListas.EListadoTipoPago> BuscaTipoPago(decimal? IdTipoPago = null)
        {
            ObjDataListas.CommandTimeout = 999999999;

            var Listado = (from n in ObjDataListas.SP_LISTADO_TIPO_PAGO(IdTipoPago)
                           select new DSMarket.Logica.Entidades.EntidadesListas.EListadoTipoPago
                           {
                               IdTipoPago=n.IdTipoPago,
                               TipoPago=n.TipoPago,
                               BloqueaMonto=n.BloqueaMonto
                           }).ToList();
            return Listado;
        }
        #endregion
        #region BUSCAR LISTADO ESTATUS FACTURACION
        public List<DSMarket.Logica.Entidades.EntidadesListas.EListaEstatusFacturacion> BuscaListaEstatusFacturacion() {
            ObjDataListas.CommandTimeout = 999999999;

            var Listado = (from n in ObjDataListas.SP_BUSCA_LISTADO_ESTATUS_FACTURACION()
                           select new DSMarket.Logica.Entidades.EntidadesListas.EListaEstatusFacturacion
                           {
                               IdEstatusFacturacion=n.IdEstatusFacturacion,
                               Estatus=n.Estatus
                           }).ToList();
            return Listado;
        }
        #endregion
        #region LISTADO DE LOS NIVELES DE ACCESO
        public List<DSMarket.Logica.Entidades.EntidadesListas.EListaNivelAcceso> ListadoNivelesAccesp() {
            ObjDataListas.CommandTimeout = 999999999;

            var Listado = (from n in ObjDataListas.SP_LISTADO_NIVEL_ACCESO()
                           select new DSMarket.Logica.Entidades.EntidadesListas.EListaNivelAcceso
                           {
                               IdNivelAcceso=n.IdNivelAcceso,
                               Descripcion=n.Descripcion
                           }).ToList();
            return Listado;
        }
        #endregion
        #region LISTADO DE USUARIOS
        public List<DSMarket.Logica.Entidades.EntidadesListas.EListaUsuarios> ListaUsuarios() {
            ObjDataListas.CommandTimeout = 999999999;

            var Buscar = (from n in ObjDataListas.SP_LISTA_USUARIOS()
                          select new DSMarket.Logica.Entidades.EntidadesListas.EListaUsuarios
                          {
                              IdUsuario=n.IdUsuario,
                              Persona=n.Persona
                          }).ToList();
            return Buscar;
        }
        #endregion
    }
}
