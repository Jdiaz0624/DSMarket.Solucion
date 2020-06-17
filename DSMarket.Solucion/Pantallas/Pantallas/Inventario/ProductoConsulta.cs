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
    public partial class ProductoConsulta : Form
    {
        public ProductoConsulta()
        {
            InitializeComponent();
        }
        public DSMarket.Logica.Comunes.VariablesGlobales variablesGlobales = new Logica.Comunes.VariablesGlobales();
        #region APLICAR TEMA
        private void TemaPredeterminado()
        {
            this.BackColor = SystemColors.Control;

            txtdescripcion.BackColor = Color.WhiteSmoke;
            txtCodigoBarra.BackColor = Color.WhiteSmoke;
            txtReferencia.BackColor = Color.WhiteSmoke;
            txtNumeroPagina.BackColor = Color.WhiteSmoke;
            txtNumeroRegistros.BackColor = Color.WhiteSmoke;
            ddlSeleccionarCategoria.BackColor = Color.WhiteSmoke;
            ddlSeleccionarMarca.BackColor = Color.WhiteSmoke;
            ddlSeleccionarModelo.BackColor = Color.WhiteSmoke;
            ddlSeleccionarTipoProducto.BackColor = Color.WhiteSmoke;
            ddlSeleccionarUnidadMedida.BackColor = Color.WhiteSmoke;

            txtdescripcion.ForeColor = Color.Black;
            txtCodigoBarra.ForeColor = Color.Black;
            txtReferencia.ForeColor = Color.Black;
            txtNumeroPagina.ForeColor = Color.Black;
            txtNumeroRegistros.ForeColor = Color.Black;
            ddlSeleccionarCategoria.ForeColor = Color.Black;
            ddlSeleccionarMarca.ForeColor = Color.Black;
            ddlSeleccionarModelo.ForeColor = Color.Black;
            ddlSeleccionarTipoProducto.ForeColor = Color.Black;
            ddlSeleccionarUnidadMedida.ForeColor = Color.Black;

            dtListado.BackgroundColor = SystemColors.Control;



        }
        #endregion

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ProductoConsulta_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void ProductoConsulta_Load(object sender, EventArgs e)
        {
            lbTitulo.Text = "CONSULTA DE INVENTARIO";
            lbTitulo.ForeColor = Color.WhiteSmoke;
            TemaPredeterminado();
            cbAgregarRangoFecha.ForeColor = Color.DarkRed;
            cbAgregarFiltroPreciso.ForeColor = Color.DarkRed;
            rbAmbos.Checked = true;
            rbAmbos.ForeColor = Color.LimeGreen;
            rbConOferta.ForeColor = Color.DarkRed;
            rbConOferta.ForeColor = Color.DarkRed;

            cbAgregarFiltroPreciso.Checked = false;
            cbAgregarRangoFecha.Checked = false;

            lbTipoProducto.Visible = false;
            ddlSeleccionarTipoProducto.Visible = false;
            lbCategoria.Visible = false;
            ddlSeleccionarCategoria.Visible = false;
            lbUnidadMdida.Visible = false;
            ddlSeleccionarUnidadMedida.Visible = false;
            lbMArca.Visible = false;
            ddlSeleccionarMarca.Visible = false;
            lbModelo.Visible = false;
            ddlSeleccionarModelo.Visible = false;
            lbFechaDesde.Visible = false;
            txtFechaDesde.Visible = false;
            lbFechaHasta.Visible = false;
            txtFechaHasta.Visible = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAgregarFiltroPreciso.Checked == true)
            {
                cbAgregarFiltroPreciso.ForeColor = Color.LimeGreen;
                lbTipoProducto.Visible = true;
                ddlSeleccionarTipoProducto.Visible = true;
                lbCategoria.Visible = true;
                ddlSeleccionarCategoria.Visible = true;
                lbUnidadMdida.Visible = true;
                ddlSeleccionarUnidadMedida.Visible = true;
                lbMArca.Visible = true;
                ddlSeleccionarMarca.Visible = true;
                lbModelo.Visible = true;
                ddlSeleccionarModelo.Visible = true;
            }
            else
            {
                cbAgregarFiltroPreciso.ForeColor = Color.DarkRed;
                lbTipoProducto.Visible = false;
                ddlSeleccionarTipoProducto.Visible = false;
                lbCategoria.Visible = false;
                ddlSeleccionarCategoria.Visible = false;
                lbUnidadMdida.Visible = false;
                ddlSeleccionarUnidadMedida.Visible = false;
                lbMArca.Visible = false;
                ddlSeleccionarMarca.Visible = false;
                lbModelo.Visible = false;
                ddlSeleccionarModelo.Visible = false;
            }
        }

        private void cbAgregarRangoFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAgregarRangoFecha.Checked == true)
            {

                cbAgregarRangoFecha.ForeColor = Color.LimeGreen;
                lbFechaDesde.Visible = true;
                txtFechaDesde.Visible = true;
                lbFechaHasta.Visible = true;
                txtFechaHasta.Visible = true;
            }
            else
            {
                cbAgregarRangoFecha.ForeColor = Color.DarkRed;
                lbFechaDesde.Visible = false;
                txtFechaDesde.Visible = false;
                lbFechaHasta.Visible = false;
                txtFechaHasta.Visible = false;
            }
        }

        private void rbAmbos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAmbos.Checked == true)
            {
                rbConOferta.ForeColor = Color.DarkRed;
                rbAmbos.ForeColor = Color.LimeGreen;
                rbSinOferta.ForeColor = Color.DarkRed;
            }
            else {
                rbConOferta.ForeColor = Color.DarkRed;
                rbAmbos.ForeColor = Color.DarkRed;
                rbSinOferta.ForeColor = Color.DarkRed;

            }
        }

        private void rbConOferta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbConOferta.Checked == true)
            {
                rbConOferta.ForeColor = Color.LimeGreen;
                rbAmbos.ForeColor = Color.DarkRed;
                rbSinOferta.ForeColor = Color.DarkRed;
            }
            else
            {
                rbConOferta.ForeColor = Color.DarkRed;
                rbAmbos.ForeColor = Color.DarkRed;
                rbSinOferta.ForeColor = Color.DarkRed;
            }
        }

        private void rbSinOferta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSinOferta.Checked == true)
            {
                rbConOferta.ForeColor = Color.DarkRed;
                rbAmbos.ForeColor = Color.DarkRed;
                rbSinOferta.ForeColor = Color.LimeGreen;
            }
            else
            {
                rbConOferta.ForeColor = Color.DarkRed;
                rbAmbos.ForeColor = Color.DarkRed;
                rbSinOferta.ForeColor = Color.DarkRed;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.MantenimientoProducto Mantenimiento = new MantenimientoProducto();
            Mantenimiento.VariablesGlobales.Accion = "INSERT";
            Mantenimiento.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.MantenimientoProducto Mantenimiento = new MantenimientoProducto();
            Mantenimiento.VariablesGlobales.Accion = "UPDATE";
            Mantenimiento.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.MantenimientoProducto Mantenimiento = new MantenimientoProducto();
            Mantenimiento.VariablesGlobales.Accion = "DELETE";
            Mantenimiento.ShowDialog();
        }

        private void btnSuplir_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.AgregarQuitarProductos Suplir = new AgregarQuitarProductos();
            Suplir.ShowDialog();
        }

        private void btnOferta_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.AgregarOferta Oferta = new AgregarOferta();
            Oferta.ShowDialog();
        }
    }
}
