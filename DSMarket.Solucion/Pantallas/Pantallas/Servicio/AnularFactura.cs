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
    public partial class AnularFactura : Form
    {
        public AnularFactura()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaServicio.LogicaServicio> ObjDataServicio = new Lazy<Logica.Logica.LogicaServicio.LogicaServicio>();
        Lazy<DSMarket.Logica.Logica.LogicaSeguridad.LogicaSeguridad> ObjDataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad.LogicaSeguridad>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region APLICAR TEMA
        private void TemaGenerico()
        {
            this.BackColor = SystemColors.Control;

            txtTipoFacturacion.BackColor = Color.WhiteSmoke;
            txtNombreCliente.BackColor = Color.WhiteSmoke;
            txtTelefono.BackColor = Color.WhiteSmoke;
            txtTipoIdentificacion.BackColor = Color.WhiteSmoke;
            txtIdentificacion.BackColor = Color.WhiteSmoke;
            txtDireccion.BackColor = Color.WhiteSmoke;
            txtEmail.BackColor = Color.WhiteSmoke;
            txtFecha.BackColor = Color.WhiteSmoke;
            txtFaturadoPor.BackColor = Color.WhiteSmoke;
            txtCantidadArtiuclos.BackColor = Color.WhiteSmoke;
            txtCantidadServicios.BackColor = Color.WhiteSmoke;
            txtTotalDescuento.BackColor = Color.WhiteSmoke;
            txtSubtotal.BackColor = Color.WhiteSmoke;
            txtImpuesto.BackColor = Color.WhiteSmoke;
            txtTotal.BackColor = Color.WhiteSmoke;
            txtTipoPago.BackColor = Color.WhiteSmoke;
            txtMontoPagar.BackColor = Color.WhiteSmoke;
            txtcambio.BackColor = Color.WhiteSmoke;
            txtClaveSeguridad.BackColor = Color.WhiteSmoke;
            txtNumeroPagina.BackColor = Color.WhiteSmoke;
            txtNumeroRegistros.BackColor = Color.WhiteSmoke;

            txtTipoFacturacion.ForeColor = Color.Black;
            txtNombreCliente.ForeColor = Color.Black;
            txtTelefono.ForeColor = Color.Black;
            txtTipoIdentificacion.ForeColor = Color.Black;
            txtIdentificacion.ForeColor = Color.Black;
            txtDireccion.ForeColor = Color.Black;
            txtEmail.ForeColor = Color.Black;
            txtFecha.ForeColor = Color.Black;
            txtFaturadoPor.ForeColor = Color.Black;
            txtCantidadArtiuclos.ForeColor = Color.Black;
            txtCantidadServicios.ForeColor = Color.Black;
            txtTotalDescuento.ForeColor = Color.Black;
            txtSubtotal.ForeColor = Color.Black;
            txtImpuesto.ForeColor = Color.Black;
            txtTotal.ForeColor = Color.Black;
            txtTipoPago.ForeColor = Color.Black;
            txtMontoPagar.ForeColor = Color.Black;
            txtcambio.ForeColor = Color.Black;
            txtClaveSeguridad.ForeColor = Color.Black;
            txtNumeroPagina.ForeColor = Color.Black;
            txtNumeroRegistros.ForeColor = Color.Black;

            txtTipoFacturacion.Enabled = false;
            txtNombreCliente.Enabled = false;
            txtTelefono.Enabled = false;
            txtTipoIdentificacion.Enabled = false;
            txtIdentificacion.Enabled = false;
            txtDireccion.Enabled = false;
            txtEmail.Enabled = false;
            txtFecha.Enabled = false;
            txtFaturadoPor.Enabled = false;
            txtCantidadArtiuclos.Enabled = false;
            txtCantidadServicios.Enabled = false;
            txtTotalDescuento.Enabled = false;
            txtSubtotal.Enabled = false;
            txtImpuesto.Enabled = false;
            txtTotal.Enabled = false;
            txtTipoPago.Enabled = false;
            txtMontoPagar.Enabled = false;
            txtcambio.Enabled = false;

            dtListado.BackgroundColor = SystemColors.Control;
        }
        #endregion
        #region SACAR LA INFORMACION DE LA FACTURA
        private void SacarInformacionFactura(decimal IdFactura) {
            try {
                
                var SacarDatosFactura = ObjDataServicio.Value.HistorialFacturacion(IdFactura,
                    null, null, null, null, null, null, 1, 1);
                foreach (var n in SacarDatosFactura) {
                    txtTipoFacturacion.Text = n.EstatusFacturacion;
                    txtNombreCliente.Text = n.Cliente;
                    txtTelefono.Text = n.Telefono;
                    txtTipoIdentificacion.Text = n.TipoIdentificacion;
                    txtIdentificacion.Text = n.NumeroIdentificacion;
                    txtDireccion.Text = n.Direccion;
                    txtEmail.Text = n.Email;
                    txtFecha.Text = n.FechaFacturacion;
                    txtFaturadoPor.Text = n.CreadoPor;
                    int CantidadArticulos = Convert.ToInt32(n.CantidadProductos);
                    txtCantidadArtiuclos.Text = CantidadArticulos.ToString("N0");
                    int CantidadServicios = Convert.ToInt32(n.CantidadServicios);
                    txtCantidadServicios.Text = CantidadServicios.ToString("N0");
                    decimal TotalDescuento = Convert.ToDecimal(n.TotalDescuento);
                    decimal SubTotal = Convert.ToDecimal(n.SubTotal);
                    decimal Impuesto = Convert.ToDecimal(n.Impuesto);
                    decimal Total = Convert.ToDecimal(n.TotalGeneral);
                    decimal MontoPagado = Convert.ToDecimal(n.MontoPagado);
                    decimal Cambio = Convert.ToDecimal(n.Cambio);
                    txtTotalDescuento.Text = TotalDescuento.ToString("N2");
                    txtSubtotal.Text = SubTotal.ToString("N2");
                    txtImpuesto.Text = Impuesto.ToString("N2");
                    txtTotal.Text = Total.ToString("N2");
                    txtTipoPago.Text = n.TipoPago;
                    txtMontoPagar.Text = MontoPagado.ToString("N2");
                    txtcambio.Text = Cambio.ToString("N2");
                    txtComentario.Text = n.Comentario;
                    VariablesGlobales.NumeroConector = Convert.ToDecimal(n.NumeroConector);
                    VariablesGlobales.IdTipoIdentificacionAnularFactura = Convert.ToDecimal(n.IdTipoIdentificacion);
                    VariablesGlobales.NumeroIdentificacionAnularFactura = n.NumeroIdentificacion;
                    VariablesGlobales.IdTipoVentaAnularFactura = Convert.ToDecimal(n.IdTipoVenta);
                    VariablesGlobales.IdCantidadDiasAnularFactura = Convert.ToDecimal(n.IdCantidadDias);
                    VariablesGlobales.PorcientoDescuentoAnularFactura = Convert.ToInt32(n.PorcientoImpuesto);
                    VariablesGlobales.IdTipOpagoAnularFactura = Convert.ToDecimal(n.IdTipoPago);
                }

                var MostrarProductosAgregados = ObjDataServicio.Value.BuscapRoductosAgregados(
                    new Nullable<decimal>(),
                    VariablesGlobales.NumeroConector);
                dtListado.DataSource = MostrarProductosAgregados;
                this.dtListado.Columns["NumeroConector"].Visible = false;
                this.dtListado.Columns["IdTipoProducto"].Visible = false;
                this.dtListado.Columns["IdCategoria"].Visible = false;
                this.dtListado.Columns["DescripcionTipoProducto1"].Visible = false;
                this.dtListado.Columns["IdProducto"].Visible = false;
                this.dtListado.Columns["ConectorProducto"].Visible = false;

            }
            catch (Exception ex) {
                MessageBox.Show("Error al mostrar la informacion, codigo de error--> " + ex.Message, VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                  
            }
        }
        #endregion
        #region ELIMINAR FACTURACION CLIENTE
        private void FacturacionCliente(decimal NumeroConector,string Accion) {
            DSMarket.Logica.Entidades.EntidadesServicio.EFacturacionClientes Mantenimiento = new Logica.Entidades.EntidadesServicio.EFacturacionClientes();

            Mantenimiento.IdFactura = 0;
            Mantenimiento.NumeroConector = NumeroConector;
            Mantenimiento.IdEstatusFacturacion = 3;
            Mantenimiento.IdComprobante = 4;
            Mantenimiento.Nombre = txtNombreCliente.Text;
            Mantenimiento.Telefono = txtTelefono.Text;
            Mantenimiento.Email = txtEmail.Text;
            Mantenimiento.IdTipoIdentificacion = VariablesGlobales.IdTipoIdentificacionAnularFactura;
            Mantenimiento.NumeroIdentificacion = VariablesGlobales.NumeroIdentificacionAnularFactura;
            Mantenimiento.Direccion = txtDireccion.Text;
            Mantenimiento.Comentario = txtComentario.Text;
            Mantenimiento.IdTipoVenta = VariablesGlobales.IdTipoVentaAnularFactura;
            Mantenimiento.IdCantidadDias = VariablesGlobales.IdCantidadDiasAnularFactura;
            Mantenimiento.IdUsuario = VariablesGlobales.IdUsuario;
            Mantenimiento.FechaFacturacion = DateTime.Now;



            var MAN = ObjDataServicio.Value.GuardarFacturacionClientes(Mantenimiento, Accion);
        }
        #endregion
        #region ELIMINAR FACTURACION CALCULOS
        private void FacturacionCalculos(decimal NumeroConector,string Accion) {

            int CantidadProductos = Convert.ToInt32(txtCantidadArtiuclos.Text);
            int CantidadServicios = Convert.ToInt32(txtCantidadServicios.Text);
            int CantidadTotal = CantidadProductos + CantidadServicios;
            decimal TotalDescuento = Convert.ToDecimal(txtTotalDescuento.Text);
            decimal SubTotal = Convert.ToDecimal(txtSubtotal.Text);
            decimal Impuesto = Convert.ToDecimal(txtImpuesto.Text);
            decimal MontoPagar = Convert.ToDecimal(txtMontoPagar.Text);
            decimal Cambio = Convert.ToDecimal(txtcambio.Text);
            decimal Total = Convert.ToDecimal(txtTotal.Text);

            TotalDescuento = TotalDescuento * -1;
            SubTotal = SubTotal * -1;
            Impuesto = Impuesto * -1;
            MontoPagar = MontoPagar * -1;
            Cambio = Cambio * -1;
            Total = Total * -1;


            DSMarket.Logica.Entidades.EntidadesServicio.EGuardarFacturacionCalculos Mantenimiento = new Logica.Entidades.EntidadesServicio.EGuardarFacturacionCalculos();

            Mantenimiento.NumeroColector = NumeroConector;
            Mantenimiento.CantidadProductos = Convert.ToInt32(txtCantidadArtiuclos.Text);
            Mantenimiento.CantidadServicios = Convert.ToInt32(txtCantidadServicios.Text);
            Mantenimiento.CantidadArticulos = CantidadTotal;
            Mantenimiento.TotalDescuento = TotalDescuento;
            Mantenimiento.SubTotal = SubTotal;
            Mantenimiento.Impuesto = Impuesto;
            Mantenimiento.PorcientoImpuesto = VariablesGlobales.PorcientoDescuentoAnularFactura;
            Mantenimiento.MontoPagado = MontoPagar;
            Mantenimiento.Cambio = Cambio;
            Mantenimiento.IdTipoPago = VariablesGlobales.IdTipOpagoAnularFactura;
            Mantenimiento.TotalGeneral = Total;

            var MAn = ObjDataServicio.Value.GuardarFacturacionCalculos(Mantenimiento, Accion);
        }


        #endregion
        #region MANTENIMIENTO DE FACTURACION DE PRODUCTOS
        private void Productos(decimal NumeroConector, string Accion)
        {
            var BuscarProductos = ObjDataServicio.Value.BuscapRoductosAgregados(
                new Nullable<decimal>(),
                NumeroConector);
            foreach (var n in BuscarProductos) {
                DSMarket.Logica.Entidades.EntidadesServicio.EFacturacionProducto MantenimientoProducto = new Logica.Entidades.EntidadesServicio.EFacturacionProducto();

                MantenimientoProducto.NumeroConector = NumeroConector;
                MantenimientoProducto.IdTipoProducto = Convert.ToDecimal(n.IdTipoProducto);
                MantenimientoProducto.IdCategoria = Convert.ToDecimal(n.IdCategoria);
                MantenimientoProducto.DescripcionProducto = n.DescripcionProducto;
                MantenimientoProducto.CantidadVendida = Convert.ToInt32(n.Cantidad);
                MantenimientoProducto.Precio = Convert.ToDecimal(n.Precio);
                MantenimientoProducto.DescuentoAplicado = Convert.ToDecimal(n.DescuentoAplicado);
                MantenimientoProducto.DescripcionTipoProducto = n.DescripcionTipoProducto;
                MantenimientoProducto.PorcientoDescuento = Convert.ToInt32(n.PorcientoDescuento);
                MantenimientoProducto.IdProducto = Convert.ToDecimal(n.IdProducto);
                MantenimientoProducto.Acumulativo = n.Acumulativo;
                MantenimientoProducto.ConectorProducto = Convert.ToDecimal(n.ConectorProducto);
                MantenimientoProducto.Impuesto = Convert.ToDecimal(n.Impuesto);


                var MAN = ObjDataServicio.Value.GuardarFacturacionProductos(MantenimientoProducto, Accion);
            }


     
        }
        #endregion
        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Servicio.HistorialFActuracion Historial = new HistorialFActuracion();
            Historial.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Historial.ShowDialog();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void AnularFactura_Load(object sender, EventArgs e)
        {
            TemaGenerico();
            txtClaveSeguridad.PasswordChar = '•';
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            SacarInformacionFactura(VariablesGlobales.IdMantenimeinto);
        }

        private void AnularFactura_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()))
            {
                MessageBox.Show("El campo clave de seguridad no puede estar vacio, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                string _ClaveSeguridad = string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()) ? null : txtClaveSeguridad.Text.Trim();

                var ValidarClaveSeguridad = ObjDataSeguridad.Value.BuscaClaveSeguridad(
                    new Nullable<decimal>(),
                    null,
                    DSMarket.Logica.Comunes.SeguridadEncriptacion.Encriptar(_ClaveSeguridad),
                    1, 1);
                if (ValidarClaveSeguridad.Count() < 1)
                {
                    MessageBox.Show("La clave de seguridad ingresada no es valida", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    string TipoFacturacion = txtTipoFacturacion.Text;

                    if (TipoFacturacion == "FACTURACION") {
                        if (MessageBox.Show("¿Quieres anular esta factura?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                            if (MessageBox.Show("¿Quieres devolver los productos facturados al inventario?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                //DEVOLVEMOS
                                FacturacionCliente(VariablesGlobales.NumeroConector, "INSERT");
                                Productos(VariablesGlobales.NumeroConector, "INSERT");
                                FacturacionCalculos(VariablesGlobales.NumeroConector, "INSERT");
                                //AFECTAMOS COMPROBANTE
                            }
                            else
                            {
                                FacturacionCliente(VariablesGlobales.NumeroConector, "INSERT");
                                Productos(VariablesGlobales.NumeroConector, "INSERT");
                                FacturacionCalculos(VariablesGlobales.NumeroConector, "INSERT");
                                //AFECTAMOS COMPROBANTE
                            }

                        }
                    }
                    else {
                        if (MessageBox.Show("¿Quieres eliminar esta cotización?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                            FacturacionCliente(VariablesGlobales.NumeroConector,"DELETE");
                            Productos(VariablesGlobales.NumeroConector,"DELETE");
                            FacturacionCalculos(VariablesGlobales.NumeroConector,"DELETEALL");
                            MessageBox.Show("Cotización eliminada exitosamente", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Dispose();
                            DSMarket.Solucion.Pantallas.Pantallas.Servicio.HistorialFActuracion Historial = new HistorialFActuracion();
                            Historial.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
                            Historial.ShowDialog();
                        }
                    }
                }
            }
        }
    }
}
