using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Entidades.EntidadesEmpresa
{
    public class EEmpleados
    {
        public decimal? IdEmpleado { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string NombreEmpleado { get; set; }

        public System.Nullable<decimal> IdTipoIdentificacion { get; set; }

        public string TipoIdentificacion { get; set; }

        public string NumeroIdentificacion { get; set; }

        public System.Nullable<decimal> IdNacionalidad { get; set; }

        public string Nacionalidad { get; set; }

        public string NSS { get; set; }

        public string Direccion { get; set; }

        public System.Nullable<decimal> IdTipoEmpleado { get; set; }

        public string TipoEmpleado { get; set; }

        public System.Nullable<decimal> IdTioNomina { get; set; }

        public string TipoNomina { get; set; }

        public System.Nullable<decimal> IdDepartamento { get; set; }

        public string Departamento { get; set; }

        public System.Nullable<decimal> IdCargo { get; set; }

        public string Cargo { get; set; }

        public string Telefono1 { get; set; }

        public string Telefono2 { get; set; }

        public string Email { get; set; }

        public System.Nullable<decimal> IdEstadoCivil { get; set; }

        public string EstadoCivil { get; set; }

        public System.Nullable<decimal> Sueldo { get; set; }

        public System.Nullable<decimal> OtrosIngresos { get; set; }

        public System.Nullable<decimal> IdFormaPago { get; set; }

        public string FormaPago { get; set; }

        public System.Nullable<System.DateTime> FechaIngreso0 { get; set; }

        public string FechaIngreso { get; set; }

        public System.Nullable<System.DateTime> FechaNacimiento0 { get; set; }

        public string FechaNacimiento { get; set; }

        public System.Nullable<bool> Estatus0 { get; set; }

        public string Estatus { get; set; }

        public System.Nullable<bool> AplicaParaComision0 { get; set; }

        public string AplicaParaComision { get; set; }

        public System.Nullable<decimal> PorcientoCOmisionVentas { get; set; }

        public System.Nullable<decimal> PorcientoComsiionServicio { get; set; }

        public System.Nullable<int> CantidadRegistros { get; set; }

        public System.Nullable<int> CantidadActivos { get; set; }

        public System.Nullable<int> CantidadInactivos { get; set; }
    }
}
