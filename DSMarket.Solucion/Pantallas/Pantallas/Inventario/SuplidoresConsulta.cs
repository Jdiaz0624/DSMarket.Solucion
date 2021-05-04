using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSMarket.Solucion.Pantallas.Pantallas.Inventario
{
    public partial class SuplidoresConsulta : Form
    {
        public SuplidoresConsulta()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaListas.LogicaListas> ObjDataListas = new Lazy<Logica.Logica.LogicaListas.LogicaListas>();
        Lazy<DSMarket.Logica.Logica.LogicaInventario.LogicaInventario> ObjDataInventario = new Lazy<Logica.Logica.LogicaInventario.LogicaInventario>();
        public DSMarket.Logica.Comunes.VariablesGlobales variablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region CARGAR LISTAS
        private void CargarListas() {
            var Lista = ObjDataListas.Value.BuscaListaTipoSuplidor();
            ddlSeleccionarTipoSuplidor.DataSource = Lista;
            ddlSeleccionarTipoSuplidor.DisplayMember = "Descripcion";
            ddlSeleccionarTipoSuplidor.ValueMember = "IdTipoSuplidor";
        }
        #endregion
        #region MOSTRAR EL LISTADO DE LOS SUPLIDORES
        private void MostrarListadoSuplidores() {
            try {
                string _Suplidor = string.IsNullOrEmpty(txtSuplidor.Text.Trim()) ? null : txtSuplidor.Text.Trim();

                var Buscar = ObjDataInventario.Value.BuscaSupervisores(
                    Convert.ToDecimal(ddlSeleccionarTipoSuplidor.SelectedValue),
                    new Nullable<decimal>(),
                    _Suplidor,
                    Convert.ToInt32(txtNumeroPagina.Value),
                    Convert.ToInt32(txtNumeroRegistros.Value));
                dtListado.DataSource = Buscar;
                if (Buscar.Count() < 1)
                {
                    lbCantidadRegistrosVariable.Text = "0";
                }
                else
                {
                    foreach (var n in Buscar)
                    {
                        int Cantidad = Convert.ToInt32(n.CantidadRegistros);
                        lbCantidadRegistrosVariable.Text = Cantidad.ToString("N0");
                    }
                }
                OcultarColumnas();
            }
            catch (Exception ex) {
                MessageBox.Show("Error al mostrar el listado de los suplidores codigo de error: " + ex.Message, variablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void OcultarColumnas() {
            this.dtListado.Columns["IdTipoSuplidor"].Visible = false;
            this.dtListado.Columns["IdSuplidor"].Visible = false;
            this.dtListado.Columns["Estatus0"].Visible = false;
            this.dtListado.Columns["UsuarioAdiciona"].Visible = false;
            this.dtListado.Columns["FechaAdiciona"].Visible = false;
            this.dtListado.Columns["UsuarioModifica"].Visible = false;
            this.dtListado.Columns["ModificadoPor"].Visible = false;
            this.dtListado.Columns["FechaModifica"].Visible = false;
            this.dtListado.Columns["FechaModificado"].Visible = false;
            this.dtListado.Columns["CantidadRegistros"].Visible = false;
        }
        #endregion
        private void lbNumeroPagina_Click(object sender, EventArgs e)
        {

        }

        private void txtNumeroPagina_ValueChanged(object sender, EventArgs e)
        {
            if(txtNumeroPagina.Value < 1)
            {
                txtNumeroPagina.Value = 1;
                MostrarListadoSuplidores();
            }
            else
            {
                MostrarListadoSuplidores();
            }
        }

        private void lbNumeroRegistros_Click(object sender, EventArgs e)
        {

        }

        private void txtNumeroRegistros_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroRegistros.Value < 1)
            {
                txtNumeroRegistros.Value = 10;
                MostrarListadoSuplidores();
            }
            else
            {
                MostrarListadoSuplidores();
            }
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void SuplidoresConsulta_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void SuplidoresConsulta_Load(object sender, EventArgs e)
        {
            variablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            CargarListas();
            lbTitulo.Text = "CONSULTA DE SUPLIDORES";
            lbTitulo.ForeColor = Color.WhiteSmoke;
            lbCantidadRegistrosVariable.ForeColor = Color.WhiteSmoke;
            lbCantidadRegistrosTitulo.ForeColor = Color.WhiteSmoke;
            dtListado.BackgroundColor = SystemColors.Control;
            this.BackColor = SystemColors.Control;
            txtSuplidor.BackColor = Color.WhiteSmoke;
            txtNumeroRegistros.BackColor = Color.WhiteSmoke;
            txtNumeroPagina.BackColor = Color.WhiteSmoke;
            ddlSeleccionarTipoSuplidor.BackColor = Color.WhiteSmoke;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.MantenimientoSupidores Mantenimiento = new MantenimientoSupidores();
            Mantenimiento.VariablesGlobales.ModoRecarga = false;
            Mantenimiento.VariablesGlobales.Accion = "INSERT";
            Mantenimiento.VariablesGlobales.IdMantenimeinto = 0;
            Mantenimiento.VariablesGlobales.IdUsuario = variablesGlobales.IdUsuario;
            Mantenimiento.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.MantenimientoSupidores Mantenimiento = new MantenimientoSupidores();
            Mantenimiento.VariablesGlobales.Accion = "UPDATE";
            Mantenimiento.VariablesGlobales.IdMantenimeinto = variablesGlobales.IdMantenimeinto;
            Mantenimiento.VariablesGlobales.IdUsuario = variablesGlobales.IdUsuario;
            Mantenimiento.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MostrarListadoSuplidores();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            btnBuscar.Enabled = true;
            btnNuevo.Enabled = true;
            btnEditar.Enabled = false;
            btnDeshabilitar.Enabled = false;
            txtNumeroPagina.Enabled = true;
            txtNumeroRegistros.Enabled = true;
            txtNumeroPagina.Value = 1;
            txtNumeroRegistros.Value = 10;
            CargarListas();
            txtSuplidor.Text = string.Empty;
            MostrarListadoSuplidores();
        }

        private void dtListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.variablesGlobales.IdMantenimeinto = Convert.ToDecimal(this.dtListado.CurrentRow.Cells["IdSuplidor"].Value.ToString());

            var BuscarRegistro = ObjDataInventario.Value.BuscaSupervisores(
               null,
               variablesGlobales.IdMantenimeinto,
               null,
               1, 1);
            foreach (var n in BuscarRegistro)
            {
                lbCantidadRegistrosVariable.Text = n.CantidadRegistros.ToString();
            }
            dtListado.DataSource = BuscarRegistro;
            OcultarColumnas();
            txtNumeroPagina.Enabled = false;
            txtNumeroRegistros.Enabled = false;
            btnBuscar.Enabled = false;
            btnNuevo.Enabled = false;
            btnEditar.Enabled = true;
        }
    }
}
