using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSMarket.Solucion.Pantallas.Pantallas.Contabilidad
{
    public partial class CatalogoCuentasMantenimiento : Form 
    {
        public CatalogoCuentasMantenimiento()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaListas.LogicaListas> ObjDataListas = new Lazy<Logica.Logica.LogicaListas.LogicaListas>();
        Lazy<DSMarket.Logica.Logica.LogicaContabilidad.LogicaContabilidad> ObjDataContabilidad = new Lazy<Logica.Logica.LogicaContabilidad.LogicaContabilidad>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region CARGAR LOS LISTADOS
        private void CargarClases() {
            var Clases = ObjDataListas.Value.BuscaClasesCuentasContables();
            ddlSeleccionarClase.DataSource = Clases;
            ddlSeleccionarClase.DisplayMember = "Descripcion";
            ddlSeleccionarClase.ValueMember = "IdClaseCuenta";
        }
        private void CargarOrigenes() {
            var Origenes = ObjDataListas.Value.BuscaOrigenesCuentasCOntables();
            ddlSeleccionarOrigen.DataSource = Origenes;
            ddlSeleccionarOrigen.DisplayMember = "Descripcion";
            ddlSeleccionarOrigen.ValueMember = "IdOrigenCuenta";
        }
        private void CargarTipos() {
            var TiposCuentas = ObjDataListas.Value.BuscaTiposCuentasContables();
            ddlSeleccionarTipo.DataSource = TiposCuentas;
            ddlSeleccionarTipo.ValueMember = "IdTipoCuentas";
            ddlSeleccionarTipo.DisplayMember = "Descripcion";
        }
        private void CargarMovimientos() {
            var AceptaMovimiento = ObjDataListas.Value.BuscaAceptaMovimientoSCuentasCotables();
            ddlSeleccionarMovimiento.DataSource = AceptaMovimiento;
            ddlSeleccionarMovimiento.DisplayMember = "Descripcion";
            ddlSeleccionarMovimiento.ValueMember = "IdMovimientoCuenta";
        }
        #endregion

        #region MANTENIMIENTO DE CATALOGO DE CUENTAS
        private void MANCatalogoCuentas() {
            DSMarket.Logica.Comunes.ProcesarInformacion.ProcesarInformacionCatalogoCuentas Procesar = new Logica.Comunes.ProcesarInformacion.ProcesarInformacionCatalogoCuentas(
                VariablesGlobales.IdMantenimeinto,
                txtNumeroCuentas.Text,
                txtAuxiliar.Text,
                txtDescripcionCuenta.Text,
                Convert.ToInt32(ddlSeleccionarOrigen.SelectedValue),
                Convert.ToInt32(ddlSeleccionarTipo.SelectedValue),
                Convert.ToInt32(ddlSeleccionarClase.SelectedValue),
                Convert.ToInt32(ddlSeleccionarMovimiento.SelectedValue),
                0,
                txtCuentaDescargo.Text,
                "",
                "",
                cbEstatus.Checked,
                txtCuentaAnterior.Text,
                Convert.ToInt32(VariablesGlobales.IdUsuario),
                DateTime.Now,
                Convert.ToInt32(VariablesGlobales.IdUsuario),
                DateTime.Now,
                VariablesGlobales.Accion);
            Procesar.ProcesarInformacion();
        }
        #endregion

        private void BuscarCuentasInferiores(string Cuenta) {

            var SacarCuentasInferior = ObjDataContabilidad.Value.BuscaCatalogoCuentas(
                         new Nullable<decimal>(),
                         null, null, null, Cuenta, 1, 999999999);
            dtListadoNiveles.DataSource = SacarCuentasInferior;
            OcultarColumnas();
        }
        private void OcultarColumnas()
        {
            this.dtListadoNiveles.Columns["IdRegistro"].Visible = false;
            this.dtListadoNiveles.Columns["IdOrigenCuenta"].Visible = false;
            this.dtListadoNiveles.Columns["IdTipoCuenta"].Visible = false;
            this.dtListadoNiveles.Columns["IdClaseCuenta"].Visible = false;
            this.dtListadoNiveles.Columns["IdAceptaMovimientoCuenta"].Visible = false;
            this.dtListadoNiveles.Columns["CodAnexo"].Visible = false;
            this.dtListadoNiveles.Columns["CuentaPresupuesto"].Visible = false;
            this.dtListadoNiveles.Columns["AuxiliarPresupuesto"].Visible = false;
            this.dtListadoNiveles.Columns["Estatus0"].Visible = false;
            this.dtListadoNiveles.Columns["UsuarioAdiciona"].Visible = false;
            this.dtListadoNiveles.Columns["FechaAdiciona"].Visible = false;
            this.dtListadoNiveles.Columns["UsuarioModifica"].Visible = false;
            this.dtListadoNiveles.Columns["ModificadoPor"].Visible = false;
            this.dtListadoNiveles.Columns["FechaModifica"].Visible = false;
            this.dtListadoNiveles.Columns["FechaModificado"].Visible = false;
        }
        #region LIMPIAR Y CERRAR CONTROLES
        private void LimpiarControles() {
            txtNumeroCuentas.Text = string.Empty;
            txtAuxiliar.Text = string.Empty;
            txtCuentaAnterior.Text = string.Empty;
            txtCuentaDescargo.Text = string.Empty;
            txtDescripcionCuenta.Text = string.Empty;
            txtNumeroPagina.Value = 1;
            txtNumeroRegistros.Value = 10;

        }
        private void CerrarPantalla() {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Contabilidad.CatalogoCuentasConsulta Consulta = new CatalogoCuentasConsulta();
            Consulta.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Consulta.ShowDialog();
        }
        #endregion

        private void CatalogoCuentasMantenimiento_Load(object sender, EventArgs e)
        {
            lbTitulo.Text = "MANTENIMIENTO DE CATALOGO DE CUENTAS";
            lbTitulo.ForeColor = Color.White;
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            CargarClases();
            CargarOrigenes();
            CargarTipos();
            CargarMovimientos();

            lbCuantaModificarTitulo.Visible = true;
            lbCuentaModficarVariable.Visible = true;
            lbAuxiliarModificarVariable.Visible = true;
            lbAuxiliarModificarTitulo.Visible = true;
           


            if (VariablesGlobales.Accion != "INSERT") {
                var SacarInformacionCuenta = ObjDataContabilidad.Value.BuscaCatalogoCuentas(
                    VariablesGlobales.IdMantenimeinto, null, null, null, null, 1, 1);
                foreach (var n in SacarInformacionCuenta) {

                    txtNumeroCuentas.Text = n.Cuenta;
                    txtAuxiliar.Text = n.Auxiliar;
                    txtCuentaDescargo.Text = n.CuentaDescargo;
                    txtCuentaAnterior.Text = n.CuentaAnterior;
                    txtDescripcionCuenta.Text = n.NombreCuenta;
                    lbAuxiliarModificarVariable.Text = n.Auxiliar;
                    lbCuentaModficarVariable.Text = n.Cuenta;
                    ddlSeleccionarOrigen.Text = n.Origen;
                    ddlSeleccionarTipo.Text = n.Tipo;
                    ddlSeleccionarClase.Text = n.Clase;
                    ddlSeleccionarMovimiento.Text = n.AceptaMovimiento;

                    BuscarCuentasInferiores(lbCuentaModficarVariable.Text);
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumeroCuentas.Text.Trim()) || string.IsNullOrEmpty(txtAuxiliar.Text.Trim()) || string.IsNullOrEmpty(txtCuentaDescargo.Text.Trim()) || string.IsNullOrEmpty(txtCuentaAnterior.Text.Trim()) || string.IsNullOrEmpty(txtDescripcionCuenta.Text.Trim()))
            {

                MessageBox.Show("Has dejado campos vacios que son necesarios para realizar esta operación, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (string.IsNullOrEmpty(txtNumeroCuentas.Text.Trim()))
                {
                    errorProvider1.SetError(txtNumeroCuentas, "Campo Vacio");
                }
                if (string.IsNullOrEmpty(txtAuxiliar.Text.Trim()))
                {
                    errorProvider1.SetError(txtAuxiliar, "Campo Vacio");
                }
                if (string.IsNullOrEmpty(txtCuentaDescargo.Text.Trim()))
                {
                    errorProvider1.SetError(txtCuentaDescargo, "Campo Vacio");
                }
                if (string.IsNullOrEmpty(txtCuentaAnterior.Text.Trim()))
                {
                    errorProvider1.SetError(txtCuentaAnterior, "Campo Vacio");
                }
                if (string.IsNullOrEmpty(txtDescripcionCuenta.Text.Trim()))
                {
                    errorProvider1.SetError(txtDescripcionCuenta, "Campo Vacio");
                }
            }
            else {
                //PROCEDEMOS A VALIDAR LOS DATOS

                if (VariablesGlobales.Accion == "INSERT")
                {
                    var ValidarCuenta = ObjDataContabilidad.Value.BuscaCatalogoCuentas(
                        new Nullable<decimal>(),
                        txtNumeroCuentas.Text,
                        txtAuxiliar.Text,
                        null, null, 1, 1);
                    if (ValidarCuenta.Count() < 1)
                    {
                        MANCatalogoCuentas();
                        MessageBox.Show("Registro guardado exitosamente", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (MessageBox.Show("¿Quieres guardar otro registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            LimpiarControles();
                        }
                        else
                        {
                            CerrarPantalla();
                        }
                       
                    }
                    else {
                        MessageBox.Show("Ya existe una cuenta registrada con el numero de cuenta y auxiliar ingresados, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
                //MODIFICAMOS
                else {
                    MANCatalogoCuentas();
                    MessageBox.Show("Registro modificado exitosamente", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CerrarPantalla();
                 
                }




            }
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            CerrarPantalla();
        }

        private void dtListadoNiveles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        

            }

        private void txtNumeroPagina_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroPagina.Value < 1)
            {
                txtNumeroPagina.Value = 1;
                BuscarCuentasInferiores(lbCuentaModficarVariable.Text);
            }
            else {
                BuscarCuentasInferiores(lbCuentaModficarVariable.Text);
            }
        }

        private void txtNumeroRegistros_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroRegistros.Value < 1)
            {
                txtNumeroRegistros.Value = 10;
                BuscarCuentasInferiores(lbCuentaModficarVariable.Text);
            }
            else {
                BuscarCuentasInferiores(lbCuentaModficarVariable.Text);
            }
        }

        private void CatalogoCuentasMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason) {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }
    }
    }

