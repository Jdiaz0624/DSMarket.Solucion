using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSMarket.Solucion.Pantallas.SubMenus
{
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }


        private void Inventario_Load(object sender, EventArgs e)
        {
            lbTitulo.Text = "MANTENIMIENTO DE INVENTARIO";
            lbIdUsuario.Text = DSMarket.Solucion.Pantallas.MenuPrincipal.MenuPrincipal.IdUsuarioMantenimientos.ToString();
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.ProductoConsulta Producto = new Pantallas.Inventario.ProductoConsulta();
            Producto.variablesGlobales.IdUsuario = Convert.ToDecimal(lbIdUsuario.Text);
            Producto.ShowDialog();
        }

        private void btnTipoProducto_Click(object sender, EventArgs e)
        {
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.TipoProductoConsulta TipoProducto = new Pantallas.Inventario.TipoProductoConsulta();
            TipoProducto.VariablesGlobales.IdUsuario = Convert.ToDecimal(lbIdUsuario.Text);
            TipoProducto.ShowDialog();
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.CategoriaConsulta MantenimientoCategoria = new Pantallas.Inventario.CategoriaConsulta();
            MantenimientoCategoria.VariablesGlobales.IdUsuario = Convert.ToDecimal(lbIdUsuario.Text);
            MantenimientoCategoria.ShowDialog();
        }

        private void btnTipoSuplidores_Click(object sender, EventArgs e)
        {
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.TipoSuplidoresConsulta MantenimientoTipoSuplidor = new Pantallas.Inventario.TipoSuplidoresConsulta();
            MantenimientoTipoSuplidor.VariablesGlobales.IdUsuario = Convert.ToDecimal(lbIdUsuario.Text);
            MantenimientoTipoSuplidor.ShowDialog();
        }

        private void btnUnidaMedida_Click(object sender, EventArgs e)
        {
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.UnidadMedidaConsulta MantenimientoUnidadMedida = new Pantallas.Inventario.UnidadMedidaConsulta();
            MantenimientoUnidadMedida.variablesGlobales.IdUsuario = Convert.ToDecimal(lbIdUsuario.Text);
            MantenimientoUnidadMedida.ShowDialog();
        }

        private void btnMArcas_Click(object sender, EventArgs e)
        {
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.MarcasConsulta MantenimientoMArcas = new Pantallas.Inventario.MarcasConsulta();
            MantenimientoMArcas.variablesGlobales.IdUsuario = Convert.ToDecimal(lbIdUsuario.Text);
            MantenimientoMArcas.ShowDialog();
        }

        private void btnMonedas_Click(object sender, EventArgs e)
        {
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.ModelosConsulta MantenimientoModelos = new Pantallas.Inventario.ModelosConsulta();
            MantenimientoModelos.VariablesGlobales.IdUsuario = Convert.ToDecimal(lbIdUsuario.Text);
            MantenimientoModelos.ShowDialog();
        }

        private void btnSuplidores_Click(object sender, EventArgs e)
        {
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.SuplidoresConsulta MantenimeintoSuplidores = new Pantallas.Inventario.SuplidoresConsulta();
            MantenimeintoSuplidores.variablesGlobales.IdUsuario = Convert.ToDecimal(lbIdUsuario.Text);
            MantenimeintoSuplidores.ShowDialog();
        }

        private void gbOpciones_Enter(object sender, EventArgs e)
        {

        }
    }
}
