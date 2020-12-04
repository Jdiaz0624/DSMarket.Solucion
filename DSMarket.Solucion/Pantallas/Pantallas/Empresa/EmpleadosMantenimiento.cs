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
    public partial class EmpleadosMantenimiento : Form
    {
        Lazy<DSMarket.Logica.Logica.LogicaEmpresa.LogicaEmpresa> ObjDataEmpresa = new Lazy<Logica.Logica.LogicaEmpresa.LogicaEmpresa>();
        Lazy<DSMarket.Logica.Logica.LogicaSeguridad.LogicaSeguridad> ObjDataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad.LogicaSeguridad>();
        Lazy<DSMarket.Logica.Logica.LogicaListas.LogicaListas> ObjDataListas = new Lazy<Logica.Logica.LogicaListas.LogicaListas>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region CERRAR Y LIMPIAR PANTALLA
        private void CerrarPantalla() {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.EmpleadosConsulta Consulta = new EmpleadosConsulta();
            Consulta.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Consulta.ShowDialog();
        }
        private void LimpiarPantalla() {
            CargarListas();
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtNumeroidentificacion.Text = string.Empty;
            txtNSS.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtTelefono1.Text = string.Empty;
            txtTelefono2.Text = string.Empty;
            txtSueldo.Text = string.Empty;
            txtOtrosIngresos.Text = string.Empty;
            txtComisionVentas.Text = string.Empty;
            txtComisionServicios.Text = string.Empty;
            cbEstatus.Checked = true;
            cbAplicaComision.Checked = false;
        }
        #endregion
        #region CARGAR LAS LISTAS DESPLEGABLES
        private void CargarListas() {
            CargarListaTipoIdentificacion();
            CargarListasNacionalidad();
            CargarListasTipoEmpleado();
            CargarListasTipoNomina();
            CargarListasDepartamentos();
            CargarListasCargos();
            CargarListasEstadoCivil();
            CargarListasFormaPago();
        }
        private void CargarListaTipoIdentificacion() {
            var TipoIdentificacion = ObjDataListas.Value.BuscaTipoIdentificacion();
            ddlTipoidentificacion.DataSource = TipoIdentificacion;
            ddlTipoidentificacion.DisplayMember = "TipoIdentificacion";
            ddlTipoidentificacion.ValueMember = "IdTipoIdentificacion";

        }
        private void CargarListasNacionalidad() {
            var Nacionalidad = ObjDataListas.Value.ListadoNacionalidad();
            ddlNacionalidad.DataSource = Nacionalidad;
            ddlNacionalidad.DisplayMember = "TipoIdentificacion";
            ddlNacionalidad.ValueMember = "IdNacionalidad";
        }
        private void CargarListasTipoEmpleado() {
            var TipoEmpleado = ObjDataListas.Value.ListadoTipoEmpleado();
            ddlTipoEmpleado.DataSource = TipoEmpleado;
            ddlTipoEmpleado.DisplayMember = "TipoEmpleado";
            ddlTipoEmpleado.ValueMember = "IdTipoEmpleado";
        }
        private void CargarListasTipoNomina() {
            var TipoNomina = ObjDataListas.Value.ListadoTipoNomina();
            txtTipoNomina.DataSource = TipoNomina;
            txtTipoNomina.DisplayMember = "TipoEmpleado";
            txtTipoNomina.ValueMember = "IdTipoNomina";

        }
        private void CargarListasDepartamentos() {
            var Departamentos = ObjDataListas.Value.ListadoDepartamentos();
            ddlDepartamento.DataSource = Departamentos;
            ddlDepartamento.DisplayMember = "Departamento";
            ddlDepartamento.ValueMember = "IdDepartamento";
        }
        private void CargarListasCargos() {
            try {
                var Cargos = ObjDataListas.Value.ListadoCargos(Convert.ToDecimal(ddlDepartamento.SelectedValue));
                ddlCargo.DataSource = Cargos;
                ddlCargo.DisplayMember = "Cargo";
                ddlCargo.ValueMember = "IdCargo";
            }
            catch (Exception) { }
        }
        private void CargarListasEstadoCivil() {
            var EstadiVicil = ObjDataListas.Value.ListadoEstadoCivil();
            ddlEstadoCivil.DataSource = EstadiVicil;
            ddlEstadoCivil.DisplayMember = "EstadoCivil";
            ddlEstadoCivil.ValueMember = "IdEstadoCivil";
        }
        private void CargarListasFormaPago() {
            var FormaPago = ObjDataListas.Value.ListadoFormaPago();
            ddlFormaPago.DataSource = FormaPago;
            ddlFormaPago.DisplayMember = "FormaPago";
            ddlFormaPago.ValueMember = "IdFormaPagoEmpleado";
        }
        #endregion
        #region MANTENIMIENTO DE EMPLEADOS
        private void MANEmpleados() {
            DSMarket.Logica.Comunes.ProcesarInformacion.Empresa.ProcesarInformacionEmpleado Procesar = new Logica.Comunes.ProcesarInformacion.Empresa.ProcesarInformacionEmpleado(
                VariablesGlobales.IdMantenimeinto,
                txtNombre.Text,
                txtApellido.Text,
                Convert.ToDecimal(ddlTipoidentificacion.SelectedValue),
                txtNumeroidentificacion.Text,
                Convert.ToDecimal(ddlNacionalidad.SelectedValue),
                txtNSS.Text,
                txtDireccion.Text,
                Convert.ToDecimal(ddlTipoEmpleado.SelectedValue),
                Convert.ToDecimal(txtTipoNomina.SelectedValue),
                Convert.ToDecimal(ddlDepartamento.SelectedValue),
                Convert.ToDecimal(ddlCargo.SelectedValue),
                txtTelefono1.Text,
                txtTelefono2.Text,
                txtEmail.Text,
                Convert.ToDecimal(ddlEstadoCivil.SelectedValue),
                Convert.ToDecimal(txtSueldo.Text),
                Convert.ToDecimal(txtOtrosIngresos.Text),
                Convert.ToDecimal(ddlFormaPago.SelectedValue),
                Convert.ToDateTime(txtFechaIngreso.Text),
                Convert.ToDateTime(txtFechaNacimiento.Text),
                cbEstatus.Checked,
                cbAplicaComision.Checked,
                Convert.ToDecimal(txtComisionVentas.Text),
                Convert.ToDecimal(txtComisionServicios.Text),
                VariablesGlobales.Accion);
            Procesar.ProcesarEmpleado();

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
        #region VALIDAR CAMPOS NUMERICOS
        /// <summary>
        /// Este me metodo es agregar un cero en los campos otros ingresos,
        /// Comision por venta y Comision por servicio en caso de que estan vacios.
        /// </summary>
        private void ValidarCmaposNumericos() {
            if (string.IsNullOrEmpty(txtOtrosIngresos.Text.Trim())) { txtOtrosIngresos.Text = "0"; }
            if (string.IsNullOrEmpty(txtComisionVentas.Text.Trim())) { txtComisionVentas.Text = "0"; }
            if (string.IsNullOrEmpty(txtComisionServicios.Text.Trim())) { txtComisionServicios.Text = "0"; }
        }
        #endregion
        public EmpleadosMantenimiento()
        {
            InitializeComponent();
        }

        private void EmpleadosMantenimiento_Load(object sender, EventArgs e)
        {
            CargarListas();
            cbAplicaComision.Checked = false;
            lbTitulo.ForeColor = Color.White;
            lbTitulo.Text = "Empleados Mantenimiento";
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            cbEstatus.Checked = true;
            if (VariablesGlobales.Accion != "INSERT") {
                btnGuardar.Text = "Modificar";

                var SacarInformacion = ObjDataEmpresa.Value.BuscaEmpleados(
                    VariablesGlobales.IdMantenimeinto,
                    null, null, null, null, null, null, 1, 1);
                foreach (var n in SacarInformacion) {
                    txtNombre.Text = n.Nombre;
                    txtApellido.Text = n.Apellido;
                    ddlTipoidentificacion.Text = n.TipoIdentificacion;
                    txtNumeroidentificacion.Text = n.NumeroIdentificacion;
                    ddlNacionalidad.Text = n.Nacionalidad;
                    txtNSS.Text = n.NSS;
                    txtDireccion.Text = n.Direccion;
                    ddlTipoEmpleado.Text = n.TipoEmpleado;
                    txtTipoNomina.Text = n.TipoNomina;
                    ddlDepartamento.Text = n.Departamento;
                    ddlCargo.Text = n.Cargo;
                    txtEmail.Text = n.Email;
                    txtTelefono1.Text = n.Telefono1;
                    txtTelefono2.Text = n.Telefono2;
                    ddlEstadoCivil.Text = n.EstadoCivil;
                    ddlFormaPago.Text = n.FormaPago;
                    txtSueldo.Text = n.Sueldo.ToString();
                    txtOtrosIngresos.Text = n.OtrosIngresos.ToString();
                    txtFechaIngreso.Text = n.FechaIngreso0.ToString();
                    txtFechaNacimiento.Text = n.FechaNacimiento0.ToString();
                    txtComisionVentas.Text = n.PorcientoCOmisionVentas.ToString();
                    txtComisionServicios.Text = n.PorcientoComsiionServicio.ToString();
                    cbEstatus.Checked = (n.Estatus0.HasValue ? n.Estatus0.Value : false);
                    cbAplicaComision.Checked = (n.AplicaParaComision0.HasValue ? n.AplicaParaComision0.Value : false);
                    lbClaveSeguridad.Visible = true;
                    txtClaveSeguridad.Visible = true;
                    txtClaveSeguridad.PasswordChar = '•';
                }
            }
            else {
                btnGuardar.Text = "Guardar";
            }
        }

        private void TxtComisionServicios_KeyPress(object sender, KeyPressEventArgs e)
        {
            DSMarket.Logica.Comunes.ValidarControles.SoloNumerosDecimales(e);
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            CerrarPantalla();
        }

        private void EmpleadosMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason) {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try {
                if (string.IsNullOrEmpty(txtNombre.Text.Trim()) ||
               string.IsNullOrEmpty(txtApellido.Text.Trim()) ||
               string.IsNullOrEmpty(ddlTipoidentificacion.Text.Trim()) ||
               string.IsNullOrEmpty(txtNumeroidentificacion.Text.Trim()) ||
               string.IsNullOrEmpty(ddlNacionalidad.Text.Trim()) ||
               string.IsNullOrEmpty(ddlTipoEmpleado.Text.Trim()) ||
               string.IsNullOrEmpty(ddlDepartamento.Text.Trim()) ||
               string.IsNullOrEmpty(ddlCargo.Text.Trim()) ||
               string.IsNullOrEmpty(txtTelefono1.Text.Trim()) ||
               string.IsNullOrEmpty(ddlEstadoCivil.Text.Trim()) ||
               string.IsNullOrEmpty(ddlFormaPago.Text.Trim()) ||
               string.IsNullOrEmpty(txtSueldo.Text.Trim()) ||
               string.IsNullOrEmpty(ddlFormaPago.Text.Trim()) ||
               string.IsNullOrEmpty(txtFechaIngreso.Text.Trim()) ||
               string.IsNullOrEmpty(txtFechaNacimiento.Text.Trim()))
                {
                    MessageBox.Show("Has dejado campos vacios que son encesarios para realizar esta operación, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (VariablesGlobales.Accion == "INSERT")
                    {

                        ValidarCmaposNumericos();
                        MANEmpleados();
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()))
                        {
                            MessageBox.Show("El campo clave de seguridad no puede estar vacio, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtClaveSeguridad.Focus();
                        }
                        else
                        {
                            string _ClaveSeguridad = string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()) ? null : txtClaveSeguridad.Text.Trim();

                            var Validar = ObjDataSeguridad.Value.BuscaClaveSeguridad(
                                new Nullable<decimal>(),
                                null,
                                DSMarket.Logica.Comunes.SeguridadEncriptacion.Encriptar(_ClaveSeguridad),
                                1, 1);
                            if (Validar.Count() < 1)
                            {
                                MessageBox.Show("La clave de seguridad ingresada no es valida, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txtClaveSeguridad.Text = string.Empty;
                                txtClaveSeguridad.Focus();
                            }
                            else
                            {
                                ValidarCmaposNumericos();
                                MANEmpleados();
                            }
                        }
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Error al realizar el mantenimiento por la siguiente razon: "+ ex.Message,VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DdlDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarListasCargos();
        }

        private void cbAplicaComision_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAplicaComision.Checked == true) {
                txtComisionVentas.Enabled = true;
                txtComisionServicios.Enabled = true;
                txtComisionVentas.Text = "0";
                txtComisionServicios.Text = "0";
            }
            else {
                txtComisionVentas.Enabled = false;
                txtComisionServicios.Enabled = false;
                txtComisionVentas.Text = "0";
                txtComisionServicios.Text = "0";
            }
        }
    }
}
