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
    public partial class MantenimientoModelos : Form
    {
        public MantenimientoModelos()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaInventario.LogicaInventario> ObjdataInventario = new Lazy<Logica.Logica.LogicaInventario.LogicaInventario>();
        Lazy<DSMarket.Logica.Logica.LogicaSeguridad.LogicaSeguridad> ObjdataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad.LogicaSeguridad>();
        Lazy<DSMarket.Logica.Logica.LogicaListas.LogicaListas> ObjDataListas = new Lazy<Logica.Logica.LogicaListas.LogicaListas>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();


        #region CARGAR LISTAS
        private void CargarListas()
        {
            var Cargar = ObjDataListas.Value.BucaLisaMarcas();
            ddlSeleccionarMarcas.DataSource = Cargar;
            ddlSeleccionarMarcas.ValueMember = "IdMarca";
            ddlSeleccionarMarcas.DisplayMember = "Descripcion";
        }
        #endregion
        #region CERRAR PANTALLA  Y RESTABELCER
        private void CerrarPantalla() {

            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.ModelosConsulta Consulta = new ModelosConsulta();
            Consulta.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Consulta.ShowDialog();
        }
        private void Restablecer() {
            CargarListas();
            txtModelo.Text = string.Empty;
            txtModelo.Focus();
        }
        #endregion
        #region MANTENIMIENTO DE MODELOS
        private void MANModelos(string Accion)
        {
            try {
                DSMarket.Logica.Entidades.EntidadesInventario.EModelos Mantenimiento = new Logica.Entidades.EntidadesInventario.EModelos();

                Mantenimiento.IdMarca = Convert.ToDecimal(ddlSeleccionarMarcas.SelectedValue);
                Mantenimiento.IdModelo = VariablesGlobales.IdMantenimeinto;
                Mantenimiento.Modelo = txtModelo.Text;
                Mantenimiento.Estatus0 = cbEstatus.Checked;
                Mantenimiento.UsuarioAdiciona = VariablesGlobales.IdUsuario;
                Mantenimiento.FechaAdiciona = DateTime.Now;
                Mantenimiento.UsuarioModifica = VariablesGlobales.IdUsuario;
                Mantenimiento.FechaModifica = DateTime.Now;
                Mantenimiento.IdTipoProducto = Convert.ToDecimal(ddlSeleccionarTipoProducto.SelectedValue);
                Mantenimiento.IdCategoria = Convert.ToDecimal(ddlSelecionarCategoria.SelectedValue);

                var MAN = ObjdataInventario.Value.MantenimientoModelos(Mantenimiento, Accion);

            }
            catch (Exception ex) {
                MessageBox.Show("Error al realizar el mantenimiento, codigo de error: " + ex.Message);
            }
        }
        #endregion
        #region CARGAR LAS CATEGORIAS
        private void CargarCategorias()
        {
            var Categorias = ObjDataListas.Value.ListadoCategorias(
                Convert.ToDecimal(ddlSeleccionarTipoProducto.SelectedValue));
            ddlSelecionarCategoria.DataSource = Categorias;
            ddlSelecionarCategoria.DisplayMember = "Descripcion";
            ddlSelecionarCategoria.ValueMember = "IdCategoria";
        }
        #endregion
        #region CARGAR LOS TIPOS DE PRODUCTOS
        private void CargarTipoProductos()
        {
            var TipoProducto = ObjDataListas.Value.ListaTipoProducto(
                new Nullable<decimal>(),
                null);
            ddlSeleccionarTipoProducto.DataSource = TipoProducto;
            ddlSeleccionarTipoProducto.DisplayMember = "Descripcion";
            ddlSeleccionarTipoProducto.ValueMember = "IdTipoproducto";
        }
        #endregion
        private void PCerrar_Click(object sender, EventArgs e)
        {
            CerrarPantalla();
        }

        private void MantenimientoModelos_Load(object sender, EventArgs e)
        {
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            cbEstatus.Checked = true;
            CargarTipoProductos();
            CargarCategorias();
            CargarListas();
            this.BackColor = SystemColors.Control;
            txtClaveSeguridad.BackColor = Color.WhiteSmoke;
            txtModelo.BackColor = Color.WhiteSmoke;
            ddlSeleccionarMarcas.BackColor = Color.WhiteSmoke;
            txtClaveSeguridad.BackColor = Color.WhiteSmoke;
            if (VariablesGlobales.Accion == "INSERT")
            {
                lbTitulo.Text = "CREAR NUEVO REGISTRO";
                lbTitulo.ForeColor = Color.WhiteSmoke;
                lbclaveSeguridad.Visible = false;
                txtClaveSeguridad.Visible = false;
                btnGuardar.Text = "Guardar Registro";
            }
            else if (VariablesGlobales.Accion == "UPDATE")
            {
                lbTitulo.Text = "MODIFICAR REGISTRO SELECCIONADO";
                lbTitulo.ForeColor = Color.WhiteSmoke;
                lbclaveSeguridad.Visible = true;
                txtClaveSeguridad.Visible = true;
                btnGuardar.Text = "Modificar Registro";


                var SacarDatos = ObjdataInventario.Value.BuscaModelos(
                    null,
                    null,
                    null,
                    VariablesGlobales.IdMantenimeinto,
                    null, 1, 1);
                foreach (var n in SacarDatos)
                {
                    ddlSeleccionarTipoProducto.Text = n.TipoPrducto;
                    ddlSelecionarCategoria.Text = n.Categoria;
                    ddlSeleccionarMarcas.Text = n.Marca;
                    txtModelo.Text = n.Modelo;
                    cbEstatus.Checked = (n.Estatus0.HasValue ? n.Estatus0.Value : false);
                    
                }
            }
        }

        private void MantenimientoModelos_FormClosing(object sender, FormClosingEventArgs e)
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
            if (string.IsNullOrEmpty(ddlSeleccionarMarcas.Text.Trim()) || string.IsNullOrEmpty(txtModelo.Text.Trim()))
            {
                MessageBox.Show("No puedes dejar campos vacios para realizar esta operación", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (VariablesGlobales.Accion == "INSERT")
                {
                    MANModelos(VariablesGlobales.Accion);
                    MessageBox.Show("Registro guardado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (MessageBox.Show("¿Quieres guardar otro registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Restablecer();
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
                    if (string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()))
                    {
                        MessageBox.Show("El campo clave de seguridad no puede estar vacio para modificar este registro", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtClaveSeguridad.Focus();
                    }
                    else
                    {
                        string _ClaveSeguridad = string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()) ? null : txtClaveSeguridad.Text.Trim();

                        var Validar = ObjdataSeguridad.Value.BuscaClaveSeguridad(
                            new Nullable<decimal>(),
                            null,
                            DSMarket.Logica.Comunes.SeguridadEncriptacion.Encriptar(_ClaveSeguridad), 1, 1);
                        if (Validar.Count() < 1)
                        {
                            MessageBox.Show("La clave de seguridad ingresada no es valida, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtClaveSeguridad.Text = string.Empty;
                            txtClaveSeguridad.Focus();
                        }
                        else
                        {
                            MANModelos(VariablesGlobales.Accion);
                            MessageBox.Show("Registro modificado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CerrarPantalla();
                        }
                    }
                }
            }
        }

        private void ddlSeleccionarTipoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                CargarCategorias();
            }
            catch (Exception) { }
        }

        private void ddlSelecionarCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                CargarListas();
            }
            catch (Exception) { }
        }
    }
}
