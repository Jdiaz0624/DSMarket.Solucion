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
    public partial class ClientesMantenimiento : Form
    {
        public ClientesMantenimiento()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaListas.LogicaListas> ObjDataListas = new Lazy<Logica.Logica.LogicaListas.LogicaListas>();
        Lazy<DSMarket.Logica.Logica.LogicaEmpresa.LogicaEmpresa> ObjDataEmpresa = new Lazy<Logica.Logica.LogicaEmpresa.LogicaEmpresa>();
        Lazy<DSMarket.Logica.Logica.LogicaSeguridad.LogicaSeguridad> ObjdataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad.LogicaSeguridad>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region CERRAR PANTALLA
        private void CerrarPantalla() {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.ClientesConsulta Consulta = new ClientesConsulta();
            Consulta.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Consulta.ShowDialog();
        }
        #endregion

        #region RESTABLECER PANTALLA
        private void RestablecerPantalla() {
            txtNombreCliente.Text = string.Empty;
            MostrarListadoCOmprobantes();
            MostrarTipoIdentificacion();
            txtNumeroidentificacionCliente.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtLimiteCredito.Text = string.Empty;
            txtLimiteCredito.Text = "0";
            txtComentario.Text = string.Empty;
            cbEstatus.Checked = true;
            cbEnvioEmail.Checked = true;
        }
        #endregion

        #region MOSTRAR EL LISTADO DE LOS COMPROBANTES FISCALES
        private void MostrarListadoCOmprobantes() {
            var MostrarComprobantes = ObjDataListas.Value.BuscaCOmprobantesFiscales();
            ddlSeleccionarComprobantes.DataSource = MostrarComprobantes;
            ddlSeleccionarComprobantes.DisplayMember = "Comprbante";
            ddlSeleccionarComprobantes.ValueMember = "IdComprobante";
        }
        #endregion

        #region MOSTRAR EL LISTADO DE LOS TIPOS DE IDENTIFICACION
        private void MostrarTipoIdentificacion() {
            var LisatdoTipoIdentificacion = ObjDataListas.Value.BuscaTipoIdentificacion();
            ddlTipIdentificacion.DataSource = LisatdoTipoIdentificacion;
            ddlTipIdentificacion.DisplayMember = "TipoIdentificacion";
            ddlTipIdentificacion.ValueMember = "IdTipoIdentificacion";
        }
        #endregion


        private void SacarDatosClientes(decimal IdCliente) {
            var BuscarCliente = ObjDataEmpresa.Value.BuscaClientes(
                IdCliente,
                null, null, null, null, null, 1, 1);
            foreach (var n in BuscarCliente) {
                txtNombreCliente.Text = n.Nombre;
                ddlSeleccionarComprobantes.Text = n.Comprobante;
                ddlTipIdentificacion.Text = n.TipoIdentificacion;
                txtNumeroidentificacionCliente.Text = n.RNC;
                txtTelefono.Text = n.Telefono;
                txtEmail.Text = n.Email;
                txtDireccion.Text = n.Direccion;
                txtLimiteCredito.Text = n.MontoCredito.ToString();
                txtComentario.Text = n.Comentario;
                txtFechaNacimiento.Text = n.FechaNacimiento0.ToString();
                cbEstatus.Checked = (n.Estatus0.HasValue ? n.Estatus0.Value : false);
                cbEnvioEmail.Checked = (n.EnvioEmail0.HasValue ? n.EnvioEmail0.Value : false);
                cbalertacumpleanos.Checked = (n.AlertaCumpleanos0.HasValue ? n.AlertaCumpleanos0.Value : false);
            }
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            CerrarPantalla();
            
        }

        private void ClientesMantenimiento_Load(object sender, EventArgs e)
        {
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            MostrarListadoCOmprobantes();
            MostrarTipoIdentificacion();
            cbEstatus.Checked = true;
            cbEnvioEmail.Checked = true;
            this.BackColor = SystemColors.Control;
            lbTitulo.ForeColor = Color.White;
            txtClaveSeguridad.BackColor = Color.WhiteSmoke;
            txtComentario.BackColor = Color.WhiteSmoke;
            txtDireccion.BackColor = Color.WhiteSmoke;
            txtEmail.BackColor = Color.WhiteSmoke;
            txtLimiteCredito.BackColor = Color.WhiteSmoke;
            txtNombreCliente.BackColor = Color.WhiteSmoke;
            txtNumeroidentificacionCliente.BackColor = Color.WhiteSmoke;
           // txtSegundoTelefono.BackColor = Color.WhiteSmoke;
            txtTelefono.BackColor = Color.WhiteSmoke;
            ddlTipIdentificacion.BackColor = Color.WhiteSmoke;

            txtClaveSeguridad.ForeColor = Color.Black;
            txtComentario.ForeColor = Color.Black;
            txtDireccion.ForeColor = Color.Black;
            txtEmail.ForeColor = Color.Black;
            txtLimiteCredito.ForeColor = Color.Black;
            txtNombreCliente.ForeColor = Color.Black;
            txtNumeroidentificacionCliente.ForeColor = Color.Black;
        //    txtSegundoTelefono.ForeColor = Color.Black;
            txtTelefono.ForeColor = Color.Black;
            ddlTipIdentificacion.ForeColor = Color.Black;

            if (VariablesGlobales.Accion == "INSERT")
            {
                lbTitulo.Text = "CREAR NUEVO REGISTRO";
                btnGuardar.Text = "Guardar registro";
                lbClaveSeguridad.Visible = false;
                txtClaveSeguridad.Visible = false;
                cbEnvioEmail.Checked = true;
            }
            else if (VariablesGlobales.Accion == "UPDATE")
            {
                lbTitulo.Text = "CREAR NUEVO REGISTRO";
                btnGuardar.Text = "Modificar Registro seleccionado";
                lbClaveSeguridad.Visible = false;
                txtClaveSeguridad.Visible = true;
                cbEnvioEmail.Checked = true;
                lbClaveSeguridad.Visible = true;
                txtClaveSeguridad.PasswordChar = '•';
                SacarDatosClientes(VariablesGlobales.IdMantenimeinto);


            }
            else if (VariablesGlobales.Accion == "DELETE")
            {
                lbTitulo.Text = "CREAR NUEVO REGISTRO";
                btnGuardar.Text = "Eliminar Registro seleccionado";
                lbClaveSeguridad.Visible = false;
                txtClaveSeguridad.Visible = true;
                cbEnvioEmail.Checked = true;
                lbClaveSeguridad.Visible = true;
                txtClaveSeguridad.PasswordChar = '•';
                SacarDatosClientes(VariablesGlobales.IdMantenimeinto);
                txtNombreCliente.Enabled = false;
                ddlSeleccionarComprobantes.Enabled = false;
                ddlTipIdentificacion.Enabled = false;
                txtNumeroidentificacionCliente.Enabled = false;
                txtTelefono.Enabled = false;
                txtEmail.Enabled = false;
                txtDireccion.Enabled = false;
                txtLimiteCredito.Enabled = false;
                txtComentario.Enabled = false;
                cbEstatus.Enabled = false;
                cbEnvioEmail.Enabled = false;
            }
        }
        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (VariablesGlobales.Accion == "DELETE") {
                if (string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()))
                {
                    MessageBox.Show("El campo clave de seguridad no puede estar vacio", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()))
                    {
                        errorProvider1.SetError(txtClaveSeguridad, "Campo Vacio");
                    }
                }
                else
                {
                    string _ClaveSeguridad = string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()) ? null : txtClaveSeguridad.Text.Trim();

                    var Validar = ObjdataSeguridad.Value.BuscaClaveSeguridad(
                        new Nullable<decimal>(),
                        null,
                        DSMarket.Logica.Comunes.SeguridadEncriptacion.Encriptar(_ClaveSeguridad),
                        1, 1);
                    if (Validar.Count() < 1)
                    {
                        MessageBox.Show("La clave de seguriad ingresada no es valida, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtClaveSeguridad.Text = string.Empty;
                        txtClaveSeguridad.Focus();
                    }
                    else
                    {
                        DSMarket.Logica.Comunes.PrcesarClientes procesar = new Logica.Comunes.PrcesarClientes(
                  VariablesGlobales.IdMantenimeinto,
                  Convert.ToDecimal(ddlSeleccionarComprobantes.SelectedValue),
                  txtNombreCliente.Text,
                  txtTelefono.Text,
                  Convert.ToDecimal(ddlTipIdentificacion.SelectedValue),
                  txtNumeroidentificacionCliente.Text,
                  Convert.ToDateTime(txtFechaNacimiento.Text),
                  cbalertacumpleanos.Checked,
                  txtDireccion.Text,
                  txtEmail.Text,
                  txtComentario.Text,
                  cbEstatus.Checked,
                  VariablesGlobales.IdUsuario,
                  DateTime.Now,
                  VariablesGlobales.IdUsuario,
                  DateTime.Now,
                  Convert.ToDecimal(txtLimiteCredito.Text),
                  cbEnvioEmail.Checked,
                  "DELETE");
                        procesar.ProcesarInformacion();
                        MessageBox.Show("Registro modificado exitosamente", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CerrarPantalla();
                    }
                }

            }
            else {
                //VALIDAMOS LOS CAMPOS VACIOS
                if (string.IsNullOrEmpty(txtNombreCliente.Text.Trim()) || string.IsNullOrEmpty(ddlSeleccionarComprobantes.Text.Trim()) || string.IsNullOrEmpty(ddlTipIdentificacion.Text.Trim()) || string.IsNullOrEmpty(txtNumeroidentificacionCliente.Text.Trim()) || string.IsNullOrEmpty(txtLimiteCredito.Text.Trim()))
                {
                    MessageBox.Show("Has dejado campos vacios que son necesarios para realizar esta operación", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (string.IsNullOrEmpty(txtNombreCliente.Text.Trim()))
                    {
                        errorProvider1.SetError(txtNombreCliente, "Campo Vacio");
                    }

                    if (string.IsNullOrEmpty(ddlSeleccionarComprobantes.Text.Trim()))
                    {
                        errorProvider1.SetError(ddlSeleccionarComprobantes, "Campo Vacio");
                    }

                    if (string.IsNullOrEmpty(ddlTipIdentificacion.Text.Trim()))
                    {
                        errorProvider1.SetError(ddlTipIdentificacion, "Campo Vacio");
                    }

                    if (string.IsNullOrEmpty(txtNumeroidentificacionCliente.Text.Trim()))
                    {
                        errorProvider1.SetError(txtNumeroidentificacionCliente, "Campo Vacio");
                    }

                    if (string.IsNullOrEmpty(txtLimiteCredito.Text.Trim()))
                    {
                        errorProvider1.SetError(txtLimiteCredito, "Campo Vacio");
                    }
                }
                else
                {
                    if (VariablesGlobales.Accion == "INSERT")
                    {
                        DSMarket.Logica.Comunes.PrcesarClientes procesar = new Logica.Comunes.PrcesarClientes(
                            VariablesGlobales.IdMantenimeinto,
                            Convert.ToDecimal(ddlSeleccionarComprobantes.SelectedValue),
                            txtNombreCliente.Text,
                            txtTelefono.Text,
                            Convert.ToDecimal(ddlTipIdentificacion.SelectedValue),
                            txtNumeroidentificacionCliente.Text,
                            Convert.ToDateTime(txtFechaNacimiento.Text),
                            cbalertacumpleanos.Checked,
                            txtDireccion.Text,
                            txtEmail.Text,
                            txtComentario.Text,
                            cbEstatus.Checked,
                            VariablesGlobales.IdUsuario,
                            DateTime.Now,
                            VariablesGlobales.IdUsuario,
                            DateTime.Now,
                            Convert.ToDecimal(txtLimiteCredito.Text),
                            cbEnvioEmail.Checked,
                            "INSERT");
                        procesar.ProcesarInformacion();
                        MessageBox.Show("Registro guardado exitosamente", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (MessageBox.Show("¿Quieres agregar otro registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            RestablecerPantalla();
                        }
                        else
                        {
                            CerrarPantalla();
                        }
                    }
                    else if (VariablesGlobales.Accion == "UPDATE")
                    {
                        if (string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()))
                        {
                            MessageBox.Show("El campo clave de seguridad no puede estar vacio", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            if (string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()))
                            {
                                errorProvider1.SetError(txtClaveSeguridad, "Campo Vacio");
                            }
                        }
                        else
                        {
                            string _ClaveSeguridad = string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()) ? null : txtClaveSeguridad.Text.Trim();

                            var Validar = ObjdataSeguridad.Value.BuscaClaveSeguridad(
                                new Nullable<decimal>(),
                                null,
                                DSMarket.Logica.Comunes.SeguridadEncriptacion.Encriptar(_ClaveSeguridad),
                                1, 1);
                            if (Validar.Count() < 1)
                            {
                                MessageBox.Show("La clave de seguriad ingresada no es valida, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txtClaveSeguridad.Text = string.Empty;
                                txtClaveSeguridad.Focus();
                            }
                            else
                            {
                                DSMarket.Logica.Comunes.PrcesarClientes procesar = new Logica.Comunes.PrcesarClientes(
                          VariablesGlobales.IdMantenimeinto,
                          Convert.ToDecimal(ddlSeleccionarComprobantes.SelectedValue),
                          txtNombreCliente.Text,
                          txtTelefono.Text,
                          Convert.ToDecimal(ddlTipIdentificacion.SelectedValue),
                          txtNumeroidentificacionCliente.Text,
                          Convert.ToDateTime(txtFechaNacimiento.Text),
                          cbalertacumpleanos.Checked,
                          txtDireccion.Text,
                          txtEmail.Text,
                          txtComentario.Text,
                          cbEstatus.Checked,
                          VariablesGlobales.IdUsuario,
                          DateTime.Now,
                          VariablesGlobales.IdUsuario,
                          DateTime.Now,
                          Convert.ToDecimal(txtLimiteCredito.Text),
                          cbEnvioEmail.Checked,
                          "UPDATE");
                                procesar.ProcesarInformacion();
                                MessageBox.Show("Registro modificado exitosamente", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                CerrarPantalla();
                            }
                        }
                    }
                }
            }

        }
    }
}
