﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Entidades.EntidadesServicio
{
    public class EFacturacion
    {
		public System.Nullable<decimal> NumeroFactura{get;set;}

		public string NumeroConector{get;set;}

		public string FacturadoA{get;set;}

		public System.Nullable<decimal> CodigoCliente{get;set;}

		public System.Nullable<decimal> IdTipoFacturacion{get;set;}

		public string Comentario{get;set;}

		public System.Nullable<int> TotalProductos{get;set;}

		public System.Nullable<int> TotalServicios{get;set;}

		public System.Nullable<int> TotalItems{get;set;}

		public System.Nullable<decimal> SubTotal{get;set;}

		public System.Nullable<decimal> DescuentoTotal{get;set;}

		public System.Nullable<decimal> ImpuestoTotal{get;set;}

		public System.Nullable<decimal> TotalGeneral{get;set;}

		public System.Nullable<decimal> IdTipoPago{get;set;}

		public System.Nullable<decimal> MontoPagado{get;set;}

		public System.Nullable<decimal> Cambio{get;set;}

		public System.Nullable<decimal> IdMoneda{get;set;}

		public System.Nullable<decimal> Tasa{get;set;}

		public System.Nullable<decimal> IdUsuario{get;set;}

		public System.Nullable<System.DateTime> FechaFacturacion{get;set;}

		public System.Nullable<decimal> IdComprobante{get;set;}

		public string ValidoHasta{get;set;}

		public string NumeroComprobante{get;set;}

		public System.Nullable<bool> EfectivoMixto { get; set; }

		public System.Nullable<decimal> MontoEfectivoMixto { get; set; }

		public System.Nullable<bool> ChequeMixto { get; set; }

		public System.Nullable<decimal> MontoChequeMixto { get; set; }

		public System.Nullable<bool> TransferenciaMixto { get; set; }

		public System.Nullable<decimal> MontoTransferenciaMixto { get; set; }

		public System.Nullable<bool> DepositoMixto { get; set; }

		public System.Nullable<decimal> MontoDepositoMixto { get; set; }

		public System.Nullable<bool> TarjetaMixto { get; set; }

		public System.Nullable<decimal> MontoTarjetaMixto { get; set; }
	}
}
