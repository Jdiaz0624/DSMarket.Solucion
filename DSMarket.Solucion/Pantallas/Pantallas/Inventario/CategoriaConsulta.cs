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
    public partial class CategoriaConsulta : Form
    {
        public CategoriaConsulta()
        {
            InitializeComponent();
        }
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();
        Lazy<DSMarket.Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion> ObjDataCOnfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion>();
        Lazy<DSMarket.Logica.Logica.LogicaInventario.LogicaInventario> ObjdataInventario = new Lazy<Logica.Logica.LogicaInventario.LogicaInventario>();
        Lazy<DSMarket.Logica.Logica.LogicaListas.LogicaListas> ObjDataListas = new Lazy<Logica.Logica.LogicaListas.LogicaListas>();

        #region Aplicar Tema
        private void APlicarTema()
        {
            this.BackColor = SystemColors.Control;

            txtCategorias.BackColor = Color.WhiteSmoke;
            txtNumeroPagina.BackColor = Color.WhiteSmoke;
            txtNumeroRegistros.BackColor = Color.WhiteSmoke;
            ddlTipoProducto.BackColor = Color.WhiteSmoke;
            dtListado.BackgroundColor = SystemColors.Control;
        }
        #endregion
        #region CARGAR LOS TIPOS DE PRODUCTOS
        private void CargarTipoProductos()
        {
            try {
                var CargarTipoProducto = ObjDataListas.Value.ListaTipoProducto();
                ddlTipoProducto.DataSource = CargarTipoProducto;
                ddlTipoProducto.DisplayMember = "Descripcion";
                ddlTipoProducto.ValueMember = "IdTipoproducto";
            }
            catch (Exception) {
              
            }
        }
        #endregion
        #region MOSTRAR EL LISTADO DE LAS CATEGORIAS
        private void MostrarCategorias() {
          //  try {
                if (cbNoAgregarTipoProducto.Checked)
                {
                    string _Categorias = string.IsNullOrEmpty(txtCategorias.Text.Trim()) ? null : txtCategorias.Text.Trim();

                    var Buscar = ObjdataInventario.Value.Buscacategoria(
                        new Nullable<decimal>(),
                        null,
                        _Categorias,
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
                        int Cantidad = Convert.ToInt32(n.CantidadRegistros);
                        lbCantidadRegistrosVariable.Text = Cantidad.ToString("N0");
                    }
                }
            }
                else
                {
                    string _Categorias = string.IsNullOrEmpty(txtCategorias.Text.Trim()) ? null : txtCategorias.Text.Trim();

                    var Buscar = ObjdataInventario.Value.Buscacategoria(
                        new Nullable<decimal>(),
                        Convert.ToDecimal(ddlTipoProducto.SelectedValue),
                        _Categorias,
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
                        int Cantidad = Convert.ToInt32(n.CantidadRegistros);
                        lbCantidadRegistrosVariable.Text = Cantidad.ToString("N0");
                    }
                }
            }
                OcultarColumnas();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error al mostrar el listado de las categorias Codigo de error --> " + ex.Message, VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
        private void OcultarColumnas()
        {
            this.dtListado.Columns["IdCategoria"].Visible = false;
            this.dtListado.Columns["IdTipoProducto"].Visible = false;
            this.dtListado.Columns["Estatus0"].Visible = false;
            this.dtListado.Columns["UsuarioAdiciona"].Visible = false;
            this.dtListado.Columns["Fechaadiciona"].Visible = false;
            this.dtListado.Columns["UsuarioModifica"].Visible = false;
            this.dtListado.Columns["FechaModifica"].Visible = false;
            this.dtListado.Columns["CantidadRegistros"].Visible = false;
        }
        #endregion
        #region SACAR LA INFORMACION DE LA EMPRESA
        private void SacarInformacionEmpresa()
        {
            var SacarInformacionEmpresa = ObjDataCOnfiguracion.Value.BuscaInformacionEmpresa();
            foreach (var n in SacarInformacionEmpresa)
            {
                VariablesGlobales.NombreSistema = n.NombreEmpresa;
            }
        }
        #endregion
        private void CategoriaConsulta_Load(object sender, EventArgs e)
        {
            SacarInformacionEmpresa();
            lbTitulo.Text = "CONSULTA DE CATEGORIAS";
            lbTitulo.ForeColor = Color.WhiteSmoke;
            lbCantidadRegistrosVariable.ForeColor = Color.WhiteSmoke;
            lbCantidadRegistrosTitulo.ForeColor = Color.WhiteSmoke;
            APlicarTema();
            CargarTipoProductos();
            this.dtListado.RowsDefaultCellStyle.BackColor = SystemColors.Control;
            this.dtListado.AlternatingRowsDefaultCellStyle.BackColor = SystemColors.Control;
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.MantenimientoCategoria Mantenimiento = new MantenimientoCategoria();
            Mantenimiento.VariablesGlobales.Accion = "INSERT";
            Mantenimiento.VariablesGlobales.IdMantenimeinto = 0;
            Mantenimiento.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Mantenimiento.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.MantenimientoCategoria Mantenimiento = new MantenimientoCategoria();
            Mantenimiento.VariablesGlobales.Accion = "UPDATE";
            Mantenimiento.VariablesGlobales.IdMantenimeinto = VariablesGlobales.IdMantenimeinto;
            Mantenimiento.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Mantenimiento.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MostrarCategorias();
        }

        private void txtNumeroPagina_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroPagina.Value < 1)
            {
                MessageBox.Show("El numero de paginas no puede ser menor a 1", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumeroPagina.Value = 1;
                MostrarCategorias();
            }
            else
            {
                MostrarCategorias();
            }
        }

        private void txtNumeroRegistros_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroRegistros.Value < 1)
            {
                MessageBox.Show("El numero de registros no puede ser menor a 1, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumeroRegistros.Value = 10;
                MostrarCategorias();
            }
            else
            {
                MostrarCategorias();
            }
        }

        private void dtListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }   

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            btnBuscar.Enabled = true;
            btnEditar.Enabled = false;
            txtNumeroPagina.Enabled = true;
            txtNumeroRegistros.Enabled = true;
            CargarTipoProductos();
            txtCategorias.Text = string.Empty;
        }

        private void dtListado_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("¿Quieres selecionar este registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.VariablesGlobales.IdMantenimeinto = Convert.ToDecimal(this.dtListado.CurrentRow.Cells["IdCategoria"].Value.ToString());

                var Buscar = ObjdataInventario.Value.Buscacategoria(VariablesGlobales.IdMantenimeinto, null, null, 1, 1);
                dtListado.DataSource = Buscar;
                OcultarColumnas();
                btnBuscar.Enabled = false;
                btnEditar.Enabled = true;
                txtNumeroPagina.Enabled = false;
                txtNumeroRegistros.Enabled = false;
            }

        }
    }
}
