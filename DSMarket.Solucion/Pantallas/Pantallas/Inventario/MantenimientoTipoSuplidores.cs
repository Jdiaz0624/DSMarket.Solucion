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
    public partial class MantenimientoTipoSuplidores : Form
    {
        public MantenimientoTipoSuplidores()
        {
            InitializeComponent();
        }
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        private void MantenimientoTipoSuplidores_Load(object sender, EventArgs e)
        {
            lbTitulo.ForeColor = Color.WhiteSmoke;
            this.BackColor = SystemColors.Control;
            txtTiposuplidor.BackColor = Color.WhiteSmoke;
            txtClaveSeguridad.BackColor = Color.WhiteSmoke;
            txtClaveSeguridad.PasswordChar = '•';
            if (VariablesGlobales.Accion == "INSERT")
            {
                btnGuardar.Text = "Guardar registro";
                lbTitulo.Text = "CREAR NUEVO REGISTRO";
                lbclaveSeguridad.Visible = false;
                txtClaveSeguridad.Visible = false;
            }
            else if (VariablesGlobales.Accion == "UPDATE")
            {
                btnGuardar.Text = "Modificar registro";
                lbTitulo.Text = "MODIFICAR REGISTRO SELECCIONADO";
                lbclaveSeguridad.Visible = true;
                txtClaveSeguridad.Visible = true;
            }
        }

        private void MantenimientoTipoSuplidores_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }

        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.TipoSuplidoresConsulta Consulta = new TipoSuplidoresConsulta();
            Consulta.ShowDialog();
        }
    }
}
