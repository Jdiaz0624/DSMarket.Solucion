using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes
{
    public class SacarNumeroCotizacion
    {
        readonly DSMarket.Logica.Logica.LogicaServicio.LogicaServicio ObjData = new Logica.LogicaServicio.LogicaServicio();

        private string NumeroConector = "";

        public SacarNumeroCotizacion(string NumeroConectorCON) {
            NumeroConector = NumeroConectorCON;
        }

        public decimal NumeroCotiacion() {
            decimal Numero = 0;

            var SacarInformacion = ObjData.SacarNumeroCotizacion(NumeroConector);
            foreach (var n in SacarInformacion) {
                Numero = (decimal)n.NumeroCotizacion;
            }
            return Numero;
        }
    }
}
