using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Entidades.EntidadesServicio
{
    public class EFacturaMinimizada
    {
		public System.Nullable<decimal> IdUsuario {get;set;}

		public string Usuario {get;set;}

		public System.Nullable<decimal> NumeroConector {get;set;}

		public System.Nullable<decimal> Secuencia {get;set;}

		public System.Nullable<bool> AgregarCliente {get;set;}

		public System.Nullable<bool> BuscarCliente {get;set;}

		public System.Nullable<int> IdTipoVenta {get;set;}

		public string TipoVenta {get;set;}

		public System.Nullable<int> IdCantidadDias {get;set;}

		public string CantidadDias {get;set;}

		public string RncConsulta {get;set;}

		public System.Nullable<decimal> IdComprobante {get;set;}

		public string Comprobante {get;set;}

		public string Nombre {get;set;}

		public string Telefono {get;set;}

		public string Email {get;set;}

		public System.Nullable<decimal> NoCotizacion {get;set;}

		public System.Nullable<decimal> IdTipoIdentificacion {get;set;}

		public string TipoIdentificacion {get;set;}

		public string NumeroIdentificacion {get;set;}

		public string Comentario {get;set;}

		public System.Nullable<decimal> MontoCredito {get;set;}

		public System.Nullable<bool> FacturarCotizar {get;set;}

		public System.Nullable<bool> FacturaPuntoVenta {get;set;}

		public System.Nullable<bool> FormatoFactura {get;set;}

		public System.Nullable<bool> BloqueaControles {get;set;}

		public System.Nullable<int> CantidadDiasGarantia {get;set;}

		public System.Nullable<int> IdTipoIngreso {get;set;}

		public string TipoIngreso {get;set;}

		public System.Nullable<int> IdTipoTiempoGarantia {get;set;}

		public string TipoTiempoGarantia {get;set;}

		public System.Nullable<int> Cantidadregistros {get;set;}

	}
}
