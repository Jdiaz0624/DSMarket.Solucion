using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes.ProcesarInformacion.Servicio
{
    public class ProcesarInformacionComisionesEmpleados
    {
        readonly DSMarket.Logica.Logica.LogicaServicio.LogicaServicio ObjData = new Logica.LogicaServicio.LogicaServicio();

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
        private string Accion = "";

        public ProcesarInformacionComisionesEmpleados(
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
            string AccionCON)
        {
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
            Accion = AccionCON;
        }
        public void ProcesarComisiones() {
            DSMarket.Logica.Entidades.EntidadesServicio.EComisionesEmpleados Procesar = new Entidades.EntidadesServicio.EComisionesEmpleados();

            Procesar.IdRegistro = IdRegistro;
            Procesar.IdEmpleado = IdEmpleado;
            Procesar.IdTipoProducto = IdTipoProducto;
            Procesar.PrecioProducto = PrecioProducto;
            Procesar.DescuentoAplicado = DescuentoAplicado;
            Procesar.ComisionEmpleado = ComisionEmpleado;
            Procesar.NumeroConectorOperacion = NumeroConectorOperacion;
            Procesar.IdProducto = IdProducto;
            Procesar.ConectorProducto = ConectorProducto;

            var MAN = ObjData.ProcesarComsionEmpleados(Procesar, Accion);
        }
    }
}
