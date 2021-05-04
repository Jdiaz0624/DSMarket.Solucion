using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Entidades.EntidadesHistorial
{
    public class EProcesarInformacionHistorialCotizaciones
    {
		public System.Nullable<decimal> IdUsuario {get;set;}

		public System.Nullable<decimal> NumeroCotizacion {get;set;}

		public string CotizadoA {get;set;}

		public System.Nullable<System.DateTime> FechaCotizacion {get;set;}

		public System.Nullable<int> TotalProductos {get;set;}

		public System.Nullable<int> TotalServicios {get;set;}

		public System.Nullable<int> TotalItems {get;set;}

		public System.Nullable<decimal> SubTotal {get;set;}

		public System.Nullable<decimal> Descuento {get;set;}

		public System.Nullable<decimal> Impuesto {get;set;}

		public System.Nullable<decimal> Total {get;set;}

		public System.Nullable<decimal> IdMoneda {get;set;}

		public System.Nullable<decimal> Tasa {get;set;}
	}
}
