using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes.ProcesarInformacion.Servicio
{
    public class ProcesarInformacionFechaMAnual
    {
        readonly DSMarket.Logica.Logica.LogicaServicio.LogicaServicio ObjData = new Logica.LogicaServicio.LogicaServicio();

        private decimal NumeroConector = 0;
        private DateTime Fecha = DateTime.Now;
        private string Accion = "";

        public ProcesarInformacionFechaMAnual(
            decimal NumeroConectorCON,
        DateTime FechaCON,
        string AccionCON)
        {
            NumeroConector = NumeroConectorCON;
            Fecha = FechaCON;
            Accion = AccionCON;
        }

        public void ProcesarInformacionFechaManual() {
            DSMarket.Logica.Entidades.EntidadesServicio.EAsignaFechaManualFActuracion Procesa = new Entidades.EntidadesServicio.EAsignaFechaManualFActuracion();

            Procesa.NumeroConector = NumeroConector;
            Procesa.FechaFactura = Fecha;

            var MAN = ObjData.AsignarFechaManual(Procesa, Accion);
        }
    }
}
