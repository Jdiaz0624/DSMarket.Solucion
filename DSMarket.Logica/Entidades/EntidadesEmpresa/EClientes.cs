using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Entidades.EntidadesEmpresa
{
    public class EClientes
    {
        public decimal? IdCliente {get;set;}

        public System.Nullable<decimal> IdComprobante {get;set;}
        public string Comprobante { get; set; }

        public string Nombre {get;set;}

        public string Telefono {get;set;}

        public System.Nullable<decimal> IdTipoIdentificacion {get;set;}
        public string TipoIdentificacion { get; set; }

        public string RNC {get;set;}

        public string Direccion {get;set;}

        public string Email {get;set;}

        public string Comentario {get;set;}

        public System.Nullable<bool> Estatus0 {get;set;}

        public string Estatus {get;set;}
        public System.Nullable<bool> EnvioEmail0 { get; set; }

        public string EnvioEmail { get; set; }

        public System.Nullable<decimal> UsuarioAdiciona {get;set;}

        public string CreadoPor {get;set;}

        public System.Nullable<System.DateTime> FechaAdiciona {get;set;}

        public string FechaCreado {get;set;}

        public System.Nullable<decimal> UsuarioModifica {get;set;}

        public string ModificadoPor {get;set;}

        public System.Nullable<System.DateTime> FechaModifica {get;set;}

        public string FechaModificado {get;set;}

        public System.Nullable<decimal> MontoCredito {get;set;}
        public System.Nullable<int> CantidadClientes { get; set; }
    }
}
