using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace DSMarket.Solucion.Pantallas.Pantallas.Inventario
{
    public partial class AgregarQuitarProductos : Form
    {
        public AgregarQuitarProductos()
        {
            InitializeComponent();
        }

        Lazy<DSMarket.Logica.Logica.LogicaListas.LogicaListas> ObjDataListas = new Lazy<Logica.Logica.LogicaListas.LogicaListas>();
        Lazy<DSMarket.Logica.Logica.LogicaInventario.LogicaInventario> ObjDataInventario = new Lazy<Logica.Logica.LogicaInventario.LogicaInventario>();
        Lazy<DSMarket.Logica.Logica.LogicaSeguridad.LogicaSeguridad> ObjDataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad.LogicaSeguridad>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        private void SacarInformacionProductoSeleccionado(decimal IdIdregistro, string NumeroConector) {
            var SacarInformacion = ObjDataInventario.Value.BuscaProductosServicios(
                IdIdregistro,
                NumeroConector,
                null, null, null, null, null, null, null, null, null, null, null, null, null, null, 1, 1);
            foreach (var n in SacarInformacion) {
                lbTipoProductoVariable.Text = n.TipoProducto;
                lbCategoriaVariable.Text = n.Categoria;
                lbMarcaVariable.Text = n.Marca;
                decimal Precio = (decimal)n.PrecioVenta;
                lbPrecioVentaVariable.Text = Precio.ToString("N2");
                int Stock = (int)n.Stock;
                lbStickVariable.Text = Stock.ToString("N0");
                int StockMinimo = (int)n.StockMinimo;
                lbStockMinimoVariable.Text = StockMinimo.ToString("N0");
                lbDescripcionVariable.Text = n.Descripcion;
            }
        }
      
        #region CERRAR PANTALLA
        private void CerrarPantalla() {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.ProductoConsulta Consulta = new ProductoConsulta();
            Consulta.variablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Consulta.ShowDialog();
        }
        #endregion

        private void CompletarOperacion(decimal Cantidad, string Accion) {
            DSMarket.Logica.Comunes.ProcesarInformacion.Inventario.ProcesarInformacionProductoServicio Procesar = new Logica.Comunes.ProcesarInformacion.Inventario.ProcesarInformacionProductoServicio(
                VariablesGlobales.IdMantenimeinto,
                VariablesGlobales.NumeroConectorstring,
                0, 0, 0, 0, 0, "", "", "", "", "", 0, 0,
                Cantidad, 0, "", "", "", "", "", false, false, false, 0, 0, "", 0,
                Accion);
            Procesar.ProcesarInformacion();
            MessageBox.Show("Operación realizada con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
            CerrarPantalla();
        }
        

        private void PCerrar_Click(object sender, EventArgs e)
        {
            CerrarPantalla();
        }

        private void AgregarQuitarProductos_Load(object sender, EventArgs e)
        {
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            rbIngresarProducto.Checked = true;
            SacarInformacionProductoSeleccionado(
                VariablesGlobales.IdMantenimeinto,
                VariablesGlobales.NumeroConectorstring);
        }

        private void rbIngresarProducto_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void rbSacarProducto_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCantidad.Text.Trim()))
            {
                string Operacion = "";
                if (rbIngresarProducto.Checked == true) {
                    Operacion = "Ingresar Items";
                }
                else if (rbSacarProducto.Checked == true) {
                    Operacion = "Sacar Items";
                }
                MessageBox.Show("El campo cantidad no puede estar vacio para " + Operacion + " favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                if (string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim())) {
                    MessageBox.Show("El campo clave de seguridad no puede estar vacio para relizar esta operació, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else {
                    var ValidarClaveSeguridad = ObjDataSeguridad.Value.BuscaClaveSeguridad(
                        new Nullable<decimal>(),
                        null,
                        DSMarket.Logica.Comunes.SeguridadEncriptacion.Encriptar(txtClaveSeguridad.Text.Trim()),
                        1, 1);
                    if (ValidarClaveSeguridad.Count() < 1) {
                        MessageBox.Show("La clave de seguridad ingresada no es valida, favor de verificar.", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else {
                        if (rbIngresarProducto.Checked == true) {
                            CompletarOperacion(
                                Convert.ToDecimal(txtCantidad.Text), "ADDPRODUCT");
                        }
                        else if (rbSacarProducto.Checked == true) {
                     

                            decimal StockActual = Convert.ToDecimal(lbStickVariable.Text);
                            decimal CantidadNueva = Convert.ToDecimal(txtCantidad.Text);
                            if (CantidadNueva > StockActual)
                            {
                                MessageBox.Show("Actualmente tienes " + StockActual.ToString("N0") + "items de este prducto e intentas sacar " + CantidadNueva.ToString("N0") + " por lo tanto esta opción no puede proceder.", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else {
                                CompletarOperacion(Convert.ToDecimal(txtCantidad.Text), "LESSPRODUCT");
                            }
                        }
                    }
                }
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            DSMarket.Logica.Comunes.ValidarControles.SoloNumeros(e);
        }

        private void AgregarQuitarProductos_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason) {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }
    }
}
