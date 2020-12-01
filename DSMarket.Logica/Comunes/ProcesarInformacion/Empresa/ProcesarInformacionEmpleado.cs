using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes.ProcesarInformacion.Empresa
{
    public class ProcesarInformacionEmpleado
    {
        readonly DSMarket.Logica.Logica.LogicaEmpresa.LogicaEmpresa Objdata = new Logica.LogicaEmpresa.LogicaEmpresa();

        private decimal IdEmpleado = 0;
        private string Nombre = "";
        private string Apellido = "";
        private decimal IdTipoIdentificacion = 0;
        private string NumeroIdentificacion = "";
        private decimal IdNacionalidad = 0;
        private string NSS = "";
        private string Direccion = "";
        private decimal IdTipoEmpleado = 0;
        private decimal IdTioNomina = 0;
        private decimal IdDepartamento = 0;
        private decimal IdCargo = 0;
        private string Telefono1 = "";
        private string Telefono2 = "";
        private string Email = "";
        private decimal IdEstadoCivil = 0;
        private decimal Sueldo = 0;
        private decimal OtrosIngresos = 0;
        private decimal IdFormaPago = 0;
        private DateTime FechaIngreso = DateTime.Now;
        private DateTime FechaNacimiento = DateTime.Now;
        private bool Estatus = false;
        private bool AplicaParaComision = false;
        private decimal PorcientoCOmisionVentas = 0;
        private decimal PorcientoComsiionServicio = 0;
        private string Accion = "";

        public ProcesarInformacionEmpleado(
            decimal IdEmpleadoCON,
        string NombreCON,
        string ApellidoCON,
        decimal IdTipoIdentificacionCON,
        string NumeroIdentificacionCON,
        decimal IdNacionalidadCON,
        string NSSCON,
        string DireccionCON,
        decimal IdTipoEmpleadoCON,
        decimal IdTioNominaCON,
        decimal IdDepartamentoCON,
        decimal IdCargoCON,
        string Telefono1CON,
        string Telefono2CON,
        string EmailCON,
        decimal IdEstadoCivilCON,
        decimal SueldoCON,
        decimal OtrosIngresosCON,
        decimal IdFormaPagoCON,
        DateTime FechaIngresoCON,
        DateTime FechaNacimientoCON,
        bool EstatusCON,
        bool AplicaParaComisionCON,
        decimal PorcientoCOmisionVentasCON,
        decimal PorcientoComsiionServicioCON,
        string AccionCON)
        {
            IdEmpleado = IdEmpleadoCON;
            Nombre = NombreCON;
            Apellido = ApellidoCON;
            IdTipoIdentificacion = IdTipoIdentificacionCON;
            NumeroIdentificacion = NumeroIdentificacionCON;
            IdNacionalidad = IdNacionalidadCON;
            NSS = NSSCON;
            Direccion = DireccionCON;
            IdTipoEmpleado = IdTipoEmpleadoCON;
            IdTioNomina = IdTioNominaCON;
            IdDepartamento = IdDepartamentoCON;
            IdCargo = IdCargoCON;
            Telefono1 = Telefono1CON;
            Telefono2 = Telefono2CON;
            Email = EmailCON;
            IdEstadoCivil = IdEstadoCivilCON;
            Sueldo = SueldoCON;
            OtrosIngresos = OtrosIngresosCON;
            IdFormaPago = IdFormaPagoCON;
            FechaIngreso = FechaIngresoCON;
            FechaNacimiento = FechaNacimientoCON;
            Estatus = EstatusCON;
            AplicaParaComision = AplicaParaComisionCON;
            PorcientoCOmisionVentas = PorcientoCOmisionVentasCON;
            PorcientoComsiionServicio = PorcientoComsiionServicioCON;
            Accion = AccionCON;
        }

        public void ProcesarEmpleado() {
            DSMarket.Logica.Entidades.EntidadesEmpresa.EEmpleados Procesar = new Entidades.EntidadesEmpresa.EEmpleados();

            Procesar.IdEmpleado = IdEmpleado;
            Procesar.Nombre = Nombre;
            Procesar.Apellido = Apellido;
            Procesar.IdTipoIdentificacion = IdTipoIdentificacion;
            Procesar.NumeroIdentificacion = NumeroIdentificacion;
            Procesar.IdNacionalidad = IdNacionalidad;
            Procesar.NSS = NSS;
            Procesar.Direccion = Direccion;
            Procesar.IdTipoEmpleado = IdTipoEmpleado;
            Procesar.IdTioNomina = IdTioNomina;
            Procesar.IdDepartamento = IdDepartamento;
            Procesar.IdCargo = IdCargo;
            Procesar.Telefono1 = Telefono1;
            Procesar.Telefono2 = Telefono2;
            Procesar.Email = Email;
            Procesar.IdEstadoCivil = IdEstadoCivil;
            Procesar.Sueldo = Sueldo;
            Procesar.OtrosIngresos = OtrosIngresos;
            Procesar.IdFormaPago = IdFormaPago;
            Procesar.FechaIngreso0 = FechaIngreso;
            Procesar.FechaNacimiento0 = FechaNacimiento;
            Procesar.Estatus0 = Estatus;
            Procesar.AplicaParaComision0 = AplicaParaComision;
            Procesar.PorcientoCOmisionVentas = PorcientoCOmisionVentas;
            Procesar.PorcientoComsiionServicio = PorcientoComsiionServicio;

            var MAN = Objdata.MantenimientoEmpleados(Procesar, Accion);
        }
    }
}
