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

namespace DSMarket.Solucion.Pantallas.Pantallas.PRUEBAS
{
    public partial class PRUEBAS : Form
    {
        public PRUEBAS()
        {
            InitializeComponent();
        }
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog Imagen = new OpenFileDialog();
                Imagen.InitialDirectory = "C://";
                Imagen.Filter = "All files(*.*)|*.*";
                Imagen.FilterIndex = 2;
                Imagen.RestoreDirectory = true;
                if (Imagen.ShowDialog() == DialogResult.OK)
                {
                    this.VariablesGlobales.RutaImagen = Imagen.FileName;
                    pictureBox1.ImageLocation = VariablesGlobales.RutaImagen;
                }
            }
            catch (Exception) { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandText = " EXEC Configuracion.SP_GUARDAR_IMAGENES_SISTEMA @IdLogoEmpresa,@Descripcion,@LogoEmpresa";
            comando.Connection = DSMarket.Data.Conexion.ConexionADO.BDConexion.ObtenerConexion();

            comando.Parameters.Add("@IdLogoEmpresa", SqlDbType.Decimal);
            comando.Parameters.Add("@Descripcion", SqlDbType.VarChar);
            comando.Parameters.Add("@LogoEmpresa", SqlDbType.Image);

            comando.Parameters["@IdLogoEmpresa"].Value = Convert.ToDecimal(textBox1.Text);
            comando.Parameters["@Descripcion"].Value = textBox2.Text;

            MemoryStream imagen = new MemoryStream();
            pictureBox1.Image.Save(imagen, System.Drawing.Imaging.ImageFormat.Jpeg);
            comando.Parameters["@LogoEmpresa"].Value = imagen.GetBuffer();

            DSMarket.Data.Conexion.ConexionADO.BDConexion.ObtenerConexion();
            comando.ExecuteNonQuery();
            DSMarket.Data.Conexion.ConexionADO.BDConexion.ObtenerConexion().Close();
            MessageBox.Show("Regsitro guardado");
        }

        private void PRUEBAS_Load(object sender, EventArgs e)
        {
           
        }
    }
}
