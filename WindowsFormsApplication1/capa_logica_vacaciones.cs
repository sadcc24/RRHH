using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    class capa_logica_vacaciones
    {
        public static SqlConnection SQL_Conexion = new SqlConnection();

        public static int Agregar(capa_presentacion_vacaciones pMotivo)
            {

                int retorno = 0;
            
                SqlCommand comando = new SqlCommand(string.Format("Insert into motivo (motivo, descripcion) values ('{0}','{1}')",
                   pMotivo.motivo, pMotivo.descripcion), conexionbd.ObtenerConexion());
                retorno = comando.ExecuteNonQuery();
                return retorno;
            }


        public static List<capa_presentacion_vacaciones> Buscarmotivo(string pmotivo)
        {
            List<capa_presentacion_vacaciones> _lista = new List<capa_presentacion_vacaciones>();

            SqlCommand _comando = new SqlCommand(String.Format(
           "SELECT codmotivo, motivo, descripcion FROM motivo where motivo ='{0}'", pmotivo), conexionbd.ObtenerConexion());
            SqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                capa_presentacion_vacaciones pMotivoo = new capa_presentacion_vacaciones();
                pMotivoo.codmotivo = _reader.GetInt32(0);
                pMotivoo.motivo= _reader.GetString(1);
                pMotivoo.descripcion = _reader.GetString(2);
             


                _lista.Add(pMotivoo);
            }

            return _lista;
        }

        public static capa_presentacion_vacaciones Obtenermotivo(int pcod)
        {
            capa_presentacion_vacaciones pMotivo = new capa_presentacion_vacaciones();
            SqlConnection conexion = conexionbd.ObtenerConexion();

            SqlCommand _comando = new SqlCommand(String.Format("SELECT codmotivo, motivo, descripcion FROM motivo where codmotivo={0}", pcod), conexion);
            SqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                pMotivo.codmotivo = _reader.GetInt32(0);
                pMotivo.motivo = _reader.GetString(1);
                pMotivo.descripcion = _reader.GetString(2);
            }

            conexion.Close();
            return pMotivo;

        }

        public static int modificarmotivo(capa_presentacion_vacaciones pmotivo)
        {
            int retorno = 0;
            SqlConnection conexion = conexionbd.ObtenerConexion();

            SqlCommand comando = new SqlCommand(string.Format("Update motivo set motivo='{0}', descripcion='{1}' where codmotivo={2}",
                pmotivo.motivo, pmotivo.descripcion, pmotivo.codmotivo), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;


        }

        public static int Eliminarmotivo(int pcodmotivo)
        {
            int retorno = 0;
            SqlConnection conexion = conexionbd.ObtenerConexion();

            SqlCommand comando = new SqlCommand(string.Format("Delete From motivo where codmotivo={0}", pcodmotivo), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;

        }




        //_----------------------------------------------------------Solicitud--------------------------------------------------------
      

        public static List<capa_presentacion_vacaciones> Obtenermotivos()
        {
            List<capa_presentacion_vacaciones> _listamotivos = new List<capa_presentacion_vacaciones>();

            SqlConnection conexion = conexionbd.ObtenerConexion();

            SqlCommand _comando = new SqlCommand("select codmotivo , motivo from motivo", conexion);
            SqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                capa_presentacion_vacaciones pmotivos = new capa_presentacion_vacaciones();

                pmotivos.codmotivo = _reader.GetInt32(0);
                pmotivos.motivo = _reader.GetString(1);

                _listamotivos.Add(pmotivos);
            }

            return _listamotivos;
        }

        //--buscar solicitud
        public static List<capa_presentacion_solicitud> Buscarsolicitud(string psolicitud)
        {
            List<capa_presentacion_solicitud> _lista = new List<capa_presentacion_solicitud>();


            SqlCommand _comando = new SqlCommand(String.Format("  select sol.codsolicitud, sol.codmotivo, mot.motivo, sol.fecinicial, sol.fecfinal, sol.candias, sol.fecsolicitud, sol.fecdecision, sol.decision, sol.descomentario, sol.idempleado,per.nombre1, per.nombre2, per.apellido1, per.apellido2, sol.idempresa, emp.nombre_empresa " +
                    "from SOLICITUDVACACIONES sol " +
                    "join MOTIVO mot ON mot.codmotivo = sol.codmotivo " +
                     "join DETALLEPERSONAL per on per.idempleado = sol.idempleado " +
                     "join EMPRESA emp on emp.idempresa = per.idempresa where decision ='{0}'", psolicitud), conexionbd.ObtenerConexion());
            //SqlCommand _comando = new SqlCommand(String.Format(
            //"select codsolicitud, codmotivo, fecinicial, fecfinal, candias, fecsolicitud, fecdecision, decision, descomentario, idempleado, idempresa from solicitudvacaciones where decision ='{0}'", psolicitud), conexionbd.ObtenerConexion());
            SqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                capa_presentacion_solicitud psolicitudd = new capa_presentacion_solicitud();
                psolicitudd.codsolicitud = _reader.GetInt32(0);
                psolicitudd.codmotivo = _reader.GetInt32(1);
                psolicitudd.motivo = _reader.GetString(2);
                //psolicitudd.codvacaciones = _reader.GetInt32(2);
                psolicitudd.fecinicial = _reader["fecinicial"].ToString();
                psolicitudd.fecfinal = _reader["fecfinal"].ToString();
                psolicitudd.candias = _reader.GetString(5);
                psolicitudd.fecsolicitud = _reader["fecsolicitud"].ToString();
                psolicitudd.fecdecision = _reader.GetString(7);
                psolicitudd.decision = _reader.GetString(8);
                psolicitudd.descomentario = _reader.GetString(9);
                psolicitudd.idempleado = _reader.GetInt32(10);
                psolicitudd.nombre1 = _reader.GetString(11);
                psolicitudd.nombre2 = _reader.GetString(12);
                psolicitudd.apellido1 = _reader.GetString(13);
                psolicitudd.apellido2 = _reader.GetString(14);
                psolicitudd.idempresa = _reader.GetInt32(15);
                psolicitudd.nombre_empresa = _reader.GetString(16);

                _lista.Add(psolicitudd);
            }

            return _lista;
        }

        //----llenar grid
       public static List<capa_presentacion_solicitud> Obtenerdatossolicitud(string pdatoss)
        {
            List<capa_presentacion_solicitud> _listadatos = new List<capa_presentacion_solicitud>();


            SqlCommand _comando = new SqlCommand(String.Format("  select sol.codsolicitud, sol.codmotivo, mot.motivo, sol.fecinicial, sol.fecfinal, sol.candias, sol.fecsolicitud, sol.fecdecision, sol.decision, sol.descomentario, sol.idempleado,per.nombre1, per.nombre2, per.apellido1, per.apellido2, sol.idempresa, emp.nombre_empresa " +
                     "from SOLICITUDVACACIONES sol "+
                     "join MOTIVO mot ON mot.codmotivo = sol.codmotivo "+
                      "join DETALLEPERSONAL per on per.idempleado = sol.idempleado "+
                      "join EMPRESA emp on emp.idempresa = per.idempresa", pdatoss), conexionbd.ObtenerConexion());
            //SqlCommand _comando = new SqlCommand(String.Format("select codsolicitud, codmotivo, fecinicial, fecfinal, candias, fecsolicitud, fecdecision, decision, descomentario, idempleado, idempresa from solicitudvacaciones ", pdatoss), conexionbd.ObtenerConexion());
            SqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                capa_presentacion_solicitud pdatos = new capa_presentacion_solicitud();

                pdatos.codsolicitud = _reader.GetInt32(0);
                pdatos.codmotivo = _reader.GetInt32(1);
                pdatos.motivo = _reader.GetString(2);
                //psolicitudd.codvacaciones = _reader.GetInt32(2);
                pdatos.fecinicial = _reader["fecinicial"].ToString();
                pdatos.fecfinal = _reader["fecfinal"].ToString();
                pdatos.candias = _reader.GetString(5);
                pdatos.fecsolicitud = _reader["fecsolicitud"].ToString();
                pdatos.fecdecision = _reader.GetString(7);
                pdatos.decision = _reader.GetString(8);
                pdatos.descomentario = _reader.GetString(9);
                pdatos.idempleado = _reader.GetInt32(10);
                pdatos.nombre1 = _reader.GetString(11);
                pdatos.nombre2 = _reader.GetString(12);
                pdatos.apellido1 = _reader.GetString(13);
                pdatos.apellido2 = _reader.GetString(14);
                pdatos.idempresa = _reader.GetInt32(15);
                pdatos.nombre_empresa = _reader.GetString(16);

                _listadatos.Add(pdatos);
            }

            return _listadatos;
        }
       

        //---insertar solicitud
        public static int Agregarsolicitud(capa_presentacion_solicitud psolicitud)
        {
            int retorno;
            SqlConnection Conexion = conexionbd.ObtenerConexion();

            SqlCommand _comando = new SqlCommand(
                string.Format("INSERT INTO solicitudvacaciones(codmotivo, fecinicial, fecfinal, candias, fecsolicitud, fecdecision, decision, descomentario, idempleado, idempresa) VALUES({0}, '{1}','{2}','{3}','{4}','{5}','{6}', '{7}', '{8}','{9}')",
               psolicitud.codmotivo, psolicitud.fecinicial, psolicitud.fecfinal, psolicitud.candias, psolicitud.fecsolicitud, psolicitud.fecdecision, psolicitud.decision, psolicitud.descomentario, psolicitud.idempleado, psolicitud.idempresa), Conexion);
            retorno = _comando.ExecuteNonQuery();
            Conexion.Close();

            return retorno;
        }



        //-----------------------------------------------------aprobacion de solicitud---------------------------------------
       public static capa_presentacion_solicitud Obtenersolicitud(int pcod)
        {
            capa_presentacion_solicitud psolicitud = new capa_presentacion_solicitud();
            SqlConnection conexion = conexionbd.ObtenerConexion();
            string sqlQuery = "  select sol.codsolicitud, sol.codmotivo, mot.motivo, sol.fecinicial, sol.fecfinal, sol.candias, sol.fecsolicitud, sol.fecdecision, sol.decision, sol.descomentario, sol.idempleado, per.nombre1, per.nombre2, per.apellido1, per.apellido2, sol.idempresa, emp.nombre_empresa " +
                     "from SOLICITUDVACACIONES sol " +
                     "join MOTIVO mot ON mot.codmotivo = sol.codmotivo " +
                      "join DETALLEPERSONAL per on per.idempleado = sol.idempleado " +
                      "join EMPRESA emp on emp.idempresa = per.idempresa " +
                      "where sol.codsolicitud = " + pcod;

            SqlCommand _comando = new SqlCommand(sqlQuery, conexionbd.ObtenerConexion());
            SqlDataReader _reader = _comando.ExecuteReader();
            capa_presentacion_solicitud pdatos = new capa_presentacion_solicitud();

            while (_reader.Read())
            {
                pdatos.codsolicitud = _reader.GetInt32(0);
                pdatos.codmotivo = _reader.GetInt32(1);
                pdatos.motivo = _reader.GetString(2);
                //psolicitudd.codvacaciones = _reader.GetInt32(2);
                pdatos.fecinicial = _reader["fecinicial"].ToString();
                pdatos.fecfinal = _reader["fecfinal"].ToString();
                pdatos.candias = _reader.GetString(5);
                pdatos.fecsolicitud = _reader["fecsolicitud"].ToString();
                pdatos.fecdecision = _reader.GetString(7);
                pdatos.decision = _reader.GetString(8);
                pdatos.descomentario = _reader.GetString(9);
                pdatos.idempleado = _reader.GetInt32(10);
                pdatos.nombre1 = _reader.GetString(11);
                pdatos.nombre2 = _reader.GetString(12);
                pdatos.apellido1 = _reader.GetString(13);
                pdatos.apellido2 = _reader.GetString(14);
                pdatos.idempresa = _reader.GetInt32(15);
                pdatos.nombre_empresa = _reader.GetString(16);

            }

            conexion.Close();
            return pdatos;

        }



        public static capa_presentacion_fecinilaboral fechainiciolaboral(int idempleado)
        {
            capa_presentacion_fecinilaboral fecinilab = new capa_presentacion_fecinilaboral();

            SqlConnection conexion = conexionbd.ObtenerConexion();

            SqlCommand _comando = new SqlCommand(String .Format("select feciniciolaboral from detallelaboral where idempleado= {0}" , idempleado), conexion);
            SqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                fecinilab.feciniciolaboral= _reader.GetString(0);
            }
            conexion.Close();
            return fecinilab;
        }

        
        //----update aceptado
        public static int modificaraceptado(int codsolicitud)
        {
            int retorno = 0;
            SqlConnection conexion = conexionbd.ObtenerConexion();
            string sqlQuery = "Update solicitudvacaciones set decision='Aprobado' where codsolicitud = " + codsolicitud;

            SqlCommand comando = new SqlCommand(sqlQuery, conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;
        }
        //----update rechazado

        public static int modificarrechazado(int codsolicitud)
        {
            int retorno = 0;
            SqlConnection conexion = conexionbd.ObtenerConexion();
            string sqlQuery = "Update solicitudvacaciones set decision='Rechazado' where codsolicitud = " + codsolicitud;

            SqlCommand comando = new SqlCommand(sqlQuery, conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;
        }


        //-----------dias tomados - dias disponibles
        public static capa_presentacion_solicitud diastomados(int idempleado)
        {
            capa_presentacion_solicitud tomados = new capa_presentacion_solicitud();

            SqlConnection conexion = conexionbd.ObtenerConexion();

            string sqlQuery = "select sum(cast(candias as int)) as dias from solicitudvacaciones where decision ='Aprobado' and idempleado = " + idempleado;

            SqlCommand _comando = new SqlCommand(sqlQuery, conexion);
            SqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                tomados.candias = _reader["dias"].ToString();
            }
            conexion.Close();
            return tomados;
        }


        //-----------insertar dias
        public static int Agregardias(capa_presentacion_diasvac pdias)
        {

            int retorno = 0;

            SqlCommand comando = new SqlCommand(string.Format("Insert into vacaciones (diarestantes, diasacumulados, idempleado, idempresa, codsolicitud) values ('{0}','{1}','{2}','{3}','{4}')",
               pdias.diarestantes, pdias.diasacumulados, pdias.idempleado, pdias.idempresa, pdias.codsolicitud), conexionbd.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }


        //---------------------------------------------Dias Festivos---------------------------------------------------------------------

        //-----------------insert festivos


        public static int Agregarfestivos(capa_presentacion_festivos pfestivo)
        {

            int retorno = 0;

            SqlCommand comando = new SqlCommand(string.Format("Insert into diasfestivos (idempleado, idempresa, fecha, descripcion, codperiodo) values ({0},'{1}','{2}','{3}',{4})",
               pfestivo.idempleado, pfestivo.idempresa, pfestivo.fecha, pfestivo.descripcion, pfestivo.codperiodo), conexionbd.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        //----------------------------------personas con solicitud aceptada
        public static List<capa_presentacion_solicitud> Buscarpersonas(string psolicitud, string psolicitud2)
        {
            List<capa_presentacion_solicitud> _lista = new List<capa_presentacion_solicitud>();


            SqlCommand _comando = new SqlCommand(String.Format("  select sol.codsolicitud, sol.codmotivo, mot.motivo, sol.fecinicial, sol.fecfinal, sol.candias, sol.fecsolicitud, sol.fecdecision, sol.decision, sol.descomentario, sol.idempleado,per.nombre1, per.nombre2, per.apellido1, per.apellido2, sol.idempresa, emp.nombre_empresa " +
                    "from SOLICITUDVACACIONES sol " +
                    "join MOTIVO mot ON mot.codmotivo = sol.codmotivo " +
                     "join DETALLEPERSONAL per on per.idempleado = sol.idempleado " +
                     "join EMPRESA emp on emp.idempresa = per.idempresa where decision='Aprobado' and fecinicial BETWEEN'" + psolicitud + "' and '" + psolicitud2 + "' "), conexionbd.ObtenerConexion());
            //SqlCommand _comando = new SqlCommand(String.Format(
            //"select codsolicitud, codmotivo, fecinicial, fecfinal, candias, fecsolicitud, fecdecision, decision, descomentario, idempleado, idempresa from solicitudvacaciones where decision ='{0}'", psolicitud), conexionbd.ObtenerConexion());
            SqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                capa_presentacion_solicitud psolicitudd = new capa_presentacion_solicitud();
                psolicitudd.codsolicitud = _reader.GetInt32(0);
                psolicitudd.codmotivo = _reader.GetInt32(1);
                psolicitudd.motivo = _reader.GetString(2);
                //psolicitudd.codvacaciones = _reader.GetInt32(2);
                psolicitudd.fecinicial = _reader["fecinicial"].ToString();
                psolicitudd.fecfinal = _reader["fecfinal"].ToString();
                psolicitudd.candias = _reader.GetString(5);
                psolicitudd.fecsolicitud = _reader["fecsolicitud"].ToString();
                psolicitudd.fecdecision = _reader.GetString(7);
                psolicitudd.decision = _reader.GetString(8);
                psolicitudd.descomentario = _reader.GetString(9);
                psolicitudd.idempleado = _reader.GetInt32(10);
                psolicitudd.nombre1 = _reader.GetString(11);
                psolicitudd.nombre2 = _reader.GetString(12);
                psolicitudd.apellido1 = _reader.GetString(13);
                psolicitudd.apellido2 = _reader.GetString(14);
                psolicitudd.idempresa = _reader.GetInt32(15);
                psolicitudd.nombre_empresa = _reader.GetString(16);

                _lista.Add(psolicitudd);
            }

            return _lista;
        }


        //-----llenar combobox periodo
        public static List<capa_presentacion_periodo> Obtenerperiodos()
        {
            List<capa_presentacion_periodo> _listaperiodos = new List<capa_presentacion_periodo>();

            SqlConnection conexion = conexionbd.ObtenerConexion();

            SqlCommand _comando = new SqlCommand("select codperiodo , perdescripcion from periodov where perestatus = 'Activado'", conexion);
            SqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                capa_presentacion_periodo pfestivos = new capa_presentacion_periodo();

                pfestivos.codperiodo = _reader.GetInt32(0);
                pfestivos.perdescripcion = _reader.GetString(1);

                _listaperiodos.Add(pfestivos);
            }

            return _listaperiodos;
        }
        //-----llenar combobox empleado

             public static List<capa_presentacion_extra> Obtenerempleado()
        {
            List<capa_presentacion_extra> _listaperiodos = new List<capa_presentacion_extra>();

            SqlConnection conexion = conexionbd.ObtenerConexion();

            SqlCommand _comando = new SqlCommand("select idempleado , nombre1, nombre2, apellido1, apellido2 from detallepersonal", conexion);
            SqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                capa_presentacion_extra pfestivos = new capa_presentacion_extra();

                pfestivos.idempleado = _reader.GetInt32(0);
                pfestivos.nombre1 = _reader.GetString(1);

                _listaperiodos.Add(pfestivos);
            }

            return _listaperiodos;
        }
        //------llenar combobox empresa

       public static List<capa_presentacion_extra> buscarempresa(string empleado)
        {
            List<capa_presentacion_extra> empresas = new List<capa_presentacion_extra>();

            SqlConnection conexion = conexionbd.ObtenerConexion();
            string queryString = "select e.idempleado, e.nombre1, emp.idempresa, emp.nombre_empresa " + 
                                 "from detallepersonal e " +
                                 "join EMPRESA emp on emp.idempresa = e.idempresa " +
                                 "where idempleado = 2";

            SqlCommand _comando = new SqlCommand(queryString, conexion);
            SqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                capa_presentacion_extra empresaslist = new capa_presentacion_extra();

                empresaslist.idempleado = _reader.GetInt32(0);
                empresaslist.nombre1 = _reader.GetString(1);
                empresaslist.idempresa = _reader.GetInt32(2);
                empresaslist.nombre_empresa = _reader.GetString(3);

                empresas.Add(empresaslist);
            }

            return empresas;
        }
        //-------------------------------------buscar festivos
        public static List<capa_presentacion_festivos> Buscarferiados(string pfestivos)
        {
            List<capa_presentacion_festivos> _lista = new List<capa_presentacion_festivos>();

            SqlCommand _comando = new SqlCommand(String.Format(
           "SELECT idempleado, idempresa, codperiodo, fecha, descripcion FROM diasfestivos  where fecha ='{0}' ", pfestivos), conexionbd.ObtenerConexion());
            SqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                capa_presentacion_festivos pfes = new capa_presentacion_festivos();
                pfes.idempleado = _reader.GetInt32(0);
                pfes.idempresa = _reader.GetInt32(1);
                pfes.codperiodo = _reader.GetInt32(2);
                pfes.fecha = _reader["fecha"].ToString(); 
                pfes.descripcion = _reader.GetString(4);


                _lista.Add(pfes);
            }

            return _lista;
        }

        public static capa_presentacion_festivos Obtenerfiestas(int pId)
        {
            capa_presentacion_festivos pfes = new capa_presentacion_festivos();
            SqlConnection conexion = conexionbd.ObtenerConexion();

            SqlCommand _comando = new SqlCommand(String.Format("SELECT idempleado, idempresa, codperiodo, fecha, descripcion FROM diasfestivos  where idempleado ='{0}'", pId), conexion);
            SqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                pfes.idempleado = _reader.GetInt32(0);
                pfes.idempresa = _reader.GetInt32(1);
                pfes.codperiodo = _reader.GetInt32(2);
                pfes.fecha = _reader["fecha"].ToString();
                pfes.descripcion = _reader.GetString(4);

            }

            conexion.Close();
            return pfes;

        }
        //------------modificar
        public static int modificarfestivo(capa_presentacion_festivos pfes)
        {
            int retorno = 0;
            SqlConnection conexion = conexionbd.ObtenerConexion();

            SqlCommand comando = new SqlCommand(string.Format("Update diasfestivos set idempleado='{0}', idempresa='{1}', codperiodo = '{2}', fecha = '{3}', descripcion = '{4}' where idempleado='{5}'",
                pfes.idempleado, pfes.idempresa, pfes.codperiodo, pfes.fecha, pfes.descripcion, pfes.idempleado), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;


        }
        //--------------------eliminar festivo


        public static int Eliminarfestivo(string pfes)
        {
            int retorno = 0;
            SqlConnection conexion = conexionbd.ObtenerConexion();

            SqlCommand comando = new SqlCommand(string.Format("Delete From  diasfestivos where descripcion like '%{0}%' ", pfes), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;

        }
        //-------------------------------------------------------mantenimiento de periodos---------------------------------------------

        public static int Agregarperiodoo(capa_presentacion_periodo pfes)
        {

            int retorno = 0;

            SqlCommand comando = new SqlCommand(string.Format("Insert into periodov (perdescripcion, perestatus) values ('{0}','{1}')",
               pfes.perdescripcion, pfes.perestatus), conexionbd.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }


        public static List<capa_presentacion_periodo> Buscarperiodoo(string pfes)
        {
            List<capa_presentacion_periodo> _lista = new List<capa_presentacion_periodo>();

            SqlCommand _comando = new SqlCommand(String.Format(
           "SELECT codperiodo, perdescripcion, perestatus FROM periodov where perestatus ='{0}'", pfes), conexionbd.ObtenerConexion());
            SqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                capa_presentacion_periodo pfestivoss = new capa_presentacion_periodo();
                pfestivoss.codperiodo = _reader.GetInt32(0);
                pfestivoss.perdescripcion = _reader.GetString(1);
                pfestivoss.perestatus = _reader.GetString(2);



                _lista.Add(pfestivoss);
            }

            return _lista;
        }

        public static capa_presentacion_periodo Obtenerperiodoo(int pcod)
        {
            capa_presentacion_periodo pMotivo = new capa_presentacion_periodo();
            SqlConnection conexion = conexionbd.ObtenerConexion();

            SqlCommand _comando = new SqlCommand(String.Format("SELECT codperiodo, perdescripcion, perestatus FROM periodov where codperiodo={0}", pcod), conexion);
            SqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                pMotivo.codperiodo = _reader.GetInt32(0);
                pMotivo.perdescripcion = _reader.GetString(1);
                pMotivo.perestatus = _reader.GetString(2);
            }

            conexion.Close();
            return pMotivo;

        }

        public static int modificarperiodoo(capa_presentacion_periodo pfes)
        {
            int retorno = 0;
            SqlConnection conexion = conexionbd.ObtenerConexion();

            SqlCommand comando = new SqlCommand(string.Format("Update periodov set perdescripcion='{0}', perestatus='{1}' where codperiodo={2}",
                pfes.perdescripcion, pfes.perestatus, pfes.codperiodo), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;


        }

        public static int Eliminarperiodoo(int pcodfes)
        {
            int retorno = 0;
            SqlConnection conexion = conexionbd.ObtenerConexion();

            SqlCommand comando = new SqlCommand(string.Format("Delete From periodov where codperiodo={0}", pcodfes), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;

        }



        //----------------------------------------planilla vacaciones

            //data grid uno
        public static List<capa_presentacion_solicitud> Buscarsolipla(string psolicitud)
        {
            List<capa_presentacion_solicitud> _lista = new List<capa_presentacion_solicitud>();


            SqlCommand _comando = new SqlCommand(String.Format("  select sol.codsolicitud, sol.codmotivo, mot.motivo, sol.fecinicial, sol.fecfinal, sol.candias, sol.fecsolicitud, sol.fecdecision, sol.decision, sol.descomentario, sol.idempleado,per.nombre1, per.nombre2, per.apellido1, per.apellido2, sol.idempresa, emp.nombre_empresa " +
                    "from SOLICITUDVACACIONES sol " +
                    "join MOTIVO mot ON mot.codmotivo = sol.codmotivo " +
                     "join DETALLEPERSONAL per on per.idempleado = sol.idempleado " +
                     "join EMPRESA emp on emp.idempresa = per.idempresa where decision ='Aprobado'", psolicitud), conexionbd.ObtenerConexion());
            //SqlCommand _comando = new SqlCommand(String.Format(
            //"select codsolicitud, codmotivo, fecinicial, fecfinal, candias, fecsolicitud, fecdecision, decision, descomentario, idempleado, idempresa from solicitudvacaciones where decision ='{0}'", psolicitud), conexionbd.ObtenerConexion());
            SqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                capa_presentacion_solicitud psolicitudd = new capa_presentacion_solicitud();
                psolicitudd.codsolicitud = _reader.GetInt32(0);
                psolicitudd.codmotivo = _reader.GetInt32(1);
                psolicitudd.motivo = _reader.GetString(2);
                //psolicitudd.codvacaciones = _reader.GetInt32(2);
                psolicitudd.fecinicial = _reader["fecinicial"].ToString();
                psolicitudd.fecfinal = _reader["fecfinal"].ToString();
                psolicitudd.candias = _reader.GetString(5);
                psolicitudd.fecsolicitud = _reader["fecsolicitud"].ToString();
                psolicitudd.fecdecision = _reader.GetString(7);
                psolicitudd.decision = _reader.GetString(8);
                psolicitudd.descomentario = _reader.GetString(9);
                psolicitudd.idempleado = _reader.GetInt32(10);
                psolicitudd.nombre1 = _reader.GetString(11);
                psolicitudd.nombre2 = _reader.GetString(12);
                psolicitudd.apellido1 = _reader.GetString(13);
                psolicitudd.apellido2 = _reader.GetString(14);
                psolicitudd.idempresa = _reader.GetInt32(15);
                psolicitudd.nombre_empresa = _reader.GetString(16);

                _lista.Add(psolicitudd);
            }

            return _lista;
        }

        //-----------------------------mostrar grid vista
        public static List<capa_presentacion_solicitud> Buscarvista(string psolicitud, string psolicitud2)
        {
            List<capa_presentacion_solicitud> _lista = new List<capa_presentacion_solicitud>();


            SqlCommand _comando = new SqlCommand(String.Format("  select sol.codsolicitud, sol.codmotivo, mot.motivo, sol.fecinicial, sol.fecfinal, sol.candias, sol.fecsolicitud, sol.fecdecision, sol.decision, sol.descomentario, sol.idempleado,per.nombre1, per.nombre2, per.apellido1, per.apellido2, sol.idempresa, emp.nombre_empresa " +
                    "from SOLICITUDVACACIONES sol " +
                    " join MOTIVO mot ON mot.codmotivo = sol.codmotivo " +
                     " join DETALLEPERSONAL per on per.idempleado = sol.idempleado " +
                     " join EMPRESA emp on emp.idempresa = per.idempresa where decision='Aprobado' and fecinicial BETWEEN'"+psolicitud+"' and '"+psolicitud2+"' "), conexionbd.ObtenerConexion());
            //SqlCommand _comando = new SqlCommand(String.Format(
            //"select codsolicitud, codmotivo, fecinicial, fecfinal, candias, fecsolicitud, fecdecision, decision, descomentario, idempleado, idempresa from solicitudvacaciones where decision ='{0}'", psolicitud), conexionbd.ObtenerConexion());
            SqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                capa_presentacion_solicitud psolicitudd = new capa_presentacion_solicitud();
                psolicitudd.codsolicitud = _reader.GetInt32(0);
                psolicitudd.codmotivo = _reader.GetInt32(1);
                psolicitudd.motivo = _reader.GetString(2);
                //psolicitudd.codvacaciones = _reader.GetInt32(2);
                psolicitudd.fecinicial = _reader["fecinicial"].ToString();
                psolicitudd.fecfinal = _reader["fecfinal"].ToString();
                psolicitudd.candias = _reader.GetString(5);
                psolicitudd.fecsolicitud = _reader["fecsolicitud"].ToString();
                psolicitudd.fecdecision = _reader.GetString(7);
                psolicitudd.decision = _reader.GetString(8);
                psolicitudd.descomentario = _reader.GetString(9);
                psolicitudd.idempleado = _reader.GetInt32(10);
                psolicitudd.nombre1 = _reader.GetString(11);
                psolicitudd.nombre2 = _reader.GetString(12);
                psolicitudd.apellido1 = _reader.GetString(13);
                psolicitudd.apellido2 = _reader.GetString(14);
                psolicitudd.idempresa = _reader.GetInt32(15);
                psolicitudd.nombre_empresa = _reader.GetString(16);

                _lista.Add(psolicitudd);
            }

            return _lista;
        }

        //.--------dias

        public static List<capa_presentacion_diasextra> Buscarvistadia(string pcods)
        {
            List<capa_presentacion_diasextra> _lista = new List<capa_presentacion_diasextra>();


            SqlCommand _comando = new SqlCommand(String.Format(" select vac.codvacaciones, vac.diarestantes, vac.diasacumulados, vac.idempleado,det.nombre1, det.apellido1, "+
                         " vac.idempresa, emp.nombre_empresa, vac.codsolicitud "+
                        " from Vacaciones vac join DETALLEPERSONAL det on det.idempleado = vac.idempleado "+
                        " join EMPRESA emp on emp.idempresa = det.idempresa where vac.codsolicitud ='"+pcods+"' "), conexionbd.ObtenerConexion());
            //SqlCommand _comando = new SqlCommand(String.Format(
            //"select codsolicitud, codmotivo, fecinicial, fecfinal, candias, fecsolicitud, fecdecision, decision, descomentario, idempleado, idempresa from solicitudvacaciones where decision ='{0}'", psolicitud), conexionbd.ObtenerConexion());
            SqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                capa_presentacion_diasextra pdiaa = new capa_presentacion_diasextra();
                pdiaa.codvacaciones = _reader.GetInt32(0);
                pdiaa.diarestantes = _reader.GetString(1);
                pdiaa.diasacumulados = _reader.GetString(2);
                pdiaa.idempleado = _reader.GetInt32(3);
                pdiaa.nombre1 = _reader.GetString(4);
                pdiaa.apellido1 = _reader.GetString(5);
                pdiaa.idempresa= _reader.GetInt32(6);
                pdiaa.nombre_empresa = _reader.GetString(7);
                pdiaa.codsolicitud = _reader.GetInt32(8);


                _lista.Add(pdiaa);
            }

            return _lista;
        }



        //----------------------------login

        public static int LoginD(string sUser, string sContra)
        {
            int retorno = 0;
            SqlCommand comando = new SqlCommand("Select usuario from USUARIO_1 WHERE usuario='" + sUser + "'And password ='" + sContra + "'", conexionbd.ObtenerConexion());
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
    }
}
