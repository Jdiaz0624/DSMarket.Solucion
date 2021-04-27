using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes
{
    public class SacarNombreClientePorDefecto
    {
        readonly DSMarket.Logica.Logica.LogicaEmpresa.LogicaEmpresa ObjData = new Logica.LogicaEmpresa.LogicaEmpresa();

        private decimal CodigoCliente = 0;

        public SacarNombreClientePorDefecto() {
            CodigoCliente = 1;
        }

        public string SacarClientePorDefecto() {
            string Nombre = "";

            var SacarInformacion = ObjData.BuscaClientes(CodigoCliente, null, null, null, null, null, 1, 1);
            foreach (var n in SacarInformacion) {
                Nombre = n.Nombre;
            }
            return Nombre;
        }
    }
}
