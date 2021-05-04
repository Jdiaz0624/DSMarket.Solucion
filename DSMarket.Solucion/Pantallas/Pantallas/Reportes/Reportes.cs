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
using System.Net;

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

        enum CodigoReportes { 
        Factura=1,
        Cotizacion=2,
        GananciaFacturacion=3,
        ReporteFacturacion=4,
        HistorialCotizaciones=5,
        CuadreCaja=6,
        ReporteDel606=7,
        ReporteDel607=8,
        ReporteDel608=9,
        CatalogoCuentas=10,
        ReporteInventario=11,
        ComisionEmpleados=12,
        Comprobantes=13,
        Financieros=14
        }

        #region MOSTRAR LA FACTURA  Y LA COTIZACION
        /// <summary>
        /// Este metodo es para generar una factura
        /// </summary>
        /// <param name="IdFactura"></param>
        /// <param name="ImpresionDirecta"></param>
        public void GenerarFacturaVenta(decimal IdFactura, bool ImpresionDirecta) {
            try {

                string UsuarioBD = "", ClaveBD = "", RutaReporte = "";
                var SacarCredencialesBD = ObjDataSeguridad.Value.SacarCredencialBD(1);
                foreach (var n in SacarCredencialesBD) {
                    UsuarioBD = n.Usuario;
                    ClaveBD = DSMarket.Logica.Comunes.SeguridadEncriptacion.DesEncriptar(n.Clave);
                }

                //SACAMOS LA RUTA DEL REPORTE
                var SacarRuta = ObjDataConfiguracion.Value.BuscaRutaReporte((int)CodigoReportes.Factura);
                foreach (var n in SacarRuta) {
                    RutaReporte = n.RutaReporte;
                }

                //GENERAMOS LA FACTURA
                ReportDocument Factura = new ReportDocument();

                SqlCommand comando = new SqlCommand();
                comando.CommandText = "EXEC [Reporte].[SP_GENERAR_FACTURA] @NumeroFactura";
                comando.Connection = DSMarket.Data.Conexion.ConexionADO.BDConexion.ObtenerConexion();

                comando.Parameters.Add("@NumeroFactura", SqlDbType.Decimal);
                comando.Parameters["@NumeroFactura"].Value = IdFactura;

                Factura.Load(@"" + RutaReporte);
                Factura.Refresh();
                Factura.SetParameterValue("@NumeroFactura", IdFactura);
                Factura.SetDatabaseLogon(UsuarioBD, ClaveBD);

                if (ImpresionDirecta == true) {
                    Factura.PrintToPrinter(1, false, 0, 0);
                }
                else if (ImpresionDirecta == false) {
                    crystalReportViewer1.ReportSource = Factura;
                }

            }
            catch (Exception ex) {
                MessageBox.Show("Error al generar la factura de venta, favor de contactar al administrador del sistema, codigo de error--> " + ex.Message, VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Este metodo es para generar una cotizacion mediante el numero
        /// </summary>
        /// <param name="NumeroCotizacion"></param>
        /// <param name="ImpresionDirecta"></param>
        public void GenerarCotizacion(decimal NumeroCotizacion, bool ImpresionDirecta) {
            try {
                string UsuarioBD = "", ClaveBD = "", RutaReporte = "";

                var SacarCredenciales = ObjDataSeguridad.Value.SacarCredencialBD(1);
                foreach (var n in SacarCredenciales) {
                    UsuarioBD = n.Usuario;
                    ClaveBD = DSMarket.Logica.Comunes.SeguridadEncriptacion.DesEncriptar(n.Clave);
                }

                var SacarRutaReporte = ObjDataConfiguracion.Value.BuscaRutaReporte((int)CodigoReportes.Cotizacion);
                foreach (var n in SacarRutaReporte) {
                    RutaReporte = n.RutaReporte;
                }

                //GENERAMOS EL REPORTE
                ReportDocument Cotizacion = new ReportDocument();

                SqlCommand comando = new SqlCommand();
                comando.CommandText = "EXEC [Reporte].[SP_GENERAR_COTIZACION] @NumeroCotizacion";
                comando.Connection = DSMarket.Data.Conexion.ConexionADO.BDConexion.ObtenerConexion();

                comando.Parameters.Add("@NumeroCotizacion", SqlDbType.Decimal);
                comando.Parameters["@NumeroCotizacion"].Value= NumeroCotizacion;

                Cotizacion.Load(@"" + RutaReporte);
                Cotizacion.Refresh();
                Cotizacion.SetParameterValue("@NumeroCotizacion", NumeroCotizacion);
                Cotizacion.SetDatabaseLogon(UsuarioBD, ClaveBD);
                if (ImpresionDirecta == true) {
                    Cotizacion.PrintToPrinter(1, false, 0, 0);
                }
                else if (ImpresionDirecta==false) {
                    crystalReportViewer1.ReportSource = Cotizacion;
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Error al generar la cotización, favor de contactar al administrador del sistema, codigo de error--> " + ex.Message, VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region GENERAR EL CUADRE DE CAJA
        public void GenerarCuadreCaja(decimal IdUsuario) {
            string RutaDeReporte = "", UsuarioBD = "", ClaveBD = "";

            var SacarRutaReporte = ObjDataConfiguracion.Value.BuscaRutaReporte((int)CodigoReportes.CuadreCaja);
            foreach (var n in SacarRutaReporte)
            {
                RutaDeReporte = n.RutaReporte;
            }

            var SacarCredenciales = ObjDataSeguridad.Value.SacarCredencialBD(1);
            foreach (var ncredencialse in SacarCredenciales)
            {
                UsuarioBD = ncredencialse.Usuario;
                ClaveBD = DSMarket.Logica.Comunes.SeguridadEncriptacion.DesEncriptar(ncredencialse.Clave);
            }



            ReportDocument Cuadre = new ReportDocument();

            SqlCommand comando = new SqlCommand();
            comando.CommandText = "[Reporte].[SP_GENERAR_REPORTE_CUADRE_CAJA] @IdUsuario";
            comando.Connection = DSMarket.Data.Conexion.ConexionADO.BDConexion.ObtenerConexion();

            comando.Parameters.Add("@IdUsuario", SqlDbType.Decimal);
            comando.Parameters["@IdUsuario"].Value = IdUsuario;

            
            Cuadre.Load(@"" + RutaDeReporte);
            Cuadre.Refresh();
            Cuadre.SetParameterValue("@IdUsuario", IdUsuario);
            Cuadre.SetDatabaseLogon(UsuarioBD, ClaveBD);
            crystalReportViewer1.ReportSource = Cuadre;
        }
        #endregion

        #region GENERAR REPORTE DE VENTA
        public void GenerarReporteVenta(decimal IdUsuario) {
            try {
                string RutaDeReporte = "", UsuarioBD = "", ClaveBD = "";

                var SacarRutaReporte = ObjDataConfiguracion.Value.BuscaRutaReporte((int)CodigoReportes.ReporteFacturacion);
                foreach (var n in SacarRutaReporte) {
                    RutaDeReporte = n.RutaReporte;
                }

                var SacarCredenciales = ObjDataSeguridad.Value.SacarCredencialBD(1);
                foreach (var ncredencialse in SacarCredenciales) {
                    UsuarioBD = ncredencialse.Usuario;
                    ClaveBD = DSMarket.Logica.Comunes.SeguridadEncriptacion.DesEncriptar(ncredencialse.Clave);
                }

                ReportDocument Reporte = new ReportDocument();

                SqlCommand comando = new SqlCommand();
                comando.CommandText = "EXEC [Reporte].[SP_REPORTE_VENTA] @IdUsuario";
                comando.Connection = DSMarket.Data.Conexion.ConexionADO.BDConexion.ObtenerConexion();

                comando.Parameters.Add("@IdUsuario", SqlDbType.Decimal);
                comando.Parameters["@IdUsuario"].Value = IdUsuario;

                Reporte.Load(@"" + RutaDeReporte);
                Reporte.Refresh();
                Reporte.SetParameterValue("@IdUsuario", IdUsuario);
                Reporte.SetDatabaseLogon(UsuarioBD, ClaveBD);
                crystalReportViewer1.ReportSource = Reporte;
            }
            catch (Exception ex) {
                MessageBox.Show("Error al generar reporte de venta, codigo de error: " + ex.Message, VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region MOSTRAR EL REPORTE DE INVENTARIO GENERAL
        public void GenerarReporteInventarioGeneral(string RutaReporte, string UsuarioBD, string ClaveBD, decimal? IdRegistro,string NumeroConector,decimal? IdTipoProducto,decimal? IdCategoria,decimal? IdMarca,decimal? IdTipoSuplidor,decimal? IdSuplidor,string Descripcion,string CodigoBarra,string Referencia,string NumeroSeguimiento,string CodigoProducto,DateTime? FechaIngresoDesde,DateTime? FechaIngresoHasta,decimal? IdUsuarioGenera,decimal? Stock,int? NumeroPagina,int? NumeroRegistro) {
            try {
                ReportDocument Reporte = new ReportDocument();

                SqlCommand comando = new SqlCommand();
                comando.CommandText = "EXEC  [Inventario].[SP_BUSCA_PRODUCTOS_SERVICIOS] @IdRegistro,@NumeroConector,@IdTipoProducto,@IdCategoria,@IdMarca,@IdTipoSuplidor,@IdSuplidor,@Descripcion,@CodigoBarra,@Referencia,@NumeroSeguimiento,@CodigoProducto,@FechaIngresoDesde,@FechaIngresoHasta,@IdUsuarioGenera,@Stock,@NumeroPagina,@NumeroRegistro";
                comando.Connection = DSMarket.Data.Conexion.ConexionADO.BDConexion.ObtenerConexion();

                Reporte.SetParameterValue("@IdRegistro", IdRegistro);
                Reporte.SetParameterValue("@NumeroConector", NumeroConector);
                Reporte.SetParameterValue("@IdTipoProducto", IdTipoProducto);
                Reporte.SetParameterValue("@IdCategoria", IdCategoria);
                Reporte.SetParameterValue("@IdMarca", IdMarca);
                Reporte.SetParameterValue("@IdTipoSuplidor", IdTipoSuplidor);
                Reporte.SetParameterValue("@IdSuplidor", IdTipoSuplidor);
                Reporte.SetParameterValue("@Descripcion", Descripcion);
                Reporte.SetParameterValue("@CodigoBarra", CodigoBarra);
                Reporte.SetParameterValue("@Referencia", Referencia);
                Reporte.SetParameterValue("@NumeroSeguimiento", NumeroSeguimiento);
                Reporte.SetParameterValue("@CodigoProducto", CodigoProducto);
                Reporte.SetParameterValue("@FechaIngresoDesde", FechaIngresoDesde);
                Reporte.SetParameterValue("@FechaIngresoHasta", FechaIngresoHasta);
                Reporte.SetParameterValue("@IdUsuarioGenera", IdUsuarioGenera);
                Reporte.SetParameterValue("@Stock", Stock);
                Reporte.SetParameterValue("@NumeroPagina", NumeroPagina);
                Reporte.SetParameterValue("@NumeroRegistro", NumeroRegistro);

                Reporte.Load(@"" + RutaReporte);
                Reporte.Refresh();

                Reporte.SetDatabaseLogon(UsuarioBD, ClaveBD);
                crystalReportViewer1.ReportSource = RutaReporte;


                //ReportDocument ReporteInventarioGeneral = new ReportDocument();

                //SqlCommand comando = new SqlCommand();
                //comando.CommandText = "EXEC  [Reporte].[SP_REPORTE_INVENTARIO]";
                //comando.Connection = DSMarket.Data.Conexion.ConexionADO.BDConexion.ObtenerConexion();

                //ReporteInventarioGeneral.Load(@"" + RutaReporte);
                //ReporteInventarioGeneral.Refresh();
                //ReporteInventarioGeneral.SetDatabaseLogon(UsuarioBD, ClaveBD);
                //crystalReportViewer1.ReportSource = ReporteInventarioGeneral;
            }
            catch (Exception ex) {
                MessageBox.Show("Error al mostrar el reporte de ventas general, codigo de error: " + ex.Message, VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region GENERAR EL REPORTE DE LA GANANCIA DE VENTA
        public void GenerarReporteGananciaVenta(decimal IdUsuario) {
            try
            {
                string RutaReporte = "", UsuarioBD = "", ClaveBD = "";

                //SACAMOS LA RUTA DEL REPORTE
                var SacarRuta = ObjDataConfiguracion.Value.BuscaRutaReporte((int)CodigoReportes.GananciaFacturacion);
                foreach (var nRuta in SacarRuta) {
                    RutaReporte = nRuta.RutaReporte;
                }

                //SACAMOS LAS CREDENCIALES DE LA BASE DE DATOS
                var SacarCredenciales = ObjDataSeguridad.Value.SacarCredencialBD(1);
                foreach (var nBD in SacarCredenciales) {
                    UsuarioBD = nBD.Usuario;
                    ClaveBD = DSMarket.Logica.Comunes.SeguridadEncriptacion.DesEncriptar(nBD.Clave);
                }

                //GENERAMOS EL REPORTE
                ReportDocument Ganancia = new ReportDocument();

                SqlCommand comando = new SqlCommand();
                comando.CommandText = "EXEC [Reporte].[SP_GENERAR_GANANCIA_VENTA] @IdUsuario";
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
        public void GenerarReporte606(decimal IdUsuario)
        {
            try
            {
                string RutaReporte = "";
                string UsuarioBD = "";
                string ClaveBD = "";

                //GENERAMOS EL REPORTE
                var SacarRutaReporte = ObjDataConfiguracion.Value.BuscaRutaReporte((int)CodigoReportes.ReporteDel606);
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
                var SacarRutaReporte = ObjDataConfiguracion.Value.BuscaRutaReporte((int)CodigoReportes.CatalogoCuentas);
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

        #region GENERAR EL REPORTE DE PRODUCTOS DEFECTUOSOS
        public void GenerarReporteComprobantes()
        {
            try
            {
                string RutaReporte = "";
                string UsuarioBD = "";
                string ClaveBD = "";

                var SacarRuta = ObjDataConfiguracion.Value.BuscaRutaReporte(17);
                foreach (var n in SacarRuta) {
                    RutaReporte = n.RutaReporte;
                }

                var SacarCrdenciales = ObjDataSeguridad.Value.SacarCredencialBD(1);
                foreach (var n in SacarCrdenciales) {
                    UsuarioBD = n.Usuario;
                    ClaveBD = DSMarket.Logica.Comunes.SeguridadEncriptacion.DesEncriptar(n.Clave);
                }


                ReportDocument Ganancia = new ReportDocument();

                SqlCommand comando = new SqlCommand();
                comando.CommandText = "EXEC [Reporte].[SP_REPORTE_COMPROBANTES_FISCALES]";
                comando.Connection = DSMarket.Data.Conexion.ConexionADO.BDConexion.ObtenerConexion();

                //comando.Parameters.Add("@IdUsuario", SqlDbType.Decimal);
                //comando.Parameters["@IdUsuario"].Value = IdUsuario;

                Ganancia.Load(@"" + RutaReporte);
                Ganancia.Refresh();
                //Ganancia.SetParameterValue("@IdUsuario", IdUsuario);
                Ganancia.SetDatabaseLogon(UsuarioBD, ClaveBD);
                crystalReportViewer1.ReportSource = Ganancia;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el reporte de los productos defectuosos, codigo de error: " + ex.Message, VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region GENERAR REPORTE FINANCIERO (ESTADO DE SITUACION Y ESTADO DE RESULTADO)
        public void GenerarReporteFinanciero(decimal IdUsuario) {
            try {
                string RutaReporte = "";
                string UsuarioBD = "";
                string ClaveBD = "";

                //SACAMOS LA RUTA DEL REPORTE
                var SacarRutaReporte = ObjDataConfiguracion.Value.BuscaRutaReporte(18);
                foreach (var n in SacarRutaReporte)
                {
                    RutaReporte = n.RutaReporte;
                }

                //SACAMOS LAS CREDENCIALES DE BASE DE DATOS
                var SacarCredenciales = ObjDataSeguridad.Value.SacarCredencialBD(1);
                foreach (var nCredneciales in SacarCredenciales)
                {
                    UsuarioBD = nCredneciales.Usuario;
                    ClaveBD = DSMarket.Logica.Comunes.SeguridadEncriptacion.DesEncriptar(nCredneciales.Clave);
                }

                //GENERAMOS EL REPORTE

                ReportDocument ReporteFinanciero = new ReportDocument();

                SqlCommand comando = new SqlCommand();
                comando.CommandText = "[Reporte].[SP_GENERAR_REPORTE_FINANCIERO] @IdUsuario";
                comando.Connection = DSMarket.Data.Conexion.ConexionADO.BDConexion.ObtenerConexion();

                comando.Parameters.Add("@IdUsuario", SqlDbType.Decimal);
                comando.Parameters["@IdUsuario"].Value = IdUsuario;

                ReporteFinanciero.Load(@"" + RutaReporte);
                ReporteFinanciero.Refresh();
                ReporteFinanciero.SetParameterValue("@IdUsuario", IdUsuario);
                ReporteFinanciero.SetDatabaseLogon(UsuarioBD, ClaveBD);
                crystalReportViewer1.ReportSource = ReporteFinanciero;
            }
            catch (Exception ex) {
                MessageBox.Show("Error al generar el reporte financierom favor de verificar, codigo de error: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region GENERAR REPORTE DE COMISION DE EMPLEADOS
        public void GenerarReporteComisionEmpleados(decimal IdUsuario) {
            try {
                string RutaReporte = "";
                string UsuarioBD = "";
                string ClaveBD = "";

                //SACAMOS LA RUTA DEL REPORTE
                var SacarRutaReporte = ObjDataConfiguracion.Value.BuscaRutaReporte(19);
                foreach (var n in SacarRutaReporte)
                {
                    RutaReporte = n.RutaReporte;
                }

                //SACAMOS LAS CREDENCIALES DE BASE DE DATOS
                var SacarCredenciales = ObjDataSeguridad.Value.SacarCredencialBD(1);
                foreach (var nCredneciales in SacarCredenciales)
                {
                    UsuarioBD = nCredneciales.Usuario;
                    ClaveBD = DSMarket.Logica.Comunes.SeguridadEncriptacion.DesEncriptar(nCredneciales.Clave);
                }


                ReportDocument ReporteFinanciero = new ReportDocument();

                SqlCommand comando = new SqlCommand();
                comando.CommandText = "[Reporte].[SP_GENERAR_REPORTE_COMISION_EMPLEADO] @IdUsuario";
                comando.Connection = DSMarket.Data.Conexion.ConexionADO.BDConexion.ObtenerConexion();

                comando.Parameters.Add("@IdUsuario", SqlDbType.Decimal);
                comando.Parameters["@IdUsuario"].Value = IdUsuario;

                ReporteFinanciero.Load(@"" + RutaReporte);
                ReporteFinanciero.Refresh();
                ReporteFinanciero.SetParameterValue("@IdUsuario", IdUsuario);
                ReporteFinanciero.SetDatabaseLogon(UsuarioBD, ClaveBD);
                crystalReportViewer1.ReportSource = ReporteFinanciero;


            }
            catch (Exception ex) {
                MessageBox.Show("Error al generar el reporte de comisiones por la siguiente razón: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region GENERAR REPORTE DE HISTORIAL DE COTIZACIONES
        public void GenerarReporteHistorialCotizaciones(decimal IdUsuario) {
            string RutaReporte = "", UsuarioBD = "", ClaveBD = "";

            //SACAMOS LA RUTA DEL REPORTE
            var SacarRutaReporte = ObjDataConfiguracion.Value.BuscaRutaReporte((int)CodigoReportes.HistorialCotizaciones);
            foreach (var nReportes in SacarRutaReporte) {
                RutaReporte = nReportes.RutaReporte;
            }

            //SACAMOS LAS CREDENCIALES DE BASE DE DATOS
            var SacarCredenciales = ObjDataSeguridad.Value.SacarCredencialBD(1);
            foreach (var n in SacarCredenciales) {
                UsuarioBD = n.Usuario;
                ClaveBD = DSMarket.Logica.Comunes.SeguridadEncriptacion.DesEncriptar(n.Clave);
            }

            //GENERAMOS EL REPORTE
            ReportDocument Reporte = new ReportDocument();

            SqlCommand comando = new SqlCommand();
            comando.CommandText = "EXEC [Reporte].[SP_REPORTE_VENTA] @IdUsuario";
            comando.Connection = DSMarket.Data.Conexion.ConexionADO.BDConexion.ObtenerConexion();

            comando.Parameters.Add("@IdUsuario", SqlDbType.Decimal);
            comando.Parameters["@IdUsuario"].Value = IdUsuario;

            Reporte.Load(@"" + RutaReporte);
            Reporte.Refresh();
            Reporte.SetParameterValue("@IdUsuario", IdUsuario);
            Reporte.SetDatabaseLogon(UsuarioBD, ClaveBD);
            crystalReportViewer1.ReportSource = Reporte;
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
