using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Entidades.EntidadesCaja
{
    public class EHistorialCierreCaja
    {
        public decimal? IdHistirualCierreCaja { get; set; }

        public System.Nullable<decimal> IdUsuario { get; set; }

        public string CerradoPor { get; set; }

        public System.Nullable<System.DateTime> FechaCierre0 { get; set; }

        public string FechaCierre { get; set; }

        public System.Nullable<decimal> MontoAntesCerrar { get; set; }

        public System.Nullable<decimal> MontoDespuesCierre { get; set; }

        public string ConceptoCierre { get; set; }
    }
}
