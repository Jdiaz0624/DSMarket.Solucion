using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Entidades.EntidadesServicio
{
    public class EFacturacionProducto
    {
        public System.Nullable<decimal> NumeroConector {get;set;}

        public System.Nullable<decimal> IdTipoProducto {get;set;}

        public System.Nullable<decimal> IdCategoria {get;set;}

        public string DescripcionProducto {get;set;}

        public System.Nullable<decimal> CantidadVendida {get;set;}

        public System.Nullable<decimal> Precio {get;set;}

        public System.Nullable<decimal> DescuentoAplicado {get;set;}

        public string DescripcionTipoProducto {get;set;}

        public System.Nullable<int> PorcientoDescuento {get;set;}

        public System.Nullable<decimal> IdProducto {get;set;}

        public string Acumulativo {get;set;}

        public System.Nullable<decimal> ConectorProducto {get;set;}
        public System.Nullable<decimal> Impuesto { get; set; }
    }
}
