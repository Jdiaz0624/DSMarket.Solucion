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
    public partial class ItemsAgregadosCotizacion : Form
    {
        public ItemsAgregadosCotizacion()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaHistorial.LogicaHistorial> ObjdataHistorial = new Lazy<Logica.Logica.LogicaHistorial.LogicaHistorial>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        private void ListadoItemsagregados() {
            int TotalProductos = 0, TotalServicios = 0, TotalItems = 0;

            var ItemsAgregados = ObjdataHistorial.Value.ItemsAgregadosCotizacion(VariablesGlobales.IdMantenimeinto, VariablesGlobales.NumeroConectorstring);
            dtListado.DataSource = ItemsAgregados;
            foreach (var n in ItemsAgregados) {
                lbNumeroFacturavariable.Text = n.NumeroCotizacion.ToString();
                lbFacturadoAvariable.Text = n.CotizacoA;
                lbfechaFacturacionvariable.Text = n.FechaCotizacion;
                TotalProductos = (int)n.TotalProductos;
                TotalServicios = (int)n.TotalServicios;
                TotalItems = (int)n.TotalItems;
                lbCantidadProductosvariable.Text = TotalProductos.ToString("N0");
                lbCantidadServiciosVariable.Text = TotalServicios.ToString("N0");
                lbNumeroItemsvariable.Text = TotalItems.ToString("N0");

            }
            OcultarColumnas();
        }
        private void OcultarColumnas() {
            this.dtListado.Columns["NumeroCotizacion"].Visible = false;
            this.dtListado.Columns["NumeroConector"].Visible = false;
            this.dtListado.Columns["CotizacoA"].Visible = false;
            this.dtListado.Columns["FechaCotizacion"].Visible = false;
            this.dtListado.Columns["TotalProductos"].Visible = false;
            this.dtListado.Columns["TotalServicios"].Visible = false;
            this.dtListado.Columns["TotalItems"].Visible = false;
            this.dtListado.Columns["IdTipoProductoRespaldo"].Visible = false;
        
        }
   
        private void CerrarPantalla()
        {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Historial.HistorialCotizaciones Historial = new HistorialCotizaciones();
            Historial.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Historial.ShowDialog();
        }

        private void ItemsAgregadosCotizacion_Load(object sender, EventArgs e)
        {
            lbTitulo.Text = "ITEMS AGREGADOS EN LA COTIZACION";
            lbTitulo.ForeColor = Color.White;
            ListadoItemsagregados();
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            CerrarPantalla();
        }

        private void ItemsAgregadosCotizacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason) {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }
    }
}
