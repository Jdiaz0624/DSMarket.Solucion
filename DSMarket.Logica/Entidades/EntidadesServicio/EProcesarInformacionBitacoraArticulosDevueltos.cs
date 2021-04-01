using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Entidades.EntidadesServicio
{
    public class EProcesarInformacionBitacoraArticulosDevueltos
    {
		public System.Nullable<decimal> IdBitacora { get; set; }

		public System.Nullable<decimal> NumeroFactura { get; set; }

		public System.Nullable<System.DateTime> FechaFactura { get; set; }

		public System.Nullable<int> CantidadArticulos { get; set; }
	}
}
