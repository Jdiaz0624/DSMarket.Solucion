using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes.ProcesarInformacion.Empresa
{
    public class ProcesarInformacionEstadoCivil
    {
        readonly DSMarket.Logica.Logica.LogicaEmpresa.LogicaEmpresa ObjDta = new Logica.LogicaEmpresa.LogicaEmpresa();

        private decimal IdEstadoCivil = 0;
        private string EstadoCivil = "";
        private bool Estatus = false;
        private decimal IdUsuario = 0;
        private string Accion = "";

        public ProcesarInformacionEstadoCivil(
            decimal IdEstadoCivilCON,
            string EstadoCivilCON,
            bool EstatusCON,
            decimal IdUsuarioCON,
            string AccionCON
            )
        {
            IdEstadoCivil = IdEstadoCivilCON;
            EstadoCivil = EstadoCivilCON;
            Estatus = EstatusCON;
            IdUsuario = IdUsuarioCON;
            Accion = AccionCON;
        }

        public void ProcesarEstadoCivil()
        {
            DSMarket.Logica.Entidades.EntidadesEmpresa.EEstadoCivil Procesar = new Entidades.EntidadesEmpresa.EEstadoCivil();

            Procesar.IdEstadoCivil = IdEstadoCivil;
            Procesar.EstadoCivil = EstadoCivil;
            Procesar.Estatus0 = Estatus;
            Procesar.UsuarioAdiciona = IdUsuario;
            Procesar.FechaAdiciona = DateTime.Now;
            Procesar.UsuarioModifica = IdUsuario;
            Procesar.FechaModifica = DateTime.Now;

            var MAn = ObjDta.MantenimientoEstadoCivil(Procesar, Accion);
        }
    }
}
