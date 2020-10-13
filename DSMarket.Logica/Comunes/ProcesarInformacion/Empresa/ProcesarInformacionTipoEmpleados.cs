using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes.ProcesarInformacion.Empresa
{
    public class ProcesarInformacionTipoEmpleados
    {
        readonly DSMarket.Logica.Logica.LogicaEmpresa.LogicaEmpresa ObjData = new Logica.LogicaEmpresa.LogicaEmpresa();

        private decimal IdTipoEmpleado = 0;
        private string Descripcion = "";
        private bool Estatus = false;
        private decimal UsuarioProcesa = 0;
        private string Accion = "";

        public ProcesarInformacionTipoEmpleados(
            decimal IdTipoEmpleadoCON,
            string DescripcionCON,
            bool EstatusCON,
            decimal UsuarioProcesaCON,
            string AccionCON)
        {
            IdTipoEmpleado = IdTipoEmpleadoCON;
            Descripcion = DescripcionCON;
            Estatus = EstatusCON;
            UsuarioProcesa = UsuarioProcesaCON;
            Accion = AccionCON;
        }

        public void ProcesarInformacion() {
            DSMarket.Logica.Entidades.EntidadesEmpresa.ETipoEmpleado Procesar = new Entidades.EntidadesEmpresa.ETipoEmpleado();

            Procesar.IdTipoEmpleado = IdTipoEmpleado;
            Procesar.TipoEmpleado = Descripcion;
            Procesar.Estatus0 = Estatus;
            Procesar.UsuarioAdiciona = UsuarioProcesa;
            Procesar.FechaAdiciona = DateTime.Now;
            Procesar.UsuarioModifica = UsuarioProcesa;
            Procesar.FechaModifica = DateTime.Now;

            var MAN = ObjData.MantenimientoTipoEmpleado(Procesar, Accion);
        }
    }
}
