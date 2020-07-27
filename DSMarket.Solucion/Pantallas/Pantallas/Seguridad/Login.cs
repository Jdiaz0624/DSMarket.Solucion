using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace DSMarket.Solucion.Pantallas.Pantallas.Seguridad
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaSeguridad.LogicaSeguridad> ObjdataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad.LogicaSeguridad>();
        Lazy<DSMarket.Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion> ObjDataCOnfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region INGRESAR AL SISTEMA
        private void IngresarSistema()
        {
            //VALIDAMOS SI LOS CAMPOS USUARIO Y CLAVE ESTAN VACIOS
            if (string.IsNullOrEmpty(txtUsuario.Text.Trim()) || string.IsNullOrEmpty(txtclave.Text.Trim()))
            {
                MessageBox.Show("Has dejado campos vacios que son necesarios para ingresar al sistema, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //VALIDAMOS LOS DATOS
                string _Usuario = string.IsNullOrEmpty(txtUsuario.Text.Trim()) ? null : txtUsuario.Text.Trim();
                string _Clave = string.IsNullOrEmpty(txtclave.Text.Trim()) ? null : txtclave.Text.Trim();

                var Validarusuario = ObjdataSeguridad.Value.BuscaUsuarios(
                    new Nullable<decimal>(),
                    _Usuario,
                    DSMarket.Logica.Comunes.SeguridadEncriptacion.Encriptar(_Clave),
                    null,
                    null,
                    1, 1);
                if (Validarusuario.Count() < 1)
                {
                    MessageBox.Show("El nombre de usuario o la clave no son validas favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsuario.Text = string.Empty;
                    txtclave.Text = string.Empty;
                    txtUsuario.Focus();
                }
                else
                {
                    //SACAMOS LOS DATOS DEL USUARIO
                    foreach (var n in Validarusuario)
                    {
                        VariablesGlobales.Estatus = Convert.ToBoolean(n.Estatus0);
                        VariablesGlobales.CambiaClave = Convert.ToBoolean(n.CambiaClave0);
                        VariablesGlobales.NombreUsuario = n.Persona;
                        VariablesGlobales.NivelAcceso = n.Nivel;
                        VariablesGlobales.IdUsuario = Convert.ToDecimal(n.IdUsuario);
                        VariablesGlobales.IdNivelAcceso = Convert.ToDecimal(n.IdNivelAcceso);


                    }
                    //VALIDAMOS EL ESTATUS DEL USUARIO
                    if (VariablesGlobales.Estatus == false)
                    {
                        MessageBox.Show("El usuario correspondiente a " + VariablesGlobales.NombreUsuario + " esta deshabilitado actualmente, favor de contactar a un administrador del sistema para desbloquear la cuenta", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtUsuario.Text = string.Empty;
                        txtclave.Text = string.Empty;
                    }
                    else
                    {
                        //VERIFICAMOS SI EL USUARIO VA A CAMBIAR CLAVE
                        if (VariablesGlobales.CambiaClave == true)
                        {
                            this.Hide();
                            DSMarket.Solucion.Pantallas.Pantallas.Seguridad.CambiaClaveUsuario CambiaClave = new CambiaClaveUsuario();
                            CambiaClave.VariablesGlobales.IdMantenimeinto = VariablesGlobales.IdUsuario;
                            CambiaClave.ShowDialog();
                        }
                        else
                        {
                            //ingresamos al sistema
                            this.Hide();
                            DSMarket.Solucion.Pantallas.MenuPrincipal.MenuPrincipal Menuprincipal = new MenuPrincipal.MenuPrincipal();
                            Menuprincipal.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
                            Menuprincipal.ShowDialog();
                        }

                    }
                }
            }
        }
        #endregion


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            /// SacarInformacionEmpresa();
            lbNombreEmpresa.Text = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            DSMarket.Logica.Comunes.AutoCompletarControles.AutoCompletarUsuarios(txtUsuario);
            VariablesGlobales.NombreSistema = lbNombreEmpresa.Text;
            txtclave.PasswordChar = '•';
            gbLogin.Visible = false;
            Efecto.Show(gbLogin);
            lbNombreEmpresa.Visible = false;
            EfectosBotones.Show(lbNombreEmpresa);
            btnMiniminzar.Visible = false;
            EfectosBotones.Show(btnMiniminzar);
            PCerrar.Visible = false;
            EfectosBotones.Show(PCerrar);
        }

        private void btnServicio_Click(object sender, EventArgs e)
        {
            IngresarSistema();
        }

        private void txtclave_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtclave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))

            {
                IngresarSistema();
            }
        }
    }
}
