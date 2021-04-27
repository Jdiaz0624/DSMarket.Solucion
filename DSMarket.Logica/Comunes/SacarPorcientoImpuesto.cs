using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes
{
    public class SacarPorcientoImpuesto
    {
        readonly DSMarket.Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion ObjData = new Logica.LogicaConfiguracion.LogicaCOnfiguracion();

        private int IdImpuesto = 0;

        public SacarPorcientoImpuesto(int IdImpuestoCON) {
            IdImpuesto = IdImpuestoCON;
        }

        public int PorcientoImpuesto() {
            int Porciento = 0;

            var SacarPorciento = ObjData.BuscaImpuestos(IdImpuesto);
            foreach (var n in SacarPorciento) {
                Porciento= (int)n.PorcientoImpuesto;
            }
            return Porciento;
        }
    }
}
