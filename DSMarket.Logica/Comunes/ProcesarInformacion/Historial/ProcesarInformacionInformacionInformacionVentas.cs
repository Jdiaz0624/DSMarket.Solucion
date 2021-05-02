using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes.ProcesarInformacion.Historial
{
    public class ProcesarInformacionInformacionInformacionVentas
    {
        readonly DSMarket.Logica.Logica.LogicaHistorial.LogicaHistorial ObjData = new Logica.LogicaHistorial.LogicaHistorial();

        private decimal IdUsuario = 0;
        private decimal NumeroFActura = 0;
        private decimal IdTipoFacturacion = 0;
        private string NumeroConector = "";
        private string FacturadoA = "";
        private string NCF = "";
        private DateTime FechaFActuracion = DateTime.Now;
        private int TotalProductos = 0;
        private int TotalServicios = 0;
        private int TotalItems = 0;
        private decimal SubTotal = 0;
        private decimal Descuento = 0;
        private decimal Impuesto = 0;
        private decimal Total = 0;
        private decimal IdTipoPago = 0;
        private decimal MontoPagado = 0;
        private decimal Cambio = 0;
        private decimal IdMoneda = 0;
        private decimal Tasa = 0;
        private string Accion = "";

        public ProcesarInformacionInformacionInformacionVentas(
        decimal IdUsuarioCON,
        decimal NumeroFActuraCON,
        decimal IdTipoFacturacionCON,
        string NumeroConectorCON,
        string FacturadoACON,
        string NCFCON,
        DateTime FechaFActuracionCON,
        int TotalProductosCON,
        int TotalServiciosCON,
        int TotalItemsCON,
        decimal SubTotalCON,
        decimal DescuentoCON,
        decimal ImpuestoCON,
        decimal TotalCON,
        decimal IdTipoPagoCON,
        decimal MontoPagadoCON,
        decimal CambioCON,
        decimal IdMonedaCON,
        decimal TasaCON,
        string AccionCON)
        {
            IdUsuario = IdUsuarioCON;
            NumeroFActura = NumeroFActuraCON;
            IdTipoFacturacion = IdTipoFacturacionCON;
            NumeroConector = NumeroConectorCON;
            FacturadoA = FacturadoACON;
            NCF = NCFCON;
            FechaFActuracion = FechaFActuracionCON;
            TotalProductos = TotalProductosCON;
            TotalServicios = TotalServiciosCON;
            TotalItems = TotalItemsCON;
            SubTotal = SubTotalCON;
            Descuento = DescuentoCON;
            Impuesto = ImpuestoCON;
            Total = TotalCON;
            IdTipoPago = IdTipoPagoCON;
            MontoPagado = MontoPagadoCON;
            Cambio = CambioCON;
            IdMoneda = IdMonedaCON;
            Tasa = TasaCON;
            Accion = AccionCON;
        }

        /// <summary>
        /// Procesar la informacion de las ventas
        /// </summary>
        public void ProcesarInformacion() {
            DSMarket.Logica.Entidades.EntidadesHistorial.EInformacionInformcionVEnta Procesar = new Entidades.EntidadesHistorial.EInformacionInformcionVEnta();

            Procesar.IdUsuario = IdUsuario;
            Procesar.NumeroFActura = NumeroFActura;
            Procesar.IdTipoFacturacion = IdTipoFacturacion;
            Procesar.NumeroConector = NumeroConector;
            Procesar.FacturadoA = FacturadoA;
            Procesar.NCF = NCF;
            Procesar.FechaFActuracion = FechaFActuracion;
            Procesar.TotalProductos = TotalProductos;
            Procesar.TotalServicios = TotalServicios;
            Procesar.TotalItems = TotalItems;
            Procesar.SubTotal = SubTotal;
            Procesar.Descuento = Descuento;
            Procesar.Impuesto = Impuesto;
            Procesar.Total = Total;
            Procesar.IdTipoPago = IdTipoPago;
            Procesar.MontoPagado = MontoPagado;
            Procesar.Cambio = Cambio;
            Procesar.IdMoneda = IdMoneda;
            Procesar.Tasa = Tasa;

            var MAN = ObjData.InformacionInformacionVenta(Procesar, Accion);
        }
    }
}
