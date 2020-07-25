using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;
using System.Data.SqlClient;

namespace DSMarket.Solucion.Pantallas.Pantallas.Reportes
{
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region MOSTRAR LA FACTURA 
        public void GenerarFacturaVenta(decimal IdFactura, string RutaReporte, string UsuaruoBD, string ClaveBD) {
            try {
                ReportDocument Factura = new ReportDocument();

                SqlCommand comando = new SqlCommand();
                comando.CommandText = "EXEC [Reporte].[SP_GENERAR_FACTURA_VENTA] @IdFactura";
                comando.Connection = DSMarket.Data.Conexion.ConexionADO.BDConexion.ObtenerConexion();

                comando.Parameters.Add("@IdFactura", SqlDbType.Decimal);
                comando.Parameters["@IdFactura"].Value = IdFactura;

                Factura.Load(@"" + RutaReporte);
                Factura.SetParameterValue("@IdFactura", IdFactura);
                Factura.SetDatabaseLogon(UsuaruoBD, ClaveBD);
                crystalReportViewer1.ReportSource = Factura;



            }
            catch (Exception ex) {
                MessageBox.Show("Error al generar la factura de venta, favor de contactar al administrador del sistema, codigo de error--> " + ex.Message, VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region GENERAR EL CUADRE DE CAJA
        public void GenerarCuadreCaja(decimal IdUsuario, string RutaReporte, string UsuarioBD, string ClaveBD) {
            ReportDocument Cuadre = new ReportDocument();

            SqlCommand comando = new SqlCommand();
            comando.CommandText = "[Reporte].[SP_GENERAR_REPORTE_CUADRE_CAJA] @IdUsuario";
            comando.Connection = DSMarket.Data.Conexion.ConexionADO.BDConexion.ObtenerConexion();

            comando.Parameters.Add("@IdUsuario", SqlDbType.Decimal);
            comando.Parameters["@IdUsuario"].Value = IdUsuario;

            
            Cuadre.Load(@"" + RutaReporte);
            Cuadre.Refresh();
            Cuadre.SetParameterValue("@IdUsuario", IdUsuario);
            Cuadre.SetDatabaseLogon(UsuarioBD, ClaveBD);
            crystalReportViewer1.ReportSource = Cuadre;
        }
        #endregion

        #region GENERAR REPORTE DE VENTA
        public void GenerarReporteVenta(decimal IdUsuario, string RutaReporte, string UsuarioBD, string ClaveBD) {
            try {
                ReportDocument ReporteVenta = new ReportDocument();
                SqlCommand comando = new SqlCommand();
                comando.CommandText = "EXEC [Reporte].[SP_BUSCAR_REPORTE_VENTA] @IdUsuario";
                comando.Connection = DSMarket.Data.Conexion.ConexionADO.BDConexion.ObtenerConexion();

                comando.Parameters.Add("@IdUsuario", SqlDbType.Decimal);
                comando.Parameters["@IdUsuario"].Value = IdUsuario;

                ReporteVenta.Load(@"" + RutaReporte);
                ReporteVenta.Refresh();
                ReporteVenta.SetParameterValue("@IdUsuario", IdUsuario);
                ReporteVenta.SetDatabaseLogon(UsuarioBD, ClaveBD);
                crystalReportViewer1.ReportSource = ReporteVenta;
            }
            catch (Exception ex) {
                MessageBox.Show("Error al generar reporte de venta, codigo de error: " + ex.Message, VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void Reportes_Load(object sender, EventArgs e)
        {
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
        }
    }
}
