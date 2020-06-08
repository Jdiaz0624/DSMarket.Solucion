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
    public partial class ClientesMantenimiento : Form
    {
        public ClientesMantenimiento()
        {
            InitializeComponent();
        }
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();


        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.ClientesConsulta Consulta = new ClientesConsulta();
            Consulta.ShowDialog();
        }

        private void ClientesMantenimiento_Load(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
            lbTitulo.ForeColor = Color.White;
            txtapellidoCliente.BackColor = Color.WhiteSmoke;
            txtClaveSeguridad.BackColor = Color.WhiteSmoke;
            txtComentario.BackColor = Color.WhiteSmoke;
            txtDireccion.BackColor = Color.WhiteSmoke;
            txtEmail.BackColor = Color.WhiteSmoke;
            txtLimiteCredito.BackColor = Color.WhiteSmoke;
            txtNombreCliente.BackColor = Color.WhiteSmoke;
            txtNumeroidentificacionCliente.BackColor = Color.WhiteSmoke;
            txtSegundoTelefono.BackColor = Color.WhiteSmoke;
            txtTelefono.BackColor = Color.WhiteSmoke;
            txtTipoidentificcionCliente.BackColor = Color.WhiteSmoke;

            txtapellidoCliente.ForeColor = Color.Black;
            txtClaveSeguridad.ForeColor = Color.Black;
            txtComentario.ForeColor = Color.Black;
            txtDireccion.ForeColor = Color.Black;
            txtEmail.ForeColor = Color.Black;
            txtLimiteCredito.ForeColor = Color.Black;
            txtNombreCliente.ForeColor = Color.Black;
            txtNumeroidentificacionCliente.ForeColor = Color.Black;
            txtSegundoTelefono.ForeColor = Color.Black;
            txtTelefono.ForeColor = Color.Black;
            txtTipoidentificcionCliente.ForeColor = Color.Black;

            if (VariablesGlobales.Accion == "INSERT")
            {
                lbTitulo.Text = "CREAR NUEVO REGISTRO";
                btnGuardar.Text = "Guardar registro";
                lbClaveSeguridad.Visible = false;
                txtClaveSeguridad.Visible = false;
                cbEnvioEmail.Checked = true;
            }
            else if (VariablesGlobales.Accion == "UPDATE")
            {
                lbTitulo.Text = "CREAR NUEVO REGISTRO";
                btnGuardar.Text = "Modificar Registro seleccionado";
                lbClaveSeguridad.Visible = false;
                txtClaveSeguridad.Visible = true;
                cbEnvioEmail.Checked = true;
                lbClaveSeguridad.Visible = true;
                txtClaveSeguridad.PasswordChar = '•';
            }
            else if (VariablesGlobales.Accion == "DELETE")
            {
                lbTitulo.Text = "CREAR NUEVO REGISTRO";
                btnGuardar.Text = "Eliminar Registro seleccionado";
                lbClaveSeguridad.Visible = false;
                txtClaveSeguridad.Visible = true;
                cbEnvioEmail.Checked = true;
                lbClaveSeguridad.Visible = true;
                txtClaveSeguridad.PasswordChar = '•';
            }
        }
    }
}
