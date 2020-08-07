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
    public partial class ModificarGarantiaFactura : Form
    {
        public ModificarGarantiaFactura()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaServicio.LogicaServicio> ObjdataServicio = new Lazy<Logica.Logica.LogicaServicio.LogicaServicio>();
        Lazy<DSMarket.Logica.Logica.LogicaSeguridad.LogicaSeguridad> ObjDataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad.LogicaSeguridad>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        private void MostrarDatosFactura(decimal NoFactura, decimal NumeroCOnector) {
            var BuscarDatosFactura = ObjdataServicio.Value.HistorialFacturacion(
                NoFactura,
                NumeroCOnector,
                null, null, null, null, null, null, 1, 1);
            foreach (var n in BuscarDatosFactura) {
                txtTipoFacturacion.Text = n.TipoVenta;
                txtNombreCliente.Text = n.Cliente;
                txtTelefono.Text = n.Telefono;
                txtTipoIdentificacion.Text = n.TipoIdentificacion;
                txtIdentificacion.Text = n.NumeroIdentificacion;
                txtDireccion.Text = n.Direccion;
                txtEmail.Text = n.Email;
                txtFecha.Text = n.FechaFacturacion;
                txtFaturadoPor.Text = n.CreadoPor;
                int CantidadArticulos = 0, CantidadServicios = 0;
                decimal TotalDescuento = 0, SubTotal = 0, Impuesto = 0, Total = 0, Monto = 0, Cambio = 0;
                CantidadArticulos = Convert.ToInt32(n.CantidadArticulos);
                CantidadServicios = Convert.ToInt32(n.CantidadServicios);
                TotalDescuento = Convert.ToDecimal(n.TotalDescuento);
                SubTotal = Convert.ToDecimal(n.SubTotal);
                Impuesto = Convert.ToDecimal(n.Impuesto);
                Total = Convert.ToDecimal(n.TotalGeneral);
                Monto = Convert.ToDecimal(n.MontoPagado);
                Cambio = Convert.ToDecimal(n.Cambio);
                txtCantidadArtiuclos.Text = CantidadArticulos.ToString("N0");
                txtCantidadServicios.Text=CantidadServicios.ToString("N0");
                txtTotalDescuento.Text=TotalDescuento.ToString("N2");
                txtSubtotal.Text=SubTotal.ToString("N2");
                txtImpuesto.Text=Impuesto.ToString("N2");
                txtTotal.Text=Total.ToString("N2");
                txtTipoPago.Text = n.TipoPago;
                txtMontoPagar.Text=Monto.ToString("N2");
                txtcambio.Text = Cambio.ToString("N2");
                txtDiasGarantia.Text = n.DiasGarantia.ToString();
                txtComentario.Text = n.Comentario;
                if (string.IsNullOrEmpty(txtDiasGarantia.Text.Trim())) {
                    txtDiasGarantia.Text = "0";
                }
            }
        }

        private void MostrarProductosFacturados(decimal NumeroCOnector) {
            var ProductosFacturados = ObjdataServicio.Value.BuscapRoductosAgregados(
                new Nullable<decimal>(),
                VariablesGlobales.NumeroConector);
            dtListado.DataSource = ProductosFacturados;
            this.dtListado.Columns["NumeroConector"].Visible = false;
            this.dtListado.Columns["IdTipoProducto"].Visible = false;
            this.dtListado.Columns["IdCategoria"].Visible = false;
            this.dtListado.Columns["DescripcionTipoProducto1"].Visible = false;
            this.dtListado.Columns["IdProducto"].Visible = false;
            this.dtListado.Columns["ConectorProducto"].Visible = false;
            this.dtListado.Columns["CantidadProductos"].Visible = false;
            this.dtListado.Columns["CantidadServicios"].Visible = false;
            this.dtListado.Columns["CantidadRegistros"].Visible = false;
        }

        private void CerrarPantalla() {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Servicio.HistorialFActuracion Historial = new HistorialFActuracion();
            Historial.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Historial.ShowDialog();
        }

        private void txtDiasGarantia_KeyPress(object sender, KeyPressEventArgs e)
        {
            DSMarket.Logica.Comunes.ValidarControles.SoloNumeros(e);
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            CerrarPantalla();
        }

        private void ModificarGarantiaFactura_Load(object sender, EventArgs e)
        {
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            lbTitulo.Text = "MODIFICAR LOS DIAS DE LA GARANTIA DE LA FACTURA SELECCIONADA";
            lbTitulo.ForeColor = Color.White;
            MostrarDatosFactura(VariablesGlobales.IdMantenimeinto, VariablesGlobales.NumeroConector);
            MostrarProductosFacturados(VariablesGlobales.NumeroConector);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()))
            {
                MessageBox.Show("El campo clave de seguridad no puede estar vacio", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                else {
                    if (string.IsNullOrEmpty(txtDiasGarantia.Text.Trim())) {
                        MessageBox.Show("Favor la cantidad de dias de garantia", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (string.IsNullOrEmpty(txtDiasGarantia.Text))
                        {
                            errorProvider1.SetError(txtDiasGarantia, "Campo Vacio");
                        }
                        
                    }
                    else
                    {
                        DSMarket.Logica.Entidades.EntidadesServicio.EFacturacionClientes Modificar = new Logica.Entidades.EntidadesServicio.EFacturacionClientes();

                        Modificar.IdFactura = VariablesGlobales.IdMantenimeinto;
                        Modificar.NumeroConector = VariablesGlobales.NumeroConector;
                        Modificar.DiasGarantia = Convert.ToInt32(txtDiasGarantia.Text);

                        var MAn = ObjdataServicio.Value.GuardarFacturacionClientes(Modificar, "UPDATE");
                        MessageBox.Show("Registro modificado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CerrarPantalla();
                    }
                }
            }
        }
    }
}
