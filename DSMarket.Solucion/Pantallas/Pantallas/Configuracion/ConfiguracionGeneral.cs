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
    public partial class ConfiguracionGeneral : Form
    {
        public ConfiguracionGeneral()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaSeguridad.LogicaSeguridad> ObjdataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad.LogicaSeguridad>();
        Lazy<DSMarket.Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion> ObjDataConfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion>();
        Lazy<DSMarket.Logica.Logica.LogicaListas.LogicaListas> ObjdataListas = new Lazy<Logica.Logica.LogicaListas.LogicaListas>();
        DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        private void CargarModulos() {
            try {
                var Cargarmodulo = ObjdataListas.Value.CargarListadoModulos();
                ddlModulo.DataSource = Cargarmodulo;
                ddlModulo.DisplayMember = "Descripcion";
                ddlModulo.ValueMember = "IdModulo";
            }
            catch (Exception) {
                MessageBox.Show("Error al cargar los modulos", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarConfiguraciones() {
            decimal? _Modulo = cbFiltrarPorFiltro.Checked == true ? Convert.ToDecimal(ddlModulo.SelectedValue) : new Nullable<decimal>();

            var Listado = ObjDataConfiguracion.Value.BuscaConfiguraciongeneral(
                new Nullable<decimal>(),
                _Modulo);
            dtListado.DataSource = Listado;
            OcultarColumnas();
        }
        private void OcultarColumnas() {
            this.dtListado.Columns["IdConfiguracion"].Visible = false;
            this.dtListado.Columns["IdModulo"].Visible = false;
            this.dtListado.Columns["Estatus0"].Visible = false;
        }
        private void ValidarClaveSeguridad() {
            string _ClaveSeguridad = DSMarket.Logica.Comunes.SeguridadEncriptacion.Encriptar(txtClaveSeguridad.Text);

            var Validar = ObjdataSeguridad.Value.BuscaClaveSeguridad(
                new Nullable<decimal>(),
                null,
                _ClaveSeguridad,
                1, 1);
            if (Validar.Count() < 1) {
                MessageBox.Show("La clave de seguridad ingresada no es valida, favor de verificar.", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtClaveSeguridad.Text = string.Empty;
                txtClaveSeguridad.Focus();
            
            }
            else {
                gbListado.Enabled = true;
                gbValidar.Enabled = false;
                cbFiltrarPorFiltro.Enabled = true;
                ddlModulo.Enabled = true;
                CargarModulos();
                CargarConfiguraciones();
            }
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ConfiguracionGeneral_Load(object sender, EventArgs e)
        {
            lbTitulo.Text = "CONFIGURACIONES GENERALES DEL SISTEMA";
            lbTitulo.ForeColor = Color.White;
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            gbValidar.Enabled = false;
            gbValidar.Enabled = true;
            cbFiltrarPorFiltro.Enabled = false;
            ddlModulo.Enabled = false;
        }

        private void txtClaveSeguridad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) {
                ValidarClaveSeguridad();
            }
        }

        private void cbFiltrarPorFiltro_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFiltrarPorFiltro.Checked == true) {
                CargarConfiguraciones();
            }
            else if (cbFiltrarPorFiltro.Checked == false) {
                CargarConfiguraciones();
            }
        }

        private void ddlModulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFiltrarPorFiltro.Checked == true) {
                CargarConfiguraciones();
            }
        }

        private void ConfiguracionGeneral_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason) {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }
    }
}
