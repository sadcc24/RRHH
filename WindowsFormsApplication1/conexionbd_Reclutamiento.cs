﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    class conexionbd_Reclutamiento
    {
        public static SqlConnection ObtenerConexion()
        {

            //          string string2 = "Data Source=DESKTOP-U9T6J4K\\SQLSERVER14; Initial Catalog=SAD2017; Integrated Security=true;";
            string string3 = "Server=tcp:erpseminario.database.windows.net;Database=ERPSeminario;User ID =adminseminario@ERPSeminario;Password=S@dseminario;Trusted_Connection=False;Encrypt=True;";
         //   string string1 = "Data Source=.;Initial Catalog=SAD2017;Integrated Security=True";
            SqlConnection conectar = new SqlConnection(string3);
            conectar.Open();
            return conectar;
        }
    }
}
