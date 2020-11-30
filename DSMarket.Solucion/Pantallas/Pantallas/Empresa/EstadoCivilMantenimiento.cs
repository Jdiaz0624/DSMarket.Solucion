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
    public partial class EstadoCivilMantenimiento : Form
    {
        Lazy<DSMarket.Logica.Logica.LogicaEmpresa.LogicaEmpresa> ObjDataEmpresa = new Lazy<Logica.Logica.LogicaEmpresa.LogicaEmpresa>();
        Lazy<DSMarket.Logica.Logica.LogicaSeguridad.LogicaSeguridad> ObjDataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad.LogicaSeguridad>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region LIMPIAR Y CERRAR PANTALLA
        private void LimpiarPantalla() {
            txtEstadoCivil.Text = string.Empty;
            cbEstatus.Checked = true;
        }
        private void CerrarPantalla() {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.EstadoCivilConsulta Consulta = new EstadoCivilConsulta();
            Consulta.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Consulta.ShowDialog();
        }
        #endregion

        #region MANTENIMIENTO DE ESTADO CIVIL
        private void MANEstadoCivil() {
            DSMarket.Logica.Comunes.ProcesarInformacion.Empresa.ProcesarInformacionEstadoCivil Procesar = new Logica.Comunes.ProcesarInformacion.Empresa.ProcesarInformacionEstadoCivil(
                VariablesGlobales.IdMantenimeinto,
                txtEstadoCivil.Text,
                cbEstatus.Checked,
                VariablesGlobales.IdUsuario,
                VariablesGlobales.Accion);
            Procesar.ProcesarEstadoCivil();
            if (VariablesGlobales.Accion == "INSERT") {
                MessageBox.Show("Registro guardado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (MessageBox.Show("¿Quieres guardar otro registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    LimpiarPantalla();
                }
                else {
                    CerrarPantalla();
                }
            }
            else {
                MessageBox.Show("Registro modificado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                CerrarPantalla();
            }
        }
        #endregion
        public EstadoCivilMantenimiento()
        {
            InitializeComponent();
        }

        private void EstadoCivilMantenimiento_Load(object sender, EventArgs e)
        {
            cbEstatus.Checked = true;
            lbTitulo.ForeColor = Color.White;
            lbTitulo.Text = "Mantenimiento de Estado Civil";
            txtClaveSeguridad.PasswordChar = '•';
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            if (VariablesGlobales.Accion != "INSERT")
            {
                lbclaveSeguridad.Visible = true;
                txtClaveSeguridad.Visible = true;
                btnGuardar.Text = "Modificar";

                var SacarInformacion = ObjDataEmpresa.Value.BuscaEstadiCivil(
                    VariablesGlobales.IdMantenimeinto,
                    null, 1, 1);
                foreach (var n in SacarInformacion)
                {
                    txtEstadoCivil.Text = n.EstadoCivil;
                    cbEstatus.Checked = (n.Estatus0.HasValue ? n.Estatus0.Value : false);
                }
            }
            else {
                btnGuardar.Text = "Guardar";
                    
            }

        }

        private void EstadoCivilMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason) {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            CerrarPantalla();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEstadoCivil.Text.Trim()))
            {
                MessageBox.Show("El campo estado civil no puede estar vacio, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEstadoCivil.Focus();
            }
            else {
                if (VariablesGlobales.Accion == "INSERT") {
                    MANEstadoCivil();
                }
                else {
                    if (string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim())) {
                        MessageBox.Show("El campo clave de seguridad no puede estar vacio, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtClaveSeguridad.Focus();
                    }
                    else {
                        string _ClaveSeguridad = string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()) ? null : txtClaveSeguridad.Text.Trim();

                        var ValidarClave = ObjDataSeguridad.Value.BuscaClaveSeguridad(
                            new Nullable<decimal>(),
                            null,
                            DSMarket.Logica.Comunes.SeguridadEncriptacion.Encriptar(_ClaveSeguridad), 1, 1);
                        if (ValidarClave.Count() < 1)
                        {
                            MessageBox.Show("La clave de seguridad ingresada no es valida, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtClaveSeguridad.Focus();
                        }
                        else {
                            MANEstadoCivil();
                        }

                    }
                }
            }
        }
    }
}
