using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSMarket.Solucion.Pantallas.Pantallas.Historial
{
    public partial class AnularFactura : Form
    {
        public AnularFactura()
        {
            InitializeComponent();
        }
        public DSMarket.Logica.Logica.LogicaHistorial.LogicaHistorial Hitorial = new Logica.Logica.LogicaHistorial.LogicaHistorial();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        private void CerrarPantalla()
        {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Historial.HistorialFacturacion Historial = new Historial.HistorialFacturacion();
            Historial.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Historial.ShowDialog();
        }
        #region SACAR LA INFORMACION DE LA FACTURA

        #endregion

        private void AnularFactura_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason) {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void AnularFactura_Load(object sender, EventArgs e)
        {
            lbTitulo.ForeColor = Color.White;
            lbTitulo.Text = "ANULACION DE FACTURA";
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            CerrarPantalla();
        }
    }
}
