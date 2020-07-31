using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Entidades.EntidadesCaja
{
    public class EReporteCuadreCaja
    {
        public System.Nullable<decimal> IdUsuario { get; set; }

        public string GeneradoPor { get; set; }

        public System.Nullable<int> IdCaja { get; set; }

        public System.Nullable<decimal> Monto { get; set; }

        public string Concepto { get; set; }

        public System.Nullable<System.DateTime> FechaProcesado0 { get; set; }

        public string FechaProcesado { get; set; }

        public System.Nullable<System.DateTime> FechaDesde0 { get; set; }

        public string FechaDesde { get; set; }

        public System.Nullable<System.DateTime> FechaHasta0 { get; set; }

        public string FechaHasta { get; set; }

        public System.Nullable<decimal> NumeroReferencia { get; set; }
    
        public System.Nullable<decimal> IdTipoPago { get; set; }

        public string TipoPago { get; set; }

        public string NombreEmpresa { get; set; }

        public string RNC { get; set; }

        public string Direccion { get; set; }

        public string Telefonos { get; set; }

        public string Email { get; set; }

        public string Email2 { get; set; }

        public string Facebook { get; set; }

        public string Instagran { get; set; }

        public System.Data.Linq.Binary LogoEmpresa { get; set; }

        public System.Nullable<decimal> MontoTotal { get; set; }

        public System.Nullable<int> Cantidadmovimientos { get; set; }
    }
}
