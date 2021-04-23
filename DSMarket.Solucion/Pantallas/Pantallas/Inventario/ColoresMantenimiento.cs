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
    public partial class ColoresMantenimiento : Form
    {
        public ColoresMantenimiento()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaInventario.LogicaInventario> ObjDataInventario = new Lazy<Logica.Logica.LogicaInventario.LogicaInventario>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        private void LimpiarControles() {
            txtColor.Text = string.Empty;
            cbEstatus.Checked = true;
        }
        private void CerrarPantalla() {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.ColoresConsulta Consulta = new ColoresConsulta();
            Consulta.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Consulta.ShowDialog();
        }

        private void SacarInformacion() {
            var SacarInformacion = ObjDataInventario.Value.BuscaColores(VariablesGlobales.IdMantenimeinto, null, 1, 1);
            foreach (var n in SacarInformacion) {
                txtColor.Text = n.Color;
                cbEstatus.Checked = (n.Estatus0.HasValue ? n.Estatus0.Value : false);
            }
        }

        private void MantenimientoColores() {
            DSMarket.Logica.Comunes.ProcesarInformacion.Inventario.ProcesarInformacionColores Procesar = new Logica.Comunes.ProcesarInformacion.Inventario.ProcesarInformacionColores(
                VariablesGlobales.IdMantenimeinto,
                txtColor.Text,
                cbEstatus.Checked,
                VariablesGlobales.Accion);
            Procesar.ProcesarInformacion();
        }

        private void ColoresMantenimiento_Load(object sender, EventArgs e)
        {
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            lbTitulo.Text = "MANTENIMIENTO DE COLORES";
            lbTitulo.ForeColor = Color.White;

            switch (VariablesGlobales.Accion) {
                case "INSERT":
                    btnGuardar.Text = "Guardar";
                    break;

                case "UPDATE":
                    btnGuardar.Text = "Modificar";
                    SacarInformacion();
                    break;

                case "DELETE":
                    btnGuardar.Text = "Eliminar";
                    SacarInformacion();
                    break;
            }
            cbEstatus.Checked = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MantenimientoColores();
            switch (VariablesGlobales.Accion)
            {
                case "INSERT":
                    MessageBox.Show("Registro guardado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (MessageBox.Show("¿Quieres guardar otro registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        LimpiarControles();
                    }
                    else {
                        CerrarPantalla();
                    }
                    break;

                case "UPDATE":
                    MessageBox.Show("Registro modificado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CerrarPantalla();
                    break;

                case "DELETE":
                    MessageBox.Show("Registro eliminado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CerrarPantalla();
                    break;
            }
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            CerrarPantalla();
        }

        private void ColoresMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason) {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
