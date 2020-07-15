using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Entidades.EntidadesServicio
{
    public class EGuardarFacturacionCalculos
    {
        public System.Nullable<decimal> NumeroColector {get;set;}

        public System.Nullable<int> CantidadProductos {get;set;}

        public System.Nullable<int> CantidadServicios {get;set;}

        public System.Nullable<int> CantidadArticulos {get;set;}

        public System.Nullable<decimal> TotalDescuento {get;set;}

        public System.Nullable<decimal> SubTotal {get;set;}

        public System.Nullable<decimal> Impuesto {get;set;}

        public System.Nullable<int> PorcientoImpuesto {get;set;}

        public System.Nullable<decimal> MontoPagado {get;set;}

        public System.Nullable<decimal> Cambio {get;set;}

        public System.Nullable<decimal> IdTipoPago {get;set;}
        public System.Nullable<decimal> TotalGeneral { get; set; }
    }
}
