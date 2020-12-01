using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes.ProcesarInformacion.Empresa
{
    public class ProcesarInformacionFormaPagoEmpleado
    {
        readonly DSMarket.Logica.Logica.LogicaEmpresa.LogicaEmpresa ObjDta = new Logica.LogicaEmpresa.LogicaEmpresa();

        private decimal IdFormaPagoEmpleado = 0;
        private string FormaPago = "";
        private bool Estatus = false;
        private decimal IdUsuario = 0;
        private string Accion = "";

        public ProcesarInformacionFormaPagoEmpleado(
            decimal IdFormaPagoEmpleadoCON,
            string FormaPagoCON,
            bool EstatusCON,
            decimal IdUsuarioCON,
            string AccionCON
            )
        {
            IdFormaPagoEmpleado = IdFormaPagoEmpleadoCON;
            FormaPago = FormaPagoCON;
            Estatus = EstatusCON;
            IdUsuario = IdUsuarioCON;
            Accion = AccionCON;
        }

        public void ProcesarFormaPago()
        {
            DSMarket.Logica.Entidades.EntidadesEmpresa.EFormaPagoEmpleado Procesar = new Entidades.EntidadesEmpresa.EFormaPagoEmpleado();

            Procesar.IdFormaPagoEmpleado = IdFormaPagoEmpleado;
            Procesar.FormaPago = FormaPago;
            Procesar.Estatus0 = Estatus;
            Procesar.UsuarioAdiciona = IdUsuario;
            Procesar.FechaAdiciona = DateTime.Now;
            Procesar.UsuarioModifica = IdUsuario;
            Procesar.FechaModifica = DateTime.Now;

            var MAn = ObjDta.MantenimientoFormaPago(Procesar, Accion);
        }
    }
}
