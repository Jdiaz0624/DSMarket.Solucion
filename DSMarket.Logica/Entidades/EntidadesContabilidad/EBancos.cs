using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Entidades.EntidadesContabilidad
{
    public class EBancos
    {
		public int? IdBanco { get; set; }

		public string Banco { get; set; }

		public System.Nullable<bool> Estatus0 { get; set; }

		public string Estatus { get; set; }

		public System.Nullable<bool> PorDefecto0 { get; set; }

		public string PorDefecto { get; set; }
	}
}
