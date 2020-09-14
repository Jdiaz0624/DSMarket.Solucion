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
    public partial class MantenimientoCondicion : Form
    {
        public MantenimientoCondicion()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaInventario.LogicaInventario> ObjDataInventario = new Lazy<Logica.Logica.LogicaInventario.LogicaInventario>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        private void CerrarPantalla() {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.CondicionConsulta Consulta = new CondicionConsulta();
            Consulta.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Consulta.ShowDialog();
        }

        private void LimpiarControles() {
            txtCondicion.Text = string.Empty;
            cbEstatus.Checked = true;
        }

        private void MantenimientoCondicion_Load(object sender, EventArgs e)
        {
            lbTitulo.Text = "MANTENIMIENTO DE CONDICIONES";
            lbTitulo.ForeColor = Color.White;
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            cbEstatus.Checked = true;
            if (VariablesGlobales.Accion != "INSERT") {
                var SacarDatos = ObjDataInventario.Value.BuscaCondiciones(VariablesGlobales.IdMantenimeinto, null, 1, 1);
                foreach (var n in SacarDatos) {
                    txtCondicion.Text = n.Condicion;
                    cbEstatus.Checked = (n.Estatus0.HasValue ? n.Estatus0.Value : false);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCondicion.Text.Trim())) {
                MessageBox.Show("El campo condición no puede estar vacio para realizar esta operación, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                DSMarket.Logica.Comunes.ProcesarInformacion.ProcesarInformacioNCondicionArticulos Procesar = new Logica.Comunes.ProcesarInformacion.ProcesarInformacioNCondicionArticulos(
                    VariablesGlobales.IdMantenimeinto,
                    txtCondicion.Text,
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
                    if (MessageBox.Show("¿Quieres guardar otro registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

        private void MantenimientoCondicion_FormClosed(object sender, FormClosedEventArgs e)
        {
          
        }

        private void MantenimientoCondicion_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason) {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }
    }
}
