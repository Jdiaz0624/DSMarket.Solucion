using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes
{
    public class ValidarCompania
    {
        readonly DSMarket.Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion ObjData = new Logica.LogicaConfiguracion.LogicaCOnfiguracion();

      

        public ValidarCompania() {
            
        }

        public int CodigoCompania() {
            int Compania = 0;

            var SacarInformacion = ObjData.BuscarUsoCompania(1, null);
            if (SacarInformacion.Count() < 1) {
                Compania = 0;
            }
            else {
                foreach (var n in SacarInformacion) {
                    Compania = (int)n.IdCompania;
                }
            }
            return Compania;
        }
    }
}
