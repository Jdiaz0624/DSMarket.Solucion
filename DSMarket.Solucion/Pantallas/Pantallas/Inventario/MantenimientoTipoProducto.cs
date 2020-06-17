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
    public partial class MantenimientoTipoProducto : Form
    {
        public MantenimientoTipoProducto()
        {
            InitializeComponent();
        }
        #region APLICAR TEMA
        private void AplicarTema() {
            this.BackColor = SystemColors.Control;
            txtTipoProducto.BackColor = Color.WhiteSmoke;
            txtClaveSeguridad.BackColor = Color.WhiteSmoke;

            
        }
        #endregion
        Lazy<DSMarket.Logica.Logica.LogicaInventario.LogicaInventario> ObjdataInventario = new Lazy<Logica.Logica.LogicaInventario.LogicaInventario>();
        Lazy<DSMarket.Logica.Logica.LogicaSeguridad.LogicaSeguridad> ObjDataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad.LogicaSeguridad>();
        Lazy<DSMarket.Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion> ObjDataCOnfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region CERRAR LA PANTALLA y LIMPIAR
        private void CerrarPantalla()
        {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.TipoProductoConsulta Consulta = new TipoProductoConsulta();
            Consulta.ShowDialog();
        }
        private void LimpiarControles()
        {
            txtTipoProducto.Text = string.Empty;
            cbacumulativo.Checked = true;
            cbEstatus.Checked = true;
        }
        #endregion
        #region MANTENIMIENTO DE TIPO DE PRODUCTOS
        private void TipoProductoMAn(string Accion)
        {
            DSMarket.Logica.Entidades.EntidadesInventario.ETipoProducto Mantenimiento = new Logica.Entidades.EntidadesInventario.ETipoProducto();

            Mantenimiento.IdTipoproducto = VariablesGlobales.IdMantenimeinto;
            Mantenimiento.Tipoproducto = txtTipoProducto.Text;
            Mantenimiento.Estatus0 = cbEstatus.Checked;
            Mantenimiento.Acumulativo0 = cbacumulativo.Checked;
            Mantenimiento.UsuarioAdiciona = VariablesGlobales.IdUsuario;
            Mantenimiento.Fechaadiciona = DateTime.Now;
            Mantenimiento.UsuarioModifica = VariablesGlobales.IdUsuario;
            Mantenimiento.FechaModifica = DateTime.Now;

            var MAN = ObjdataInventario.Value.MantenimeintoTipoProducto(Mantenimiento, Accion);
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
        private void cbacumulativo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbacumulativo.Checked == true)
            {
                cbacumulativo.ForeColor = Color.LimeGreen;
                cbEstatus.ForeColor = Color.DarkRed;
            }
            else
            {
                cbacumulativo.ForeColor = Color.DarkRed;
                cbEstatus.ForeColor = Color.DarkRed;
            }
        }

        private void cbEstatus_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEstatus.Checked == true)
            {
                cbacumulativo.ForeColor = Color.DarkRed;
                cbEstatus.ForeColor = Color.LimeGreen;
            }
            else
            {
                cbacumulativo.ForeColor = Color.DarkRed;
                cbEstatus.ForeColor = Color.DarkRed;
            }
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            CerrarPantalla();
        }

        private void MantenimientoTipoProducto_Load(object sender, EventArgs e)
        {
            SacarInformacionEmpresa();
            cbacumulativo.Checked = true;
            cbEstatus.Checked = true;
            cbacumulativo.ForeColor = Color.DarkRed;
            cbEstatus.ForeColor = Color.DarkRed;
            AplicarTema();
            if (VariablesGlobales.Accion == "INSERT")
            {
                lbTitulo.Text = "CREAR NUEVO REGISTRO";
                lbTitulo.ForeColor = Color.WhiteSmoke;
                btnGuardar.Text = "Guardar registro";
            }
            else if (VariablesGlobales.Accion == "UPDATE")
            {
                lbTitulo.Text = "MODIFICAR REGISTRO SELECCIONADO";
                btnGuardar.Text = "Modificar registro";
                lbTitulo.ForeColor = Color.WhiteSmoke;

                //SACAMOS LOS DATOS 
                var SacarDatos = ObjdataInventario.Value.BuscaTipoProducto(
                    VariablesGlobales.IdMantenimeinto,
                    null,
                    1, 1);
                foreach (var n in SacarDatos)
                {
                    txtTipoProducto.Text = n.Tipoproducto;
                    cbEstatus.Checked = (n.Estatus0.HasValue ? n.Estatus0.Value : false);
                    cbacumulativo.Checked = (n.Acumulativo0.HasValue ? n.Acumulativo0.Value : false);
                }
            }
          

        }

        private void MantenimientoTipoProducto_FormClosing(object sender, FormClosingEventArgs e)
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
            if (VariablesGlobales.Accion == "INSERT")
            {
                try {
                    TipoProductoMAn("INSERT");
                    MessageBox.Show("Registro guardado exitosamente", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (MessageBox.Show("¿Quieres guardar otro registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        LimpiarControles();
                    }
                    else
                    {
                        CerrarPantalla();
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show("Error al guardar el registro, favor de verificar, codigo de error --> " + ex.Message, VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //validamos el campo para la clave de seguridad
                if (string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()))
                {
                    MessageBox.Show("El campo clave de seguridad no puede estar vacio, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //VALIDAMOS LA CLAVE DE SEGURIDAD INGRESADA
                    string _ClaveSeguridad = string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()) ? null : txtClaveSeguridad.Text.Trim();

                    var ValidarClaveSeguridad = ObjDataSeguridad.Value.BuscaClaveSeguridad(
                        new Nullable<decimal>(),
                        null,
                        DSMarket.Logica.Comunes.SeguridadEncriptacion.Encriptar(_ClaveSeguridad),
                        1, 1);
                    if (ValidarClaveSeguridad.Count() < 1)
                    {
                        MessageBox.Show("La clave de seguridad ingresada no es valida, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else {
                        TipoProductoMAn("UPDATE");
                         MessageBox.Show("Registro modificado exitosamente", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                         CerrarPantalla();
                    }

                }
            }
        }
    }
}
