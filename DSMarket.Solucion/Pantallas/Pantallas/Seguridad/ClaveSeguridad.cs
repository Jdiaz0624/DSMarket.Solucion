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
    public partial class ClaveSeguridad : Form
    {
        public ClaveSeguridad()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaListas.LogicaListas> ObjdataListas = new Lazy<Logica.Logica.LogicaListas.LogicaListas>();
        Lazy<DSMarket.Logica.Logica.LogicaSeguridad.LogicaSeguridad> ObjdataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad.LogicaSeguridad>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        private void MostrarListadoUsuarios() {
            var Listado = ObjdataListas.Value.ListaUsuarios();
            ddlSeleccionarUsuario.DataSource = Listado;
            ddlSeleccionarUsuario.DisplayMember = "Persona";
            ddlSeleccionarUsuario.ValueMember = "IdUsuario";
         
        }

        private void ClavesRegistradas() {
            var ClaveRegistradas = ObjdataSeguridad.Value.BuscaClaveSeguridad(
                new Nullable<decimal>(),
                Convert.ToDecimal(ddlSeleccionarUsuario.SelectedValue),
                null, 1, 100);
            dtListado.DataSource = ClaveRegistradas;
            this.dtListado.Columns["IdClaveSeguridad"].Visible = false;
            this.dtListado.Columns["IdUsuario"].Visible = false;
            this.dtListado.Columns["Estatus0"].Visible = false;
        }
        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ClaveSeguridad_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void ClaveSeguridad_Load(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
            lbTitulo.ForeColor = Color.WhiteSmoke;
            lbTitulo.Text = "MANTENIMIENTO DE CLAVE DE SEGURIDAD";
            lbCantidadRegistrosVariable.ForeColor = Color.WhiteSmoke;
            lbCantidadRegistrosTitulo.ForeColor = Color.WhiteSmoke;
            txtClave.BackColor = Color.WhiteSmoke;
            txtClaveSeguridad.BackColor = Color.WhiteSmoke;
            txtConfirmarClave.BackColor = Color.WhiteSmoke;
            txtNumeroPagina.BackColor = Color.WhiteSmoke;
            txtNumeroRegistros.BackColor = Color.WhiteSmoke;
            ddlSeleccionarUsuario.BackColor = Color.WhiteSmoke;

            txtClave.ForeColor = Color.Black;
            txtClaveSeguridad.ForeColor = Color.Black;
            txtConfirmarClave.ForeColor = Color.Black;
            txtNumeroPagina.ForeColor = Color.Black;
            txtNumeroRegistros.ForeColor = Color.Black;
            ddlSeleccionarUsuario.ForeColor = Color.Black;



            dtListado.BackgroundColor = SystemColors.Control;

            txtClave.PasswordChar = '•';
            txtClaveSeguridad.PasswordChar = '•';
            txtConfirmarClave.PasswordChar = '•';

            MostrarListadoUsuarios();
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            ClavesRegistradas();
        }

        private void ddlSeleccionarUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                ClavesRegistradas();
            }
            catch (Exception) { }
        }
    }
}
