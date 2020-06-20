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
    public partial class MantenimientoTipoSuplidores : Form
    {
        public MantenimientoTipoSuplidores()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaInventario.LogicaInventario> ObjdataInventario = new Lazy<Logica.Logica.LogicaInventario.LogicaInventario>();
        Lazy<DSMarket.Logica.Logica.LogicaSeguridad.LogicaSeguridad> ObjdataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad.LogicaSeguridad>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();


        #region MANTENIIMEINTO DE TIPO DE SUPLIDORES
        private void MANTipoSUplidores(string Accion)
        {
            try {
                DSMarket.Logica.Entidades.EntidadesInventario.ETipoSuplidores Mantenimiento = new Logica.Entidades.EntidadesInventario.ETipoSuplidores();

                Mantenimiento.IdTipoSuplidor = VariablesGlobales.IdMantenimeinto;
                Mantenimiento.TipoSuplidor = txtTiposuplidor.Text;
                Mantenimiento.Estatus0 = cbEstatus.Checked;
                Mantenimiento.UsuarioAdiciona = VariablesGlobales.IdUsuario;
                Mantenimiento.FechaAdiciona = DateTime.Now;
                Mantenimiento.UsuarioModifica = VariablesGlobales.IdUsuario;
                Mantenimiento.FechaModifica = DateTime.Now;

                var MAN = ObjdataInventario.Value.MantenimientoTipoSuplidores(Mantenimiento, Accion);

            }
            catch (Exception ex) {
                MessageBox.Show("Error al realizar el mantenimiento codigo de rrror: " + ex.Message, VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region CERRAR Y RESTABLECER
        private void CerrarPantalla()
        {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.TipoSuplidoresConsulta Consulta = new TipoSuplidoresConsulta();
            VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Consulta.ShowDialog();
        }
        private void RestablecerPantalla()
        {
            txtTiposuplidor.Text = string.Empty;
            cbEstatus.Checked = true;
        }
        #endregion
        private void MantenimientoTipoSuplidores_Load(object sender, EventArgs e)
        {
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            cbEstatus.Checked = true;
            lbTitulo.ForeColor = Color.WhiteSmoke;
            this.BackColor = SystemColors.Control;
            txtTiposuplidor.BackColor = Color.WhiteSmoke;
            txtClaveSeguridad.BackColor = Color.WhiteSmoke;
            txtClaveSeguridad.PasswordChar = '•';
            if (VariablesGlobales.Accion == "INSERT")
            {
                btnGuardar.Text = "Guardar registro";
                lbTitulo.Text = "CREAR NUEVO REGISTRO";
                lbclaveSeguridad.Visible = false;
                txtClaveSeguridad.Visible = false;
            }
            else if (VariablesGlobales.Accion == "UPDATE")
            {
                btnGuardar.Text = "Modificar registro";
                lbTitulo.Text = "MODIFICAR REGISTRO SELECCIONADO";
                lbclaveSeguridad.Visible = true;
                txtClaveSeguridad.Visible = true;

                var SacarInformacion = ObjdataInventario.Value.BuscaTipoSupidores(
                    VariablesGlobales.IdMantenimeinto,
                    null, 1, 1);
                foreach (var n in SacarInformacion)
                {
                    txtTiposuplidor.Text = n.TipoSuplidor;
                    cbEstatus.Checked = (n.Estatus0.HasValue ? n.Estatus0.Value : false);
                }
            }
        }

        private void MantenimientoTipoSuplidores_FormClosing(object sender, FormClosingEventArgs e)
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
            CerrarPantalla();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTiposuplidor.Text.Trim()))
            {
                MessageBox.Show("El campo tipo de suplidor no puede estar vacio para realziar esta operación", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                if (VariablesGlobales.Accion == "INSERT")
                {
                    MANTipoSUplidores(VariablesGlobales.Accion);
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
                    if (string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()))
                    {
                        MessageBox.Show("El campo clave de seguridad no puede estar vacio", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtClaveSeguridad.Focus();
                    }
                    else
                    {
                        string _ClaveSeguridad = string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()) ? null : txtClaveSeguridad.Text.Trim();

                        var ValidarClaveSeguridad = ObjdataSeguridad.Value.BuscaClaveSeguridad(
                            new Nullable<decimal>(),
                            null,
                            DSMarket.Logica.Comunes.SeguridadEncriptacion.Encriptar(_ClaveSeguridad), 1, 1);
                        if (ValidarClaveSeguridad.Count() < 1)
                        {
                            MessageBox.Show("La clave de seguridad ingresada no es valida, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtClaveSeguridad.Text = string.Empty;
                            txtClaveSeguridad.Focus();
                        }
                        else
                        {
                            MANTipoSUplidores(VariablesGlobales.Accion);
                            MessageBox.Show("Registro modificado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CerrarPantalla();
                        }
                    }
                }
            }

          
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
