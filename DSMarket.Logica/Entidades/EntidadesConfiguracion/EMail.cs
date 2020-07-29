using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Entidades.EntidadesConfiguracion
{
    public class EMail
    {
        public System.Nullable<decimal> IdMail { get; set; }

        public string Mail { get; set; }

        public string Clave { get; set; }

        public System.Nullable<bool> Estatus { get; set; }

        public System.Nullable<int> IdTipoCorreo { get; set; }

        public System.Nullable<int> IdTipoMail { get; set; }

        public string TipoMail { get; set; }

        public System.Nullable<int> Puerto { get; set; }

        public string smtp { get; set; }
    }
}
