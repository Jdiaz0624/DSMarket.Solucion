using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes.ProcesarInformacion.Empresa
{
    public class ProcesarInformacionNacionalidad
    {
        readonly DSMarket.Logica.Logica.LogicaEmpresa.LogicaEmpresa ObjDta = new Logica.LogicaEmpresa.LogicaEmpresa();

        private decimal IdNacionalidad = 0;
        private string Nacionalidad = "";
        private bool Estatus = false;
        private decimal IdUsuario = 0;
        private string Accion = "";

        public ProcesarInformacionNacionalidad(
            decimal IdNacionalidadCON,
            string NacionalidadCON,
            bool EstatusCON,
            decimal IdUsuarioCON,
            string AccionCON
            )
        {
            IdNacionalidad = IdNacionalidadCON;
            Nacionalidad = NacionalidadCON;
            Estatus = EstatusCON;
            IdUsuario = IdUsuarioCON;
            Accion = AccionCON;
        }

        public void ProcesarNacionalidad() {
            DSMarket.Logica.Entidades.EntidadesEmpresa.ENacionalidad Procesar = new Entidades.EntidadesEmpresa.ENacionalidad();

            Procesar.IdNacionalidad = IdNacionalidad;
            Procesar.Nacionalidad = Nacionalidad;
            Procesar.Estatus0 = Estatus;
            Procesar.UsuarioAdiciona = IdUsuario;
            Procesar.FechaAdiciona = DateTime.Now;
            Procesar.UsuarioModifica = IdUsuario;
            Procesar.FechaModifica = DateTime.Now;

            var MAn = ObjDta.MantenimientoNacionalidad(Procesar, Accion);
        }
    }
}
