using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes.ProcesarInformacion.Empresa
{
    public class ProcesarInformacionCitas
    {

        readonly DSMarket.Logica.Logica.LogicaEmpresa.LogicaEmpresa Objdata = new Logica.LogicaEmpresa.LogicaEmpresa();


        //VARIABLES DEL ENCABEZADO DE LAS CITAS
        private decimal IdCitasEncabezado = 0;
        private decimal IdEmpleadoEncabezado = 0;
        private DateTime FechaEncabezado = DateTime.Now;
        private string HoraEncabezado = "";
        private string NombreClienteEncabezado = "";
        private string TelefonoEncabezado = "";
        private string DireccionEncabezado = "";
        private string NumeroIdentificacionEncabezado = "";
        private decimal NumeroConectorEncabezado = 0;
        private bool EstatusEncabezado = false;
        private string AccionEncabezado = "";

        //VARIABLES DE LAS CITAS EN DETALLE
        private decimal NumeroConectorDetalle = 0;
        private decimal IdProductoDetalle = 0;
        private decimal PrecioDetalle = 0;
        private string DescripcionProductoDetalle = "";
        private string AccionDetalle = "";





        /// <summary>
        /// Este constructor es para procesar la informacion del encabezado de las citas
        /// </summary>
        /// <param name="IdCitasEncabezadoCON"></param>
        /// <param name="IdEmpleadoEncabezadoCON"></param>
        /// <param name="FechaEncabezadoCON"></param>
        /// <param name="HoraEncabezadoCON"></param>
        /// <param name="NombreClienteEncabezadoCON"></param>
        /// <param name="TelefonoEncabezadoCON"></param>
        /// <param name="DireccionEncabezadoCON"></param>
        /// <param name="NumeroIdentificacionEncabezadoCON"></param>
        /// <param name="NumeroConectorEncabezadoCON"></param>
        /// <param name="EstatusEncabezadoCON"></param>
        public ProcesarInformacionCitas(
        decimal IdCitasEncabezadoCON,
        decimal IdEmpleadoEncabezadoCON,
        DateTime FechaEncabezadoCON,
        string HoraEncabezadoCON,
        string NombreClienteEncabezadoCON,
        string TelefonoEncabezadoCON,
        string DireccionEncabezadoCON,
        string NumeroIdentificacionEncabezadoCON,
        decimal NumeroConectorEncabezadoCON,
        bool EstatusEncabezadoCON,
        string AccionEncabezadoCON)
        {
            IdCitasEncabezado = IdCitasEncabezadoCON;
            IdEmpleadoEncabezado = IdEmpleadoEncabezadoCON;
            FechaEncabezado = FechaEncabezadoCON;
            HoraEncabezado = HoraEncabezadoCON;
            NombreClienteEncabezado = NombreClienteEncabezadoCON;
            TelefonoEncabezado = TelefonoEncabezadoCON;
            DireccionEncabezado = DireccionEncabezadoCON;
            NumeroIdentificacionEncabezado = NumeroIdentificacionEncabezadoCON;
            NumeroConectorEncabezado = NumeroConectorEncabezadoCON;
            EstatusEncabezado = EstatusEncabezadoCON;
            AccionEncabezado = AccionEncabezadoCON;
        }


        /// <summary>
        /// Este constructor es para procesar la informacion del detalle de las citas
        /// </summary>
        /// <param name="NumeroConectorDetalleCON"></param>
        /// <param name="IdProductoDetalleCON"></param>
        /// <param name="PrecioDetalleCON"></param>
        /// <param name="DescripcionProductoDetalleCON"></param>
        public ProcesarInformacionCitas(
        decimal NumeroConectorDetalleCON,
        decimal IdProductoDetalleCON,
        decimal PrecioDetalleCON,
        string DescripcionProductoDetalleCON,
        string AccionDetalleCON)
        {
            NumeroConectorDetalle = NumeroConectorDetalleCON;
            IdProductoDetalle = IdProductoDetalleCON;
            PrecioDetalle = PrecioDetalleCON;
            DescripcionProductoDetalle = DescripcionProductoDetalleCON;
            AccionDetalle = AccionDetalleCON;
        }

        public void ProcesarInformacionCitasEncabezado() {
            DSMarket.Logica.Entidades.EntidadesEmpresa.ECitasEncabezado Procesar = new Entidades.EntidadesEmpresa.ECitasEncabezado();

            Procesar.IdCitas = IdCitasEncabezado;
            Procesar.IdEmpleado = IdEmpleadoEncabezado;
            Procesar.FechaCita0 = FechaEncabezado;
            Procesar.Hora = HoraEncabezado;
            Procesar.NombreCliente = NombreClienteEncabezado;
            Procesar.Telefono = TelefonoEncabezado;
            Procesar.Direccion = DireccionEncabezado;
            Procesar.NumeroIdentificacion = NumeroIdentificacionEncabezado;
            Procesar.NumeroConectorCita = NumeroConectorEncabezado;
            Procesar.Estatus0 = EstatusEncabezado;

            var MAN = Objdata.MantenimientoCitasEncabezado(Procesar, AccionEncabezado);
        }


        public void ProcesarInformacionDetalle() {
            DSMarket.Logica.Entidades.EntidadesEmpresa.ECitasDetalle Procesar = new Entidades.EntidadesEmpresa.ECitasDetalle();

            Procesar.NumeroConectorCita = NumeroConectorDetalle;
            Procesar.IdProducto = IdProductoDetalle;
            Procesar.Precio = PrecioDetalle;
            Procesar.DescripcionProducto = DescripcionProductoDetalle;

            var MAN = Objdata.GuardarDetalleCitas(Procesar, AccionDetalle);
        }

    }
}
