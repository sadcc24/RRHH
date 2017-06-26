//using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public class D_Rol
    {

        public static SqlCommand SQL_cmd;
        public static SqlConnection SQL_Conexion = new SqlConnection();

        //funcion login el cual consulta los datos del usuario por medio de usuario y contraseña 

        public static int LoginD(string sUser, string sContra)
        {
            //declaramos una variable de tipo entero con valor a 0
            int iValorRetorno = 0;
            SQL_Conexion.ConnectionString =
"Data Source=127.0.0.1;" +
"Initial Catalog=SAD2017;" +
"User id=sa;" +
"Password=12345;";
            //hacemos el query el cual se asignara a odbccomand
            SQL_Conexion.Open();
            SQL_cmd = new SqlCommand("Select usuario from USUARIO_1 WHERE usuario='" + sUser + "'And password ='" + sContra + "'", SQL_Conexion);
            //ejecuta la consulta si hay un dato devuelve un 1, si no un 0
            Object obj = SQL_cmd.ExecuteScalar();

            if (obj == null)
            {
                iValorRetorno = 0;
                SQL_Conexion.Close();
            }
            else
            {
                iValorRetorno = 1;
                SQL_Conexion.Close();
            }
            //devolvvemos la variable
            return iValorRetorno;
        }

    }
}
