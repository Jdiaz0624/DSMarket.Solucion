using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSMarket.Solucion.Pantallas.SubMenus
{
    public partial class Nomina : Form
    {
        public Nomina()
        {
            InitializeComponent();
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Nomina_Load(object sender, EventArgs e)
        {
            lbTitulo.Text = "MODULO DE EMPRESA";
            lbIdUsuario.Text = DSMarket.Solucion.Pantallas.MenuPrincipal.MenuPrincipal.IdUsuarioMantenimientos.ToString();
            lbTitulo.ForeColor = Color.White;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.ClientesConsulta Clientes = new Pantallas.Empresa.ClientesConsulta();
            Clientes.VariablesGlobales.IdUsuario = Convert.ToDecimal(lbIdUsuario.Text);
            Clientes.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.NominaConsulta Nomina = new Pantallas.Empresa.NominaConsulta();
           
            Nomina.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.DepartamentosConsulta Departamentos = new Pantallas.Empresa.DepartamentosConsulta();
            Departamentos.VariablesGlobales.IdUsuario = Convert.ToDecimal(lbIdUsuario.Text);
            Departamentos.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.CargosConsulta Cargos = new Pantallas.Empresa.CargosConsulta();
            Cargos.VariablesGlobales.IdUsuario = Convert.ToDecimal(lbIdUsuario.Text);
            Cargos.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.CompraSuplidores CompraSuplidoresConsulta = new Pantallas.Empresa.CompraSuplidores();
            CompraSuplidoresConsulta.Variableslobales.IdUsuario = Convert.ToDecimal(lbIdUsuario.Text);
            CompraSuplidoresConsulta.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.TipoEmpleadoConsulta TipoEmpleado = new Pantallas.Empresa.TipoEmpleadoConsulta();
            TipoEmpleado.VariablesGlobales.IdUsuario = Convert.ToDecimal(lbIdUsuario.Text);
            TipoEmpleado.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.TipoNominaConsulta TipoNomina = new Pantallas.Empresa.TipoNominaConsulta();
            TipoNomina.VariablesGlobales.IdUsuario = Convert.ToDecimal(lbIdUsuario.Text);
            TipoNomina.ShowDialog();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.BancoConsulta ConsultaBancos = new Pantallas.Empresa.BancoConsulta();
            ConsultaBancos.VariablesGlobales.IdUsuario = Convert.ToDecimal(lbIdUsuario.Text);
            ConsultaBancos.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.TipoMovimientoConsulta ConsultaTipoMovimiento = new Pantallas.Empresa.TipoMovimientoConsulta();
            ConsultaTipoMovimiento.VariablesGlobales.IdUsuario = Convert.ToDecimal(lbIdUsuario.Text);
            ConsultaTipoMovimiento.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.RetencionesConsulta ConsultaRetenciones = new Pantallas.Empresa.RetencionesConsulta();
            ConsultaRetenciones.VariablesGlobales.IdUsuario = Convert.ToDecimal(lbIdUsuario.Text);
            ConsultaRetenciones.ShowDialog();
        }

        private void btnPorcientoRetenciones_Click(object sender, EventArgs e)
        {
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.PorcientoRetencionConsulta ConsultaPorcientoRetencion = new Pantallas.Empresa.PorcientoRetencionConsulta();
            ConsultaPorcientoRetencion.VariablesGlobales.IdUsuario = Convert.ToDecimal(lbIdUsuario.Text);
            ConsultaPorcientoRetencion.ShowDialog();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.NacionalidadConsulta ConsultaNacionalidad = new Pantallas.Empresa.NacionalidadConsulta();
            ConsultaNacionalidad.VariablesGlobales.IdUsuario = Convert.ToInt32(lbIdUsuario.Text);
            ConsultaNacionalidad.ShowDialog();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.EstadoCivilConsulta ConsultaEstadoCivil = new Pantallas.Empresa.EstadoCivilConsulta();
            ConsultaEstadoCivil.VariablesGlobales.IdUsuario = Convert.ToInt32(lbIdUsuario.Text);
            ConsultaEstadoCivil.ShowDialog();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.FormaPagoEmpleadoConsulta ConsultaFormaPago = new Pantallas.Empresa.FormaPagoEmpleadoConsulta();
            ConsultaFormaPago.VariablesGlobales.IdUsuario = Convert.ToDecimal(lbIdUsuario.Text);
            ConsultaFormaPago.ShowDialog();
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.EmpleadosConsulta ConsultarEmpleados = new Pantallas.Empresa.EmpleadosConsulta();
            ConsultarEmpleados.VariablesGlobales.IdUsuario = Convert.ToDecimal(lbIdUsuario.Text);
            ConsultarEmpleados.ShowDialog();
        }
    }
}
