﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Logica.LogicaEmpresa
{
    public class LogicaEmpresa
    {
        DSMarket.Data.Conexion.ConexionLINQ.BDConexionEmpresaDataContext ObjData = new Data.Conexion.ConexionLINQ.BDConexionEmpresaDataContext(System.Configuration.ConfigurationManager.ConnectionStrings["DSMarketConexion"].ConnectionString);

        #region MANTENIMIENTO DE CLIENTES3
        /// <summary>
        /// Este metodo es para buscar el listado de los clientes registrados en la base de datos.
        /// </summary>
        /// <param name="IdCliente"></param>
        /// <param name="IdComprobante"></param>
        /// <param name="Nombre"></param>
        /// <param name="RNC"></param>
        /// <param name="Estatus"></param>
        /// <param name="NumeroPagina"></param>
        /// <param name="NumeroRegistros"></param>
        /// <returns></returns>
        public List<DSMarket.Logica.Entidades.EntidadesEmpresa.EClientes> BuscaClientes(decimal? IdCliente = null, decimal? IdComprobante = null, string Nombre = null, string RNC = null, bool? Estatus = null, bool? EnvioEmail = null, int? NumeroPagina = null, int? NumeroRegistros = null)
        {
            ObjData.CommandTimeout = 999999999;

            var Listado = (from n in ObjData.SP_BUSCA_CLIENTES(IdCliente, IdComprobante, Nombre, RNC, Estatus, EnvioEmail, NumeroPagina, NumeroRegistros)
                           select new DSMarket.Logica.Entidades.EntidadesEmpresa.EClientes
                           {
                               IdCliente=n.IdCliente,
                               IdComprobante=n.IdComprobante,
                               Comprobante=n.Comprobante,
                               Nombre=n.Nombre,
                               Telefono=n.Telefono,
                               IdTipoIdentificacion=n.IdTipoIdentificacion,
                               TipoIdentificacion=n.TipoIdentificacion,
                               RNC=n.RNC,
                               Direccion=n.Direccion,
                               Email=n.Email,
                               Comentario=n.Comentario,
                               Estatus0=n.Estatus0,
                               Estatus=n.Estatus,
                               EnvioEmail0=n.EnvioEmail0,
                               EnvioEmail=n.EnvioEmail,
                               UsuarioAdiciona =n.UsuarioAdiciona,
                               CreadoPor=n.CreadoPor,
                               FechaAdiciona=n.FechaAdiciona,
                               FechaCreado=n.FechaCreado,
                               UsuarioModifica=n.UsuarioModifica,
                               ModificadoPor=n.ModificadoPor,
                               FechaModifica=n.FechaModifica,
                               FechaModificado=n.FechaModificado,
                               MontoCredito=n.MontoCredito,
                               CantidadClientes=n.CantidadClientes
                           }).ToList();
            return Listado;
        }

        public DSMarket.Logica.Entidades.EntidadesEmpresa.EClientes MantenimientoClientes(DSMarket.Logica.Entidades.EntidadesEmpresa.EClientes Item, string Accion) {
            ObjData.CommandTimeout = 999999999;

            DSMarket.Logica.Entidades.EntidadesEmpresa.EClientes Mantenimeinto = null;

            var Clientes = ObjData.SP_MANTENIMIENTO_CLIENTES(
                Item.IdCliente,
                Item.IdComprobante,
                Item.Nombre,
                Item.Telefono,
                Item.IdTipoIdentificacion,
                Item.RNC,
                Item.Direccion,
                Item.Email,
                Item.Comentario,
                Item.Estatus0,
                Item.UsuarioAdiciona,
                Item.MontoCredito,
                Item.EnvioEmail0,
                Accion);
            if (Clientes != null) {
                Mantenimeinto = (from n in Clientes
                                 select new DSMarket.Logica.Entidades.EntidadesEmpresa.EClientes
                                 {
                                     IdCliente=n.IdCliente,
                                     IdComprobante=n.IdComprobante,
                                     Nombre=n.Nombre,
                                     Telefono=n.Telefono,
                                     IdTipoIdentificacion=n.IdTipoIdentificacion,
                                     RNC=n.RNC,
                                     Direccion=n.Direccion,
                                     Email=n.Email,
                                     Comentario=n.Comentario,
                                     Estatus0=n.Estatus,
                                     UsuarioAdiciona=n.UsuarioAdiciona,
                                     FechaAdiciona=n.FechaAdiciona,
                                     UsuarioModifica=n.UsuarioModifica,
                                     FechaModifica=n.FechaModifica,
                                     MontoCredito=n.MontoCredito,
                                     EnvioEmail0=n.EnvioEmail
                                 }).FirstOrDefault();
            }
            return Mantenimeinto;
        }
        #endregion

        #region MANTENIMIENTO DE COMPRA DE SUPLIDORES
        //LISTADO DE COMPRA A SUPLIDORES
        public List<DSMarket.Logica.Entidades.EntidadesEmpresa.ECompraSuplidores> BuscaCompraSuplidores(decimal? IdCompraSuplidor = null, decimal? IdTipoSuplidor = null, decimal? IdSuplidor = null, string RNCCedula = null, DateTime? FechaCreadoDesde = null, DateTime? FechaCreadoHasta = null, int? NumeroPagina = null, int? NumeroRegistros = null) {
            ObjData.CommandTimeout = 999999999;

            var Listado = (from n in ObjData.SP_BUSCA_REGISTROS_COMPRA_SUPLIDORES(
                IdCompraSuplidor,
                IdTipoSuplidor,
                IdSuplidor,
                RNCCedula,
                FechaCreadoDesde,
                FechaCreadoHasta,
                NumeroPagina,
                NumeroRegistros)
                           select new DSMarket.Logica.Entidades.EntidadesEmpresa.ECompraSuplidores
                           {
                               IdCompraSuplidor=n.IdCompraSuplidor,
                               IdTipoSuplidor=n.IdTipoSuplidor,
                               TipoSuplidor=n.TipoSuplidor,
                               IdSuplidor=n.IdSuplidor,
                               Suplidor=n.Suplidor,
                               RNCCedula=n.RNCCedula,
                               IdTipoIdentificacion=n.IdTipoIdentificacion,
                               TipoIdentificacion=n.TipoIdentificacion,
                               IdTipoBienesServicios=n.IdTipoBienesServicios,
                               TipoBienesServicios=n.TipoBienesServicios,
                               CodigoTipoBienesServicio=n.CodigoTipoBienesServicio,
                               NCF =n.NCF,
                               NCFModificado=n.NCFModificado,
                               FechaComprobante0=n.FechaComprobante0,
                               FechaComprobante=n.FechaComprobante,
                               FechaPago0=n.FechaPago0,
                               FechaPago=n.FechaPago,
                               MontoFacturadoServicios=n.MontoFacturadoServicios,
                               MontoFacturadoBienes=n.MontoFacturadoBienes,
                               TotalMontoFacturado=n.TotalMontoFacturado,
                               ITBISFacturado=n.ITBISFacturado,
                               ITBISRetenido=n.ITBISRetenido,
                               ITBISSujetoProporcionalidad=n.ITBISSujetoProporcionalidad,
                               ITBISLlevadoCosto=n.ITBISLlevadoCosto,
                               ITBISPorAdelantar=n.ITBISPorAdelantar,
                               ITBISPercibidoCompras=n.ITBISPercibidoCompras,
                               IdTipoRetencionISR=n.IdTipoRetencionISR,
                               TipoRetencionISR=n.TipoRetencionISR,
                               CodigoTipoRetencionISR=n.CodigoTipoRetencionISR,
                               MontoRetencionRenta=n.MontoRetencionRenta,
                               ISRPercibidoCompras=n.ISRPercibidoCompras,
                               ImpuestoSelectivoConsumo=n.ImpuestoSelectivoConsumo,
                               OtrosImpuestosTasa=n.OtrosImpuestosTasa,
                               MontoPropinaLegal=n.MontoPropinaLegal,
                               IdFormaPago=n.IdFormaPago,
                               FormaPago=n.FormaPago,
                               CodigoTipoPago=n.CodigoTipoPago,
                               UsuarioAdiciona=n.UsuarioAdiciona,
                               CreadoPor=n.CreadoPor,
                               FechaCreado0=n.FechaCreado0,
                               FechaCreado=n.FechaCreado,
                               CantidadRegistros=n.CantidadRegistros
                           }).ToList();
            return Listado;
        }

        //MANTENIMIENTO DE COMPRA DE SUPLIDORES
        public DSMarket.Logica.Entidades.EntidadesEmpresa.ECompraSuplidores MantenimientoCompraSuplidores(DSMarket.Logica.Entidades.EntidadesEmpresa.ECompraSuplidores Item, string Accion) {
            ObjData.CommandTimeout = 999999999;

            DSMarket.Logica.Entidades.EntidadesEmpresa.ECompraSuplidores Mantenimiento = null;

            var CompraSuplidores = ObjData.SP_MANTENIMIENTO_COMPRAS_SUPLIDORES(
                Item.IdCompraSuplidor,
                Item.IdTipoSuplidor,
                Item.IdSuplidor,
                Item.RNCCedula,
                Item.IdTipoIdentificacion,
                Item.IdTipoBienesServicios,
                Item.NCF,
                Item.NCFModificado,
                Item.FechaComprobante0,
                Item.FechaPago0,
                Item.MontoFacturadoServicios,
                Item.MontoFacturadoBienes,
                Item.TotalMontoFacturado,
                Item.ITBISFacturado,
                Item.ITBISRetenido,
                Item.ITBISSujetoProporcionalidad,
                Item.ITBISLlevadoCosto,
                Item.ITBISPorAdelantar,
                Item.ITBISPercibidoCompras,
                Item.IdTipoRetencionISR,
                Item.MontoRetencionRenta,
                Item.ISRPercibidoCompras,
                Item.ImpuestoSelectivoConsumo,
                Item.OtrosImpuestosTasa,
                Item.MontoPropinaLegal,
                Item.IdFormaPago,
                Item.UsuarioAdiciona,
                Item.FechaCreado0,
                Accion);
            if (CompraSuplidores != null) {
                Mantenimiento = (from n in CompraSuplidores
                                 select new DSMarket.Logica.Entidades.EntidadesEmpresa.ECompraSuplidores
                                 {
                                     IdCompraSuplidor = n.IdCompraSuplidor,
                                     IdTipoSuplidor = n.IdTipoSuplidor,
                                     IdSuplidor = n.IdSuplidor,
                                     RNCCedula = n.RNCCedula,
                                     IdTipoIdentificacion = n.IdTipoIdentificacion,
                                     IdTipoBienesServicios = n.IdTipoBienesServicios,
                                     NCF = n.NCF,
                                     NCFModificado = n.NCFModificado,
                                     FechaComprobante0 = n.FechaComprobante,
                                     FechaPago0 = n.FechaPago,
                                     MontoFacturadoServicios = n.MontoFacturadoServicios,
                                     MontoFacturadoBienes = n.MontoFacturadoBienes,
                                     TotalMontoFacturado = n.TotalMontoFacturado,
                                     ITBISFacturado = n.ITBISFacturado,
                                     ITBISRetenido = n.ITBISRetenido,
                                     ITBISSujetoProporcionalidad = n.ITBISSujetoProporcionalidad,
                                     ITBISLlevadoCosto = n.ITBISLlevadoCosto,
                                     ITBISPorAdelantar = n.ITBISPorAdelantar,
                                     ITBISPercibidoCompras = n.ITBISPercibidoCompras,
                                     IdTipoRetencionISR = n.IdTipoRetencionISR,
                                     MontoRetencionRenta = n.MontoRetencionRenta,
                                     ISRPercibidoCompras = n.ISRPercibidoCompras,
                                     ImpuestoSelectivoConsumo = n.ImpuestoSelectivoConsumo,
                                     OtrosImpuestosTasa = n.OtrosImpuestosTasa,
                                     MontoPropinaLegal = n.MontoPropinaLegal,
                                     IdFormaPago = n.IdFormaPago,
                                     UsuarioAdiciona = n.UsuarioAdiciona,
                                     FechaCreado0 = n.FechaCreado
                                 }).FirstOrDefault();
            }
            return Mantenimiento;
        }
        #endregion

        #region MANTENIMIENTO DE DEPARTAMENTOS
        //listado de los departamentos
        public List<DSMarket.Logica.Entidades.EntidadesEmpresa.EDepartamentos> BuscaDepartamentos(decimal? IdDepartamento = null, string Descripcion = null, int? NumeroPagina = null, int? NumeroRegistros = null) {

            ObjData.CommandTimeout = 999999999;

            var Buscar = (from n in ObjData.SP_BUSCA_DEPARTAMENTOS(IdDepartamento, Descripcion, NumeroPagina, NumeroRegistros)
                          select new DSMarket.Logica.Entidades.EntidadesEmpresa.EDepartamentos
                          {
                              IdDepartamento=n.IdDepartamento,
                              Departamento=n.Departamento,
                              Estatus0=n.Estatus0,
                              Estatus=n.Estatus,
                              UsuarioAdiciona=n.UsuarioAdiciona,
                              CreadoPor=n.CreadoPor,
                              FechaAdiciona=n.FechaAdiciona,
                              FechaCreado=n.FechaCreado,
                              UsuarioModifica=n.UsuarioModifica,
                              ModificadoPor=n.ModificadoPor,
                              FechaModifica=n.FechaModifica,
                              FechaModificado=n.FechaModificado,
                              CantidadRegistros=n.CantidadRegistros
                             
                          }).ToList();
            return Buscar;
        }
        //MANTENIMIENTO DE DEPARTAMENTOS
        public DSMarket.Logica.Entidades.EntidadesEmpresa.EDepartamentos MantenimientoDepartamentos(DSMarket.Logica.Entidades.EntidadesEmpresa.EDepartamentos Item, string Accion) {
            ObjData.CommandTimeout = 999999999;

            DSMarket.Logica.Entidades.EntidadesEmpresa.EDepartamentos Mantenimiento = null;

            var Departamento = ObjData.SP_MANTENIMIENTO_DEPARTAMENTOS(
                Item.IdDepartamento,
                Item.Departamento,
                Item.Estatus0
                , Item.UsuarioAdiciona,
                Accion);

            if (Departamento != null) {
                Mantenimiento = (from n in Departamento
                                 select new DSMarket.Logica.Entidades.EntidadesEmpresa.EDepartamentos
                                 {
                                     IdDepartamento=n.IdDepartamento,
                                     Departamento=n.Descripcion,
                                     Estatus0=n.Estatus,
                                     UsuarioAdiciona=n.UsuarioAdiciona,
                                     FechaAdiciona=n.FechaAdiciona,
                                     UsuarioModifica=n.UsuarioModifica,
                                     FechaModifica=n.FechaModifica
                                 }).FirstOrDefault();
            }
            return Mantenimiento;
        }
        #endregion

        #region MANTENIMIENTO DE CARGOS
        //LISTADO DE LOS CARGOS
        public List<DSMarket.Logica.Entidades.EntidadesEmpresa.ECargos> BuscaCargos(decimal? IdCargo = null, decimal? IdDepartamento = null, string Descripcion = null, int? NumeroPagina = 1, int? NumeroRegistro = null) {
            ObjData.CommandTimeout = 999999999;

            var Listado = (from n in ObjData.SP_BUSCA_CARGOS(IdCargo, IdDepartamento, Descripcion, NumeroPagina, NumeroRegistro)
                           select new DSMarket.Logica.Entidades.EntidadesEmpresa.ECargos
                           {
                               IdCargo=n.IdCargo,
                               IdDepartamento=n.IdDepartamento,
                               Departamento=n.Departamento,
                               Cargo=n.Cargo,
                               Estatus0=n.Estatus0,
                               Estatus=n.Estatus,
                               UsuarioAdiciona=n.UsuarioAdiciona,
                               CreadoPor=n.CreadoPor,
                               FechaAdiciona=n.FechaAdiciona,
                               FechaCreado=n.FechaCreado,
                               UsuarioModifica=n.UsuarioModifica,
                               ModificadoPor=n.ModificadoPor,
                               FechaModifica=n.FechaModifica,
                               FechaModificado=n.FechaModificado,
                               CantidadRegistros=n.CantidadRegistros
                           }).ToList();
            return Listado;
        }

        //MANTENIMIENTO DE CARGOS
        public DSMarket.Logica.Entidades.EntidadesEmpresa.ECargos MantenimientoCargos(DSMarket.Logica.Entidades.EntidadesEmpresa.ECargos Item, string Accion) {
            ObjData.CommandTimeout = 999999999;

            DSMarket.Logica.Entidades.EntidadesEmpresa.ECargos Mantenimiento = null;

            var Cargos = ObjData.SP_MANTENIMIENTO_CARGOS(
                Item.IdCargo,
                Item.IdDepartamento,
                Item.Cargo,
                Item.Estatus0,
                Item.UsuarioAdiciona,
                Accion);
            if (Cargos != null) {
                Mantenimiento = (from n in Cargos
                                 select new DSMarket.Logica.Entidades.EntidadesEmpresa.ECargos
                                 {
                                     IdCargo=n.IdCargo,
                                     IdDepartamento=n.IdDepartamento,
                                     Cargo=n.Descripcion,
                                     Estatus0=n.Estatus,
                                     UsuarioAdiciona=n.UsuarioAdiciona,
                                     FechaAdiciona=n.FechaAdiciona,
                                     UsuarioModifica=n.UsuarioModifica,
                                     FechaModifica=n.FechaModifica
                                 }).FirstOrDefault();
            }
            return Mantenimiento;
        }
        #endregion

        #region MANTENIMIENTO DE TIPO DE EMPLEADOS
        //LISTADO DE TIPO DE EMPLEADOS
        public List<DSMarket.Logica.Entidades.EntidadesEmpresa.ETipoEmpleado> BuscaTipoEmpleado(decimal? IdTipoEmpleado = null, string Descripcion = null, int? NumeroPagina = null, int? NumeroRegistros = null) {
            ObjData.CommandTimeout = 999999999;

            var Listado = (from n in ObjData.SP_BUSCA_TIPO_EMPLEADO(IdTipoEmpleado, Descripcion, NumeroPagina, NumeroRegistros)
                           select new DSMarket.Logica.Entidades.EntidadesEmpresa.ETipoEmpleado
                           {
                               IdTipoEmpleado=n.IdTipoEmpleado,
                               TipoEmpleado=n.TipoEmpleado,
                               Estatus0=n.Estatus0,
                               Estatus=n.Estatus,
                               UsuarioAdiciona=n.UsuarioAdiciona,
                               CreadoPor=n.CreadoPor,
                               FechaAdiciona=n.FechaAdiciona,
                               FechaCreado=n.FechaCreado,
                               UsuarioModifica=n.UsuarioModifica,
                               ModificadoPor=n.ModificadoPor,
                               FechaModifica=n.FechaModifica,
                               FechaModificado=n.FechaModificado,
                              CantidadRegistros=n.CantidadRegistros
                           }).ToList();
            return Listado;
        }

        //MANTENIMIENTO DE TIPO DE EMPLEADOS
        public DSMarket.Logica.Entidades.EntidadesEmpresa.ETipoEmpleado MantenimientoTipoEmpleado(DSMarket.Logica.Entidades.EntidadesEmpresa.ETipoEmpleado Item, string Accion){
            ObjData.CommandTimeout = 999999999;

            DSMarket.Logica.Entidades.EntidadesEmpresa.ETipoEmpleado Mantenimiento = null;

            var TipoEmpleado = ObjData.SP_MANTENIMIENTO_TIPO_EMPLEADO(
                Item.IdTipoEmpleado,
                Item.TipoEmpleado,
                Item.Estatus0,
                Item.UsuarioAdiciona,
                Accion);
            if (TipoEmpleado != null) {
                Mantenimiento = (from n in TipoEmpleado
                                 select new DSMarket.Logica.Entidades.EntidadesEmpresa.ETipoEmpleado
                                 {
                                     IdTipoEmpleado=n.IdTipoEmpleado,
                                     TipoEmpleado=n.Descripcion,
                                     Estatus0=n.Estatus,
                                     UsuarioAdiciona=n.UsuarioAdiciona,
                                     FechaAdiciona=n.FechaAdiciona,
                                     UsuarioModifica=n.UsuarioModifica,
                                     FechaModifica=n.FechaModifica
                                 }).FirstOrDefault();
            }
            return Mantenimiento;
        }
        #endregion

        #region MANTENIMIENTO DE TIPO DE NOMINA
        //LISTADO DE MANTENIMIENTO DE TIPO NOMINA
        public List<DSMarket.Logica.Entidades.EntidadesEmpresa.ETipoNomina> BuscaTipoNomina(decimal? IdTipoNomina = null, string Descripcion = null, int? NumeroPagina = null, int? NumeroRegistro = null) {
            ObjData.CommandTimeout = 999999999;

            var Buscar = (from n in ObjData.SP_BUSCA_TIPO_NOMINA(IdTipoNomina, Descripcion, NumeroPagina, NumeroRegistro)
                          select new DSMarket.Logica.Entidades.EntidadesEmpresa.ETipoNomina
                          {
                              IdTipoNomina=n.IdTipoNomina,
                              TipoNomina=n.TipoNomina,
                              Estatus0=n.Estatus0,
                              Estatus=n.Estatus,
                              UsuarioAdiciona=n.UsuarioAdiciona,
                              CreadoPor=n.CreadoPor,
                              FechaAdiciona=n.FechaAdiciona,
                              FechaCreado=n.FechaCreado,
                              UsuairoModifica=n.UsuairoModifica,
                              ModificadoPor=n.ModificadoPor,
                              FechaModifica=n.FechaModifica,
                              FechaModificado=n.FechaModificado,
                              CantidadRegistros=n.CantidadRegistros
                          }).ToList();
            return Buscar;
        }

        public DSMarket.Logica.Entidades.EntidadesEmpresa.ETipoNomina MantenimientoTipoNomina(DSMarket.Logica.Entidades.EntidadesEmpresa.ETipoNomina Item, string Accion) {
            ObjData.CommandTimeout = 999999999;

            DSMarket.Logica.Entidades.EntidadesEmpresa.ETipoNomina Mantenimiento = null;

            var TipoNomina = ObjData.SP_MANTENIMIENTO_TIPO_NOMINA(
                Item.IdTipoNomina,
                Item.TipoNomina,
                Item.Estatus0,
                (int)Item.UsuarioAdiciona,
                Accion);
            if (TipoNomina != null) {
                Mantenimiento = (from n in TipoNomina
                                 select new DSMarket.Logica.Entidades.EntidadesEmpresa.ETipoNomina
                                 {
                                     IdTipoNomina=n.IdTipoNomina,
                                     TipoNomina=n.Descripcion,
                                     Estatus0=n.Estatus,
                                     UsuarioAdiciona=n.UsuarioAdiciona,
                                     FechaAdiciona=n.FechaAdiciona,
                                     UsuairoModifica=n.UsuairoModifica,
                                     FechaModifica=n.FechaModifica
                                 }).FirstOrDefault();
            }
            return Mantenimiento;


        }
        #endregion

        #region MANTENIMIENTO DE BANCO
        //LISTAD DE BANCOS
        public List<DSMarket.Logica.Entidades.EntidadesEmpresa.EBancos> ListadoBancos(decimal? IdBancos = null, string NombreBanco = null, int? NumeroPagina = null, int? NumeroRegistros = null) 
        {
            ObjData.CommandTimeout = 999999999;

            var Listado = (from n in ObjData.SP_BUSCA_LISTADO_BANCOS(IdBancos, NombreBanco, NumeroPagina, NumeroRegistros)
                           select new DSMarket.Logica.Entidades.EntidadesEmpresa.EBancos
                           {
                               IdBanco=n.IdBanco,
                               CuentaContable=n.CuentaContable,
                               Auxiliar=n.Auxiliar,
                               Banco=n.Banco,
                               Estatus0=n.Estatus0,
                               Estatus=n.Estatus,
                               UsuarioAdiciona=n.UsuarioAdiciona,
                               CreadoPor=n.CreadoPor,
                               FechaAdiciona=n.FechaAdiciona,
                               FechaCreado=n.FechaCreado,
                               UsuarioModifica=n.UsuarioModifica,
                               ModificadoPor=n.ModificadoPor,
                               FechaModifica=n.FechaModifica,
                               FechaModificado=n.FechaModificado,
                               CantidadRegistros=n.CantidadRegistros
                           }).ToList();
            return Listado;
        }

        //MANTENIMIENTO DE BANCOS
        public DSMarket.Logica.Entidades.EntidadesEmpresa.EBancos MantenimientoBancos(DSMarket.Logica.Entidades.EntidadesEmpresa.EBancos Item, string Accion) {
            ObjData.CommandTimeout = 999999999;

            DSMarket.Logica.Entidades.EntidadesEmpresa.EBancos Mantenimiento = null;


            var BAncos = ObjData.SP_MANTENIMIENTO_DE_BANCOS(
                Item.IdBanco,
                Item.CuentaContable,
                Item.Auxiliar,
                Item.Banco,
                Item.Estatus0,
                Item.UsuarioAdiciona,
                Accion);
            if (BAncos != null) {
                Mantenimiento = (from n in BAncos
                                 select new DSMarket.Logica.Entidades.EntidadesEmpresa.EBancos
                                 {
                                     IdBanco=n.IdBanco,
                                     CuentaContable=n.CuentaContable,
                                     Auxiliar=n.Auxiliar,
                                     Banco=n.Nombre,
                                     Estatus0=n.Estatus,
                                     UsuarioAdiciona=n.UsuarioAdiciona,
                                     FechaAdiciona=n.FechaAdiciona,
                                     UsuarioModifica=n.UsuarioModifica,
                                     FechaModifica=n.FechaModifica
                                 }).FirstOrDefault();
            }
            return Mantenimiento;
        }
        #endregion

        #region MANTENIMIENTO DE TIPO DE MOVIMIENTO
        //LISTADO DE TIPO DE MOVIMIENTO
        public List<DSMarket.Logica.Entidades.EntidadesEmpresa.ETipoMovimiento> ListadoTipoMovimiento(decimal? IdTipoMovimiento = null, string Descripcion = null, int? NumeroPagina = null, int? NumeroRegistros = null) {
            ObjData.CommandTimeout = 999999999;

            var Listado = (from n in ObjData.SP_BUSCA_TIPO_MOVIMIENTO(IdTipoMovimiento, Descripcion, NumeroPagina, NumeroRegistros)
                           select new DSMarket.Logica.Entidades.EntidadesEmpresa.ETipoMovimiento
                           {
                               IdTipoMovimiento=n.IdTipoMovimiento,
                               TipoMovimiento=n.TipoMovimiento,
                               Estatus0=n.Estatus0,
                               Estatus=n.Estatus,
                               UsuarioAdiciona=n.UsuarioAdiciona,
                               CreadoPor=n.CreadoPor,
                               FechaAdiciona=n.FechaAdiciona,
                               FechaCreado=n.FechaCreado,
                               UsuarioModifica=n.UsuarioModifica,
                               ModificadoPor=n.ModificadoPor,
                               FechaModifica=n.FechaModifica,
                               FechaModificado=n.FechaModificado,
                               CantidadRegistros=n.CantidadRegistros
                           }).ToList();
            return Listado;
        }
        //MANTENIMIENTO DE TIPO DE MOVIMIENTO
        public DSMarket.Logica.Entidades.EntidadesEmpresa.ETipoMovimiento MantenimientoTipoMovimiento(DSMarket.Logica.Entidades.EntidadesEmpresa.ETipoMovimiento Item, string Accion) {
            ObjData.CommandTimeout = 999999999;

            DSMarket.Logica.Entidades.EntidadesEmpresa.ETipoMovimiento Mantenimiento = null;

            var TipoMovimiento = ObjData.SP_MANTENIMIENTO_TIPO_MOVIMIENTO(
                Item.IdTipoMovimiento,
                Item.TipoMovimiento,
                Item.Estatus0,
                Item.UsuarioAdiciona,
                Accion);
            if (TipoMovimiento != null) {
                Mantenimiento = (from n in TipoMovimiento
                                 select new DSMarket.Logica.Entidades.EntidadesEmpresa.ETipoMovimiento
                                 {
                                     IdTipoMovimiento=n.IdTipoMovimiento,
                                     TipoMovimiento=n.Descripcion,
                                     Estatus0=n.Estatus,
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
