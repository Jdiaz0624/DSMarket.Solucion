using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSMarket.Solucion.Pantallas.Pantallas.Configuracion
{
    public partial class ModificarConfiguracionGeneral : Form
    {
        public ModificarConfiguracionGeneral()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion> ObjDataConfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion>();
        Lazy<DSMarket.Logica.Logica.LogicaSeguridad.LogicaSeguridad> ObjDataSeguriad = new Lazy<Logica.Logica.LogicaSeguridad.LogicaSeguridad>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region RESTABLECER PANTALLA
        private void RestablecerPantalla() {
            btnRestablecer.Enabled = false;
            gbListado.Visible = false;
            lbCantidadRegistrosActivosTiirulo.Visible = false;
            LbCantidadRegistrosActivosVariable.Visible = false;
            LbCantidadRegistrosInactivosTirulo.Visible = false;
            LbCantidadRegistrosInactivosVariable.Visible = false;
            gbModificar.Visible = false;

            txtClaveSeguridad.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
        }
        #endregion
        private void ModificarConfiguracionGeneral_Load(object sender, EventArgs e)
        {
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            lbTitulo.Text = "MODIFICAR CONFIGURACION DEL SISTEMA";
            lbTitulo.ForeColor = Color.White;
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()))
            {
                MessageBox.Show("El campo de clave de seguridad no pude estar vacios favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()))
                {
                    errorProvider1.SetError(txtClaveSeguridad, "Campo Vacio");
                }
            }
            else {
                //VALIDAMOS LA CLAVE DE SEGURIDAD

                string _ClaveSeguridad = string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()) ? null : txtClaveSeguridad.Text.Trim();

                var ValidarClaveSeguridad = ObjDataSeguriad.Value.BuscaClaveSeguridad(
                    new Nullable<decimal>(),
                    null,
                    DSMarket.Logica.Comunes.SeguridadEncriptacion.Encriptar(_ClaveSeguridad),
                    1, 1);
                if (ValidarClaveSeguridad.Count() < 1)
                {
                    MessageBox.Show("La clave de seguridad ingresada no es valida, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtClaveSeguridad.Text = string.Empty;
                    txtClaveSeguridad.Focus();
                }
                else {
                    btnRestablecer.Enabled = true;
                    gbListado.Visible = true;
                    lbCantidadRegistrosActivosTiirulo.Visible = true;
                    LbCantidadRegistrosActivosVariable.Visible = true;
                    LbCantidadRegistrosInactivosTirulo.Visible = true;
                    LbCantidadRegistrosInactivosVariable.Visible = true;

                    int CantidadRegistrosActivos = 0, CantidadRegistrosInactivos = 0;

                    var MostrarListadoConfiguracionGeneral = ObjDataConfiguracion.Value.BuscaCOnfiguracionGeneral(
                        new Nullable<int>());
                    dtListado.DataSource = MostrarListadoConfiguracionGeneral;
                    foreach (var n in MostrarListadoConfiguracionGeneral) {
                        CantidadRegistrosActivos = Convert.ToInt32(n.CantidadActivos);
                        CantidadRegistrosInactivos = Convert.ToInt32(n.CantidadInactivos);

                        LbCantidadRegistrosActivosVariable.Text = CantidadRegistrosActivos.ToString("N0");
                        LbCantidadRegistrosInactivosVariable.Text = CantidadRegistrosInactivos.ToString("N0");
                    }
                    this.dtListado.Columns["IdConfiguracionGeneral"].Visible = false;
                    this.dtListado.Columns["Estatus0"].Visible = false;
                    this.dtListado.Columns["CantidadActivos"].Visible = false;
                    this.dtListado.Columns["CantidadInactivos"].Visible = false;
                }
            }
        }

        private void DtListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("¿Quieres seleccionar este registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {

                this.VariablesGlobales.IdMantenimeinto = Convert.ToDecimal(this.dtListado.CurrentRow.Cells["IdConfiguracionGeneral"].Value.ToString());

                gbModificar.Visible = true;
                var BuscarRegistroSeleccionado = ObjDataConfiguracion.Value.BuscaCOnfiguracionGeneral(Convert.ToInt32(VariablesGlobales.IdMantenimeinto));
                dtListado.DataSource = BuscarRegistroSeleccionado;
                foreach (var n in BuscarRegistroSeleccionado) {
                    txtDescripcion.Text = n.Descripcion;
                    cbSuma.Checked = (n.Estatus0.HasValue ? n.Estatus0.Value : false);
                }
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescripcion.Text.Trim())) {
                MessageBox.Show("El campo descripción no puede estar vacio, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (string.IsNullOrEmpty(txtDescripcion.Text.Trim()))
                {
                    errorProvider1.SetError(txtDescripcion, "Campo vacio");
                }
              
            }
            else
            {
                DSMarket.Logica.Comunes.ProcesarInformacionModificarConfiguracionGeneral Modificar = new Logica.Comunes.ProcesarInformacionModificarConfiguracionGeneral(
                   Convert.ToInt32(VariablesGlobales.IdMantenimeinto),
                   txtDescripcion.Text,
                   cbSuma.Checked,
                   "UPDATE");
                Modificar.ModificarInformacionGeneral();
                MessageBox.Show("Registro modificado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                RestablecerPantalla();
            }
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ModificarConfiguracionGeneral_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason) {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void BtnRestablecer_Click(object sender, EventArgs e)
        {
            RestablecerPantalla();
        }
    }
}
