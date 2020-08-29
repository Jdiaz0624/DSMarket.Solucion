using DSMarket.Logica.Logica.LogicaContabilidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSMarket.Solucion.Pantallas.Pantallas.Contabilidad
{
    public partial class CatalogoCuentasConsulta : Form
    {
        public CatalogoCuentasConsulta()
        {
            InitializeComponent();
        }
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();
        DSMarket.Logica.Logica.LogicaContabilidad.LogicaContabilidad ObjDataContabilidad = new LogicaContabilidad();

        #region LISTADO DE CUENTAS CONTABLES
        private void MostrarListadoCUentas() {
            string _NumeroCuenta = string.IsNullOrEmpty(txtNumeroCuentaConsulta.Text.Trim()) ? null : txtNumeroCuentaConsulta.Text.Trim();
            string _AuxiliarCuenta = string.IsNullOrEmpty(txtAuxiliarConsulta.Text.Trim()) ? null : txtAuxiliarConsulta.Text.Trim();
            string _DescripcionCuenta = string.IsNullOrEmpty(txtDescripcionConsulta.Text.Trim()) ? null : txtDescripcionConsulta.Text.Trim();

            var Buscar = ObjDataContabilidad.BuscaCatalogoCuentas(
                new Nullable<decimal>(),
                _NumeroCuenta,
                _AuxiliarCuenta,
                _DescripcionCuenta,
                null,
                Convert.ToInt32(txtNumeroPagina.Value),
                Convert.ToInt32(txtNumeroRegistros.Value));
            dtListado.DataSource = Buscar;
            OcultarColumnas();
        }
        private void OcultarColumnas() {
            this.dtListado.Columns["IdRegistro"].Visible = false;
            this.dtListado.Columns["IdOrigenCuenta"].Visible = false;
            this.dtListado.Columns["IdTipoCuenta"].Visible = false;
            this.dtListado.Columns["IdClaseCuenta"].Visible = false;
            this.dtListado.Columns["IdAceptaMovimientoCuenta"].Visible = false;
            this.dtListado.Columns["CodAnexo"].Visible = false;
            this.dtListado.Columns["CuentaPresupuesto"].Visible = false;
            this.dtListado.Columns["AuxiliarPresupuesto"].Visible = false;
            this.dtListado.Columns["Estatus0"].Visible = false;
            this.dtListado.Columns["UsuarioAdiciona"].Visible = false;
            this.dtListado.Columns["FechaAdiciona"].Visible = false;
            this.dtListado.Columns["UsuarioModifica"].Visible = false;
            this.dtListado.Columns["ModificadoPor"].Visible = false;
            this.dtListado.Columns["FechaModifica"].Visible = false;
            this.dtListado.Columns["FechaModificado"].Visible = false;
        }
        #endregion

        private void CatalogoCuentasConsulta_Load(object sender, EventArgs e)
        {
            MostrarListadoCUentas();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Contabilidad.CatalogoCuentasMantenimiento Mantenimiento = new CatalogoCuentasMantenimiento();
            Mantenimiento.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Mantenimiento.VariablesGlobales.Accion = "INSERT";
            Mantenimiento.VariablesGlobales.IdMantenimeinto = 0;
            Mantenimiento.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Contabilidad.CatalogoCuentasMantenimiento Mantenimiento = new CatalogoCuentasMantenimiento();
            Mantenimiento.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Mantenimiento.VariablesGlobales.Accion = "UPDATE";
            Mantenimiento.VariablesGlobales.IdMantenimeinto = VariablesGlobales.IdMantenimeinto;
            Mantenimiento.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MostrarListadoCUentas();
        }

        private void txtNumeroPagina_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroPagina.Value < 1)
            {
                txtNumeroPagina.Value = 1;
                MostrarListadoCUentas();
            }
            else {
                MostrarListadoCUentas();
            }
        }

        private void txtNumeroRegistros_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroRegistros.Value < 1)
            {
                txtNumeroRegistros.Value = 10;
                MostrarListadoCUentas();
            }
            else {
                MostrarListadoCUentas();
            }
        }

        private void txtAuxiliarConsulta_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
