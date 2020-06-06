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
    public partial class MantenimientoModelos : Form
    {
        public MantenimientoModelos()
        {
            InitializeComponent();
        }
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.ModelosConsulta Consulta = new ModelosConsulta();
            Consulta.ShowDialog();
        }

        private void MantenimientoModelos_Load(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
            txtClaveSeguridad.BackColor = Color.WhiteSmoke;
            txtModelo.BackColor = Color.WhiteSmoke;
            ddlSeleccionarMarcas.BackColor = Color.WhiteSmoke;
            txtClaveSeguridad.BackColor = Color.WhiteSmoke;
            if (VariablesGlobales.Accion == "INSERT")
            {
                lbTitulo.Text = "CREAR NUEVO REGISTRO";
                lbTitulo.ForeColor = Color.WhiteSmoke;
                lbclaveSeguridad.Visible = false;
                txtClaveSeguridad.Visible = false;
                btnGuardar.Text = "Guardar Registro";
                cbEstatus.Checked = false;
                cbEstatus.ForeColor = Color.DarkRed;
            }
            else if (VariablesGlobales.Accion == "UPDATE")
            {
                lbTitulo.Text = "MODIFICAR REGISTRO SELECCIONADO";
                lbTitulo.ForeColor = Color.WhiteSmoke;
                lbclaveSeguridad.Visible = false;
                txtClaveSeguridad.Visible = false;
                btnGuardar.Text = "Modificar Registro";
                cbEstatus.Checked = false;
                cbEstatus.ForeColor = Color.DarkRed;
            }
        }

        private void MantenimientoModelos_FormClosing(object sender, FormClosingEventArgs e)
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
