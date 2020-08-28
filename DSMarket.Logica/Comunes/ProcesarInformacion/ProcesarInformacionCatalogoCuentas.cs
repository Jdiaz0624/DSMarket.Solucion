using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes.ProcesarInformacion
{
    public class ProcesarInformacionCatalogoCuentas
    {
        public readonly DSMarket.Logica.Logica.LogicaContabilidad.LogicaContabilidad ObjData = new Logica.LogicaContabilidad.LogicaContabilidad();

        private decimal IdRegistro = 0;
        private string Cuenta = "";
        private string Auxiliar = "";
        private string Descripcion = "";
        private int IdOrigenCuenta = 0;
        private int IdTipoCuenta = 0;
        private int IdClaseCuenta = 0;
        private int IdAceptaMovimientoCuenta = 0;
        private int CodAnexo = 0;
        private string CuentaDescargo = "";
        private string CuentaPresupuesto = "";
        private string AuxiliarPresupuesto = "";
        private bool Estatus = false;
        private string CuentaAnterior = "";
        private int UsuarioAdiciona = 0;
        private DateTime FechaAdiciona = DateTime.Now;
        private int UsuarioModifica = 0;
        private DateTime FechaModifica = DateTime.Now;
        private string Accion = "";

        public ProcesarInformacionCatalogoCuentas(
             decimal IdRegistroCON,
         string CuentaCON,
         string AuxiliarCON,
         string DescripcionCON,
         int IdOrigenCuentaCON,
         int IdTipoCuentaCON,
         int IdClaseCuentaCON,
         int IdAceptaMovimientoCuentaCON,
         int CodAnexoCON,
         string CuentaDescargoCON,
         string CuentaPresupuestoCON,
         string AuxiliarPresupuestoCON,
         bool EstatusCON,
         string CuentaAnteriorCON,
         int UsuarioAdicionaCON,
         DateTime FechaAdicionaCON,
         int UsuarioModificaCON,
         DateTime FechaModificaCON,
         string AccionCON)
        {


            IdRegistro = IdRegistroCON;
            Cuenta = CuentaCON;
            Auxiliar = AuxiliarCON;
            Descripcion = DescripcionCON;
            IdOrigenCuenta = IdOrigenCuentaCON;
            IdTipoCuenta = IdTipoCuentaCON;
            IdClaseCuenta = IdClaseCuentaCON;
            IdAceptaMovimientoCuenta = IdAceptaMovimientoCuentaCON;
            CodAnexo = CodAnexoCON;
            CuentaDescargo = CuentaDescargoCON;
            CuentaPresupuesto = CuentaPresupuestoCON;
            AuxiliarPresupuesto = AuxiliarPresupuestoCON;
            Estatus = EstatusCON;
            CuentaAnterior = CuentaAnteriorCON;
            UsuarioAdiciona = UsuarioAdicionaCON;
            FechaAdiciona = FechaAdicionaCON;
            UsuarioModifica = UsuarioModificaCON;
            FechaModifica = FechaModificaCON;
            Accion = AccionCON;
    }

        public void ProcesarInformacion() {
            DSMarket.Logica.Entidades.EntidadesContabilidad.ECatalogoCuentas Procesar = new Entidades.EntidadesContabilidad.ECatalogoCuentas();

            Procesar.IdRegistro = IdRegistro;
            Procesar.Cuenta = Cuenta;
            Procesar.Auxiliar = Auxiliar;
            Procesar.CuentaDescargo = Descripcion;
            Procesar.IdOrigenCuenta = IdOrigenCuenta;
            Procesar.IdTipoCuenta = IdTipoCuenta;
            Procesar.IdClaseCuenta = IdClaseCuenta;
            Procesar.IdAceptaMovimientoCuenta = IdAceptaMovimientoCuenta;
            Procesar.CodAnexo = CodAnexo;
            Procesar.CuentaDescargo = CuentaDescargo;
            Procesar.CuentaPresupuesto = CuentaPresupuesto;
            Procesar.AuxiliarPresupuesto = AuxiliarPresupuesto;
            Procesar.Estatus0 = Estatus;
            Procesar.CuentaAnterior = CuentaAnterior;
            Procesar.UsuarioAdiciona = UsuarioAdiciona;
            Procesar.FechaAdiciona = FechaAdiciona;
            Procesar.UsuarioModifica = UsuarioModifica;
            Procesar.FechaModifica = FechaModifica;

            var MAN = ObjData.MantenimientoCatalogoCuentas(Procesar, Accion);
        }
    }
}
