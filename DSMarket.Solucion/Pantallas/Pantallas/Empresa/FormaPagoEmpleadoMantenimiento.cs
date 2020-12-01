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
    public partial class FormaPagoEmpleadoMantenimiento : Form
    {
        Lazy<DSMarket.Logica.Logica.LogicaEmpresa.LogicaEmpresa> ObjDataEmpresa = new Lazy<Logica.Logica.LogicaEmpresa.LogicaEmpresa>();
        Lazy<DSMarket.Logica.Logica.LogicaSeguridad.LogicaSeguridad> ObjDataSegurdad = new Lazy<Logica.Logica.LogicaSeguridad.LogicaSeguridad>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region CERRAR Y LIMPIAR PANTALLA
        private void CerrarPantalla() {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.FormaPagoEmpleadoConsulta Consulta = new FormaPagoEmpleadoConsulta();
            Consulta.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Consulta.ShowDialog();
        }
        private void LimpiarPantalla() {
            txtFormaPago.Text = string.Empty;
            cbEstatus.Checked = true;
        }
        #endregion

        #region MANTENIMIENTO DE FORMA DE PAGO
        private void MANFormaPago() {
            DSMarket.Logica.Comunes.ProcesarInformacion.Empresa.ProcesarInformacionFormaPagoEmpleado Prcesar = new Logica.Comunes.ProcesarInformacion.Empresa.ProcesarInformacionFormaPagoEmpleado(
                VariablesGlobales.IdMantenimeinto,
                txtFormaPago.Text,
                cbEstatus.Checked,
                VariablesGlobales.IdUsuario,
                VariablesGlobales.Accion);
            Prcesar.ProcesarFormaPago();
            if (VariablesGlobales.Accion == "INSERT") {
                MessageBox.Show("Registro guardado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (MessageBox.Show("¿Quieres agregar otro registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    LimpiarPantalla();
                }
                else {
                    CerrarPantalla();
                }
            }
            else {
                MessageBox.Show("Registro guardado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                CerrarPantalla();
            }
        }
        #endregion
        public FormaPagoEmpleadoMantenimiento()
        {
            InitializeComponent();
        }

        private void FormaPagoEmpleadoMantenimiento_Load(object sender, EventArgs e)
        {
            lbTitulo.ForeColor = Color.White;
            lbTitulo.Text = "Forma de Pago Mantenimiento";
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            cbEstatus.Checked = true;

            if (VariablesGlobales.Accion != "INSERT") {
                btnGuardar.Text = "Modificar";
                lbclaveSeguridad.Visible = true;
                txtClaveSeguridad.Visible = true;
                txtClaveSeguridad.PasswordChar = '•';
                var SacarInformacion = ObjDataEmpresa.Value.BuscaFormaPagoEmpleado(
                    VariablesGlobales.IdMantenimeinto,
                    null, 1, 1);
                foreach (var n in SacarInformacion) {
                    txtFormaPago.Text = n.FormaPago;
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

        private void FormaPagoEmpleadoMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason) {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFormaPago.Text.Trim())) {
                MessageBox.Show("El campo forma de pago no puede estar vacio, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFormaPago.Focus();
            }
            else {
                if (VariablesGlobales.Accion == "INSERT") {
                    MANFormaPago();
                }
                else {
                    if (string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()))
                    {
                        MessageBox.Show("El campo clave de seguridad no puede estar vacio, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtClaveSeguridad.Focus();
                    }
                    else {
                        string _ClaveSeguridad = string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()) ? null : txtClaveSeguridad.Text.Trim();

                        var Validar = ObjDataSegurdad.Value.BuscaClaveSeguridad(
                            new Nullable<decimal>(),
                            null,
                            DSMarket.Logica.Comunes.SeguridadEncriptacion.Encriptar(_ClaveSeguridad), 1, 1);
                        if (Validar.Count() < 1)
                        {
                            MessageBox.Show("La clave de seguridad no es valida, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtClaveSeguridad.Text = string.Empty;
                            txtClaveSeguridad.Focus();
                        }
                        else {
                            MANFormaPago();
                        }
                    }
                }
            }
        }
    }
}
