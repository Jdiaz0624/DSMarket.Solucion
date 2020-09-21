using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Entidades.EntidadesContabilidad
{
    public class ESacarDatosReporteFinanciero
    {
        public string CuentaAuxiliar { get; set; }

        public string ConceptoCuenta { get; set; }

        public System.Nullable<decimal> Valor { get; set; }

        public string Cuenta { get; set; }

        public string CuentaDescargo { get; set; }
    }
}
