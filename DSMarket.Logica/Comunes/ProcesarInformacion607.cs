using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes
{
    public class ProcesarInformacion607
    {
        public readonly Lazy<DSMarket.Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion> ObjDataConfiguracion = new Lazy<Logica.LogicaConfiguracion.LogicaCOnfiguracion>();


        private decimal  IdUsuario = 0;
        private string   NumeroIdentificacion = "";
        private string   TipoIdentificacion = "";
        private decimal  IdTipoIdentificacion = 0;
        private string   NCF = "";
        private string   NCFModificado = "";
        private decimal  IdTipoIngreso = 0;
        private string   TipoIngreso = "";
        private string   CodigoTipoIngreso = "";
        private DateTime FechaFacturacion = DateTime.Now;
        private string   FechaArchivo = "";
        private string   FechaRetencion = "";
        private decimal  MontoFacturado = 0;
        private decimal  ImpuestoFacturado = 0;
        private decimal  ITBISRetenidoPorTerceros = 0;
        private decimal  ITBISPercibido = 0;
        private decimal  RetencionRentaPorTerceros = 0;
        private decimal  ISRPercibido = 0;
        private decimal  ImpuestoSostenidoConsumo = 0;
        private decimal  OtrosImpuestoTasa = 0;
        private decimal  MontoPropinaLegal = 0;
        private decimal  MontoEfectivo = 0;
        private decimal  MontoChequeTransferenciaDeposito = 0;
        private decimal  MontoTarjetaDebitoCredito = 0;
        private decimal  MontoVentaCredito = 0;
        private decimal  BonosCertificadosRegalos = 0;
        private decimal  Permuta = 0;
        private decimal  OtrasFormasVenta = 0;
        private decimal  CantidadRegistros = 0;
        private DateTime FechaDesde = DateTime.Now;
        private DateTime FechaHasta = DateTime.Now;
        private string Accion = "";



        public ProcesarInformacion607(
           decimal  IdUsuarioCON,
           string   NumeroIdentificacionCON,
           string   TipoIdentificacionCON,
           decimal  IdTipoIdentificacionCON,
           string   NCFCON,
           string   NCFModificadoCON,
           decimal  IdTipoIngresoCON,
           string   TipoIngresoCON,
           string   CodigoTipoIngresoCON,
           DateTime FechaFacturacionCON,
           string   FechaArchivoCON,
           string   FechaRetencionCON,
           decimal  MontoFacturadoCON,
           decimal  ImpuestoFacturadoCON,
           decimal  ITBISRetenidoPorTercerosCON,
           decimal  ITBISPercibidoCON,
           decimal  RetencionRentaPorTercerosCON,
           decimal  ISRPercibidoCON,
           decimal  ImpuestoSostenidoConsumoCON,
           decimal  OtrosImpuestoTasaCON,
           decimal  MontoPropinaLegalCON,
           decimal  MontoEfectivoCON,
           decimal  MontoChequeTransferenciaDepositoCON,
           decimal  MontoTarjetaDebitoCreditoCON,
           decimal  MontoVentaCreditoCON,
           decimal  BonosCertificadosRegalosCON,
           decimal  PermutaCON,
           decimal  OtrasFormasVentaCON,
           decimal  CantidadRegistrosCON,
           DateTime FechaDesdeCON,
           DateTime FechaHastaCON,
           string AccionCON
            )
        {
            IdUsuario = IdUsuarioCON;
            NumeroIdentificacion = NumeroIdentificacionCON;
            TipoIdentificacion = TipoIdentificacionCON;
            IdTipoIdentificacion = IdTipoIdentificacionCON;
            NCF = NCFCON;
            NCFModificado = NCFModificadoCON;
            IdTipoIngreso = IdTipoIngresoCON;
            TipoIngreso = TipoIngresoCON;
            CodigoTipoIngreso = CodigoTipoIngresoCON;
            FechaFacturacion = FechaFacturacionCON;
            FechaArchivo = FechaArchivoCON;
            FechaRetencion = FechaRetencionCON;
            MontoFacturado = MontoFacturadoCON;
            ImpuestoFacturado = ImpuestoFacturadoCON;
            ITBISRetenidoPorTerceros = ITBISRetenidoPorTercerosCON;
            ITBISPercibido = ITBISPercibidoCON;
            RetencionRentaPorTerceros = RetencionRentaPorTercerosCON;
            ISRPercibido = ISRPercibidoCON;
            ImpuestoSostenidoConsumo = ImpuestoSostenidoConsumoCON;
            OtrosImpuestoTasa = OtrosImpuestoTasaCON;
            MontoPropinaLegal = MontoPropinaLegalCON;
            MontoEfectivo = MontoEfectivoCON;
            MontoChequeTransferenciaDeposito = MontoChequeTransferenciaDepositoCON;
            MontoTarjetaDebitoCredito = MontoTarjetaDebitoCreditoCON;
            MontoVentaCredito = MontoVentaCreditoCON;
            BonosCertificadosRegalos = BonosCertificadosRegalosCON;
            Permuta = PermutaCON;
            OtrasFormasVenta = OtrasFormasVentaCON;
            CantidadRegistros = CantidadRegistrosCON;
            FechaDesde = FechaDesdeCON;
            FechaHasta = FechaHastaCON;
            Accion = AccionCON;
        }

        public void ProcesarInformacion() {
            DSMarket.Logica.Entidades.EntidadesConfiguracion.EProcesarInformacion607 Procesar = new Entidades.EntidadesConfiguracion.EProcesarInformacion607();

            Procesar.IdUsuario = IdUsuario;
            Procesar.NumeroIdentificacion = NumeroIdentificacion;
            Procesar.TipoIdentificacion = TipoIdentificacion;
            Procesar.IdTipoIdentificacion = IdTipoIdentificacion;
            Procesar.NCF = NCF;
            Procesar.NCFModificado = NCFModificado;
            Procesar.IdTipoIngreso = IdTipoIngreso;
            Procesar.TipoIngreso = TipoIngreso;
            Procesar.CodigoTipoIngreso = CodigoTipoIngreso;
            Procesar.FechaFacturacion = FechaFacturacion;
            Procesar.FechaArchivo = FechaArchivo;
            Procesar.MontoFacturado = MontoFacturado;
            Procesar.ImpuestoFacturado = ImpuestoFacturado;
            Procesar.ITBISRetenidoPorTerceros = ITBISRetenidoPorTerceros;
            Procesar.ITBISPercibido = ITBISPercibido;
            Procesar.RetencionRentaPorTerceros = RetencionRentaPorTerceros;
            Procesar.ISRPercibido = ISRPercibido;
            Procesar.ImpuestoSostenidoConsumo = ImpuestoSostenidoConsumo;
            Procesar.OtrosImpuestoTasa = OtrosImpuestoTasa;
            Procesar.MontoPropinaLegal = MontoPropinaLegal;
            Procesar.MontoEfectivo = MontoPropinaLegal;
            Procesar.MontoChequeTransferenciaDeposito = MontoChequeTransferenciaDeposito;
            Procesar.MontoTarjetaDebitoCredito = MontoTarjetaDebitoCredito;
            Procesar.MontoVentaCredito = MontoVentaCredito;
            Procesar.BonosCertificadosRegalos = BonosCertificadosRegalos;
            Procesar.Permuta = Permuta;
            Procesar.OtrasFormasVenta = OtrasFormasVenta;
            Procesar.CantidadRegistros = CantidadRegistros;
            Procesar.FechaDesde = FechaDesde;
            Procesar.FechaHasta = FechaHasta;

            var MAN = ObjDataConfiguracion.Value.ProcesarInformacion607(Procesar, Accion);



        }
    }

  
}
