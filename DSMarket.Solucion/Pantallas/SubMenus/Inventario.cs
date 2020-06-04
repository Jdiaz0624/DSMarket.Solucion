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
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.ProductoConsulta Producto = new Pantallas.Inventario.ProductoConsulta();
            Producto.ShowDialog();
        }
    }
}
