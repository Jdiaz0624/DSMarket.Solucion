﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Entidades.EntidadesHistorial
{
    public class EItemsAgregadosFactura
    {
		public string Descripcion { get; set; }
		public decimal? NumeroFactura {get;set;}

		public string NumeroConector {get;set;}
		public decimal IdTipoFacturacion { get; set; }

		public string TipoFacturacion { get; set; }

		public string Anulada { get; set; }

		public string FacturadoA {get;set;}

		public string FechaFacturacion {get;set;}
		public string HoraFacturacion { get; set; }

		public System.Nullable<int> TotalProductos {get;set;}

		public System.Nullable<int> TotalServicios {get;set;}

		public System.Nullable<int> TotalItems {get;set;}

		public string Coenectordetalle {get;set;}

		public string Tipo {get;set;}

		public System.Nullable<decimal> Precio {get;set;}

		public System.Nullable<decimal> Descuento {get;set;}

		public System.Nullable<int> Cantidad {get;set;}

		public System.Nullable<int> PorcientoImpuesto {get;set;}

		public System.Nullable<decimal> SubTotal {get;set;}

		public System.Nullable<decimal> Impuesto {get;set;}

		public System.Nullable<decimal> Total {get;set;}

		public System.Nullable<decimal> IdRegistroRespaldo {get;set;}

		public string NumeroConectorItemRespaldo {get;set;}

		public System.Nullable<decimal> IdTipoProductoRespaldo {get;set;}

		public System.Nullable<decimal> IdCategoriaRespaldo {get;set;}

		public System.Nullable<decimal> IdMarcaRespaldo {get;set;}

		public System.Nullable<decimal> IdTipoSuplidorRespaldo {get;set;}

		public System.Nullable<decimal> IdSuplidorRespaldo {get;set;}

		

		public string CodigoBarraRespaldo {get;set;}

		public string Referencia {get;set;}

		public string NumeroSeguimientoRespaldo {get;set;}

		public string CodigoProductoRespaldo {get;set;}

		public System.Nullable<decimal> PrecioCompraRespaldo {get;set;}

		public System.Nullable<decimal> PrecioVentaRespaldo {get;set;}

		public System.Nullable<decimal> StockRespaldo {get;set;}

		public System.Nullable<decimal> StockMinimoRespaldo {get;set;}

		public string UnidadMedidaRespaldo {get;set;}

		public string ModeloRespaldo {get;set;}

		public string ColorRespaldo {get;set;}

		public string CondicionRespaldo {get;set;}

		public string CapacidadRespaldo {get;set;}

		public System.Nullable<bool> AplicaParaImpuestoRespaldo {get;set;}

		public System.Nullable<bool> TieneImagenRespaldo {get;set;}

		public System.Nullable<bool> LlevaGarantiaRespaldo {get;set;}

		public System.Nullable<decimal> IdTipoGarantiaRespaldo {get;set;}

		public System.Nullable<int> TiempoGarantiaRespaldo {get;set;}

		public string ComentarioItemRespaldo {get;set;}

		public System.Nullable<decimal> UsuarioAdicionaRespaldo {get;set;}

		public System.Nullable<System.DateTime> FechaAdicionaRespaldo {get;set;}

		public System.Nullable<decimal> UsuarioModificaRespaldo {get;set;}

		public System.Nullable<System.DateTime> FechaModificaRespaldo {get;set;}

		public System.Nullable<System.DateTime> FechaIngresoRespaldo {get;set;}
	}
}
