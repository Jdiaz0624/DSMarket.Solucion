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
    public partial class MantenimientoCondiciones : Form
    {
        public MantenimientoCondiciones()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaInventario.LogicaInventario> ObjDataInventario = new Lazy<Logica.Logica.LogicaInventario.LogicaInventario>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        private void LimpiarControles() {
            txtCondicion.Text = string.Empty;
            cbEstatus.Checked = true;
        }
        private void CerrarPantalla() {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.CondicionConsulta Consulta = new CondicionConsulta();
            Consulta.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Consulta.ShowDialog();
        }
        private void MANCondicion() {
            DSMarket.Logica.Comunes.ProcesarInformacion.Inventario.ProcesarCondiciones Procesar = new Logica.Comunes.ProcesarInformacion.Inventario.ProcesarCondiciones(
                VariablesGlobales.IdMantenimeinto,
                txtCondicion.Text,
                cbEstatus.Checked,
                VariablesGlobales.Accion);
            Procesar.ProcesarInformacion();
        }
        private void SacarInformacion() {
            var SacrInformacion = ObjDataInventario.Value.BuscaCondiciones(VariablesGlobales.IdMantenimeinto, null, 1, 1);
            foreach (var n in SacrInformacion) {
                txtCondicion.Text = n.Condicion;
                cbEstatus.Checked = (n.Estatus0.HasValue ? n.Estatus0.Value : false);
            }
        }
        private void MantenimientoCondiciones_Load(object sender, EventArgs e)
        {
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            lbTitulo.Text = "MANTENIMIENTO DE CONDICIONES";
            lbTitulo.ForeColor = Color.White;
            cbEstatus.Checked = true;
            switch (VariablesGlobales.Accion) {
                case "INSERT":
                    btnGuardar.Text = "Guardar";
                    break;

                case "UPDATE":
                    btnGuardar.Text = "Modificar";
                    SacarInformacion();
                    break;

                case "DELETE":
                    btnGuardar.Text = "Borrar";
                    SacarInformacion();
                    break;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MANCondicion();

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
                    MessageBox.Show("Registro borrar con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CerrarPantalla();
                    break;
            }
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            CerrarPantalla();
        }

        private void MantenimientoCondiciones_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason) {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }
    }
}
