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
    public partial class Caja : Form
    {
        public Caja()
        {
            InitializeComponent();
        }

        private void Caja_Load(object sender, EventArgs e)
        {
            //btnAbirCerrarCaja.Visible = false;
            //Efecto.Show(btnAbirCerrarCaja);
            //btnMonedas.Visible = false;
            //Efecto.Show(btnMonedas);
            //btnCuadreCaja.Visible = false;
            //Efecto.Show(btnCuadreCaja);
            lbTitulo.Text = "PROCESO DE CAJA";
            lbIdUsuario.Text = DSMarket.Solucion.Pantallas.MenuPrincipal.MenuPrincipal.IdUsuarioMantenimientos.ToString();
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAbirCerrarCaja_Click(object sender, EventArgs e)
        {
            DSMarket.Solucion.Pantallas.Pantallas.Caja.Caja Caja = new Pantallas.Caja.Caja();
            Caja.VariablesGlobales.IdUsuario = Convert.ToDecimal(lbIdUsuario.Text);
            Caja.ShowDialog();
        }

        private void btnCuadreCaja_Click(object sender, EventArgs e)
        {
            DSMarket.Solucion.Pantallas.Pantallas.Caja.CuadreCaja Cudre = new Pantallas.Caja.CuadreCaja();
            Cudre.VariablesGlobales.IdUsuario = Convert.ToDecimal(lbIdUsuario.Text);
            Cudre.ShowDialog();
        }

        private void btnMonedas_Click(object sender, EventArgs e)
        {
            DSMarket.Solucion.Pantallas.Pantallas.Caja.ConfigurarMontoInicialCaja MontoInicial = new Pantallas.Caja.ConfigurarMontoInicialCaja();
            MontoInicial.VariablesGlobales.IdUsuario = Convert.ToDecimal(lbIdUsuario.Text);
            MontoInicial.ShowDialog();
        }
    }
}
