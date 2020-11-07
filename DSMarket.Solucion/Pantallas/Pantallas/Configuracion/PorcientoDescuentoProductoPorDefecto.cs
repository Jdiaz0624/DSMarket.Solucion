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
    public partial class PorcientoDescuentoProductoPorDefecto : Form
    {
        public PorcientoDescuentoProductoPorDefecto()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion> ObjdataConfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion>();
        Lazy<DSMarket.Logica.Logica.LogicaSeguridad.LogicaSeguridad> ObjDataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad.LogicaSeguridad>();
        public DSMarket.Logica.Comunes.VariablesGlobales variablesGlobales = new Logica.Comunes.VariablesGlobales();
        private void PorcientoDescuentoProductoPorDefecto_Load(object sender, EventArgs e)
        {
            lbTitulo.Text = "PORCIENTO DE DESCUENTO POR DEFECTO";
            lbTitulo.ForeColor = Color.White;
            variablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();

        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPorciento.Text.Trim())) {
                MessageBox.Show("Favor ingresar el porciento de descuento", variablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                int PorcientoDescuento = Convert.ToInt32(txtPorciento.Text);
                if (PorcientoDescuento < 0 || PorcientoDescuento > 100)
                {
                    MessageBox.Show("Parametro no valido, el porciento de descuento tiene que estar entre 0 y 100", variablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else {
                    DSMarket.Logica.Comunes.ProcesarInformacion.Configuracion.ProcesarInformacionDescuentoPorDefecto Procesar = new Logica.Comunes.ProcesarInformacion.Configuracion.ProcesarInformacionDescuentoPorDefecto(
                        1,
                        PorcientoDescuento,
                        "UPDATE");
                    Procesar.ProcesarInformacion();
                    MessageBox.Show("Registro Modificado con exito", variablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
            }
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim())) {
                MessageBox.Show("El campo clave de seguridad no puede estar vacio, favor de verificar", variablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                string _ClaveSeguridad = string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()) ? null : txtClaveSeguridad.Text.Trim();

                var ValidarRegistro = ObjDataSeguridad.Value.BuscaClaveSeguridad(
                    new Nullable<decimal>(),
                    null,
                    DSMarket.Logica.Comunes.SeguridadEncriptacion.Encriptar(_ClaveSeguridad),
                    1, 1);
                if (ValidarRegistro.Count() < 1)
                {
                    MessageBox.Show("La clave de seguridad ingresada no es valida, favor de verificar", variablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtClaveSeguridad.Text = string.Empty;
                    txtClaveSeguridad.Focus();
                }
                else {
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = true;
                    txtPorciento.Text = DSMarket.Logica.Comunes.ValidarConfiguracionGeneral.SacarPorcientoDescuentoProducto(1).ToString();
                }
            }
        }

        private void txtPorciento_KeyPress(object sender, KeyPressEventArgs e)
        {
            DSMarket.Logica.Comunes.ValidarControles.SoloNumeros(e);
        }

        private void PorcientoDescuentoProductoPorDefecto_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason) {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }
    }
}
