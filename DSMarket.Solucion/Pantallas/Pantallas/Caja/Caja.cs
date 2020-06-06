using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSMarket.Solucion.Pantallas.Pantallas.Caja
{
    public partial class Caja : Form
    {
        public Caja()
        {
            InitializeComponent();
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Caja_Load(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
            txtCodigoCaja.BackColor = Color.WhiteSmoke;
            txtConcepto.BackColor = Color.WhiteSmoke;
            txtMonto.BackColor = Color.WhiteSmoke;
            rbIngresar.ForeColor = Color.LimeGreen;
            rbSacar.ForeColor = Color.DarkRed;
            rbIngresar.Checked = true;
            lbTitulo.Text = "CAJA";
            lbTitulo.ForeColor = Color.WhiteSmoke;
        }
    }
}
