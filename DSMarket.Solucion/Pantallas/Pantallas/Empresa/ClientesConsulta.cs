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
    public partial class ClientesConsulta : Form
    {
        public ClientesConsulta()
        {
            InitializeComponent();
        }

        private void ClientesConsulta_Load(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
            dtListado.BackgroundColor = SystemColors.Control;

            txtCedulaCliente.BackColor = Color.WhiteSmoke;
            txtCodigoCliente.BackColor = Color.WhiteSmoke;
            txtNombreCliente.BackColor = Color.WhiteSmoke;
            txtNumeroPagina.BackColor = Color.WhiteSmoke;
            txtNumeroRegistros.BackColor = Color.WhiteSmoke;

            txtCedulaCliente.ForeColor = Color.Black;
            txtCodigoCliente.ForeColor = Color.Black;
            txtNombreCliente.ForeColor = Color.Black;
            txtNumeroPagina.ForeColor = Color.Black;
            txtNumeroRegistros.ForeColor = Color.Black;

            lbTitulo.Text = "CONSULTA DE CLIENTES";
            lbTitulo.ForeColor = Color.White;
            lbCantidadRegistrosTitulo.ForeColor = Color.WhiteSmoke;
            lbCantidadRegistrosVariable.ForeColor = Color.WhiteSmoke;
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.ClientesMantenimiento mantenimiento = new ClientesMantenimiento();
            mantenimiento.VariablesGlobales.Accion = "INSERT";
            mantenimiento.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.ClientesMantenimiento mantenimiento = new ClientesMantenimiento();
            mantenimiento.VariablesGlobales.Accion = "UPDATE";
            mantenimiento.ShowDialog();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.ClientesMantenimiento mantenimiento = new ClientesMantenimiento();
            mantenimiento.VariablesGlobales.Accion = "DELETE";
            mantenimiento.ShowDialog();
        }
    }
}
