using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes.ProcesarInformacion
{
    public class ProcesarInformacionColoresArticulos
    {
        public readonly DSMarket.Logica.Logica.LogicaInventario.LogicaInventario ObjData = new Logica.LogicaInventario.LogicaInventario();

        private decimal IdColor = 0;
        private string Color = "";
        private bool Estatus = false;
        private decimal IdUsuario = 0;
        private DateTime Fechaproceso = DateTime.Now;
        private string Accion = "";

        public ProcesarInformacionColoresArticulos(
        decimal IdColorCON,
        string ColorCON,
        bool EstatusCON,
        decimal IdUsuarioCON,
        DateTime FechaprocesoCON,
        string AccionCON)
        {
            IdColor = IdColorCON;
            Color = ColorCON;
            Estatus = EstatusCON;
            IdUsuario = IdUsuarioCON;
            Fechaproceso = FechaprocesoCON;
            Accion = AccionCON;
        }
        public void ProcesarInformacion() {
            DSMarket.Logica.Entidades.EntidadesInventario.EColorArticulo Procesar = new Entidades.EntidadesInventario.EColorArticulo();

            Procesar.IdColor = IdColor;
            Procesar.Color = Color;
            Procesar.Estatus0 = Estatus;
            Procesar.UsuarioAdiciona = IdUsuario;
            Procesar.FechaAdiciona = Fechaproceso;
            Procesar.UsuarioModifica = IdUsuario;
            Procesar.FechaModifica = Fechaproceso;

            var MAN = ObjData.MantenimientoColorArticulos(Procesar, Accion);
        }
    }
}
