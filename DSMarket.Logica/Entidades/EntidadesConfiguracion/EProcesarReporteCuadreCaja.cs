using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Entidades.EntidadesConfiguracion
{
    public class EProcesarReporteCuadreCaja
    {
        public System.Nullable<decimal> IdUsuario { get; set; }

        public System.Nullable<int> IdCaja { get; set; }

        public System.Nullable<decimal> Monto { get; set; }

        public string Concepto { get; set; }

        public System.Nullable<System.DateTime> FechaProcesado { get; set; }

        public System.Nullable<System.DateTime> FechaDesde { get; set; }

        public System.Nullable<System.DateTime> FechaHasta { get; set; }

        public System.Nullable<decimal> NumeroReferencia { get; set; }

        public System.Nullable<decimal> IdTipoPago { get; set; }
    }
}
