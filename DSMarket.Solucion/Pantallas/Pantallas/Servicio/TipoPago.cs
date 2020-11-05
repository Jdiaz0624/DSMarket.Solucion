using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSMarket.Solucion.Pantallas.Pantallas.Servicio
{
    public partial class TipoPago : Form
    {
        public TipoPago()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaServicio.LogicaServicio> ObjDataServicio = new Lazy<Logica.Logica.LogicaServicio.LogicaServicio>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region MOSTRAR EL LISTADO DE LOS TIPOS DE PAGOS
        private void MostrarListadoTipoPago() {
            string _TipoPago = string.IsNullOrEmpty(txtTipoPago.Text.Trim()) ? null : txtTipoPago.Text.Trim();

            var Buscar = ObjDataServicio.Value.BuscaTipoPago(
                new Nullable<decimal>(),
                _TipoPago,
                Convert.ToInt32(txtNumeroPagina.Value),
                Convert.ToInt32(txtNumeroRegistros.Value));
            dtListado.DataSource = Buscar;
            OcultarColumnas();
            if (Buscar.Count() < 1)
            {
                lbCantidadRegistrosVariable.Text = "0";
            }
            else {
                foreach (var n in Buscar) {
                    int CantidadRegistros = Convert.ToInt32(n.CantidadRegistros);

                    lbCantidadRegistrosVariable.Text = CantidadRegistros.ToString("N0");
                }
            }
        }
        private void OcultarColumnas() {
            this.dtListado.Columns["IdTipoPago"].Visible = false;
            this.dtListado.Columns["Estatus0"].Visible = false;
            this.dtListado.Columns["UsuarioAdiciona"].Visible = false;
            this.dtListado.Columns["FechaAdiciona"].Visible = false;
            this.dtListado.Columns["ModificadoPor"].Visible = false;
            this.dtListado.Columns["FechaModifica"].Visible = false;
            this.dtListado.Columns["FechaModificado"].Visible = false;
            this.dtListado.Columns["BloqueaMonto0"].Visible = false;
            this.dtListado.Columns["CantidadRegistros"].Visible = false;
            this.dtListado.Columns["ImpuestoAdicional0"].Visible = false;
            this.dtListado.Columns["PorcentajeEntero0"].Visible = false;
        }
        #endregion
        #region TEMA GENERICO
        private void AplicarTema() {
            lbTitulo.Text = "Mantenimiento de tipo de pagos";
            lbTitulo.ForeColor = Color.White;
            lbCantidadRegistrosTitulo.Text = "Cantidad de Registros: ";
            lbCantidadRegistrosTitulo.ForeColor = Color.White;
            lbCantidadRegistrosVariable.Text = "0";
            lbCantidadRegistrosVariable.ForeColor = Color.White;


            this.BackColor = SystemColors.Control;
            txtTipoPago.BackColor = Color.WhiteSmoke;
            txtNumeroPagina.BackColor = Color.WhiteSmoke;
            txtNumeroRegistros.BackColor = Color.WhiteSmoke;

            txtTipoPago.ForeColor = Color.Black;
            txtNumeroRegistros.ForeColor = Color.Black;
            txtNumeroPagina.ForeColor = Color.Black;

            dtListado.BackgroundColor = SystemColors.Control;
        }
        #endregion
        #region RESTABELCER PANTALLA
        private void RestablecerPantalla() {
            btnNuevo.Enabled = true;
            btnEditar.Enabled = false;
            btnRestablecer.Enabled = false;
            txtNumeroPagina.Enabled = true;
            txtNumeroRegistros.Enabled = true;
            txtNumeroPagina.Value = 1;
            txtNumeroRegistros.Value = 10;
            txtTipoPago.Text = string.Empty;
            MostrarListadoTipoPago();
        }
        #endregion

        private void TipoPago_Load(object sender, EventArgs e)
        {
            AplicarTema();
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void TipoPago_FormClosing(object sender, FormClosingEventArgs e)
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
            DSMarket.Solucion.Pantallas.Pantallas.Servicio.MantenimientoTipoPago Mantenimiento = new MantenimientoTipoPago();
            Mantenimiento.VariablesGlobales.Accion = "INSERT";
            Mantenimiento.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Mantenimiento.VariablesGlobales.IdMantenimeinto = 0;
            Mantenimiento.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Servicio.MantenimientoTipoPago Mantenimiento = new MantenimientoTipoPago();
            Mantenimiento.VariablesGlobales.Accion = "UPDATE";
            Mantenimiento.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Mantenimiento.VariablesGlobales.IdMantenimeinto = VariablesGlobales.IdMantenimeinto;
            Mantenimiento.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MostrarListadoTipoPago();
        }

        private void txtNumeroPagina_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroPagina.Value < 1)
            {
                txtNumeroPagina.Value = 1;
                MostrarListadoTipoPago();
            }
            else {
                MostrarListadoTipoPago();
            }
        }

        private void txtNumeroRegistros_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroRegistros.Value < 1)
            {
                txtNumeroRegistros.Value = 10;
                MostrarListadoTipoPago();
            }
            else {
                MostrarListadoTipoPago();
            }
        }

        private void dtListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            RestablecerPantalla();
        }

        private void DtListado_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("¿Quieres seleccionar este registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.VariablesGlobales.IdMantenimeinto = Convert.ToDecimal(this.dtListado.CurrentRow.Cells["IdTipoPago"].Value.ToString());
                var Buscar = ObjDataServicio.Value.BuscaTipoPago(
                    VariablesGlobales.IdMantenimeinto,
                    null, 1, 1);
                dtListado.DataSource = Buscar;
                OcultarColumnas();
                btnNuevo.Enabled = false;
                btnEditar.Enabled = true;
                btnRestablecer.Enabled = true;
                txtNumeroPagina.Enabled = false;
                txtNumeroRegistros.Enabled = false;
            }
        }
    }
}
