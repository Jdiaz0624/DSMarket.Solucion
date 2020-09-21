using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes.ProcesarInformacion
{
    public class ProcesarDatosReporteFinanciero
    {
        readonly DSMarket.Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion Objdata = new Logica.LogicaConfiguracion.LogicaCOnfiguracion();

        private decimal IdUsuario = 0;
        private int TipoReporte = 0;
        private string CuentaAuxiliar = "";
        private string ConceptoCuenta = "";
        private decimal Valor = 0;
        private string Cuenta = "";
        private string CuentaDescargo = "";
        private string Ano = "";
        private string Mes = "";
        private string Accion = "";

        public ProcesarDatosReporteFinanciero(
            decimal IdUsuarioCON,
            int TipoReporteCON,
            string CuentaAuxiliarCON,
            string ConceptoCuentaCON,
            decimal ValorCON,
            string CuentaCON,
            string CuentaDescargoCON,
            string AnoCON,
            string MesCON,
            string AccionCON)
        {
            IdUsuario = IdUsuarioCON;
            TipoReporte = TipoReporteCON;
            CuentaAuxiliar = CuentaAuxiliarCON;
            ConceptoCuenta = ConceptoCuentaCON;
            Valor = ValorCON;
            Cuenta = CuentaCON;
            CuentaDescargo = CuentaDescargoCON;
            Ano = AnoCON;
            Mes = MesCON;
            Accion = AccionCON;
        }
        public void ProcesarInformacion() {
            DSMarket.Logica.Entidades.EntidadesConfiguracion.EProcesarDatosReporteFinanciero Procesar = new Entidades.EntidadesConfiguracion.EProcesarDatosReporteFinanciero();

            Procesar.IdUsuario = IdUsuario;
            Procesar.TipoReporte = TipoReporte;
            Procesar.CuentaAuxiliar = CuentaAuxiliar;
            Procesar.ConceptoCuenta = ConceptoCuenta;
            Procesar.Valor = Valor;
            Procesar.Cuenta = Cuenta;
            Procesar.CuentaDescargo = CuentaDescargo;
            Procesar.Ano = Ano;
            Procesar.Mes = Mes;

            var MAN = Objdata.ProcesarDatoReporteFinanciero(Procesar, Accion);
        }
    }
}
