using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSMarket.Solucion.Pantallas.Pantallas.Configuracion
{
    public partial class PoliticasEmpresa : Form
    {
        Lazy<DSMarket.Logica.Logica.LogicaServicio.LogicaServicio> ObjDataServicio = new Lazy<Logica.Logica.LogicaServicio.LogicaServicio>();
        public DSMarket.Logica.Comunes.VariablesGlobales variablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region MOSTRAR EL LISTADO DE LAS OBSERVACIONES
        private void MostrarListado() {

            var Listado = ObjDataServicio.Value.BuscaObservaciones(
                new Nullable<int>());
            dtProductosAgregados.DataSource = Listado;
            this.dtProductosAgregados.Columns["IdObservacion"].Visible = false;
        }
        #endregion
        private void Restablecer()
        {
            MostrarListado();
            txtPolitica.Text = string.Empty;
            btnModificar.Enabled = false;
        }
        public PoliticasEmpresa()
        {
            InitializeComponent();
        }

        private void PoliticasEmpresa_Load(object sender, EventArgs e)
        {
            MostrarListado();
            variablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            lbTitulo.Text = "MODIFICAR POLITICAS DE EMPRESA";
            lbTitulo.ForeColor = Color.White;
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Configuracion.InformacionEmpresa Informacion = new InformacionEmpresa();
            Informacion.VariablesGlobales.IdUsuario = variablesGlobales.IdUsuario;
            Informacion.ShowDialog();
        }

        private void dtProductosAgregados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.variablesGlobales.IdMantenimeinto = Convert.ToDecimal(Convert.ToDecimal(this.dtProductosAgregados.CurrentRow.Cells["IdObservacion"].Value.ToString()));

            var Buscar = ObjDataServicio.Value.BuscaObservaciones(Convert.ToInt32(variablesGlobales.IdMantenimeinto));
            dtProductosAgregados.DataSource = Buscar;
            this.dtProductosAgregados.Columns["IdObservacion"].Visible = false;
            foreach (var n in Buscar)
            {
                txtPolitica.Text = n.Observacion;
                btnModificar.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Restablecer();
        }

        private void PoliticasEmpresa_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason) {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DSMarket.Logica.Comunes.ProcesarInformacion.ProcesarInformacionObservaciones Procesecar = new Logica.Comunes.ProcesarInformacion.ProcesarInformacionObservaciones(
                Convert.ToInt32(variablesGlobales.IdMantenimeinto),
                txtPolitica.Text,
                "UPDATE");
            Procesecar.ProcesarInformacion();
            MessageBox.Show("Registro Modificado con exito", variablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
            Restablecer();
        }
    }
}
