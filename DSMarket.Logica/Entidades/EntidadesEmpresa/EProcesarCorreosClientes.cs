using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Entidades.EntidadesEmpresa
{
    public class EProcesarCorreosClientes
    {
		public System.Nullable<decimal> IdRegistro { get; set; }

		public System.Nullable<decimal> IdUsuario { get; set; }

		public System.Nullable<decimal> IdCliente { get; set; }

		public string Cliente { get; set; }

		public string Correo { get; set; }
	}
}
