using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes.ProcesarInformacion
{
    public class ProcesarInformacionCapacidadArticulos
    {
        public readonly DSMarket.Logica.Logica.LogicaInventario.LogicaInventario ObjData = new Logica.LogicaInventario.LogicaInventario();

        private decimal IdCapacidad = 0;
        private string Capacidad = "";
        private bool Estatus = false;
        private decimal IdUsuario = 0;
        private DateTime FechaProceso = DateTime.Now;
        private string Accion = "";

        public ProcesarInformacionCapacidadArticulos(
            decimal IdCapacidadCON,
        string CapacidadCON,
        bool EstatusCON,
        decimal IdUsuarioCON,
        DateTime FechaProcesoCON,
        string AccionCON)
        {
            IdCapacidad = IdCapacidadCON;
            Capacidad = CapacidadCON;
            Estatus = EstatusCON;
            IdUsuario = IdUsuarioCON;
            FechaProceso = FechaProcesoCON;
            Accion = AccionCON;
        }
        public void ProcesarInformacion() {
            DSMarket.Logica.Entidades.EntidadesInventario.ECapacidadArticulos Procesar = new Entidades.EntidadesInventario.ECapacidadArticulos();

            Procesar.IdCapacidad = IdCapacidad;
            Procesar.Capacidad = Capacidad;
            Procesar.Estatus0 = Estatus;
            Procesar.UsuarioAdiciona = IdUsuario;
            Procesar.FechaAdiciona = FechaProceso;
            Procesar.UsuarioModifica = IdUsuario;
            Procesar.FechaModifica = FechaProceso;

            var MAN = ObjData.MantenimientoCapacidadArticulos(Procesar, Accion);
        }
    }
}
