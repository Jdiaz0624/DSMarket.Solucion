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
    public partial class CredencialesBD : Form
    {
        public CredencialesBD()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaSeguridad.LogicaSeguridad> ObjDataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad.LogicaSeguridad>();
        Lazy<DSMarket.Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion> ObjDataConfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region MOSTRAR LAS CREDENCIALES DE LA BD
        private void MostrarCredenciales() {
            var SacarCredenciales = ObjDataSeguridad.Value.SacarCredencialBD(1);
            foreach (var n in SacarCredenciales) {
                txtUsuario.Text = n.Usuario;
                txtClave.Text = DSMarket.Logica.Comunes.SeguridadEncriptacion.DesEncriptar(n.Clave);
            }
        }
        #endregion

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Configuracion.Reportes Reportes = new Reportes();
            Reportes.ShowDialog();
        }

        private void CredencialesBD_Load(object sender, EventArgs e)
        {
            MostrarCredenciales();
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            this.BackColor = SystemColors.Control;
            txtClave.BackColor = Color.WhiteSmoke;
            txtclaveSeguridad.BackColor = Color.WhiteSmoke;
            txtUsuario.BackColor = Color.WhiteSmoke;
            txtclaveSeguridad.PasswordChar = '•';
            lbTitulo.Text = "CREDENCIALES DE BASE DE DATOS";
            lbTitulo.ForeColor = Color.WhiteSmoke;
        }

        private void CredencialesBD_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text.Trim()) || string.IsNullOrEmpty(txtClave.Text.Trim()))
            {
                MessageBox.Show("El usuario o la clave no pueden estar vacios para modificar este registro", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                if (string.IsNullOrEmpty(txtclaveSeguridad.Text.Trim()))
                {
                    MessageBox.Show("La clave de seguridad no puede estar vacio para modificar este registro", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else {
                    string _ClaveSeguridad = string.IsNullOrEmpty(txtclaveSeguridad.Text.Trim()) ? null : txtclaveSeguridad.Text.Trim();

                    var ValidarClaveSeguridad = ObjDataSeguridad.Value.BuscaClaveSeguridad(
                        new Nullable<decimal>(),
                        null,
                        DSMarket.Logica.Comunes.SeguridadEncriptacion.Encriptar(_ClaveSeguridad),
                        1, 1);
                    if (ValidarClaveSeguridad.Count() < 1)
                    {
                        MessageBox.Show("La clave de seguridad ingresada no es valida, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtclaveSeguridad.Text = string.Empty;
                        txtclaveSeguridad.Focus();
                    }
                    else {
                        DSMarket.Logica.Entidades.EntidadesSeguridad.ECredenciales Modificar = new Logica.Entidades.EntidadesSeguridad.ECredenciales();

                        Modificar.IdCredencial = 1;
                        Modificar.Usuario = txtUsuario.Text;
                        Modificar.Clave = DSMarket.Logica.Comunes.SeguridadEncriptacion.Encriptar(txtClave.Text);

                        var MAN = ObjDataSeguridad.Value.ModificarCredencial(Modificar, "UPDATE");

                        MessageBox.Show("Registro modificado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtUsuario.Text = string.Empty;
                        txtClave.Text = string.Empty;
                        txtclaveSeguridad.Text = string.Empty;
                        MostrarCredenciales();

                    }
                }
            }
        }
    }
}
