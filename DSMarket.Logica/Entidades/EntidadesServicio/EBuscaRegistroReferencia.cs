using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Entidades.EntidadesServicio
{
    public class EBuscaRegistroReferencia
    {
		public System.Nullable<decimal> NumeroConector {get;set;}

		public decimal? IdFactura {get;set;}

		public string Referencia {get;set;}
		public string Producto { get; set; }

		public string Estatus {get;set;}

		public string DescripcionTipoProducto {get;set;}

		public System.Nullable<decimal> IdTipoProducto {get;set;}

		public string TipoProducto {get;set;}

		public System.Nullable<decimal> IdCategoria {get;set;}

		public string Categoria {get;set;}

		public string FechaFacturacion {get;set;}

		public System.Nullable<decimal> CantidadVendida {get;set;}

		public System.Nullable<decimal> Precio {get;set;}

		public System.Nullable<int> PorcientoDescuento {get;set;}

		public string Acumulativo {get;set;}

		public System.Nullable<decimal> DescuentoAplicado {get;set;}

		public System.Nullable<decimal> Impuesto {get;set;}

		public System.Nullable<decimal> Total {get;set;}

		public System.Nullable<decimal> IdProducto {get;set;}

		public string ProductoInventario {get;set;}

		public System.Nullable<int> CantidadRegistros {get;set;}
	}
}
