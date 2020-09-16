using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes.ProcesarInformacion
{
    public class ProcesarInformacionObservaciones
    {
        readonly DSMarket.Logica.Logica.LogicaServicio.LogicaServicio ObjDataServicio = new Logica.LogicaServicio.LogicaServicio();

        private int IdObservacion = 0;
        private string Observacion = "";
        private string Accion = "";

        public ProcesarInformacionObservaciones(
           int IdObservacionCON,
           string ObservacionCON,
           string AccionCON)
        {
            IdObservacion = IdObservacionCON;
            Observacion = ObservacionCON;
            Accion = AccionCON;
        }
        public void ProcesarInformacion() {
            DSMarket.Logica.Entidades.EntidadesServicio.EObservaciones Procesar = new Entidades.EntidadesServicio.EObservaciones();
            Procesar.IdObServacion = IdObservacion;
            Procesar.Observacion = Observacion;
            var MAN = ObjDataServicio.MantenimientoObservacion(Procesar, Accion);
        }
    }
}
