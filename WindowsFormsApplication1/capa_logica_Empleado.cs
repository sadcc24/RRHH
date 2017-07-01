using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

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

         
            string ecrypt = classEncryptD.Encrypt(sContra);

            int retorno = 0;
                    SqlCommand comando2 = new SqlCommand("Select usuario from USUARIO_1 WHERE usuario='" + sUser + "'And password ='" + ecrypt + "'", conexionbd_Empleado.ObtenerConexion());
                    Object obj = comando2.ExecuteScalar();
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

            SQL_Conexion.Close();
        }


        public static DataTable ObtenerRegistros(string sUser)
        {
            DataTable dtRegistros = new DataTable();//Tabla de datos
            try
            {//Llamada de Conexion y Query
                SqlCommand comando = new SqlCommand(string.Format("SELECT c.usuario , b.nombre_empresa FROM EMPLEADO A INNER JOIN Empresa B ON A.idempresa = B.idempresa INNER JOIN USUARIO_1 C ON C.codusuario = A.codusuario WHERE C.usuario = '" + sUser + "';"), conexionbd_Empleado.ObtenerConexion());
                SqlDataAdapter SqlDAdAdaptador = new SqlDataAdapter();
                SqlDAdAdaptador.SelectCommand = comando;
                SqlDAdAdaptador.Fill(dtRegistros);//Llena la tabla dtRegistros
                SQL_Conexion.Close();
            }
            catch (Exception Ex)
            {
}
            return dtRegistros;
        }

        public static int InsertaEmpleado()
    {
        int retorno = 0;
        SqlCommand comando = new SqlCommand("EXEC InsertaEmpleado", conexionbd_Empleado.ObtenerConexion());
        retorno = comando.ExecuteNonQuery();
        return retorno;
    }

        //public static void DatosEmpleado(string sUser)
        //{
        //    SqlDataAdapter comando = new SqlDataAdapter("Select password from USUARIO_1 WHERE usuario='" + sUser + "'", conexionbd_Empleado.ObtenerConexion());
        //    DataTable Datos = new DataTable();
        //    comando.Fill(Datos);
        //    SQL_Conexion.Close();

        //    string password = Datos.Rows[0][0].ToString();
        //    SQL_Conexion.Close();

        //}
    }
}
