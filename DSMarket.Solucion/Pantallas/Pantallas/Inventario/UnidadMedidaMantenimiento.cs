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
    public partial class UnidadMedidaMantenimiento : Form
    {
        public UnidadMedidaMantenimiento()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaInventario.LogicaInventario> ObjDataInventario = new Lazy<Logica.Logica.LogicaInventario.LogicaInventario>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        private void LimpiarControles() {
            txtUnidadMedida.Text = string.Empty;
            cbEstatus.Checked = true;
        }


        private void SacarInformacionSeleccionada() {
            var SacarInformacion = ObjDataInventario.Value.BuscaUnidadMedida(VariablesGlobales.IdMantenimeinto, null, 1, 1);
            foreach (var n in SacarInformacion) {
                txtUnidadMedida.Text = n.UnidadMedida;
                cbEstatus.Checked = (n.Estatus0.HasValue ? n.Estatus0.Value : false);
            }
        }
        private void CerrarPantalla() {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.UnidadMedidaConsulta Consulta = new UnidadMedidaConsulta();
            Consulta.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Consulta.ShowDialog();
        }

        private void MantenimientoUnidadMEdida() {

            DSMarket.Logica.Comunes.ProcesarInformacion.Inventario.ProcesarUnidadMedida Procesar = new Logica.Comunes.ProcesarInformacion.Inventario.ProcesarUnidadMedida(
                VariablesGlobales.IdMantenimeinto,
                txtUnidadMedida.Text,
                cbEstatus.Checked,
                VariablesGlobales.Accion);
            Procesar.ProcesarInformacion();
            switch (VariablesGlobales.Accion) {
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
        private void UnidadMedidaMantenimiento_Load(object sender, EventArgs e)
        {
            lbTitulo.Text = "MANTENIMIENTO DE UNIDAD DE MEDIDA";
            lbTitulo.ForeColor = Color.White;
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            cbEstatus.Checked = true;
            if (VariablesGlobales.Accion == "UPDATE")
            {
                SacarInformacionSeleccionada();
                btnGuardar.Text = "Modificar";
            }
            else if (VariablesGlobales.Accion == "DELETE")
            {
                SacarInformacionSeleccionada();
                btnGuardar.Text = "Delete";
            }
            else {
                btnGuardar.Text = "Guardar";
            }
        }

        private void UnidadMedidaMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            CerrarPantalla();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MantenimientoUnidadMEdida();
        }
    }
}
