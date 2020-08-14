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
    public partial class ConfigurarRutaArchivotxt : Form
    {
        public ConfigurarRutaArchivotxt()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaSeguridad.LogicaSeguridad> ObjDataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad.LogicaSeguridad>();
        Lazy<DSMarket.Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion> ObjDataConfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()))
            {
                MessageBox.Show("El campo clave de seguridad no puede estar vacio, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()))
                {
                    errorProvider1.SetError(txtClaveSeguridad, "Campo Vacio");
                }
            }
            else {
                string _ClaveSeguridad = string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()) ? null : txtClaveSeguridad.Text.Trim();

                var ValidarClave = ObjDataSeguridad.Value.BuscaClaveSeguridad(
                    new Nullable<decimal>(),
                    null,
                    DSMarket.Logica.Comunes.SeguridadEncriptacion.Encriptar(_ClaveSeguridad),
                    1, 1);
                if (ValidarClave.Count() < 1)
                {
                    MessageBox.Show("La clave de seguriad ingresada no es valida, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtClaveSeguridad.Text = string.Empty;
                    txtClaveSeguridad.Focus();
                }
                else {
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = true;

                    var SacarRutaArchivotxt = ObjDataConfiguracion.Value.BuscaRutaArchivotxt(1);
                    foreach (var n in SacarRutaArchivotxt) {
                        txtRutaArchivo.Text = n.Ruta;
                    }
                }
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog carpeta = new FolderBrowserDialog();
            if (carpeta.ShowDialog() == DialogResult.OK)
            {
                txtRutaArchivo.Text = carpeta.SelectedPath;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            DSMarket.Logica.Comunes.ProcesarRUtaArchivotxt Procesar = new Logica.Comunes.ProcesarRUtaArchivotxt(
                1,
                txtRutaArchivo.Text,
                "UPDATE");
            Procesar.ProcesarInformacion();
            MessageBox.Show("Registro guardado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ConfigurarRutaArchivotxt_Load(object sender, EventArgs e)
        {
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ConfigurarRutaArchivotxt_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason) {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }
    }
}
