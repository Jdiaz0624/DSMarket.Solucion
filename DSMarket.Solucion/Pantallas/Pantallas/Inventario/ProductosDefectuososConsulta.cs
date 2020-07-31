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
    public partial class ProductosDefectuososConsulta : Form
    {
        public ProductosDefectuososConsulta()
        {
            InitializeComponent();
        }
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();
        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void ProductosDefectuososConsulta_Load(object sender, EventArgs e)
        {

        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.ProductoConsulta consulta = new ProductoConsulta();
            consulta.variablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            consulta.ShowDialog();
        }
    }
}
