using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DSMarket.Data.Conexion.ConexionADO
{
    public static class BDConexion
    {
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection Conexion = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DSMarketConexion"].ConnectionString);
            Conexion.Open();
            return Conexion;
        }
    }
}
