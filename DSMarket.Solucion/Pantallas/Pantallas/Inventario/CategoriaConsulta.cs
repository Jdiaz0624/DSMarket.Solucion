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
        #region Aplicar Tema
        private void APlicarTema()
        {
            this.BackColor = SystemColors.Control;

            txtTipoProducto.BackColor = Color.WhiteSmoke;
            txtNumeroPagina.BackColor = Color.WhiteSmoke;
            txtNumeroRegistros.BackColor = Color.WhiteSmoke;
            ddlTipoProducto.BackColor = Color.WhiteSmoke;
            dtListado.BackgroundColor = SystemColors.Control;
        }
        #endregion
        private void CategoriaConsulta_Load(object sender, EventArgs e)
        {
            lbTitulo.Text = "CONSULTA DE CATEGORIAS";
            lbTitulo.ForeColor = Color.WhiteSmoke;
            lbCantidadRegistrosVariable.ForeColor = Color.WhiteSmoke;
            lbCantidadRegistrosTitulo.ForeColor = Color.WhiteSmoke;
            APlicarTema();

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
            Mantenimiento.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.MantenimientoCategoria Mantenimiento = new MantenimientoCategoria();
            Mantenimiento.VariablesGlobales.Accion = "UPDATE";
            Mantenimiento.ShowDialog();
        }
    }
}
