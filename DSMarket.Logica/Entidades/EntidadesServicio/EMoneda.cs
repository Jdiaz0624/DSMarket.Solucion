using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Entidades.EntidadesServicio
{
    public class EMoneda
    {
		public System.Nullable<decimal> IdMoneda { get; set; }

		public string Moneda { get; set; }

		public string Sigla { get; set; }

		public System.Nullable<bool> Estatus0 { get; set; }

		public string Estatus { get; set; }

		public System.Nullable<decimal> Tasa { get; set; }

		public System.Nullable<decimal> UsuarioAdiciona { get; set; }

		public string CreadoPor { get; set; }

		public System.Nullable<System.DateTime> FechaAdiciona { get; set; }

		public string FechaCreado { get; set; }

		public System.Nullable<decimal> UsuarioModifica { get; set; }

		public string ModificadoPor { get; set; }

		public System.Nullable<System.DateTime> FechaModifica { get; set; }

		public string FechaModificado { get; set; }

		public System.Nullable<bool> PorDefecto0 { get; set; }

		public string PorDefecto { get; set; }
	}
}
