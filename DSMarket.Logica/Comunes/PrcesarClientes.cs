using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes
{
    public class PrcesarClientes
    {
        public readonly Lazy<DSMarket.Logica.Logica.LogicaEmpresa.LogicaEmpresa> ObjDataEmpresa = new Lazy<Logica.LogicaEmpresa.LogicaEmpresa>();

        private decimal IdCliente = 0;
        private decimal IdComprobante = 0;
        private string Nombre = "";
        private string Telefono = "";
        private decimal IdTipoIdentificacion = 0;
        private string RNC = "";
        private DateTime FechaNacimiento = DateTime.Now;
        private bool AceptaCumpleanos = false;
        private string Direccion = "";
        private string EMail = "";
        private string Comentario = "";
        private bool Estatus = false;
        private decimal UsuarioAdiciona = 0;
        private DateTime FechaAdiciona = DateTime.Now;
        private decimal UsuarioModifica = 0;
        private DateTime FechaModifica = DateTime.Now;
        private decimal MontoCredito = 0;
        private bool EnvioEmail = false;
        private string Accion = "";

        public PrcesarClientes(
            decimal IdClienteCON,
            decimal IdComprobanteCON,
            string NombreCON,
            string TelefonoCON,
            decimal IdTipoIdentificacionCON,
            string RNCCON,
            DateTime FechaNacimientoCON,
            bool AceptaCumpleanosCON,
            string DireccionCON,
            string EMailCON,
            string ComentarioCON,
            bool EstatusCON,
            decimal UsuarioAdicionaCON,
            DateTime FechaAdicionaCON,
            decimal UsuarioModificaCON,
            DateTime FechaModificaCON,
            decimal MontoCreditoCON,
            bool EnvioEmailCON,
            string AccionCON)
        {
            IdCliente = IdClienteCON;
            IdComprobante = IdComprobanteCON;
            Nombre = NombreCON;
            Telefono = TelefonoCON;
            IdTipoIdentificacion = IdTipoIdentificacionCON;
            RNC = RNCCON;
            FechaNacimiento = FechaNacimientoCON;
            AceptaCumpleanos = AceptaCumpleanosCON;
            Direccion = DireccionCON;
            EMail = EMailCON;
            Comentario = ComentarioCON;
            Estatus = EstatusCON;
            UsuarioAdiciona = UsuarioAdicionaCON;
            FechaAdiciona = FechaAdicionaCON;
            UsuarioModifica = UsuarioModificaCON;
            FechaModifica = FechaModificaCON;
            MontoCredito = MontoCreditoCON;
            EnvioEmail = EnvioEmailCON;
            Accion = AccionCON;

        }

        public void ProcesarInformacion() {
            DSMarket.Logica.Entidades.EntidadesEmpresa.EClientes Procesar = new Entidades.EntidadesEmpresa.EClientes();

            Procesar.IdCliente = IdCliente;
            Procesar.IdComprobante = IdComprobante;
            Procesar.Nombre = Nombre;
            Procesar.Telefono = Telefono;
            Procesar.IdTipoIdentificacion = IdTipoIdentificacion;
            Procesar.RNC = RNC;
            Procesar.FechaNacimiento0 = FechaNacimiento;
            Procesar.AlertaCumpleanos0 = AceptaCumpleanos;
            Procesar.Direccion = Direccion;
            Procesar.Email = EMail;
            Procesar.Comentario = Comentario;
            Procesar.Estatus0 = Estatus;
            Procesar.UsuarioAdiciona = UsuarioAdiciona;
            Procesar.FechaAdiciona = FechaAdiciona;
            Procesar.UsuarioModifica = UsuarioModifica;
            Procesar.FechaModifica = FechaModifica;
            Procesar.MontoCredito = MontoCredito;
            Procesar.EnvioEmail0 = EnvioEmail;

            var MAN = ObjDataEmpresa.Value.MantenimientoClientes(Procesar, Accion);
        }
    }
}
