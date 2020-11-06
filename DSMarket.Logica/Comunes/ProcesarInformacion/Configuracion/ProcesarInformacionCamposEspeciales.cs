using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes.ProcesarInformacion.Configuracion
{
    public class ProcesarInformacionCamposEspeciales
    {
        readonly DSMarket.Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion ObjData = new Logica.LogicaConfiguracion.LogicaCOnfiguracion();

        private decimal IdCampoEspecial = 0;
        private string Nombre = "";
        private int Longitud = 0;
        private bool Estatus = false;
        private string Accion = "";

        public ProcesarInformacionCamposEspeciales(
            decimal IdCampoEspecialCON,
            string NombreCON,
            int LongitudCON,
            bool EstatusCON,
            string AccionCON)
        {
            IdCampoEspecial = IdCampoEspecialCON;
            Nombre = NombreCON;
            Longitud = LongitudCON;
            Estatus = EstatusCON;
            Accion = AccionCON;
        }

        public void ProcesarInformacion() {
            DSMarket.Logica.Entidades.EntidadesConfiguracion.ECamposEspeciales Procesar = new Entidades.EntidadesConfiguracion.ECamposEspeciales();

            Procesar.IdCampoEspecial = IdCampoEspecial;
            Procesar.Nombre = Nombre;
            Procesar.LongitudCampo = Longitud;
            Procesar.Estatus0 = Estatus;

            var MAn = ObjData.ModificarCamposEspeciales(Procesar, Accion);
        }
    }
}
