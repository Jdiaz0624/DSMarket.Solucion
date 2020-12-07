using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Entidades.EntidadesEmpresa
{
    public class ECitasEncabezado
    {
		public decimal? IdCitas { get; set; }

		public System.Nullable<decimal> IdEmpleado { get; set; }

		public string Empleado { get; set; }

		public System.Nullable<System.DateTime> FechaCita0 { get; set; }

		public string FechaCita { get; set; }

		public string Hora { get; set; }

		public string NombreCliente { get; set; }

		public string Telefono { get; set; }

		public string Direccion { get; set; }

		public string NumeroIdentificacion { get; set; }

		public System.Nullable<decimal> NumeroConectorCita { get; set; }

		public System.Nullable<bool> Estatus0 { get; set; }

		public string Estatus { get; set; }
	}
}
