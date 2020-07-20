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
    public partial class HistorialFActuracion : Form
    {
        public HistorialFActuracion()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaServicio.LogicaServicio> ObhDataServicio = new Lazy<Logica.Logica.LogicaServicio.LogicaServicio>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();
        #region APLCIAR TEMA
        private void AplicarTema() {
            this.BackColor = SystemColors.Control;


        }
        #endregion

        #region MOSTRAR EL LISTADO DE LAS VENTAS
        private void MostrarListadoVentas() {
            try {
                if (cbNoagregarRangofecha.Checked == true) {
                    //HACEMOS LA CONSULTA AGREGANDO RANGO DE FECHA
                    if (rbGenerar.Checked == true) {
                        string _NombrreCliente = string.IsNullOrEmpty(txtParametro.Text.Trim()) ? null : txtParametro.Text.Trim();

                        var BuscarRegistro = ObhDataServicio.Value.HistorialFacturacion(
                            new Nullable<decimal>(),
                            null,
                            null,
                            null,
                            _NombrreCliente,
                            Convert.ToDateTime(txtFechaDesde.Text),
                            Convert.ToDateTime(txtFechaHasta.Text),
                            Convert.ToInt32(txtNumeroPagina.Value),
                            Convert.ToInt32(txtNumeroRegistros.Value));
                        dtListado.DataSource = BuscarRegistro;
                    }
                    else if (rbNumero.Checked == true) {

                    }
                    else if (rbEstatus.Checked == true) {

                    }
                    else if (rbTipoFacturacion.Checked == true) {

                    }
                    else if (rbTipoPago.Checked == true) {

                    }
                    else {
                        MessageBox.Show("Favor de seleccionar una opción para consultar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else {
                    //HACEMOS LA CONSULTA SIN AGREGAR RANGO DE FECHA
                    if (rbGenerar.Checked == true)
                    {
                        string _NombrreCliente = string.IsNullOrEmpty(txtParametro.Text.Trim()) ? null : txtParametro.Text.Trim();

                        var BuscarRegistro = ObhDataServicio.Value.HistorialFacturacion(
                            new Nullable<decimal>(),
                            null,
                            null,
                            null,
                            _NombrreCliente,
                            null,
                            null,
                            Convert.ToInt32(txtNumeroPagina.Value),
                            Convert.ToInt32(txtNumeroRegistros.Value));
                        dtListado.DataSource = BuscarRegistro;
                    }
                    else if (rbNumero.Checked == true)
                    {

                    }
                    else if (rbEstatus.Checked == true)
                    {

                    }
                    else if (rbTipoFacturacion.Checked == true)
                    {

                    }
                    else if (rbTipoPago.Checked == true)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Favor de seleccionar una opción para consultar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Error al mostrar el listado, codigo de error--> " + ex.Message, VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        private void HistorialFActuracion_Load(object sender, EventArgs e)
        {
            rbGenerar.ForeColor = Color.LimeGreen;
            rbNumero.ForeColor = Color.DarkRed;
            rbEstatus.ForeColor = Color.DarkRed;
            rbTipoFacturacion.ForeColor = Color.DarkRed;
            rbTipoPago.ForeColor = Color.DarkRed;
            cbNoagregarRangofecha.ForeColor = Color.DarkRed;
            rbGenerar.Checked = true;
            lbCantidadRegistrosTitulo.ForeColor = Color.White;
            lbCantidadRegistros.ForeColor = Color.White;
            lbCantidadRegistrosVariable.ForeColor = Color.White;
            lbFechaDesde.Visible = false;
            txtFechaDesde.Visible = false;
            lbFechaHAsta.Visible = false;
            txtFechaHasta.Visible = false;
           // lbParametro.Visible = false;
          //  txtParametro.Visible = false;
            lbSeleccionar.Visible = false;
            ddlSeleccionar.Visible = false;
        }

        private void rbGenerar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGenerar.Checked == true)
            {
                rbGenerar.ForeColor = Color.LimeGreen;
                rbNumero.ForeColor = Color.DarkRed;
                rbEstatus.ForeColor = Color.DarkRed;
                rbTipoFacturacion.ForeColor = Color.DarkRed;
                rbTipoPago.ForeColor = Color.DarkRed;
                // cbNoagregarRangofecha.ForeColor = Color.DarkRed;

                txtParametro.Text = string.Empty;
                lbParametro.Visible = true;
                txtParametro.Visible = true;
                lbSeleccionar.Visible = false;
                ddlSeleccionar.Visible = false;
            }
            else
            {
                rbGenerar.ForeColor = Color.DarkRed;
                rbNumero.ForeColor = Color.DarkRed;
                rbEstatus.ForeColor = Color.DarkRed;
                rbTipoFacturacion.ForeColor = Color.DarkRed;
                rbTipoPago.ForeColor = Color.DarkRed;
               // cbNoagregarRangofecha.ForeColor = Color.DarkRed;

                lbParametro.Visible = false;
                txtParametro.Visible = false;
                lbSeleccionar.Visible = false;
                ddlSeleccionar.Visible = false;
            }
        }

        private void rbNumero_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNumero.Checked == true)
            {
                rbGenerar.ForeColor = Color.DarkRed;
                rbNumero.ForeColor = Color.LimeGreen;
                rbEstatus.ForeColor = Color.DarkRed;
                rbTipoFacturacion.ForeColor = Color.DarkRed;
                rbTipoPago.ForeColor = Color.DarkRed;
                //  cbNoagregarRangofecha.ForeColor = Color.DarkRed;

                txtParametro.Text = string.Empty;
                lbParametro.Visible = true;
                txtParametro.Visible = true;
                lbSeleccionar.Visible = false;
                ddlSeleccionar.Visible = false;
            }
            else
            {
                rbGenerar.ForeColor = Color.DarkRed;
                rbNumero.ForeColor = Color.DarkRed;
                rbEstatus.ForeColor = Color.DarkRed;
                rbTipoFacturacion.ForeColor = Color.DarkRed;
                rbTipoPago.ForeColor = Color.DarkRed;
             //   cbNoagregarRangofecha.ForeColor = Color.DarkRed;

                lbParametro.Visible = false;
                txtParametro.Visible = false;
                lbSeleccionar.Visible = false;
                ddlSeleccionar.Visible = false;
            }
        }

        private void rbEstatus_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEstatus.Checked == true)
            {
                rbGenerar.ForeColor = Color.DarkRed;
                rbNumero.ForeColor = Color.DarkRed;
                rbEstatus.ForeColor = Color.LimeGreen;
                rbTipoFacturacion.ForeColor = Color.DarkRed;
                rbTipoPago.ForeColor = Color.DarkRed;
              //  cbNoagregarRangofecha.ForeColor = Color.DarkRed;

                lbParametro.Visible = false;
                txtParametro.Visible = false;
                lbSeleccionar.Visible = true;
                ddlSeleccionar.Visible = true;
            }
            else
            {
                rbGenerar.ForeColor = Color.DarkRed;
                rbNumero.ForeColor = Color.DarkRed;
                rbEstatus.ForeColor = Color.DarkRed;
                rbTipoFacturacion.ForeColor = Color.DarkRed;
                rbTipoPago.ForeColor = Color.DarkRed;
            //    cbNoagregarRangofecha.ForeColor = Color.DarkRed;

                lbParametro.Visible = false;
                txtParametro.Visible = false;
                lbSeleccionar.Visible = false;
                ddlSeleccionar.Visible = false;
            }
        }

        private void rbTipoFacturacion_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTipoFacturacion.Checked == true)
            {
                rbGenerar.ForeColor = Color.DarkRed;
                rbNumero.ForeColor = Color.DarkRed;
                rbEstatus.ForeColor = Color.DarkRed;
                rbTipoFacturacion.ForeColor = Color.LimeGreen;
                rbTipoPago.ForeColor = Color.DarkRed;
              //  cbNoagregarRangofecha.ForeColor = Color.DarkRed;

                lbParametro.Visible = false;
                txtParametro.Visible = false;
                lbSeleccionar.Visible = true;
                ddlSeleccionar.Visible = true;
            }
            else
            {
                rbGenerar.ForeColor = Color.DarkRed;
                rbNumero.ForeColor = Color.DarkRed;
                rbEstatus.ForeColor = Color.DarkRed;
                rbTipoFacturacion.ForeColor = Color.DarkRed;
                rbTipoPago.ForeColor = Color.DarkRed;
            //    cbNoagregarRangofecha.ForeColor = Color.DarkRed;

                lbParametro.Visible = false;
                txtParametro.Visible = false;
                lbSeleccionar.Visible = false;
                ddlSeleccionar.Visible = false;
            }
        }

        private void rbTipoPago_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTipoPago.Checked == true)
            {
                rbGenerar.ForeColor = Color.DarkRed;
                rbNumero.ForeColor = Color.DarkRed;
                rbEstatus.ForeColor = Color.DarkRed;
                rbTipoFacturacion.ForeColor = Color.DarkRed;
                rbTipoPago.ForeColor = Color.LimeGreen;
            //    cbNoagregarRangofecha.ForeColor = Color.DarkRed;

                lbParametro.Visible = false;
                txtParametro.Visible = false;
                lbSeleccionar.Visible = true;
                ddlSeleccionar.Visible = true;
            }
            else
            {
                rbGenerar.ForeColor = Color.DarkRed;
                rbNumero.ForeColor = Color.DarkRed;
                rbEstatus.ForeColor = Color.DarkRed;
                rbTipoFacturacion.ForeColor = Color.DarkRed;
                rbTipoPago.ForeColor = Color.DarkRed;
                cbNoagregarRangofecha.ForeColor = Color.DarkRed;

                lbParametro.Visible = false;
                txtParametro.Visible = false;
                lbSeleccionar.Visible = false;
                ddlSeleccionar.Visible = false;
            }
        }

        private void cbNoagregarRangofecha_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNoagregarRangofecha.Checked == true)
            {
                //rbGenerar.ForeColor = Color.DarkRed;
                //rbNumero.ForeColor = Color.DarkRed;
                //rbEstatus.ForeColor = Color.DarkRed;
                //rbTipoFacturacion.ForeColor = Color.DarkRed;
                //rbTipoPago.ForeColor = Color.DarkRed;
                cbNoagregarRangofecha.ForeColor = Color.LimeGreen;

                lbFechaDesde.Visible = true;
                txtFechaDesde.Visible = true;
                lbFechaHAsta.Visible = true;
                txtFechaHasta.Visible = true;
            }
            else
            {
                //rbGenerar.ForeColor = Color.DarkRed;
                //rbNumero.ForeColor = Color.DarkRed;
                //rbEstatus.ForeColor = Color.DarkRed;
                //rbTipoFacturacion.ForeColor = Color.DarkRed;
                //rbTipoPago.ForeColor = Color.DarkRed;
                cbNoagregarRangofecha.ForeColor = Color.DarkRed;

                lbFechaDesde.Visible = false;
                txtFechaDesde.Visible = false;
                lbFechaHAsta.Visible = false;
                txtFechaHasta.Visible = false;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            DSMarket.Solucion.Pantallas.Pantallas.Servicio.Facturacion Convertir = new Facturacion();
            Convertir.VariablesGlobales.ConvertirCotizacionFactura = true;
            Convertir.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Servicio.AnularFactura Anular = new AnularFactura();
            Anular.ShowDialog();
        }

        private void HistorialFActuracion_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtParametro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rbNumero.Checked == true) {
                DSMarket.Logica.Comunes.ValidarControles.SoloNumeros(e);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MostrarListadoVentas();
        }
    }
}
