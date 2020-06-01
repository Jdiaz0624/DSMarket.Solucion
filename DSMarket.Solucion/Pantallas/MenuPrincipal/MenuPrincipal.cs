using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSMarket.Solucion.Pantallas.MenuPrincipal
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }
        DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region FUNCION PARA LLAMAR LOS FORMULARIOS
        private void AbrirPantallasEnPanel(object Pantalla)
        {
            if (PanelCuerpo.Controls.Count > 0)
                this.PanelCuerpo.Controls.RemoveAt(0);
            Form Formulario = Pantalla as Form;
            Formulario.TopLevel = false;
            Formulario.Dock = DockStyle.Fill;
            this.PanelCuerpo.Controls.Add(Formulario);
            this.PanelCuerpo.Tag = Formulario;
           // VariablesGlobales.NombreSistema = lbUsuarioConectado.Text;

            Formulario.Show();
        }
        #endregion
        private void PCerrar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Quieres salir del sistema?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void PMinimizar_Click(object sender, EventArgs e)
        {
            try {
                this.WindowState = FormWindowState.Minimized;
            }
            catch (Exception) { }
        }

        private void PMaximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            PMaximizar.Visible = false;
            PRestaurar.Visible = true;

        }

        private void PRestaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            PMaximizar.Visible = true;
            PRestaurar.Visible = false;
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            btnServicio.Visible = false;
            btnInventario.Visible = false;
            btnCaja.Visible = false;
            btnClientes.Visible = false;
            btnNomina.Visible = false;
            btnSuplidores.Visible = false;
            btnConfiguracion.Visible = false;
            btnSeguridad.Visible = false;
            btnCerrarSesion.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (PanelOpciones.Width == 270)
            {
                PanelOpciones.Visible = false;
                PanelOpciones.Width = 68;
                PanelMenu.Width = 90;
                Separador.Width = 52;
                pbLogolargo.Visible = false;
                lbLogoCorto.Visible = true;
                EfectoIda.Show(PanelOpciones);
            }
            else
            {
                PanelOpciones.Visible = false;
                PanelOpciones.Width = 270;
                PanelMenu.Width = 300;
                Separador.Width = 252;
                pbLogolargo.Visible = true;
                lbLogoCorto.Visible = false;
                EfectoIda.Show(PanelOpciones);
            }
        }

        private void btnServicio_Click(object sender, EventArgs e)
        {
            AbrirPantallasEnPanel(new DSMarket.Solucion.Pantallas.SubMenus.Servicio());
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
           // IdUsuario = Convert.ToDecimal(lbiDUSUARIO.Text);
            AbrirPantallasEnPanel(new DSMarket.Solucion.Pantallas.SubMenus.Inventario());
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {
            AbrirPantallasEnPanel(new DSMarket.Solucion.Pantallas.SubMenus.Caja());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {

        }

        private void btnNomina_Click(object sender, EventArgs e)
        {

        }

        private void btnSuplidores_Click(object sender, EventArgs e)
        {

        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {

        }

        private void btnSeguridad_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Quieres cerrar sesión?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                Application.Restart();
            }
        }
    }
}
