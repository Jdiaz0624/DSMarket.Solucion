using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSMarket.Solucion.Pantallas.Pantallas.Configuracion
{
    public partial class CredencialesBD : Form
    {
        public CredencialesBD()
        {
            InitializeComponent();
        }
      
        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Configuracion.Reportes Reportes = new Reportes();
            Reportes.ShowDialog();
        }

        private void CredencialesBD_Load(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
            txtClave.BackColor = Color.WhiteSmoke;
            txtclaveSeguridad.BackColor = Color.WhiteSmoke;
            txtUsuario.BackColor = Color.WhiteSmoke;
            txtclaveSeguridad.PasswordChar = '•';
            lbTitulo.Text = "CREDENCIALES DE BASE DE DATOS";
            lbTitulo.ForeColor = Color.WhiteSmoke;
        }
    }
}
