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
    public partial class UsuariosConsulta : Form
    {
        Lazy<DSMarket.Logica.Logica.LogicaSeguridad.LogicaSeguridad> ObjDataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad.LogicaSeguridad>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region MOSTRAR LISTADO DE USUARIOS
        private void ConsultarUsuarios() {
            string _Usuario = string.IsNullOrEmpty(txtUsuaio.Text.Trim()) ? null : txtUsuaio.Text.Trim();
            string _Persona = string.IsNullOrEmpty(txtPersona.Text.Trim()) ? null : txtPersona.Text.Trim();

            var Buscar = ObjDataSeguridad.Value.BuscaUsuarios(
                new Nullable<decimal>(),
                null,
                null,
                _Usuario,
                _Persona,
                Convert.ToInt32(txtNumeroPagina.Value),
                Convert.ToInt32(txtNumeroRegistros.Value));
            dtListado.DataSource = Buscar;
            OcultarColumnas();
        }
        private void OcultarColumnas() {
            this.dtListado.Columns["IdUsuario"].Visible = false;
            this.dtListado.Columns["IdNivelAcceso"].Visible = false;
            this.dtListado.Columns["Clave"].Visible = false;
            this.dtListado.Columns["Estatus0"].Visible = false;
            this.dtListado.Columns["CambiaClave0"].Visible = false;
            this.dtListado.Columns["CambiaClave"].Visible = false;
            this.dtListado.Columns["UsuarioAdicona"].Visible = false;
            this.dtListado.Columns["FechaAdiciona0"].Visible = false;
            this.dtListado.Columns["UsuarioModifica"].Visible = false;
            this.dtListado.Columns["ModificadoPor"].Visible = false;
            this.dtListado.Columns["FechaModifica0"].Visible = false;
            this.dtListado.Columns["FechaModificado"].Visible = false;
        }
        #endregion
        public UsuariosConsulta()
        {
            InitializeComponent();
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void UsuariosConsulta_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Seguridad.UsuariosMantenimiento Mantenimiento = new UsuariosMantenimiento();
            Mantenimiento.VariablesGlobales.Accion = "INSERT";
            Mantenimiento.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Mantenimiento.VariablesGlobales.IdMantenimeinto = 0;
            Mantenimiento.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Seguridad.UsuariosMantenimiento Mantenimiento = new UsuariosMantenimiento();
            Mantenimiento.VariablesGlobales.Accion = "UPDATE";
            Mantenimiento.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Mantenimiento.VariablesGlobales.IdMantenimeinto = VariablesGlobales.IdMantenimeinto;
            Mantenimiento.ShowDialog();
        }

        private void UsuariosConsulta_Load(object sender, EventArgs e)
        {
            lbTitulo.Text = "CONSULTA DE USUARIOS";
            lbTitulo.ForeColor = Color.WhiteSmoke;
            lbCantidadRegistrosVariable.ForeColor = Color.WhiteSmoke;
            lbCantidadRegistrosTitulo.ForeColor = Color.WhiteSmoke;

            txtNumeroPagina.BackColor = Color.WhiteSmoke;
            txtNumeroRegistros.BackColor = Color.WhiteSmoke;
            txtPersona.BackColor = Color.WhiteSmoke;
            txtUsuaio.BackColor = Color.WhiteSmoke;
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ConsultarUsuarios();
        }

        private void txtNumeroPagina_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroPagina.Value < 1)
            {
                txtNumeroPagina.Value = 1;
                ConsultarUsuarios();
            }
            else {
                ConsultarUsuarios();
            }
        }

        private void txtNumeroRegistros_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroRegistros.Value < 1)
            {
                txtNumeroRegistros.Value = 10;
                ConsultarUsuarios();
            }
            else {
                ConsultarUsuarios();
            }
        }

        private void dtListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.VariablesGlobales.IdMantenimeinto = Convert.ToDecimal(this.dtListado.CurrentRow.Cells["IdUsuario"].Value.ToString());
            this.VariablesGlobales.IdNivelAcceso = Convert.ToDecimal(this.dtListado.CurrentRow.Cells["IdNivelAcceso"].Value.ToString());

            var BuscarRegistro = ObjDataSeguridad.Value.BuscaUsuarios(
               VariablesGlobales.IdMantenimeinto,
               null, null, null, null, 1, 1);
            dtListado.DataSource = BuscarRegistro;
            OcultarColumnas();
            btnBuscar.Enabled = false;
            btnNuevo.Enabled = false;
            btnEditar.Enabled = true;
            txtNumeroPagina.Enabled = false;
            txtNumeroRegistros.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnBuscar.Enabled = true;
            btnNuevo.Enabled = true;
            btnEditar.Enabled = false;
            txtNumeroPagina.Enabled = true;
            txtNumeroRegistros.Enabled = true;
            txtNumeroPagina.Value = 1;
            txtNumeroRegistros.Value = 10;
            txtUsuaio.Text = string.Empty;
            txtPersona.Text = string.Empty;
            ConsultarUsuarios();
        }
    }
    
}
