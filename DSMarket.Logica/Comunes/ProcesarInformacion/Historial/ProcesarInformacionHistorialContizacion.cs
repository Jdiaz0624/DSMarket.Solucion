using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes.ProcesarInformacion.Historial
{
    public class ProcesarInformacionHistorialContizacion
    {
        readonly DSMarket.Logica.Logica.LogicaHistorial.LogicaHistorial Historial = new Logica.LogicaHistorial.LogicaHistorial();

        private decimal IdUsuario = 0;
        private decimal NumeroCotizacion = 0;
        private string CotizadoA = "";
        private DateTime FechaCotizacion = DateTime.Now;
        private int TotalProductos = 0;
        private int TotalServicios = 0;
        private int TotalItems = 0;
        private decimal SubTotal = 0;
        private decimal Descuento = 0;
        private decimal Impuesto = 0;
        private decimal Total = 0;
        private decimal IdMoneda = 0;
        private decimal Tasa = 0;
        private string Accion = "";

        public ProcesarInformacionHistorialContizacion(
            decimal IdUsuarioCON,
            decimal NumeroCotizacionCON,
            string CotizadoACON,
            DateTime FechaCotizacionCON,
            int TotalProductosCON,
            int TotalServiciosCON,
            int TotalItemsCON,
            decimal SubTotalCON,
            decimal DescuentoCON,
            decimal ImpuestoCON,
            decimal TotalCON,
            decimal IdMonedaCON,
            decimal TasaCON,
            string AccionCON)
        {
            IdUsuario = IdUsuarioCON;
            NumeroCotizacion = NumeroCotizacionCON;
            CotizadoA = CotizadoACON;
            FechaCotizacion = FechaCotizacionCON;
            TotalProductos = TotalProductosCON;
            TotalServicios = TotalServiciosCON;
            TotalItems = TotalItemsCON;
            SubTotal = SubTotalCON;
            Descuento = DescuentoCON;
            Impuesto = ImpuestoCON;
            Total = TotalCON;
            IdMoneda = IdMonedaCON;
            Tasa = TasaCON;
            Accion = AccionCON;
        }

        public void ProcesarInformacion() {
            DSMarket.Logica.Entidades.EntidadesHistorial.EProcesarInformacionHistorialCotizaciones Procesar = new Entidades.EntidadesHistorial.EProcesarInformacionHistorialCotizaciones();

            Procesar.IdUsuario = IdUsuario;
            Procesar.NumeroCotizacion = NumeroCotizacion;
            Procesar.CotizadoA = CotizadoA;
            Procesar.FechaCotizacion = FechaCotizacion;
            Procesar.TotalProductos = TotalProductos;
            Procesar.TotalServicios = TotalServicios;
            Procesar.TotalItems = TotalItems;
            Procesar.SubTotal = SubTotal;
            Procesar.Descuento = Descuento;
            Procesar.Impuesto = Impuesto;
            Procesar.Total = Total;
            Procesar.IdMoneda = IdMoneda;
            Procesar.Tasa = Tasa;

            var MAN = Historial.ProcesarHistorialCotizaciones(Procesar, Accion);
        }
    }
}
