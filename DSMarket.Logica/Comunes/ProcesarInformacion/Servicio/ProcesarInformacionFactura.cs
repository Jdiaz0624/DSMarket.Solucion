﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes.ProcesarInformacion.Servicio
{
    public class ProcesarInformacionFactura
    {
        readonly DSMarket.Logica.Logica.LogicaServicio.LogicaServicio ObjDta = new Logica.LogicaServicio.LogicaServicio();

        private decimal NumeroFactura = 0;
        private string NumeroConector = "";
        private string FacturadoA = "";
        private decimal CodigoCliente = 0;
        private decimal IdTipoFacturacion = 0;
        private string Comentario = "";
        private int TotalProductos = 0;
        private int TotalServicios = 0;
        private int TotalItems = 0;
        private decimal SubTotal = 0;
        private decimal DescuentoTotal = 0;
        private decimal ImpuestoTotal = 0;
        private decimal TotalGeneral = 0;
        private decimal IdTipoPago = 0;
        private decimal MontoPagado = 0;
        private decimal Cambio = 0;
        private decimal IdMoneda = 0;
        private decimal Tasa = 0;
        private decimal IdUsuario = 0;
        // FechaFacturacion DATETIME
        private decimal IdComprobante = 0;
        private string ValidoHasta = "";
        private string NumeroComprobante = "";
        private bool EfectivoMixto = false;
        private decimal MontoEfectivoMixto = 0;
        private bool chequeMixto = false;
        private decimal MontoChequeMixto = 0;
        private bool TransferenciaMixto = false;
        private decimal MontoTransferenciaMixto = 0;
        private bool DepositoMixto = false;
        private decimal MontoDepositoMixto = 0;
        private bool TarjetaMixto = false;
        private decimal MontoTarjetaMixto = 0;
        private string Accion = "";

        public ProcesarInformacionFactura(
            decimal NumeroFacturaCON,
            string NumeroConectorCON,
            string FacturadoACON,
            decimal CodigoClienteCON,
            decimal IdTipoFacturacionCON,
            string ComentarioCON,
            int TotalProductosCON,
            int TotalServiciosCON,
            int TotalItemsCON,
            decimal SubTotalCON,
            decimal DescuentoTotalCON,
            decimal ImpuestoTotalCON,
            decimal TotalGeneralCON,
            decimal IdTipoPagoCON,
            decimal MontoPagadoCON,
            decimal CambioCON,
            decimal IdMonedaCON,
            decimal TasaCON,
            decimal IdUsuarioCON,
            decimal IdComprobanteCON,
            string ValidoHastaCON,
            string NumeroComprobanteCON,
            bool EfectivoMixtoCON,
            decimal MontoEfectivoMixtoCON,
            bool chequeMixtoCON,
            decimal MontoChequeMixtoCON,
            bool TransferenciaMixtoCON,
            decimal MontoTransferenciaMixtoCON,
            bool DepositoMixtoCON,
            decimal MontoDepositoMixtoCON,
            bool TarjetaMixtoCON,
            decimal MontoTarjetaMixtoCON,
            string AccionCON)
        {
            NumeroFactura = NumeroFacturaCON;
            NumeroConector = NumeroConectorCON;
            FacturadoA = FacturadoACON;
            CodigoCliente = CodigoClienteCON;
            IdTipoFacturacion = IdTipoFacturacionCON;
            Comentario = ComentarioCON;
            TotalProductos = TotalProductosCON;
            TotalServicios = TotalServiciosCON;
            TotalItems = TotalItemsCON;
            SubTotal = SubTotalCON;
            DescuentoTotal = DescuentoTotalCON;
            ImpuestoTotal = ImpuestoTotalCON;
            TotalGeneral = TotalGeneralCON;
            IdTipoPago = IdTipoPagoCON;
            MontoPagado = MontoPagadoCON;
            Cambio = CambioCON;
            IdMoneda = IdMonedaCON;
            Tasa = TasaCON;
            IdUsuario = IdUsuarioCON;
            IdComprobante = IdComprobanteCON;
            ValidoHasta = ValidoHastaCON;
            NumeroComprobante = NumeroComprobanteCON;
            EfectivoMixto = EfectivoMixtoCON;
            MontoEfectivoMixto = MontoEfectivoMixtoCON;
            chequeMixto = chequeMixtoCON;
            MontoChequeMixto = MontoChequeMixtoCON;
            TransferenciaMixto = TransferenciaMixtoCON;
            MontoTransferenciaMixto = MontoTransferenciaMixtoCON;
            DepositoMixto = DepositoMixtoCON;
            MontoDepositoMixto = MontoDepositoMixtoCON;
            TarjetaMixto = TarjetaMixtoCON;
            MontoTarjetaMixto = MontoTarjetaMixtoCON;
            Accion = AccionCON;
        }

        /// <summary>
        /// Procesar la informacion de la factura
        /// </summary>
        public void ProcesarInformacion() {
            DSMarket.Logica.Entidades.EntidadesServicio.EFacturacion Procesar = new Entidades.EntidadesServicio.EFacturacion();

            Procesar.NumeroFactura = NumeroFactura;
            Procesar.NumeroConector = NumeroConector;
            Procesar.FacturadoA = FacturadoA;
            Procesar.CodigoCliente = CodigoCliente;
            Procesar.IdTipoFacturacion = IdTipoFacturacion;
            Procesar.Comentario = Comentario;
            Procesar.TotalProductos = TotalProductos;
            Procesar.TotalServicios = TotalServicios;
            Procesar.TotalItems = TotalItems;
            Procesar.SubTotal = SubTotal;
            Procesar.DescuentoTotal = DescuentoTotal;
            Procesar.ImpuestoTotal = ImpuestoTotal;
            Procesar.TotalGeneral = TotalGeneral;
            Procesar.IdTipoPago = IdTipoPago;
            Procesar.MontoPagado = MontoPagado;
            Procesar.Cambio = Cambio;
            Procesar.IdMoneda = IdMoneda;
            Procesar.Tasa = Tasa;
            Procesar.IdUsuario = IdUsuario;
            Procesar.FechaFacturacion = DateTime.Now;
            Procesar.IdComprobante = IdComprobante;
            Procesar.ValidoHasta = ValidoHasta;
            Procesar.NumeroComprobante = NumeroComprobante;
            Procesar.EfectivoMixto = EfectivoMixto;
            Procesar.MontoEfectivoMixto = MontoEfectivoMixto;
            Procesar.ChequeMixto = chequeMixto;
            Procesar.MontoChequeMixto = MontoChequeMixto;
            Procesar.TransferenciaMixto = TransferenciaMixto;
            Procesar.MontoTransferenciaMixto = MontoTransferenciaMixto;
            Procesar.DepositoMixto = DepositoMixto;
            Procesar.MontoDepositoMixto = MontoDepositoMixto;
            Procesar.TarjetaMixto = TarjetaMixto;
            Procesar.MontoTarjetaMixto = MontoTarjetaMixto;

            var MAn = ObjDta.ProcesarFacturacion(Procesar, Accion);
        }
    }
}
