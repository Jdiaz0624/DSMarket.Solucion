using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Entidades.EntidadesServicio
{
    public class EFacturacionPreview
    {
		public System.Nullable<decimal> IdUsuario { get; set; }

		public string NumeroConector { get; set; }

		public System.Nullable<decimal> IdProducto { get; set; }

		public System.Nullable<decimal> IdTipoProducto { get; set; }

		public System.Nullable<decimal> Precio { get; set; }

		public System.Nullable<decimal> DescuentoAplicado { get; set; }

		public System.Nullable<decimal> Cantidad { get; set; }

		public System.Nullable<decimal> SubTotal { get; set; }

		public System.Nullable<decimal> Impuesto { get; set; }

		public System.Nullable<decimal> Total { get; set; }

		public System.Nullable<int> TotalProdctos { get; set; }

		public System.Nullable<int> TotalServicios { get; set; }

		public System.Nullable<int> TotalItems { get; set; }

		public System.Nullable<decimal> SubTotal1 { get; set; }

		public System.Nullable<decimal> TotalDescuento { get; set; }

		public System.Nullable<decimal> TotalImpuesto { get; set; }

		public System.Nullable<decimal> TotalGeneral { get; set; }
	}
}
