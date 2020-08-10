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
    public partial class CompraSuplidores : Form
    {
        public CompraSuplidores()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaEmpresa.LogicaEmpresa> ObjdataEmpresa = new Lazy<Logica.Logica.LogicaEmpresa.LogicaEmpresa>();
        public DSMarket.Logica.Comunes.VariablesGlobales Variableslobales = new Logica.Comunes.VariablesGlobales();

        #region MOSTRAR EL LISTADO DE LAS COMPRAS DE SUPLIDORES
        private void MostrarListadoCompras() {
            string _RNC = string.IsNullOrEmpty(txtRNC.Text.Trim()) ? null : txtRNC.Text.Trim();

            var Consultar = ObjdataEmpresa.Value.BuscaCompraSuplidores(
                new Nullable<decimal>(),
                null,
                null,
                _RNC,
                Convert.ToDateTime(txtFechaDesde.Text),
                Convert.ToDateTime(txtFechaHasta.Text),
                Convert.ToInt32(txtNumeroPagina.Value),
                Convert.ToInt32(txtNumeroRegistros.Value));
            dtListado.DataSource = Consultar;
            if (Consultar.Count() < 1)
            {
                lbCantidadRegistrosVariable.Text = "0";
            }
            else {
                foreach (var n in Consultar) {
                    int CantidadRegistros = Convert.ToInt32(n.CantidadRegistros);
                    lbCantidadRegistrosVariable.Text = CantidadRegistros.ToString("N0");
                }
            }
            OcultarColumnas();
        }
        private void OcultarColumnas() {
            this.dtListado.Columns["IdCompraSuplidor"].Visible = false;
            this.dtListado.Columns["IdTipoSuplidor"].Visible = false;
            this.dtListado.Columns["IdSuplidor"].Visible = false;
            this.dtListado.Columns["IdTipoIdentificacion"].Visible = false;
            this.dtListado.Columns["IdTipoBienesServicios"].Visible = false;
            this.dtListado.Columns["FechaComprobante0"].Visible = false;
            this.dtListado.Columns["FechaPago0"].Visible = false;
            this.dtListado.Columns["IdTipoRetencionISR"].Visible = false;
            this.dtListado.Columns["IdFormaPago"].Visible = false;
            this.dtListado.Columns["UsuarioAdiciona"].Visible = false;
            this.dtListado.Columns["FechaCreado0"].Visible = false;
            this.dtListado.Columns["CantidadRegistros"].Visible = false;
        }
        #endregion
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void CompraSuplidores_Load(object sender, EventArgs e)
        {
            lbTitulo.Text = "COMPRA DE SUPLIDORES CONSULTA";
            lbTitulo.ForeColor = Color.White;
            lbCantidadRegistrosTitulo.ForeColor = Color.White;
            lbCantidadRegistrosVariable.ForeColor = Color.White;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MostrarListadoCompras();
        }

        private void txtNumeroPagina_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroPagina.Value < 1)
            {
                txtNumeroPagina.Value = 1;
                MostrarListadoCompras();
            }
            else {
                MostrarListadoCompras();
            }
        }

        private void txtNumeroRegistros_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroRegistros.Value < 1)
            {
                txtNumeroRegistros.Value = 10;
                MostrarListadoCompras();
            }
            else {
                MostrarListadoCompras();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.MantenimientoCompraSuplidores Mantenimiento = new MantenimientoCompraSuplidores();
            Mantenimiento.VariablesGlobales.IdUsuario = Variableslobales.IdUsuario;
            Mantenimiento.VariablesGlobales.Accion = "INSERT";
            Mantenimiento.VariablesGlobales.IdMantenimeinto = 0;
            Mantenimiento.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.MantenimientoCompraSuplidores Mantenimiento = new MantenimientoCompraSuplidores();
            Mantenimiento.VariablesGlobales.IdUsuario = Variableslobales.IdUsuario;
            Mantenimiento.VariablesGlobales.Accion = "UPDATE";
            Mantenimiento.VariablesGlobales.IdMantenimeinto = Variableslobales.IdMantenimeinto;
            Mantenimiento.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.MantenimientoCompraSuplidores Mantenimiento = new MantenimientoCompraSuplidores();
            Mantenimiento.VariablesGlobales.IdUsuario = Variableslobales.IdUsuario;
            Mantenimiento.VariablesGlobales.Accion = "DELETE";
            Mantenimiento.VariablesGlobales.IdMantenimeinto = Variableslobales.IdMantenimeinto;
            Mantenimiento.ShowDialog();
        }

        private void dtListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("¿Quieres seleccionar este registro?", Variableslobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {

                this.Variableslobales.IdMantenimeinto = Convert.ToDecimal(this.dtListado.CurrentRow.Cells["IdCompraSuplidor"].Value.ToString());
            }
        }
    }
}
