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

                    //ELIMINAMOS LOS DATOS DEL REPORTE BAJO EL USUARIO ACTUAL
                    DSMarket.Logica.Comunes.ProcesarInformacion.ProcesarDatosReporteFinanciero Eliminar = new Logica.Comunes.ProcesarInformacion.ProcesarDatosReporteFinanciero(
                        VariablesGlobales.IdUsuario, 0, "", "", 0, "", "", "", "", "DELETE");
                    Eliminar.ProcesarInformacion();

                    int TipoReporte = 0;
                    if (rbEstadoSituacion.Checked) {
                        TipoReporte = 1;
                    }
                    else {
                        TipoReporte = 2;
                    }

                    //SACAMOS LOS DATOS
                    string _Ano = string.IsNullOrEmpty(txtAño.Text.Trim()) ? null : txtAño.Text.Trim();
                    //string me = string.IsNullOrEmpty(txtMes.Text.Trim()) ? null : txtMes.Text.Trim();

                    var SacarDatos = ObjDataContabilidad.Value.SacarDatosRepirteFinancero(
                        _Ano,
                        MesActual,
                        TipoReporte);
                    foreach (var n in SacarDatos) {
                        DSMarket.Logica.Comunes.ProcesarInformacion.ProcesarDatosReporteFinanciero Guardar = new Logica.Comunes.ProcesarInformacion.ProcesarDatosReporteFinanciero(
                            VariablesGlobales.IdUsuario,
                            TipoReporte,
                            n.CuentaAuxiliar,
                            n.ConceptoCuenta,
                            Convert.ToDecimal(n.Valor),
                            n.Cuenta,
                            n.CuentaDescargo,
                            _Ano,
                            MesActual,
                            "INSERT");
                        Guardar.ProcesarInformacion();
                    }
                    //INVOCAMOS EL REPORTE
                    DSMarket.Solucion.Pantallas.Pantallas.Reportes.Reportes Reporte = new Reportes();
                    Reporte.GenerarReporteFinanciero(VariablesGlobales.IdUsuario);
                    Reporte.ShowDialog();
                }
            }
        }

        private void ReportesFinancieros_Load(object sender, EventArgs e)
        {
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            txtAño.Text = DateTime.Now.Year.ToString();
            txtMes.Text = DateTime.Now.Month.ToString();
            rbEstadoSituacion.Checked = true;
            lbTitulo.Text = "GENERAR REPORTE FINANCIEROS";
            lbTitulo.ForeColor = Color.White;
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
