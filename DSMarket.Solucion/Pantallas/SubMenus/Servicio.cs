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
    public partial class Servicio : Form
    {
        public Servicio()
        {
            InitializeComponent();
        }

        Lazy<DSMarket.Logica.Logica.LogicaCaja.LogicaCaja> ObjDataCaja = new Lazy<Logica.Logica.LogicaCaja.LogicaCaja>();
        DSMarket.Logica.Comunes.VariablesGlobales VariablsGlobales = new Logica.Comunes.VariablesGlobales();
        private void Servicio_Load(object sender, EventArgs e)
        {
            lbTitulo.Text = "MENU - SERVICIO";
            lbTitulo.ForeColor = Color.White;
            lbUsuario.Text = DSMarket.Solucion.Pantallas.MenuPrincipal.MenuPrincipal.IdUsuarioMantenimientos.ToString();
            VariablsGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            bool EstatusCaja = false;
            var CalidarCaja = ObjDataCaja.Value.BuscaEstatusCaja();
            foreach (var n in CalidarCaja) {
                EstatusCaja = Convert.ToBoolean(n.Estatus0);
            }
            if (EstatusCaja == true)
            {
                DSMarket.Solucion.Pantallas.Pantallas.Servicio.Facturacion FActuracion = new Pantallas.Servicio.Facturacion();
                FActuracion.VariablesGlobales.IdUsuario = Convert.ToDecimal(lbUsuario.Text);
                FActuracion.VariablesGlobales.GenerarConector = true;
                FActuracion.ShowDialog();
            }
            else {
                MessageBox.Show("No se puede acceder a esta pantalla por que la caja esta actualmente cerrada, favor de abrir la caja para poder facturar", VariablsGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DSMarket.Solucion.Pantallas.Pantallas.Servicio.TipoPago MantenimientoTipoPago = new Pantallas.Servicio.TipoPago();
            MantenimientoTipoPago.ShowDialog();
        }

        private void btnCotizacion_Click(object sender, EventArgs e)
        {
            DSMarket.Solucion.Pantallas.Pantallas.Servicio.HistorialFActuracion Historial = new Pantallas.Servicio.HistorialFActuracion();
            Historial.ShowDialog();
        }
    }
}
