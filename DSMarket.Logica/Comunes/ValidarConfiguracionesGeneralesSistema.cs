using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes
{
    public class ValidarConfiguracionesGeneralesSistema
    {
        readonly DSMarket.Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion ObjData = new Logica.LogicaConfiguracion.LogicaCOnfiguracion();

        private decimal IdConfiguracion = 0;
        private decimal IDModulo = 0;

        public ValidarConfiguracionesGeneralesSistema(
            decimal IdConfiguracionCON,
        decimal IDModuloCON)
        {
            IdConfiguracion = IdConfiguracionCON;
            IDModulo = IDModuloCON;
        }

        public bool ValidarConfiguracionGeneral() {
            bool Respuesta = false;

            var Validar = ObjData.BuscaConfiguraciongeneral(IdConfiguracion, IDModulo);
            foreach (var n in Validar) {
                Respuesta = (bool)n.Estatus0;
            }
            return Respuesta;
        }
    }
}
