using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Entidades.EntidadesConfiguracion
{
    public class EInformacionEmpresa
    {
        public System.Nullable<decimal> IdInformacionEmpresa {get;set;}

        public string NombreEmpresa {get;set;}

        public string RNC {get;set;}

        public string Direccion {get;set;}

        public string Email {get;set;}

        public string Email2 {get;set;}

        public string Facebook {get;set;}

        public string Instagran {get;set;}

        public string Telefonos {get;set;}

        public System.Nullable<int> IdLogoEmpresa {get;set;}

        public System.Data.Linq.Binary LogoEmpresa {get;set;}
    }
}
