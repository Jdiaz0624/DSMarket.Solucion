using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes.ProcesarInformacion.Inventario
{
    public class ProcesarInformacionColores
    {
        readonly DSMarket.Logica.Logica.LogicaInventario.LogicaInventario ObjData = new Logica.LogicaInventario.LogicaInventario();

        private decimal IdColor = 0;
        private string Descripcion = "";
        private bool Estatus = false;
        private string Accion = "";

        public ProcesarInformacionColores(
            decimal IdColorCON,
            string DescripcionCON,
            bool EstatusCON,
            string AccionCON)
        {
            IdColor = IdColorCON;
            Descripcion = DescripcionCON;
            Estatus = EstatusCON;
            Accion = AccionCON;
        }
        /// <summary>
        /// Procesar información de los colores
        /// </summary>
        public void ProcesarInformacion() {
            DSMarket.Logica.Entidades.EntidadesInventario.EColores Procesar = new Entidades.EntidadesInventario.EColores();

            Procesar.IdColor = IdColor;
            Procesar.Color = Descripcion;
            Procesar.Estatus0 = Estatus;

            var MAN = ObjData.ProcesarColores(Procesar, Accion);


        }
    }
}
