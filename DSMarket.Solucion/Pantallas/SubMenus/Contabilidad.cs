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
    public partial class Contabilidad : Form
    {
        public Contabilidad()
        {
            InitializeComponent();
        }

        private void btnInformacionEmpresa_Click(object sender, EventArgs e)
        {
            DSMarket.Solucion.Pantallas.Pantallas.Contabilidad.CatalogoCuentasConsulta ConsultaCatalogos = new Pantallas.Contabilidad.CatalogoCuentasConsulta();
            ConsultaCatalogos.VariablesGlobales.IdUsuario = Convert.ToDecimal(lbusuario.Text);
            ConsultaCatalogos.ShowDialog();
        }

        private void Contabilidad_Load(object sender, EventArgs e)
        {
            lbusuario.Text = DSMarket.Solucion.Pantallas.MenuPrincipal.MenuPrincipal.IdUsuarioMantenimientos.ToString();
        }
    }
}
