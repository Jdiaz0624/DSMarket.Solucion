using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSMarket.Solucion.Pantallas.Pantallas.Empresa
{
    public partial class MantenimientoCompraSuplidores : Form
    {
        public MantenimientoCompraSuplidores()
        {
            InitializeComponent();
        }

        private void MantenimientoCompraSuplidores_Load(object sender, EventArgs e)
        {
            lbTitulo.Text = "REGISTRO DE COMPRA A SUPLIDORES";
            lbTitulo.ForeColor = Color.White;
        }
    }
}
