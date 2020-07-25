using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes
{
    public  class ProcesarReporteVenta 
    {
        static readonly Lazy<DSMarket.Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion> ObjDataConfiguracion = new Lazy<Logica.LogicaConfiguracion.LogicaCOnfiguracion>();

        private decimal IdUsuario = 0;
        private string Cliente = "";
        private string EstatusFacturacion = "";
        private decimal IdFactura = 0;
        private decimal NumeroConector = 0;
        private decimal IdEstatusFActuracion = 0;
        private string TipoIdentificacion = "";
        private string DescripciomComprobanre = "";
        private string Comprobante = "";
        private decimal IdComprobante = 0;
        private string Descripcion = "";
        private string Telefono = "";
        private string Email = "";
        private decimal IdTipoIdentificacion = 0;
        private string NumeroIdentificacion = "";
        private string Direccion = "";
        private string Comentario = "";
        private decimal IdTipoVenta = 0;
        private string TipoVenta = "";
        private int CantidadDias = 0;
        private int IdCantidadDias = 0;
        private decimal UsuarioVendio = 0;
        private string CreadoPor = "";
        private DateTime FechaFActuracion = DateTime.Now;
        private int CantidadProductos = 0;
        private int CantidadServicios = 0;
        private int CantidadArticulos = 0;
        private decimal TotalDescuento = 0;
        private decimal SubTotal = 0;
        private decimal Impuesto = 0;
        private int PorcientoImpuesto = 0;
        private decimal MontoPagado = 0;
        private decimal Cambio = 0;
        private decimal IdTipoPago = 0;
        private string TipoPago = "";
        private decimal TotalGeneral = 0;
        private string Accion = "";

        //METODO CONSTRUCTOR
        public ProcesarReporteVenta(
            decimal IdUaurioCon,
            string ClienteCon,
            string EstatusFacturacionCon,
            decimal IdFacturaCon,
            decimal NumeroConectorCon,
            decimal IdEstatusFActuracionCon,
            string TipoIdentificacionCon,
            string DescripciomComprobanreCon,
            string ComprobanteCon,
            decimal IdComprobanteCon,
            string DescripcionCon,
            string TelefonoCon,
            string EmailCon,
            decimal IdTipoIdentificacionCon,
            string NumeroIdentificacionCon,
            string DireccionCon,
            string ComentarioCon,
            decimal IdTipoVentaCon,
            string TipoVentaCon,
            int CantidadDiasCon,
            int IdCantidadDiasCon,
            decimal UsuarioVendioCon,
            string CreadoPorCon,
            DateTime FechaFActuracionCon,
            int CantidadProductosCon,
            int CantidadServiciosCon,
            int CantidadArticulosCon,
            decimal TotalDescuentoCon,
            decimal SubTotalCon,
            decimal ImpuestoCon,
            int PorcientoImpuestoCon,
            decimal MontoPagadoCon,
            decimal CambioCon,
            decimal IdTipoPagoCon,
            string TipoPagoCon,
            decimal TotalGeneralCon,
            string AccionCon
             
            )
        {
            IdUsuario = IdUaurioCon;
            Cliente = ClienteCon;
            EstatusFacturacion = EstatusFacturacionCon;
            IdFactura = IdFacturaCon;
            NumeroConector = NumeroConectorCon;
            IdEstatusFActuracion = IdEstatusFActuracionCon;
            TipoIdentificacion = TipoIdentificacionCon;
            DescripciomComprobanre = DescripciomComprobanreCon;
            Comprobante = ComentarioCon;
            IdComprobante = IdComprobanteCon;
            Descripcion = DescripcionCon;
            Telefono = TelefonoCon;
            Email = EmailCon;
            IdTipoIdentificacion = IdTipoIdentificacionCon;
            NumeroIdentificacion = NumeroIdentificacionCon;
            Direccion = DireccionCon;
            Comentario = ComentarioCon;
            IdTipoVenta = IdTipoVentaCon;
            TipoVenta = TipoVentaCon;
            CantidadDias = CantidadDiasCon;
            IdCantidadDias = IdCantidadDiasCon;
            UsuarioVendio = UsuarioVendioCon;
            CreadoPor = CreadoPorCon;
            FechaFActuracion = FechaFActuracionCon;
            CantidadProductos = CantidadProductosCon;
            CantidadServicios = CantidadServiciosCon;
            CantidadArticulos = CantidadArticulosCon;
            TotalDescuento = TotalDescuentoCon;
            SubTotal = SubTotalCon;
            Impuesto = ImpuestoCon;
            PorcientoImpuesto = PorcientoImpuestoCon;
            MontoPagado = MontoPagadoCon;
            Cambio = CambioCon;
            IdTipoPago = IdTipoPagoCon;
            TipoPago = TipoPagoCon;
            TotalGeneral = TotalGeneralCon;
            Accion = AccionCon;
    }

        public void ProcesarInformacion() {
            DSMarket.Logica.Entidades.EntidadesConfiguracion.EGuardarReporteVenta Procesar = new Entidades.EntidadesConfiguracion.EGuardarReporteVenta();

            Procesar.IdUsuario = IdUsuario;
            Procesar.Cliente = Cliente;
            Procesar.EstatusFacturacion = EstatusFacturacion;
            Procesar.IdFactura = IdFactura;
            Procesar.NumeroConector = NumeroConector;
            Procesar.IdEstatusFActuracion = IdEstatusFActuracion;
            Procesar.TipoIdentificacion = TipoIdentificacion;
            Procesar.DescripciomComprobanre = DescripciomComprobanre;
            Procesar.Comprobante = Comprobante;
            Procesar.IdComprobante = IdComprobante;
            Procesar.Descripcion = Descripcion;
            Procesar.Telefono = Telefono;
            Procesar.Email = Email;
            Procesar.IdTipoIdentificacion = IdTipoIdentificacion;
            Procesar.NumeroIdentificacion = NumeroIdentificacion;
            Procesar.Direccion = Direccion;
            Procesar.Comentario = Comentario;
            Procesar.IdTipoVenta = IdTipoVenta;
            Procesar.TipoVenta = TipoVenta;
            Procesar.CantidadDias = CantidadDias;
            Procesar.IdCantidadDias = IdCantidadDias;
            Procesar.UsuarioVendio = UsuarioVendio;
            Procesar.CreadoPor = CreadoPor;
            Procesar.FechaFActuracion = FechaFActuracion;
            Procesar.CantidadProductos = CantidadProductos;
            Procesar.CantidadServicios = CantidadServicios;
            Procesar.CantidadArticulos = CantidadArticulos;
            Procesar.TotalDescuento = TotalDescuento;
            Procesar.SubTotal = SubTotal;
            Procesar.Impuesto = Impuesto;
            Procesar.PorcientoImpuesto = PorcientoImpuesto;
            Procesar.MontoPagado = MontoPagado;
            Procesar.Cambio = Cambio;
            Procesar.IdTipoPago = IdTipoPago;
            Procesar.TipoPago = TipoPago;
            Procesar.TotalGeneral = TotalGeneral;

            var MAN = ObjDataConfiguracion.Value.GuardarReporteVenta(Procesar, Accion);
        }

    }
}
