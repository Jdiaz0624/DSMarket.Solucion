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
    public partial class PasarInventarioDefectuoso : Form
    {
        public PasarInventarioDefectuoso()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaInventario.LogicaInventario> ObjdataInventario = new Lazy<Logica.Logica.LogicaInventario.LogicaInventario>();
        Lazy<DSMarket.Logica.Logica.LogicaSeguridad.LogicaSeguridad> ObjDataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad.LogicaSeguridad>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();
        public bool LlevaImagen = false;
        public bool Acumulativo = false;
        public decimal IdTipoProducto = 0;
        public decimal IdCategoria = 0;
        public decimal IdUnidadMedida = 0;
        public decimal IdMarca = 0;
        public decimal IdModelo = 0;
        public decimal IdTipoSuplidor = 0;
        public decimal IdSuplidor = 0;
        public bool AplicaImpuesto = false;
        public DateTime FechaIngreso = DateTime.Now;
        public bool EstatusProducto = false;

        #region SACAR LOS DATOS DEL PRODUCTO
        private void SacarDatosProducto(decimal IdProducto, decimal NumeroConector) {
            var SacarInformacion = ObjdataInventario.Value.BuscaProductos(
                IdProducto,
                NumeroConector,
                null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null,1,1);
            foreach (var n in SacarInformacion) {
                txtTipoProducto.Text = n.TipoProducto;
                txtCategoria.Text = n.Categoria;
                txtUnidadMedida.Text = n.UnidadMedida;
                txtMarca.Text = n.Marca;
                txtModelo.Text = n.Modelo;
                txtTipoSuplidor.Text = n.TipoSuplidor;
                txtSuplidor.Text = n.Suplidor;
                txtCodigoBarra.Text = n.CodigoBarra;
                txtReferencia.Text = n.Referencia;
                decimal PrecioCompra = 0, PrecioVenta = 0, CantidadExistente = 0, CantidadMinima = 0;
                PrecioCompra = Convert.ToDecimal(n.PrecioCompra);
                PrecioVenta = Convert.ToDecimal(n.PrecioVenta);
                CantidadExistente = Convert.ToDecimal(n.Stock);
                CantidadMinima = Convert.ToDecimal(n.StockMinimo);
                txtPrecioCompra.Text = PrecioCompra.ToString("N2");
                txtPrecioVenta.Text = PrecioVenta.ToString("N2");
                txtStock.Text = CantidadExistente.ToString("N0");
                txtStockMinimo.Text = CantidadMinima.ToString("N0");
                txtPorcientoDescuento.Text = n.PorcientoDescuento.ToString();
                txtdescripcion.Text = n.Producto;
                txtComentario.Text = n.Comentario;
                txtAplicaImpuest.Text = n.AplicaParaImpuesto;
                txtAcumulativo.Text = n.ProductoAcumulativo;
                txtCantdadProcesar.Text = "1";
                Acumulativo = Convert.ToBoolean(n.ProductoAcumulativo0);
                IdTipoProducto = Convert.ToDecimal(n.IdTipoProducto);
                IdCategoria = Convert.ToDecimal(n.IdCategoria);
                IdUnidadMedida = Convert.ToDecimal(n.IdUnidadMedida);
                IdMarca = Convert.ToDecimal(n.IdMarca);
                IdModelo = Convert.ToDecimal(n.IdModelo);
                IdTipoSuplidor = Convert.ToDecimal(n.IdTipoSuplidor);
                IdSuplidor = Convert.ToDecimal(n.IdSuplidor);
                AplicaImpuesto = Convert.ToBoolean(n.AplicaParaImpuesto0);
                EstatusProducto = Convert.ToBoolean(n.EstatusProducto0);
                txtNumeroSeguimiento.Text = n.NumeroSeguimiento;
                if (Acumulativo == true)
                {
                    txtCantdadProcesar.Enabled = true;
                }
                else {
                    txtCantdadProcesar.Enabled = false;
                }

                LlevaImagen = Convert.ToBoolean(n.LlevaImagen0);
                if (LlevaImagen == true) {
                    //CARGAMOS AL IMAGEN DEL PRODUCTO
                    SqlCommand comando = new SqlCommand("SELECT FotoProducto FROM Inventario.FotoProducto WHERE IdProducto = " + VariablesGlobales.IdMantenimeinto + " and NumeroConector = " + VariablesGlobales.NumeroConector, DSMarket.Data.Conexion.ConexionADO.BDConexion.ObtenerConexion());
                    SqlDataAdapter adaptar = new SqlDataAdapter(comando);
                    DataSet ds = new DataSet("FotoProducto");
                    adaptar.Fill(ds, "FotoProducto");
                    byte[] DATOS = new byte[0];
                    DataRow dr = ds.Tables["FotoProducto"].Rows[0];
                    DATOS = (byte[])dr["FotoProducto"];
                    MemoryStream ms = new MemoryStream(DATOS);
                    pbFoto.Image = System.Drawing.Bitmap.FromStream(ms);
                }

            }
        }
        #endregion
        #region GUARDAR PRODUCTO DEFECTUOSO
        private void GuardarProductoDefectuoso() {
            DSMarket.Logica.Comunes.ProcesarProductosDefectuosos Defectuoso = new Logica.Comunes.ProcesarProductosDefectuosos(
                       0,
                       VariablesGlobales.NumeroConector,
                       IdTipoProducto,
                       IdCategoria,
                       IdUnidadMedida,
                       IdMarca,
                       IdModelo,
                       IdTipoSuplidor,
                       IdSuplidor,
                       txtdescripcion.Text,
                       txtCodigoBarra.Text,
                       txtReferencia.Text,
                       Convert.ToDecimal(txtPrecioCompra.Text),
                       Convert.ToDecimal(txtPrecioVenta.Text),
                       Convert.ToDecimal(txtStock.Text),
                       Convert.ToDecimal(txtStockMinimo.Text),
                       Convert.ToDecimal(txtPorcientoDescuento.Text),
                       false,
                       Acumulativo,
                       LlevaImagen,
                       VariablesGlobales.IdUsuario,
                       DateTime.Now,
                       VariablesGlobales.IdUsuario,
                       DateTime.Now,
                       FechaIngreso,
                       txtComentario.Text,
                       AplicaImpuesto,
                       false,
                       Convert.ToDecimal(txtCantdadProcesar.Text),
                       txtNumeroSeguimiento.Text,
                       "INSERT");
            Defectuoso.ProcesarInformaicon();
        }
        #endregion
        #region AFECTAR INVENTARIO
        private void AfectarInventario(string Accion) {
            DSMarket.Logica.Entidades.EntidadesInventario.EProducto Afectar = new Logica.Entidades.EntidadesInventario.EProducto();
            Afectar.IdProducto = VariablesGlobales.IdMantenimeinto;
            Afectar.IdTipoProducto = IdTipoProducto;
            Afectar.NumeroConector = VariablesGlobales.NumeroConector;
            Afectar.Stock = Convert.ToDecimal(txtCantdadProcesar.Text);
            Afectar.EstatusProducto0 = EstatusProducto;
            Afectar.ProductoAcumulativo0 = Acumulativo;
            var MAN = ObjdataInventario.Value.MantenimientoProducto(Afectar, Accion);
        }
        #endregion
        #region CERRAR LA PANTALLA
        private void CerrarPantalla() {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.ProductoConsulta Producto = new ProductoConsulta();
            Producto.variablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Producto.ShowDialog();
        }
        #endregion
        private void PasarInventarioDefectuoso_Load(object sender, EventArgs e)
        {
            lbTitulo.Text = "Descartar productos defectuosos";
            lbTitulo.ForeColor = Color.White;
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            CerrarPantalla();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            SacarDatosProducto(VariablesGlobales.IdMantenimeinto, VariablesGlobales.NumeroConector);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //VALIDAMOS LA CLAVE DE SEGURIDAD
            if (string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()))
            {
                MessageBox.Show("El campo clave de seguridad no puede estar vacio para realizar esta operación, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                //VALIDAMOS LA CLAVE DE SEGURIDAD
                string _ClaveSeguridad = string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()) ? null : txtClaveSeguridad.Text.Trim();

                var Validar = ObjDataSeguridad.Value.BuscaClaveSeguridad(
                    new Nullable<decimal>(),
                    null,
                    DSMarket.Logica.Comunes.SeguridadEncriptacion.Encriptar(_ClaveSeguridad),
                    1, 1);
                if (Validar.Count() < 1)
                {
                    MessageBox.Show("La clave de seguriad ingresada no es valida, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtClaveSeguridad.Text = string.Empty;
                    txtClaveSeguridad.Focus();
                }
                else {
                    //REALIZAMOS PROCESOS DE GUARDAR LOS DATOS EN EL INVENTARIO DE PRODUCTOS DEFECTUOSOS Y ELIMINAMOS O DESCONTAMOS

                    //GUARDAMOS
                    if (string.IsNullOrEmpty(txtCantdadProcesar.Text.Trim()))
                    {
                        MessageBox.Show("La cantidad no puede estar vacia, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else {
                        int CantidadProcesar = 0, CantidadAlmacen = 0, Operacion = 0;
                        CantidadProcesar = Convert.ToInt32(txtCantdadProcesar.Text);
                        CantidadAlmacen = Convert.ToInt32(txtStock.Text);

                        if (CantidadProcesar > CantidadAlmacen)
                        {
                            MessageBox.Show("No es posible procesar esta información por que la cantidad a procesar es superior a la cantidad en inventario, favor de verificar e intentarlo nuevamente", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else {
                            Operacion = CantidadAlmacen - CantidadProcesar;
                            if (Acumulativo == true) {
                                GuardarProductoDefectuoso();
                                AfectarInventario("LESSPRODUCT");
                                MessageBox.Show("Proceso completado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                CerrarPantalla();
                            }
                            else {
                                GuardarProductoDefectuoso();
                                AfectarInventario("CHANGESTATUS");
                                MessageBox.Show("Proceso completado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                CerrarPantalla();
                            }
                        }


                    }
                }
            }
        }
    }
}
