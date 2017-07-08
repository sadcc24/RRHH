using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApplication1
{
    class capa_logica_formaciones
    {
        public static SqlConnection SQL_Conexion = new SqlConnection();

        public static int Agregar(capa_presentacion_formaciones pMotivo)
        {

            int retorno = 0;

            SqlCommand comando = new SqlCommand(string.Format("Insert into motivouno (motivo, descripcion) values ('{0}','{1}')",
               pMotivo.motivo, pMotivo.descripcion), conexionbd.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }


        public static List<capa_presentacion_formaciones.departamento> departamentos(string usuario) {
            List<capa_presentacion_formaciones.departamento> dep = new List<capa_presentacion_formaciones.departamento>();

            SqlCommand comando = new SqlCommand("select * from DEPARTAMENTOEMPRESA ", conexionbd.ObtenerConexion());
            SqlDataReader dr = comando.ExecuteReader();

            while (dr.Read())
            {

                dep.Add(new capa_presentacion_formaciones.departamento() {iddepartamento= dr["iddepartamentoempresa"].ToString(), nombredepartamento=dr["nombredeptoempresa"].ToString() });

            }
            return dep;
        }

        public static List<capa_presentacion_formaciones.empleados> empleados(string usuario)
        {
            List<capa_presentacion_formaciones.empleados> emp = new List<capa_presentacion_formaciones.empleados>();

            SqlCommand comando = new SqlCommand("select e.idempleado,e.idempresa,CONCAT(dp.nombre1,' ',dp.nombre2,' ',dp.apellido1,' ', dp.apellido2) as nombre from EMPLEADO e left join DetallePersonal dp on e.idempleado = dp.idempleado ", conexionbd.ObtenerConexion());
            SqlDataReader dr = comando.ExecuteReader();

            while (dr.Read())
            {

                emp.Add(new capa_presentacion_formaciones.empleados() { idempleado = dr["idempleado"].ToString(), empleado = dr["nombre"].ToString() });

            }
            return emp;
        }





        public static string id_asignacion2()
        {
            string id = "";

            SqlCommand comando = new SqlCommand("SELECT MAX(idasignacion)as id FROM ASIGNACION ", conexionbd.ObtenerConexion());
            SqlDataReader dr = comando.ExecuteReader();

            while (dr.Read())
            {
                id = dr["id"].ToString();

            }
            SQL_Conexion.Close();


            return id;
        }

        public static string empresa_empleado(string empleado) {
            string idempresa = "";

            SqlCommand comando = new SqlCommand("SELECT idempresa from EMPLEADO where idempleado="+empleado, conexionbd.ObtenerConexion());
            SqlDataReader dr = comando.ExecuteReader();

            while (dr.Read())
            {
                idempresa = dr["idempresa"].ToString();

            }
            SQL_Conexion.Close();

            return idempresa;
        }

        public static int asignacion(string idcapacitacion, string metodoasignacion, string empleado, string departamento, string fechainicio, string fechafin, string horario,string metodo,string usuario) {
            int rasignacion=0;

            if (metodo == "1")
            {
                SqlCommand comando2 = new SqlCommand(" insert into ASIGNACION (asigfecha,idcapacitacion) values(GETDATE()," + idcapacitacion + ")", conexionbd.ObtenerConexion());
                rasignacion = comando2.ExecuteNonQuery();
                SQL_Conexion.Close();

                string asignacionid = id_asignacion2();
                string empresa = empresa_empleado(empleado);

                comando2 = new SqlCommand("insert into DETALLEASIGNACION (horario,idasignacion,idempleado,idempresa,fecha_inicio,fecha_fin) values ('" + horario + "'," + asignacionid + "," + empleado + "," + empresa + ",'" + fechainicio + "','" + fechafin + "')", conexionbd.ObtenerConexion());
                rasignacion = comando2.ExecuteNonQuery();
                SQL_Conexion.Close();

            }
            else if (metodo == "2") {

                string empresa_asig = consulta_empresa(usuario);


                SqlCommand comando = new SqlCommand("select e.idempleado,e.idempresa,dl.departamento from empleado e left join DetalleLaboral dl on e.idempleado = dl.idempleado where dl.departamento = "+departamento+" and e.estado = 1 and e.idempresa = "+empresa_asig, conexionbd.ObtenerConexion());
                SqlDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    SqlCommand comando2 = new SqlCommand(" insert into ASIGNACION (asigfecha,idcapacitacion) values(GETDATE()," + idcapacitacion + ")", conexionbd.ObtenerConexion());
                    rasignacion = comando2.ExecuteNonQuery();
                    

                    string asignacionid = id_asignacion2();
                    string empresa = empresa_empleado(empleado);

                    comando2 = new SqlCommand("insert into DETALLEASIGNACION (horario,idasignacion,idempleado,idempresa,fecha_inicio,fecha_fin) values ('" + horario + "'," + asignacionid + "," + dr["idempleado"].ToString() + "," + empresa + ",'" + fechainicio + "','" + fechafin + "')", conexionbd.ObtenerConexion());
                    rasignacion = comando2.ExecuteNonQuery();
                  

                }
                SQL_Conexion.Close();


               
            }

            

          


            return rasignacion;
        }

        public static List<capa_presentacion_formaciones.info_capa> info_capacitaciones(string usuario) {


            string empresa=consulta_empresa(usuario);

            List<capa_presentacion_formaciones.info_capa> info_cap = new List<capa_presentacion_formaciones.info_capa>();
            SqlCommand comando = new SqlCommand("select c.idcapacitacion,c.costo,c.nombre,c.descripcion,dc.expositor,t.tipo from CAPACITACION c left join  DETALLECAPACITACION dc on dc.idcapacitacion = c.idcapacitacion left join TIPO t on t.idtipo = dc.idtipo where c.status = 1 and c.idempresa="+empresa+" order by C.idcapacitacion ASC ", conexionbd_Empleado.ObtenerConexion());
            SqlDataReader dr = comando.ExecuteReader();

            while (dr.Read()) {

                info_cap.Add(new capa_presentacion_formaciones.info_capa() { idcapacitacion = dr["idcapacitacion"].ToString(), nombre_capa = dr["nombre"].ToString(), descripcion_capa = dr["descripcion"].ToString(), area = dr["tipo"].ToString(), expositor = dr["expositor"].ToString(), costo = dr["costo"].ToString() });

            }

            return info_cap;
        }

        public static List<capa_presentacion_formaciones.infotipocapacitacion> info_tipocapacitaciones() {
            List<capa_presentacion_formaciones.infotipocapacitacion> infotipo_cap = new List<capa_presentacion_formaciones.infotipocapacitacion>();
            SqlCommand comando = new SqlCommand("select * from TIPO where status=1", conexionbd.ObtenerConexion());
            SqlDataReader dr = comando.ExecuteReader();

            while (dr.Read())
            {

                infotipo_cap.Add(new capa_presentacion_formaciones.infotipocapacitacion() { idtipo = dr["idtipo"].ToString(), tipo = dr["tipo"].ToString() });

            }
            SQL_Conexion.Close();
            return infotipo_cap;
        }


        public static int modificar_capacitacion(string id_capacitacion, string nombre, string descripcion, string expositor, string costo, string area) {

            int modificacion = 0;
            SqlCommand comando = new SqlCommand("  update CAPACITACION set nombre='" + nombre + "' , descripcion='" + descripcion + "' where idcapacitacion=" + id_capacitacion, conexionbd.ObtenerConexion());
            modificacion = comando.ExecuteNonQuery();
            SQL_Conexion.Close();


            SqlCommand comando2 = new SqlCommand("  update DETALLECAPACITACION set expositor='" + expositor + "', idtipo=" + area + " where idcapacitacion=" + id_capacitacion, conexionbd.ObtenerConexion());
            modificacion = comando2.ExecuteNonQuery();
            SQL_Conexion.Close();

            return modificacion;
        }

        public static int eliminar_capacitacion(string id_capacitacion) {
            int eliminar = 0;

            SqlCommand comando2 = new SqlCommand(" update CAPACITACION set status=0 where idcapacitacion=" + id_capacitacion, conexionbd.ObtenerConexion());
            eliminar = comando2.ExecuteNonQuery();
            SQL_Conexion.Close();


            return eliminar;
            ;
        }


        public static string consulta_empresa(string usuario) {
            string empresa="";

            SqlCommand comando = new SqlCommand("select e.idempresa from USUARIO_1 u left join EMPLEADO e on u.codusuario = e.codusuario where u.usuario = '"+usuario+"'", conexionbd.ObtenerConexion());
            SqlDataReader dr = comando.ExecuteReader();

            while (dr.Read())
            {
                empresa = dr["idempresa"].ToString();

            }
            SQL_Conexion.Close();


            return empresa;
        }



        public static string cod_capacitacion(string nombre, string empresa, string descripcion) {
            string codigo="";

            SqlCommand comando = new SqlCommand("select idcapacitacion from CAPACITACION where status=1 and nombre='"+nombre+"' and descripcion='"+descripcion+"' and idempresa="+empresa, conexionbd.ObtenerConexion());
            SqlDataReader dr = comando.ExecuteReader();

            while (dr.Read())
            {
                codigo = dr["idcapacitacion"].ToString();

            }
            SQL_Conexion.Close();
            return codigo;
        }

        public static int nueva_capacitacion(string nombre, string descripcion, string expositor, string costo, string area, string usuario) {
            int nuevo = 0;

            string empresa = consulta_empresa(usuario);
           
            

            SqlCommand comando2 = new SqlCommand("insert into CAPACITACION (fechapago,costo,nombre,descripcion,status,idempresa) values(GETDATE(),"+costo+",'"+nombre+"','"+descripcion+"',1,"+empresa+")", conexionbd.ObtenerConexion());
            nuevo = comando2.ExecuteNonQuery();
            SQL_Conexion.Close();

            string idcapacitacion = cod_capacitacion(nombre, empresa, descripcion);

            comando2 = new SqlCommand("insert into DETALLECAPACITACION(expositor, idtipo, idcapacitacion) values('"+expositor+"',"+area+","+idcapacitacion+")", conexionbd.ObtenerConexion());
            nuevo = comando2.ExecuteNonQuery();
            SQL_Conexion.Close();

            return nuevo;
        } 

        public static int LoginD(string sUser, string sContra)
        {
            string ecrypt = classEncryptD.Encrypt(sContra);

            int retorno = 0;
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
    }
}
