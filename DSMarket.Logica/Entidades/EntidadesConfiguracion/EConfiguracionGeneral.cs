using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Entidades.EntidadesConfiguracion
{
    public class EConfiguracionGeneral
    {
		public System.Nullable<decimal> IdConfiguracion { get; set; }

		public System.Nullable<decimal> IdModulo { get; set; }

		public string Modulo { get; set; }

		public string Descripcion { get; set; }

		public System.Nullable<bool> Estatus0 { get; set; }

		public string Estatus { get; set; }
	}
}
