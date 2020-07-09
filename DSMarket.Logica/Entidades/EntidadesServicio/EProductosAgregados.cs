using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Entidades.EntidadesServicio
{
    public class EProductosAgregados
    {
        public System.Nullable<decimal> NumeroConector {get;set;}

        public System.Nullable<decimal> IdTipoProducto {get;set;}

        public string DescripcionTipoProducto {get;set;}

        public System.Nullable<decimal> IdCategoria {get;set;}

        public string Categoria {get;set;}

        public string DescripcionProducto {get;set;}

        public System.Nullable<decimal> Precio {get;set;}

        public System.Nullable<decimal> Cantidad {get;set;}

        public System.Nullable<decimal> DescuentoAplicado {get;set;}

        public System.Nullable<decimal> Total {get;set;}

        public string DescripcionTipoProducto1 {get;set;}

        public System.Nullable<int> PorcientoDescuento {get;set;}

        public string Acumulativo {get;set;}

        public System.Nullable<decimal> IdProducto {get;set;}

        public System.Nullable<decimal> ConectorProducto {get;set;}

        public string AplicaImpuesto {get;set;}

        public System.Nullable<decimal> Impuesto {get;set;}

        public System.Nullable<decimal> CantidadProductos {get;set;}

        public System.Nullable<decimal> CantidadServicios {get;set;}

        public System.Nullable<decimal> CantidadRegistros {get;set;}

        public System.Nullable<decimal> TotalDescuento {get;set;}

        public System.Nullable<int> PorcientoImpuesto {get;set;}

        public System.Nullable<decimal> SubTotal {get;set;}

        public System.Nullable<decimal> TotalImpuesto {get;set;}

        public System.Nullable<decimal> TotalGeneral {get;set;}
    }
}
