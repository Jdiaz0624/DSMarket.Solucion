using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace DSMarket.Solucion.Pantallas.Pantallas.Empresa
{
    public partial class CompraSuplidores : Form
    {
        public CompraSuplidores()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaEmpresa.LogicaEmpresa> ObjdataEmpresa = new Lazy<Logica.Logica.LogicaEmpresa.LogicaEmpresa>();
        Lazy<DSMarket.Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion> ObjDataConfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion>();
        Lazy<DSMarket.Logica.Logica.LogicaSeguridad.LogicaSeguridad> ObjdataSeguriad = new Lazy<Logica.Logica.LogicaSeguridad.LogicaSeguridad>();
        public DSMarket.Logica.Comunes.VariablesGlobales Variableslobales = new Logica.Comunes.VariablesGlobales();

        #region MOSTRAR EL LISTADO DE LAS COMPRAS DE SUPLIDORES
        private void MostrarListadoCompras() {
            string _RNC = string.IsNullOrEmpty(txtRNC.Text.Trim()) ? null : txtRNC.Text.Trim();

            var Consultar = ObjdataEmpresa.Value.BuscaCompraSuplidores(
                new Nullable<decimal>(),
                null,
                null,
                _RNC,
                Convert.ToDateTime(txtFechaDesde.Text),
                Convert.ToDateTime(txtFechaHasta.Text),
                Convert.ToInt32(txtNumeroPagina.Value),
                Convert.ToInt32(txtNumeroRegistros.Value));
            dtListado.DataSource = Consultar;
            if (Consultar.Count() < 1)
            {
                lbCantidadRegistrosVariable.Text = "0";
            }
            else {
                foreach (var n in Consultar) {
                    int CantidadRegistros = Convert.ToInt32(n.CantidadRegistros);
                    lbCantidadRegistrosVariable.Text = CantidadRegistros.ToString("N0");
                    
                }
            }
            OcultarColumnas();
        }
        private void OcultarColumnas() {
            this.dtListado.Columns["IdCompraSuplidor"].Visible = false;
            this.dtListado.Columns["IdTipoSuplidor"].Visible = false;
            this.dtListado.Columns["IdSuplidor"].Visible = false;
            this.dtListado.Columns["IdTipoIdentificacion"].Visible = false;
            this.dtListado.Columns["IdTipoBienesServicios"].Visible = false;
            this.dtListado.Columns["FechaComprobante0"].Visible = false;
            this.dtListado.Columns["FechaPago0"].Visible = false;
            this.dtListado.Columns["IdTipoRetencionISR"].Visible = false;
            this.dtListado.Columns["IdFormaPago"].Visible = false;
            this.dtListado.Columns["UsuarioAdiciona"].Visible = false;
            this.dtListado.Columns["FechaCreado0"].Visible = false;
            this.dtListado.Columns["CantidadRegistros"].Visible = false;
            this.dtListado.Columns["CodigoTipoBienesServicio"].Visible = false;
            this.dtListado.Columns["CodigoTipoRetencionISR"].Visible = false;
            this.dtListado.Columns["CodigoTipoPago"].Visible = false;
        }
        #endregion
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void CompraSuplidores_Load(object sender, EventArgs e)
        {
            lbTitulo.Text = "COMPRA DE SUPLIDORES CONSULTA";
            lbTitulo.ForeColor = Color.White;
            lbCantidadRegistrosTitulo.ForeColor = Color.White;
            lbCantidadRegistrosVariable.ForeColor = Color.White;
            rbPorPantalla.Checked = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MostrarListadoCompras();
        }

        private void txtNumeroPagina_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroPagina.Value < 1)
            {
                txtNumeroPagina.Value = 1;
                MostrarListadoCompras();
            }
            else {
                MostrarListadoCompras();
            }
        }

        private void txtNumeroRegistros_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroRegistros.Value < 1)
            {
                txtNumeroRegistros.Value = 10;
                MostrarListadoCompras();
            }
            else {
                MostrarListadoCompras();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.MantenimientoCompraSuplidores Mantenimiento = new MantenimientoCompraSuplidores();
            Mantenimiento.VariablesGlobales.IdUsuario = Variableslobales.IdUsuario;
            Mantenimiento.VariablesGlobales.Accion = "INSERT";
            Mantenimiento.VariablesGlobales.IdMantenimeinto = 0;
            Mantenimiento.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.MantenimientoCompraSuplidores Mantenimiento = new MantenimientoCompraSuplidores();
            Mantenimiento.VariablesGlobales.IdUsuario = Variableslobales.IdUsuario;
            Mantenimiento.VariablesGlobales.Accion = "UPDATE";
            Mantenimiento.VariablesGlobales.IdMantenimeinto = Variableslobales.IdMantenimeinto;
            Mantenimiento.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.MantenimientoCompraSuplidores Mantenimiento = new MantenimientoCompraSuplidores();
            Mantenimiento.VariablesGlobales.IdUsuario = Variableslobales.IdUsuario;
            Mantenimiento.VariablesGlobales.Accion = "DELETE";
            Mantenimiento.VariablesGlobales.IdMantenimeinto = Variableslobales.IdMantenimeinto;
            Mantenimiento.ShowDialog();
        }

        private void dtListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Variableslobales.IdMantenimeinto = Convert.ToDecimal(this.dtListado.CurrentRow.Cells["IdCompraSuplidor"].Value.ToString());

            var BuscarRegistro = ObjdataEmpresa.Value.BuscaCompraSuplidores(
                Variableslobales.IdMantenimeinto,
                null, null, null, null, null, 1, 1);
            dtListado.DataSource = BuscarRegistro;
            OcultarColumnas();
            btnBuscar.Enabled = false;
            btnNuevo.Enabled = false;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            txtNumeroPagina.Enabled = false;
            txtNumeroRegistros.Enabled = false;
            btnRestablecer.Enabled = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            btnBuscar.Enabled = true;
            btnNuevo.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            txtNumeroPagina.Enabled = true;
            txtNumeroRegistros.Enabled = true;
            txtNumeroPagina.Value = 1;
            txtNumeroRegistros.Value = 10;
            txtRNC.Text = string.Empty;
            txtFechaDesde.Text = DateTime.Now.ToString();
            txtFechaHasta.Text = DateTime.Now.ToString();
            btnRestablecer.Enabled = false;
            MostrarListadoCompras();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            if (rbPorPantalla.Checked == true) {

                //ELIMINAMOS EL REGISTRO
                DSMarket.Logica.Comunes.ProcesarInformacionDataReporte606 Eliminar = new Logica.Comunes.ProcesarInformacionDataReporte606(
                        Variableslobales.IdUsuario,0,0,"",0,"","",0,"",0,"","","","",DateTime.Now,"",DateTime.Now,"",0,0,0,0,0,0,0,0,0,0,"","",0,0,0,0,0,0,"","",0,"",DateTime.Now,"",0,DateTime.Now,DateTime.Now, "DELETE");
                Eliminar.ProcesarInformacionReporte606();


                string _RNC = string.IsNullOrEmpty(txtRNC.Text.Trim()) ? null : txtRNC.Text.Trim();
                var SacarCantidadRegistros = ObjdataEmpresa.Value.BuscaCompraSuplidores(
                    new Nullable<decimal>(),
                    null,
                    null,
                    _RNC,
                    Convert.ToDateTime(txtFechaDesde.Text),
                    Convert.ToDateTime(txtFechaHasta.Text),
                    1, 999999999);
                foreach (var Data in SacarCantidadRegistros)
                {
                    DSMarket.Logica.Comunes.ProcesarInformacionDataReporte606 Guardar = new Logica.Comunes.ProcesarInformacionDataReporte606(
                        Variableslobales.IdUsuario,
                        Convert.ToDecimal(Data.IdCompraSuplidor),
                        Convert.ToDecimal(Data.IdTipoSuplidor),
                        Data.TipoSuplidor,
                        Convert.ToDecimal(Data.IdSuplidor),
                        Data.Suplidor,
                        Data.RNCCedula,
                        Convert.ToDecimal(Data.IdTipoIdentificacion),
                        Data.TipoIdentificacion,
                        Convert.ToDecimal(Data.IdTipoBienesServicios),
                        Data.TipoBienesServicios,
                        Data.CodigoTipoBienesServicio,
                        Data.NCF,
                        Data.NCFModificado,
                        Convert.ToDateTime(Data.FechaComprobante0),
                        Data.FechaComprobante,
                        Convert.ToDateTime(Data.FechaPago0),
                        Data.FechaPago,
                        Convert.ToDecimal(Data.MontoFacturadoServicios),
                        Convert.ToDecimal(Data.MontoFacturadoBienes),
                        Convert.ToDecimal(Data.TotalMontoFacturado),
                        Convert.ToDecimal(Data.ITBISFacturado),
                        Convert.ToDecimal(Data.ITBISRetenido),
                        Convert.ToDecimal(Data.ITBISSujetoProporcionalidad),
                        Convert.ToDecimal(Data.ITBISLlevadoCosto),
                        Convert.ToDecimal(Data.ITBISPorAdelantar),
                        Convert.ToDecimal(Data.ITBISPercibidoCompras),
                        Convert.ToDecimal(Data.IdTipoRetencionISR),
                        Data.TipoRetencionISR,
                        Data.CodigoTipoRetencionISR,
                        Convert.ToDecimal(Data.MontoRetencionRenta),
                        Convert.ToDecimal(Data.ISRPercibidoCompras),
                        Convert.ToDecimal(Data.ImpuestoSelectivoConsumo),
                        Convert.ToDecimal(Data.OtrosImpuestosTasa),
                        Convert.ToDecimal(Data.MontoPropinaLegal),
                        Convert.ToDecimal(Data.IdFormaPago),
                        Data.FormaPago,
                        Data.CodigoTipoPago,
                        Convert.ToDecimal(Data.UsuarioAdiciona),
                        Data.CreadoPor,
                        Convert.ToDateTime(Data.FechaCreado0),
                        Data.FechaCreado,
                        Convert.ToDecimal(Data.CantidadRegistros),
                        Convert.ToDateTime(txtFechaDesde.Text),
                        Convert.ToDateTime(txtFechaHasta.Text),
                        "INSERT");
                    Guardar.ProcesarInformacionReporte606();
                }


                //INVOCAMOS EL REPORTE FISICO DEL 606
                string RutaReporte = "";
                string UsuarioBD = "";
                string ClaveBD = "";

                //SACAMOS LA RUTA DEL REPORTE
                var SacarRutareporte = ObjDataConfiguracion.Value.BuscaRutaReporte(10);
                foreach (var nruta in SacarRutareporte) {
                    RutaReporte = nruta.RutaReporte;
                }

                //VAR SACAR CREDENCIALES
                var SacarCredencialesBD = ObjdataSeguriad.Value.SacarCredencialBD(1);
                foreach (var ncredenciales in SacarCredencialesBD) {
                    UsuarioBD = ncredenciales.Usuario;
                    ClaveBD = DSMarket.Logica.Comunes.SeguridadEncriptacion.DesEncriptar(ncredenciales.Clave);
                }

                //INVOCAMOS EL REPORTE
                DSMarket.Solucion.Pantallas.Pantallas.Reportes.Reportes Reporte606 = new Reportes.Reportes();
                Reporte606.GenerarReporte606(
                    Variableslobales.IdUsuario);
                Reporte606.ShowDialog();
            }
            else if (rbEntxt.Checked == true) {
                string RutaArchivo = "";

                var SacarRutaArchivo = ObjDataConfiguracion.Value.BuscaRutaArchivotxt(1);
                foreach (var n in SacarRutaArchivo) {
                    RutaArchivo = n.Ruta;
                }

                //GENERAMOS LA FECHA DE PERIODO
                DateTime FechaPeriodo = Convert.ToDateTime(txtPeriodo.Text);
                int Year = FechaPeriodo.Year;
                string Month = FechaPeriodo.Month.ToString();
                string day = FechaPeriodo.Day.ToString();

                if (Month.Length == 1) {
                    Month = "0" + Month;
                }

                if (day.Length == 1)
                {
                    day = "0" + day;
                }

                string RNC = "";
                string Periofo = Year.ToString() + Month + day;
                string CantidadRegistros = "";

                //SACAMOS EL RNC DE LA EMPRESA
                var SacarRNC = ObjDataConfiguracion.Value.BuscaInformacionEmpresa();
                foreach (var n in SacarRNC)
                {
                    RNC = n.RNC;
                }

                //SACAMOS LA CANTIDAD DE REGISTROS
                string _RNC = string.IsNullOrEmpty(txtRNC.Text.Trim()) ? null : txtRNC.Text.Trim();
                var SacarCantidadRegistros = ObjdataEmpresa.Value.BuscaCompraSuplidores(
                    new Nullable<decimal>(),
                    null,
                    null,
                    _RNC,
                    Convert.ToDateTime(txtFechaDesde.Text),
                    Convert.ToDateTime(txtFechaHasta.Text),
                    1, 999999999);
                foreach (var Cantidad in SacarCantidadRegistros)
                {
                    CantidadRegistros = Cantidad.CantidadRegistros.ToString();
                }

                using (StreamWriter outPutFile = new StreamWriter(@""+RutaArchivo +@"\DGII_F_606_"+RNC+"_"+Periofo+".txt"))
                {
                 
                    var Lineas = ObjdataEmpresa.Value.BuscaCompraSuplidores(
                         new Nullable<decimal>(),
                    null,
                    null,
                    _RNC,
                    Convert.ToDateTime(txtFechaDesde.Text),
                    Convert.ToDateTime(txtFechaHasta.Text),
                    1, 999999999);
                    outPutFile.WriteLine("606|" + RNC + "|"+Periofo+"|"+CantidadRegistros);
                    foreach (var n in Lineas)
                    {
                        outPutFile.WriteLine(n.RNCCedula + "|" + n.IdTipoIdentificacion + "|" + n.CodigoTipoBienesServicio + "|" + n.NCF + "|" + n.NCFModificado + "|" + n.FechaComprobante + "|" + n.FechaPago + "|" + n.MontoFacturadoServicios + "|" + n.MontoFacturadoBienes + "|" + n.TotalMontoFacturado + "|" + n.ITBISFacturado + "|" + n.ITBISRetenido + "|" + n.ITBISSujetoProporcionalidad + "|" + n.ITBISLlevadoCosto + "|" + n.ITBISPorAdelantar + "|" + n.ITBISPercibidoCompras + "|" + n.CodigoTipoRetencionISR + "|" + n.MontoRetencionRenta + "|" + n.ISRPercibidoCompras + "|" + n.ImpuestoSelectivoConsumo + "|" + n.OtrosImpuestosTasa + "|" + n.MontoPropinaLegal + "|" + n.CodigoTipoPago);
                    }
                }

            }
            else {
                MessageBox.Show("Favor de seleccionar una opcioón para el reporte", Variableslobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RbPorPantalla_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPorPantalla.Checked)
            {
                lbPeriodo.Visible = false;
                txtPeriodo.Visible = false;
            }
            else {
                lbPeriodo.Visible = true;
                txtPeriodo.Visible = true;
            }
        }

        private void RbEntxt_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEntxt.Checked)
            {
                lbPeriodo.Visible = true;
                txtPeriodo.Visible = true;
            }
            else {
                lbPeriodo.Visible = false;
                txtPeriodo.Visible = false;
            }
        }
    }
}
