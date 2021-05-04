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
    public partial class BancoConsulta : Form
    {
        public BancoConsulta()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaEmpresa.LogicaEmpresa> ObjDataEmpresa = new Lazy<Logica.Logica.LogicaEmpresa.LogicaEmpresa>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region SACAR EL LISTADO DE LOS BANCOS
        private void Listado() {
            string _Banco = string.IsNullOrEmpty(txtBanco.Text.Trim()) ? null : txtBanco.Text;

            var Listado = ObjDataEmpresa.Value.ListadoBancos(
                new Nullable<decimal>(),
                _Banco,
                (int)txtNumeroPagina.Value,
                (int)txtNumeroRegistros.Value);
            dtListado.DataSource = Listado;
            if (Listado.Count() < 1)
            {
                lbCantidadRegistrosVariable.Text = "0";
            }
            else {
                int CantidadRegistros = 0;

                foreach (var n in Listado) {
                    CantidadRegistros = (int)n.CantidadRegistros;
                    lbCantidadRegistrosVariable.Text = CantidadRegistros.ToString("N0");
                }
            }
            OcultarColumnas();
        }
        private void OcultarColumnas() {
            this.dtListado.Columns["IdBanco"].Visible = false;
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

        private void BancoConsulta_Load(object sender, EventArgs e)
        {
            lbTitulo.Text = "CONSULTA DE BANCOS";
            lbTitulo.ForeColor = Color.White;
            lbCantidadRegistrosTitulo.ForeColor = Color.White;
            lbCantidadRegistrosVariable.ForeColor = Color.White;
            lbCantidadRegistrosVariable.Text = "0";
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BancoConsulta_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason) {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Listado();
        }

        private void txtNumeroPagina_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroPagina.Value < 1) {
                txtNumeroPagina.Value = 1;
                Listado();
            }
            else {
                Listado();
            }
        }

        private void txtNumeroRegistros_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroRegistros.Value < 1) {
                txtNumeroRegistros.Value = 10;
                Listado();
            }
            else {
                Listado();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnBuscar.Enabled = true;
            btnNuevo.Enabled = true;
            btnEditar.Enabled = false;
            txtNumeroPagina.Enabled = true;
            txtNumeroRegistros.Enabled = false;
            txtNumeroPagina.Value = 1;
            txtNumeroRegistros.Value = 10;
            txtBanco.Text = string.Empty;
            Listado();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.MantenimientoBancos Mantenimiento = new MantenimientoBancos();
            Mantenimiento.VariablesGlobales.IdMantenimeinto = 0;
            Mantenimiento.VariablesGlobales.Accion = "INSERT";
            Mantenimiento.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Mantenimiento.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.MantenimientoBancos Mantenimiento = new MantenimientoBancos();
            Mantenimiento.VariablesGlobales.IdMantenimeinto = VariablesGlobales.IdMantenimeinto;
            Mantenimiento.VariablesGlobales.Accion = "UPDATE";
            Mantenimiento.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Mantenimiento.ShowDialog();
        }

        private void dtListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.VariablesGlobales.IdMantenimeinto = Convert.ToDecimal(this.dtListado.CurrentRow.Cells["IdBanco"].Value.ToString());

            var BuscarRegistroSeleccionado = ObjDataEmpresa.Value.ListadoBancos(
                VariablesGlobales.IdMantenimeinto,
                null, 1, 1);
            lbCantidadRegistrosVariable.Text = "1";
            dtListado.DataSource = BuscarRegistroSeleccionado;
            OcultarColumnas();
            btnNuevo.Enabled = false;
            btnBuscar.Enabled = false;
            btnEditar.Enabled = true;
            txtNumeroPagina.Enabled = false;
            txtNumeroRegistros.Enabled = false;
        }
    }
}
