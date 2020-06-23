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

        #region APLICAR TEMA
        private void APlicarTema()
        {
            this.BackColor = SystemColors.Control;

            txtCantidad.BackColor = Color.WhiteSmoke;
            txtCantidad.ForeColor = Color.Black;
            txtClaveSeguridad.BackColor = Color.WhiteSmoke;
            txtClaveSeguridad.ForeColor = Color.Black;


        }
        #endregion
        #region SACAR LOS DATOS DEL PRODUCTO
        private void SacardatosProducto(decimal IdProducto, decimal NumeroConector)
        {
            var SacarDatos = ObjDataInventario.Value.BuscaProductos(
                IdProducto,
                NumeroConector,
                null, null, null, null, null, null, null, null, null, null, null, 1, 1);
            foreach (var n in SacarDatos)
            {
                lbTipoProductoVariable.Text = n.TipoProducto;
                lbCategoriaVariable.Text = n.Categoria;
                lbUnidadMedidaVariable.Text = n.UnidadMedida;
                lbMarcaVariable.Text = n.Marca;
                lbModeloVariable.Text = n.Modelo;
                lbTipoSuplidorvariable.Text = n.TipoSuplidor;
                lbSuplidorVariable.Text = n.Suplidor;
                lbDescripcionVariable.Text = n.Producto;
                lbComentarioVariable.Text = n.Comentario;
                lbCodigoBarraVariable.Text = n.CodigoBarra;
                lbReferenciaVariable.Text = n.Referencia;
                lbPrecioCompraVariable.Text = n.PrecioCompra.ToString();
                lbPrecioVentaVariable.Text = n.PrecioVenta.ToString();
                lbStickVariable.Text = n.Stock.ToString();
                lbStockMinimoVariable.Text = n.StockMinimo.ToString();
                lbPorcientoDescuentoVariable.Text = n.PorcientoDescuento.ToString();

                int CantidadAlmacen = Convert.ToInt32(n.Stock);
                if (CantidadAlmacen == 0)
                {
                    rbSacarProducto.Enabled = false;
                }
                
                //cbAceptaOferta.Checked = (n.AfectaOferta0.HasValue ? n.AfectaOferta0.Value : false);
                //cbacumulativo.Checked = (n.ProductoAcumulativo0.HasValue ? n.ProductoAcumulativo0.Value : false);
                //cbLlevaImagen.Checked = (n.LlevaImagen0.HasValue ? n.LlevaImagen0.Value : false);

                //if (cbLlevaImagen.Checked == true)
                //{
                //    //HALAR LA IMAGEN
                //}
            }
        }
        #endregion
        #region AGREGAR O SACAR PRODUCTOS
        private void MANSacarIngresar() {
            DSMarket.Logica.Entidades.EntidadesInventario.EProducto Operacion = new Logica.Entidades.EntidadesInventario.EProducto();

            Operacion.IdProducto = VariablesGlobales.IdMantenimeinto;
            Operacion.NumeroConector = VariablesGlobales.NumeroConector;
            Operacion.Stock = Convert.ToDecimal(txtCantidad.Text);

            var MAN = ObjDataInventario.Value.MantenimientoProducto(Operacion, VariablesGlobales.Accion);
        }
        #endregion
        #region CERRAR PANTALLA
        private void CerrarPantalla() {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.ProductoConsulta Consulta = new ProductoConsulta();
            Consulta.variablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Consulta.ShowDialog();
        }
        #endregion
        private void PCerrar_Click(object sender, EventArgs e)
        {
            CerrarPantalla();
        }

        private void AgregarQuitarProductos_Load(object sender, EventArgs e)
        {
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            rbIngresarProducto.Checked = true;
            rbIngresarProducto.ForeColor = Color.LimeGreen;
            rbSacarProducto.ForeColor = Color.DarkRed;
            APlicarTema();
            SacardatosProducto(VariablesGlobales.IdMantenimeinto, VariablesGlobales.NumeroConector);
            VariablesGlobales.Accion = "ADDPRODUCT";
            rbIngresarProducto.Checked = true;
        }

        private void rbIngresarProducto_CheckedChanged(object sender, EventArgs e)
        {
            if (rbIngresarProducto.Checked == true)
            {
                rbIngresarProducto.ForeColor = Color.LimeGreen;
                rbSacarProducto.ForeColor = Color.DarkRed;
                VariablesGlobales.Accion = "ADDPRODUCT";
            }
            else
            {
                rbIngresarProducto.ForeColor = Color.DarkRed;
                rbSacarProducto.ForeColor = Color.DarkRed;
            }
        }

        private void rbSacarProducto_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSacarProducto.Checked == true)
            {
                rbIngresarProducto.ForeColor = Color.DarkRed;
                rbSacarProducto.ForeColor = Color.LimeGreen;
                VariablesGlobales.Accion = "LESSPRODUCT";
            }
            else
            {
                rbIngresarProducto.ForeColor = Color.DarkRed;
                rbSacarProducto.ForeColor = Color.DarkRed;
            }
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCantidad.Text))
            {
                MessageBox.Show("El campo cantidad no puede estar vacio", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                if (string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()))
                {
                    MessageBox.Show("El campo clave de seguridad no puede estar vacio", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else {
                    string _ClaveSeguridad = string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()) ? null : txtClaveSeguridad.Text.Trim();

                    var Validar = ObjDataSeguridad.Value.BuscaClaveSeguridad(
                        new Nullable<decimal>(),
                        null,
                        DSMarket.Logica.Comunes.SeguridadEncriptacion.Encriptar(_ClaveSeguridad), 1, 1);
                    if (Validar.Count() < 1)
                    {
                        MessageBox.Show("La clave de seguridad no es valida", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtClaveSeguridad.Text = string.Empty;
                        txtClaveSeguridad.Focus();
                    }
                    else
                    {
                        //PROCEDEMOS
                        if (VariablesGlobales.Accion == "LESSPRODUCT")
                        {
                            int CantidadExistente = Convert.ToInt32(lbStickVariable.Text);
                            int CantidadSacar = Convert.ToInt32(txtCantidad.Text);
                            if (CantidadSacar > CantidadExistente)
                            {
                                MessageBox.Show("La cantidad que intentas sacar supera a la cantidad existente, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                MANSacarIngresar();
                                MessageBox.Show("Operación realizada con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                CerrarPantalla();
                            }
                        }
                        else
                        {
                            MANSacarIngresar();
                            MessageBox.Show("Operación realizada con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CerrarPantalla();
                        }
                    }

                }
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            DSMarket.Logica.Comunes.ValidarControles.SoloNumeros(e);
        }
    }
}
