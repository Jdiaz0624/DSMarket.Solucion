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
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();
        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Seguridad.UsuariosConsulta Consulta = new UsuariosConsulta();
            Consulta.ShowDialog();
        }

        private void UsuariosMantenimiento_Load(object sender, EventArgs e)
        {
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
    }
}
