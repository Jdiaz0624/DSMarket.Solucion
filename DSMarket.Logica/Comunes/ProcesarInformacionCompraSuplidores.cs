using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes
{
    public class ProcesarInformacionCompraSuplidores
    {
        public readonly Lazy<DSMarket.Logica.Logica.LogicaEmpresa.LogicaEmpresa> ObjDataEmpresa = new Lazy<Logica.LogicaEmpresa.LogicaEmpresa>();

        //DECLARAMOS LAS VARIABLES NECESARIAS PARA REALIZAR ESTE PROCESO
        private decimal IdCompraSuplidor = 0;
        private decimal IdTipoSuplidor = 0;
        private decimal IdSuplidor = 0;
        private string RNCCedula = "";
        private decimal IdTipoIdentificacion = 0;
        private decimal IdTipoBienesServicios = 0;
        private string NCF = "";
        private string NCFModificado = "";
        private DateTime FechaComprobante = DateTime.Now;
        private DateTime FechaPago = DateTime.Now;
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
        private decimal MontoRetencionRenta = 0;
        private decimal ISRPercibidoCompras = 0;
        private decimal ImpuestoSelectivoConsumo = 0;
        private decimal OtrosImpuestosTasa = 0;
        private decimal MontoPropinaLegal = 0;
        private decimal IdFormaPago = 0;
        private decimal UsuarioAdiciona = 0;
        private DateTime FechaCreado = DateTime.Now;
        private string Accion = "";

        public ProcesarInformacionCompraSuplidores(
        decimal IdCompraSuplidorCON,
        decimal IdTipoSuplidorCON,
        decimal IdSuplidorCON,
        string RNCCedulaCON,
        decimal IdTipoIdentificacionCON,
        decimal IdTipoBienesServiciosCON,
        string NCFCON,
        string NCFModificadoCON,
        DateTime FechaComprobanteCON,
        DateTime FechaPagoCON,
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
        decimal MontoRetencionRentaCON,
        decimal ISRPercibidoComprasCON,
        decimal ImpuestoSelectivoConsumoCON,
        decimal OtrosImpuestosTasaCON,
        decimal MontoPropinaLegalCON,
        decimal IdFormaPagoCON,
        decimal UsuarioAdicionaCON,
        DateTime FechaCreadoCON,
        string AccionCON)
        {
            IdCompraSuplidor = IdCompraSuplidorCON;
            IdTipoSuplidor = IdTipoSuplidorCON;
            IdSuplidor = IdSuplidorCON;
            RNCCedula = RNCCedulaCON;
            IdTipoIdentificacion = IdTipoIdentificacionCON;
            IdTipoBienesServicios = IdTipoBienesServiciosCON;
            NCF = NCFCON;
            NCFModificado = NCFModificadoCON;
            FechaComprobante = FechaComprobanteCON;
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
            MontoRetencionRenta = MontoRetencionRentaCON;
            ISRPercibidoCompras = ISRPercibidoComprasCON;
            ImpuestoSelectivoConsumo = ImpuestoSelectivoConsumoCON;
            OtrosImpuestosTasa = OtrosImpuestosTasaCON;
            MontoPropinaLegal = MontoPropinaLegalCON;
            IdFormaPago = IdFormaPagoCON;
            UsuarioAdiciona = UsuarioAdicionaCON;
            FechaCreado = FechaCreadoCON;
            Accion = AccionCON;
        }

        public void PrcesarInformacion() {
            DSMarket.Logica.Entidades.EntidadesEmpresa.ECompraSuplidores Procesar = new Entidades.EntidadesEmpresa.ECompraSuplidores();

            Procesar.IdCompraSuplidor = IdCompraSuplidor;
            Procesar.IdTipoSuplidor = IdTipoSuplidor;
            Procesar.IdSuplidor = IdSuplidor;
            Procesar.RNCCedula = RNCCedula;
            Procesar.IdTipoIdentificacion = IdTipoIdentificacion;
            Procesar.IdTipoBienesServicios = IdTipoBienesServicios;
            Procesar.NCF = NCF;
            Procesar.NCFModificado = NCFModificado;
            Procesar.FechaComprobante0 = FechaComprobante;
            Procesar.FechaPago0 = FechaPago;
            Procesar.MontoFacturadoServicios = MontoFacturadoServicios;
            Procesar.MontoFacturadoBienes = MontoFacturadoBienes;
            Procesar.TotalMontoFacturado = TotalMontoFacturado;
            Procesar.ITBISFacturado = ITBISFacturado;
            Procesar.ITBISRetenido = ITBISRetenido;
            Procesar.ITBISSujetoProporcionalidad = ITBISSujetoProporcionalidad;
            Procesar.ITBISLlevadoCosto = ITBISLlevadoCosto;
            Procesar.ITBISPorAdelantar = ITBISPorAdelantar;
            Procesar.ITBISPercibidoCompras = ITBISPercibidoCompras;
            Procesar.ImpuestoSelectivoConsumo = ImpuestoSelectivoConsumo;
            Procesar.OtrosImpuestosTasa = OtrosImpuestosTasa;
            Procesar.MontoPropinaLegal = MontoPropinaLegal;
            Procesar.IdFormaPago = IdFormaPago;
            Procesar.UsuarioAdiciona = UsuarioAdiciona;
            Procesar.FechaCreado0 = FechaCreado;

            var MAN = ObjDataEmpresa.Value.MantenimientoCompraSuplidores(Procesar, Accion);
        }
    }
}
