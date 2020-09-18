using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Entidades.EntidadesConfiguracion
{
    public class EComprobantes
    {
        public decimal? IdComprobante { get; set; }

        public string Comprobante { get; set; }

        public string Serie { get; set; }

        public string TipoComprobante { get; set; }

        public System.Nullable<decimal> Secuencia { get; set; }

        public System.Nullable<decimal> SecuenciaInicial { get; set; }

        public System.Nullable<decimal> SecuenciaFinal { get; set; }

        public System.Nullable<decimal> Limite { get; set; }

        public System.Nullable<bool> Estatus0 { get; set; }

        public string Estatus { get; set; }

        public string ValidoHasta { get; set; }

        public System.Nullable<bool> PorDefecto0 { get; set; }

        public string PorDefecto { get; set; }

        public System.Nullable<decimal> Posiciones { get; set; }
        public System.Nullable<int> CobroPorcientoAdicional { get; set; }
    }
}
