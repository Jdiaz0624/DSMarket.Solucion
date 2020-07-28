using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes
{
    
    public class GenerarBAckupBD
    {
        public readonly Lazy<DSMarket.Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion> ObjDataConfiguracion = new Lazy<Logica.LogicaConfiguracion.LogicaCOnfiguracion>();
        private string Ruta = "";
        private string Accion = "";

        public GenerarBAckupBD(
            string RutaCON,
            string AccionCON)
        {
            Ruta = RutaCON;
            Accion = AccionCON;
        }

        public void GenerarBAckup() {
            DSMarket.Logica.Entidades.EntidadesConfiguracion.EGenerarRutaBackup GenerarBackup = new Entidades.EntidadesConfiguracion.EGenerarRutaBackup();

            GenerarBackup.RutaArchivo = Ruta;

            var MAN = ObjDataConfiguracion.Value.GenerarBackup(GenerarBackup, Accion);
        }
    }
}
