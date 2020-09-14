using DSMarket.Logica.Logica.LogicaInventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes.ProcesarInformacion
{
    public class ProcesarInformacioNCondicionArticulos
    {
        public readonly DSMarket.Logica.Logica.LogicaInventario.LogicaInventario ObjDataInventario = new LogicaInventario();

        private decimal IdCondicion = 0;
        private string Condicion = "";
        private bool Estatus = false;
        private decimal IdUsuario = 0;
        private DateTime FechaProceso = DateTime.Now;
        private string Accion = "";

        public ProcesarInformacioNCondicionArticulos(
            decimal IdCondicionCON,
        string CondicionCON,
        bool EstatusCON,
        decimal IdUsuarioCON,
        DateTime FechaProcesoCON,
        string AccionCON
        )
        {
            IdCondicion = IdCondicionCON;
            Condicion = CondicionCON;
            Estatus = EstatusCON;
            IdUsuario = IdUsuarioCON;
            FechaProceso = FechaProcesoCON;
            Accion = AccionCON;        
        }

        public void ProcesarInformacion() {
            DSMarket.Logica.Entidades.EntidadesInventario.ECondiciones Procesar = new Entidades.EntidadesInventario.ECondiciones();

            Procesar.IdCondicion = IdCondicion;
            Procesar.Condicion = Condicion;
            Procesar.Estatus0 = Estatus;
            Procesar.UsuarioAdiciona = IdUsuario;
            Procesar.FechaAdiciona = FechaProceso;
            Procesar.UsuarioModifica = IdUsuario;
            Procesar.FechaModifica = FechaProceso;

            var MAN = ObjDataInventario.MantenimientoCondiciones(Procesar, Accion);
        }
    }
}
