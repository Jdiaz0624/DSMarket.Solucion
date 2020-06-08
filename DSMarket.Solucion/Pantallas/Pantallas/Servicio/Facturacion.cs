using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace DSMarket.Solucion.Pantallas.Pantallas.Servicio
{
    public partial class Facturacion : Form
    {
        public Facturacion()
        {
            InitializeComponent();
        }
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region BLOQUEAR Y DESBLOQUEAR CONTROLES DEL LADO DEL CLIENTE
        private void BloarControlesClientes() {
            txtCodigoCliente.Enabled = false;
            btnAgregarAlmacen.Enabled = false;
            btnRegresar.Enabled = false;
            ddlTipoFacturacion.Enabled = false;
            txtTelefono.Enabled = false;
            txtEmail.Enabled = false;
            ddlTipoIdentificacion.Enabled = false;
            txtIdentificacion.Enabled = false;
            txtDireccion.Enabled = false;
            txtComentario.Enabled = false;
            txtNombrePaciente.Enabled = false;

            //CARGAR LOS TIPOS DE FACTURACION
            //CARGAR LOS TIPOS DE IDENTIFICACION

            txtCodigoCliente.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtIdentificacion.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtComentario.Text = string.Empty;
            txtNombrePaciente.Text = string.Empty;

            txtNombrePaciente.Text = "CLIENTE CONSUMIDOR FINAL";
            txtIdentificacion.Text = "00000000000";
        }
        private void DesbloquearControlesClientes() {
            txtCodigoCliente.Enabled = true;
            btnAgregarAlmacen.Enabled = true;
            btnRegresar.Enabled = true;
            ddlTipoFacturacion.Enabled = true;
            txtTelefono.Enabled = true;
            txtEmail.Enabled = true;
            ddlTipoIdentificacion.Enabled = true;
            txtIdentificacion.Enabled = true;
            txtDireccion.Enabled = true;
            txtComentario.Enabled = true;
            txtNombrePaciente.Enabled = true;

            txtCodigoCliente.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtIdentificacion.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtComentario.Text = string.Empty;
            txtNombrePaciente.Text = string.Empty;
        }
        #endregion
        #region APLICAR TEMA
        private void TemaGenerico() {
            //COLOR DE FONDO
            this.BackColor = SystemColors.Control;


            //COLOR DE TEMBOX
            txtCodigoCliente.BackColor = Color.WhiteSmoke;
            ddlTipoFacturacion.BackColor = Color.WhiteSmoke;
            txtNombrePaciente.BackColor = Color.WhiteSmoke;
            txtTelefono.BackColor = Color.WhiteSmoke;
            txtEmail.BackColor = Color.WhiteSmoke;
            txtNoCotizacion.BackColor = Color.WhiteSmoke;
            ddlTipoIdentificacion.BackColor = Color.WhiteSmoke;
            txtIdentificacion.BackColor = Color.WhiteSmoke;
            txtDireccion.BackColor = Color.WhiteSmoke;
            txtComentario.BackColor = Color.WhiteSmoke;
            ddlTipoVenta.BackColor = Color.WhiteSmoke;
            ddlCantidadDias.BackColor = Color.WhiteSmoke;
            txtCantidadArtiuclos.BackColor = Color.WhiteSmoke;
            txtTotalDescuento.BackColor = Color.WhiteSmoke;
            txtSubtotal.BackColor = Color.WhiteSmoke;
            txtImpuesto.BackColor = Color.WhiteSmoke;
            txtPorcientoImpuesto.BackColor = Color.WhiteSmoke;
            txtTotal.BackColor = Color.WhiteSmoke;
            ddltIPago.BackColor = Color.WhiteSmoke;
            txtMontoPagar.BackColor = Color.WhiteSmoke;
            txtCambio.BackColor = Color.WhiteSmoke;
            txtCantidadServicios.BackColor = Color.WhiteSmoke;

            //COLOR DE FUENTE
            txtCodigoCliente.ForeColor = Color.Black;
            ddlTipoFacturacion.ForeColor = Color.Black;
            txtNombrePaciente.ForeColor = Color.Black;
            txtTelefono.ForeColor = Color.Black;
            txtEmail.ForeColor = Color.Black;
            txtNoCotizacion.ForeColor = Color.Black;
            ddlTipoIdentificacion.ForeColor = Color.Black;
            txtIdentificacion.ForeColor = Color.Black;
            txtDireccion.ForeColor = Color.Black;
            txtComentario.ForeColor = Color.Black;
            ddlTipoVenta.ForeColor = Color.Black;
            ddlCantidadDias.ForeColor = Color.Black;
            txtCantidadArtiuclos.ForeColor = Color.Black;
            txtTotalDescuento.ForeColor = Color.Black;
            txtSubtotal.ForeColor = Color.Black;
            txtImpuesto.ForeColor = Color.Black;
            txtPorcientoImpuesto.ForeColor = Color.Black;
            txtTotal.ForeColor = Color.Black;
            ddltIPago.ForeColor = Color.Black;
            txtMontoPagar.ForeColor = Color.Black;
            txtCambio.ForeColor = Color.Black;
            txtCantidadServicios.ForeColor = Color.Black;

            dtProductosAgregados.BackgroundColor = SystemColors.Control;
            dtFacturasMinimizadas.BackgroundColor = SystemColors.Control;

        }
        #endregion
        #region METODOS PARA MOVER LA PANTALLA
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        #endregion
        private void Facturacion_Load(object sender, EventArgs e)
        {
            TemaGenerico();
            lbTitulo.Text = "FACTURACION";
            lbTitulo.ForeColor = Color.White;
            lbCredito.Text = "Credito:";
            lbCredito.ForeColor = Color.White;
            lbMontoCredito.Text = "0.00";
            lbMontoCredito.ForeColor = Color.White;
            rbFacturar.Checked = true;
            BloarControlesClientes();
            rbFacturar.ForeColor = Color.LimeGreen;
            rbCotizar.ForeColor = Color.DarkRed;
            cbAgregarCliente.ForeColor = Color.DarkRed;
            rbfacturaspanish.Checked = true;
            rbfacturaspanish.ForeColor = Color.LimeGreen;
            rbfacturaenglish.ForeColor = Color.DarkRed;
            cbFacturaPuntoVenta.ForeColor = Color.DarkRed;
            cbFacturaPuntoVenta.Checked = false;
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            
        }

        private void rbFacturar_CheckedChanged(object sender, EventArgs e)
        {
            if (VariablesGlobales.ConvertirCotizacionFactura == true)
            {
                lbTitulo.Text = "CONVERTIR COTIZACION A FACTURA";
            }
            else
            {
                if (rbFacturar.Checked == true)
                {
                    lbTitulo.Text = "FACTURACION";
                    rbFacturar.ForeColor = Color.LimeGreen;
                }
                else
                {
                    lbTitulo.Text = "COTIZACION";
                    rbFacturar.ForeColor = Color.DarkRed;
                }
            }
        }

        private void rbCotizar_CheckedChanged(object sender, EventArgs e)
        {
            if (VariablesGlobales.ConvertirCotizacionFactura == true)
            {
                lbTitulo.Text = "CONVERTIR COTIZACION A FACTURA";
            }
            else
            {
                if (rbCotizar.Checked == true)
                {
                    lbTitulo.Text = "COTIZACION";
                    rbCotizar.ForeColor = Color.LimeGreen;
                }
                else
                {
                    lbTitulo.Text = "FACTURACION";
                    rbCotizar.ForeColor = Color.DarkRed;
                }
            }
        }

        private void cbAgregarCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAgregarCliente.Checked == true)
            {
                lbCredito.Visible = true;
                lbMontoCredito.Visible = true;
                DesbloquearControlesClientes();
                cbAgregarCliente.ForeColor = Color.LimeGreen;
            }
            else
            {
                lbCredito.Visible = false;
                lbMontoCredito.Visible = false;
                BloarControlesClientes();
                cbAgregarCliente.ForeColor = Color.DarkRed;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Servicio.AgregarProductos AddProducts = new AgregarProductos();
            AddProducts.ShowDialog();
        }

        private void Facturacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            //switch (e.CloseReason)
            //{
            //    case CloseReason.UserClosing:
            //        e.Cancel = true;
            //        break;
            //}
        }

        private void rbfacturaspanish_CheckedChanged(object sender, EventArgs e)
        {
            if (rbfacturaspanish.Checked == true)
            {
                rbfacturaspanish.ForeColor = Color.LimeGreen;
                rbfacturaenglish.ForeColor = Color.DarkRed;
            }
            else
            {
                rbfacturaspanish.ForeColor = Color.DarkRed;
                rbfacturaenglish.ForeColor = Color.DarkRed;
            }
        }

        private void rbfacturaenglish_CheckedChanged(object sender, EventArgs e)
        {
            if (rbfacturaenglish.Checked == true)
            {
                rbfacturaspanish.ForeColor = Color.DarkRed;
                rbfacturaenglish.ForeColor = Color.LimeGreen;
            }
            else
            {
                rbfacturaspanish.ForeColor = Color.DarkRed;
                rbfacturaenglish.ForeColor = Color.DarkRed;
            }
        }

        private void cbFacturaPuntoVenta_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFacturaPuntoVenta.Checked == true)
            {
                cbFacturaPuntoVenta.ForeColor = Color.LimeGreen;
            }
            else
            {
                cbFacturaPuntoVenta.ForeColor = Color.DarkRed;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
        }

        private void PCerrar_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
