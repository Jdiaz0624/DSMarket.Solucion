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
    public partial class Comprobantes : Form
    {
        public Comprobantes()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion> ObjDataConfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion>();
        Lazy<DSMarket.Logica.Logica.LogicaSeguridad.LogicaSeguridad> ObjDataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad.LogicaSeguridad>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region MOSTRAR EL LISTADO DE LOS COMPROBANTES FISCALES
        private void MostrarListadoComprobantes() {
            try {
                var Listado = ObjDataConfiguracion.Value.BuscaComprobantesFiscales(
                    new Nullable<decimal>());
                dtListado.DataSource = Listado;
                OcultarColumnas();
            }
            catch (Exception ex) {
                MessageBox.Show("Error al mostrar el listado de los comprobantes fiscales  " + ex.Message, VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void OcultarColumnas() {
            this.dtListado.Columns["IdComprobante"].Visible = false;
            this.dtListado.Columns["Estatus0"].Visible = false;
            this.dtListado.Columns["PorDefecto0"].Visible = false;
        }
        #endregion
        #region MANTENIMIENTO DE COMPROBANTES FISCALES
        private void MAnCOmprobantesFiscales(string Accion) {
            try {
                DSMarket.Logica.Entidades.EntidadesConfiguracion.EMantenimientoComprobantes Modificar = new Logica.Entidades.EntidadesConfiguracion.EMantenimientoComprobantes();

                Modificar.IdComprobante = VariablesGlobales.IdMantenimeinto;
                Modificar.Descripcion = txtDescripcion.Text;
                Modificar.Serie = txtSerie.Text;
                Modificar.TipoComprobante = txtTipoComprobante.Text;
                Modificar.Secuencia = Convert.ToInt64(txtSecuencial.Text);
                Modificar.SecuenciaInicial = Convert.ToInt64(txtSecuenciaInicial.Text);
                Modificar.SecuenciaFinal = Convert.ToInt64(txtSecuenciaFinal.Text);
                Modificar.Limite = Convert.ToInt64(txtLimite.Text);
                Modificar.Estatus = cbEstatus.Checked;
                Modificar.ValidoHasta = txtValidoHasta.Text;
                Modificar.PorDefecto = cbPorDefecto.Checked;
                Modificar.Posiciones = Convert.ToInt64(txtPociciones.Text);

                var MAN = ObjDataConfiguracion.Value.MantenimientoComprobantes(Modificar, Accion);
            }
            catch (Exception ex) {
                MessageBox.Show("Error al modificar registro, codigo de error--> " + ex.Message, VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region RESTABELCER PANTALLA
        private void RestabelcerPantalla() {
            txtDescripcion.Text = string.Empty;
            txtSerie.Text = string.Empty;
            txtTipoComprobante.Text = string.Empty;
            txtSecuencial.Text = string.Empty;
            txtSecuenciaInicial.Text = string.Empty;
            txtSecuenciaFinal.Text = string.Empty;
            txtLimite.Text = string.Empty;
            txtValidoHasta.Text = string.Empty;
            txtPociciones.Text = string.Empty;
            txtClaveSeguridad.Text = string.Empty;
            cbEstatus.Checked = false;
            cbPorDefecto.Checked = false;
            MostrarListadoComprobantes();
        }
        #endregion
        #region CONFIGURAICON GENERAL
        private void SacarDataConfiguracionGeneral(int IdConfiguraciongeneral) {
            var SacarData = ObjDataConfiguracion.Value.BuscaCOnfiguracionGeneral(IdConfiguraciongeneral);
            foreach (var n in SacarData) {
                cbUsarComprobantes.Checked = (n.Estatus0.HasValue ? n.Estatus0.Value : false);
            }
        }
        private void MantenimeintoConfiguraicongeneral(string Accion) {
            if (cbUsarComprobantes.Checked == true) {
                DSMarket.Logica.Entidades.EntidadesConfiguracion.EConfiguracionGeneral Modificar = new Logica.Entidades.EntidadesConfiguracion.EConfiguracionGeneral();

                Modificar.IdConfiguracionGeneral = 1;
                Modificar.Descripcion = "Usar Comprobantes Fiscales";
                Modificar.Estatus0 = true;

                var MAN = ObjDataConfiguracion.Value.MantenimientoConfiguracionGeneral(Modificar, Accion);
            }
            else if (cbUsarComprobantes.Checked == false) {
                DSMarket.Logica.Entidades.EntidadesConfiguracion.EConfiguracionGeneral Modificar = new Logica.Entidades.EntidadesConfiguracion.EConfiguracionGeneral();

                Modificar.IdConfiguracionGeneral = 1;
                Modificar.Descripcion = "Usar Comprobantes Fiscales";
                Modificar.Estatus0 = false;

                var MAN = ObjDataConfiguracion.Value.MantenimientoConfiguracionGeneral(Modificar, Accion);
            }
        }
        #endregion
        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Comprobantes_Load(object sender, EventArgs e)
        {
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            MostrarListadoComprobantes();
            SacarDataConfiguracionGeneral(1);
            this.BackColor = SystemColors.Control;
            txtClaveSeguridad.BackColor = Color.WhiteSmoke;
            txtDescripcion.BackColor = Color.WhiteSmoke;
            txtLimite.BackColor = Color.WhiteSmoke;
            txtPociciones.BackColor = Color.WhiteSmoke;
            txtSecuenciaFinal.BackColor = Color.WhiteSmoke;
            txtSecuenciaInicial.BackColor = Color.WhiteSmoke;
            txtSecuencial.BackColor = Color.WhiteSmoke;
            txtSerie.BackColor = Color.WhiteSmoke;
            txtTipoComprobante.BackColor = Color.WhiteSmoke;
            txtValidoHasta.BackColor = Color.WhiteSmoke;

            txtClaveSeguridad.ForeColor = Color.Black;
            txtDescripcion.ForeColor = Color.Black;
            txtLimite.ForeColor = Color.Black;
            txtPociciones.ForeColor = Color.Black;
            txtSecuenciaFinal.ForeColor = Color.Black;
            txtSecuenciaInicial.ForeColor = Color.Black;
            txtSecuencial.ForeColor = Color.Black;
            txtSerie.ForeColor = Color.Black;
            txtTipoComprobante.ForeColor = Color.Black;
            txtValidoHasta.ForeColor = Color.Black;

            txtClaveSeguridad.PasswordChar = '•';

            lbTitulo.Text = "MANTENIMIENTO DE COMPROBANTES";
            lbTitulo.ForeColor = Color.WhiteSmoke;

            dtListado.BackgroundColor = SystemColors.Control;
            cbEstatus.ForeColor = Color.DarkRed;
            cbPorDefecto.ForeColor = Color.DarkRed;
            cbUsarComprobantes.ForeColor = Color.DarkRed;
        }

        private void cbEstatus_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEstatus.Checked == true)
            {
                cbEstatus.ForeColor = Color.LimeGreen;
            }
            else
            {
                cbEstatus.ForeColor = Color.DarkRed;
            }
        }

        private void cbPorDefecto_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPorDefecto.Checked == true)
            {
                cbPorDefecto.ForeColor = Color.LimeGreen;
            }
            else
            {
                cbPorDefecto.ForeColor = Color.DarkRed;
            }
        }

        private void Comprobantes_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void cbUsarComprobantes_CheckedChanged(object sender, EventArgs e)
        {
            if (cbUsarComprobantes.Checked == true)
            {
                cbUsarComprobantes.ForeColor = Color.LimeGreen;

                DSMarket.Logica.Entidades.EntidadesConfiguracion.EConfiguracionGeneral Modificar = new Logica.Entidades.EntidadesConfiguracion.EConfiguracionGeneral();

                Modificar.IdConfiguracionGeneral = 1;
                Modificar.Descripcion = "Usar Comprobantes Fiscales";
                Modificar.Estatus0 = true;

                var MAN = ObjDataConfiguracion.Value.MantenimientoConfiguracionGeneral(Modificar, "UPDATE");
            }
            else {
                cbUsarComprobantes.ForeColor = Color.DarkRed;

                DSMarket.Logica.Entidades.EntidadesConfiguracion.EConfiguracionGeneral Modificar = new Logica.Entidades.EntidadesConfiguracion.EConfiguracionGeneral();

                Modificar.IdConfiguracionGeneral = 1;
                Modificar.Descripcion = "Usar Comprobantes Fiscales";
                Modificar.Estatus0 = false;

                var MAN = ObjDataConfiguracion.Value.MantenimientoConfiguracionGeneral(Modificar, "UPDATE");
                
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            RestabelcerPantalla();
        }

        private void dtListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("¿Quieres seleccionar este registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                this.VariablesGlobales.IdMantenimeinto = Convert.ToDecimal(this.dtListado.CurrentRow.Cells["IdComprobante"].Value.ToString());

                var Comprobantes = ObjDataConfiguracion.Value.BuscaComprobantesFiscales(
                    VariablesGlobales.IdMantenimeinto);
                dtListado.DataSource = components;
                foreach (var n in Comprobantes) {
                    txtDescripcion.Text = n.Comprobante;
                    txtSerie.Text = n.Serie;
                    txtTipoComprobante.Text = n.TipoComprobante;
                    txtSecuencial.Text = n.Secuencia.ToString();
                    txtSecuenciaInicial.Text = n.SecuenciaInicial.ToString();
                    txtSecuenciaFinal.Text = n.SecuenciaFinal.ToString();
                    txtLimite.Text = n.Limite.ToString();
                    txtValidoHasta.Text = n.ValidoHasta;
                    txtPociciones.Text = n.Posiciones.ToString();
                    cbEstatus.Checked = (n.Estatus0.HasValue ? n.Estatus0.Value : false);
                    cbPorDefecto.Checked = (n.PorDefecto0.HasValue ? n.PorDefecto0.Value : false);
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim())) {
                MessageBox.Show("El campo clave de seguridad no puede estar vacio, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                if (string.IsNullOrEmpty(txtDescripcion.Text.Trim()) || string.IsNullOrEmpty(txtSerie.Text.Trim()) || string.IsNullOrEmpty(txtTipoComprobante.Text.Trim()) || string.IsNullOrEmpty(txtSecuencial.Text.Trim()) || string.IsNullOrEmpty(txtSecuenciaInicial.Text.Trim()) || string.IsNullOrEmpty(txtSecuenciaFinal.Text.Trim()) || string.IsNullOrEmpty(txtLimite.Text.Trim()) || string.IsNullOrEmpty(txtValidoHasta.Text.Trim()) || string.IsNullOrEmpty(txtPociciones.Text.Trim()))
                {
                    MessageBox.Show("No puedes dejar campos vacios para modificar este registro", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else {
                    //VALIDAMOS LA CLAVED E SEGURIDAD
                    string _ClaveSeguridad = string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()) ? null : txtClaveSeguridad.Text.Trim();

                    var ValidarClave = ObjDataSeguridad.Value.BuscaClaveSeguridad(
                        new Nullable<decimal>(),
                        null,
                        DSMarket.Logica.Comunes.SeguridadEncriptacion.Encriptar(_ClaveSeguridad),
                        1, 1);
                    if (ValidarClave.Count() < 1)
                    {
                        MessageBox.Show("La clave de seguridad ingresada no es valida, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtClaveSeguridad.Text = string.Empty;
                        txtClaveSeguridad.Focus();
                    }
                    else
                    {
                        //modificamos
                        MAnCOmprobantesFiscales("INSERT");
                        MessageBox.Show("Registro modificado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RestabelcerPantalla();
                    }
                }
            }
        }
    }
}
