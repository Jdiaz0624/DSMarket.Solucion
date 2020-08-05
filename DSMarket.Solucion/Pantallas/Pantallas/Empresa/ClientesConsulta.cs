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
    public partial class ClientesConsulta : Form
    {
        public ClientesConsulta()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaEmpresa.LogicaEmpresa> ObjdataEmpresa = new Lazy<Logica.Logica.LogicaEmpresa.LogicaEmpresa>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region MOSTRAR EL LISTADO DE LOS CLIENTES
        private void MostrarListadoClientes() {
            string _NombreCliente = string.IsNullOrEmpty(txtNombreCliente.Text.Trim()) ? null : txtNombreCliente.Text.Trim();
            string _RNC = string.IsNullOrEmpty(txtCedulaCliente.Text.Trim()) ? null : txtCedulaCliente.Text.Trim();

            var Listado = ObjdataEmpresa.Value.BuscaClientes(
                new Nullable<decimal>(),
                null,
                _NombreCliente,
                _RNC,
                null,
                null,
                Convert.ToInt32(txtNumeroPagina.Value),
                Convert.ToInt32(txtNumeroRegistros.Value));
            dtListado.DataSource = Listado;
            OcultarColumnas();
            if (Listado.Count() < 1)
            {
                lbCantidadRegistrosVariable.Text = "0";
            }
            else {
                foreach (var n in Listado) {
                    int CantidadRegistros = Convert.ToInt32(n.CantidadClientes);
                    lbCantidadRegistrosVariable.Text = CantidadRegistros.ToString("N0");
                }
            }
        }
        private void OcultarColumnas() {
            this.dtListado.Columns["IdCliente"].Visible = false;
            this.dtListado.Columns["IdComprobante"].Visible = false;
            this.dtListado.Columns["IdTipoIdentificacion"].Visible = false;
            this.dtListado.Columns["Estatus0"].Visible = false;
            this.dtListado.Columns["EnvioEmail0"].Visible = false;
            this.dtListado.Columns["UsuarioAdiciona"].Visible = false;
            this.dtListado.Columns["FechaAdiciona"].Visible = false;
            this.dtListado.Columns["UsuarioModifica"].Visible = false;
            this.dtListado.Columns["ModificadoPor"].Visible = false;
            this.dtListado.Columns["FechaModifica"].Visible = false;
            this.dtListado.Columns["FechaModificado"].Visible = false;
            this.dtListado.Columns["CantidadClientes"].Visible = false;
        }
        #endregion
        private void ClientesConsulta_Load(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
            dtListado.BackgroundColor = SystemColors.Control;

            txtCedulaCliente.BackColor = Color.WhiteSmoke;
           // txtCodigoCliente.BackColor = Color.WhiteSmoke;
            txtNombreCliente.BackColor = Color.WhiteSmoke;
            txtNumeroPagina.BackColor = Color.WhiteSmoke;
            txtNumeroRegistros.BackColor = Color.WhiteSmoke;

            txtCedulaCliente.ForeColor = Color.Black;
           // txtCodigoCliente.ForeColor = Color.Black;
            txtNombreCliente.ForeColor = Color.Black;
            txtNumeroPagina.ForeColor = Color.Black;
            txtNumeroRegistros.ForeColor = Color.Black;

            lbTitulo.Text = "CONSULTA DE CLIENTES";
            lbTitulo.ForeColor = Color.White;
            lbCantidadRegistrosTitulo.ForeColor = Color.WhiteSmoke;
            lbCantidadRegistrosVariable.ForeColor = Color.WhiteSmoke;
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.ClientesMantenimiento mantenimiento = new ClientesMantenimiento();
            mantenimiento.VariablesGlobales.Accion = "INSERT";
            mantenimiento.VariablesGlobales.IdMantenimeinto = 0;
            mantenimiento.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.ClientesMantenimiento mantenimiento = new ClientesMantenimiento();
            mantenimiento.VariablesGlobales.Accion = "UPDATE";
            mantenimiento.VariablesGlobales.IdMantenimeinto = VariablesGlobales.IdMantenimeinto;
            mantenimiento.ShowDialog();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.ClientesMantenimiento mantenimiento = new ClientesMantenimiento();
            mantenimiento.VariablesGlobales.Accion = "DELETE";
            mantenimiento.VariablesGlobales.IdMantenimeinto = VariablesGlobales.IdMantenimeinto;
            mantenimiento.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MostrarListadoClientes();
        }

        private void txtNumeroPagina_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroPagina.Value < 1)
            {
                txtNumeroPagina.Value = 1;
                MostrarListadoClientes();
            }
            else {
                MostrarListadoClientes();
            }
        }

        private void txtNumeroRegistros_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroRegistros.Value < 1)
            {
                txtNumeroRegistros.Value = 10;
                MostrarListadoClientes();
            }
            else {
                MostrarListadoClientes();
            }
        }

        private void dtListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("¿Quieres seleccionar este registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {

                this.VariablesGlobales.IdMantenimeinto = Convert.ToDecimal(this.dtListado.CurrentRow.Cells["IdCliente"].Value.ToString());

                var BuscarCliente = ObjdataEmpresa.Value.BuscaClientes(
                    VariablesGlobales.IdMantenimeinto,
                    null, null, null, null, null, 1, 1);
                dtListado.DataSource = BuscarCliente;
                OcultarColumnas();
                if (BuscarCliente.Count() < 1)
                {
                    lbCantidadRegistrosVariable.Text = "0";
                }
                else {
                    foreach (var n in BuscarCliente) {
                        int Cantidad = Convert.ToInt32(n.CantidadClientes);
                        lbCantidadRegistrosVariable.Text = Cantidad.ToString("N0");
                    }
                }
                btnNuevo.Enabled = false;
                btnEditar.Enabled = true;
                btnDeshabilitar.Enabled = true;
                txtNumeroPagina.Enabled = false;
                txtNumeroRegistros.Enabled = false;
            }
        }

        private void btnRestabelcer_Click(object sender, EventArgs e)
        {
            btnNuevo.Enabled = true;
            btnEditar.Enabled = false;
            btnDeshabilitar.Enabled = false;
            txtNumeroPagina.Enabled = true;
            txtNumeroRegistros.Enabled = true;
            txtNumeroPagina.Value = 1;
            txtNumeroRegistros.Value = 10;
            txtNombreCliente.Text = string.Empty;
            txtCedulaCliente.Text = string.Empty;
            MostrarListadoClientes();
        }
    }
}
