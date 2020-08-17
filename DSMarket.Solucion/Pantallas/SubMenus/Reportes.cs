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
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            lbTitulo.Text = "MODULO DE REPORTES";
            lbTitulo.ForeColor = Color.White;
            lbIdUsuario.Text = DSMarket.Solucion.Pantallas.MenuPrincipal.MenuPrincipal.IdUsuarioMantenimientos.ToString();
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DSMarket.Solucion.Pantallas.Pantallas.Reportes.ReportesDGII DGII = new Pantallas.Reportes.ReportesDGII();
            DGII.VariablesGlobales.IdUsuario = Convert.ToDecimal(lbIdUsuario.Text);
            DGII.ShowDialog();
        }
    }
}
