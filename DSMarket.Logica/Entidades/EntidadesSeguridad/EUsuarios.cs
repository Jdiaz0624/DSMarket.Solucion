using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Entidades.EntidadesSeguridad
{
    public class EUsuarios
    {
        public System.Nullable<decimal> IdUsuario {get;set;}

        public System.Nullable<decimal> IdNivelAcceso {get;set;}

        public string Nivel {get;set;}

        public string Usuario {get;set;}

        public string Clave {get;set;}

        public string Persona {get;set;}

        public System.Nullable<bool> Estatus0 {get;set;}

        public string Estatus {get;set;}

        public System.Nullable<bool> CambiaClave0 {get;set;}

        public string CambiaClave {get;set;}

        public System.Nullable<decimal> UsuarioAdicona {get;set;}

        public string CreadoPor {get;set;}

        public System.Nullable<System.DateTime> FechaAdiciona0 {get;set;}

        public string FechaCreado {get;set;}

        public System.Nullable<decimal> UsuarioModifica {get;set;}

        public string ModificadoPor {get;set;}

        public System.Nullable<System.DateTime> FechaModifica0 {get;set;}

        public string FechaModificado {get;set;}
    }
}
