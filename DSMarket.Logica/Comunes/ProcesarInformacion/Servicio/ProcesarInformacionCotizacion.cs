using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes.ProcesarInformacion.Servicio
{
    public class ProcesarInformacionCotizacion
    {
        readonly DSMarket.Logica.Logica.LogicaServicio.LogicaServicio ObjData = new Logica.LogicaServicio.LogicaServicio();

        private decimal NumeroCotizacion = 0;
        private string NumeroConector = "";
        private string CotizacoA = "";
        private decimal CodigoCliente = 0;
        private decimal IdTipoFacturacion = 0;
        private string Comentario = "";
        private int TotalProductos = 0;
        private int TotalServicios = 0;
        private int TotalItems = 0;
        private decimal SubTotal = 0;
        private decimal DescuentoTotal = 0;
        private decimal ImpuestoTotal = 0;
        private decimal TotalGeneral = 0;
        private decimal IdTipoPago = 0;
        private decimal MontoPagado = 0;
        private decimal Cambio = 0;
        private decimal IdMoneda = 0;
        private decimal Tasa = 0;
        private decimal IdUsuario = 0;
        private DateTime FechaCotizacion = DateTime.Now;
        private string Accion = "";

        public ProcesarInformacionCotizacion(
            decimal NumeroCotizacionCON,
            string NumeroConectorCON,
            string CotizacoACON,
            decimal CodigoClienteCON,
            decimal IdTipoFacturacionCON,
            string ComentarioCON,
            int TotalProductosCON,
            int TotalServiciosCON,
            int TotalItemsCON,
            decimal SubTotalCON,
            decimal DescuentoTotalCON,
            decimal ImpuestoTotalCON,
            decimal TotalGeneralCON,
            decimal IdTipoPagoCON,
            decimal MontoPagadoCON,
            decimal CambioCON,
            decimal IdMonedaCON,
            decimal TasaCON,
            decimal IdUsuarioCON,
            DateTime FechaCotizacionCON,
            string AccionCON)
        {
            NumeroCotizacion = NumeroCotizacionCON;
            NumeroConector = NumeroConectorCON;
            CotizacoA = CotizacoACON;
            CodigoCliente = CodigoClienteCON;
            IdTipoFacturacion = IdTipoFacturacionCON;
            Comentario = ComentarioCON;
            TotalProductos = TotalProductosCON;
            TotalServicios = TotalServiciosCON;
            TotalItems = TotalItemsCON;
            SubTotal = SubTotalCON;
            DescuentoTotal = DescuentoTotalCON;
            ImpuestoTotal = ImpuestoTotalCON;
            TotalGeneral = TotalGeneralCON;
            IdTipoPago = IdTipoPagoCON;
            MontoPagado = MontoPagadoCON;
            Cambio = CambioCON;
            IdMoneda = IdMonedaCON;
            Tasa = TasaCON;
            IdUsuario = IdUsuarioCON;
            FechaCotizacion = FechaCotizacionCON;
            Accion = AccionCON;
        }
        /// <summary>
        /// Procesar la información de la cotización
        /// </summary>
        public void ProcesarInformacion() {
            DSMarket.Logica.Entidades.EntidadesServicio.ECotizacion Procesar = new Entidades.EntidadesServicio.ECotizacion();

            Procesar.NumeroCotizacion = NumeroCotizacion;
            Procesar.NumeroConector = NumeroConector;
            Procesar.CotizacoA = CotizacoA;
            Procesar.CodigoCliente = CodigoCliente;
            Procesar.IdTipoFacturacion = IdTipoFacturacion;
            Procesar.Comentario = Comentario;
            Procesar.TotalProductos = TotalProductos;
            Procesar.TotalServicios = TotalServicios;
            Procesar.TotalItems = TotalItems;
            Procesar.SubTotal = SubTotal;
            Procesar.DescuentoTotal = DescuentoTotal;
            Procesar.ImpuestoTotal = ImpuestoTotal;
            Procesar.TotalGeneral = TotalGeneral;
            Procesar.IdTipoPago = IdTipoPago;
            Procesar.MontoPagado = MontoPagado;
            Procesar.Cambio = Cambio;
            Procesar.IdMoneda = IdMoneda;
            Procesar.Tasa = Tasa;
            Procesar.IdUsuario = IdUsuario;
            Procesar.FechaCotizacion = FechaCotizacion;

            var MAN = ObjData.ProcesarCotizacion(Procesar, Accion);
        
        }
    }
}
