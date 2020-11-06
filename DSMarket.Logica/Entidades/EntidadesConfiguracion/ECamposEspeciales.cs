using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Entidades.EntidadesConfiguracion
{
    public class ECamposEspeciales
    {
		public System.Nullable<decimal> IdCampoEspecial { get; set; }

		public string Nombre { get; set; }

		public System.Nullable<int> LongitudCampo { get; set; }

		public System.Nullable<bool> Estatus0 { get; set; }

		public string Estatus { get; set; }
	}
}
