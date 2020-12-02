using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Entidades.EntidadesServicio
{
    public class EComisionesEmpleados
    {
		public decimal? IdRegistro {get;set;}

		public System.Nullable<decimal> IdEmpleado {get;set;}

		public string Empleado {get;set;}

		public System.Nullable<decimal> IdTipoProducto {get;set;}

		public string TipoProducto {get;set;}

		public System.Nullable<decimal> PrecioProducto {get;set;}

		public System.Nullable<decimal> DescuentoAplicado {get;set;}

		public System.Nullable<decimal> ComisionEmpleado {get;set;}

		public System.Nullable<decimal> ComisionPagar {get;set;}

		public System.Nullable<decimal> NumeroConectorOperacion {get;set;}

		public System.Nullable<decimal> IdProducto {get;set;}

		public System.Nullable<decimal> ConectorProducto {get;set;}

		public System.Nullable<System.DateTime> Fecha {get;set;}

		public string FechaProceso {get;set;}

		public System.Nullable<int> CantidadRegistros {get;set;}

		public System.Nullable<int> CantidadVentas {get;set;}

		public System.Nullable<int> CantidadServicios {get;set;}
	}
}
