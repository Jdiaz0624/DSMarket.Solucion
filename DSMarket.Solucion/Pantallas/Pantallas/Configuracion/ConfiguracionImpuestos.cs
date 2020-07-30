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
    public partial class ConfiguracionImpuestos : Form
    {
        public ConfiguracionImpuestos()
        {
            InitializeComponent();
        }

        Lazy<DSMarket.Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion> ObjDataConfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion>();
        Lazy<DSMarket.Logica.Logica.LogicaSeguridad.LogicaSeguridad> ObjDataSeguriad = new Lazy<Logica.Logica.LogicaSeguridad.LogicaSeguridad>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariableGlobales = new Logica.Comunes.VariablesGlobales();

        private void MostrarListadoImpuestos() {
            var MostrarImpuestos = ObjDataConfiguracion.Value.BuscaImpuestos(1);
            dtListado.DataSource = MostrarImpuestos;
            OcultarColumnas();
        }
        private void OcultarColumnas() {
            this.dtListado.Columns["IdImpuesto"].Visible = false;
            this.dtListado.Columns["Operacion0"].Visible = false;
            

        }

        private void Restablecer() {
            dtListado.DataSource = null;
            groupBox2.Enabled = false;
            groupBox1.Enabled = false;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            txtClaveSeguridad.Enabled = true;
            btnNuevo.Enabled = true;
            txtClaveSeguridad.Text = string.Empty;
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ConfiguracionImpuestos_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason) {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()))
            {
                MessageBox.Show("El campo clave de seguridad no puede estar vacio", VariableGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                string _ClaveSeguridad = string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()) ? null : txtClaveSeguridad.Text.Trim();

                var ValidarClave = ObjDataSeguriad.Value.BuscaClaveSeguridad(
                    new Nullable<decimal>(),
                    null,
                    DSMarket.Logica.Comunes.SeguridadEncriptacion.Encriptar(_ClaveSeguridad),
                    1, 1);
                if (ValidarClave.Count() < 1)
                {
                    MessageBox.Show("La clave de seguridad ingresada no es valida", VariableGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtClaveSeguridad.Text = string.Empty;
                }
                else {
                    groupBox1.Enabled = true;
                    groupBox1.Visible = true;
                    groupBox2.Visible = true;
                    txtClaveSeguridad.Enabled = false;
                    btnNuevo.Enabled = false;
                    MostrarListadoImpuestos();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Restablecer();
        }

        private void dtListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("¿Quieres seleccionar este registro?", VariableGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
         

                var Buscar = ObjDataConfiguracion.Value.BuscaImpuestos(1);
                foreach (var n in Buscar) {
                    txtDescripcion.Text = n.Descripcion;
                    txtPorciento.Text = n.PorcientoImpuesto.ToString();
                    txtEstatus.Text = n.Operacion;
                    cbSuma.Checked = (n.Operacion0.HasValue ? n.Operacion0.Value : false);
                    groupBox2.Enabled = true;
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPorciento.Text.Trim()))
            {
                MessageBox.Show("El campo % no puede estar vacio", VariableGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //MODIFICAMOS
                DSMarket.Logica.Comunes.ModificarImpuesto update = new Logica.Comunes.ModificarImpuesto(
                    1,
                    txtDescripcion.Text,
                    Convert.ToInt32(txtPorciento.Text),
                    cbSuma.Checked);
                update.Modificar();
                MessageBox.Show("Registro modificado con exito", VariableGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarListadoImpuestos();

            }
        }

        private void txtPorciento_KeyPress(object sender, KeyPressEventArgs e)
        {
            DSMarket.Logica.Comunes.ValidarControles.SoloNumeros(e);
        }

        private void ConfiguracionImpuestos_Load(object sender, EventArgs e)
        {
            VariableGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            lbTitulo.Text = "MODIFICAR EL IMPUESTO DE VENTA";
            lbTitulo.ForeColor = Color.White;
        }

        private void PCerrar_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
