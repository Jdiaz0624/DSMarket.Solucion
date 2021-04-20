using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes.ProcesarInformacion.Servicio
{
    public class ProcesarInformacionFacturacionPreview
    {
        readonly DSMarket.Logica.Logica.LogicaServicio.LogicaServicio ObjData = new Logica.LogicaServicio.LogicaServicio();

        private decimal IdUsuario = 0;
        private string NumeroConector = "";
        private decimal IdProducto = 0;
        private decimal IdTipoProducto = 0;
        private decimal Precio = 0;
        private int Cantidad = 0;
        private decimal Descuento = 0;
        private decimal PorcientoImpuesto = 0;
        private string Accion = "";

        public ProcesarInformacionFacturacionPreview(
            decimal IdUsuarioCON,
        string NumeroConectorCON,
        decimal IdProductoCON,
        decimal IdTipoProductoCON,
        decimal PrecioCON,
        int CantidadCON,
        decimal DescuentoCON,
        decimal PorcientoImpuestoCON,
        string AccionCON)
        {
            IdUsuario = IdUsuarioCON;
            NumeroConector = NumeroConectorCON;
            IdProducto = IdProductoCON;
            IdTipoProducto = IdTipoProductoCON;
            Precio = PrecioCON;
            Cantidad = CantidadCON;
            Descuento = DescuentoCON;
            PorcientoImpuesto = PorcientoImpuestoCON;
            Accion = AccionCON;
        }
        /// <summary>
        /// Este metodo es para procesar la informacion del preview de la factura
        /// </summary>
        public void ProcesarInformacion() {
            DSMarket.Logica.Entidades.EntidadesServicio.EFacturacionPreview Procesar = new Entidades.EntidadesServicio.EFacturacionPreview();

            Procesar.IdUsuario = IdUsuario;
            Procesar.NumeroConector = NumeroConector;
            Procesar.IdProducto = IdProducto;
            Procesar.IdTipoProducto = IdTipoProducto;
            Procesar.Precio = Precio;
            Procesar.Cantidad = Cantidad;
            Procesar.Descuento = Descuento;
            Procesar.PorcientoImpuesto = PorcientoImpuesto;

            var MAN = ObjData.ProcesarDatosFacturacionPreview(Procesar, Accion);
        }
    }
}
