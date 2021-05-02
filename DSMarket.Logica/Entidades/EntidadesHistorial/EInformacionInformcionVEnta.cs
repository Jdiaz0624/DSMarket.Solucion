using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Entidades.EntidadesHistorial
{
    public class EInformacionInformcionVEnta
    {
		public System.Nullable<decimal> IdUsuario {get;set;}

		public System.Nullable<decimal> NumeroFActura {get;set;}
		public System.Nullable<decimal> IdTipoFacturacion { get; set; }

		public string NumeroConector {get;set;}
		public string FacturadoA { get; set; }

		public string NCF {get;set;}

		public System.Nullable<System.DateTime> FechaFActuracion {get;set;}

		public System.Nullable<int> TotalProductos {get;set;}

		public System.Nullable<int> TotalServicios {get;set;}

		public System.Nullable<int> TotalItems {get;set;}

		public System.Nullable<decimal> SubTotal {get;set;}

		public System.Nullable<decimal> Descuento {get;set;}

		public System.Nullable<decimal> Impuesto {get;set;}

		public System.Nullable<decimal> Total {get;set;}

		public System.Nullable<decimal> IdTipoPago {get;set;}

		public System.Nullable<decimal> MontoPagado {get;set;}

		public System.Nullable<decimal> Cambio {get;set;}

		public System.Nullable<decimal> IdMoneda {get;set;}

		public System.Nullable<decimal> Tasa {get;set;}
	}
}
