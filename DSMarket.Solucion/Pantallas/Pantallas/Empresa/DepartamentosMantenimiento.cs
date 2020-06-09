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
    public partial class DepartamentosMantenimiento : Form
    {
        public DepartamentosMantenimiento()
        {
            InitializeComponent();
        }
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();
        private void DepartamentosMantenimiento_Load(object sender, EventArgs e)
        {
            lbTitulo.ForeColor = Color.WhiteSmoke;
            this.BackColor = SystemColors.Control;
            txtUnidadMedida.BackColor = Color.WhiteSmoke;
            txtClaveSeguridad.BackColor = Color.WhiteSmoke;

            if (VariablesGlobales.Accion == "INSERT")
            {
                lbTitulo.Text = "CREAR NUEVO REGISTRO";
                lbclaveSeguridad.Visible = false;
                txtClaveSeguridad.Visible = false;
                btnGuardar.Text = "Guardar registro";
            }
            else if (VariablesGlobales.Accion == "UPDATE")
            {
                lbTitulo.Text = "MODIFICAR REGISTRO SELECCIONADO";
                lbclaveSeguridad.Visible = true;
                txtClaveSeguridad.Visible = true;
                txtClaveSeguridad.PasswordChar = '•';
                btnGuardar.Text = "Modificar registro";
            }
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.DepartamentosConsulta Consulta = new DepartamentosConsulta();
            Consulta.ShowDialog();
        }

        private void DepartamentosMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
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
