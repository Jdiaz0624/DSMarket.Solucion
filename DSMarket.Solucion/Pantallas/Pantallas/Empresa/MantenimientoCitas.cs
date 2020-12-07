using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSMarket.Solucion.Pantallas.Pantallas.Empresa
{
    public partial class MantenimientoCitas : Form
    {
        Lazy<DSMarket.Logica.Logica.LogicaEmpresa.LogicaEmpresa> ObjDataEmpresa = new Lazy<Logica.Logica.LogicaEmpresa.LogicaEmpresa>();
        Lazy<DSMarket.Logica.Logica.LogicaInventario.LogicaInventario> ObjDataInventario = new Lazy<Logica.Logica.LogicaInventario.LogicaInventario>();
        Lazy<DSMarket.Logica.Logica.LogicaListas.LogicaListas> ObjDataListas = new Lazy<Logica.Logica.LogicaListas.LogicaListas>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();
        public MantenimientoCitas()
        {
            InitializeComponent();
        }

        #region LIMPIAR Y CERRAR PANTALLA
        private void LimpiarPantalla() { }
        private void CerrarPantalla() {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.ProgramacionCitas ConsultaCitas = new ProgramacionCitas();
            ConsultaCitas.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            ConsultaCitas.ShowDialog();
        }
        #endregion
        #region CARGAR EL LISTADO DE LOS TIPOS DE PRODUCTOS
        private void ListadoTipoProductos() {
            var TipoProducto = ObjDataListas.Value.ListaTipoProducto(new Nullable<decimal>(), null);
            ddlSeleccionarTipoProducto.DataSource = TipoProducto;
            ddlSeleccionarTipoProducto.DisplayMember = "Descripcion";
            ddlSeleccionarTipoProducto.ValueMember = "IdTipoproducto";
        }
        #endregion
        #region MOSTRAR EL LISTADO DE LOS PRODUCTOS
        private void MostrarListadoProductos() {
            string _NombreProducto = string.IsNullOrEmpty(txtNombreServicioProdcto.Text.Trim()) ? null : txtNombreServicioProdcto.Text.Trim();

            var Listado = ObjDataInventario.Value.BuscaProductos(
                new Nullable<decimal>(),
                null,
                _NombreProducto,
                null, null, null, null,
                Convert.ToDecimal(ddlSeleccionarTipoProducto.SelectedValue),
                null, null, null, null, null, null, null, null, null, null,
                Convert.ToInt32(txtNumeroPagina.Value),
                Convert.ToInt32(txtNumeroRegistros.Value));
            dtListadoServicoProducto.DataSource = Listado;
            OcultarColumnas();
        }
        #endregion
        #region OCULTAR COLUMNAS PRODCTOS
        private void OcultarColumnas() {
            this.dtListadoServicoProducto.Columns["IdProducto"].Visible = false;
            this.dtListadoServicoProducto.Columns["IdMarca"].Visible = false;
            this.dtListadoServicoProducto.Columns["Marca"].Visible = false;
            this.dtListadoServicoProducto.Columns["IdModelo"].Visible = false;
            this.dtListadoServicoProducto.Columns["Modelo"].Visible = false;
            this.dtListadoServicoProducto.Columns["IdColor"].Visible = false;
            this.dtListadoServicoProducto.Columns["Color"].Visible = false;
            this.dtListadoServicoProducto.Columns["IdCapacidad"].Visible = false;
            this.dtListadoServicoProducto.Columns["IdCondicion"].Visible = false;
            this.dtListadoServicoProducto.Columns["Condicion"].Visible = false;
            this.dtListadoServicoProducto.Columns["NumeroConector"].Visible = false;
            this.dtListadoServicoProducto.Columns["IdTipoProducto"].Visible = false;
            this.dtListadoServicoProducto.Columns["Referencia"].Visible = false;
            this.dtListadoServicoProducto.Columns["IdCategoria"].Visible = false;
            this.dtListadoServicoProducto.Columns["Categoria"].Visible = false;
            this.dtListadoServicoProducto.Columns["IdUnidadMedida"].Visible = false;
            this.dtListadoServicoProducto.Columns["IdTipoSuplidor"].Visible = false;
            this.dtListadoServicoProducto.Columns["TipoSuplidor"].Visible = false;
            this.dtListadoServicoProducto.Columns["IdSuplidor"].Visible = false;
            this.dtListadoServicoProducto.Columns["Suplidor"].Visible = false;
            this.dtListadoServicoProducto.Columns["CodigoBarra"].Visible = false;
            this.dtListadoServicoProducto.Columns["PrecioCompra"].Visible = false;
            this.dtListadoServicoProducto.Columns["PrecioVenta"].Visible = false;
            this.dtListadoServicoProducto.Columns["Stock"].Visible = false;
            this.dtListadoServicoProducto.Columns["StockMinimo"].Visible = false;
            this.dtListadoServicoProducto.Columns["PorcientoDescuento"].Visible = false;
            this.dtListadoServicoProducto.Columns["AfectaOferta0"].Visible = false;
            this.dtListadoServicoProducto.Columns["AceptaOferta"].Visible = false;
            this.dtListadoServicoProducto.Columns["ProductoAcumulativo0"].Visible = false;
            this.dtListadoServicoProducto.Columns["ProductoAcumulativo"].Visible = false;
            this.dtListadoServicoProducto.Columns["LlevaImagen0"].Visible = false;
            this.dtListadoServicoProducto.Columns["LlevaImagen"].Visible = false;
            this.dtListadoServicoProducto.Columns["UsuarioAdicion"].Visible = false;
            this.dtListadoServicoProducto.Columns["CreadoPor"].Visible = false;
            this.dtListadoServicoProducto.Columns["FechaAdiciona"].Visible = false;
            this.dtListadoServicoProducto.Columns["FechaCreado"].Visible = false;
            this.dtListadoServicoProducto.Columns["UsuarioModifica"].Visible = false;
            this.dtListadoServicoProducto.Columns["ModificadoPor"].Visible = false;
            this.dtListadoServicoProducto.Columns["FechaModifica"].Visible = false;
            this.dtListadoServicoProducto.Columns["FechaModificado"].Visible = false;
            this.dtListadoServicoProducto.Columns["Fecha"].Visible = false;
            this.dtListadoServicoProducto.Columns["AplicaParaImpuesto0"].Visible = false;
            this.dtListadoServicoProducto.Columns["EstatusProducto0"].Visible = false;
            this.dtListadoServicoProducto.Columns["EstatusProducto"].Visible = false;
            this.dtListadoServicoProducto.Columns["AplicaParaImpuesto"].Visible = false;
            this.dtListadoServicoProducto.Columns["NumeroSeguimiento"].Visible = false;
            this.dtListadoServicoProducto.Columns["CantidadRegistros"].Visible = false;
            this.dtListadoServicoProducto.Columns["ProductosConOferta"].Visible = false;
            this.dtListadoServicoProducto.Columns["ProductoProximoAgotarse"].Visible = false;
            this.dtListadoServicoProducto.Columns["ProductosAgostados"].Visible = false;
            this.dtListadoServicoProducto.Columns["CapilalInvertido"].Visible = false;
            this.dtListadoServicoProducto.Columns["GananciaAproximada"].Visible = false;
            this.dtListadoServicoProducto.Columns["Comentario"].Visible = false;
            this.dtListadoServicoProducto.Columns["Capacidad"].Visible = false;
            this.dtListadoServicoProducto.Columns["UnidadMedida"].Visible = false;
        }
        #endregion
        #region PROCESAR INFORMACION
        private void MantenimientoCitasEncabezado() {
            decimal IdEmpleado = 0;

            if (string.IsNullOrEmpty(txtNombreEmpleado.Text.Trim())) {
                IdEmpleado = 0;
            }
            else {
                string _NombreEmpleado = string.IsNullOrEmpty(txtNombreEmpleado.Text.Trim()) ? null : txtNombreEmpleado.Text.Trim();

                var BuscarEmpleado = ObjDataEmpresa.Value.BuscaEmpleados(
                    new Nullable<decimal>(),
                    _NombreEmpleado, null, null, null, null, null, 1, 1);
                if (BuscarEmpleado.Count() < 1) { IdEmpleado = 0; }
                else {
                    foreach (var n in BuscarEmpleado) {
                        IdEmpleado = Convert.ToDecimal(n.IdEmpleado);
                    }
                }


            }


            DSMarket.Logica.Comunes.ProcesarInformacion.Empresa.ProcesarInformacionCitas Procesar = new Logica.Comunes.ProcesarInformacion.Empresa.ProcesarInformacionCitas(
                VariablesGlobales.IdMantenimeinto,
                IdEmpleado,
                Convert.ToDateTime(txtFechaCita.Text),
                txtHoraCita.Text,
                txtNombreCliente.Text,
                txtTelefono.Text,
                txtDireccion.Text,
                txtNumeroIdentificacion.Text,
                VariablesGlobales.NumeroConector,
                cbEstatus.Checked,
                VariablesGlobales.Accion);
            Procesar.ProcesarInformacionCitasEncabezado();
        }


        #endregion
        #region MOSTRAR LOS PRODICTOS AGREGADOS
        private void MostrarProductosAgregados(decimal NumeroConector) {
            var MostrarProductosAgregados = ObjDataEmpresa.Value.BuscaCitaDetalle(NumeroConector);
            dtListadoProductosAgregados.DataSource = MostrarProductosAgregados;
            this.dtListadoProductosAgregados.Columns["NumeroConectorCita"].Visible = false;
            this.dtListadoProductosAgregados.Columns["IdProducto"].Visible = false;
            this.dtListadoProductosAgregados.Columns["CantidadRegistros"].Visible = false;
            this.dtListadoProductosAgregados.Columns["Total"].Visible = false;
        }
        #endregion
        #region GENERAR NUMERO DE CONECTOR
        private void GenerarNumeroConector() {
            if (VariablesGlobales.Accion == "INSERT") {
                Random Numero = new Random();
                VariablesGlobales.NumeroConector = Numero.Next(0, 999999999);
            }
        }
        #endregion

        private void MantenimientoCitas_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason) {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            DSMarket.Logica.Comunes.ProcesarInformacion.Empresa.ProcesarInformacionCitas Eliminar = new Logica.Comunes.ProcesarInformacion.Empresa.ProcesarInformacionCitas(
                VariablesGlobales.NumeroConector,
                0, 0, "", "DELETEALL");
            Eliminar.ProcesarInformacionDetalle();
            CerrarPantalla();
        }

        private void MantenimientoCitas_Load(object sender, EventArgs e)
        {
            ListadoTipoProductos();
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            lbTitulo.ForeColor = Color.White;
            lbTitulo.Text = "Mantenimiento de Citas";
            GenerarNumeroConector();
            cbEstatus.Checked = true;
            if (VariablesGlobales.Accion != "INSERT") {

                var BuscarInformacion = ObjDataEmpresa.Value.BuscaEncabezadoCita(
                    VariablesGlobales.IdMantenimeinto.ToString(),
                    null, null, null, null, null, null, 1, 1);
                foreach (var n in BuscarInformacion) {
                    txtNombreEmpleado.Text = n.Empleado;
                    txtHoraCita.Text = n.Hora;
                    txtNombreCliente.Text = n.NombreCliente;
                    txtDireccion.Text = n.Direccion;
                    txtFechaCita.Text = n.FechaCita0.ToString();
                    txtNumeroIdentificacion.Text = n.NumeroIdentificacion;
                    txtTelefono.Text = n.Telefono;
                    cbEstatus.Checked = (n.Estatus0.HasValue ? n.Estatus0.Value : false);
                }
                if (txtNombreEmpleado.Text == "N/A") {
                    txtNombreEmpleado.Text = string.Empty;
                }
                MostrarProductosAgregados(VariablesGlobales.NumeroConector);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumeroIdentificacion.Text.Trim()))
            {
                MessageBox.Show("Favor de ingresar el numero de identificación del cliente para buscar registros", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                //BUSCAMOS LOS DATOS DEL CLIENTE
                string _RNC = string.IsNullOrEmpty(txtNumeroIdentificacion.Text.Trim()) ? null : txtNumeroIdentificacion.Text.Trim();

                var BuscarCliente = ObjDataEmpresa.Value.BuscaClientes(
                    new Nullable<decimal>(),
                    null,
                    null,
                    _RNC,
                    null, null, 1, 1);
                if (BuscarCliente.Count() < 1)
                {
                    MessageBox.Show("No se encontrarón registros con el numero de identificación ingresado", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else {
                    foreach (var n in BuscarCliente) {
                        txtNombreCliente.Text = n.Nombre;
                        txtTelefono.Text = n.Telefono;
                        txtDireccion.Text = n.Direccion;
                    }
                }
            }
        }

        private void txtNombreServicioProdcto_TextChanged(object sender, EventArgs e)
        {
            MostrarListadoProductos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarListadoProductos();
        }

        private void dtListadoServicoProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("¿Quieres agregar este registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {

                decimal IdPrductoDetalle = Convert.ToDecimal(this.dtListadoServicoProducto.CurrentRow.Cells["IdProducto"].Value.ToString());
                decimal PrecioProductoDetalle = Convert.ToDecimal(this.dtListadoServicoProducto.CurrentRow.Cells["PrecioVenta"].Value.ToString());
                string DescripcionProductoDetalle = this.dtListadoServicoProducto.CurrentRow.Cells["Producto"].Value.ToString();

               

                DSMarket.Logica.Comunes.ProcesarInformacion.Empresa.ProcesarInformacionCitas Procesar = new Logica.Comunes.ProcesarInformacion.Empresa.ProcesarInformacionCitas(
                    VariablesGlobales.NumeroConector,
                    IdPrductoDetalle,
                    PrecioProductoDetalle,
                    DescripcionProductoDetalle,
                    "INSERT");
                Procesar.ProcesarInformacionDetalle();

            }

            MostrarProductosAgregados(VariablesGlobales.NumeroConector);
        }

        private void dtListadoProductosAgregados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("¿Quieres quitar este registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                decimal IdProducto = Convert.ToDecimal(this.dtListadoProductosAgregados.CurrentRow.Cells["IdProducto"].Value.ToString());
                DSMarket.Logica.Comunes.ProcesarInformacion.Empresa.ProcesarInformacionCitas Eliminar = new Logica.Comunes.ProcesarInformacion.Empresa.ProcesarInformacionCitas(
                VariablesGlobales.NumeroConector,
                IdProducto, 0, "", "DELETE");
                Eliminar.ProcesarInformacionDetalle();
                MostrarProductosAgregados(VariablesGlobales.NumeroConector);

            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            MantenimientoCitasEncabezado();
            MessageBox.Show("Registro guardado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
            CerrarPantalla();
        }
    }
}
