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
    public partial class MantenimientoCategoria : Form
    {
        public MantenimientoCategoria()
        {
            InitializeComponent();
        }
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();
        #region APLICAR TEMA
        private void AplicarTema()
        {
            this.BackColor = SystemColors.Control;
            txtCategoria.BackColor = Color.WhiteSmoke;
            txtClaveSeguridad.BackColor = Color.WhiteSmoke;
        }
        #endregion

        private void MantenimientoCategoria_Load(object sender, EventArgs e)
        {
            lbTitulo.ForeColor = Color.WhiteSmoke;
            AplicarTema();
            if (VariablesGlobales.Accion == "INSERT")
            {
                lbTitulo.Text = "CREAR NUEVO REGISTRO";
                btnGuardar.Text = "Guardar Registro";
                lbClaveSeguridad.Visible = false;
                txtClaveSeguridad.Visible = false;
            }
            else if (VariablesGlobales.Accion == "UPDATE")
            {
                lbTitulo.Text = "MODIFICAR REGISTRO SELECCIONADO";
                btnGuardar.Text = "Modificar Registro";
            }
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.CategoriaConsulta Consulta = new CategoriaConsulta();
            Consulta.ShowDialog();
        }
    }
}
