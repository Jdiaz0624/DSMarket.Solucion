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
    public partial class TipoEmpleadoMantenimiento : Form
    {
        Lazy<DSMarket.Logica.Logica.LogicaEmpresa.LogicaEmpresa> ObjDataEmpleado = new Lazy<Logica.Logica.LogicaEmpresa.LogicaEmpresa>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        private void LimpiarPantalla() {
            txtTipoEmpleado.Text = string.Empty;
            cbEstatus.Checked = true;
        }
        private void CerrarPantalla() {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.TipoEmpleadoConsulta Consulta = new TipoEmpleadoConsulta();
            Consulta.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Consulta.ShowDialog();
        }
 
        public TipoEmpleadoMantenimiento()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTipoEmpleado.Text.Trim()))
            {
                MessageBox.Show("El campo tipo de empleado no puede estar vacio, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                if (VariablesGlobales.Accion == "INSERT") {
                    DSMarket.Logica.Comunes.ProcesarInformacion.Empresa.ProcesarInformacionTipoEmpleados Guardar = new Logica.Comunes.ProcesarInformacion.Empresa.ProcesarInformacionTipoEmpleados(
                        0,
                        txtTipoEmpleado.Text,
                        cbEstatus.Checked,
                        VariablesGlobales.IdUsuario,
                        "INSERT");
                    Guardar.ProcesarInformacion();
                    MessageBox.Show("Registro guardado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (MessageBox.Show("¿Quieres agregar otro registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        LimpiarPantalla();
                    }
                    else {
                        CerrarPantalla();
                    }
                }
                else {
                    DSMarket.Logica.Comunes.ProcesarInformacion.Empresa.ProcesarInformacionTipoEmpleados Modificar = new Logica.Comunes.ProcesarInformacion.Empresa.ProcesarInformacionTipoEmpleados(
                        0,
                        txtTipoEmpleado.Text,
                        cbEstatus.Checked,
                        VariablesGlobales.IdUsuario,
                        "UPDATE");
                    Modificar.ProcesarInformacion();
                    MessageBox.Show("Registro modificado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CerrarPantalla();

                }
            }
        }

        private void TipoEmpleadoMantenimiento_Load(object sender, EventArgs e)
        {
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            lbTitulo.Text = "MANTENIMIENTO DE TIPO DE EMPLEADO";
            lbTitulo.ForeColor = Color.White;
            cbEstatus.Checked = true;

            if (VariablesGlobales.Accion != "UPDATE") {
                var SacarInformacion = ObjDataEmpleado.Value.BuscaTipoEmpleado(
                    VariablesGlobales.IdMantenimeinto,
                    null, 1, 1);
                foreach (var n in SacarInformacion) {
                    txtTipoEmpleado.Text = n.TipoEmpleado;
                    cbEstatus.Checked = (n.Estatus0.HasValue ? n.Estatus0.Value : false);
                }

                //lbclaveSeguridad.Visible = true;
                //txtClaveSeguridad.Visible = true;
            }
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            CerrarPantalla();
        }

        private void TipoEmpleadoMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason) {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
                       
            }
        }
    }
}
