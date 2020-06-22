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
    public partial class MantenimientoUnidadMedida : Form
    {
        public MantenimientoUnidadMedida()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaInventario.LogicaInventario> ObjDataInventari = new Lazy<Logica.Logica.LogicaInventario.LogicaInventario>();
        Lazy<DSMarket.Logica.Logica.LogicaSeguridad.LogicaSeguridad> ObjDataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad.LogicaSeguridad>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region RESTABELCER Y CERRAR PANTALLA
        private void CerrarPantalla() {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.UnidadMedidaConsulta Consulta = new UnidadMedidaConsulta();
            Consulta.variablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Consulta.ShowDialog();
        }
        private void RestablecerPantalla() {
            txtUnidadMedida.Text = string.Empty;
            cbEstatus.Checked = true;
            cbEstatus.ForeColor = Color.LimeGreen;
            txtUnidadMedida.Focus();
        }
        #endregion
        #region MANTENIMIENTO DE UNIDAD DE MEDIDA
        private void MAnUnidadMedida(string Accion)
        {
            try {
                DSMarket.Logica.Entidades.EntidadesInventario.EUnidadMedida Mantenimiento = new Logica.Entidades.EntidadesInventario.EUnidadMedida();

                Mantenimiento.IdUnidadMedida = VariablesGlobales.IdMantenimeinto;
                Mantenimiento.UnidadMedida = txtUnidadMedida.Text;
                Mantenimiento.Estatus0 = cbEstatus.Checked;
                Mantenimiento.UsuarioAdiciona = VariablesGlobales.IdUsuario;
                Mantenimiento.FechaAdiciona = DateTime.Now;
                Mantenimiento.UsuarioModifica = VariablesGlobales.IdUsuario;
                Mantenimiento.FechaModifica = DateTime.Now;

                var MAN = ObjDataInventari.Value.MantenimientoUnidadMedida(Mantenimiento, Accion);
            }
            catch (Exception ex) {
                MessageBox.Show("Error al realizar el mantenimiento, codigo de error --> " + ex.Message, VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        private void PCerrar_Click(object sender, EventArgs e)
        {
            CerrarPantalla();
        }

        private void MantenimientoUnidadMedida_Load(object sender, EventArgs e)
        {
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            cbEstatus.Checked = true;
            this.BackColor = SystemColors.Control;
            txtUnidadMedida.BackColor = Color.WhiteSmoke;
            txtClaveSeguridad.BackColor = Color.WhiteSmoke;
            lbTitulo.ForeColor = Color.WhiteSmoke;
            if (VariablesGlobales.Accion == "INSERT")
            {
                lbTitulo.Text = "CREAR NUEVO REGISTRO";
                btnGuardar.Text = "Guardar registro";
                txtClaveSeguridad.Visible = false;
                lbclaveSeguridad.Visible = false;
            }
            else if (VariablesGlobales.Accion == "UPDATE")
            {
                lbTitulo.Text = "MODIFICAR REGISTRO SELECCIONADO";
                btnGuardar.Text = "Modificar registro";
                txtClaveSeguridad.Visible = true;
                lbclaveSeguridad.Visible = true;

                //SACAMOS LOS DATOS DEL REGISTRO SELCCIONADO
                var SacarDatos = ObjDataInventari.Value.BuscaUnidadMedida(
                    Convert.ToDecimal(VariablesGlobales.IdMantenimeinto),
                    null, 1, 1);
                foreach (var n in SacarDatos)
                {
                    txtUnidadMedida.Text = n.UnidadMedida;
                    cbEstatus.Checked = (n.Estatus0.HasValue ? n.Estatus0.Value : false);
                }
            }
        }

        private void MantenimientoUnidadMedida_FormClosing(object sender, FormClosingEventArgs e)
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
            if (string.IsNullOrEmpty(txtUnidadMedida.Text.Trim()))
            {
                MessageBox.Show("No puede sdejar el campo unidad de medida vacio para realizar esta operación", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (VariablesGlobales.Accion == "INSERT")
                {
                  

                    if (VariablesGlobales.ModoRecarga == false)
                    {
                        MAnUnidadMedida("INSERT");
                        MessageBox.Show("Registro guardado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (MessageBox.Show("¿Quieres guardar otro registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            RestablecerPantalla();
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
                        MessageBox.Show("El campo clave de seguridad no peude estar vacio para modificar este registro, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        string _Clave = string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()) ? null : txtClaveSeguridad.Text.Trim();

                        var ValidarClave = ObjDataSeguridad.Value.BuscaClaveSeguridad(
                            new Nullable<decimal>(),
                            null,
                            DSMarket.Logica.Comunes.SeguridadEncriptacion.Encriptar(_Clave),
                            1, 1);
                        if (ValidarClave.Count() < 1)
                        {
                            MessageBox.Show("La clave de seguridad ingresada no es valida, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtClaveSeguridad.Text = string.Empty;
                            txtClaveSeguridad.Focus();
                        }
                        else
                        {
                            MAnUnidadMedida("UPDATE");
                            MessageBox.Show("Registro modificado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CerrarPantalla();
                        }
                    }
                }
            }
        }
    }
}
