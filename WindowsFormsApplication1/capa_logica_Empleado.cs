using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    class capa_logica_Empleado
    {
        public static SqlConnection SQL_Conexion = new SqlConnection();

        public static int Agregar(capa_presentacion_Empleado pMotivo)
            {

                int retorno = 0;
            
                SqlCommand comando = new SqlCommand(string.Format("Insert into motivouno (motivo, descripcion) values ('{0}','{1}')",
                   pMotivo.motivo, pMotivo.descripcion), conexionbd_Empleado.ObtenerConexion());
                retorno = comando.ExecuteNonQuery();
                return retorno;
            }

        public void cargagrid()
        {

        }

        public static int LoginD(string sUser, string sContra)
        {
            int retorno = 0;
            SqlCommand comando = new SqlCommand("Select usuario from USUARIO_1 WHERE usuario='" + sUser + "'And password ='" + sContra + "'", conexionbd_Empleado.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            Object obj = comando.ExecuteScalar();

            if (obj == null)
            {
                retorno = 0;
                SQL_Conexion.Close();
            }
            else
            {
                retorno = 1;
                SQL_Conexion.Close();
            }
            //devolvvemos la variable
            return retorno;
        }
    

    public static int InsertaEmpleado()
    {
        int retorno = 0;
        SqlCommand comando = new SqlCommand("EXEC InsertaEmpleado", conexionbd_Empleado.ObtenerConexion());
        retorno = comando.ExecuteNonQuery();
        return retorno;
    }
}
}
