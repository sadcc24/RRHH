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
            string string2 = "Data Source=erpseminario.database.windows.net;" + "Initial Catalog=ERPSeminario;" + "User id=adminseminario;" + "Password=S@dseminario;";
            string string1 = "Data Source=127.0.0.1;" + "Initial Catalog=SAD20174;" + "User id=sa;" + "Password=12345;"; 
            SqlConnection conectar = new SqlConnection(string1);
            conectar.Open();
            return conectar;
        }
        
    }
}
