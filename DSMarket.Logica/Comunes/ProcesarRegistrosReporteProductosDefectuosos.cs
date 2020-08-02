using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes
{
    public class ProcesarRegistrosReporteProductosDefectuosos
    {
        public readonly Lazy<DSMarket.Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion> ObjData = new Lazy<Logica.LogicaConfiguracion.LogicaCOnfiguracion>();


        private decimal IdUsuario = 0;
        private decimal NumeroConector = 0;
        private decimal IdTipoProducto = 0;
        private string Producto = "";
        private string TipoProducto = "";
        private decimal IdCategoria = 0;
        private string Categoria = "";
        private decimal IdUnidadMedida = 0;
        private string UnidadMedida = "";
        private decimal Idmarca = 0;
        private string Marca = "";
        private decimal IdModelo = 0;
        private string Modelo = "";
        private decimal IdTipoSuplidor = 0;
        private string TipoSuplidor = "";
        private decimal IdSuplidor = 0;
        private string Suplidor = "";
        private string CodigoBarra = "";
        private string Referencia = "";
        private decimal PrecioCompra = 0;
        private decimal PrecioVenta = 0;
        private decimal Stock = 0;
        private decimal StockMinimo = 0;
        private decimal PorcientoDescuento = 0;
        private bool AfctaOferta0 = false;
        private string AfectaOferta = "";
        private bool ProductoAcumulativo0 = false;
        private string ProductoAcumulativo = "";
        private bool LlevaImagen0 = false;
        private string LlevaImagen = "";
        private decimal UsuarioAdiciona = 0;
        private string CreadoPor = "";
        private DateTime FechaAdiciona = DateTime.Now;
        private string FechaCreado = "";
        private decimal UsuarioModifica = 0;
        private string ModificadoPor = "";
        private DateTime FechaModifica = DateTime.Now;
        private string FechaModificado = "";
        private DateTime Fecha = DateTime.Now;
        private bool AplicaParaImpuesto0 = false;
        private bool EstatusProducto0 = false;
        private string EstatusProducto = "";
        private string AplicaImpuesto = "";
        private decimal CantidadAgregada = 0;
        private decimal CantidadRegistros = 0;
        private decimal ProductoConOferta = 0;
        private decimal ProductoProximoAgotarse = 0;
        private decimal ProductosAgostados = 0;
        private decimal TotalProductos = 0;
        private string Comentario = "";
        private string Accion = "";

       public ProcesarRegistrosReporteProductosDefectuosos(
       decimal IdUsuarioCON,
       decimal NumeroConectorCON,
       decimal IdTipoProductoCON,
       string ProductoCON,
       string TipoProductoCON,
       decimal IdCategoriaCON,
       string CategoriaCON,
       decimal IdUnidadMedidaCON,
       string UnidadMedidaCON,
       decimal IdmarcaCON,
       string MarcaCON,
       decimal IdModeloCON,
       string ModeloCON,
       decimal IdTipoSuplidorCON,
       string TipoSuplidorCON,
       decimal IdSuplidorCON,
       string SuplidorCON,
       string CodigoBarraCON,
       string ReferenciaCON,
       decimal PrecioCompraCON,
       decimal PrecioVentaCON,
       decimal StockCON,
       decimal StockMinimoCON,
       decimal PorcientoDescuentoCON,
       bool AfctaOferta0CON,
       string AfectaOfertaCON,
       bool ProductoAcumulativo0CON,
       string ProductoAcumulativoCON,
       bool LlevaImagen0CON,
       string LlevaImagenCON,
       decimal UsuarioAdicionaCON,
       string CreadoPorCON,
       DateTime FechaAdicionaCON,
       string FechaCreadoCON,
       decimal UsuarioModificaCON,
       string ModificadoPorCON,
       DateTime FechaModificaCON,
       string FechaModificadoCON,
       DateTime FechaCON,
       bool AplicaParaImpuesto0CON,
       bool EstatusProducto0CON,
       string EstatusProductoCON,
       string AplicaImpuestoCON,
       decimal CantidadAgregadaCON,
       decimal CantidadRegistrosCON,
       decimal ProductoConOfertaCON,
       decimal ProductoProximoAgotarseCON,
       decimal ProductosAgostadosCON,
       decimal TotalProductosCON,
       string ComentarioCON,
       string AccionCON
            )
        {
            IdUsuario = IdUsuarioCON;
            NumeroConector = NumeroConectorCON;
            IdTipoProducto = IdTipoProductoCON;
            Producto = ProductoCON;
            TipoProducto = TipoProductoCON;
            IdCategoria = IdCategoriaCON;
            Categoria = CategoriaCON;
            IdUnidadMedida = IdUnidadMedidaCON;
            UnidadMedida = UnidadMedidaCON;
            Idmarca = IdmarcaCON;
            Marca = MarcaCON;
            IdModelo = IdModeloCON;
            Modelo = ModeloCON;
            IdTipoSuplidor = IdTipoSuplidorCON;
            TipoSuplidor = TipoSuplidorCON;
            IdSuplidor = IdSuplidorCON;
            Suplidor = SuplidorCON;
            CodigoBarra = CodigoBarraCON;
            Referencia = ReferenciaCON;
            PrecioCompra = PrecioCompraCON;
            PrecioVenta = PrecioVentaCON;
            Stock = StockCON;
            StockMinimo = StockMinimoCON;
            PorcientoDescuento = PorcientoDescuentoCON;
            AfctaOferta0 = AfctaOferta0CON;
            AfectaOferta = AfectaOfertaCON;
            ProductoAcumulativo0 = ProductoAcumulativo0CON;
            ProductoAcumulativo = ProductoAcumulativoCON;
            LlevaImagen0 = LlevaImagen0CON;
            LlevaImagen = LlevaImagenCON;
            UsuarioAdiciona = UsuarioAdicionaCON;
            CreadoPor = CreadoPorCON;
            FechaAdiciona = FechaAdicionaCON;
            FechaCreado = FechaCreadoCON;
            UsuarioModifica = UsuarioModificaCON;
            ModificadoPor = ModificadoPorCON;
            FechaModifica = FechaModificaCON;
            FechaModificado = FechaModificadoCON;
            Fecha = FechaCON;
            AplicaParaImpuesto0 = AplicaParaImpuesto0CON;
            EstatusProducto0 = EstatusProducto0CON;
            EstatusProducto = EstatusProductoCON;
            AplicaImpuesto = AplicaImpuestoCON;
            CantidadAgregada = CantidadAgregadaCON;
            CantidadRegistros = CantidadRegistrosCON;
            ProductoConOferta = ProductoConOfertaCON;
            ProductoProximoAgotarse = ProductoProximoAgotarseCON;
            ProductosAgostados = ProductosAgostadosCON;
            TotalProductos = TotalProductosCON;
            Comentario = ComentarioCON;
            Accion = AccionCON;
        }

        public void ProcesarInformacionreporteProductosDefectuosos() {
            DSMarket.Logica.Entidades.EntidadesConfiguracion.EReporteProductosDefectuosos Reporte = new Entidades.EntidadesConfiguracion.EReporteProductosDefectuosos();

            Reporte.IdUsuario = IdUsuario;
            Reporte.NumeroConector = NumeroConector;
            Reporte.IdTipoProducto = IdTipoProducto;
            Reporte.Producto = Producto;
            Reporte.TipoProducto = TipoProducto;
            Reporte.IdCategoria = IdCategoria;
            Reporte.Categoria = Categoria;
            Reporte.IdUnidadMedida = IdUnidadMedida;
            Reporte.UnidadMedida = UnidadMedida;
            Reporte.Idmarca = Idmarca;
            Reporte.Marca = Marca;
            Reporte.IdModelo = IdModelo;
            Reporte.Modelo = Modelo;
            Reporte.IdTipoSuplidor = IdTipoSuplidor;
            Reporte.TipoSuplidor = TipoSuplidor;
            Reporte.IdSuplidor = IdSuplidor;
            Reporte.Suplidor = Suplidor;
            Reporte.CodigoBarra = CodigoBarra;
            Reporte.Referencia = Referencia;
            Reporte.PrecioCompra = PrecioCompra;
            Reporte.PrecioVenta = PrecioVenta;
            Reporte.Stock = Stock;
            Reporte.StockMinimo = StockMinimo;
            Reporte.PorcientoDescuento = PorcientoDescuento;
            Reporte.AfctaOferta0 = AfctaOferta0;
            Reporte.AfectaOferta = AfectaOferta;
            Reporte.ProductoAcumulativo0 = ProductoAcumulativo0;
            Reporte.ProductoAcumulativo = ProductoAcumulativo;
            Reporte.LlevaImagen0 = LlevaImagen0;
            Reporte.LlevaImagen = LlevaImagen;
            Reporte.UsuarioAdiciona = UsuarioAdiciona;
            Reporte.CreadoPor = CreadoPor;
            Reporte.FechaAdiciona = FechaAdiciona;
            Reporte.FechaCreado = FechaCreado;
            Reporte.UsuarioModifica = UsuarioModifica;
            Reporte.ModificadoPor = ModificadoPor;
            Reporte.FechaModifica = FechaModifica;
            Reporte.FechaModificado = FechaModificado;
            Reporte.Fecha = Fecha;
            Reporte.AplicaParaImpuesto0 = AplicaParaImpuesto0;
            Reporte.EstatusProducto0 = EstatusProducto0;
            Reporte.EstatusProducto = EstatusProducto;
            Reporte.AplicaImpuesto = AplicaImpuesto;
            Reporte.CantidadAgregada = CantidadAgregada;
            Reporte.CantidadRegistros = CantidadRegistros;
            Reporte.ProductoConOferta = ProductoConOferta;
            Reporte.ProductoProximoAgotarse = ProductoProximoAgotarse;
            Reporte.ProductosAgostados = ProductosAgostados;
            Reporte.TotalProductos = TotalProductos;
            Reporte.Comentario = Comentario;

            var man = ObjData.Value.GuardarRegistrosProductosDefectuosos(Reporte, Accion);
        }
    }
}
