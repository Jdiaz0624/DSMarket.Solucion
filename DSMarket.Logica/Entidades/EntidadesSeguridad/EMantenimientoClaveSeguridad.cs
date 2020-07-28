using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Entidades.EntidadesSeguridad
{
    public class EMantenimientoClaveSeguridad
    {
        public System.Nullable<decimal> IdCLaveSeguridad { get; set; }

        public System.Nullable<decimal> IdUsuario { get; set; }

        public string Clave { get; set; }

        public System.Nullable<bool> Estatus { get; set; }
    }
}
