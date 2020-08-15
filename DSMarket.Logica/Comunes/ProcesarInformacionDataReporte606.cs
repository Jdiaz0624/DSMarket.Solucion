using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes
{
    public class ProcesarInformacionDataReporte606 : Logica.LogicaConfiguracion.LogicaCOnfiguracion
    {
      //  public readonly Lazy<DSMarket.Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion> Conexion = new Lazy<Logica.LogicaConfiguracion.LogicaCOnfiguracion>();

        //DECLARAMOS LAS VARIABLES NECESARIAS PARA ESTE PROCESO
        private decimal IdUsuario = 0;
        private decimal IdCompraSuplidor = 0;
        private decimal IdTipoSuplidor = 0;
        private string TipoSuplidor = "";
        private decimal IdSuplidor = 0;
        private string Suplidor = "";
        private string RNCCedula = "";
        private decimal IdTipoIdentificacion = 0;
        private string TipoIdentificacion = "";
        private decimal IdTipoBienesServicios = 0;
        private string TipoBienesServicios = "";
        private string CodigoTipoBienesServicio = "";
        private string NCF = "";
        private string NCFMODIFICADO = "";
        private DateTime FechaComprobante0 = DateTime.Now;
        private string FechaComprobante = "";
        private DateTime FechaPago0 = DateTime.Now;
        private string FechaPago = "";
        private decimal MontoFacturadoServicios = 0;
        private decimal MontoFacturadoBienes = 0;
        private decimal TotalMontoFacturado = 0;
        private decimal ITBISFacturado = 0;
        private decimal ITBISRetenido = 0;
        private decimal ITBISSujetoProporcionalidad = 0;
        private decimal ITBISLlevadoCosto = 0;
        private decimal ITBISPorAdelantar = 0;
        private decimal ITBISPercibidoCompras = 0;
        private decimal IdTipoRetencionISR = 0;
        private string TipoRetencionISR = "";
        private string CodigoTipoRetencionISR = "";
        private decimal MontoRetencionRenta = 0;
        private decimal ISRPercibidoCompras = 0;
        private decimal ImpuestoSelectivoConsumo = 0;
        private decimal OtrosImpuestosTasa = 0;
        private decimal MontoPropinaLegal = 0;
        private decimal IdFormaPago = 0;
        private string FormaPago = "";
        private string CodigoTipoPago = "";
        private decimal UsuarioAdiciona = 0;
        private string CreadoPor = "";
        private DateTime FechaCreado0 = DateTime.Now;
        private string FechaCreado = "";
        private decimal CantidadRegistros = 0;
        private string Accion = "";

        //CREAMOS UN CONSTUTRUCTOR PARA PASARLE LOS DATOS A LAS VARIABLES
        public ProcesarInformacionDataReporte606(
              decimal IdUsuarioCON,
              decimal IdCompraSuplidorCON,
              decimal IdTipoSuplidorCON,
              string TipoSuplidorCON,
              decimal IdSuplidorCON,
              string SuplidorCON,
              string RNCCedulaCON,
              decimal IdTipoIdentificacionCON,
              string TipoIdentificacionCON,
              decimal IdTipoBienesServiciosCON,
              string TipoBienesServiciosCON,
              string CodigoTipoBienesServicioCON,
              string NCFCON,
              string NCFMODIFICADOCON,
              DateTime FechaComprobante0CON,
              string FechaComprobanteCON,
              DateTime FechaPago0CON,
              string FechaPagoCON,
              decimal MontoFacturadoServiciosCON,
              decimal MontoFacturadoBienesCON,
              decimal TotalMontoFacturadoCON,
              decimal ITBISFacturadoCON,
              decimal ITBISRetenidoCON,
              decimal ITBISSujetoProporcionalidadCON,
              decimal ITBISLlevadoCostoCON,
              decimal ITBISPorAdelantarCON,
              decimal ITBISPercibidoComprasCON,
              decimal IdTipoRetencionISRCON,
              string TipoRetencionISRCON,
              string CodigoTipoRetencionISRCON,
              decimal MontoRetencionRentaCON,
              decimal ISRPercibidoComprasCON,
              decimal ImpuestoSelectivoConsumoCON,
              decimal OtrosImpuestosTasaCON,
              decimal MontoPropinaLegalCON,
              decimal IdFormaPagoCON,
              string FormaPagoCON,
              string CodigoTipoPagoCON,
              decimal UsuarioAdicionaCON,
              string CreadoPorCON,
              DateTime FechaCreado0CON,
              string FechaCreadoCON,
              decimal CantidadRegistrosCON,
              string AccionCON
            )
        {
            IdUsuario = IdUsuarioCON;
            IdCompraSuplidor = IdCompraSuplidorCON;
            IdTipoSuplidor = IdTipoSuplidorCON;
            TipoSuplidor = TipoSuplidorCON;
            IdSuplidor = IdSuplidorCON;
            Suplidor = SuplidorCON;
            RNCCedula = RNCCedulaCON;
            IdTipoIdentificacion = IdTipoIdentificacionCON;
            TipoIdentificacion = TipoIdentificacionCON;
            IdTipoBienesServicios = IdTipoBienesServiciosCON;
            TipoBienesServicios = TipoBienesServiciosCON;
            CodigoTipoBienesServicio = CodigoTipoBienesServicioCON;
            NCF = NCFCON;
            NCFMODIFICADO = NCFMODIFICADOCON;
            FechaComprobante0 = FechaComprobante0CON;
            FechaComprobante = FechaComprobanteCON;
            FechaPago0 = FechaPago0CON;
            FechaPago = FechaPagoCON;
            MontoFacturadoServicios = MontoFacturadoServiciosCON;
            MontoFacturadoBienes = MontoFacturadoBienesCON;
            TotalMontoFacturado = TotalMontoFacturadoCON;
            ITBISFacturado = ITBISFacturadoCON;
            ITBISRetenido = ITBISRetenidoCON;
            ITBISSujetoProporcionalidad = ITBISSujetoProporcionalidadCON;
            ITBISLlevadoCosto = ITBISLlevadoCostoCON;
            ITBISPorAdelantar = ITBISPorAdelantarCON;
            ITBISPercibidoCompras = ITBISPercibidoComprasCON;
            IdTipoRetencionISR = IdTipoRetencionISRCON;
            TipoRetencionISR = TipoRetencionISRCON;
            CodigoTipoRetencionISR = CodigoTipoRetencionISRCON;
            MontoRetencionRenta = MontoRetencionRentaCON;
            ISRPercibidoCompras = ISRPercibidoComprasCON;
            ImpuestoSelectivoConsumo = ImpuestoSelectivoConsumoCON;
            OtrosImpuestosTasa = OtrosImpuestosTasaCON;
            MontoPropinaLegal = MontoPropinaLegalCON;
            IdFormaPago = IdFormaPagoCON;
            FormaPago = FormaPagoCON;
            CodigoTipoPago = CodigoTipoPagoCON;
            UsuarioAdiciona = UsuarioAdicionaCON;
            CreadoPor = CreadoPorCON;
            FechaCreado0 = FechaCreado0CON;
            FechaCreado = FechaCreadoCON;
            CantidadRegistros = CantidadRegistrosCON;
            Accion = AccionCON;
    }
        public void ProcesarInformacionReporte606() {
            DSMarket.Logica.Entidades.EntidadesConfiguracion.EGuardarDatosReporte606 Procesar = new Entidades.EntidadesConfiguracion.EGuardarDatosReporte606();

            Procesar.IdUsuario = IdUsuario;
            Procesar.IdCompraSuplidor = IdCompraSuplidor;
            Procesar.IdTipoSuplidor = IdTipoSuplidor;
            Procesar.TipoSuplidor = TipoSuplidor;
            Procesar.IdSuplidor = IdSuplidor;
            Procesar.Suplidor = Suplidor;
            Procesar.RNCCedula = RNCCedula;
            Procesar.IdTipoIdentificacion = IdTipoIdentificacion;
            Procesar.TipoIdentificacion = TipoIdentificacion;
            Procesar.IdTipoBienesServicios = IdTipoBienesServicios;
            Procesar.TipoBienesServicios = TipoBienesServicios;
            Procesar.CodigoTipoBienesServicio = CodigoTipoBienesServicio;
            Procesar.NCF = NCF;
            Procesar.NCFMODIFICADO = NCFMODIFICADO;
            Procesar.FechaComprobante0 = FechaComprobante0;
            Procesar.FechaComprobante = FechaComprobante;
            Procesar.FechaPago0 = FechaPago0;
            Procesar.FechaPago = FechaPago;
            Procesar.MontoFacturadoServicios = MontoFacturadoServicios;
            Procesar.MontoFacturadoBienes = MontoFacturadoBienes;
            Procesar.TotalMontoFacturado = TotalMontoFacturado;
            Procesar.ITBISFacturado = ITBISFacturado;
            Procesar.ITBISRetenido = ITBISRetenido;
            Procesar.ITBISSujetoProporcionalidad = ITBISSujetoProporcionalidad;
            Procesar.ITBISLlevadoCosto = ITBISLlevadoCosto;
            Procesar.ITBISPorAdelantar = ITBISPorAdelantar;
            Procesar.ITBISPercibidoCompras = ITBISPercibidoCompras;
            Procesar.IdTipoRetencionISR = IdTipoRetencionISR;
            Procesar.TipoRetencionISR = TipoRetencionISR;
            Procesar.CodigoTipoRetencionISR = CodigoTipoRetencionISR;
            Procesar.MontoRetencionRenta = MontoRetencionRenta;
            Procesar.ISRPercibidoCompras = ISRPercibidoCompras;
            Procesar.ImpuestoSelectivoConsumo = ImpuestoSelectivoConsumo;
            Procesar.OtrosImpuestosTasa = OtrosImpuestosTasa;
            Procesar.MontoPropinaLegal = MontoPropinaLegal;
            Procesar.IdFormaPago = IdFormaPago;
            Procesar.FormaPago = FormaPago;
            Procesar.CodigoTipoPago = CodigoTipoPago;
            Procesar.UsuarioAdiciona = UsuarioAdiciona;
            Procesar.CreadoPor = CreadoPor;
            Procesar.FechaCreado0 = FechaCreado0;
            Procesar.FechaCreado = FechaCreado;
            Procesar.CantidadRegistros = CantidadRegistros;

            var MAN = GuardarDatosReporte606(Procesar, Accion);


    }
    }
}
