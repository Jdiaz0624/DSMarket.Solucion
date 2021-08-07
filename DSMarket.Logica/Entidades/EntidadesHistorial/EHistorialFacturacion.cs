using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Entidades.EntidadesHistorial
{
    public class EHistorialFacturacion
    {
		public decimal NumeroFactura {get;set;}

		public string NumeroConector {get;set;}

		public string FacturadoA {get;set;}

		public System.Nullable<decimal> CodigoCliente {get;set;}

		public decimal IdTipoFacturacion {get;set;}

		public string TipoFacturacion {get;set;}

		public string Comentario {get;set;}

		public System.Nullable<int> TotalProductos {get;set;}

		public System.Nullable<int> TotalServicios {get;set;}

		public System.Nullable<int> TotalItems {get;set;}

		public System.Nullable<decimal> SubTotal {get;set;}

		public System.Nullable<decimal> DescuentoTotal {get;set;}

		public System.Nullable<decimal> ImpuestoTotal {get;set;}

		public System.Nullable<decimal> TotalGeneral {get;set;}

		public System.Nullable<decimal> IdTipoPago {get;set;}

		public string TipoPago {get;set;}

		public System.Nullable<decimal> MontoPagado {get;set;}

		public System.Nullable<decimal> Cambio {get;set;}

		public System.Nullable<decimal> IdMoneda {get;set;}

		public string Moneda {get;set;}

		public System.Nullable<decimal> Tasa {get;set;}

		public System.Nullable<decimal> IdUsuario {get;set;}

		public string CreadoPor {get;set;}

		public System.Nullable<System.DateTime> FechaFacturacion0 {get;set;}

		public string FechaFacturacion {get;set;}

		public string Hora { get; set; }

		public System.Nullable<decimal> IdComprobante {get;set;}

		public string NCF {get;set;}

		public string ValidoHasta {get;set;}

		public string NumeroComprobante {get;set;}

		public System.Nullable<decimal> CapitalInvertido {get;set;}

		public System.Nullable<decimal> GananciaVenta {get;set;}

		public System.Nullable<decimal> Ganancia { get; set; }
	}
}
