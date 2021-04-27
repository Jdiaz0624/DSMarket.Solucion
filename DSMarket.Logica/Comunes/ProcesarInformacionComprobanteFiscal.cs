using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes
{
    public class ProcesarInformacionComprobanteFiscal
    {
        readonly DSMarket.Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion ObjData = new Logica.LogicaConfiguracion.LogicaCOnfiguracion();

        private decimal IdComprbanteFiscal = 0;

        public ProcesarInformacionComprobanteFiscal(
            decimal IdComprbanteFiscalCON)
        {
            IdComprbanteFiscal = IdComprbanteFiscalCON;
        }

        /// <summary>
        /// Este metodo es para generar un numero de comprobante fiscal
        /// </summary>
        /// <returns></returns>
        public string GenerarComprobanteFiscal() {
            string ComprobanteFiscal = "";

            var GenerarComprobante = ObjData.GenerarComprobante(IdComprbanteFiscal);
            foreach (var n in GenerarComprobante) {
                ComprobanteFiscal = n.Comprobante;
            }
            return ComprobanteFiscal;
        }


        /// <summary>
        /// Este metodo es para sacar el valido hasta del comprobante generado.
        /// </summary>
        /// <returns></returns>
        public string SacarFechaValidoComprobante() {
            string ValidoHasta = "";

            var FechaValido = ObjData.BuscaComprobantesFiscales(IdComprbanteFiscal);
            foreach (var n in FechaValido) {
                ValidoHasta = n.ValidoHasta;
            }
            return ValidoHasta;
        }
    }
}
