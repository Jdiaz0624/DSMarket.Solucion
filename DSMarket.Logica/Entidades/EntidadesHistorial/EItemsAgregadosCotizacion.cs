using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Entidades.EntidadesHistorial
{
    public class EItemsAgregadosCotizacion
    {
		public System.Nullable<decimal> NumeroCotizacion { get; set; }

		public string NumeroConector { get; set; }

		public string CotizacoA { get; set; }

		public string FechaCotizacion { get; set; }

		public System.Nullable<int> TotalProductos { get; set; }

		public System.Nullable<int> TotalServicios { get; set; }

		public System.Nullable<int> TotalItems { get; set; }

		public string DescripcionRespaldo { get; set; }

		public System.Nullable<decimal> IdTipoProductoRespaldo { get; set; }
		public string TipoProducto { get; set; }

		public System.Nullable<decimal> Precio { get; set; }

		public System.Nullable<decimal> Descuento { get; set; }

		public System.Nullable<int> Cantidad { get; set; }

		public System.Nullable<decimal> SubTotal { get; set; }

		public System.Nullable<decimal> Impuesto { get; set; }

		public System.Nullable<decimal> Total { get; set; }
	}
}
