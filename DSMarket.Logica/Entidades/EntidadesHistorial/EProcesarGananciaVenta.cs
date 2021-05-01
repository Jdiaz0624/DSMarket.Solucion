using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Entidades.EntidadesHistorial
{
    public class EProcesarGananciaVenta
    {
		public System.Nullable<decimal> IdUsuario {get;set;}

		public System.Nullable<decimal> IdEstatusFacturacion {get;set;}

		public string Estatus {get;set;}

		public System.Nullable<decimal> NumeroFactura {get;set;}

		public string Descripcion {get;set;}

		public System.Nullable<decimal> IdCategoria {get;set;}

		public System.Nullable<decimal> IdTipoProducto {get;set;}

		public System.Nullable<decimal> PrecioCompra {get;set;}

		public System.Nullable<decimal> PrecioVenta {get;set;}

		public System.Nullable<decimal> CantidadVendida {get;set;}
		public System.Nullable<decimal> DescuentoAplicado { get; set; }

		public System.Nullable<decimal> TotalDescuentoAplicado {get;set;}

		public System.Nullable<decimal> TotalVenta {get;set;}

		public System.Nullable<decimal> TotalPrecioCompra {get;set;}

		public System.Nullable<decimal> Ganancia {get;set;}
	}
}
