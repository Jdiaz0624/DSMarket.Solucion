using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSMarket.Solucion.Pantallas.Pantallas.Seguridad
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtclave.PasswordChar = '•';
            gbLogin.Visible = false;
            Efecto.Show(gbLogin);
            lbNombreEmpresa.Visible = false;
            EfectosBotones.Show(lbNombreEmpresa);
            btnMiniminzar.Visible = false;
            EfectosBotones.Show(btnMiniminzar);
            PCerrar.Visible = false;
            EfectosBotones.Show(PCerrar);
        }

        private void btnServicio_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.MenuPrincipal.MenuPrincipal MenuPrincipal = new MenuPrincipal.MenuPrincipal();
            MenuPrincipal.ShowDialog();
        }
    }
}
