using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSMarket.Solucion.Pantallas.Pantallas.Inventario
{
    public partial class MantenimientoSupidores : Form
    {
        public MantenimientoSupidores()
        {
            InitializeComponent();
        }
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();
        Lazy<DSMarket.Logica.Logica.LogicaListas.LogicaListas> ObjDataListas = new Lazy<Logica.Logica.LogicaListas.LogicaListas>();
        Lazy<DSMarket.Logica.Logica.LogicaSeguridad.LogicaSeguridad> ObjdaaSeguridad = new Lazy<Logica.Logica.LogicaSeguridad.LogicaSeguridad>();
        Lazy<DSMarket.Logica.Logica.LogicaInventario.LogicaInventario> ObjDataInventario = new Lazy<Logica.Logica.LogicaInventario.LogicaInventario>();


        #region CARGAR LISTAS
        private void CargarListas()
        {
            var Lista = ObjDataListas.Value.BuscaListaTipoSuplidor();
            ddlSeleccionarTipoSuplidor.DataSource = Lista;
            ddlSeleccionarTipoSuplidor.DisplayMember = "Descripcion";
            ddlSeleccionarTipoSuplidor.ValueMember = "IdTipoSuplidor";
        }
        #endregion
        #region CERRAR Y RESTABLECER
        private void CerrarPantalla() {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.SuplidoresConsulta consulta = new SuplidoresConsulta();
            consulta.variablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            consulta.ShowDialog();
        }
        private void RestabelcerPantalla() {
            CargarListas();
            txtContacto.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtSuplidor.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            cbEstatus.Checked = true;
        }
        #endregion
        #region MANTENIIENTO DE SUPLIDORES
        private void MANSuplidores(string Accion)
        {
            try {
                DSMarket.Logica.Entidades.EntidadesInventario.ESuplidores Mantenimiento = new Logica.Entidades.EntidadesInventario.ESuplidores();

                Mantenimiento.IdTipoSuplidor = Convert.ToDecimal(ddlSeleccionarTipoSuplidor.SelectedValue);
                Mantenimiento.IdSuplidor = VariablesGlobales.IdMantenimeinto;
                Mantenimiento.Suplidor = txtSuplidor.Text;
                Mantenimiento.Telefono = txtTelefono.Text;
                Mantenimiento.Email = txtEmail.Text;
                Mantenimiento.Direccion = txtDireccion.Text;
                Mantenimiento.Contacto = txtContacto.Text;
                Mantenimiento.Estatus0 = cbEstatus.Checked;
                Mantenimiento.UsuarioAdiciona = VariablesGlobales.IdUsuario;
                Mantenimiento.FechaAdiciona = DateTime.Now;
                Mantenimiento.UsuarioModifica = VariablesGlobales.IdUsuario;
                Mantenimiento.FechaModifica = DateTime.Now;

                var MAN = ObjDataInventario.Value.MantenimientoSuplidores(Mantenimiento, Accion);
            }
            catch (Exception ex) {
                MessageBox.Show("Error al realizar el mantenimiento de suplidores, codigo de error: " + ex.Message, VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        private void PCerrar_Click(object sender, EventArgs e)
        {
            CerrarPantalla();
            
        }

        private void MantenimientoSupidores_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void MantenimientoSupidores_Load(object sender, EventArgs e)
        {
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            CargarListas();
            this.BackColor = SystemColors.Control;
            txtClaveSeguridad.BackColor = Color.WhiteSmoke;
            txtContacto.BackColor = Color.WhiteSmoke;
            txtDireccion.BackColor = Color.WhiteSmoke;
            txtEmail.BackColor = Color.WhiteSmoke;
            txtSuplidor.BackColor = Color.WhiteSmoke;
            txtTelefono.BackColor = Color.WhiteSmoke;
            cbEstatus.Checked = true;
            cbEstatus.ForeColor = Color.DarkRed;

            if (VariablesGlobales.Accion == "INSERT")
            {
                lbTitulo.Text = "CREAR NUEVO REGISTRO";
                lbTitulo.ForeColor = Color.WhiteSmoke;
                btnGuardar.Text = "Guardar registro";
                lbclaveSeguridad.Visible = false;
                txtClaveSeguridad.Visible = false;

            }
            else if (VariablesGlobales.Accion == "UPDATE")
            {
                lbTitulo.Text = "MODIFICAR REGISTRO SELECCIONADO";
                lbTitulo.ForeColor = Color.WhiteSmoke;
                btnGuardar.Text = "Modificar registro";
                lbclaveSeguridad.Visible = true;
                txtClaveSeguridad.Visible = true;

                var SacarData = ObjDataInventario.Value.BuscaSupervisores(
                    null,
                    VariablesGlobales.IdMantenimeinto,
                    null, 1, 1);
                foreach (var n in SacarData)
                {
                    ddlSeleccionarTipoSuplidor.Text = n.TipoSuplidor;
                    txtSuplidor.Text = n.Suplidor;
                    txtTelefono.Text = n.Telefono;
                    txtEmail.Text = n.Email;
                    txtDireccion.Text = n.Direccion;
                    txtContacto.Text = n.Contacto;
                    cbEstatus.Checked = (n.Estatus0.HasValue ? n.Estatus0.Value : false);
                }
            }
        }

        private void cbEstatus_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEstatus.Checked == true)
            {
                cbEstatus.ForeColor = Color.LimeGreen;
            }
            else
            {
                cbEstatus.ForeColor = Color.DarkRed;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ddlSeleccionarTipoSuplidor.Text.Trim()) || string.IsNullOrEmpty(txtSuplidor.Text.Trim()))
            {
                MessageBox.Show("has dejado campos vacios que son necesarios para realziar esta operación", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (VariablesGlobales.Accion == "INSERT")
                {
                   

                    if (VariablesGlobales.ModoRecarga == false)
                    {
                        MANSuplidores(VariablesGlobales.Accion);
                        MessageBox.Show("Registro guardado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (MessageBox.Show("¿Quieres guardar otro registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            RestabelcerPantalla();
                        }
                        else
                        {
                            CerrarPantalla();
                        }
                    }
                    else
                    {

                    }
                }
                else
                {
                    if (string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()))
                    {
                        MessageBox.Show("El campo clave de seguridad no peude estar vacio, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtClaveSeguridad.Focus();
                    }
                    else
                    {
                        string _ClaveSeguriad = string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()) ? null : txtClaveSeguridad.Text.Trim();

                        var Validar = ObjdaaSeguridad.Value.BuscaClaveSeguridad(
                            new Nullable<decimal>(),
                            null,
                            DSMarket.Logica.Comunes.SeguridadEncriptacion.Encriptar(_ClaveSeguriad), 1, 1);
                        if (Validar.Count() < 1)
                        {
                            MessageBox.Show("La clave de seguridad ingresada no es valida, favor de veriricar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MANSuplidores(VariablesGlobales.Accion);
                            MessageBox.Show("Registro modificado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CerrarPantalla();
                        }
                    }
                }
            }
        }
    }
}
