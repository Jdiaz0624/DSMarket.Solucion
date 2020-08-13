using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSMarket.Solucion.Pantallas.Pantallas.Caja
{
    public partial class ConfigurarMontoInicialCaja : Form
    {
        public ConfigurarMontoInicialCaja()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaCaja.LogicaCaja> ObjdataCaja = new Lazy<Logica.Logica.LogicaCaja.LogicaCaja>();
        Lazy<DSMarket.Logica.Logica.LogicaSeguridad.LogicaSeguridad> ObjDataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad.LogicaSeguridad>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

         
        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ConfigurarMontoInicialCaja_Load(object sender, EventArgs e)
        {
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            lbTitulo.Text = "Configurar el monto inicial de la caja";
            lbTitulo.ForeColor = Color.White;
        }

        private void BtnValidar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()))
            {
                MessageBox.Show("El campo clave de seguridad no puede estar vacio, favor de seguridad", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()))
                {
                    errorProvider1.SetError(txtClaveSeguridad, "Campo Vacio");
                }
            }
            else {
                //VALIDAMOS LA CLAVE DE SEGURIDAD
                string _ClaveSeguridad = string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()) ? null : txtClaveSeguridad.Text.Trim();

                var Validar = ObjDataSeguridad.Value.BuscaClaveSeguridad(
                    new Nullable<decimal>(),
                    null,
                    DSMarket.Logica.Comunes.SeguridadEncriptacion.Encriptar(_ClaveSeguridad), 1, 1);
                if (Validar.Count() < 1)
                {
                    MessageBox.Show("La clave de seguridad ingresada no es valida, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtClaveSeguridad.Text = string.Empty;

                }
                else {
                    groupBox1.Enabled = false;
                    groupBox2.Visible = true;

                    var SacarMonto = ObjdataCaja.Value.BuscaMontoInicialCaja(1);
                    foreach (var n in SacarMonto) {
                        txtMontoInicialCaja.Text = n.MontoInicialCaja.ToString();
                    }
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMontoInicialCaja.Text.Trim()))
            {
                MessageBox.Show("El campo monto inicial de la caja no puede estar vacio, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (string.IsNullOrEmpty(txtMontoInicialCaja.Text.Trim()))
                {
                    errorProvider1.SetError(txtMontoInicialCaja, "Campo Vacio");
                }
            }
            else {
                DSMarket.Logica.Comunes.ProcesarMontoInicialCaja Monto = new Logica.Comunes.ProcesarMontoInicialCaja(
                    1,
                    Convert.ToDecimal(txtMontoInicialCaja.Text),
                    "UPDATE");
                Monto.ProcesarInformacion();
                MessageBox.Show("Registro modificado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TxtMontoInicialCaja_KeyPress(object sender, KeyPressEventArgs e)
        {
            DSMarket.Logica.Comunes.ValidarControles.SoloNumeros(e);
        }
    }
}
