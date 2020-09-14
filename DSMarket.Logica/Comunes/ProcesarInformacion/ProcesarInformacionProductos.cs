using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes.ProcesarInformacion
{
    public class ProcesarInformacionProductos
    {
        readonly DSMarket.Logica.Logica.LogicaInventario.LogicaInventario ObjData = new Logica.LogicaInventario.LogicaInventario();

        private decimal IdProducto = 0;
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
        private decimal UsuarioAdicion = 0;
        private DateTime FechaAdiciona = DateTime.Now;
        private decimal UsuarioModifica = 0;
        private DateTime FechaModifica = DateTime.Now;
        private DateTime Fecha = DateTime.Now;
        private string Comentario = "";
        private bool AplicaParaImpuesto = false;
        private bool EstatusProducto = false;
        private string NumeroSeguimiento = "";
        private decimal IdColor = 0;
        private decimal IdCondicion = 0;
        private decimal IdCapacidad = 0;
        private string Accion = "";

        public ProcesarInformacionProductos(
        decimal IdProductoCON,
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
        decimal UsuarioAdicionCON,
        DateTime FechaAdicionaCON,
        decimal UsuarioModificaCON,
        DateTime FechaModificaCON,
        DateTime FechaCON,
        string ComentarioCON,
        bool AplicaParaImpuestoCON,
        bool EstatusProductoCON,
        string NumeroSeguimientoCON,
        decimal IdColorCON,
        decimal IdCondicionCON,
        decimal IdCapacidadCON,
        string AccionCON)
        {
            IdProducto = IdProductoCON;
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
            UsuarioAdicion = UsuarioAdicionCON;
            FechaAdiciona = FechaAdicionaCON;
            UsuarioModifica = UsuarioModificaCON;
            FechaModifica = FechaModificaCON;
             Fecha = FechaCON;
            Comentario = ComentarioCON;
            AplicaParaImpuesto = AplicaParaImpuestoCON;
            EstatusProducto = EstatusProductoCON;
            NumeroSeguimiento = NumeroSeguimientoCON;
            IdColor = IdColorCON;
            IdCondicion = IdCondicionCON;
            IdCapacidad = IdCapacidadCON;
            Accion = AccionCON;
        }

        public void ProcesarInformacion() {
            DSMarket.Logica.Entidades.EntidadesInventario.EProducto Procesar = new Entidades.EntidadesInventario.EProducto();

            Procesar.IdProducto = IdProducto;
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
            Procesar.UsuarioAdicion = UsuarioAdicion;
            Procesar.FechaAdiciona = FechaAdiciona;
            Procesar.UsuarioModifica = UsuarioModifica;
            Procesar.FechaModifica = FechaModifica;
            Procesar.Fecha = Fecha;
            Procesar.Comentario = Comentario;
            Procesar.AplicaParaImpuesto0 = AplicaParaImpuesto;
            Procesar.EstatusProducto0 = EstatusProducto;
            Procesar.NumeroSeguimiento = NumeroSeguimiento;
            Procesar.IdColor = IdColor;
            Procesar.IdCondicion = IdCondicion;
            Procesar.IdCapacidad = IdCapacidad;

            var MAn = ObjData.MantenimientoProducto(Procesar, Accion);

        }
    }
}
