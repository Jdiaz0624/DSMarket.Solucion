using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes.ProcesarInformacion.Inventario
{
    public class ProcesarInformacionCapacidad
    {
        readonly DSMarket.Logica.Logica.LogicaInventario.LogicaInventario ObjData = new Logica.LogicaInventario.LogicaInventario();

        private decimal IdCapacidad = 0;
        private string Descripcion = "";
        private bool Estatus = false;
        private string Accion = "";

        public ProcesarInformacionCapacidad(
            decimal IdCapacidadCON,
           string DescripcionCON,
           bool EstatusCON,
           string AccionCON)
        {
            IdCapacidad = IdCapacidadCON;
            Descripcion = DescripcionCON;
            Estatus = EstatusCON;
            Accion = AccionCON;
        }

        /// <summary>
        /// Procesar informacion de las capacidades de los equipos
        /// </summary>
        public void ProcesarInformacion() {
            DSMarket.Logica.Entidades.EntidadesInventario.ECapacidad Procesar = new Entidades.EntidadesInventario.ECapacidad();

            Procesar.IdCapacidad = IdCapacidad;
            Procesar.Capacidad = Descripcion;
            Procesar.Estatus0 = Estatus;

            var MAN = ObjData.ProcesarCapacidad(Procesar, Accion);
        }
    }
}
