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
using System.Data;

namespace DSMarket.Solucion.Pantallas.Pantallas.Graficos
{
    public partial class CantidadMArcas : Form
    {
        public CantidadMArcas()
        {
            InitializeComponent();
        }
        int[] Cantidad = new int[10];
        string[] Marca = new string[10];

        private void ObtenerInformacion() {

            int Contador = 0;
            SqlConnection Conexion = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DSMarketConexion"].ConnectionString);

            SqlCommand comando = new SqlCommand("SELECT COUNT(*) AS Cantidad ,m.Descripcion as Marca from Inventario.Producto pro inner join Inventario.Marcas m on m.IdMarca = pro.IdMarca group by m.Descripcion", Conexion);
            Conexion.Open();
            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read()) {
                Cantidad[Contador] = Convert.ToInt32(reader.GetInt32(0));
                Marca[Contador] = reader.GetString(1);
                Contador++;
            }
            GraficoMarcas.Series["Series1"].Points.DataBindXY(Marca,Cantidad );
        }

        private void CantidadMArcas_Load(object sender, EventArgs e)
        {
            ObtenerInformacion();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
    }

