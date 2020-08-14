using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes
{
    public class ProcesarRUtaArchivotxt
    {
        public readonly Lazy<DSMarket.Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion> ObjData = new Lazy<Logica.LogicaConfiguracion.LogicaCOnfiguracion>();

        private int IdRutaArchivotxt = 0;
        private string RutaArchivotxt = "";
        private string Accion = "";

        public ProcesarRUtaArchivotxt(
            int IdRutaArchivotxtCON,
            string RutaArchivotxtCON,
            string AccionCON)
        {
            IdRutaArchivotxt = IdRutaArchivotxtCON;
            RutaArchivotxt = RutaArchivotxtCON;
            Accion = AccionCON;
        }

        public void ProcesarInformacion() {
            DSMarket.Logica.Entidades.EntidadesConfiguracion.ERutaArchivotxt Procesar = new Entidades.EntidadesConfiguracion.ERutaArchivotxt();

            Procesar.IdRutaArchivotxt = IdRutaArchivotxt;
            Procesar.Ruta = RutaArchivotxt;

            var MAN = ObjData.Value.ModificarRUtaArchivotxt(Procesar, Accion);
        }
    }
}
