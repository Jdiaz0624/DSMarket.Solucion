using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes
{
   
    public class MantenimientoClaveSeguridad
    {

        public readonly Lazy<DSMarket.Logica.Logica.LogicaSeguridad.LogicaSeguridad> ObjData = new Lazy<Logica.LogicaSeguridad.LogicaSeguridad>();


        private decimal IdClaveSeguridad = 0;
        private decimal IdUsuario = 0;
        private string Clave = "";
        private bool Estatus = false;
        private string Accion = "";

        public MantenimientoClaveSeguridad(
            decimal IdClaveSeguridadCON,
            decimal IdUsuarioCON,
            string ClaveCON,
            bool EstatusCON,
            string AccionCOn)
        {
            IdClaveSeguridad = IdClaveSeguridadCON;
            IdUsuario = IdUsuarioCON;
            Clave = ClaveCON;
            Estatus = EstatusCON;
            Accion = AccionCOn;
        }

        public void MAntenimientoClave() {
            DSMarket.Logica.Entidades.EntidadesSeguridad.EMantenimientoClaveSeguridad Mantenimiento = new Entidades.EntidadesSeguridad.EMantenimientoClaveSeguridad();

            Mantenimiento.IdCLaveSeguridad = IdClaveSeguridad;
            Mantenimiento.IdUsuario = IdUsuario;
            Mantenimiento.Clave = Clave;
            Mantenimiento.Estatus = Estatus;

            var MAN = ObjData.Value.MantenimientoClaveSeguridad(Mantenimiento, Accion);
        }
    }
}
