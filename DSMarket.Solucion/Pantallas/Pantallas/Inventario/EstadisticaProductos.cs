using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSMarket.Solucion.Pantallas.Pantallas.Inventario
{
    public partial class EstadisticaProductos : Form
    {
        public EstadisticaProductos()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaInventario.LogicaInventario> ObjDataInventario = new Lazy<Logica.Logica.LogicaInventario.LogicaInventario>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region ENUMERACIONES
        enum AccionRealizar {
            ArticulosConOfertas = 1,
            ProductosProximoAgotarse=2,
            ProductosAgotados=3
        }
        #endregion
        private void Listado() {
            if (VariablesGlobales.EstadisticaProducto == Convert.ToInt32(AccionRealizar.ArticulosConOfertas))
            {
                //LISTADO DE PRODUCTOS CON OFERTAS
            }
            else if (VariablesGlobales.EstadisticaProducto == Convert.ToInt32(AccionRealizar.ProductosProximoAgotarse))
            {
                //LISTADO DE PRODUCTOS AGOTARSE
                var MostrarProductosProximoAgotarse = ObjDataInventario.Value.ProductosProximoAgotarse(
                    new Nullable<decimal>(),
                    null,
                    null,
                    null,
                    null,
                    null,
                    null,
                    null,
                    null,
                    null,
                    null,
                    null,
                    null,
                    Convert.ToInt32(txtNumeroPagina.Value),
                    Convert.ToInt32(txtNumeroRegistros.Value));
                dtListado.DataSource = MostrarProductosProximoAgotarse;
                foreach (var n in MostrarProductosProximoAgotarse)
                {
                    int Cantidad = Convert.ToInt32(n.CantidadRegistros);
                    lbCantidadPoductosAgotarse.Text = Cantidad.ToString("N0");
                }
                OcultarColumnas();
            }
            else if (VariablesGlobales.EstadisticaProducto == Convert.ToInt32(AccionRealizar.ProductosAgotados))
            {
                //LISTADO DE PRODUCTOS AGOTADOS
                var MostrarProductosAgotados = ObjDataInventario.Value.ProductosAgotados(
                  new Nullable<decimal>(),
                  null,
                  null,
                  null,
                  null,
                  null,
                  null,
                  null,
                  null,
                  null,
                  null,
                  null,
                  null,
                  Convert.ToInt32(txtNumeroPagina.Value),
                  Convert.ToInt32(txtNumeroRegistros.Value));
                dtListado.DataSource = MostrarProductosAgotados;
                foreach (var n in MostrarProductosAgotados)
                {
                    int Cantidad = Convert.ToInt32(n.CantidadRegistros);
                    lbCantidadPoductosAgotarse.Text = Cantidad.ToString("N0");
                }
                OcultarColumnas();
            }
        }
        private void OcultarColumnas()
        {
            this.dtListado.Columns["IdProducto"].Visible = false;
            this.dtListado.Columns["NumeroConector"].Visible = false;
            this.dtListado.Columns["IdTipoProducto"].Visible = false;
            this.dtListado.Columns["IdCategoria"].Visible = false;
            this.dtListado.Columns["IdUnidadMedida"].Visible = false;
            this.dtListado.Columns["IdMarca"].Visible = false;
            this.dtListado.Columns["IdModelo"].Visible = false;
            this.dtListado.Columns["IdTipoSuplidor"].Visible = false;
            this.dtListado.Columns["IdSuplidor"].Visible = false;
            this.dtListado.Columns["PrecioCompra"].Visible = false;
            this.dtListado.Columns["AfectaOferta0"].Visible = false;
            this.dtListado.Columns["ProductoAcumulativo0"].Visible = false;
            this.dtListado.Columns["LlevaImagen0"].Visible = false;
            this.dtListado.Columns["UsuarioAdicion"].Visible = false;
            this.dtListado.Columns["FechaAdiciona"].Visible = false;
            this.dtListado.Columns["UsuarioModifica"].Visible = false;
            this.dtListado.Columns["ModificadoPor"].Visible = false;
            this.dtListado.Columns["FechaModifica"].Visible = false;
            this.dtListado.Columns["FechaModificado"].Visible = false;
            this.dtListado.Columns["Fecha"].Visible = false;
            this.dtListado.Columns["CantidadRegistros"].Visible = false;
            //this.dtListado.Columns["ProductosConOferta"].Visible = false;
            //this.dtListado.Columns["ProductoProximoAgotarse"].Visible = false;
            //this.dtListado.Columns["ProductosAgostados"].Visible = false;
        }
        private void EstadisticaProductos_Load(object sender, EventArgs e)
        {
            Listado();
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.ProductoConsulta Consulta = new ProductoConsulta();
            Consulta.variablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Consulta.ShowDialog();
        }

        private void txtNumeroPagina_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroPagina.Value < 1)
            {
                txtNumeroPagina.Value = 1;
                Listado();
            }
            else {
                Listado();
            }
        }

        private void txtNumeroRegistros_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroRegistros.Value < 1)
            {
                txtNumeroRegistros.Value = 10;
                Listado();
            }
            else {
                Listado();
            }
        }
    }
}
