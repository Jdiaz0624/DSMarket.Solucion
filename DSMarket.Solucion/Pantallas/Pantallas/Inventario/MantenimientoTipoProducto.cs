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
    public partial class MantenimientoTipoProducto : Form
    {
        public MantenimientoTipoProducto()
        {
            InitializeComponent();
        }
        #region APLICAR TEMA
        private void AplicarTema() {
            this.BackColor = SystemColors.Control;
            txtTipoProducto.BackColor = Color.WhiteSmoke;
            txtClaveSeguridad.BackColor = Color.WhiteSmoke;

            
        }
        #endregion
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();
        private void cbacumulativo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbacumulativo.Checked == true)
            {
                cbacumulativo.ForeColor = Color.LimeGreen;
                cbEstatus.ForeColor = Color.DarkRed;
            }
            else
            {
                cbacumulativo.ForeColor = Color.DarkRed;
                cbEstatus.ForeColor = Color.DarkRed;
            }
        }

        private void cbEstatus_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEstatus.Checked == true)
            {
                cbacumulativo.ForeColor = Color.DarkRed;
                cbEstatus.ForeColor = Color.LimeGreen;
            }
            else
            {
                cbacumulativo.ForeColor = Color.DarkRed;
                cbEstatus.ForeColor = Color.DarkRed;
            }
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.TipoProductoConsulta Consulta = new TipoProductoConsulta();
            Consulta.ShowDialog();
        }

        private void MantenimientoTipoProducto_Load(object sender, EventArgs e)
        {
            cbacumulativo.Checked = false;
            cbEstatus.Checked = false;
            cbacumulativo.ForeColor = Color.DarkRed;
            cbEstatus.ForeColor = Color.DarkRed;
            AplicarTema();
            if (VariablesGlobales.Accion == "INSERT")
            {
                lbTitulo.Text = "CREAR NUEVO REGISTRO";
                lbTitulo.ForeColor = Color.WhiteSmoke;
                btnGuardar.Text = "Guardar registro";
            }
            else if (VariablesGlobales.Accion == "UPDATE")
            {
                lbTitulo.Text = "MODIFICAR REGISTRO SELECCIONADO";
                btnGuardar.Text = "Modificar registro";
                lbTitulo.ForeColor = Color.WhiteSmoke;
            }
          

        }

        private void MantenimientoTipoProducto_FormClosing(object sender, FormClosingEventArgs e)
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
