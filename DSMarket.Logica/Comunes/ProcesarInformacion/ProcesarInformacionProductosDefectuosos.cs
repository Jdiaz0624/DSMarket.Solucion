using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes.ProcesarInformacion
{
    public class ProcesarInformacionProductosDefectuosos
    {
        readonly DSMarket.Logica.Logica.LogicaInventario.LogicaInventario ObjData = new Logica.LogicaInventario.LogicaInventario();

		private decimal IdProductoDefectuoso = 0; //
		private decimal NumeroConector = 0;
		private decimal IdTipoProducto = 0;
		private string Producto = "";
		private decimal IdCategoria = 0;
		private decimal IdUnidadMedida = 0;
		private decimal IdMarca = 0;
		private decimal IdModelo = 0;
		private decimal IdColor = 0;
		private decimal IdCondicion = 0;
		private decimal IdCapacidad = 0;
		private decimal IdTipoSuplidor = 0;
		private decimal IdSuplidor = 0;
		private string CodigoBarra = "";
		private string Referencia = "";
		private decimal PrecioCompra = 0;
		private decimal PrecioVenta = 0;
		private decimal Stock = 0;
		private decimal StockMinimo = 0;
		private decimal PorcientoDescuento = 0;
		private bool AfectaOferta0 = false;
		private bool ProductoAcumulativo0 = false;
		private bool LlevaImagen0 = false;
		private decimal UsuarioAdiciona = 0;
		private DateTime FechaAdiciona = DateTime.Now;
		private decimal UsuarioModifica = 0;
		private DateTime FechaModifica = DateTime.Now;
		private DateTime Fecha = DateTime.Now;
		private bool AplicaParaImpuesto0 = false;
		private bool EstatusProducto0 = false;
		private decimal CantidadAgregada = 0;
		private string NumeroSeguimiento = "";
		private string Comentario = "";
		private string Accion = "";

		public ProcesarInformacionProductosDefectuosos(
		decimal IdProductoDefectuosoCON,
		decimal NumeroConectorCON,
		decimal IdTipoProductoCON,
		string ProductoCON,
		decimal IdCategoriaCON,
		decimal IdUnidadMedidaCON,
		decimal IdMarcaCON,
		decimal IdModeloCON,
		decimal IdColorCON,
		decimal IdCondicionCON,
		decimal IdCapacidadCON,
		decimal IdTipoSuplidorCON,
		decimal IdSuplidorCON,
		string CodigoBarraCON,
		string ReferenciaCON,
		decimal PrecioCompraCON,
		decimal PrecioVentaCON,
		decimal StockCON,
		decimal StockMinimoCON,
		decimal PorcientoDescuentoCON,
		bool AfectaOferta0CON,
		bool ProductoAcumulativo0CON,
		bool LlevaImagen0CON,
		decimal UsuarioAdicionaCON,
		DateTime FechaAdicionaCON,
		decimal UsuarioModificaCON,
		DateTime FechaModificaCON,
		DateTime FechaCON,
		bool AplicaParaImpuesto0CON,
		bool EstatusProducto0CON,
		decimal CantidadAgregadaCON,
		string NumeroSeguimientoCON,
		string ComentarioCON,
		string AccionCON)
		{
			IdProductoDefectuoso = IdProductoDefectuosoCON;
			NumeroConector = NumeroConectorCON;
			IdTipoProducto = IdTipoProductoCON;
			Producto = ProductoCON;
			IdCategoria = IdCategoriaCON;
			IdUnidadMedida = IdUnidadMedidaCON;
			IdMarca = IdMarcaCON;
			IdModelo = IdModeloCON;
			IdColor = IdColorCON;
			IdCondicion = IdCondicionCON;
			IdCapacidad = IdCapacidadCON;
			IdTipoSuplidor = IdTipoSuplidorCON;
			IdSuplidor = IdSuplidorCON;
			CodigoBarra = CodigoBarraCON;
			Referencia = ReferenciaCON;
			PrecioCompra = PrecioCompraCON;
			PrecioVenta = PrecioVentaCON;
			Stock = StockCON;
			StockMinimo = StockMinimoCON;
			PorcientoDescuento = PorcientoDescuentoCON;
			AfectaOferta0 = AfectaOferta0CON;
			ProductoAcumulativo0 = ProductoAcumulativo0CON;
			LlevaImagen0 = LlevaImagen0CON;
			UsuarioAdiciona = UsuarioAdicionaCON;
			FechaAdiciona = FechaAdicionaCON;
			UsuarioModifica = UsuarioModificaCON;
			FechaModifica = FechaModificaCON;
			Fecha = FechaCON;
			AplicaParaImpuesto0 = AplicaParaImpuesto0CON;
			EstatusProducto0 = EstatusProducto0CON;
			CantidadAgregada = CantidadAgregadaCON;
			NumeroSeguimiento = NumeroSeguimientoCON;
			Comentario = ComentarioCON;
			Accion = AccionCON;
				}
		public void ProcesarInformacion() {
			DSMarket.Logica.Entidades.EntidadesInventario.EProductosDefectuosos Procesar = new Entidades.EntidadesInventario.EProductosDefectuosos();

			Procesar.IdProductoDefectuoso = IdProductoDefectuoso;
			Procesar.NumeroConector = NumeroConector;
			Procesar.IdTipoProducto = IdTipoProducto;
			Procesar.IdCategoria = IdCategoria;
			Procesar.IdUnidadMedida = IdUnidadMedida;
			Procesar.IdMarca = IdMarca;
			Procesar.IdModelo = IdModelo;
			Procesar.IdTipoSuplidor = IdTipoSuplidor;
			Procesar.IdSuplidor = IdSuplidor;
			Procesar.Producto = Producto;
			Procesar.CodigoBarra = CodigoBarra;
			Procesar.Referencia = Referencia;
			Procesar.PrecioCompra = PrecioCompra;
			Procesar.PrecioVenta = PrecioVenta;
			Procesar.Stock = Stock;
			Procesar.StockMinimo = StockMinimo;
			Procesar.PorcientoDescuento = PorcientoDescuento;
			Procesar.AfectaOferta0 = AfectaOferta0;
			Procesar.ProductoAcumulativo0 = ProductoAcumulativo0;
			Procesar.LlevaImagen0 = LlevaImagen0;
			Procesar.UsuarioAdiciona = UsuarioAdiciona;
			Procesar.FechaAdiciona = FechaAdiciona;
			Procesar.UsuarioModifica = UsuarioModifica;
			Procesar.FechaModifica = FechaModifica;
			Procesar.Fecha = Fecha;
			Procesar.Comentario = Comentario;
			Procesar.AplicaParaImpuesto0 = AplicaParaImpuesto0;
			Procesar.EstatusProducto0 = EstatusProducto0;
			Procesar.CantidadAgregada = CantidadAgregada;
			Procesar.NumeroSeguimiento = NumeroSeguimiento;
			Procesar.IdColor = IdColor;
			Procesar.IdCondicion = IdCondicion;
			Procesar.IdCapacidad = IdCapacidad;

			var MAN = ObjData.MantenimientoProductosDefectuoso(Procesar, Accion);
		}
	}
}
