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
    public partial class ModelosConsulta : Form
    {
        public ModelosConsulta()
        {
            InitializeComponent();
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ModelosConsulta_Load(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
            dtListado.BackgroundColor = SystemColors.Control;
            ddlSeleccionarMarcas.BackColor = Color.WhiteSmoke;
            txtModelos.BackColor = Color.WhiteSmoke;
            txtNumeroPagina.BackColor = Color.WhiteSmoke;
            txtNumeroRegistros.BackColor = Color.WhiteSmoke;
            lbTitulo.Text = "CONSULTA DE MODELOS";
            lbTitulo.ForeColor = Color.WhiteSmoke;
            lbCantidadRegistrosTitulo.ForeColor = Color.WhiteSmoke;
            lbCantidadRegistrosVariable.ForeColor = Color.WhiteSmoke;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.MantenimientoModelos Mantenimietnto = new MantenimientoModelos();
            Mantenimietnto.VariablesGlobales.Accion = "INSERT";
            Mantenimietnto.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.MantenimientoModelos Mantenimietnto = new MantenimientoModelos();
            Mantenimietnto.VariablesGlobales.Accion = "UPDATE";
            Mantenimietnto.ShowDialog();
        }

        private void ModelosConsulta_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }
    }
}
