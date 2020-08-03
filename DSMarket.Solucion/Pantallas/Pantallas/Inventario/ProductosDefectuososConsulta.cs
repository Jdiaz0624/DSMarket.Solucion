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
    public partial class ProductosDefectuososConsulta : Form
    {
        public ProductosDefectuososConsulta()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaInventario.LogicaInventario> ObjDataInventario = new Lazy<Logica.Logica.LogicaInventario.LogicaInventario>();
        Lazy<DSMarket.Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion> ObjDataConfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion>();
        Lazy<DSMarket.Logica.Logica.LogicaSeguridad.LogicaSeguridad> ObjDataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad.LogicaSeguridad>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region MOSTRAR EL LISTADO DE LOS PRODUCTOS DEFECTUOSOS
        private void MostrarListadoProductosDefectuosos() {
            string _DescripcionProducto = string.IsNullOrEmpty(txtdescripcion.Text.Trim()) ? null : txtdescripcion.Text.Trim();
            string _CodigoBarra = string.IsNullOrEmpty(txtCodigoBarra.Text.Trim()) ? null : txtCodigoBarra.Text.Trim();
            string _Referencia = string.IsNullOrEmpty(txtReferencia.Text.Trim()) ? null : txtReferencia.Text.Trim();

            var BuscarRegistros = ObjDataInventario.Value.BuscaProductosDefectuosos(
                new Nullable<decimal>(),
                null,
                _DescripcionProducto,
                _CodigoBarra,
                _Referencia,
                null, null, null, null, null, null, null, null, null,
                Convert.ToInt32(txtNumeroPagina.Value),
                Convert.ToInt32(txtNumeroRegistros.Value));
            dtListado.DataSource = BuscarRegistros;
            OcultarColumnas();
            if (BuscarRegistros.Count() < 1)
            {
                lbCantidad.Text = "0";
                lbCantidad2.Text = "0";
            }
            else {
                foreach (var n in BuscarRegistros)
                {
                    int CantidadRegistros = Convert.ToInt32(n.CantidadRegistros);
                    lbCantidad.Text = CantidadRegistros.ToString("N0");

                    int TotalProductos = Convert.ToInt32(n.TotalProductos);
                    lbCantidad2.Text = TotalProductos.ToString("N0");
                }
            }
        }
        private void OcultarColumnas() {
            this.dtListado.Columns["IdProductoDefectuoso"].Visible = false;
            this.dtListado.Columns["NumeroConector"].Visible = false;
            this.dtListado.Columns["IdTipoProducto"].Visible = false;
            this.dtListado.Columns["IdCategoria"].Visible = false;
            this.dtListado.Columns["IdUnidadMedida"].Visible = false;
            this.dtListado.Columns["IdMarca"].Visible = false;
            this.dtListado.Columns["IdModelo"].Visible = false;
            this.dtListado.Columns["IdTipoSuplidor"].Visible = false;
            this.dtListado.Columns["IdSuplidor"].Visible = false;
            this.dtListado.Columns["PrecioCompra"].Visible = false;
            this.dtListado.Columns["Stock"].Visible = false;
            this.dtListado.Columns["StockMinimo"].Visible = false;
            this.dtListado.Columns["AfectaOferta0"].Visible = false;
            this.dtListado.Columns["AceptaOferta"].Visible = false;
            this.dtListado.Columns["ProductoAcumulativo0"].Visible = false;
            this.dtListado.Columns["LlevaImagen0"].Visible = false;
            this.dtListado.Columns["LlevaImagen"].Visible = false;
            this.dtListado.Columns["UsuarioAdiciona"].Visible = false;
            this.dtListado.Columns["FechaAdiciona"].Visible = false;
            this.dtListado.Columns["UsuarioModifica"].Visible = false;
            this.dtListado.Columns["ModificadoPor"].Visible = false;
            this.dtListado.Columns["FechaModifica"].Visible = false;
            this.dtListado.Columns["FechaModificado"].Visible = false;
            this.dtListado.Columns["Fecha"].Visible = false;
            this.dtListado.Columns["AplicaParaImpuesto0"].Visible = false;
            this.dtListado.Columns["EstatusProducto0"].Visible = false;
            this.dtListado.Columns["EstatusProducto"].Visible = false;
            this.dtListado.Columns["AplicaParaImpuesto"].Visible = false;
          //  this.dtListado.Columns["CantidadAgregada"].Visible = false;
            this.dtListado.Columns["CantidadRegistros"].Visible = false;
            this.dtListado.Columns["ProductosConOferta"].Visible = false;
            this.dtListado.Columns["ProductoProximoAgotarse"].Visible = false;
            this.dtListado.Columns["ProductosAgostados"].Visible = false;
            this.dtListado.Columns["TotalProductos"].Visible = false;
            this.dtListado.Columns["Comentario"].Visible = false;
        }
        #endregion
        #region GENERAR EL REPORTE
        private void InvocarReporte() {
            string RutaReporte = "";
            string UsuarioBD = "";
            string ClaveBD = "";
            //9 codigo de reporte

            var SacarRutaReporte = ObjDataConfiguracion.Value.BuscaRutaReporte(9);
            foreach (var n in SacarRutaReporte) {
                RutaReporte = n.RutaReporte;
            }

            var SacarCredenciales = ObjDataSeguridad.Value.SacarCredencialBD(1);
            foreach (var n in SacarCredenciales) {
                UsuarioBD = n.Usuario;
                ClaveBD = DSMarket.Logica.Comunes.SeguridadEncriptacion.DesEncriptar(n.Clave);
            }

            //INVOCAMOS

            DSMarket.Solucion.Pantallas.Pantallas.Reportes.Reportes Reporte = new Reportes.Reportes();
            Reporte.GenerarReporteProductosDefectuosos(
                VariablesGlobales.IdUsuario,
                RutaReporte,
                UsuarioBD,
                ClaveBD);
            Reporte.ShowDialog();
        }
        #endregion
        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void ProductosDefectuososConsulta_Load(object sender, EventArgs e)
        {
            lbTitulo.Text = "Listado de productos defectuosos";
            lbTitulo.ForeColor = Color.White;
            lbCantidad.ForeColor = Color.White;
            lbCantidadProductoTitulo.ForeColor = Color.White;
            lbProducto.ForeColor = Color.White;
            lbCantidad2.ForeColor = Color.White;
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.ProductoConsulta consulta = new ProductoConsulta();
            consulta.variablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            consulta.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MostrarListadoProductosDefectuosos();
            lbClaveSeguridad.Visible = false;
            txtClaveSeguridad.Visible = false;
            txtClaveSeguridad.Text = string.Empty;
        }

        private void txtNumeroPagina_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroPagina.Value < 1)
            {
                txtNumeroPagina.Value = 1;
                MostrarListadoProductosDefectuosos();
            }
            else {
                MostrarListadoProductosDefectuosos();
            }
        }

        private void txtNumeroRegistros_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroRegistros.Value < 1)
            {
                txtNumeroRegistros.Value = 10;
                MostrarListadoProductosDefectuosos();
            }
            else {
                MostrarListadoProductosDefectuosos();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.MantenimientoProductoDefectuoso Mantenimiento = new MantenimientoProductoDefectuoso();
            Mantenimiento.VariablesGlobales.IdMantenimeinto = 0;
            Mantenimiento.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Mantenimiento.VariablesGlobales.Accion = "INSERT";
            Mantenimiento.ShowDialog();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            DSMarket.Logica.Entidades.EntidadesConfiguracion.EReporteProductosDefectuosos Eliminar = new Logica.Entidades.EntidadesConfiguracion.EReporteProductosDefectuosos();
            Eliminar.IdUsuario = VariablesGlobales.IdUsuario;
            var MAN = ObjDataConfiguracion.Value.GuardarRegistrosProductosDefectuosos(Eliminar, "DELETE");

            string _DescripcionProducto = string.IsNullOrEmpty(txtdescripcion.Text.Trim()) ? null : txtdescripcion.Text.Trim();
            string _CodigoBarra = string.IsNullOrEmpty(txtCodigoBarra.Text.Trim()) ? null : txtCodigoBarra.Text.Trim();
            string _Referencia = string.IsNullOrEmpty(txtReferencia.Text.Trim()) ? null : txtReferencia.Text.Trim();

            var BuscarRegistros = ObjDataInventario.Value.BuscaProductosDefectuosos(
                new Nullable<decimal>(),
                null,
                _DescripcionProducto,
                _CodigoBarra,
                _Referencia,
                null, null, null, null, null, null, null, null, null,
                Convert.ToInt32(txtNumeroPagina.Value),
                Convert.ToInt32(txtNumeroRegistros.Value));
            foreach (var n in BuscarRegistros) {
                DSMarket.Logica.Comunes.ProcesarRegistrosReporteProductosDefectuosos Procesar = new Logica.Comunes.ProcesarRegistrosReporteProductosDefectuosos(
                    VariablesGlobales.IdUsuario,
                    Convert.ToDecimal(n.NumeroConector),
                    Convert.ToDecimal(n.IdTipoProducto),
                    n.Producto,
                    n.TipoProducto,
                    Convert.ToDecimal(n.IdCategoria),
                    n.Categoria,
                    Convert.ToDecimal(n.IdUnidadMedida),
                    n.UnidadMedida,
                    Convert.ToDecimal(n.IdMarca),
                    n.Marca,
                    Convert.ToDecimal(n.IdModelo),
                    n.Modelo,
                    Convert.ToDecimal(n.IdTipoSuplidor),
                    n.TipoSuplidor,
                    Convert.ToDecimal(n.IdSuplidor),
                    n.Suplidor,
                    n.CodigoBarra,
                    n.Referencia,
                    Convert.ToDecimal(n.PrecioCompra),
                    Convert.ToDecimal(n.PrecioVenta),
                    Convert.ToDecimal(n.Stock),
                    Convert.ToDecimal(n.StockMinimo),
                    Convert.ToDecimal(n.PorcientoDescuento),
                    Convert.ToBoolean(n.AfectaOferta0),
                    n.AceptaOferta,
                    Convert.ToBoolean(n.ProductoAcumulativo0),
                    n.ProductoAcumulativo,
                    Convert.ToBoolean(n.LlevaImagen0),
                    n.LlevaImagen,
                    Convert.ToDecimal(n.UsuarioAdiciona),
                    n.CreadoPor,
                    Convert.ToDateTime(n.FechaAdiciona),
                    n.FechaCreado,
                    Convert.ToDecimal(n.UsuarioModifica),
                    n.ModificadoPor,
                    Convert.ToDateTime(n.FechaModifica),
                    n.FechaModificado,
                    Convert.ToDateTime(n.Fecha),
                    Convert.ToBoolean(n.AplicaParaImpuesto0),
                    Convert.ToBoolean(n.EstatusProducto0),
                    n.EstatusProducto,
                    n.AplicaParaImpuesto,
                    Convert.ToDecimal(n.CantidadAgregada),
                    Convert.ToDecimal(n.CantidadRegistros),
                    Convert.ToDecimal(n.ProductosConOferta),
                    Convert.ToDecimal(n.ProductoProximoAgotarse),
                    Convert.ToDecimal(n.ProductosAgostados),
                    Convert.ToDecimal(n.TotalProductos),
                    n.Comentario,
                    "INSERT");
                Procesar.ProcesarInformacionreporteProductosDefectuosos();
            }

            //INVOCAMOS EL RPEORTE
            InvocarReporte();
        }

        private void cbEliminarTodo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEliminarTodo.Checked)
            {
                btnEliminar.Enabled = true;
                dtListado.Enabled = true;
                lbClaveSeguridad.Visible = true;
                txtClaveSeguridad.Visible = true;
            }
            else {
                btnEliminar.Enabled = false;
                dtListado.Enabled = false;
                lbClaveSeguridad.Visible = false;
                txtClaveSeguridad.Visible = false;
                txtClaveSeguridad.Text = string.Empty;
            }
        }

        private void dtListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("¿Quieres seleccionar este registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                this.VariablesGlobales.IdMantenimeinto = Convert.ToDecimal(this.dtListado.CurrentRow.Cells["IdProductoDefectuoso"].Value.ToString());
                this.VariablesGlobales.NumeroConector = Convert.ToDecimal(this.dtListado.CurrentRow.Cells["NumeroConector"].Value.ToString());

                var BuscarRegostro = ObjDataInventario.Value.BuscaProductosDefectuosos(
                    VariablesGlobales.IdMantenimeinto,
                    VariablesGlobales.NumeroConector,
                    null, null, null, null, null, null, null, null, null, null, null, null, 1, 1);
                dtListado.DataSource = BuscarRegostro;
                OcultarColumnas();
                btnEliminar.Enabled = true;
                lbClaveSeguridad.Visible = true;
                txtClaveSeguridad.Visible = true;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cbEliminarTodo.Checked) {
                //ELIMINAR TODO EL HISTORIAL
                if (string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()))
                {
                    MessageBox.Show("El campo clave de seguridad no puede estar vacio, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()))
                    {
                        errorProvider1.SetError(txtClaveSeguridad, "Campo Vacio");
                    }
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
                            MessageBox.Show("La clave de seguridad ingresada no es valida, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtClaveSeguridad.Text = string.Empty;
                            txtClaveSeguridad.Focus();
                        }
                        else
                        {

                            if (MessageBox.Show("Si procedes eliminaras todos los registros del historial, ¿Quieres continuar con este proceso?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                DSMarket.Logica.Entidades.EntidadesInventario.EProductosDefectuosos Eliminar = new Logica.Entidades.EntidadesInventario.EProductosDefectuosos();
                                var MAN = ObjDataInventario.Value.MantenimientoProductosDefectuoso(Eliminar, "DELETEALL");
                                MessageBox.Show("Todos los registros del historial fueron eliminados exitosamente", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                MostrarListadoProductosDefectuosos();
                                lbClaveSeguridad.Visible = false;
                                txtClaveSeguridad.Visible = false;
                                txtClaveSeguridad.Text = string.Empty;
                                btnEliminar.Enabled = false;
                                cbEliminarTodo.Checked = false;
                            }
                        }
                    }
              
              
          
            }
            else {
                //ELIMINAR EL REGISTRO SELECCIONADO
                //VALIDAMOS SI EL CAMPOS ESTA VACIO
                if (string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()))
                {
                    MessageBox.Show("El campo clave de seguridad no puede estar vacio, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()))
                    {
                        errorProvider1.SetError(txtClaveSeguridad, "Campo Vacio");
                    }
                }
                else {
                    //VALIDAMOS QUE LA CLAVE DE SEGURIDAD INGRESADA ES VALIDA
                    string _ClaveSeguridad = string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()) ? null : txtClaveSeguridad.Text.Trim();

                    var Validar = ObjDataSeguridad.Value.BuscaClaveSeguridad(
                        new Nullable<decimal>(),
                        null,
                        DSMarket.Logica.Comunes.SeguridadEncriptacion.Encriptar(_ClaveSeguridad),
                        1, 1);
                    if (Validar.Count() < 1)
                    {
                        MessageBox.Show("La clave de seguridad ingresada no es valida, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtClaveSeguridad.Text = string.Empty;
                        txtClaveSeguridad.Focus();
                    }
                    else {
                        DSMarket.Logica.Entidades.EntidadesInventario.EProductosDefectuosos Eliminar = new Logica.Entidades.EntidadesInventario.EProductosDefectuosos();
                        Eliminar.IdProductoDefectuoso = VariablesGlobales.IdMantenimeinto;
                        Eliminar.NumeroConector = VariablesGlobales.NumeroConector;
                        var MAN = ObjDataInventario.Value.MantenimientoProductosDefectuoso(Eliminar, "DELETE");
                        MessageBox.Show("Registro eliminado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MostrarListadoProductosDefectuosos();
                        lbClaveSeguridad.Visible = false;
                        txtClaveSeguridad.Visible = false;
                        txtClaveSeguridad.Text = string.Empty;
                        btnEliminar.Enabled = false;
                        cbEliminarTodo.Checked = false;
                    }
                }
            }
        }
    }
}
