using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes
{
    public class SacarNumeroFactura
    {
        readonly DSMarket.Logica.Logica.LogicaServicio.LogicaServicio Objdata = new Logica.LogicaServicio.LogicaServicio();

        private string NumeroConector = "";

        public SacarNumeroFactura(string NumeroCoenctorCON) {
            NumeroConector = NumeroCoenctorCON;
        }

        public decimal SacarNumero() {
            decimal NumeroFactura = 0;

            var SacarInformacion = Objdata.SacarNumeroFactura(NumeroConector);
            foreach (var n in SacarInformacion) {
                NumeroFactura = (decimal)n.NumeroFactura;
            }
            return NumeroFactura;
        }
    }
}
