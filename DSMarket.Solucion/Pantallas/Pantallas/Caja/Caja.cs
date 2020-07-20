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
    public partial class Caja : Form
    {
        public Caja()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaCaja.LogicaCaja> ObjDataLogica = new Lazy<Logica.Logica.LogicaCaja.LogicaCaja>();
        Lazy<DSMarket.Logica.Logica.LogicaSeguridad.LogicaSeguridad> ObjDataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad.LogicaSeguridad>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region MOSTRAR EL ESTATUS DE LA CAJA
        private void MostrarEstatusCaja() {
            var Mostrar = ObjDataLogica.Value.BuscaEstatusCaja();
            foreach (var n in Mostrar)
            {
                lbNombreCaja.Text = n.Caja;
                lbEstatus.Text = n.Estatus;
                decimal MontoCaja = Convert.ToDecimal(n.MontoActual);
                lbMonto.Text = MontoCaja.ToString("N2");
            }
        }
        #endregion
        #region ABRIR CERRAR CAJA
        private void AbrirCerrarCaja(string Accion) {
            try {
                DSMarket.Logica.Entidades.EntidadesCaja.ECajaGeneral AbrirCerrar = new Logica.Entidades.EntidadesCaja.ECajaGeneral();

                AbrirCerrar.IdCaja = 1;
                AbrirCerrar.Caja = "Caja General";
                AbrirCerrar.MontoActual = Convert.ToDecimal(lbMonto.Text);
                AbrirCerrar.Estatus0 = true;

                var MAN = ObjDataLogica.Value.AfectarCaja(AbrirCerrar, Accion);

            }
            catch (Exception ex) {
                MessageBox.Show("Error al abrir o cerrar caja, codigo de error --> " + ex.Message, VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void IngresarSacarDinero(string Accion)
        {
            try
            {
                DSMarket.Logica.Entidades.EntidadesCaja.ECajaGeneral AbrirCerrar = new Logica.Entidades.EntidadesCaja.ECajaGeneral();

                AbrirCerrar.IdCaja = 1;
                AbrirCerrar.Caja = "Caja General";
                AbrirCerrar.MontoActual = Convert.ToDecimal(txtMonto.Text);
                AbrirCerrar.Estatus0 = true;

                var MAN = ObjDataLogica.Value.AfectarCaja(AbrirCerrar, Accion);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir o cerrar caja, codigo de error --> " + ex.Message, VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region VALIDAR CLAVE SEGURIDAD
        private void ValidarClave() {
            if (string.IsNullOrEmpty(txtClaveSegrudiad.Text.Trim()))
            {
                MessageBox.Show("La clave de seguridad no puede estar vacia, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string _ClaveSeguridad = string.IsNullOrEmpty(txtClaveSegrudiad.Text.Trim()) ? null : txtClaveSegrudiad.Text.Trim();

                var Validar = ObjDataSeguridad.Value.BuscaClaveSeguridad(
                    new Nullable<decimal>(),
                    null,
                    DSMarket.Logica.Comunes.SeguridadEncriptacion.Encriptar(_ClaveSeguridad),
                    1, 1);
                if (Validar.Count() < 1)
                {
                    MessageBox.Show("La clave de seguridad ingresada no es valida, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtClaveSegrudiad.Text = string.Empty;
                    txtClaveSegrudiad.Focus();
                }
                else
                {
                    btnAbrirCerrar.Enabled = true;
                    btnProcesar.Enabled = true;
                }
            }
        }
        #endregion
        #region FECTAR CAJA
        private void AfectarCaja(decimal Monto, string Concepto) {
            DSMarket.Logica.Entidades.EntidadesCaja.EHistorialCaja MantenimientoCaja = new Logica.Entidades.EntidadesCaja.EHistorialCaja();

            MantenimientoCaja.IdHistorialCaja = 0;
            MantenimientoCaja.IdCaja = 1;
            MantenimientoCaja.Monto = Monto;
            MantenimientoCaja.Concepto = Concepto;
            MantenimientoCaja.Fecha0 = DateTime.Now;
            MantenimientoCaja.IdUsuario = VariablesGlobales.IdUsuario;
            MantenimientoCaja.NumeroReferencia = VariablesGlobales.NumeroConector;
            MantenimientoCaja.IdTipoPago = 1;

            var MAN = ObjDataLogica.Value.MantenimientoHistorialCaja(MantenimientoCaja, "INSERT");
        }
        #endregion
        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Caja_Load(object sender, EventArgs e)
        {
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            MostrarEstatusCaja();
            this.BackColor = SystemColors.Control;
            txtClaveSegrudiad.BackColor = Color.WhiteSmoke;
            txtConcepto.BackColor = Color.WhiteSmoke;
            txtMonto.BackColor = Color.WhiteSmoke;
            rbIngresar.ForeColor = Color.LimeGreen;
            rbSacar.ForeColor = Color.DarkRed;
            rbIngresar.Checked = true;
            lbTitulo.Text = "CAJA";
            lbTitulo.ForeColor = Color.WhiteSmoke;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ValidarClave();
        }

        private void btnAbrirCerrar_Click(object sender, EventArgs e)
        {
            if (lbEstatus.Text == "ABIERTA")
            {
                AbrirCerrarCaja("CLOSEBOX");
                MostrarEstatusCaja();
            }
            else {
                AbrirCerrarCaja("OPENBOX");
                MostrarEstatusCaja();
            }
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMonto.Text.Trim()))
            {
                MessageBox.Show("El campo monto no puede estar vacio, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMonto.Focus();
            }
            else {
                if (rbIngresar.Checked == true)
                {
                    if (string.IsNullOrEmpty(txtConcepto.Text.Trim()))
                    {
                        txtConcepto.Text = "INGRESO DE EFECTIVO";
                    }
                    IngresarSacarDinero("ADDMONEY");
                  //  AbrirCerrarCaja("");
                   

                    decimal Monto = 0;
                    string Concepto = txtConcepto.Text;
                    Monto = Convert.ToDecimal(txtMonto.Text);
                    AfectarCaja(Monto, Concepto);

                    MostrarEstatusCaja();
                    txtConcepto.Text = string.Empty;
                    txtMonto.Text = string.Empty;
                }
                else if (rbSacar.Checked == true)
                {
                    if (string.IsNullOrEmpty(txtConcepto.Text.Trim()))
                    {
                        txtConcepto.Text = "EGRESO DE EFECTIVO";
                    }
                    double MontoActual = Convert.ToDouble(lbMonto.Text);
                    double MontoProcesar = Convert.ToDouble(txtMonto.Text);

                    if (MontoActual < MontoProcesar)
                    {
                        MessageBox.Show("El valor que intentas retirar supera a la cantidad actual de la caja, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        IngresarSacarDinero("LESSMONEY");
                        //  AbrirCerrarCaja("");


                        decimal Monto = 0;
                        string Concepto = txtConcepto.Text;
                        Monto = Convert.ToDecimal(txtMonto.Text);
                        Monto = Monto * -1;
                        AfectarCaja(Monto, Concepto);

                        MostrarEstatusCaja();
                        txtConcepto.Text = string.Empty;
                        txtMonto.Text = string.Empty;
                    }
                }
            }
        }

        private void txtClaveSegrudiad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                ValidarClave();
            }
        }
    }
}
