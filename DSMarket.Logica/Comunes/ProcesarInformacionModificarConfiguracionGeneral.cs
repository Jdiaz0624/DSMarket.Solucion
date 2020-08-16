using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes
{
    public class ProcesarInformacionModificarConfiguracionGeneral : DSMarket.Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion
    {

        private int IdConfiguracionGeneral = 0;
        private string Descripcion = "";
        private bool Estatus = false;
        private string Accion = "";

        public ProcesarInformacionModificarConfiguracionGeneral(
            int IdConfiguracionGeneralCON,
            string DescripcionCON,
            bool EstatusCON,
            string AccionCON)
        {
            IdConfiguracionGeneral = IdConfiguracionGeneralCON;
            Descripcion = DescripcionCON;
            Estatus = EstatusCON;
            Accion = AccionCON;
        }

        public void ModificarInformacionGeneral() {
            DSMarket.Logica.Entidades.EntidadesConfiguracion.EModificarConfiguracionGeneral Modificar = new Entidades.EntidadesConfiguracion.EModificarConfiguracionGeneral();

            Modificar.IdConfiguracionGeneral = IdConfiguracionGeneral;
            Modificar.Descripcion = Descripcion;
            Modificar.Estatus = Estatus;

            var MAN = ModificarConfiguracionGeneral(Modificar, Accion);
        }
    }
}
