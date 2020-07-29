using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes
{
    public class ModificarImpuesto
    {
        public readonly Lazy<DSMarket.Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion> ObjDataConfiguracion = new Lazy<Logica.LogicaConfiguracion.LogicaCOnfiguracion>();


        private int IdImpuesto = 0;
        private string Descripcion="";
        private int PorcientoImpuesto = 0;
        private bool Operacion = false;
        private string Accion = "UPDATE";

        public ModificarImpuesto(
            int IdImpuestoCON,
            string DescripcionCON,
            int PorcientoComisionCON,
            bool OperacionCON)
        {
            IdImpuesto = IdImpuestoCON;
            Descripcion = DescripcionCON;
            PorcientoImpuesto = PorcientoComisionCON;
            Operacion = OperacionCON;
        }

        public void Modificar() {
            DSMarket.Logica.Entidades.EntidadesConfiguracion.EModificarImpuestoVenta update = new Entidades.EntidadesConfiguracion.EModificarImpuestoVenta();

            update.IdImpuesto = IdImpuesto;
            update.Descripcion = Descripcion;
            update.PorcientoImpuesto = PorcientoImpuesto;
            update.Operacion = Operacion;

            var MAN = ObjDataConfiguracion.Value.ModificarImpuesto(update, Accion);
        }

    }
}
