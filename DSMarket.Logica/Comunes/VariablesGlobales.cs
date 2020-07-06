using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes
{
    public class VariablesGlobales
    {
        public string NombreSistema { get; set; }
        public bool ConvertirCotizacionFactura = false;
        public bool ModoRecarga { get; set; }
        public bool LlevaDescuentoPregunta { get; set; }
        public string Accion { get; set; }
        public decimal IdMantenimeinto { get; set; }
        public decimal Conector { get; set; }
        public string RutaImagen { get; set; }
        public decimal NumeroConector { get; set; }
        public int EstadisticaProducto { get; set; }
        public bool SacarDataEspejo { get; set; }
      // public bool Bloquear

        public bool BloqueaControles = false;
        public bool GenerarConector  { get; set; }
        public decimal SecuencialFActuraMinimizada { get; set; }

        public decimal IdProductoSeleccionadoAgregarPorpductos { get; set; }
        public decimal NumeroConectorSeleccionadoAgregarPorpductos { get; set; }


        public decimal IdTipoProductoSeleccionadoAgregarEditar { get; set; }
        public decimal IdCategoriaSeleccionadoAgregarEditar { get; set; }
        public decimal IdProductoSeleccionadoAgregarEditar { get; set; }
        public decimal IdNumeroConectorProductoAgregarEditar { get; set; }

        #region DATOS SACADOS DEL USUARIO EN EL LOGIN
        public bool Estatus { get; set; }
        public bool CambiaClave { get; set; }
        public string NombreUsuario { get; set; }
        public string NivelAcceso { get; set; }
        public decimal IdUsuario { get; set; }
        public decimal IdNivelAcceso { get; set; }
        #endregion
    }
}
