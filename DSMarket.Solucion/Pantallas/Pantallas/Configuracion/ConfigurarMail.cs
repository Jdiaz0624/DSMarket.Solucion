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
    public partial class ConfigurarMail : Form
    {
        public ConfigurarMail()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion> ObjDataConfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion>();
        Lazy<DSMarket.Logica.Logica.LogicaSeguridad.LogicaSeguridad> ObjDataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad.LogicaSeguridad>();
        Lazy<DSMarket.Logica.Logica.LogicaListas.LogicaListas> ObjDataListas = new Lazy<Logica.Logica.LogicaListas.LogicaListas>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region CARGAR LOS TIPO DE MAILS
        private void CargarListadoTipoMail() {
            var TipoMail = ObjDataListas.Value.BuscaTipoMail();
            ddlSeleccionarTipoSuplidor.DataSource = TipoMail;
            ddlSeleccionarTipoSuplidor.DisplayMember = "TipoMail";
            ddlSeleccionarTipoSuplidor.ValueMember = "IdTipoMail";
        }
        #endregion

        #region BUSCAR TIPO MAIL
        private void SacarDatosTipoMail() {
            var SacarTipoMail = ObjDataConfiguracion.Value.BuscaTipoMail(
                Convert.ToInt32(ddlSeleccionarTipoSuplidor.SelectedValue));
            foreach (var n in SacarTipoMail) {
                txtsmtp.Text = n.smtp;
                txtPuerto.Text = n.Puerto.ToString();
            }
        }
        #endregion

        #region BUSCA MAIL
        public void MostrarListadoMails(decimal IdMail) {

            var Buscar = ObjDataConfiguracion.Value.BuscaMail(IdMail);
            foreach (var n in Buscar) {
                txtMail.Text = n.Mail;
                txtClave.Text = DSMarket.Logica.Comunes.SeguridadEncriptacion.DesEncriptar(n.Clave);
                ddlSeleccionarTipoSuplidor.Text = n.TipoMail;
                cbEstatus.Checked = (n.Estatus.HasValue ? n.Estatus.Value : false);
            }
        }
        #endregion

        private void Restablecer() {
            groupBox1.Enabled = true;
            txtClaveSeguridad.Text = string.Empty;
            groupBox2.Enabled = false;
            txtClave.Text = string.Empty;
            txtMail.Text = string.Empty;
            txtPuerto.Text = string.Empty;
            txtsmtp.Text = string.Empty;
            txtClaveSeguridad.Focus();
        }
        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ConfigurarMail_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason) {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void ConfigurarMail_Load(object sender, EventArgs e)
        {
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            lbTitulo.Text = "CONFIGURACION DE MAIL";
            lbTitulo.ForeColor = Color.White;

            CargarListadoTipoMail();
            SacarDatosTipoMail();
            //SACAMOS LOS DATOS DEL TIPO DEL CORREO
        }

        private void ddlSeleccionarTipoSuplidor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                SacarDatosTipoMail();
            }
            catch (Exception) { }
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()))
            {
                MessageBox.Show("El campo clave de seguridad no puede estar vacio", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                string _Clave = string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()) ? null : txtClaveSeguridad.Text.Trim();

                var Validar = ObjDataSeguridad.Value.BuscaClaveSeguridad(
                    new Nullable<decimal>(),
                    null,
                   DSMarket.Logica.Comunes.SeguridadEncriptacion.Encriptar(_Clave), 1, 1);
                if (Validar.Count() < 1)
                {
                    MessageBox.Show("La clave de seguridad ingresada no es valida, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtClaveSeguridad.Text = string.Empty;
                    txtClaveSeguridad.Focus();
                }
                else {
                    MostrarListadoMails(1);
                    groupBox2.Enabled = true;
                    groupBox1.Enabled = false;
                }
            }
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            Restablecer();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMail.Text.Trim()) || string.IsNullOrEmpty(txtClave.Text.Trim()) || string.IsNullOrEmpty(ddlSeleccionarTipoSuplidor.Text.Trim()))
            {
                MessageBox.Show("No puedes dejar campos vacios para modificar este registro", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                //MODIFICAMOS
                DSMarket.Logica.Comunes.ActualizarMail update = new Logica.Comunes.ActualizarMail(
                    1,
                    txtMail.Text,
                    DSMarket.Logica.Comunes.SeguridadEncriptacion.Encriptar(txtClave.Text),
                    cbEstatus.Checked,
                    Convert.ToInt32(ddlSeleccionarTipoSuplidor.SelectedValue));
                update.Actualizar();
                MessageBox.Show("Registro actualizado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Restablecer();
            }
        }
    }
}
