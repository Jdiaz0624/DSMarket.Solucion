using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes
{
    public static class ValidarNivelUsuario
    {
        static readonly Lazy<DSMarket.Logica.Logica.LogicaSeguridad.LogicaSeguridad> ObjdataSeguridad = new Lazy<Logica.LogicaSeguridad.LogicaSeguridad>();



        public static decimal ValidarNivelAccesoUsuario( decimal IdUsuario) {

            decimal IdNivelAcceso = 0;
            var SacarNivelAccesoUsuario = ObjdataSeguridad.Value.BuscaUsuarios(
                IdUsuario,
                null, null, null, null, 1, 1);
            foreach (var n in SacarNivelAccesoUsuario) {
                IdNivelAcceso = Convert.ToDecimal(n.IdNivelAcceso);
            }
            return IdNivelAcceso;

        }
    }
}
