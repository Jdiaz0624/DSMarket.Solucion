using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes.ProcesarInformacion.Historial
{
    public class ProcesarInformacionGananciaVenta
    {
        readonly DSMarket.Logica.Logica.LogicaHistorial.LogicaHistorial ObjData = new Logica.LogicaHistorial.LogicaHistorial();

        private decimal IdUsuario = 0;
        private decimal IdEstatusFacturacion = 0;
        private string Estatus = "";
        private decimal NumeroFactura = 0;
        private string Descripcion = "";
        private decimal IdCategoria = 0;
        private decimal IdTipoProducto = 0;
        private decimal PrecioCompra = 0;
        private decimal PrecioVenta = 0;
        private decimal CantidadVendida = 0;
        private decimal DescuentoAplicado = 0;
        private decimal TotalDescuentoAplicado = 0;
        private decimal TotalVenta = 0;
        private decimal TotalPrecioCompra = 0;
        private decimal Ganancia = 0;
        private string Accion = "";

        public ProcesarInformacionGananciaVenta(
            decimal IdUsuarioCON,
        decimal IdEstatusFacturacionCON,
        string EstatusCON,
        decimal NumeroFacturaCON,
        string DescripcionCON,
        decimal IdCategoriaCON,
        decimal IdTipoProductoCON,
        decimal PrecioCompraCON,
        decimal PrecioVentaCON,
        decimal CantidadVendidaCON,
        decimal DescuentoAplicadoCON,
        decimal TotalDescuentoAplicadoCON,
        decimal TotalVentaCON,
        decimal TotalPrecioCompraCON,
        decimal GananciaCON,
        string AccionCON)
        {
            IdUsuario = IdUsuarioCON;
            IdEstatusFacturacion = IdEstatusFacturacionCON;
            Estatus = EstatusCON;
            NumeroFactura = NumeroFacturaCON;
            Descripcion = DescripcionCON;
            IdCategoria = IdCategoriaCON;
            IdTipoProducto = IdTipoProductoCON;
            PrecioCompra = PrecioCompraCON;
            PrecioVenta = PrecioVentaCON;
            CantidadVendida = CantidadVendidaCON;
            DescuentoAplicado = DescuentoAplicadoCON;
            TotalDescuentoAplicado = TotalDescuentoAplicadoCON;
            TotalVenta = TotalVentaCON;
            TotalPrecioCompra = TotalPrecioCompraCON;
            Ganancia = GananciaCON;
            Accion = AccionCON;
        }


        /// <summary>
        /// Procesar la información de la ganancia de venta
        /// </summary>
        public void ProcesarInformacion() {
            DSMarket.Logica.Entidades.EntidadesHistorial.EProcesarGananciaVenta Procesar = new Entidades.EntidadesHistorial.EProcesarGananciaVenta();

            Procesar.IdUsuario = IdUsuario;
            Procesar.IdEstatusFacturacion = IdEstatusFacturacion;
            Procesar.Estatus = Estatus;
            Procesar.NumeroFactura = NumeroFactura;
            Procesar.Descripcion = Descripcion;
            Procesar.IdCategoria = IdCategoria;
            Procesar.IdTipoProducto = IdTipoProducto;
            Procesar.PrecioCompra = PrecioCompra;
            Procesar.PrecioVenta = PrecioVenta;
            Procesar.CantidadVendida = CantidadVendida;
            Procesar.DescuentoAplicado = DescuentoAplicado;
            Procesar.TotalDescuentoAplicado = TotalDescuentoAplicado;
            Procesar.TotalVenta = TotalVenta;
            Procesar.TotalPrecioCompra = TotalPrecioCompra;
            Procesar.Ganancia = Ganancia;

            var MAN = ObjData.ProcesarGananciaVenta(Procesar, Accion);
        
        
        }
    }
}
