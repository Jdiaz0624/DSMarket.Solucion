using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes.ProcesarInformacion.Configuracion
{
    public class ProcesarInformacionDatosreporteEmpleados
    {
        readonly DSMarket.Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion ObjData = new Logica.LogicaConfiguracion.LogicaCOnfiguracion();

        private decimal IdUsuario = 0;
        private decimal IdRegistro = 0;
        private decimal IdEmpleado = 0;
        private decimal IdTipoProducto = 0;
        private decimal PrecioProducto = 0;
        private decimal DescuentoAplicado = 0;
        private decimal ComisionEmpleado = 0;
        private decimal NumeroConectorOperacion = 0;
        private decimal IdProducto = 0;
        private decimal ConectorProducto = 0;
        private DateTime Fecha = DateTime.Now;
        private bool Estatus = false;
        private DateTime ValidadoDesde = DateTime.Now;
        private DateTime ValidadoHasta = DateTime.Now;
        private string Accion = "";

        public ProcesarInformacionDatosreporteEmpleados(
           decimal IdUsuarioCON,
           decimal IdRegistroCON,
           decimal IdEmpleadoCON,
           decimal IdTipoProductoCON,
           decimal PrecioProductoCON,
           decimal DescuentoAplicadoCON,
           decimal ComisionEmpleadoCON,
           decimal NumeroConectorOperacionCON,
           decimal IdProductoCON,
           decimal ConectorProductoCON,
           DateTime FechaCON,
           bool EstatusCON,
           DateTime ValidadoDesdeCON,
           DateTime ValidadoHastaCON,
           string AccionCON)
        {
            IdUsuario = IdUsuarioCON;
            IdRegistro = IdRegistroCON;
            IdEmpleado = IdEmpleadoCON;
            IdTipoProducto = IdTipoProductoCON;
            PrecioProducto = PrecioProductoCON;
            DescuentoAplicado = DescuentoAplicadoCON;
            ComisionEmpleado = ComisionEmpleadoCON;
            NumeroConectorOperacion = NumeroConectorOperacionCON;
            IdProducto = IdProductoCON;
            ConectorProducto = ConectorProductoCON;
            Fecha = FechaCON;
            Estatus = EstatusCON;
            ValidadoDesde = ValidadoDesdeCON;
            ValidadoHasta = ValidadoHastaCON;
             Accion = AccionCON;
        }
        public void ProcesarInformacionDatosComisiones() {
            DSMarket.Logica.Entidades.EntidadesConfiguracion.EProcesarDatosComisionEmpleado Procesar = new Entidades.EntidadesConfiguracion.EProcesarDatosComisionEmpleado();

            Procesar.IdUsuario = IdUsuario;
            Procesar.IdRegistro = IdRegistro;
            Procesar.IdEmpleado = IdEmpleado;
            Procesar.IdTipoProducto = IdTipoProducto;
            Procesar.PrecioProducto = PrecioProducto;
            Procesar.DescuentoAplicado = DescuentoAplicado;
            Procesar.ComisionEmpleado = ComisionEmpleado;
            Procesar.NumeroConectorOperacion = NumeroConectorOperacion;
            Procesar.IdProducto = IdProducto;
            Procesar.ConectorProducto = ConectorProducto;
            Procesar.Fecha = Fecha;
            Procesar.Estatus = Estatus;
            Procesar.ValidadoDesde = ValidadoDesde;
            Procesar.ValidadoHasta = ValidadoHasta;

            var MAN = ObjData.ProcesarInformacionDatosReporteEmpleado(Procesar, Accion);
        }
    }
}
