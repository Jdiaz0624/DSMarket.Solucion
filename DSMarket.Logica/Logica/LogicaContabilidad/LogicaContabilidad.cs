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
        #region MANTENIMIENTO DE CUENTAS MOVIMIENTOS
        public DSMarket.Logica.Entidades.EntidadesContabilidad.EGuardarCuentasMovimientos GuardarCuentasMovimientos(DSMarket.Logica.Entidades.EntidadesContabilidad.EGuardarCuentasMovimientos Item, string Accion) {
            ObjData.CommandTimeout = 999999999;

            DSMarket.Logica.Entidades.EntidadesContabilidad.EGuardarCuentasMovimientos Mantenimiento = null;

            var CuentasMovimientos = ObjData.SP_GUARDAR_CUENTAS_MOVIMIENTOS(
                Item.IdRegistro,
                Item.Ano,
                Item.Mes,
                Item.IdTipoCuenta,
                Item.IdModulo,
                Item.Conector,
                Item.Secuencia,
                Item.Banco,
                Item.Cuenta,
                Item.Auxiliar,
                Item.Valor,
                Item.IdOrigen,
                Item.ConceptoCuenta,
                Item.NumeroRelacionado,
                Item.IdClaseCuenta,
                Item.IdCuentaContable,
                Accion);
            if (CuentasMovimientos != null) {
                Mantenimiento = (from n in CuentasMovimientos
                                 select new DSMarket.Logica.Entidades.EntidadesContabilidad.EGuardarCuentasMovimientos
                                 {
                                     IdRegistro=n.IdRegistro,
                                     Ano=n.Ano,
                                     Mes=n.Mes,
                                     IdTipoCuenta=n.IdTipoCuenta,
                                     IdModulo=n.IdModulo,
                                     Conector=n.Conector,
                                     Secuencia=n.Secuencia,
                                     Banco=n.Banco,
                                     Cuenta=n.Cuenta,
                                     Auxiliar=n.Auxiliar,
                                     Valor=n.Valor,
                                     IdOrigen=n.IdOrigen,
                                     ConceptoCuenta=n.ConceptoCuenta,
                                     NumeroRelacionado=n.NumeroRelacionado,
                                     IdClaseCuenta=n.IdClaseCuenta,
                                     IdCuentaContable=n.IdCuentaContable
                                 }).FirstOrDefault();

            }
            return Mantenimiento;

        }
        #endregion
        #region MANTENIMIENTO DE BANCOS
        //LISTADO DE BANCOS
        public List<DSMarket.Logica.Entidades.EntidadesContabilidad.EBancos> BuscaBancos(decimal? IdBanco = null, string Banco = null, bool? PorDefecto = null, int? NumeroPagina = null, int? NumeroRegistros = null) {
            ObjData.CommandTimeout = 999999999;

            var Listado = (from n in ObjData.SP_BUSCA_BANCOS(IdBanco, Banco, PorDefecto, NumeroPagina, NumeroRegistros)
                           select new DSMarket.Logica.Entidades.EntidadesContabilidad.EBancos
                           {
                               IdBanco=n.IdBanco,
                               Banco=n.Banco,
                               Estatus0=n.Estatus0,
                               Estatus=n.Estatus,
                               PorDefecto0=n.PorDefecto0,
                               PorDefecto=n.PorDefecto,
                               
                           }).ToList();
            return Listado;
        }
        //MANTENIMIENTO DE BANCOS
        public DSMarket.Logica.Entidades.EntidadesContabilidad.EBancos MantenimientoBancos(DSMarket.Logica.Entidades.EntidadesContabilidad.EBancos Item, string Accion) {
            ObjData.CommandTimeout = 999999999;

            DSMarket.Logica.Entidades.EntidadesContabilidad.EBancos Mantenimiento = null;

            var Bancos = ObjData.SP_MANTENIMIENTO_BANCOS(
                Item.IdBanco,
                Item.Banco,
                Item.Estatus0,
                Item.PorDefecto0,
                Accion);
            if (Bancos != null) {
                Mantenimiento = (from n in Bancos
                                 select new DSMarket.Logica.Entidades.EntidadesContabilidad.EBancos
                                 {
                                     IdBanco=Convert.ToInt32(n.IdBanco),
                                     Banco=n.Banco,
                                     Estatus0=n.Estatus,
                                     PorDefecto0=n.PorDefecto
                                 }).FirstOrDefault();
            }
            return Mantenimiento;
        }
        #endregion
        #region BUSCA CONCEPTOS CUENTAS PROCESOS
        public List<DSMarket.Logica.Entidades.EntidadesContabilidad.EConceptoCuentasProcesos> BuscaProcesosCuentas(int? IdConceptoCuentasProcesos = null) {
            ObjData.CommandTimeout = 999999999;

            var Buscar = (from n in ObjData.SP_BUSCA_CONCEPTOS_CUENTAS_PROCESOS(IdConceptoCuentasProcesos)
                          select new DSMarket.Logica.Entidades.EntidadesContabilidad.EConceptoCuentasProcesos
                          {
                              IdConceptoCuentasProcesos=n.IdConceptoCuentasProcesos,
                              Concepto=n.Concepto
                          }).ToList();
            return Buscar;
        }
        #endregion
        #region SACAR INFORMACION CUENTAS MOVIMIENTOS
        public List<DSMarket.Logica.Entidades.EntidadesContabilidad.ESacarInformacionCuentasMovimientos> SacarInformacionCuentasMovimientos(string Ano = null, string Mes = null) {
            ObjData.CommandTimeout = 999999999;

            var Listado = (from n in ObjData.SP_SACAR_INFORMACION_CUENTAS_MOVIMIENTOS(Ano, Mes)
                           select new DSMarket.Logica.Entidades.EntidadesContabilidad.ESacarInformacionCuentasMovimientos
                           {
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
                               IdOrigen=n.IdOrigen,
                               OrigenCuenta=n.OrigenCuenta,
                               ConceptoCuenta=n.ConceptoCuenta,
                               NumeroRelacionado=n.NumeroRelacionado,
                               IdClaseCuenta=n.IdClaseCuenta,
                               ClaseCuenta=n.ClaseCuenta,
                               IdCuentaContable=n.IdCuentaContable,
                               CuentaDescargo=n.CuentaDescargo
                           }).ToList();
            return Listado;
        }
        #endregion
        #region SACAR DATOS REPORTE FINANCIEROS
        public List<DSMarket.Logica.Entidades.EntidadesContabilidad.ESacarDatosReporteFinanciero> SacarDatosRepirteFinancero(string Ano = null, string Mes = null, int? TipoReporte = null) {
            ObjData.CommandTimeout = 999999999;

            var Listado = (from n in ObjData.SP_SACAR_DATOS_REPORTES_FINANCIEROS(Ano, Mes, TipoReporte)
                           select new DSMarket.Logica.Entidades.EntidadesContabilidad.ESacarDatosReporteFinanciero
                           {
                               CuentaAuxiliar=n.CuentaAuxiliar,
                               ConceptoCuenta=n.ConceptoCuenta,
                               Valor=n.Valor,
                               Cuenta=n.Cuenta,
                               CuentaDescargo=n.CuentaDescargo
                           }).ToList();
            return Listado;
        }
        #endregion
    }
}
