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
    public partial class MantenimientoSupidores : Form
    {
        public MantenimientoSupidores()
        {
            InitializeComponent();
        }
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.SuplidoresConsulta consulta = new SuplidoresConsulta();
            consulta.ShowDialog();
        }

        private void MantenimientoSupidores_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void MantenimientoSupidores_Load(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
            txtClaveSeguridad.BackColor = Color.WhiteSmoke;
            txtContacto.BackColor = Color.WhiteSmoke;
            txtDireccion.BackColor = Color.WhiteSmoke;
            txtEmail.BackColor = Color.WhiteSmoke;
            txtSuplidor.BackColor = Color.WhiteSmoke;
            txtTelefono.BackColor = Color.WhiteSmoke;
            cbEstatus.Checked = false;
            cbEstatus.ForeColor = Color.DarkRed;

            if (VariablesGlobales.Accion == "INSERT")
            {
                lbTitulo.Text = "CREAR NUEVO REGISTRO";
                lbTitulo.ForeColor = Color.WhiteSmoke;
                btnGuardar.Text = "Guardar registro";
                lbclaveSeguridad.Visible = false;
                txtClaveSeguridad.Visible = false;

            }
            else if (VariablesGlobales.Accion == "UPDATE")
            {
                lbTitulo.Text = "MODIFICAR REGISTRO SELECCIONADO";
                lbTitulo.ForeColor = Color.WhiteSmoke;
                btnGuardar.Text = "Modificar registro";
                lbclaveSeguridad.Visible = false;
                txtClaveSeguridad.Visible = false;
            }
        }

        private void cbEstatus_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEstatus.Checked == true)
            {
                cbEstatus.ForeColor = Color.LimeGreen;
            }
            else
            {
                cbEstatus.ForeColor = Color.DarkRed;
            }
        }
    }
}
