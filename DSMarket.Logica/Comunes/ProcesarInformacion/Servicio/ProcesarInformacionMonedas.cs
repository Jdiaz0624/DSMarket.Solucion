using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes.ProcesarInformacion.Servicio
{
    public class ProcesarInformacionMonedas
    {
        readonly DSMarket.Logica.Logica.LogicaServicio.LogicaServicio ObjData = new Logica.LogicaServicio.LogicaServicio();

        private decimal IdMoneda = 0;
        private string Descripcion = "";
        private string Sigla = "";
        private bool Estatus = false;
        private decimal Tasa = 0;
        private decimal IdUsuario = 0;
        private bool PorDefecto = false;
        private string Accion = "";

        public ProcesarInformacionMonedas(
            decimal IdMonedaCON,
        string DescripcionCON,
        string SiglaCON,
        bool EstatusCON,
        decimal TasaCON,
        decimal IdUsuarioCON,
        bool PorDefectoCON,
        string AccionCON)
        {
            IdMoneda = IdMonedaCON;
            Descripcion = DescripcionCON;
            Sigla = SiglaCON;
            Estatus = EstatusCON;
            Tasa = TasaCON;
            IdUsuario = IdUsuarioCON;
            PorDefecto = PorDefectoCON;
            Accion = AccionCON;
        }
        /// <summary>
        /// Procesar Informacion de Monedas
        /// </summary>
        public void ProcesarInformacion() {
            DSMarket.Logica.Entidades.EntidadesServicio.EMoneda Procesar = new Entidades.EntidadesServicio.EMoneda();

            Procesar.IdMoneda = IdMoneda;
            Procesar.Moneda = Descripcion;
            Procesar.Sigla = Sigla;
            Procesar.Estatus0 = Estatus;
            Procesar.Tasa = Tasa;
            Procesar.UsuarioAdiciona = IdUsuario;
            Procesar.FechaAdiciona = DateTime.Now;
            Procesar.UsuarioModifica = IdUsuario;
            Procesar.FechaModifica = DateTime.Now;
            Procesar.PorDefecto0 = PorDefecto;

            var MAN = ObjData.ProcesarMonedas(Procesar, Accion);
        }
    }
}
