using System;
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
        #endregion
    }
}
