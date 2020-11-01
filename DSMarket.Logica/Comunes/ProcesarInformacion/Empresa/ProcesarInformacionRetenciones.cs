using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes.ProcesarInformacion.Empresa
{
    public class ProcesarInformacionRetenciones
    {
        readonly DSMarket.Logica.Logica.LogicaEmpresa.LogicaEmpresa ObjData = new Logica.LogicaEmpresa.LogicaEmpresa();

        private decimal IdRetencion = 0;
        private string Retencion = "";
        private bool Estatus = false;
        private decimal IdUsuario = 0;
        private string Accion = "";

        public ProcesarInformacionRetenciones(
            decimal IdRetencionCON,
        string RetencionCON,
        bool EstatusCON,
        decimal IdUsuarioCON,
        string AccionCON)
        {
            IdRetencion = IdRetencionCON;
            Retencion = RetencionCON;
            Estatus = EstatusCON;
            IdUsuario = IdUsuarioCON;
            Accion = AccionCON;
        }

        public void ProcesarInformacion() {
            DSMarket.Logica.Entidades.EntidadesEmpresa.ERetenciones Procesar = new Entidades.EntidadesEmpresa.ERetenciones();

            Procesar.IdRetencion = IdRetencion;
            Procesar.Retencion = Retencion;
            Procesar.Estatus0 = Estatus;
            Procesar.UsuarioAdiciona = IdUsuario;
            Procesar.FechaAdiciona = DateTime.Now;
            Procesar.UsuarioModifica = IdUsuario;
            Procesar.FechaModifica = DateTime.Now;

            var MAN = ObjData.MantenimientoRetenciones(Procesar, Accion);
        }
    }
}
