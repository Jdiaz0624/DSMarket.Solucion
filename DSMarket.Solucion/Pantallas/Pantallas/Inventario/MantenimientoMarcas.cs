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
    public partial class MantenimientoMarcas : Form
    {
        public MantenimientoMarcas()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaInventario.LogicaInventario> ObjDataInventario = new Lazy<Logica.Logica.LogicaInventario.LogicaInventario>();
        Lazy<DSMarket.Logica.Logica.LogicaSeguridad.LogicaSeguridad> ObjDataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad.LogicaSeguridad>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region MANTENIMIENTO DE MARCAS
        private void MAnMArcas(string Accion)
        {
            try {
                DSMarket.Logica.Entidades.EntidadesInventario.Emarcas Mantenimiento = new Logica.Entidades.EntidadesInventario.Emarcas();

                Mantenimiento.IdMarca = VariablesGlobales.IdMantenimeinto;
                Mantenimiento.Marca = txtMArca.Text;
                Mantenimiento.Estatus0 = cbEstatus.Checked;
                Mantenimiento.UsuarioAdiciona = VariablesGlobales.IdUsuario;
                Mantenimiento.FechaAdiciona = DateTime.Now;
                Mantenimiento.UsuarioModifica = VariablesGlobales.IdUsuario;
                Mantenimiento.FechaModifica = DateTime.Now;

                var MAN = ObjDataInventario.Value.MantenimientoMarcas(Mantenimiento, Accion);
            }
            catch (Exception) {
                MessageBox.Show("Error al realizar el mantenimiento", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region LIMPIAR Y CERRAR
        private void CerrarPantalla()
        {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.MarcasConsulta consulta = new MarcasConsulta();
            consulta.variablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            consulta.ShowDialog();

        }
        private void LimpiarPantalla() {
            txtMArca.Text = string.Empty;
            cbEstatus.Checked = true;
        }
        #endregion
        #region PROCESAR MANTENIMIENTO
        private void ProcesarMantenimiento()
        {
            //VALIDAMOS SI HAY CAMPOS VACIOS
            if (string.IsNullOrEmpty(txtMArca.Text.Trim()))
            {
                MessageBox.Show("El campo marca no puede estar vacio, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (VariablesGlobales.Accion == "INSERT")
                {
                    MAnMArcas("INSERT");
                    MessageBox.Show("Registro guardado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (MessageBox.Show("¿Quieres gaurdar otro registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        LimpiarPantalla();
                    }
                    else
                    {
                        CerrarPantalla();
                    }

                    if (VariablesGlobales.ModoRecarga == false)
                    {

                    }
                    else
                    {

                    }
                }
                else
                {
                    //VERIFICAMOS SI EL CAMPO CLAVE DE SEGURIDAD ESTA VACIO
                    if (string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()))
                    {
                        MessageBox.Show("El campo clave de seguridad no puede estar vacio, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        //VALIDAMOS QUE LA CLAVE INGRESADA ES VALIDA
                        string _Clavengresada = string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()) ? null : txtClaveSeguridad.Text.Trim();

                        var ValidarClave = ObjDataSeguridad.Value.BuscaClaveSeguridad(
                            new Nullable<decimal>(),
                            null,
                           DSMarket.Logica.Comunes.SeguridadEncriptacion.Encriptar(_Clavengresada),
                           1, 1);
                        if (ValidarClave.Count() < 1)
                        {
                            MessageBox.Show("La clave ingresada no es valida, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtClaveSeguridad.Text = string.Empty;
                            txtClaveSeguridad.Focus();
                        }
                        else
                        {
                            MAnMArcas("UPDATE");
                            MessageBox.Show("Registro modificado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CerrarPantalla();
                        }

                    }
                }
            }
        }
        #endregion

        private void MantenimientoMarcas_Load(object sender, EventArgs e)
        {
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            this.BackColor = SystemColors.Control;
            txtClaveSeguridad.BackColor = Color.WhiteSmoke;
            txtMArca.BackColor = Color.WhiteSmoke;
            cbEstatus.Checked = true;
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
                txtClaveSeguridad.PasswordChar = '•';

                //SACAMOS LOS DATOS DEL REGISTRO SELECCIONADO
                var SacaDatos = ObjDataInventario.Value.Buscamarcas(
                    VariablesGlobales.IdMantenimeinto,
                    null, 1, 1);
                foreach (var n in SacaDatos)
                {
                    txtMArca.Text = n.Marca;
                    cbEstatus.Checked = (n.Estatus0.HasValue ? n.Estatus0.Value : false);
                }
            }
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            CerrarPantalla();
        }

        private void MantenimientoMarcas_FormClosing(object sender, FormClosingEventArgs e)
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
            ProcesarMantenimiento();
        }

        private void txtClaveSeguridad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                ProcesarMantenimiento();
            }
        }
    }
}
