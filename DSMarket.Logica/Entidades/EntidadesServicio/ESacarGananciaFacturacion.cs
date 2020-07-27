using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Entidades.EntidadesServicio
{
    public class ESacarGananciaFacturacion
    {
        public int? IdEstatusFacturacion { get; set; }

        public string Estatus { get; set; }

        public decimal? IdFactura { get; set; }

        public string DescripcionProducto { get; set; }

        public string Acumulativo { get; set; }

        public System.Nullable<decimal> IdCategoria { get; set; }

        public string Categoria { get; set; }

        public string TipoProducto { get; set; }

        public System.Nullable<decimal> PrecioCompra { get; set; }

        public System.Nullable<decimal> PrecioVenta { get; set; }
    
        public System.Nullable<decimal> CantidadVendida { get; set; }

        public System.Nullable<decimal> DescuentoAplicado { get; set; }

        public System.Nullable<decimal> TotalVenta { get; set; }

        public System.Nullable<decimal> TotalPrecioCompra { get; set; }

        public System.Nullable<decimal> Ganancia { get; set; }
    }
}
