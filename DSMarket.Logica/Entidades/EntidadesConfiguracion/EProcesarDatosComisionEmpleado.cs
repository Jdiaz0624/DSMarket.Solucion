using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Entidades.EntidadesConfiguracion
{
    public class EProcesarDatosComisionEmpleado
    {
        public System.Nullable<decimal> IdUsuario { get; set; }

        public System.Nullable<decimal> IdRegistro { get; set; }

        public System.Nullable<decimal> IdEmpleado { get; set; }

        public System.Nullable<decimal> IdTipoProducto { get; set; }

        public System.Nullable<decimal> PrecioProducto { get; set; }

        public System.Nullable<decimal> DescuentoAplicado { get; set; }

        public System.Nullable<decimal> ComisionEmpleado { get; set; }

        public System.Nullable<decimal> NumeroConectorOperacion { get; set; }

        public System.Nullable<decimal> IdProducto { get; set; }

        public System.Nullable<decimal> ConectorProducto { get; set; }

        public System.Nullable<System.DateTime> Fecha { get; set; }

        public System.Nullable<bool> Estatus { get; set; }

        public System.Nullable<System.DateTime> ValidadoDesde { get; set; }

        public System.Nullable<System.DateTime> ValidadoHasta { get; set; }
    }
}
