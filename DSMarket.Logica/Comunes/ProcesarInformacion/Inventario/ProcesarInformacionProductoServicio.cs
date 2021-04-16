using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes.ProcesarInformacion.Inventario
{
    public class ProcesarInformacionProductoServicio
    {
        readonly DSMarket.Logica.Logica.LogicaInventario.LogicaInventario ObjData = new Logica.LogicaInventario.LogicaInventario();

        private decimal IdRegistro = 0;
        private string NumeroConector = "";
        private decimal IdTipoProducto = 0;
        private decimal IdCategoria = 0;
        private decimal IdMarca = 0;
        private decimal IdTipoSuplidor = 0;
        private decimal IdSuplidor = 0;
        private string Descripcion = "";
        private string CodigoBarra = "";
        private string Referencia = "";
        private string NumeroSeguimiento = "";
        private string CodigoProducto = "";
        private decimal PrecioCompra = 0;
        private decimal PrecioVenta = 0;
        private decimal Stock = 0;
        private decimal StockMinimo = 0;
        private string UnidadMedida = "";
        private string Modelo = "";
        private string Color = "";
        private string Condicion = "";
        private string Capacidad = "";
        private bool AplicaParaImpuesto = false;
        private bool TieneImagen = false;
        private bool LlevaGarantia = false;
        private decimal IdTipoGarantia = 0;
        private int TiempoGarantia = 0;
        private string Comentario = "";
        private decimal IdUsuario = 0;
        private string Accion = "";

        public ProcesarInformacionProductoServicio(
            decimal IdRegistroCON,
        string NumeroConectorCON,
        decimal IdTipoProductoCON,
        decimal IdCategoriaCON,
        decimal IdMarcaCON,
        decimal IdTipoSuplidorCON,
        decimal IdSuplidorCON,
        string DescripcionCON,
        string CodigoBarraCON,
        string ReferenciaCON,
        string NumeroSeguimientoCON,
        string CodigoProductoCON,
        decimal PrecioCompraCON,
        decimal PrecioVentaCON,
        decimal StockCON,
        decimal StockMinimoCON,
        string UnidadMedidaCON,
        string ModeloCON,
        string ColorCON,
        string CondicionCON,
        string CapacidadCON,
        bool AplicaParaImpuestoCON,
        bool TieneImagenCON,
        bool LlevaGarantiaCON,
        decimal IdTipoGarantiaCON,
        int TiempoGarantiaCON,
        string ComentarioCON,
        decimal IdUsuarioCON,
        string AccionCON)
        {
            IdRegistro = IdRegistroCON;
            NumeroConector = NumeroConectorCON;
            IdTipoProducto = IdTipoProductoCON;
            IdCategoria = IdCategoriaCON;
            IdMarca = IdMarcaCON;
            IdTipoSuplidor = IdTipoSuplidorCON;
            IdSuplidor = IdSuplidorCON;
            Descripcion = DescripcionCON;
            CodigoBarra = CodigoBarraCON;
            Referencia = ReferenciaCON;
            NumeroSeguimiento = NumeroSeguimientoCON;
            CodigoProducto = CodigoProductoCON;
            PrecioCompra = PrecioCompraCON;
            PrecioVenta = PrecioVentaCON;
            Stock = StockCON;
            StockMinimo = StockMinimoCON;
            UnidadMedida = UnidadMedidaCON;
            Modelo = ModeloCON;
             Color = ColorCON;
            Condicion = CondicionCON;
            Capacidad = CapacidadCON;
            AplicaParaImpuesto = AplicaParaImpuestoCON;
            TieneImagen = TieneImagenCON;
            LlevaGarantia = LlevaGarantiaCON;
            IdTipoGarantia = IdTipoGarantiaCON;
            TiempoGarantia = TiempoGarantiaCON;
            Comentario = ComentarioCON;
            IdUsuario = IdUsuarioCON;
            Accion = AccionCON;
        }

        /// <summary>
        /// Este metodo es para procesar la informacion de los productos y servicios
        /// </summary>
        public void ProcesarInformacion() {
            DSMarket.Logica.Entidades.EntidadesInventario.EProductosServicios Procesar = new Entidades.EntidadesInventario.EProductosServicios();

            Procesar.IdRegistro = IdRegistro;
            Procesar.NumeroConector = NumeroConector;
            Procesar.IdTipoProducto = IdTipoProducto;
            Procesar.IdCategoria = IdCategoria;
            Procesar.IdMarca = IdMarca;
            Procesar.IdTipoSuplidor = IdTipoSuplidor;
            Procesar.IdSuplidor = IdSuplidor;
            Procesar.Descripcion = Descripcion;
            Procesar.CodigoBarra = CodigoBarra;
            Procesar.Referencia = Referencia;
            Procesar.NumeroSeguimiento = NumeroSeguimiento;
            Procesar.CodigoProducto = CodigoProducto;
            Procesar.PrecioCompra = PrecioCompra;
            Procesar.PrecioVenta = PrecioVenta;
            Procesar.Stock = Stock;
            Procesar.StockMinimo = StockMinimo;
            Procesar.UnidadMedida = UnidadMedida;
            Procesar.Modelo = Modelo;
            Procesar.Color = Color;
            Procesar.Condicion = Condicion;
            Procesar.Capacidad = Capacidad;
            Procesar.AplicaParaImpuesto0 = AplicaParaImpuesto;
            Procesar.TieneImagen0 = TieneImagen;
            Procesar.LlevaGarantia0 = LlevaGarantia;
            Procesar.IdTipoGarantia = IdTipoGarantia;
            Procesar.TiempoGarantia = TiempoGarantia;
            Procesar.Comentario = Comentario;
            Procesar.UsuarioAdiciona = IdUsuario;
            Procesar.FechaAdiciona0 = DateTime.Now;
            Procesar.UsuarioModifica = IdUsuario;
            Procesar.FechaModifica0 = DateTime.Now;
            Procesar.FechaIngreso0 = DateTime.Now;

            var MAn = ObjData.ProcesarProductosServicios(Procesar, Accion);
        }
    }
}
