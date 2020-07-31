using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Entidades.EntidadesServicio
{
    public class EMantenimientoTipoPago
    {
        public System.Nullable<decimal> IdTipoPago {get;set;}

        public string Descripcion {get;set;}

        public System.Nullable<bool> Estatus {get;set;}

        public System.Nullable<decimal> UsuarioAdiciona {get;set;}

        public System.Nullable<System.DateTime> FechaAdiciona {get;set;}

        public System.Nullable<decimal> UsuarioModifica {get;set;}

        public System.Nullable<System.DateTime> FechaModifica {get;set;}

        public System.Nullable<bool> BloqueaMonto {get;set;}

        public System.Nullable<bool> ImpuestoAdicional {get;set;}

        public System.Nullable<bool> PorcentajeEntero {get;set;}

        public System.Nullable<decimal> Valor {get;set;}
    }
}
