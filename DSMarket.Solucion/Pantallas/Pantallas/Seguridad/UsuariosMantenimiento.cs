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
    public partial class UsuariosMantenimiento : Form
    {
        public UsuariosMantenimiento()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaListas.LogicaListas> ObjDataListas = new Lazy<Logica.Logica.LogicaListas.LogicaListas>();
        Lazy<DSMarket.Logica.Logica.LogicaSeguridad.LogicaSeguridad> ObjDataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad.LogicaSeguridad>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        private void LimpiarCOntroles() {
            CargarNivelesAcceso();
            txtUsuario.Text = string.Empty;
            txtClave.Text = string.Empty;
            txtConfirmar.Text = string.Empty;
            txtPersona.Text = string.Empty;
            txtClaveSeguridad.Text = string.Empty;
        }
        public void CargarNivelesAcceso() {
            var Niveles = ObjDataListas.Value.ListadoNivelesAccesp();
            txtPerfil.DataSource = Niveles;
            txtPerfil.DisplayMember = "Descripcion";
            txtPerfil.ValueMember = "IdNivelAcceso";
        }

        private void CerrarPantalla() {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Seguridad.UsuariosConsulta Consulta = new UsuariosConsulta();
            Consulta.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Consulta.ShowDialog();
        }

        private void MAnUsuaruis() {
            try
            {
                if (string.IsNullOrEmpty(txtPerfil.Text.Trim()) || string.IsNullOrEmpty(txtUsuario.Text.Trim()) || string.IsNullOrEmpty(txtClave.Text.Trim()) || string.IsNullOrEmpty(txtConfirmar.Text.Trim()) || string.IsNullOrEmpty(txtPersona.Text.Trim()))
                {
                    MessageBox.Show("No puedes dejar campos vacios para realizar esta operación", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                   
                        string _Clave = string.IsNullOrEmpty(txtClave.Text.Trim()) ? null : txtClave.Text.Trim();
                        string _ConfirmarClave = string.IsNullOrEmpty(txtConfirmar.Text.Trim()) ? null : txtConfirmar.Text.Trim();

                        if (_Clave != _ConfirmarClave)
                        {
                            MessageBox.Show("Las claves ingresada no concuerdan favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else {
                            if (VariablesGlobales.Accion == "INSERT")
                            {
                                DSMarket.Logica.Comunes.ProcesarUsuarios Mantenimiento = new Logica.Comunes.ProcesarUsuarios(
                                VariablesGlobales.IdMantenimeinto,
                                Convert.ToDecimal(txtPerfil.SelectedValue),
                                txtUsuario.Text,
                                DSMarket.Logica.Comunes.SeguridadEncriptacion.Encriptar(txtClave.Text),
                                txtPersona.Text,
                                cbEstatus.Checked,
                                cbCambiaCLave.Checked,
                                VariablesGlobales.IdUsuario,
                                VariablesGlobales.Accion);
                                Mantenimiento.MAntenimientoUsuarios();
                                MessageBox.Show("Registro guardado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (MessageBox.Show("¿Quieres guardar otro registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    LimpiarCOntroles();
                                }
                                else {
                                    CerrarPantalla();
                                }
                            }
                            else {
                            if (string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()))
                            {
                                MessageBox.Show("El campo clave de seguridad no puede estar vacio", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else {
                                string _CLaveSeguridad = string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()) ? null : txtClaveSeguridad.Text.Trim();

                                var ValidarClave = ObjDataSeguridad.Value.BuscaClaveSeguridad(
                                    new Nullable<decimal>(),
                                    null,
                                    DSMarket.Logica.Comunes.SeguridadEncriptacion.Encriptar(_CLaveSeguridad),
                                    1, 1);
                                if (ValidarClave.Count() < 1)
                                {
                                    MessageBox.Show("La clave de seguridad no es valida, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    txtClaveSeguridad.Text = string.Empty;
                                }
                                else {
                                    DSMarket.Logica.Comunes.ProcesarUsuarios Mantenimiento = new Logica.Comunes.ProcesarUsuarios(
                                VariablesGlobales.IdMantenimeinto,
                                Convert.ToDecimal(txtPerfil.SelectedValue),
                                txtUsuario.Text,
                                DSMarket.Logica.Comunes.SeguridadEncriptacion.Encriptar(txtClave.Text),
                                txtPersona.Text,
                                cbEstatus.Checked,
                                cbCambiaCLave.Checked,
                                VariablesGlobales.IdUsuario,
                                VariablesGlobales.Accion);
                                    Mantenimiento.MAntenimientoUsuarios();
                                    MessageBox.Show("Registro modificado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    CerrarPantalla();
                                }
                            }
                            }
                        }
                    

                }

            }
            catch (Exception ex) {
                MessageBox.Show("Error al realizar el mantenimiento, codigo de error: " + ex.Message, VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void PCerrar_Click(object sender, EventArgs e)
        {
            CerrarPantalla();
        }

        private void UsuariosMantenimiento_Load(object sender, EventArgs e)
        {
            CargarNivelesAcceso();
            this.BackColor = SystemColors.Control;
            txtClave.BackColor = Color.WhiteSmoke;
            txtClaveSeguridad.BackColor = Color.WhiteSmoke;
            txtConfirmar.BackColor = Color.WhiteSmoke;
            txtPerfil.BackColor = Color.WhiteSmoke;
            txtPersona.BackColor = Color.WhiteSmoke;
            txtUsuario.BackColor = Color.WhiteSmoke;
            txtClave.PasswordChar = '•';
            txtConfirmar.PasswordChar = '•';

            if (VariablesGlobales.Accion == "INSERT")
            {
                lbTitulo.Text = "CREAR NUEVO REGISTRO";
                lbTitulo.ForeColor = Color.WhiteSmoke;
                btnGuardar.Text = "Guardar registro";
                lbClaveSeguridad.Visible = false;
                txtClaveSeguridad.Visible = false;
            }
            else if (VariablesGlobales.Accion == "UPDATE")
            {
                lbTitulo.Text = "MODIFICAR REGISTRO";
                lbTitulo.ForeColor = Color.WhiteSmoke;
                btnGuardar.Text = "Modificar registro";
                lbClaveSeguridad.Visible = true;
                txtClaveSeguridad.Visible = true;
                txtClaveSeguridad.PasswordChar = '•';
            }

            if (VariablesGlobales.Accion == "UPDATE") {
                var SacarInformacionUsuario = ObjDataSeguridad.Value.BuscaUsuarios(
                    VariablesGlobales.IdMantenimeinto,
                    null,
                    null,
                    null,
                    null, 1, 1);
                foreach (var n in SacarInformacionUsuario) {
                    txtPerfil.Text = n.Nivel;
                    txtUsuario.Text = n.Usuario;
                    txtClave.Text = DSMarket.Logica.Comunes.SeguridadEncriptacion.DesEncriptar(n.Clave);
                    txtConfirmar.Text= DSMarket.Logica.Comunes.SeguridadEncriptacion.DesEncriptar(n.Clave);
                    txtPersona.Text = n.Persona;
                    cbEstatus.Checked = (n.Estatus0.HasValue ? n.Estatus0.Value : false);
                    cbCambiaCLave.Checked = (n.CambiaClave0.HasValue ? n.CambiaClave0.Value : false);
                }
            }
        }

        private void UsuariosMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MAnUsuaruis();
        }
    }
}
