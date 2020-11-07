using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes.ProcesarInformacion.Configuracion
{
    public class ProcesarInformacionDescuentoPorDefecto
    {
        readonly DSMarket.Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion ObjData = new Logica.LogicaConfiguracion.LogicaCOnfiguracion();

        private int IdPorcientoDescuentoProducto = 0;
        private decimal PorcientoDescuentoProducto = 0;
        private string Accion = "";

        public ProcesarInformacionDescuentoPorDefecto(
            int IdPorcientoDescuentoProductoCON,
        decimal PorcientoDescuentoProductoCON,
        string AccionCON)
        {
            IdPorcientoDescuentoProducto = IdPorcientoDescuentoProductoCON;
            PorcientoDescuentoProducto = PorcientoDescuentoProductoCON;
            Accion = AccionCON;
        }
        public void ProcesarInformacion() {
            DSMarket.Logica.Entidades.EntidadesConfiguracion.EPorcientoDescuentoPorDefecto Procesar = new Entidades.EntidadesConfiguracion.EPorcientoDescuentoPorDefecto();

            Procesar.IdPorcientoDescuento = IdPorcientoDescuentoProducto;
            Procesar.PorcientoDescuento = PorcientoDescuentoProducto;

            var MAN = ObjData.ModificarPorcientoDefecto(Procesar, Accion);
        }
    }
}
