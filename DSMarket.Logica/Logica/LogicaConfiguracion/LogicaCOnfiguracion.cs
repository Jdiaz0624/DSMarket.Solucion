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
        #region MANTENIMIENTO DE INFORACION DE EMPRESA
        //LISTADO DE INFORMACION DE EMPRESA
        public List<DSMarket.Logica.Entidades.EntidadesConfiguracion.EInformacionEmpresa> BuscaInformacionEmpresa()
        {
            ObjData.CommandTimeout = 999999999;

            var Informacion = (from n in ObjData.SP_SACAR_INFORMACION_EMPRESA()
                               select new DSMarket.Logica.Entidades.EntidadesConfiguracion.EInformacionEmpresa
                               {
                                   IdInformacionEmpresa = n.IdInformacionEmpresa,
                                   NombreEmpresa = n.NombreEmpresa,
                                   RNC = n.RNC,
                                   Direccion = n.Direccion,
                                   Email = n.Email,
                                   Email2 = n.Email2,
                                   Facebook = n.Facebook,
                                   Instagran = n.Instagran,
                                   Telefonos = n.Telefonos,
                                   IdLogoEmpresa = n.IdLogoEmpresa,
                                   LogoEmpresa=n.LogoEmpresa
                               }).ToList();
            return Informacion;
        }

        //MANTENIMIENTO INFORMACION EMPRESA
        public DSMarket.Logica.Entidades.EntidadesConfiguracion.EInformacionEmpresa ModificarInformacionEmpresa(DSMarket.Logica.Entidades.EntidadesConfiguracion.EInformacionEmpresa Item, string Accion)
        {
            ObjData.CommandTimeout = 999999999;

            DSMarket.Logica.Entidades.EntidadesConfiguracion.EInformacionEmpresa Modificar = null;

            var InformacionEmpresa = ObjData.SP_MODIFICAR_INFORMACION_EMPRESA(
                Item.IdInformacionEmpresa,
                Item.NombreEmpresa,
                Item.RNC,
                Item.Direccion,
                Item.Email,
                Item.Email2,
                Item.Facebook,
                Item.Instagran,
                Item.Telefonos,
                Item.IdLogoEmpresa,
                Accion);
            if (InformacionEmpresa != null)
            {
                Modificar = (from n in InformacionEmpresa
                             select new DSMarket.Logica.Entidades.EntidadesConfiguracion.EInformacionEmpresa
                             {
                                 IdInformacionEmpresa=n.IdInformacionEmpresa,
                                 NombreEmpresa=n.NombreEmpresa,
                                 RNC=n.RNC,
                                 Direccion=n.Direccion,
                                 Email=n.Email,
                                 Email2=n.Email2,
                                 Facebook=n.Facebook,
                                 Instagran=n.Instagran,
                                 Telefonos=n.Telefonos,
                                 IdLogoEmpresa=n.IdLogoEmpresa
                             }).FirstOrDefault();
            }
            return Modificar;
        }
        #endregion
    }
}
