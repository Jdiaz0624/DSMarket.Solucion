using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes
{
    public class ProcesarUsuarios
    {
        public readonly Lazy<DSMarket.Logica.Logica.LogicaSeguridad.LogicaSeguridad> ObjDataSeguridad = new Lazy<Logica.LogicaSeguridad.LogicaSeguridad>();

        //VARIABLES

        private decimal IdUsuario = 0;
        private decimal IdNivelAcceso = 0;
        private string Usuario = "";
        private string Clave = "";
        private string Persona = "";
        private bool Estatus = false;
        private bool CambiaClave = false;
        private decimal UsuarioProcesa = 0;
        private string Accion = "";

        public ProcesarUsuarios(
            decimal IdUsuarioCON,
            decimal IdNivelAccesoCon,
            string UsuarioCOn,
            string ClaveCon,
            string PersonaCOn,
            bool EstatusCon,
            bool CambiaClaveCon,
            decimal UsuarioProcesaCon,
            string AccionCOn)
        {
            IdUsuario = IdUsuarioCON;
            IdNivelAcceso = IdNivelAccesoCon;
            Usuario = UsuarioCOn;
            Clave = ClaveCon;
            Persona = PersonaCOn;
            Estatus = EstatusCon;
            CambiaClave = CambiaClaveCon;
            UsuarioProcesa = UsuarioProcesaCon;
            Accion = AccionCOn;
        }

        public void MAntenimientoUsuarios()
        {
            DSMarket.Logica.Entidades.EntidadesSeguridad.EMantenimientoUsuario Mantenimiento = new Entidades.EntidadesSeguridad.EMantenimientoUsuario();

            Mantenimiento.IdUsuario = IdUsuario;
            Mantenimiento.IdNivelAcceso = IdNivelAcceso;
            Mantenimiento.Usuario = Usuario;
            Mantenimiento.Clave = Clave;
            Mantenimiento.Persona = Persona;
            Mantenimiento.Estatus = Estatus;
            Mantenimiento.CambiaClave = CambiaClave;
            Mantenimiento.UsuarioAdicona = UsuarioProcesa;
            Mantenimiento.FechaAdiciona = DateTime.Now;
            Mantenimiento.UsuarioModifica = UsuarioProcesa;
            Mantenimiento.FechaModifica = DateTime.Now;

            var MAN = ObjDataSeguridad.Value.MantenimientoUsuarios(Mantenimiento, Accion);
        }
    }
}
