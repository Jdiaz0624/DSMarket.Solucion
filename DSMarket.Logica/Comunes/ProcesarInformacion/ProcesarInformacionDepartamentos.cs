using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes.ProcesarInformacion
{
    public class ProcesarInformacionDepartamentos
    {
        readonly DSMarket.Logica.Logica.LogicaEmpresa.LogicaEmpresa ObjData = new Logica.LogicaEmpresa.LogicaEmpresa();

        private decimal IdDepartamento = 0;
        private string Descripcion = "";
        private bool Estatus = false;
        private decimal UsuarioAdiciona = 0;
        private DateTime FechaAdiciona = DateTime.Now;
        private decimal UsuarioModifica = 0;
        private DateTime FechaModifica = DateTime.Now;
        private string Accion = "";

        public ProcesarInformacionDepartamentos(
            decimal IdDepartamentoCON,
        string DescripcionCON,
        bool EstatusCON,
        decimal UsuarioAdicionaCON,
        DateTime FechaAdicionaCON,
        decimal UsuarioModificaCON,
        DateTime FechaModificaCON,
        string AccionCON)
        {
            IdDepartamento = IdDepartamentoCON;
            Descripcion = DescripcionCON;
            Estatus = EstatusCON;
            UsuarioAdiciona = UsuarioAdicionaCON;
            FechaAdiciona = FechaAdicionaCON;
            UsuarioModifica = UsuarioModificaCON;
            FechaModifica = FechaModificaCON;
            Accion = AccionCON;
        }

        public void ProcesarInformacion() {
            DSMarket.Logica.Entidades.EntidadesEmpresa.EDepartamentos Procesar = new Entidades.EntidadesEmpresa.EDepartamentos();

            Procesar.IdDepartamento = IdDepartamento;
            Procesar.Departamento = Descripcion;
            Procesar.Estatus0 = Estatus;
            Procesar.UsuarioAdiciona = UsuarioAdiciona;
            Procesar.FechaAdiciona = FechaAdiciona;
            Procesar.UsuarioModifica = UsuarioModifica;
            Procesar.FechaModifica = FechaModifica;

            var MAN = ObjData.MantenimientoDepartamentos(Procesar, Accion);
        }

    }
}
