using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSMarket.Solucion.Pantallas.SubMenus
{
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaCaja.LogicaCaja> ObjDataCaja = new Lazy<Logica.Logica.LogicaCaja.LogicaCaja>();
        Lazy<DSMarket.Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion> ObjdataConfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion>();
        Lazy<DSMarket.Logica.Logica.LogicaSeguridad.LogicaSeguridad> ObjDataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad.LogicaSeguridad>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();
        private void Reportes_Load(object sender, EventArgs e)
        {
            lbTitulo.Text = "MODULO DE REPORTES";
            lbTitulo.ForeColor = Color.White;
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            lbIdUsuario.Text = DSMarket.Solucion.Pantallas.MenuPrincipal.MenuPrincipal.IdUsuarioMantenimientos.ToString();
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DSMarket.Solucion.Pantallas.Pantallas.Reportes.ReportesDGII DGII = new Pantallas.Reportes.ReportesDGII();
            DGII.VariablesGlobales.IdUsuario = Convert.ToDecimal(lbIdUsuario.Text);
            DGII.ShowDialog();
        }

        private void BtnReporteCotizaciones_Click(object sender, EventArgs e)
        {
            //BUSCAMOS EL HISTORIAL DE CAJA SEGUN LA FECHA

            var BuscarHistorialCaja = ObjDataCaja.Value.BuscaHistorialCaja(
                new Nullable<decimal>(),
                null,
                DateTime.Now,
                DateTime.Now);
            if (BuscarHistorialCaja.Count() < 1)
            {
                MessageBox.Show("No se encontraron registros para generar este reporte", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                //ELIMINAMOS LOS REGISTROS

                DSMarket.Logica.Entidades.EntidadesConfiguracion.EProcesarReporteCuadreCaja Eliminar = new Logica.Entidades.EntidadesConfiguracion.EProcesarReporteCuadreCaja();
                Eliminar.IdUsuario = VariablesGlobales.IdUsuario;
                var MANEliminar = ObjdataConfiguracion.Value.ProcesarCuadreCaja(Eliminar, "DELETE");

                foreach (var n in BuscarHistorialCaja)
                {
                    DSMarket.Logica.Entidades.EntidadesConfiguracion.EProcesarReporteCuadreCaja Procesar = new Logica.Entidades.EntidadesConfiguracion.EProcesarReporteCuadreCaja();

                    Procesar.IdUsuario = VariablesGlobales.IdUsuario;
                    Procesar.IdCaja = 1;
                    Procesar.Monto = Convert.ToDecimal(n.Monto);
                    Procesar.Concepto = n.Concepto;
                    Procesar.FechaProcesado = Convert.ToDateTime(n.Fecha0);
                    Procesar.FechaDesde = DateTime.Now;
                    Procesar.FechaHasta = DateTime.Now;
                    Procesar.NumeroReferencia = Convert.ToDecimal(n.NumeroReferencia);
                    Procesar.IdTipoPago = Convert.ToDecimal(n.IdTipoPago);

                    var MANProcesar = ObjdataConfiguracion.Value.ProcesarCuadreCaja(Procesar, "INSERT");




                    string RutaReporte = "", UsuarioBD = "", ClaveBD = "";

                    var SacarRutaReporte = ObjdataConfiguracion.Value.BuscaRutaReporte(3);
                    foreach (var nRuta in SacarRutaReporte)
                    {
                        RutaReporte = nRuta.RutaReporte;
                    }

                    var SacarCredenciales = ObjDataSeguridad.Value.SacarCredencialBD(1);
                    foreach (var n2 in SacarCredenciales)
                    {
                        UsuarioBD = n2.Usuario;
                        ClaveBD = DSMarket.Logica.Comunes.SeguridadEncriptacion.DesEncriptar(n2.Clave);
                    }

                    DSMarket.Solucion.Pantallas.Pantallas.Reportes.Reportes Invocar = new Pantallas.Reportes.Reportes();

                    Invocar.GenerarCuadreCaja(
                        VariablesGlobales.IdUsuario,
                        RutaReporte,
                        UsuarioBD,
                        ClaveBD);
                    Invocar.ShowDialog();
                }
            }

        }

        private void btnReporteComprobantesFiscales_Click(object sender, EventArgs e)
        {
            DSMarket.Solucion.Pantallas.Pantallas.Reportes.Reportes Invocar = new Pantallas.Reportes.Reportes();
            Invocar.GenerarReporteComprobantes();
            Invocar.ShowDialog();
        }
    }
}
