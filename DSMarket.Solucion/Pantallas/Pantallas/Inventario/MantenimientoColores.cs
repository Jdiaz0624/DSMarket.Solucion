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
    public partial class MantenimientoColores : Form
    {
        public MantenimientoColores()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaInventario.LogicaInventario> ObjDataInventario = new Lazy<Logica.Logica.LogicaInventario.LogicaInventario>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();
        private void CerrarPantalla() {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.ConsultaColores Consulta = new ConsultaColores();
            Consulta.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Consulta.ShowDialog();
        }

        private void LimpiarControles() {
            txtColor.Text = string.Empty;
            cbEstatus.Checked = true;
        }
        private void MantenimientoColores_Load(object sender, EventArgs e)
        {
            lbTitulo.ForeColor = Color.White;
            lbTitulo.Text = "MANTENIMIENTO DE COLORES";
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            cbEstatus.Checked = true;
            if (VariablesGlobales.Accion != "INSERT") {
                var SacarInformacion = ObjDataInventario.Value.BuscaColoresArticulos(
                    VariablesGlobales.IdMantenimeinto,
                    null, 1, 1);
                foreach (var n in SacarInformacion) {
                    txtColor.Text = n.Color;
                    cbEstatus.Checked = (n.Estatus0.HasValue ? n.Estatus0.Value : false);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtColor.Text.Trim()))
            {
                MessageBox.Show("El campo color no puede estar vacio, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                DSMarket.Logica.Comunes.ProcesarInformacion.ProcesarInformacionColoresArticulos Procesar = new Logica.Comunes.ProcesarInformacion.ProcesarInformacionColoresArticulos(
                    VariablesGlobales.IdMantenimeinto,
                    txtColor.Text,
                    cbEstatus.Checked,
                    VariablesGlobales.IdUsuario,
                    DateTime.Now,
                    VariablesGlobales.Accion);
                Procesar.ProcesarInformacion();
                if (VariablesGlobales.Accion != "INSERT")
                {
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

        private void MantenimientoColores_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason) {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }
    }
}
