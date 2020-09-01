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
        Lazy<DSMarket.Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion> ObjDataConfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion>();
        Lazy<DSMarket.Logica.Logica.LogicaSeguridad.LogicaSeguridad> ObjDataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad.LogicaSeguridad>();
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
                Factura.Refresh();
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

        #region MOSTRAR EL REPORTE DE INVENTARIO GENERAL
        public void GenerarReporteInventarioGeneral(string RutaReporte, string UsuarioBD, string ClaveBD) {
            try {
                ReportDocument ReporteInventarioGeneral = new ReportDocument();

                SqlCommand comando = new SqlCommand();
                comando.CommandText = "EXEC  [Reporte].[SP_REPORTE_INVENTARIO]";
                comando.Connection = DSMarket.Data.Conexion.ConexionADO.BDConexion.ObtenerConexion();

                ReporteInventarioGeneral.Load(@"" + RutaReporte);
                ReporteInventarioGeneral.Refresh();
                ReporteInventarioGeneral.SetDatabaseLogon(UsuarioBD, ClaveBD);
                crystalReportViewer1.ReportSource = ReporteInventarioGeneral;
            }
            catch (Exception ex) {
                MessageBox.Show("Error al mostrar el reporte de ventas general, codigo de error: " + ex.Message, VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region GENERAR EL REPORTE DE LA GANANCIA DE VENTA
        public void GenerarReporteGananciaVenta(decimal IdUsuario, string RutaReporte, string UsuarioBD, string ClaveBD) {
            try
            {
                ReportDocument Ganancia = new ReportDocument();

                SqlCommand comando = new SqlCommand();
                comando.CommandText = "EXEC [Reporte].[SP_GENERAR_REPORTE_GANANCIA_VENTA] @IdUsuario";
                comando.Connection = DSMarket.Data.Conexion.ConexionADO.BDConexion.ObtenerConexion();

                comando.Parameters.Add("@IdUsuario", SqlDbType.Decimal);
                comando.Parameters["@IdUsuario"].Value = IdUsuario;

                Ganancia.Load(@"" + RutaReporte);
                Ganancia.Refresh();
                Ganancia.SetParameterValue("@IdUsuario", IdUsuario);
                Ganancia.SetDatabaseLogon(UsuarioBD, ClaveBD);
                crystalReportViewer1.ReportSource = Ganancia;
            }
            catch (Exception ex) {
                MessageBox.Show("Error al generar el reporte de las ganancias, codigo de error: " + ex.Message, VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region GENERAR EL REPORTE DE PRODUCTOS DEFECTUOSOS
        public void GenerarReporteProductosDefectuosos(decimal IdUsuario, string RutaReporte, string UsuarioBD, string ClaveBD)
        {
            try
            {
                ReportDocument Ganancia = new ReportDocument();

                SqlCommand comando = new SqlCommand();
                comando.CommandText = "EXEC [Reporte].[REPORTE_LISTADO_PRODUCTOS_DEFECTUOSOS] @IdUsuario";
                comando.Connection = DSMarket.Data.Conexion.ConexionADO.BDConexion.ObtenerConexion();

                comando.Parameters.Add("@IdUsuario", SqlDbType.Decimal);
                comando.Parameters["@IdUsuario"].Value = IdUsuario;

                Ganancia.Load(@"" + RutaReporte);
                Ganancia.Refresh();
                Ganancia.SetParameterValue("@IdUsuario", IdUsuario);
                Ganancia.SetDatabaseLogon(UsuarioBD, ClaveBD);
                crystalReportViewer1.ReportSource = Ganancia;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el reporte de los productos defectuosos, codigo de error: " + ex.Message, VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region GENERAR EL REPORTE DEL 606
        public void GenerarReporte606(decimal IdUsuario, string RutaReporte, string UsuarioBD, string ClaveBD)
        {
            try
            {
                ReportDocument Ganancia = new ReportDocument();

                SqlCommand comando = new SqlCommand();
                comando.CommandText = "EXEC [Reporte].[SP_GENERAR_REPORTE_606] @IdUsuario";
                comando.Connection = DSMarket.Data.Conexion.ConexionADO.BDConexion.ObtenerConexion();

                comando.Parameters.Add("@IdUsuario", SqlDbType.Decimal);
                comando.Parameters["@IdUsuario"].Value = IdUsuario;

                Ganancia.Load(@"" + RutaReporte);
                Ganancia.Refresh();
                Ganancia.SetParameterValue("@IdUsuario", IdUsuario);
                Ganancia.SetDatabaseLogon(UsuarioBD, ClaveBD);
                crystalReportViewer1.ReportSource = Ganancia;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el reporte del 606, codigo de error: " + ex.Message, VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region GENERAR EL REPORTE DEL 607
        public void GenerarReporte607(decimal IdUsuario)
        {
            try
            {

               
                string RutaReporte = "";
                string UsuarioBD = "";
                string ClaveBD = "";

                //GENERAMOS EL REPORTE
                var SacarRutaReporte = ObjDataConfiguracion.Value.BuscaRutaReporte(11);
                foreach (var n in SacarRutaReporte) {
                    RutaReporte = n.RutaReporte;
                }

                //SACAMOS LAS CREDENCIALES DE LA BASE DE DATOS
                var SacarCredenciales = ObjDataSeguridad.Value.SacarCredencialBD(1);
                foreach (var nSeguridad in SacarCredenciales) {
                    UsuarioBD = nSeguridad.Usuario;
                    ClaveBD = DSMarket.Logica.Comunes.SeguridadEncriptacion.DesEncriptar(nSeguridad.Clave);
                }

                //INVOCAMOS EL REPORTE
                ReportDocument Ganancia = new ReportDocument();

                SqlCommand comando = new SqlCommand();
                comando.CommandText = "EXEC [Reporte].[SP_GENERAR_REPORTE_607_POR_PANTALLA] @IdUsuario";
                comando.Connection = DSMarket.Data.Conexion.ConexionADO.BDConexion.ObtenerConexion();

                comando.Parameters.Add("@IdUsuario", SqlDbType.Decimal);
                comando.Parameters["@IdUsuario"].Value = IdUsuario;

                Ganancia.Load(@"" + RutaReporte);
                Ganancia.Refresh();
                Ganancia.SetParameterValue("@IdUsuario", IdUsuario);
                Ganancia.SetDatabaseLogon(UsuarioBD, ClaveBD);
                crystalReportViewer1.ReportSource = Ganancia;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el reporte del 606, codigo de error: " + ex.Message, VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region GENERAR EL REPORTE DEL 608
        public void GenerarReporte608(decimal IdUsuario)
        {
            try
            {


                string RutaReporte = "";
                string UsuarioBD = "";
                string ClaveBD = "";

                //GENERAMOS EL REPORTE
                var SacarRutaReporte = ObjDataConfiguracion.Value.BuscaRutaReporte(13);
                foreach (var n in SacarRutaReporte)
                {
                    RutaReporte = n.RutaReporte;
                }

                //SACAMOS LAS CREDENCIALES DE LA BASE DE DATOS
                var SacarCredenciales = ObjDataSeguridad.Value.SacarCredencialBD(1);
                foreach (var nSeguridad in SacarCredenciales)
                {
                    UsuarioBD = nSeguridad.Usuario;
                    ClaveBD = DSMarket.Logica.Comunes.SeguridadEncriptacion.DesEncriptar(nSeguridad.Clave);
                }

                //INVOCAMOS EL REPORTE
                ReportDocument Ganancia = new ReportDocument();

                SqlCommand comando = new SqlCommand();
                comando.CommandText = "EXEC [Reporte].[SP_REPORTE_PANTALLA_608] @IdUsuario";
                comando.Connection = DSMarket.Data.Conexion.ConexionADO.BDConexion.ObtenerConexion();

                comando.Parameters.Add("@IdUsuario", SqlDbType.Decimal);
                comando.Parameters["@IdUsuario"].Value = IdUsuario;

                Ganancia.Load(@"" + RutaReporte);
                Ganancia.Refresh();
                Ganancia.SetParameterValue("@IdUsuario", IdUsuario);
                Ganancia.SetDatabaseLogon(UsuarioBD, ClaveBD);
                crystalReportViewer1.ReportSource = Ganancia;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el reporte del 606, codigo de error: " + ex.Message, VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region GENERAR REPORTE DEL CATALOGO DE CUENTAS
        public void GenerarReporteCatalogoCuentas() {
            try {
                string RutaReporte = "";
                string UsuarioBD = "";
                string ClaveBD = "";

                //GENERAMOS EL REPORTE
                var SacarRutaReporte = ObjDataConfiguracion.Value.BuscaRutaReporte(16);
                foreach (var n in SacarRutaReporte)
                {
                    RutaReporte = n.RutaReporte;
                }

                //SACAMOS LAS CREDENCIALES DE LA BASE DE DATOS
                var SacarCredenciales = ObjDataSeguridad.Value.SacarCredencialBD(1);
                foreach (var nSeguridad in SacarCredenciales)
                {
                    UsuarioBD = nSeguridad.Usuario;
                    ClaveBD = DSMarket.Logica.Comunes.SeguridadEncriptacion.DesEncriptar(nSeguridad.Clave);
                }

                //INVOCAMOS EL REPORTE
                ReportDocument CATALOGO = new ReportDocument();

                SqlCommand comando = new SqlCommand();
                comando.CommandText = "EXEC [Reporte].[CATALOGO_CUENTAS]";
                comando.Connection = DSMarket.Data.Conexion.ConexionADO.BDConexion.ObtenerConexion();

                //  comando.Parameters.Add("@IdUsuario", SqlDbType.Decimal);
                //  comando.Parameters["@IdUsuario"].Value = IdUsuario;

                CATALOGO.Load(@"" + RutaReporte);
                CATALOGO.Refresh();
                // Ganancia.SetParameterValue("@IdUsuario", IdUsuario);
                CATALOGO.SetDatabaseLogon(UsuarioBD, ClaveBD);
                crystalReportViewer1.ReportSource = CATALOGO;

            }
            catch (Exception ex) {
                MessageBox.Show("Error al generar el reporte de estado de cuenta, codigo de error " + ex.Message, "ERROR AL GENERAR REPORTE",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        private void Reportes_Load(object sender, EventArgs e)
        {
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
