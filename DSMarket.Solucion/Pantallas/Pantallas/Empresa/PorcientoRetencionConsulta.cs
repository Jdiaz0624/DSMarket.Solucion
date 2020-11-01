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
    public partial class PorcientoRetencionConsulta : Form
    {
        public PorcientoRetencionConsulta()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaEmpresa.LogicaEmpresa> ObjDataEmpresa = new Lazy<Logica.Logica.LogicaEmpresa.LogicaEmpresa>();
        Lazy<DSMarket.Logica.Logica.LogicaListas.LogicaListas> ObjDataListas = new Lazy<Logica.Logica.LogicaListas.LogicaListas>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        private void MostrarListadoRetenciones() {
            var Retenciones = ObjDataListas.Value.ListadoRetenciones();
            ddlRetencencion.DataSource = Retenciones;
            ddlRetencencion.DisplayMember = "Retencion";
            ddlRetencencion.ValueMember = "IdRetencion";
        }

        private void ListadoPorcientoRetenciones() {

            var Listado = ObjDataEmpresa.Value.BuscaPorCientoretenciones(
                new Nullable<decimal>(),
                Convert.ToDecimal(ddlRetencencion.SelectedValue),
                null,
                Convert.ToInt32(txtNumeroPagina.Value),
                Convert.ToInt32(txtNumeroRegistros.Value));
            dtListado.DataSource = Listado;
            OcultarColumnas();
            if (Listado.Count() < 1) {
                lbCantidadRegistrosVariable.Text = "0";
            }
            else {
                int CantidadRegistros = 0;
                foreach (var n in Listado) {
                    CantidadRegistros = Convert.ToInt32(n.CantidadRegistros);
                    lbCantidadRegistrosVariable.Text = CantidadRegistros.ToString("N0");
                }
            }
        
        }
        private void OcultarColumnas() {
            this.dtListado.Columns["IdPorcientoRetencion"].Visible = false;
            this.dtListado.Columns["IdRetencion"].Visible = false;
            this.dtListado.Columns["Secuencia"].Visible = false;
            this.dtListado.Columns["Estatus0"].Visible = false;
            this.dtListado.Columns["UsuarioAdiciona"].Visible = false;
            this.dtListado.Columns["FechaAdiciona"].Visible = false;
            this.dtListado.Columns["UsuarioModifica"].Visible = false;
            this.dtListado.Columns["ModificadoPor"].Visible = false;
            this.dtListado.Columns["FechaModifica"].Visible = false;
            this.dtListado.Columns["FechaModificado"].Visible = false;
            this.dtListado.Columns["CantidadRegistros"].Visible = false;
        }
        private void PorcientoRetencionConsulta_Load(object sender, EventArgs e)
        {
            MostrarListadoRetenciones();
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            lbTitulo.ForeColor = Color.White;
            lbTitulo.Text = "Consulta de % de Retención";
            lbCantidadRegistrosTitulo.ForeColor = Color.White;
            lbCantidadRegistrosVariable.ForeColor = Color.White;

        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void PorcientoRetencionConsulta_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason) {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ListadoPorcientoRetenciones();
        }

        private void txtNumeroPagina_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroPagina.Value < 1)
            {
                txtNumeroPagina.Value = 1;
                ListadoPorcientoRetenciones();
            }
            else {
                ListadoPorcientoRetenciones();
            }
        }

        private void txtNumeroRegistros_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroRegistros.Value < 1)
            {
                txtNumeroRegistros.Value = 10;
                ListadoPorcientoRetenciones();
            }
            else {
                ListadoPorcientoRetenciones();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.MantenimientoPorcientoretencion Nuevo = new MantenimientoPorcientoretencion();
            Nuevo.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Nuevo.VariablesGlobales.IdMantenimeinto = 0;
            Nuevo.VariablesGlobales.SecuenciaRegistro = 0;
            Nuevo.VariablesGlobales.Accion = "INSERT";
            Nuevo.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.MantenimientoPorcientoretencion Nuevo = new MantenimientoPorcientoretencion();
            Nuevo.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Nuevo.VariablesGlobales.IdMantenimeinto = VariablesGlobales.IdMantenimeinto;
            Nuevo.VariablesGlobales.SecuenciaRegistro = VariablesGlobales.SecuenciaRegistro;
            Nuevo.VariablesGlobales.Accion = "UPDATE";
            Nuevo.ShowDialog();
        }

        private void btnRestabelcer_Click(object sender, EventArgs e)
        {
            MostrarListadoRetenciones();
            btnNuevo.Enabled = true;
            btnBuscar.Enabled = true;
            btnEditar.Enabled = false;
            txtNumeroPagina.Enabled = true;
            txtNumeroRegistros.Enabled = true;
            txtNumeroPagina.Value = 1;
            txtNumeroRegistros.Value = 10;
        }

        private void dtListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("¿Quieres seleccionar este registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                this.VariablesGlobales.IdMantenimeinto = Convert.ToDecimal(this.dtListado.CurrentRow.Cells["IdPorcientoRetencion"].Value.ToString());
                this.VariablesGlobales.SecuenciaRegistro = Convert.ToDecimal(this.dtListado.CurrentRow.Cells["Secuencia"].Value.ToString());


                var Buscar = ObjDataEmpresa.Value.BuscaPorCientoretenciones(
                    VariablesGlobales.IdMantenimeinto,
                    null,
                    (int)VariablesGlobales.SecuenciaRegistro,
                    1, 1);
                dtListado.DataSource = Buscar;
                OcultarColumnas();
                btnBuscar.Enabled = false;
                btnNuevo.Enabled = false;
                btnEditar.Enabled = true;
                txtNumeroPagina.Enabled = false;
                txtNumeroRegistros.Enabled = false;
            }
        }
    }
}
