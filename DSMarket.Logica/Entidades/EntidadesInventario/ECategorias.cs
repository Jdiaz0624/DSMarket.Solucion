using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Entidades.EntidadesInventario
{
    public class ECategorias
    {
        public decimal? IdCategoria { get; set; }

        public string Categoria { get; set; }

        public System.Nullable<bool> Estatus0 { get; set; }

        public string Estatus { get; set; }

        public System.Nullable<decimal> UsuarioAdiciona { get; set; }

        public System.Nullable<System.DateTime> Fechaadiciona { get; set; }

        public string FechaCreado { get; set; }

        public System.Nullable<decimal> UsuarioModifica { get; set; }

        public System.Nullable<System.DateTime> FechaModifica { get; set; }

        public string FechaModifica1 { get; set; }

        public System.Nullable<int> CantidadRegistros { get; set; }
    }
}
