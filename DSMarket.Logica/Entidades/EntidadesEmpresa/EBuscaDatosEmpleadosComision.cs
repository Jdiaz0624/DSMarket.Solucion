using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Entidades.EntidadesEmpresa
{
    public class EBuscaDatosEmpleadosComision
    {
        public decimal? IdEmpleado { get; set; }

        public string Nombre { get; set; }

        public System.Nullable<decimal> PorcientoCOmisionVentas { get; set; }

        public System.Nullable<decimal> PorcientoComsiionServicio { get; set; }
    }
}
