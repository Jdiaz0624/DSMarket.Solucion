using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSMarket.Solucion.Pantallas.Pantallas.Reportes
{
    public partial class ReportesFinancieros : Form
    {
        public ReportesFinancieros()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion> ObjDataConfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion>();
        Lazy<DSMarket.Logica.Logica.LogicaContabilidad.LogicaContabilidad> ObjDataContabilidad = new Lazy<Logica.Logica.LogicaContabilidad.LogicaContabilidad>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();



        private void txtMes_KeyPress(object sender, KeyPressEventArgs e)
        {
            DSMarket.Logica.Comunes.ValidarControles.SoloNumeros(e);
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAño.Text.Trim()) || string.IsNullOrEmpty(txtMes.Text.Trim()))
            {
                MessageBox.Show("No puedes dejar campos vacios para generar este reporte", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                string AnoIngresado = txtAño.Text;
                string MesIngresado = txtMes.Text;

                int CantidadDigitosAno = AnoIngresado.Length;
                int CantidadDitigoMes = MesIngresado.Length;

                if (CantidadDigitosAno < 4)
                {
                    MessageBox.Show("El año ingresado no es valido, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else {
                    string MesActual = "";
                    if (CantidadDitigoMes == 1)
                    {
                        MesActual = "0" + MesIngresado;
                    }
                    else {
                        MesActual = MesIngresado;
                    }
                    //PROCESAMOS LA INFORMACION
                    DSMarket.Logica.Comunes.ProcesarInformacion.ProcesarInformacionReportesFinancieros Eliminar = new Logica.Comunes.ProcesarInformacion.ProcesarInformacionReportesFinancieros(
                        VariablesGlobales.IdUsuario, 0, "", "", 0, "", 0, "", 0, 0, 0, "", "", "", 0, 0, "", "", 0, 0, "", 0, 0, "DELETE");
                    Eliminar.ProcesarInformacion();
                    var SacarInformacion = ObjDataContabilidad.Value.SacarInformacionCuentasMovimientos(
                        txtAño.Text,
                        MesActual);
                    foreach (var n in SacarInformacion) {
                        DSMarket.Logica.Comunes.ProcesarInformacion.ProcesarInformacionReportesFinancieros Guardar = new Logica.Comunes.ProcesarInformacion.ProcesarInformacionReportesFinancieros(
                            VariablesGlobales.IdUsuario,
                            Convert.ToDecimal(n.IdRegistro),
                            n.Ano,
                            n.Mes,
                            Convert.ToInt32(n.IdTipoCuenta),
                            n.TipoCuenta,
                            Convert.ToInt32(n.IdModulo),
                            n.Modulo,
                            Convert.ToDecimal(n.Conector),
                            Convert.ToInt32(n.Secuencia),
                            Convert.ToInt32(n.Banco),
                            n.NombreBanco,
                            n.Cuenta,
                            n.Auxiliar,
                            Convert.ToDecimal(n.Valor),
                            Convert.ToInt32(n.IdOrigen),
                            n.OrigenCuenta,
                            n.ConceptoCuenta,
                            Convert.ToDecimal(n.NumeroRelacionado),
                            Convert.ToInt32(n.IdClaseCuenta),
                            n.ClaseCuenta,
                            Convert.ToDecimal(n.IdCuentaContable),
                            Convert.ToInt32(n.CuentaDescargo),
                            "INSERT");
                        Guardar.ProcesarInformacion();
                    }
                    if (rbEstadoSituacion.Checked) { }
                    else { }
                }
            }
        }

        private void ReportesFinancieros_Load(object sender, EventArgs e)
        {
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            txtAño.Text = DateTime.Now.Year.ToString();
            txtMes.Text = DateTime.Now.Month.ToString();
            rbEstadoSituacion.Checked = true;
        }

        private void ReportesFinancieros_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason) {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
