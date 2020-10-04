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
    public partial class DepartamentosMantenimiento : Form
    {
        public DepartamentosMantenimiento()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaEmpresa.LogicaEmpresa> ObjData = new Lazy<Logica.Logica.LogicaEmpresa.LogicaEmpresa>();
        Lazy<DSMarket.Logica.Logica.LogicaSeguridad.LogicaSeguridad> ObjDayaSeguridad = new Lazy<Logica.Logica.LogicaSeguridad.LogicaSeguridad>();

        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        private void LimpiarControles() {
            txtDepartamento.Text = string.Empty;
            cbEstatus.Checked = true;
        }
        private void CerarPantalla() {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.DepartamentosConsulta Consulta = new DepartamentosConsulta();
            Consulta.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Consulta.ShowDialog();
        }
        #region MANTENIMIENTO DE DEPARTAMENTOS
        private void MANDepartamentos() {

            DSMarket.Logica.Comunes.ProcesarInformacion.ProcesarInformacionDepartamentos Procesar = new Logica.Comunes.ProcesarInformacion.ProcesarInformacionDepartamentos(
                VariablesGlobales.IdMantenimeinto,
                txtDepartamento.Text,
                cbEstatus.Checked,
                VariablesGlobales.IdUsuario,
                DateTime.Now,
                VariablesGlobales.IdUsuario,
                DateTime.Now,
                VariablesGlobales.Accion);
            Procesar.ProcesarInformacion();

            if (VariablesGlobales.Accion == "INSERT") {
                MessageBox.Show("Registro guardado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (MessageBox.Show("¿Quieres guardar otro registro", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    LimpiarControles();
                }
                else {
                    CerarPantalla();
                }
            }
            else {
                MessageBox.Show("Registro modificado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                CerarPantalla();
            }
        }
        #endregion
        private void DepartamentosMantenimiento_Load(object sender, EventArgs e)
        {
            lbTitulo.ForeColor = Color.WhiteSmoke;
            this.BackColor = SystemColors.Control;
            txtDepartamento.BackColor = Color.WhiteSmoke;
            txtClaveSeguridad.BackColor = Color.WhiteSmoke;
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            cbEstatus.Checked = true;

            if (VariablesGlobales.Accion == "INSERT")
            {
                lbTitulo.Text = "CREAR NUEVO REGISTRO";
                lbclaveSeguridad.Visible = false;
                txtClaveSeguridad.Visible = false;
                btnGuardar.Text = "Guardar registro";
            }
            else if (VariablesGlobales.Accion == "UPDATE")
            {
                lbTitulo.Text = "MODIFICAR REGISTRO SELECCIONADO";
                lbclaveSeguridad.Visible = true;
                txtClaveSeguridad.Visible = true;
                txtClaveSeguridad.PasswordChar = '•';
                btnGuardar.Text = "Modificar registro";
            }

            if (VariablesGlobales.Accion != "INSERT") {

                lbclaveSeguridad.Visible = true;
                txtClaveSeguridad.Visible = true;

                var SacarDatos = ObjData.Value.BuscaDepartamentos(VariablesGlobales.IdMantenimeinto, null, 1, 1);
                foreach (var n in SacarDatos) {
                    txtDepartamento.Text = n.Departamento;
                    cbEstatus.Checked = (n.Estatus0.HasValue ? n.Estatus0.Value : false);
                }
            }
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            CerarPantalla();
        }

        private void DepartamentosMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
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
            if (VariablesGlobales.Accion != "INSERT") {
                //VALIDAMOS LA CLAVE DE SEGURIDAD
                if (string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()))
                {
                    MessageBox.Show("Favor de ingresar la clave de seguridad para modificar este registro", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else {
                    string _Claveseguridad = string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()) ? null : txtClaveSeguridad.Text.Trim();

                    var Validar = ObjDayaSeguridad.Value.BuscaClaveSeguridad(
                        new Nullable<decimal>(),
                        null,
                        DSMarket.Logica.Comunes.SeguridadEncriptacion.Encriptar(_Claveseguridad),
                        1, 1);
                    if (Validar.Count() < 1) {
                        MessageBox.Show("La clave de seguridad ingresada no es valida, favor de vericicar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtClaveSeguridad.Text = string.Empty;
                    }
                    else {
                        MANDepartamentos();
                    }
                }
            }
            else {
                MANDepartamentos();
            }
        }
    }
}
