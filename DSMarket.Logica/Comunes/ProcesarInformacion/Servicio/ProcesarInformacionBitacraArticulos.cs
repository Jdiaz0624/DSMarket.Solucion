using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes.ProcesarInformacion.Servicio
{
    public class ProcesarInformacionBitacraArticulos
    {
        readonly DSMarket.Logica.Logica.LogicaServicio.LogicaServicio ObjData = new Logica.LogicaServicio.LogicaServicio();

        private decimal IdBitacora = 0;
        private decimal NumeroFactura = 0;
        private DateTime FechaFactura = DateTime.Now;
        private int CantidadRegistros = 0;
        private string Accion = "";

        public ProcesarInformacionBitacraArticulos(
            decimal IdBitacoraCON,
        decimal NumeroFacturaCON,
        DateTime FechaFacturaCON,
        int CantidadRegistrosCON,
        string AccionCON)
        {
            IdBitacora = IdBitacoraCON;
            NumeroFactura = NumeroFacturaCON;
            FechaFactura = FechaFacturaCON;
            CantidadRegistros = CantidadRegistrosCON;
            Accion = AccionCON;
        }

        public void ProcesarInformacion() {
            DSMarket.Logica.Entidades.EntidadesServicio.EProcesarInformacionBitacoraArticulosDevueltos Procesar = new Entidades.EntidadesServicio.EProcesarInformacionBitacoraArticulosDevueltos();

            Procesar.IdBitacora = IdBitacora;
            Procesar.NumeroFactura = NumeroFactura;
            Procesar.FechaFactura = FechaFactura;
            Procesar.CantidadArticulos = CantidadRegistros;

            var MAN = ObjData.BitacoraArticulos(Procesar, Accion);
        }
    }
}
