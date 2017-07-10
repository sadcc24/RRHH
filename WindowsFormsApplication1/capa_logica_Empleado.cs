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

        public static DataTable GetEmpleadoGrid()
        {
            DataTable dtRegistros = new DataTable();//Tabla de datos
            try
            {//Llamada de Conexion y Query
                SqlCommand comando = new SqlCommand(string.Format("exec gridEmpleado;"), conexionbd_Empleado.ObtenerConexion());
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

        public static DataTable GetEmpleadoDatos(string idemp)
        {
            DataTable dtRegistros = new DataTable();//Tabla de datos
            try
            {//Llamada de Conexion y Query
                SqlCommand comando = new SqlCommand(string.Format("exec EmpleadoDatos '" + idemp+"';"), conexionbd_Empleado.ObtenerConexion());
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

        public static DataTable obtieneRol()
        {
            DataTable dtRegistros = new DataTable();//Tabla de datos
            try
            {//Llamada de Conexion y Query
                SqlCommand comando = new SqlCommand(string.Format("select idrol, rol from ROL;"), conexionbd_Empleado.ObtenerConexion());
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

        public static DataTable obtieneDepto()
        {
            DataTable dtRegistros = new DataTable();//Tabla de datos
            try
            {//Llamada de Conexion y Query
                SqlCommand comando = new SqlCommand(string.Format("select cast(iddepartamentoempresa as int) as id,nombredeptoempresa from DEPARTAMENTOEMPRESA;;"), conexionbd_Empleado.ObtenerConexion());
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
        public static DataTable obtienePuesto(string depto)
        {
            DataTable dtRegistros = new DataTable();//Tabla de datos
            try
            {//Llamada de Conexion y Query
                SqlCommand comando = new SqlCommand(string.Format("select idpuestodetrabajo, nombrepuesto from PUESTODETRABAJO where iddepartamentoempresa ='"+depto+"';"), conexionbd_Empleado.ObtenerConexion());
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
        public static int LoginD(string sUser, string sContra)
        {

         
            string ecrypt = classEncryptD.Encrypt(sContra);

            int retorno = 0;
            //string insert = "INSERT INTO DetalleLaboral (idempleado,idempresa,sueldo,aumento,puesto,jornada,departamento,feciniciolaboral)VALUES('4','1','','','Desarrollador','8 horas','Tecnologia','2017-07-02');";
            //SqlCommand comando3 = new SqlCommand(insert, conexionbd_Empleado.ObtenerConexion());
            //Object obj2 = comando3.ExecuteScalar();
            //SQL_Conexion.Close();
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
                SqlCommand comando = new SqlCommand(string.Format("exec TomaDatosLogin '" + sUser + "';"), conexionbd_Empleado.ObtenerConexion());
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

        public static int InsertaEmpleado( int? experiencia, int? estudio,int Estado, int CodUsuario, int Empresa, int rol,decimal sueldo, decimal aumento, string puesto, string jornada, string feciniciolaboral, string nombre1, string nombre2, string apellido1, string apellido2, string apellido3, string nacionalidad, string sexo, string fechanacimiento, string direccion, int telefono, string identificacion, string fotografia)
    {
        int retorno = 0;
        SqlCommand comando = new SqlCommand("exec InsertaEmpleado " + Estado+ ",'"+ CodUsuario+ "','"+ Empresa+ "','" +rol+ "','" +sueldo +"','"+aumento+"','"+puesto+"','"+jornada+"','"+feciniciolaboral+ "','" + experiencia + "','" + estudio + "','" + nombre1+"','"+nombre2+"','"+apellido1+"','"+apellido2+"','"+apellido3+"','"+nacionalidad+"','"+sexo+"','"+fechanacimiento+"','"+direccion+"',"+telefono+",'"+identificacion+"','"+ fotografia+"';", conexionbd_Empleado.ObtenerConexion());
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
