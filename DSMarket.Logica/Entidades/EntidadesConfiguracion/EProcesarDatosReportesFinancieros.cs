using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Entidades.EntidadesConfiguracion
{
    public class EProcesarDatosReportesFinancieros
    {
		public System.Nullable<decimal> IdUsuario {get;set;}

		public System.Nullable<decimal> IdRegistro {get;set;}

		public string Ano {get;set;}

		public string Mes {get;set;}

		public System.Nullable<int> IdTipoCuenta {get;set;}

		public string TipoCuenta {get;set;}

		public System.Nullable<int> IdModulo {get;set;}

		public string Modulo {get;set;}

		public System.Nullable<decimal> Conector {get;set;}

		public System.Nullable<int> Secuencia {get;set;}

		public System.Nullable<int> Banco {get;set;}

		public string NombreBanco {get;set;}

		public string Cuenta {get;set;}

		public string Auxiliar {get;set;}

		public System.Nullable<decimal> Valor {get;set;}

		public System.Nullable<int> IdOrigenCuenta {get;set;}

		public string OrigenCuenta {get;set;}

		public string CuentaConcepto {get;set;}

		public System.Nullable<decimal> NumeroRelacionado {get;set;}

		public System.Nullable<int> IdClaseCuenta {get;set;}

		public string ClaseCuenta {get;set;}

		public System.Nullable<decimal> IdCuentaContable {get;set;}

		public System.Nullable<int> Cuentadescargo {get;set;}
	}
}
