using DSMarket.Logica.Comunes;
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
    public partial class TipoNominaMantenimiento : Form
    {
        Lazy<DSMarket.Logica.Logica.LogicaEmpresa.LogicaEmpresa> ObjDataEmpresa = new Lazy<Logica.Logica.LogicaEmpresa.LogicaEmpresa>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        private void LimpiarCOntroles() {
            txtTipoNomina.Text = string.Empty;
            cbEstatus.Checked = true;
            txtTipoNomina.Focus();
        }
        private void CerrarPantalla() {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.TipoNominaConsulta Consulta = new TipoNominaConsulta();
            Consulta.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Consulta.ShowDialog();
        }
        public TipoNominaMantenimiento()
        {
            InitializeComponent();
        }

        private void TipoNominaMantenimiento_Load(object sender, EventArgs e)
        {
            lbTitulo.Text = "MANTENIMIENTO DE TIPO DE NOMINA";
            lbTitulo.ForeColor = Color.White;
            cbEstatus.Checked = true;
            VariablesGlobales.NombreSistema = InformacionEmpresa.SacarNombreEmpresa();
            if (VariablesGlobales.Accion != "INSERT") {
                var SacarInformacion = ObjDataEmpresa.Value.BuscaTipoNomina(
                    VariablesGlobales.IdMantenimeinto,
                    null, 1, 1);
                foreach (var n in SacarInformacion) {
                    txtTipoNomina.Text = n.TipoNomina;
                    cbEstatus.Checked = (n.Estatus0.HasValue ? n.Estatus0.Value : false);
                }
            }
    }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTipoNomina.Text.Trim()))
            {
                MessageBox.Show("El campo tipo de nomina no puede estar vacio, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                if (VariablesGlobales.Accion == "INSERT") {
                    DSMarket.Logica.Comunes.ProcesarInformacion.Empresa.ProcesarInformacionTipoNomina Guardar = new Logica.Comunes.ProcesarInformacion.Empresa.ProcesarInformacionTipoNomina(
                        VariablesGlobales.IdMantenimeinto,
                        txtTipoNomina.Text,
                        cbEstatus.Checked,
                        VariablesGlobales.IdUsuario,
                        VariablesGlobales.Accion);
                    Guardar.ProcesarInformacion();
                    MessageBox.Show("Registro guardado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (MessageBox.Show("¿Quieres gaurdar otro registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        LimpiarCOntroles();
                    }
                    else {
                        CerrarPantalla();
                    }
                
                }
                else {
                    DSMarket.Logica.Comunes.ProcesarInformacion.Empresa.ProcesarInformacionTipoNomina Modificar = new Logica.Comunes.ProcesarInformacion.Empresa.ProcesarInformacionTipoNomina(
                           VariablesGlobales.IdMantenimeinto,
                           txtTipoNomina.Text,
                           cbEstatus.Checked,
                           VariablesGlobales.IdUsuario,
                           VariablesGlobales.Accion);
                    Modificar.ProcesarInformacion();
                    MessageBox.Show("Registro Modificado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CerrarPantalla();
                }
            }
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            CerrarPantalla();
        }

        private void TipoNominaMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason) {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }
    }
}
