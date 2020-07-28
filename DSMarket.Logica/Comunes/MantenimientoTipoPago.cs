using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes
{
    public class MantenimientoTipoPago
    {
        public readonly Lazy<DSMarket.Logica.Logica.LogicaServicio.LogicaServicio> ObjdataServicios = new Lazy<Logica.LogicaServicio.LogicaServicio>();


        private decimal IdTipoPago = 0;
        private string Descripcion = "";
        private bool Estatus = false;
        private decimal UsuarioAdiciona = 0;
        private DateTime FechaAdiciona = DateTime.Now;
        private decimal UsuarioModifica = 0;
        private DateTime FechaModifica = DateTime.Now;
        private bool BloqueaMonto = false;
        private string Accion = "";

        public MantenimientoTipoPago(
            decimal IdTipoPagoCON,
            string DescripcionCON,
            bool EstatusCON,
            decimal UsuarioAdicionaCON,
            DateTime FechaAdicionaCON,
            decimal UsuarioModificaCON,
            DateTime FechaModificaCON,
            bool BloqueaMontoCON,
            string AccionCON)
        {
            IdTipoPago = IdTipoPagoCON;
            Descripcion = DescripcionCON;
            Estatus = EstatusCON;
            UsuarioAdiciona = UsuarioAdicionaCON;
            FechaAdiciona = FechaAdicionaCON;
            UsuarioModifica = UsuarioModificaCON;
            FechaModifica = FechaModificaCON;
            BloqueaMonto = BloqueaMontoCON;
            Accion = AccionCON;
           
        }

        public void MANtenimeinto() {
            DSMarket.Logica.Entidades.EntidadesServicio.EMantenimientoTipoPago Mantenimiento = new Entidades.EntidadesServicio.EMantenimientoTipoPago();

            Mantenimiento.IdTipoPago = IdTipoPago;
            Mantenimiento.Descripcion = Descripcion;
            Mantenimiento.Estatus = Estatus;
            Mantenimiento.UsuarioAdiciona = UsuarioAdiciona;
            Mantenimiento.FechaAdiciona = FechaAdiciona;
            Mantenimiento.UsuarioModifica = UsuarioModifica;
            Mantenimiento.FechaModifica = FechaModifica;
            Mantenimiento.BloqueaMonto = BloqueaMonto;

            var MAN = ObjdataServicios.Value.MantenimientoTipoPago(Mantenimiento, Accion);
        }

        
    }
}
