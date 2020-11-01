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
    public partial class MantenimientoPorcientoretencion : Form
    {
        public MantenimientoPorcientoretencion()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaEmpresa.LogicaEmpresa> ObjDataEmpresa = new Lazy<Logica.Logica.LogicaEmpresa.LogicaEmpresa>();
        Lazy<DSMarket.Logica.Logica.LogicaSeguridad.LogicaSeguridad> ObjDataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad.LogicaSeguridad>();
        Lazy<DSMarket.Logica.Logica.LogicaListas.LogicaListas> ObjDataListas = new Lazy<Logica.Logica.LogicaListas.LogicaListas>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        private void MostrarListadoRetenciones()
        {
            var Retenciones = ObjDataListas.Value.ListadoRetenciones();
            ddlRetencencion.DataSource = Retenciones;
            ddlRetencencion.DisplayMember = "Retencion";
            ddlRetencencion.ValueMember = "IdRetencion";
        }

        private void LimpiarControles() {
            txtMontoInicial.Text = string.Empty;
            txtMontoFinal.Text = string.Empty;
            txtMontosumar.Text = string.Empty;
            txtPorcientoCia.Text = string.Empty;
            txtPorcientoEmpleado.Text = string.Empty;

            txtMontoInicial.Text = "0";
            txtMontoFinal.Text = "0";
            txtMontosumar.Text = "0";
            txtPorcientoCia.Text = "0";
            txtPorcientoEmpleado.Text = "0";

        }
        private void CerrarPantalla() {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.PorcientoRetencionConsulta Consulta = new PorcientoRetencionConsulta();
            Consulta.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Consulta.ShowDialog();
        }

        private void MantenimientoPorcientoretencion_Load(object sender, EventArgs e)
        {
            MostrarListadoRetenciones();
            cbEstatus.Checked = true;
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            lbTitulo.Text = "Mantenimiento Porciento Retencines";
            lbTitulo.ForeColor = Color.White;

            if (VariablesGlobales.Accion != "INSERT") {
                var Buscar = ObjDataEmpresa.Value.BuscaPorCientoretenciones(
                    VariablesGlobales.IdMantenimeinto,
                    null,
                    (int)VariablesGlobales.SecuenciaRegistro,
                    1, 1);
                foreach (var n in Buscar) {
                    ddlRetencencion.Text = n.Retencion;
                    txtMontoInicial.Text = n.MontoInicial.ToString();
                    txtMontoFinal.Text = n.MontoFinal.ToString();
                    txtMontosumar.Text = n.MontoSumar.ToString();
                    txtPorcientoCia.Text = n.PorcientoCia.ToString();
                    txtPorcientoEmpleado.Text = n.PorcientoEmpleado.ToString();
                    cbEstatus.Checked = (n.Estatus0.HasValue ? n.Estatus0.Value : false);
                }
                lbclaveSeguridad.Visible = true;
                txtClaveSeguridad.Visible = true;
                txtClaveSeguridad.PasswordChar = '•';
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ddlRetencencion.Text.Trim()) ||  string.IsNullOrEmpty(txtMontoInicial.Text.Trim()) || string.IsNullOrEmpty(txtMontoFinal.Text.Trim()) || string.IsNullOrEmpty(txtMontosumar.Text.Trim()) || string.IsNullOrEmpty(txtPorcientoCia.Text.Trim()) || string.IsNullOrEmpty(txtPorcientoEmpleado.Text.Trim()))
            {
                MessageBox.Show("No puedes dejar campos vacios para realizar esta operación", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else {
                if (VariablesGlobales.Accion == "INSERT") {
                    DSMarket.Logica.Comunes.ProcesarInformacion.Empresa.ProcesarInformacionPorcientoRetencion Nuevo = new Logica.Comunes.ProcesarInformacion.Empresa.ProcesarInformacionPorcientoRetencion(
                        VariablesGlobales.IdMantenimeinto,
                        Convert.ToDecimal(ddlRetencencion.SelectedValue),
                        (int)VariablesGlobales.SecuenciaRegistro,
                        Convert.ToDecimal(txtMontoInicial.Text),
                        Convert.ToDecimal(txtMontoFinal.Text),
                        Convert.ToDecimal(txtMontosumar.Text),
                        Convert.ToDecimal(txtPorcientoCia.Text),
                        Convert.ToDecimal(txtPorcientoEmpleado.Text),
                        cbEstatus.Checked,
                        VariablesGlobales.IdUsuario,
                        VariablesGlobales.Accion);
                    Nuevo.ProcesarInformacion();
                    MessageBox.Show("Registro guardado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (MessageBox.Show("¿Quieres guardar otro registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        LimpiarControles();
                    }
                    else {
                        CerrarPantalla();
                    }
                }
                else {
                    if (string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()))
                    {
                        MessageBox.Show("El campo clave de seguridad no puede estar vacio para modificar este registro, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else {
                        string _ClaveSeguridad = string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()) ? null : txtClaveSeguridad.Text.Trim();

                        var Validar = ObjDataSeguridad.Value.BuscaClaveSeguridad(
                            new Nullable<decimal>(),
                            null,
                            DSMarket.Logica.Comunes.SeguridadEncriptacion.Encriptar(_ClaveSeguridad), 1, 1);
                        if (Validar.Count() < 1) {
                            MessageBox.Show("La clave de seguridad ingresada no es valida, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtClaveSeguridad.Text = string.Empty;
                            txtClaveSeguridad.Focus();
                        }
                        else {
                            DSMarket.Logica.Comunes.ProcesarInformacion.Empresa.ProcesarInformacionPorcientoRetencion Modificar = new Logica.Comunes.ProcesarInformacion.Empresa.ProcesarInformacionPorcientoRetencion(
                           VariablesGlobales.IdMantenimeinto,
                           Convert.ToDecimal(ddlRetencencion.SelectedValue),
                           (int)VariablesGlobales.SecuenciaRegistro,
                           Convert.ToDecimal(txtMontoInicial.Text),
                           Convert.ToDecimal(txtMontoFinal.Text),
                           Convert.ToDecimal(txtMontosumar.Text),
                           Convert.ToDecimal(txtPorcientoCia.Text),
                           Convert.ToDecimal(txtPorcientoEmpleado.Text),
                           cbEstatus.Checked,
                           VariablesGlobales.IdUsuario,
                           VariablesGlobales.Accion);
                            Modificar.ProcesarInformacion();
                            MessageBox.Show("Registro modificado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CerrarPantalla();

                        }
                    
                    }
                }
            }
        }

        private void txtPorcientoEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            DSMarket.Logica.Comunes.ValidarControles.SoloNumerosDecimales(e);
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            CerrarPantalla();
        }

        private void MantenimientoPorcientoretencion_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason) {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }
    }
}
