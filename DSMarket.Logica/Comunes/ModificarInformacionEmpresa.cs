using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes
{
    public class ModificarInformacionEmpresa
    {
        public readonly Lazy<DSMarket.Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion> ObjDataConfiguracion = new Lazy<Logica.LogicaConfiguracion.LogicaCOnfiguracion>();


        private decimal IdInformacionEmpresa = 0;
        private string NombreEmpresa = "";
        private string RNC = "";
        private string Direccion = "";
        private string Email = "";
        private string Email2 = "";
        private string Fcebook = "";
        private string Instagram = "";
        private string Telefonos = "";
        private int    IdLogoEmpresa = 0;
        private string Accion = "";

        public ModificarInformacionEmpresa(
            decimal IdInformacionEmpresaCON,
            string NombreEmpresaCON,
            string RNCCON,
            string DireccionCON,
            string EmailCON,
            string Email2CON,
            string FcebookCON,
            string InstagramCON,
            string TelefonosCON,
            int IdLogoEmpresaCON,
            string AccionCON)
        {
            IdInformacionEmpresa = IdInformacionEmpresaCON;
            NombreEmpresa = NombreEmpresaCON;
            RNC = RNCCON;
            Direccion = DireccionCON;
            Email = EmailCON;
            Email2 = Email2CON;
            Fcebook = FcebookCON;
            Instagram = InstagramCON;
            Telefonos = TelefonosCON;
            IdLogoEmpresa = IdLogoEmpresaCON;
            Accion = AccionCON;
        }

        public void ModificarInformacion() {
            DSMarket.Logica.Entidades.EntidadesConfiguracion.EInformacionEmpresa Modificar = new Entidades.EntidadesConfiguracion.EInformacionEmpresa();

            Modificar.IdInformacionEmpresa = IdInformacionEmpresa;
            Modificar.NombreEmpresa = NombreEmpresa;
            Modificar.RNC = RNC;
            Modificar.Direccion = Direccion;
            Modificar.Email = Email;
            Modificar.Email2 = Email2;
            Modificar.Facebook = Fcebook;
            Modificar.Instagran = Instagram;
            Modificar.Telefonos = Telefonos;
            Modificar.IdLogoEmpresa = IdLogoEmpresa;

            var MAN = ObjDataConfiguracion.Value.ModificarInformacionEmpresa(Modificar, Accion);
        }

    }
}
