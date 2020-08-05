using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes
{
    public static class ValidarConfiguracionGeneral
    {
         static readonly Lazy<DSMarket.Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion> ObjDataConfiguracion = new Lazy<Logica.LogicaConfiguracion.LogicaCOnfiguracion>();

        public static bool Validar(int IdCOnfiguracionGeneral) {
            bool Resultado = false;
            var ValidarInformacion = ObjDataConfiguracion.Value.BuscaCOnfiguracionGeneral(IdCOnfiguracionGeneral);
            foreach (var n in ValidarInformacion) {
                Resultado = Convert.ToBoolean(n.Estatus0);
            }
            return Resultado;
        }
    }
}
