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
    public partial class NominaConsulta : Form
    {
        public NominaConsulta()
        {
            InitializeComponent();
        }

        private void NominaConsulta_Load(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
            dtListado.BackgroundColor = SystemColors.Control;
            txtCargo.BackColor = Color.WhiteSmoke;
            txtnombre.BackColor = Color.WhiteSmoke;
            txtNumeroIdentificacion.BackColor = Color.WhiteSmoke;
            txtNumeroPagina.BackColor = Color.WhiteSmoke;
            txtNumeroRegistros.BackColor = Color.WhiteSmoke;
            ddlSeleccionarDepartamento.BackColor = Color.WhiteSmoke;
            ddlSeleccionarTipoIdentificacion.BackColor = Color.WhiteSmoke;

            txtCargo.ForeColor = Color.Black;
            txtnombre.ForeColor = Color.Black;
            txtNumeroIdentificacion.ForeColor = Color.Black;
            txtNumeroPagina.ForeColor = Color.Black;
            txtNumeroRegistros.ForeColor = Color.Black;

            lbTitulo.ForeColor = Color.WhiteSmoke;
            lbTitulo.Text = "CONSULTA DE EMPLEADOS";
            lbCantidadRegistrosVariable.ForeColor = Color.WhiteSmoke;
            lbCantidadRegistrosTitulo.ForeColor = Color.WhiteSmoke;

            rbActivos.Checked = true;
            rbActivos.ForeColor = Color.LimeGreen;
            rbCancelados.ForeColor = Color.DarkRed;
            rbAmbos.ForeColor = Color.DarkRed;
            cbAgregarDepartamentos.Checked = false;
            cbAgregarDepartamentos.ForeColor = Color.DarkRed;
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private void NominaConsulta_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void rbActivos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbActivos.Checked == true)
            {
                rbActivos.ForeColor = Color.LimeGreen;
                rbCancelados.ForeColor = Color.DarkRed;
                rbAmbos.ForeColor = Color.DarkRed;
            }
            else
            {
                rbActivos.ForeColor = Color.DarkRed;
                rbCancelados.ForeColor = Color.DarkRed;
                rbAmbos.ForeColor = Color.DarkRed;
            }
        }

        private void rbCancelados_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCancelados.Checked == true)
            {
                rbActivos.ForeColor = Color.DarkRed;
                rbCancelados.ForeColor = Color.LimeGreen;
                rbAmbos.ForeColor = Color.DarkRed;
            }
            else
            {
                rbActivos.ForeColor = Color.DarkRed;
                rbCancelados.ForeColor = Color.DarkRed;
                rbAmbos.ForeColor = Color.DarkRed;
            }
        }

        private void rbAmbos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAmbos.Checked == true)
            {
                rbActivos.ForeColor = Color.DarkRed;
                rbCancelados.ForeColor = Color.DarkRed;
                rbAmbos.ForeColor = Color.LimeGreen;
            }
            else
            {
                rbActivos.ForeColor = Color.DarkRed;
                rbCancelados.ForeColor = Color.DarkRed;
                rbAmbos.ForeColor = Color.DarkRed;
            }
        }

        private void cbAgregarDepartamentos_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAgregarDepartamentos.Checked == true)
            {
                cbAgregarDepartamentos.ForeColor = Color.LimeGreen;
            }
            else
            {
                cbAgregarDepartamentos.ForeColor = Color.DarkRed;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.NominaMantenimiento Mantenimiento = new NominaMantenimiento();
            Mantenimiento.VariablesGlobales.Accion = "INSERT";
            Mantenimiento.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.NominaMantenimiento Mantenimiento = new NominaMantenimiento();
            Mantenimiento.VariablesGlobales.Accion = "UPDATE";
            Mantenimiento.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.NominaMantenimiento Mantenimiento = new NominaMantenimiento();
            Mantenimiento.VariablesGlobales.Accion = "CANCEL";
            Mantenimiento.ShowDialog();
        }

        private void dtListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
