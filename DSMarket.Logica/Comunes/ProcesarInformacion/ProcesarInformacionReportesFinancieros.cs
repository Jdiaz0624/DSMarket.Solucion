using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes.ProcesarInformacion
{
    public class ProcesarInformacionReportesFinancieros
    {
        public readonly DSMarket.Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion ObjDaya = new Logica.LogicaConfiguracion.LogicaCOnfiguracion();

        private decimal IdUsuario = 0;
        private decimal IdRegistro = 0;
        private string Ano = "";
        private string Mes = "";
        private int IdTipoCuenta = 0;
        private string TipoCuenta = "";
        private int IdModulo = 0;
        private string Modulo = "";
        private decimal Conector = 0;
        private int Secuencia = 0;
        private int Banco = 0;
        private string NombreBanco = "";
        private string Cuenta = "";
        private string Auxiliar = "";
        private decimal Valor = 0;
        private int IdOrigenCuenta = 0;
        private string OrigenCuenta = "";
        private string CuentaConcepto = "";
        private decimal NumeroRelacionado = 0;
        private int IdClaseCuenta = 0;
        private string ClaseCuenta = "";
        private decimal IdCuentaContable = 0;
        private int Cuentadescargo = 0;
        private string Accion = "";

        public ProcesarInformacionReportesFinancieros(
            decimal IdUsuarioCON,
            decimal IdRegistroCON,
            string AnoCON,
            string MesCON,
            int IdTipoCuentaCON,
            string TipoCuentaCON,
            int IdModuloCON,
            string ModuloCON,
            decimal ConectorCON,
            int SecuenciaCON,
            int BancoCON,
            string NombreBancoCON,
            string CuentaCON,
            string AuxiliarCON,
            decimal ValorCON,
            int IdOrigenCuentaCON,
            string OrigenCuentaCON,
            string CuentaConceptoCON,
            decimal NumeroRelacionadoCON,
            int IdClaseCuentaCON,
            string ClaseCuentaCON,
            decimal IdCuentaContableCON,
            int CuentadescargoCON,
            string AccionCON)
        {
            IdUsuario = IdUsuarioCON;
            IdRegistro = IdRegistroCON;
            Ano = AnoCON;
            Mes = MesCON;
            IdTipoCuenta = IdTipoCuentaCON;
            TipoCuenta = TipoCuentaCON;
            IdModulo = IdModuloCON;
            Modulo = ModuloCON;
            Conector = ConectorCON;
            Secuencia = SecuenciaCON;
            Banco = BancoCON;
            NombreBanco = NombreBancoCON;
            Cuenta = CuentaCON;
            Auxiliar = AuxiliarCON;
            Valor = ValorCON;
            IdOrigenCuenta = IdOrigenCuentaCON;
            OrigenCuenta = OrigenCuentaCON;
            CuentaConcepto = CuentaConceptoCON;
            NumeroRelacionado = NumeroRelacionadoCON;
            IdClaseCuenta = IdClaseCuentaCON;
            ClaseCuenta = ClaseCuentaCON;
            IdCuentaContable = IdCuentaContableCON;
            Cuentadescargo = CuentadescargoCON;
            Accion = AccionCON;
        }

        public void ProcesarInformacion() {
            DSMarket.Logica.Entidades.EntidadesConfiguracion.EProcesarDatosReportesFinancieros Procesar = new Entidades.EntidadesConfiguracion.EProcesarDatosReportesFinancieros();
            Procesar.IdUsuario = IdUsuario;
            Procesar.IdRegistro = IdRegistro;
            Procesar.Ano = Ano;
            Procesar.Mes = Mes;
            Procesar.IdTipoCuenta = IdTipoCuenta;
            Procesar.TipoCuenta = TipoCuenta;
            Procesar.IdModulo = IdModulo;
            Procesar.Modulo = Modulo;
            Procesar.Conector = Conector;
            Procesar.Secuencia = Secuencia;
            Procesar.Banco = Banco;
            Procesar.NombreBanco = NombreBanco;
            Procesar.Cuenta = Cuenta;
            Procesar.Auxiliar = Auxiliar;
            Procesar.Valor = Valor;
            Procesar.IdOrigenCuenta = IdOrigenCuenta;
            Procesar.OrigenCuenta = OrigenCuenta;
            Procesar.CuentaConcepto = CuentaConcepto;
            Procesar.NumeroRelacionado = NumeroRelacionado;
            Procesar.IdClaseCuenta = IdClaseCuenta;
            Procesar.ClaseCuenta = ClaseCuenta;
            Procesar.IdCuentaContable = IdCuentaContable;
            Procesar.Cuentadescargo = Cuentadescargo;

            var MAN = ObjDaya.ProcesarDatosReportesFinancieros(Procesar, Accion);
        }
    }
}
