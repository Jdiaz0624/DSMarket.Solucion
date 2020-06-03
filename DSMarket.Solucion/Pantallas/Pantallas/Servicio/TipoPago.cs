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
    public partial class TipoPago : Form
    {
        public TipoPago()
        {
            InitializeComponent();
        }
        #region TEMA GENERICO
        private void AplicarTema() {
            lbTitulo.Text = "Mantenimiento de tipo de pagos";
            lbTitulo.ForeColor = Color.White;
            lbCantidadRegistrosTitulo.Text = "Cantidad de Registros: ";
            lbCantidadRegistrosTitulo.ForeColor = Color.White;
            lbCantidadRegistrosVariable.Text = "0";
            lbCantidadRegistrosVariable.ForeColor = Color.White;


            this.BackColor = SystemColors.Control;
            txtTipoPago.BackColor = Color.WhiteSmoke;
            txtNumeroPagina.BackColor = Color.WhiteSmoke;
            txtNumeroRegistros.BackColor = Color.WhiteSmoke;

            txtTipoPago.ForeColor = Color.Black;
            txtNumeroRegistros.ForeColor = Color.Black;
            txtNumeroPagina.ForeColor = Color.Black;

            dtListado.BackgroundColor = SystemColors.Control;
        }
        #endregion

        private void TipoPago_Load(object sender, EventArgs e)
        {
            AplicarTema();
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void TipoPago_FormClosing(object sender, FormClosingEventArgs e)
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
            DSMarket.Solucion.Pantallas.Pantallas.Servicio.MantenimientoTipoPago Mantenimiento = new MantenimientoTipoPago();
            Mantenimiento.VariablesGlobales.Accion = "INSERT";
            Mantenimiento.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Servicio.MantenimientoTipoPago Mantenimiento = new MantenimientoTipoPago();
            Mantenimiento.VariablesGlobales.Accion = "UPDATE";
            Mantenimiento.ShowDialog();
        }
    }
}
