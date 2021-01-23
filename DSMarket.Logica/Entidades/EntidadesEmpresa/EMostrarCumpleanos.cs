using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Entidades.EntidadesEmpresa
{
    public class EMostrarCumpleanos
    {
		public decimal? CodigoCliente { get; set; }

		public string Cliente { get; set; }

		public string FechaNacimiento { get; set; }

		public string Edad { get; set; }

		public string MesNacimiento { get; set; }

		public string MesActual { get; set; }

		public string Cumpleanos { get; set; }
	}
}
