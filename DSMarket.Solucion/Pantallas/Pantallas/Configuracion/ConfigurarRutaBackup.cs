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
    public partial class ConfigurarRutaBackup : Form
    {
        public ConfigurarRutaBackup()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion> ObjDataConfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion>();
        public DSMarket.Logica.Comunes.VariablesGlobales variablesglobales = new Logica.Comunes.VariablesGlobales();

        private void SacarRuta(decimal IdRutaBackup) {
            var SacarRuta = ObjDataConfiguracion.Value.BuscaRutaBAckup(IdRutaBackup);
            foreach (var n in SacarRuta) {
                txtRutaReportes.Text = n.Ruta;
            }
        }
        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog carpeta = new FolderBrowserDialog();
            if (carpeta.ShowDialog() == DialogResult.OK)
            {
                txtRutaReportes.Text = carpeta.SelectedPath;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DSMarket.Logica.Comunes.MantenimientoRutaBAckup Modificar = new Logica.Comunes.MantenimientoRutaBAckup(
                1, txtRutaReportes.Text, "UPDATE");
            Modificar.MAntenimientoRuta();
            MessageBox.Show("Ruta Modificada con exito", variablesglobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
            SacarRuta(1);
        }

        private void ConfigurarRutaBackup_Load(object sender, EventArgs e)
        {
            variablesglobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            SacarRuta(1);
        }

        private void ConfigurarRutaBackup_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason) {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }
    }
}
