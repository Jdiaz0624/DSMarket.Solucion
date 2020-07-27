using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSMarket.Solucion.Pantallas.Pantallas.Seguridad
{
    public partial class CambiaClaveUsuario : Form
    {
        public CambiaClaveUsuario()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaSeguridad.LogicaSeguridad> ObjDataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad.LogicaSeguridad>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        private void CerrarPantalla() {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Seguridad.Login Login = new Login();
            Login.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CerrarPantalla();
        }

        private void CambiaClaveUsuario_Load(object sender, EventArgs e)
        {
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtClave.Text.Trim()) || string.IsNullOrEmpty(txtConfirmar.Text.Trim()))
            {
                MessageBox.Show("No puedes dejar campos vacios para cambiar la clave", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                string _Clave = string.IsNullOrEmpty(txtClave.Text.Trim()) ? null : txtClave.Text.Trim();
                string _ConfirmarClave = string.IsNullOrEmpty(txtConfirmar.Text.Trim()) ? null : txtConfirmar.Text.Trim();

                if (_Clave != _ConfirmarClave)
                {
                    MessageBox.Show("Las claves ingresada no ocncuerdan, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtClave.Text = string.Empty;
                    txtConfirmar.Text = string.Empty;
                }
                else {
                    DSMarket.Logica.Comunes.ProcesarUsuarios procesar = new Logica.Comunes.ProcesarUsuarios(
                        VariablesGlobales.IdMantenimeinto,
                        0,
                        "",
                        DSMarket.Logica.Comunes.SeguridadEncriptacion.Encriptar(_Clave),
                        "",
                        false,
                        false,
                        0,
                        "CHANGEPASSWORD");
                    procesar.MAntenimientoUsuarios();
                    MessageBox.Show("Clave cambiada con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CerrarPantalla();
                }
            }
        }

        private void CambiaClaveUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason) {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }
    }
}
