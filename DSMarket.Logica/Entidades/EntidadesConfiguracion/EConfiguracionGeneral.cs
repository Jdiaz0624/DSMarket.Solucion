using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Entidades.EntidadesConfiguracion
{
    public class EConfiguracionGeneral
    {
        public int? IdConfiguracionGeneral { get; set; }

        public string Descripcion { get; set; }

        public System.Nullable<bool> Estatus0 { get; set; }

        public string Estatus { get; set; }

        public System.Nullable<int> CantidadActivos { get; set; }

        public System.Nullable<int> CantidadInactivos { get; set; }
    }
}
