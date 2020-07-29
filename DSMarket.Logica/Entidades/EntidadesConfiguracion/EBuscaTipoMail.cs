using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Entidades.EntidadesConfiguracion
{
    public class EBuscaTipoMail
    {
        public System.Nullable<int> IdTipoMail { get; set; }

        public string TipoMail { get; set; }

        public string smtp { get; set; }

        public System.Nullable<int> Puerto { get; set; }
    }
}
