using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
   public class conexionbd_Empleado
    {
        public static SqlConnection ObtenerConexion()
        {
            string string3 = "Server=tcp:erpseminario.database.windows.net;Database=ERPSeminario;User ID =adminseminario@ERPSeminario;Password=S@dseminario;Trusted_Connection=False;Encrypt=True;";
           // string string1 = "Data Source=127.0.0.1;" + "Initial Catalog=SAD2017;" + "User id=sa;" + "Password=12345;"; 
            SqlConnection conectar = new SqlConnection(string3);
            conectar.Open();
            return conectar;
        }
        
    }
}
