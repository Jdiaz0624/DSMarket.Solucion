using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes
{
    public class ActualizarMail
    {
        public readonly Lazy<DSMarket.Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion> ObjdataCOnfiguracion = new Lazy<Logica.LogicaConfiguracion.LogicaCOnfiguracion>();


        private decimal IdMalil = 0;
        private string Mail = "";
        private string Clave = "";
        private bool Estatus = false;
        private int IdTipoCorreo = 0;
        private string Accion = "UPDATE";

        public ActualizarMail(
            decimal IdMailCON,
            string MailCON,
            string ClaveCON,
            bool EstatusCON,
            int IdTipoCorreoCON)
        {
            IdMalil = IdMailCON;
            Mail = MailCON;
            Clave = ClaveCON;
            Estatus = EstatusCON;
            IdTipoCorreo = IdTipoCorreoCON;

        }

        public void Actualizar() {
            DSMarket.Logica.Entidades.EntidadesConfiguracion.EMail Update = new Entidades.EntidadesConfiguracion.EMail();

            Update.IdMail = IdMalil;
            Update.Mail = Mail;
            Update.Clave = Clave;
            Update.Estatus = Estatus;
            Update.IdTipoCorreo = IdTipoCorreo;

            var MAN = ObjdataCOnfiguracion.Value.MantenimientoMail(Update, Accion);
        }
    }
}
