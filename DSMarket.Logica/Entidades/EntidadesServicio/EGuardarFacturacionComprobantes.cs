using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Entidades.EntidadesServicio
{
    public class EGuardarFacturacionComprobantes
    {
        public System.Nullable<decimal> IdFacturacion { get; set; }

        public System.Nullable<decimal> NumeroConector { get; set; }

        public string DescripcionComprobante { get; set; }

        public string Comprobante { get; set; }
    }
}
