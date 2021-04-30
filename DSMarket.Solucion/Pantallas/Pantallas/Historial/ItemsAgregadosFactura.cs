using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSMarket.Solucion.Pantallas.Pantallas.Historial
{
    public partial class ItemsAgregadosFactura : Form
    {
        public ItemsAgregadosFactura()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaHistorial.LogicaHistorial> ObjdataHistorial = new Lazy<Logica.Logica.LogicaHistorial.LogicaHistorial>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        private void ListadoItemsAgregados() {
            int TotalProductos = 0, TotalServicios = 0, TotalItems = 0;
            var Buscaritems = ObjdataHistorial.Value.ItemsAgregadosFactura(
                VariablesGlobales.IdMantenimeinto,
                VariablesGlobales.NumeroConectorstring);
            foreach (var n in Buscaritems) {
                lbNumeroFacturavariable.Text = n.NumeroFactura.ToString();
                lbFacturadoAvariable.Text = n.FacturadoA;
                lbfechaFacturacionvariable.Text = n.FechaFacturacion;
                TotalProductos = (int)n.TotalProductos;
                lbCantidadProductosvariable.Text = TotalProductos.ToString("N0");
                TotalServicios = (int)n.TotalServicios;
                lbCantidadServiciosVariable.Text = TotalServicios.ToString("N0");
                TotalItems = (int)n.TotalItems;
                lbNumeroItemsvariable.Text = TotalItems.ToString("N0");
                lbfacturaAnuladavariable.Text = n.Anulada;
            }
            dtListado.DataSource = Buscaritems;
            OcultarColumnas();
        }
        private void OcultarColumnas() {
            this.dtListado.Columns["NumeroFactura"].Visible = false;
            this.dtListado.Columns["NumeroConector"].Visible = false;
            this.dtListado.Columns["FacturadoA"].Visible = false;
            this.dtListado.Columns["FechaFacturacion"].Visible = false;
            this.dtListado.Columns["TotalProductos"].Visible = false;
            this.dtListado.Columns["TotalServicios"].Visible = false;
            this.dtListado.Columns["TotalItems"].Visible = false;
            this.dtListado.Columns["Coenectordetalle"].Visible = false;
            this.dtListado.Columns["Tipo"].Visible = false;
            this.dtListado.Columns["Precio"].Visible = false;
            this.dtListado.Columns["Descuento"].Visible = false;
            this.dtListado.Columns["Cantidad"].Visible = false;
            this.dtListado.Columns["PorcientoImpuesto"].Visible = false;
            this.dtListado.Columns["SubTotal"].Visible = false;
            this.dtListado.Columns["Impuesto"].Visible = false;
            this.dtListado.Columns["Total"].Visible = false;
            this.dtListado.Columns["IdRegistroRespaldo"].Visible = false;
            this.dtListado.Columns["NumeroConectorItemRespaldo"].Visible = false;
            this.dtListado.Columns["IdTipoProductoRespaldo"].Visible = false;
            this.dtListado.Columns["IdCategoriaRespaldo"].Visible = false;
            this.dtListado.Columns["IdMarcaRespaldo"].Visible = false;
            this.dtListado.Columns["IdTipoSuplidorRespaldo"].Visible = false;
            this.dtListado.Columns["IdSuplidorRespaldo"].Visible = false;
            this.dtListado.Columns["Descripcion"].Visible = false;
            this.dtListado.Columns["CodigoBarraRespaldo"].Visible = false;
            this.dtListado.Columns["ReferenciaRespaldo"].Visible = false;
            this.dtListado.Columns["NumeroSeguimientoRespaldo"].Visible = false;
            this.dtListado.Columns["CodigoProductoRespaldo"].Visible = false;
            this.dtListado.Columns["PrecioCompraRespaldo"].Visible = false;
            this.dtListado.Columns["PrecioVentaRespaldo"].Visible = false;
            this.dtListado.Columns["StockRespaldo"].Visible = false;
            this.dtListado.Columns["StockMinimoRespaldo"].Visible = false;
            this.dtListado.Columns["UnidadMedidaRespaldo"].Visible = false;
            this.dtListado.Columns["ModeloRespaldo"].Visible = false;
            this.dtListado.Columns["ColorRespaldo"].Visible = false;
            this.dtListado.Columns["CondicionRespaldo"].Visible = false;
            this.dtListado.Columns["CapacidadRespaldo"].Visible = false;
            this.dtListado.Columns["AplicaParaImpuestoRespaldo"].Visible = false;
            this.dtListado.Columns["TieneImagenRespaldo"].Visible = false;
            this.dtListado.Columns["LlevaGarantiaRespaldo"].Visible = false;
            this.dtListado.Columns["IdTipoGarantiaRespaldo"].Visible = false;
            this.dtListado.Columns["TiempoGarantiaRespaldo"].Visible = false;
            this.dtListado.Columns["ComentarioItemRespaldo"].Visible = false;
            this.dtListado.Columns["UsuarioAdicionaRespaldo"].Visible = false;
            this.dtListado.Columns["FechaAdicionaRespaldo"].Visible = false;
            this.dtListado.Columns["UsuarioModificaRespaldo"].Visible = false;
            this.dtListado.Columns["FechaModificaRespaldo"].Visible = false;
            this.dtListado.Columns["FechaIngresoRespaldo"].Visible = false;

        }
        private void CerrarPantalla() {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Historial.HistorialFacturacion Historial = new HistorialFacturacion();
            Historial.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Historial.ShowDialog();
        }

        private void ItemsAgregadosFactura_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason) {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void ItemsAgregadosFactura_Load(object sender, EventArgs e)
        {
            lbTitulo.Text = "ITEMS AGREGADO EN FACTURA";
            lbTitulo.ForeColor = Color.White;
            ListadoItemsAgregados();
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            CerrarPantalla();
        }
    }
}
