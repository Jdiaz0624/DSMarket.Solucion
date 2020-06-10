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
    public partial class NominaMantenimiento : Form
    {
        public NominaMantenimiento()
        {
            InitializeComponent();
        }
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();
        private void NominaMantenimiento_Load(object sender, EventArgs e)
        {
            lbTitulo.ForeColor = Color.WhiteSmoke;
            this.BackColor = SystemColors.Control;

            txtApellido.BackColor = Color.WhiteSmoke;
            txtClaveSeguridad.BackColor = Color.WhiteSmoke;
            txtComentario.BackColor = Color.WhiteSmoke;
            txtDireccion.BackColor = Color.WhiteSmoke;
            txtEmail.BackColor = Color.WhiteSmoke;
            txtFechaIngreso.BackColor = Color.WhiteSmoke;
            txtNombre.BackColor = Color.WhiteSmoke;
            txtNumeroCuenta.BackColor = Color.WhiteSmoke;
            txtNumeroidentificacion.BackColor = Color.WhiteSmoke;
            txtPorcientoComisionServicio.BackColor = Color.WhiteSmoke;
            txtPorcientoComisionVentas.BackColor = Color.WhiteSmoke;
            txtSalarioMensual.BackColor = Color.WhiteSmoke;
            txtTelefono.BackColor = Color.WhiteSmoke;
            txtTelefono2.BackColor = Color.WhiteSmoke;
            ddlSeleccioanrDepartamentos.BackColor = Color.WhiteSmoke;
            ddlSeleccionarBanco.BackColor = Color.WhiteSmoke;
            ddlSeleccionarCargos.BackColor = Color.WhiteSmoke;
            ddlSeleccionarEstadiCivil.BackColor = Color.WhiteSmoke;
            ddlSeleccionarSexo.BackColor = Color.WhiteSmoke;
            ddlSeleccionartipoCuenta.BackColor = Color.WhiteSmoke;
            ddlSeleccionarTipoEmpleado.BackColor = Color.WhiteSmoke;
            ddlSeleccionarTipoIdentificacion.BackColor = Color.WhiteSmoke;
            ddlSeleccionarTipoNomina.BackColor = Color.WhiteSmoke;

            if (VariablesGlobales.Accion == "INSERT")
            {
                lbTitulo.Text = "CREAR NUEVO REGISTRO";
                lbclaveSeguridad.Visible = false;
                txtClaveSeguridad.Visible = false;
                btnGuardar.Text = "Guardar registro";
            }
            else if (VariablesGlobales.Accion == "UPDATE")
            {
                lbTitulo.Text = "MODIFICAR REGISTRPO";
                lbclaveSeguridad.Visible = true;
                txtClaveSeguridad.Visible = true;
                txtClaveSeguridad.PasswordChar = '•';
                btnGuardar.Text = "Modificar registro";
            }
            else
            {
                lbTitulo.Text = "CANCELACION DE EMPLEADO";
                lbclaveSeguridad.Visible = true;
                txtClaveSeguridad.Visible = true;
                txtClaveSeguridad.PasswordChar = '•';
                btnGuardar.Text = "Procesar registro";

                txtApellido.Enabled = false;
              //  txtClaveSeguridad.Enabled = false;
                txtComentario.Enabled = false;
                txtDireccion.Enabled = false;
                txtEmail.Enabled = false;
                txtFechaIngreso.Enabled = false;
                txtNombre.Enabled = false;
                txtNumeroCuenta.Enabled = false;
                txtNumeroidentificacion.Enabled = false;
                txtPorcientoComisionServicio.Enabled = false;
                txtPorcientoComisionVentas.Enabled = false;
                txtSalarioMensual.Enabled = false;
                txtTelefono.Enabled = false;
                txtTelefono2.Enabled = false;
                ddlSeleccioanrDepartamentos.Enabled = false;
                ddlSeleccionarBanco.Enabled = false;
                ddlSeleccionarCargos.Enabled = false;
                ddlSeleccionarEstadiCivil.Enabled = false;
                ddlSeleccionarSexo.Enabled = false;
                ddlSeleccionartipoCuenta.Enabled = false;
                ddlSeleccionarTipoEmpleado.Enabled = false;
                ddlSeleccionarTipoIdentificacion.Enabled = false;
                ddlSeleccionarTipoNomina.Enabled = false;
                cbComisionVentas.Enabled = false;
                cbComisionServicio.Enabled = false;
                rbActivo.Enabled = false;
                rbInactivo.Enabled = false;
                rbCancelado.Enabled = false;
            }
            
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.NominaConsulta Consulta = new NominaConsulta();
            Consulta.ShowDialog();
        }
    }
}
