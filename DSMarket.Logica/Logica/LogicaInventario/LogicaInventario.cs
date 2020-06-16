using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Logica.LogicaInventario
{
    public class LogicaInventario
    {
        DSMarket.Data.Conexion.ConexionLINQ.BDConexionInventarioDataContext Objdata = new Data.Conexion.ConexionLINQ.BDConexionInventarioDataContext(System.Configuration.ConfigurationManager.ConnectionStrings["DSMarketConexion"].ConnectionString);

        #region MANTENIMIENTO DE TIPO DE PRODUCTO
        //LISTADO DE TIPO DE PRODUCTO
        public List<DSMarket.Logica.Entidades.EntidadesInventario.ETipoProducto> BuscaTipoProducto(decimal? IdTipoProducto = null, string Descripcion = null, int? NumeroPagina = null, int? NumeroRegistros = null)
        {
            Objdata.CommandTimeout = 999999999;

            var Buscar = (from n in Objdata.SP_BUSCA_TIPO_PRODUCTOS(IdTipoProducto, Descripcion, NumeroPagina, NumeroRegistros)
                          select new DSMarket.Logica.Entidades.EntidadesInventario.ETipoProducto
                          {
                             IdTipoproducto=n.IdTipoproducto,
                             Tipoproducto=n.Tipoproducto,
                             Estatus0=n.Estatus0,
                             Estatus=n.Estatus,
                             Acumulativo0=n.Acumulativo0,
                             Acumulativo=n.Acumulativo,
                             UsuarioAdiciona=n.UsuarioAdiciona,
                             CreadoPor=n.CreadoPor,
                             Fechaadiciona=n.Fechaadiciona,
                             FechaCreado=n.FechaCreado,
                             UsuarioModifica=n.UsuarioModifica,
                             ModificadoPor=n.ModificadoPor,
                             FechaModifica=n.FechaModifica,
                             FechaModificado=n.FechaModificado,
                             CantidadRegistros=n.CantidadRegistros   
                          }).ToList();
            return Buscar;
        }

        //MANTENIMIENTO DE TIPO DE PRODUCTO
        public DSMarket.Logica.Entidades.EntidadesInventario.ETipoProducto MantenimeintoTipoProducto(DSMarket.Logica.Entidades.EntidadesInventario.ETipoProducto Item, string Accion)
        {
            Objdata.CommandTimeout = 999999999;

            DSMarket.Logica.Entidades.EntidadesInventario.ETipoProducto Mantenimeinto = null;

            var TipoProducto = Objdata.SP_MANTENIMIENTO_TIPO_PRODUCTO(
                Item.IdTipoproducto,
                Item.Tipoproducto,
                Item.Estatus0,
                Item.Acumulativo0,
                Item.UsuarioAdiciona,
                Accion);
            if (TipoProducto != null)
            {
                Mantenimeinto = (from n in TipoProducto
                                 select new DSMarket.Logica.Entidades.EntidadesInventario.ETipoProducto
                                 {
                                     IdTipoproducto=n.IdTipoproducto,
                                     Tipoproducto=n.Descripcion,
                                     Estatus0=n.Estatus,
                                     Acumulativo0=n.Acumulativo,
                                     UsuarioAdiciona=n.UsuarioAdiciona,
                                     Fechaadiciona=n.Fechaadiciona,
                                     UsuarioModifica=n.UsuarioModifica,
                                     FechaModifica=n.FechaModifica
                                 }).FirstOrDefault();
            }
            return Mantenimeinto;
        }
        #endregion

        #region MANTENIMIENTO DE CATEGORIAS
        //LISTADO DE CATEGORIAS
        public List<DSMarket.Logica.Entidades.EntidadesInventario.ECategorias> Buscacategoria(decimal? Idcategoria = null,decimal? IdTipoProducto = null, string Descripcion = null, int? NumeroPagina = null, int? Numeroregistros = null)
        {
            Objdata.CommandTimeout = 999999999;

            var Buscar = (from n in Objdata.SP_BUSCA_CATEGORIAS(Idcategoria,IdTipoProducto, Descripcion, NumeroPagina, Numeroregistros)
                          select new DSMarket.Logica.Entidades.EntidadesInventario.ECategorias
                          {
                              IdCategoria=n.IdCategoria,
                              IdTipoProducto=n.IdTipoProducto,
                              TipoProducto=n.TipoProducto,
                              Categoria=n.Categoria,
                              Estatus0=n.Estatus0,
                              Estatus=n.Estatus,
                              UsuarioAdiciona=n.UsuarioAdiciona,
                              CreadoPor=n.CreadoPor,
                              Fechaadiciona=n.Fechaadiciona,
                              FechaCreado=n.FechaCreado,
                              UsuarioModifica=n.UsuarioModifica,
                              FechaModificado=n.FechaModificado,
                              FechaModifica=n.FechaModifica,
                              ModificadoPor=n.ModificadoPor,
                              CantidadRegistros=n.CantidadRegistros
                          }).ToList();
            return Buscar;
        }

        //MANTENIMIENTO DE CATEGORIAS
        public DSMarket.Logica.Entidades.EntidadesInventario.ECategorias MantenimientoCategorias(DSMarket.Logica.Entidades.EntidadesInventario.ECategorias Item, string Accion)
        {
            Objdata.CommandTimeout = 999999999;

            DSMarket.Logica.Entidades.EntidadesInventario.ECategorias Mantenimiento = null;

            var Categoria = Objdata.SP_MANTENIMIENTO_CATEGORIAS(
                Item.IdCategoria,
                Item.IdTipoProducto,
                Item.Categoria,
                Item.Estatus0,
                Item.UsuarioAdiciona,
                Accion);
            if (Categoria != null)
            {
                Mantenimiento = (from n in Categoria
                                 select new DSMarket.Logica.Entidades.EntidadesInventario.ECategorias
                                 {
                                     IdCategoria=n.IdCategoria,
                                     IdTipoProducto=n.IdTipoProducto,
                                     Categoria=n.Descripcion,
                                     Estatus0=n.Estatus,
                                     UsuarioAdiciona=n.UsuarioAdiciona,
                                     Fechaadiciona=n.Fechaadiciona,
                                     UsuarioModifica=n.UsuarioModifica,
                                     FechaModifica = n.FechaModifica
                                 }).FirstOrDefault();
            }
            return Mantenimiento;
        }
        #endregion

        #region MANTENIMIENTO DE MARCAS
        //LISTADO DE MARCAS
        public List<DSMarket.Logica.Entidades.EntidadesInventario.Emarcas> Buscamarcas(decimal? IdMarca = null, string Descripcion = null, int? NumeroPagina = null, int? Numeroregistros = null)
        {
            Objdata.CommandTimeout = 999999999;

            var Buscar = (from n in Objdata.SP_BUSCA_MARCAS(IdMarca, Descripcion, NumeroPagina, Numeroregistros)
                          select new DSMarket.Logica.Entidades.EntidadesInventario.Emarcas
                          {
                              IdMarca=n.IdMarca,
                              Marca=n.Marca,
                              Estatus0=n.Estatus0,
                              Estatus=n.Estatus,
                              UsuarioAdiciona=n.UsuarioAdiciona,
                              CreadoPor=n.CreadoPor,
                              FechaAdiciona=n.FechaAdiciona,
                              FechaCreado=n.FechaCreado,
                              UsuarioModifica=n.UsuarioModifica,
                              ModificadoPor=n.ModificadoPor,
                              FechaModifica=n.FechaModifica,
                              FechaModificado=n.FechaModificado
                          }).ToList();
            return Buscar;
        }

        //MANTENIMIENTO DE MARCAS
        public DSMarket.Logica.Entidades.EntidadesInventario.Emarcas MantenimientoMarcas(DSMarket.Logica.Entidades.EntidadesInventario.Emarcas Item, string Accion)
        {
            Objdata.CommandTimeout = 999999999;

            DSMarket.Logica.Entidades.EntidadesInventario.Emarcas Mantenimiento = null;

            var Marcas = Objdata.SP_MANTENIMIENTO_MARCAS(
                Item.IdMarca,
                Item.Marca,
                Item.Estatus0,
                Item.UsuarioAdiciona,
                Accion);
            if (Marcas != null)
            {
                Mantenimiento = (from n in Marcas
                                 select new DSMarket.Logica.Entidades.EntidadesInventario.Emarcas
                                 {
                                     IdMarca=n.IdMarca,
                                     Marca=n.Descripcion,
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
