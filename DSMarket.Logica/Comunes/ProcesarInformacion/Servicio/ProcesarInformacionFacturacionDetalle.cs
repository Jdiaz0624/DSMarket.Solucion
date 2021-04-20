using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes.ProcesarInformacion.Servicio
{
    public class ProcesarInformacionFacturacionDetalle
    {
        readonly DSMarket.Logica.Logica.LogicaServicio.LogicaServicio ObjData = new Logica.LogicaServicio.LogicaServicio();

        private string NumeroConector = "";
        private string Tipo = "";
        private decimal Precio = 0;
        private decimal Descuento = 0;
        private int Cantidad = 0;
        private decimal IdRegistroRespaldo = 0;
        private string NumeroConectorItemRespaldo = "";
        private decimal IdTipoProductoRespaldo = 0;
        private decimal IdCategoriaRespaldo = 0;
        private decimal IdMarcaRespaldo = 0;
        private decimal IdTipoSuplidorRespaldo = 0;
        private decimal IdSuplidorRespaldo = 0;
        private string DescripcionRespaldo = "";
        private string CodigoBarraRespaldo = "";
        private string ReferenciaRespaldo = "";
        private string NumeroSeguimientoRespaldo = "";
        private string CodigoProductoRespaldo = "";
        private decimal PrecioCompraRespaldo = 0;
        private decimal PrecioVentaRespaldo = 0;
        private decimal StockRespaldo = 0;
        private decimal StockMinimoRespaldo = 0;
        private string UnidadMedidaRespaldo = "";
        private string ModeloRespaldo = "";
        private string ColorRespaldo = "";
        private string CondicionRespaldo = "";
        private string CapacidadRespaldo = "";
        private bool AplicaParaImpuestoRespaldo = false;
        private bool TieneImagenRespaldo = false;
        private bool LlevaGarantiaRespaldo = false;
        private decimal IdTipoGarantiaRespaldo = 0;
        private int TiempoGarantiaRespaldo = 0;
        private string ComentarioItemRespaldo = "";
        private decimal UsuarioAdicionaRespaldo = 0;
        private DateTime FechaAdicionaRespaldo = DateTime.Now;
        private decimal UsuarioModificaRespaldo = 0;
        private DateTime FechaModificaRespaldo = DateTime.Now;
        private DateTime FechaIngresoRespaldo = DateTime.Now;
        private string Accion = "";

        public ProcesarInformacionFacturacionDetalle(
            string NumeroConectorCON,
        string TipoCON,
        decimal PrecioCON,
        decimal DescuentoCON,
        int CantidadCON,
        decimal IdRegistroRespaldoCON,
        string NumeroConectorItemRespaldoCON,
        decimal IdTipoProductoRespaldoCON,
        decimal IdCategoriaRespaldoCON,
        decimal IdMarcaRespaldoCON,
        decimal IdTipoSuplidorRespaldoCON,
        decimal IdSuplidorRespaldoCON,
        string DescripcionRespaldoCON,
        string CodigoBarraRespaldoCON,
        string ReferenciaRespaldoCON,
        string NumeroSeguimientoRespaldoCON,
        string CodigoProductoRespaldoCON,
        decimal PrecioCompraRespaldoCON,
        decimal PrecioVentaRespaldoCON,
        decimal StockRespaldoCON,
        decimal StockMinimoRespaldoCON,
        string UnidadMedidaRespaldoCON,
        string ModeloRespaldoCON,
        string ColorRespaldoCON,
        string CondicionRespaldoCON,
        string CapacidadRespaldoCON,
        bool AplicaParaImpuestoRespaldoCON,
        bool TieneImagenRespaldoCON,
        bool LlevaGarantiaRespaldoCON,
        decimal IdTipoGarantiaRespaldoCON,
        int TiempoGarantiaRespaldoCON,
        string ComentarioItemRespaldoCON,
        decimal UsuarioAdicionaRespaldoCON,
        DateTime FechaAdicionaRespaldoCON,
        decimal UsuarioModificaRespaldoCON,
        DateTime FechaModificaRespaldoCON,
        DateTime FechaIngresoRespaldoCON,
        string AccionCON)
        {
            NumeroConector = NumeroConectorCON;
            Tipo = TipoCON;
            Precio = PrecioCON;
            Descuento = DescuentoCON;
            Cantidad = CantidadCON;
            IdRegistroRespaldo = IdRegistroRespaldoCON;
            NumeroConectorItemRespaldo = NumeroConectorItemRespaldoCON;
            IdTipoProductoRespaldo = IdTipoProductoRespaldoCON;
            IdCategoriaRespaldo = IdCategoriaRespaldoCON;
            IdMarcaRespaldo = IdMarcaRespaldoCON;
            IdTipoSuplidorRespaldo = IdTipoSuplidorRespaldoCON;
            IdSuplidorRespaldo = IdSuplidorRespaldoCON;
            DescripcionRespaldo = DescripcionRespaldoCON;
            CodigoBarraRespaldo = CodigoBarraRespaldoCON;
            ReferenciaRespaldo = ReferenciaRespaldoCON;
            NumeroSeguimientoRespaldo = NumeroSeguimientoRespaldoCON;
            CodigoProductoRespaldo = CodigoProductoRespaldoCON;
            PrecioCompraRespaldo = PrecioCompraRespaldoCON;
            PrecioVentaRespaldo = PrecioVentaRespaldoCON;
            StockRespaldo = StockRespaldoCON;
            StockMinimoRespaldo = StockMinimoRespaldoCON;
            UnidadMedidaRespaldo = UnidadMedidaRespaldoCON;
            ModeloRespaldo = ModeloRespaldoCON;
            ColorRespaldo = ColorRespaldoCON;
            CondicionRespaldo = CondicionRespaldoCON;
            CapacidadRespaldo = CapacidadRespaldoCON;
            AplicaParaImpuestoRespaldo = AplicaParaImpuestoRespaldoCON;
            TieneImagenRespaldo = TieneImagenRespaldoCON;
            LlevaGarantiaRespaldo = LlevaGarantiaRespaldoCON;
            IdTipoGarantiaRespaldo = IdTipoGarantiaRespaldoCON;
            TiempoGarantiaRespaldo = TiempoGarantiaRespaldoCON;
            ComentarioItemRespaldo = ComentarioItemRespaldoCON;
            UsuarioAdicionaRespaldo = UsuarioAdicionaRespaldoCON;
            FechaAdicionaRespaldo = FechaAdicionaRespaldoCON;
            UsuarioModificaRespaldo = UsuarioModificaRespaldoCON;
            FechaModificaRespaldo = FechaModificaRespaldoCON;
            FechaIngresoRespaldo = FechaIngresoRespaldoCON;
            Accion = AccionCON;
        }
        /// <summary>
        /// Este metodo es para procesar la informacion de la facturacion en detalle
        /// </summary>
        public void ProcesarInformacion() {

            DSMarket.Logica.Entidades.EntidadesServicio.EFacturacionDetalle Procesar = new Entidades.EntidadesServicio.EFacturacionDetalle();
            Procesar.NumeroConector = NumeroConector;
            Procesar.Tipo = Tipo;
            Procesar.Precio = Precio;
            Procesar.Descuento = Descuento;
            Procesar.Cantidad = Cantidad;
            Procesar.IdRegistroRespaldo = IdRegistroRespaldo;
            Procesar.NumeroConectorItemRespaldo = NumeroConectorItemRespaldo;
            Procesar.IdTipoProductoRespaldo = IdTipoProductoRespaldo;
            Procesar.IdCategoriaRespaldo = IdCategoriaRespaldo;
            Procesar.IdMarcaRespaldo = IdMarcaRespaldo;
            Procesar.IdTipoSuplidorRespaldo = IdTipoSuplidorRespaldo;
            Procesar.IdSuplidorRespaldo = IdSuplidorRespaldo;
            Procesar.DescripcionRespaldo = DescripcionRespaldo;
            Procesar.CodigoBarraRespaldo = CodigoBarraRespaldo;
            Procesar.ReferenciaRespaldo = ReferenciaRespaldo;
            Procesar.NumeroSeguimientoRespaldo = NumeroSeguimientoRespaldo;
            Procesar.CodigoProductoRespaldo = CodigoProductoRespaldo;
            Procesar.PrecioCompraRespaldo = PrecioCompraRespaldo;
            Procesar.PrecioVentaRespaldo = PrecioVentaRespaldo;
            Procesar.StockRespaldo = StockRespaldo;
            Procesar.StockMinimoRespaldo = StockMinimoRespaldo;
            Procesar.UnidadMedidaRespaldo = UnidadMedidaRespaldo;
            Procesar.ModeloRespaldo = ModeloRespaldo;
            Procesar.ColorRespaldo = ColorRespaldo;
            Procesar.CondicionRespaldo = CondicionRespaldo;
            Procesar.CapacidadRespaldo = CapacidadRespaldo;
            Procesar.AplicaParaImpuestoRespaldo = AplicaParaImpuestoRespaldo;
            Procesar.TieneImagenRespaldo = TieneImagenRespaldo;
            Procesar.LlevaGarantiaRespaldo = LlevaGarantiaRespaldo;
            Procesar.IdTipoGarantiaRespaldo = IdTipoGarantiaRespaldo;
            Procesar.TiempoGarantiaRespaldo = TiempoGarantiaRespaldo;
            Procesar.ComentarioItemRespaldo = ComentarioItemRespaldo;
            Procesar.UsuarioAdicionaRespaldo = UsuarioAdicionaRespaldo;
            Procesar.FechaAdicionaRespaldo = FechaAdicionaRespaldo;
            Procesar.UsuarioModificaRespaldo = UsuarioModificaRespaldo;
            Procesar.FechaModificaRespaldo = FechaModificaRespaldo;
            Procesar.FechaIngresoRespaldo = FechaIngresoRespaldo;

            var MAN = ObjData.ProcesarfacturacionDetalle(Procesar, Accion);
        }
    }
}
