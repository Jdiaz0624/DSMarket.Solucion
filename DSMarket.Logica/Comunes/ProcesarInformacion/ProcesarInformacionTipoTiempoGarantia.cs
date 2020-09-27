using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes.ProcesarInformacion
{
    public class ProcesarInformacionTipoTiempoGarantia
    {
        readonly DSMarket.Logica.Logica.LogicaServicio.LogicaServicio ObjData = new Logica.LogicaServicio.LogicaServicio();

        private int IdTipoTiempoGarantia = 0;
        private string TipoTiempoGarantia = "";
        private int TiempoGarantia = 0;
        private string Accion = "";

        public ProcesarInformacionTipoTiempoGarantia(
            int IdTipoTiempoGarantiaCON,
        string TipoTiempoGarantiaCON,
        int TiempoGarantiaCON,
        string AccionCON)
        {
            IdTipoTiempoGarantia = IdTipoTiempoGarantiaCON;
            TipoTiempoGarantia = TipoTiempoGarantiaCON;
            TiempoGarantia = TiempoGarantiaCON;
            Accion = AccionCON;
        }
        public void ProcesarInformacion() {
            try {
                DSMarket.Logica.Entidades.EntidadesServicio.ETipoTiempoGarantia Procesar = new Entidades.EntidadesServicio.ETipoTiempoGarantia();

                Procesar.IdTipoTiempoGarantia = IdTipoTiempoGarantia;
                Procesar.TipoTiempoGarantia = TipoTiempoGarantia;
                Procesar.TiempoGarantia = TiempoGarantia;

                var MAN = ObjData.ModificarTipoTiempoGaranta(Procesar, Accion);
            }
            catch (Exception) { }
        }
    }
}
