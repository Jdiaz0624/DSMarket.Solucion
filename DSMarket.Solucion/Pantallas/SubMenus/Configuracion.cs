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
        Lazy<DSMarket.Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion> ObjDataConfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        private void Configuracion_Load(object sender, EventArgs e)
        {
            lbTitulo.Text = "CONFIGURACION DEL SISTEMA";
            lbTitulo.ForeColor = Color.White;
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
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
            DSMarket.Solucion.Pantallas.Pantallas.Configuracion.Comprobantes NCF = new Pantallas.Configuracion.Comprobantes();
            //NCF.VariablesGlobales.IdUsuario = Convert.ToDecimal(lbUsuario.Text);
            NCF.ShowDialog();
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

        private void button3_Click(object sender, EventArgs e)
        {
            DSMarket.Solucion.Pantallas.Pantallas.Configuracion.ConfiguracionImpuestos Impuestos = new Pantallas.Configuracion.ConfiguracionImpuestos();
            Impuestos.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DSMarket.Solucion.Pantallas.Pantallas.Configuracion.ConfigurarMail Mail = new Pantallas.Configuracion.ConfigurarMail();
            Mail.ShowDialog();
        }

        private void BtnRutaArchivotxt_Click(object sender, EventArgs e)
        {
            DSMarket.Solucion.Pantallas.Pantallas.Configuracion.ConfigurarRutaArchivotxt txt = new Pantallas.Configuracion.ConfigurarRutaArchivotxt();
            txt.ShowDialog();
        }

        private void BtnComfiguracionGeneral_Click(object sender, EventArgs e)
        {
            DSMarket.Solucion.Pantallas.Pantallas.Configuracion.ConfiguracionGeneral ConfiguracionGeneral = new Pantallas.Configuracion.ConfiguracionGeneral();
            ConfiguracionGeneral.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DSMarket.Solucion.Pantallas.Pantallas.Configuracion.PorcientoDescuentoProductoPorDefecto Porciento = new Pantallas.Configuracion.PorcientoDescuentoProductoPorDefecto();
            Porciento.ShowDialog();
        }
    }
}
