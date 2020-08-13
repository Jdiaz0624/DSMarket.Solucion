using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes
{
    public class ProcesarMontoInicialCaja
    {
        public readonly Lazy<DSMarket.Logica.Logica.LogicaCaja.LogicaCaja> ObjDataCaja = new Lazy<Logica.LogicaCaja.LogicaCaja>();

        private int IdCaja = 0;
        private decimal MontoInicialCaja = 0;
        private string Accion = "";

        public ProcesarMontoInicialCaja(
            int IdCajaCON,
            decimal MontoInicialCajaCON,
            string AccionCON)
        {
            IdCaja = IdCajaCON;
            MontoInicialCaja = MontoInicialCajaCON;
            Accion = AccionCON;
        }

        public void ProcesarInformacion() {
            DSMarket.Logica.Entidades.EntidadesCaja.EMontoInicialCaja Procesar = new Entidades.EntidadesCaja.EMontoInicialCaja();

            Procesar.IdCaja = IdCaja;
            Procesar.MontoInicialCaja = MontoInicialCaja;

            var MAN = ObjDataCaja.Value.MantenimientoMontoInicialCaja(Procesar, Accion);
        }
    }
}
