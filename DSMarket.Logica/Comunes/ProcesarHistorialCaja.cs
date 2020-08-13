using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes
{
    public class ProcesarHistorialCaja
    {
        public readonly Lazy<DSMarket.Logica.Logica.LogicaCaja.LogicaCaja> ObjdataCaja = new Lazy<Logica.LogicaCaja.LogicaCaja>();

        private decimal IdHistorialCierreCaja = 0;
        private decimal IdUsuario = 0;
        private decimal MontoAntesCerrar = 0;
        private decimal MontoDespuesCerrar = 0;
        private string ConceptoCierre = "";
        private string Accion = "";

        public ProcesarHistorialCaja(
            decimal IdHistorialCierreCajaCON,
            decimal IdUsuarioCON,
            decimal MontoAntesCerrarCON,
            decimal MontoDespuesCerrarCON,
            string ConceptoCierreCON,
            string AccionCON)
        {
            IdHistorialCierreCaja = IdHistorialCierreCajaCON;
            IdUsuario = IdUsuarioCON;
            MontoAntesCerrar = MontoAntesCerrarCON;
            MontoDespuesCerrar = MontoDespuesCerrarCON;
            ConceptoCierre = ConceptoCierreCON;
            Accion = AccionCON;
        }

        private void ProcesarInformacion() {
            DSMarket.Logica.Entidades.EntidadesCaja.EHistorialCierreCaja Procesar = new Entidades.EntidadesCaja.EHistorialCierreCaja();

            Procesar.IdHistirualCierreCaja = IdHistorialCierreCaja;
            Procesar.IdUsuario = IdUsuario;
            Procesar.FechaCierre0 = DateTime.Now;
            Procesar.MontoAntesCerrar = MontoAntesCerrar;
            Procesar.MontoDespuesCierre = MontoDespuesCerrar;
            Procesar.ConceptoCierre = ConceptoCierre;

            var MAN = ObjdataCaja.Value.MantenimientoHistorialCierreCaja(Procesar, Accion);
        }
    }
}
