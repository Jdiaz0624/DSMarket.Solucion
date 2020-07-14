using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Entidades.EntidadesConfiguracion
{
    public class EMantenimientoComprobantes
    {
        public System.Nullable<decimal> IdComprobante { get; set; }

        public string Descripcion { get; set; }

        public string Serie { get; set; }

        public string TipoComprobante { get; set; }

        public System.Nullable<long> Secuencia { get; set; }

        public System.Nullable<long> SecuenciaInicial { get; set; }

        public System.Nullable<long> SecuenciaFinal { get; set; }

        public System.Nullable<long> Limite { get; set; }

        public System.Nullable<bool> Estatus { get; set; }

        public string ValidoHasta { get; set; }

        public System.Nullable<bool> PorDefecto { get; set; }

        public System.Nullable<long> Posiciones { get; set; }
    }
}
