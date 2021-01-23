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
    public partial class MostrarClientesCumpleanos : Form
    {
        public MostrarClientesCumpleanos()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaEmpresa.LogicaEmpresa> ObjDtaEmpresa = new Lazy<Logica.Logica.LogicaEmpresa.LogicaEmpresa>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        private void MostrarListadoCumpleanos() {
            var MostrarListado = ObjDtaEmpresa.Value.MostrarCumpleanosClientes(
                Convert.ToInt32(txtNumeroPagina.Value),
                Convert.ToInt32(txtNumeroRegistros.Value));
            dtListado.DataSource = MostrarListado;

            lbCantidadRegistrosVariable.Text = MostrarListado.Count.ToString("N0");

            this.dtListado.Columns["CodigoCliente"].Visible = false;
            this.dtListado.Columns["MesNacimiento"].Visible = false;
            this.dtListado.Columns["MesActual"].Visible = false;
            this.dtListado.Columns["Cumpleanos"].Visible = false;
        }
        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.ClientesConsulta Consulta = new ClientesConsulta();
            Consulta.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Consulta.ShowDialog();
        }

        private void MostrarClientesCumpleanos_Load(object sender, EventArgs e)
        {
            lbCantidadRegistrosTitulo.ForeColor = Color.White;
            lbCantidadRegistrosVariable.ForeColor = Color.White;
            MostrarListadoCumpleanos();

        }

        private void MostrarClientesCumpleanos_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason) {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }
    }
}
