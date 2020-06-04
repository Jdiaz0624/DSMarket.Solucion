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
    public partial class AgregarOferta : Form
    {
        public AgregarOferta()
        {
            InitializeComponent();
        }

        #region APLICAR TEMA
        private void APlicarTema()
        {
            this.BackColor = SystemColors.Control;

            txtPorcientoOferta.BackColor = Color.WhiteSmoke;
            txtPorcientoOferta.ForeColor = Color.Black;
            txtClaveSeguridad.BackColor = Color.WhiteSmoke;
            txtClaveSeguridad.ForeColor = Color.Black;

        }
        #endregion
        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.ProductoConsulta Volver = new ProductoConsulta();
            Volver.ShowDialog();
        }

        private void AgregarOferta_Load(object sender, EventArgs e)
        {
            lbTitulo.Text = "AGREGAR OFERTA";
            lbTitulo.ForeColor = Color.WhiteSmoke;
            APlicarTema();
        }
    }
}
