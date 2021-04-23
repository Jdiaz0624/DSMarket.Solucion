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
    public partial class MantenimientoCapacidad : Form
    {
        public MantenimientoCapacidad()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaInventario.LogicaInventario> ObjDataInventario = new Lazy<Logica.Logica.LogicaInventario.LogicaInventario>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        private void LimpiarConteroles() {
            txtCapacidad.Text = string.Empty;
            txtCapacidad.Focus();
            cbEstatus.Checked = true;
        }
        private void CerrarPantalla() {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.CapacidadConsulta Consulta = new CapacidadConsulta();
            Consulta.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Consulta.ShowDialog();
        }
        private void ProcesarCapacidad() {
            DSMarket.Logica.Comunes.ProcesarInformacion.Inventario.ProcesarInformacionCapacidad Procsar = new Logica.Comunes.ProcesarInformacion.Inventario.ProcesarInformacionCapacidad(
                VariablesGlobales.IdMantenimeinto,
                txtCapacidad.Text,
                cbEstatus.Checked,
                VariablesGlobales.Accion);
            Procsar.ProcesarInformacion();
        }
        private void SacarInformacionCapacidad() {

            var SacarInformacion = ObjDataInventario.Value.BuscaCapacidad(
                VariablesGlobales.IdMantenimeinto,
                null, 1, 1);
            foreach (var n in SacarInformacion) {
                txtCapacidad.Text = n.Capacidad;
                cbEstatus.Checked = (n.Estatus0.HasValue ? n.Estatus0.Value : false);
            }
        }
        private void MantenimientoCapacidad_Load(object sender, EventArgs e)
        {
            lbTitulo.Text = "MANTENIMIENTO DE CAPACIDAD";
            lbTitulo.ForeColor = Color.White;
            cbEstatus.Checked = true;
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            switch (VariablesGlobales.Accion) {
                case "INSERT":
                    btnGuardar.Text = "Guardar";
                    break;

                case "UPDATE":
                    btnGuardar.Text = "Modificar";
                    SacarInformacionCapacidad();
                    break;

                case "DELETE":
                    btnGuardar.Text = "Borrar";
                    SacarInformacionCapacidad();
                    break;
            }
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            CerrarPantalla();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ProcesarCapacidad();
            switch (VariablesGlobales.Accion)
            {
                case "INSERT":
                    MessageBox.Show("Registro guardado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (MessageBox.Show("¿Quieres guardar otro registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        LimpiarConteroles();
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

        private void MantenimientoCapacidad_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason) {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }
    }
}
