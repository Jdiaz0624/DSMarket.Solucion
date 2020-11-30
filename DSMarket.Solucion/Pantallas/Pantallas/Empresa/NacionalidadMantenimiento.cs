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
    public partial class NacionalidadMantenimiento : Form
    {
        Lazy<DSMarket.Logica.Logica.LogicaEmpresa.LogicaEmpresa> ObjDataEmpresa = new Lazy<Logica.Logica.LogicaEmpresa.LogicaEmpresa>();
        Lazy<DSMarket.Logica.Logica.LogicaSeguridad.LogicaSeguridad> ObjDataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad.LogicaSeguridad>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region CERRAR PANTALLA Y LIMPIAR CONTROLES
        private void LimpiarControles() {
            txtNacionalidad.Text = string.Empty;
            cbEstatus.Checked = true;
        }
        private void CerrarPantalla() {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.NacionalidadConsulta Consulta = new NacionalidadConsulta();
            Consulta.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Consulta.ShowDialog();
        }
        #endregion

        #region MANTENIMIENTO DE NACIONALIDAD
        private void MANNacionalidad() {
            DSMarket.Logica.Comunes.ProcesarInformacion.Empresa.ProcesarInformacionNacionalidad Procesar = new Logica.Comunes.ProcesarInformacion.Empresa.ProcesarInformacionNacionalidad(
                VariablesGlobales.IdMantenimeinto,
                txtNacionalidad.Text,
                cbEstatus.Checked,
                VariablesGlobales.IdUsuario,
                VariablesGlobales.Accion);
            Procesar.ProcesarNacionalidad();
            if (VariablesGlobales.Accion == "INSERT") {
                MessageBox.Show("Registro guardado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (MessageBox.Show("¿Quieres agregar otro registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    LimpiarControles();
                }
                else {
                    CerrarPantalla();
                }
            } else {
                MessageBox.Show("Registro modificado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                CerrarPantalla();
            }
        }
        #endregion
        public NacionalidadMantenimiento()
        {
            InitializeComponent();
        }

        private void NacionalidadMantenimiento_Load(object sender, EventArgs e)
        {
            lbTitulo.ForeColor = Color.White;
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            lbTitulo.Text = "Mantenimiento de Nacionalidad";
            txtClaveSeguridad.PasswordChar = '•';
            cbEstatus.Checked = true;
            if (VariablesGlobales.Accion != "INSERT")
            {
                lbclaveSeguridad.Visible = true;
                txtClaveSeguridad.Visible = true;
                btnGuardar.Text = "Modificar";

                var SacarInformacion = ObjDataEmpresa.Value.BuscaNacionalidad(
                    VariablesGlobales.IdMantenimeinto,
                    null, 1, 1);
                foreach (var n in SacarInformacion)
                {
                    txtNacionalidad.Text = n.Nacionalidad;
                    cbEstatus.Checked = (n.Estatus0.HasValue ? n.Estatus0.Value : false);
                }
            }
            else {
                btnGuardar.Text = "Guardar";
            }
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            CerrarPantalla();
        }

        private void NacionalidadMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason) {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNacionalidad.Text.Trim())) {
                MessageBox.Show("El campo nacionalidad no puede estar vacio, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNacionalidad.Focus();
            }
            else {
                if (VariablesGlobales.Accion == "INSERT") {
                    MANNacionalidad();
                } else {
                    if (string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()))
                    {
                        MessageBox.Show("El campo clave de seguridad no puede estar vacio, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtClaveSeguridad.Focus();
                    }
                    else {
                        string _Clave = string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()) ? null : txtClaveSeguridad.Text.Trim();

                        var ValidarClave = ObjDataSeguridad.Value.BuscaClaveSeguridad(
                            new Nullable<decimal>(),
                            null,
                            DSMarket.Logica.Comunes.SeguridadEncriptacion.Encriptar(_Clave), 1, 1);
                        if (ValidarClave.Count() < 1) {
                            MessageBox.Show("La clave de seguridad ingresada no es valida, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtClaveSeguridad.Text = string.Empty;
                            txtClaveSeguridad.Focus();
                        }
                        else {
                            MANNacionalidad();
                            
                        }
                    }
                }
            }
        }
    }
}
