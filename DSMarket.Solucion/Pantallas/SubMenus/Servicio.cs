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
    public partial class Servicio : Form
    {
        public Servicio()
        {
            InitializeComponent();
        }

        private void Servicio_Load(object sender, EventArgs e)
        {
            lbTitulo.Text = "MENU - SERVICIO";
            lbTitulo.ForeColor = Color.White;
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            DSMarket.Solucion.Pantallas.Pantallas.Servicio.Facturacion FActuracion = new Pantallas.Servicio.Facturacion();
            FActuracion.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DSMarket.Solucion.Pantallas.Pantallas.Servicio.TipoPago MantenimientoTipoPago = new Pantallas.Servicio.TipoPago();
            MantenimientoTipoPago.ShowDialog();
        }

        private void btnCotizacion_Click(object sender, EventArgs e)
        {
            DSMarket.Solucion.Pantallas.Pantallas.Servicio.HistorialFActuracion Historial = new Pantallas.Servicio.HistorialFActuracion();
            Historial.ShowDialog();
        }
    }
}
