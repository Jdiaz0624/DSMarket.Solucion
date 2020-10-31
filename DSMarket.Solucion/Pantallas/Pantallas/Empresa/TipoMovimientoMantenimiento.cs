using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSMarket.Solucion.Pantallas.Pantallas.Empresa
{
    public partial class TipoMovimientoMantenimiento : Form
    {
        public TipoMovimientoMantenimiento()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaEmpresa.LogicaEmpresa> ObjData = new Lazy<Logica.Logica.LogicaEmpresa.LogicaEmpresa>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        private void CerrarPantalla() {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.TipoMovimientoConsulta Consulta = new TipoMovimientoConsulta();
            Consulta.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Consulta.ShowDialog();
        }
        private void LimpiarCOntroles() {
            txtTipoMovimiento.Text = string.Empty;
            cbEstatus.Checked = false;
            txtTipoMovimiento.Focus();
        }

        private void TipoMovimientoMantenimiento_Load(object sender, EventArgs e)
        {
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            lbCantidadRegistrosTitulo.ForeColor = Color.White;
            lbCantidadRegistrosVariable.ForeColor = Color.White;
            lbTitulo.ForeColor = Color.White;
            cbEstatus.Checked = true;

            if (VariablesGlobales.Accion != "INSERT") {
                var SacarInformacion = ObjData.Value.ListadoTipoMovimiento(
                    VariablesGlobales.IdMantenimeinto,
                    null, 1, 1);
                foreach (var n in SacarInformacion) {
                    txtTipoMovimiento.Text = n.TipoMovimiento;
                    cbEstatus.Checked = (n.Estatus0.HasValue ? n.Estatus0.Value : false);
                }
            }
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            CerrarPantalla();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTipoMovimiento.Text.Trim()))
            {
                MessageBox.Show("El campo tipo de moviminto no puede estar vacio, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                if (VariablesGlobales.Accion == "INSERT") {
                    DSMarket.Logica.Comunes.ProcesarInformacion.Empresa.ProcesarInformacionTipoMovimiento Guardar = new Logica.Comunes.ProcesarInformacion.Empresa.ProcesarInformacionTipoMovimiento(
                        VariablesGlobales.IdMantenimeinto,
                        txtTipoMovimiento.Text,
                        cbEstatus.Checked,
                        VariablesGlobales.IdUsuario,
                        DateTime.Now,
                        VariablesGlobales.IdUsuario,
                        DateTime.Now,
                        VariablesGlobales.Accion);
                    Guardar.ProcesarInformacion();
                    MessageBox.Show("Registro guardado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (MessageBox.Show("¿Quieres guardar otro registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        LimpiarCOntroles();
                    }
                    else {
                        CerrarPantalla();
                    }
                }
                else {
                    DSMarket.Logica.Comunes.ProcesarInformacion.Empresa.ProcesarInformacionTipoMovimiento Modificar = new Logica.Comunes.ProcesarInformacion.Empresa.ProcesarInformacionTipoMovimiento(
                           VariablesGlobales.IdMantenimeinto,
                           txtTipoMovimiento.Text,
                           cbEstatus.Checked,
                           VariablesGlobales.IdUsuario,
                           DateTime.Now,
                           VariablesGlobales.IdUsuario,
                           DateTime.Now,
                           VariablesGlobales.Accion);
                    Modificar.ProcesarInformacion();
                    MessageBox.Show("Registro Modificado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CerrarPantalla();
                }
            }
        }

        private void TipoMovimientoMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason) {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }
    }
}
