using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Entidades.EntidadesSeguridad
{
    public class ECredenciales
    {
        public int? IdCredencial { get; set; }

        public string Usuario { get; set; }

        public string Clave { get; set; }
    }
}
