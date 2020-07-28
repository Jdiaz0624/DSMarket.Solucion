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
    public partial class Configuracion : Form
    {
        public Configuracion()
        {
            InitializeComponent();
        }

        private void Configuracion_Load(object sender, EventArgs e)
        {
            lbTitulo.Text = "CONFIGURACION DEL SISTEMA";
            lbTitulo.ForeColor = Color.White;
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnInformacionEmpresa_Click(object sender, EventArgs e)
        {
            DSMarket.Solucion.Pantallas.Pantallas.Configuracion.InformacionEmpresa Informacion = new Pantallas.Configuracion.InformacionEmpresa();
            Informacion.ShowDialog();
        }

        private void btnComprobantes_Click(object sender, EventArgs e)
        {
            DSMarket.Solucion.Pantallas.Pantallas.Configuracion.Comprobantes Comprobantes = new Pantallas.Configuracion.Comprobantes();
            Comprobantes.ShowDialog();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            DSMarket.Solucion.Pantallas.Pantallas.Configuracion.Reportes Reportes = new Pantallas.Configuracion.Reportes();
            Reportes.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DSMarket.Solucion.Pantallas.Pantallas.Configuracion.GenerarBackupBD Backup = new Pantallas.Configuracion.GenerarBackupBD();
           // Backup.VariablesGlobales.IdUsuario = Convert.ToDecimal(lbUsuario.Text);
            Backup.ShowDialog();
        }
    }
}
