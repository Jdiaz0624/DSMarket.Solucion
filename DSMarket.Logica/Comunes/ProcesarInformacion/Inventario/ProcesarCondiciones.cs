using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes.ProcesarInformacion.Inventario
{
    public class ProcesarCondiciones
    {
        readonly DSMarket.Logica.Logica.LogicaInventario.LogicaInventario ObjData = new Logica.LogicaInventario.LogicaInventario();

        private decimal IdCondicion = 0;
        private string Descripcion = "";
        private bool Estatus = false;
        private string Accion = "";

        public ProcesarCondiciones(
            decimal IdCondicionON,
        string DescripcionCON,
        bool EstatusCON,
        string AccionCON)
        {
            IdCondicion = IdCondicionON;
            Descripcion = DescripcionCON;
            Estatus = EstatusCON;
            Accion = AccionCON;
        }

        /// <summary>
        /// Procesar las condiciones de los equipos
        /// </summary>
        public void ProcesarInformacion() {
            DSMarket.Logica.Entidades.EntidadesInventario.ECondicion Procesar = new Entidades.EntidadesInventario.ECondicion();

            Procesar.IdCondicion = IdCondicion;
            Procesar.Condicion = Descripcion;
            Procesar.Estatus0 = Estatus;

            var MAN = ObjData.ProcesarCondiciones(Procesar, Accion);
        }
    }
}
