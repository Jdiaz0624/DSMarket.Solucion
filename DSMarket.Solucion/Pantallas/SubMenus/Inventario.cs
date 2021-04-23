using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSMarket.Solucion.Pantallas.SubMenus
{
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }

        enum OpcionesConfigunacionGeneral
        {
            ImpuestoPorDefecto = 1,
            LlevaGarantiaPorDefecto = 2,
            CampoReferenciaObligatorio = 3,
            CampoReferenciaNumerico = 4,
            ValidarampoReferencia = 5,
            UnidadMedidaSeleccionable = 6,
            CampoModeloSeleccionable = 7,
            CampoColorSeleccionable = 8,
            CampoCondicionSeleccionable = 9,
            CampoCapacidadSeleccionable = 10,
            RestablecerListasDesplegablesGuardar = 11,
            AutoCompletarCampoReferenciaConsulta = 12
        }

        /// <summary>
        /// Este metodo es para validar las configuraciones generales del sistema
        /// </summary>
        private void ValidarConfiguracionesGenerales()
        {

            //DECLARAMOS LAS VARIABLES PARA RECIBIR LOS CAMPOS PARA VALIDAR
            bool RespuestaValidacion = false;


            


            



            #region UNIDAD DE MEDIDA SELECCIONABLE
            DSMarket.Logica.Comunes.ValidarConfiguracionesGeneralesSistema ValidarUnidadMedidaSeleccionable = new Logica.Comunes.ValidarConfiguracionesGeneralesSistema((decimal)OpcionesConfigunacionGeneral.UnidadMedidaSeleccionable, 1);
            RespuestaValidacion = ValidarUnidadMedidaSeleccionable.ValidarConfiguracionGeneral();

            switch (RespuestaValidacion)
            {
                case true:
                    btnUnidadMedida.Visible = true;
                    break;
                case false:
                    btnUnidadMedida.Visible = false;
                    break;
            }
            #endregion

            #region MODELO SELECCIONABLE
            DSMarket.Logica.Comunes.ValidarConfiguracionesGeneralesSistema ValidarCampoModeloSeleccionable = new Logica.Comunes.ValidarConfiguracionesGeneralesSistema((decimal)OpcionesConfigunacionGeneral.CampoModeloSeleccionable, 1);
            RespuestaValidacion = ValidarCampoModeloSeleccionable.ValidarConfiguracionGeneral();

            switch (RespuestaValidacion)
            {
                case true:
                    btnModelo.Visible = true;
                    break;
                case false:
                    btnModelo.Visible = false;
                    break;
            }
            #endregion

            #region COLORES SELECCIONABLES
            DSMarket.Logica.Comunes.ValidarConfiguracionesGeneralesSistema ValidarCampoColorSeleccionable = new Logica.Comunes.ValidarConfiguracionesGeneralesSistema((decimal)OpcionesConfigunacionGeneral.CampoColorSeleccionable, 1);
            RespuestaValidacion = ValidarCampoColorSeleccionable.ValidarConfiguracionGeneral();
            switch (RespuestaValidacion)
            {
                case true:
                    btnColores.Visible = true;
                    break;

                case false:
                    btnColores.Visible = false;
                    break;
            }
            #endregion

            #region CONDICIONES SELECCIONABLES
            DSMarket.Logica.Comunes.ValidarConfiguracionesGeneralesSistema ValidarCampoCondicionSeleccionable = new Logica.Comunes.ValidarConfiguracionesGeneralesSistema((decimal)OpcionesConfigunacionGeneral.CampoCondicionSeleccionable, 1);
            RespuestaValidacion = ValidarCampoCondicionSeleccionable.ValidarConfiguracionGeneral();
            switch (RespuestaValidacion)
            {
                case true:
                    btnCondiciones.Visible = true;
                    break;

                case false:
                    btnCondiciones.Visible = false;
                    break;
            }
            #endregion

            #region CAPACIDAD SELECCIONABLE
            DSMarket.Logica.Comunes.ValidarConfiguracionesGeneralesSistema ValidarCampoCapacidadSeleccionable = new Logica.Comunes.ValidarConfiguracionesGeneralesSistema((decimal)OpcionesConfigunacionGeneral.CampoCapacidadSeleccionable, 1);
            RespuestaValidacion = ValidarCampoCapacidadSeleccionable.ValidarConfiguracionGeneral();
            switch (RespuestaValidacion)
            {
                case true:
                    btnCapacidad.Visible = true;
                    break;

                case false:
                    btnCapacidad.Visible = false;
                    break;
            }

            #endregion












        }
        private void Inventario_Load(object sender, EventArgs e)
        {
            lbTitulo.Text = "MANTENIMIENTO DE INVENTARIO";
            lbIdUsuario.Text = DSMarket.Solucion.Pantallas.MenuPrincipal.MenuPrincipal.IdUsuarioMantenimientos.ToString();
            ValidarConfiguracionesGenerales();
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.ProductoConsulta Producto = new Pantallas.Inventario.ProductoConsulta();
            Producto.variablesGlobales.IdUsuario = Convert.ToDecimal(lbIdUsuario.Text);
            Producto.ShowDialog();
        }

        private void btnTipoProducto_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.CategoriaConsulta MantenimientoCategoria = new Pantallas.Inventario.CategoriaConsulta();
            MantenimientoCategoria.VariablesGlobales.IdUsuario = Convert.ToDecimal(lbIdUsuario.Text);
            MantenimientoCategoria.ShowDialog();
        }

        private void btnTipoSuplidores_Click(object sender, EventArgs e)
        {
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.TipoSuplidoresConsulta MantenimientoTipoSuplidor = new Pantallas.Inventario.TipoSuplidoresConsulta();
            MantenimientoTipoSuplidor.VariablesGlobales.IdUsuario = Convert.ToDecimal(lbIdUsuario.Text);
            MantenimientoTipoSuplidor.ShowDialog();
        }

        private void btnUnidaMedida_Click(object sender, EventArgs e)
        {
         
        }

        private void btnMArcas_Click(object sender, EventArgs e)
        {
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.MarcasConsulta MantenimientoMArcas = new Pantallas.Inventario.MarcasConsulta();
            MantenimientoMArcas.variablesGlobales.IdUsuario = Convert.ToDecimal(lbIdUsuario.Text);
            MantenimientoMArcas.ShowDialog();
        }

        private void btnMonedas_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSuplidores_Click(object sender, EventArgs e)
        {
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.SuplidoresConsulta MantenimeintoSuplidores = new Pantallas.Inventario.SuplidoresConsulta();
            MantenimeintoSuplidores.variablesGlobales.IdUsuario = Convert.ToDecimal(lbIdUsuario.Text);
            MantenimeintoSuplidores.ShowDialog();
        }

        private void gbOpciones_Enter(object sender, EventArgs e)
        {

        }

       

        private void btnCondiciones_Click(object sender, EventArgs e)
        {
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.CondicionConsulta ConsultaCondiciones = new Pantallas.Inventario.CondicionConsulta();
            ConsultaCondiciones.VariablesGlobales.IdUsuario = Convert.ToDecimal(lbIdUsuario.Text);
            ConsultaCondiciones.ShowDialog();
        }

        private void btbCapacidad_Click(object sender, EventArgs e)
        {

            DSMarket.Solucion.Pantallas.Pantallas.Inventario.CapacidadConsulta ConsultaCapacidad = new Pantallas.Inventario.CapacidadConsulta();
            ConsultaCapacidad.VariablesGlobales.IdUsuario = Convert.ToDecimal(lbIdUsuario.Text);
            ConsultaCapacidad.ShowDialog();
        }

        private void btnModelo_Click(object sender, EventArgs e)
        {
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.ModelosConsulta ConsultaModelos = new Pantallas.Inventario.ModelosConsulta();
            ConsultaModelos.VariablesGlobales.IdUsuario = Convert.ToDecimal(lbIdUsuario.Text);
            ConsultaModelos.ShowDialog();
        }

        private void btnUnidadMedida_Click(object sender, EventArgs e)
        {
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.UnidadMedidaConsulta unidadMEdidaConsulta = new Pantallas.Inventario.UnidadMedidaConsulta();
            unidadMEdidaConsulta.VariablesGlobales.IdUsuario = Convert.ToDecimal(lbIdUsuario.Text);
            unidadMEdidaConsulta.ShowDialog();
        }

        private void btnColores_Click_1(object sender, EventArgs e)
        {
            DSMarket.Solucion.Pantallas.Pantallas.Inventario.ColoresConsulta ConsultaColores = new Pantallas.Inventario.ColoresConsulta();
            ConsultaColores.VariablesGlobales.IdUsuario = Convert.ToDecimal(lbIdUsuario.Text);
            ConsultaColores.ShowDialog();
        }
    }
}
