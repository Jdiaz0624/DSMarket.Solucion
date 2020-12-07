using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Entidades.EntidadesEmpresa
{
    public class ECitasDetalle
    {
		public System.Nullable<decimal> NumeroConectorCita { get; set; }

		public System.Nullable<decimal> IdProducto { get; set; }

		public System.Nullable<decimal> Precio { get; set; }

		public string DescripcionProducto { get; set; }

		public System.Nullable<int> CantidadRegistros { get; set; }

		public System.Nullable<decimal> Total { get; set; }
	}
}
