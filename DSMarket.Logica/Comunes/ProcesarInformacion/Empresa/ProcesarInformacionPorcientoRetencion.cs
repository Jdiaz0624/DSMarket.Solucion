using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes.ProcesarInformacion.Empresa
{
    public class ProcesarInformacionPorcientoRetencion
    {
        readonly DSMarket.Logica.Logica.LogicaEmpresa.LogicaEmpresa ObjData = new Logica.LogicaEmpresa.LogicaEmpresa();

        private decimal IdPorcientoRetencion = 0;
        private decimal IdRetencion = 0;
        private int Secuencia = 0;
        private decimal MontoInicial = 0;
        private decimal MontoFinal = 0;
        private decimal MontoSumar = 0;
        private decimal PorcientoCia = 0;
        private decimal PorcientoEmpleado = 0;
        private bool Estatus0 = false;
        private decimal UsuarioAdiciona = 0;
        private string Accion = "";

        public ProcesarInformacionPorcientoRetencion(
            decimal IdPorcientoRetencionCON,
        decimal IdRetencionCON,
        int SecuenciaCON,
        decimal MontoInicialCON,
        decimal MontoFinalCON,
        decimal MontoSumarCON,
        decimal PorcientoCiaCON,
        decimal PorcientoEmpleadoCON,
        bool Estatus0CON,
        decimal UsuarioAdicionaCON,
        string AccionCON)
        {
            IdPorcientoRetencion = IdPorcientoRetencionCON;
            IdRetencion = IdRetencionCON;
            Secuencia = SecuenciaCON;
            MontoInicial = MontoInicialCON;
            MontoFinal = MontoFinalCON;
            MontoSumar = MontoSumarCON;
            PorcientoCia = PorcientoCiaCON;
            PorcientoEmpleado = PorcientoEmpleadoCON;
            Estatus0 = Estatus0CON;
            UsuarioAdiciona = UsuarioAdicionaCON;
            Accion = AccionCON;

        }
        public void ProcesarInformacion() {
            DSMarket.Logica.Entidades.EntidadesEmpresa.EPorcientoRetenciones Procesar = new Entidades.EntidadesEmpresa.EPorcientoRetenciones();

            Procesar.IdPorcientoRetencion = IdPorcientoRetencion;
            Procesar.IdRetencion = IdRetencion;
            Procesar.Secuencia = Secuencia;
            Procesar.MontoInicial = MontoInicial;
            Procesar.MontoFinal = MontoFinal;
            Procesar.MontoSumar = MontoSumar;
            Procesar.PorcientoCia = PorcientoCia;
            Procesar.PorcientoEmpleado = PorcientoEmpleado;
            Procesar.Estatus0 = Estatus0;
            Procesar.UsuarioAdiciona = UsuarioAdiciona;
            Procesar.FechaAdiciona = DateTime.Now;
            Procesar.UsuarioModifica = UsuarioAdiciona;
            Procesar.FechaModifica = DateTime.Now;

            var MAN = ObjData.MantenimientoPorcientoretencion(Procesar, Accion);
        }

    }
}
