using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Logica.LogicaContabilidad
{
    public class LogicaContabilidad
    {
        DSMarket.Data.Conexion.ConexionLINQ.BDConexionContabilidadDataContext ObjData = new Data.Conexion.ConexionLINQ.BDConexionContabilidadDataContext(System.Configuration.ConfigurationManager.ConnectionStrings["DSMarketConexion"].ConnectionString);
        #region MANTENIMIENTO DE CATALOGO DE CUENTAS
        //LISTADO DE CATALOGO DE CUENTAS
        public List<DSMarket.Logica.Entidades.EntidadesContabilidad.ECatalogoCuentas> BuscaCatalogoCuentas(decimal? IdRegistro = null, string CuentaContable = null, string Auxiliar = null, string DescripcionCuenta = null, string CuentaDecarge = null, int? NumeroPagina = null, int? NumeroRegistros = null) {
            ObjData.CommandTimeout = 999999999;

            var Listado = (from n in ObjData.SP_BUSCA_REGISTROS_CATALOGO_CUENTAS(IdRegistro, CuentaContable, Auxiliar, DescripcionCuenta, CuentaDecarge, NumeroPagina, NumeroRegistros)
                           select new DSMarket.Logica.Entidades.EntidadesContabilidad.ECatalogoCuentas
                           {
                               IdRegistro=n.IdRegistro,
                               Cuenta=n.Cuenta,
                               Auxiliar=n.Auxiliar,
                               NombreCuenta=n.NombreCuenta,
                               IdOrigenCuenta=n.IdOrigenCuenta,
                               Origen=n.Origen,
                               IdTipoCuenta=n.IdTipoCuenta,
                               Tipo=n.Tipo,
                               IdClaseCuenta=n.IdClaseCuenta,
                               Clase=n.Clase,
                               IdAceptaMovimientoCuenta=n.IdAceptaMovimientoCuenta,
                               AceptaMovimiento=n.AceptaMovimiento,
                               CodAnexo=n.CodAnexo,
                               CuentaDescargo=n.CuentaDescargo,
                               CuentaPresupuesto=n.CuentaPresupuesto,
                               AuxiliarPresupuesto=n.AuxiliarPresupuesto,
                               Estatus0=n.Estatus0,
                               Estatus=n.Estatus,
                               CuentaAnterior=n.CuentaAnterior,
                               UsuarioAdiciona=n.UsuarioAdiciona,
                               CreadoPor=n.CreadoPor,
                               FechaAdiciona=n.FechaAdiciona,
                               FechaCreado=n.FechaCreado,
                               UsuarioModifica=n.UsuarioModifica,
                               ModificadoPor=n.ModificadoPor,
                               FechaModifica=n.FechaModifica,
                               FechaModificado=n.FechaModificado
                           }).ToList();
            return Listado;
        }

        //MANTENIMIENTO DE CATALOGO DE CUENTAS
        public DSMarket.Logica.Entidades.EntidadesContabilidad.ECatalogoCuentas MantenimientoCatalogoCuentas(DSMarket.Logica.Entidades.EntidadesContabilidad.ECatalogoCuentas Item, string Accion) {
            ObjData.CommandTimeout = 999999999;

            DSMarket.Logica.Entidades.EntidadesContabilidad.ECatalogoCuentas Mantenimiento = null;

            var CatalogoCuentas = ObjData.SP_MANTENIMIENTO_CATALOGO_CUENTA(
                Item.IdRegistro,
                Item.Cuenta,
                Item.Auxiliar,
                Item.NombreCuenta,
                Item.IdOrigenCuenta,
                Item.IdTipoCuenta,
                Item.IdClaseCuenta,
                Item.IdAceptaMovimientoCuenta,
                Item.CodAnexo,
                Item.CuentaDescargo,
                Item.CuentaPresupuesto,
                Item.AuxiliarPresupuesto,
                Item.Estatus0,
                Item.CuentaAnterior,
                Item.UsuarioAdiciona,
                Accion);
            if (CatalogoCuentas != null) {
                Mantenimiento = (from n in CatalogoCuentas
                                 select new DSMarket.Logica.Entidades.EntidadesContabilidad.ECatalogoCuentas
                                 {
                                     IdRegistro=n.IdRegistro,
                                     Cuenta=n.Cuenta,
                                     Auxiliar=n.Auxiliar,
                                     NombreCuenta=n.Descripcion,
                                     IdOrigenCuenta=n.IdOrigenCuenta,
                                     IdTipoCuenta=n.IdTipoCuenta,
                                     IdClaseCuenta=n.IdClaseCuenta,
                                     IdAceptaMovimientoCuenta=n.IdAceptaMovimientoCuenta,
                                     CodAnexo=n.CodAnexo,
                                     CuentaDescargo=n.CuentaDescargo,
                                     CuentaPresupuesto=n.CuentaPresupuesto,
                                     AuxiliarPresupuesto=n.AuxiliarPresupuesto,
                                     Estatus0=n.Estatus,
                                     CuentaAnterior=n.CuentaAnterior,
                                     UsuarioAdiciona=n.UsuarioAdiciona,
                                     FechaAdiciona=n.FechaAdiciona,
                                     UsuarioModifica=n.UsuarioModifica,
                                     FechaModifica=n.FechaModifica
                                 }).FirstOrDefault();
            }
            return Mantenimiento;
        }
        #endregion

     
    }
}
