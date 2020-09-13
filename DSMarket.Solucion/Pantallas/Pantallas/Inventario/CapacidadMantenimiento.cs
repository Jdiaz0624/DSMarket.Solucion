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
    public partial class CapacidadMantenimiento : Form
    {
        Lazy<DSMarket.Logica.Logica.LogicaInventario.LogicaInventario> ObjdataInventario = new Lazy<Logica.Logica.LogicaInventario.LogicaInventario>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        private void CerrarPantalla() {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.CapacidadConulta Consulta = new CapacidadConulta();
            Consulta.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Consulta.ShowDialog();
        }
        private void LimpiarControles() {
            txtCapacidad.Text = string.Empty;
            cbEstatus.Checked = true;
        }
        public CapacidadMantenimiento()
        {
            InitializeComponent();
        }

        private void CapacidadMantenimiento_Load(object sender, EventArgs e)
        {
            lbTitulo.Text = "MANTENIMIENTO DE CAPACIDA DE ARTICULOS";
            lbTitulo.ForeColor = Color.White;
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            if (VariablesGlobales.Accion != "INSERT") {
                var SacarDatos = ObjdataInventario.Value.CapacidadArticulos(VariablesGlobales.IdMantenimeinto, null, 1, 1);
                foreach (var n in SacarDatos) {
                    txtCapacidad.Text = n.Capacidad;
                    cbEstatus.Checked=(n.Estatus0.HasValue ? n.Estatus0.Value : false);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCapacidad.Text.Trim())) {
                MessageBox.Show("El campo capacidad no puede estar vacio, para realizar esta operación", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                DSMarket.Logica.Comunes.ProcesarInformacion.ProcesarInformacionCapacidadArticulos Procesar = new Logica.Comunes.ProcesarInformacion.ProcesarInformacionCapacidadArticulos(
                    VariablesGlobales.IdMantenimeinto,
                    txtCapacidad.Text,
                    cbEstatus.Checked,
                    VariablesGlobales.IdUsuario,
                    DateTime.Now,
                    VariablesGlobales.Accion);
                Procesar.ProcesarInformacion();
                if (VariablesGlobales.Accion != "INSERT") {
                    MessageBox.Show("Registro modificado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CerrarPantalla();
                }
                else {
                    MessageBox.Show("Registro guardado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (MessageBox.Show("¿Quieres agregar otro registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        LimpiarControles();
                    }
                    else {
                        CerrarPantalla();
                    }
                }
            }
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            CerrarPantalla();
        }

        private void CapacidadMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason) {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }
    }
}
