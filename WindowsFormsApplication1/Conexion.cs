using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public class Conexion
    {
        public SqlCommand SQL_cmd;
        public SqlConnection SQL_Conexion = new SqlConnection();

        public int conecta()
        { 
        SQL_Conexion.ConnectionString =
                "Data Source=127.0.0.1;" +
                "Initial Catalog=SAD2017;" +
                "User id=sa;" +
                "Password=12345;";
                SQL_Conexion.Open();
            int val = 1;
            return val;
    }
    }
}
