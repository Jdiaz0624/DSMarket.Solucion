using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes
{
    public static class ObtenerConceptoCuentas 
    {
        static readonly Lazy<DSMarket.Logica.Logica.LogicaContabilidad.LogicaContabilidad> ObjdataContabilidad = new Lazy<Logica.LogicaContabilidad.LogicaContabilidad>();
        public static string SacarConceptoCuenta(int IdCOnceptoCuenta) {

            string Concepto = "";

            var SacarConcepto = ObjdataContabilidad.Value.BuscaProcesosCuentas(IdCOnceptoCuenta);
            foreach (var n in SacarConcepto) {
                Concepto = n.Concepto;
            }
            return Concepto;
        }
        
    }
}
