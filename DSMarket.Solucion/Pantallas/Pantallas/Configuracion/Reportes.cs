using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DSMarket.Solucion.Pantallas.Pantallas.Configuracion
{
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion> ObjDataConfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region MOSTRAR EL LISTADO DE LOS REPORTES
        private void MostrarListadoReportes() {
            var Listado = ObjDataConfiguracion.Value.BuscaRutaReporte(
                new Nullable<int>());
            dtListado.DataSource = Listado;
            this.dtListado.Columns["IdReporte"].Visible = false;
            btnBuscar.Enabled = false;
            txtNombreReporte.Text = string.Empty;
            txtRutaReporte.Text = string.Empty;
        }
        #endregion

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Configuracion.CredencialesBD Credenciales = new CredencialesBD();
            Credenciales.ShowDialog();
  
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            MostrarListadoReportes();
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            lbTitulo.Text = "CONFIGURACION DE REPORTES DEL SISTEMA";
            lbTitulo.ForeColor = Color.WhiteSmoke;
            dtListado.BackgroundColor = SystemColors.Control;
        }

        private void Reportes_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void btnBuscarRuta_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    txtRutaReporte.Text = openFileDialog1.FileName;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar el archivo: " + ex.Message);
                }
            }
        }

        private void dtListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("¿Quieres seleccionar este registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                this.VariablesGlobales.IdMantenimeinto = Convert.ToDecimal(this.dtListado.CurrentRow.Cells["IdReporte"].Value.ToString());

                var Seleccionar = ObjDataConfiguracion.Value.BuscaRutaReporte(Convert.ToInt32(VariablesGlobales.IdMantenimeinto));
                dtListado.DataSource = Seleccionar;
                foreach (var n in Seleccionar) {
                    txtNombreReporte.Text = n.Nombre;
                    txtRutaReporte.Text = n.RutaReporte;
                    }
                this.dtListado.Columns["IdReporte"].Visible = false;
                btnBuscar.Enabled = true;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            MostrarListadoReportes();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DSMarket.Logica.Entidades.EntidadesConfiguracion.ERutaReporte Modificar = new Logica.Entidades.EntidadesConfiguracion.ERutaReporte();

            Modificar.IdReporte = Convert.ToInt32(VariablesGlobales.IdMantenimeinto);
            Modificar.Nombre = txtNombreReporte.Text;
            Modificar.RutaReporte = txtRutaReporte.Text;

            var MAn = ObjDataConfiguracion.Value.MantenimientoRutaReporte(Modificar, "UPDATE");
            MessageBox.Show("Registro modificado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
            MostrarListadoReportes();
        }
    }
}
