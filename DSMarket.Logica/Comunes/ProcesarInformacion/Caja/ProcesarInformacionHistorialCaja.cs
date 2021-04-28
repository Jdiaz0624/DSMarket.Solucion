using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes.ProcesarInformacion.Caja
{
    public class ProcesarInformacionHistorialCaja
    {
        readonly DSMarket.Logica.Logica.LogicaCaja.LogicaCaja ObjDataCaja = new Logica.LogicaCaja.LogicaCaja();

        private decimal IdHistorialCaja = 0;
        private decimal IdCaja = 0;
        private decimal Monto = 0;
        private string Concepto = "";
        private decimal IdUsuario = 0;
        private decimal NumeroReferencia = 0;
        private decimal IdTipoPago = 0;
        private string Accion = "";

        public ProcesarInformacionHistorialCaja(
            decimal IdHistorialCajaCON,
        decimal IdCajaCON,
        decimal MontoCON,
        string ConceptoCON,
        decimal IdUsuarioCON,
        decimal NumeroReferenciaCON,
        decimal IdTipoPagoCON,
        string AccionCON)
        {
            IdHistorialCaja = IdHistorialCajaCON;
            IdCaja = IdCajaCON;
            Monto = MontoCON;
            Concepto = ConceptoCON;
            IdUsuario = IdUsuarioCON;
            NumeroReferencia = NumeroReferenciaCON;
            IdTipoPago = IdTipoPagoCON;
            Accion = AccionCON;       
        }

        /// <summary>
        /// Procesar la informacion de la caja
        /// </summary>
        public void ProcesarInformacion() {
            DSMarket.Logica.Entidades.EntidadesCaja.EHistorialCaja Procesar = new Entidades.EntidadesCaja.EHistorialCaja();

            Procesar.IdHistorialCaja = IdHistorialCaja;
            Procesar.IdCaja = IdCaja;
            Procesar.Monto = Monto;
            Procesar.Concepto = Concepto;
            Procesar.Fecha0 = DateTime.Now;
            Procesar.IdUsuario = IdUsuario;
            Procesar.NumeroReferencia = NumeroReferencia;
            Procesar.IdTipoPago = IdTipoPago;

            var MAN = ObjDataCaja.MantenimientoHistorialCaja(Procesar, Accion);
        }
    }
}
