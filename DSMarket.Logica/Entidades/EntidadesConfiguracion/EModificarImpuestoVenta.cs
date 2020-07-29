using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Entidades.EntidadesConfiguracion
{
    public class EModificarImpuestoVenta
    {
        public System.Nullable<int> IdImpuesto { get; set; }

        public string Descripcion { get; set; }

        public System.Nullable<int> PorcientoImpuesto { get; set; }

        public System.Nullable<bool> Operacion { get; set; }
    }
}
