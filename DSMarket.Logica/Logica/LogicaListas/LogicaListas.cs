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
        public List<DSMarket.Logica.Entidades.EntidadesListas.EListaMarcas> BucaLisaMarcas(decimal? IdCategoria = null)
        {
            ObjDataListas.CommandTimeout = 999999999;

            var Buscar = (from n in ObjDataListas.SP_CARGAR_MARCAS(IdCategoria)
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
                               BloqueaMonto=n.BloqueaMonto,
                               ImpuestoAdicional=n.ImpuestoAdicional,
                               PorcentajeEntero=n.PorcentajeEntero,
                               Valor=n.Valor
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
        #region LISTADO DE TIPO DE MAIL
        public List<DSMarket.Logica.Entidades.EntidadesListas.EListaTipoMail> BuscaTipoMail() {
            ObjDataListas.CommandTimeout = 999999999;

            var Listado = (from n in ObjDataListas.SP_BUSCA_LISTA_TIPO_MAIL()
                           select new DSMarket.Logica.Entidades.EntidadesListas.EListaTipoMail
                           {
                               IdTipoMail=n.IdTipoMail,
                               TipoMail=n.TipoMail
                           }).ToList();
            return Listado;
        }
        #endregion
        #region LISTADO DE BIENES Y SERVICIOS
        public List<DSMarket.Logica.Entidades.EntidadesListas.ETipoBienesServicios> ListadoBienesServicios() {
            ObjDataListas.CommandTimeout = 999999999;

            var Listado = (from n in ObjDataListas.SP_LISTADO_BIENES_SERVICIOS()
                           select new DSMarket.Logica.Entidades.EntidadesListas.ETipoBienesServicios
                           {
                               IdTipoBienesServicio=n.IdTipoBienesServicio,
                               Descripcion=n.Descripcion
                           }).ToList();
            return Listado;
        }
        #endregion
        #region LISTADO DE TIPO DE RETENCION ISR
        public List<DSMarket.Logica.Entidades.EntidadesListas.ETipoRetencionISR> BuscaTipoRetencionISR() {
            ObjDataListas.CommandTimeout = 999999999;

            var Listado = (from n in ObjDataListas.SP_LISTADO_TIPO_RETENCION_ISR()
                           select new DSMarket.Logica.Entidades.EntidadesListas.ETipoRetencionISR
                           {
                               IdTipoRetencionISR=n.IdTipoRetencionISR,
                               Descripcion=n.Descripcion,
                               Estatus=n.Estatus
                           }).ToList();
            return Listado;
        }
        #endregion
        #region LISTADO TIPOS DEINGRESOS
        //CARGAR LISTDO DE TIPOS DE INGRESOS
        public List<DSMarket.Logica.Entidades.EntidadesListas.EListaTipoIngresos> ListadoTipoIngresos() {
            ObjDataListas.CommandTimeout = 999999999;

            var Listado = (from n in ObjDataListas.SP_BUSCA_LISTA_TIPO_INGRESOS()
                           select new DSMarket.Logica.Entidades.EntidadesListas.EListaTipoIngresos
                           {
                               IdTipoIngreso=n.IdTipoIngreso,
                               Descripcion=n.Descripcion

                           }).ToList();
            return Listado;
        }
        #endregion
        #region MOSTRAR LOS TIPOS DE ANULACIONES
        public List<DSMarket.Logica.Entidades.EntidadesListas.EListadoTipoAnulaicon> ListadoTipoAnulaciones() {
            ObjDataListas.CommandTimeout = 999999999;

            var Listado = (from n in ObjDataListas.SP_MOSTRAR_LISTADO_TIPO_ANULACION()
                           select new DSMarket.Logica.Entidades.EntidadesListas.EListadoTipoAnulaicon
                           {
                               IdTipoAnulacion=n.IdTipoAnulacion,
                               Descripcion=n.Descripcion
                           }).ToList();
            return Listado;
        }
        #endregion

        #region PROPIEDADES CATALOGO CUENTAS
        //LISTADO DE CLASES DE CUENTAS CONTABLES
        public List<DSMarket.Logica.Entidades.EntidadesListas.EClasesCuentasContables> BuscaClasesCuentasContables()
        {
            ObjDataListas.CommandTimeout = 999999999;

            var Listado = (from n in ObjDataListas.SP_BUSCAR_LISTADO_CLASES_CUENTAS_CONTABLES()
                           select new DSMarket.Logica.Entidades.EntidadesListas.EClasesCuentasContables
                           {
                               IdClaseCuenta=n.IdClaseCuenta,
                               Descripcion=n.Descripcion
                           }).ToList();
            return Listado;
        }

        //LISTADO DE ORIGENES DE CUENTAS CONTABLES
        public List<DSMarket.Logica.Entidades.EntidadesListas.EOrigenCuentaContables> BuscaOrigenesCuentasCOntables() {
            ObjDataListas.CommandTimeout = 999999999;

            var Listado = (from n in ObjDataListas.SP_BUSCA_ORIGEN_CUENTAS_CONTABLES()
                           select new DSMarket.Logica.Entidades.EntidadesListas.EOrigenCuentaContables
                           {
                               IdOrigenCuenta=n.IdOrigenCuenta,
                               Descripcion=n.Descripcion
                              
                           }).ToList();
            return Listado;
        }

        //LISTADO DE TIPO DE CUENTAS CONTABLES
        public List<DSMarket.Logica.Entidades.EntidadesListas.ETipoCuentasContables> BuscaTiposCuentasContables() {
            ObjDataListas.CommandTimeout = 999999999;

            var Listado = (from n in ObjDataListas.SP_BUSCA_TIPO_CUENTAS_CONTABLES()
                           select new DSMarket.Logica.Entidades.EntidadesListas.ETipoCuentasContables
                           {
                               IdTipoCuentas=n.IdTipoCuentas,
                               Descripcion=n.Descripcion
                           }).ToList();
            return Listado;
        }

        //LISTADO DE ACEPTA MOVIMIENTOS CUENTAS CONTABLES
        public List<DSMarket.Logica.Entidades.EntidadesListas.EAceptaMovimientoCuentasCOntables> BuscaAceptaMovimientoSCuentasCotables() {
            ObjDataListas.CommandTimeout = 999999999;

            var Listado = (from n in ObjDataListas.SP_BUSCA_ACEPTA_MOVIMIENTOS_CUENTAS_CONTABLES()
                           select new DSMarket.Logica.Entidades.EntidadesListas.EAceptaMovimientoCuentasCOntables
                           {
                               IdMovimientoCuenta=n.IdMovimientoCuenta,
                               Descripcion=n.Descripcion
                           }).ToList();
            return Listado;
        }
        #endregion
        #region LISTADO DE COLORES
        public List<DSMarket.Logica.Entidades.EntidadesListas.EColor> ListadoColores() {
            ObjDataListas.CommandTimeout = 999999999;

            var Listado = (from n in ObjDataListas.SP_LISTADO_COLORES()
                           select new DSMarket.Logica.Entidades.EntidadesListas.EColor
                           {
                               IdColor=n.IdColor,
                               Color=n.Color
                           }).ToList();
            return Listado;
        }
        #endregion
        #region LISTADO DE CONDICIONES
        public List<DSMarket.Logica.Entidades.EntidadesListas.ECondicion> ListadoCondiciones() {
            ObjDataListas.CommandTimeout = 999999999;

            var Listado = (from n in ObjDataListas.SP_LISTADO_CONDICIONES()
                           select new DSMarket.Logica.Entidades.EntidadesListas.ECondicion
                           {
                               IdCondicion=n.IdCondicion,
                               Condicion=n.Condicion
                           }).ToList();
            return Listado;
        }
        #endregion

        #region LISTADO DE CAPACIDAD
        public List<DSMarket.Logica.Entidades.EntidadesListas.ECapacidadArticulos> ListadoCapacidad() {
            ObjDataListas.CommandTimeout = 999999999;

            var Listado = (from n in ObjDataListas.SP_LISTADO_CAPACIDAD_ARTICULO()
                           select new DSMarket.Logica.Entidades.EntidadesListas.ECapacidadArticulos
                           {
                               IdCapacidad=n.IdCapacidad,
                               Capacidad=n.Capacidad
                           }).ToList();
            return Listado;
        }
        #endregion
    }
}
