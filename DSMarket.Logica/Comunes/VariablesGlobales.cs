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
        public string DescripcionTipoProductoAgregarProductos { get; set; }


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


        #region MODIFICAR LOS REGISTROS AGREGADOS A FACTURA
        public decimal IdHistorialProductoModificarRegistro { get; set; }
        public decimal IdProductoModificarRegistro { get; set; }
        public string TipoProductoModificarRegistro { get; set; }
        public string CategoriaModificarRegistro { get; set; }
        public string ProductoModificarRegistro { get; set; }
        public string CantidadAgregadaModificarregistro { get; set; }
        public string CantidadUsarModificarRegistro { get; set; }
        public string PrecioModificarRegistro { get; set; }
        public string PorcientoDescuentoModificarRegistro { get; set; }
        public string DescuentoAplicadoModificarRegistro { get; set; }
        public string AcumulativoModificarRegistro { get; set; }
       public int CantidadUsadaModificarRegistro { get; set; }
        public int DiferenciaCantidadUsada { get; set; }
        public decimal IdTipoProductoModificarRegistro { get; set; }
        public decimal IdCategoriaModificarRegistro { get; set; }

        #endregion

        #region VARIABLES PARA MODIFICAR LOS ARTICULOS AGREGADOS A FACTURA

        public int CantidadDispobible { get; set; }
        public int CantidadUsar { get; set; }
        public int Diferencia { get; set; }
        public int NuevaCantidad { get; set; }
        public int CantidadRegistrosIngresadaEliminarRegistro { get; set; }
        public decimal IdHistorialProductoEliminarRegistro { get; set; }
        #endregion
        public bool AplicaImpuesto { get; set; }
        public decimal IdTipoProductoNuevo { get; set; }
        public decimal IdEstatusFacturacionHistorial { get; set; }
        public string EstatusFacturacion { get; set; }

        public bool FacturacionProducto { get; set; }


        #region VARIABLES PARA LA ANULACION DE LAS FACTURAS
        public decimal IdTipoIdentificacionAnularFactura { get; set; }
        public string NumeroIdentificacionAnularFactura { get; set; }
        public decimal IdTipoVentaAnularFactura { get; set; }
        public decimal IdCantidadDiasAnularFactura { get; set; }
        public int PorcientoDescuentoAnularFactura { get; set; }
        public decimal IdTipOpagoAnularFactura { get; set; }

        public decimal IdTipoProductoAnularFactura { get; set; }
        public bool AcumulativoAnularFactura { get; set; }
        #endregion

        public bool GananciaFacturaUnica { get; set; }

    }
}
