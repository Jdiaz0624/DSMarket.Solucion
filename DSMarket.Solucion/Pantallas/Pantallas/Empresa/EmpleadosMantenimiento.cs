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
    public partial class EmpleadosMantenimiento : Form
    {
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();
        public EmpleadosMantenimiento()
        {
            InitializeComponent();
        }

        private void EmpleadosMantenimiento_Load(object sender, EventArgs e)
        {

        }

        private void TxtComisionServicios_KeyPress(object sender, KeyPressEventArgs e)
        {
            DSMarket.Logica.Comunes.ValidarControles.SoloNumerosDecimales(e);
        }
    }
}
