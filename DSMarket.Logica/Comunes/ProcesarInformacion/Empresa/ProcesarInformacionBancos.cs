using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes.ProcesarInformacion.Empresa
{
    public class ProcesarInformacionBancos
    {
        readonly DSMarket.Logica.Logica.LogicaEmpresa.LogicaEmpresa ObjDaa = new Logica.LogicaEmpresa.LogicaEmpresa();

        private decimal IdBanco = 0;
        private int CuentaContable = 0;
        private int Auxiliar = 0;
        private string Banco = "";
        private bool Estatus = false;
        private decimal IdUsuario = 0;
        private string Accion = "";

        public ProcesarInformacionBancos(
            decimal IdBancoCON,
            int CuentaContableCON,
            int AuxiliarCON,
            string BancoCON,
            bool EstatusCON,
            decimal IdUsuarioCON,
            string AccionCON)
        {
            IdBanco = IdBancoCON;
            CuentaContable = CuentaContableCON;
            Auxiliar = AuxiliarCON;
            Banco = BancoCON;
            Estatus = EstatusCON;
            IdUsuario = IdUsuarioCON;
            Accion = AccionCON;
        }

        public void ProcesarInformacion() {
            DSMarket.Logica.Entidades.EntidadesEmpresa.EBancos Procesar = new Entidades.EntidadesEmpresa.EBancos();

            Procesar.IdBanco = IdBanco;
            Procesar.CuentaContable = CuentaContable;
            Procesar.Auxiliar = Auxiliar;
            Procesar.Banco = Banco;
            Procesar.Estatus0 = Estatus;
            Procesar.UsuarioAdiciona = IdUsuario;
            Procesar.FechaAdiciona = DateTime.Now;
            Procesar.UsuarioModifica = IdUsuario;
            Procesar.FechaModifica = DateTime.Now;

            var MAN = ObjDaa.MantenimientoBancos(Procesar, Accion);
        }
    }
}
