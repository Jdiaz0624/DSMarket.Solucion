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
    public partial class TipoSuplidoresConsulta : Form
    {
        public TipoSuplidoresConsulta()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaInventario.LogicaInventario> ObjdataInventario = new Lazy<Logica.Logica.LogicaInventario.LogicaInventario>();
        Lazy<DSMarket.Logica.Logica.LogicaSeguridad.LogicaSeguridad> ObjdataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad.LogicaSeguridad>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region MOSTRAR EL LISTADO DE LOS TIPO DE SUPLIDORES
        private void MostrarListado() {
            try {
                string _TipoSuplidor = string.IsNullOrEmpty(txttiposuplidor.Text.Trim()) ? null : txttiposuplidor.Text.Trim();

                var Buscar = ObjdataInventario.Value.BuscaTipoSupidores(
                    new Nullable<decimal>(),
                    _TipoSuplidor,
                    Convert.ToInt32(txtNumeroPagina.Value),
                    Convert.ToInt32(txtNumeroRegistros.Value));
                dtListado.DataSource = Buscar;
                if (Buscar.Count() < 1)
                {
                    lbCantidadRegistrosVariable.Text = "0";
                }
                else
                {
                    foreach (var n in Buscar)
                    {
                        int Cantidad = Convert.ToInt32(n.IdTipoSuplidor);
                        lbCantidadRegistrosVariable.Text = Cantidad.ToString("N0");
                    }
                }
                OcultarColumnas();
            }

            catch (Exception) {
                MessageBox.Show("Error al mostrar el listado", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void OcultarColumnas() {
            this.dtListado.Columns["IdTipoSuplidor"].Visible = false;
            this.dtListado.Columns["Estatus0"].Visible = false;
            this.dtListado.Columns["UsuarioAdiciona"].Visible = false;
            this.dtListado.Columns["FechaAdiciona"].Visible = false;
            this.dtListado.Columns["UsuarioModifica"].Visible = false;
            this.dtListado.Columns["ModificadoPor"].Visible = false;
            this.dtListado.Columns["FechaModifica"].Visible = false;
            this.dtListado.Columns["FechaModificado"].Visible = false;
            this.dtListado.Columns["CantidadRegistros"].Visible = false;
        }
        #endregion
        #region RESTABLECER PANTALLA
        private void RestablecerPantalla() {
            txttiposuplidor.Text = string.Empty;
            txtNumeroPagina.Value = 1;
            txtNumeroRegistros.Value = 10;
            txtNumeroPagina.Enabled = true;
            txtNumeroRegistros.Enabled = true;
            btnBuscar.Enabled = true;
            btnNuevo.Enabled = true;
            btnDeshabilitar.Enabled = false;
            btnEditar.Enabled = false;
            MostrarListado();
        }
        #endregion
        #region APLICAR TEMA GENERICO
        private void Aplicartema() {
            this.BackColor = SystemColors.Control;
            txttiposuplidor.BackColor = Color.WhiteSmoke;
            txtNumeroRegistros.BackColor = Color.WhiteSmoke;
            txtNumeroPagina.BackColor = Color.WhiteSmoke;
            dtListado.BackgroundColor = SystemColors.Control;
        }
        #endregion

        private void TipoSuplidoresConsulta_Load(object sender, EventArgs e)
        {
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            lbTitulo.ForeColor = Color.WhiteSmoke;
            lbTitulo.Text = "CONSULTA DE TIPO DE SUPLIDORES";
            lbCantidadRegistrosTitulo.ForeColor = Color.WhiteSmoke;
            lbCantidadRegistrosVariable.ForeColor = Color.WhiteSmoke;
            Aplicartema();
        }

        private void TipoSuplidoresConsulta_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.MantenimientoTipoSuplidores Mantenimiento = new MantenimientoTipoSuplidores();
            Mantenimiento.VariablesGlobales.ModoRecarga = false;
            Mantenimiento.VariablesGlobales.Accion = "INSERT";
            Mantenimiento.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Mantenimiento.VariablesGlobales.IdMantenimeinto = 0;
            Mantenimiento.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.MantenimientoTipoSuplidores Mantenimiento = new MantenimientoTipoSuplidores();
            Mantenimiento.VariablesGlobales.Accion = "UPDATE";
            Mantenimiento.VariablesGlobales.IdMantenimeinto = VariablesGlobales.IdMantenimeinto;
            Mantenimiento.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Mantenimiento.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MostrarListado();
        }

        private void txtNumeroPagina_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroPagina.Value < 1)
            {
                txtNumeroPagina.Value = 1;
                MostrarListado();
            }
            else
            {
                MostrarListado();
            }
        }

        private void txtNumeroRegistros_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroRegistros.Value < 1)
            {
                txtNumeroRegistros.Value = 10;
                MostrarListado();
            }
            else
            {
                MostrarListado();
            }
        }

        private void dtListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.VariablesGlobales.IdMantenimeinto = Convert.ToDecimal(this.dtListado.CurrentRow.Cells["IdTipoSuplidor"].Value.ToString());

            var Seleccionar = ObjdataInventario.Value.BuscaTipoSupidores(
                VariablesGlobales.IdMantenimeinto,
                null, 1, 1);
            dtListado.DataSource = Seleccionar;
            foreach (var n in Seleccionar)
            {
                int Cantidad = Convert.ToInt32(n.CantidadRegistros);
                lbCantidadRegistrosVariable.Text = Cantidad.ToString("N0");
            }
            OcultarColumnas();

            btnBuscar.Enabled = false;
            btnNuevo.Enabled = false;
            btnEditar.Enabled = true;
            btnDeshabilitar.Enabled = true;
            txtNumeroPagina.Enabled = false;
            txtNumeroRegistros.Enabled = false;
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            RestablecerPantalla();
        }
    }
}
