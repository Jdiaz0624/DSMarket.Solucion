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
    public partial class MantenimientoProducto : Form
    {
        public MantenimientoProducto()
        {
            InitializeComponent();
        }
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();
        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.ProductoConsulta Consulta = new ProductoConsulta();
            Consulta.ShowDialog();
        }

        private void MantenimientoProducto_Load(object sender, EventArgs e)
        {

            lbTitulo.ForeColor = Color.WhiteSmoke;
            if (VariablesGlobales.Accion == "INSERT")
            {
                lbTitulo.Text = "CREAR NUEVO PRODUCTO";
                btnGuardar.Text = "Guardar";

                lbCLaveSeguridad.Visible = false;
                txtClaveSeguridad.Visible = false;
            }
            else if (VariablesGlobales.Accion == "UPDATE")
            {
                lbTitulo.Text = "MODIFICAR PRODUCTO SELECCIONADO";
                btnGuardar.Text = "Modificar";

                lbCLaveSeguridad.Visible = true;
                txtClaveSeguridad.Visible = true;
                txtStock.Enabled = false;
            }
            else if(VariablesGlobales.Accion=="DELETE")
            {
                lbTitulo.Text = "ELIMINAR PRODUCTO SELECCIONADO";
                btnGuardar.Text = "Eliminar";

                ddlSeleccionarTipoProducto.Enabled = false;
                ddlSeleccionarCategoria.Enabled = false;
                ddlSeleccionarUnidadMedida.Enabled = false;
                ddlSeleccionarMarca.Enabled = false;
                ddlSeleccionarModelo.Enabled = false;
                ddlSeleccionarTipoSuplidor.Enabled = false;
                ddlSeleccionarSuplidor.Enabled = false;
                txtdescripcion.Enabled = false;
                txtComentario.Enabled = false;
                txtCodigoBarra.Enabled = false;
                txtReferencia.Enabled = false;
                txtPrecioCompra.Enabled = false;
                txtPrecioVenta.Enabled = false;
                txtStock.Enabled = false;
                txtStockMinimo.Enabled = false;
                txtPorcientoDescuento.Enabled = false;
                btnAgregarTipoProducto.Enabled = false;
                btnRefrescarTipoProducto.Enabled = false;
                btnAgregarCategoria.Enabled = false;
                btnRefrescarCategoria.Enabled = false;
                btnAgregarUnidadMedida.Enabled = false;
                btnRefrescarUnidadMedida.Enabled = false;
                btnAgregarMarca.Enabled = false;
                btnRefrescarMarca.Enabled = false;
                btnAgregarModelo.Enabled = false;
                btnRefrescarModelo.Enabled = false;
                btnAgregarTipoSuplidor.Enabled = false;
                btnRefrescarTipoSuplidor.Enabled = false;
                btnAgregarSuplidor.Enabled = false;
                btnRefrescarSuplidor.Enabled = false;
                cbAceptaOferta.Enabled = false;

                lbCLaveSeguridad.Visible = true;
                txtClaveSeguridad.Visible = true;

                btnBuscarFoto.Enabled = false;
            }

            
        }
    }
}
