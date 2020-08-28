using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Entidades.EntidadesContabilidad
{
    public class ECatalogoCuentas
    {
		public System.Nullable<decimal> IdRegistro {get;set;}
		
		public string Cuenta {get;set;}
		
		public string Auxiliar {get;set;}
		
		public string NombreCuenta {get;set;}
		
		public System.Nullable<int> IdOrigenCuenta {get;set;}
		
		public string Origen {get;set;}
		
		public System.Nullable<int> IdTipoCuenta {get;set;}
		
		public string Tipo {get;set;}
		
		public System.Nullable<int> IdClaseCuenta {get;set;}
		
		public string Clase {get;set;}
		
		public System.Nullable<int> IdAceptaMovimientoCuenta {get;set;}
		
		public string AceptaMovimiento {get;set;}
		
		public System.Nullable<int> CodAnexo {get;set;}
		
		public string CuentaDescargo {get;set;}
		
		public string CuentaPresupuesto {get;set;}
		
		public string AuxiliarPresupuesto {get;set;}
		
		public System.Nullable<bool> Estatus0 {get;set;}
		
		public string Estatus {get;set;}
		
		public string CuentaAnterior {get;set;}
		
		public System.Nullable<int> UsuarioAdiciona {get;set;}
		
		public string CreadoPor {get;set;}
		
		public System.Nullable<System.DateTime> FechaAdiciona {get;set;}
		
		public string FechaCreado {get;set;}
		
		public System.Nullable<int> UsuarioModifica {get;set;}
		
		public string ModificadoPor {get;set;}
		
		public System.Nullable<System.DateTime> FechaModifica {get;set;}
		
		public string FechaModificado {get;set;}
	}
}
