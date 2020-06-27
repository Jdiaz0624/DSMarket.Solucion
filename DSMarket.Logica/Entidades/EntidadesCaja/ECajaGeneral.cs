using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Entidades.EntidadesCaja
{
    public class ECajaGeneral
    {
        public decimal? IdCaja { get; set; }

        public string Caja { get; set; }

        public System.Nullable<decimal> MontoActual { get; set; }

        public System.Nullable<bool> Estatus0 { get; set; }

        public string Estatus { get; set; }
    }
}
