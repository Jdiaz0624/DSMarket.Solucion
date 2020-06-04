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
    public partial class AgregarQuitarProductos : Form
    {
        public AgregarQuitarProductos()
        {
            InitializeComponent();
        }
        #region APLICAR TEMA
        private void APlicarTema()
        {
            this.BackColor = SystemColors.Control;

            txtCantidad.BackColor = Color.WhiteSmoke;
            txtCantidad.ForeColor = Color.Black;
            txtClaveSeguridad.BackColor = Color.WhiteSmoke;
            txtClaveSeguridad.ForeColor = Color.Black;


        }
        #endregion
        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.ProductoConsulta Consulta = new ProductoConsulta();
            Consulta.ShowDialog();
        }

        private void AgregarQuitarProductos_Load(object sender, EventArgs e)
        {
            rbIngresarProducto.Checked = true;
            rbIngresarProducto.ForeColor = Color.LimeGreen;
            rbSacarProducto.ForeColor = Color.DarkRed;
            APlicarTema();
        }

        private void rbIngresarProducto_CheckedChanged(object sender, EventArgs e)
        {
            if (rbIngresarProducto.Checked == true)
            {
                rbIngresarProducto.ForeColor = Color.LimeGreen;
                rbSacarProducto.ForeColor = Color.DarkRed;
            }
            else
            {
                rbIngresarProducto.ForeColor = Color.DarkRed;
                rbSacarProducto.ForeColor = Color.DarkRed;
            }
        }

        private void rbSacarProducto_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSacarProducto.Checked == true)
            {
                rbIngresarProducto.ForeColor = Color.DarkRed;
                rbSacarProducto.ForeColor = Color.LimeGreen;
            }
            else
            {
                rbIngresarProducto.ForeColor = Color.DarkRed;
                rbSacarProducto.ForeColor = Color.DarkRed;
            }
        }
    }
}
