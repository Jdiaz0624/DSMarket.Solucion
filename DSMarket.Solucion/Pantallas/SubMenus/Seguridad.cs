using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSMarket.Solucion.Pantallas.SubMenus
{
    public partial class Seguridad : Form
    {
        public Seguridad()
        {
            InitializeComponent();
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            DSMarket.Solucion.Pantallas.Pantallas.Seguridad.UsuariosConsulta ConsultaUsuarios = new Pantallas.Seguridad.UsuariosConsulta();
            ConsultaUsuarios.ShowDialog();
        }

        private void btnClaveSeguridad_Click(object sender, EventArgs e)
        {
            DSMarket.Solucion.Pantallas.Pantallas.Seguridad.ClaveSeguridad ClaveSeguridad = new Pantallas.Seguridad.ClaveSeguridad();
            ClaveSeguridad.ShowDialog();
        }
    }
}
