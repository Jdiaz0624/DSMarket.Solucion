using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Entidades.EntidadesConfiguracion
{
    public class EGuardarReporteVenta
    {
        public System.Nullable<decimal> IdUsuario{get;set;}

        public string Cliente{get;set;}

        public string EstatusFacturacion{get;set;}

        public System.Nullable<decimal> IdFactura{get;set;}

        public System.Nullable<decimal> NumeroConector{get;set;}

        public System.Nullable<decimal> IdEstatusFActuracion{get;set;}

        public string TipoIdentificacion{get;set;}

        public string DescripciomComprobanre{get;set;}

        public string Comprobante{get;set;}

        public System.Nullable<decimal> IdComprobante{get;set;}

        public string Descripcion{get;set;}

        public string Telefono{get;set;}

        public string Email{get;set;}

        public System.Nullable<decimal> IdTipoIdentificacion{get;set;}

        public string NumeroIdentificacion{get;set;}

        public string Direccion{get;set;}

        public string Comentario{get;set;}

        public System.Nullable<decimal> IdTipoVenta{get;set;}

        public string TipoVenta{get;set;}

        public System.Nullable<int> CantidadDias{get;set;}

        public System.Nullable<int> IdCantidadDias{get;set;}

        public System.Nullable<decimal> UsuarioVendio{get;set;}

        public string CreadoPor{get;set;}

        public System.Nullable<System.DateTime> FechaFActuracion{get;set;}

        public System.Nullable<decimal> CantidadProductos{get;set;}

        public System.Nullable<decimal> CantidadServicios{get;set;}

        public System.Nullable<decimal> CantidadArticulos{get;set;}

        public System.Nullable<decimal> TotalDescuento{get;set;}

        public System.Nullable<decimal> SubTotal{get;set;}

        public System.Nullable<decimal> Impuesto{get;set;}

        public System.Nullable<int> PorcientoImpuesto{get;set;}

        public System.Nullable<decimal> MontoPagado{get;set;}

        public System.Nullable<decimal> Cambio{get;set;}

        public System.Nullable<decimal> IdTipoPago{get;set;}

        public string TipoPago{get;set;}

        public System.Nullable<decimal> TotalGeneral{get;set;}
    }
}
