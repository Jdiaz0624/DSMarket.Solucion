using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes.ProcesarInformacion.Configuracion
{
    public class ProcesarInformacionConfiguracionGeneralSistema
    {
        readonly DSMarket.Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion ObjData = new Logica.LogicaConfiguracion.LogicaCOnfiguracion();

        private decimal IdConfiguraciongeneral = 0;
        private decimal IdModulo = 0;
        private string Descripcion = "";
        private bool Estatus = false;
        private string Accion = "";

        public ProcesarInformacionConfiguracionGeneralSistema(
            decimal IdConfiguraciongeneralCON,
            decimal IdModuloCON,
            string DescripcionCON,
            bool EstatusCON,
            string AccionCON)
        {
            IdConfiguraciongeneral = IdConfiguraciongeneralCON;
            IdModulo = IdModuloCON;
            Descripcion = DescripcionCON;
            Estatus = EstatusCON;
            Accion = AccionCON;
        }

        /// <summary>
        /// Este metodo es para procesar la información de la configuracion general del sistema
        /// </summary>
        public void ProcesarInformacion() {
            DSMarket.Logica.Entidades.EntidadesConfiguracion.EConfiguracionGeneral Procesar = new Entidades.EntidadesConfiguracion.EConfiguracionGeneral();

            Procesar.IdConfiguracion = IdConfiguraciongeneral;
            Procesar.IdModulo = IdModulo;
            Procesar.Descripcion = Descripcion;
            Procesar.Estatus0 = Estatus;

            var MAN = ObjData.ModificarConfiguracionesGenerales(Procesar, Accion);
        }

    }
}
