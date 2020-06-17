using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes
{
    
    public static class InformacionEmpresa
    {
        static readonly Lazy<DSMarket.Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion> ObjDataConfiguracion = new Lazy<Logica.LogicaConfiguracion.LogicaCOnfiguracion>();
        public static string SacarNombreEmpresa()
        {
            string NombreEmpresa = "";
            var SacarNombreEmpresa = ObjDataConfiguracion.Value.BuscaInformacionEmpresa();
            foreach (var n in SacarNombreEmpresa)
            {
                NombreEmpresa = n.NombreEmpresa;
            }

            return NombreEmpresa;
        }
    }
}
