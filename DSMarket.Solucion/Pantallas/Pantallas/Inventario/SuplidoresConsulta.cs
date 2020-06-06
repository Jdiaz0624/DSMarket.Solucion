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
    public partial class SuplidoresConsulta : Form
    {
        public SuplidoresConsulta()
        {
            InitializeComponent();
        }

        private void lbNumeroPagina_Click(object sender, EventArgs e)
        {

        }

        private void txtNumeroPagina_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lbNumeroRegistros_Click(object sender, EventArgs e)
        {

        }

        private void txtNumeroRegistros_ValueChanged(object sender, EventArgs e)
        {

        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void SuplidoresConsulta_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void SuplidoresConsulta_Load(object sender, EventArgs e)
        {
            lbTitulo.Text = "CONSULTA DE SUPLIDORES";
            lbTitulo.ForeColor = Color.WhiteSmoke;
            lbCantidadRegistrosVariable.ForeColor = Color.WhiteSmoke;
            lbCantidadRegistrosTitulo.ForeColor = Color.WhiteSmoke;
            dtListado.BackgroundColor = SystemColors.Control;
            this.BackColor = SystemColors.Control;
            txtSuplidor.BackColor = Color.WhiteSmoke;
            txtNumeroRegistros.BackColor = Color.WhiteSmoke;
            txtNumeroPagina.BackColor = Color.WhiteSmoke;
            ddlSeleccionarTipoSuplidor.BackColor = Color.WhiteSmoke;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.MantenimientoSupidores Mantenimiento = new MantenimientoSupidores();
            Mantenimiento.VariablesGlobales.Accion = "INSERT";
            Mantenimiento.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.MantenimientoSupidores Mantenimiento = new MantenimientoSupidores();
            Mantenimiento.VariablesGlobales.Accion = "UPDATE";
            Mantenimiento.ShowDialog();
        }
    }
}
