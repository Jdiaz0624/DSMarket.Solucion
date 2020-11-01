using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Entidades.EntidadesEmpresa
{
    public class EPorcientoRetenciones
    {
		public System.Nullable<decimal> IdPorcientoRetencion { get; set; }

		public System.Nullable<decimal> IdRetencion { get; set; }

		public string Retencion { get; set; }

		public System.Nullable<int> Secuencia { get; set; }

		public System.Nullable<decimal> MontoInicial { get; set; }

		public System.Nullable<decimal> MontoFinal { get; set; }

		public System.Nullable<decimal> MontoSumar { get; set; }

		public System.Nullable<decimal> PorcientoCia { get; set; }

		public System.Nullable<decimal> PorcientoEmpleado { get; set; }

		public System.Nullable<bool> Estatus0 { get; set; }

		public string Estatus { get; set; }

		public System.Nullable<decimal> UsuarioAdiciona { get; set; }

		public string CreadoPor { get; set; }

		public System.Nullable<System.DateTime> FechaAdiciona { get; set; }

		public string FechaCreado { get; set; }

		public System.Nullable<decimal> UsuarioModifica { get; set; }

		public string ModificadoPor { get; set; }

		public System.Nullable<System.DateTime> FechaModifica { get; set; }

		public string FechaModificado { get; set; }

		public System.Nullable<int> CantidadRegistros { get; set; }
	}
}
