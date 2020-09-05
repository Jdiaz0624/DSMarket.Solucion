using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes.ProcesarInformacion
{
    public class ProcesarInformacionCuentasMovimientos
    {
        public readonly Lazy<DSMarket.Logica.Logica.LogicaContabilidad.LogicaContabilidad> ObjData = new Lazy<Logica.LogicaContabilidad.LogicaContabilidad>();

        //DECLARAMOS LAS VARIABLES NECESARIAS PARA REALZIAR EL PROCESO

        private decimal IdRegistro = 0;
        private string Ano = "";
        private string Mes = "";
        private int IdTipoCuenta = 0;
        private int IdModulo = 0;
        private decimal Conector = 0;
        private decimal Secuencia = 0;
        private decimal Banco = 0;
        private string Cuenta = "";
        private string Auxiliar = "";
        private decimal Valor = 0;
        private int IdOrigen = 0;
        private string ConceptoCuenta = "";
        private decimal NumeroRelacionado = 0;
        private string Accion = "";

        //CREAMOS UN CONSTRUCTOR PARA PROCESAR LA INFORMACION DE ENTRADA
        public ProcesarInformacionCuentasMovimientos(
            decimal IdRegistroCON,
        string AnoCON,
        string MesCON,
        int IdTipoCuentaCON,
        int IdModuloCON,
        decimal ConectorCON,
        decimal SecuenciaCON,
        decimal BancoCON,
        string CuentaCON,
        string AuxiliarCON,
        decimal ValorCON,
        int IdOrigenCON,
        string ConceptoCuentaCON,
        decimal NumeroRelacionadoCON,
        string AccionCON)
        {
            IdRegistro = IdRegistroCON;
            Ano = AnoCON;
            Mes = MesCON;
            IdTipoCuenta = IdTipoCuentaCON;
            IdModulo = IdModuloCON;
            Conector = ConectorCON;
            Secuencia = SecuenciaCON;
            Banco = BancoCON;
            Cuenta = CuentaCON;
            Auxiliar = AuxiliarCON;
            Valor = ValorCON;
            IdOrigen = IdOrigenCON;
            ConceptoCuenta = ConceptoCuentaCON;
            NumeroRelacionado = NumeroRelacionadoCON;
            Accion = AccionCON;
        }

        //CREAMOS UN METODO PARA MANDAR LA INFORMACION A LA BASE DE DATOS
        public void ProcesarInformacion() {
            DSMarket.Logica.Entidades.EntidadesContabilidad.EGuardarCuentasMovimientos Procesar = new Entidades.EntidadesContabilidad.EGuardarCuentasMovimientos();

            Procesar.IdRegistro = IdRegistro;
            Procesar.Ano = Ano;
            Procesar.Mes = Mes;
            Procesar.IdTipoCuenta = IdTipoCuenta;
            Procesar.IdModulo = IdModulo;
            Procesar.Conector = Conector;
            Procesar.Secuencia = Secuencia;
            Procesar.Banco = Banco;
            Procesar.Cuenta = Cuenta;
            Procesar.Auxiliar = Auxiliar;
            Procesar.Valor = Valor;
            Procesar.IdOrigen = IdOrigen;
            Procesar.ConceptoCuenta = ConceptoCuenta;
            Procesar.NumeroRelacionado = NumeroRelacionado;

            var MAN = ObjData.Value.GuardarCuentasMovimientos(Procesar, Accion);
        }
    }
}
