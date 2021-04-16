﻿using DSMarket.Logica.Entidades.EntidadesListas;
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
        public List<DSMarket.Logica.Entidades.EntidadesInventario.Emarcas> Buscamarcas(decimal? IdMarca = null,decimal? IdTipoProducto = null, decimal? IdCategoria = null, string Descripcion = null, int? NumeroPagina = null, int? Numeroregistros = null)
        {
            Objdata.CommandTimeout = 999999999;

            var Buscar = (from n in Objdata.SP_BUSCA_MARCAS(IdMarca, IdTipoProducto, IdCategoria, Descripcion, NumeroPagina, Numeroregistros)
                          select new DSMarket.Logica.Entidades.EntidadesInventario.Emarcas
                          {
                              IdMarca=n.IdMarca,
                              IdTipoProducto=n.IdTipoProducto,
                              TipoProducto=n.TipoProducto,
                              Marca=n.Marca,
                              IdCateoria=n.IdCateoria,
                              Categoria=n.Categoria,
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
                Item.IdCateoria,
                Item.IdTipoProducto,
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
                                     FechaModifica=n.FechaModifica,
                                     IdCateoria=n.IdCategoria,
                                     IdTipoProducto=n.IdTipoProducto
                                 }).FirstOrDefault();
            }
            return Mantenimiento;
        }
        #endregion
        #region MANTENIMIENTO DE TIPO DE SUPLIDORES
        //LISTADO DE TIPO DE SUPLIDORES
        public List<DSMarket.Logica.Entidades.EntidadesInventario.ETipoSuplidores> BuscaTipoSupidores(decimal? IdTipoSuplidor = null, string Descripcion = null, int? NumeroPagina = null, int? NumeroRegistros = null)
        {
            Objdata.CommandTimeout = 999999999;

            var Buscar = (from n in Objdata.SP_BUSCA_TIPO_SUPLIDORES(IdTipoSuplidor, Descripcion, NumeroPagina, NumeroRegistros)
                          select new DSMarket.Logica.Entidades.EntidadesInventario.ETipoSuplidores
                          {
                              IdTipoSuplidor=n.IdTipoSuplidor,
                              TipoSuplidor=n.TipoSuplidor,
                              Estatus0=n.Estatus0,
                              Estatus=n.Estatus,
                              UsuarioAdiciona=n.UsuarioAdiciona,
                              CreadoPor=n.CreadoPor,
                              FechaAdiciona=n.FechaAdiciona,
                              FechaCreado=n.FechaCreado,
                              UsuarioModifica=n.UsuarioModifica,
                              ModificadoPor=n.ModificadoPor,
                              FechaModificado=n.FechaModificado,
                              FechaModifica=n.FechaModifica,
                              CantidadRegistros=n.CantidadRegistros
                          }).ToList();
            return Buscar;
        }

        //MANTENIMIENTO DE TIPO DE SUPLIDORES
        public DSMarket.Logica.Entidades.EntidadesInventario.ETipoSuplidores MantenimientoTipoSuplidores(DSMarket.Logica.Entidades.EntidadesInventario.ETipoSuplidores Item, string Accion)
        {
            Objdata.CommandTimeout = 999999999;

            DSMarket.Logica.Entidades.EntidadesInventario.ETipoSuplidores Mantenimiento = null;

            var TipoSuplidor = Objdata.SP_MANTENIMIENTO_TIPO_SUPLIDOR(
                Item.IdTipoSuplidor,
                Item.TipoSuplidor,
                Item.Estatus0,
                Item.UsuarioAdiciona,
                Accion);
            if (TipoSuplidor != null)
            {
                Mantenimiento = (from n in TipoSuplidor
                                 select new DSMarket.Logica.Entidades.EntidadesInventario.ETipoSuplidores
                                 {
                                     IdTipoSuplidor=n.IdTipoSuplidor,
                                     TipoSuplidor=n.Descripcion,
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
        #region MANTENIMIENTO DE SUPLIDORES
        //LISTADO DE SUPLIDORES
        public List<DSMarket.Logica.Entidades.EntidadesInventario.ESuplidores> BuscaSupervisores(decimal? IdTipoSuplidor = null, decimal? IdSuplidor = null, string Suplidor = null, int? NumeroPagina = null, int? NumeroRegistros = 10)
        {
            Objdata.CommandTimeout = 999999999;

            var Listado = (from n in Objdata.SP_BUSCA_SUPLIDORES(IdTipoSuplidor, IdSuplidor, Suplidor, NumeroPagina, NumeroRegistros)
                           select new DSMarket.Logica.Entidades.EntidadesInventario.ESuplidores
                           {
                               IdTipoSuplidor=n.IdTipoSuplidor,
                               TipoSuplidor=n.TipoSuplidor,
                               IdSuplidor=n.IdSuplidor,
                               Suplidor=n.Suplidor,
                               Telefono=n.Telefono,
                               Email=n.Email,
                               Direccion=n.Direccion,
                               Contacto=n.Contacto,
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
        //MANTENIMIENTO DE SUPLIDORES
        public DSMarket.Logica.Entidades.EntidadesInventario.ESuplidores MantenimientoSuplidores(DSMarket.Logica.Entidades.EntidadesInventario.ESuplidores Item, string Accion)
        {
            Objdata.CommandTimeout = 999999999;

            DSMarket.Logica.Entidades.EntidadesInventario.ESuplidores Mantenimiento = null;

            var Suplidor = Objdata.SP_MANTENIMIENTO_SUPLIDORES(
                Item.IdTipoSuplidor,
                Item.IdSuplidor,
                Item.Suplidor,
                Item.Telefono,
                Item.Email,
                Item.Direccion,
                Item.Contacto,
                Item.Estatus0,
                Item.UsuarioAdiciona,
                Accion);
            if (Suplidor != null)
            {
                Mantenimiento = (from n in Suplidor
                                 select new DSMarket.Logica.Entidades.EntidadesInventario.ESuplidores
                                 {
                                     IdTipoSuplidor=n.IdTipoSuplidor,
                                     IdSuplidor=n.IdSuplidor,
                                     Suplidor=n.Nombre,
                                     Telefono=n.Telefono,
                                     Email=n.Email,
                                     Direccion=n.Direccion,
                                     Contacto=n.Contacto,
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
        #region MANTENIMIENTO DE PRODUCTO
        //LISTADO DE PRODUCTOS
        public List<DSMarket.Logica.Entidades.EntidadesInventario.EProducto> BuscaProductos(decimal? IdProducto = null, decimal? NumeroConector = null, string Descripcion = null, string CodigoBarra = null, string Referencia = null, DateTime? FechaDesde = null, DateTime? FechaHasta = null, decimal? IdTipoProducto = null, decimal? IdCategoria = null, decimal? IdUnidadMedida = null, decimal? IdMarca = null, decimal? IdModelo = null, decimal? IdColor = null, decimal? IdCondicion = null, decimal? IdCapacidad = null, bool? TieneOferta = null, bool? EstatusProducto = null,string NumeroSeguimiento = null, int? NumeroPagina = null, int? NumeroRegistros = null)
        {
            Objdata.CommandTimeout = 999999999;

            var Buscar = (from n in Objdata.SP_BUSCA_PRODUCTO(IdProducto, NumeroConector, Descripcion, CodigoBarra, Referencia, FechaDesde, FechaHasta, IdTipoProducto, IdCategoria, IdUnidadMedida, IdMarca, IdModelo, IdColor, IdCondicion, IdCapacidad, TieneOferta, EstatusProducto, NumeroSeguimiento, NumeroPagina, NumeroRegistros)
                          select new DSMarket.Logica.Entidades.EntidadesInventario.EProducto
                          {
                              IdProducto=n.IdProducto,
                              IdMarca = n.IdMarca,
                              Marca = n.Marca,
                              IdModelo = n.IdModelo,
                              Modelo = n.Modelo,
                              IdColor=n.IdColor,
                              Color=n.Color,
                              IdCondicion=n.IdCondicion,
                              Condicion=n.Condicion,
                              IdCapacidad=n.IdCapacidad,
                              Capacidad=n.Capacidad,
                              NumeroConector =n.NumeroConector,
                              IdTipoProducto=n.IdTipoProducto,
                              Producto=n.Producto,
                              Referencia = n.Referencia,
                              TipoProducto =n.TipoProducto,
                              IdCategoria =n.IdCategoria,
                              Categoria=n.Categoria,
                              IdUnidadMedida=n.IdUnidadMedida,
                              UnidadMedida=n.UnidadMedida,
                              IdTipoSuplidor=n.IdTipoSuplidor,
                              TipoSuplidor=n.TipoSuplidor,
                              IdSuplidor=n.IdSuplidor,
                              Suplidor=n.Suplidor,
                              CodigoBarra=n.CodigoBarra,
                              PrecioCompra=n.PrecioCompra,
                              PrecioVenta=n.PrecioVenta,
                              Stock=n.Stock,
                              StockMinimo=n.StockMinimo,
                              PorcientoDescuento=n.PorcientoDescuento,
                              AfectaOferta0=n.AfectaOferta0,
                              AceptaOferta=n.AceptaOferta,
                              ProductoAcumulativo0=n.ProductoAcumulativo0,
                              ProductoAcumulativo=n.ProductoAcumulativo,
                              LlevaImagen0=n.LlevaImagen0,
                              LlevaImagen=n.LlevaImagen,
                              UsuarioAdicion=n.UsuarioAdicion,
                              CreadoPor=n.CreadoPor,
                              FechaAdiciona=n.FechaAdiciona,
                              FechaCreado=n.FechaCreado,
                              UsuarioModifica=n.UsuarioModifica,
                              ModificadoPor=n.ModificadoPor,
                              FechaModifica=n.FechaModifica,
                              FechaModificado=n.FechaModificado,
                              Fecha=n.Fecha,
                              EstatusProducto0=n.EstatusProducto0,
                              EstatusProducto=n.EstatusProducto,
                              AplicaParaImpuesto0=n.AplicaParaImpuesto0,
                              AplicaParaImpuesto=n.AplicaParaImpuesto,
                              NumeroSeguimiento=n.NumeroSeguimiento,
                              CantidadRegistros=n.CantidadRegistros,
                              ProductosConOferta=n.ProductosConOferta,
                              ProductoProximoAgotarse=n.ProductoProximoAgotarse,
                              ProductosAgostados=n.ProductosAgostados,
                              CapilalInvertido=n.CapilalInvertido,
                              GananciaAproximada=n.GananciaAproximada,
                              Comentario=n.Comentario,
                          }).ToList();
            return Buscar;
        }


        //MANTENIMIENTO DE PRODUCTOS
        public DSMarket.Logica.Entidades.EntidadesInventario.EProducto MantenimientoProducto(DSMarket.Logica.Entidades.EntidadesInventario.EProducto Item, string Accion)
        {
            Objdata.CommandTimeout = 999999999;

            DSMarket.Logica.Entidades.EntidadesInventario.EProducto Mantenimiento = null;

            var Producto = Objdata.SP_MANTENIMIENTO_PRODUCTO(
                Item.IdProducto
                , Item.NumeroConector
                , Item.IdTipoProducto
                , Item.IdCategoria
                , Item.IdUnidadMedida
                , Item.IdMarca
                , Item.IdModelo
                , Item.IdTipoSuplidor
                , Item.IdSuplidor
                , Item.Producto
                , Item.CodigoBarra
                , Item.Referencia
                , Item.PrecioCompra
                , Item.PrecioVenta
                , Item.Stock
                , Item.StockMinimo
                , Item.PorcientoDescuento
                , Item.AfectaOferta0
                , Item.ProductoAcumulativo0
                , Item.LlevaImagen0
                , Item.UsuarioAdicion
                , Item.Comentario
                , Item.AplicaParaImpuesto0
                , Item.EstatusProducto0
                , Item.NumeroSeguimiento
                , Item.IdColor
                , Item.IdCondicion
                , Item.IdCapacidad
                , Accion);
            if (Producto != null)
            {
                Mantenimiento = (from n in Producto
                                 select new DSMarket.Logica.Entidades.EntidadesInventario.EProducto
                                 {
                                      IdProducto=n.IdProducto,
                                      NumeroConector=n.NumeroConector,
                                      IdTipoProducto=n.IdTipoProducto,
                                      Producto=n.Descripcion,
                                      IdCategoria=n.IdCategoria,
                                      IdUnidadMedida=n.IdUnidadMedida,
                                      IdMarca=n.IdMarca,
                                      IdModelo=n.IdModelo,
                                      IdTipoSuplidor=n.IdTipoSuplidor,
                                      IdSuplidor=n.IdSuplidor,
                                      CodigoBarra=n.CodigoBarra,
                                      Referencia=n.Referencia,
                                      PrecioCompra=n.PrecioCompra,
                                      PrecioVenta=n.PrecioVenta,
                                      Stock=n.Stock,
                                      StockMinimo=n.StockMinimo,
                                      PorcientoDescuento=n.PorcientoDescuento,
                                      AfectaOferta0=n.AfectaOferta,
                                      ProductoAcumulativo0=n.ProductoAcumulativo,
                                      LlevaImagen0=n.LlevaImagen,
                                      UsuarioAdicion=n.UsuarioAdicion,
                                      FechaAdiciona=n.FechaAdiciona,
                                      UsuarioModifica=n.UsuarioModifica,
                                      FechaModifica=n.FechaModifica,
                                      Fecha=n.Fecha,
                                      Comentario=n.Comentario,
                                      AplicaParaImpuesto0=n.AplicaParaImpuesto,
                                      EstatusProducto0 = n.EstatusProducto,
                                      NumeroSeguimiento=n.NumeroSeguimiento,
                                      IdColor=n.IdColor,
                                      IdCondicion=n.IdCondicion,
                                      IdCapacidad=n.IdCapacidad
                                 }).FirstOrDefault();
            }
            return Mantenimiento;
        }

        //LISTADO DE LOS PRODUCTOS PROXIMOS A AGOTARSE
        public List<DSMarket.Logica.Entidades.EntidadesInventario.EProductoProximoAgotarse> ProductosProximoAgotarse(decimal? IdProducto = null, decimal? NumeroConector = null, string Descripcion = null, string CodigoBarra = null, string Referencia = null, DateTime? FechaDesde = null, DateTime? FechaHasta = null, decimal? IdTipoProducto = null, decimal? IdCategoria = null, decimal? IdUnidadMedida = null, decimal? IdMarca = null, decimal? IdModelo = null, bool? TieneOferta = null, int? NumeroPagina = null, int? NumeroRegistros = null)
        {
            Objdata.CommandTimeout = 999999999;

            var Listado = (from n in Objdata.SP_BUSCA_PRODUCTO_PRIXIMO_AGOTARSE(IdProducto, NumeroConector, Descripcion, CodigoBarra, Referencia, FechaDesde, FechaHasta, IdTipoProducto, IdCategoria, IdUnidadMedida, IdMarca, IdModelo, TieneOferta, NumeroPagina, NumeroRegistros)
                           select new DSMarket.Logica.Entidades.EntidadesInventario.EProductoProximoAgotarse
                           {
                               IdProducto = n.IdProducto,
                               NumeroConector = n.NumeroConector,
                               IdTipoProducto = n.IdTipoProducto,
                               Producto = n.Producto,
                               TipoProducto = n.TipoProducto,
                               IdCategoria = n.IdCategoria,
                               Categoria = n.Categoria,
                               IdUnidadMedida = n.IdUnidadMedida,
                               UnidadMedida = n.UnidadMedida,
                               IdMarca = n.IdMarca,
                               Marca = n.Marca,
                               IdModelo = n.IdModelo,
                               Modelo = n.Modelo,
                               IdTipoSuplidor = n.IdTipoSuplidor,
                               TipoSuplidor = n.TipoSuplidor,
                               IdSuplidor = n.IdSuplidor,
                               Suplidor = n.Suplidor,
                               CodigoBarra = n.CodigoBarra,
                               Referencia = n.Referencia,
                               PrecioCompra = n.PrecioCompra,
                               PrecioVenta = n.PrecioVenta,
                               Stock = n.Stock,
                               StockMinimo = n.StockMinimo,
                               PorcientoDescuento = n.PorcientoDescuento,
                               AfectaOferta0 = n.AfectaOferta0,
                               AceptaOferta = n.AceptaOferta,
                               ProductoAcumulativo0 = n.ProductoAcumulativo0,
                               ProductoAcumulativo = n.ProductoAcumulativo,
                               LlevaImagen0 = n.LlevaImagen0,
                               LlevaImagen = n.LlevaImagen,
                               UsuarioAdicion = n.UsuarioAdicion,
                               CreadoPor = n.CreadoPor,
                               FechaAdiciona = n.FechaAdiciona,
                               FechaCreado = n.FechaCreado,
                               UsuarioModifica = n.UsuarioModifica,
                               ModificadoPor = n.ModificadoPor,
                               FechaModifica = n.FechaModifica,
                               FechaModificado = n.FechaModificado,
                               Fecha = n.Fecha,
                               CantidadRegistros = n.CantidadRegistros,
                               Comentario = n.Comentario,
                           }).ToList();
            return Listado;
        }


        //LISTADO DE LOS PRODUCTOS PROXIMOS A AGOTADOS
        public List<DSMarket.Logica.Entidades.EntidadesInventario.EProductosAgotados> ProductosAgotados(decimal? IdProducto = null, decimal? NumeroConector = null, string Descripcion = null, string CodigoBarra = null, string Referencia = null, DateTime? FechaDesde = null, DateTime? FechaHasta = null, decimal? IdTipoProducto = null, decimal? IdCategoria = null, decimal? IdUnidadMedida = null, decimal? IdMarca = null, decimal? IdModelo = null, bool? TieneOferta = null, int? NumeroPagina = null, int? NumeroRegistros = null)
        {
            Objdata.CommandTimeout = 999999999;

            var Listado = (from n in Objdata.SP_BUSCA_PRODUCTOS_AGOTADOS(IdProducto, NumeroConector, Descripcion, CodigoBarra, Referencia, FechaDesde, FechaHasta, IdTipoProducto, IdCategoria, IdUnidadMedida, IdMarca, IdModelo, TieneOferta, NumeroPagina, NumeroRegistros)
                           select new DSMarket.Logica.Entidades.EntidadesInventario.EProductosAgotados
                           {
                               IdProducto = n.IdProducto,
                               NumeroConector = n.NumeroConector,
                               IdTipoProducto = n.IdTipoProducto,
                               Producto = n.Producto,
                               TipoProducto = n.TipoProducto,
                               IdCategoria = n.IdCategoria,
                               Categoria = n.Categoria,
                               IdUnidadMedida = n.IdUnidadMedida,
                               UnidadMedida = n.UnidadMedida,
                               IdMarca = n.IdMarca,
                               Marca = n.Marca,
                               IdModelo = n.IdModelo,
                               Modelo = n.Modelo,
                               IdTipoSuplidor = n.IdTipoSuplidor,
                               TipoSuplidor = n.TipoSuplidor,
                               IdSuplidor = n.IdSuplidor,
                               Suplidor = n.Suplidor,
                               CodigoBarra = n.CodigoBarra,
                               Referencia = n.Referencia,
                               PrecioCompra = n.PrecioCompra,
                               PrecioVenta = n.PrecioVenta,
                               Stock = n.Stock,
                               StockMinimo = n.StockMinimo,
                               PorcientoDescuento = n.PorcientoDescuento,
                               AfectaOferta0 = n.AfectaOferta0,
                               AceptaOferta = n.AceptaOferta,
                               ProductoAcumulativo0 = n.ProductoAcumulativo0,
                               ProductoAcumulativo = n.ProductoAcumulativo,
                               LlevaImagen0 = n.LlevaImagen0,
                               LlevaImagen = n.LlevaImagen,
                               UsuarioAdicion = n.UsuarioAdicion,
                               CreadoPor = n.CreadoPor,
                               FechaAdiciona = n.FechaAdiciona,
                               FechaCreado = n.FechaCreado,
                               UsuarioModifica = n.UsuarioModifica,
                               ModificadoPor = n.ModificadoPor,
                               FechaModifica = n.FechaModifica,
                               FechaModificado = n.FechaModificado,
                               Fecha = n.Fecha,
                               CantidadRegistros = n.CantidadRegistros,
                               Comentario = n.Comentario,
                           }).ToList();
            return Listado;
        }
        #endregion
        #region MANTENIMIENTO DE PRODUCTOS Y SERVICIOS
        //LISTADO DE PRODUCTOS
        public List<DSMarket.Logica.Entidades.EntidadesInventario.EProductosServicios> BuscaProductosServicios(decimal? IdRegistro = null, string NumeroConector = null, decimal? IdTipoProducto = null, decimal? IdCategoria = null, decimal? IdMarca = null, decimal? IdTipoSuplidor = null, decimal? IdSuplidor = null, string Descripcion = null, string CodigoBarra = null, string Referencia = null, string NumeroSeguimiento = null, string CodigoProducto = null, DateTime? FechaIngresoDesde = null, DateTime? FechaIngresoHasta = null, decimal? IdUsuarioGenera = null, decimal? Stock = null) {
            Objdata.CommandTimeout = 999999999;

            var Listado = (from n in Objdata.SP_BUSCA_PRODUCTOS_SERVICIOS(IdRegistro, NumeroConector, IdTipoProducto, IdCategoria, IdMarca, IdTipoSuplidor, IdSuplidor, Descripcion, CodigoBarra, Referencia, NumeroSeguimiento, CodigoProducto, FechaIngresoDesde, FechaIngresoHasta, IdUsuarioGenera, Stock)
                           select new DSMarket.Logica.Entidades.EntidadesInventario.EProductosServicios
                           {
                               IdRegistro=n.IdRegistro,
                               NumeroConector=n.NumeroConector,
                               IdTipoProducto=n.IdTipoProducto,
                               TipoProducto=n.TipoProducto,
                               IdCategoria=n.IdCategoria,
                               Categoria=n.Categoria,
                               IdMarca=n.IdMarca,
                               Marca=n.Marca,
                               IdTipoSuplidor=n.IdTipoSuplidor,
                               TipoSuplidor=n.TipoSuplidor,
                               IdSuplidor=n.IdSuplidor,
                               Suplidor=n.Suplidor,
                               Descripcion=n.Descripcion,
                               CodigoBarra=n.CodigoBarra,
                               Referencia=n.Referencia,
                               NumeroSeguimiento=n.NumeroSeguimiento,
                               CodigoProducto=n.CodigoProducto,
                               PrecioCompra=n.PrecioCompra,
                               PrecioVenta=n.PrecioVenta,
                               GananciaAproximada=n.GananciaAproximada,
                               Stock=n.Stock,
                               StockMinimo=n.StockMinimo,
                               Estatus=n.Estatus,
                               UnidadMedida=n.UnidadMedida,
                               Modelo=n.Modelo,
                               Color=n.Color,
                               Condicion=n.Condicion,
                               Capacidad=n.Capacidad,
                               AplicaParaImpuesto0=n.AplicaParaImpuesto0,
                               AplicaParaImpuesto=n.AplicaParaImpuesto,
                               TieneImagen0=n.TieneImagen0,
                               TieneImagen=n.TieneImagen,
                               LlevaGarantia0=n.LlevaGarantia0,
                               LlevaGarantia=n.LlevaGarantia,
                               IdTipoGarantia=n.IdTipoGarantia,
                               TipoTiempoGarantia=n.TipoTiempoGarantia,
                               TiempoGarantia=n.TiempoGarantia,
                               Comentario=n.Comentario,
                               UsuarioAdiciona=n.UsuarioAdiciona,
                               CreadoPor=n.CreadoPor,
                               FechaAdiciona0=n.FechaAdiciona0,
                               FechaAdiciona=n.FechaAdiciona,
                               UsuarioModifica=n.UsuarioModifica,
                               ModificadoPor=n.ModificadoPor,
                               FechaModifica0 = n.FechaModifica0,
                               FechaModifica=n.FechaModifica,
                               FechaIngreso0=n.FechaIngreso0,
                               FechaIngreso=n.FechaIngreso,
                               NombreEmpresa=n.NombreEmpresa,
                               RNC=n.RNC,
                               Direccion=n.Direccion,
                               Telefonos=n.Telefonos,
                               Email=n.Email,
                               Email2=n.Email2,
                               Facebook=n.Facebook,
                               Instagran=n.Instagran,
                               GeneradoPor=n.GeneradoPor,
                               CapitalInvertido=n.CapitalInvertido,
                               GananciaAproximadaTotal=n.GananciaAproximadaTotal,
                               LogoEmpresa=n.LogoEmpresa
                           }).ToList();
            return Listado;
        }

        public DSMarket.Logica.Entidades.EntidadesInventario.EProductosServicios ProcesarProductosServicios(DSMarket.Logica.Entidades.EntidadesInventario.EProductosServicios Item, string Accion) {
            Objdata.CommandTimeout = 999999999;

            DSMarket.Logica.Entidades.EntidadesInventario.EProductosServicios Procesar = null;

            var ProductosServicios = Objdata.SP_PROCESAR_INFORMACION_PRODUCTOS_SERVICIOS(
                Item.IdRegistro,
                Item.NumeroConector,
                Item.IdTipoProducto,
                Item.IdCategoria,
                Item.IdMarca,
                Item.IdTipoSuplidor,
                Item.IdSuplidor,
                Item.Descripcion,
                Item.CodigoBarra,
                Item.Referencia,
                Item.NumeroSeguimiento,
                Item.CodigoProducto,
                Item.PrecioCompra,
                Item.PrecioVenta,
                Item.Stock,
                Item.StockMinimo,
                Item.UnidadMedida,
                Item.Modelo,
                Item.Color,
                Item.Condicion,
                Item.Capacidad,
                Item.AplicaParaImpuesto0,
                Item.TieneImagen0,
                Item.LlevaGarantia0,
                Item.IdTipoGarantia,
                Item.TiempoGarantia,
                Item.Comentario,
                Item.UsuarioAdiciona,
                Accion);
            if (ProductosServicios != null) {
                Procesar = (from n in ProductosServicios
                            select new DSMarket.Logica.Entidades.EntidadesInventario.EProductosServicios
                            {
                                IdRegistro = n.IdRegistro,
                                NumeroConector = n.NumeroConector,
                                IdTipoProducto = n.IdTipoProducto,
                                IdCategoria = n.IdCategoria,
                                IdMarca = n.IdMarca,
                                IdTipoSuplidor = n.IdTipoSuplidor,
                                IdSuplidor = n.IdSuplidor,
                                Descripcion = n.Descripcion,
                                CodigoBarra = n.CodigoBarra,
                                Referencia = n.Referencia,
                                NumeroSeguimiento = n.NumeroSeguimiento,
                                CodigoProducto = n.CodigoProducto,
                                PrecioCompra = n.PrecioCompra,
                                PrecioVenta = n.PrecioVenta,
                                Stock = n.Stock,
                                StockMinimo = n.StockMinimo,
                                UnidadMedida = n.UnidadMedida,
                                Modelo = n.Modelo,
                                Color = n.Color,
                                Condicion = n.Condicion,
                                Capacidad = n.Capacidad,
                                AplicaParaImpuesto0 = n.AplicaParaImpuesto,
                                TieneImagen0 = n.TieneImagen,
                                LlevaGarantia0 = n.LlevaGarantia,
                                IdTipoGarantia = n.IdTipoGarantia,
                                TiempoGarantia = n.TiempoGarantia,
                                Comentario = n.Comentario,
                                UsuarioAdiciona = n.UsuarioAdiciona,
                                FechaAdiciona0 = n.FechaAdiciona,
                                UsuarioModifica = n.UsuarioModifica,
                                FechaModifica0 = n.FechaModifica,
                                FechaIngreso0 = n.FechaIngreso,
                            }).FirstOrDefault();
            }
            return Procesar;
        }
        #endregion
        #region MANTENIMIENTO DE PRODUCTOS DEFECTUOSOS
        //LISTADO DE PRODUCTOS DEFECTUOSOS
        public List<DSMarket.Logica.Entidades.EntidadesInventario.EProductosDefectuosos> BuscaProductosDefectuosos(decimal? IdProducto = null, decimal? NumeroConector = null, string Descripcion = null, string CodigoBarra = null, string Referencia = null, DateTime? FechaDesde = null, DateTime? FechaHasta = null, decimal? IdTipoProducto = null, decimal? IdCategoria = null, decimal? IdUnidadMedida = null, decimal? IdMarca = null, decimal? IdModelo = null, bool? TieneOferta = null, bool? EstatusProducto = null, string NumeroSeguimiento = null, int? NumeroPagina = null, int? NumeroRegistros = null)
        {
            Objdata.CommandTimeout = 999999999;

            var Buscar = (from n in Objdata.SP_BUSCA_PRODUCTOS_DEFECTUOSOS(IdProducto, NumeroConector, Descripcion, CodigoBarra, Referencia, FechaDesde, FechaHasta, IdTipoProducto, IdCategoria, IdUnidadMedida, IdMarca, IdModelo, TieneOferta, EstatusProducto, NumeroSeguimiento, NumeroPagina, NumeroRegistros)
                          select new DSMarket.Logica.Entidades.EntidadesInventario.EProductosDefectuosos
                          {
                              IdProductoDefectuoso = n.IdProductoDefectuoso,
                              NumeroConector = n.NumeroConector,
                              IdTipoProducto = n.IdTipoProducto,
                              Producto = n.Producto,
                              TipoProducto = n.TipoProducto,
                              IdCategoria = n.IdCategoria,
                              Categoria = n.Categoria,
                              IdUnidadMedida = n.IdUnidadMedida,
                              UnidadMedida = n.UnidadMedida,
                              IdMarca = n.IdMarca,
                              Marca = n.Marca,
                              IdModelo = n.IdModelo,
                              Modelo = n.Modelo,
                              IdColor=n.IdColor,
                              Color=n.Color,
                              IdCondicion = n.IdCondicion,
                              Condicion = n.Condicion,
                              IdCapacidad =n.IdCapacidad,
                              Capacidad=n.Capacidad,
                              IdTipoSuplidor = n.IdTipoSuplidor,
                              TipoSuplidor = n.TipoSuplidor,
                              IdSuplidor = n.IdSuplidor,
                              Suplidor = n.Suplidor,
                              CodigoBarra = n.CodigoBarra,
                              Referencia = n.Referencia,
                              PrecioCompra = n.PrecioCompra,
                              PrecioVenta = n.PrecioVenta,
                              Stock = n.Stock,
                              StockMinimo = n.StockMinimo,
                              PorcientoDescuento = n.PorcientoDescuento,
                              AfectaOferta0 = n.AfectaOferta0,
                              AceptaOferta = n.AceptaOferta,
                              ProductoAcumulativo0 = n.ProductoAcumulativo0,
                              ProductoAcumulativo = n.ProductoAcumulativo,
                              LlevaImagen0 = n.LlevaImagen0,
                              LlevaImagen = n.LlevaImagen,
                              UsuarioAdiciona = n.UsuarioAdiciona,
                              CreadoPor = n.CreadoPor,
                              FechaAdiciona = n.FechaAdiciona,
                              FechaCreado = n.FechaCreado,
                              UsuarioModifica = n.UsuarioModifica,
                              ModificadoPor = n.ModificadoPor,
                              FechaModifica = n.FechaModifica,
                              FechaModificado = n.FechaModificado,
                              Fecha = n.Fecha,
                              EstatusProducto0 = n.EstatusProducto0,
                              EstatusProducto = n.EstatusProducto,
                              AplicaParaImpuesto0 = n.AplicaParaImpuesto0,
                              AplicaParaImpuesto = n.AplicaParaImpuesto,
                              CantidadAgregada=n.CantidadAgregada,
                              NumeroSeguimiento=n.NumeroSeguimiento,
                              CantidadRegistros = n.CantidadRegistros,
                              ProductosConOferta = n.ProductosConOferta,
                              ProductoProximoAgotarse = n.ProductoProximoAgotarse,
                              ProductosAgostados = n.ProductosAgostados,
                              TotalProductos=n.TotalProductos,
                              Comentario = n.Comentario,


                          }).ToList();
            return Buscar;
        }


        //MANTENIMIENTO DE PRODUCTOS
        public DSMarket.Logica.Entidades.EntidadesInventario.EProductosDefectuosos MantenimientoProductosDefectuoso(DSMarket.Logica.Entidades.EntidadesInventario.EProductosDefectuosos Item, string Accion)
        {
            Objdata.CommandTimeout = 999999999;

            DSMarket.Logica.Entidades.EntidadesInventario.EProductosDefectuosos Mantenimiento = null;

            var Producto = Objdata.SP_MANTENIMIENTO_PRODUCTOS_DEFECTUOSOS(
                Item.IdProductoDefectuoso
                , Item.NumeroConector
                , Item.IdTipoProducto
                , Item.IdCategoria
                , Item.IdUnidadMedida
                , Item.IdMarca
                , Item.IdModelo
                , Item.IdTipoSuplidor
                , Item.IdSuplidor
                , Item.Producto
                , Item.CodigoBarra
                , Item.Referencia
                , Item.PrecioCompra
                , Item.PrecioVenta
                , Item.Stock
                , Item.StockMinimo
                , Item.PorcientoDescuento
                , Item.AfectaOferta0
                , Item.ProductoAcumulativo0
                , Item.LlevaImagen0
                , Item.UsuarioAdiciona
                , Item.Comentario
                , Item.AplicaParaImpuesto0
                , Item.EstatusProducto0
                , Item.CantidadAgregada
                , Item.NumeroSeguimiento
                , Item.IdColor
                , Item.IdCapacidad
                , Item.IdCondicion
                , Accion);
            if (Producto != null)
            {
                Mantenimiento = (from n in Producto
                                 select new DSMarket.Logica.Entidades.EntidadesInventario.EProductosDefectuosos
                                 {
                                     IdProductoDefectuoso = n.IdProductoDefectuoso,
                                     NumeroConector = n.NumeroConector,
                                     IdTipoProducto = n.IdTipoProducto,
                                     Producto = n.Descripcion,
                                     IdCategoria = n.IdCategoria,
                                     IdUnidadMedida = n.IdUnidadMedida,
                                     IdMarca = n.IdMarca,
                                     IdModelo = n.IdModelo,
                                     IdTipoSuplidor = n.IdTipoSuplidor,
                                     IdSuplidor = n.IdSuplidor,
                                     CodigoBarra = n.CodigoBarra,
                                     Referencia = n.Referencia,
                                     PrecioCompra = n.PrecioCompra,
                                     PrecioVenta = n.PrecioVenta,
                                     Stock = n.Stock,
                                     StockMinimo = n.StockMinimo,
                                     PorcientoDescuento = n.PorcientoDescuento,
                                     AfectaOferta0 = n.AfectaOferta,
                                     ProductoAcumulativo0 = n.ProductoAcumulativo,
                                     LlevaImagen0 = n.LlevaImagen,
                                     UsuarioAdiciona = n.UsuarioAdicion,
                                     FechaAdiciona = n.FechaAdiciona,
                                     UsuarioModifica = n.UsuarioModifica,
                                     FechaModifica = n.FechaModifica,
                                     Fecha = n.Fecha,
                                     Comentario = n.Comentario,
                                     AplicaParaImpuesto0 = n.AplicaParaImpuesto,
                                     EstatusProducto0 = n.EstatusProducto,
                                    CantidadAgregada=n.CantidadAgregada,
                                    NumeroSeguimiento=n.NumeroSeguimiento,
                                    IdColor=n.IdColor,
                                    IdCapacidad=n.IdCapacidad,
                                    IdCondicion=n.IdCondicion
                                    
                                 }).FirstOrDefault();
            }
            return Mantenimiento;
        }

        #endregion
        #region MOSTRAR LA CANTIDAD DE LOS PRODUCTOS DEFECTUOSOS
        public List<DSMarket.Logica.Entidades.EntidadesInventario.ECantidadProductosDefectuosos> CantidadProductosDefectuosos() {
            Objdata.CommandTimeout = 999999999;

            var Cantidad = (from n in Objdata.SP_MOSTRAR_CANTIDAD_PRODUCTOS_DEFECTUOSOS()
                            select new DSMarket.Logica.Entidades.EntidadesInventario.ECantidadProductosDefectuosos
                            {
                                CantidadProductosDefectuosos=n.CantidadProductosDefectuosos
                            }).ToList();
            return Cantidad;
        }
        #endregion
        #region VALIDAR REFERENCIA DE PRODUCTO
        public List<DSMarket.Logica.Entidades.EntidadesInventario.EValidaReferenciaProducto> ValidarReferenciaProducto(string Referencia = null) {
            Objdata.CommandTimeout = 999999999;

            var Listado = (from n in Objdata.SP_VALIDAR_REFERENCIA_PRODUCTO(Referencia)
                           select new DSMarket.Logica.Entidades.EntidadesInventario.EValidaReferenciaProducto
                           {
                               Total=n.Total
                           }).ToList();
            return Listado;
        }
        #endregion
    }
}
