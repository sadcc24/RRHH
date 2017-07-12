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
                   pMotivo.motivo, pMotivo.descripcion), conexionbd.ObtenerConexion());
                retorno = comando.ExecuteNonQuery();
                return retorno;
            }
        public static DataTable GetEmpleadoGrid()
        {
            DataTable dtRegistros = new DataTable();//Tabla de datos
            try
            {//Llamada de Conexion y Query
                SqlCommand comando = new SqlCommand(string.Format("exec gridEmpleado;"), conexionbd.ObtenerConexion());
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
        public static DataTable GetUsuarioGrid()
        {
            DataTable dtRegistros = new DataTable();//Tabla de datos
            try
            {//Llamada de Conexion y Query
                SqlCommand comando = new SqlCommand(string.Format("select u.usuario, r.rol, u.codusuario from USUARIO_1 U left join ROL R on r.idrol = u.idrol;"), conexionbd.ObtenerConexion());
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
        public static DataTable GetTipoGrid()
        {
            DataTable dtRegistros = new DataTable();//Tabla de datos
            try
            {//Llamada de Conexion y Query
                SqlCommand comando = new SqlCommand(string.Format("select idrol, rol from rol;"), conexionbd.ObtenerConexion());
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
        public static DataTable GetEmpleadoGridCandidato()
        {
            DataTable dtRegistros = new DataTable();//Tabla de datos
            try
            {//Llamada de Conexion y Query
                SqlCommand comando = new SqlCommand(string.Format("exec gridCandidato;"), conexionbd.ObtenerConexion());
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
                SqlCommand comando = new SqlCommand(string.Format("exec EmpleadoDatos '" + idemp+"';"), conexionbd.ObtenerConexion());
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
                SqlCommand comando = new SqlCommand(string.Format("select idrol, rol from ROL;"), conexionbd.ObtenerConexion());
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
                SqlCommand comando = new SqlCommand(string.Format("select cast(iddepartamentoempresa as int) as id,nombredeptoempresa from DEPARTAMENTOEMPRESA;;"), conexionbd.ObtenerConexion());
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
        public static DataTable obtieneEmpresa()
        {
            DataTable dtRegistros = new DataTable();//Tabla de datos
            try
            {//Llamada de Conexion y Query
                SqlCommand comando = new SqlCommand(string.Format("select idempresa, nombre_empresa from empresa"), conexionbd.ObtenerConexion());
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
                SqlCommand comando = new SqlCommand(string.Format("select idpuestodetrabajo, nombrepuesto from PUESTODETRABAJO where iddepartamentoempresa ='"+depto+"';"), conexionbd.ObtenerConexion());
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
            SqlCommand comando2 = new SqlCommand("Select usuario from USUARIO_1 WHERE usuario='" + sUser + "'And password ='" + ecrypt + "'", conexionbd.ObtenerConexion());
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
                SqlCommand comando = new SqlCommand(string.Format("exec TomaDatosLogin '" + sUser + "';"), conexionbd.ObtenerConexion());
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

        public static int InsertaEmpleado( int? experiencia, int? estudio,int Estado, int CodUsuario, int Empresa, int rol,string sueldo, string aumento, string puesto, string jornada, string feciniciolaboral, string nombre1, string nombre2, string apellido1, string apellido2, string apellido3, string nacionalidad, string sexo, string fechanacimiento, string direccion, int telefono, string identificacion, byte[] fotografia)
    {
        int retorno = 0;
        SqlCommand comando = new SqlCommand("exec InsertaEmpleado " + Estado+ ",'"+ CodUsuario+ "','"+ Empresa+ "','" +rol+ "','" +sueldo +"','"+aumento+"','"+puesto+"','"+jornada+"','"+feciniciolaboral+ "','" + experiencia + "','" + estudio + "','" + nombre1+"','"+nombre2+"','"+apellido1+"','"+apellido2+"','"+apellido3+"','"+nacionalidad+"','"+sexo+"','"+fechanacimiento+"','"+direccion+"',"+telefono+",'"+identificacion+"','"+ fotografia+"';", conexionbd.ObtenerConexion());
        retorno = comando.ExecuteNonQuery();
        return retorno;
    }
        public static int ActualizaEmpleado(int idempleado, int? experiencia, int? estudio, int Estado, int Empresa, int rol, string sueldo, string aumento, int puesto, int jornada, string feciniciolaboral, string nombre1, string nombre2, string apellido1, string apellido2, string apellido3, string nacionalidad, string sexo, string fechanacimiento, string direccion, int telefono, string identificacion, byte[] fotografia)
        {
            int retorno = 0;
            SqlCommand comando = new SqlCommand("exec ActualizaEmpleado "+ idempleado + "," + Estado + "," + Empresa + "," + rol + ",'" + sueldo + "','" + aumento + "','" + puesto + "','" + jornada + "','" + feciniciolaboral + "'," + experiencia + "," + estudio + ",'" + nombre1 + "','" + nombre2 + "','" + apellido1 + "','" + apellido2 + "','" + apellido3 + "','" + nacionalidad + "','" + sexo + "','" + fechanacimiento + "','" + direccion + "'," + telefono + "," + identificacion + ",'" + fotografia + "';", conexionbd.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static int ActualizaPass(int idempleado, string pass)
        {
            int retorno = 0;
            SqlCommand comando = new SqlCommand("update USUARIO_1 set password ='" + pass + "' where codusuario =" + idempleado +";", conexionbd.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
        public static int InsertaRol(string pass)
        {
            int retorno = 0;
            SqlCommand comando = new SqlCommand("insert into ROL(rol)values('" + pass + "');", conexionbd.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
        public static int decandidatoaempleado(string jornada, int rol, string sueldo, string aumento, int idempresa, int candidato)
        {
            int retorno = 0;
            SqlCommand comando = new SqlCommand("exec InsertaEmpleadoSolicitud " + jornada + "," + rol + "," + sueldo + "," + aumento + ",'" + idempresa + "','" + candidato + "';", conexionbd.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
        public static int vepassword(int id, string pass)
        {
            string ecrypt = classEncryptD.Encrypt(pass);
            int retorno = 0;
            SqlCommand comando = new SqlCommand("select password from USUARIO_1 where codusuario =" + id + " and password ='" + ecrypt + "';", conexionbd.ObtenerConexion());
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
    }
}
