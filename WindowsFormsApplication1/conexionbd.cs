﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
   public class conexionbd
    {
        public static SqlConnection ObtenerConexion()
        {

/*<<<<<<< HEAD
            string string2 = "Data Source=DESKTOP-U9T6J4K\\SQLSERVER14; Initial Catalog=SAD2017; Integrated Security=true;";
            string string1 = "Data Source=127.0.0.1;" + "Initial Catalog=SAD2017;" + "User id=sa;" + "Password=12345;"; 
            SqlConnection conectar = new SqlConnection(string1);
=======*/
            string string2 = "Data Source=DESKTOP-NF03BP4\\SQLEXPRESS; Initial Catalog=SAD2017; Integrated Security=true;";
            string string1 = "Data Source=127.0.0.1;" + "Initial Catalog=SAD2017;" + "User id=sa;" + "Password=12345;"; 
            SqlConnection conectar = new SqlConnection(string2);
//>>>>>>> fix_2
            conectar.Open();
            return conectar;
        }
        
    }
}
