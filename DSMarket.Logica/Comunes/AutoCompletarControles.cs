using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace DSMarket.Logica.Comunes
{
    public class AutoCompletarControles
    {
        public static void AutoCompletarUsuarios(TextBox Usuarios)
        {   //AUTOCOMPLETAR USUARIOS
            SqlCommand comando = new SqlCommand("select Usuario from Seguridad.Usuario where Estatus = 1 and Usuario !='juan.diaz'", DSMarket.Data.Conexion.ConexionADO.BDConexion.ObtenerConexion());
            SqlDataReader readr = comando.ExecuteReader();
            while (readr.Read() == true)
            {
                Usuarios.AutoCompleteCustomSource.Add(readr["Usuario"].ToString());
            }
            readr.Close();
        }


        public static void AutoCOmpletarEmpleados(TextBox Usuarios)
        {   //AUTOCOMPLETAR USUARIOS
            SqlCommand comando = new SqlCommand("select  CONCAT(Nombre,' ',Apellido) as Nombre from Empresa.Empleado where AplicaParaComision = 1", DSMarket.Data.Conexion.ConexionADO.BDConexion.ObtenerConexion());
            SqlDataReader readr = comando.ExecuteReader();
            while (readr.Read() == true)
            {
                Usuarios.AutoCompleteCustomSource.Add(readr["Nombre"].ToString());
            }
            readr.Close();
        }
    }
}




