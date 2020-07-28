using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSMarket.Solucion.Pantallas.Pantallas.Servicio
{
    public partial class MantenimientoTipoPago : Form
    {
        public MantenimientoTipoPago()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaServicio.LogicaServicio> ObjDataServicio = new Lazy<Logica.Logica.LogicaServicio.LogicaServicio>();
        Lazy<DSMarket.Logica.Logica.LogicaSeguridad.LogicaSeguridad> ObjDataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad.LogicaSeguridad>();
       public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();
        #region TEMA GENERICO
        private void AplicarTema()
        {
            lbTitulo.ForeColor = Color.White;
            this.BackColor = SystemColors.Control;
            txtTipoPago.BackColor = Color.WhiteSmoke;
            txtClaveSeguridad.BackColor = Color.WhiteSmoke;
            txtClaveSeguridad.ForeColor = Color.Black;
            txtTipoPago.ForeColor = Color.Black;
        }
        #endregion
        #region MANTENIMEINTO DE TIPO DE PAGO
        private void MANTipoPago(string Accion) {
            try {
                DSMarket.Logica.Comunes.MantenimientoTipoPago TipoPago = new Logica.Comunes.MantenimientoTipoPago(
                    VariablesGlobales.IdMantenimeinto,
                    txtTipoPago.Text,
                    cbEstatus.Checked,
                    VariablesGlobales.IdUsuario,
                    DateTime.Now,
                    VariablesGlobales.IdUsuario,
                    DateTime.Now,
                    cbBloqueaMonto.Checked,
                    Accion);
                TipoPago.MANtenimeinto();
            }
            catch (Exception ex) {
                MessageBox.Show("Error al realizar este mantenimiento, codigo de error: " + ex.Message, VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region RESTABELCER PANTALLA
        private void RestablecerPantalla() {
            txtTipoPago.Text = string.Empty;
            cbEstatus.Checked = true;
            cbBloqueaMonto.Checked = false;
        }
        #endregion
        #region CERRAR PANTALLA
        private void CerrarPantalla() {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Servicio.TipoPago Consulta = new TipoPago();
            Consulta.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Consulta.ShowDialog();
        }
        #endregion

        private void MantenimientoTipoPago_Load(object sender, EventArgs e)
        {
            AplicarTema();
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            txtClaveSeguridad.PasswordChar = '•';
            if (VariablesGlobales.Accion == "INSERT")
            {
                btnGuardar.Text = "Guardar Registro";
                lbTitulo.Text = "Crear nuevo registro";
                lbClaveSeguridad.Visible = false;
                txtClaveSeguridad.Visible = false;
            }
            else
            {
                btnGuardar.Text = "Modificar Registro";
                lbTitulo.Text = "Modificar registro seleccionado";

                lbClaveSeguridad.Visible = true;
                txtClaveSeguridad.Visible = true;

                var SacarData = ObjDataServicio.Value.BuscaTipoPago(
                    VariablesGlobales.IdMantenimeinto,
                    null, 1, 1);
                foreach (var n in SacarData) {
                    txtTipoPago.Text = n.TipoPago;
                    cbEstatus.Checked = (n.Estatus0.HasValue ? n.Estatus0.Value : false);
                    cbBloqueaMonto.Checked = (n.BloqueaMonto0.HasValue ? n.BloqueaMonto0.Value : false);
                }
            }
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            CerrarPantalla();
        }

        private void MantenimientoTipoPago_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTipoPago.Text.Trim()))
            {
                MessageBox.Show("El campo tipo de pago no puede estar vacio, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                if (VariablesGlobales.Accion == "INSERT")
                {
                    //GUARDAMOS
                    MANTipoPago("INSERT");
                    MessageBox.Show("Registro guardado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (MessageBox.Show("¿Quieres agregar otro registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        RestablecerPantalla();
                    }
                    else {
                        CerrarPantalla();
                    }
                }
                else {
                    if (string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()))
                    {
                        MessageBox.Show("El campo clave de seguridad no puede estar vacio, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else {
                        string _ClaveSeguridad = string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()) ? null : txtClaveSeguridad.Text.Trim();

                        var ValidarClave = ObjDataSeguridad.Value.BuscaClaveSeguridad(
                            new Nullable<decimal>(),
                            null,
                           DSMarket.Logica.Comunes.SeguridadEncriptacion.Encriptar(_ClaveSeguridad),
                           1, 1);
                        if (ValidarClave.Count() < 1)
                        {
                            MessageBox.Show("La clave de seguridad ingresada no es valida", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtClaveSeguridad.Text = string.Empty;
                        }
                        else {
                            MANTipoPago("UPDATE");
                            MessageBox.Show("Registro modificado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CerrarPantalla();
                        }
                    }
                }
            }
        }
    }
}
