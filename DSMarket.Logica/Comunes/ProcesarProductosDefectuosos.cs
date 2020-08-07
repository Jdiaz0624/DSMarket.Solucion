using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes
{
    public class ProcesarProductosDefectuosos
    {
        public readonly Lazy<DSMarket.Logica.Logica.LogicaInventario.LogicaInventario> ObjDataInventario = new Lazy<Logica.LogicaInventario.LogicaInventario>();

        private decimal IdProductoDefectuoso = 0;
        private decimal NumeroConector = 0;
        private decimal IdTipoProducto = 0;
        private decimal IdCategoria = 0;
        private decimal IdUnidadMedida = 0;
        private decimal IdMarca = 0;
        private decimal IdModelo = 0;
        private decimal IdTipoSuplidor = 0;
        private decimal IdSuplidor = 0;
        private string Descripcion = "";
        private string CodigoBarra = "";
        private string Referencia = "";
        private decimal PrecioCompra = 0;
        private decimal PrecioVenta = 0;
        private decimal Stock = 0;
        private decimal StockMinimo = 0;
        private decimal PorcientoDescuento = 0;
        private bool AfectaOferta = false;
        private bool ProductoAcumulativo = false;
        private bool LlevaImagen = false;
        private decimal UsuarioAdiciona = 0;
        private DateTime FechaAdiciona = DateTime.Now;
        private decimal UsuarioModifica = 0;
        private DateTime FechaModifica = DateTime.Now;
        private DateTime Fecha = DateTime.Now;
        private string Comentario = "";
        private bool AplicaParaImpuesto = false;
        private bool EstatusProducto = false;
        private decimal CantidadAgregada = 0;
        private string NumeroSeguimiento = "";
        private string Accion = "";

        //CREAMOS UN METODO CONSTRUCTOR
        public ProcesarProductosDefectuosos(
        decimal IdProductoDefectuosoCON,
        decimal NumeroConectorCON,
        decimal IdTipoProductoCON,
        decimal IdCategoriaCON,
        decimal IdUnidadMedidaCON,
        decimal IdMarcaCON,
        decimal IdModeloCON,
        decimal IdTipoSuplidorCON,
        decimal IdSuplidorCON,
        string DescripcionCON,
        string CodigoBarraCON,
        string ReferenciaCON,
        decimal PrecioCompraCON,
        decimal PrecioVentaCON,
        decimal StockCON,
        decimal StockMinimoCON,
        decimal PorcientoDescuentoCON,
        bool AfectaOfertaCON,
        bool ProductoAcumulativoCON,
        bool LlevaImagenCON,
        decimal UsuarioAdicionaCON,
        DateTime FechaAdicionaCON,
        decimal UsuarioModificaCON,
        DateTime FechaModificaCON,
        DateTime FechaCON,
        string ComentarioCON,
        bool AplicaParaImpuestoCON,
        bool EstatusProductoCON,
        decimal CantidadAgregadaCON,
        string NumeroSeguimientoCON,
        string AccionCON)
        {
        IdProductoDefectuoso = IdProductoDefectuosoCON;
        NumeroConector = NumeroConectorCON;
        IdTipoProducto = IdTipoProductoCON;
        IdCategoria = IdCategoriaCON;
        IdUnidadMedida = IdUnidadMedidaCON;
        IdMarca = IdMarcaCON;
        IdModelo = IdModeloCON;
        IdTipoSuplidor = IdTipoSuplidorCON;
        IdSuplidor = IdSuplidorCON;
        Descripcion = DescripcionCON;
        CodigoBarra = CodigoBarraCON;
        Referencia = ReferenciaCON;
        PrecioCompra = PrecioCompraCON;
        PrecioVenta = PrecioVentaCON;
        Stock = StockCON;
        StockMinimo = StockMinimoCON;
        PorcientoDescuento = PorcientoDescuentoCON;
        AfectaOferta = AfectaOfertaCON;
        ProductoAcumulativo = ProductoAcumulativoCON;
        LlevaImagen = LlevaImagenCON;
        UsuarioAdiciona = UsuarioAdicionaCON;
        FechaAdiciona = FechaAdicionaCON;
        UsuarioModifica = UsuarioModificaCON;
        FechaModifica = FechaModificaCON;
        Fecha = FechaCON;
        Comentario = ComentarioCON;
        AplicaParaImpuesto = AplicaParaImpuestoCON;
        EstatusProducto = EstatusProductoCON;
        CantidadAgregada = CantidadAgregadaCON;
            NumeroSeguimiento = NumeroSeguimientoCON;
        Accion = AccionCON;
    }

        public void ProcesarInformaicon() {
            DSMarket.Logica.Entidades.EntidadesInventario.EProductosDefectuosos Procesar = new Entidades.EntidadesInventario.EProductosDefectuosos();

            Procesar.IdProductoDefectuoso = IdProductoDefectuoso;
            Procesar.NumeroConector = NumeroConector;
            Procesar.IdTipoProducto = IdTipoProducto;
            Procesar.IdCategoria = IdCategoria;
            Procesar.IdUnidadMedida = IdUnidadMedida;
            Procesar.IdMarca = IdMarca;
            Procesar.IdModelo = IdModelo;
            Procesar.IdTipoSuplidor = IdTipoSuplidor;
            Procesar.IdSuplidor = IdSuplidor;
            Procesar.Producto = Descripcion;
            Procesar.CodigoBarra = CodigoBarra;
            Procesar.Referencia = Referencia;
            Procesar.PrecioCompra = PrecioCompra;
            Procesar.PrecioVenta = PrecioVenta;
            Procesar.Stock = Stock;
            Procesar.StockMinimo = StockMinimo;
            Procesar.PorcientoDescuento = PorcientoDescuento;
            Procesar.AfectaOferta0 = AfectaOferta;
            Procesar.ProductoAcumulativo0 = ProductoAcumulativo;
            Procesar.LlevaImagen0 = LlevaImagen;
            Procesar.UsuarioAdiciona = UsuarioAdiciona;
            Procesar.FechaAdiciona = FechaAdiciona;
            Procesar.UsuarioModifica = UsuarioModifica;
            Procesar.FechaModifica = FechaModifica;
            Procesar.Fecha = Fecha;
            Procesar.Comentario = Comentario;
            Procesar.AplicaParaImpuesto0 = AplicaParaImpuesto;
            Procesar.EstatusProducto0 = EstatusProducto;
            Procesar.CantidadAgregada = CantidadAgregada;
            Procesar.NumeroSeguimiento = NumeroSeguimiento;

            var MAN = ObjDataInventario.Value.MantenimientoProductosDefectuoso(Procesar, Accion);

        }

    }
}
