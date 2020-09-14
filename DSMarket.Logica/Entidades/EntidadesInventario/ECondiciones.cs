using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Entidades.EntidadesInventario
{
    public class ECondiciones
    {
		public decimal? IdCondicion {get;set;}

		public string Condicion {get;set;}

		public System.Nullable<bool> Estatus0 {get;set;}

		public string Estatus {get;set;}

		public System.Nullable<decimal> UsuarioAdiciona {get;set;}

		public string CreadoPor {get;set;}

		public System.Nullable<System.DateTime> FechaAdiciona {get;set;}

		public string FechaCreado {get;set;}

		public System.Nullable<decimal> UsuarioModifica {get;set;}

		public string ModificadoPor {get;set;}

		public System.Nullable<System.DateTime> FechaModifica {get;set;}

		public string FechaModificado {get;set;}
		public System.Nullable<int> CantidadRegistros { get; set; }
	}
}
