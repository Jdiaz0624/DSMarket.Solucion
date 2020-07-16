using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Entidades.EntidadesCaja
{
    public class EHistiroalCaja
    {
        public System.Nullable<decimal> IdHistorialCaja { get; set; }

        public System.Nullable<decimal> IdCaja { get; set; }

        public System.Nullable<decimal> Monto { get; set; }

        public string Concepto { get; set; }

        public System.Nullable<System.DateTime> Fecha { get; set; }

        public System.Nullable<decimal> IdUsuario { get; set; }

        public System.Nullable<decimal> NumeroReferencia { get; set; }

        public System.Nullable<decimal> IdTipoPago { get; set; }
    }
}
