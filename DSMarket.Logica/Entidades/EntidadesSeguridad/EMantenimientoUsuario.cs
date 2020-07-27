using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Entidades.EntidadesSeguridad
{
    public class EMantenimientoUsuario
    {
        public System.Nullable<decimal> IdUsuario { get; set; }

        public System.Nullable<decimal> IdNivelAcceso { get; set; }
    
        public string Usuario { get; set; }

        public string Clave { get; set; }

        public string Persona { get; set; }

        public System.Nullable<bool> Estatus { get; set; }

        public System.Nullable<bool> CambiaClave { get; set; }

        public System.Nullable<decimal> UsuarioAdicona { get; set; }

        public System.Nullable<System.DateTime> FechaAdiciona { get; set; }

        public System.Nullable<decimal> UsuarioModifica { get; set; }

        public System.Nullable<System.DateTime> FechaModifica { get; set; }
    }
}
