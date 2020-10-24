using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes.ProcesarInformacion.Empresa
{
    public class ProcesarInformacionTipoNomina 
    {
        readonly DSMarket.Logica.Logica.LogicaEmpresa.LogicaEmpresa ObjData = new Logica.LogicaEmpresa.LogicaEmpresa();

        private decimal IdTipoNomina = 0;
        private string TipoNomina = "";
        private bool Estatus = false;
        private decimal IdUsuario = 0;
        private string Accion = "";

        public ProcesarInformacionTipoNomina(
            decimal IdTipoNominaCON,
            string TipoNominaCON,
            bool EstatusCON,
            decimal IdUsuarioCON,
            string AccionCON)
        {
            IdTipoNomina = IdTipoNominaCON;
            TipoNomina = TipoNominaCON;
            Estatus = EstatusCON;
            IdUsuario = IdUsuarioCON;
            Accion = AccionCON;
        }

        public void ProcesarInformacion() {
            DSMarket.Logica.Entidades.EntidadesEmpresa.ETipoNomina Procesar = new Entidades.EntidadesEmpresa.ETipoNomina();

            Procesar.IdTipoNomina = IdTipoNomina;
            Procesar.TipoNomina = TipoNomina;
            Procesar.Estatus0 = Estatus;
            Procesar.UsuarioAdiciona = IdUsuario;
            Procesar.FechaAdiciona = DateTime.Now;
            Procesar.UsuairoModifica = IdUsuario;
            Procesar.FechaModifica = DateTime.Now;

            var MAN = ObjData.MantenimientoTipoNomina(Procesar, Accion);
        }
    }
}
