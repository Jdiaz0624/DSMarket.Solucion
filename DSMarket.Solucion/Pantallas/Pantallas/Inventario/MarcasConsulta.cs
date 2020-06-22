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
    public partial class MarcasConsulta : Form
    {
        public MarcasConsulta()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaInventario.LogicaInventario> ObjDataInventario = new Lazy<Logica.Logica.LogicaInventario.LogicaInventario>();
        public DSMarket.Logica.Comunes.VariablesGlobales variablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region MOSTRAR EL LISTADO DE LAS MARCAS
        private void MostrarListadoMarcas()
        {
            string _Marca = string.IsNullOrEmpty(txtMarca.Text.Trim()) ? null : txtMarca.Text.Trim();

            var BuscarRegistros = ObjDataInventario.Value.Buscamarcas(
                new Nullable<decimal>(),
                _Marca,
                Convert.ToInt32(txtNumeroPagina.Value),
                Convert.ToInt32(txtNumeroRegistros.Value));
            dtListado.DataSource = BuscarRegistros;
            if (BuscarRegistros.Count() < 1)
            {
                lbCantidadRegistrosVariable.Text = "0";
            }
            else
            {
                foreach (var n in BuscarRegistros)
                {
                    int Cantidad = Convert.ToInt32(n.CantidadRegistros);
                    lbCantidadRegistrosVariable.Text = Cantidad.ToString("N0");
                }
            }
            OcultarRegistros();
        }

        private void OcultarRegistros() {
            this.dtListado.Columns["IdMarca"].Visible = false;
            this.dtListado.Columns["Estatus0"].Visible = false;
            this.dtListado.Columns["UsuarioAdiciona"].Visible = false;
            this.dtListado.Columns["FechaAdiciona"].Visible = false;
            this.dtListado.Columns["UsuarioModifica"].Visible = false;
            this.dtListado.Columns["FechaModifica"].Visible = false;
            this.dtListado.Columns["CantidadRegistros"].Visible = false;
        }
        #endregion
        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void MarcasConsulta_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.MantenimientoMarcas Mantenimiento = new MantenimientoMarcas();
            Mantenimiento.VariablesGlobales.ModoRecarga = false;
            Mantenimiento.VariablesGlobales.Accion = "INSERT";
            Mantenimiento.VariablesGlobales.IdMantenimeinto = 0;
            Mantenimiento.VariablesGlobales.IdUsuario = variablesGlobales.IdUsuario;
            Mantenimiento.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.MantenimientoMarcas Mantenimiento = new MantenimientoMarcas();
            Mantenimiento.VariablesGlobales.Accion = "UPDATE";
            Mantenimiento.VariablesGlobales.IdMantenimeinto = variablesGlobales.IdMantenimeinto;
            Mantenimiento.VariablesGlobales.IdUsuario = variablesGlobales.IdUsuario;
            Mantenimiento.ShowDialog();
        }

        private void MarcasConsulta_Load(object sender, EventArgs e)
        {
            variablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            lbTitulo.Text = "CONSULTA DE MARCAS";
            lbTitulo.ForeColor = Color.WhiteSmoke;
            lbCantidadRegistrosTitulo.ForeColor = Color.WhiteSmoke;
            lbCantidadRegistrosVariable.ForeColor = Color.WhiteSmoke;
            this.BackColor = SystemColors.Control;
            txtMarca.BackColor = Color.WhiteSmoke;
            txtNumeroPagina.BackColor = Color.WhiteSmoke;
            txtNumeroRegistros.BackColor = Color.WhiteSmoke;
            dtListado.BackgroundColor = SystemColors.Control;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MostrarListadoMarcas();
        }

        private void txtNumeroPagina_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroPagina.Value < 1)
            {
                MessageBox.Show("El numero de pagina no puede estar vacio, favor de verificar", variablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumeroPagina.Value = 1;
                MostrarListadoMarcas();
            }
            else
            {
                MostrarListadoMarcas();
            }
        }

        private void txtNumeroRegistros_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroRegistros.Value < 1)
            {
                MessageBox.Show("El numero de registros no puede ser menor a 1, favor de verificar", variablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumeroRegistros.Value = 10;
                MostrarListadoMarcas();
            }
            else
            {
                MostrarListadoMarcas();
            }
        }

        private void dtListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("¿Quieres seleccionar este registro?", variablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.variablesGlobales.IdMantenimeinto = Convert.ToDecimal(this.dtListado.CurrentRow.Cells["IdMarca"].Value.ToString());

                var BuscarRegistro = ObjDataInventario.Value.Buscamarcas(
                    variablesGlobales.IdMantenimeinto,
                    null, 1, 1);
                if (BuscarRegistro.Count() < 1)
                {
                    lbCantidadRegistrosVariable.Text = "0";
                }
                else
                {
                    foreach (var n in BuscarRegistro)
                    {
                        int Cantidad = Convert.ToInt32(n.CantidadRegistros);
                        lbCantidadRegistrosVariable.Text = Cantidad.ToString("N0");
                    }
                }
                dtListado.DataSource = BuscarRegistro;

                btnBuscar.Enabled = false;
                btnEditar.Enabled = true;
                txtNumeroPagina.Enabled = false;
                txtNumeroRegistros.Enabled = false;
            }
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            btnBuscar.Enabled = true;
            btnEditar.Enabled = false;
            txtNumeroPagina.Enabled = true;
            txtNumeroRegistros.Enabled = true;
            txtMarca.Text = string.Empty;
            txtNumeroPagina.Value = 1;
            txtNumeroRegistros.Value = 10;
            MostrarListadoMarcas();
        }
    }
}
