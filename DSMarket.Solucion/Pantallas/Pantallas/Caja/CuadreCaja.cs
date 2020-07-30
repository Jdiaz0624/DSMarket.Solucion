using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSMarket.Solucion.Pantallas.Pantallas.Caja
{
    public partial class CuadreCaja : Form
    {
        public CuadreCaja()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaCaja.LogicaCaja> ObjDataCaja = new Lazy<Logica.Logica.LogicaCaja.LogicaCaja>();
        Lazy<DSMarket.Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion> ObjdataConfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion>();
        Lazy<DSMarket.Logica.Logica.LogicaSeguridad.LogicaSeguridad> ObjDataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad.LogicaSeguridad>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        private void CuadreCaja_Load(object sender, EventArgs e)
        {
            gbSeleccionar.BackColor = SystemColors.Control;
            this.BackColor = SystemColors.Control;
            cbCradreMail.Checked = false;
            cbCradreMail.ForeColor = Color.DarkRed;
            lbTitulo.Text = "CUADRE DE CAJA";
            lbTitulo.ForeColor = Color.WhiteSmoke;
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
        }

        private void CuadreCaja_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cbCradreMail_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCradreMail.Checked == true)
            {
                cbCradreMail.ForeColor = Color.LimeGreen;

            }
            else
            {
                cbCradreMail.ForeColor = Color.DarkRed;
            }
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            try {
                //BUSCAMOS EL HISTORIAL DE CAJA SEGUN LA FECHA

                var BuscarHistorialCaja = ObjDataCaja.Value.BuscaHistorialCaja(
                    new Nullable<decimal>(),
                    null,
                    Convert.ToDateTime(txtFechaDesde.Text),
                    Convert.ToDateTime(txtFechaHasta.Text));
                if (BuscarHistorialCaja.Count() < 1)
                {
                    MessageBox.Show("No se encontraron registros en el rango de fecha ingresado, favor de verificar los parametros", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //ELIMINAMOS LOS REGISTROS

                    DSMarket.Logica.Entidades.EntidadesConfiguracion.EProcesarReporteCuadreCaja Eliminar = new Logica.Entidades.EntidadesConfiguracion.EProcesarReporteCuadreCaja();
                    Eliminar.IdUsuario = VariablesGlobales.IdUsuario;
                    var MANEliminar = ObjdataConfiguracion.Value.ProcesarCuadreCaja(Eliminar, "DELETE");

                    //SACAMOS LOS DATOS INGRESADOS
                    foreach (var n in BuscarHistorialCaja)
                    {
                        DSMarket.Logica.Entidades.EntidadesConfiguracion.EProcesarReporteCuadreCaja Procesar = new Logica.Entidades.EntidadesConfiguracion.EProcesarReporteCuadreCaja();

                        Procesar.IdUsuario = VariablesGlobales.IdUsuario;
                        Procesar.IdCaja = 1;
                        Procesar.Monto = Convert.ToDecimal(n.Monto);
                        Procesar.Concepto = n.Concepto;
                        Procesar.FechaProcesado = Convert.ToDateTime(n.Fecha0);
                        Procesar.FechaDesde = Convert.ToDateTime(txtFechaDesde.Text);
                        Procesar.FechaHasta = Convert.ToDateTime(txtFechaHasta.Text);
                        Procesar.NumeroReferencia = Convert.ToDecimal(n.NumeroReferencia);
                        Procesar.IdTipoPago = Convert.ToDecimal(n.IdTipoPago);

                        var MANProcesar = ObjdataConfiguracion.Value.ProcesarCuadreCaja(Procesar, "INSERT");
                    }

                    if (cbCradreMail.Checked) {
                        //ENVIAMOS EL CORREO DE NOTIFICACION
                          string CorreoOrigen = "";
                          string ClaveCorreoOrigen = "";
                        string CorreoDestino = "";  //"ing.juanmarcelinom.diaz@gmail.com";
                          string CuerpoCorreo = "";
                          string AsuntoCorreo = "CUADRE DE CAJA";
                          string SMTP = "";
                          int Puerto = 0;
                          decimal MontoEnviar = 100;
                        DateTime FechaDesde = Convert.ToDateTime(txtFechaDesde.Text);
                        DateTime FechaHasta = Convert.ToDateTime(txtFechaHasta.Text);
                        string FechaDesdeLetera = FechaDesde.ToString("dd/MM/yyyy");
                        string FechaHastaLetra = FechaHasta.ToString("dd/MM/yyyy");

                        //SACAMOS EL MONTO A ENVIAR

                        //SACAMOS LOS DATOS DEL CORREO CONFIGURADO
                        var SacarDatosCorreoConfigurado = ObjdataConfiguracion.Value.BuscaMail(1);
                        foreach (var n in SacarDatosCorreoConfigurado) {
                            CorreoOrigen = n.Mail;
                            ClaveCorreoOrigen = DSMarket.Logica.Comunes.SeguridadEncriptacion.DesEncriptar(n.Clave);
                            CorreoDestino = n.Mail;
                            CuerpoCorreo = "Cuadre de caja, validado desde " + FechaDesdeLetera +" Hasta " + txtFechaHasta + " con el monto total de " + MontoEnviar.ToString("N2");
                            SMTP = n.smtp;
                            Puerto = Convert.ToInt32(n.Puerto);


                        }

                        DSMarket.Logica.Comunes.Mails Enviar = new Logica.Comunes.Mails(
                            CorreoOrigen, ClaveCorreoOrigen, CorreoDestino, CuerpoCorreo, AsuntoCorreo, SMTP, Puerto);
                        Enviar.EnviarCorreo();
    }
                    //INVOCAMOS EL REPORTE
                    DSMarket.Solucion.Pantallas.Pantallas.Reportes.Reportes Generar = new Reportes.Reportes();


                    string RutaReporte = "", UsuarioBD="", ClaveBD="";

                    var SacarRutaReporte = ObjdataConfiguracion.Value.BuscaRutaReporte(3);
                    foreach (var n in SacarRutaReporte) {
                        RutaReporte = n.RutaReporte;
                    }

                    var SacarCredenciales = ObjDataSeguridad.Value.SacarCredencialBD(1);
                    foreach (var n2 in SacarCredenciales) {
                        UsuarioBD = n2.Usuario;
                        ClaveBD = DSMarket.Logica.Comunes.SeguridadEncriptacion.DesEncriptar(n2.Clave);
                    }


                    Generar.GenerarCuadreCaja(
                        VariablesGlobales.IdUsuario,
                        RutaReporte,
                        UsuarioBD,
                        ClaveBD);
                    Generar.ShowDialog();
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Error al procesar el cuadre de caja, codigo de error--> " + ex.Message, VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
