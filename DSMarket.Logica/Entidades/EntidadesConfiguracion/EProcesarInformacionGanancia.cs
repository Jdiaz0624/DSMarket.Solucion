using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Entidades.EntidadesConfiguracion
{
    public class EProcesarInformacionGanancia
    {
        public System.Nullable<decimal> IdUsuario { get; set; }

        public System.Nullable<decimal> IdEstatusFacturacion { get; set; }

        public string Estatus { get; set; }

        public System.Nullable<decimal> IdFActura { get; set; }

        public string DescripcionProducto { get; set; }

        public string Acumulativo { get; set; }

        public System.Nullable<decimal> IdCategoria { get; set; }

        public string Categoria { get; set; }

        public string TipoProducto { get; set; }

        public System.Nullable<decimal> PrecioCompra { get; set; }

        public System.Nullable<decimal> PrecioVenta { get; set; }

        public System.Nullable<int> CantidadVendda { get; set; }

        public System.Nullable<decimal> DescuentoAplicado { get; set; }

        public System.Nullable<decimal> TotalVenta { get; set; }

        public System.Nullable<decimal> TotalPrecioCompra { get; set; }

        public System.Nullable<decimal> Ganancia { get; set; }
    }
}
