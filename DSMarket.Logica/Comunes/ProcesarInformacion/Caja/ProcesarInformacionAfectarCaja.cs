using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes.ProcesarInformacion.Caja
{
    public class ProcesarInformacionAfectarCaja
    {
        readonly DSMarket.Logica.Logica.LogicaCaja.LogicaCaja ObjDataCaja = new Logica.LogicaCaja.LogicaCaja();

        private decimal IdCaja = 0;
        private string Descripcion = "";
        private decimal MontoActual = 0;
        private bool Estatus = false;
        private string Accion = "";

        public ProcesarInformacionAfectarCaja(
            decimal IdCajaCON,
            string DescripcionCON,
            decimal MontoActualCON,
            bool EstatusCON,
            string AccionCON)
        {
            IdCaja = IdCajaCON;
            Descripcion = DescripcionCON;
            MontoActual = MontoActualCON;
            Estatus = EstatusCON;
            Accion = AccionCON;
        }

        /// <summary>
        /// Procesar la informacion de la caja
        /// </summary>
        public void ProcesarInformacion() {
            DSMarket.Logica.Entidades.EntidadesCaja.ECajaGeneral Afectar = new Entidades.EntidadesCaja.ECajaGeneral();

            Afectar.IdCaja = IdCaja;
            Afectar.Caja = Descripcion;
            Afectar.MontoActual = MontoActual;
            Afectar.Estatus0 = Estatus;


            var MAn = ObjDataCaja.AfectarCaja(Afectar, Accion);
        }
    }
}
