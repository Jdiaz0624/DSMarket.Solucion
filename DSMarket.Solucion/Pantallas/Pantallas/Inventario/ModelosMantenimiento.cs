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
    public partial class ModelosMantenimiento : Form
    {
        public ModelosMantenimiento()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaListas.LogicaListas> ObjDataListas = new Lazy<Logica.Logica.LogicaListas.LogicaListas>();
        Lazy<DSMarket.Logica.Logica.LogicaInventario.LogicaInventario> ObjDataInventario = new Lazy<Logica.Logica.LogicaInventario.LogicaInventario>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        private void CargarMarcas()
        {

            try
            {
                var Marcas = ObjDataListas.Value.BucaLisaMarcas(new Nullable<decimal>());
                ddlMarca.DataSource = Marcas;
                ddlMarca.DisplayMember = "Descripcion";
                ddlMarca.ValueMember = "IdMarca";

            }
            catch (Exception) { }
        }
        private void MantenimientoModelo() {
            DSMarket.Logica.Comunes.ProcesarInformacion.Inventario.ProcesarInformacionModelos Procesar = new Logica.Comunes.ProcesarInformacion.Inventario.ProcesarInformacionModelos(
                Convert.ToDecimal(ddlMarca.SelectedValue),
                VariablesGlobales.IdMantenimeinto,
                txtModelo.Text,
                cbEstatus.Checked,
                VariablesGlobales.Accion);
            Procesar.ProcesarInformacion();
        }

        private void LimpiarControles() {
            CargarMarcas();
            txtModelo.Text = string.Empty;
            cbEstatus.Checked = true;
        }
        private void CerrarPantalla() {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.ModelosConsulta Consulta = new ModelosConsulta();
            Consulta.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Consulta.ShowDialog();
          
        }
        private void SacarInformacionModelo() {
            var SacarInformacion = ObjDataInventario.Value.BuscaModelos(
                        new Nullable<decimal>(),
                        VariablesGlobales.IdMantenimeinto,
                        null, 1, 1);
            foreach (var n in SacarInformacion)
            {
                ddlMarca.Text = n.Marca;
                txtModelo.Text = n.Modelo;
                cbEstatus.Checked = (n.Estatus0.HasValue ? n.Estatus0.Value : false);
            }
        }
        private void ModelosMantenimiento_Load(object sender, EventArgs e)
        {
            CargarMarcas();
            cbEstatus.Checked = true;
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            lbTitulo.ForeColor = Color.White;
            lbTitulo.Text = "MANTENIMIENTO DE MODELOS";
            if (VariablesGlobales.Accion == "UPDATE")
            {
                SacarInformacionModelo();
                btnGuardar.Text = "Editar";
            }
            else if (VariablesGlobales.Accion == "INSERT")
            {
                btnGuardar.Text = "Guardar";
            }
            else if (VariablesGlobales.Accion == "DELETE") {
                SacarInformacionModelo();
                btnGuardar.Text = "Eliminar";
            }
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            CerrarPantalla();
        }

        private void ModelosMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason) {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ddlMarca.Text.Trim()) || string.IsNullOrEmpty(txtModelo.Text.Trim())) {
                MessageBox.Show("El campo marca o modelo no pueden estar vacios para realizar este proceso, favor de verificar.", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                MantenimientoModelo();


                switch (VariablesGlobales.Accion) {
                    case "INSERT":
                        MessageBox.Show("Registro guardado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (MessageBox.Show("¿Quieres gaurdar otro registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                            LimpiarControles();
                        }
                        else {
                            CerrarPantalla();
                        }
                        break;

                    case "UPDATE":
                        MessageBox.Show("Registro Modificado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CerrarPantalla();
                        break;

                    case "DELETE":
                        MessageBox.Show("Registro Eliminado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CerrarPantalla();
                        break;
                }
            }
        }
    }
}
