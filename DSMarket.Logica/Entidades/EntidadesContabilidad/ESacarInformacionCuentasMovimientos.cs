using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Entidades.EntidadesContabilidad
{
    public class ESacarInformacionCuentasMovimientos
    {
		public System.Nullable<decimal> IdRegistro {get;set;}

		public string Ano {get;set;}

		public string Mes {get;set;}

		public System.Nullable<int> IdTipoCuenta {get;set;}

		public string TipoCuenta {get;set;}

		public System.Nullable<int> IdModulo {get;set;}

		public string Modulo {get;set;}

		public System.Nullable<decimal> Conector {get;set;}

		public System.Nullable<decimal> Secuencia {get;set;}

		public System.Nullable<decimal> Banco {get;set;}

		public string NombreBanco {get;set;}

		public string Cuenta {get;set;}

		public string Auxiliar {get;set;}

		public System.Nullable<decimal> Valor {get;set;}

		public System.Nullable<int> IdOrigen {get;set;}

		public string OrigenCuenta {get;set;}

		public string ConceptoCuenta {get;set;}

		public System.Nullable<decimal> NumeroRelacionado {get;set;}

		public System.Nullable<int> IdClaseCuenta {get;set;}

		public string ClaseCuenta {get;set;}

		public System.Nullable<decimal> IdCuentaContable {get;set;}

		public string CuentaDescargo {get;set;}
	}
}
