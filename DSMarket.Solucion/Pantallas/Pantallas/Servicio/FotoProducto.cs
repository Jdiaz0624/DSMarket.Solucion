using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace DSMarket.Solucion.Pantallas.Pantallas.Servicio
{
    public partial class FotoProducto : Form
    {
        public FotoProducto()
        {
            InitializeComponent();
        }
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlovbales = new Logica.Comunes.VariablesGlobales();


        private void MostrarImagenSeleccionado(PictureBox Imaen)
        {
            try
            {
                SqlCommand comando = new SqlCommand("select FotoProducto from Inventario.FotoProducto where IdProducto = " + VariablesGlovbales.IdProductoSeleccionadoAgregarPorpductos + " and NumeroConector = " + VariablesGlovbales.NumeroConectorSeleccionadoAgregarPorpductos, DSMarket.Data.Conexion.ConexionADO.BDConexion.ObtenerConexion());
                SqlDataAdapter adaptar = new SqlDataAdapter(comando);
                DataSet ds = new DataSet("FotoProducto");
                adaptar.Fill(ds, "FotoProducto");
                byte[] DATOS = new byte[0];
                DataRow dr = ds.Tables["FotoProducto"].Rows[0];
                DATOS = (byte[])dr["FotoProducto"];
                MemoryStream ms = new MemoryStream(DATOS);
                Imaen.Image = System.Drawing.Bitmap.FromStream(ms);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, VariablesGlovbales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FotoProducto_Load(object sender, EventArgs e)
        {
            MostrarImagenSeleccionado(pictureBox1);
        }
    }
}
