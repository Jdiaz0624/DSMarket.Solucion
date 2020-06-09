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
    public partial class CargosConsulta : Form
    {
        public CargosConsulta()
        {
            InitializeComponent();
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void CargosConsulta_Load(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
            dtListado.BackgroundColor = SystemColors.Control;
            ddlSeleccionarDepartamento.BackColor = Color.WhiteSmoke;
            txtCargo.BackColor = Color.WhiteSmoke;
            txtNumeroPagina.BackColor = Color.WhiteSmoke;
            txtNumeroRegistros.BackColor = Color.WhiteSmoke;

            ddlSeleccionarDepartamento.ForeColor = Color.Black;
            txtCargo.ForeColor = Color.Black;
            txtNumeroPagina.ForeColor = Color.Black;
            txtNumeroRegistros.ForeColor = Color.Black;


        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.CargosMantenimiento mantenimiento = new CargosMantenimiento();
            mantenimiento.VariablesGlobales.Accion = "INSERT";
            mantenimiento.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.CargosMantenimiento mantenimiento = new CargosMantenimiento();
            mantenimiento.VariablesGlobales.Accion = "UPDATE";
            mantenimiento.ShowDialog();
        }

        private void CargosConsulta_FormClosing(object sender, FormClosingEventArgs e)
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
