using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Logica.LogicaSeguridad
{
    public class LogicaSeguridad
    {
        DSMarket.Data.Conexion.ConexionLINQ.BDConexionSeguridadDataContext ObjData = new Data.Conexion.ConexionLINQ.BDConexionSeguridadDataContext(System.Configuration.ConfigurationManager.ConnectionStrings["DSMarketConexion"].ConnectionString);

        #region MANTENIMIENTO DE USUARIOS
        //BUSCA LISTADO DE USUARIOS
        public List<DSMarket.Logica.Entidades.EntidadesSeguridad.EUsuarios> BuscaUsuarios(decimal? IdUsuario = null, string UsuarioLogin = null, string Clave = null, string Usuario = null, string Persona = null, int? NumeroPagina = null, int? NumeroRegistros = null)
        {
            ObjData.CommandTimeout = 999999999;

            var BuscarUsuario = (from n in ObjData.SP_BUSCA_USUARIOS(IdUsuario, UsuarioLogin, Clave, Usuario, Persona, NumeroPagina, NumeroRegistros)
                                 select new DSMarket.Logica.Entidades.EntidadesSeguridad.EUsuarios
                                 {
                                     IdUsuario=n.IdUsuario,
                                     IdNivelAcceso=n.IdNivelAcceso,
                                     Nivel=n.Nivel,
                                     Usuario=n.Usuario,
                                     Clave=n.Clave,
                                     Persona=n.Persona,
                                     Estatus0=n.Estatus0,
                                     Estatus=n.Estatus,
                                     CambiaClave0=n.CambiaClave0,
                                     CambiaClave=n.CambiaClave,
                                     UsuarioAdicona=n.UsuarioAdicona,
                                     FechaAdiciona0=n.FechaAdiciona0,
                                     UsuarioModifica=n.UsuarioModifica,
                                     FechaModifica0=n.FechaModifica0,
                                     CreadoPor=n.CreadoPor,
                                     FechaCreado=n.FechaCreado,
                                     ModificadoPor=n.ModificadoPor,
                                     FechaModificado=n.FechaModificado
                                 }).ToList();
            return BuscarUsuario;
        }
        #endregion
        #region MANTENIMIENTO DE CLAVE DE SEGURIDAD
        public List<DSMarket.Logica.Entidades.EntidadesSeguridad.EClaveSeguridad> BuscaClaveSeguridad(decimal? IdClaveSeguridad = null, decimal? IdUsuario = null, string Clave = null, int? NumeroPagina = null, int? Numeroregistros = null)
        {
            ObjData.CommandTimeout = 999999999;

            var Buscar = (from n in ObjData.SP_BUSCA_CLAVE_SEGURIDAD(IdClaveSeguridad, IdUsuario, Clave, NumeroPagina, Numeroregistros)
                          select new DSMarket.Logica.Entidades.EntidadesSeguridad.EClaveSeguridad
                          {
                              IdClaveSeguridad=n.IdClaveSeguridad,
                              IdUsuario=n.IdUsuario,
                              Clave=n.Clave,
                              Estatus0=n.Estatus0,
                              Estatus=n.Estatus
                          }).ToList();
            return Buscar;
        }
        #endregion
        #region MANTENIMIENTO DE CREDENCIALES DE BASE DE DATOS
        //LISTADO DE CREDENCIALES DE BASES DE DATOS
        public List<DSMarket.Logica.Entidades.EntidadesSeguridad.ECredenciales> SacarCredencialBD(int? IdCredencial = null) {
            ObjData.CommandTimeout = 999999999;

            var Listado = (from n in ObjData.SP_SACAR_CREDENCIALES_BD(IdCredencial)
                           select new DSMarket.Logica.Entidades.EntidadesSeguridad.ECredenciales
                           {
                               IdCredencial=n.IdCredencial,
                               Usuario=n.Usuario,
                               Clave=n.Clave
                           }).ToList();
            return Listado;
        }

        //MANTENIMIENTO DE CREDENCIALES DE BASE DE DATOS
        public DSMarket.Logica.Entidades.EntidadesSeguridad.ECredenciales ModificarCredencial(DSMarket.Logica.Entidades.EntidadesSeguridad.ECredenciales Item, string Accion) {
            ObjData.CommandTimeout = 999999999;

            DSMarket.Logica.Entidades.EntidadesSeguridad.ECredenciales Modificar = null;

            var Credenciales = ObjData.SP_MODIFICAR_CREDENCIAL_BD(
                Item.IdCredencial,
                Item.Usuario,
                Item.Clave,
                Accion);
            if (Credenciales != null) {
                Modificar = (from n in Credenciales
                             select new DSMarket.Logica.Entidades.EntidadesSeguridad.ECredenciales
                             {
                                 IdCredencial=n.IdCredencial,
                                 Usuario=n.Usuario,
                                 Clave=n.Clave
                             }).FirstOrDefault();
            }
            return Modificar;
        }
        #endregion
    }
}
