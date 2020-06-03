using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSMarket.Solucion.Pantallas.Pantallas.Servicio
{
    public partial class MantenimientoTipoPago : Form
    {
        public MantenimientoTipoPago()
        {
            InitializeComponent();
        }
       public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();
        #region TEMA GENERICO
        private void AplicarTema()
        {
            lbTitulo.ForeColor = Color.White;
            this.BackColor = SystemColors.Control;
            txtTipoPago.BackColor = Color.WhiteSmoke;
            txtClaveSeguridad.BackColor = Color.WhiteSmoke;
            txtClaveSeguridad.ForeColor = Color.Black;
            txtTipoPago.ForeColor = Color.Black;
        }
        #endregion

        private void MantenimientoTipoPago_Load(object sender, EventArgs e)
        {
            AplicarTema();
            txtClaveSeguridad.PasswordChar = '•';
            if (VariablesGlobales.Accion == "INSERT")
            {
                btnGuardar.Text = "Guardar Registro";
                lbTitulo.Text = "Crear nuevo registro";
            }
            else
            {
                btnGuardar.Text = "Modificar Registro";
                lbTitulo.Text = "Modificar registro seleccionado";
            }
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Servicio.TipoPago Consulta = new TipoPago();
            Consulta.ShowDialog();
        }

        private void MantenimientoTipoPago_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }
    }
}
