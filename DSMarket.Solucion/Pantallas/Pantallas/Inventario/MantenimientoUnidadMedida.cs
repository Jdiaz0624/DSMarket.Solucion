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
    public partial class MantenimientoUnidadMedida : Form
    {
        public MantenimientoUnidadMedida()
        {
            InitializeComponent();
        }
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();
        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.UnidadMedidaConsulta Consulta = new UnidadMedidaConsulta();
            Consulta.ShowDialog();
        }

        private void MantenimientoUnidadMedida_Load(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
            txtUnidadMedida.BackColor = Color.WhiteSmoke;
            txtClaveSeguridad.BackColor = Color.WhiteSmoke;
            lbTitulo.ForeColor = Color.WhiteSmoke;
            if (VariablesGlobales.Accion == "INSERT")
            {
                lbTitulo.Text = "CREAR NUEVO REGISTRO";
                btnGuardar.Text = "Guardar registro";
                txtClaveSeguridad.Visible = false;
                lbclaveSeguridad.Visible = false;
            }
            else if (VariablesGlobales.Accion == "UPDATE")
            {
                lbTitulo.Text = "MODIFICAR REGISTRO SELECCIONADO";
                btnGuardar.Text = "Modificar registro";
                txtClaveSeguridad.Visible = true;
                lbclaveSeguridad.Visible = true;
            }
        }

        private void MantenimientoUnidadMedida_FormClosing(object sender, FormClosingEventArgs e)
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
