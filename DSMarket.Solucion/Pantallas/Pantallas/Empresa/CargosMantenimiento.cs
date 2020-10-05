using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSMarket.Solucion.Pantallas.Pantallas.Empresa
{
    public partial class CargosMantenimiento : Form
    {
        public CargosMantenimiento()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaListas.LogicaListas> ObjDataListass = new Lazy<Logica.Logica.LogicaListas.LogicaListas>();
        Lazy<DSMarket.Logica.Logica.LogicaEmpresa.LogicaEmpresa> ObjDataEmpresa = new Lazy<Logica.Logica.LogicaEmpresa.LogicaEmpresa>();
        Lazy<DSMarket.Logica.Logica.LogicaSeguridad.LogicaSeguridad> ObjdataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad.LogicaSeguridad>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        private void LimpiarControles() {
            MostrarListadoDepartamntos();
            txtCargo.Text = string.Empty;
            cbEstatus.Checked = true;
        }
        private void CerrarPantalla() {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.CargosConsulta Consulta = new CargosConsulta();
            Consulta.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Consulta.ShowDialog();
        }

        private void MANCargos() {
            try {
                if (string.IsNullOrEmpty(ddlSeleccionarDepartamento.Text.Trim()) || string.IsNullOrEmpty(txtCargo.Text.Trim()))
                {
                    MessageBox.Show("No puedes dejar campos vacios para realizar esta operación, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else {
                    DSMarket.Logica.Comunes.ProcesarInformacion.ProcesarInformacionCargos Procesar = new Logica.Comunes.ProcesarInformacion.ProcesarInformacionCargos(
                        VariablesGlobales.IdMantenimeinto,
                        Convert.ToDecimal(ddlSeleccionarDepartamento.SelectedValue),
                        txtCargo.Text,
                        cbEstatus.Checked,
                        VariablesGlobales.IdUsuario,
                        DateTime.Now,
                        VariablesGlobales.IdUsuario,
                        DateTime.Now,
                        VariablesGlobales.Accion);
                    Procesar.ProcesarInformacion();
                    if (VariablesGlobales.Accion != "INSERT")
                    {
                        MessageBox.Show("Registro modificado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else {
                        MessageBox.Show("Registro guardado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Error al realizar el mantenimiento de los cargos, codigo de error: " + ex.Message,VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region MOSTRAR EL LISTADO DE LOS DEPARTAMENTOS
        private void MostrarListadoDepartamntos()
        {
            var Departamentos = ObjDataListass.Value.ListadoDepartamentos();
            ddlSeleccionarDepartamento.DataSource = Departamentos;
            ddlSeleccionarDepartamento.DisplayMember = "Departamento";
            ddlSeleccionarDepartamento.ValueMember = "IdDepartamento";
        }
        #endregion
       
        private void PCerrar_Click(object sender, EventArgs e)
        {
            CerrarPantalla();
        }

        private void CargosMantenimiento_Load(object sender, EventArgs e)
        {
            MostrarListadoDepartamntos();
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            lbTitulo.ForeColor = Color.WhiteSmoke;
            this.BackColor = SystemColors.Control;
            txtCargo.BackColor = Color.WhiteSmoke;
            ddlSeleccionarDepartamento.BackColor = Color.WhiteSmoke;
            

            if (VariablesGlobales.Accion == "INSERT")
            {
                lbTitulo.Text = "CREAR NUEVO REGISTRO";
                btnGuardar.Text = "Guardar registro";
                lbclaveSeguridad.Visible = false;
                txtClaveSeguridad.Visible = false;
                cbEstatus.Checked = true;
            }
            else if (VariablesGlobales.Accion == "UPDATE")
            {
                lbTitulo.Text = "MODIFICAR REGISTRO SELECCIONADO";
                btnGuardar.Text = "Modificar registro";
                lbclaveSeguridad.Visible = true;
                txtClaveSeguridad.Visible = true;
                txtClaveSeguridad.PasswordChar = '•';
                txtClaveSeguridad.Text = string.Empty;


                var SacarDatos = ObjDataEmpresa.Value.BuscaCargos(
                    VariablesGlobales.IdMantenimeinto,
                    null, null, 1, 1);
                foreach (var n in SacarDatos) {
                    ddlSeleccionarDepartamento.Text = n.Departamento;
                    txtCargo.Text = n.Cargo;
                    cbEstatus.Checked = (n.Estatus0.HasValue ? n.Estatus0.Value : false);
                }

                lbclaveSeguridad.Visible = true;
                txtClaveSeguridad.Visible = true;
            }

        }

        private void CargosMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
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
            if (VariablesGlobales.Accion != "INSERT")
            {
                if (string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()))
                {
                    MessageBox.Show("El campo clave de seguridad no puede estar vacio para modificar este registro", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else {
                    string _ClaveSeguridad = string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()) ? null : txtClaveSeguridad.Text.Trim();

                    var Validar = ObjdataSeguridad.Value.BuscaClaveSeguridad(
                        new Nullable<decimal>(),
                        null,
                        DSMarket.Logica.Comunes.SeguridadEncriptacion.Encriptar(_ClaveSeguridad),
                        1, 1);
                    if (Validar.Count() < 1)
                    {
                        MessageBox.Show("La clave de seguridad ingresada no es valida, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtClaveSeguridad.Text = string.Empty;

                    }
                    else {
                        MANCargos();
                        CerrarPantalla();
                    }
                }
            }
            else {
                MANCargos();
                if (MessageBox.Show("¿Quieres guardar otro registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                    LimpiarControles();
                }
                else {
                    CerrarPantalla();
                }
            }
        }
    }
}
