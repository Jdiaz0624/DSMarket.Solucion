using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes
{
    public class MantenimientoRutaBAckup
    {
        public readonly Lazy<DSMarket.Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion> ObjData = new Lazy<Logica.LogicaConfiguracion.LogicaCOnfiguracion>();


        private decimal IdRutaBackup = 0;
        private string Ruta = "";
        private string Accion = "";

        public MantenimientoRutaBAckup(
            decimal IdRUtaBAckupCON,
            string RutaCON,
            string AccionCON)
        {
            IdRutaBackup = IdRUtaBAckupCON;
            Ruta = RutaCON;
            Accion = AccionCON;
        }
        public void MAntenimientoRuta() {
            DSMarket.Logica.Entidades.EntidadesConfiguracion.ERutaBackup Mantenimiento = new Entidades.EntidadesConfiguracion.ERutaBackup();

            Mantenimiento.IdRutaBAckupBD = IdRutaBackup;
            Mantenimiento.Ruta = Ruta;

            var MAN = ObjData.Value.MantenimientoRutaBackup(Mantenimiento, Accion);
        }
    }
}
