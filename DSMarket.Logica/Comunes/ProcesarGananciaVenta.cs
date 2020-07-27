using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes
{
    public class ProcesarGananciaVenta
    {
        public readonly Lazy<DSMarket.Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion> ObjDataConfiguracion = new Lazy<Logica.LogicaConfiguracion.LogicaCOnfiguracion>();

        private decimal IdUsuario = 0;
        private decimal IdEstatusFacturacion = 0;
        private string  Estatus = "";
        private decimal IdFActura = 0;
        private string  DescripcionProducto = "";
        private string  Acumulativo = "";
        private decimal IdCategoria = 0;
        private string  Categoria = "";
        private string  TipoProducto = "";
        private decimal PrecioCompra = 0;
        private decimal PrecioVenta = 0;
        private int     CantidadVendda = 0;
        private decimal DescuentoAplicado = 0;
        private decimal TotalVenta = 0;
        private decimal TotalPrecioCompra = 0;
        private decimal Ganancia = 0;
        private string Accion = "";

        public ProcesarGananciaVenta(
            decimal IdUsuarioCon,
            decimal IdEstatusFacturacionCon,
            string EstatusCon,
            decimal IdFActuraCon,
            string DescripcionProductoCon,
            string AcumulativoCon,
            decimal IdCategoriaCon,
            string CategoriaCon,
            string TipoProductoCon,
            decimal PrecioCompraCon,
            decimal PrecioVentaCon,
            int CantidadVenddaCon,
            decimal DescuentoAplicadoCon,
            decimal TotalVentaCon,
            decimal TotalPrecioCompraCon,
            decimal GananciaCon,
            string AccionCon)
        {
            IdUsuario = IdUsuarioCon;
            IdEstatusFacturacion = IdEstatusFacturacionCon;
            Estatus = EstatusCon;
            IdFActura = IdFActuraCon;
            DescripcionProducto = DescripcionProductoCon;
            Acumulativo = AcumulativoCon;
            IdCategoria = IdCategoriaCon;
            Categoria = CategoriaCon;
            TipoProducto = TipoProductoCon;
            PrecioCompra = PrecioCompraCon;
            PrecioVenta = PrecioVentaCon;
            CantidadVendda = CantidadVenddaCon;
            DescuentoAplicado = DescuentoAplicadoCon;
            TotalVenta = TotalVentaCon;
            TotalPrecioCompra = TotalPrecioCompraCon;
            Ganancia = GananciaCon;
            Accion = AccionCon;
        }

        public void ProcesarGanancia() {

            DSMarket.Logica.Entidades.EntidadesConfiguracion.EProcesarInformacionGanancia Procesar = new Entidades.EntidadesConfiguracion.EProcesarInformacionGanancia();

            Procesar.IdUsuario = IdUsuario;
            Procesar.IdEstatusFacturacion = IdEstatusFacturacion;
            Procesar.Estatus = Estatus;
            Procesar.IdFActura = IdFActura;
            Procesar.DescripcionProducto = DescripcionProducto;
            Procesar.Acumulativo = Acumulativo;
            Procesar.IdCategoria = IdCategoria;
            Procesar.Categoria = Categoria;
            Procesar.TipoProducto = TipoProducto;
            Procesar.PrecioCompra = PrecioCompra;
            Procesar.PrecioVenta = PrecioVenta;
            Procesar.CantidadVendda = CantidadVendda;
            Procesar.DescuentoAplicado = DescuentoAplicado;
            Procesar.TotalVenta = TotalVenta;
            Procesar.TotalPrecioCompra = TotalPrecioCompra;
            Procesar.Ganancia = Ganancia;

            var MANProcesar = ObjDataConfiguracion.Value.ProcesarInformacionGanancia(Procesar, Accion);
        }
    }
}
