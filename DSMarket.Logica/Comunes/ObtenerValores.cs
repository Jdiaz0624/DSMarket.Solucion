using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes
{
    public static class ObtenerValores 
    {
        static readonly Lazy<DSMarket.Logica.Logica.LogicaContabilidad.LogicaContabilidad> ObjdataContabilidad = new Lazy<Logica.LogicaContabilidad.LogicaContabilidad>();
        static readonly Lazy<DSMarket.Logica.Logica.LogicaServicio.LogicaServicio> ObjDataServicio = new Lazy<Logica.LogicaServicio.LogicaServicio>();

        //OBTENER EL CONCEPTO DE LA CUENTA PROCESO
        public static string SacarConceptoCuenta(int IdCOnceptoCuenta) {

            string Concepto = "";

            var SacarConcepto = ObjdataContabilidad.Value.BuscaProcesosCuentas(IdCOnceptoCuenta);
            foreach (var n in SacarConcepto) {
                Concepto = n.Concepto;
            }
            return Concepto;
        }

        //OBTENER EL NUMERO DE FACTURA
        //public static decimal SacarNumeroFactura(decimal NumeroConector) {
        //    decimal NumeroFactura = 0;

        //    var ObtenerNumeroFactura = ObjDataServicio.Value.SacarNumeroFactura(NumeroConector);
        //    foreach (var n in ObtenerNumeroFactura) {
        //        NumeroFactura = Convert.ToDecimal(n.IdFactura);
        //    }
        //    return NumeroFactura;
        //}

        //OBTENER EL TIPO DE CUENTA
        public static int ObtenerTipoCuentaContable(decimal IdCuentaCatalogo) {
            int IdTipocuentaContable = 0;

            var ObtenerTipocuenta = ObjdataContabilidad.Value.BuscaCatalogoCuentas(IdCuentaCatalogo, null, null, null, null, 1, 1);
            foreach (var n in ObtenerTipocuenta) {
                IdTipocuentaContable = Convert.ToInt32(n.IdTipoCuenta);
            }
            return IdTipocuentaContable;
        }

        //OBTENER EL ORIGEN DE LA CUENTA BANCARIA
        public static int ObtenerORigenCuentaContable(decimal IdCuentaCatalogo)
        {
            int IdOrigenCuentaContable = 0;

            var ObtenerTipocuenta = ObjdataContabilidad.Value.BuscaCatalogoCuentas(IdCuentaCatalogo, null, null, null, null, 1, 1);
            foreach (var n in ObtenerTipocuenta)
            {
                IdOrigenCuentaContable = Convert.ToInt32(n.IdOrigenCuenta);
            }
            return IdOrigenCuentaContable;
        }

        //OBTENER LA CLASE DE LA CUENTA CONTABLE
        public static int ObtenerClaseCuentaContable(decimal IdCuentaCatalogo)
        {
            int IdClaseCuentaContable = 0;

            var ObtenerTipocuenta = ObjdataContabilidad.Value.BuscaCatalogoCuentas(IdCuentaCatalogo, null, null, null, null, 1, 1);
            foreach (var n in ObtenerTipocuenta)
            {
                IdClaseCuentaContable = Convert.ToInt32(n.IdClaseCuenta);
            }
            return IdClaseCuentaContable;
        }

        //OBTENER EL CODIGO DEL REGISTRO DEL CATALOGO DE CUENTAS
        public static int ObtenerCodigoRegistroCatalogoCuentas(decimal IdCuentaCatalogo)
        {
            int IdRegistroCatalogo = 0;

            var ObtenerTipocuenta = ObjdataContabilidad.Value.BuscaCatalogoCuentas(IdCuentaCatalogo, null, null, null, null, 1, 1);
            foreach (var n in ObtenerTipocuenta)
            {
                IdRegistroCatalogo = Convert.ToInt32(n.IdRegistro);
            }
            return IdRegistroCatalogo;
        }

        //OBTENER EL NOMBRE DE LA CUENTA CONTABLE
        public static string ObtenerCuentaContable(decimal IdCuentaCatalogo) {

            string CuentaContable = "";

            var ObtenerCuenta = ObjdataContabilidad.Value.BuscaCatalogoCuentas(IdCuentaCatalogo);
            foreach (var n in ObtenerCuenta) {
                CuentaContable = n.Cuenta;
            }
            return CuentaContable;
        }

        //OBTENER EL AUXILIAR CONTABLE
        public static string ObtenerAuxiliarContable(decimal IdCuentaCatalogo)
        {

            string AuxiliarContable = "";

            var ObtenerCuenta = ObjdataContabilidad.Value.BuscaCatalogoCuentas(IdCuentaCatalogo);
            foreach (var n in ObtenerCuenta)
            {
                AuxiliarContable = n.Auxiliar;
            }
            return AuxiliarContable;
        }


        //OBTENER EL BANCO POR DEFECTO
        public static decimal ObtenerCodigoBancoPorDefecto() {

            decimal IdBanco = 0;

            var SacarDato = ObjdataContabilidad.Value.BuscaBancos(new Nullable<decimal>(), null, true, 1, 1);
            foreach (var n in SacarDato) {
                IdBanco = Convert.ToDecimal(n.IdBanco);
            }
            return IdBanco;
        }

    }
}
