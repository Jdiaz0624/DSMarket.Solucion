using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSMarket.Solucion.Pantallas.Pantallas.Empresa
{
    public partial class MantenimientoBancos : Form
    {
        public MantenimientoBancos()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaEmpresa.LogicaEmpresa> ObjDataEmpresa = new Lazy<Logica.Logica.LogicaEmpresa.LogicaEmpresa>();
        Lazy<DSMarket.Logica.Logica.LogicaSeguridad.LogicaSeguridad> ObjDataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad.LogicaSeguridad>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        private void LimpiarControles() {
            txtBanco.Text = string.Empty;
            txtAuxiliar.Text = string.Empty;
            txtCuenta.Text = string.Empty;
            cbEstatus.Checked = true;
            txtBanco.Focus();
        }
        private void CerrarPantalla() {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.BancoConsulta Consulta = new BancoConsulta();
            Consulta.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Consulta.ShowDialog();
        }

        private void MantenimientoBancos_Load(object sender, EventArgs e)
        {
            lbTitulo.Text = "MANTENIMIENTO DE BANCOS";
            lbTitulo.ForeColor = Color.White;
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            cbEstatus.Checked = true;

            if (VariablesGlobales.Accion != "INSERT") {
                //SACAMOS LOS DATOS DEL REGISTRO 
                var SacarInformacionRegistro = ObjDataEmpresa.Value.ListadoBancos(
                    VariablesGlobales.IdMantenimeinto,
                    null, 1, 1);
                foreach (var n in SacarInformacionRegistro) {
                    txtBanco.Text = n.Banco;
                    txtCuenta.Text = n.CuentaContable.ToString();
                    txtAuxiliar.Text = n.Auxiliar.ToString();
                    cbEstatus.Checked = (n.Estatus0.HasValue ? n.Estatus0.Value : false);
                }

                lbclaveSeguridad.Visible = true;
                txtClaveSeguridad.Visible = true;
                txtClaveSeguridad.PasswordChar = '•';
            }

        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            CerrarPantalla();
        }

        private void MantenimientoBancos_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason) {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void txtAuxiliar_KeyPress(object sender, KeyPressEventArgs e)
        {
            DSMarket.Logica.Comunes.ValidarControles.SoloNumeros(e);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //VALIDAMOS LOS CAMPOS VACIOS
            if (string.IsNullOrEmpty(txtBanco.Text.Trim()) || string.IsNullOrEmpty(txtCuenta.Text.Trim()) || string.IsNullOrEmpty(txtAuxiliar.Text.Trim()))
            {
                MessageBox.Show("No puedes dejar campos vacios para realizar esta operación", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                if (VariablesGlobales.Accion == "INSERT") {
                    DSMarket.Logica.Comunes.ProcesarInformacion.Empresa.ProcesarInformacionBancos Guardar = new Logica.Comunes.ProcesarInformacion.Empresa.ProcesarInformacionBancos(
                        VariablesGlobales.IdMantenimeinto,
                        Convert.ToInt32(txtCuenta.Text),
                        Convert.ToInt32(txtAuxiliar.Text),
                        txtBanco.Text,
                        cbEstatus.Checked,
                        VariablesGlobales.IdUsuario,
                        "INSERT");
                    Guardar.ProcesarInformacion();
                    MessageBox.Show("Registro guardado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (MessageBox.Show("¿Quieres agregar otro registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        LimpiarControles();
                    }
                    else {
                        CerrarPantalla();
                    }
                }
                else {
                    if (string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()))
                    {
                        MessageBox.Show("El campo clave de seguridad no puede estar vacio para modificar este registro", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else {
                        //VALIDAMOS LA CLAVE DE SEGURIDAD
                        string _ClaveSeguridad = string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()) ? null : txtClaveSeguridad.Text.Trim();

                        var ValidarClaveSeguridad = ObjDataSeguridad.Value.BuscaClaveSeguridad(
                            new Nullable<decimal>(),
                            null,
                            DSMarket.Logica.Comunes.SeguridadEncriptacion.Encriptar(_ClaveSeguridad),
                            1, 1);
                        if (ValidarClaveSeguridad.Count() < 1) {
                            MessageBox.Show("La clave de seguridad ingresada no es valida, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtClaveSeguridad.Text = string.Empty;
                            txtClaveSeguridad.Focus();
                        }
                        else {

                            //MODIFICAMOS
                            DSMarket.Logica.Comunes.ProcesarInformacion.Empresa.ProcesarInformacionBancos Modificar = new Logica.Comunes.ProcesarInformacion.Empresa.ProcesarInformacionBancos(
                       VariablesGlobales.IdMantenimeinto,
                       Convert.ToInt32(txtCuenta.Text),
                       Convert.ToInt32(txtAuxiliar.Text),
                       txtBanco.Text,
                       cbEstatus.Checked,
                       VariablesGlobales.IdUsuario,
                       "UPDATE");
                            Modificar.ProcesarInformacion();
                            MessageBox.Show("Registro modificado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CerrarPantalla();
                        }
                    }
                
                }
            }
        }
    }
}
