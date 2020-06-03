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
        #region APLCIAR TEMA
        private void AplicarTema() {
            this.BackColor = SystemColors.Control;


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

            lbFechaDesde.Visible = false;
            txtFechaDesde.Visible = false;
            lbFechaHAsta.Visible = false;
            txtFechaHasta.Visible = false;
            lbParametro.Visible = false;
            txtParametro.Visible = false;
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

                lbParametro.Visible = false;
                txtParametro.Visible = false;
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
    }
}
