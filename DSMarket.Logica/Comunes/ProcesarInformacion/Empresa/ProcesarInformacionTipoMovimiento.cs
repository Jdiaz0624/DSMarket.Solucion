using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes.ProcesarInformacion.Empresa
{
    public class ProcesarInformacionTipoMovimiento
    {
        readonly DSMarket.Logica.Logica.LogicaEmpresa.LogicaEmpresa ObjData = new Logica.LogicaEmpresa.LogicaEmpresa();

        private decimal IdTipoMovimiento = 0;
        private string TipoMovimiento = "";
        private bool Estatus = false;
        private decimal UsuarioAdiciona = 0;
        private DateTime FechaAdiciona = DateTime.Now;
        private decimal UsuarioModifica = 0;
        private DateTime FechaModifica = DateTime.Now;
        private string Accion = "";

        public ProcesarInformacionTipoMovimiento(
        decimal IdTipoMovimientoCON,
        string TipoMovimientoCON,
        bool EstatusCON,
        decimal UsuarioAdicionaCON,
        DateTime FechaAdicionaCON,
        decimal UsuarioModificaCON,
        DateTime FechaModificaCON,
        string AccionCON)
        {
            IdTipoMovimiento = IdTipoMovimientoCON;
            TipoMovimiento = TipoMovimientoCON;
            Estatus = EstatusCON;
            UsuarioAdiciona = UsuarioAdicionaCON;
            FechaAdiciona = FechaAdicionaCON;
             UsuarioModifica = UsuarioModificaCON;
            FechaModifica = FechaModificaCON;
            Accion = AccionCON;
        }

        public void ProcesarInformacion() {
            DSMarket.Logica.Entidades.EntidadesEmpresa.ETipoMovimiento Procesar = new Entidades.EntidadesEmpresa.ETipoMovimiento();

            Procesar.IdTipoMovimiento = IdTipoMovimiento;
            Procesar.TipoMovimiento = TipoMovimiento;
            Procesar.Estatus0 = Estatus;
            Procesar.UsuarioAdiciona = UsuarioAdiciona;
            Procesar.FechaAdiciona = FechaAdiciona;
            Procesar.UsuarioModifica = UsuarioModifica;
            Procesar.FechaModifica = FechaModifica;

            var MAN = ObjData.MantenimientoTipoMovimiento(Procesar, Accion);
        }
    }
}
