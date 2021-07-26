using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Entidades.EntidadesConfiguracion
{
    public class ECompaniaUso
    {
		public int? IdRegistro { get; set; }

		public System.Nullable<int> IdCompania { get; set; }

		public string Nombre { get; set; }

		public string RazonSocial { get; set; }

		public string Direccion { get; set; }

		public string Telefono { get; set; }
	}
}
