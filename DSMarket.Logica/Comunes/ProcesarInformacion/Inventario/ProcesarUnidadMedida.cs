using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes.ProcesarInformacion.Inventario
{
    public class ProcesarUnidadMedida
    {
        readonly DSMarket.Logica.Logica.LogicaInventario.LogicaInventario ObjData = new Logica.LogicaInventario.LogicaInventario();

        private decimal IdUnidadMedida = 0;
        private string Descripcion = "";
        private bool Estatus = false;
        private string Accion = "";

        public ProcesarUnidadMedida(
            decimal IdUnidadMedidaCON,
        string DescripcionCON,
        bool EstatusCON,
        string AccionCON)
        {
            IdUnidadMedida = IdUnidadMedidaCON;
            Descripcion = DescripcionCON;
            Estatus = EstatusCON;
            Accion = AccionCON;
        }
        /// <summary>
        /// Procesar informacion de las unidades de medidas
        /// </summary>
        public void ProcesarInformacion() {
            DSMarket.Logica.Entidades.EntidadesInventario.EUnidadMEdida Procesar = new Entidades.EntidadesInventario.EUnidadMEdida();

            Procesar.IdUnidadMedida = IdUnidadMedida;
            Procesar.UnidadMedida = Descripcion;
            Procesar.Estatus0 = Estatus;

            var MAN = ObjData.ProcesarUnidadMedida(Procesar, Accion);
        }
    }
}
