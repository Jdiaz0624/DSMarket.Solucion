using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes
{
    public class ProcesarInformacionReporte608
    {
        public readonly Lazy<DSMarket.Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion> Data = new Lazy<Logica.LogicaConfiguracion.LogicaCOnfiguracion>();

        //DECLARAMOS LAS VARIABLES
        private decimal IdUsuario = 0;
        private string Comprobante = "";
        private DateTime FechaFacturacion0 = DateTime.Now;
        private string FechaFActuracion = "";
        private string FechaArchivo = "";
        private string TipoAnulacion = "";
        private string CodigoTipoAnulacion = "";
        private string Comentario = "";
        private decimal CantidadRegistros = 0;
        private DateTime ValidadoDesde = DateTime.Now;
        private DateTime ValidadoHasta = DateTime.Now;
        private string Accion = "";

        //GENERAMOS UN CONSTRUCTOR PARA MANEJAR EL FLUJO DE INFORMACION

        public ProcesarInformacionReporte608(
            decimal IdUsuarioCON,
            string ComprobanteCON,
            DateTime FechaFacturacion0CON,
            string FechaFActuracionCON,
            string FechaArchivoCON,
            string TipoAnulacionCON,
            string CodigoTipoAnulacionCON,
            string ComentarioCON,
            decimal CantidadRegistrosCON,
            DateTime ValidadoDesdeCON,
            DateTime ValidadoHastaCON,
            string AccionCON)
        {
            IdUsuario = IdUsuarioCON;
            Comprobante = ComprobanteCON;
            FechaFacturacion0 = FechaFacturacion0CON;
            FechaFActuracion = FechaFActuracionCON;
            FechaArchivo = FechaArchivoCON;
            TipoAnulacion = TipoAnulacionCON;
            CodigoTipoAnulacion = CodigoTipoAnulacionCON;
            Comentario = ComentarioCON;
            CantidadRegistros = CantidadRegistrosCON;
            ValidadoDesde = ValidadoDesdeCON;
            ValidadoHasta = ValidadoHastaCON;
            Accion = AccionCON;
        }

        public void ProcesarInformacion() {
            DSMarket.Logica.Entidades.EntidadesConfiguracion.EProcesarInformacion608 Procesar = new Entidades.EntidadesConfiguracion.EProcesarInformacion608();

            Procesar.IdUsuario = IdUsuario;
            Procesar.Comprobante = Comprobante;
            Procesar.FechaFacturacion0 = FechaFacturacion0;
            Procesar.FechaFActuracion = FechaFActuracion;
            Procesar.FechaArchivo = FechaArchivo;
            Procesar.TipoAnulacion = TipoAnulacion;
            Procesar.CodigoTipoAnulacion = CodigoTipoAnulacion;
            Procesar.Comentario = Comentario;
            Procesar.CantidadRegistros = CantidadRegistros;
            Procesar.ValidadoDesde = ValidadoDesde;
            Procesar.ValidadoHasta = ValidadoHasta;

            var MAN = Data.Value.ProcesarInformacion608(Procesar, Accion);
        }

    }
}
