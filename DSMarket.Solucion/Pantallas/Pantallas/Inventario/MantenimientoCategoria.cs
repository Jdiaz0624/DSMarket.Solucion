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
    public partial class MantenimientoCategoria : Form
    {
        public MantenimientoCategoria()
        {
            InitializeComponent();
        }
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();
        Lazy<DSMarket.Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion> ObjDataCOnfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion>();
        Lazy<DSMarket.Logica.Logica.LogicaInventario.LogicaInventario> ObjdataInventario = new Lazy<Logica.Logica.LogicaInventario.LogicaInventario>();
        Lazy<DSMarket.Logica.Logica.LogicaListas.LogicaListas> ObjDataListas = new Lazy<Logica.Logica.LogicaListas.LogicaListas>();
        Lazy<DSMarket.Logica.Logica.LogicaSeguridad.LogicaSeguridad> ObjdataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad.LogicaSeguridad>();

        #region APLICAR TEMA
        private void AplicarTema()
        {
            this.BackColor = SystemColors.Control;
            txtCategoria.BackColor = Color.WhiteSmoke;
            txtClaveSeguridad.BackColor = Color.WhiteSmoke;
        }
        #endregion
        #region CARGAR LOS TIPOS DE PRODUCTOS
        private void CargarTipoProductos()
        {
            try
            {
                var CargarTipoProducto = ObjDataListas.Value.ListaTipoProducto();
                ddlTipoProducto.DataSource = CargarTipoProducto;
                ddlTipoProducto.DisplayMember = "Descripcion";
                ddlTipoProducto.ValueMember = "IdTipoproducto";
            }
            catch (Exception)
            {

            }
        }
        #endregion
        #region MANTENIMIENTO DE CATEGORIAS
        private void MANCategoria(string Accion)
        {
            try {
                DSMarket.Logica.Entidades.EntidadesInventario.ECategorias Mantenimiento = new Logica.Entidades.EntidadesInventario.ECategorias();

                Mantenimiento.IdCategoria = VariablesGlobales.IdMantenimeinto;
                Mantenimiento.IdTipoProducto = Convert.ToDecimal(ddlTipoProducto.SelectedValue);
                Mantenimiento.Categoria = txtCategoria.Text;
                Mantenimiento.Estatus0 = cbEstatus.Checked;
                Mantenimiento.UsuarioAdiciona = VariablesGlobales.IdUsuario;
                Mantenimiento.Fechaadiciona = DateTime.Now;
                Mantenimiento.UsuarioModifica = VariablesGlobales.IdUsuario;
                Mantenimiento.FechaModifica = DateTime.Now;

                var MAN = ObjdataInventario.Value.MantenimientoCategorias(Mantenimiento, Accion);
            }
            catch (Exception) {
                MessageBox.Show("Error al realizar el mantenimiento", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region CERRAR Y LIMPIAR CONTROLES
        private void LimpiarControles() {
            CargarTipoProductos();
            txtCategoria.Text = string.Empty;
            cbEstatus.Checked = true;
        }
        private void Cerrar() {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.CategoriaConsulta Consulta = new CategoriaConsulta();
            Consulta.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Consulta.ShowDialog();
        }

        #endregion
        #region SACAR LA INFORMACION DE LA EMPRESA
        private void SacarInformacionEmpresa()
        {
            var SacarInformacionEmpresa = ObjDataCOnfiguracion.Value.BuscaInformacionEmpresa();
            foreach (var n in SacarInformacionEmpresa)
            {
                VariablesGlobales.NombreSistema = n.NombreEmpresa;
            }
        }
        #endregion
        private void MantenimientoCategoria_Load(object sender, EventArgs e)
        {
            SacarInformacionEmpresa();
            lbTitulo.ForeColor = Color.WhiteSmoke;
            AplicarTema();
            cbEstatus.Checked = true;
            CargarTipoProductos();
            if (VariablesGlobales.Accion == "INSERT")
            {
                lbTitulo.Text = "CREAR NUEVO REGISTRO";
                btnGuardar.Text = "Guardar Registro";
                lbClaveSeguridad.Visible = false;
                txtClaveSeguridad.Visible = false;
            }
            else if (VariablesGlobales.Accion == "UPDATE")
            {
                lbTitulo.Text = "MODIFICAR REGISTRO SELECCIONADO";
                btnGuardar.Text = "Modificar Registro";

                //SACAMOS LOS DATOS 
                var SacarDatos = ObjdataInventario.Value.Buscacategoria(
                    VariablesGlobales.IdMantenimeinto,
                    null,
                    null,
                    1, 1);
                foreach (var n in SacarDatos)
                {
                    ddlTipoProducto.Text = n.TipoProducto;
                    txtCategoria.Text = n.Categoria;
                    cbEstatus.Checked = (n.Estatus0.HasValue ? n.Estatus0.Value : false);
                }
            }
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            Cerrar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ddlTipoProducto.Text.Trim()) || string.IsNullOrEmpty(txtCategoria.Text.Trim()))
            {
                MessageBox.Show("No puedes dejar campos vacios para realizar esta operación", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (VariablesGlobales.Accion == "INSERT")
                {
                    //GUARDAMOS LOS DATOS
                    MANCategoria("INSERT");
                    MessageBox.Show("Registro guardado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (MessageBox.Show("¿Quieres guardar otro registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        LimpiarControles();
                    }
                    else
                    {
                        Cerrar();
                    }

                }
                else
                {
                    //VALIDAMOS LA CLAVE DE SEGURIDAD
                    if (string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()))
                    {
                        MessageBox.Show("La clave de seguridad no peude estar vacia, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        var ValidarClave = ObjdataSeguridad.Value.BuscaClaveSeguridad(
                            new Nullable<decimal>(),
                            null,
                           DSMarket.Logica.Comunes.SeguridadEncriptacion.Encriptar(txtClaveSeguridad.Text),
                           1, 1);
                        if (ValidarClave.Count() < 1)
                        {
                            MessageBox.Show("La clave de seguridad ingresada no es valida, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            //GUARDAMOS LOS DATOS
                            MANCategoria("UPDATE");
                            MessageBox.Show("Registro modificado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Cerrar();
                        }
                    }
                }
            }
        }
    }
}
