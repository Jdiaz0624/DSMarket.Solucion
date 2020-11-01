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
    public partial class RetencionesConsulta : Form
    {
        public RetencionesConsulta()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaEmpresa.LogicaEmpresa> ObjDataEmpresa = new Lazy<Logica.Logica.LogicaEmpresa.LogicaEmpresa>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region MOSTRAR EL LISTADO DE LAS RETENCIONES
        private void MostrarListadoRetenciones() {
            string _Retencion = string.IsNullOrEmpty(txtRetencion.Text.Trim()) ? null : txtRetencion.Text.Trim();

            var Buscar = ObjDataEmpresa.Value.BuscaRetenciones(
                new Nullable<decimal>(),
                _Retencion,
                Convert.ToInt32(txtNumeroPagina.Value),
                Convert.ToInt32(txtNumeroRegistros.Value));
            dtListado.DataSource = Buscar;
            OcultarColumnas();
            if (Buscar.Count() < 1)
            {
                lbCantidadRegistrosVariable.Text = "0";
            }
            else {
                int CantidadRegistros = 0;

                foreach (var n in Buscar) {
                    CantidadRegistros = Convert.ToInt32(n.CantidadRegistros);
                    lbCantidadRegistrosVariable.Text = CantidadRegistros.ToString("N0");
                }
            }
        }
        private void OcultarColumnas() {
            this.dtListado.Columns["IdRetencion"].Visible = false;
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
        private void RetencionesConsulta_Load(object sender, EventArgs e)
        {
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            lbTitulo.Text = "Consulta de Retenciones";
            lbTitulo.ForeColor = Color.White;
            lbCantidadRegistrosTitulo.ForeColor = Color.White;
            lbCantidadRegistrosVariable.ForeColor = Color.White;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MostrarListadoRetenciones();
        }

        private void txtNumeroPagina_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroPagina.Value < 1) {
                txtNumeroPagina.Value = 1;
                MostrarListadoRetenciones();
            }
            else {
                MostrarListadoRetenciones();
            }
        }

        private void txtNumeroRegistros_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroRegistros.Value < 1) {
                txtNumeroRegistros.Value = 10;
                MostrarListadoRetenciones();

            }
            else {
                MostrarListadoRetenciones();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.RetencionesMantenimiento Nuevo = new RetencionesMantenimiento();
            Nuevo.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Nuevo.VariablesGlobales.Accion = "INSERT";
            Nuevo.VariablesGlobales.IdMantenimeinto = 0;
         //   Nuevo.VariablesGlobales.SecuenciaRegistro = 0;
            Nuevo.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.RetencionesMantenimiento Modificar = new RetencionesMantenimiento();
            Modificar.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Modificar.VariablesGlobales.Accion = "UPDATE";
            Modificar.VariablesGlobales.IdMantenimeinto = VariablesGlobales.IdMantenimeinto;
           // Modificar.VariablesGlobales.SecuenciaRegistro = VariablesGlobales.SecuenciaRegistro;
            Modificar.ShowDialog();
        }

        private void btnRestabelcer_Click(object sender, EventArgs e)
        {
            btnNuevo.Enabled = true;
            btnEditar.Enabled = false;
            btnBuscar.Enabled = true;
            txtRetencion.Text = string.Empty;
            txtNumeroPagina.Enabled = true;
            txtNumeroRegistros.Enabled = true;
            txtNumeroPagina.Value = 1;
            txtNumeroRegistros.Value = 10;
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dtListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("¿Quieres seleccioanr este registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                this.VariablesGlobales.IdMantenimeinto = Convert.ToDecimal(dtListado.CurrentRow.Cells["IdRetencion"].Value.ToString());

                var BuscarRegistro = ObjDataEmpresa.Value.BuscaRetenciones(
                    VariablesGlobales.IdMantenimeinto, null, 1, 1);
                dtListado.DataSource = BuscarRegistro;
                OcultarColumnas();
                txtNumeroPagina.Enabled = false;
                txtNumeroRegistros.Enabled = false;
                btnNuevo.Enabled = false;
                btnBuscar.Enabled = false;
                btnEditar.Enabled = true;
               
            }
        }

        private void RetencionesConsulta_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason) {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }
    }
}
